Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports DotNetEnv
Imports MySql.Data.MySqlClient

Public Class frmAI
    Private ReadOnly httpClient As HttpClient
    Private Const DEEPSEEK_API_URL As String = "https://api.deepseek.com/v1/chat/completions"
    Private dbConnection As MySqlConnection ' Add this field

    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
        httpClient = New HttpClient()
        Dim apiKey As String = GetApiKey()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
        ' Initialize database connection
        dbConnection = createDBConnection()
    End Sub

    Private Function GetUserFinancialData() As String
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Throw New Exception("User is not logged in")
        End If

        Dim financialData As New StringBuilder()
        Try
            dbConnection.Open()

            ' Get expenses (updated to match user_expenses table)
            Using cmdExpenses As New MySqlCommand(
            "SELECT Item, Cost, Category, Description, date FROM user_expenses " &
            "WHERE UserID = @userId ORDER BY date DESC LIMIT 10",
            dbConnection)
                cmdExpenses.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmdExpenses.ExecuteReader()
                    financialData.AppendLine("Recent Expenses:")
                    While reader.Read()
                        financialData.AppendLine($"- ${reader("Cost")} for {reader("Item")} ({reader("Category")}) on {CDate(reader("date")).ToString("MM/dd/yyyy")}")
                    End While
                End Using
            End Using

            ' Get budget information (using categories and transactions tables)
            Using cmdBudget As New MySqlCommand(
            "SELECT c.CategoryName, SUM(t.Amount) as TotalAmount " &
            "FROM categories c " &
            "INNER JOIN transactions t ON c.CategoryID = t.CategoryID " &
            "WHERE t.UserID = @userId AND t.Type = 'Expense' " &
            "GROUP BY c.CategoryID, c.CategoryName",
            dbConnection)
                cmdBudget.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmdBudget.ExecuteReader()
                    financialData.AppendLine(vbNewLine & "Budget Information:")
                    While reader.Read()
                        financialData.AppendLine($"- {reader("CategoryName")}: ${reader("TotalAmount")}")
                    End While
                End Using
            End Using

            ' Get savings information (updated to match savings_goals table)
            Using cmdSavings As New MySqlCommand(
            "SELECT GoalName, TargetAmount, CurrentAmount, TargetDate " &
            "FROM savings_goals WHERE UserID = @userId",
            dbConnection)
                cmdSavings.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmdSavings.ExecuteReader()
                    financialData.AppendLine(vbNewLine & "Savings Goals:")
                    While reader.Read()
                        financialData.AppendLine($"- {reader("GoalName")}: ${reader("CurrentAmount")}/${reader("TargetAmount")} " &
                                           $"(Target: {CDate(reader("TargetDate")).ToString("MM/dd/yyyy")})")
                    End While
                End Using
            End Using

            Return financialData.ToString()

        Finally
            dbConnection.Close()
        End Try
    End Function

    Private Sub LoadEnvironmentVariables()
        Try
            ' Load the .env file from the application root directory
            Env.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env"))
        Catch ex As Exception
            MessageBox.Show("Error loading environment variables: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetApiKey() As String
        Try
            Dim apiKey As String = Env.GetString("API_KEY")
            If String.IsNullOrEmpty(apiKey) Then
                Throw New Exception("API_KEY not found in environment variables")
            End If
            Return apiKey
        Catch ex As Exception
            MessageBox.Show("Error reading API key: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If String.IsNullOrWhiteSpace(UserInputTextBox.Text) Then
            MessageBox.Show("Please enter a message", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SendButton.Enabled = False
        UserInputTextBox.Enabled = False

        Try
            Dim userMessage As String = UserInputTextBox.Text
            ChatHistoryRichTextBox.AppendText("You: " & userMessage & Environment.NewLine)

            Dim aiResponse As String = Await GetAIResponse(userMessage)
            ChatHistoryRichTextBox.AppendText("AI: " & aiResponse & Environment.NewLine & Environment.NewLine)

            UserInputTextBox.Clear()
        Catch ex As Exception
            MessageBox.Show("Error getting AI response: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SendButton.Enabled = True
            UserInputTextBox.Enabled = True
        End Try
    End Sub

    Private Async Function GetAIResponse(message As String) As Task(Of String)
        Dim financialContext As String = GetUserFinancialData()
        Dim enhancedMessage As String = $"As a financial advisor, considering the following user data:" &
                                      vbNewLine & financialContext &
                                      vbNewLine & "User question: " & message

        Dim requestBody As New With {
            .model = "deepseek-chat",
            .messages = New List(Of Object) From {
                New With {
                    .role = "system",
                    .content = "You are a financial advisor. Analyze the provided financial data and give professional advice."
                },
                New With {
                    .role = "user",
                    .content = enhancedMessage
                }
            },
            .temperature = 0.7,
            .max_tokens = 1000
        }

        Dim jsonRequestBody As String = JsonConvert.SerializeObject(requestBody)
        Dim content As New StringContent(jsonRequestBody, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await httpClient.PostAsync(DEEPSEEK_API_URL, content)
        response.EnsureSuccessStatusCode()

        Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
        Dim aiResult = JsonConvert.DeserializeObject(Of DeepSeekResponse)(jsonResponse)

        Return aiResult.choices(0).message.content
    End Function
End Class

Public Class DeepSeekResponse
    Public Property choices As List(Of DeepSeekChoice)
End Class

Public Class DeepSeekChoice
    Public Property message As DeepSeekMessage
End Class

Public Class DeepSeekMessage
    Public Property content As String
    Public Property role As String
End Class

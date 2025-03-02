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

    Private Sub AppendFormattedMessage(sender As String, message As String, isAI As Boolean)
        ' Add timestamp
        Dim timestamp = DateTime.Now.ToString("HH:mm")
        ChatHistoryRichTextBox.SelectionColor = Color.Gray
        ChatHistoryRichTextBox.SelectionFont = New Font("Arial", 8)
        ChatHistoryRichTextBox.AppendText($"[{timestamp}] ")

        ' Format sender
        ChatHistoryRichTextBox.SelectionColor = If(isAI, Color.RoyalBlue, Color.DarkGreen)
        ChatHistoryRichTextBox.SelectionFont = New Font("Arial", 10, FontStyle.Bold)
        ChatHistoryRichTextBox.AppendText(sender & ": ")

        ' Format message
        ChatHistoryRichTextBox.SelectionColor = Color.Black
        ChatHistoryRichTextBox.SelectionFont = New Font("Arial", 10)
        ChatHistoryRichTextBox.AppendText(message & Environment.NewLine)

        If isAI Then
            ChatHistoryRichTextBox.AppendText(Environment.NewLine)
        End If

        ' Scroll to end
        ChatHistoryRichTextBox.ScrollToCaret()
    End Sub

    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
        httpClient = New HttpClient()
        Dim apiKey As String = GetApiKey()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
        ' Initialize database connection
        dbConnection = createDBConnection()
        ChatHistoryRichTextBox.BackColor = Color.White
        ChatHistoryRichTextBox.BorderStyle = BorderStyle.FixedSingle
        ChatHistoryRichTextBox.Font = New Font("Segoe UI", 9.75F)
        ChatHistoryRichTextBox.ForeColor = Color.Black
        ChatHistoryRichTextBox.ReadOnly = True
        ChatHistoryRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical
        LoadEnvironmentVariables()
        LoadChatHistory()
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

    Private Sub SaveChatMessage(role As String, message As String, context As String)
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Return
        End If

        Try
            dbConnection.Open()
            Using cmd As New MySqlCommand(
            "INSERT INTO chat_history (UserID, Role, Message, Context) " &
            "VALUES (@userId, @role, @message, @context)",
            dbConnection)
                cmd.Parameters.AddWithValue("@userId", AccountData.UserID)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@message", message)
                cmd.Parameters.AddWithValue("@context", context)
                cmd.ExecuteNonQuery()
            End Using
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Sub LoadChatHistory()
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Return
        End If

        Try
            dbConnection.Open()
            Using cmd As New MySqlCommand(
        "SELECT Role, Message FROM chat_history " &
        "WHERE UserID = @userId " &
        "ORDER BY Timestamp ASC",
        dbConnection)
                cmd.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmd.ExecuteReader()
                    ChatHistoryRichTextBox.Clear()
                    While reader.Read()
                        Dim isAI = reader("Role").ToString() = "ai"
                        Dim sender As String = If(isAI, "AI", "You")
                        AppendFormattedMessage(sender, reader("Message").ToString(), isAI)
                    End While
                End Using
            End Using
        Finally
            dbConnection.Close()
        End Try
    End Sub


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
            Dim financialContext As String = GetUserFinancialData()

            ' Use new formatting for user message
            AppendFormattedMessage("You", userMessage, False)

            ' Save user message
            SaveChatMessage("user", userMessage, financialContext)

            Dim aiResponse As String = Await GetAIResponse(userMessage)

            ' Use new formatting for AI response
            AppendFormattedMessage("AI", aiResponse, True)

            ' Save AI response
            SaveChatMessage("ai", aiResponse, financialContext)

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
                                      vbNewLine & "User question: " & message &
                                      vbNewLine & "Please provide a concise response with only the necessary information."

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

        ' Post-process the response to extract necessary information
        Dim aiContent As String = aiResult.choices(0).message.content
        Dim necessaryData As String = ExtractNecessaryData(aiContent)

        Return necessaryData
    End Function

    Private Function ExtractNecessaryData(aiContent As String) As String
        ' Implement your logic to extract necessary data from aiContent
        ' For example, you can use regular expressions or string manipulation
        ' This is a placeholder implementation
        Return aiContent ' Modify this to return only the necessary data
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

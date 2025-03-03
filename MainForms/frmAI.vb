Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports DotNetEnv
Imports MySql.Data.MySqlClient

Public Class frmAI
    Private ReadOnly httpClient As HttpClient
    Private Const DEEPSEEK_API_URL As String = "https://api.deepseek.com/chat/completions"
    Private dbConnection As MySqlConnection 

    Private Sub AppendFormattedMessage(sender As String, message As String, isAI As Boolean)
        ' Add timestamp
        Dim timestamp = DateTime.Now.ToString("HH:mm")
        ChatHistoryRichTextBox.SelectionColor = Color.Gray
        ChatHistoryRichTextBox.SelectionFont = New Font("Century Gothic", 10)
        ChatHistoryRichTextBox.AppendText($"[{timestamp}] ")

        ' Format sender
        ChatHistoryRichTextBox.SelectionColor = If(isAI, Color.RoyalBlue, Color.DarkGreen)
        ChatHistoryRichTextBox.SelectionFont = New Font("Century Gothic", 16, FontStyle.Bold)
        ChatHistoryRichTextBox.AppendText(sender & ": ")

        ' Format message
        ChatHistoryRichTextBox.SelectionColor = Color.Black
        ChatHistoryRichTextBox.SelectionFont = New Font("Century Gothic", 14)
        AppendFormattedText(message)

        If isAI Then
            ChatHistoryRichTextBox.AppendText(Environment.NewLine)
        End If

        ' Scroll to end
        ChatHistoryRichTextBox.ScrollToCaret()
    End Sub

    Private Sub AppendFormattedText(message As String)
        Dim parts = message.Split(New Char() {" "c}, StringSplitOptions.None)
        For Each part In parts
            Dim fontStyle As FontStyle = FontStyle.Regular
            Dim text = part
            Dim fontSize As Single = 14

            If text.StartsWith("*") AndAlso text.EndsWith("*") Then
                fontStyle = FontStyle.Bold
                text = text.Trim("*"c)
            End If

            If text.StartsWith("_") AndAlso text.EndsWith("_") Then
                fontStyle = FontStyle.Italic
                text = text.Trim("_"c)
            End If

            If text.StartsWith("~") AndAlso text.EndsWith("~") Then
                fontStyle = FontStyle.Underline
                text = text.Trim("~"c)
            End If

            If text.Contains("**") Then
                fontStyle = FontStyle.Bold
                text = text.Replace("**", "")
            End If

            If text.StartsWith("###") Then
                fontSize = 18
                text = text.TrimStart("#"c)
            End If

            ChatHistoryRichTextBox.SelectionFont = New Font("Century Gothic", fontSize, fontStyle)
            ChatHistoryRichTextBox.AppendText(text & " ")
        Next
        ChatHistoryRichTextBox.AppendText(Environment.NewLine)
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
        ChatHistoryRichTextBox.Font = New Font("Century Gothic", 14)
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

            ' Get budget information (using the budgets table)
            Using cmdBudget As New MySqlCommand(
                "SELECT c.CategoryName, b.Amount, b.StartDate, b.EndDate " &
                "FROM budgets b " &
                "INNER JOIN categories c ON b.CategoryID = c.CategoryID " &
                "WHERE b.UserID = @userId " &
                "AND CURRENT_DATE BETWEEN b.StartDate AND b.EndDate",
                dbConnection)
                cmdBudget.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmdBudget.ExecuteReader()
                    financialData.AppendLine(vbNewLine & "Budget Information:")
                    While reader.Read()
                        financialData.AppendLine(
                $"- {reader("CategoryName")}: ${reader("Amount")} " &
                $"(Valid: {CDate(reader("StartDate")).ToString("MM/dd/yyyy")} - {CDate(reader("EndDate")).ToString("MM/dd/yyyy")})")
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
            ' First, insert the new message
            Using cmdInsert As New MySqlCommand(
            "INSERT INTO chat_history (UserID, Role, Message, Context) " &
            "VALUES (@userId, @role, @message, @context)",
            dbConnection)
                cmdInsert.Parameters.AddWithValue("@userId", AccountData.UserID)
                cmdInsert.Parameters.AddWithValue("@role", role)
                cmdInsert.Parameters.AddWithValue("@message", message)
                cmdInsert.Parameters.AddWithValue("@context", context)
                cmdInsert.ExecuteNonQuery()
            End Using

            ' Then, delete older messages if count exceeds the limit
            Using cmdDelete As New MySqlCommand(
            "DELETE FROM chat_history " &
            "WHERE UserID = @userId " &
            "AND ChatID NOT IN (" &
            "    SELECT ChatID FROM (" &
            "        SELECT ChatID " &
            "        FROM chat_history " &
            "        WHERE UserID = @userId " &
            "        ORDER BY Timestamp DESC " &
            "        LIMIT 50" &
            "    ) as temp" &
            ")",
            dbConnection)
                cmdDelete.Parameters.AddWithValue("@userId", AccountData.UserID)
                cmdDelete.ExecuteNonQuery()
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
            "ORDER BY Timestamp DESC " &
            "LIMIT 50",
            dbConnection)
                cmd.Parameters.AddWithValue("@userId", AccountData.UserID)
                Using reader = cmd.ExecuteReader()
                    ChatHistoryRichTextBox.Clear()
                    Dim messages As New List(Of (Role As String, Message As String))

                    ' Store messages in a list first (they come in reverse order)
                    While reader.Read()
                        messages.Add((reader("Role").ToString(), reader("Message").ToString()))
                    End While

                    ' Display messages in chronological order
                    For i As Integer = messages.Count - 1 To 0 Step -1
                        Dim isAI = messages(i).Role = "ai"
                        Dim sender As String = If(isAI, "AI", "You")
                        AppendFormattedMessage(sender, messages(i).Message, isAI)
                    Next
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

    Private Async Function GetAIResponse(message As String) As Task(Of String)
        ' First validate if the message is finance-related
        'If Not IsFinancialQuery(message) Then
        '    Return "I apologize, but I can only assist with financial topics and questions related to your financial data. Please ask something about your expenses, budget, savings, or financial planning."
        'End If

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
                .content = "You are a strictly financial advisor AI. Only provide responses related to financial matters, " &
                          "personal finance, budgeting, savings, investments, and financial planning. " &
                          "If a question is not related to finance or the user's financial data, " &
                          "politely decline to answer and remind the user that you can only discuss financial topics. " &
                          "Always analyze the provided financial data to give personalized financial advice."
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

    'Private Function IsFinancialQuery(message As String) As Boolean
    '    ' List of financial-related keywords
    '    Dim financialKeywords As String() = {
    '    "money", "budget", "expense", "spend", "save", "invest", "income", "cost",
    '    "bill", "payment", "debt", "loan", "interest", "bank", "account", "finance",
    '    "dollar", "profit", "loss", "balance", "credit", "debit", "fund", "salary",
    '    "earning", "tax", "investment", "stock", "bond", "market", "portfolio",
    '    "saving", "goal", "financial", "economy", "price", "cash", "transaction"
    '}

    '    ' Convert message to lower case for case-insensitive comparison
    '    Dim lowerMessage As String = message.ToLower()

    '    ' Check if the message contains any financial keywords
    '    Return financialKeywords.Any(Function(keyword) lowerMessage.Contains(keyword))
    'End Function

    Private Function ExtractNecessaryData(aiContent As String) As String
        ' Implement your logic to extract necessary data from aiContent
        ' For example, you can use regular expressions or string manipulation
        ' This is a placeholder implementation
        Return aiContent ' Modify this to return only the necessary data
    End Function

    Private Async Sub SendButton_Click_1(sender As Object, e As EventArgs) Handles SendButton.Click
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

    Private Sub btnClearHistory_Click_1(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Return
        End If

        ' Show confirmation dialog
        Dim result = MessageBox.Show(
        "Are you sure you want to clear your chat history? This action cannot be undone.",
        "Clear Chat History",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                dbConnection.Open()
                ' Delete all chat history for the current user
                Using cmd As New MySqlCommand(
                "DELETE FROM chat_history WHERE UserID = @userId",
                dbConnection)
                    cmd.Parameters.AddWithValue("@userId", AccountData.UserID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Clear the chat display
                ChatHistoryRichTextBox.Clear()
                MessageBox.Show(
                "Chat history has been cleared successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(
                "Error clearing chat history: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub
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

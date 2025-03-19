Imports System.Net.Http
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq
Imports DotNetEnv
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography

Public Class frmOCR
    Private ReadOnly httpClient As HttpClient
    Private Const DEEPSEEK_API_URL As String = "https://api.deepseek.com/chat/completions"
    Private dbConnection As MySqlConnection
    Private _lastOcrText As String = String.Empty
    Private _lastImageHash As String = String.Empty

    Private Function CalculateImageHash(filePath As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Using fileStream As FileStream = File.OpenRead(filePath)
                Dim hashBytes As Byte() = sha256.ComputeHash(fileStream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function

    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
        pbxScan.Visible = True
        httpClient = New HttpClient()
        Dim apiKey As String = GetAIApiKey()
        If Not String.IsNullOrEmpty(apiKey) Then
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
        End If
        dbConnection = createDBConnection()
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
            Dim apiKey As String = Env.GetString("API_KEY_OCR")
            If String.IsNullOrEmpty(apiKey) Then
                Throw New Exception("API_KEY not found in environment variables")
            End If
            Return apiKey
        Catch ex As Exception
            MessageBox.Show("Error reading API key: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Function GetAIApiKey() As String
        Try
            Dim apiKey As String = Env.GetString("API_KEY")
            If String.IsNullOrEmpty(apiKey) Then
                Throw New Exception("API_KEY not found in environment variables")
            End If
            Return apiKey
        Catch ex As Exception
            MessageBox.Show("Error reading AI API key: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Async Function UploadImageToOCRSpace(filePath As String) As Task(Of String)
        Dim apiKey As String = GetApiKey()
        If String.IsNullOrEmpty(apiKey) Then
            Return "Error: API key is missing"
        End If

        ' Check file size before uploading
        Dim fileInfo As New FileInfo(filePath)
        If fileInfo.Length > 1024 * 1024 Then ' If larger than 1MB
            Return "Error: Image file is too large. Please use an image smaller than 1MB"
        End If

        Dim apiUrl As String = "https://api.ocr.space/parse/image"

        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromMinutes(2) ' Increase timeout to 2 minutes

                Using form As New MultipartFormDataContent()
                    form.Add(New StringContent(apiKey), "apikey")
                    form.Add(New StringContent("eng"), "language")
                    form.Add(New StringContent("2"), "OCREngine") ' Try engine 2 instead of default
                    form.Add(New StringContent("true"), "detectOrientation")
                    form.Add(New StringContent("true"), "scale")
                    form.Add(New StringContent("true"), "detectCheckbox")
                    form.Add(New ByteArrayContent(File.ReadAllBytes(filePath)), "file", Path.GetFileName(filePath))

                    ' Add a small delay before making the request
                    Await Task.Delay(1000)

                    Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, form)
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                    Debug.WriteLine("OCR API Response: " & responseContent)

                    Dim jsonResponse As JObject = JObject.Parse(responseContent)

                    If jsonResponse("ErrorMessage") IsNot Nothing AndAlso Not String.IsNullOrEmpty(jsonResponse("ErrorMessage").ToString()) Then
                        ' If we get E202, try one more time with different engine
                        If jsonResponse("ErrorMessage").ToString().Contains("E202") Then
                            form.Add(New StringContent("1"), "OCREngine")
                            Await Task.Delay(2000) ' Wait 2 seconds before retry
                            response = Await client.PostAsync(apiUrl, form)
                            responseContent = Await response.Content.ReadAsStringAsync()
                            jsonResponse = JObject.Parse(responseContent)
                        End If

                        If jsonResponse("ErrorMessage") IsNot Nothing AndAlso Not String.IsNullOrEmpty(jsonResponse("ErrorMessage").ToString()) Then
                            Return "API Error: " & jsonResponse("ErrorMessage").ToString()
                        End If
                    End If

                    If jsonResponse("ParsedResults") IsNot Nothing AndAlso jsonResponse("ParsedResults").Any() Then
                        Return jsonResponse("ParsedResults")(0)("ParsedText").ToString()
                    Else
                        Return "Error: No text was extracted from the image. Response: " & responseContent
                    End If
                End Using
            End Using
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    Private Async Function GetAIAnalysis(text As String) As Task(Of String)
        Dim requestBody As New With {
            .model = "deepseek-chat",
            .messages = New List(Of Object) From {
                New With {
                    .role = "system",
                    .content = "You are an AI assistant that analyzes OCR text. Please do not provide any response in Markdown format. Please analyze the text content for:" & vbCrLf &
                              "1. Key information extraction" & vbCrLf &
                              "2. Potential OCR errors and corrections" & vbCrLf &
                              "3. Document type identification" & vbCrLf &
                              "4. Financial information if present"
                },
                New With {
                    .role = "user",
                    .content = $"Analyze this OCR text: {text}"
                }
            },
            .temperature = 0.7,
            .max_tokens = 1000
        }

        Dim jsonRequestBody As String = JsonConvert.SerializeObject(requestBody)
        Dim content As New StringContent(jsonRequestBody, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(DEEPSEEK_API_URL, content)
            response.EnsureSuccessStatusCode()

            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim aiResult = JsonConvert.DeserializeObject(Of DeepSeekResponse)(jsonResponse)

            If Not String.IsNullOrEmpty(AccountData.UserID) Then
                SaveChatMessage("ai", aiResult.choices(0).message.content, text)
            End If

            Return aiResult.choices(0).message.content
        Catch ex As Exception
            Return $"Error analyzing text: {ex.Message}"
        End Try
    End Function

    Private Async Function ClassifyOCRDataWithAI(text As String) As Task(Of String)
        Dim requestBody As New With {
        .model = "deepseek-chat",
        .messages = New List(Of Object) From {
            New With {
                .role = "system",
                .content = "You are an AI assistant that analyzes OCR text from financial documents. " &
                          "Classify the document into one of these categories: 'Income', 'Expense', or 'Savings'. " &
                          "Then extract key financial information in JSON format with these fields based on category: " &
                          "1. For Income: {""category"": ""Income"", ""source"": ""[source]"", ""amount"": [amount], ""date"": ""[date if available, otherwise today's date]""}" &
                          "2. For Expense: {""category"": ""Expense"", ""item"": ""[item name]"", ""cost"": [amount], ""expenseCategory"": ""[category]"", ""description"": ""[brief description]"", ""date"": ""[date if available, otherwise today's date]""}" &
                          "3. For Savings: {""category"": ""Savings"", ""goalName"": ""[goal name or purpose]"", ""targetAmount"": [target amount if available], ""currentAmount"": [current amount], ""targetDate"": ""[target date if available]""}"
            },
            New With {
                .role = "user",
                .content = $"Analyze and classify this OCR text into Income, Expense, or Savings category. Extract the relevant information in JSON format: {text}"
            }
        },
        .temperature = 0.3,
        .max_tokens = 1000
    }

        Dim jsonRequestBody As String = JsonConvert.SerializeObject(requestBody)
        Dim content As New StringContent(jsonRequestBody, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(DEEPSEEK_API_URL, content)
            response.EnsureSuccessStatusCode()

            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim aiResult = JsonConvert.DeserializeObject(Of DeepSeekResponse)(jsonResponse)

            Return aiResult.choices(0).message.content
        Catch ex As Exception
            Return $"Error classifying text: {ex.Message}"
        End Try
    End Function

    Private Function ExtractJsonFromAIResponse(response As String) As JObject
        Try
            ' Look for JSON pattern in the response
            Dim jsonPattern As String = "\{(?:[^{}]|(?<open>\{)|(?<-open>\}))+(?(open)(?!))\}"
            Dim match As Match = Regex.Match(response, jsonPattern)

            If match.Success Then
                Return JObject.Parse(match.Value)
            Else
                ' If no JSON found, return empty object
                Return New JObject()
            End If
        Catch ex As Exception
            MessageBox.Show("Error extracting JSON data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New JObject()
        End Try
    End Function

    Private Async Function SaveOCRDataToDatabase(jsonData As JObject, imageHash As String) As Task(Of Boolean)
        If jsonData Is Nothing OrElse Not jsonData.HasValues Then
            MessageBox.Show("No valid data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim category As String = jsonData.Value(Of String)("category")
        Dim success As Boolean = False

        Select Case category.ToLower()
            Case "income"
                success = Await SaveIncomeData(jsonData, imageHash)
            Case "expense"
                success = Await SaveExpenseData(jsonData, imageHash)
            Case "savings"
                success = Await SaveSavingsData(jsonData)
            Case Else
                MessageBox.Show("Unknown category: " & category, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
        End Select

        Return success
    End Function

    Private Async Function SaveIncomeData(data As JObject, imageHash As String) As Task(Of Boolean)
        Try
            Dim source As String = data.Value(Of String)("source")
            Dim amount As Decimal = data.Value(Of Decimal)("amount")
            Dim dateStr As String = data.Value(Of String)("date")
            Dim incomeDate As Date

            If Not Date.TryParse(dateStr, incomeDate) Then
                incomeDate = DateTime.Now
            End If

            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO user_income (UserID, Source, Amount, Date, ImageHash) VALUES (@UserID, @Source, @Amount, @Date, @ImageHash)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@Source", source)
                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@Date", incomeDate)
                    cmd.Parameters.AddWithValue("@ImageHash", imageHash)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving income data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Async Function SaveExpenseData(data As JObject, imageHash As String) As Task(Of Boolean)
        Try
            Dim item As String = data.Value(Of String)("item")
            Dim cost As Decimal = data.Value(Of Decimal)("cost")
            Dim category As String = data.Value(Of String)("expenseCategory")
            Dim description As String = data.Value(Of String)("description")
            Dim dateStr As String = data.Value(Of String)("date")
            Dim expenseDate As Date

            If Not Date.TryParse(dateStr, expenseDate) Then
                expenseDate = DateTime.Now
            End If

            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO user_expenses (UserID, Item, Cost, Category, Description, Date, ImageHash) VALUES (@UserID, @Item, @Cost, @Category, @Description, @Date, @ImageHash)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@Item", item)
                    cmd.Parameters.AddWithValue("@Cost", cost)
                    cmd.Parameters.AddWithValue("@Category", category)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.Parameters.AddWithValue("@Date", expenseDate)
                    cmd.Parameters.AddWithValue("@ImageHash", imageHash)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving expense data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Async Function SaveSavingsData(data As JObject) As Task(Of Boolean)
        Try
            Dim goalName As String = data.Value(Of String)("goalName")
            Dim targetAmount As Decimal = If(data("targetAmount") IsNot Nothing, data.Value(Of Decimal)("targetAmount"), 0)
            Dim currentAmount As Decimal = If(data("currentAmount") IsNot Nothing, data.Value(Of Decimal)("currentAmount"), 0)
            Dim dateStr As String = If(data("targetDate") IsNot Nothing, data.Value(Of String)("targetDate"), Date.Now.AddYears(1).ToString("yyyy-MM-dd"))
            Dim targetDate As Date

            If Not Date.TryParse(dateStr, targetDate) Then
                targetDate = Date.Now.AddYears(1)
            End If

            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO savings_goals (UserID, GoalName, TargetAmount, CurrentAmount, TargetDate) VALUES (@UserID, @GoalName, @TargetAmount, @CurrentAmount, @TargetDate)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@GoalName", goalName)
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
                    cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
                    cmd.Parameters.AddWithValue("@TargetDate", targetDate)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving savings data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub SaveChatMessage(role As String, message As String, context As String)
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Return
        End If

        Try
            dbConnection.Open()
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
        Finally
            dbConnection.Close()
        End Try
    End Sub

    Private Async Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Try
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                openFileDialog.Title = "Select an Image File"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim selectedFilePath As String = openFileDialog.FileName

                    Dim imageHash As String = CalculateImageHash(selectedFilePath)
                    _lastImageHash = imageHash  ' Store the image hash

                    If Await IsImageHashDuplicate(imageHash) Then
                        MessageBox.Show("This image has already been uploaded.", "Duplicate Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    rtbAIResponse.Text = "Processing image, please wait..."
                    btnOpenFile.Enabled = False
                    btnUploadData.Enabled = False
                    pbxScan.Visible = False

                    Dim ocrResult As String = Await UploadImageToOCRSpace(selectedFilePath)
                    _lastOcrText = ocrResult

                    Dim analysis As String = Await GetAIAnalysis(ocrResult)
                    rtbAIResponse.Text = analysis

                    UserExperience.AddXP(50)
                    UserExperience.SaveUserExperience(AccountData.UserID)

                    Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                    If mainForm IsNot Nothing Then
                        mainForm.UpdateExperienceBar()
                        mainForm.prgExperience.Invalidate()
                        mainForm.prgExperience.Refresh()
                        mainForm.lblLevel.Refresh()
                    End If
                End If
            End Using
        Catch ex As Exception
            rtbAIResponse.Text = "Error: " & ex.Message
        Finally
            btnOpenFile.Enabled = True
            btnUploadData.Enabled = True
        End Try
    End Sub

    Private Async Function IsImageHashDuplicate(imageHash As String) As Task(Of Boolean)
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM (SELECT ImageHash FROM user_income WHERE ImageHash = @ImageHash UNION ALL SELECT ImageHash FROM user_expenses WHERE ImageHash = @ImageHash) AS combined"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ImageHash", imageHash)
                    Dim count As Integer = Convert.ToInt32(Await cmd.ExecuteScalarAsync())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking image hash: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Async Sub btnUploadData_Click(sender As Object, e As EventArgs) Handles btnUploadData.Click
        If String.IsNullOrWhiteSpace(_lastOcrText) Then
            MessageBox.Show("Please scan a document first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        btnUploadData.Enabled = False
        btnOpenFile.Enabled = False
        rtbAIResponse.Text = "Processing document..."

        Try
            Dim classificationResult As String = Await ClassifyOCRDataWithAI(_lastOcrText)
            Dim jsonData As JObject = ExtractJsonFromAIResponse(classificationResult)

            If jsonData IsNot Nothing AndAlso jsonData.HasValues Then
                Dim category As String = jsonData.Value(Of String)("category")
                Dim result = MessageBox.Show(
                $"The document has been classified as {category}. Would you like to upload this data to your {category.ToLower()} records?",
                "Confirm Upload",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

                If result = DialogResult.Yes Then
                    ' Pass the stored image hash here
                    Dim success As Boolean = Await SaveOCRDataToDatabase(jsonData, _lastImageHash)
                    If success Then
                        MessageBox.Show($"Data has been successfully added to your {category.ToLower()} records.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        rtbAIResponse.Text = $"✓ Document processed and uploaded as {category}"

                        UserExperience.AddXP(30)
                        UserExperience.SaveUserExperience(AccountData.UserID)

                        Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                        If mainForm IsNot Nothing Then
                            mainForm.UpdateExperienceBar()
                            mainForm.prgExperience.Invalidate()
                            mainForm.prgExperience.Refresh()
                            mainForm.lblLevel.Refresh()
                        End If
                    Else
                        rtbAIResponse.Text = "⚠️ Upload failed. Please try again."
                    End If
                Else
                    rtbAIResponse.Text = "Upload cancelled."
                End If
            Else
                MessageBox.Show("Could not extract valid data from the document. Please check the OCR results and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtbAIResponse.Text = "⚠️ Could not classify document. Please check the OCR text."
            End If
        Catch ex As Exception
            rtbAIResponse.Text = "Error: " & ex.Message
        Finally
            btnUploadData.Enabled = True
            btnOpenFile.Enabled = True
        End Try
    End Sub

    Private Sub btnClearAIHistory_Click(sender As Object, e As EventArgs) Handles btnClearAIHistory.Click
        If String.IsNullOrEmpty(AccountData.UserID) Then
            Return
        End If

        Dim result = MessageBox.Show(
        "Are you sure you want to clear your AI analysis history? This action cannot be undone.",
        "Clear AI History",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                dbConnection.Open()
                Using cmd As New MySqlCommand(
                "DELETE FROM chat_history WHERE UserID = @userId",
                dbConnection)
                    cmd.Parameters.AddWithValue("@userId", AccountData.UserID)
                    cmd.ExecuteNonQuery()
                End Using

                rtbAIResponse.Clear()
                MessageBox.Show(
                "AI analysis history has been cleared successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

                ' Add experience points
                UserExperience.AddXP(5)

                ' Save user experience data
                UserExperience.SaveUserExperience(AccountData.UserID)

                ' Update the experience bar in frmMain
                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()

                    ' Force the progress bar to refresh
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If
            Catch ex As Exception
                MessageBox.Show(
                "Error clearing AI history: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Finally
                dbConnection.Close()
            End Try
        End If
    End Sub

    Private Async Sub btnAnalyze_Click_1(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        'If String.IsNullOrWhiteSpace(rtbOCR.Text) Then
        '    MessageBox.Show("Please scan a document first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        'btnAnalyze.Enabled = False
        'rtbAIResponse.Text = "Analyzing text..."
        'Try
        '    Dim analysis As String = Await GetAIAnalysis(rtbOCR.Text)
        '    rtbAIResponse.Text = analysis

        '    ' Add experience points
        '    UserExperience.AddXP(15)

        '    ' Save user experience data
        '    UserExperience.SaveUserExperience(AccountData.UserID)

        '    ' Update the experience bar in frmMain
        '    Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
        '    If mainForm IsNot Nothing Then
        '        mainForm.UpdateExperienceBar()

        '        ' Force the progress bar to refresh
        '        mainForm.prgExperience.Invalidate()
        '        mainForm.prgExperience.Refresh()
        '        mainForm.lblLevel.Refresh()
        '    End If
        'Finally
        '    btnAnalyze.Enabled = True
        'End Try
    End Sub
End Class

' Remove duplicate class definitions
' The following classes are already defined elsewhere in the code

'Public Class DeepSeekResponse
'    Public Property choices As List(Of DeepSeekChoice)
'End Class

'Public Class DeepSeekChoice
'    Public Property message As DeepSeekMessage
'End Class

'Public Class DeepSeekMessage
'    Public Property content As String
'    Public Property role As String
'End Class

Imports System.Net.Http
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq
Imports DotNetEnv
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient

Public Class frmOCR
    Private ReadOnly httpClient As HttpClient
    Private Const DEEPSEEK_API_URL As String = "https://api.deepseek.com/chat/completions"
    Private dbConnection As MySqlConnection

    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
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

    Private Async Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Try
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                openFileDialog.Title = "Select an Image File"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim selectedFilePath As String = openFileDialog.FileName
                    rtbOCR.Text = "Processing image, please wait..."
                    Dim ocrResult As String = Await UploadImageToOCRSpace(selectedFilePath)
                    rtbOCR.Text = ocrResult
                End If
            End Using
        Catch ex As Exception
            rtbOCR.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Async Function GetAIAnalysis(text As String) As Task(Of String)
        Dim requestBody As New With {
            .model = "deepseek-chat",
            .messages = New List(Of Object) From {
                New With {
                    .role = "system",
                    .content = "You are an AI assistant that analyzes OCR text. Please analyze the text content for:" & vbCrLf &
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

            ' Save the analysis to chat history
            If Not String.IsNullOrEmpty(AccountData.UserID) Then
                SaveChatMessage("ai", aiResult.choices(0).message.content, text)
            End If

            Return aiResult.choices(0).message.content
        Catch ex As Exception
            Return $"Error analyzing text: {ex.Message}"
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

    Private Async Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        If String.IsNullOrWhiteSpace(rtbOCR.Text) Then
            MessageBox.Show("Please scan a document first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        btnAnalyze.Enabled = False
        rtbAIResponse.Text = "Analyzing text..."
        Try
            Dim analysis As String = Await GetAIAnalysis(rtbOCR.Text)
            rtbAIResponse.Text = analysis
        Finally
            btnAnalyze.Enabled = True
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

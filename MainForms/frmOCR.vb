Imports System.Net.Http
Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq
Imports DotNetEnv
Imports System.IO


Public Class frmOCR

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



    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
    End Sub

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
End Class
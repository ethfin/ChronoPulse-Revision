Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Imports DotNetEnv

Public Class frmAI
    Private ReadOnly httpClient As HttpClient
    Private Const DEEPSEEK_API_URL As String = "https://api.deepseek.com/v1/chat/completions"

    Public Sub New()
        InitializeComponent()
        LoadEnvironmentVariables()
        httpClient = New HttpClient()
        Dim apiKey As String = GetApiKey()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
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
        Dim requestBody As New With {
            .model = "deepseek-chat",
            .messages = New List(Of Object) From {
                New With {
                    .role = "user",
                    .content = message
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

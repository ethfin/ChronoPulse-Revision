Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO

Public Class frmAI
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        InitializeComponent()
        httpClient = New HttpClient()
        Dim apiKey As String = GetApiKey()
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)
    End Sub

    Private Function GetApiKey() As String
        Dim json As String = File.ReadAllText("appsettings.json")
        Dim config = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
        Return config("ApiKey")
    End Function

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim userMessage As String = UserInputTextBox.Text
        ChatHistoryRichTextBox.AppendText("You: " & userMessage & Environment.NewLine)

        Dim aiResponse As String = Await GetAIResponse(userMessage)
        ChatHistoryRichTextBox.AppendText("AI: " & aiResponse & Environment.NewLine)

        UserInputTextBox.Clear()
    End Sub

    Private Async Function GetAIResponse(message As String) As Task(Of String)
        Dim requestBody As New With {
            .prompt = message,
            .max_tokens = 150
        }
        Dim jsonRequestBody As String = JsonConvert.SerializeObject(requestBody)
        Dim content As New StringContent(jsonRequestBody, Encoding.UTF8, "application/json")

        ' Update the URL to the GPT-4o endpoint
        Dim response As HttpResponseMessage = Await httpClient.PostAsync("https://api.openai.com/v1/engines/gpt-4o/completions", content)
        response.EnsureSuccessStatusCode()

        Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
        Dim aiResult = JsonConvert.DeserializeObject(Of AIResponse)(jsonResponse)

        Return aiResult.choices(0).text.Trim()
    End Function
End Class

Public Class AIResponse
    Public Property choices As List(Of Choice)
End Class

Public Class Choice
    Public Property text As String
End Class
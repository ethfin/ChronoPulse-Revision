Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

' THIS IS A SAMPLE CODE AND MAY NOT WORK AS-IS
' PLEASE MAKE SURE TO UPDATE THE CODE TO MATCH YOUR REQUIREMENTS

Public Class frmAI
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        InitializeComponent()
        httpClient = New HttpClient()
        ' Add your API key here
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")
    End Sub

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
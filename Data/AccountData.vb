Public Class AccountData
    Public Shared Property Username As String
    Public Shared Property UserID As String

    Public Shared Sub Clear()
        Username = String.Empty
        UserID = String.Empty
    End Sub
End Class

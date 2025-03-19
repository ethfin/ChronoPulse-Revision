Public Class AccountData
    Public Shared Property UserID As Integer
    Public Shared Property Username As String
    Public Shared Property HideNameInLeaderboard As Boolean

    Public Shared Sub Clear()
        UserID = 0
        Username = String.Empty
        HideNameInLeaderboard = False
    End Sub
End Class

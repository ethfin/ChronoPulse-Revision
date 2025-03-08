Public Class UserExperience
    Public Shared Property CurrentXP As Integer = 0
    Public Shared Property CurrentLevel As Integer = 1

    Private Shared ReadOnly XPThresholds As New Dictionary(Of Integer, Integer) From {
        {1, 100}, {2, 250}, {3, 500}, {4, 1000}, {5, 2000}
    }

    Public Shared Sub AddXP(points As Integer)
        CurrentXP += points
        CheckForLevelUp()
    End Sub

    Private Shared Sub CheckForLevelUp()
        If XPThresholds.ContainsKey(CurrentLevel + 1) AndAlso CurrentXP >= XPThresholds(CurrentLevel + 1) Then
            CurrentLevel += 1
            MessageBox.Show($"Congratulations! You've reached level {CurrentLevel}!")
        End If
    End Sub

    Public Shared Function GetProgressToNextLevel() As Double
        Dim nextLevel As Integer = CurrentLevel + 1
        If Not XPThresholds.ContainsKey(nextLevel) Then Return 1.0

        Dim currentThreshold As Integer = If(CurrentLevel = 1, 0, XPThresholds(CurrentLevel))
        Dim nextThreshold As Integer = XPThresholds(nextLevel)
        Dim xpForNextLevel As Integer = nextThreshold - currentThreshold
        Dim progress As Double = (CurrentXP - currentThreshold) / xpForNextLevel

        Return Math.Min(Math.Max(progress, 0), 1)
    End Function
End Class

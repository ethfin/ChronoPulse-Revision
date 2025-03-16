Imports MySql.Data.MySqlClient

Public Class UserExperience
    Public Shared Property CurrentXP As Integer = 0
    Public Shared Property CurrentLevel As Integer = 1

    Private Shared ReadOnly XPThresholds As New Dictionary(Of Integer, Integer) From {
        {1, 100}, {2, 250}, {3, 500}, {4, 1000}, {5, 2000}
    }

    Public Shared Sub LoadUserExperience(userID As Integer)
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT Level, Experience FROM user_experience WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", userID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        CurrentLevel = reader.GetInt32("Level")
                        CurrentXP = reader.GetInt32("Experience")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Shared Sub SaveUserExperience(userID As Integer)
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "INSERT INTO user_experience (UserID, Level, Experience) VALUES (@UserID, @Level, @Experience) " &
                                  "ON DUPLICATE KEY UPDATE Level = @Level, Experience = @Experience"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@Level", CurrentLevel)
                cmd.Parameters.AddWithValue("@Experience", CurrentXP)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

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

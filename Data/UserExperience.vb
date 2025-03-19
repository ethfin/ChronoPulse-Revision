Imports MySql.Data.MySqlClient

Public Class UserExperience
    Public Shared Property CurrentXP As Integer = 0
    Public Shared Property CurrentLevel As Integer = 1

    Private Shared ReadOnly XPThresholds As New Dictionary(Of Integer, Integer) From {
    {1, 100}, {2, 250}, {3, 500}, {4, 1000}, {5, 1500}, {6, 2000}, {7, 2500}, {8, 3000}, {9, 3500}, {10, 4000},
    {11, 4500}, {12, 5000}, {13, 5500}, {14, 6000}, {15, 6500}, {16, 7000}, {17, 7500}, {18, 8000}, {19, 8500}, {20, 9000},
    {21, 9500}, {22, 10000}, {23, 10500}, {24, 11000}, {25, 11500}, {26, 12000}, {27, 12500}, {28, 13000}, {29, 13500}, {30, 14000},
    {31, 14500}, {32, 15000}, {33, 15500}, {34, 16000}, {35, 16500}, {36, 17000}, {37, 17500}, {38, 18000}, {39, 18500}, {40, 19000},
    {41, 19500}, {42, 20000}, {43, 20500}, {44, 21000}, {45, 21500}, {46, 22000}, {47, 22500}, {48, 23000}, {49, 23500}, {50, 24000}
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
        Dim multiplier As Double = GetXPMultiplier(CurrentLevel)
        CurrentXP += CInt(points * multiplier)
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

    Private Shared Function GetXPMultiplier(level As Integer) As Double
        If level < 2 Then
            Return 1.0
        End If

        ' Increment the multiplier for levels 2 and above
        Return 1.0 + (level - 1) * 1.0
    End Function
End Class
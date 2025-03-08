Imports MySql.Data.MySqlClient
Public Class Achievement
    Public Property ID As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property XPReward As Integer
    Public Property IsUnlocked As Boolean

    Public Sub Unlock()
        If Not IsUnlocked Then
            IsUnlocked = True
            UserExperience.AddXP(XPReward)
            MessageBox.Show($"Achievement Unlocked: {Name}" & vbCrLf &
                           $"{Description}" & vbCrLf &
                           $"+{XPReward} XP")
        End If
    End Sub
End Class

Public Class AchievementManager
    Public Shared _achievements As New List(Of Achievement)

    Public Shared Sub Initialize()
        _achievements.Add(New Achievement With {
            .ID = 1,
            .Name = "Budget Master",
            .Description = "Create your first budget",
            .XPReward = 20,
            .IsUnlocked = False
        })

        _achievements.Add(New Achievement With {
            .ID = 2,
            .Name = "Savings Starter",
            .Description = "Create your first savings goal",
            .XPReward = 20,
            .IsUnlocked = False
        })

        _achievements.Add(New Achievement With {
            .ID = 3,
            .Name = "Financial Tracker",
            .Description = "Track 10 expenses",
            .XPReward = 30,
            .IsUnlocked = False
        })

        _achievements.Add(New Achievement With {
            .ID = 4,
            .Name = "First Expense",
            .Description = "Add your first expense",
            .XPReward = 10,
            .IsUnlocked = False
        })
    End Sub

    Public Shared Sub CheckAchievements()
        ' Logic to check if achievements should be unlocked
        ' Example: Check number of expenses to unlock "Financial Tracker"
        CheckExpenseTrackerAchievement()
    End Sub

    Private Shared Sub CheckExpenseTrackerAchievement()
        Dim achievement = _achievements.Find(Function(a) a.ID = 3)
        If achievement IsNot Nothing AndAlso Not achievement.IsUnlocked Then
            ' Count expenses in database
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM user_expenses WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count >= 10 Then
                        achievement.Unlock()
                    End If
                End Using
            End Using
        End If
    End Sub
End Class

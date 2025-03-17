Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class frmQuests

    Private Sub frmQuests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the quests table exists in the database
        EnsureQuestTable()
        LoadQuests()
    End Sub

    Private Sub LoadQuests()
        flpQuests.Controls.Clear()

        Dim totalMonthlyIncome As Decimal = GetThisMonthIncome()
        Dim totalMonthlyExpenses As Decimal = GetThisMonthExpenses()
        Dim totalSaved As Decimal = totalMonthlyIncome - totalMonthlyExpenses

        ' Example quests
        CreateQuestPanel("Save $100 This Month", 100D, totalSaved)
        CreateQuestPanel("Save $500 This Month", 500D, totalSaved)
        CreateQuestPanel("Save $1000 This Month", 1000D, totalSaved)
        CreateQuestPanel("Save 10% of Your Income This Month", totalMonthlyIncome * 0.1D, totalSaved)
        CreateQuestPanel("Save 20% of Your Income This Month", totalMonthlyIncome * 0.2D, totalSaved)
        CreateQuestPanel("Save $2000 This Month", 2000D, totalSaved)
    End Sub


    Private Sub EnsureQuestTable()
        ' Creates the user_quests table if it doesn't exist
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String =
                "CREATE TABLE IF NOT EXISTS `user_quests` (
                    `UserID` INT NOT NULL,
                    `QuestName` VARCHAR(255) NOT NULL,
                    `IsCompleted` TINYINT DEFAULT 0,
                    `CompletionDate` DATETIME NULL,
                    PRIMARY KEY (`UserID`, `QuestName`)
                );"
            Using cmd As New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetThisMonthIncome() As Decimal
        Dim total As Decimal = 0
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String =
                "SELECT COALESCE(SUM(Amount),0) FROM user_income
                 WHERE UserID=@UserID
                 AND MONTH(`Date`) = MONTH(CURRENT_DATE())
                 AND YEAR(`Date`)  = YEAR(CURRENT_DATE())"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                total = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return total
    End Function

    Private Function GetThisMonthExpenses() As Decimal
        Dim total As Decimal = 0
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String =
                "SELECT COALESCE(SUM(Cost),0) FROM user_expenses
                 WHERE UserID=@UserID
                 AND MONTH(`Date`) = MONTH(CURRENT_DATE())
                 AND YEAR(`Date`)  = YEAR(CURRENT_DATE())"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                total = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return total
    End Function

    Private Sub CreateQuestPanel(questName As String, goalAmount As Decimal, currentSaved As Decimal)
        Dim questPanel As New Guna2Panel With {
        .FillColor = Color.FromArgb(13, 17, 64),
        .Size = New Size(560, 80),
        .BorderStyle = BorderStyle.FixedSingle,
        .BorderRadius = 10
    }

        Dim lblQuestName As New Label With {
        .Text = questName,
        .ForeColor = Color.White,
        .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
        .Location = New Point(10, 10),
        .Size = New Size(200, 20),
        .BackColor = Color.Transparent
    }
        questPanel.Controls.Add(lblQuestName)

        Dim lblProgress As New Label With {
        .ForeColor = Color.White,
        .Font = New Font("Century Gothic", 9.0F, FontStyle.Regular),
        .Location = New Point(10, 30),
        .Size = New Size(200, 20),
        .BackColor = Color.Transparent
    }

        Dim progressValue As Decimal = Math.Max(0, Math.Min(1, currentSaved / goalAmount))
        lblProgress.Text = String.Format("Progress: ${0:F2} / ${1:F2}", Math.Max(0, currentSaved), goalAmount)
        questPanel.Controls.Add(lblProgress)

        Dim prgQuest As New Guna2ProgressBar With {
        .Location = New Point(10, 50),
        .Size = New Size(300, 20),
        .Value = CInt(progressValue * 100),
        .FillColor = Color.Gray,
        .ProgressColor = Color.LightGreen
    }
        questPanel.Controls.Add(prgQuest)

        ' Check if quest is complete, if so, award XP if not already claimed
        If progressValue >= 1D Then
            ' If user hasn't completed the quest before, mark it complete and give XP
            If Not IsQuestCompleted(questName) Then
                CompleteQuest(questName)
                UserExperience.AddXP(50)               ' Award 50 XP
                UserExperience.SaveUserExperience(AccountData.UserID)  ' Save updated XP

                ' Update the experience bar in frmMain (similar to frmExpenses)
                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If

                ' Display quest completion message
                MessageBox.Show($"Quest complete! You have earned 50 points!", "Quest Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        flpQuests.Controls.Add(questPanel)
    End Sub


    Private Function IsQuestCompleted(questName As String) As Boolean
        ' Checks the user_quests table to see if the quest is already completed
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String =
                "SELECT IsCompleted FROM user_quests
                 WHERE UserID = @UserID AND QuestName = @QuestName LIMIT 1"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                cmd.Parameters.AddWithValue("@QuestName", questName)
                Dim resultObj = cmd.ExecuteScalar()
                If resultObj IsNot Nothing AndAlso Convert.ToInt32(resultObj) = 1 Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function

    Private Sub CompleteQuest(questName As String)
        ' Mark the quest as completed in user_quests
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()

            Dim query As String =
                "INSERT INTO user_quests (UserID, QuestName, IsCompleted, CompletionDate)
                 VALUES (@UserID, @QuestName, 1, NOW())
                 ON DUPLICATE KEY UPDATE IsCompleted=1, CompletionDate=NOW()"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                cmd.Parameters.AddWithValue("@QuestName", questName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ExportQuestData(questName As String)
        ' Example of exporting quest completion data using ExportUtility
        Dim dgv As New DataGridView()
        dgv.Columns.Add("QuestName", "Quest Name")
        dgv.Columns.Add("Completed", "Completed")
        dgv.Columns.Add("CompletionDate", "Completion Date")

        ' Pull the single quest's record from user_quests
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String =
                "SELECT QuestName, IsCompleted, CompletionDate 
                 FROM user_quests 
                 WHERE UserID = @UserID AND QuestName=@QuestName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                cmd.Parameters.AddWithValue("@QuestName", questName)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim rowIndex As Integer = dgv.Rows.Add()
                        dgv.Rows(rowIndex).Cells("QuestName").Value = reader("QuestName").ToString()
                        dgv.Rows(rowIndex).Cells("Completed").Value = (reader("IsCompleted").ToString() = "1").ToString()
                        dgv.Rows(rowIndex).Cells("CompletionDate").Value = reader("CompletionDate").ToString()
                    End While
                End Using
            End Using
        End Using

        ' Perform export
        Dim expUtil As New ExportUtility(ExportUtility.ExportFormat.CSV)
        expUtil.Export(dgv, "QuestCompletion")
    End Sub

End Class

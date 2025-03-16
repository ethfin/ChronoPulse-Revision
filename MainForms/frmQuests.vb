Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class frmQuests

    Private flpQuests As FlowLayoutPanel

    Private Sub frmQuests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a FlowLayoutPanel (like flpDashboard) at runtime
        flpQuests = New FlowLayoutPanel With {
            .Name = "flpQuests",
            .FlowDirection = FlowDirection.TopDown,
            .WrapContents = False,
            .AutoScroll = True,
            .Size = New Size(560, 400),
            .Location = New Point(10, 10),
            .BackColor = Color.Transparent
        }
        Me.Controls.Add(flpQuests)

        GenerateFinancialQuests()
    End Sub

    Private Sub GenerateFinancialQuests()
        Dim monthlyExpenses As Decimal = 0D
        Dim monthlyIncome As Decimal = 0D

        Dim currentMonth As Integer = DateTime.Now.Month
        Dim currentYear As Integer = DateTime.Now.Year

        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()

            ' Sum up monthly expenses
            Dim expensesQuery As String =
            "SELECT IFNULL(SUM(Cost),0) FROM user_expenses " &
            "WHERE UserID=@UserID AND MONTH(date)=@Month AND YEAR(date)=@Year"

            Using cmdExpenses As New MySqlCommand(expensesQuery, connection)
                cmdExpenses.Parameters.AddWithValue("@UserID", AccountData.UserID)
                cmdExpenses.Parameters.AddWithValue("@Month", currentMonth)
                cmdExpenses.Parameters.AddWithValue("@Year", currentYear)
                monthlyExpenses = Convert.ToDecimal(cmdExpenses.ExecuteScalar())
            End Using

            ' Sum up monthly income
            Dim incomeQuery As String =
            "SELECT IFNULL(SUM(Amount),0) FROM user_income " &
            "WHERE UserID=@UserID AND MONTH(Date)=@Month AND YEAR(Date)=@Year"

            Using cmdIncome As New MySqlCommand(incomeQuery, connection)
                cmdIncome.Parameters.AddWithValue("@UserID", AccountData.UserID)
                cmdIncome.Parameters.AddWithValue("@Month", currentMonth)
                cmdIncome.Parameters.AddWithValue("@Year", currentYear)
                monthlyIncome = Convert.ToDecimal(cmdIncome.ExecuteScalar())
            End Using
        End Using

        Dim leftover As Decimal = monthlyIncome - monthlyExpenses
        Dim saveSuggestion As Decimal = Math.Round(leftover * 0.2D, 2)

        ' Check if the financial quest is already completed
        Dim questCompleted As Boolean = IsFinancialQuestAlreadyCompleted()

        ' Create a Guna2Panel for the quest
        Dim questPanel As New Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(540, 100),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10
        }

        ' Create a label for the quest text
        Dim questMessage As String =
        If(questCompleted,
           "Congratulations! You have completed the financial quest for this month. A new quest has been generated.",
           If(leftover > 0,
              $"Try saving at least ${saveSuggestion} this month!",
              "Your expenses exceed your income this month. Look for ways to reduce spending!"))

        Dim lblQuest As New Label With {
            .AutoSize = False,
            .Size = New Size(520, 40),
            .Location = New Point(10, 10),
            .ForeColor = Color.White,
            .Text = questMessage,
            .Font = New Font("Century Gothic", 10, FontStyle.Regular),
            .BackColor = Color.Transparent
        }
        questPanel.Controls.Add(lblQuest)

        ' Create a Guna2ProgressBar instead of standard ProgressBar
        Dim questProgress As New Guna2ProgressBar With {
            .Name = "pbQuestProgress",
            .Size = New Size(520, 20),
            .Location = New Point(10, 60),
            .Minimum = 0,
            .Maximum = 100,
            .BorderRadius = 5,
            .ForeColor = Color.FromArgb(94, 148, 255),
            .ProgressColor = Color.FromArgb(0, 192, 0),
            .ProgressColor2 = Color.FromArgb(0, 192, 0)
        }

        ' Calculate progress value and set visual cue
        If monthlyIncome > 0 Then
            Dim progressValue As Integer = 0
            If leftover > 0 Then
                progressValue = CInt(Math.Min((leftover / monthlyIncome) * 100, 100))
                questProgress.ProgressColor = Color.FromArgb(0, 192, 0)  ' Green for positive progress
            Else
                progressValue = 0
                questProgress.ProgressColor = Color.Red  ' Red for negative balance
            End If
            questProgress.Value = progressValue
        End If

        questPanel.Controls.Add(questProgress)

        ' Add the panel to the FlowLayoutPanel
        flpQuests.Controls.Add(questPanel)

        ' If the quest is completed, create a new quest based on the leftover amount
        If questCompleted Then
            CreateNewFinancialQuest(leftover)
        End If
    End Sub

    Private Sub CreateNewFinancialQuest(startingPoint As Decimal)
        Dim newSaveSuggestion As Decimal = Math.Round(startingPoint * 0.2D, 2)

        ' Create a Guna2Panel for the new quest
        Dim newQuestPanel As New Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(540, 100),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10
        }

        ' Create a label for the new quest text
        Dim newQuestMessage As String = $"Try saving at least ${newSaveSuggestion} this month!"

        Dim lblNewQuest As New Label With {
            .AutoSize = False,
            .Size = New Size(520, 40),
            .Location = New Point(10, 10),
            .ForeColor = Color.White,
            .Text = newQuestMessage,
            .Font = New Font("Century Gothic", 10, FontStyle.Regular),
            .BackColor = Color.Transparent
        }
        newQuestPanel.Controls.Add(lblNewQuest)

        ' Create a Guna2ProgressBar for the new quest
        Dim newQuestProgress As New Guna2ProgressBar With {
            .Name = "pbNewQuestProgress",
            .Size = New Size(520, 20),
            .Location = New Point(10, 60),
            .Minimum = 0,
            .Maximum = 100,
            .BorderRadius = 5,
            .ForeColor = Color.FromArgb(94, 148, 255),
            .ProgressColor = Color.FromArgb(0, 192, 0),
            .ProgressColor2 = Color.FromArgb(0, 192, 0),
            .Value = 0  ' Start at 0% since this is a new quest
        }

        newQuestPanel.Controls.Add(newQuestProgress)

        ' Add the new quest panel to the FlowLayoutPanel
        flpQuests.Controls.Add(newQuestPanel)
    End Sub

    Private Function IsFinancialQuestAlreadyCompleted() As Boolean
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM user_quests WHERE UserID=@uid AND Month=@month AND Year=@year AND QuestName='FinancialQuest'"
            Using cmd As New MySqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@uid", AccountData.UserID)
                cmd.Parameters.AddWithValue("@month", DateTime.Now.Month)
                cmd.Parameters.AddWithValue("@year", DateTime.Now.Year)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Private Sub MarkFinancialQuestAsCompleted()
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim sql As String = "INSERT INTO user_quests (UserID, QuestName, Month, Year, CompletedDate) VALUES (@uid, 'FinancialQuest', @month, @year, NOW())"
            Using cmd As New MySqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@uid", AccountData.UserID)
                cmd.Parameters.AddWithValue("@month", DateTime.Now.Month)
                cmd.Parameters.AddWithValue("@year", DateTime.Now.Year)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class

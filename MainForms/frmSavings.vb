Imports MySql.Data.MySqlClient

Public Class frmSavings

    Private _CurrentSavingsPanelName As String = Nothing

    Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavingsGoals()
    End Sub

    Private Sub LoadSavingsGoals()
        flpSavings.Controls.Clear()

        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT GoalID, GoalName, TargetAmount, CurrentAmount, TargetDate FROM savings_goals WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim goalID As Integer = CInt(reader("GoalID"))
                        Dim goalName As String = reader("GoalName").ToString()
                        Dim targetAmount As Decimal = CDec(reader("TargetAmount"))
                        Dim currentAmount As Decimal = CDec(reader("CurrentAmount"))
                        Dim targetDate As DateTime = CDate(reader("TargetDate"))

                        CreateSavingsPanel(goalID, goalName, targetAmount, currentAmount, targetDate)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub CreateSavingsPanel(goalID As Integer, goalName As String, targetAmount As Decimal, currentAmount As Decimal, targetDate As DateTime)
        Dim savingsPanel As New Guna.UI2.WinForms.Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(720, 60),
            .Name = "pnlSavings" & goalID.ToString(),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10
        }

        Dim lblGoalName As New Label With {
            .Name = "lblGoalName" & goalID.ToString(),
            .Text = goalName,
            .Location = New Point(10, 10),
            .AutoSize = False,
            .Size = New Size(110, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblGoalName.Click, Sub(sender, e) SelectSavingsPanel(savingsPanel, goalName, targetAmount, currentAmount, targetDate)
        savingsPanel.Controls.Add(lblGoalName)

        Dim lblTargetAmount As New Label With {
            .Name = "lblTargetAmount" & goalID.ToString(),
            .Text = "Target: $" & targetAmount.ToString("F2"),
            .Location = New Point(10, 30),
            .AutoSize = False,
            .Size = New Size(100, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblTargetAmount.Click, Sub(sender, e) SelectSavingsPanel(savingsPanel, goalName, targetAmount, currentAmount, targetDate)
        savingsPanel.Controls.Add(lblTargetAmount)

        Dim lblCurrentAmount As New Label With {
            .Name = "lblCurrentAmount" & goalID.ToString(),
            .Text = "Current: $" & currentAmount.ToString("F2"),
            .Location = New Point(130, 10),
            .AutoSize = False,
            .Size = New Size(200, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblCurrentAmount.Click, Sub(sender, e) SelectSavingsPanel(savingsPanel, goalName, targetAmount, currentAmount, targetDate)
        savingsPanel.Controls.Add(lblCurrentAmount)

        Dim lblTargetDate As New Label With {
            .Name = "lblTargetDate" & goalID.ToString(),
            .Text = "Target Date: " & targetDate.ToShortDateString(),
            .Location = New Point(130, 30),
            .AutoSize = False,
            .Size = New Size(120, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblTargetDate.Click, Sub(sender, e) SelectSavingsPanel(savingsPanel, goalName, targetAmount, currentAmount, targetDate)
        savingsPanel.Controls.Add(lblTargetDate)

        Dim deleteButton As New Button With {
            .Text = "Remove",
            .Size = New Size(80, 25),
            .Location = New Point(620, 25),
            .Name = "btnDeleteSavings" & goalID.ToString(),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular)
        }
        AddHandler deleteButton.Click, Sub(sender, e) DeleteSavings(goalID, savingsPanel)
        savingsPanel.Controls.Add(deleteButton)

        AddHandler savingsPanel.Click, Sub(sender, e) SelectSavingsPanel(savingsPanel, goalName, targetAmount, currentAmount, targetDate)

        flpSavings.Controls.Add(savingsPanel)
    End Sub

    Private Sub SelectSavingsPanel(selectedPanel As Guna.UI2.WinForms.Guna2Panel, goalName As String, targetAmount As Decimal, currentAmount As Decimal, targetDate As DateTime)
        For Each panel As Guna.UI2.WinForms.Guna2Panel In flpSavings.Controls.OfType(Of Guna.UI2.WinForms.Guna2Panel)()
            panel.FillColor = Color.FromArgb(13, 17, 64)
        Next

        selectedPanel.FillColor = Color.FromArgb(8, 6, 26)
        _CurrentSavingsPanelName = selectedPanel.Name

        PopulateFields(goalName, targetAmount, currentAmount, targetDate)
    End Sub

    Private Sub PopulateFields(goalName As String, targetAmount As Decimal, currentAmount As Decimal, targetDate As DateTime)
        txtGoalName.Text = goalName
        txtTargetAmount.Text = targetAmount.ToString()
        txtCurrentAmount.Text = currentAmount.ToString()
        dtpTargetDate.Value = targetDate
    End Sub

    Private Sub btnAddSavingsGoal_Click(sender As Object, e As EventArgs) Handles btnAddSavingsGoal.Click
        Dim goalName As String = txtGoalName.Text
        Dim targetAmount As Decimal
        Dim currentAmount As Decimal
        Dim targetDate As Date = dtpTargetDate.Value

        If Not Decimal.TryParse(txtTargetAmount.Text, targetAmount) Then
            MessageBox.Show("Please enter a valid target amount.")
            Return
        End If

        If Not Decimal.TryParse(txtCurrentAmount.Text, currentAmount) Then
            MessageBox.Show("Please enter a valid current amount.")
            Return
        End If

        If String.IsNullOrEmpty(goalName) Then
            MessageBox.Show("Please enter a goal name.")
            Return
        End If

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO savings_goals (UserID, GoalName, TargetAmount, CurrentAmount, TargetDate) VALUES (@UserID, @GoalName, @TargetAmount, @CurrentAmount, @TargetDate)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@GoalName", goalName)
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
                    cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
                    cmd.Parameters.AddWithValue("@TargetDate", targetDate)
                    cmd.ExecuteNonQuery()
                End Using

                UserExperience.AddXP(5)
                UserExperience.SaveUserExperience(AccountData.UserID)

                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If

                MessageBox.Show("Savings goal added successfully.")
                LoadSavingsGoals()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateSavingsGoal_Click(sender As Object, e As EventArgs) Handles btnUpdateSavingsGoal.Click
        Dim goalName As String = txtGoalName.Text
        Dim targetAmount As Decimal
        Dim currentAmount As Decimal
        Dim targetDate As Date = dtpTargetDate.Value

        If Not Decimal.TryParse(txtTargetAmount.Text, targetAmount) Then
            MessageBox.Show("Please enter a valid target amount.")
            Return
        End If

        If Not Decimal.TryParse(txtCurrentAmount.Text, currentAmount) Then
            MessageBox.Show("Please enter a valid current amount.")
            Return
        End If

        If String.IsNullOrEmpty(goalName) Then
            MessageBox.Show("Please enter a goal name.")
            Return
        End If

        If String.IsNullOrEmpty(_CurrentSavingsPanelName) Then
            MessageBox.Show("Please select a savings goal to update.")
            Return
        End If

        Dim goalID As Integer = Integer.Parse(_CurrentSavingsPanelName.Replace("pnlSavings", ""))

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "UPDATE savings_goals SET GoalName = @GoalName, TargetAmount = @TargetAmount, CurrentAmount = @CurrentAmount, TargetDate = @TargetDate WHERE GoalID = @GoalID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@GoalID", goalID)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@GoalName", goalName)
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
                    cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
                    cmd.Parameters.AddWithValue("@TargetDate", targetDate)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Savings goal updated successfully.")
                LoadSavingsGoals()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteSavings(goalID As Integer, panelToRemove As Panel)
        Dim confirm = MessageBox.Show("Remove savings goal?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "DELETE FROM savings_goals WHERE GoalID = @GoalID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@GoalID", goalID)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            flpSavings.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exporter As New ExportUtility(ExportUtility.ExportFormat.CSV)

        Dim dgv As New DataGridView()
        dgv.Columns.Add("GoalName", "Goal Name")
        dgv.Columns.Add("TargetAmount", "Target Amount")
        dgv.Columns.Add("CurrentAmount", "Current Amount")
        dgv.Columns.Add("TargetDate", "Target Date")

        For Each panel As Panel In flpSavings.Controls.OfType(Of Panel)()
            Dim lblGoalName As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblGoalName"))
            Dim lblTargetAmount As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblTargetAmount"))
            Dim lblCurrentAmount As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblCurrentAmount"))
            Dim lblTargetDate As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblTargetDate"))

            If lblGoalName IsNot Nothing AndAlso lblTargetAmount IsNot Nothing AndAlso lblCurrentAmount IsNot Nothing AndAlso lblTargetDate IsNot Nothing Then
                Dim goalName As String = lblGoalName.Text
                Dim targetAmount As String = lblTargetAmount.Text
                Dim currentAmount As String = lblCurrentAmount.Text
                Dim targetDate As String = lblTargetDate.Text

                dgv.Rows.Add(goalName, targetAmount, currentAmount, targetDate)
            End If
        Next

        exporter.Export(dgv, "SavingsGoals")
    End Sub

    'Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    dgvSavings.AllowUserToAddRows = False ' Prevents the extra empty row
    '    LoadSavingsGoals()
    'End Sub

    'Private Sub LoadSavingsGoals()
    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "SELECT GoalID, GoalName, TargetAmount, CurrentAmount, TargetDate FROM savings_goals WHERE UserID = @UserID"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                    Dim dt As New DataTable()
    '                    dt.Load(reader)
    '                    dgvSavings.DataSource = dt

    '                    ' Hide the GoalID column
    '                    If dgvSavings.Columns.Contains("GoalID") Then
    '                        dgvSavings.Columns("GoalID").Visible = False
    '                    End If
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnAddSavingsGoal_Click(sender As Object, e As EventArgs) Handles btnAddSavingsGoal.Click
    '    Dim goalName As String = txtGoalName.Text
    '    Dim targetAmount As Decimal
    '    Dim currentAmount As Decimal
    '    Dim targetDate As Date = dtpTargetDate.Value

    '    If Not Decimal.TryParse(txtTargetAmount.Text, targetAmount) Then
    '        MessageBox.Show("Please enter a valid target amount.")
    '        Return
    '    End If

    '    If Not Decimal.TryParse(txtCurrentAmount.Text, currentAmount) Then
    '        MessageBox.Show("Please enter a valid current amount.")
    '        Return
    '    End If

    '    If String.IsNullOrEmpty(goalName) Then
    '        MessageBox.Show("Please enter a goal name.")
    '        Return
    '    End If

    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "INSERT INTO savings_goals (UserID, GoalName, TargetAmount, CurrentAmount, TargetDate) VALUES (@UserID, @GoalName, @TargetAmount, @CurrentAmount, @TargetDate)"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                cmd.Parameters.AddWithValue("@GoalName", goalName)
    '                cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
    '                cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
    '                cmd.Parameters.AddWithValue("@TargetDate", targetDate)
    '                cmd.ExecuteNonQuery()
    '            End Using

    '            ' Add experience points
    '            UserExperience.AddXP(5)

    '            ' Save user experience data
    '            UserExperience.SaveUserExperience(AccountData.UserID)

    '            ' Update the experience bar in frmMain
    '            Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
    '            If mainForm IsNot Nothing Then
    '                mainForm.UpdateExperienceBar()

    '                ' Force the progress bar to refresh
    '                mainForm.prgExperience.Invalidate()
    '                mainForm.prgExperience.Refresh()
    '                mainForm.lblLevel.Refresh()
    '            End If

    '            MessageBox.Show("Savings goal added successfully.")
    '            LoadSavingsGoals() ' Refresh the DataGridView
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub dgvSavings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSavings.CellClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = dgvSavings.Rows(e.RowIndex)
    '        txtGoalName.Text = row.Cells("GoalName").Value.ToString()
    '        txtTargetAmount.Text = row.Cells("TargetAmount").Value.ToString()
    '        txtCurrentAmount.Text = row.Cells("CurrentAmount").Value.ToString()
    '        dtpTargetDate.Value = Convert.ToDateTime(row.Cells("TargetDate").Value)
    '    End If
    'End Sub

    'Private Sub btnUpdateSavingsGoal_Click(sender As Object, e As EventArgs) Handles btnUpdateSavingsGoal.Click
    '    Dim goalName As String = txtGoalName.Text
    '    Dim targetAmount As Decimal
    '    Dim currentAmount As Decimal
    '    Dim targetDate As Date = dtpTargetDate.Value

    '    If Not Decimal.TryParse(txtTargetAmount.Text, targetAmount) Then
    '        MessageBox.Show("Please enter a valid target amount.")
    '        Return
    '    End If

    '    If Not Decimal.TryParse(txtCurrentAmount.Text, currentAmount) Then
    '        MessageBox.Show("Please enter a valid current amount.")
    '        Return
    '    End If

    '    If String.IsNullOrEmpty(goalName) Then
    '        MessageBox.Show("Please enter a goal name.")
    '        Return
    '    End If

    '    If dgvSavings.SelectedRows.Count > 0 Then
    '        Dim selectedRow As DataGridViewRow = dgvSavings.SelectedRows(0)
    '        Dim goalID As Integer = Convert.ToInt32(selectedRow.Cells("GoalID").Value)

    '        Try
    '            Using connection As MySqlConnection = Common.createDBConnection()
    '                connection.Open()
    '                Dim query As String = "UPDATE savings_goals SET GoalName = @GoalName, TargetAmount = @TargetAmount, CurrentAmount = @CurrentAmount, TargetDate = @TargetDate WHERE GoalID = @GoalID AND UserID = @UserID"
    '                Using cmd As New MySqlCommand(query, connection)
    '                    cmd.Parameters.AddWithValue("@GoalID", goalID)
    '                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                    cmd.Parameters.AddWithValue("@GoalName", goalName)
    '                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
    '                    cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
    '                    cmd.Parameters.AddWithValue("@TargetDate", targetDate)
    '                    cmd.ExecuteNonQuery()
    '                End Using
    '            End Using
    '            MessageBox.Show("Savings goal updated successfully.")
    '            LoadSavingsGoals() ' Refresh the DataGridView
    '        Catch ex As Exception
    '            MessageBox.Show("An error occurred: " & ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Please select a savings goal to update.")
    '    End If
    'End Sub

    'Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    '    ' Create an instance of the ExportUtility class
    '    Dim exporter As New ExportUtility()

    '    ' Export the data
    '    exporter.ExportToCSV(dgvSavings, "Savings")
    'End Sub

    'Private Sub btnDeleteSavingsGoal_Click(sender As Object, e As EventArgs) Handles btnDeleteSavingsGoal.Click
    '    If dgvSavings.SelectedRows.Count > 0 Then
    '        ' Confirm before deleting
    '        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this savings goal?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '        If result = DialogResult.Yes Then
    '            Dim selectedRow As DataGridViewRow = dgvSavings.SelectedRows(0)
    '            Dim goalID As Integer = Convert.ToInt32(selectedRow.Cells("GoalID").Value)

    '            Try
    '                Using connection As MySqlConnection = Common.createDBConnection()
    '                    connection.Open()
    '                    Dim query As String = "DELETE FROM savings_goals WHERE GoalID = @GoalID AND UserID = @UserID"

    '                    Using cmd As New MySqlCommand(query, connection)
    '                        cmd.Parameters.AddWithValue("@GoalID", goalID)
    '                        cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                        cmd.ExecuteNonQuery()
    '                    End Using

    '                    MessageBox.Show("Savings goal deleted successfully.")
    '                    LoadSavingsGoals() ' Refresh the DataGridView

    '                    ' Clear the form fields after deletion
    '                    txtGoalName.Text = ""
    '                    txtTargetAmount.Text = ""
    '                    txtCurrentAmount.Text = ""
    '                    dtpTargetDate.Value = DateTime.Now
    '                End Using
    '            Catch ex As Exception
    '                MessageBox.Show("An error occurred: " & ex.Message)
    '            End Try
    '        End If
    '    Else
    '        MessageBox.Show("Please select a savings goal to delete.")
    '    End If
    'End Sub
End Class

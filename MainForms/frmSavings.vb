Imports MySql.Data.MySqlClient

Public Class frmSavings
    Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSavings.AllowUserToAddRows = False ' Prevents the extra empty row
        LoadSavingsGoals()
    End Sub

    Private Sub LoadSavingsGoals()
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT GoalID, GoalName, TargetAmount, CurrentAmount, TargetDate FROM savings_goals WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        dgvSavings.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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

                ' Add experience points
                UserExperience.AddXP(5)

                ' Save user experience data
                UserExperience.SaveUserExperience(AccountData.UserID)

                ' Update the experience bar in frmMain
                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()

                    ' Force the progress bar to refresh
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If

                MessageBox.Show("Savings goal added successfully.")
                LoadSavingsGoals() ' Refresh the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvSavings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSavings.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSavings.Rows(e.RowIndex)
            txtGoalName.Text = row.Cells("GoalName").Value.ToString()
            txtTargetAmount.Text = row.Cells("TargetAmount").Value.ToString()
            txtCurrentAmount.Text = row.Cells("CurrentAmount").Value.ToString()
            dtpTargetDate.Value = Convert.ToDateTime(row.Cells("TargetDate").Value)
        End If
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

        If dgvSavings.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvSavings.SelectedRows(0)
            Dim goalID As Integer = Convert.ToInt32(selectedRow.Cells("GoalID").Value)

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
                End Using
                MessageBox.Show("Savings goal updated successfully.")
                LoadSavingsGoals() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a savings goal to update.")
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create an instance of the ExportUtility class
        Dim exporter As New ExportUtility()

        ' Export the data
        exporter.ExportToCSV(dgvSavings, "Savings")
    End Sub

End Class

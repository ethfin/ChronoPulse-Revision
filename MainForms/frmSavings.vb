Imports MySql.Data.MySqlClient

Public Class frmSavings
    Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSavingsGoals()
    End Sub

    Private Sub LoadSavingsGoals()
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT GoalName, TargetAmount, CurrentAmount, TargetDate FROM savings_goals WHERE UserID = @UserID"
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
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming AccountData.UserID holds the current user's ID
                    cmd.Parameters.AddWithValue("@GoalName", goalName)
                    cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)
                    cmd.Parameters.AddWithValue("@CurrentAmount", currentAmount)
                    cmd.Parameters.AddWithValue("@TargetDate", targetDate)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Savings goal added successfully.")
            LoadSavingsGoals() ' Refresh the DataGridView
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
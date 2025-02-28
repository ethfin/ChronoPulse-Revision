Imports MySql.Data.MySqlClient

Public Class frmIncome
    Private Sub btnAddIncome_Click(sender As Object, e As EventArgs) Handles btnAddIncome.Click
        Dim source As String = txtSource.Text
        Dim amount As Decimal
        Dim incomeDate As Date = dtpDate.Value

        If Not Decimal.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If String.IsNullOrEmpty(source) Then
            MessageBox.Show("Please enter a source.")
            Return
        End If

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO user_income (UserID, Source, Amount, Date) VALUES (@UserID, @Source, @Amount, @Date)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming AccountData.UserID holds the current user's ID
                    cmd.Parameters.AddWithValue("@Source", source)
                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@Date", incomeDate)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Income added successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
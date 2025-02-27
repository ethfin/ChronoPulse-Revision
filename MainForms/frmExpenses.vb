Imports MySql.Data.MySqlClient

Public Class frmExpenses
    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        Dim item As String = txtItem.Text
        Dim cost As Decimal
        Dim category As String = txtCategory.Text
        Dim description As String = txtDescription.Text

        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        If String.IsNullOrEmpty(item) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO user_expenses (UserID, Item, Cost, Category, Description, date) VALUES (@UserID, @Item, @Cost, @Category, @Description, @Date)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming AccountData.UserID holds the current user's ID
                    cmd.Parameters.AddWithValue("@Item", item)
                    cmd.Parameters.AddWithValue("@Cost", cost)
                    cmd.Parameters.AddWithValue("@Category", category)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Expense added successfully.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
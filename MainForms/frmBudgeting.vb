Imports MySql.Data.MySqlClient

Public Class frmBudgeting
    Private Sub frmBudgeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadBudgets()
        dgvBudgets.AllowUserToAddRows = False
        dgvBudgets.ReadOnly = True
    End Sub

    Private Sub LoadCategories()
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT CategoryID, CategoryName FROM categories"
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        cmbCategory.DataSource = dt
                        cmbCategory.DisplayMember = "CategoryName"
                        cmbCategory.ValueMember = "CategoryID"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadBudgets()
        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "SELECT BudgetID, CategoryID, Amount, StartDate, EndDate, Description FROM budgets WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        dgvBudgets.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddBudget_Click(sender As Object, e As EventArgs) Handles btnAddBudget.Click
        Dim categoryID As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
        Dim amount As Decimal
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value
        Dim description As String = txtDescription.Text

        If Not Decimal.TryParse(txtBudgetAmount.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "INSERT INTO budgets (UserID, CategoryID, Amount, StartDate, EndDate, Description) VALUES (@UserID, @CategoryID, @Amount, @StartDate, @EndDate, @Description)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID)
                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Budget added successfully.")
            LoadBudgets() ' Refresh the DataGridView
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvBudgets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBudgets.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBudgets.Rows(e.RowIndex)
            cmbCategory.SelectedValue = row.Cells("CategoryID").Value
            txtBudgetAmount.Text = row.Cells("Amount").Value.ToString()
            dtpStartDate.Value = Convert.ToDateTime(row.Cells("StartDate").Value)
            dtpEndDate.Value = Convert.ToDateTime(row.Cells("EndDate").Value)
            txtDescription.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdateBudget_Click(sender As Object, e As EventArgs) Handles btnUpdateBudget.Click
        Dim categoryID As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
        Dim amount As Decimal
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value
        Dim description As String = txtDescription.Text

        If Not Decimal.TryParse(txtBudgetAmount.Text, amount) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If dgvBudgets.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBudgets.SelectedRows(0)
            Dim budgetID As Integer = Convert.ToInt32(selectedRow.Cells("BudgetID").Value)

            Try
                Using connection As MySqlConnection = Common.createDBConnection()
                    connection.Open()
                    Dim query As String = "UPDATE budgets SET CategoryID = @CategoryID, Amount = @Amount, StartDate = @StartDate, EndDate = @EndDate, Description = @Description WHERE BudgetID = @BudgetID AND UserID = @UserID"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@BudgetID", budgetID)
                        cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID)
                        cmd.Parameters.AddWithValue("@Amount", amount)
                        cmd.Parameters.AddWithValue("@StartDate", startDate)
                        cmd.Parameters.AddWithValue("@EndDate", endDate)
                        cmd.Parameters.AddWithValue("@Description", description)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Budget updated successfully.")
                LoadBudgets() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a budget to update.")
        End If
    End Sub
End Class

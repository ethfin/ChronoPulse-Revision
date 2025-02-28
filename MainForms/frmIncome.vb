Imports MySql.Data.MySqlClient

Public Class frmIncome
    Private Sub frmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIncomeData()
    End Sub

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
            LoadIncomeData() ' Refresh the DataGridView after adding a new income
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadIncomeData()
        Dim query As String = "SELECT Source AS SOURCE, CONCAT('$', Amount) AS AMOUNT, DATE_FORMAT(Date, '%m/%d/%Y') AS DATE FROM user_income WHERE UserID = @UserID"
        Dim dt As New DataTable()

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        dgIncome.DataSource = dt
        dgIncome.AllowUserToAddRows = False
        dgIncome.BackgroundColor = Color.White
        dgIncome.BorderStyle = BorderStyle.None
        dgIncome.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
        dgIncome.DefaultCellStyle.SelectionForeColor = Color.Black
        dgIncome.EnableHeadersVisualStyles = False
        dgIncome.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgIncome.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgIncome.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        dgIncome.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        dgIncome.RowHeadersVisible = False
        dgIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgIncome.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
        dgIncome.AllowUserToAddRows = False
        dgIncome.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub
End Class
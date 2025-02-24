Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private Sub LoadUserExpenses()
        Dim query As String = "SELECT Item AS ITEM, CONCAT('$', Cost) AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
        Dim dt As New DataTable()

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming Username is the UserID
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        dgExpenses.DataSource = dt
        dgExpenses.DataSource = dt
        dgExpenses.AllowUserToAddRows = False
        dgExpenses.BackgroundColor = Color.White
        dgExpenses.BorderStyle = BorderStyle.None
        dgExpenses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
        dgExpenses.DefaultCellStyle.SelectionForeColor = Color.Black
        dgExpenses.EnableHeadersVisualStyles = False
        dgExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgExpenses.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        dgExpenses.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        dgExpenses.RowHeadersVisible = False
        dgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
        dgExpenses.AllowUserToAddRows = False
        dgExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUserExpenses()
    End Sub
End Class
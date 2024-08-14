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

        dgvExpenses.DataSource = dt
        dgvExpenses.AllowUserToAddRows = False
        dgvExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUserExpenses()
    End Sub
End Class
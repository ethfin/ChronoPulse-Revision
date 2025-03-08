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
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@Source", source)
                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@Date", incomeDate)
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

                MessageBox.Show("Income added successfully.")
                LoadIncomeData() ' Refresh the DataGridView
            End Using
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create an instance of the ExportUtility class
        Dim exporter As New ExportUtility()

        ' Export the data
        exporter.ExportToCSV(dgIncome, "Income")
    End Sub
End Class
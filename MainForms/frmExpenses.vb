Imports MySql.Data.MySqlClient

Public Class frmExpenses

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpenses()
        LoadCategories()
    End Sub

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        Dim item As String = txtItem.Text
        Dim cost As Decimal
        Dim category As String = cmbCategory.Text
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
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@Item", item)
                    cmd.Parameters.AddWithValue("@Cost", cost)
                    cmd.Parameters.AddWithValue("@Category", category)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using

                ' Check if this is the user's first expense
                Dim countQuery As String = "SELECT COUNT(*) FROM user_expenses WHERE UserID = @UserID"
                Using countCmd As New MySqlCommand(countQuery, connection)
                    countCmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    Dim count As Integer = Convert.ToInt32(countCmd.ExecuteScalar())
                    If count = 1 Then
                        ' Unlock the "First Expense" achievement
                        Dim achievement = AchievementManager._achievements.Find(Function(a) a.ID = 4)
                        If achievement IsNot Nothing Then
                            achievement.Unlock()
                        End If
                    End If
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

                MessageBox.Show("Expense added successfully.")
                LoadExpenses() ' Refresh the DataGridView after adding a new expense
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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

    Private Sub LoadExpenses()
        Dim query As String = "SELECT Item AS ITEM, CONCAT('$', Cost) AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create an instance of the ExportUtility class
        Dim exporter As New ExportUtility()

        ' Export the data
        exporter.ExportToCSV(dgExpenses, "Expenses")
    End Sub
End Class
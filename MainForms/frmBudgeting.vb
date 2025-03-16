Imports MySql.Data.MySqlClient

Public Class frmBudgeting

    Private _CurrentBudgetPanelName As String = Nothing

    Private Sub frmBudgeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBudgets()
        LoadCategories()
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
        FlowLayoutPanel1.Controls.Clear()

        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT b.BudgetID, b.CategoryID, c.CategoryName, b.Description, b.Amount, b.StartDate, b.EndDate " &
                                  "FROM budgets b " &
                                  "JOIN categories c ON b.CategoryID = c.CategoryID " &
                                  "WHERE b.UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim budgetID As Integer = CInt(reader("BudgetID"))
                        Dim categoryID As Integer = CInt(reader("CategoryID"))
                        Dim categoryName As String = reader("CategoryName").ToString()
                        Dim description As String = reader("Description").ToString()
                        Dim amount As Decimal = CDec(reader("Amount"))
                        Dim startDate As DateTime = CDate(reader("StartDate"))
                        Dim endDate As DateTime = CDate(reader("EndDate"))

                        CreateBudgetPanel(budgetID, categoryID, categoryName, description, amount, startDate, endDate)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub CreateBudgetPanel(budgetID As Integer, categoryID As Integer, categoryName As String, description As String, amount As Decimal, startDate As DateTime, endDate As DateTime)
        Dim budgetPanel As New Guna.UI2.WinForms.Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(720, 60),
            .Name = "pnlBudget" & budgetID.ToString(),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10
        }

        Dim lblDescription As New Label With {
            .Name = "lblDescription" & budgetID.ToString(),
            .Text = description,
            .Location = New Point(10, 10),
            .AutoSize = False,
            .Size = New Size(110, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblDescription.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)
        budgetPanel.Controls.Add(lblDescription)

        Dim lblAmount As New Label With {
            .Name = "lblAmount" & budgetID.ToString(),
            .Text = "$" & amount.ToString("F2"),
            .Location = New Point(10, 30),
            .AutoSize = False,
            .Size = New Size(100, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblAmount.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)
        budgetPanel.Controls.Add(lblAmount)

        Dim lblCategory As New Label With {
            .Name = "lblCategory" & budgetID.ToString(),
            .Text = "Category: " & categoryName,
            .Location = New Point(130, 10),
            .AutoSize = False,
            .Size = New Size(200, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblCategory.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)
        budgetPanel.Controls.Add(lblCategory)

        Dim lblStartDate As New Label With {
            .Name = "lblStartDate" & budgetID.ToString(),
            .Text = "Start Date: " & startDate.ToShortDateString(),
            .Location = New Point(130, 30),
            .AutoSize = False,
            .Size = New Size(150, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblStartDate.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)
        budgetPanel.Controls.Add(lblStartDate)

        Dim lblEndDate As New Label With {
            .Name = "lblEndDate" & budgetID.ToString(),
            .Text = "End Date: " & endDate.ToShortDateString(),
            .Location = New Point(300, 30),
            .AutoSize = False,
            .Size = New Size(150, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblEndDate.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)
        budgetPanel.Controls.Add(lblEndDate)

        Dim deleteButton As New Button With {
            .Text = "Remove",
            .Size = New Size(80, 25),
            .Location = New Point(620, 25),
            .Name = "btnDeleteBudget" & budgetID.ToString(),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular)
        }
        AddHandler deleteButton.Click, Sub(sender, e) DeleteBudget(budgetID, budgetPanel)
        budgetPanel.Controls.Add(deleteButton)

        AddHandler budgetPanel.Click, Sub(sender, e) SelectBudgetPanel(budgetPanel, categoryID, categoryName, description, amount, startDate, endDate)

        FlowLayoutPanel1.Controls.Add(budgetPanel)
    End Sub

    Private Sub SelectBudgetPanel(selectedPanel As Guna.UI2.WinForms.Guna2Panel, categoryID As Integer, categoryName As String, description As String, amount As Decimal, startDate As DateTime, endDate As DateTime)
        For Each panel As Guna.UI2.WinForms.Guna2Panel In FlowLayoutPanel1.Controls.OfType(Of Guna.UI2.WinForms.Guna2Panel)()
            panel.FillColor = Color.FromArgb(13, 17, 64)
        Next

        selectedPanel.FillColor = Color.FromArgb(8, 6, 26)
        _CurrentBudgetPanelName = selectedPanel.Name

        PopulateFields(categoryID, description, amount, startDate, endDate)
    End Sub

    Private Sub PopulateFields(categoryID As Integer, description As String, amount As Decimal, startDate As DateTime, endDate As DateTime)
        cmbCategory.SelectedValue = categoryID
        txtDescription.Text = description
        txtBudgetAmount.Text = amount.ToString()
        dtpStartDate.Value = startDate
        dtpEndDate.Value = endDate
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

                UserExperience.AddXP(5)
                UserExperience.SaveUserExperience(AccountData.UserID)

                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If

                MessageBox.Show("Budget added successfully.")
                LoadBudgets()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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

        If String.IsNullOrEmpty(_CurrentBudgetPanelName) Then
            MessageBox.Show("Please select a budget to update.")
            Return
        End If

        Dim budgetID As Integer = Integer.Parse(_CurrentBudgetPanelName.Replace("pnlBudget", ""))

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
                MessageBox.Show("Budget updated successfully.")
                LoadBudgets()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteBudget(budgetID As Integer, panelToRemove As Panel)
        Dim confirm = MessageBox.Show("Remove budget?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "DELETE FROM budgets WHERE BudgetID = @BudgetID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@BudgetID", budgetID)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            FlowLayoutPanel1.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exporter As New ExportUtility(ExportUtility.ExportFormat.CSV)

        Dim dgv As New DataGridView()
        dgv.Columns.Add("Description", "Description")
        dgv.Columns.Add("Amount", "Amount")
        dgv.Columns.Add("Category", "Category")
        dgv.Columns.Add("StartDate", "Start Date")
        dgv.Columns.Add("EndDate", "End Date")

        For Each panel As Panel In FlowLayoutPanel1.Controls.OfType(Of Panel)()
            Dim lblDescription As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblDescription"))
            Dim lblAmount As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblAmount"))
            Dim lblCategory As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblCategory"))
            Dim lblStartDate As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblStartDate"))
            Dim lblEndDate As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblEndDate"))

            If lblDescription IsNot Nothing AndAlso lblAmount IsNot Nothing AndAlso lblCategory IsNot Nothing AndAlso lblStartDate IsNot Nothing AndAlso lblEndDate IsNot Nothing Then
                Dim description As String = lblDescription.Text
                Dim amount As String = lblAmount.Text
                Dim category As String = lblCategory.Text
                Dim startDate As String = lblStartDate.Text
                Dim endDate As String = lblEndDate.Text

                dgv.Rows.Add(description, amount, category, startDate, endDate)
            End If
        Next

        exporter.Export(dgv, "Budgets")
    End Sub

    'Private Sub frmBudgeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadCategories()
    '    LoadBudgets()
    '    dgvBudgets.AllowUserToAddRows = False
    '    dgvBudgets.ReadOnly = True
    'End Sub

    'Private Sub LoadCategories()
    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "SELECT CategoryID, CategoryName FROM categories"
    '            Using cmd As New MySqlCommand(query, connection)
    '                Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                    Dim dt As New DataTable()
    '                    dt.Load(reader)
    '                    cmbCategory.DataSource = dt
    '                    cmbCategory.DisplayMember = "CategoryName"
    '                    cmbCategory.ValueMember = "CategoryID"
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub LoadBudgets()
    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "SELECT BudgetID, CategoryID, Description, Amount, StartDate, EndDate FROM budgets WHERE UserID = @UserID"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                    Dim dt As New DataTable()
    '                    dt.Load(reader)
    '                    dgvBudgets.DataSource = dt

    '                    ' Hide the ID columns
    '                    dgvBudgets.Columns("BudgetID").Visible = False
    '                    dgvBudgets.Columns("CategoryID").Visible = False
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnAddBudget_Click(sender As Object, e As EventArgs) Handles btnAddBudget.Click
    '    Dim categoryID As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
    '    Dim amount As Decimal
    '    Dim startDate As Date = dtpStartDate.Value
    '    Dim endDate As Date = dtpEndDate.Value
    '    Dim description As String = txtDescription.Text

    '    If Not Decimal.TryParse(txtBudgetAmount.Text, amount) Then
    '        MessageBox.Show("Please enter a valid amount.")
    '        Return
    '    End If

    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "INSERT INTO budgets (UserID, CategoryID, Amount, StartDate, EndDate, Description) VALUES (@UserID, @CategoryID, @Amount, @StartDate, @EndDate, @Description)"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                cmd.Parameters.AddWithValue("@CategoryID", categoryID)
    '                cmd.Parameters.AddWithValue("@Amount", amount)
    '                cmd.Parameters.AddWithValue("@StartDate", startDate)
    '                cmd.Parameters.AddWithValue("@EndDate", endDate)
    '                cmd.Parameters.AddWithValue("@Description", description)
    '                cmd.ExecuteNonQuery()
    '            End Using

    '            ' Add experience points
    '            UserExperience.AddXP(5)

    '            ' Save user experience data
    '            UserExperience.SaveUserExperience(AccountData.UserID)

    '            ' Update the experience bar in frmMain
    '            Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
    '            If mainForm IsNot Nothing Then
    '                mainForm.UpdateExperienceBar()

    '                ' Force the progress bar to refresh
    '                mainForm.prgExperience.Invalidate()
    '                mainForm.prgExperience.Refresh()
    '                mainForm.lblLevel.Refresh()
    '            End If

    '            MessageBox.Show("Budget added successfully.")
    '            LoadBudgets() ' Refresh the DataGridView
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub dgvBudgets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBudgets.CellClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = dgvBudgets.Rows(e.RowIndex)
    '        cmbCategory.SelectedValue = row.Cells("CategoryID").Value
    '        txtBudgetAmount.Text = row.Cells("Amount").Value.ToString()
    '        dtpStartDate.Value = Convert.ToDateTime(row.Cells("StartDate").Value)
    '        dtpEndDate.Value = Convert.ToDateTime(row.Cells("EndDate").Value)
    '        txtDescription.Text = row.Cells("Description").Value.ToString()
    '    End If
    'End Sub

    'Private Sub btnUpdateBudget_Click(sender As Object, e As EventArgs) Handles btnUpdateBudget.Click
    '    Dim categoryID As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
    '    Dim amount As Decimal
    '    Dim startDate As Date = dtpStartDate.Value
    '    Dim endDate As Date = dtpEndDate.Value
    '    Dim description As String = txtDescription.Text

    '    If Not Decimal.TryParse(txtBudgetAmount.Text, amount) Then
    '        MessageBox.Show("Please enter a valid amount.")
    '        Return
    '    End If

    '    If dgvBudgets.SelectedRows.Count > 0 Then
    '        Dim selectedRow As DataGridViewRow = dgvBudgets.SelectedRows(0)
    '        Dim budgetID As Integer = Convert.ToInt32(selectedRow.Cells("BudgetID").Value)

    '        Try
    '            Using connection As MySqlConnection = Common.createDBConnection()
    '                connection.Open()
    '                Dim query As String = "UPDATE budgets SET CategoryID = @CategoryID, Amount = @Amount, StartDate = @StartDate, EndDate = @EndDate, Description = @Description WHERE BudgetID = @BudgetID AND UserID = @UserID"
    '                Using cmd As New MySqlCommand(query, connection)
    '                    cmd.Parameters.AddWithValue("@BudgetID", budgetID)
    '                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                    cmd.Parameters.AddWithValue("@CategoryID", categoryID)
    '                    cmd.Parameters.AddWithValue("@Amount", amount)
    '                    cmd.Parameters.AddWithValue("@StartDate", startDate)
    '                    cmd.Parameters.AddWithValue("@EndDate", endDate)
    '                    cmd.Parameters.AddWithValue("@Description", description)
    '                    cmd.ExecuteNonQuery()
    '                End Using
    '            End Using
    '            MessageBox.Show("Budget updated successfully.")
    '            LoadBudgets() ' Refresh the DataGridView
    '        Catch ex As Exception
    '            MessageBox.Show("An error occurred: " & ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Please select a budget to update.")
    '    End If
    'End Sub

    'Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    '    ' Create an instance of the ExportUtility class
    '    Dim exporter As New ExportUtility()

    '    ' Export the data
    '    exporter.ExportToCSV(dgvBudgets, "Budget")
    'End Sub

    'Private Sub btnDeleteBudget_Click(sender As Object, e As EventArgs) Handles btnDeleteBudget.Click
    '    If dgvBudgets.SelectedRows.Count > 0 Then
    '        ' Confirm before deleting
    '        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this budget?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '        If result = DialogResult.Yes Then
    '            Dim selectedRow As DataGridViewRow = dgvBudgets.SelectedRows(0)
    '            Dim budgetID As Integer = Convert.ToInt32(selectedRow.Cells("BudgetID").Value)

    '            Try
    '                Using connection As MySqlConnection = Common.createDBConnection()
    '                    connection.Open()
    '                    Dim query As String = "DELETE FROM budgets WHERE BudgetID = @BudgetID AND UserID = @UserID"

    '                    Using cmd As New MySqlCommand(query, connection)
    '                        cmd.Parameters.AddWithValue("@BudgetID", budgetID)
    '                        cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                        cmd.ExecuteNonQuery()
    '                    End Using

    '                    MessageBox.Show("Budget deleted successfully.")
    '                    LoadBudgets() ' Refresh the DataGridView

    '                    ' Clear the form fields after deletion
    '                    cmbCategory.SelectedIndex = -1
    '                    txtBudgetAmount.Text = ""
    '                    txtDescription.Text = ""
    '                    dtpStartDate.Value = DateTime.Now
    '                    dtpEndDate.Value = DateTime.Now
    '                End Using
    '            Catch ex As Exception
    '                MessageBox.Show("An error occurred: " & ex.Message)
    '            End Try
    '        End If
    '    Else
    '        MessageBox.Show("Please select a budget to delete.")
    '    End If
    'End Sub
End Class

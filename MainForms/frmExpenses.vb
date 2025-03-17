Imports MySql.Data.MySqlClient
Imports Guna.UI.WinForms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmExpenses

    Private _CurrentExpensePanelName As String = Nothing
    Private _ExpensePanelsAddedCount As Integer = 0

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpExpenses.FlowDirection = FlowDirection.TopDown
        flpExpenses.WrapContents = False  ' Add this line
        flpExpenses.AutoScroll = True     ' Ensure this is set to True
        flpExpenses.AutoScrollMinSize = New Size(0, 0)  ' Reset this if needed
        dtpDate.Value = DateTime.Now    ' Set the DateTimePicker to the current date
        LoadExpenses()
        LoadCategories()
        LoadPieChart() ' Load the pie chart when the form loads
    End Sub

    Private Sub LoadPieChart()
        Dim expensesData As DataTable = GetCurrentMonthExpensesByCategory()
        PopulatePieChart(expensesData)
    End Sub

    Private Sub PopulatePieChart(expensesData As DataTable)
        chrtPie.Series.Clear()
        Dim pieSeries As New Series("Expenses")
        pieSeries.ChartType = SeriesChartType.Pie

        Dim totalExpenses As Decimal = expensesData.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TotalCost"))

        For Each row As DataRow In expensesData.Rows
            Dim category As String = row("Category").ToString()
            Dim totalCost As Decimal = Convert.ToDouble(row("TotalCost"))
            Dim percentage As Decimal = (totalCost / totalExpenses) * 100
            Dim point As DataPoint = New DataPoint() With {
            .AxisLabel = $"{category} ({percentage:F2}%)",
            .YValues = New Double() {totalCost}
        }
            pieSeries.Points.Add(point)
        Next

        chrtPie.Series.Add(pieSeries)

        ' Configure the legend
        chrtPie.Legends.Clear()
        Dim legend As New Legend()
        legend.Docking = Docking.Bottom
        legend.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        legend.ForeColor = Color.White
        legend.BackColor = Color.Transparent
        chrtPie.Legends.Add(legend)

        ' Set the background color of the chart area to transparent
        chrtPie.ChartAreas(0).BackColor = Color.Transparent

        ' Set the font style and color for the chart series
        pieSeries.Font = New Font("Century Gothic", 10, FontStyle.Regular)
        pieSeries.LabelForeColor = Color.White

        ' Hide labels inside the pie chart
        pieSeries.IsValueShownAsLabel = False
        pieSeries("PieLabelStyle") = "Disabled"

        ' Set the legend text to display the category names with percentages
        For Each point As DataPoint In pieSeries.Points
            point.LegendText = point.AxisLabel
        Next

        ' Add a title to the chart
        chrtPie.Titles.Clear()
        Dim title As New Title("Current Month")
        title.Font = New Font("Century Gothic", 14, FontStyle.Bold)
        title.ForeColor = Color.White
        chrtPie.Titles.Add(title)
    End Sub


    Private Function GetCurrentMonthExpensesByCategory() As DataTable
        Dim dt As New DataTable()
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT Category, SUM(Cost) AS TotalCost FROM user_expenses WHERE UserID = @UserID AND MONTH(`Date`) = MONTH(CURRENT_DATE()) AND YEAR(`Date`) = YEAR(CURRENT_DATE()) GROUP BY Category"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub btnAddExpense_Click(sender As Object, e As EventArgs) Handles btnAddExpense.Click
        Dim item As String = txtItem.Text
        Dim cost As Decimal
        Dim category As String = cmbCategory.Text
        Dim description As String = txtDescription.Text
        Dim expenseDate As DateTime = dtpDate.Value

        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        If String.IsNullOrEmpty(item) OrElse String.IsNullOrEmpty(category) Then
            MessageBox.Show("Please fill in Item and Cost fields.")
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
                    cmd.Parameters.AddWithValue("@Date", expenseDate)
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
        ' Clear any existing controls
        flpExpenses.Controls.Clear()

        ' Query the database for expenses
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()

            Dim query As String = "SELECT expense_id, Item, Cost, Category, Description, date " &
                             "FROM user_expenses WHERE UserID = @UserID ORDER BY date DESC"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim expensesByMonth As New Dictionary(Of String, List(Of Dictionary(Of String, Object)))()

                    While reader.Read()
                        Dim expense As New Dictionary(Of String, Object) From {
                       {"expense_id", CInt(reader("expense_id"))},
                       {"Item", reader("Item").ToString()},
                       {"Cost", CDec(reader("Cost"))},
                       {"Category", reader("Category").ToString()},
                       {"Description", reader("Description").ToString()},
                       {"date", CDate(reader("date"))}
                   }

                        Dim monthKey As String = CDate(expense("date")).ToString("MMMM yyyy")

                        If Not expensesByMonth.ContainsKey(monthKey) Then
                            expensesByMonth(monthKey) = New List(Of Dictionary(Of String, Object))()
                        End If

                        expensesByMonth(monthKey).Add(expense)
                    End While

                    For Each monthKey As String In expensesByMonth.Keys
                        ' Create a header panel for the month
                        Dim monthHeaderPanel As New Guna.UI2.WinForms.Guna2Panel With {
                       .FillColor = Color.FromArgb(173, 181, 211),
                       .Size = New Size(720, 60),
                       .Name = "pnlMonthHeader" & monthKey,
                       .BorderStyle = BorderStyle.FixedSingle,
                       .BorderRadius = 10
                   }

                        ' Add a label to display the month
                        Dim lblMonth As New Label With {
                       .Name = "lblMonth" & monthKey,
                       .Text = monthKey,
                       .Location = New Point((monthHeaderPanel.Width - 700) / 2, 5), ' Center the label
                       .AutoSize = False,
                       .Size = New Size(700, 50),
                       .ForeColor = Color.Black,
                       .Font = New Font("Century Gothic", 20, FontStyle.Bold),
                       .TextAlign = ContentAlignment.MiddleCenter,
                       .BackColor = Color.Transparent
                   }
                        monthHeaderPanel.Controls.Add(lblMonth)

                        ' Add the month header panel to the FlowLayoutPanel
                        flpExpenses.Controls.Add(monthHeaderPanel)

                        ' Add the expenses for the month
                        For Each expense As Dictionary(Of String, Object) In expensesByMonth(monthKey)
                            CreateExpensePanel(CInt(expense("expense_id")), expense("Item").ToString(), CDec(expense("Cost")), expense("Category").ToString(), expense("Description").ToString(), CDate(expense("date")))
                        Next
                    Next
                End Using
            End Using
        End Using
    End Sub

    Private Sub CreateExpensePanel(expenseID As Integer, item As String, cost As Decimal,
                               category As String, description As String, expenseDate As DateTime)

        Dim expensePanel As New Guna.UI2.WinForms.Guna2Panel With {
           .FillColor = Color.FromArgb(13, 17, 64),
           .Size = New Size(720, 60),
           .Name = "pnlExpense" & expenseID.ToString(),
           .BorderStyle = BorderStyle.FixedSingle,
           .BorderRadius = 10
        }

        ' Example labels for displaying expense data
        Dim lblItem As New Label With {
           .Name = "lblItem" & expenseID.ToString(),
           .Text = item,
           .Location = New Point(10, 10),
           .AutoSize = False,
           .Size = New Size(110, 20),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
           .TextAlign = ContentAlignment.MiddleLeft,
           .BackColor = Color.Transparent
       }
        AddHandler lblItem.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)
        expensePanel.Controls.Add(lblItem)

        Dim lblCost As New Label With {
           .Name = "lblCost" & expenseID.ToString(),
           .Text = "Cost: " & cost.ToString("F2"),
           .Location = New Point(10, 30),
           .AutoSize = False,
           .Size = New Size(100, 20),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
           .TextAlign = ContentAlignment.MiddleLeft,
           .BackColor = Color.Transparent
       }
        AddHandler lblCost.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)
        expensePanel.Controls.Add(lblCost)

        Dim lblCategory As New Label With {
           .Name = "lblCategory" & expenseID.ToString(),
           .Text = "Category: " & category,
           .Location = New Point(130, 10),
           .AutoSize = False,
           .Size = New Size(200, 20),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
           .TextAlign = ContentAlignment.MiddleLeft,
           .BackColor = Color.Transparent
       }
        AddHandler lblCategory.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)
        expensePanel.Controls.Add(lblCategory)

        Dim lblDate As New Label With {
           .Name = "lblDate" & expenseID.ToString(),
           .Text = "Date: " & expenseDate.ToShortDateString(),
           .Location = New Point(130, 30),
           .AutoSize = False,
           .Size = New Size(120, 20),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
           .TextAlign = ContentAlignment.MiddleLeft,
           .BackColor = Color.Transparent
       }
        AddHandler lblDate.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)
        expensePanel.Controls.Add(lblDate)

        ' Optional: display description (could be in a separate label or tooltip)
        Dim lblDescription As New Label With {
           .Name = "lblDescription" & expenseID.ToString(),
           .Text = "Note: " & description,
           .Location = New Point(360, 10),
           .AutoSize = False,
           .Size = New Size(200, 20),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
           .TextAlign = ContentAlignment.MiddleLeft,
           .BackColor = Color.Transparent
       }
        AddHandler lblDescription.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)
        expensePanel.Controls.Add(lblDescription)

        ' Create a delete button
        Dim deleteButton As New Button With {
           .Text = "Remove",
           .Size = New Size(80, 25),
           .Location = New Point(620, 25),
           .Name = "btnDeleteExpense" & expenseID.ToString(),
           .ForeColor = Color.White,
           .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular)
       }
        AddHandler deleteButton.Click, Sub(sender, e) DeleteExpense(expenseID, expensePanel)
        expensePanel.Controls.Add(deleteButton)

        ' Add click event handler to the panel
        AddHandler expensePanel.Click, Sub(sender, e) SelectExpensePanel(expensePanel, item, cost, category, description, expenseDate)

        ' Add this panel to the FlowLayoutPanel
        flpExpenses.Controls.Add(expensePanel)
    End Sub

    Private Sub SelectExpensePanel(selectedPanel As Guna.UI2.WinForms.Guna2Panel, item As String, cost As Decimal, category As String, description As String, expenseDate As DateTime)
        ' Deselect all panels except month header panels
        For Each panel As Guna.UI2.WinForms.Guna2Panel In flpExpenses.Controls.OfType(Of Guna.UI2.WinForms.Guna2Panel)()
            If Not panel.Name.StartsWith("pnlMonthHeader") Then
                panel.FillColor = Color.FromArgb(13, 17, 64)
            End If
        Next

        ' Select the clicked panel
        selectedPanel.FillColor = Color.FromArgb(8, 6, 26)

        ' Set the current expense panel name
        _CurrentExpensePanelName = selectedPanel.Name

        ' Populate the fields
        PopulateFields(item, cost, category, description, expenseDate)
    End Sub


    Private Sub PopulateFields(item As String, cost As Decimal, category As String, description As String, expenseDate As DateTime)
        txtItem.Text = item
        txtCost.Text = cost.ToString()
        cmbCategory.Text = category
        txtDescription.Text = description
        dtpDate.Value = expenseDate
    End Sub

    Private Sub btnUpdateExpenses_Click(sender As Object, e As EventArgs) Handles btnUpdateExpenses.Click
        Dim item As String = txtItem.Text
        Dim cost As Decimal
        Dim category As String = cmbCategory.Text
        Dim description As String = txtDescription.Text
        Dim expenseDate As DateTime = dtpDate.Value

        If Not Decimal.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("Please enter a valid cost.")
            Return
        End If

        If String.IsNullOrEmpty(item) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Check if an expense panel is selected
        If String.IsNullOrEmpty(_CurrentExpensePanelName) Then
            MessageBox.Show("Please select an expense to update.")
            Return
        End If

        Dim expenseID As Integer = Integer.Parse(_CurrentExpensePanelName.Replace("pnlExpense", ""))

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()

                ' Check if the expense still exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM user_expenses WHERE expense_id = @ID"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@ID", expenseID)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count = 0 Then
                        Dim result As DialogResult = MessageBox.Show("That item no longer exists. Would you like to add it to your expenses?", "Item Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            btnAddExpense_Click(sender, e)
                        End If
                        Return
                    End If
                End Using

                ' Update the expense
                Dim query As String = "UPDATE user_expenses SET Item = @Item, Cost = @Cost, Category = @Category, Description = @Description, date = @Date WHERE expense_id = @ID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Item", item)
                    cmd.Parameters.AddWithValue("@Cost", cost)
                    cmd.Parameters.AddWithValue("@Category", category)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.Parameters.AddWithValue("@Date", expenseDate)
                    cmd.Parameters.AddWithValue("@ID", expenseID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Expense updated successfully.")
                LoadExpenses() ' Refresh the FlowLayoutPanel
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub DeleteExpense(expenseID As Integer, panelToRemove As Panel)
        ' First remove from DB
        Dim confirm = MessageBox.Show("Remove expense?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "DELETE FROM user_expenses WHERE expense_id = @ID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", expenseID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Remove the panel from the flow layout
            flpExpenses.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
            LoadExpenses() ' Refresh the FlowLayoutPanel
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create an instance of the ExportUtility class
        Dim exporter As New ExportUtility(ExportUtility.ExportFormat.CSV)

        ' Create a DataGridView to hold the expense data
        Dim dgv As New DataGridView()
        dgv.Columns.Add("Item", "Item")
        dgv.Columns.Add("Cost", "Cost")
        dgv.Columns.Add("Category", "Category")
        dgv.Columns.Add("Description", "Description")
        dgv.Columns.Add("Date", "Date")

        ' Populate the DataGridView with expense data
        For Each panel As Panel In flpExpenses.Controls.OfType(Of Panel)()
            Dim lblItem As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblItem"))
            Dim lblCost As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblCost"))
            Dim lblCategory As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblCategory"))
            Dim lblDescription As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblDescription"))
            Dim lblDate As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblDate"))

            If lblItem IsNot Nothing AndAlso lblCost IsNot Nothing AndAlso lblCategory IsNot Nothing AndAlso lblDescription IsNot Nothing AndAlso lblDate IsNot Nothing Then
                Dim item As String = lblItem.Text
                Dim cost As String = lblCost.Text
                Dim category As String = lblCategory.Text
                Dim description As String = lblDescription.Text
                Dim dateStr As String = lblDate.Text

                dgv.Rows.Add(item, cost, category, description, dateStr)
            End If
        Next

        ' Export the data
        exporter.Export(dgv, "Expenses")
    End Sub

    ' ------------------------------------------------------------
    'Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadExpenses()
    '    LoadCategories()
    'End Sub

    'Private Sub btnAddExpense_Click(sender As Object, e As EventArgs)
    '    Dim item As String = txtItem.Text
    '    Dim cost As Decimal
    '    Dim category As String = cmbCategory.Text
    '    Dim description As String = txtDescription.Text

    '    If Not Decimal.TryParse(txtCost.Text, cost) Then
    '        MessageBox.Show("Please enter a valid cost.")
    '        Return
    '    End If

    '    If String.IsNullOrEmpty(item) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(description) Then
    '        MessageBox.Show("Please fill in all fields.")
    '        Return
    '    End If

    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "INSERT INTO user_expenses (UserID, Item, Cost, Category, Description, date) VALUES (@UserID, @Item, @Cost, @Category, @Description, @Date)"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                cmd.Parameters.AddWithValue("@Item", item)
    '                cmd.Parameters.AddWithValue("@Cost", cost)
    '                cmd.Parameters.AddWithValue("@Category", category)
    '                cmd.Parameters.AddWithValue("@Description", description)
    '                cmd.Parameters.AddWithValue("@Date", DateTime.Now)
    '                cmd.ExecuteNonQuery()
    '            End Using

    '            ' Check if this is the user's first expense
    '            Dim countQuery As String = "SELECT COUNT(*) FROM user_expenses WHERE UserID = @UserID"
    '            Using countCmd As New MySqlCommand(countQuery, connection)
    '                countCmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                Dim count As Integer = Convert.ToInt32(countCmd.ExecuteScalar())
    '                If count = 1 Then
    '                    ' Unlock the "First Expense" achievement
    '                    Dim achievement = AchievementManager._achievements.Find(Function(a) a.ID = 4)
    '                    If achievement IsNot Nothing Then
    '                        achievement.Unlock()
    '                    End If
    '                End If
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

    '            MessageBox.Show("Expense added successfully.")
    '            LoadExpenses() ' Refresh the DataGridView after adding a new expense
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
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

    'Private Sub LoadExpenses()
    '    Dim query As String = "SELECT Item AS ITEM, CONCAT('$', Cost) AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
    '    Dim dt As New DataTable()

    '    Using conn As MySqlConnection = Common.createDBConnection()
    '        Using cmd As New MySqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '            conn.Open()
    '            Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                dt.Load(reader)
    '            End Using
    '        End Using
    '    End Using

    '    'dgExpenses.DataSource = dt
    '    'dgExpenses.AllowUserToAddRows = False
    '    'dgExpenses.BackgroundColor = Color.White
    '    'dgExpenses.BorderStyle = BorderStyle.None
    '    'dgExpenses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
    '    'dgExpenses.DefaultCellStyle.SelectionForeColor = Color.Black
    '    'dgExpenses.EnableHeadersVisualStyles = False
    '    'dgExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
    '    'dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.White
    '    'dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
    '    'dgExpenses.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    '    'dgExpenses.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
    '    'dgExpenses.RowHeadersVisible = False
    '    'dgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '    'dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
    '    'dgExpenses.AllowUserToAddRows = False
    '    'dgExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None
    'End Sub

    'Private Sub btnExport_Click(sender As Object, e As EventArgs)
    '    ' Create an instance of the ExportUtility class
    '    'Dim exporter As New ExportUtility()

    '    ' Export the data
    '    'exporter.ExportToCSV(dgExpenses, "Expenses")
    'End Sub

    'Private Sub dgExpenses_CellClick(sender As Object, e As DataGridViewCellEventArgs)
    '    'If e.RowIndex >= 0 Then
    '    '    Dim row As DataGridViewRow = dgExpenses.Rows(e.RowIndex)
    '    '    txtItem.Text = row.Cells("ITEM").Value.ToString()
    '    '    txtCost.Text = row.Cells("COST").Value.ToString().Replace("$", "")
    '    '    cmbCategory.Text = row.Cells("CATEGORY").Value.ToString()
    '    '    txtDescription.Text = row.Cells("DESCRIPTION").Value.ToString()
    '    'End If
    'End Sub

    'Private Sub btnUpdateExpenses_Click(sender As Object, e As EventArgs)
    '    'Dim item As String = txtItem.Text
    '    'Dim cost As Decimal
    '    'Dim category As String = cmbCategory.Text
    '    'Dim description As String = txtDescription.Text

    '    'If Not Decimal.TryParse(txtCost.Text, cost) Then
    '    '    MessageBox.Show("Please enter a valid cost.")
    '    '    Return
    '    'End If

    '    'If String.IsNullOrEmpty(item) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(description) Then
    '    '    MessageBox.Show("Please fill in all fields.")
    '    '    Return
    '    'End If

    '    'If dgExpenses.SelectedRows.Count > 0 OrElse dgExpenses.SelectedCells.Count > 0 Then
    '    '    Dim rowIndex As Integer = If(dgExpenses.SelectedRows.Count > 0, dgExpenses.SelectedRows(0).Index, dgExpenses.SelectedCells(0).RowIndex)
    '    '    Dim selectedItem As String = dgExpenses.Rows(rowIndex).Cells("ITEM").Value.ToString()
    '    '    Dim selectedDate As String = dgExpenses.Rows(rowIndex).Cells("DATE").Value.ToString()

    '    '    Try
    '    '        Using connection As MySqlConnection = Common.createDBConnection()
    '    '            connection.Open()
    '    '            Dim query As String = "UPDATE user_expenses SET Item = @Item, Cost = @Cost, Category = @Category, Description = @Description WHERE UserID = @UserID AND Item = @OriginalItem AND DATE_FORMAT(date, '%m/%d/%Y') = @OriginalDate"
    '    '            Using cmd As New MySqlCommand(query, connection)
    '    '                cmd.Parameters.AddWithValue("@Item", item)
    '    '                cmd.Parameters.AddWithValue("@Cost", cost)
    '    '                cmd.Parameters.AddWithValue("@Category", category)
    '    '                cmd.Parameters.AddWithValue("@Description", description)
    '    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '    '                cmd.Parameters.AddWithValue("@OriginalItem", selectedItem)
    '    '                cmd.Parameters.AddWithValue("@OriginalDate", selectedDate)
    '    '                cmd.ExecuteNonQuery()
    '    '            End Using
    '    '            MessageBox.Show("Expense updated successfully.")
    '    '            LoadExpenses() ' Refresh the DataGridView
    '    '        End Using
    '    '    Catch ex As Exception
    '    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    '    End Try
    '    'Else
    '    '    MessageBox.Show("Please select an expense to update.")
    '    'End If
    'End Sub

    'Private Sub btnDeleteExpense_Click(sender As Object, e As EventArgs)
    '    'If dgExpenses.SelectedRows.Count > 0 OrElse dgExpenses.SelectedCells.Count > 0 Then
    '    '    ' Confirm before deleting
    '    '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    '    If result = DialogResult.Yes Then
    '    '        Dim rowIndex As Integer = If(dgExpenses.SelectedRows.Count > 0, dgExpenses.SelectedRows(0).Index, dgExpenses.SelectedCells(0).RowIndex)
    '    '        Dim selectedItem As String = dgExpenses.Rows(rowIndex).Cells("ITEM").Value.ToString()
    '    '        Dim selectedDate As String = dgExpenses.Rows(rowIndex).Cells("DATE").Value.ToString()

    '    '        Try
    '    '            Using connection As MySqlConnection = Common.createDBConnection()
    '    '                connection.Open()
    '    '                Dim query As String = "DELETE FROM user_expenses WHERE UserID = @UserID AND Item = @Item AND DATE_FORMAT(date, '%m/%d/%Y') = @Date"

    '    '                Using cmd As New MySqlCommand(query, connection)
    '    '                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '    '                    cmd.Parameters.AddWithValue("@Item", selectedItem)
    '    '                    cmd.Parameters.AddWithValue("@Date", selectedDate)
    '    '                    cmd.ExecuteNonQuery()
    '    '                End Using

    '    '                MessageBox.Show("Expense deleted successfully.")
    '    '                LoadExpenses() ' Refresh the DataGridView

    '    '                ' Clear the form fields after deletion
    '    '                txtItem.Text = ""
    '    '                txtCost.Text = ""
    '    '                txtDescription.Text = ""
    '    '            End Using
    '    '        Catch ex As Exception
    '    '            MessageBox.Show("An error occurred: " & ex.Message)
    '    '        End Try
    '    '    End If
    '    'Else
    '    '    MessageBox.Show("Please select an expense to delete.")
    '    'End If
    'End Sub
End Class
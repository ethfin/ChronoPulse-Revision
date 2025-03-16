Imports MySql.Data.MySqlClient

Public Class frmIncome

    Private _CurrentIncomePanelName As String = Nothing

    Private Sub frmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpIncome.FlowDirection = FlowDirection.TopDown
        flpIncome.WrapContents = False  ' Add this line
        flpIncome.AutoScroll = True     ' Ensure this is set to True
        flpIncome.AutoScrollMinSize = New Size(0, 0)  ' Reset this if needed
        LoadIncomeData()
    End Sub

    Private Sub LoadIncomeData()
        flpIncome.Controls.Clear()

        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT IncomeID, Source, Amount, Date FROM user_income WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim incomeID As Integer = CInt(reader("IncomeID"))
                        Dim source As String = reader("Source").ToString()
                        Dim amount As Decimal = CDec(reader("Amount"))
                        Dim incomeDate As DateTime = CDate(reader("Date"))

                        CreateIncomePanel(incomeID, source, amount, incomeDate)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub CreateIncomePanel(incomeID As Integer, source As String, amount As Decimal, incomeDate As DateTime)
        Dim incomePanel As New Guna.UI2.WinForms.Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(720, 60),
            .Name = "pnlIncome" & incomeID.ToString(),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10
        }

        Dim lblSource As New Label With {
            .Name = "lblSource" & incomeID.ToString(),
            .Text = source,
            .Location = New Point(10, 10),
            .AutoSize = False,
            .Size = New Size(110, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblSource.Click, Sub(sender, e) SelectIncomePanel(incomePanel, source, amount, incomeDate)
        incomePanel.Controls.Add(lblSource)

        Dim lblAmount As New Label With {
            .Name = "lblAmount" & incomeID.ToString(),
            .Text = "Cost: " & amount.ToString("F2"),
            .Location = New Point(10, 30),
            .AutoSize = False,
            .Size = New Size(100, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblAmount.Click, Sub(sender, e) SelectIncomePanel(incomePanel, source, amount, incomeDate)
        incomePanel.Controls.Add(lblAmount)

        Dim lblDate As New Label With {
            .Name = "lblDate" & incomeID.ToString(),
            .Text = "Date: " & incomeDate.ToShortDateString(),
            .Location = New Point(130, 10),
            .AutoSize = False,
            .Size = New Size(200, 20),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        AddHandler lblDate.Click, Sub(sender, e) SelectIncomePanel(incomePanel, source, amount, incomeDate)
        incomePanel.Controls.Add(lblDate)

        Dim deleteButton As New Button With {
            .Text = "Remove",
            .Size = New Size(80, 25),
            .Location = New Point(620, 25),
            .Name = "btnDeleteIncome" & incomeID.ToString(),
            .ForeColor = Color.White,
            .Font = New Font("Century Gothic", 9.75F, FontStyle.Regular)
        }
        AddHandler deleteButton.Click, Sub(sender, e) DeleteIncome(incomeID, incomePanel)
        incomePanel.Controls.Add(deleteButton)

        AddHandler incomePanel.Click, Sub(sender, e) SelectIncomePanel(incomePanel, source, amount, incomeDate)

        flpIncome.Controls.Add(incomePanel)
    End Sub

    Private Sub SelectIncomePanel(selectedPanel As Guna.UI2.WinForms.Guna2Panel, source As String, amount As Decimal, incomeDate As DateTime)
        For Each panel As Guna.UI2.WinForms.Guna2Panel In flpIncome.Controls.OfType(Of Guna.UI2.WinForms.Guna2Panel)()
            panel.FillColor = Color.FromArgb(13, 17, 64)
        Next

        selectedPanel.FillColor = Color.FromArgb(8, 6, 26)
        _CurrentIncomePanelName = selectedPanel.Name

        PopulateFields(source, amount, incomeDate)
    End Sub

    Private Sub PopulateFields(source As String, amount As Decimal, incomeDate As DateTime)
        txtSource.Text = source
        txtAmount.Text = amount.ToString()
        dtpDate.Value = incomeDate
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

                UserExperience.AddXP(5)
                UserExperience.SaveUserExperience(AccountData.UserID)

                Dim mainForm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                If mainForm IsNot Nothing Then
                    mainForm.UpdateExperienceBar()
                    mainForm.prgExperience.Invalidate()
                    mainForm.prgExperience.Refresh()
                    mainForm.lblLevel.Refresh()
                End If

                LoadIncomeData()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateIncome_Click(sender As Object, e As EventArgs) Handles btnUpdateIncome.Click
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

        If String.IsNullOrEmpty(_CurrentIncomePanelName) Then
            MessageBox.Show("Please select an income record to update.")
            Return
        End If

        Dim incomeID As Integer = Integer.Parse(_CurrentIncomePanelName.Replace("pnlIncome", ""))

        Try
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "UPDATE user_income SET Source = @Source, Amount = @Amount, Date = @Date WHERE IncomeID = @IncomeID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@IncomeID", incomeID)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.Parameters.AddWithValue("@Source", source)
                    cmd.Parameters.AddWithValue("@Amount", amount)
                    cmd.Parameters.AddWithValue("@Date", incomeDate)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Income record updated successfully.")
                LoadIncomeData()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteIncome(incomeID As Integer, panelToRemove As Panel)
        Dim confirm = MessageBox.Show("Remove income record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "DELETE FROM user_income WHERE IncomeID = @IncomeID AND UserID = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@IncomeID", incomeID)
                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            flpIncome.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exporter As New ExportUtility(ExportUtility.ExportFormat.CSV)

        Dim dgv As New DataGridView()
        dgv.Columns.Add("Source", "Source")
        dgv.Columns.Add("Amount", "Amount")
        dgv.Columns.Add("Date", "Date")

        For Each panel As Panel In flpIncome.Controls.OfType(Of Panel)()
            Dim lblSource As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblSource"))
            Dim lblAmount As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblAmount"))
            Dim lblDate As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.Contains("lblDate"))

            If lblSource IsNot Nothing AndAlso lblAmount IsNot Nothing AndAlso lblDate IsNot Nothing Then
                Dim source As String = lblSource.Text
                Dim amount As String = lblAmount.Text
                Dim dateStr As String = lblDate.Text

                dgv.Rows.Add(source, amount, dateStr)
            End If
        Next

        exporter.Export(dgv, "Income")
    End Sub

    'Private Sub frmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadIncomeData()
    'End Sub

    'Private Sub btnAddIncome_Click(sender As Object, e As EventArgs) Handles btnAddIncome.Click
    '    Dim source As String = txtSource.Text
    '    Dim amount As Decimal
    '    Dim incomeDate As Date = dtpDate.Value

    '    If Not Decimal.TryParse(txtAmount.Text, amount) Then
    '        MessageBox.Show("Please enter a valid amount.")
    '        Return
    '    End If

    '    If String.IsNullOrEmpty(source) Then
    '        MessageBox.Show("Please enter a source.")
    '        Return
    '    End If

    '    Try
    '        Using connection As MySqlConnection = Common.createDBConnection()
    '            connection.Open()
    '            Dim query As String = "INSERT INTO user_income (UserID, Source, Amount, Date) VALUES (@UserID, @Source, @Amount, @Date)"
    '            Using cmd As New MySqlCommand(query, connection)
    '                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                cmd.Parameters.AddWithValue("@Source", source)
    '                cmd.Parameters.AddWithValue("@Amount", amount)
    '                cmd.Parameters.AddWithValue("@Date", incomeDate)
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

    '            MessageBox.Show("Income added successfully.")
    '            LoadIncomeData() ' Refresh the DataGridView
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub LoadIncomeData()
    '    Dim query As String = "SELECT Source AS SOURCE, CONCAT('$', Amount) AS AMOUNT, DATE_FORMAT(Date, '%m/%d/%Y') AS DATE FROM user_income WHERE UserID = @UserID"
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

    '    dgIncome.DataSource = dt
    '    'dgIncome.AllowUserToAddRows = False
    '    'dgIncome.BackgroundColor = Color.White
    '    'dgIncome.BorderStyle = BorderStyle.None
    '    'dgIncome.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
    '    'dgIncome.DefaultCellStyle.SelectionForeColor = Color.Black
    '    'dgIncome.EnableHeadersVisualStyles = False
    '    'dgIncome.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
    '    'dgIncome.ColumnHeadersDefaultCellStyle.BackColor = Color.White
    '    'dgIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
    '    'dgIncome.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    '    'dgIncome.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
    '    'dgIncome.RowHeadersVisible = False
    '    'dgIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '    'dgIncome.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
    '    'dgIncome.AllowUserToAddRows = False
    '    'dgIncome.CellBorderStyle = DataGridViewCellBorderStyle.None
    'End Sub

    'Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
    '    ' Create an instance of the ExportUtility class
    '    Dim exporter As New ExportUtility()

    '    ' Export the data
    '    exporter.ExportToCSV(dgIncome, "Income")
    'End Sub

    'Private Sub dgIncome_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgIncome.CellClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = dgIncome.Rows(e.RowIndex)
    '        txtSource.Text = row.Cells("SOURCE").Value.ToString()
    '        txtAmount.Text = row.Cells("AMOUNT").Value.ToString().Replace("$", "")
    '        dtpDate.Value = Convert.ToDateTime(row.Cells("DATE").Value)
    '    End If
    'End Sub

    'Private Sub btnDeleteIncome_Click(sender As Object, e As EventArgs) Handles btnDeleteIncome.Click
    '    If dgIncome.SelectedRows.Count > 0 OrElse dgIncome.SelectedCells.Count > 0 Then
    '        ' Confirm before deleting
    '        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this income record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '        If result = DialogResult.Yes Then
    '            Dim rowIndex As Integer = If(dgIncome.SelectedRows.Count > 0, dgIncome.SelectedRows(0).Index, dgIncome.SelectedCells(0).RowIndex)
    '            Dim selectedSource As String = dgIncome.Rows(rowIndex).Cells("SOURCE").Value.ToString()
    '            Dim selectedDate As String = dgIncome.Rows(rowIndex).Cells("DATE").Value.ToString()

    '            Try
    '                Using connection As MySqlConnection = Common.createDBConnection()
    '                    connection.Open()
    '                    Dim query As String = "DELETE FROM user_income WHERE UserID = @UserID AND Source = @Source AND DATE_FORMAT(Date, '%m/%d/%Y') = @Date"

    '                    Using cmd As New MySqlCommand(query, connection)
    '                        cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                        cmd.Parameters.AddWithValue("@Source", selectedSource)
    '                        cmd.Parameters.AddWithValue("@Date", selectedDate)
    '                        cmd.ExecuteNonQuery()
    '                    End Using

    '                    MessageBox.Show("Income record deleted successfully.")
    '                    LoadIncomeData() ' Refresh the DataGridView

    '                    ' Clear the form fields after deletion
    '                    txtSource.Text = ""
    '                    txtAmount.Text = ""
    '                    dtpDate.Value = DateTime.Now
    '                End Using
    '            Catch ex As Exception
    '                MessageBox.Show("An error occurred: " & ex.Message)
    '            End Try
    '        End If
    '    Else
    '        MessageBox.Show("Please select an income record to delete.")
    '    End If
    'End Sub

    'Private Sub btnUpdateIncome_Click(sender As Object, e As EventArgs) Handles btnUpdateIncome.Click
    '    Dim source As String = txtSource.Text
    '    Dim amount As Decimal
    '    Dim incomeDate As Date = dtpDate.Value

    '    If Not Decimal.TryParse(txtAmount.Text, amount) Then
    '        MessageBox.Show("Please enter a valid amount.")
    '        Return
    '    End If

    '    If String.IsNullOrEmpty(source) Then
    '        MessageBox.Show("Please enter a source.")
    '        Return
    '    End If

    '    If dgIncome.SelectedRows.Count > 0 OrElse dgIncome.SelectedCells.Count > 0 Then
    '        Dim rowIndex As Integer = If(dgIncome.SelectedRows.Count > 0, dgIncome.SelectedRows(0).Index, dgIncome.SelectedCells(0).RowIndex)
    '        Dim selectedSource As String = dgIncome.Rows(rowIndex).Cells("SOURCE").Value.ToString()
    '        Dim selectedDate As String = dgIncome.Rows(rowIndex).Cells("DATE").Value.ToString()

    '        Try
    '            Using connection As MySqlConnection = Common.createDBConnection()
    '                connection.Open()
    '                Dim query As String = "UPDATE user_income SET Source = @Source, Amount = @Amount, Date = @Date WHERE UserID = @UserID AND Source = @OriginalSource AND DATE_FORMAT(Date, '%m/%d/%Y') = @OriginalDate"

    '                Using cmd As New MySqlCommand(query, connection)
    '                    cmd.Parameters.AddWithValue("@Source", source)
    '                    cmd.Parameters.AddWithValue("@Amount", amount)
    '                    cmd.Parameters.AddWithValue("@Date", incomeDate)
    '                    cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
    '                    cmd.Parameters.AddWithValue("@OriginalSource", selectedSource)
    '                    cmd.Parameters.AddWithValue("@OriginalDate", selectedDate)
    '                    cmd.ExecuteNonQuery()
    '                End Using

    '                MessageBox.Show("Income record updated successfully.")
    '                LoadIncomeData() ' Refresh the DataGridView
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("An error occurred: " & ex.Message)
    '        End Try
    '    Else
    '        MessageBox.Show("Please select an income record to update.")
    '    End If
    'End Sub
End Class
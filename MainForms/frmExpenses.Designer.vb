<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpenses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chrtPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnUpdateExpenses = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddExpense = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpExpenses = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.chrtPie)
        Me.Guna2Panel1.Controls.Add(Me.dtpDate)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdateExpenses)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnAddExpense)
        Me.Guna2Panel1.Controls.Add(Me.cmbCategory)
        Me.Guna2Panel1.Controls.Add(Me.txtCost)
        Me.Guna2Panel1.Controls.Add(Me.txtDescription)
        Me.Guna2Panel1.Controls.Add(Me.txtItem)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(286, 631)
        Me.Guna2Panel1.TabIndex = 26
        '
        'chrtPie
        '
        Me.chrtPie.BackColor = System.Drawing.Color.Transparent
        Me.chrtPie.BorderlineColor = System.Drawing.Color.Transparent
        Me.chrtPie.BorderlineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.chrtPie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtPie.Legends.Add(Legend1)
        Me.chrtPie.Location = New System.Drawing.Point(12, 338)
        Me.chrtPie.Name = "chrtPie"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtPie.Series.Add(Series1)
        Me.chrtPie.Size = New System.Drawing.Size(268, 259)
        Me.chrtPie.TabIndex = 36
        Me.chrtPie.Text = "Chart1"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.Transparent
        Me.dtpDate.BorderRadius = 10
        Me.dtpDate.Checked = True
        Me.dtpDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpDate.Font = New System.Drawing.Font("Pixelify Sans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(12, 160)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpDate.TabIndex = 33
        Me.dtpDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'btnUpdateExpenses
        '
        Me.btnUpdateExpenses.Animated = True
        Me.btnUpdateExpenses.BorderRadius = 15
        Me.btnUpdateExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateExpenses.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateExpenses.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateExpenses.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateExpenses.IndicateFocus = True
        Me.btnUpdateExpenses.Location = New System.Drawing.Point(12, 243)
        Me.btnUpdateExpenses.Name = "btnUpdateExpenses"
        Me.btnUpdateExpenses.Size = New System.Drawing.Size(260, 35)
        Me.btnUpdateExpenses.TabIndex = 31
        Me.btnUpdateExpenses.Text = "UPDATE"
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.BorderRadius = 15
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(12, 284)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(260, 35)
        Me.btnExport.TabIndex = 30
        Me.btnExport.Text = "EXPORT"
        '
        'btnAddExpense
        '
        Me.btnAddExpense.Animated = True
        Me.btnAddExpense.BorderRadius = 15
        Me.btnAddExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddExpense.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddExpense.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddExpense.ForeColor = System.Drawing.Color.Black
        Me.btnAddExpense.IndicateFocus = True
        Me.btnAddExpense.Location = New System.Drawing.Point(12, 202)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(260, 35)
        Me.btnAddExpense.TabIndex = 29
        Me.btnAddExpense.Text = "ADD"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderRadius = 10
        Me.cmbCategory.BorderThickness = 0
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Pixelify Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(12, 45)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(260, 36)
        Me.cmbCategory.TabIndex = 28
        '
        'txtCost
        '
        Me.txtCost.Animated = True
        Me.txtCost.BorderRadius = 10
        Me.txtCost.BorderThickness = 0
        Me.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCost.DefaultText = ""
        Me.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Location = New System.Drawing.Point(12, 122)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtCost.PlaceholderText = "COST"
        Me.txtCost.SelectedText = ""
        Me.txtCost.Size = New System.Drawing.Size(260, 35)
        Me.txtCost.TabIndex = 27
        '
        'txtDescription
        '
        Me.txtDescription.Animated = True
        Me.txtDescription.BorderRadius = 10
        Me.txtDescription.BorderThickness = 0
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(12, 84)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtDescription.PlaceholderText = "NOTE"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(260, 35)
        Me.txtDescription.TabIndex = 26
        '
        'txtItem
        '
        Me.txtItem.Animated = True
        Me.txtItem.BorderRadius = 10
        Me.txtItem.BorderThickness = 0
        Me.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItem.DefaultText = ""
        Me.txtItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItem.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItem.Location = New System.Drawing.Point(12, 7)
        Me.txtItem.Margin = New System.Windows.Forms.Padding(0)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtItem.PlaceholderText = "ITEM"
        Me.txtItem.SelectedText = ""
        Me.txtItem.Size = New System.Drawing.Size(260, 35)
        Me.txtItem.TabIndex = 25
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.flpExpenses)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(286, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(946, 631)
        Me.Guna2Panel2.TabIndex = 27
        '
        'flpExpenses
        '
        Me.flpExpenses.AutoScroll = True
        Me.flpExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpExpenses.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpExpenses.Location = New System.Drawing.Point(0, 0)
        Me.flpExpenses.Name = "flpExpenses"
        Me.flpExpenses.Size = New System.Drawing.Size(946, 631)
        Me.flpExpenses.TabIndex = 0
        Me.flpExpenses.WrapContents = False
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1232, 631)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmExpenses"
        Me.Text = "frmExpenses"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnUpdateExpenses As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddExpense As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents txtCost As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtItem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpExpenses As FlowLayoutPanel
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents chrtPie As DataVisualization.Charting.Chart
End Class

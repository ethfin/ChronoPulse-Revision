<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgeting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateBudget = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddBudget = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtBudgetAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdateBudget)
        Me.Guna2Panel1.Controls.Add(Me.btnAddBudget)
        Me.Guna2Panel1.Controls.Add(Me.txtDescription)
        Me.Guna2Panel1.Controls.Add(Me.dtpEndDate)
        Me.Guna2Panel1.Controls.Add(Me.dtpStartDate)
        Me.Guna2Panel1.Controls.Add(Me.txtBudgetAmount)
        Me.Guna2Panel1.Controls.Add(Me.cmbCategory)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(279, 505)
        Me.Guna2Panel1.TabIndex = 29
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
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(9, 249)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 35)
        Me.btnExport.TabIndex = 37
        Me.btnExport.Text = "Export"
        '
        'btnUpdateBudget
        '
        Me.btnUpdateBudget.Animated = True
        Me.btnUpdateBudget.BorderRadius = 15
        Me.btnUpdateBudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateBudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateBudget.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateBudget.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBudget.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateBudget.IndicateFocus = True
        Me.btnUpdateBudget.Location = New System.Drawing.Point(157, 208)
        Me.btnUpdateBudget.Name = "btnUpdateBudget"
        Me.btnUpdateBudget.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdateBudget.TabIndex = 36
        Me.btnUpdateBudget.Text = "Update"
        '
        'btnAddBudget
        '
        Me.btnAddBudget.Animated = True
        Me.btnAddBudget.BorderRadius = 15
        Me.btnAddBudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddBudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddBudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddBudget.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddBudget.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBudget.ForeColor = System.Drawing.Color.Black
        Me.btnAddBudget.IndicateFocus = True
        Me.btnAddBudget.Location = New System.Drawing.Point(12, 208)
        Me.btnAddBudget.Name = "btnAddBudget"
        Me.btnAddBudget.Size = New System.Drawing.Size(112, 35)
        Me.btnAddBudget.TabIndex = 35
        Me.btnAddBudget.Text = "Add"
        '
        'txtDescription
        '
        Me.txtDescription.Animated = True
        Me.txtDescription.BorderRadius = 10
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(9, 9)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtDescription.PlaceholderText = "Description"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(260, 35)
        Me.txtDescription.TabIndex = 33
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpEndDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndDate.Location = New System.Drawing.Point(9, 166)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpEndDate.TabIndex = 32
        Me.dtpEndDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpStartDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.Location = New System.Drawing.Point(9, 124)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpStartDate.TabIndex = 31
        Me.dtpStartDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'txtBudgetAmount
        '
        Me.txtBudgetAmount.Animated = True
        Me.txtBudgetAmount.BorderRadius = 10
        Me.txtBudgetAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBudgetAmount.DefaultText = ""
        Me.txtBudgetAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBudgetAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBudgetAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBudgetAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBudgetAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBudgetAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBudgetAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBudgetAmount.Location = New System.Drawing.Point(9, 44)
        Me.txtBudgetAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.txtBudgetAmount.Name = "txtBudgetAmount"
        Me.txtBudgetAmount.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtBudgetAmount.PlaceholderText = "Amount"
        Me.txtBudgetAmount.SelectedText = ""
        Me.txtBudgetAmount.Size = New System.Drawing.Size(260, 35)
        Me.txtBudgetAmount.TabIndex = 30
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(9, 82)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(260, 36)
        Me.cmbCategory.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(279, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(687, 505)
        Me.Guna2Panel2.TabIndex = 30
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(687, 505)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'frmBudgeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(966, 505)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmBudgeting"
        Me.Text = "frmBudgeting"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnUpdateBudget As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddBudget As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents txtBudgetAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class

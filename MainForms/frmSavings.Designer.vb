<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTargetAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGoalName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCurrentAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpTargetDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnAddSavingsGoal = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvSavings = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnUpdateSavingsGoal = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvSavings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTargetAmount
        '
        Me.txtTargetAmount.Animated = True
        Me.txtTargetAmount.BorderRadius = 10
        Me.txtTargetAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTargetAmount.DefaultText = ""
        Me.txtTargetAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTargetAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTargetAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTargetAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTargetAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTargetAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTargetAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTargetAmount.Location = New System.Drawing.Point(9, 44)
        Me.txtTargetAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTargetAmount.Name = "txtTargetAmount"
        Me.txtTargetAmount.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtTargetAmount.PlaceholderText = "Target Amount"
        Me.txtTargetAmount.SelectedText = ""
        Me.txtTargetAmount.Size = New System.Drawing.Size(260, 35)
        Me.txtTargetAmount.TabIndex = 11
        '
        'txtGoalName
        '
        Me.txtGoalName.Animated = True
        Me.txtGoalName.BorderRadius = 10
        Me.txtGoalName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGoalName.DefaultText = ""
        Me.txtGoalName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGoalName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGoalName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGoalName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGoalName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGoalName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtGoalName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGoalName.Location = New System.Drawing.Point(9, 9)
        Me.txtGoalName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtGoalName.Name = "txtGoalName"
        Me.txtGoalName.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtGoalName.PlaceholderText = "Goal"
        Me.txtGoalName.SelectedText = ""
        Me.txtGoalName.Size = New System.Drawing.Size(260, 35)
        Me.txtGoalName.TabIndex = 10
        '
        'txtCurrentAmount
        '
        Me.txtCurrentAmount.Animated = True
        Me.txtCurrentAmount.BorderRadius = 10
        Me.txtCurrentAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentAmount.DefaultText = ""
        Me.txtCurrentAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCurrentAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCurrentAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCurrentAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentAmount.Location = New System.Drawing.Point(9, 79)
        Me.txtCurrentAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCurrentAmount.Name = "txtCurrentAmount"
        Me.txtCurrentAmount.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtCurrentAmount.PlaceholderText = "Current Amount"
        Me.txtCurrentAmount.SelectedText = ""
        Me.txtCurrentAmount.Size = New System.Drawing.Size(260, 35)
        Me.txtCurrentAmount.TabIndex = 12
        '
        'dtpTargetDate
        '
        Me.dtpTargetDate.Checked = True
        Me.dtpTargetDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpTargetDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTargetDate.Location = New System.Drawing.Point(12, 117)
        Me.dtpTargetDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTargetDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTargetDate.Name = "dtpTargetDate"
        Me.dtpTargetDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpTargetDate.TabIndex = 13
        Me.dtpTargetDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'btnAddSavingsGoal
        '
        Me.btnAddSavingsGoal.Animated = True
        Me.btnAddSavingsGoal.BorderRadius = 15
        Me.btnAddSavingsGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSavingsGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSavingsGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddSavingsGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddSavingsGoal.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAddSavingsGoal.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnAddSavingsGoal.ForeColor = System.Drawing.Color.White
        Me.btnAddSavingsGoal.IndicateFocus = True
        Me.btnAddSavingsGoal.Location = New System.Drawing.Point(12, 159)
        Me.btnAddSavingsGoal.Name = "btnAddSavingsGoal"
        Me.btnAddSavingsGoal.Size = New System.Drawing.Size(112, 45)
        Me.btnAddSavingsGoal.TabIndex = 14
        Me.btnAddSavingsGoal.Text = "Add"
        '
        'dgvSavings
        '
        Me.dgvSavings.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSavings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSavings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSavings.ColumnHeadersHeight = 22
        Me.dgvSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSavings.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSavings.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvSavings.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSavings.Location = New System.Drawing.Point(278, 0)
        Me.dgvSavings.Name = "dgvSavings"
        Me.dgvSavings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSavings.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSavings.RowHeadersVisible = False
        Me.dgvSavings.Size = New System.Drawing.Size(522, 450)
        Me.dgvSavings.TabIndex = 15
        Me.dgvSavings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSavings.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSavings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvSavings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSavings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSavings.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSavings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSavings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSavings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSavings.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSavings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSavings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSavings.ThemeStyle.HeaderStyle.Height = 22
        Me.dgvSavings.ThemeStyle.ReadOnly = False
        Me.dgvSavings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSavings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSavings.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSavings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSavings.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSavings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSavings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnUpdateSavingsGoal
        '
        Me.btnUpdateSavingsGoal.Animated = True
        Me.btnUpdateSavingsGoal.BorderRadius = 15
        Me.btnUpdateSavingsGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSavingsGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSavingsGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateSavingsGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateSavingsGoal.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnUpdateSavingsGoal.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnUpdateSavingsGoal.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSavingsGoal.IndicateFocus = True
        Me.btnUpdateSavingsGoal.Location = New System.Drawing.Point(160, 159)
        Me.btnUpdateSavingsGoal.Name = "btnUpdateSavingsGoal"
        Me.btnUpdateSavingsGoal.Size = New System.Drawing.Size(112, 45)
        Me.btnUpdateSavingsGoal.TabIndex = 16
        Me.btnUpdateSavingsGoal.Text = "Update"
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpdateSavingsGoal)
        Me.Controls.Add(Me.dgvSavings)
        Me.Controls.Add(Me.btnAddSavingsGoal)
        Me.Controls.Add(Me.dtpTargetDate)
        Me.Controls.Add(Me.txtCurrentAmount)
        Me.Controls.Add(Me.txtTargetAmount)
        Me.Controls.Add(Me.txtGoalName)
        Me.Name = "frmSavings"
        Me.Text = "frmSavings"
        CType(Me.dgvSavings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtTargetAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtGoalName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtCurrentAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpTargetDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents btnAddSavingsGoal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvSavings As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents btnUpdateSavingsGoal As Guna.UI2.WinForms.Guna2Button
End Class

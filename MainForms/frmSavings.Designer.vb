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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUpdateSavingsGoal = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddSavingsGoal = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpTargetDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtCurrentAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTargetAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGoalName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpSavings = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnUpdateSavingsGoal)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnAddSavingsGoal)
        Me.Guna2Panel1.Controls.Add(Me.dtpTargetDate)
        Me.Guna2Panel1.Controls.Add(Me.txtCurrentAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtTargetAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtGoalName)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(283, 450)
        Me.Guna2Panel1.TabIndex = 29
        '
        'btnUpdateSavingsGoal
        '
        Me.btnUpdateSavingsGoal.Animated = True
        Me.btnUpdateSavingsGoal.BorderRadius = 15
        Me.btnUpdateSavingsGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSavingsGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSavingsGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateSavingsGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateSavingsGoal.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateSavingsGoal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSavingsGoal.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateSavingsGoal.IndicateFocus = True
        Me.btnUpdateSavingsGoal.Location = New System.Drawing.Point(160, 159)
        Me.btnUpdateSavingsGoal.Name = "btnUpdateSavingsGoal"
        Me.btnUpdateSavingsGoal.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdateSavingsGoal.TabIndex = 36
        Me.btnUpdateSavingsGoal.Text = "Update"
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
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(12, 200)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 35)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export"
        '
        'btnAddSavingsGoal
        '
        Me.btnAddSavingsGoal.Animated = True
        Me.btnAddSavingsGoal.BorderRadius = 15
        Me.btnAddSavingsGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSavingsGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSavingsGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddSavingsGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddSavingsGoal.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddSavingsGoal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSavingsGoal.ForeColor = System.Drawing.Color.Black
        Me.btnAddSavingsGoal.IndicateFocus = True
        Me.btnAddSavingsGoal.Location = New System.Drawing.Point(12, 159)
        Me.btnAddSavingsGoal.Name = "btnAddSavingsGoal"
        Me.btnAddSavingsGoal.Size = New System.Drawing.Size(112, 35)
        Me.btnAddSavingsGoal.TabIndex = 34
        Me.btnAddSavingsGoal.Text = "Add"
        '
        'dtpTargetDate
        '
        Me.dtpTargetDate.Checked = True
        Me.dtpTargetDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpTargetDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpTargetDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTargetDate.Location = New System.Drawing.Point(12, 117)
        Me.dtpTargetDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTargetDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTargetDate.Name = "dtpTargetDate"
        Me.dtpTargetDate.Size = New System.Drawing.Size(257, 36)
        Me.dtpTargetDate.TabIndex = 32
        Me.dtpTargetDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
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
        Me.txtCurrentAmount.TabIndex = 31
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
        Me.txtTargetAmount.TabIndex = 30
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
        Me.txtGoalName.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.flpSavings)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(283, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(517, 450)
        Me.Guna2Panel2.TabIndex = 30
        '
        'flpSavings
        '
        Me.flpSavings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSavings.Location = New System.Drawing.Point(0, 0)
        Me.flpSavings.Name = "flpSavings"
        Me.flpSavings.Size = New System.Drawing.Size(517, 450)
        Me.flpSavings.TabIndex = 0
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmSavings"
        Me.Text = "frmSavings"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnUpdateSavingsGoal As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddSavingsGoal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpTargetDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents txtCurrentAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtTargetAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtGoalName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpSavings As FlowLayoutPanel
End Class

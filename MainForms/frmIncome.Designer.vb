<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIncome
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUpdateIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSource = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnUpdateIncome)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnAddIncome)
        Me.Guna2Panel1.Controls.Add(Me.dtpDate)
        Me.Guna2Panel1.Controls.Add(Me.txtAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtSource)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(278, 450)
        Me.Guna2Panel1.TabIndex = 29
        '
        'btnUpdateIncome
        '
        Me.btnUpdateIncome.Animated = True
        Me.btnUpdateIncome.BorderRadius = 15
        Me.btnUpdateIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateIncome.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateIncome.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateIncome.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateIncome.IndicateFocus = True
        Me.btnUpdateIncome.Location = New System.Drawing.Point(157, 124)
        Me.btnUpdateIncome.Name = "btnUpdateIncome"
        Me.btnUpdateIncome.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdateIncome.TabIndex = 34
        Me.btnUpdateIncome.Text = "Update"
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
        Me.btnExport.Location = New System.Drawing.Point(12, 165)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 35)
        Me.btnExport.TabIndex = 33
        Me.btnExport.Text = "Export"
        '
        'btnAddIncome
        '
        Me.btnAddIncome.Animated = True
        Me.btnAddIncome.BorderRadius = 15
        Me.btnAddIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddIncome.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddIncome.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddIncome.ForeColor = System.Drawing.Color.Black
        Me.btnAddIncome.IndicateFocus = True
        Me.btnAddIncome.Location = New System.Drawing.Point(12, 124)
        Me.btnAddIncome.Name = "btnAddIncome"
        Me.btnAddIncome.Size = New System.Drawing.Size(112, 35)
        Me.btnAddIncome.TabIndex = 32
        Me.btnAddIncome.Text = "Add"
        '
        'dtpDate
        '
        Me.dtpDate.Checked = True
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(9, 82)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpDate.TabIndex = 31
        Me.dtpDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'txtAmount
        '
        Me.txtAmount.Animated = True
        Me.txtAmount.BorderRadius = 10
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(9, 44)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtAmount.PlaceholderText = "Amount"
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(260, 35)
        Me.txtAmount.TabIndex = 30
        '
        'txtSource
        '
        Me.txtSource.Animated = True
        Me.txtSource.BorderRadius = 10
        Me.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSource.DefaultText = ""
        Me.txtSource.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSource.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSource.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSource.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSource.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSource.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSource.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSource.Location = New System.Drawing.Point(9, 9)
        Me.txtSource.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSource.PlaceholderText = "Source"
        Me.txtSource.SelectedText = ""
        Me.txtSource.Size = New System.Drawing.Size(260, 35)
        Me.txtSource.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(278, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(522, 450)
        Me.Guna2Panel2.TabIndex = 30
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(522, 450)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmIncome"
        Me.Text = "frmIncome"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnUpdateIncome As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddIncome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtSource As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class

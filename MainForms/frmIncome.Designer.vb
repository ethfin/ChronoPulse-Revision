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
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSource = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnAddIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
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
        Me.txtAmount.TabIndex = 9
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
        Me.txtSource.TabIndex = 8
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
        Me.dtpDate.TabIndex = 10
        Me.dtpDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'btnAddIncome
        '
        Me.btnAddIncome.Animated = True
        Me.btnAddIncome.BorderRadius = 15
        Me.btnAddIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddIncome.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAddIncome.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnAddIncome.ForeColor = System.Drawing.Color.White
        Me.btnAddIncome.IndicateFocus = True
        Me.btnAddIncome.Location = New System.Drawing.Point(12, 124)
        Me.btnAddIncome.Name = "btnAddIncome"
        Me.btnAddIncome.Size = New System.Drawing.Size(112, 45)
        Me.btnAddIncome.TabIndex = 11
        Me.btnAddIncome.Text = "Add"
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddIncome)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtSource)
        Me.Name = "frmIncome"
        Me.Text = "frmIncome"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtSource As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents btnAddIncome As Guna.UI2.WinForms.Guna2Button
End Class

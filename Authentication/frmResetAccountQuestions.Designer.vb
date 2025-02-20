<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetAccountQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetAccountQuestions))
        Me.panelLogin1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chkShowPassword2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.lblError = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtVerifyPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelLogin1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogin1
        '
        Me.panelLogin1.BackColor = System.Drawing.Color.GhostWhite
        Me.panelLogin1.Controls.Add(Me.chkShowPassword)
        Me.panelLogin1.Controls.Add(Me.chkShowPassword2)
        Me.panelLogin1.Controls.Add(Me.txtPassword)
        Me.panelLogin1.Controls.Add(Me.btnClose)
        Me.panelLogin1.Controls.Add(Me.btnMinimize)
        Me.panelLogin1.Controls.Add(Me.lblError)
        Me.panelLogin1.Controls.Add(Me.btnReset)
        Me.panelLogin1.Controls.Add(Me.LinkLabel1)
        Me.panelLogin1.Controls.Add(Me.txtVerifyPassword)
        Me.panelLogin1.Controls.Add(Me.Label1)
        Me.panelLogin1.Controls.Add(Me.lblWelcome1)
        Me.panelLogin1.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin1.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin1.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLogin1.Name = "panelLogin1"
        Me.panelLogin1.Size = New System.Drawing.Size(729, 546)
        Me.panelLogin1.TabIndex = 11
        '
        'chkShowPassword
        '
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 0
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.chkShowPassword.Location = New System.Drawing.Point(464, 282)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(199, 26)
        Me.chkShowPassword.TabIndex = 1
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 0
        Me.chkShowPassword.UncheckedState.BorderThickness = 0
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'chkShowPassword2
        '
        Me.chkShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.CheckedState.BorderRadius = 0
        Me.chkShowPassword2.CheckedState.BorderThickness = 0
        Me.chkShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.chkShowPassword2.Location = New System.Drawing.Point(464, 395)
        Me.chkShowPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowPassword2.Name = "chkShowPassword2"
        Me.chkShowPassword2.Size = New System.Drawing.Size(199, 26)
        Me.chkShowPassword2.TabIndex = 3
        Me.chkShowPassword2.Text = "Show Password"
        Me.chkShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword2.UncheckedState.BorderRadius = 0
        Me.chkShowPassword2.UncheckedState.BorderThickness = 0
        Me.chkShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword.BorderRadius = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(95, 229)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.MaxLength = 62
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(552, 44)
        Me.txtPassword.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.CheckedState.ForeColor = System.Drawing.Color.Red
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClose.IndicateFocus = True
        Me.btnClose.Location = New System.Drawing.Point(675, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 45
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseTransparentBackground = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.FillColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinimize.ForeColor = System.Drawing.Color.DimGray
        Me.btnMinimize.HoverState.FillColor = System.Drawing.Color.GhostWhite
        Me.btnMinimize.IndicateFocus = True
        Me.btnMinimize.Location = New System.Drawing.Point(637, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 37)
        Me.btnMinimize.TabIndex = 44
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseTransparentBackground = True
        '
        'lblError
        '
        Me.lblError.AutoSize = False
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(95, 428)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(552, 49)
        Me.lblError.TabIndex = 43
        Me.lblError.TabStop = False
        Me.lblError.Text = "Error"
        Me.lblError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BorderRadius = 2
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IndicateFocus = True
        Me.btnReset.Location = New System.Drawing.Point(251, 485)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(240, 55)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(605, 553)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 20)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "← Previous"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtVerifyPassword.BorderRadius = 2
        Me.txtVerifyPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerifyPassword.DefaultText = ""
        Me.txtVerifyPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVerifyPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtVerifyPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(95, 342)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVerifyPassword.MaxLength = 62
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPassword.PlaceholderText = "Re-enter Password"
        Me.txtVerifyPassword.SelectedText = ""
        Me.txtVerifyPassword.Size = New System.Drawing.Size(552, 44)
        Me.txtVerifyPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(89, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 66)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please enter your new password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome1
        '
        Me.lblWelcome1.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.lblWelcome1.Location = New System.Drawing.Point(19, 101)
        Me.lblWelcome1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(704, 39)
        Me.lblWelcome1.TabIndex = 10
        Me.lblWelcome1.Text = "Reset Account"
        Me.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 15)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(200, 85)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'frmResetAccountQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 546)
        Me.Controls.Add(Me.panelLogin1)
        Me.Name = "frmResetAccountQuestions"
        Me.Text = "frmResetAccountQuestions"
        Me.panelLogin1.ResumeLayout(False)
        Me.panelLogin1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLogin1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chkShowPassword2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblError As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtVerifyPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class

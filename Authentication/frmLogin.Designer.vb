<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.pnlLoginContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblErrorMsg = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lnklblResetAccount = New System.Windows.Forms.LinkLabel()
        Me.lnklblSignup = New System.Windows.Forms.LinkLabel()
        Me.guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.pbxBackground = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlLoginContainer.SuspendLayout()
        CType(Me.pbxBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoginContainer
        '
        Me.pnlLoginContainer.Controls.Add(Me.lblErrorMsg)
        Me.pnlLoginContainer.Controls.Add(Me.cbxShowPassword)
        Me.pnlLoginContainer.Controls.Add(Me.guna2HtmlLabel5)
        Me.pnlLoginContainer.Controls.Add(Me.guna2HtmlLabel3)
        Me.pnlLoginContainer.Controls.Add(Me.lnklblResetAccount)
        Me.pnlLoginContainer.Controls.Add(Me.lnklblSignup)
        Me.pnlLoginContainer.Controls.Add(Me.guna2HtmlLabel4)
        Me.pnlLoginContainer.Controls.Add(Me.btnLogin)
        Me.pnlLoginContainer.Controls.Add(Me.txtPassword)
        Me.pnlLoginContainer.Controls.Add(Me.txtUsername)
        Me.pnlLoginContainer.Controls.Add(Me.btnClose)
        Me.pnlLoginContainer.Controls.Add(Me.guna2HtmlLabel2)
        Me.pnlLoginContainer.Controls.Add(Me.guna2HtmlLabel1)
        Me.pnlLoginContainer.Controls.Add(Me.pbxBackground)
        Me.pnlLoginContainer.Controls.Add(Me.pbxLogo)
        Me.pnlLoginContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginContainer.FillColor = System.Drawing.Color.GhostWhite
        Me.pnlLoginContainer.Location = New System.Drawing.Point(1, 1)
        Me.pnlLoginContainer.Name = "pnlLoginContainer"
        Me.pnlLoginContainer.Padding = New System.Windows.Forms.Padding(60, 30, 30, 30)
        Me.pnlLoginContainer.Size = New System.Drawing.Size(973, 602)
        Me.pnlLoginContainer.TabIndex = 1
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.AutoSize = False
        Me.lblErrorMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorMsg.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorMsg.Location = New System.Drawing.Point(86, 526)
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.Size = New System.Drawing.Size(260, 43)
        Me.lblErrorMsg.TabIndex = 14
        Me.lblErrorMsg.TabStop = False
        Me.lblErrorMsg.Text = Nothing
        Me.lblErrorMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxShowPassword
        '
        Me.cbxShowPassword.AutoSize = True
        Me.cbxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.CheckedState.BorderRadius = 0
        Me.cbxShowPassword.CheckedState.BorderThickness = 0
        Me.cbxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.cbxShowPassword.Location = New System.Drawing.Point(86, 369)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(116, 19)
        Me.cbxShowPassword.TabIndex = 3
        Me.cbxShowPassword.Text = "Show Password"
        Me.cbxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'guna2HtmlLabel5
        '
        Me.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel5.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel5.Location = New System.Drawing.Point(86, 311)
        Me.guna2HtmlLabel5.Name = "guna2HtmlLabel5"
        Me.guna2HtmlLabel5.Size = New System.Drawing.Size(58, 17)
        Me.guna2HtmlLabel5.TabIndex = 13
        Me.guna2HtmlLabel5.TabStop = False
        Me.guna2HtmlLabel5.Text = "Password"
        '
        'guna2HtmlLabel3
        '
        Me.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel3.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel3.Location = New System.Drawing.Point(86, 248)
        Me.guna2HtmlLabel3.Name = "guna2HtmlLabel3"
        Me.guna2HtmlLabel3.Size = New System.Drawing.Size(60, 17)
        Me.guna2HtmlLabel3.TabIndex = 12
        Me.guna2HtmlLabel3.TabStop = False
        Me.guna2HtmlLabel3.Text = "Username"
        '
        'lnklblResetAccount
        '
        Me.lnklblResetAccount.AutoSize = True
        Me.lnklblResetAccount.Font = New System.Drawing.Font("Inter Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnklblResetAccount.LinkColor = System.Drawing.Color.Black
        Me.lnklblResetAccount.Location = New System.Drawing.Point(83, 490)
        Me.lnklblResetAccount.Name = "lnklblResetAccount"
        Me.lnklblResetAccount.Size = New System.Drawing.Size(89, 15)
        Me.lnklblResetAccount.TabIndex = 5
        Me.lnklblResetAccount.TabStop = True
        Me.lnklblResetAccount.Text = "Reset Account"
        '
        'lnklblSignup
        '
        Me.lnklblSignup.AutoSize = True
        Me.lnklblSignup.Font = New System.Drawing.Font("Inter Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnklblSignup.LinkColor = System.Drawing.Color.Black
        Me.lnklblSignup.Location = New System.Drawing.Point(201, 203)
        Me.lnklblSignup.Name = "lnklblSignup"
        Me.lnklblSignup.Size = New System.Drawing.Size(49, 15)
        Me.lnklblSignup.TabIndex = 0
        Me.lnklblSignup.TabStop = True
        Me.lnklblSignup.Text = "Sign up"
        '
        'guna2HtmlLabel4
        '
        Me.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel4.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel4.Location = New System.Drawing.Point(86, 470)
        Me.guna2HtmlLabel4.Name = "guna2HtmlLabel4"
        Me.guna2HtmlLabel4.Size = New System.Drawing.Size(260, 17)
        Me.guna2HtmlLabel4.TabIndex = 9
        Me.guna2HtmlLabel4.TabStop = False
        Me.guna2HtmlLabel4.Text = "Forgotten your password or your login details?"
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(86, 410)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(260, 45)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log In"
        '
        'guna2HtmlLabel2
        '
        Me.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel2.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel2.Location = New System.Drawing.Point(86, 203)
        Me.guna2HtmlLabel2.Name = "guna2HtmlLabel2"
        Me.guna2HtmlLabel2.Size = New System.Drawing.Size(109, 17)
        Me.guna2HtmlLabel2.TabIndex = 4
        Me.guna2HtmlLabel2.TabStop = False
        Me.guna2HtmlLabel2.Text = "Not registered yet?"
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(86, 157)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(238, 40)
        Me.guna2HtmlLabel1.TabIndex = 3
        Me.guna2HtmlLabel1.TabStop = False
        Me.guna2HtmlLabel1.Text = "Welcome Back"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.password
        Me.txtPassword.Location = New System.Drawing.Point(86, 331)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(260, 35)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtUsername.Location = New System.Drawing.Point(86, 268)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(260, 35)
        Me.txtUsername.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.HoverState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(931, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.UseTransparentBackground = True
        '
        'pbxBackground
        '
        Me.pbxBackground.BorderRadius = 30
        Me.pbxBackground.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pbxBackground.ImageRotate = 0!
        Me.pbxBackground.Location = New System.Drawing.Point(446, 33)
        Me.pbxBackground.Name = "pbxBackground"
        Me.pbxBackground.Size = New System.Drawing.Size(494, 539)
        Me.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBackground.TabIndex = 2
        Me.pbxBackground.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Dark
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(86, 33)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(75, 75)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 1
        Me.pbxLogo.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(975, 604)
        Me.Controls.Add(Me.pnlLoginContainer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.pnlLoginContainer.ResumeLayout(False)
        Me.pnlLoginContainer.PerformLayout()
        CType(Me.pbxBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents pnlLoginContainer As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents lnklblResetAccount As LinkLabel
    Private WithEvents lnklblSignup As LinkLabel
    Private WithEvents guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Private WithEvents guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pbxBackground As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblErrorMsg As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

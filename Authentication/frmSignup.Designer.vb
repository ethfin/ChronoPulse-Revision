<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignup))
        Me.pnlLoginContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.pnlSignUpProgress = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblErrorMsg = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lnklblSignup = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtVerifyPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbxBackground = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlLoginContainer.SuspendLayout()
        Me.pnlSignUpProgress.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoginContainer
        '
        Me.pnlLoginContainer.Controls.Add(Me.btnClose)
        Me.pnlLoginContainer.Controls.Add(Me.pnlSignUpProgress)
        Me.pnlLoginContainer.Controls.Add(Me.pbxBackground)
        Me.pnlLoginContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginContainer.FillColor = System.Drawing.Color.GhostWhite
        Me.pnlLoginContainer.Location = New System.Drawing.Point(1, 1)
        Me.pnlLoginContainer.Name = "pnlLoginContainer"
        Me.pnlLoginContainer.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlLoginContainer.Size = New System.Drawing.Size(973, 602)
        Me.pnlLoginContainer.TabIndex = 2
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
        'pnlSignUpProgress
        '
        Me.pnlSignUpProgress.Controls.Add(Me.lblTitle)
        Me.pnlSignUpProgress.Controls.Add(Me.Guna2HtmlLabel6)
        Me.pnlSignUpProgress.Controls.Add(Me.txtEmail)
        Me.pnlSignUpProgress.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnlSignUpProgress.Controls.Add(Me.txtPassword)
        Me.pnlSignUpProgress.Controls.Add(Me.lblErrorMsg)
        Me.pnlSignUpProgress.Controls.Add(Me.cbxShowPassword)
        Me.pnlSignUpProgress.Controls.Add(Me.guna2HtmlLabel5)
        Me.pnlSignUpProgress.Controls.Add(Me.guna2HtmlLabel3)
        Me.pnlSignUpProgress.Controls.Add(Me.lnklblSignup)
        Me.pnlSignUpProgress.Controls.Add(Me.btnLogin)
        Me.pnlSignUpProgress.Controls.Add(Me.txtVerifyPassword)
        Me.pnlSignUpProgress.Controls.Add(Me.txtUsername)
        Me.pnlSignUpProgress.Controls.Add(Me.guna2HtmlLabel2)
        Me.pnlSignUpProgress.Controls.Add(Me.guna2HtmlLabel1)
        Me.pnlSignUpProgress.Controls.Add(Me.pbxLogo)
        Me.pnlSignUpProgress.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSignUpProgress.Location = New System.Drawing.Point(530, 30)
        Me.pnlSignUpProgress.Name = "pnlSignUpProgress"
        Me.pnlSignUpProgress.Size = New System.Drawing.Size(413, 542)
        Me.pnlSignUpProgress.TabIndex = 16
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(87, 237)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(33, 17)
        Me.Guna2HtmlLabel6.TabIndex = 34
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.arroba
        Me.txtEmail.Location = New System.Drawing.Point(87, 257)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(260, 35)
        Me.txtEmail.TabIndex = 33
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(87, 295)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(58, 17)
        Me.Guna2HtmlLabel4.TabIndex = 32
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Password"
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
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.password
        Me.txtPassword.Location = New System.Drawing.Point(87, 315)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(260, 35)
        Me.txtPassword.TabIndex = 31
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.AutoSize = False
        Me.lblErrorMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorMsg.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorMsg.Location = New System.Drawing.Point(87, 489)
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.Size = New System.Drawing.Size(260, 43)
        Me.lblErrorMsg.TabIndex = 30
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
        Me.cbxShowPassword.Location = New System.Drawing.Point(87, 411)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(116, 19)
        Me.cbxShowPassword.TabIndex = 24
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
        Me.guna2HtmlLabel5.Location = New System.Drawing.Point(87, 353)
        Me.guna2HtmlLabel5.Name = "guna2HtmlLabel5"
        Me.guna2HtmlLabel5.Size = New System.Drawing.Size(105, 17)
        Me.guna2HtmlLabel5.TabIndex = 29
        Me.guna2HtmlLabel5.TabStop = False
        Me.guna2HtmlLabel5.Text = "Confirm Password"
        '
        'guna2HtmlLabel3
        '
        Me.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel3.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel3.Location = New System.Drawing.Point(87, 179)
        Me.guna2HtmlLabel3.Name = "guna2HtmlLabel3"
        Me.guna2HtmlLabel3.Size = New System.Drawing.Size(60, 17)
        Me.guna2HtmlLabel3.TabIndex = 28
        Me.guna2HtmlLabel3.TabStop = False
        Me.guna2HtmlLabel3.Text = "Username"
        '
        'lnklblSignup
        '
        Me.lnklblSignup.AutoSize = True
        Me.lnklblSignup.Font = New System.Drawing.Font("Inter Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnklblSignup.LinkColor = System.Drawing.Color.Black
        Me.lnklblSignup.Location = New System.Drawing.Point(306, 147)
        Me.lnklblSignup.Name = "lnklblSignup"
        Me.lnklblSignup.Size = New System.Drawing.Size(41, 15)
        Me.lnklblSignup.TabIndex = 20
        Me.lnklblSignup.TabStop = True
        Me.lnklblSignup.Text = "Log in"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(87, 438)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(260, 45)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "Sign Up"
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Animated = True
        Me.txtVerifyPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerifyPassword.DefaultText = ""
        Me.txtVerifyPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVerifyPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVerifyPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtVerifyPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVerifyPassword.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.password
        Me.txtVerifyPassword.Location = New System.Drawing.Point(87, 373)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtVerifyPassword.PlaceholderText = "Password"
        Me.txtVerifyPassword.SelectedText = ""
        Me.txtVerifyPassword.Size = New System.Drawing.Size(260, 35)
        Me.txtVerifyPassword.TabIndex = 23
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
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtUsername.Location = New System.Drawing.Point(87, 199)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(260, 35)
        Me.txtUsername.TabIndex = 21
        '
        'guna2HtmlLabel2
        '
        Me.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel2.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel2.Location = New System.Drawing.Point(151, 147)
        Me.guna2HtmlLabel2.Name = "guna2HtmlLabel2"
        Me.guna2HtmlLabel2.Size = New System.Drawing.Size(149, 17)
        Me.guna2HtmlLabel2.TabIndex = 27
        Me.guna2HtmlLabel2.TabStop = False
        Me.guna2HtmlLabel2.Text = "Already have an account?"
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(220, 101)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(127, 40)
        Me.guna2HtmlLabel1.TabIndex = 25
        Me.guna2HtmlLabel1.TabStop = False
        Me.guna2HtmlLabel1.Text = "Sign Up!"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Dark
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(272, 13)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(75, 75)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 22
        Me.pbxLogo.TabStop = False
        '
        'pbxBackground
        '
        Me.pbxBackground.BorderRadius = 30
        Me.pbxBackground.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbxBackground.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pbxBackground.Image = Global.ChronoPulse_Revision.My.Resources.Resources.background
        Me.pbxBackground.ImageRotate = 0!
        Me.pbxBackground.Location = New System.Drawing.Point(30, 30)
        Me.pbxBackground.Name = "pbxBackground"
        Me.pbxBackground.Size = New System.Drawing.Size(494, 542)
        Me.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBackground.TabIndex = 15
        Me.pbxBackground.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitle.AutoSize = False
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("DM Sans 14pt Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(155, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(111, 75)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "CHRONO PULSE"
        Me.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(975, 604)
        Me.Controls.Add(Me.pnlLoginContainer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSignup"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSignup"
        Me.pnlLoginContainer.ResumeLayout(False)
        Me.pnlSignUpProgress.ResumeLayout(False)
        Me.pnlSignUpProgress.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlLoginContainer As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Private WithEvents pbxBackground As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlSignUpProgress As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblErrorMsg As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents lnklblSignup As LinkLabel
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtVerifyPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

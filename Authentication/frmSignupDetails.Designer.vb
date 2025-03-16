<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignupDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignupDetails))
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblErrorMsg = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtVerifyPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(296, 114)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(63, 17)
        Me.Guna2HtmlLabel8.TabIndex = 59
        Me.Guna2HtmlLabel8.TabStop = False
        Me.Guna2HtmlLabel8.Text = "Last Name"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(28, 172)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(61, 17)
        Me.Guna2HtmlLabel7.TabIndex = 58
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.BorderRadius = 10
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
        Me.txtUsername.Location = New System.Drawing.Point(28, 192)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(504, 35)
        Me.txtUsername.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Animated = True
        Me.txtLastName.BorderRadius = 10
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtLastName.Location = New System.Drawing.Point(296, 134)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtLastName.PlaceholderText = "Last Name"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(236, 35)
        Me.txtLastName.TabIndex = 1
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(28, 227)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(35, 17)
        Me.Guna2HtmlLabel6.TabIndex = 54
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BorderRadius = 10
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
        Me.txtEmail.Location = New System.Drawing.Point(28, 247)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(504, 35)
        Me.txtEmail.TabIndex = 3
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(28, 285)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(57, 17)
        Me.Guna2HtmlLabel4.TabIndex = 52
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BorderRadius = 10
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
        Me.txtPassword.Location = New System.Drawing.Point(28, 305)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(504, 35)
        Me.txtPassword.TabIndex = 4
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.AutoSize = False
        Me.lblErrorMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorMsg.Location = New System.Drawing.Point(151, 404)
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.Size = New System.Drawing.Size(381, 66)
        Me.lblErrorMsg.TabIndex = 50
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
        Me.cbxShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbxShowPassword.Location = New System.Drawing.Point(31, 404)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(114, 19)
        Me.cbxShowPassword.TabIndex = 6
        Me.cbxShowPassword.Text = "Show Password"
        Me.cbxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'guna2HtmlLabel5
        '
        Me.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel5.Location = New System.Drawing.Point(28, 343)
        Me.guna2HtmlLabel5.Name = "guna2HtmlLabel5"
        Me.guna2HtmlLabel5.Size = New System.Drawing.Size(103, 17)
        Me.guna2HtmlLabel5.TabIndex = 49
        Me.guna2HtmlLabel5.TabStop = False
        Me.guna2HtmlLabel5.Text = "Confirm Password"
        '
        'guna2HtmlLabel3
        '
        Me.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel3.Location = New System.Drawing.Point(28, 114)
        Me.guna2HtmlLabel3.Name = "guna2HtmlLabel3"
        Me.guna2HtmlLabel3.Size = New System.Drawing.Size(63, 17)
        Me.guna2HtmlLabel3.TabIndex = 48
        Me.guna2HtmlLabel3.TabStop = False
        Me.guna2HtmlLabel3.Text = "First Name"
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Animated = True
        Me.txtVerifyPassword.BorderRadius = 10
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
        Me.txtVerifyPassword.Location = New System.Drawing.Point(28, 363)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtVerifyPassword.PlaceholderText = "Password"
        Me.txtVerifyPassword.SelectedText = ""
        Me.txtVerifyPassword.Size = New System.Drawing.Size(504, 35)
        Me.txtVerifyPassword.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Animated = True
        Me.txtFirstName.BorderRadius = 10
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtFirstName.Location = New System.Drawing.Point(28, 134)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.PlaceholderText = "First Name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(236, 35)
        Me.txtFirstName.TabIndex = 0
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(320, 49)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(212, 40)
        Me.guna2HtmlLabel1.TabIndex = 45
        Me.guna2HtmlLabel1.TabStop = False
        Me.guna2HtmlLabel1.Text = "Register here!"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(31, 35)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(150, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 60
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'frmSignupDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(560, 482)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblErrorMsg)
        Me.Controls.Add(Me.cbxShowPassword)
        Me.Controls.Add(Me.guna2HtmlLabel5)
        Me.Controls.Add(Me.guna2HtmlLabel3)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSignupDetails"
        Me.Text = "frmSignupDetails"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtVerifyPassword As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents lblErrorMsg As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class

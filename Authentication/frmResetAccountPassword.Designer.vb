<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResetAccountPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetAccountPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVerifyPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkShowPassword2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelLogin1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblError1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.lblError = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.Label1.Location = New System.Drawing.Point(89, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 66)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please enter your new password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtVerifyPassword.Location = New System.Drawing.Point(95, 302)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVerifyPassword.MaxLength = 62
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPassword.PlaceholderText = "Re-enter Password"
        Me.txtVerifyPassword.SelectedText = ""
        Me.txtVerifyPassword.Size = New System.Drawing.Size(552, 44)
        Me.txtVerifyPassword.TabIndex = 2
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
        Me.txtPassword.Location = New System.Drawing.Point(95, 190)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.MaxLength = 62
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(552, 44)
        Me.txtPassword.TabIndex = 0
        '
        'chkShowPassword2
        '
        Me.chkShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.CheckedState.BorderRadius = 0
        Me.chkShowPassword2.CheckedState.BorderThickness = 0
        Me.chkShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.chkShowPassword2.Location = New System.Drawing.Point(464, 354)
        Me.chkShowPassword2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowPassword2.Name = "chkShowPassword2"
        Me.chkShowPassword2.Size = New System.Drawing.Size(199, 26)
        Me.chkShowPassword2.TabIndex = 3
        Me.chkShowPassword2.Text = "Show Password"
        Me.chkShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword2.UncheckedState.BorderRadius = 0
        Me.chkShowPassword2.UncheckedState.BorderThickness = 0
        Me.chkShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'chkShowPassword
        '
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.CheckedState.BorderRadius = 0
        Me.chkShowPassword.CheckedState.BorderThickness = 0
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkShowPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.chkShowPassword.Location = New System.Drawing.Point(464, 242)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(199, 26)
        Me.chkShowPassword.TabIndex = 1
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkShowPassword.UncheckedState.BorderRadius = 0
        Me.chkShowPassword.UncheckedState.BorderThickness = 0
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(200, 85)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 44
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'panelLogin1
        '
        Me.panelLogin1.BackColor = System.Drawing.Color.GhostWhite
        Me.panelLogin1.Controls.Add(Me.lblError1)
        Me.panelLogin1.Controls.Add(Me.btnSubmit)
        Me.panelLogin1.Controls.Add(Me.lblWelcome1)
        Me.panelLogin1.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLogin1.Controls.Add(Me.chkShowPassword)
        Me.panelLogin1.Controls.Add(Me.chkShowPassword2)
        Me.panelLogin1.Controls.Add(Me.txtPassword)
        Me.panelLogin1.Controls.Add(Me.txtVerifyPassword)
        Me.panelLogin1.Controls.Add(Me.Label1)
        Me.panelLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin1.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelLogin1.Name = "panelLogin1"
        Me.panelLogin1.Size = New System.Drawing.Size(729, 546)
        Me.panelLogin1.TabIndex = 11
        '
        'lblError1
        '
        Me.lblError1.AutoSize = False
        Me.lblError1.BackColor = System.Drawing.Color.Transparent
        Me.lblError1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError1.ForeColor = System.Drawing.Color.Red
        Me.lblError1.Location = New System.Drawing.Point(95, 402)
        Me.lblError1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(552, 49)
        Me.lblError1.TabIndex = 50
        Me.lblError1.TabStop = False
        Me.lblError1.Text = "Error"
        Me.lblError1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError1.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 2
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.IndicateFocus = True
        Me.btnSubmit.Location = New System.Drawing.Point(251, 460)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(240, 55)
        Me.btnSubmit.TabIndex = 49
        Me.btnSubmit.Text = "Submit"
        '
        'lblWelcome1
        '
        Me.lblWelcome1.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.lblWelcome1.Location = New System.Drawing.Point(268, 26)
        Me.lblWelcome1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(461, 39)
        Me.lblWelcome1.TabIndex = 48
        Me.lblWelcome1.Text = "Reset Password"
        Me.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblError
        '
        Me.lblError.AutoSize = False
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(71, 348)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(414, 40)
        Me.lblError.TabIndex = 43
        Me.lblError.TabStop = False
        Me.lblError.Text = "Error"
        Me.lblError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'frmResetAccountPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 546)
        Me.Controls.Add(Me.panelLogin1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmResetAccountPassword"
        Me.Text = "frmResetAccountPassword"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVerifyPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkShowPassword2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelLogin1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblError As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblWelcome1 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblError1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

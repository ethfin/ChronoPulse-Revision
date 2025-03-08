<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetAccountSecurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResetAccountSecurity))
        Me.panelLogin1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lblQ1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblError = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbSQ1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSQA1Verify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSQA1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.txtSQA2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSQA2Verify = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSQ2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblError2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblQ2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbxShowPassword2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.panelLogin1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLogin1
        '
        Me.panelLogin1.Controls.Add(Me.btnReset)
        Me.panelLogin1.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLogin1.Controls.Add(Me.cbxShowPassword2)
        Me.panelLogin1.Controls.Add(Me.cbxShowPassword)
        Me.panelLogin1.Controls.Add(Me.lblQ2)
        Me.panelLogin1.Controls.Add(Me.lblQ1)
        Me.panelLogin1.Controls.Add(Me.lblError2)
        Me.panelLogin1.Controls.Add(Me.lblError)
        Me.panelLogin1.Controls.Add(Me.cmbSQ2)
        Me.panelLogin1.Controls.Add(Me.cmbSQ1)
        Me.panelLogin1.Controls.Add(Me.txtSQA2Verify)
        Me.panelLogin1.Controls.Add(Me.txtSQA2)
        Me.panelLogin1.Controls.Add(Me.txtSQA1Verify)
        Me.panelLogin1.Controls.Add(Me.txtSQA1)
        Me.panelLogin1.Controls.Add(Me.lblWelcome1)
        Me.panelLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin1.FillColor = System.Drawing.Color.GhostWhite
        Me.panelLogin1.FillColor2 = System.Drawing.Color.GhostWhite
        Me.panelLogin1.FillColor3 = System.Drawing.Color.GhostWhite
        Me.panelLogin1.FillColor4 = System.Drawing.Color.GhostWhite
        Me.panelLogin1.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin1.Name = "panelLogin1"
        Me.panelLogin1.Size = New System.Drawing.Size(547, 444)
        Me.panelLogin1.TabIndex = 11
        '
        'btnReset
        '
        Me.btnReset.Animated = True
        Me.btnReset.BorderRadius = 15
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IndicateFocus = True
        Me.btnReset.Location = New System.Drawing.Point(226, 374)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 47)
        Me.btnReset.TabIndex = 68
        Me.btnReset.Text = "Reset"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(150, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 67
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'cbxShowPassword
        '
        Me.cbxShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.cbxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.CheckedState.BorderRadius = 0
        Me.cbxShowPassword.CheckedState.BorderThickness = 0
        Me.cbxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!)
        Me.cbxShowPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbxShowPassword.Location = New System.Drawing.Point(290, 204)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(149, 21)
        Me.cbxShowPassword.TabIndex = 3
        Me.cbxShowPassword.Text = "Show Password"
        Me.cbxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword.UseVisualStyleBackColor = False
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = False
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(12, 83)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(216, 24)
        Me.lblQ1.TabIndex = 65
        Me.lblQ1.TabStop = False
        Me.lblQ1.Text = "Question 1:"
        Me.lblQ1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblError
        '
        Me.lblError.AutoSize = False
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(38, 159)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(175, 38)
        Me.lblError.TabIndex = 63
        Me.lblError.TabStop = False
        Me.lblError.Text = "Error"
        Me.lblError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'cmbSQ1
        '
        Me.cmbSQ1.BackColor = System.Drawing.Color.Transparent
        Me.cmbSQ1.BorderColor = System.Drawing.Color.Gray
        Me.cmbSQ1.BorderRadius = 2
        Me.cmbSQ1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSQ1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSQ1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSQ1.ItemHeight = 30
        Me.cmbSQ1.Items.AddRange(New Object() {"What was the name of your first stuffed animal or doll?", "In what city did your parents meet?", "What was the first concert you ever attended?", "What is the name of the street where you grew up?", "What was the make and model of your first car?", "What was the name of your favorite teacher in elementary school?", "What was your childhood best friend’s nickname?", "What’s your pet’s name?", "What’s your favorite color?", "What’s your lucky number?"})
        Me.cmbSQ1.Location = New System.Drawing.Point(10, 115)
        Me.cmbSQ1.Name = "cmbSQ1"
        Me.cmbSQ1.Size = New System.Drawing.Size(226, 36)
        Me.cmbSQ1.TabIndex = 0
        '
        'txtSQA1Verify
        '
        Me.txtSQA1Verify.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA1Verify.BorderRadius = 2
        Me.txtSQA1Verify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA1Verify.DefaultText = ""
        Me.txtSQA1Verify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1Verify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1Verify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1Verify.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA1Verify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1Verify.Location = New System.Drawing.Point(290, 159)
        Me.txtSQA1Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSQA1Verify.Name = "txtSQA1Verify"
        Me.txtSQA1Verify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA1Verify.PlaceholderText = "Re-enter Answer"
        Me.txtSQA1Verify.SelectedText = ""
        Me.txtSQA1Verify.Size = New System.Drawing.Size(216, 38)
        Me.txtSQA1Verify.TabIndex = 2
        '
        'txtSQA1
        '
        Me.txtSQA1.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA1.BorderRadius = 2
        Me.txtSQA1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA1.DefaultText = ""
        Me.txtSQA1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA1.Location = New System.Drawing.Point(290, 115)
        Me.txtSQA1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSQA1.Name = "txtSQA1"
        Me.txtSQA1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA1.PlaceholderText = "Answer"
        Me.txtSQA1.SelectedText = ""
        Me.txtSQA1.Size = New System.Drawing.Size(216, 38)
        Me.txtSQA1.TabIndex = 1
        '
        'lblWelcome1
        '
        Me.lblWelcome1.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.lblWelcome1.Location = New System.Drawing.Point(200, 34)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(346, 32)
        Me.lblWelcome1.TabIndex = 47
        Me.lblWelcome1.Text = "Security Questions"
        Me.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSQA2
        '
        Me.txtSQA2.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA2.BorderRadius = 2
        Me.txtSQA2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA2.DefaultText = ""
        Me.txtSQA2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2.Location = New System.Drawing.Point(290, 248)
        Me.txtSQA2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSQA2.Name = "txtSQA2"
        Me.txtSQA2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA2.PlaceholderText = "Answer"
        Me.txtSQA2.SelectedText = ""
        Me.txtSQA2.Size = New System.Drawing.Size(216, 38)
        Me.txtSQA2.TabIndex = 5
        '
        'txtSQA2Verify
        '
        Me.txtSQA2Verify.BorderColor = System.Drawing.Color.Gray
        Me.txtSQA2Verify.BorderRadius = 2
        Me.txtSQA2Verify.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQA2Verify.DefaultText = ""
        Me.txtSQA2Verify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2Verify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQA2Verify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2Verify.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQA2Verify.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQA2Verify.Location = New System.Drawing.Point(290, 292)
        Me.txtSQA2Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSQA2Verify.Name = "txtSQA2Verify"
        Me.txtSQA2Verify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQA2Verify.PlaceholderText = "Re-enter Answer"
        Me.txtSQA2Verify.SelectedText = ""
        Me.txtSQA2Verify.Size = New System.Drawing.Size(216, 38)
        Me.txtSQA2Verify.TabIndex = 6
        '
        'cmbSQ2
        '
        Me.cmbSQ2.BackColor = System.Drawing.Color.Transparent
        Me.cmbSQ2.BorderColor = System.Drawing.Color.Gray
        Me.cmbSQ2.BorderRadius = 2
        Me.cmbSQ2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSQ2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSQ2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSQ2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSQ2.ItemHeight = 30
        Me.cmbSQ2.Items.AddRange(New Object() {"What was the name of your first stuffed animal or doll?", "In what city did your parents meet?", "What was the first concert you ever attended?", "What is the name of the street where you grew up?", "What was the make and model of your first car?", "What was the name of your favorite teacher in elementary school?", "What was your childhood best friend’s nickname?", "What’s your pet’s name?", "What’s your favorite color?", "What’s your lucky number?"})
        Me.cmbSQ2.Location = New System.Drawing.Point(10, 250)
        Me.cmbSQ2.Name = "cmbSQ2"
        Me.cmbSQ2.Size = New System.Drawing.Size(226, 36)
        Me.cmbSQ2.TabIndex = 4
        '
        'lblError2
        '
        Me.lblError2.AutoSize = False
        Me.lblError2.BackColor = System.Drawing.Color.Transparent
        Me.lblError2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(38, 292)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(175, 38)
        Me.lblError2.TabIndex = 64
        Me.lblError2.TabStop = False
        Me.lblError2.Text = "Error"
        Me.lblError2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError2.Visible = False
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = False
        Me.lblQ2.BackColor = System.Drawing.Color.Transparent
        Me.lblQ2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(13, 219)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(216, 24)
        Me.lblQ2.TabIndex = 66
        Me.lblQ2.TabStop = False
        Me.lblQ2.Text = "Question 2:"
        Me.lblQ2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxShowPassword2
        '
        Me.cbxShowPassword2.BackColor = System.Drawing.Color.Transparent
        Me.cbxShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword2.CheckedState.BorderRadius = 0
        Me.cbxShowPassword2.CheckedState.BorderThickness = 0
        Me.cbxShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowPassword2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShowPassword2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cbxShowPassword2.Location = New System.Drawing.Point(290, 337)
        Me.cbxShowPassword2.Name = "cbxShowPassword2"
        Me.cbxShowPassword2.Size = New System.Drawing.Size(149, 21)
        Me.cbxShowPassword2.TabIndex = 7
        Me.cbxShowPassword2.Text = "Show Password"
        Me.cbxShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword2.UncheckedState.BorderRadius = 0
        Me.cbxShowPassword2.UncheckedState.BorderThickness = 0
        Me.cbxShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowPassword2.UseVisualStyleBackColor = False
        '
        'frmResetAccountSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 444)
        Me.Controls.Add(Me.panelLogin1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmResetAccountSecurity"
        Me.Text = "frmResetAccountSecurity"
        Me.panelLogin1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLogin1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblQ1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblError As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbSQ1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSQA1Verify As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSQA1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblWelcome1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbxShowPassword2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblQ2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblError2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbSQ2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSQA2Verify As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSQA2 As Guna.UI2.WinForms.Guna2TextBox
End Class

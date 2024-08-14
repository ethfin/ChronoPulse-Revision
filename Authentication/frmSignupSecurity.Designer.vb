<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignupSecurity
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
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblErrorMsg = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cmbQuestion1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbQuestion2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSQVAnswer1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSQAnswer1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSQVAnswer2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSQAnswer2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxShowAnswer2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbxShowAnswer1 = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitle.AutoSize = False
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("DM Sans 14pt Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(109, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(111, 75)
        Me.lblTitle.TabIndex = 55
        Me.lblTitle.Text = "CHRONO PULSE"
        Me.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.AutoSize = False
        Me.lblErrorMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorMsg.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorMsg.Location = New System.Drawing.Point(289, 29)
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.Size = New System.Drawing.Size(236, 43)
        Me.lblErrorMsg.TabIndex = 50
        Me.lblErrorMsg.TabStop = False
        Me.lblErrorMsg.Text = Nothing
        Me.lblErrorMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(28, 94)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(395, 40)
        Me.guna2HtmlLabel1.TabIndex = 45
        Me.guna2HtmlLabel1.TabStop = False
        Me.guna2HtmlLabel1.Text = "Set-up Security Questions"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Dark
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(28, 13)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(75, 75)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 42
        Me.pbxLogo.TabStop = False
        '
        'cmbQuestion1
        '
        Me.cmbQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.cmbQuestion1.BorderRadius = 10
        Me.cmbQuestion1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestion1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuestion1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbQuestion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbQuestion1.ItemHeight = 30
        Me.cmbQuestion1.Items.AddRange(New Object() {"What was the name of your first pet?", "What is your mother’s maiden name?", "What was the make and model of your first car?", "In what city were you born?", "What is the name of the town where you grew up?", "What was your favorite subject in school?", "What is your favorite childhood memory?", "What was the name of your elementary school?", "What was your childhood nickname?", "In what city did you meet your spouse/significant other?"})
        Me.cmbQuestion1.Location = New System.Drawing.Point(28, 167)
        Me.cmbQuestion1.Name = "cmbQuestion1"
        Me.cmbQuestion1.Size = New System.Drawing.Size(497, 36)
        Me.cmbQuestion1.TabIndex = 56
        '
        'cmbQuestion2
        '
        Me.cmbQuestion2.BackColor = System.Drawing.Color.Transparent
        Me.cmbQuestion2.BorderRadius = 10
        Me.cmbQuestion2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestion2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuestion2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbQuestion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbQuestion2.ItemHeight = 30
        Me.cmbQuestion2.Items.AddRange(New Object() {"What was the name of your first pet?", "What is your mother’s maiden name?", "What was the make and model of your first car?", "In what city were you born?", "What is the name of the town where you grew up?", "What was your favorite subject in school?", "What is your favorite childhood memory?", "What was the name of your elementary school?", "What was your childhood nickname?", "In what city did you meet your spouse/significant other?"})
        Me.cmbQuestion2.Location = New System.Drawing.Point(28, 315)
        Me.cmbQuestion2.Name = "cmbQuestion2"
        Me.cmbQuestion2.Size = New System.Drawing.Size(497, 36)
        Me.cmbQuestion2.TabIndex = 57
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(296, 209)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(92, 17)
        Me.Guna2HtmlLabel8.TabIndex = 63
        Me.Guna2HtmlLabel8.TabStop = False
        Me.Guna2HtmlLabel8.Text = "Confirm Answer"
        '
        'txtSQVAnswer1
        '
        Me.txtSQVAnswer1.Animated = True
        Me.txtSQVAnswer1.BorderRadius = 10
        Me.txtSQVAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQVAnswer1.DefaultText = ""
        Me.txtSQVAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQVAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQVAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQVAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQVAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQVAnswer1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQVAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQVAnswer1.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtSQVAnswer1.Location = New System.Drawing.Point(296, 229)
        Me.txtSQVAnswer1.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSQVAnswer1.Name = "txtSQVAnswer1"
        Me.txtSQVAnswer1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQVAnswer1.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSQVAnswer1.PlaceholderText = "Confirm Answer"
        Me.txtSQVAnswer1.SelectedText = ""
        Me.txtSQVAnswer1.Size = New System.Drawing.Size(229, 35)
        Me.txtSQVAnswer1.TabIndex = 62
        '
        'guna2HtmlLabel3
        '
        Me.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel3.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.guna2HtmlLabel3.Location = New System.Drawing.Point(28, 209)
        Me.guna2HtmlLabel3.Name = "guna2HtmlLabel3"
        Me.guna2HtmlLabel3.Size = New System.Drawing.Size(45, 17)
        Me.guna2HtmlLabel3.TabIndex = 61
        Me.guna2HtmlLabel3.TabStop = False
        Me.guna2HtmlLabel3.Text = "Answer"
        '
        'txtSQAnswer1
        '
        Me.txtSQAnswer1.Animated = True
        Me.txtSQAnswer1.BorderRadius = 10
        Me.txtSQAnswer1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQAnswer1.DefaultText = ""
        Me.txtSQAnswer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQAnswer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQAnswer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQAnswer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQAnswer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQAnswer1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQAnswer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQAnswer1.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtSQAnswer1.Location = New System.Drawing.Point(28, 229)
        Me.txtSQAnswer1.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSQAnswer1.Name = "txtSQAnswer1"
        Me.txtSQAnswer1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQAnswer1.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSQAnswer1.PlaceholderText = "Answer"
        Me.txtSQAnswer1.SelectedText = ""
        Me.txtSQAnswer1.Size = New System.Drawing.Size(229, 35)
        Me.txtSQAnswer1.TabIndex = 60
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(28, 144)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(65, 17)
        Me.Guna2HtmlLabel2.TabIndex = 64
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Question 1:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(28, 292)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(66, 17)
        Me.Guna2HtmlLabel4.TabIndex = 65
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Question 2:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(296, 357)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(92, 17)
        Me.Guna2HtmlLabel5.TabIndex = 69
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Confirm Answer"
        '
        'txtSQVAnswer2
        '
        Me.txtSQVAnswer2.Animated = True
        Me.txtSQVAnswer2.BorderRadius = 10
        Me.txtSQVAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQVAnswer2.DefaultText = ""
        Me.txtSQVAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQVAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQVAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQVAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQVAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQVAnswer2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQVAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQVAnswer2.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtSQVAnswer2.Location = New System.Drawing.Point(296, 377)
        Me.txtSQVAnswer2.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSQVAnswer2.Name = "txtSQVAnswer2"
        Me.txtSQVAnswer2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQVAnswer2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSQVAnswer2.PlaceholderText = "Confirm Answer"
        Me.txtSQVAnswer2.SelectedText = ""
        Me.txtSQVAnswer2.Size = New System.Drawing.Size(229, 35)
        Me.txtSQVAnswer2.TabIndex = 68
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(28, 357)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(45, 17)
        Me.Guna2HtmlLabel6.TabIndex = 67
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "Answer"
        '
        'txtSQAnswer2
        '
        Me.txtSQAnswer2.Animated = True
        Me.txtSQAnswer2.BorderRadius = 10
        Me.txtSQAnswer2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQAnswer2.DefaultText = ""
        Me.txtSQAnswer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSQAnswer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSQAnswer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQAnswer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSQAnswer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQAnswer2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSQAnswer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSQAnswer2.IconRight = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.txtSQAnswer2.Location = New System.Drawing.Point(28, 377)
        Me.txtSQAnswer2.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSQAnswer2.Name = "txtSQAnswer2"
        Me.txtSQAnswer2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQAnswer2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSQAnswer2.PlaceholderText = "Answer"
        Me.txtSQAnswer2.SelectedText = ""
        Me.txtSQAnswer2.Size = New System.Drawing.Size(229, 35)
        Me.txtSQAnswer2.TabIndex = 66
        '
        'cbxShowAnswer2
        '
        Me.cbxShowAnswer2.AutoSize = True
        Me.cbxShowAnswer2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowAnswer2.CheckedState.BorderRadius = 0
        Me.cbxShowAnswer2.CheckedState.BorderThickness = 0
        Me.cbxShowAnswer2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowAnswer2.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.cbxShowAnswer2.Location = New System.Drawing.Point(28, 415)
        Me.cbxShowAnswer2.Name = "cbxShowAnswer2"
        Me.cbxShowAnswer2.Size = New System.Drawing.Size(116, 19)
        Me.cbxShowAnswer2.TabIndex = 70
        Me.cbxShowAnswer2.Text = "Show Password"
        Me.cbxShowAnswer2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowAnswer2.UncheckedState.BorderRadius = 0
        Me.cbxShowAnswer2.UncheckedState.BorderThickness = 0
        Me.cbxShowAnswer2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'cbxShowAnswer1
        '
        Me.cbxShowAnswer1.AutoSize = True
        Me.cbxShowAnswer1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowAnswer1.CheckedState.BorderRadius = 0
        Me.cbxShowAnswer1.CheckedState.BorderThickness = 0
        Me.cbxShowAnswer1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxShowAnswer1.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.cbxShowAnswer1.Location = New System.Drawing.Point(28, 267)
        Me.cbxShowAnswer1.Name = "cbxShowAnswer1"
        Me.cbxShowAnswer1.Size = New System.Drawing.Size(116, 19)
        Me.cbxShowAnswer1.TabIndex = 71
        Me.cbxShowAnswer1.Text = "Show Password"
        Me.cbxShowAnswer1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxShowAnswer1.UncheckedState.BorderRadius = 0
        Me.cbxShowAnswer1.UncheckedState.BorderThickness = 0
        Me.cbxShowAnswer1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'frmSignupSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(560, 482)
        Me.Controls.Add(Me.cbxShowAnswer1)
        Me.Controls.Add(Me.cbxShowAnswer2)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.txtSQVAnswer2)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.txtSQAnswer2)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.txtSQVAnswer1)
        Me.Controls.Add(Me.guna2HtmlLabel3)
        Me.Controls.Add(Me.txtSQAnswer1)
        Me.Controls.Add(Me.cmbQuestion2)
        Me.Controls.Add(Me.cmbQuestion1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblErrorMsg)
        Me.Controls.Add(Me.guna2HtmlLabel1)
        Me.Controls.Add(Me.pbxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSignupSecurity"
        Me.Text = "frmSignupSecurity"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents cmbQuestion1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbQuestion2 As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents cbxShowAnswer2 As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents cbxShowAnswer1 As Guna.UI2.WinForms.Guna2CheckBox
    Public WithEvents txtSQVAnswer1 As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtSQAnswer1 As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtSQVAnswer2 As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtSQAnswer2 As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents lblErrorMsg As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

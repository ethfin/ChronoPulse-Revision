<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlLeaderboard = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLevel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prgExperience = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.pbxUser = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnOCR = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExpenses = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAI = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.cmsDropDown = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.cmsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlMenu.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDropDown.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.BorderRadius = 20
        Me.pnlContainer.BorderThickness = 1
        Me.pnlContainer.CustomBorderColor = System.Drawing.Color.Silver
        Me.pnlContainer.CustomizableEdges.BottomLeft = False
        Me.pnlContainer.CustomizableEdges.BottomRight = False
        Me.pnlContainer.CustomizableEdges.TopRight = False
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(259, 48)
        Me.pnlContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(27, 37, 27, 25)
        Me.pnlContainer.Size = New System.Drawing.Size(1453, 839)
        Me.pnlContainer.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(61, 14)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(133, 31)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenu.Controls.Add(Me.pnlLeaderboard)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.pbxLogo)
        Me.pnlMenu.Controls.Add(Me.Guna2Button1)
        Me.pnlMenu.Controls.Add(Me.Guna2Panel4)
        Me.pnlMenu.Controls.Add(Me.btnOCR)
        Me.pnlMenu.Controls.Add(Me.btnIncome)
        Me.pnlMenu.Controls.Add(Me.btnExpenses)
        Me.pnlMenu.Controls.Add(Me.btnAI)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.CustomBorderColor = System.Drawing.Color.White
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(259, 887)
        Me.pnlMenu.TabIndex = 4
        '
        'pnlLeaderboard
        '
        Me.pnlLeaderboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlLeaderboard.Location = New System.Drawing.Point(0, 531)
        Me.pnlLeaderboard.Name = "pnlLeaderboard"
        Me.pnlLeaderboard.Size = New System.Drawing.Size(256, 227)
        Me.pnlLeaderboard.TabIndex = 14
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderRadius = 10
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.ChronoPulse_Revision.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogout.IndicateFocus = True
        Me.btnLogout.Location = New System.Drawing.Point(15, 748)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(231, 55)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.UseTransparentBackground = True
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Light
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(11, 15)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(235, 123)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnQuests
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(15, 469)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(231, 55)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Quests"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 20
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.lblLevel)
        Me.Guna2Panel4.Controls.Add(Me.prgExperience)
        Me.Guna2Panel4.Controls.Add(Me.lblUsername)
        Me.Guna2Panel4.Controls.Add(Me.pbxUser)
        Me.Guna2Panel4.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel4.CustomizableEdges.BottomRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 811)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(259, 76)
        Me.Guna2Panel4.TabIndex = 11
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(195, 18)
        Me.lblLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(50, 21)
        Me.lblLevel.TabIndex = 22
        Me.lblLevel.Text = "Level 1"
        '
        'prgExperience
        '
        Me.prgExperience.BorderRadius = 5
        Me.prgExperience.Location = New System.Drawing.Point(61, 42)
        Me.prgExperience.Margin = New System.Windows.Forms.Padding(4)
        Me.prgExperience.Name = "prgExperience"
        Me.prgExperience.Size = New System.Drawing.Size(184, 20)
        Me.prgExperience.TabIndex = 21
        Me.prgExperience.Text = "Guna2ProgressBar1"
        Me.prgExperience.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'pbxUser
        '
        Me.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxUser.FillColor = System.Drawing.Color.Transparent
        Me.pbxUser.Image = Global.ChronoPulse_Revision.My.Resources.Resources.user_white
        Me.pbxUser.ImageRotate = 0!
        Me.pbxUser.Location = New System.Drawing.Point(15, 18)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(43, 39)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 0
        Me.pbxUser.TabStop = False
        '
        'btnOCR
        '
        Me.btnOCR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOCR.Animated = True
        Me.btnOCR.BackColor = System.Drawing.Color.Transparent
        Me.btnOCR.BorderRadius = 10
        Me.btnOCR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOCR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOCR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOCR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOCR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOCR.FillColor = System.Drawing.Color.Transparent
        Me.btnOCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnOCR.ForeColor = System.Drawing.Color.White
        Me.btnOCR.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ocr
        Me.btnOCR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOCR.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnOCR.IndicateFocus = True
        Me.btnOCR.Location = New System.Drawing.Point(15, 406)
        Me.btnOCR.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOCR.Name = "btnOCR"
        Me.btnOCR.Size = New System.Drawing.Size(231, 55)
        Me.btnOCR.TabIndex = 10
        Me.btnOCR.Text = "Scanner"
        Me.btnOCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOCR.UseTransparentBackground = True
        '
        'btnIncome
        '
        Me.btnIncome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIncome.Animated = True
        Me.btnIncome.BackColor = System.Drawing.Color.Transparent
        Me.btnIncome.BorderRadius = 10
        Me.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIncome.FillColor = System.Drawing.Color.Transparent
        Me.btnIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncome.ForeColor = System.Drawing.Color.White
        Me.btnIncome.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDIncome
        Me.btnIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIncome.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnIncome.IndicateFocus = True
        Me.btnIncome.Location = New System.Drawing.Point(15, 343)
        Me.btnIncome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(231, 55)
        Me.btnIncome.TabIndex = 7
        Me.btnIncome.Text = "Income"
        Me.btnIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIncome.UseTransparentBackground = True
        '
        'btnExpenses
        '
        Me.btnExpenses.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExpenses.Animated = True
        Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnExpenses.BorderRadius = 10
        Me.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExpenses.FillColor = System.Drawing.Color.Transparent
        Me.btnExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.White
        Me.btnExpenses.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDExpenses
        Me.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnExpenses.IndicateFocus = True
        Me.btnExpenses.Location = New System.Drawing.Point(15, 281)
        Me.btnExpenses.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(231, 55)
        Me.btnExpenses.TabIndex = 6
        Me.btnExpenses.Text = "Expenses"
        Me.btnExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.UseTransparentBackground = True
        '
        'btnAI
        '
        Me.btnAI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAI.Animated = True
        Me.btnAI.BackColor = System.Drawing.Color.Transparent
        Me.btnAI.BorderRadius = 10
        Me.btnAI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAI.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAI.FillColor = System.Drawing.Color.Transparent
        Me.btnAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAI.ForeColor = System.Drawing.Color.White
        Me.btnAI.Image = Global.ChronoPulse_Revision.My.Resources.Resources.chat_blue
        Me.btnAI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAI.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAI.IndicateFocus = True
        Me.btnAI.Location = New System.Drawing.Point(15, 218)
        Me.btnAI.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAI.Name = "btnAI"
        Me.btnAI.Size = New System.Drawing.Size(231, 55)
        Me.btnAI.TabIndex = 5
        Me.btnAI.Text = "Chatbot"
        Me.btnAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAI.UseTransparentBackground = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDashboard.Animated = True
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BorderRadius = 10
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dashboard_blue
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.IndicateFocus = True
        Me.btnDashboard.Location = New System.Drawing.Point(15, 155)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(231, 55)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.UseTransparentBackground = True
        '
        'ToolTip
        '
        Me.ToolTip.AllowLinksHandling = True
        Me.ToolTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        Me.ToolTip.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        '
        'cmsDropDown
        '
        Me.cmsDropDown.BackColor = System.Drawing.Color.GhostWhite
        Me.cmsDropDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmsDropDown.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDropDown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsLogout})
        Me.cmsDropDown.Name = "cmsDropDown"
        Me.cmsDropDown.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsDropDown.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmsDropDown.RenderStyle.ColorTable = Nothing
        Me.cmsDropDown.RenderStyle.RoundedEdges = True
        Me.cmsDropDown.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsDropDown.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsDropDown.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.cmsDropDown.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.cmsDropDown.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsDropDown.Size = New System.Drawing.Size(127, 30)
        '
        'cmsLogout
        '
        Me.cmsLogout.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.cmsLogout.Name = "cmsLogout"
        Me.cmsLogout.Size = New System.Drawing.Size(126, 26)
        Me.cmsLogout.Text = "Logout"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.HoverState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(1409, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.UseTransparentBackground = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.BorderColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.ForeColor = System.Drawing.Color.White
        Me.pnlTop.Location = New System.Drawing.Point(259, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1453, 48)
        Me.pnlTop.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1712, 887)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDropDown.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pbxUser As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents btnAI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmsDropDown As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents cmsLogout As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnExpenses As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIncome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOCR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents prgExperience As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lblLevel As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlLeaderboard As FlowLayoutPanel
End Class

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
        Me.ckbxTheme = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.lblCurrentPanel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbxUser = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLevel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prgExperience = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.btnOCR = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBudget = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSavings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExpenses = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAI = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.cmsDropDown = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.cmsSystemTray = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDropDown.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlContainer.CustomBorderColor = System.Drawing.Color.Silver
        Me.pnlContainer.CustomizableEdges.BottomLeft = False
        Me.pnlContainer.CustomizableEdges.BottomRight = False
        Me.pnlContainer.CustomizableEdges.TopRight = False
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(194, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContainer.Size = New System.Drawing.Size(1090, 661)
        Me.pnlContainer.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Pixelify Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(46, 11)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(100, 25)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckbxTheme
        '
        Me.ckbxTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckbxTheme.BackColor = System.Drawing.Color.Transparent
        Me.ckbxTheme.CheckedState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.light_mode
        Me.ckbxTheme.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbxTheme.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Image = Global.ChronoPulse_Revision.My.Resources.Resources.light_mode
        Me.ckbxTheme.ImageOffset = New System.Drawing.Point(0, 0)
        Me.ckbxTheme.ImageRotate = 0!
        Me.ckbxTheme.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.IndicateFocus = True
        Me.ckbxTheme.Location = New System.Drawing.Point(142, 515)
        Me.ckbxTheme.Name = "ckbxTheme"
        Me.ckbxTheme.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Size = New System.Drawing.Size(24, 24)
        Me.ckbxTheme.TabIndex = 1
        Me.ckbxTheme.UseTransparentBackground = True
        Me.ckbxTheme.Visible = False
        '
        'lblCurrentPanel
        '
        Me.lblCurrentPanel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCurrentPanel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPanel.Font = New System.Drawing.Font("Pixelify Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblCurrentPanel.Location = New System.Drawing.Point(12, 515)
        Me.lblCurrentPanel.Name = "lblCurrentPanel"
        Me.lblCurrentPanel.Size = New System.Drawing.Size(124, 27)
        Me.lblCurrentPanel.TabIndex = 1
        Me.lblCurrentPanel.Text = "Dashboard"
        Me.lblCurrentPanel.Visible = False
        '
        'pbxUser
        '
        Me.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxUser.FillColor = System.Drawing.Color.Transparent
        Me.pbxUser.Image = Global.ChronoPulse_Revision.My.Resources.Resources.user_white
        Me.pbxUser.ImageRotate = 0!
        Me.pbxUser.Location = New System.Drawing.Point(11, 15)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(32, 32)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 0
        Me.pbxUser.TabStop = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Guna2Button1)
        Me.pnlMenu.Controls.Add(Me.ckbxTheme)
        Me.pnlMenu.Controls.Add(Me.lblCurrentPanel)
        Me.pnlMenu.Controls.Add(Me.Guna2Panel4)
        Me.pnlMenu.Controls.Add(Me.btnOCR)
        Me.pnlMenu.Controls.Add(Me.btnBudget)
        Me.pnlMenu.Controls.Add(Me.btnSavings)
        Me.pnlMenu.Controls.Add(Me.btnIncome)
        Me.pnlMenu.Controls.Add(Me.btnExpenses)
        Me.pnlMenu.Controls.Add(Me.btnAI)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.Guna2Separator1)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.pbxLogo)
        Me.pnlMenu.CustomBorderColor = System.Drawing.Color.White
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(194, 661)
        Me.pnlMenu.TabIndex = 4
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.lblLevel)
        Me.Guna2Panel4.Controls.Add(Me.prgExperience)
        Me.Guna2Panel4.Controls.Add(Me.lblUsername)
        Me.Guna2Panel4.Controls.Add(Me.pbxUser)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 599)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(194, 62)
        Me.Guna2Panel4.TabIndex = 11
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(146, 15)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(38, 15)
        Me.lblLevel.TabIndex = 22
        Me.lblLevel.Text = "Level 1"
        '
        'prgExperience
        '
        Me.prgExperience.BorderRadius = 5
        Me.prgExperience.Location = New System.Drawing.Point(46, 34)
        Me.prgExperience.Name = "prgExperience"
        Me.prgExperience.Size = New System.Drawing.Size(138, 16)
        Me.prgExperience.TabIndex = 21
        Me.prgExperience.Text = "Guna2ProgressBar1"
        Me.prgExperience.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
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
        Me.btnOCR.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnOCR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnOCR.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ocr
        Me.btnOCR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOCR.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnOCR.IndicateFocus = True
        Me.btnOCR.Location = New System.Drawing.Point(11, 424)
        Me.btnOCR.Name = "btnOCR"
        Me.btnOCR.Size = New System.Drawing.Size(173, 45)
        Me.btnOCR.TabIndex = 10
        Me.btnOCR.Text = "OCR"
        Me.btnOCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOCR.UseTransparentBackground = True
        '
        'btnBudget
        '
        Me.btnBudget.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBudget.Animated = True
        Me.btnBudget.BackColor = System.Drawing.Color.Transparent
        Me.btnBudget.BorderRadius = 10
        Me.btnBudget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBudget.FillColor = System.Drawing.Color.Transparent
        Me.btnBudget.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnBudget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnBudget.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDBudget
        Me.btnBudget.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBudget.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBudget.IndicateFocus = True
        Me.btnBudget.Location = New System.Drawing.Point(11, 373)
        Me.btnBudget.Name = "btnBudget"
        Me.btnBudget.Size = New System.Drawing.Size(173, 45)
        Me.btnBudget.TabIndex = 9
        Me.btnBudget.Text = "Budget"
        Me.btnBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBudget.UseTransparentBackground = True
        '
        'btnSavings
        '
        Me.btnSavings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSavings.Animated = True
        Me.btnSavings.BackColor = System.Drawing.Color.Transparent
        Me.btnSavings.BorderRadius = 10
        Me.btnSavings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSavings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSavings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSavings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSavings.FillColor = System.Drawing.Color.Transparent
        Me.btnSavings.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSavings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSavings.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDSavings
        Me.btnSavings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSavings.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSavings.IndicateFocus = True
        Me.btnSavings.Location = New System.Drawing.Point(11, 322)
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Size = New System.Drawing.Size(173, 45)
        Me.btnSavings.TabIndex = 8
        Me.btnSavings.Text = "Goals"
        Me.btnSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSavings.UseTransparentBackground = True
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
        Me.btnIncome.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnIncome.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDIncome
        Me.btnIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIncome.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnIncome.IndicateFocus = True
        Me.btnIncome.Location = New System.Drawing.Point(11, 271)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(173, 45)
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
        Me.btnExpenses.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExpenses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnExpenses.Image = Global.ChronoPulse_Revision.My.Resources.Resources.btnDExpenses
        Me.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnExpenses.IndicateFocus = True
        Me.btnExpenses.Location = New System.Drawing.Point(11, 220)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(173, 45)
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
        Me.btnAI.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAI.Image = Global.ChronoPulse_Revision.My.Resources.Resources.chat_blue
        Me.btnAI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAI.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAI.IndicateFocus = True
        Me.btnAI.Location = New System.Drawing.Point(11, 169)
        Me.btnAI.Name = "btnAI"
        Me.btnAI.Size = New System.Drawing.Size(173, 45)
        Me.btnAI.TabIndex = 5
        Me.btnAI.Text = "AI Chatbot"
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
        Me.btnDashboard.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnDashboard.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dashboard_blue
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.IndicateFocus = True
        Me.btnDashboard.Location = New System.Drawing.Point(11, 118)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(173, 45)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.UseTransparentBackground = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(9, 87)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(176, 10)
        Me.Guna2Separator1.TabIndex = 3
        Me.Guna2Separator1.UseTransparentBackground = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btnLogout.IconColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(11, 548)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(173, 45)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Light
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(9, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(176, 69)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
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
        Me.cmsDropDown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsSystemTray, Me.cmsTheme, Me.cmsLogout})
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
        Me.cmsDropDown.Size = New System.Drawing.Size(145, 82)
        '
        'cmsSystemTray
        '
        Me.cmsSystemTray.CheckOnClick = True
        Me.cmsSystemTray.Name = "cmsSystemTray"
        Me.cmsSystemTray.Size = New System.Drawing.Size(144, 26)
        Me.cmsSystemTray.Text = "System Tray"
        '
        'cmsTheme
        '
        Me.cmsTheme.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dark_mode
        Me.cmsTheme.Name = "cmsTheme"
        Me.cmsTheme.Size = New System.Drawing.Size(144, 26)
        Me.cmsTheme.Text = "Light/Dark"
        '
        'cmsLogout
        '
        Me.cmsLogout.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.cmsLogout.Name = "cmsLogout"
        Me.cmsLogout.Size = New System.Drawing.Size(144, 26)
        Me.cmsLogout.Text = "Logout"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
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
        Me.Guna2Button1.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Guna2Button1.Image = Global.ChronoPulse_Revision.My.Resources.Resources.arroba
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(11, 475)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(173, 45)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "DEMO"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDropDown.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents lblCurrentPanel As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pbxUser As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Private WithEvents ckbxTheme As Guna.UI2.WinForms.Guna2ImageCheckBox
    Private WithEvents pbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents btnAI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmsDropDown As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents cmsSystemTray As ToolStripMenuItem
    Friend WithEvents cmsTheme As ToolStripMenuItem
    Friend WithEvents cmsLogout As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnExpenses As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIncome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSavings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBudget As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOCR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents prgExperience As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lblLevel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class

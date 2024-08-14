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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCurrentPanel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.cmsDropDown = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.cmsSystemTray = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ckbxTheme = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.pbxUser = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnGames = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cmsTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.cmsDropDown.SuspendLayout()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainer.BorderRadius = 15
        Me.pnlContainer.CustomBorderColor = System.Drawing.Color.Silver
        Me.pnlContainer.CustomizableEdges.BottomLeft = False
        Me.pnlContainer.CustomizableEdges.BottomRight = False
        Me.pnlContainer.CustomizableEdges.TopRight = False
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlContainer.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlContainer.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlContainer.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(92, 43)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlContainer.Size = New System.Drawing.Size(1192, 618)
        Me.pnlContainer.TabIndex = 5
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlHeader.Controls.Add(Me.lblUsername)
        Me.pnlHeader.Controls.Add(Me.ckbxTheme)
        Me.pnlHeader.Controls.Add(Me.lblCurrentPanel)
        Me.pnlHeader.Controls.Add(Me.pbxUser)
        Me.pnlHeader.CustomBorderColor = System.Drawing.Color.White
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(92, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1192, 43)
        Me.pnlHeader.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = False
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("DM Sans 14pt", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Location = New System.Drawing.Point(1056, 20)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(92, 17)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentPanel
        '
        Me.lblCurrentPanel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCurrentPanel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPanel.Font = New System.Drawing.Font("DM Sans 14pt", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentPanel.Location = New System.Drawing.Point(19, 17)
        Me.lblCurrentPanel.Name = "lblCurrentPanel"
        Me.lblCurrentPanel.Size = New System.Drawing.Size(88, 23)
        Me.lblCurrentPanel.TabIndex = 1
        Me.lblCurrentPanel.Text = "Dashboard"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlMenu.Controls.Add(Me.btnGames)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.Guna2Separator1)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.pbxLogo)
        Me.pnlMenu.CustomBorderColor = System.Drawing.Color.White
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(92, 661)
        Me.pnlMenu.TabIndex = 4
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(9, 87)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(74, 10)
        Me.Guna2Separator1.TabIndex = 3
        Me.Guna2Separator1.UseTransparentBackground = True
        '
        'ToolTip
        '
        Me.ToolTip.AllowLinksHandling = True
        Me.ToolTip.Font = New System.Drawing.Font("Inter", 9.0!)
        Me.ToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        Me.ToolTip.TitleFont = New System.Drawing.Font("Inter", 9.0!)
        '
        'cmsDropDown
        '
        Me.cmsDropDown.BackColor = System.Drawing.Color.GhostWhite
        Me.cmsDropDown.Font = New System.Drawing.Font("Inter", 9.0!)
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
        Me.cmsDropDown.Size = New System.Drawing.Size(145, 70)
        '
        'cmsSystemTray
        '
        Me.cmsSystemTray.CheckOnClick = True
        Me.cmsSystemTray.Name = "cmsSystemTray"
        Me.cmsSystemTray.Size = New System.Drawing.Size(144, 22)
        Me.cmsSystemTray.Text = "System Tray"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ckbxTheme
        '
        Me.ckbxTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckbxTheme.BackColor = System.Drawing.Color.Transparent
        Me.ckbxTheme.CheckedState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.light_mode
        Me.ckbxTheme.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckbxTheme.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dark_mode
        Me.ckbxTheme.ImageOffset = New System.Drawing.Point(0, 0)
        Me.ckbxTheme.ImageRotate = 0!
        Me.ckbxTheme.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.IndicateFocus = True
        Me.ckbxTheme.Location = New System.Drawing.Point(113, 13)
        Me.ckbxTheme.Name = "ckbxTheme"
        Me.ckbxTheme.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Size = New System.Drawing.Size(24, 24)
        Me.ckbxTheme.TabIndex = 1
        Me.ckbxTheme.UseTransparentBackground = True
        '
        'pbxUser
        '
        Me.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxUser.FillColor = System.Drawing.Color.Transparent
        Me.pbxUser.Image = Global.ChronoPulse_Revision.My.Resources.Resources.user
        Me.pbxUser.ImageRotate = 0!
        Me.pbxUser.Location = New System.Drawing.Point(1151, 5)
        Me.pbxUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxUser.Name = "pbxUser"
        Me.pbxUser.Size = New System.Drawing.Size(32, 32)
        Me.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxUser.TabIndex = 0
        Me.pbxUser.TabStop = False
        '
        'btnGames
        '
        Me.btnGames.Animated = True
        Me.btnGames.BackColor = System.Drawing.Color.Transparent
        Me.btnGames.BorderRadius = 10
        Me.btnGames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGames.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGames.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGames.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGames.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGames.FillColor = System.Drawing.Color.Transparent
        Me.btnGames.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGames.ForeColor = System.Drawing.Color.White
        Me.btnGames.Image = CType(resources.GetObject("btnGames.Image"), System.Drawing.Image)
        Me.btnGames.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnGames.IndicateFocus = True
        Me.btnGames.Location = New System.Drawing.Point(9, 154)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(74, 45)
        Me.btnGames.TabIndex = 5
        Me.btnGames.UseTransparentBackground = True
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
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.IndicateFocus = True
        Me.btnDashboard.Location = New System.Drawing.Point(9, 103)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(74, 45)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.UseTransparentBackground = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btnLogout.IconColor = System.Drawing.Color.Red
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.Location = New System.Drawing.Point(11, 579)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(70, 70)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.ChronoPulse_Revision.My.Resources.Resources.ChronoPulse_Logo_Dark
        Me.pbxLogo.ImageRotate = 0!
        Me.pbxLogo.Location = New System.Drawing.Point(9, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(74, 69)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'cmsTheme
        '
        Me.cmsTheme.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dark_mode
        Me.cmsTheme.Name = "cmsTheme"
        Me.cmsTheme.Size = New System.Drawing.Size(144, 22)
        Me.cmsTheme.Text = "Light/Dark"
        '
        'cmsLogout
        '
        Me.cmsLogout.Image = Global.ChronoPulse_Revision.My.Resources.Resources.close_red
        Me.cmsLogout.Name = "cmsLogout"
        Me.cmsLogout.Size = New System.Drawing.Size(144, 22)
        Me.cmsLogout.Text = "Logout"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.cmsDropDown.ResumeLayout(False)
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
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
    Friend WithEvents btnGames As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmsDropDown As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents cmsSystemTray As ToolStripMenuItem
    Friend WithEvents cmsTheme As ToolStripMenuItem
    Friend WithEvents cmsLogout As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

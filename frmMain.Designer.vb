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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ckbxTheme = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.lblCurrentPanel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbxUser = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.pbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvExpenses = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlContainer.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlContainer.BorderRadius = 15
        Me.pnlContainer.Controls.Add(Me.dgvExpenses)
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
        'ckbxTheme
        '
        Me.ckbxTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckbxTheme.CheckedState.Image = Global.ChronoPulse_Revision.My.Resources.Resources.light_mode
        Me.ckbxTheme.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Image = Global.ChronoPulse_Revision.My.Resources.Resources.dark_mode
        Me.ckbxTheme.ImageOffset = New System.Drawing.Point(0, 0)
        Me.ckbxTheme.ImageRotate = 0!
        Me.ckbxTheme.ImageSize = New System.Drawing.Size(30, 30)
        Me.ckbxTheme.Location = New System.Drawing.Point(113, 13)
        Me.ckbxTheme.Name = "ckbxTheme"
        Me.ckbxTheme.Size = New System.Drawing.Size(24, 24)
        Me.ckbxTheme.TabIndex = 1
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
        'pbxUser
        '
        Me.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.GhostWhite
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
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        'dgvExpenses
        '
        Me.dgvExpenses.AllowUserToResizeColumns = False
        Me.dgvExpenses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Inter Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvExpenses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExpenses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.dgvExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExpenses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExpenses.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Inter Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExpenses.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvExpenses.EnableHeadersVisualStyles = True
        Me.dgvExpenses.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvExpenses.Location = New System.Drawing.Point(33, 33)
        Me.dgvExpenses.Name = "dgvExpenses"
        Me.dgvExpenses.ReadOnly = True
        Me.dgvExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExpenses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExpenses.RowHeadersVisible = False
        Me.dgvExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvExpenses.RowTemplate.Height = 30
        Me.dgvExpenses.Size = New System.Drawing.Size(1126, 552)
        Me.dgvExpenses.TabIndex = 20
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.dgvExpenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvExpenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvExpenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvExpenses.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvExpenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvExpenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvExpenses.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvExpenses.ThemeStyle.ReadOnly = True
        Me.dgvExpenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvExpenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvExpenses.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvExpenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvExpenses.ThemeStyle.RowsStyle.Height = 30
        Me.dgvExpenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvExpenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvExpenses As Guna.UI2.WinForms.Guna2DataGridView
End Class

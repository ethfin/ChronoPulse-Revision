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
        Me.lnklblGoBack = New System.Windows.Forms.LinkLabel()
        Me.pnlLogin = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.pnlSignUpProgress = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSignup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLoginContainer.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLoginContainer
        '
        Me.pnlLoginContainer.Controls.Add(Me.lnklblGoBack)
        Me.pnlLoginContainer.Controls.Add(Me.pnlLogin)
        Me.pnlLoginContainer.Controls.Add(Me.btnClose)
        Me.pnlLoginContainer.Controls.Add(Me.pnlSignUpProgress)
        Me.pnlLoginContainer.Controls.Add(Me.btnSignup)
        Me.pnlLoginContainer.Controls.Add(Me.btnNext)
        Me.pnlLoginContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginContainer.FillColor = System.Drawing.Color.GhostWhite
        Me.pnlLoginContainer.Location = New System.Drawing.Point(1, 1)
        Me.pnlLoginContainer.Name = "pnlLoginContainer"
        Me.pnlLoginContainer.Padding = New System.Windows.Forms.Padding(30)
        Me.pnlLoginContainer.Size = New System.Drawing.Size(973, 602)
        Me.pnlLoginContainer.TabIndex = 2
        '
        'lnklblGoBack
        '
        Me.lnklblGoBack.AutoSize = True
        Me.lnklblGoBack.Font = New System.Drawing.Font("Inter Medium", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lnklblGoBack.LinkColor = System.Drawing.Color.Black
        Me.lnklblGoBack.Location = New System.Drawing.Point(383, 557)
        Me.lnklblGoBack.Name = "lnklblGoBack"
        Me.lnklblGoBack.Size = New System.Drawing.Size(55, 15)
        Me.lnklblGoBack.TabIndex = 62
        Me.lnklblGoBack.TabStop = True
        Me.lnklblGoBack.Text = "Go back"
        Me.lnklblGoBack.Visible = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.BorderRadius = 20
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.guna2HtmlLabel1)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLogin.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlLogin.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLogin.Location = New System.Drawing.Point(30, 30)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLogin.Size = New System.Drawing.Size(347, 542)
        Me.pnlLogin.TabIndex = 17
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(43, 297)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(260, 45)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log In"
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.AutoSize = False
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.GhostWhite
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(13, 202)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(321, 89)
        Me.guna2HtmlLabel1.TabIndex = 5
        Me.guna2HtmlLabel1.TabStop = False
        Me.guna2HtmlLabel1.Text = "Already have an Account?"
        Me.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlSignUpProgress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSignUpProgress.Location = New System.Drawing.Point(383, 30)
        Me.pnlSignUpProgress.Name = "pnlSignUpProgress"
        Me.pnlSignUpProgress.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlSignUpProgress.Size = New System.Drawing.Size(560, 482)
        Me.pnlSignUpProgress.TabIndex = 16
        '
        'btnSignup
        '
        Me.btnSignup.Animated = True
        Me.btnSignup.BorderRadius = 15
        Me.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignup.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnSignup.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.IndicateFocus = True
        Me.btnSignup.Location = New System.Drawing.Point(533, 523)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(260, 45)
        Me.btnSignup.TabIndex = 63
        Me.btnSignup.Text = "Sign up"
        Me.btnSignup.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Animated = True
        Me.btnNext.BorderRadius = 15
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.IndicateFocus = True
        Me.btnNext.Location = New System.Drawing.Point(533, 523)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(260, 45)
        Me.btnNext.TabIndex = 61
        Me.btnNext.Text = "Next"
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
        Me.pnlLoginContainer.PerformLayout()
        Me.pnlLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlLoginContainer As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents pnlSignUpProgress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents lnklblGoBack As LinkLabel
    Private WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnSignup As Guna.UI2.WinForms.Guna2Button
End Class

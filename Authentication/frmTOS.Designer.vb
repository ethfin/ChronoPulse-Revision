<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTOS
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
        Me.pnlTOS = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAccept = New Guna.UI2.WinForms.Guna2Button()
        Me.rtbTOS = New System.Windows.Forms.RichTextBox()
        Me.chbAgree = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.pnlTOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTOS
        '
        Me.pnlTOS.Controls.Add(Me.btnAccept)
        Me.pnlTOS.Controls.Add(Me.rtbTOS)
        Me.pnlTOS.Controls.Add(Me.chbAgree)
        Me.pnlTOS.Controls.Add(Me.btnClose)
        Me.pnlTOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTOS.FillColor = System.Drawing.Color.GhostWhite
        Me.pnlTOS.Location = New System.Drawing.Point(1, 1)
        Me.pnlTOS.Name = "pnlTOS"
        Me.pnlTOS.Padding = New System.Windows.Forms.Padding(30, 30, 30, 30)
        Me.pnlTOS.Size = New System.Drawing.Size(973, 602)
        Me.pnlTOS.TabIndex = 3
        '
        'btnAccept
        '
        Me.btnAccept.Animated = True
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.BorderRadius = 15
        Me.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccept.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAccept.Font = New System.Drawing.Font("Pixelify Sans", 12.0!)
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.IndicateFocus = True
        Me.btnAccept.Location = New System.Drawing.Point(356, 523)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(260, 45)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "Continue"
        '
        'rtbTOS
        '
        Me.rtbTOS.BackColor = System.Drawing.Color.GhostWhite
        Me.rtbTOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbTOS.Location = New System.Drawing.Point(33, 49)
        Me.rtbTOS.Name = "rtbTOS"
        Me.rtbTOS.Size = New System.Drawing.Size(907, 445)
        Me.rtbTOS.TabIndex = 2
        Me.rtbTOS.Text = ""
        '
        'chbAgree
        '
        Me.chbAgree.AutoSize = True
        Me.chbAgree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbAgree.CheckedState.BorderRadius = 0
        Me.chbAgree.CheckedState.BorderThickness = 0
        Me.chbAgree.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbAgree.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAgree.Location = New System.Drawing.Point(320, 494)
        Me.chbAgree.Name = "chbAgree"
        Me.chbAgree.Size = New System.Drawing.Size(333, 24)
        Me.chbAgree.TabIndex = 1
        Me.chbAgree.Text = "I agree to the Terms of Service (TOS)"
        Me.chbAgree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chbAgree.UncheckedState.BorderRadius = 0
        Me.chbAgree.UncheckedState.BorderThickness = 0
        Me.chbAgree.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        'frmTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(975, 604)
        Me.Controls.Add(Me.pnlTOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTOS"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTOS"
        Me.pnlTOS.ResumeLayout(False)
        Me.pnlTOS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlTOS As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents rtbTOS As RichTextBox
    Friend WithEvents chbAgree As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents btnAccept As Guna.UI2.WinForms.Guna2Button
End Class

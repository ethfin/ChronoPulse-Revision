<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAI
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
        Me.ChatHistoryRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClearHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.SendButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UserInputTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChatHistoryRichTextBox
        '
        Me.ChatHistoryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChatHistoryRichTextBox.Font = New System.Drawing.Font("Pixelify Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatHistoryRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.ChatHistoryRichTextBox.Name = "ChatHistoryRichTextBox"
        Me.ChatHistoryRichTextBox.ReadOnly = True
        Me.ChatHistoryRichTextBox.Size = New System.Drawing.Size(1176, 457)
        Me.ChatHistoryRichTextBox.TabIndex = 1
        Me.ChatHistoryRichTextBox.Text = ""
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnClearHistory)
        Me.Guna2Panel1.Controls.Add(Me.SendButton)
        Me.Guna2Panel1.Controls.Add(Me.UserInputTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 457)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1176, 122)
        Me.Guna2Panel1.TabIndex = 10
        '
        'btnClearHistory
        '
        Me.btnClearHistory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClearHistory.Animated = True
        Me.btnClearHistory.BorderRadius = 15
        Me.btnClearHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClearHistory.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearHistory.ForeColor = System.Drawing.Color.White
        Me.btnClearHistory.IndicateFocus = True
        Me.btnClearHistory.Location = New System.Drawing.Point(241, 30)
        Me.btnClearHistory.Name = "btnClearHistory"
        Me.btnClearHistory.Size = New System.Drawing.Size(112, 35)
        Me.btnClearHistory.TabIndex = 12
        Me.btnClearHistory.Text = "Clear"
        '
        'SendButton
        '
        Me.SendButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SendButton.Animated = True
        Me.SendButton.BorderRadius = 15
        Me.SendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SendButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.SendButton.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.ForeColor = System.Drawing.Color.White
        Me.SendButton.IndicateFocus = True
        Me.SendButton.Location = New System.Drawing.Point(829, 28)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(112, 35)
        Me.SendButton.TabIndex = 11
        Me.SendButton.Text = "Send"
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserInputTextBox.Animated = True
        Me.UserInputTextBox.BorderRadius = 10
        Me.UserInputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserInputTextBox.DefaultText = ""
        Me.UserInputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserInputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserInputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserInputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserInputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserInputTextBox.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserInputTextBox.Location = New System.Drawing.Point(356, 28)
        Me.UserInputTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.UserInputTextBox.PlaceholderText = "Type here..."
        Me.UserInputTextBox.SelectedText = ""
        Me.UserInputTextBox.Size = New System.Drawing.Size(470, 37)
        Me.UserInputTextBox.TabIndex = 10
        '
        'frmAI
        '
        Me.AcceptButton = Me.SendButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 579)
        Me.Controls.Add(Me.ChatHistoryRichTextBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAI"
        Me.Text = "frmAI"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChatHistoryRichTextBox As RichTextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClearHistory As Guna.UI2.WinForms.Guna2Button
    Private WithEvents SendButton As Guna.UI2.WinForms.Guna2Button
    Private WithEvents UserInputTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class

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
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.ChatHistoryRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.btnClearHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.Location = New System.Drawing.Point(12, 392)
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserInputTextBox.TabIndex = 0
        '
        'ChatHistoryRichTextBox
        '
        Me.ChatHistoryRichTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChatHistoryRichTextBox.Font = New System.Drawing.Font("Pixelify Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatHistoryRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.ChatHistoryRichTextBox.Name = "ChatHistoryRichTextBox"
        Me.ChatHistoryRichTextBox.ReadOnly = True
        Me.ChatHistoryRichTextBox.Size = New System.Drawing.Size(1176, 374)
        Me.ChatHistoryRichTextBox.TabIndex = 1
        Me.ChatHistoryRichTextBox.Text = ""
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(118, 389)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 2
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'btnClearHistory
        '
        Me.btnClearHistory.Location = New System.Drawing.Point(199, 389)
        Me.btnClearHistory.Name = "btnClearHistory"
        Me.btnClearHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnClearHistory.TabIndex = 3
        Me.btnClearHistory.Text = "Clear"
        Me.btnClearHistory.UseVisualStyleBackColor = True
        '
        'frmAI
        '
        Me.AcceptButton = Me.SendButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 579)
        Me.Controls.Add(Me.btnClearHistory)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.ChatHistoryRichTextBox)
        Me.Controls.Add(Me.UserInputTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAI"
        Me.Text = "frmAI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserInputTextBox As TextBox
    Friend WithEvents ChatHistoryRichTextBox As RichTextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents btnClearHistory As Button
End Class

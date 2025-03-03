<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOCR
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
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.rtbOCR = New System.Windows.Forms.RichTextBox()
        Me.rtbAIResponse = New System.Windows.Forms.RichTextBox()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.btnClearAIHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "openFileDialog"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 415)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Upload"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'rtbOCR
        '
        Me.rtbOCR.Location = New System.Drawing.Point(12, 12)
        Me.rtbOCR.Name = "rtbOCR"
        Me.rtbOCR.Size = New System.Drawing.Size(380, 397)
        Me.rtbOCR.TabIndex = 1
        Me.rtbOCR.Text = ""
        '
        'rtbAIResponse
        '
        Me.rtbAIResponse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbAIResponse.Location = New System.Drawing.Point(398, 12)
        Me.rtbAIResponse.Name = "rtbAIResponse"
        Me.rtbAIResponse.Size = New System.Drawing.Size(390, 397)
        Me.rtbAIResponse.TabIndex = 2
        Me.rtbAIResponse.Text = ""
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnalyze.Location = New System.Drawing.Point(632, 415)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalyze.TabIndex = 3
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'btnClearAIHistory
        '
        Me.btnClearAIHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearAIHistory.Location = New System.Drawing.Point(713, 415)
        Me.btnClearAIHistory.Name = "btnClearAIHistory"
        Me.btnClearAIHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAIHistory.TabIndex = 4
        Me.btnClearAIHistory.Text = "Clear"
        Me.btnClearAIHistory.UseVisualStyleBackColor = True
        '
        'frmOCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearAIHistory)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.rtbAIResponse)
        Me.Controls.Add(Me.rtbOCR)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Name = "frmOCR"
        Me.Text = "frmOCR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents rtbOCR As RichTextBox
    Friend WithEvents rtbAIResponse As RichTextBox
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents btnClearAIHistory As Button
End Class

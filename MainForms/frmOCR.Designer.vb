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
        Me.rtbAIResponse = New System.Windows.Forms.RichTextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClearAIHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUploadData = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAnalyze = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOpenFile = New Guna.UI2.WinForms.Guna2Button()
        Me.pbxScan = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pbxScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "openFileDialog"
        '
        'rtbAIResponse
        '
        Me.rtbAIResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.rtbAIResponse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbAIResponse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbAIResponse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rtbAIResponse.Location = New System.Drawing.Point(0, 0)
        Me.rtbAIResponse.Name = "rtbAIResponse"
        Me.rtbAIResponse.Size = New System.Drawing.Size(800, 384)
        Me.rtbAIResponse.TabIndex = 2
        Me.rtbAIResponse.Text = ""
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnClearAIHistory)
        Me.Guna2Panel1.Controls.Add(Me.btnUploadData)
        Me.Guna2Panel1.Controls.Add(Me.btnAnalyze)
        Me.Guna2Panel1.Controls.Add(Me.btnOpenFile)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 384)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 66)
        Me.Guna2Panel1.TabIndex = 6
        '
        'btnClearAIHistory
        '
        Me.btnClearAIHistory.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClearAIHistory.Animated = True
        Me.btnClearAIHistory.BorderRadius = 15
        Me.btnClearAIHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearAIHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearAIHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearAIHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearAIHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnClearAIHistory.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAIHistory.ForeColor = System.Drawing.Color.Black
        Me.btnClearAIHistory.IndicateFocus = True
        Me.btnClearAIHistory.Location = New System.Drawing.Point(676, 19)
        Me.btnClearAIHistory.Name = "btnClearAIHistory"
        Me.btnClearAIHistory.Size = New System.Drawing.Size(112, 35)
        Me.btnClearAIHistory.TabIndex = 4
        Me.btnClearAIHistory.Text = "Clear"
        '
        'btnUploadData
        '
        Me.btnUploadData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnUploadData.Animated = True
        Me.btnUploadData.BorderRadius = 15
        Me.btnUploadData.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadData.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUploadData.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUploadData.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadData.ForeColor = System.Drawing.Color.Black
        Me.btnUploadData.IndicateFocus = True
        Me.btnUploadData.Location = New System.Drawing.Point(558, 19)
        Me.btnUploadData.Name = "btnUploadData"
        Me.btnUploadData.Size = New System.Drawing.Size(112, 35)
        Me.btnUploadData.TabIndex = 3
        Me.btnUploadData.Text = "Save"
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAnalyze.Animated = True
        Me.btnAnalyze.BorderRadius = 15
        Me.btnAnalyze.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAnalyze.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAnalyze.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAnalyze.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAnalyze.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAnalyze.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalyze.ForeColor = System.Drawing.Color.Black
        Me.btnAnalyze.IndicateFocus = True
        Me.btnAnalyze.Location = New System.Drawing.Point(440, 19)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(112, 35)
        Me.btnAnalyze.TabIndex = 2
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.Visible = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnOpenFile.Animated = True
        Me.btnOpenFile.BorderRadius = 15
        Me.btnOpenFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOpenFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOpenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOpenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOpenFile.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnOpenFile.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenFile.IndicateFocus = True
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 19)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(112, 35)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "Scan"
        '
        'pbxScan
        '
        Me.pbxScan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxScan.BackColor = System.Drawing.Color.Transparent
        Me.pbxScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxScan.FillColor = System.Drawing.Color.Transparent
        Me.pbxScan.Image = Global.ChronoPulse_Revision.My.Resources.Resources.analysis
        Me.pbxScan.ImageRotate = 0!
        Me.pbxScan.Location = New System.Drawing.Point(341, 135)
        Me.pbxScan.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxScan.Name = "pbxScan"
        Me.pbxScan.Size = New System.Drawing.Size(95, 88)
        Me.pbxScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxScan.TabIndex = 7
        Me.pbxScan.TabStop = False
        Me.pbxScan.UseTransparentBackground = True
        '
        'frmOCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbxScan)
        Me.Controls.Add(Me.rtbAIResponse)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmOCR"
        Me.Text = "frmOCR"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.pbxScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openFileDialog As OpenFileDialog
    Friend WithEvents rtbAIResponse As RichTextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClearAIHistory As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnUploadData As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAnalyze As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnOpenFile As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pbxScan As Guna.UI2.WinForms.Guna2PictureBox
End Class

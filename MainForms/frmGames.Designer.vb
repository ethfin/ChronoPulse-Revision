<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGames
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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ListViewApps = New System.Windows.Forms.ListView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAddFiles = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteFiles = New Guna.UI2.WinForms.Guna2Button()
        Me.ListViewTrackApp = New System.Windows.Forms.ListView()
        Me.lblCurrentPanel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListViewAppsContext = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.AddApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListViewAppsContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'ListViewApps
        '
        Me.ListViewApps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewApps.HideSelection = False
        Me.ListViewApps.LargeImageList = Me.ImageList
        Me.ListViewApps.Location = New System.Drawing.Point(10, 59)
        Me.ListViewApps.Name = "ListViewApps"
        Me.ListViewApps.Size = New System.Drawing.Size(898, 259)
        Me.ListViewApps.TabIndex = 0
        Me.ListViewApps.UseCompatibleStateImageBehavior = False
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddFiles.Animated = True
        Me.btnAddFiles.AutoRoundedCorners = True
        Me.btnAddFiles.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFiles.BorderRadius = 18
        Me.btnAddFiles.DefaultAutoSize = True
        Me.btnAddFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddFiles.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAddFiles.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddFiles.ForeColor = System.Drawing.Color.White
        Me.btnAddFiles.IndicateFocus = True
        Me.btnAddFiles.Location = New System.Drawing.Point(10, 324)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(76, 38)
        Me.btnAddFiles.TabIndex = 1
        Me.btnAddFiles.Text = "Add"
        '
        'btnDeleteFiles
        '
        Me.btnDeleteFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteFiles.Animated = True
        Me.btnDeleteFiles.AutoRoundedCorners = True
        Me.btnDeleteFiles.BorderRadius = 18
        Me.btnDeleteFiles.DefaultAutoSize = True
        Me.btnDeleteFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteFiles.FillColor = System.Drawing.Color.Black
        Me.btnDeleteFiles.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteFiles.ForeColor = System.Drawing.Color.White
        Me.btnDeleteFiles.IndicateFocus = True
        Me.btnDeleteFiles.Location = New System.Drawing.Point(92, 324)
        Me.btnDeleteFiles.Name = "btnDeleteFiles"
        Me.btnDeleteFiles.Size = New System.Drawing.Size(101, 38)
        Me.btnDeleteFiles.TabIndex = 2
        Me.btnDeleteFiles.Text = "Delete"
        '
        'ListViewTrackApp
        '
        Me.ListViewTrackApp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewTrackApp.Font = New System.Drawing.Font("Inter Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewTrackApp.HideSelection = False
        Me.ListViewTrackApp.Location = New System.Drawing.Point(13, 413)
        Me.ListViewTrackApp.Name = "ListViewTrackApp"
        Me.ListViewTrackApp.Size = New System.Drawing.Size(892, 135)
        Me.ListViewTrackApp.TabIndex = 3
        Me.ListViewTrackApp.UseCompatibleStateImageBehavior = False
        '
        'lblCurrentPanel
        '
        Me.lblCurrentPanel.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPanel.Font = New System.Drawing.Font("DM Sans 14pt", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentPanel.Location = New System.Drawing.Point(13, 30)
        Me.lblCurrentPanel.Name = "lblCurrentPanel"
        Me.lblCurrentPanel.Size = New System.Drawing.Size(101, 23)
        Me.lblCurrentPanel.TabIndex = 4
        Me.lblCurrentPanel.Text = "Applications"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("DM Sans 14pt", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 384)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(76, 23)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Run Time"
        '
        'ListViewAppsContext
        '
        Me.ListViewAppsContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddApplicationToolStripMenuItem, Me.DeleteApplicationToolStripMenuItem})
        Me.ListViewAppsContext.Name = "Guna2ContextMenuStrip1"
        Me.ListViewAppsContext.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListViewAppsContext.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.ListViewAppsContext.RenderStyle.ColorTable = Nothing
        Me.ListViewAppsContext.RenderStyle.RoundedEdges = True
        Me.ListViewAppsContext.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.ListViewAppsContext.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListViewAppsContext.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ListViewAppsContext.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.ListViewAppsContext.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ListViewAppsContext.Size = New System.Drawing.Size(181, 70)
        '
        'AddApplicationToolStripMenuItem
        '
        Me.AddApplicationToolStripMenuItem.Name = "AddApplicationToolStripMenuItem"
        Me.AddApplicationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddApplicationToolStripMenuItem.Text = "Add"
        '
        'DeleteApplicationToolStripMenuItem
        '
        Me.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem"
        Me.DeleteApplicationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteApplicationToolStripMenuItem.Text = "Delete"
        '
        'frmGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 561)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.lblCurrentPanel)
        Me.Controls.Add(Me.ListViewTrackApp)
        Me.Controls.Add(Me.btnDeleteFiles)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Controls.Add(Me.ListViewApps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGames"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "frmLibrary"
        Me.ListViewAppsContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ListViewApps As ListView
    Friend WithEvents ImageList As ImageList
    Friend WithEvents btnAddFiles As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteFiles As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ListViewTrackApp As ListView
    Private WithEvents lblCurrentPanel As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ListViewAppsContext As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents AddApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteApplicationToolStripMenuItem As ToolStripMenuItem
End Class

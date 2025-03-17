<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIncome
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chrtPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnUpdateIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddIncome = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSource = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpIncome = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.chrtPie)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdateIncome)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnAddIncome)
        Me.Guna2Panel1.Controls.Add(Me.dtpDate)
        Me.Guna2Panel1.Controls.Add(Me.txtAmount)
        Me.Guna2Panel1.Controls.Add(Me.txtSource)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(278, 596)
        Me.Guna2Panel1.TabIndex = 29
        '
        'chrtPie
        '
        Me.chrtPie.BackColor = System.Drawing.Color.Transparent
        Me.chrtPie.BorderlineColor = System.Drawing.Color.Transparent
        Me.chrtPie.BorderlineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.chrtPie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtPie.Legends.Add(Legend1)
        Me.chrtPie.Location = New System.Drawing.Point(12, 247)
        Me.chrtPie.Name = "chrtPie"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtPie.Series.Add(Series1)
        Me.chrtPie.Size = New System.Drawing.Size(257, 328)
        Me.chrtPie.TabIndex = 35
        Me.chrtPie.Text = "Chart1"
        '
        'btnUpdateIncome
        '
        Me.btnUpdateIncome.Animated = True
        Me.btnUpdateIncome.BorderRadius = 15
        Me.btnUpdateIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateIncome.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateIncome.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateIncome.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateIncome.IndicateFocus = True
        Me.btnUpdateIncome.Location = New System.Drawing.Point(12, 165)
        Me.btnUpdateIncome.Name = "btnUpdateIncome"
        Me.btnUpdateIncome.Size = New System.Drawing.Size(257, 35)
        Me.btnUpdateIncome.TabIndex = 5
        Me.btnUpdateIncome.Text = "UPDATE"
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.BorderRadius = 15
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(12, 206)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(257, 35)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "EXPORT"
        '
        'btnAddIncome
        '
        Me.btnAddIncome.Animated = True
        Me.btnAddIncome.BorderRadius = 15
        Me.btnAddIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddIncome.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddIncome.Font = New System.Drawing.Font("Pixelify Sans", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddIncome.ForeColor = System.Drawing.Color.Black
        Me.btnAddIncome.IndicateFocus = True
        Me.btnAddIncome.Location = New System.Drawing.Point(12, 124)
        Me.btnAddIncome.Name = "btnAddIncome"
        Me.btnAddIncome.Size = New System.Drawing.Size(257, 35)
        Me.btnAddIncome.TabIndex = 4
        Me.btnAddIncome.Text = "ADD"
        '
        'dtpDate
        '
        Me.dtpDate.BorderRadius = 10
        Me.dtpDate.Checked = True
        Me.dtpDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpDate.Font = New System.Drawing.Font("Pixelify Sans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpDate.ForeColor = System.Drawing.SystemColors.Control
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(9, 82)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(260, 36)
        Me.dtpDate.TabIndex = 3
        Me.dtpDate.Value = New Date(2025, 2, 28, 13, 5, 3, 13)
        '
        'txtAmount
        '
        Me.txtAmount.Animated = True
        Me.txtAmount.BorderRadius = 10
        Me.txtAmount.BorderThickness = 0
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(9, 44)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtAmount.PlaceholderText = "AMOUNT"
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(260, 35)
        Me.txtAmount.TabIndex = 2
        '
        'txtSource
        '
        Me.txtSource.Animated = True
        Me.txtSource.BorderRadius = 10
        Me.txtSource.BorderThickness = 0
        Me.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSource.DefaultText = ""
        Me.txtSource.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSource.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSource.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSource.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSource.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtSource.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSource.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSource.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSource.Location = New System.Drawing.Point(9, 9)
        Me.txtSource.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSource.PlaceholderText = "SOURCE"
        Me.txtSource.SelectedText = ""
        Me.txtSource.Size = New System.Drawing.Size(260, 35)
        Me.txtSource.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.flpIncome)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(278, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(652, 596)
        Me.Guna2Panel2.TabIndex = 30
        '
        'flpIncome
        '
        Me.flpIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpIncome.Location = New System.Drawing.Point(0, 0)
        Me.flpIncome.Name = "flpIncome"
        Me.flpIncome.Size = New System.Drawing.Size(652, 596)
        Me.flpIncome.TabIndex = 0
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 596)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmIncome"
        Me.Text = "frmIncome"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnUpdateIncome As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddIncome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtSource As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpIncome As FlowLayoutPanel
    Friend WithEvents chrtPie As DataVisualization.Charting.Chart
End Class

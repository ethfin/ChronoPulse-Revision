<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvExpenses = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgExpenses = New System.Windows.Forms.DataGridView()
        Me.chCost = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chLine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chPie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExpenses
        '
        Me.dgvExpenses.AllowUserToResizeColumns = False
        Me.dgvExpenses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvExpenses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExpenses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgvExpenses.TabIndex = 21
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvExpenses.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
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
        'dgExpenses
        '
        Me.dgExpenses.AllowUserToAddRows = False
        Me.dgExpenses.AllowUserToDeleteRows = False
        Me.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExpenses.Location = New System.Drawing.Point(65, 72)
        Me.dgExpenses.Name = "dgExpenses"
        Me.dgExpenses.ReadOnly = True
        Me.dgExpenses.RowHeadersWidth = 51
        Me.dgExpenses.Size = New System.Drawing.Size(511, 223)
        Me.dgExpenses.TabIndex = 22
        '
        'chCost
        '
        ChartArea1.Name = "ChartArea1"
        Me.chCost.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chCost.Legends.Add(Legend1)
        Me.chCost.Location = New System.Drawing.Point(65, 312)
        Me.chCost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chCost.Name = "chCost"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chCost.Series.Add(Series1)
        Me.chCost.Size = New System.Drawing.Size(511, 247)
        Me.chCost.TabIndex = 23
        Me.chCost.Text = "Bar Chart"
        '
        'chPie
        '
        ChartArea2.Name = "ChartArea1"
        Me.chPie.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chPie.Legends.Add(Legend2)
        Me.chPie.Location = New System.Drawing.Point(602, 312)
        Me.chPie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chPie.Name = "chPie"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chPie.Series.Add(Series2)
        Me.chPie.Size = New System.Drawing.Size(437, 247)
        Me.chPie.TabIndex = 24
        Me.chPie.Text = "Pie Chart"
        '
        'chLine
        '
        ChartArea3.Name = "ChartArea1"
        Me.chLine.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chLine.Legends.Add(Legend3)
        Me.chLine.Location = New System.Drawing.Point(602, 72)
        Me.chLine.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chLine.Name = "chLine"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chLine.Series.Add(Series3)
        Me.chLine.Size = New System.Drawing.Size(437, 223)
        Me.chLine.TabIndex = 25
        Me.chLine.Text = "Line Chart"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1192, 618)
        Me.Controls.Add(Me.chLine)
        Me.Controls.Add(Me.chPie)
        Me.Controls.Add(Me.chCost)
        Me.Controls.Add(Me.dgExpenses)
        Me.Controls.Add(Me.dgvExpenses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chPie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvExpenses As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgExpenses As DataGridView
    Friend WithEvents chCost As DataVisualization.Charting.Chart
    Friend WithEvents chPie As DataVisualization.Charting.Chart
    Friend WithEvents chLine As DataVisualization.Charting.Chart
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.chrtLine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblCurrentMonthInc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCurrentMonthExp = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chrtPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalIncome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalExpenses = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flpDashboard = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblCurrentMonthBalance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalBalance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.chrtLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lblCurrentMonthBalance)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.chrtLine)
        Me.Guna2Panel1.Controls.Add(Me.lblCurrentMonthInc)
        Me.Guna2Panel1.Controls.Add(Me.lblCurrentMonthExp)
        Me.Guna2Panel1.Controls.Add(Me.chrtPie)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.flpDashboard)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1192, 618)
        Me.Guna2Panel1.TabIndex = 0
        '
        'chrtLine
        '
        Me.chrtLine.BackColor = System.Drawing.Color.Transparent
        ChartArea5.Name = "ChartArea1"
        Me.chrtLine.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chrtLine.Legends.Add(Legend5)
        Me.chrtLine.Location = New System.Drawing.Point(586, 296)
        Me.chrtLine.Name = "chrtLine"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.chrtLine.Series.Add(Series5)
        Me.chrtLine.Size = New System.Drawing.Size(475, 266)
        Me.chrtLine.TabIndex = 4
        Me.chrtLine.Text = "Chart1"
        '
        'lblCurrentMonthInc
        '
        Me.lblCurrentMonthInc.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentMonthInc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMonthInc.ForeColor = System.Drawing.Color.White
        Me.lblCurrentMonthInc.Location = New System.Drawing.Point(187, 12)
        Me.lblCurrentMonthInc.Name = "lblCurrentMonthInc"
        Me.lblCurrentMonthInc.Size = New System.Drawing.Size(73, 25)
        Me.lblCurrentMonthInc.TabIndex = 2
        Me.lblCurrentMonthInc.Text = "Income"
        '
        'lblCurrentMonthExp
        '
        Me.lblCurrentMonthExp.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentMonthExp.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMonthExp.ForeColor = System.Drawing.Color.White
        Me.lblCurrentMonthExp.Location = New System.Drawing.Point(12, 12)
        Me.lblCurrentMonthExp.Name = "lblCurrentMonthExp"
        Me.lblCurrentMonthExp.Size = New System.Drawing.Size(80, 25)
        Me.lblCurrentMonthExp.TabIndex = 1
        Me.lblCurrentMonthExp.Text = "Expense"
        '
        'chrtPie
        '
        Me.chrtPie.BackColor = System.Drawing.Color.Transparent
        Me.chrtPie.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea6.Name = "ChartArea1"
        Me.chrtPie.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.chrtPie.Legends.Add(Legend6)
        Me.chrtPie.Location = New System.Drawing.Point(586, 12)
        Me.chrtPie.Name = "chrtPie"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.chrtPie.Series.Add(Series6)
        Me.chrtPie.Size = New System.Drawing.Size(475, 278)
        Me.chrtPie.TabIndex = 3
        Me.chrtPie.Text = "Chart1"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.lblTotalIncome)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2Panel3.Location = New System.Drawing.Point(187, 43)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(169, 46)
        Me.Guna2Panel3.TabIndex = 2
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalIncome.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncome.ForeColor = System.Drawing.Color.White
        Me.lblTotalIncome.Location = New System.Drawing.Point(3, 7)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(57, 34)
        Me.lblTotalIncome.TabIndex = 1
        Me.lblTotalIncome.Text = "TEXT"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.lblTotalExpenses)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.IndianRed
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 43)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(169, 46)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpenses.ForeColor = System.Drawing.Color.White
        Me.lblTotalExpenses.Location = New System.Drawing.Point(3, 7)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(57, 34)
        Me.lblTotalExpenses.TabIndex = 0
        Me.lblTotalExpenses.Text = "TEXT"
        '
        'flpDashboard
        '
        Me.flpDashboard.AutoScroll = True
        Me.flpDashboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpDashboard.Location = New System.Drawing.Point(12, 95)
        Me.flpDashboard.Name = "flpDashboard"
        Me.flpDashboard.Size = New System.Drawing.Size(568, 511)
        Me.flpDashboard.TabIndex = 0
        '
        'lblCurrentMonthBalance
        '
        Me.lblCurrentMonthBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentMonthBalance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMonthBalance.ForeColor = System.Drawing.Color.White
        Me.lblCurrentMonthBalance.Location = New System.Drawing.Point(362, 12)
        Me.lblCurrentMonthBalance.Name = "lblCurrentMonthBalance"
        Me.lblCurrentMonthBalance.Size = New System.Drawing.Size(80, 25)
        Me.lblCurrentMonthBalance.TabIndex = 5
        Me.lblCurrentMonthBalance.Text = "Balance"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 10
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.lblTotalBalance)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.Orange
        Me.Guna2Panel4.Location = New System.Drawing.Point(362, 43)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(169, 46)
        Me.Guna2Panel4.TabIndex = 6
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalance.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.ForeColor = System.Drawing.Color.White
        Me.lblTotalBalance.Location = New System.Drawing.Point(3, 7)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(57, 34)
        Me.lblTotalBalance.TabIndex = 1
        Me.lblTotalBalance.Text = "TEXT"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1192, 618)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.chrtLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpDashboard As FlowLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalExpenses As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalIncome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCurrentMonthExp As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCurrentMonthInc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chrtPie As DataVisualization.Charting.Chart
    Friend WithEvents chrtLine As DataVisualization.Charting.Chart
    Friend WithEvents lblCurrentMonthBalance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalBalance As Guna.UI2.WinForms.Guna2HtmlLabel
End Class

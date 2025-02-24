Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard

    Private Sub LoadUserExpenses()
        Dim query As String = "SELECT Item AS ITEM, CONCAT('$', Cost) AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
        Dim dt As New DataTable()

        Using conn As MySqlConnection = Common.createDBConnection()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming Username is the UserID
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        dgExpenses.DataSource = dt
        dgExpenses.AllowUserToAddRows = False
        dgExpenses.BackgroundColor = Color.White
        dgExpenses.BorderStyle = BorderStyle.None
        dgExpenses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
        dgExpenses.DefaultCellStyle.SelectionForeColor = Color.Black
        dgExpenses.EnableHeadersVisualStyles = False
        dgExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgExpenses.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        dgExpenses.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        dgExpenses.RowHeadersVisible = False
        dgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
        dgExpenses.AllowUserToAddRows = False
        dgExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None

        ' Populate the charts with data
        PopulateChart(dt)
    End Sub

    Private Sub PopulateChart(dt As DataTable)
        ' Clear existing series
        chCost.Series.Clear()
        chPie.Series.Clear()
        chLine.Series.Clear()

        ' Create a new series for column chart
        Dim columnSeries As New Series("Expenses")
        columnSeries.ChartType = SeriesChartType.Column ' Change to Column for vertical bars
        columnSeries.Color = Color.FromArgb(0, 122, 204) ' Use a simple color for the bars

        ' Create a new series for pie chart
        Dim pieSeries As New Series("Expenses")
        pieSeries.ChartType = SeriesChartType.Pie ' Change to Pie for pie chart

        ' Create a new series for line chart
        Dim lineSeries As New Series("Expenses")
        lineSeries.ChartType = SeriesChartType.Line ' Change to Line for line chart
        lineSeries.Color = Color.FromArgb(0, 122, 204) ' Use a simple color for the line

        ' Add data points to the series
        For Each row As DataRow In dt.Rows
            Dim item As String = row("ITEM").ToString()
            Dim cost As Double = Convert.ToDouble(row("COST").ToString().Replace("$", ""))
            columnSeries.Points.AddXY(item, cost)
            pieSeries.Points.AddXY(item, cost)
            lineSeries.Points.AddXY(item, cost)
        Next

        ' Add the series to the charts
        chCost.Series.Add(columnSeries)
        chPie.Series.Add(pieSeries)
        chLine.Series.Add(lineSeries)

        ' Configure chart area for a minimalist design for column chart
        Dim chartArea As ChartArea = chCost.ChartAreas(0)
        chartArea.AxisX.MajorGrid.Enabled = False
        chartArea.AxisY.MajorGrid.Enabled = False
        chartArea.AxisX.MinorGrid.Enabled = False
        chartArea.AxisY.MinorGrid.Enabled = False
        chartArea.AxisX.LineColor = Color.Transparent
        chartArea.AxisY.LineColor = Color.Transparent
        chartArea.AxisX.LabelStyle.ForeColor = Color.Black
        chartArea.AxisY.LabelStyle.ForeColor = Color.Black
        chartArea.BackColor = Color.White
        chartArea.BorderColor = Color.Transparent

        ' Set axis titles for column chart
        chartArea.AxisX.Title = "Item"
        chartArea.AxisY.Title = "Cost"
        chartArea.AxisX.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
        chartArea.AxisY.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
        chartArea.AxisX.TitleForeColor = Color.Black
        chartArea.AxisY.TitleForeColor = Color.Black

        ' Remove the legend for column chart
        chCost.Legends.Clear()

        ' Configure pie chart area
        Dim pieChartArea As ChartArea = chPie.ChartAreas(0)
        pieChartArea.BackColor = Color.White
        pieChartArea.BorderColor = Color.Transparent

        ' Remove the legend for pie chart
        chPie.Legends.Clear()

        ' Configure line chart area
        Dim lineChartArea As ChartArea = chLine.ChartAreas(0)
        lineChartArea.AxisX.MajorGrid.Enabled = False
        lineChartArea.AxisY.MajorGrid.Enabled = False
        lineChartArea.AxisX.MinorGrid.Enabled = False
        lineChartArea.AxisY.MinorGrid.Enabled = False
        lineChartArea.AxisX.LineColor = Color.Transparent
        lineChartArea.AxisY.LineColor = Color.Transparent
        lineChartArea.AxisX.LabelStyle.ForeColor = Color.Black
        lineChartArea.AxisY.LabelStyle.ForeColor = Color.Black
        lineChartArea.BackColor = Color.White
        lineChartArea.BorderColor = Color.Transparent

        ' Set axis titles for line chart
        lineChartArea.AxisX.Title = "Item"
        lineChartArea.AxisY.Title = "Cost"
        lineChartArea.AxisX.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
        lineChartArea.AxisY.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
        lineChartArea.AxisX.TitleForeColor = Color.Black
        lineChartArea.AxisY.TitleForeColor = Color.Black

        ' Remove the legend for line chart
        chLine.Legends.Clear()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUserExpenses()
    End Sub
End Class
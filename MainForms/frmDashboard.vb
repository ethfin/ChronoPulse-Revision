Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard

    Private Sub LoadAllData()
        LoadUserExpenses()
        UpdateTotalExpensesLabel()
        UpdateTotalIncomeLabel()
        UpdateTotalBalanceLabel()
        LoadPieChart()
        LoadLineChart()
    End Sub

    Private Sub UpdateTotalBalanceLabel()
        Dim totalBalance As Decimal = GetCurrentTotalBalance()
        lblTotalBalance.Text = totalBalance.ToString("F2")
    End Sub

    Private Sub LoadLineChart()
        Dim incomeData As DataTable = GetCurrentMonthIncome()
        PopulateLineChart(incomeData)
    End Sub

    Private Sub PopulateLineChart(incomeData As DataTable)
        chrtLine.Series.Clear()
        Dim lineSeries As New Series("Income")
        lineSeries.ChartType = SeriesChartType.Line

        ' Set a gradient color for the line
        lineSeries.Color = Color.FromArgb(0, 122, 204) ' Start color
        lineSeries.BorderWidth = 3

        For Each row As DataRow In incomeData.Rows
            Dim dateValue As DateTime = Convert.ToDateTime(row("Date"))
            lineSeries.Points.AddXY(dateValue.ToString("MM/dd/yyyy"), Convert.ToDouble(row("Amount")))
        Next

        ' Add markers to the end points of the lines
        lineSeries.MarkerStyle = MarkerStyle.Circle
        lineSeries.MarkerSize = 8
        lineSeries.MarkerColor = Color.Blue

        chrtLine.Series.Add(lineSeries)

        ' Configure the legend
        chrtLine.Legends.Clear()
        Dim legend As New Legend()
        legend.Docking = Docking.Right
        legend.Font = New Font("Pixelify Sans", 10, FontStyle.Bold)
        legend.ForeColor = Color.White
        legend.BackColor = Color.Transparent
        chrtLine.Legends.Add(legend)

        ' Set the background color of the chart area to transparent
        chrtLine.ChartAreas(0).BackColor = Color.Transparent

        ' Set the font style and color for the chart series
        lineSeries.Font = New Font("Pixelify Sans", 10, FontStyle.Regular)
        lineSeries.LabelForeColor = Color.White

        ' Set the axis labels and lines to white
        Dim chartArea As ChartArea = chrtLine.ChartAreas(0)
        chartArea.AxisX.LabelStyle.ForeColor = Color.White
        chartArea.AxisY.LabelStyle.ForeColor = Color.White
        chartArea.AxisX.LineColor = Color.White
        chartArea.AxisY.LineColor = Color.White

        ' Disable the major and minor grid lines
        chartArea.AxisX.MajorGrid.Enabled = False
        chartArea.AxisY.MajorGrid.Enabled = False
        chartArea.AxisX.MinorGrid.Enabled = False
        chartArea.AxisY.MinorGrid.Enabled = False

        ' Add a title to the chart
        chrtLine.Titles.Clear()
        Dim title As New Title("Current Month Income")
        title.Font = New Font("Pixelify Sans", 14, FontStyle.Bold)
        title.ForeColor = Color.White
        chrtLine.Titles.Add(title)
    End Sub

    Private Function GetCurrentMonthIncome() As DataTable
        Dim dt As New DataTable()
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT Date, Amount FROM user_income WHERE UserID = @UserID AND MONTH(`Date`) = MONTH(CURRENT_DATE()) AND YEAR(`Date`) = YEAR(CURRENT_DATE())"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub LoadPieChart()
        Dim expensesData As DataTable = GetCurrentMonthExpensesByCategory()
        PopulatePieChart(expensesData)
    End Sub

    Private Sub PopulatePieChart(expensesData As DataTable)
        chrtPie.Series.Clear()
        Dim pieSeries As New Series("Expenses")
        pieSeries.ChartType = SeriesChartType.Pie

        Dim totalExpenses As Decimal = expensesData.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TotalCost"))

        For Each row As DataRow In expensesData.Rows
            Dim category As String = row("Category").ToString()
            Dim totalCost As Decimal = Convert.ToDouble(row("TotalCost"))
            Dim percentage As Decimal = (totalCost / totalExpenses) * 100
            Dim point As DataPoint = New DataPoint() With {
            .AxisLabel = $"{category} ({percentage:F2}%)",
            .YValues = New Double() {totalCost}
        }
            pieSeries.Points.Add(point)
        Next

        chrtPie.Series.Add(pieSeries)

        ' Configure the legend
        chrtPie.Legends.Clear()
        Dim legend As New Legend()
        legend.Docking = Docking.Right
        legend.Font = New Font("Pixelify Sans", 10, FontStyle.Bold)
        legend.ForeColor = Color.White
        legend.BackColor = Color.Transparent
        chrtPie.Legends.Add(legend)

        ' Set the background color of the chart area to transparent
        chrtPie.ChartAreas(0).BackColor = Color.Transparent

        ' Set the font style and color for the chart series
        pieSeries.Font = New Font("Pixelify Sans", 10, FontStyle.Regular)
        pieSeries.LabelForeColor = Color.White

        ' Hide labels inside the pie chart
        pieSeries.IsValueShownAsLabel = False
        pieSeries("PieLabelStyle") = "Disabled"

        ' Set the legend text to display the category names with percentages
        For Each point As DataPoint In pieSeries.Points
            point.LegendText = point.AxisLabel
        Next

        ' Add a title to the chart
        chrtPie.Titles.Clear()
        Dim title As New Title("Current Month")
        title.Font = New Font("Pixelify Sans", 14, FontStyle.Bold)
        title.ForeColor = Color.White
        chrtPie.Titles.Add(title)
    End Sub


    Private Function GetCurrentMonthExpensesByCategory() As DataTable
        Dim dt As New DataTable()
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT Category, SUM(Cost) AS TotalCost FROM user_expenses WHERE UserID = @UserID AND MONTH(`Date`) = MONTH(CURRENT_DATE()) AND YEAR(`Date`) = YEAR(CURRENT_DATE()) GROUP BY Category"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub UpdateTotalExpensesLabel()
        Dim totalExpenses As Decimal = GetTotalExpenses()
        lblTotalExpenses.Text = "-" & totalExpenses.ToString("F2")
    End Sub

    Private Sub UpdateTotalIncomeLabel()
        Dim totalIncome As Decimal = GetTotalIncome()
        lblTotalIncome.Text = "+" & totalIncome.ToString("F2")
    End Sub

    Private Function GetCurrentTotalBalance() As Decimal
        Dim totalIncome As Decimal = GetTotalIncome()
        Dim totalExpenses As Decimal = GetTotalExpenses()
        Return totalIncome - totalExpenses
    End Function


    Private Function GetTotalExpenses() As Decimal
        Dim totalExpenses As Decimal = 0
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT COALESCE(SUM(Cost), 0) AS TotalExpenses FROM user_expenses WHERE UserID = @UserID AND MONTH(`Date`) = MONTH(CURRENT_DATE()) AND YEAR(`Date`) = YEAR(CURRENT_DATE())"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                totalExpenses = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return totalExpenses
    End Function

    Private Function GetTotalIncome() As Decimal
        Dim totalIncome As Decimal = 0
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT COALESCE(SUM(Amount), 0) AS TotalIncome FROM user_income WHERE UserID = @UserID AND MONTH(`Date`) = MONTH(CURRENT_DATE()) AND YEAR(`Date`) = YEAR(CURRENT_DATE())"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                totalIncome = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return totalIncome
    End Function

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllData()
        flpDashboard.FlowDirection = FlowDirection.TopDown
        flpDashboard.WrapContents = False  ' Add this line
        flpDashboard.AutoScroll = True     ' Ensure this is set to True
        flpDashboard.AutoScrollMinSize = New Size(0, 0)  ' Reset this if needed
        lblCurrentMonthExp.Text = DateTime.Now.ToString("MMMM") & " Expenses"
        lblCurrentMonthInc.Text = DateTime.Now.ToString("MMMM") & " Income"
        lblCurrentMonthBalance.Text = DateTime.Now.ToString("MMMM") & " Balance"
    End Sub

    Private Sub LoadUserExpenses()
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT Item, Cost, Category, Description, Date FROM user_expenses WHERE UserID = @UserID ORDER BY Date DESC"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        MessageBox.Show("No expenses found for the user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    While reader.Read()
                        Dim item As String = reader("Item").ToString()
                        Dim cost As Decimal = CDec(reader("Cost"))
                        Dim category As String = reader("Category").ToString()
                        Dim description As String = reader("Description").ToString()
                        Dim dateValue As DateTime = CDate(reader("Date"))

                        CreateExpensePanel(item, cost, category, description, dateValue)
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub CreateExpensePanel(item As String, cost As Decimal, category As String, description As String, dateValue As DateTime)
        Dim expensePanel As New Guna.UI2.WinForms.Guna2Panel With {
            .FillColor = Color.FromArgb(13, 17, 64),
            .Size = New Size(530, 60),
            .BorderStyle = BorderStyle.FixedSingle,
            .BorderRadius = 10,
            .Enabled = False ' Disable the panel
        }

        Dim lblItem As New Label With {
            .Text = item,
            .Location = New Point(10, 10),
            .AutoSize = False,
            .Size = New Size(110, 20),
            .ForeColor = Color.White,
            .Font = New Font("Pixelify Sans", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        expensePanel.Controls.Add(lblItem)

        Dim lblCost As New Label With {
            .Text = "Cost: " & cost.ToString("F2"),
            .Location = New Point(10, 30),
            .AutoSize = False,
            .Size = New Size(100, 20),
            .ForeColor = Color.White,
            .Font = New Font("Pixelify Sans", 9.75F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        expensePanel.Controls.Add(lblCost)

        Dim lblCategory As New Label With {
            .Text = "Category: " & category,
            .Location = New Point(130, 10),
            .AutoSize = False,
            .Size = New Size(200, 20),
            .ForeColor = Color.White,
            .Font = New Font("Pixelify Sans", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        expensePanel.Controls.Add(lblCategory)

        Dim lblDate As New Label With {
            .Text = "Date: " & dateValue.ToShortDateString(),
            .Location = New Point(130, 30),
            .AutoSize = False,
            .Size = New Size(120, 20),
            .ForeColor = Color.White,
            .Font = New Font("Pixelify Sans", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        expensePanel.Controls.Add(lblDate)

        Dim lblDescription As New Label With {
            .Text = "Note: " & description,
            .Location = New Point(350, 10),
            .AutoSize = False,
            .Size = New Size(200, 20),
            .ForeColor = Color.White,
            .Font = New Font("Pixelify Sans", 9.75F, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleLeft,
            .BackColor = Color.Transparent
        }
        expensePanel.Controls.Add(lblDescription)

        flpDashboard.Controls.Add(expensePanel)
    End Sub

    'Private Sub LoadUserExpenses()
    '    Dim query As String = "SELECT Item AS ITEM, CONCAT('$', Cost) AS COST, Category AS CATEGORY, Description AS DESCRIPTION, DATE_FORMAT(date, '%m/%d/%Y') AS DATE FROM user_expenses WHERE UserID = @UserID"
    '    Dim dt As New DataTable()

    '    Using conn As MySqlConnection = Common.createDBConnection()
    '        Using cmd As New MySqlCommand(query, conn)
    '            cmd.Parameters.AddWithValue("@UserID", AccountData.UserID) ' Assuming Username is the UserID
    '            conn.Open()
    '            Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                dt.Load(reader)
    '            End Using
    '        End Using
    '    End Using

    '    dgExpenses.DataSource = dt
    '    dgExpenses.AllowUserToAddRows = False
    '    dgExpenses.BackgroundColor = Color.White
    '    dgExpenses.BorderStyle = BorderStyle.None
    '    dgExpenses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245)
    '    dgExpenses.DefaultCellStyle.SelectionForeColor = Color.Black
    '    dgExpenses.EnableHeadersVisualStyles = False
    '    dgExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
    '    dgExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.White
    '    dgExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
    '    dgExpenses.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    '    dgExpenses.DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
    '    dgExpenses.RowHeadersVisible = False
    '    dgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '    dgExpenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
    '    dgExpenses.AllowUserToAddRows = False
    '    dgExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None

    '    ' Populate the charts with data
    '    PopulateChart(dt)
    'End Sub

    'Private Sub PopulateChart(dt As DataTable)
    '    ' Clear existing series
    '    chCost.Series.Clear()
    '    chPie.Series.Clear()
    '    chLine.Series.Clear()

    '    ' Create a new series for column chart
    '    Dim columnSeries As New Series("Expenses")
    '    columnSeries.ChartType = SeriesChartType.Column ' Change to Column for vertical bars
    '    columnSeries.Color = Color.FromArgb(0, 122, 204) ' Use a simple color for the bars

    '    ' Create a new series for pie chart
    '    Dim pieSeries As New Series("Expenses")
    '    pieSeries.ChartType = SeriesChartType.Pie ' Change to Pie for pie chart

    '    ' Create a new series for line chart
    '    Dim lineSeries As New Series("Expenses")
    '    lineSeries.ChartType = SeriesChartType.Line ' Change to Line for line chart
    '    lineSeries.Color = Color.FromArgb(0, 122, 204) ' Use a simple color for the line

    '    ' Add data points to the series
    '    For Each row As DataRow In dt.Rows
    '        Dim item As String = row("ITEM").ToString()
    '        Dim cost As Double = Convert.ToDouble(row("COST").ToString().Replace("$", ""))
    '        columnSeries.Points.AddXY(item, cost)
    '        pieSeries.Points.AddXY(item, cost)
    '        lineSeries.Points.AddXY(item, cost)
    '    Next

    '    ' Add the series to the charts
    '    chCost.Series.Add(columnSeries)
    '    chPie.Series.Add(pieSeries)
    '    chLine.Series.Add(lineSeries)

    '    ' Configure chart area for a minimalist design for column chart
    '    Dim chartArea As ChartArea = chCost.ChartAreas(0)
    '    chartArea.AxisX.MajorGrid.Enabled = False
    '    chartArea.AxisY.MajorGrid.Enabled = False
    '    chartArea.AxisX.MinorGrid.Enabled = False
    '    chartArea.AxisY.MinorGrid.Enabled = False
    '    chartArea.AxisX.LineColor = Color.Transparent
    '    chartArea.AxisY.LineColor = Color.Transparent
    '    chartArea.AxisX.LabelStyle.ForeColor = Color.Black
    '    chartArea.AxisY.LabelStyle.ForeColor = Color.Black
    '    chartArea.BackColor = Color.White
    '    chartArea.BorderColor = Color.Transparent

    '    ' Set axis titles for column chart
    '    chartArea.AxisX.Title = "Item"
    '    chartArea.AxisY.Title = "Cost"
    '    chartArea.AxisX.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
    '    chartArea.AxisY.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
    '    chartArea.AxisX.TitleForeColor = Color.Black
    '    chartArea.AxisY.TitleForeColor = Color.Black

    '    ' Remove the legend for column chart
    '    chCost.Legends.Clear()

    '    ' Configure pie chart area
    '    Dim pieChartArea As ChartArea = chPie.ChartAreas(0)
    '    pieChartArea.BackColor = Color.White
    '    pieChartArea.BorderColor = Color.Transparent

    '    ' Remove the legend for pie chart
    '    chPie.Legends.Clear()

    '    ' Configure line chart area
    '    Dim lineChartArea As ChartArea = chLine.ChartAreas(0)
    '    lineChartArea.AxisX.MajorGrid.Enabled = False
    '    lineChartArea.AxisY.MajorGrid.Enabled = False
    '    lineChartArea.AxisX.MinorGrid.Enabled = False
    '    lineChartArea.AxisY.MinorGrid.Enabled = False
    '    lineChartArea.AxisX.LineColor = Color.Transparent
    '    lineChartArea.AxisY.LineColor = Color.Transparent
    '    lineChartArea.AxisX.LabelStyle.ForeColor = Color.Black
    '    lineChartArea.AxisY.LabelStyle.ForeColor = Color.Black
    '    lineChartArea.BackColor = Color.White
    '    lineChartArea.BorderColor = Color.Transparent

    '    ' Set axis titles for line chart
    '    lineChartArea.AxisX.Title = "Item"
    '    lineChartArea.AxisY.Title = "Cost"
    '    lineChartArea.AxisX.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
    '    lineChartArea.AxisY.TitleFont = New Font("Segoe UI", 10, FontStyle.Regular)
    '    lineChartArea.AxisX.TitleForeColor = Color.Black
    '    lineChartArea.AxisY.TitleForeColor = Color.Black

    '    ' Remove the legend for line chart
    '    chLine.Legends.Clear()
    'End Sub

    'Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    LoadUserExpenses()
    'End Sub
End Class
Imports System.IO
Imports System.Windows.Forms
Imports System.Text

Public Class ExportUtility
    ' Properties for customization
    Private _defaultFileExtension As String = "csv"
    Private _defaultExportFormat As ExportFormat = ExportFormat.CSV

    ' Enum for export formats
    Public Enum ExportFormat
        CSV
        Excel
        PDF
    End Enum

    Public Sub New()

    End Sub

    ' Constructor with format specification
    Public Sub New(exportFormat As ExportFormat)
        _defaultExportFormat = exportFormat

        ' Set appropriate extension based on format
        Select Case exportFormat
            Case ExportFormat.CSV
                _defaultFileExtension = "csv"
            Case ExportFormat.Excel
                _defaultFileExtension = "xlsx"
            Case ExportFormat.PDF
                _defaultFileExtension = "pdf"
        End Select
    End Sub

    Public Function Export(dgv As DataGridView, formName As String) As Boolean
        Select Case _defaultExportFormat
            Case ExportFormat.CSV
                Return ExportToCSV(dgv, formName)
            Case ExportFormat.Excel
                Return ExportToExcel(dgv, formName)
            Case ExportFormat.PDF
                Return ExportToPDF(dgv, formName)
            Case Else
                Return ExportToCSV(dgv, formName)
        End Select
    End Function

    Public Function ExportToCSV(dgv As DataGridView, formName As String) As Boolean
        Try
            ' Create SaveFileDialog
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV File (*.csv)|*.csv"
            saveDialog.Title = "Export Data to CSV"

            ' Set default filename with current date
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            saveDialog.FileName = $"{formName}_{currentDate}.csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Create StringBuilder to store data
                Dim csv As New StringBuilder()

                ' Add column headers
                Dim headerLine As New List(Of String)()
                For Each col As DataGridViewColumn In dgv.Columns
                    headerLine.Add(col.HeaderText)
                Next
                csv.AppendLine(String.Join(",", headerLine))

                ' Add rows
                For Each row As DataGridViewRow In dgv.Rows
                    Dim dataLine As New List(Of String)()
                    For Each cell As DataGridViewCell In row.Cells
                        ' Handle null values and escape commas
                        Dim value As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                        If value.Contains(",") Or value.Contains("""") Or value.Contains(vbNewLine) Then
                            value = $"""{value.Replace("""", """""")}"""
                        End If
                        dataLine.Add(value)
                    Next
                    csv.AppendLine(String.Join(",", dataLine))
                Next

                ' Write to file
                File.WriteAllText(saveDialog.FileName, csv.ToString())
                MessageBox.Show($"Data exported successfully to {saveDialog.FileName}", "Export Complete",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ExportToExcel(dgv As DataGridView, formName As String) As Boolean
        ' Require Microsoft.Office.Interop.Excel
        MessageBox.Show("Excel export functionality not yet implemented.", "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
    End Function

    Public Function ExportToPDF(dgv As DataGridView, formName As String) As Boolean
        ' Require a PDF library like iTextSharp
        MessageBox.Show("PDF export functionality not yet implemented.", "Information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
    End Function
End Class

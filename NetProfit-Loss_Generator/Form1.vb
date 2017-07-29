Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1


    Dim expense_count As Integer = 0
    Dim revenue_count As Integer = 0
    Dim expense_total As Single
    Dim revenue_total As Single

    Public Structure Revenue_Details
        Dim revTitle As String
        Dim revVal As Single
    End Structure

    Public revItems(99) As Revenue_Details



    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click


        dlgOpen.ShowDialog()

        Dim excelfile As New StreamReader(dlgOpen.FileName)

        Dim excelApp As Excel.Application
        Dim intLoopCounter As Integer
        Dim excelWorkbook As Excel.Workbook
        Dim excelWorksheet As Excel.Worksheet
        Dim excelRange As Excel.Range

        'configure excel application and opens proper workbook and worksheets
        excelApp = New Excel.Application
        excelApp.Workbooks.Open(dlgOpen.FileName)
        excelWorkbook = excelApp.Workbooks(1)
        excelWorksheet = excelWorkbook.Worksheets(1)


        For intLoopCounter = 1 To CInt(excelWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row)
            excelRange = excelWorksheet.Range("A" & intLoopCounter)

            revItems(intLoopCounter).revTitle = excelRange.Value
        Next intLoopCounter

        For intLoopCounter = 1 To CInt(excelWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row)
            excelRange = excelWorksheet.Range("B" & intLoopCounter)

            revItems(intLoopCounter).revVal = excelRange.Value


        Next intLoopCounter

        excelApp.Quit()

        'testing
        Dim count As Integer = 0
        For loops = 0 To 5

            ListBox1.Items.Add(revItems(count).revTitle)
            ListBox2.Items.Add(revItems(count).revTitle)
            count = count + 1
        Next
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Show()
    End Sub


End Class

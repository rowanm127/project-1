Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.OleDb

Public Class ReportTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'iTextSharp: Variables are created to edit properties however don't forget you can quickly create paragraphs and cells etc.
        'E.g. pdfDoc.Add(New Paragraph(" ")) or table.AddCell(" ")

        Dim pdfDoc As New Document()
        Dim pdfwWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Simple.pdf", FileMode.Create))

        Dim table As New PdfPTable(3)
        'Table width
        table.TotalWidth = 400.0F
        'Fix the width
        table.LockedWidth = True

        'relative col widths in proportions - 1/3 and 2/3
        Dim widths() As Integer = {5, 5, 2}
        table.SetWidths(widths)
        table.HorizontalAlignment = 1
        'leave a gap before and after the table
        table.SpacingBefore = 20.0F
        table.SpacingAfter = 30.0F

        'Sets new cell variable
        Dim cell As New PdfPCell(New Phrase("First Name"))
        'Sets how many columns to span
        cell.Colspan = 1
        'Set the cell border widths
        'cell.Border = 0 (This sets the cell to have no border)
        cell.BorderWidthLeft = 0F
        cell.BorderWidthRight = 1.0F
        cell.BorderWidthTop = 0F
        cell.BorderWidthBottom = 1.0F
        'Alignmenet 0=Left, 1=Centre, 2=Right
        cell.HorizontalAlignment = 0
        'Set cell padding
        cell.Padding = 5
        'Adds the cell to the table
        table.AddCell(cell)

        'Sets new cell
        cell = New PdfPCell(New Phrase("Last Name"))
        'Sets how many columns to span
        cell.Colspan = 1
        'Set the cell border widths
        cell.BorderWidthLeft = 1.0F
        cell.BorderWidthRight = 1.0F
        cell.BorderWidthTop = 0F
        cell.BorderWidthBottom = 1.0F
        'Alignmenet 0=Left, 1=Centre, 2=Right
        cell.HorizontalAlignment = 0
        'Set cell padding
        cell.Padding = 5
        'Adds the cell to the table
        table.AddCell(cell)

        'Sets new cell
        cell = New PdfPCell(New Phrase("Result"))
        'Sets how many columns to span
        cell.Colspan = 1
        'Set the cell border widths
        cell.BorderWidthLeft = 1.0F
        cell.BorderWidthRight = 0F
        cell.BorderWidthTop = 0F
        cell.BorderWidthBottom = 1.0F
        'Alignmenet 0=Left, 1=Centre, 2=Right
        cell.HorizontalAlignment = 0
        'Set cell padding
        cell.Padding = 5
        'Adds the cell to the table
        table.AddCell(cell)

        'Setup Connection and Query
        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
        Dim con As New OleDbConnection(connString)
        'Connect to Database
        con.Open()
        'Set query
        Dim query As String
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4002:001') ORDER BY Students.SLastName"
        Dim command As OleDbCommand = New OleDbCommand(query, con)
        Using rdr As OleDbDataReader = command.ExecuteReader()
            While rdr.Read()
                table.AddCell(rdr(0).ToString())
                table.AddCell(rdr(1).ToString())
                table.AddCell(rdr(2).ToString())
            End While
        End Using

        query = "SELECT UnitName From Unit Where (Unit = '4002:001')"
        Dim UnitName As String
        command = New OleDbCommand(query, con)
        Using rdr As OleDbDataReader = command.ExecuteReader()
            While rdr.Read()
                UnitName = rdr(0).ToString()
            End While
        End Using

        pdfDoc.Open()
        pdfDoc.Add(New Paragraph(LoginScreen.User))
        'Set new paragraph variable
        Dim paragraph As New Paragraph(New Phrase("Unit Results"))
        'Set alignment to center
        paragraph.Alignment = 1
        pdfDoc.Add(paragraph)
        'Set new paragraph
        paragraph = New Paragraph(New Phrase(UnitName))
        paragraph.Alignment = 1
        pdfDoc.Add(paragraph)
        paragraph = New Paragraph(New Phrase("WB4002:001"))
        paragraph.Alignment = 1
        pdfDoc.Add(paragraph)
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(table)
        pdfDoc.Close()

        con.Close()
    End Sub
End Class
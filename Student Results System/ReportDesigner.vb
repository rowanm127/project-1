Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class ReportDesigner
    Dim previousReportType As String = ""
    Dim previousAdaptive1 As String = ""
    Private Sub cmbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedIndexChanged
        Dim reportType As String = cmbReportType.SelectedItem
        'Adds initial options to combo boxes and makes objects visible
        If reportType = "Unit" And reportType <> previousReportType Then
            cmbAdaptive.Items.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            txtFirstName.Visible = False
            lblAdaptive.Visible = True
            lblAdaptive.Text = "Unit:"
            lblAdaptive2.Visible = True
            lblAdaptive2.Text = "Module:"
            cmbAdaptive.Visible = True
            cmbAdaptive.Items.Add("WB4001")
            cmbAdaptive.Items.Add("WB4002")
            cmbAdaptive.Items.Add("WB4003")
            cmbAdaptive.Items.Add("WB4004")
            cmbAdaptive.Items.Add("WB4005")
            previousReportType = reportType
        End If

        If reportType = "Module" And reportType <> previousReportType Then
            cmbAdaptive.Items.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            txtFirstName.Visible = False
            lblAdaptive.Visible = True
            cmbAdaptive.Visible = True
            lblAdaptive.Text = "Module:"
            cmbAdaptive.Items.Add("WB4001")
            cmbAdaptive.Items.Add("WB4002")
            cmbAdaptive.Items.Add("WB4003")
            cmbAdaptive.Items.Add("WB4004")
            cmbAdaptive.Items.Add("WB4005")
            previousReportType = reportType
        End If

        If reportType = "Student" And reportType <> previousReportType Then
            cmbAdaptive.Items.Clear()
            txtFirstName.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            lblAdaptive.Visible = True
            txtFirstName.Visible = True
            txtLastName.Visible = True
            lblAdaptive2.Visible = True
            lblAdaptive3.Visible = True
            cmbYear.Visible = True
            lblYear.Visible = True
            lblAdaptive.Text = "Student:"
            txtFirstName.Location = New Point(116, 133)
            txtLastName.Location = New Point(116, 178)
            lblAdaptive2.Text = "First Name:"
            lblAdaptive3.Text = "Last Name:"
            previousReportType = reportType
        End If
    End Sub

    Private Sub cmbAdaptive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdaptive.SelectedIndexChanged
        Dim reportType As String = cmbReportType.SelectedItem
        Dim adaptive1 As String = cmbAdaptive.SelectedItem
        If reportType = "Unit" And adaptive1 = "WB4002" Then
            cmbAdaptive2.Items.Clear()
            lblAdaptive3.Visible = True
            lblAdaptive3.Text = "Unit:"
            cmbAdaptive2.Visible = True
            cmbAdaptive2.Items.Add("001")
            cmbAdaptive2.Items.Add("002")
            cmbAdaptive2.Items.Add("003")
            cmbAdaptive2.Items.Add("004")
            previousAdaptive1 = adaptive1
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim moduleNum As String = cmbAdaptive.Text
        Dim moduleNumNoWB As String = moduleNum.Replace("WB", "")
        Dim unitNum As String = cmbAdaptive.Text & ":" & cmbAdaptive2.Text
        Dim unitNumNoWB As String = unitNum.Replace("WB", "")

        Dim saveFile As New SaveFileDialog()
        saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        saveFile.Filter = "PDF File (*.pdf)|*.pdf"
        saveFile.ShowDialog()

        'iTextSharp: Variables are created to edit properties however don't forget you can quickly create paragraphs and cells etc.
        'E.g. pdfDoc.Add(New Paragraph(" ")) or table.AddCell(" ")

        Dim pdfDoc As New Document()
        Dim pdfwWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFile.FileName, FileMode.Create))

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

        If cmbReportType.SelectedItem = "Unit" Then
            'Setup Connection and Query
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            'Connect to Database
            con.Open()
            'Set query
            Dim query As String
            query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '" & unitNumNoWB & "') ORDER BY Students.SLastName"
            Dim command As OleDbCommand = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    table.AddCell(rdr(0).ToString())
                    table.AddCell(rdr(1).ToString())
                    table.AddCell(rdr(2).ToString())
                End While
            End Using

            query = "SELECT UnitName From Unit Where (Unit = '" & unitNumNoWB & "')"

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
            paragraph = New Paragraph(New Phrase(unitNum))
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(table)
            pdfDoc.Close()

            con.Close()
        End If

        If cmbReportType.SelectedItem = "Module" Then
            'Setup Connection and Query
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            'Connect to Database
            con.Open()
            'Set query
            Dim query As String
            query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.Module = '" & moduleNumNoWB & "') ORDER BY Students.SLastName"
            Dim command As OleDbCommand = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    table.AddCell(rdr(0).ToString())
                    table.AddCell(rdr(1).ToString())
                    table.AddCell(rdr(2).ToString())
                End While
            End Using

            query = "SELECT ModuleName From Unit Where (Module = '" & moduleNumNoWB & "')"

            Dim ModuleName As String
            command = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    ModuleName = rdr(0).ToString()
                End While
            End Using

            pdfDoc.Open()
            pdfDoc.Add(New Paragraph(LoginScreen.User))
            'Set new paragraph variable
            Dim paragraph As New Paragraph(New Phrase("Module Results"))
            'Set alignment to center
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            'Set new paragraph
            paragraph = New Paragraph(New Phrase(ModuleName))
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            paragraph = New Paragraph(New Phrase(moduleNum))
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(table)
            pdfDoc.Close()

            con.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MsgBox("Opening your default PDF application. Please print from there.")
        Process.Start("Simple.pdf")
    End Sub
End Class
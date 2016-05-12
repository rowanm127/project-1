Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class ReportDesigner
    'Setup Connection
    Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
    Dim con As New OleDbConnection(connString)
    Dim previousReportType As String = ""
    Dim previousAdaptive1 As String = ""
    Dim printorSave As String = ""
    Private Sub cmbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedIndexChanged
        Dim reportType As String = cmbReportType.SelectedItem
        'Adds initial options to combo boxes and makes objects visible
        If reportType = "Unit" And reportType <> previousReportType Then
            cmbAdaptive.DataSource = Nothing
            cmbAdaptive.Items.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            lblAdaptive.Visible = True
            lblAdaptive.Text = "Unit Report:"
            lblAdaptive2.Visible = True
            lblAdaptive2.Text = "Module:"
            cmbAdaptive.Visible = True
            cmbAdaptive.Items.Add("WB4002")
            cmbAdaptive.Items.Add("WB4003")
            cmbAdaptive.Items.Add("WB4004")
            cmbAdaptive.Items.Add("WB5002")
            cmbAdaptive.Items.Add("WB5003")
            previousReportType = reportType
        End If

        If reportType = "Module" And reportType <> previousReportType Then
            cmbAdaptive.DataSource = Nothing
            cmbAdaptive.Items.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            lblAdaptive.Visible = True
            lblAdaptive2.Visible = True
            cmbAdaptive.Visible = True
            lblAdaptive.Text = "Module Report:"
            lblAdaptive2.Text = "Module:"
            cmbAdaptive.Items.Add("WB4001")
            cmbAdaptive.Items.Add("WB4002")
            cmbAdaptive.Items.Add("WB4003")
            cmbAdaptive.Items.Add("WB4004")
            cmbAdaptive.Items.Add("WB4005")
            cmbAdaptive.Items.Add("WB5001")
            cmbAdaptive.Items.Add("WB5002")
            cmbAdaptive.Items.Add("WB5003")
            cmbAdaptive.Items.Add("WB5004")
            cmbAdaptive.Items.Add("WB5005")
            cmbAdaptive.Items.Add("WB5006")
            cmbAdaptive.Items.Add("WB5007")
            previousReportType = reportType
        End If

        If reportType = "Student" And reportType <> previousReportType Then
            cmbAdaptive.Items.Clear()
            cmbAdaptive.Visible = True
            cmbAdaptive2.Visible = False
            lblAdaptive.Visible = True
            lblAdaptive2.Visible = True
            lblAdaptive.Text = "Student Report:"
            lblAdaptive2.Text = "Student:"
            'Setup Connection and Query to obtain Student Names with IDs
            Using con As New OleDbConnection(connString)
                'Connect to Database
                con.Open()
                'Set query
                Dim query As String
                'Combines several columns into one
                query = "SELECT [SId] & ' ' & [SFirstName] & ' ' & [SLastName] AS SIdName FROM Students ORDER BY Students.SLastName"
                Using command As OleDbCommand = New OleDbCommand(query, con)
                    Dim rdr As OleDbDataReader = command.ExecuteReader()
                    Dim dt As DataTable = New DataTable
                    dt.Load(rdr)
                    cmbAdaptive.ValueMember = "SId"
                    cmbAdaptive.DisplayMember = "SidName"
                    cmbAdaptive.DataSource = dt
                End Using
            End Using
            previousReportType = reportType
        End If
    End Sub

    Private Sub cmbAdaptive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdaptive.SelectedIndexChanged
        Dim reportType As String = cmbReportType.SelectedItem
        If reportType = "Unit" Then
            Dim adaptive1 As String = cmbAdaptive.SelectedItem
            If adaptive1 = "WB4002" Then
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

            If adaptive1 = "WB4003" Then
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

            If adaptive1 = "WB4004" Then
                cmbAdaptive2.Items.Clear()
                lblAdaptive3.Visible = True
                lblAdaptive3.Text = "Unit:"
                cmbAdaptive2.Visible = True
                cmbAdaptive2.Items.Add("001")
                cmbAdaptive2.Items.Add("002")
                cmbAdaptive2.Items.Add("003")
                previousAdaptive1 = adaptive1
            End If

            If adaptive1 = "WB5002" Then
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

            If adaptive1 = "WB5003" Then
                cmbAdaptive2.Items.Clear()
                lblAdaptive3.Visible = True
                lblAdaptive3.Text = "Unit:"
                cmbAdaptive2.Visible = True
                cmbAdaptive2.Items.Add("001")
                cmbAdaptive2.Items.Add("002")
                previousAdaptive1 = adaptive1
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbReportType.Text <> "" Then
            If cmbAdaptive.Text <> "" Then
                printorSave = "Save"
                CreateReport()
            ElseIf cmbReportType.Text = "Unit" And cmbAdaptive.Text = "" And cmbAdaptive2.Text = "" Then
                MsgBox("Please choose a Unit.")
            ElseIf cmbReportType.Text = "Module" And cmbAdaptive.Text = "" Then
                MsgBox("Please choose a Module")
            End If
        Else
            MsgBox("Please choose a report type.")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cmbReportType.Text <> "" Then
            If cmbAdaptive.Text <> "" Then
                printorSave = "Print"
                CreateReport()
            ElseIf cmbReportType.Text = "Unit" And cmbAdaptive.Text = "" And cmbAdaptive2.Text = "" Then
                MsgBox("Please choose a Unit.")
            ElseIf cmbReportType.Text = "Module" And cmbAdaptive.Text = "" Then
                MsgBox("Please choose a Module")
            End If
        Else
            MsgBox("Please choose a report type.")
        End If
    End Sub

    Private Sub CreateReport()
        Dim moduleNum As String = ""
        Dim moduleNumNoWB As String = ""
        Dim unitNum As String = ""
        Dim unitNumNoWB As String = ""
        Dim saveLocation As String = ""
        Dim studentID = cmbAdaptive.Text.Split(" "c)(0)


        If printorSave = "Save" Then
            Dim saveFile As New SaveFileDialog()
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            saveFile.Filter = "PDF File (*.pdf)|*.pdf"
            saveFile.ShowDialog()
            saveLocation = saveFile.FileName
        ElseIf printorSave = "Print" Then
            If My.Computer.FileSystem.DirectoryExists("Temp") Then
                'Do nothing
            Else
                System.IO.Directory.CreateDirectory("Temp")
            End If
            saveLocation = "Temp\Simple.pdf"
        End If

        'iTextSharp: Variables are created to edit properties however don't forget you can quickly create paragraphs and cells etc.
        'E.g. pdfDoc.Add(New Paragraph(" ")) or table.AddCell(" ")

        Dim pdfDoc As New Document()
        Dim pdfwWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveLocation, FileMode.Create))


        If cmbReportType.Text = "Module" Or cmbReportType.Text = "Unit" Then
            moduleNum = cmbAdaptive.Text
            moduleNumNoWB = moduleNum.Replace("WB", "")
            unitNum = cmbAdaptive.Text & ":" & cmbAdaptive2.Text
            unitNumNoWB = unitNum.Replace("WB", "")

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

                Dim UnitName As String = ""
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
                'Connect to Database
                con.Open()
                'Set query
                Dim query As String
                If moduleNumNoWB = "4001" Or moduleNumNoWB = "5001" Then
                    query = "SELECT Students.SFirstName, Students.SLastName, ModulePassResults.ModulePass FROM (([Module] INNER JOIN ModulePassResults ON [Module].[Module] = ModulePassResults.[Module]) INNER JOIN Students ON ModulePassResults.SId = Students.SId) WHERE ([Module].[Module] = '" & moduleNumNoWB & "') ORDER BY Students.SLastName"
                Else
                    query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (([Module] INNER JOIN ModuleResults ON [Module].[Module] = ModuleResults.[Module]) INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE ([Module].[Module] = '" & moduleNumNoWB & "') ORDER BY Students.SLastName"
                End If
                Dim command As OleDbCommand = New OleDbCommand(query, con)
                Using rdr As OleDbDataReader = command.ExecuteReader()
                    While rdr.Read()
                        table.AddCell(rdr(0).ToString())
                        table.AddCell(rdr(1).ToString())
                        table.AddCell(rdr(2).ToString())
                    End While
                End Using

                query = "Select ModuleName From [Module] Where ([Module] = '" & moduleNumNoWB & "')"

                Dim ModuleName As String = ""
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

            'If report type = Student
        Else
            Dim table As New PdfPTable(2)
            'Table width
            table.TotalWidth = 400.0F
            'Fix the width
            table.LockedWidth = True

            'relative col widths in proportions - 1/3 and 2/3
            Dim widths() As Integer = {5, 5}
            table.SetWidths(widths)
            table.HorizontalAlignment = 1
            'leave a gap before and after the table
            table.SpacingBefore = 20.0F
            table.SpacingAfter = 30.0F

            'Sets new cell variable
            Dim cell As New PdfPCell(New Phrase("Module/Unit"))
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
            cell = New PdfPCell(New Phrase("Result/Pass"))
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

            'Connect to Database
            con.Open()
            'Set query
            Dim query As String
            query = "SELECT ModulePassResults.[Module], ModulePassResults.ModulePass FROM (Students INNER JOIN ModulePassResults ON Students.SId = ModulePassResults.SId) WHERE (ModulePassResults.SId = " & studentID(0) & ")"
            Dim command As OleDbCommand = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    table.AddCell(rdr(0).ToString())
                    table.AddCell(rdr(1).ToString())
                End While
            End Using

            'Set query
            query = "SELECT ModuleResults.[Module], ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.SId = " & studentID(0) & ")"
            command = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    table.AddCell(rdr(0).ToString())
                    table.AddCell(rdr(1).ToString())
                End While
            End Using

            'Set query
            query = "SELECT UnitResults.Unit, UnitResults.UnitResult FROM (Students INNER JOIN UnitResults ON Students.SId = UnitResults.SId) WHERE (UnitResults.SId = " & studentID(0) & ")"
            command = New OleDbCommand(query, con)
            Using rdr As OleDbDataReader = command.ExecuteReader()
                While rdr.Read()
                    table.AddCell(rdr(0).ToString())
                    table.AddCell(rdr(1).ToString())
                End While
            End Using

            pdfDoc.Open()
            pdfDoc.Add(New Paragraph(LoginScreen.User))
            'Set new paragraph variable
            Dim paragraph As New Paragraph(New Phrase("Student Results"))
            'Set alignment to center
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            paragraph = New Paragraph(New Phrase(cmbAdaptive.Text))
            paragraph.Alignment = 1
            pdfDoc.Add(paragraph)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(table)
            pdfDoc.Close()

            con.Close()

        End If

        If printorSave = "Print" Then
            MsgBox("Opening your default PDF application. Please print from there.")
            Process.Start("Temp\Simple.pdf")
        End If
    End Sub
End Class
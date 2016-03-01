Public Class ReportDesigner
    Dim previousReportType As String = ""
    Dim previousAdaptive1 As String = ""
    Private Sub cmbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedIndexChanged
        Dim reportType As String = cmbReportType.SelectedItem
        'Adds initial options to combo boxes and makes objects visible
        If reportType = "Assignment/Unit" And reportType <> previousReportType Then
            cmbAdaptive.Items.Clear()
            lblAdaptive3.Visible = False
            cmbAdaptive2.Visible = False
            txtFirstName.Visible = False
            lblAdaptive.Visible = True
            lblAdaptive.Text = "Assignment/Unit:"
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
        If reportType = "Assignment/Unit" And adaptive1 = "WB4002" Then
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

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub
End Class
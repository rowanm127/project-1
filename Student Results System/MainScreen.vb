Imports System.Data.OleDb
Public Class MainScreen
    Dim lastClicked As String = ""
    'Setup Connection and Query
    Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
    Dim con As New OleDbConnection(connString)

    Private Sub mnuSidebarToggle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSidebarToggle.Click
        'Sets the toggle to not be checked
        mnuSidebarToggle.Checked = Not mnuSidebarToggle.Checked
        'If the toggle is not checked and is clicked then the panel is set to hide and the toggle is set to checked
        If mnuSidebarToggle.Checked = False Then
            SplitContainer1.Panel1Collapsed = True
            mnuSidebarToggle.Checked = True
        Else
            'If the toggle is checked and is clicked then the panel is set to show and the toggle is set to not be checked
            SplitContainer1.Panel1Collapsed = False
            mnuSidebarToggle.Checked = False
        End If
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddStudent.Click
		'Sets new form as the AddStudent form
		Dim openForm As New AddStudent
		openForm.Owner = Me
		'openForm.CenterToParent()
		openForm.ShowDialog(Me)
		'Sets last clicked button to Add Student (for the most recent action feature)
		lastClicked = "AddStudent"
    End Sub

    Private Sub mnuAddStudent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddStudent.Click
        Dim openForm As New AddStudent
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        'Sets last clicked button to Add Student (for the most recent action feature)
        lastClicked = "AddStudent"
    End Sub

    Private Sub mnuAddResult_Click(sender As Object, e As EventArgs) Handles mnuAddResult.Click
        Dim openForm As New AddResult
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        'Sets last clicked button to Add Result (for the most recent action feature)
        lastClicked = "AddResult"
    End Sub

    Private Sub btnAdvSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdvSearch.Click
        'Sets new form to Advanced Search form
		Dim openForm As New AdvSearch
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub

    Public Sub MainScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Loads data into the Students table.
        Me.StudentsTableAdapter.Fill(Me.DefaultDataSet2.Students)

        'Connect to Database
        con.Open()

        tableLoadModule("4001", dgv4001)
        tableLoadModule("4002", dgv4002)
        tableLoadModule("4003", dgv4003)
        tableLoadModule("4004", dgv4004)
        tableLoadModule("4005", dgv4005)
        tableLoadModule("5001", dgv5001)
        tableLoadModule("5002", dgv5002)
        tableLoadModule("5003", dgv5003)
        tableLoadModule("5004", dgv5004)
        tableLoadModule("5005", dgv5005)
        tableLoadModule("5006", dgv5006)
        tableLoadModule("5007", dgv5007)

        tableLoadUnit("4002:001", dgv4002001)
        tableLoadUnit("4002:002", dgv4002002)
        tableLoadUnit("4002:003", dgv4002003)
        tableLoadUnit("4002:004", dgv4002004)
        tableLoadUnit("4003:001", dgv4003001)
        tableLoadUnit("4003:002", dgv4003002)
        tableLoadUnit("4003:003", dgv4003003)
        tableLoadUnit("4003:004", dgv4003004)
        tableLoadUnit("4004:001", dgv4004001)
        tableLoadUnit("4004:002", dgv4004002)
        tableLoadUnit("4004:003", dgv4004003)
        tableLoadUnit("5002:001", dgv5002001)
        tableLoadUnit("5002:002", dgv5002002)
        tableLoadUnit("5002:003", dgv5002003)
        tableLoadUnit("5002:004", dgv5002004)
        tableLoadUnit("5003:001", dgv5003001)
        tableLoadUnit("5003:002", dgv5003002)

        con.Close()
    End Sub

    Public Sub tableLoadModule(moduleNum, tableNum)
        'Set query
        Dim query As String
        If moduleNum <> "4001" Or moduleNum <> "5001" Then
            query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '" & moduleNum & "') ORDER BY Students.SLastName"
        Else
            query = "SELECT Students.SFirstName, Students.SLastName, ModulePassResults.ModulePass FROM (ModulePassResults INNER JOIN Students ON ModulePassResults.SId = Students.SId) WHERE (ModulePassResults.[Module] = '" & moduleNum & "') ORDER BY Students.SLastName"
        End If
        Dim command As OleDbCommand = New OleDbCommand(query, con)
        Dim loadDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim loadDataSet As DataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        tableNum.DataSource = loadDataSet
        'Set new table to show
        tableNum.DataMember = "Load_Table"
    End Sub

    Public Sub tableLoadUnit(unitNum, tableNum)
        'Set query
        Dim query As String
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '" & unitNum & "') ORDER BY Students.SLastName"
        Dim command As OleDbCommand = New OleDbCommand(query, con)
        Dim loadDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim loadDataSet As DataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        tableNum.DataSource = loadDataSet
        'Set new table to show
        tableNum.DataMember = "Load_Table"
    End Sub

    Private Sub tsbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openForm As New ReportDesigner
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub

    Private Sub mnuReportDesigner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openForm As New ReportDesigner
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim openForm As New ReportDesigner
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        lastClicked = "ReportDesigner"
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbSearch.SelectedItem <> "" And txtWaterSearch.Text <> "" Then
            'Switches the tab to search results tab
            mtabHome.SelectedIndex = 13
            'Setup Connection and Query
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            'Set query depending on option
            Dim quickSearch As String = ""
            If cmbSearch.SelectedItem = "First Name" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SFirstName LIKE '%" & txtWaterSearch.Text & "%') ORDER BY Students.SLastName"
            ElseIf cmbSearch.SelectedItem = "Last Name" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SLastName LIKE '%" & txtWaterSearch.Text & "%') ORDER BY Students.SLastName"
            ElseIf cmbSearch.SelectedItem = "Year" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SYear = " & txtWaterSearch.Text & ") ORDER BY Students.SYear"
            ElseIf cmbSearch.SelectedItem = "Module" Then
                If txtWaterSearch.Text = "4001" Or txtWaterSearch.Text = "5001" Then
                    quickSearch = "SELECT Students.SFirstName, Students.SLastName, ModulePassResults.ModulePass, ModulePassResults.[Module] FROM (ModulePassResults INNER JOIN Students ON ModulePassResults.SId = Students.SId) WHERE (ModulePassResults.[Module] = '" & txtWaterSearch.Text & "') ORDER BY Students.SLastName"
                Else
                    quickSearch = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult, ModuleResults.[Module] FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '" & txtWaterSearch.Text & "') ORDER BY Students.SLastName"
                End If
            ElseIf cmbSearch.SelectedItem = "Unit" Then
                quickSearch = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult, UnitResults.[Unit] FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.[Unit] LIKE '%" & txtWaterSearch.Text & "%') ORDER BY Students.SLastName"
            End If
            Dim command As OleDbCommand = New OleDbCommand(quickSearch, con)
            Dim searchDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(command)
            Dim searchDataSet As DataSet = New DataSet
            'Connect to Database
            con.Open()
            '
            searchDataAdapter.Fill(searchDataSet, "Search_Table")
            '
            con.Close()
            'Set new DataSet
            dgvSearch.DataSource = searchDataSet
            'Set new table to show
            dgvSearch.DataMember = "Search_Table"
        Else
            'If no text in search box
            MsgBox("Please enter a search term")
        End If
    End Sub

    Private Sub btnAddResult_Click(sender As Object, e As EventArgs) Handles btnAddResult.Click
        'Sets new form to the Add Result form
        Dim openForm As New AddResult
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        'Sets last clicked button to Add Result
        lastClicked = "AddResult"
    End Sub

    Private Sub EditDGV(sender As Object, e As EventArgs) Handles dgvStudents.CellEndEdit, dgv4001.CellEndEdit, dgv4002.CellEndEdit
        Dim editedTable As DataGridView
        'Set query
        Dim query As String
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4002') ORDER BY Students.SLastName"
        Dim command As OleDbCommand = New OleDbCommand(query, con)
        Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim dataSet As DataSet = New DataSet
        'Fill DataAdapter
        dataAdapter.Fill(dataSet, "Load_Table")
        'Set new DataSet
        dgv4002.DataSource = dataSet
        'Set new table to show
        dgv4002.DataMember = "Load_Table"

        editedTable = CType(sender, DataGridView)

        editedTable.EndEdit()
        Dim dt As DataTable = DirectCast(dataSet.Tables("ModuleResults"), DataTable)

        dataAdapter.Update(dt)

    End Sub

    Private Sub mnuHideToolbar_Click(sender As Object, e As EventArgs) Handles mnuHideToolbar.Click
        'Sets the toggle to not be checked
        'If the toggle is not checked and is clicked then the toolbar is set to hide and the toggle is set to checked
        If mnuHideToolbar.Checked = False Then
            ToolStrip1.Hide()
            mnuHideToolbar.Checked = True
        Else
            'If the toggle is checked and is clicked then the toolbar is set to show and the toggle is set to not be checked
            ToolStrip1.Show()
            mnuHideToolbar.Checked = False
        End If
    End Sub
End Class

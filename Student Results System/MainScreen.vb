Imports System.Data.OleDb
Public Class MainScreen
	Dim lastClicked As String = ""

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
        'See above
		Dim openForm As New AddStudent
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        'Sets last clicked button to Add Student (for the most recent action feature)
		lastClicked = "AddStudent"
    End Sub

    Private Sub btnAdvSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdvSearch.Click
        'Sets new form to Advanced Search form
		Dim openForm As New AdvSearch
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub

    Public Sub MainScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DefaultDataSet2.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.DefaultDataSet2.Students)
	
        'Setup Connection and Query
        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
        Dim con As New OleDbConnection(connString)
        'Connect to Database
        con.Open()

        'WB4001
        'Set query
        Dim query As String
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4001') ORDER BY Students.SLastName"
        Dim command As OleDbCommand = New OleDbCommand(query, con)
        Dim loadDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim loadDataSet As DataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4001.DataSource = loadDataSet
        'Set new table to show
        dgv4001.DataMember = "Load_Table"

        'WB4002
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4002') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4002.DataSource = loadDataSet
        'Set new table to show
        dgv4002.DataMember = "Load_Table"

        'WB4002:001
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4002:001') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4002001.DataSource = loadDataSet
        'Set new table to show
        dgv4002001.DataMember = "Load_Table"

        'WB4002:002
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4002:002') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4002002.DataSource = loadDataSet
        'Set new table to show
        dgv4002002.DataMember = "Load_Table"

        'WB4002:003
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4002:003') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4002003.DataSource = loadDataSet
        'Set new table to show
        dgv4002003.DataMember = "Load_Table"

        'WB4002:004
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4002:004') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4002004.DataSource = loadDataSet
        'Set new table to show
		dgv4002004.DataMember = "Load_Table"

		'WB4003
		'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4003') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4003.DataSource = loadDataSet
        'Set new table to show
		dgv4003.DataMember = "Load_Table"

		'WB4003:001
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4003:001') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4003001.DataSource = loadDataSet
        'Set new table to show
		dgv4003001.DataMember = "Load_Table"
		
		'WB4003:002
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4003:002') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4003002.DataSource = loadDataSet
        'Set new table to show
		dgv4003002.DataMember = "Load_Table"

		'WB4003:003
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4003:003') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4003003.DataSource = loadDataSet
        'Set new table to show
		dgv4003003.DataMember = "Load_Table"
	
		'WB4003:004
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4003:004') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4003004.DataSource = loadDataSet
        'Set new table to show
        dgv4003004.DataMember = "Load_Table"
	
        'WB4004
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4004') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4004.DataSource = loadDataSet
        'Set new table to show
		dgv4004.DataMember = "Load_Table"
		
		'WB4004:001
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4004:001') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4004001.DataSource = loadDataSet
        'Set new table to show
		dgv4004001.DataMember = "Load_Table"

		'WB4004:002
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4004:002') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4004002.DataSource = loadDataSet
        'Set new table to show
		dgv4004002.DataMember = "Load_Table"
		
		'WB4004:003
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.Unit = '4004:003') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4004003.DataSource = loadDataSet
        'Set new table to show
		dgv4004003.DataMember = "Load_Table"
		
		'WB4005
        'Set query
        query = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '4005') ORDER BY Students.SLastName"
        command = New OleDbCommand(query, con)
        loadDataAdapter = New OleDbDataAdapter(command)
        loadDataSet = New DataSet
        'Fill DataAdapter
        loadDataAdapter.Fill(loadDataSet, "Load_Table")
        'Set new DataSet
        dgv4005.DataSource = loadDataSet
        'Set new table to show
		dgv4005.DataMember = "Load_Table"
		
		con.Close()
    End Sub

    Private Sub tsbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrint.Click
        Dim openForm As New ReportDesigner
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub

    Private Sub mnuReportDesigner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportDesigner.Click
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
			mtabHome.SelectedIndex = 7
            'Setup Connection and Query
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            'Set query depending on option
            Dim quickSearch As String
            If cmbSearch.SelectedItem = "First Name" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SFirstName LIKE '%" & txtWaterSearch.Text & "%') ORDER BY Students.SLastName"
            ElseIf cmbSearch.SelectedItem = "Last Name" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SLastName LIKE '%" & txtWaterSearch.Text & "%') ORDER BY Students.SLastName"
            ElseIf cmbSearch.SelectedItem = "Year" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SYear = " & txtWaterSearch.Text & ") ORDER BY Students.SYear"
            ElseIf cmbSearch.SelectedItem = "Module" Then
                quickSearch = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult, ModuleResults.[Module] FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '" & txtWaterSearch.Text & "')"
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

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        '!Deprecated! Should probably be removed soon since there is no need to reset search results anymore
        MainScreen_Load(sender, e)
    End Sub

    Private Sub btnAddResult_Click(sender As Object, e As EventArgs) Handles btnAddResult.Click
        'Sets new form to the Add Result form
        Dim openForm As New AddResult
        openForm.Owner = Me
        openForm.ShowDialog(Me)
        'Sets last clicked button to Add Result
        lastClicked = "AddResult"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim openForm As New ReportTest
        openForm.Owner = Me
        openForm.ShowDialog(Me)
    End Sub
End Class

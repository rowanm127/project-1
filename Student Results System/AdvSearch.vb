Imports System.Data.OleDb
Public Class AdvSearch

    Private Sub btnAdvSearch_Click(sender As Object, e As EventArgs) Handles btnAdvSearch.Click
        If txtFirstName.Text <> "" Or txtLastName.Text <> "" Or cmbYear.Text <> "" Or cmbModule.Text <> "" Then
            'Switches the tab to search results tab
            MainScreen.mtabHome.SelectedIndex = 13
            'Setup Connection and Query
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            'Set query depending on option
            Dim quickSearch As String = ""
            If txtFirstName.Text <> "" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SFirstName LIKE '%" & txtFirstName.Text & "%') ORDER BY Students.SLastName"
            ElseIf txtLastName.Text <> "" Then
                quickSearch = "SELECT * FROM(Students) WHERE (SLastName LIKE '%" & txtLastName.Text & "%') ORDER BY Students.SLastName"
            ElseIf cmbYear.Text <> "" Or " " Then
                quickSearch = "SELECT * FROM(Students) WHERE (SYear = " & cmbYear.Text & ") ORDER BY Students.SYear"
            ElseIf cmbType.SelectedItem = "Module" Then
                If cmbModule.Text = "4001" Or cmbModule.Text = "5001" Then
                    quickSearch = "SELECT Students.SFirstName, Students.SLastName, ModulePassResults.ModulePass, ModulePassResults.[Module] FROM (ModulePassResults INNER JOIN Students ON ModulePassResults.SId = Students.SId) WHERE (ModulePassResults.[Module] = '" & cmbModule.Text & "') ORDER BY Students.SLastName"
                Else
                    quickSearch = "SELECT Students.SFirstName, Students.SLastName, ModuleResults.ModuleResult, ModuleResults.[Module] FROM (ModuleResults INNER JOIN Students ON ModuleResults.SId = Students.SId) WHERE (ModuleResults.[Module] = '" & cmbModule.Text & "') ORDER BY Students.SLastName"
                End If
            ElseIf cmbType.SelectedItem = "Unit" Then
                quickSearch = "SELECT Students.SFirstName, Students.SLastName, UnitResults.UnitResult, UnitResults.[Unit] FROM (UnitResults INNER JOIN Students ON UnitResults.SId = Students.SId) WHERE (UnitResults.[Unit] LIKE '%" & cmbUnit.Text & "%') ORDER BY Students.SLastName"
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
            MainScreen.dgvSearch.DataSource = searchDataSet
            'Set new table to show
            MainScreen.dgvSearch.DataMember = "Search_Table"
        Else
            'If no text in search box
            MsgBox("Please enter a search term")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Module" Then
            cmbUnit.Hide()
            lblUnit.Hide()
            cmbModule.Show()
            lblModule.Show()
            cmbModule.Location = New Point(94, 197)
            lblModule.Location = New Point(31, 200)
        End If
        If cmbType.Text = "Unit" Then
            cmbModule.Hide()
            lblModule.Hide()
            cmbUnit.Show()
            lblUnit.Show()
            cmbUnit.Location = New Point(94, 197)
            lblUnit.Location = New Point(31, 200)
        End If
    End Sub
End Class
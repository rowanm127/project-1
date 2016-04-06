Imports System.Data.OleDb
Public Class AddResult
    Dim previousResultType As String = ""

    Private Sub AddResult_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Setup Connection and Query to obtain Student Names with IDs
        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
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
                cmbSId.ValueMember = "Sid"
                cmbSId.DisplayMember = "SidName"
                cmbSId.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btnAddResult_Click(sender As System.Object, e As System.EventArgs) Handles btnAddResult.Click
        Dim markText As String = txtMark.Text
        Dim markTextInt As New Integer
        Dim SIdWithName As String = cmbSId.Text
        Dim SId As String = SIdWithName.Split(" ")(0)

        If (txtMark.Text <> "" And cmbResultType.SelectedItem = "Module" And cmbModule.Text <> "" Or txtMark.Text <> "" And cmbResultType.SelectedItem = "Unit" And cmbUnit.Text <> "") Then
            If Integer.TryParse(markText, markTextInt) Then
                If markText >= 0 And markText <= 100 Then
                    If cmbResultType.SelectedItem = "Module" Then
                        'Connect to Database
                        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
                        Dim con As New OleDbConnection(connString)
                        con.Open()
                        'Query to insert result into table
                        If cmbModule.Text = "4001" Or cmbModule.Text = "5001" Then
                            Dim addResult As OleDbCommand = New OleDbCommand("INSERT INTO ModulePassResults (SId, [Module], ModulePass) VALUES ('" & SId & "','" & cmbModule.Text & "','" & txtMark.Text & "')", con)
                            addResult.ExecuteNonQuery()
                        Else
                            Dim addResult As OleDbCommand = New OleDbCommand("INSERT INTO ModuleResults (SId, [Module], ModuleResult) VALUES ('" & SId & "','" & cmbModule.Text & "','" & txtMark.Text & "')", con)
                            addResult.ExecuteNonQuery()
                        End If
                        con.Close()
                        MainScreen.MainScreen_Load(sender, e)
                        ' Asks the user if they wish to add another result
                        Dim MsgStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1
                        Dim UserYesNo = MsgBox("Do you wish to add another result/Go to next student?", MsgStyle, "")
                        If UserYesNo = MsgBoxResult.No Then
                            Me.Close()
                        ElseIf UserYesNo = MsgBoxResult.Yes Then
                            Try
                                Dim SidIndex As Integer = cmbSId.SelectedIndex
                                cmbSId.SelectedIndex = SidIndex + 1
                                txtMark.Clear()
                                txtMark.Select()
                            Catch
                                MsgBox("End of students reached.")
                            End Try
                        End If
                    End If

                    If cmbResultType.SelectedItem = "Unit" Then
                        'Connect to Database
                        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
                        Dim con As New OleDbConnection(connString)
                        con.Open()
                        'Query to insert result into table
                        Dim addResult As OleDbCommand = New OleDbCommand("INSERT INTO UnitResults (SId, Unit, UnitResult) VALUES ('" & SId & "','" & cmbUnit.Text & "','" & txtMark.Text & "')", con)
                        addResult.ExecuteNonQuery()
                        con.Close()
                        MainScreen.MainScreen_Load(sender, e)
                        ' Asks the user if they wish to add another result
                        Dim MsgStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1
                        Dim UserYesNo = MsgBox("Do you wish to add another result/Go to next student?", MsgStyle, "")
                        If UserYesNo = MsgBoxResult.No Then
                            Me.Close()
                        ElseIf UserYesNo = MsgBoxResult.Yes Then
                            Dim SidIndex As Integer = cmbSId.SelectedIndex
                            cmbSId.SelectedIndex = SidIndex + 1
                            txtMark.Clear()
                            txtMark.Select()
                        End If
                    End If

                Else
                    MsgBox("Mark must be from 0-100")
                End If
            Else
                MsgBox("Please enter a number")
            End If
        Else
            MsgBox("Please fill out all fields.")
        End If
    End Sub

    Private Sub cmbResultType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbResultType.SelectedIndexChanged
        Dim resultType As String = cmbResultType.SelectedItem
        If resultType = "Module" Then
            lblModule.Show()
            cmbModule.Show()
            lblModule.Location = New Point(46, 87)
            cmbModule.Location = New Point(125, 88)
            previousResultType = "Module"
        End If
        If resultType = "Unit" Then
            lblMark.Show()
            txtMark.Show()
            lblModule.Hide()
            cmbModule.Hide()
            lblUnit.Show()
            cmbUnit.Show()
            lblUnit.Location = New Point(46, 87)
            cmbUnit.Location = New Point(125, 88)
            previousResultType = "Unit"
        End If
    End Sub

    Private Sub cmbModule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModule.SelectedIndexChanged
        If cmbModule.Text = "4001" Or lblModule.Text = "5001" Then
            txtMark.Hide()
            lblMark.Show()
            lblMark.Text = "Passed:"
            cmbPass.Show()
        Else
            lblMark.Show()
            lblMark.Text = "Mark:"
            txtMark.Show()
            lblUnit.Hide()
            cmbUnit.Hide()
            cmbPass.Hide()
        End If
    End Sub
End Class
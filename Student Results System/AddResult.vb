Imports System.Data.OleDb
Public Class AddResult
    Dim previousResultType As String = ""
    Private Sub btnAddResult_Click(sender As System.Object, e As System.EventArgs) Handles btnAddResult.Click
        Dim markText As String = txtMark.Text
        Dim markTextInt As New Integer
        If (txtMark.Text <> "" And cmbResultType.SelectedItem = "Module" And cmbModule.Text <> "" Or txtMark.Text <> "" And cmbResultType.SelectedItem = "Unit" And cmbUnit.Text <> "") Then
            If Integer.TryParse(markText, markTextInt) Then
                If markText >= 0 And markText <= 100 Then
                    If cmbResultType.SelectedItem = "Module" Then
                        'Connect to Database
                        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
                        Dim con As New OleDbConnection(connString)
                        con.Open()
                        'Query
                        Dim addResult As OleDbCommand = New OleDbCommand("INSERT INTO ModuleResults (SId, [Module], ModuleResult) VALUES ('" & cmbSId.Text & "','" & cmbModule.Text & "','" & txtMark.Text & "')", con)
                        addResult.ExecuteNonQuery()
                        con.Close()
                        MainScreen.MainScreen_Load(sender, e)
                        ' Asks the user if they wish to add another result
                        Dim MsgStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1
                        Dim UserYesNo = MsgBox("Do you wish to add another result?", MsgStyle, "")
                        If UserYesNo = MsgBoxResult.No Then
                            Me.Close()
                        End If
                    End If
                    If cmbResultType.SelectedItem = "Unit" Then
                        'Connect to Database
                        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
                        Dim con As New OleDbConnection(connString)
                        con.Open()
                        'Query
                        Dim addResult As OleDbCommand = New OleDbCommand("INSERT INTO UnitResults (SId, Unit, UnitResult) VALUES ('" & cmbSId.Text & "','" & cmbUnit.Text & "','" & txtMark.Text & "')", con)
                        addResult.ExecuteNonQuery()
                        con.Close()
                        MainScreen.MainScreen_Load(sender, e)
                        ' Asks the user if they wish to add another result
                        Dim MsgStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1
                        Dim UserYesNo = MsgBox("Do you wish to add another result?", MsgStyle, "")
                        If UserYesNo = MsgBoxResult.No Then
                            Me.Close()
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
            lblMark.Show()
            txtMark.Show()
            lblUnit.Hide()
            cmbUnit.Hide()
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
        End If
    End Sub
End Class
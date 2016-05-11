Imports System.Data.OleDb

Public Class AddStudent
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If txtName.Text <> "" And txtLastName.Text <> "" And cmbYear.Text <> "" Then
            'Connect to Database
            Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
            Dim con As New OleDbConnection(connString)
            con.Open()
            'Query
            Dim addStudent As OleDbCommand = New OleDbCommand("INSERT INTO Students (SFirstName, SLastName, SYear) VALUES (""" & txtName.Text & """,""" & txtLastName.Text & """,'" & cmbYear.Text & "')", con)
            addStudent.ExecuteNonQuery()
            con.Close()
            MainScreen.StudentsTableAdapter.Fill(MainScreen.DefaultDataSet2.Students)
            ' Asks the user if they wish to add another student
            Dim MsgStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1
            Dim UserYesNo = MsgBox("Do you wish to add another student?", MsgStyle, "")
            If UserYesNo = MsgBoxResult.No Then
                Me.Close()
            Else
                txtName.Select()
            End If
        Else
            MsgBox("Please fill out all fields.")
        End If
    End Sub
End Class
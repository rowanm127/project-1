Imports System.Data.OleDb

Public Class LoginScreen
    Public Shared User As String
    Sub btnLoginClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        'Open Connection
        Dim connString As String = "Provider= Microsoft.ACE.OLEDB.12.0; " & "Data Source=Default.accdb;"
        Dim con As New OleDbConnection(connString)
        con.Open()
        'Query
        Dim getDetails As OleDbCommand = New OleDbCommand("SELECT * FROM [Users] WHERE [Username] = '" & txtUserName.Text & "' AND [Password] = '" & txtUserPassword.Text & "'", con)
        'Creates variables for the database reader
		Dim dr As OleDbDataReader = getDetails.ExecuteReader
        Dim userFound As Boolean = False
        Dim firstName As String = ""
        Dim lastName As String = ""

        'if User is found
        While dr.Read
            userFound = True
            firstName = dr("FirstName").ToString
            lastName = dr("LastName").ToString
        End While

        'Check Result
        If userFound = True Then
            MainScreen.Show()
            MainScreen.lblWelcome.Text = "Welcome " & firstName & " " & lastName
            User = firstName & " " & lastName
            Close()
        Else
            'If the user is not found
			MsgBox("Username/Password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If

        con.Close()
    End Sub
End Class
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if username or password is empty
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Both fields was supply
            ' Check if user exist in database
            ' Connect to DB
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()
            Try
                'conn.Open()
                'MsgBox("Susscess")
                Dim strSelect As String = "SELECT * FROM User_T WHERE username='" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"
                Dim cmdSelect As New SqlCommand(strSelect, conn)

                Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

                If dtr.Read() Then
                    frmChangePassword.Show()
                    Me.Hide()

                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    txtPassword.Text = ""
                    txtUsername.Text = ""

                    'Focus on Username field
                    txtUsername.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'User clicking on cancel button only clears field
        ' and refocus to first field
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub

End Class

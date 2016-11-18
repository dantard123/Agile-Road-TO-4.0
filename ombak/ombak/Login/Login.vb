Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        txtUsername.Focus()

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "SELECT * FROM RememberMe WHERE ID = 1"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                txtUsername.Text = dtr("TempUsername").ToString()
                txtPassword.Text = dtr("TempPassword").ToString()
            End While
        End If
    End Sub

    Private Sub lklblFoget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblFoget.LinkClicked
        ForgetPassword.Show()
    End Sub

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
                Dim strSelect As String = "SELECT * FROM Staff WHERE UserName='" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'"
                Dim cmdSelect As New SqlCommand(strSelect, conn)
                Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
                If chkboxRemember.Checked = False Then
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                End If
                If dtr.Read() Then
                    Globalstaffid = dtr("StaffId").ToString()
                    Globalstaffname = dtr("StaffName").ToString()
                    Globalstaffic = dtr("StaffIC").ToString()
                    Globalstaffgender = dtr("StaffGender").ToString()
                    Globalstaffposition = dtr("StaffPosition").ToString()
                    Globalstaffcontact = dtr("StaffContact").ToString()
                    Globalstaffemail = dtr("StaffEmail").ToString()
                    Globalstaffaddress = dtr("StaffAddress").ToString()
                    Globalusername2 = dtr("UserName").ToString()
                    Globalpassword = dtr("Password").ToString()
                    dtr.Close()
                    If chkboxRemember.Checked = True Then
                        Dim strUpdate As String = "Update RememberMe Set TempUsername = @TempUsername, TempPassword = @TempPassword Where ID = 1"
                        Dim cmdUpdate As New SqlCommand(strUpdate, conn)
                        cmdUpdate.Parameters.AddWithValue("@TempUsername", txtUsername.Text)
                        cmdUpdate.Parameters.AddWithValue("@TempPassword", txtPassword.Text)
                        cmdUpdate.ExecuteNonQuery()
                    End If
                    If Globalstaffposition = "Manager" Then
                        Manager.Show()
                    End If
                    If Globalstaffposition = "Clerk" Then
                        Clerk.Show()
                    End If
                    If Globalstaffposition = "Cashier" Then
                        Cashier.Show()
                    End If
                    chkboxRemember.Checked = False
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
            conn.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'User clicking on cancel button only clears field
        ' and refocus to first field
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class

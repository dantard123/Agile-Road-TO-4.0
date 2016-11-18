Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ChangePassword

    Dim Flag As Boolean = True

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtConfirmPassword.Text <> txtNewPassword.Text) Then
            MessageBox.Show("The confirmation password do not match!")
            Flag = False
        Else
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()
            Try
                Dim strUpdate As String = "Update Staff Set Password = @Password Where UserName = @UserName"
                Dim cmdUpdate As New SqlCommand(strUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@UserName", Globalusername2)
                cmdUpdate.Parameters.AddWithValue("@Password", txtConfirmPassword.Text)
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Password had been updated successfully!")
                GlobalUsername.Globalpassword = txtConfirmPassword.Text()
                txtExistingPassword.Text = ""
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("Invalid data, password has not been updated!")
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub txtExistingPassword_TextChanged(sender As Object, e As EventArgs) Handles txtExistingPassword.Leave
        If (txtExistingPassword.Text <> GlobalUsername.Globalpassword) Then
            MessageBox.Show("The existing password is incorrect!")
            Flag = False
        Else
            Flag = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtExistingPassword.Text = ""
        txtNewPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
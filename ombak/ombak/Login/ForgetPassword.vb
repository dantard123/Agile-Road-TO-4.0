Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ForgetPassword

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtPassword.Text = ""
        Dim flag As Boolean = False
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Staff Where StaffEmail = @StaffEmail"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@StaffEmail", SqlDbType.VarChar).Value = txtEmail.Text
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                txtPassword.Text = dtr("Password").ToString()
                flag = True
            End While
        End If
        If flag = False Then
            MessageBox.Show("Invalid data, please make sure the email address entered correctly!")
            txtEmail.Focus()
        End If
        conn.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
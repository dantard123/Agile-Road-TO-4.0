Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class Cashier

    Private Sub lklblChangePassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblChangePassword.LinkClicked
        ChangePassword.Show()
    End Sub

    Private Sub lklblManageCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblManageCustomer.LinkClicked
        Customer.Show()
    End Sub

    Private Sub lklblManageStock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblManageStock.LinkClicked
        ProductControl.Show()
    End Sub

    Private Sub lklblManagePayment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblManagePayment.LinkClicked
        Payment.Show()
    End Sub

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        lblLoginDate.Text = Date.Today()
        lblLoginTime.Text = TimeOfDay()

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "SELECT * FROM Staff WHERE UserName='" & Globalusername2 & "' AND Password = '" & Globalpassword & "'"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.Read() Then
            lblStaffID.Text = dtr("StaffId").ToString()
            lblStaffName.Text = dtr("StaffName").ToString()
            lblStaffIC.Text = dtr("StaffIC").ToString()
            lblStaffGender.Text = dtr("StaffGender").ToString()
            lblStaffPosition.Text = dtr("StaffPosition").ToString()
            lblStaffContact.Text = dtr("StaffContact").ToString()
            lblStaffEmail.Text = dtr("StaffEmail").ToString()
            lblStaffAddress.Text = dtr("StaffAddress").ToString()
            Dim data As Byte() = DirectCast(dtr("Photo"), Byte())
            Dim ms As New MemoryStream(data)
            profilePicture.Image = Image.FromStream(ms)
            dtr.Close()
        End If
        conn.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class
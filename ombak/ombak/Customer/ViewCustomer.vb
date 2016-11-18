Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ViewCustomer

    Private Sub cboxCusID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCusID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxCusID.SelectedItem


        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtCusName.Text = dtr("CusName").ToString()
                txtCusAge.Text = dtr("Age").ToString()
                txtGender.Text = dtr("Gender").ToString()
                txtEmail.Text = dtr("EmailAddress").ToString()
                txtAddress.Text = dtr("HomeAddress").ToString()
                txtPoint.Text = dtr("Point").ToString()
            End While

        End If

        conn.Close()
        dtr.Close()
    End Sub

    Private Sub lklblAddCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblAddCustomer.LinkClicked
        AddCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblViewCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblViewCustomer.LinkClicked
        Me.Show()
    End Sub

    Private Sub lklblEditCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblEditCustomer.LinkClicked
        EditCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblDeleteCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblDeleteCustomer.LinkClicked
        DeleteCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub lklblPrizeRedemption_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblPrizeRedemption.LinkClicked
        PrizeRedemption.Show()
        Me.Hide()
    End Sub

    Private Sub ViewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer"
        Dim cmdSelect As New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                cboxCusID.Items.Add(dtr("CusID").ToString())
            End While
        End If
        conn.Close()
        dtr.Close()
    End Sub
End Class
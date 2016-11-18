Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration

Public Class AddCustomer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim gender As String
        If rbMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strInsert As String = "Insert Into Customer (CusID, CusName, Age, Gender, EmailAddress, HomeAddress, Point) Values (@CusID, @CusName, @Age, @Gender, @EmailAddress, @HomeAddress, @Point)"
        Dim cmdInsert As New SqlCommand(strInsert, conn)

        Try
            cmdInsert.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = txtCusID.Text
            cmdInsert.Parameters.AddWithValue("@CusName", SqlDbType.VarChar).Value = txtCusName.Text
            cmdInsert.Parameters.AddWithValue("@Age", SqlDbType.VarChar).Value = txtCusAge.Text
            cmdInsert.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = gender
            cmdInsert.Parameters.AddWithValue("@EmailAddress", SqlDbType.VarChar).Value = (txtEmail1.Text + cboxEmail2.SelectedItem)
            cmdInsert.Parameters.AddWithValue("@HomeAddress", SqlDbType.VarChar).Value = txtAddress.Text
            cmdInsert.Parameters.AddWithValue("@Point", SqlDbType.Int).Value = 0
            cmdInsert.ExecuteNonQuery()
            MessageBox.Show("New Customer had been added successfully!")
            SetID()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the customer has not been added!")
        End Try

        conn.Close()
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCusName.Focus()
        SetID()
    End Sub

    Public Sub SetID()
        Dim conn As New SqlConnection

        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                Dim customerid As Integer = dtr("CusID").ToString() + 1
                txtCusID.Text = customerid.ToString()
            End While
        Else
            txtCusID.Text = "1000"
        End If

        conn.Close()
        dtr.Close()
    End Sub

    Private Sub lklblAddCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblAddCustomer.LinkClicked
        Me.Show()
    End Sub

    Private Sub lklblViewCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblViewCustomer.LinkClicked
        ViewCustomer.Show()
        Me.Hide()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtCusName.Text = ""
        txtCusAge.Text = ""
        txtEmail1.Text = ""
        txtAddress.Text = ""
        rbFemale.Checked = False
        rbMale.Checked = False
        cboxEmail2.SelectedIndex = -1
    End Sub

End Class
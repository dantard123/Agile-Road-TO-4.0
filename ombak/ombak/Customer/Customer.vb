Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class Customer

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
                txtACusID.Text = customerid.ToString()
            End While
        Else
            txtACusID.Text = "1000"
        End If

        conn.Close()
        dtr.Close()
    End Sub

    Public Sub ReloadComboBox()
        cboxVCusID.Items.Clear()
        cboxECusID.Items.Clear()
        cboxDCusID.Items.Clear()
        cboxPCusID.Items.Clear()
        cboxRRedemptionID.Items.Clear()
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Order By CusID"
        Dim strSelect2 As String = "Select * From Redeem Order By RedemptionID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        Dim cmdSelect2 As New SqlCommand(strSelect2, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                cboxVCusID.Items.Add(dtr("CusID").ToString())
                cboxECusID.Items.Add(dtr("CusID").ToString())
                cboxDCusID.Items.Add(dtr("CusID").ToString())
                cboxPCusID.Items.Add(dtr("CusID").ToString())
            End While
        End If
        dtr.Close()

        Dim dtr2 As SqlDataReader = cmdSelect2.ExecuteReader()
        If dtr2.HasRows Then
            While dtr2.Read
                cboxRRedemptionID.Items.Add(dtr2("RedemptionID").ToString())
            End While
        End If
        dtr2.Close()

        conn.Close()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        lblStaffID.Text = GlobalUsername.Globalstaffid
        lblStaffName.Text = GlobalUsername.Globalstaffname

        txtACusName.Focus()
        SetID()
        ReloadComboBox()
    End Sub

    Private Sub btnAAdd_Click(sender As Object, e As EventArgs) Handles btnAAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim name As String = txtACusName.Text.Trim()
        Dim ic As String = txtACustomerIC.Text.Trim()
        Dim contact As String = txtAContact.Text.Trim()
        Dim email1 As String = txtAEmail1.Text.Trim()
        Dim homeaddress As String = txtAHomeAddress.Text.Trim()
        Dim email2 As String = cboxAEmail2.SelectedItem

        If name = "" Then
            err.AppendLine("- Name Cannot Be Empty!")
            ctr = If(ctr, txtACusName)
        End If
        If ic = "" Or Not IsNumeric(ic) Or ic.Length <> 12 Then
            err.AppendLine("- Invalid customer IC, must be 12 digits!")
            ctr = If(ctr, txtACustomerIC)
        End If
        If contact = "" Or Not IsNumeric(contact) Or contact.Length <> 10 And contact.Length <> 11 Then
            err.AppendLine("- Invalid contact number, must be 10 or 11 digits!")
            ctr = If(ctr, txtAContact)
        End If
        If email1 = "" Or email2 = "" Then
            err.AppendLine("- Invalid Email Address!")
            ctr = If(ctr, txtAEmail1)
            ctr = If(ctr, cboxAEmail2)
        End If
        If homeaddress = "" Then
            err.AppendLine("- Home Address Cannot Be Empty")
            ctr = If(ctr, txtACusName)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If


        Dim gender As String
        If rbAMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strInsert As String = "Insert Into Customer (CusName, CusIC, Contact, Gender, EmailAddress, HomeAddress, Point) Values (@CusName, @CusIC, @Contact, @Gender, @EmailAddress, @HomeAddress, @Point)"
        Dim cmdInsert As New SqlCommand(strInsert, conn)

        Try
            cmdInsert.Parameters.AddWithValue("@CusName", SqlDbType.VarChar).Value = txtACusName.Text
            cmdInsert.Parameters.AddWithValue("@CusIC", SqlDbType.VarChar).Value = txtACustomerIC.Text
            cmdInsert.Parameters.AddWithValue("@Contact", SqlDbType.VarChar).Value = txtAContact.Text
            cmdInsert.Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = gender
            cmdInsert.Parameters.AddWithValue("@EmailAddress", SqlDbType.VarChar).Value = (txtAEmail1.Text + cboxAEmail2.SelectedItem)
            cmdInsert.Parameters.AddWithValue("@HomeAddress", SqlDbType.VarChar).Value = txtAHomeAddress.Text
            cmdInsert.Parameters.AddWithValue("@Point", SqlDbType.Int).Value = 0
            cmdInsert.ExecuteNonQuery()
            MessageBox.Show("New Customer had been added successfully!")
            SetID()
            ReloadComboBox()
            txtACusName.Text = ""
            txtACustomerIC.Text = ""
            txtAContact.Text = ""
            txtAEmail1.Text = ""
            txtAHomeAddress.Text = ""
            rbAFemale.Checked = False
            rbAMale.Checked = False
            cboxAEmail2.SelectedIndex = -1
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the customer has not been added!")
        End Try

        conn.Close()
    End Sub

    Private Sub btnACancel_Click(sender As Object, e As EventArgs) Handles btnACancel.Click
        txtACusName.Text = ""
        txtACustomerIC.Text = ""
        txtAContact.Text = ""
        txtAEmail1.Text = ""
        txtAHomeAddress.Text = ""
        rbAFemale.Checked = False
        rbAMale.Checked = False
        cboxAEmail2.SelectedIndex = -1
    End Sub

    Private Sub cboxVCusID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxVCusID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxVCusID.SelectedItem

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                txtVCusName.Text = dtr("CusName").ToString()
                txtVCustomerIC.Text = dtr("CusIC").ToString()
                txtVContact.Text = dtr("Contact").ToString()
                txtVGender.Text = dtr("Gender").ToString()
                txtVEmail.Text = dtr("EmailAddress").ToString()
                txtVHomeAddress.Text = dtr("HomeAddress").ToString()
                txtVPoint.Text = dtr("Point").ToString()
            End While
        End If
        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnVCancel_Click(sender As Object, e As EventArgs) Handles btnVCancel.Click
        cboxVCusID.SelectedIndex = 0
        txtVCusName.Text = ""
        txtVCustomerIC.Text = ""
        txtVContact.Text = ""
        txtVGender.Text = ""
        txtVEmail.Text = ""
        txtVHomeAddress.Text = ""
        txtVPoint.Text = ""
    End Sub

    Private Sub cboxECusID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxECusID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxECusID.SelectedItem

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtECusName.Text = dtr("CusName").ToString()
                txtECustomerIC.Text = dtr("CusIC").ToString()
                txtEContact.Text = dtr("Contact").ToString()
                txtEGender.Text = dtr("Gender").ToString()
                txtEEmail.Text = dtr("EmailAddress").ToString()
                txtEHomeAddress.Text = dtr("HomeAddress").ToString()
                txtEPoint.Text = dtr("Point").ToString()
            End While
        End If
        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnEUpdate_Click(sender As Object, e As EventArgs) Handles btnEUpdate.Click
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Try
            Dim strUpdate As String = "Update Customer Set Contact = @Contact, EmailAddress = @EmailAddress, HomeAddress = @HomeAddress Where CusID = @CusID"
            Dim cmdUpdate As New SqlCommand(strUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxECusID.SelectedItem
            cmdUpdate.Parameters.AddWithValue("@Contact", txtEContact.Text)
            cmdUpdate.Parameters.AddWithValue("@EmailAddress", txtEEmail.Text)
            cmdUpdate.Parameters.AddWithValue("@HomeAddress", txtEHomeAddress.Text)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Customer detail had been updated successfully!")
            ReloadComboBox()
            cboxECusID.SelectedIndex = 0
            txtECusName.Text = ""
            txtECustomerIC.Text = ""
            txtEContact.Text = ""
            txtEGender.Text = ""
            txtEEmail.Text = ""
            txtEHomeAddress.Text = ""
            txtEPoint.Text = ""
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the customer detail has not been updated!")
        End Try
        conn.Close()
    End Sub

    Private Sub btnECancel_Click(sender As Object, e As EventArgs) Handles btnECancel.Click
        cboxECusID.SelectedIndex = 0
        txtECusName.Text = ""
        txtECustomerIC.Text = ""
        txtEContact.Text = ""
        txtEGender.Text = ""
        txtEEmail.Text = ""
        txtEHomeAddress.Text = ""
        txtEPoint.Text = ""
    End Sub

    Private Sub cboxDCusID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxDCusID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxDCusID.SelectedItem

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtDCusName.Text = dtr("CusName").ToString()
                txtDCustomerIC.Text = dtr("CusIC").ToString()
                txtDContact.Text = dtr("Contact").ToString()
                txtDGender.Text = dtr("Gender").ToString()
                txtDEmail.Text = dtr("EmailAddress").ToString()
                txtDHomeAddress.Text = dtr("HomeAddress").ToString()
                txtDPoint.Text = dtr("Point").ToString()
            End While
        End If
        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnDDelete_Click(sender As Object, e As EventArgs) Handles btnDDelete.Click
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strDelete As String = "Delete Customer Where CusID = @CusID"
        Dim cmdDelete As New SqlCommand(strDelete, conn)
        cmdDelete.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxDCusID.SelectedItem

        Dim Box As MsgBoxResult = MsgBox("Do you sure you want to delete it?", MsgBoxStyle.YesNo)
        If Box = MsgBoxResult.Yes Then
            cmdDelete.ExecuteNonQuery()
            MessageBox.Show("The specific customer detail had been deleted successfully!")
            ReloadComboBox()
            cboxDCusID.SelectedIndex = 0
            txtDCusName.Text = ""
            txtDCustomerIC.Text = ""
            txtDContact.Text = ""
            txtDGender.Text = ""
            txtDEmail.Text = ""
            txtDHomeAddress.Text = ""
            txtDPoint.Text = ""
        End If
        conn.Close()
    End Sub

    Private Sub btnDCancel_Click(sender As Object, e As EventArgs) Handles btnDCancel.Click
        cboxDCusID.SelectedIndex = 0
        txtDCusName.Text = ""
        txtDCustomerIC.Text = ""
        txtDContact.Text = ""
        txtDGender.Text = ""
        txtDEmail.Text = ""
        txtDHomeAddress.Text = ""
        txtDPoint.Text = ""
    End Sub

    Private Sub cboxPCusID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPCusID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxPCusID.SelectedItem

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                txtPCusName.Text = dtr("CusName").ToString()
                txtPPoint.Text = dtr("Point").ToString()
            End While
        End If
        dtr.Close()
        conn.Close()
    End Sub

    Private Sub cboxPSelectPrize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPSelectPrize.SelectedIndexChanged
        If cboxPSelectPrize.SelectedIndex = 0 Then
            txtPSinglePrizePoint.Text = "30"
        ElseIf cboxPSelectPrize.SelectedIndex = 1 Or cboxPSelectPrize.SelectedIndex = 2 Then
            txtPSinglePrizePoint.Text = "20"
        Else
            txtPSinglePrizePoint.Text = "10"
        End If
    End Sub

    Private Sub btnPRedeem_Click(sender As Object, e As EventArgs) Handles btnPRedeem.Click
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strInsert As String = "Insert Into Redeem (CustomerID, CustomerName, PrizeName, PrizePoint, PrizeAmount, TotalPrizePoint) Values (@CustomerID, @CustomerName, @PrizeName, @PrizePoint, @PrizeAmount, @TotalPrizePoint)"
        Dim strUpdate As String = "Update Customer Set Point=@Point Where CusID = @CusID"
        Dim cmdInsert As New SqlCommand(strInsert, conn)
        Dim cmdUpdate As New SqlCommand(strUpdate, conn)

        Try
            cmdInsert.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Value = cboxPCusID.Text
            cmdInsert.Parameters.AddWithValue("@CustomerName", SqlDbType.VarChar).Value = txtPCusName.Text
            cmdInsert.Parameters.AddWithValue("@PrizeName", SqlDbType.VarChar).Value = cboxPSelectPrize.Text
            cmdInsert.Parameters.AddWithValue("@PrizePoint", SqlDbType.VarChar).Value = txtPSinglePrizePoint.Text
            cmdInsert.Parameters.AddWithValue("@PrizeAmount", SqlDbType.VarChar).Value = cboxPPrizeAmount.SelectedItem
            cmdInsert.Parameters.AddWithValue("@TotalPrizePoint", SqlDbType.VarChar).Value = txtPTotalPrizePoint.Text
            cmdUpdate.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = cboxPCusID.Text
            cmdUpdate.Parameters.AddWithValue("@Point", SqlDbType.Int).Value = txtPBalancePoint.Text
            cmdInsert.ExecuteNonQuery()
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("New Redemption had been added successfully!")
            SetID()
            ReloadComboBox()
            cboxPCusID.SelectedIndex = 0
            txtPCusName.Text = ""
            txtPPoint.Text = ""
            cboxPSelectPrize.SelectedIndex = -1
            txtPBalancePoint.Text = ""
            cboxPPrizeAmount.SelectedIndex = -1
            txtPSinglePrizePoint.Text = ""
            txtPTotalPrizePoint.Text = ""
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the redemption has not been added!")
        End Try

        conn.Close()
    End Sub

    Private Sub btnPCancel_Click(sender As Object, e As EventArgs) Handles btnPCancel.Click
        cboxPCusID.SelectedIndex = 0
        txtPCusName.Text = ""
        txtPPoint.Text = ""
        cboxPSelectPrize.SelectedIndex = -1
        txtPBalancePoint.Text = ""
        cboxPPrizeAmount.SelectedIndex = -1
        txtPSinglePrizePoint.Text = ""
        txtPTotalPrizePoint.Text = ""
    End Sub

    Private Sub cboxPPrizeAmount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPPrizeAmount.SelectedIndexChanged

        Try
            Dim SinglePrizePoint As Integer = Integer.Parse(txtPSinglePrizePoint.Text)
            Dim PrizeAmount As Integer = Integer.Parse(cboxPPrizeAmount.SelectedItem)
            Dim Point As Integer = Integer.Parse(txtPPoint.Text)
            Dim TotalPrizePoint As Integer
            Dim BalancePoint As Integer

            TotalPrizePoint = SinglePrizePoint * PrizeAmount
            BalancePoint = Point - TotalPrizePoint

            txtPTotalPrizePoint.Text = TotalPrizePoint.ToString()
            txtPBalancePoint.Text = BalancePoint.ToString()

            If BalancePoint < 0 Then
                MessageBox.Show("Invalid data, not enough point to redeem the product!")
                cboxPPrizeAmount.SelectedIndex = -1
            End If
        Catch ex As ArgumentNullException

        End Try
    End Sub

    Private Sub cboxRRedemptionID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRRedemptionID.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Redeem Where RedemptionID = @RedemptionID"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@RedemptionID", SqlDbType.Int).Value = cboxRRedemptionID.SelectedItem

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                txtRCustomerID.Text = dtr("CustomerID").ToString()
                txtRCustomerName.Text = dtr("CustomerName").ToString()
                txtRPrizeName.Text = dtr("PrizeName").ToString()
                txtRPrizePoint.Text = dtr("PrizePoint").ToString()
                txtRPrizeAmount.Text = dtr("PrizeAmount").ToString()
                txtRTotalPrizePoint.Text = dtr("TotalPrizePoint").ToString()
            End While
        End If
        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnRCancel_Click(sender As Object, e As EventArgs) Handles btnRCancel.Click
        cboxRRedemptionID.SelectedIndex = 0
        txtRCustomerID.Text = ""
        txtRCustomerName.Text = ""
        txtRPrizeName.Text = ""
        txtRPrizePoint.Text = ""
        txtRPrizeAmount.Text = ""
        txtRTotalPrizePoint.Text = ""
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub
End Class
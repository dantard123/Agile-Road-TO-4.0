Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Text

Public Class Payment
    Dim strProductID(6, 54) As Integer
    Dim strProductName(6, 54) As String
    Dim strProductPrice(6, 54) As String
    Dim strProductCategory(6, 54) As String
    Dim intProductQuantity(6, 54) As Integer
    Dim intAlterQuantity(6, 54) As Integer
    Dim intTrack As Integer = 0
    Dim strChange, strTendered As String

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaffID.Text = GlobalUsername.Globalstaffid
        lblStaffName.Text = GlobalUsername.Globalstaffname

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "SELECT * FROM Staff WHERE UserName='" & Globalusername2 & "' AND Password = '" & GlobalUsername.Globalpassword & "'"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.Read() Then
            Dim data As Byte() = DirectCast(dtr("Photo"), Byte())
            Dim ms As New MemoryStream(data)
            profilepicture.Image = Image.FromStream(ms)
            dtr.Close()
        End If
        conn.Close()
        resetDGV()
        resetPaymentDetail()
        Me.PaymentTempTableAdapter.Fill(Me.DatabaseDataSet.PaymentTemp)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        getButtonValue("Beverage")
        DGV.Columns(0).ReadOnly = False
        DGV.AllowUserToResizeColumns = False
        DGV.AllowUserToResizeRows = False
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
    End Sub

    Sub enableButton(ByVal index, ByVal id, ByVal name, ByVal price, ByVal category, ByVal quantity)
        Dim btn As Button = CType(Me.Controls("btnItem" + index.ToString()), Button)
        btn.Enabled = True
        btn.Text = name
        strProductID(intTrack, index) = id
        strProductName(intTrack, index) = name
        strProductPrice(intTrack, index) = price
        strProductCategory(intTrack, index) = category
        intProductQuantity(intTrack, index) = quantity
    End Sub
    Sub disableButton()
        Dim i As Integer
        For i = 0 To 53
            Dim btn As Button = CType(Me.Controls("btnItem" + i.ToString()), Button)
            btn.Enabled = False
            btn.Text = ""
        Next
    End Sub
    Sub getButtonValue(ByVal category)
        disableButton()
        setButtonFocus(intTrack)
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "Select * From Product Where ProductCategory = @ProductCategory"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@ProductCategory", category)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        Dim i As Integer = 0
        If dtr.HasRows Then
            While dtr.Read
                enableButton(i, dtr("ProductID"), dtr("ProductName").ToString(), dtr("UnitPrice").ToString(), dtr("ProductCategory").ToString(), dtr("QuantityAvailable"))
                i += 1
            End While
        End If
        conn.Close()
        dtr.Close()
    End Sub
    Sub setButtonFocus(ByVal btnIndex)
        If btnIndex = 0 Then
            btnBeverage.BackColor = Color.Aqua
            btnFood.BackColor = Color.Transparent
            btnSnack.BackColor = Color.Transparent
            btnDailySupplies.BackColor = Color.Transparent
            btnMagazine.BackColor = Color.Transparent
            btnOther.BackColor = Color.Transparent
        ElseIf btnIndex = 1 Then
            btnBeverage.BackColor = Color.Transparent
            btnFood.BackColor = Color.Aqua
            btnSnack.BackColor = Color.Transparent
            btnDailySupplies.BackColor = Color.Transparent
            btnMagazine.BackColor = Color.Transparent
            btnOther.BackColor = Color.Transparent
        ElseIf btnIndex = 2 Then
            btnBeverage.BackColor = Color.Transparent
            btnFood.BackColor = Color.Transparent
            btnSnack.BackColor = Color.Aqua
            btnDailySupplies.BackColor = Color.Transparent
            btnMagazine.BackColor = Color.Transparent
            btnOther.BackColor = Color.Transparent
        ElseIf btnIndex = 3 Then
            btnBeverage.BackColor = Color.Transparent
            btnFood.BackColor = Color.Transparent
            btnSnack.BackColor = Color.Transparent
            btnDailySupplies.BackColor = Color.Aqua
            btnMagazine.BackColor = Color.Transparent
            btnOther.BackColor = Color.Transparent
        ElseIf btnIndex = 4 Then
            btnBeverage.BackColor = Color.Transparent
            btnFood.BackColor = Color.Transparent
            btnSnack.BackColor = Color.Transparent
            btnDailySupplies.BackColor = Color.Transparent
            btnMagazine.BackColor = Color.Aqua
            btnOther.BackColor = Color.Transparent
        ElseIf btnIndex = 5 Then
            btnBeverage.BackColor = Color.Transparent
            btnFood.BackColor = Color.Transparent
            btnSnack.BackColor = Color.Transparent
            btnDailySupplies.BackColor = Color.Transparent
            btnMagazine.BackColor = Color.Transparent
            btnOther.BackColor = Color.Aqua
        End If
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        intTrack = 5
        getButtonValue("Other")
    End Sub
    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        intTrack = 1
        getButtonValue("Food")
    End Sub
    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        intTrack = 2
        getButtonValue("Snack")
    End Sub
    Private Sub btnDailySupplies_Click(sender As Object, e As EventArgs) Handles btnDailySupplies.Click
        intTrack = 3
        getButtonValue("Daily Supplies")
    End Sub
    Private Sub btnMagazine_Click(sender As Object, e As EventArgs) Handles btnMagazine.Click
        intTrack = 4
        getButtonValue("Magazine")
    End Sub
    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        intTrack = 0
        getButtonValue("Beverage")
    End Sub

    Function checkExisting(ByVal pName)
        Dim flag As Boolean = False
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "Select * From PaymentTemp"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                If pName.Equals(dtr("ProductName").ToString()) Then
                    flag = True
                End If
            End While
        End If
        conn.Close()
        dtr.Close()
        Return flag
    End Function

    Sub productInsert(ByVal index)
        Dim flag As Boolean
        flag = checkExisting(strProductName(intTrack, index))
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        If flag Then
            Try
                Dim strInsert As String = "Update PaymentTemp Set SubTotal=@SubTotal, Quantity=@Quantity Where ProductName=@ProductName"
                Dim cmdInsert As New SqlCommand(strInsert, conn)
                cmdInsert.Parameters.AddWithValue("@ProductName", strProductName(intTrack, index))
                cmdInsert.Parameters.AddWithValue("@SubTotal", (intAlterQuantity(intTrack, index) * strProductPrice(intTrack, index)).ToString("0.00"))
                cmdInsert.Parameters.AddWithValue("@Quantity", intAlterQuantity(intTrack, index))
                cmdInsert.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("Failed Update the Value!")
            End Try
        Else
            Try
                Dim strInsert As String = "Insert Into PaymentTemp (ProductName, UnitPrice, SubTotal, Quantity) Values (@ProductName, @UnitPrice, @SubTotal, @Quantity)"
                Dim cmdInsert As New SqlCommand(strInsert, conn)
                cmdInsert.Parameters.AddWithValue("@ProductName", SqlDbType.VarChar).Value = strProductName(intTrack, index)
                cmdInsert.Parameters.AddWithValue("@UnitPrice", SqlDbType.VarChar).Value = strProductPrice(intTrack, index)
                cmdInsert.Parameters.AddWithValue("@SubTotal", SqlDbType.VarChar).Value = (intAlterQuantity(intTrack, index) * strProductPrice(intTrack, index)).ToString("0.00")
                cmdInsert.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = intAlterQuantity(intTrack, index)
                cmdInsert.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("Failed Adding the Value!")
            End Try
        End If
        conn.Close()
        refreshDGV()
        calculateTotal()
        setNcalculate()
    End Sub

    Sub calculateTotal()
        Dim dblTtl As Double
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "Select * From PaymentTemp"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                dblTtl += dtr("Subtotal").ToString()
            End While
        End If
        conn.Close()
        dtr.Close()
        lblTotal.Text = dblTtl.ToString("0.00")
    End Sub

    Private Sub btnItem0_Click(sender As Object, e As EventArgs) Handles btnItem0.Click
        intAlterQuantity(intTrack, 0) += 1
        productInsert(0)
    End Sub
    Private Sub btnItem1_Click(sender As Object, e As EventArgs) Handles btnItem1.Click
        intAlterQuantity(intTrack, 1) += 1
        productInsert(1)
    End Sub
    Private Sub btnItem2_Click(sender As Object, e As EventArgs) Handles btnItem2.Click
        intAlterQuantity(intTrack, 2) += 1
        productInsert(2)
    End Sub
    Private Sub btnItem3_Click(sender As Object, e As EventArgs) Handles btnItem3.Click
        intAlterQuantity(intTrack, 3) += 1
        productInsert(3)
    End Sub
    Private Sub btnItem4_Click(sender As Object, e As EventArgs) Handles btnItem4.Click
        intAlterQuantity(intTrack, 4) += 1
        productInsert(4)
    End Sub
    Private Sub btnItem5_Click(sender As Object, e As EventArgs) Handles btnItem5.Click
        intAlterQuantity(intTrack, 5) += 1
        productInsert(5)
    End Sub
    Private Sub btnItem6_Click(sender As Object, e As EventArgs) Handles btnItem6.Click
        intAlterQuantity(intTrack, 6) += 1
        productInsert(6)
    End Sub
    Private Sub btnItem7_Click(sender As Object, e As EventArgs) Handles btnItem7.Click
        intAlterQuantity(intTrack, 7) += 1
        productInsert(7)
    End Sub
    Private Sub btnItem8_Click(sender As Object, e As EventArgs) Handles btnItem8.Click
        intAlterQuantity(intTrack, 8) += 1
        productInsert(8)
    End Sub
    Private Sub btnItem9_Click(sender As Object, e As EventArgs) Handles btnItem9.Click
        intAlterQuantity(intTrack, 9) += 1
        productInsert(9)
    End Sub
    Private Sub btnItem10_Click(sender As Object, e As EventArgs) Handles btnItem10.Click
        intAlterQuantity(intTrack, 10) += 1
        productInsert(10)
    End Sub
    Private Sub btnItem11_Click(sender As Object, e As EventArgs) Handles btnItem11.Click
        intAlterQuantity(intTrack, 11) += 1
        productInsert(11)
    End Sub
    Private Sub btnItem12_Click(sender As Object, e As EventArgs) Handles btnItem12.Click
        intAlterQuantity(intTrack, 12) += 1
        productInsert(12)
    End Sub
    Private Sub btnItem13_Click(sender As Object, e As EventArgs) Handles btnItem13.Click
        intAlterQuantity(intTrack, 13) += 1
        productInsert(13)
    End Sub
    Private Sub btnItem14_Click(sender As Object, e As EventArgs) Handles btnItem14.Click
        intAlterQuantity(intTrack, 14) += 1
        productInsert(14)
    End Sub
    Private Sub btnItem15_Click(sender As Object, e As EventArgs) Handles btnItem15.Click
        intAlterQuantity(intTrack, 15) += 1
        productInsert(15)
    End Sub
    Private Sub btnItem16_Click(sender As Object, e As EventArgs) Handles btnItem16.Click
        intAlterQuantity(intTrack, 16) += 1
        productInsert(16)
    End Sub
    Private Sub btnItem17_Click(sender As Object, e As EventArgs) Handles btnItem17.Click
        intAlterQuantity(intTrack, 17) += 1
        productInsert(17)
    End Sub
    Private Sub btnItem18_Click(sender As Object, e As EventArgs) Handles btnItem18.Click
        intAlterQuantity(intTrack, 18) += 1
        productInsert(18)
    End Sub
    Private Sub btnItem19_Click(sender As Object, e As EventArgs) Handles btnItem19.Click
        intAlterQuantity(intTrack, 19) += 1
        productInsert(19)
    End Sub
    Private Sub btnItem20_Click(sender As Object, e As EventArgs) Handles btnItem20.Click
        intAlterQuantity(intTrack, 20) += 1
        productInsert(20)
    End Sub
    Private Sub btnItem21_Click(sender As Object, e As EventArgs) Handles btnItem21.Click
        intAlterQuantity(intTrack, 21) += 1
        productInsert(21)
    End Sub
    Private Sub btnItem22_Click(sender As Object, e As EventArgs) Handles btnItem22.Click
        intAlterQuantity(intTrack, 22) += 1
        productInsert(22)
    End Sub
    Private Sub btnItem23_Click(sender As Object, e As EventArgs) Handles btnItem23.Click
        intAlterQuantity(intTrack, 23) += 1
        productInsert(23)
    End Sub
    Private Sub btnItem24_Click(sender As Object, e As EventArgs) Handles btnItem24.Click
        intAlterQuantity(intTrack, 24) += 1
        productInsert(24)
    End Sub
    Private Sub btnItem25_Click(sender As Object, e As EventArgs) Handles btnItem25.Click
        intAlterQuantity(intTrack, 25) += 1
        productInsert(25)
    End Sub
    Private Sub btnItem26_Click(sender As Object, e As EventArgs) Handles btnItem26.Click
        intAlterQuantity(intTrack, 26) += 1
        productInsert(26)
    End Sub
    Private Sub btnItem27_Click(sender As Object, e As EventArgs) Handles btnItem27.Click
        intAlterQuantity(intTrack, 27) += 1
        productInsert(27)
    End Sub
    Private Sub btnItem28_Click(sender As Object, e As EventArgs) Handles btnItem28.Click
        intAlterQuantity(intTrack, 28) += 1
        productInsert(28)
    End Sub
    Private Sub btnItem29_Click(sender As Object, e As EventArgs) Handles btnItem29.Click
        intAlterQuantity(intTrack, 29) += 1
        productInsert(29)
    End Sub
    Private Sub btnItem30_Click(sender As Object, e As EventArgs) Handles btnItem30.Click
        intAlterQuantity(intTrack, 30) += 1
        productInsert(30)
    End Sub
    Private Sub btnItem31_Click(sender As Object, e As EventArgs) Handles btnItem31.Click
        intAlterQuantity(intTrack, 31) += 1
        productInsert(31)
    End Sub
    Private Sub btnItem32_Click(sender As Object, e As EventArgs) Handles btnItem32.Click
        intAlterQuantity(intTrack, 32) += 1
        productInsert(32)
    End Sub
    Private Sub btnItem33_Click(sender As Object, e As EventArgs) Handles btnItem33.Click
        intAlterQuantity(intTrack, 33) += 1
        productInsert(33)
    End Sub
    Private Sub btnItem34_Click(sender As Object, e As EventArgs) Handles btnItem34.Click
        intAlterQuantity(intTrack, 34) += 1
        productInsert(34)
    End Sub
    Private Sub btnItem35_Click(sender As Object, e As EventArgs) Handles btnItem35.Click
        intAlterQuantity(intTrack, 35) += 1
        productInsert(35)
    End Sub
    Private Sub btnItem36_Click(sender As Object, e As EventArgs) Handles btnItem36.Click
        intAlterQuantity(intTrack, 36) += 1
        productInsert(36)
    End Sub
    Private Sub btnItem37_Click(sender As Object, e As EventArgs) Handles btnItem37.Click
        intAlterQuantity(intTrack, 37) += 1
        productInsert(37)
    End Sub
    Private Sub btnItem38_Click(sender As Object, e As EventArgs) Handles btnItem38.Click
        intAlterQuantity(intTrack, 38) += 1
        productInsert(38)
    End Sub
    Private Sub btnItem39_Click(sender As Object, e As EventArgs) Handles btnItem39.Click
        intAlterQuantity(intTrack, 39) += 1
        productInsert(39)
    End Sub
    Private Sub btnItem40_Click(sender As Object, e As EventArgs) Handles btnItem40.Click
        intAlterQuantity(intTrack, 40) += 1
        productInsert(40)
    End Sub
    Private Sub btnItem41_Click(sender As Object, e As EventArgs) Handles btnItem41.Click
        intAlterQuantity(intTrack, 41) += 1
        productInsert(41)
    End Sub
    Private Sub btnItem42_Click(sender As Object, e As EventArgs) Handles btnItem42.Click
        intAlterQuantity(intTrack, 42) += 1
        productInsert(42)
    End Sub
    Private Sub btnItem43_Click(sender As Object, e As EventArgs) Handles btnItem43.Click
        intAlterQuantity(intTrack, 43) += 1
        productInsert(43)
    End Sub
    Private Sub btnItem44_Click(sender As Object, e As EventArgs) Handles btnItem44.Click
        intAlterQuantity(intTrack, 44) += 1
        productInsert(44)
    End Sub
    Private Sub btnItem45_Click(sender As Object, e As EventArgs) Handles btnItem45.Click
        intAlterQuantity(intTrack, 45) += 1
        productInsert(45)
    End Sub
    Private Sub btnItem46_Click(sender As Object, e As EventArgs) Handles btnItem46.Click
        intAlterQuantity(intTrack, 46) += 1
        productInsert(46)
    End Sub
    Private Sub btnItem47_Click(sender As Object, e As EventArgs) Handles btnItem47.Click
        intAlterQuantity(intTrack, 47) += 1
        productInsert(47)
    End Sub
    Private Sub btnItem48_Click(sender As Object, e As EventArgs) Handles btnItem48.Click
        intAlterQuantity(intTrack, 48) += 1
        productInsert(48)
    End Sub
    Private Sub btnItem49_Click(sender As Object, e As EventArgs) Handles btnItem49.Click
        intAlterQuantity(intTrack, 49) += 1
        productInsert(49)
    End Sub
    Private Sub btnItem50_Click(sender As Object, e As EventArgs) Handles btnItem50.Click
        intAlterQuantity(intTrack, 50) += 1
        productInsert(50)
    End Sub
    Private Sub btnItem51_Click(sender As Object, e As EventArgs) Handles btnItem51.Click
        intAlterQuantity(intTrack, 51) += 1
        productInsert(51)
    End Sub
    Private Sub btnItem52_Click(sender As Object, e As EventArgs) Handles btnItem52.Click
        intAlterQuantity(intTrack, 52) += 1
        productInsert(52)
    End Sub
    Private Sub btnItem53_Click(sender As Object, e As EventArgs) Handles btnItem53.Click
        intAlterQuantity(intTrack, 53) += 1
        productInsert(53)
    End Sub

    Sub resetPaymentDetail()
        txtAmountTendered.Text = "0.00"
        lblChangeDue.Text = "0.00"
        lblTotal.Text = "0.00"
        strChange = "0.00"
        strTendered = "0.00"
        txtMemberID.Text = ""
        lblValid.Text = ""
    End Sub
    Sub refreshDGV()
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim dt As New DataTable
        dt.Clear()
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("Select * from PaymentTemp", conn)
        da.Fill(dt)
        DGV.DataSource = dt
        conn.Close()
    End Sub
    Sub resetDGV()
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            Dim strSelect As String = "Delete From PaymentTemp"
            Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
            cmdSelect.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to Reset")
        End Try
        conn.Close()
    End Sub
    Sub resetTempValue()
        Dim i, j As Integer
        For i = 0 To 5
            For j = 0 To 53
                strProductID(i, j) = 0
                strProductName(i, j) = ""
                strProductPrice(i, j) = ""
                strProductCategory(i, j) = ""
                intProductQuantity(i, j) = 0
                intAlterQuantity(i, j) = 0
            Next
        Next
        intTrack = 0
    End Sub
    Sub resetAll()
        resetDGV()
        refreshDGV()
        resetTempValue()
        resetPaymentDetail()
        getButtonValue("Beverage")
    End Sub

    Private Sub txtAmountTendered_TextChanged(sender As Object, e As EventArgs) Handles txtAmountTendered.Leave
        strTendered = txtAmountTendered.Text
        setNcalculate()
    End Sub
    Sub setNcalculate()
        txtAmountTendered.Text = FormatNumber(strTendered, 2)
        lblChangeDue.Text = (strTendered - lblTotal.Text).ToString("0.00")
    End Sub

    Private Sub btnRM100_Click(sender As Object, e As EventArgs) Handles btnRM100.Click
        strTendered += 100
        setNcalculate()
    End Sub
    Private Sub btnRM10_Click(sender As Object, e As EventArgs) Handles btnRM10.Click
        strTendered += 10
        setNcalculate()
    End Sub
    Private Sub btnRM50_Click(sender As Object, e As EventArgs) Handles btnRM50.Click
        strTendered += 50
        setNcalculate()
    End Sub
    Private Sub btnRM5_Click(sender As Object, e As EventArgs) Handles btnRM5.Click
        strTendered += 5
        setNcalculate()
    End Sub
    Private Sub btnRM20_Click(sender As Object, e As EventArgs) Handles btnRM20.Click
        strTendered += 20
        setNcalculate()
    End Sub
    Private Sub btnRM1_Click(sender As Object, e As EventArgs) Handles btnRM1.Click
        strTendered += 1
        setNcalculate()
    End Sub

    Function checkMemberID(ByVal memberID)
        Dim check As Boolean = False
        Try
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()
            Dim strSelect As String = "Select * From Customer Where CusID = @CusID"
            Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
            cmdSelect.Parameters.AddWithValue("@CusID", memberID)
            Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
            If dtr.HasRows Then
                While dtr.Read
                    check = True
                End While
            End If
            conn.Close()
            dtr.Close()
        Catch ex As System.Data.SqlClient.SqlException
            check = False
        End Try
        Return check
    End Function
    Function savePayment()
        Dim newID As Integer
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            If checkMemberID(txtMemberID.Text) Then
                Dim strInsert As String = "Insert Into Payment (MemberID, StaffID, PaymentDate, TotalAmount) Values (@MemberID, @StaffID, @PaymentDate, @TotalAmount); SELECT @@IDENTITY"
                Dim cmdInsert As New SqlCommand(strInsert, conn)
                cmdInsert.Parameters.AddWithValue("@MemberID", SqlDbType.Int).Value = txtMemberID.Text
                cmdInsert.Parameters.AddWithValue("@StaffID", SqlDbType.Int).Value = GlobalUsername.Globalstaffid
                cmdInsert.Parameters.AddWithValue("@PaymentDate", SqlDbType.VarChar).Value = Date.Now().ToString("dd/MM/yyyy")
                cmdInsert.Parameters.AddWithValue("@TotalAmount", SqlDbType.VarChar).Value = lblTotal.Text
                newID = cmdInsert.ExecuteScalar()
            Else
                Dim strInsert As String = "Insert Into Payment (StaffID, PaymentDate, TotalAmount) Values (@StaffID, @PaymentDate, @TotalAmount); SELECT @@IDENTITY"
                Dim cmdInsert As New SqlCommand(strInsert, conn)
                cmdInsert.Parameters.AddWithValue("@StaffID", SqlDbType.Int).Value = GlobalUsername.Globalstaffid
                cmdInsert.Parameters.AddWithValue("@PaymentDate", SqlDbType.VarChar).Value = Date.Now().ToString("dd/MM/yyyy")
                cmdInsert.Parameters.AddWithValue("@TotalAmount", SqlDbType.VarChar).Value = lblTotal.Text
                newID = cmdInsert.ExecuteScalar()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error Inserting Payment!")
        End Try
        conn.Close()
        Return newID
    End Function
    Sub savePaymentDetail(ByVal newID)
        Dim i, j As Integer
        For i = 0 To 5
            For j = 0 To 53
                If intAlterQuantity(i, j) <> 0 Then
                    Dim conn As New SqlConnection
                    Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
                    conn = New SqlConnection(connstr)
                    conn.Open()
                    Try
                        Dim strInsert As String = "Insert Into PaymentDetail (PaymentID, ProductID, Quantity, UnitPrice, SubTotal, ProductName, ProductCategory) Values (@PaymentID, @ProductID, @Quantity, @UnitPrice, @SubTotal, @ProductName, @ProductCategory)"
                        Dim cmdInsert As New SqlCommand(strInsert, conn)
                        cmdInsert.Parameters.AddWithValue("@PaymentID", SqlDbType.Int).Value = newID
                        cmdInsert.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = strProductID(i, j)
                        cmdInsert.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = intAlterQuantity(i, j)
                        cmdInsert.Parameters.AddWithValue("@UnitPrice", SqlDbType.VarChar).Value = strProductPrice(i, j)
                        cmdInsert.Parameters.AddWithValue("@SubTotal", SqlDbType.VarChar).Value = (strProductPrice(i, j) * intAlterQuantity(i, j)).ToString("0.00")
                        cmdInsert.Parameters.AddWithValue("@ProductName", SqlDbType.VarChar).Value = strProductName(i, j)
                        cmdInsert.Parameters.AddWithValue("@ProductCategory", SqlDbType.VarChar).Value = strProductCategory(i, j)
                        cmdInsert.ExecuteNonQuery()
                        updateStockQuantity(strProductID(i, j), (intProductQuantity(i, j) - intAlterQuantity(i, j)))
                    Catch ex As System.Data.SqlClient.SqlException
                        MessageBox.Show("Error Inserting Payment Detail!")
                    End Try
                    conn.Close()
                End If
            Next
        Next
    End Sub
    Sub updateStockQuantity(ByVal productID, ByVal quantity)
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            Dim strInsert As String = "Update Product Set QuantityAvailable=@QuantityAvailable Where ProductID=@ProductID"
            Dim cmdInsert As New SqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@QuantityAvailable", quantity)
            cmdInsert.Parameters.AddWithValue("@ProductID", productID)
            cmdInsert.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Failed Update the Quantity!")
        End Try
        conn.Close()
    End Sub
    Sub updateMembershipPoint(ByVal point, ByVal memberID)
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            Dim strInsert As String = "Update Customer Set Point=@Point Where CusID=@CusID"
            Dim cmdInsert As New SqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@Point", point)
            cmdInsert.Parameters.AddWithValue("@CusID", memberID)
            cmdInsert.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Failed Update the Point!")
        End Try
        conn.Close()
    End Sub
    Sub printBill()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog(Me)
    End Sub
    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        If lblTotal.Text = 0 Then
            MessageBox.Show("No Item to be Pay!")
        ElseIf lblChangeDue.Text >= 0 Then
            Dim newID As Integer
            newID = savePayment()
            If newID <> 0 Then
                savePaymentDetail(newID)
            Else
                MessageBox.Show("Error No Payment ID Found!")
            End If
            MessageBox.Show("Payment Sucessful!")
            updateMembershipPoint(Int32.Parse(Math.Floor(Double.Parse(lblTotal.Text))), txtMemberID.Text)
            printBill()
            resetAll()
        Else
            MessageBox.Show("Invalid Amount Tendered!")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetAll()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        If GlobalUsername.Globalstaffposition = "Manager" Then
            AdminFunction.Show()
        Else
            MessageBox.Show("Only manager allow to manage payment transaction!")
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            Dim strInsert As String = "Update PaymentTemp Set SubTotal=@SubTotal, Quantity=@Quantity Where ProductName=@ProductName"
            Dim cmdInsert As New SqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@ProductName", DGV.Rows(e.RowIndex).Cells(1).Value)
            cmdInsert.Parameters.AddWithValue("@SubTotal", FormatNumber((Double.Parse(DGV.Rows(e.RowIndex).Cells(2).Value) * DGV.Rows(e.RowIndex).Cells(0).Value), 2))
            cmdInsert.Parameters.AddWithValue("@Quantity", DGV.Rows(e.RowIndex).Cells(0).Value)
            cmdInsert.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Failed Update the Value!")
        End Try
        conn.Close()
        Dim i As Integer
        For i = 0 To 53
            If DGV.Rows(e.RowIndex).Cells(1).Value.Equals(strProductName(intTrack, i)) Then
                intAlterQuantity(intTrack, i) = DGV.Rows(e.RowIndex).Cells(0).Value
            End If
        Next
        If DGV.IsCurrentRowDirty Then
            refreshDGV()
        End If
    End Sub

    Private Sub txtMemberID_TextChanged(sender As Object, e As EventArgs) Handles txtMemberID.Leave
        Dim flag As Boolean = checkMemberID(txtMemberID.Text)
        If flag = False Then
            lblValid.Text = "Invalid Member ID"
        Else
            lblValid.Text = "Valid Member ID"
        End If
    End Sub

    Private Sub DGV_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Dim result = MessageBox.Show("Delete the selected item?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()
            Try
                Dim strSelect As String = "Delete From PaymentTemp Where ProductName=@ProductName"
                Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
                cmdSelect.Parameters.AddWithValue("@ProductName", DGV.Rows(e.RowIndex).Cells(1).Value)
                cmdSelect.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Failed to Delete")
            End Try
            conn.Close()
            Dim i As Integer
            For i = 0 To 53
                If DGV.Rows(e.RowIndex).Cells(1).Value.Equals(strProductName(intTrack, i)) Then
                    intAlterQuantity(intTrack, i) = 0
                End If
            Next
            refreshDGV()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontSubFooter As New Font("Calibri", 12)

        Dim header As String = "Ombak Convenience Store Receipt"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)

        Dim body As New StringBuilder
        body.AppendLine("Product Name                       Quantity     Price(RM)     Sub-Total(RM)")
        body.AppendLine("---------------------------------------------------------------------------")

        Dim i, j As Integer
        For i = 0 To 5
            For j = 0 To 53
                If intAlterQuantity(i, j) <> 0 Then
                    body.AppendFormat("{0,-30}     {1,-8}     {2,9}     {3,13}" & vbNewLine, strProductName(i, j), intAlterQuantity(i, j), strProductPrice(i, j), (strProductPrice(i, j) * intAlterQuantity(i, j)).ToString("0.00"))
                End If
            Next
        Next
        body.AppendLine()
        body.AppendLine("---------------------------------------------------------------------------")
        body.AppendFormat("Total Sales Incl GST 6% : RM {0}" & vbNewLine & "Amount Tendered :         RM {1}" & vbNewLine & "Change :                  RM {2}", lblTotal.Text, txtAmountTendered.Text, lblChangeDue.Text)

        With e.Graphics
            .DrawImage(My.Resources.logo, 320, 0, 180, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 180, 80)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 115)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 135, 180)
        End With

        Dim flag As Boolean = checkMemberID(txtMemberID.Text)
        If flag = True Then
            Dim subFooter As String = String.Format("Member ID : {0}" & vbNewLine & "Points Collected: {1}" & vbNewLine & "Thank You Please Come Again", txtMemberID.Text, Int32.Parse(Math.Floor(Double.Parse(lblTotal.Text))), txtMemberID.Text)
            e.Graphics.DrawString(subFooter, fontSubFooter, Brushes.Black, 135, 1000)
        Else
            Dim subFooter As String = String.Format("Thank You Please Come Again")
            e.Graphics.DrawString(subFooter, fontSubFooter, Brushes.Black, 135, 1000)
        End If
    End Sub






End Class

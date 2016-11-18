Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text

Public Class SupplierControl

    Dim ds As New DataSet()

    Private Sub SupplierControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Full Screen Mode
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        lblStaffID.Text = GlobalUsername.Globalstaffid
        lblStaffName.Text = GlobalUsername.Globalstaffname

        Dim thisDate As Date = Today
        resetAllField()
        txtCreateDate1.Text = Format(thisDate, "MM/dd/yyyy")
    End Sub

    Public Sub SetID()

        txtSupplierID1.Text = ""

        Dim conn As New SqlConnection

        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Supplier"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                Dim supplierID As Integer = dtr("SupplierID").ToString() + 1
                txtSupplierID1.Text = supplierID.ToString()
            End While
        Else
            txtSupplierID1.Text = "1001"
        End If

        dtr.Close()
        conn.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd0_Click(sender As Object, e As EventArgs) Handles btnAdd0.Click
        'Add Product

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierName As String = txtSupplierName1.Text
        Dim contactNumber As String = cboContactNum1_1.SelectedItem + "-" + txtContactNum1_2.Text
        Dim emailAddress As String = txtEmailAddress1_1.Text + "@" + cboEmailAddress1_2.SelectedItem
        Dim createDate As String = txtCreateDate1.Text

        '(3) Validation
        If supplierName = "" Then
            err.AppendLine("- Invalid Supplier Name")
            ctr = If(ctr, txtSupplierID1)
        End If

        If txtContactNum1_2.Text = "" Or Not IsNumeric(txtContactNum1_2.Text) Then
            err.AppendLine("- Invalid Contact Number")
            ctr = If(ctr, txtContactNum1_2)
        End If

        If txtEmailAddress1_1.Text = "" Then
            err.AppendLine("- Invalid Email Address")
            ctr = If(ctr, txtEmailAddress1_1)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        '(5) Create and Open Connection
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strInsert As String = "Insert Into Supplier (SupplierName, SupplierContactNum, SupplierEmailAddress, CreateDate, SupplierStatus ) Values (@SupplierName, @SupplierContactNum, @SupplierEmailAddress, @CreateDate, @SupplierStatus )"
        Dim cmdInsert As New SqlCommand(strInsert, conn)

        Try
            'cmdInsert.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = txtACusID.Text
            cmdInsert.Parameters.AddWithValue("@SupplierName", SqlDbType.VarChar).Value = supplierName
            cmdInsert.Parameters.AddWithValue("@SupplierContactNum", SqlDbType.VarChar).Value = contactNumber
            cmdInsert.Parameters.AddWithValue("@SupplierEmailAddress", SqlDbType.VarChar).Value = emailAddress
            cmdInsert.Parameters.AddWithValue("@CreateDate", SqlDbType.VarChar).Value = createDate
            cmdInsert.Parameters.AddWithValue("@SupplierStatus", SqlDbType.VarChar).Value = "Available"

            Dim success As Integer = cmdInsert.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("New Supplier had been added successfully!")
                resetAllField()
            Else
                MessageBox.Show("Supplier add fail!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the Supplier has not been added!")
        End Try

        conn.Close()
    End Sub

    Public Sub resetAllField()

        'Register Supplier Tab
        SetID()
        txtSupplierName1.Text = ""
        cboContactNum1_1.SelectedIndex = 0
        txtContactNum1_2.Text = ""
        txtEmailAddress1_1.Text = ""
        cboEmailAddress1_2.SelectedIndex = 0

        'Display Supplier By ID 
        txtSupplierID2.Text = ""
        txtSupplierName2.Text = ""
        txtContactNumber2.Text = ""
        txtEmailAddress2.Text = ""
        txtCreateDate2.Text = ""

        'Display Supplier By Name
        txtSupplierName3.Text = ""

        'clear Update Purpose
        txtSupplierID6.Text = ""
        txtSupplierName6.Text = ""
        txtContactNumber6.Text = ""
        txtContactNumber6.Enabled = False
        txtEmailAddress6.Text = ""
        txtEmailAddress6.Enabled = False
        txtCreateDate6.Text = ""
        btnUpdate6.Enabled = False

        'clear delete purpose
        txtSupplierID9.Text = ""
        txtSupplierName9.Text = ""
        txtContactNumber9.Text = ""
        txtEmailAddress9.Text = ""
        txtCreateDate9.Text = ""
        btnDelete9.Enabled = False

        Load_All_Product()

    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click

        'Search Product By ID For Read Only

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierID As String = txtSupplierID2.Text

        '(3) Validation
        If supplierID = "" Then
            err.AppendLine("- Invalid Supplier ID")
            ctr = If(ctr, txtSupplierID2)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Supplier Where SupplierID = @SupplierID AND SupplierStatus = @SupplierStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = supplierID
        cmdSelect.Parameters.AddWithValue("@SupplierStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtSupplierName2.Text = dtr("SupplierName").ToString()
                txtContactNumber2.Text = dtr("SupplierContactNum").ToString()
                txtEmailAddress2.Text = dtr("SupplierEmailAddress").ToString()
                txtCreateDate2.Text = dtr("CreateDate").ToString()
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnSearch6_Click(sender As Object, e As EventArgs) Handles btnSearch6.Click

        'Search Supplier By ID For Update Purpose

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierID As String = txtSupplierID6.Text

        '(3) Validation
        If supplierID = "" Then
            err.AppendLine("- Invalid Supplier ID")
            ctr = If(ctr, txtSupplierID6)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Supplier Where SupplierID = @SupplierID AND SupplierStatus = @SupplierStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = supplierID
        cmdSelect.Parameters.AddWithValue("@SupplierStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtSupplierName6.Text = dtr("SupplierName").ToString()
                txtContactNumber6.Text = dtr("SupplierContactNum").ToString()
                txtEmailAddress6.Text = dtr("SupplierEmailAddress").ToString()
                txtCreateDate6.Text = dtr("CreateDate").ToString()

                txtContactNumber6.Enabled = True
                txtEmailAddress6.Enabled = True
                btnUpdate6.Enabled = True
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierModule.SelectedIndexChanged, TabControl1.SelectedIndexChanged
        resetAllField()

    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs)

        'Update Supplier

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierID As String = txtSupplierID6.Text
        Dim contactNo As String = txtContactNumber6.Text
        Dim email As String = txtEmailAddress6.Text

        '(3) Validation
        If contactNo = "" Then
            err.AppendLine("- Invalid Contact Number")
            ctr = If(ctr, txtContactNumber6)
        End If

        If email = "" Then
            err.AppendLine("- Invalid Email Address")
            ctr = If(ctr, txtEmailAddress6)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        '(5) Create and Open connection
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Try
            Dim strUpdate As String = "Update Supplier Set SupplierContactNum = @SupplierContactNum, SupplierEmailAddress = @SupplierEmailAddress  Where SupplierID = @SupplierID"
            Dim cmdUpdate As New SqlCommand(strUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@SupplierContactNum", SqlDbType.VarChar).Value = contactNo
            cmdUpdate.Parameters.AddWithValue("@SupplierEmailAddress", SqlDbType.VarChar).Value = email
            cmdUpdate.Parameters.AddWithValue("@SupplierID", SqlDbType.VarChar).Value = supplierID

            Dim success As Integer = cmdUpdate.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("Supplier Info has been updated successfully!")
                resetAllField()
            Else
                MessageBox.Show("Supplier Info update failed!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the Supplier detail has not been updated!")
        End Try

        conn.Close()

    End Sub

    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete9.Click

        'Delete Supplier (Update the supplier status to "deleted" because the management still can retrieve the deleted supplier record in future for "unknown" purpose)
        'All the Display or search supplier will not display "deleted" supplier.

        '(1) Read inputs
        Dim supplierID As String = txtSupplierID9.Text

        '(2) Create and Open connection
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
        conn = New SqlConnection(connstr)
        conn.Open()

        Try

            Dim strUpdate As String = "Update Supplier Set SupplierStatus = @SupplierStatus Where SupplierID = @SupplierID"
            Dim cmdUpdate As New SqlCommand(strUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = supplierID
            cmdUpdate.Parameters.AddWithValue("@SupplierStatus", SqlDbType.VarChar).Value = "Deleted"

            Dim success As Integer = cmdUpdate.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("Supplier has been deleted successfully!")
                resetAllField()
            Else
                MessageBox.Show("Supplier's delete failed!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("The Supplier has not Delete!")
        End Try

            conn.Close()


    End Sub

    Private Sub Load_All_Product()

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select SupplierID,SupplierName,SupplierContactNum,SupplierEmailAddress,CreateDate From Supplier Where SupplierStatus = 'Available'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Supplier")
            conn.Close()

            'Set DataGridView3
            Dim row As DataGridViewRow = Me.DataGridView3.RowTemplate
            row.Height = 30
            row.MinimumHeight = 20

            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "Supplier"

            With DataGridView3
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .BackgroundColor = Color.LightGray
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToResizeColumns = False
                .RowsDefaultCellStyle.BackColor = Color.Bisque
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            End With
            'DataGridView1.GridColor = Color.Red
            'DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
            'DataGridView1.BackgroundColor = Color.LightGray

            'DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red
            'DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

            'DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

            'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'DataGridView1.AllowUserToResizeColumns = False

            'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
            'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige


        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub txtProductName3_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierName3.TextChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select SupplierID,SupplierName,SupplierContactNum,SupplierEmailAddress From Supplier Where SupplierStatus = 'Available' AND SupplierName LIKE '%" + txtSupplierName3.Text + "%'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Supplier")
            conn.Close()
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "Supplier"

            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnSearch9_Click(sender As Object, e As EventArgs) Handles btnSearch9.Click
        'Search Product By ID For Delete Purpose 

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierID As String = txtSupplierID9.Text

        '(3) Validation
        If supplierID = "" Then
            err.AppendLine("- Invalid Supplier ID")
            ctr = If(ctr, txtSupplierID9)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Supplier Where SupplierID = @SupplierID AND SupplierStatus = @SupplierStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = supplierID
        cmdSelect.Parameters.AddWithValue("@SupplierStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtSupplierName9.Text = dtr("SupplierName").ToString()
                txtContactNumber9.Text = dtr("SupplierContactNum").ToString()
                txtEmailAddress9.Text = dtr("SupplierEmailAddress").ToString()
                txtCreateDate9.Text = dtr("CreateDate").ToString()

                btnDelete9.Enabled = True
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnReset0_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReset0.MouseClick
        resetAllField()
    End Sub

    Private Sub btnReset6_Click(sender As Object, e As EventArgs)
        resetAllField()
    End Sub

    Private Sub btnReset9_Click(sender As Object, e As EventArgs) Handles btnReset9.Click
        resetAllField()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub btnReset6_Click_1(sender As Object, e As EventArgs) Handles btnReset6.Click
        resetAllField()
    End Sub
End Class
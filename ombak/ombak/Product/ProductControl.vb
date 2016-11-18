Imports System.Text
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ProductControl

    Dim ds As New DataSet()

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmbakDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.OmbakDataSet.Product)
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

        txtProductID1.Text = ""

        Dim conn As New SqlConnection

        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        'Get Product ID
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Product"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                Dim productID As Integer = dtr("ProductID").ToString() + 1
                txtProductID1.Text = productID.ToString()
            End While
        Else
            txtProductID1.Text = "10001"
        End If
        dtr.Close()
        conn.Close()

    End Sub

    Public Sub SetSupplierID()

        cboSupplierID1.Items.Clear()

        Dim conn As New SqlConnection

        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        'Get Product ID
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Supplier"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                cboSupplierID1.Items.Add(dtr("SupplierID").ToString())
            End While
        End If
        dtr.Close()
        conn.Close()

        cboSupplierID1.SelectedIndex = 0
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        resetAllField()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd0.Click

        'Add Product

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim dotLength As Integer = txtUnitPrice1.Text.Length - (txtUnitPrice1.Text.IndexOf(".") + 1)

        '(2) Read inputs
        Dim prodName As String = txtProductName1.Text
        Dim unitPrice As String = txtUnitPrice1.Text
        Dim prodCategory As String = cboCategory1.SelectedItem
        Dim prodBrand As String = txtProductBrand1.Text
        Dim createDate As String = txtCreateDate1.Text
        Dim supplierID As String = cboSupplierID1.SelectedItem

        '(3) Validation
        If prodName = "" Then
            err.AppendLine("- Invalid Product Name")
            ctr = If(ctr, txtProductName1)
        End If

        If prodBrand = "" Then
            err.AppendLine("- Invalid Product Brand")
            ctr = If(ctr, txtProductBrand1)
        End If

        If unitPrice = "" Or Not IsNumeric(unitPrice) Or dotLength <> 2 Then
            err.AppendLine("- Invalid Unit Price, Please Enter 2 decimal places unit price")
            ctr = If(ctr, txtUnitPrice1)
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
        Dim strInsert As String = "Insert Into Product (ProductName, UnitPrice, ProductCategory, ProductBrand, CreateDate, QuantityAvailable, ProductStatus, SupplierID ) Values (@ProductName, @UnitPrice, @ProductCategory, @ProductBrand, @CreateDate, @QuantityAvailable, @ProductStatus, @SupplierID )"
        Dim cmdInsert As New SqlCommand(strInsert, conn)

        Try
            'cmdInsert.Parameters.AddWithValue("@CusID", SqlDbType.Int).Value = txtACusID.Text
            cmdInsert.Parameters.AddWithValue("@ProductName", SqlDbType.VarChar).Value = prodName
            cmdInsert.Parameters.AddWithValue("@UnitPrice", SqlDbType.VarChar).Value = unitPrice
            cmdInsert.Parameters.AddWithValue("@ProductCategory", SqlDbType.VarChar).Value = prodCategory
            cmdInsert.Parameters.AddWithValue("@ProductBrand", SqlDbType.VarChar).Value = prodBrand
            cmdInsert.Parameters.AddWithValue("@CreateDate", SqlDbType.VarChar).Value = createDate
            cmdInsert.Parameters.AddWithValue("@QuantityAvailable", SqlDbType.Int).Value = 0
            cmdInsert.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Available"
            cmdInsert.Parameters.AddWithValue("@SupplierID", SqlDbType.VarChar).Value = supplierID

            Dim success As Integer = cmdInsert.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("New Product had been added successfully!")
                resetAllField()
            Else
                MessageBox.Show("Product add fail!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the Product has not been added!")
        End Try

        conn.Close()

    End Sub

    Public Sub resetAllField()

        'Register Product
        SetID()
        SetSupplierID()
        txtProductName1.Text = ""
        txtUnitPrice1.Text = ""
        cboCategory1.SelectedIndex = 0
        txtProductBrand1.Text = ""

        'Display Product By ID 
        txtProductID2.Text = ""
        txtProductName2.Text = ""
        txtUnitPrice2.Text = ""
        txtCategory2.Text = ""
        txtProductBrand2.Text = ""
        txtCreateDate2.Text = ""
        txtQuantity2.Text = ""
        txtSupplierID2.Text = ""

        'Display Product By Name
        txtProductName3.Text = ""

        'Display Product By Category
        cboProductCategory4.SelectedIndex = -1

        'Display Product By Supplier
        txtSupplierID5.Text = ""

        'Update Purpose -By ID
        txtProductID6.Text = ""
        txtProductName6.Text = ""
        txtUnitPrice6.Text = ""
        txtUnitPrice6.Enabled = False
        txtCategory6.Text = ""
        txtProductBrand6.Text = ""
        txtCreateDate6.Text = ""
        txtQuantity6.Text = ""
        txtSupplierID6.Text = ""
        btnUpdate6.Enabled = False

        'Clear Delete Purpose 
        txtProductID9.Text = ""
        txtProductName9.Text = ""
        txtUnitPrice9.Text = ""
        txtCategory9.Text = ""
        txtProductBrand9.Text = ""
        txtCreateDate9.Text = ""
        txtQuantity9.Text = ""
        txtSupplierID9.Text = ""

        'Clear seach by Supplier ID GridView
        DataGridView5.DataSource = Nothing
        DataGridView5.Rows.Clear()
        DataGridView10.DataSource = Nothing
        DataGridView10.Rows.Clear()

        'Display Product By Supplier
        txtQuantity10.Text = ""

        txtProductID11.Text = ""
        txtAddAmount.Text = ""
        txtAddAmount.Enabled = False

        Load_All_Product()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click

        'Search Product By ID For Read Only

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID2.Text

        '(3) Validation
        If prodID = "" Then
            err.AppendLine("- Invalid Product ID")
            ctr = If(ctr, txtProductID2)
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

        Dim strSelect As String = "Select * From Product Where ProductID = @ProductID AND ProductStatus = @ProductStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
        cmdSelect.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtProductName2.Text = dtr("ProductName").ToString()
                txtUnitPrice2.Text = dtr("UnitPrice").ToString()
                txtCategory2.Text = dtr("ProductCategory").ToString()
                txtProductBrand2.Text = dtr("ProductBrand").ToString()
                txtCreateDate2.Text = dtr("CreateDate").ToString()
                txtQuantity2.Text = dtr("QuantityAvailable").ToString()
                txtSupplierID2.Text = dtr("SupplierID").ToString()
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnSearch3_Click(sender As Object, e As EventArgs) Handles btnSearch6.Click

        'Search Product By ID For Update Purpose

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID6.Text

        '(3) Validation
        If prodID = "" Then
            err.AppendLine("- Invalid Product ID")
            ctr = If(ctr, txtProductID6)
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

        Dim strSelect As String = "Select * From Product Where ProductID = @ProductID AND ProductStatus = @ProductStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
        cmdSelect.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtProductName6.Text = dtr("ProductName").ToString()
                txtUnitPrice6.Text = dtr("UnitPrice").ToString()
                txtCategory6.Text = dtr("ProductCategory").ToString()
                txtProductBrand6.Text = dtr("ProductBrand").ToString()
                txtCreateDate6.Text = dtr("CreateDate").ToString()
                txtQuantity6.Text = dtr("QuantityAvailable").ToString()
                txtSupplierID6.Text = dtr("SupplierID").ToString()

                txtUnitPrice6.Enabled = True
                btnUpdate6.Enabled = True
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductModule.SelectedIndexChanged, TabControl2.SelectedIndexChanged, TabControl1.SelectedIndexChanged, TabControl3.SelectedIndexChanged
        resetAllField()

    End Sub

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate6.Click

        'Update Product

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID6.Text
        Dim unitPrice As String = txtUnitPrice6.Text

        '(3) Validation
        If unitPrice = "" Then
            err.AppendLine("- Invalid Unit Price")
            ctr = If(ctr, txtUnitPrice6)
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
            Dim strUpdate As String = "Update Product Set UnitPrice = @UnitPrice Where ProductID = @ProductID"
            Dim cmdUpdate As New SqlCommand(strUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
            cmdUpdate.Parameters.AddWithValue("@UnitPrice", SqlDbType.VarChar).Value = unitPrice

            Dim success As Integer = cmdUpdate.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("Product Unit Price has been updated successfully!")
                resetAllField()
            Else
                MessageBox.Show("Product Unit Price update failed!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the Product detail has not been updated!")
        End Try

        conn.Close()

    End Sub

    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete9.Click

        'Delete Product (Update the product status to "deleted" because the management still can retrieve the deleted product record in future for "unknown" purpose)
        'All the Display or search product will not display "deleted" product.

        '(1) Read inputs
        Dim prodID As String = txtProductID9.Text
        Dim currentStock As Integer = Integer.Parse(txtQuantity9.Text)

        'Check whether the product quantity still exist or not, if the stock haven clear, the user should not be able to delete.
        If currentStock = 0 Then

            '(2) Create and Open connection
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()

            Try
                Dim strUpdate As String = "Update Product Set ProductStatus = @ProductStatus Where ProductID = @ProductID"
                Dim cmdUpdate As New SqlCommand(strUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
                cmdUpdate.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Deleted"

                Dim success As Integer = cmdUpdate.ExecuteNonQuery()

                If success > 0 Then
                    MessageBox.Show("Product has been deleted successfully!")
                    resetAllField()
                Else
                    MessageBox.Show("Product's delete failed!")
                End If

            Catch ex As System.Data.SqlClient.SqlException
                MessageBox.Show("The Product has not Delete!")
            End Try

            conn.Close()
        Else
            MessageBox.Show("Sorry, The Quantity Available must be 0 to perfom this action")
        End If

    End Sub

    Private Sub btnSearch5_Click(sender As Object, e As EventArgs) Handles btnSearch9.Click

        'Search Product By ID For Delete Purpose

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID9.Text

        '(3) Validation
        If prodID = "" Then
            err.AppendLine("- Invalid Product ID")
            ctr = If(ctr, txtProductID9)
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

        Dim strSelect As String = "Select * From Product Where ProductID = @ProductID AND ProductStatus = @ProductStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
        cmdSelect.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtProductName9.Text = dtr("ProductName").ToString()
                txtUnitPrice9.Text = dtr("UnitPrice").ToString()
                txtCategory9.Text = dtr("ProductCategory").ToString()
                txtProductBrand9.Text = dtr("ProductBrand").ToString()
                txtCreateDate9.Text = dtr("CreateDate").ToString()
                txtQuantity9.Text = dtr("QuantityAvailable").ToString()
                txtSupplierID9.Text = dtr("SupplierID").ToString()

                btnDelete9.Enabled = True
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub Load_All_Product()

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select ProductID,ProductName,UnitPrice,QuantityAvailable,ProductBrand, SupplierID From Product Where ProductStatus = 'Available'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Product")
            conn.Close()

            'Set DataGridView3
            Dim row As DataGridViewRow = Me.DataGridView3.RowTemplate
            row.Height = 30
            row.MinimumHeight = 20

            'Set DataGridView4
            Dim row2 As DataGridViewRow = Me.DataGridView4.RowTemplate
            row2.Height = 30
            row2.MinimumHeight = 20

            'Set DataGridView5
            Dim row3 As DataGridViewRow = Me.DataGridView5.RowTemplate
            row3.Height = 30
            row3.MinimumHeight = 20

            'Set DataGridView10
            Dim row10 As DataGridViewRow = Me.DataGridView10.RowTemplate
            row10.Height = 30
            row10.MinimumHeight = 20

            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "Product"
            DataGridView4.DataSource = ds
            DataGridView4.DataMember = "Product"

            With DataGridView3
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToResizeColumns = False
                .RowsDefaultCellStyle.BackColor = Color.Bisque
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            End With

            With DataGridView4
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToResizeColumns = False
                .RowsDefaultCellStyle.BackColor = Color.Bisque
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            End With

            With DataGridView5
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToResizeColumns = False
                .RowsDefaultCellStyle.BackColor = Color.Bisque
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            End With

            With DataGridView10
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .CellBorderStyle = DataGridViewCellBorderStyle.None
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

    Private Sub txtProductName3_TextChanged(sender As Object, e As EventArgs) Handles txtProductName3.TextChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select ProductID,ProductName,UnitPrice,QuantityAvailable,ProductBrand, SupplierID From Product Where ProductStatus = 'Available' AND ProductName LIKE '%" + txtProductName3.Text + "%'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Product")
            conn.Close()
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "Product"

            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub cboProductCategory4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductCategory4.SelectedIndexChanged
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select ProductID,ProductName,UnitPrice,QuantityAvailable,ProductBrand, SupplierID From Product Where ProductStatus = 'Available' AND ProductCategory LIKE '%" + cboProductCategory4.SelectedItem + "%'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Product")
            conn.Close()
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "Product"

            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnSearch5_Click_1(sender As Object, e As EventArgs) Handles btnSearch5.Click

        'Search Product By supplier ID

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim supplierID As String = txtSupplierID5.Text

        '(3) Validation
        If supplierID = "" Then
            err.AppendLine("- Invalid Supplier ID")
            ctr = If(ctr, txtSupplierID5)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If


        'Start Search
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select ProductID,ProductName,UnitPrice,QuantityAvailable,ProductBrand, SupplierID From Product Where ProductStatus = 'Available' AND SupplierID = '" + supplierID + "'"
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Product")
            conn.Close()
            DataGridView5.DataSource = ds
            DataGridView5.DataMember = "Product"

            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnReset0_Click(sender As Object, e As EventArgs) Handles btnReset0.Click
        resetAllField()
    End Sub

    Private Sub btnReset6_Click(sender As Object, e As EventArgs) Handles btnReset6.Click
        resetAllField()
    End Sub

    Private Sub btnReset9_Click(sender As Object, e As EventArgs) Handles btnReset9.Click
        resetAllField()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSearch10.Click
        'Search Low quantity Product

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim quantityToCheck As String = txtQuantity10.Text

        '(3) Validation
        If quantityToCheck = "" Then
            err.AppendLine("- Invalid Quantity Amount")
            ctr = If(ctr, txtQuantity10)
        End If

        '(4) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        'Start Search
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString

        conn = New SqlConnection(connstr)
        Try

            Dim sql As String = "Select ProductID,ProductName,UnitPrice,QuantityAvailable,ProductBrand, SupplierID From Product Where ProductStatus = 'Available' AND QuantityAvailable <= " + quantityToCheck
            Dim dataadapter As New SqlDataAdapter(sql, conn)
            ds.Clear()
            conn.Open()
            dataadapter.Fill(ds, "Product")
            conn.Close()
            DataGridView10.DataSource = ds
            DataGridView10.DataMember = "Product"

            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnReset10_Click(sender As Object, e As EventArgs) Handles btnReset10.Click
        resetAllField()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnSearch11.Click
        'Search Product By ID For Update Purpose

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID11.Text

        '(3) Validation
        If prodID = "" Then
            err.AppendLine("- Invalid Product ID")
            ctr = If(ctr, txtProductID11)
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

        Dim strSelect As String = "Select * From Product Where ProductID = @ProductID AND ProductStatus = @ProductStatus"
        Dim cmdSelect As New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
        cmdSelect.Parameters.AddWithValue("@ProductStatus", SqlDbType.VarChar).Value = "Available"

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                txtProductName11.Text = dtr("ProductName").ToString()
                txtUnitPrice11.Text = dtr("UnitPrice").ToString()
                txtCategory11.Text = dtr("ProductCategory").ToString()
                txtProductBrand11.Text = dtr("ProductBrand").ToString()
                txtQuantity11.Text = dtr("QuantityAvailable").ToString()
                txtSupplierID11.Text = dtr("SupplierID").ToString()

                btnAdd11.Enabled = True
                txtAddAmount.Enabled = True
            End While
        Else
            MessageBox.Show("There Are no record inside Database!")
        End If

        dtr.Close()
        conn.Close()
    End Sub

    Private Sub btnUpdate11_Click(sender As Object, e As EventArgs) Handles btnAdd11.Click
        'Update Product

        '(1) For validation purpose
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        '(2) Read inputs
        Dim prodID As String = txtProductID11.Text
        Dim addAmount As String = txtAddAmount.Text


        '(3) Validation
        If addAmount = "" Or Not IsNumeric(addAmount) Then
            err.AppendLine("- Invalid Quantity ")
            ctr = If(ctr, txtUnitPrice6)
        End If

        Dim totalQuantity As Integer = Integer.Parse(txtQuantity11.Text) + Integer.Parse(txtAddAmount.Text)

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
            Dim strUpdate As String = "Update Product Set QuantityAvailable = @QuantityAvailable Where ProductID = @ProductID"
            Dim cmdUpdate As New SqlCommand(strUpdate, conn)
            cmdUpdate.Parameters.AddWithValue("@ProductID", SqlDbType.Int).Value = prodID
            cmdUpdate.Parameters.AddWithValue("@QuantityAvailable", SqlDbType.Int).Value = totalQuantity

            Dim success As Integer = cmdUpdate.ExecuteNonQuery()

            If success > 0 Then
                MessageBox.Show("Product Quantity has been Added successfully!")
                resetAllField()
            Else
                MessageBox.Show("Product Quantity update failed!")
            End If

        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Invalid data, the Product Quatity has not been updated!")
        End Try

        conn.Close()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

End Class
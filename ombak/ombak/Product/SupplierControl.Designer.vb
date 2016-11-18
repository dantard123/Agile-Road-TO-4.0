<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierControl))
        Me.editSupplier = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCreateDate6 = New System.Windows.Forms.TextBox()
        Me.txtSupplierName6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmailAddress6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContactNumber6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnReset6 = New System.Windows.Forms.Button()
        Me.btnUpdate6 = New System.Windows.Forms.Button()
        Me.txtSupplierID6 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnSearch6 = New System.Windows.Forms.Button()
        Me.txtEmailAddress1_1 = New System.Windows.Forms.TextBox()
        Me.txtSupplierID1 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnReset0 = New System.Windows.Forms.Button()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboEmailAddress1_2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboContactNum1_1 = New System.Windows.Forms.ComboBox()
        Me.btnAdd0 = New System.Windows.Forms.Button()
        Me.txtCreateDate1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContactNum1_2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSupplierName1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.viewSupplier = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.bySupplierID = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCreateDate2 = New System.Windows.Forms.TextBox()
        Me.txtSupplierName2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmailAddress2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtContactNumber2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSupplierID2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearch2 = New System.Windows.Forms.Button()
        Me.byName = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.txtSupplierName3 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmbakDataSet = New ombak.ombakDataSet()
        Me.addSupplier = New System.Windows.Forms.TabPage()
        Me.ProductTableAdapter = New ombak.ombakDataSetTableAdapters.ProductTableAdapter()
        Me.cmsClear = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupplierModule = New System.Windows.Forms.TabControl()
        Me.deleteSupplier = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCreateDate9 = New System.Windows.Forms.TextBox()
        Me.txtSupplierName9 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmailAddress9 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtContactNumber9 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnReset9 = New System.Windows.Forms.Button()
        Me.btnDelete9 = New System.Windows.Forms.Button()
        Me.txtSupplierID9 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnSearch9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.editSupplier.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.viewSupplier.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.bySupplierID.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.byName.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmbakDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addSupplier.SuspendLayout()
        Me.cmsClear.SuspendLayout()
        Me.SupplierModule.SuspendLayout()
        Me.deleteSupplier.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editSupplier
        '
        Me.editSupplier.Controls.Add(Me.GroupBox2)
        Me.editSupplier.Controls.Add(Me.txtSupplierID6)
        Me.editSupplier.Controls.Add(Me.Label23)
        Me.editSupplier.Controls.Add(Me.btnSearch6)
        Me.editSupplier.Controls.Add(Me.btnReset6)
        Me.editSupplier.Location = New System.Drawing.Point(4, 34)
        Me.editSupplier.Name = "editSupplier"
        Me.editSupplier.Size = New System.Drawing.Size(1346, 502)
        Me.editSupplier.TabIndex = 2
        Me.editSupplier.Text = "Update Supplier Info"
        Me.editSupplier.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCreateDate6)
        Me.GroupBox2.Controls.Add(Me.txtSupplierName6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtEmailAddress6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtContactNumber6)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnUpdate6)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(304, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 339)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier Details"
        '
        'txtCreateDate6
        '
        Me.txtCreateDate6.Enabled = False
        Me.txtCreateDate6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDate6.Location = New System.Drawing.Point(358, 188)
        Me.txtCreateDate6.Name = "txtCreateDate6"
        Me.txtCreateDate6.Size = New System.Drawing.Size(266, 32)
        Me.txtCreateDate6.TabIndex = 31
        '
        'txtSupplierName6
        '
        Me.txtSupplierName6.BackColor = System.Drawing.Color.White
        Me.txtSupplierName6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSupplierName6.Enabled = False
        Me.txtSupplierName6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName6.Location = New System.Drawing.Point(358, 74)
        Me.txtSupplierName6.Name = "txtSupplierName6"
        Me.txtSupplierName6.Size = New System.Drawing.Size(350, 25)
        Me.txtSupplierName6.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 30)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Create &Date : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 30)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Supplier Name : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailAddress6
        '
        Me.txtEmailAddress6.Enabled = False
        Me.txtEmailAddress6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress6.Location = New System.Drawing.Point(358, 150)
        Me.txtEmailAddress6.Name = "txtEmailAddress6"
        Me.txtEmailAddress6.Size = New System.Drawing.Size(266, 32)
        Me.txtEmailAddress6.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(132, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 30)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Contact Number : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNumber6
        '
        Me.txtContactNumber6.Enabled = False
        Me.txtContactNumber6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber6.Location = New System.Drawing.Point(358, 112)
        Me.txtContactNumber6.Name = "txtContactNumber6"
        Me.txtContactNumber6.Size = New System.Drawing.Size(266, 32)
        Me.txtContactNumber6.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(132, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 30)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Email Address : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset6
        '
        Me.btnReset6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset6.Location = New System.Drawing.Point(881, 55)
        Me.btnReset6.Name = "btnReset6"
        Me.btnReset6.Size = New System.Drawing.Size(160, 32)
        Me.btnReset6.TabIndex = 23
        Me.btnReset6.Text = "Reset"
        Me.btnReset6.UseVisualStyleBackColor = True
        '
        'btnUpdate6
        '
        Me.btnUpdate6.Enabled = False
        Me.btnUpdate6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate6.Location = New System.Drawing.Point(286, 256)
        Me.btnUpdate6.Name = "btnUpdate6"
        Me.btnUpdate6.Size = New System.Drawing.Size(160, 32)
        Me.btnUpdate6.TabIndex = 22
        Me.btnUpdate6.Text = "Update"
        Me.btnUpdate6.UseVisualStyleBackColor = True
        '
        'txtSupplierID6
        '
        Me.txtSupplierID6.Location = New System.Drawing.Point(499, 57)
        Me.txtSupplierID6.Name = "txtSupplierID6"
        Me.txtSupplierID6.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierID6.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(273, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(220, 30)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Supplier &ID : "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch6
        '
        Me.btnSearch6.Location = New System.Drawing.Point(715, 55)
        Me.btnSearch6.Name = "btnSearch6"
        Me.btnSearch6.Size = New System.Drawing.Size(160, 32)
        Me.btnSearch6.TabIndex = 6
        Me.btnSearch6.Text = "Search"
        Me.btnSearch6.UseVisualStyleBackColor = True
        '
        'txtEmailAddress1_1
        '
        Me.txtEmailAddress1_1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress1_1.Location = New System.Drawing.Point(431, 191)
        Me.txtEmailAddress1_1.Name = "txtEmailAddress1_1"
        Me.txtEmailAddress1_1.Size = New System.Drawing.Size(123, 32)
        Me.txtEmailAddress1_1.TabIndex = 8
        '
        'txtSupplierID1
        '
        Me.txtSupplierID1.Enabled = False
        Me.txtSupplierID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierID1.Location = New System.Drawing.Point(431, 71)
        Me.txtSupplierID1.Name = "txtSupplierID1"
        Me.txtSupplierID1.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierID1.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(205, 71)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(220, 30)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Supplier &ID : "
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset0
        '
        Me.btnReset0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset0.Location = New System.Drawing.Point(431, 287)
        Me.btnReset0.Name = "btnReset0"
        Me.btnReset0.Size = New System.Drawing.Size(90, 30)
        Me.btnReset0.TabIndex = 13
        Me.btnReset0.Text = "Reset"
        Me.btnReset0.UseVisualStyleBackColor = True
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboEmailAddress1_2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboContactNum1_1)
        Me.GroupBox3.Controls.Add(Me.txtEmailAddress1_1)
        Me.GroupBox3.Controls.Add(Me.txtSupplierID1)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.btnReset0)
        Me.GroupBox3.Controls.Add(Me.btnAdd0)
        Me.GroupBox3.Controls.Add(Me.txtCreateDate1)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtContactNum1_2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtSupplierName1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(288, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(850, 420)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Register Supplier"
        '
        'cboEmailAddress1_2
        '
        Me.cboEmailAddress1_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmailAddress1_2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmailAddress1_2.FormattingEnabled = True
        Me.cboEmailAddress1_2.Items.AddRange(New Object() {"hotmail.com", "yahoo.com", "live.com", "gmail.com"})
        Me.cboEmailAddress1_2.Location = New System.Drawing.Point(595, 192)
        Me.cboEmailAddress1_2.Name = "cboEmailAddress1_2"
        Me.cboEmailAddress1_2.Size = New System.Drawing.Size(154, 31)
        Me.cboEmailAddress1_2.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(559, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 31)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "@"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(507, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 31)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "-"
        '
        'cboContactNum1_1
        '
        Me.cboContactNum1_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContactNum1_1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContactNum1_1.FormattingEnabled = True
        Me.cboContactNum1_1.Items.AddRange(New Object() {"010", "011", "012", "013", "014", "015", "016", "017", "018", "019"})
        Me.cboContactNum1_1.Location = New System.Drawing.Point(431, 147)
        Me.cboContactNum1_1.Name = "cboContactNum1_1"
        Me.cboContactNum1_1.Size = New System.Drawing.Size(70, 31)
        Me.cboContactNum1_1.TabIndex = 4
        '
        'btnAdd0
        '
        Me.btnAdd0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd0.Location = New System.Drawing.Point(335, 287)
        Me.btnAdd0.Name = "btnAdd0"
        Me.btnAdd0.Size = New System.Drawing.Size(90, 30)
        Me.btnAdd0.TabIndex = 12
        Me.btnAdd0.Text = "Add"
        Me.btnAdd0.UseVisualStyleBackColor = True
        '
        'txtCreateDate1
        '
        Me.txtCreateDate1.Enabled = False
        Me.txtCreateDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDate1.Location = New System.Drawing.Point(431, 229)
        Me.txtCreateDate1.Name = "txtCreateDate1"
        Me.txtCreateDate1.Size = New System.Drawing.Size(210, 31)
        Me.txtCreateDate1.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(205, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(220, 30)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Create &Date : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(205, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(220, 30)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Email Address : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNum1_2
        '
        Me.txtContactNum1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum1_2.Location = New System.Drawing.Point(530, 147)
        Me.txtContactNum1_2.Name = "txtContactNum1_2"
        Me.txtContactNum1_2.Size = New System.Drawing.Size(111, 31)
        Me.txtContactNum1_2.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(205, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 30)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Contact Number :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSupplierName1
        '
        Me.txtSupplierName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName1.Location = New System.Drawing.Point(431, 108)
        Me.txtSupplierName1.Name = "txtSupplierName1"
        Me.txtSupplierName1.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierName1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier Name : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'viewSupplier
        '
        Me.viewSupplier.Controls.Add(Me.TabControl1)
        Me.viewSupplier.Location = New System.Drawing.Point(4, 34)
        Me.viewSupplier.Name = "viewSupplier"
        Me.viewSupplier.Padding = New System.Windows.Forms.Padding(3)
        Me.viewSupplier.Size = New System.Drawing.Size(1346, 502)
        Me.viewSupplier.TabIndex = 1
        Me.viewSupplier.Text = "Display Supplier"
        Me.viewSupplier.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.bySupplierID)
        Me.TabControl1.Controls.Add(Me.byName)
        Me.TabControl1.Location = New System.Drawing.Point(71, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(18, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1200, 475)
        Me.TabControl1.TabIndex = 0
        '
        'bySupplierID
        '
        Me.bySupplierID.Controls.Add(Me.GroupBox1)
        Me.bySupplierID.Controls.Add(Me.txtSupplierID2)
        Me.bySupplierID.Controls.Add(Me.Label9)
        Me.bySupplierID.Controls.Add(Me.btnSearch2)
        Me.bySupplierID.Location = New System.Drawing.Point(4, 34)
        Me.bySupplierID.Name = "bySupplierID"
        Me.bySupplierID.Padding = New System.Windows.Forms.Padding(3)
        Me.bySupplierID.Size = New System.Drawing.Size(1192, 437)
        Me.bySupplierID.TabIndex = 0
        Me.bySupplierID.Text = "By Supplier ID"
        Me.bySupplierID.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCreateDate2)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddress2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtContactNumber2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(251, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 318)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Details"
        '
        'txtCreateDate2
        '
        Me.txtCreateDate2.Enabled = False
        Me.txtCreateDate2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDate2.Location = New System.Drawing.Point(358, 188)
        Me.txtCreateDate2.Name = "txtCreateDate2"
        Me.txtCreateDate2.Size = New System.Drawing.Size(210, 32)
        Me.txtCreateDate2.TabIndex = 9
        '
        'txtSupplierName2
        '
        Me.txtSupplierName2.BackColor = System.Drawing.Color.White
        Me.txtSupplierName2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSupplierName2.Enabled = False
        Me.txtSupplierName2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName2.Location = New System.Drawing.Point(358, 74)
        Me.txtSupplierName2.Name = "txtSupplierName2"
        Me.txtSupplierName2.Size = New System.Drawing.Size(350, 25)
        Me.txtSupplierName2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Create &Date : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(132, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(220, 30)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Supplier Name : "
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailAddress2
        '
        Me.txtEmailAddress2.Enabled = False
        Me.txtEmailAddress2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress2.Location = New System.Drawing.Point(358, 150)
        Me.txtEmailAddress2.Name = "txtEmailAddress2"
        Me.txtEmailAddress2.Size = New System.Drawing.Size(210, 32)
        Me.txtEmailAddress2.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(132, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(220, 30)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Contact Number : "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNumber2
        '
        Me.txtContactNumber2.Enabled = False
        Me.txtContactNumber2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber2.Location = New System.Drawing.Point(358, 112)
        Me.txtContactNumber2.Name = "txtContactNumber2"
        Me.txtContactNumber2.Size = New System.Drawing.Size(210, 32)
        Me.txtContactNumber2.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(132, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(220, 30)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Email Address : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSupplierID2
        '
        Me.txtSupplierID2.Location = New System.Drawing.Point(487, 28)
        Me.txtSupplierID2.Name = "txtSupplierID2"
        Me.txtSupplierID2.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierID2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(261, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 30)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Supplier &ID : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch2
        '
        Me.btnSearch2.Location = New System.Drawing.Point(703, 28)
        Me.btnSearch2.Name = "btnSearch2"
        Me.btnSearch2.Size = New System.Drawing.Size(160, 32)
        Me.btnSearch2.TabIndex = 2
        Me.btnSearch2.Text = "Search"
        Me.btnSearch2.UseVisualStyleBackColor = True
        '
        'byName
        '
        Me.byName.Controls.Add(Me.DataGridView3)
        Me.byName.Controls.Add(Me.txtSupplierName3)
        Me.byName.Controls.Add(Me.Label33)
        Me.byName.Location = New System.Drawing.Point(4, 34)
        Me.byName.Name = "byName"
        Me.byName.Size = New System.Drawing.Size(1192, 437)
        Me.byName.TabIndex = 3
        Me.byName.Text = "By Supplier Name"
        Me.byName.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 87)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(1192, 350)
        Me.DataGridView3.TabIndex = 6
        '
        'txtSupplierName3
        '
        Me.txtSupplierName3.Location = New System.Drawing.Point(522, 28)
        Me.txtSupplierName3.Name = "txtSupplierName3"
        Me.txtSupplierName3.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierName3.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(296, 28)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(220, 30)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Supplier Name : "
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.OmbakDataSet
        '
        'OmbakDataSet
        '
        Me.OmbakDataSet.DataSetName = "ombakDataSet"
        Me.OmbakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addSupplier
        '
        Me.addSupplier.Controls.Add(Me.GroupBox3)
        Me.addSupplier.Location = New System.Drawing.Point(4, 34)
        Me.addSupplier.Name = "addSupplier"
        Me.addSupplier.Padding = New System.Windows.Forms.Padding(3)
        Me.addSupplier.Size = New System.Drawing.Size(1346, 502)
        Me.addSupplier.TabIndex = 0
        Me.addSupplier.Text = "Register Supplier"
        Me.addSupplier.UseVisualStyleBackColor = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'cmsClear
        '
        Me.cmsClear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.cmsClear.Name = "cmsClear"
        Me.cmsClear.Size = New System.Drawing.Size(102, 26)
        '
        'SupplierModule
        '
        Me.SupplierModule.Controls.Add(Me.addSupplier)
        Me.SupplierModule.Controls.Add(Me.viewSupplier)
        Me.SupplierModule.Controls.Add(Me.editSupplier)
        Me.SupplierModule.Controls.Add(Me.deleteSupplier)
        Me.SupplierModule.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SupplierModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierModule.Location = New System.Drawing.Point(0, 193)
        Me.SupplierModule.Name = "SupplierModule"
        Me.SupplierModule.Padding = New System.Drawing.Point(18, 3)
        Me.SupplierModule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SupplierModule.SelectedIndex = 0
        Me.SupplierModule.Size = New System.Drawing.Size(1354, 540)
        Me.SupplierModule.TabIndex = 7
        '
        'deleteSupplier
        '
        Me.deleteSupplier.Controls.Add(Me.GroupBox4)
        Me.deleteSupplier.Controls.Add(Me.txtSupplierID9)
        Me.deleteSupplier.Controls.Add(Me.Label31)
        Me.deleteSupplier.Controls.Add(Me.btnSearch9)
        Me.deleteSupplier.Controls.Add(Me.btnReset9)
        Me.deleteSupplier.Location = New System.Drawing.Point(4, 34)
        Me.deleteSupplier.Name = "deleteSupplier"
        Me.deleteSupplier.Size = New System.Drawing.Size(1346, 502)
        Me.deleteSupplier.TabIndex = 3
        Me.deleteSupplier.Text = "Delete Supplier"
        Me.deleteSupplier.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCreateDate9)
        Me.GroupBox4.Controls.Add(Me.txtSupplierName9)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtEmailAddress9)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtContactNumber9)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.btnDelete9)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(304, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(746, 339)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Supplier Details"
        '
        'txtCreateDate9
        '
        Me.txtCreateDate9.Enabled = False
        Me.txtCreateDate9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDate9.Location = New System.Drawing.Point(358, 188)
        Me.txtCreateDate9.Name = "txtCreateDate9"
        Me.txtCreateDate9.Size = New System.Drawing.Size(210, 32)
        Me.txtCreateDate9.TabIndex = 31
        '
        'txtSupplierName9
        '
        Me.txtSupplierName9.BackColor = System.Drawing.Color.White
        Me.txtSupplierName9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSupplierName9.Enabled = False
        Me.txtSupplierName9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName9.Location = New System.Drawing.Point(358, 74)
        Me.txtSupplierName9.Name = "txtSupplierName9"
        Me.txtSupplierName9.Size = New System.Drawing.Size(350, 25)
        Me.txtSupplierName9.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 30)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Create &Date : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(132, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 30)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Supplier Name : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailAddress9
        '
        Me.txtEmailAddress9.Enabled = False
        Me.txtEmailAddress9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress9.Location = New System.Drawing.Point(358, 150)
        Me.txtEmailAddress9.Name = "txtEmailAddress9"
        Me.txtEmailAddress9.Size = New System.Drawing.Size(210, 32)
        Me.txtEmailAddress9.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(132, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(220, 30)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Contact Number : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNumber9
        '
        Me.txtContactNumber9.Enabled = False
        Me.txtContactNumber9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber9.Location = New System.Drawing.Point(358, 112)
        Me.txtContactNumber9.Name = "txtContactNumber9"
        Me.txtContactNumber9.Size = New System.Drawing.Size(210, 32)
        Me.txtContactNumber9.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(132, 149)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(220, 30)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Email Address : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset9
        '
        Me.btnReset9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset9.Location = New System.Drawing.Point(881, 55)
        Me.btnReset9.Name = "btnReset9"
        Me.btnReset9.Size = New System.Drawing.Size(160, 32)
        Me.btnReset9.TabIndex = 23
        Me.btnReset9.Text = "Reset"
        Me.btnReset9.UseVisualStyleBackColor = True
        '
        'btnDelete9
        '
        Me.btnDelete9.Enabled = False
        Me.btnDelete9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete9.Location = New System.Drawing.Point(286, 256)
        Me.btnDelete9.Name = "btnDelete9"
        Me.btnDelete9.Size = New System.Drawing.Size(160, 32)
        Me.btnDelete9.TabIndex = 22
        Me.btnDelete9.Text = "Delete"
        Me.btnDelete9.UseVisualStyleBackColor = True
        '
        'txtSupplierID9
        '
        Me.txtSupplierID9.Location = New System.Drawing.Point(499, 57)
        Me.txtSupplierID9.Name = "txtSupplierID9"
        Me.txtSupplierID9.Size = New System.Drawing.Size(210, 31)
        Me.txtSupplierID9.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(273, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(220, 30)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Supplier ID : "
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch9
        '
        Me.btnSearch9.Location = New System.Drawing.Point(715, 55)
        Me.btnSearch9.Name = "btnSearch9"
        Me.btnSearch9.Size = New System.Drawing.Size(160, 32)
        Me.btnSearch9.TabIndex = 6
        Me.btnSearch9.Text = "Search"
        Me.btnSearch9.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(425, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'backButton
        '
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.Location = New System.Drawing.Point(12, 10)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(110, 65)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backButton.TabIndex = 73
        Me.backButton.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(953, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 29)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Staff Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(995, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Staff ID : "
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(1120, 112)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffName.TabIndex = 96
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(1120, 64)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffID.TabIndex = 95
        '
        'SupplierControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SupplierModule)
        Me.Name = "SupplierControl"
        Me.Text = "SupplierControl"
        Me.editSupplier.ResumeLayout(False)
        Me.editSupplier.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.viewSupplier.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.bySupplierID.ResumeLayout(False)
        Me.bySupplierID.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.byName.ResumeLayout(False)
        Me.byName.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmbakDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addSupplier.ResumeLayout(False)
        Me.cmsClear.ResumeLayout(False)
        Me.SupplierModule.ResumeLayout(False)
        Me.deleteSupplier.ResumeLayout(False)
        Me.deleteSupplier.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents editSupplier As System.Windows.Forms.TabPage
    Friend WithEvents txtEmailAddress1_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnReset0 As System.Windows.Forms.Button
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd0 As System.Windows.Forms.Button
    Friend WithEvents txtCreateDate1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected Friend WithEvents viewSupplier As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents bySupplierID As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCreateDate2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierID2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearch2 As System.Windows.Forms.Button
    Friend WithEvents byName As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSupplierName3 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OmbakDataSet As ombak.ombakDataSet
    Friend WithEvents addSupplier As System.Windows.Forms.TabPage
    Friend WithEvents ProductTableAdapter As ombak.ombakDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents cmsClear As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SupplierModule As System.Windows.Forms.TabControl
    Friend WithEvents deleteSupplier As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset9 As System.Windows.Forms.Button
    Friend WithEvents btnDelete9 As System.Windows.Forms.Button
    Friend WithEvents txtSupplierID9 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnSearch9 As System.Windows.Forms.Button
    Friend WithEvents txtContactNum1_2 As System.Windows.Forms.TextBox
    Friend WithEvents cboContactNum1_1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmailAddress1_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCreateDate9 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName9 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress9 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber9 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCreateDate6 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierName6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress6 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber6 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnReset6 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate6 As System.Windows.Forms.Button
    Friend WithEvents txtSupplierID6 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSearch6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents backButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
End Class

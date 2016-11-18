<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnStaffCancel = New System.Windows.Forms.PictureBox()
        Me.btnStaffAdd = New System.Windows.Forms.PictureBox()
        Me.gbAddPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.btnAddBrowse = New System.Windows.Forms.PictureBox()
        Me.txtAddStaffICs = New System.Windows.Forms.TextBox()
        Me.lblAddStaffIC = New System.Windows.Forms.Label()
        Me.pbAddProfilePicture = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblAddStaffIDs = New System.Windows.Forms.Label()
        Me.cbAddEmailType = New System.Windows.Forms.ComboBox()
        Me.cbAddAreaCode = New System.Windows.Forms.ComboBox()
        Me.lblAddStaffName = New System.Windows.Forms.Label()
        Me.cbAddStaffPosition = New System.Windows.Forms.ComboBox()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.txtAddStaffContactNumber = New System.Windows.Forms.TextBox()
        Me.lblAddStaffContact = New System.Windows.Forms.Label()
        Me.lblAddStaffPosition = New System.Windows.Forms.Label()
        Me.lblAddStaffGender = New System.Windows.Forms.Label()
        Me.lblAddAddress = New System.Windows.Forms.Label()
        Me.lblAddEmailAddress = New System.Windows.Forms.Label()
        Me.txtAddStaffAddress = New System.Windows.Forms.TextBox()
        Me.txtAddStaffEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtAddStaffName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnReadStaff = New System.Windows.Forms.PictureBox()
        Me.btnCancelStaff = New System.Windows.Forms.PictureBox()
        Me.gbReadPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.lblReadStaffICs = New System.Windows.Forms.Label()
        Me.lblReadStaffIC = New System.Windows.Forms.Label()
        Me.pbReadProfilePicture = New System.Windows.Forms.PictureBox()
        Me.cbReadStaffID = New System.Windows.Forms.ComboBox()
        Me.lblReadStaffAddresses = New System.Windows.Forms.Label()
        Me.lblReadStaffEmails = New System.Windows.Forms.Label()
        Me.lblReadStaffContacts = New System.Windows.Forms.Label()
        Me.lblReadStaffPositions = New System.Windows.Forms.Label()
        Me.lblReadStaffGenders = New System.Windows.Forms.Label()
        Me.lblReadStaffNames = New System.Windows.Forms.Label()
        Me.lblReadStaffContact = New System.Windows.Forms.Label()
        Me.lblReadStaffAddress = New System.Windows.Forms.Label()
        Me.lblReadStaffEmail = New System.Windows.Forms.Label()
        Me.lblReadStaffPosition = New System.Windows.Forms.Label()
        Me.lblReadStaffGender = New System.Windows.Forms.Label()
        Me.lblReadStaffId = New System.Windows.Forms.Label()
        Me.lblReadStaffName = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnStaffUpdate = New System.Windows.Forms.PictureBox()
        Me.btnCancelUpdateStaff = New System.Windows.Forms.PictureBox()
        Me.gbUpdatePersonalDetails = New System.Windows.Forms.GroupBox()
        Me.btnUpdateBrowse = New System.Windows.Forms.PictureBox()
        Me.lblUpdateStaffICs = New System.Windows.Forms.Label()
        Me.lblUpdateStaffIC = New System.Windows.Forms.Label()
        Me.pbUpdateProfilePicture = New System.Windows.Forms.PictureBox()
        Me.cbUpdateStaffPositions = New System.Windows.Forms.ComboBox()
        Me.lblUpdateStaffGenders = New System.Windows.Forms.Label()
        Me.lblUpdateStaffNames = New System.Windows.Forms.Label()
        Me.cbUpdateStaffID = New System.Windows.Forms.ComboBox()
        Me.txtUpdateStaffContacts = New System.Windows.Forms.TextBox()
        Me.txtUpdateStaffAddresses = New System.Windows.Forms.TextBox()
        Me.lblUpdateStaffName = New System.Windows.Forms.Label()
        Me.lblUpdateStaffID = New System.Windows.Forms.Label()
        Me.txtUpdateStaffEmails = New System.Windows.Forms.TextBox()
        Me.lblUpdateStaffGender = New System.Windows.Forms.Label()
        Me.lblUpdateStaffAddress = New System.Windows.Forms.Label()
        Me.lblUpdateStaffPosition = New System.Windows.Forms.Label()
        Me.lblUpdateStaffEmail = New System.Windows.Forms.Label()
        Me.lblUpdateStaffContact = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnStaffDelete = New System.Windows.Forms.PictureBox()
        Me.gbDeletePersonalDetails = New System.Windows.Forms.GroupBox()
        Me.lblDeleteStaffICs = New System.Windows.Forms.Label()
        Me.lblDeleteStaffIC = New System.Windows.Forms.Label()
        Me.pbDeleteProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblDeleteStaffAddresses = New System.Windows.Forms.Label()
        Me.lblDeleteStaffEmails = New System.Windows.Forms.Label()
        Me.lblDeleteStaffcontact = New System.Windows.Forms.Label()
        Me.lblDeleteStaffPositions = New System.Windows.Forms.Label()
        Me.lblDeleteStaffGenders = New System.Windows.Forms.Label()
        Me.lblDeleteStaffNames = New System.Windows.Forms.Label()
        Me.cbDeleteStaffId = New System.Windows.Forms.ComboBox()
        Me.lblDeleteStaffPosition = New System.Windows.Forms.Label()
        Me.lblDeleteStaffAddress = New System.Windows.Forms.Label()
        Me.lblDeleteStaffID = New System.Windows.Forms.Label()
        Me.lblDeleteStaffEmail = New System.Windows.Forms.Label()
        Me.lblDeleteStaffName = New System.Windows.Forms.Label()
        Me.lblDeleteStaffGender = New System.Windows.Forms.Label()
        Me.lblDeleteStaffContacts = New System.Windows.Forms.Label()
        Me.btnCancelDeleteStaff = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffID2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStaffid = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btnStaffCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStaffAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAddPersonalDetails.SuspendLayout()
        CType(Me.btnAddBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.btnReadStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReadPersonalDetails.SuspendLayout()
        CType(Me.pbReadProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.btnStaffUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelUpdateStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUpdatePersonalDetails.SuspendLayout()
        CType(Me.btnUpdateBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUpdateProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.btnStaffDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDeletePersonalDetails.SuspendLayout()
        CType(Me.pbDeleteProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelDeleteStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 230)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1350, 500)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnStaffCancel)
        Me.TabPage1.Controls.Add(Me.btnStaffAdd)
        Me.TabPage1.Controls.Add(Me.gbAddPersonalDetails)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1342, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Add Staff"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnStaffCancel
        '
        Me.btnStaffCancel.Image = Global.ombak.My.Resources.Resources.cancelbutton
        Me.btnStaffCancel.Location = New System.Drawing.Point(698, 397)
        Me.btnStaffCancel.Name = "btnStaffCancel"
        Me.btnStaffCancel.Size = New System.Drawing.Size(100, 50)
        Me.btnStaffCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnStaffCancel.TabIndex = 188
        Me.btnStaffCancel.TabStop = False
        '
        'btnStaffAdd
        '
        Me.btnStaffAdd.Image = Global.ombak.My.Resources.Resources.insertbutton
        Me.btnStaffAdd.Location = New System.Drawing.Point(592, 397)
        Me.btnStaffAdd.Name = "btnStaffAdd"
        Me.btnStaffAdd.Size = New System.Drawing.Size(100, 50)
        Me.btnStaffAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnStaffAdd.TabIndex = 187
        Me.btnStaffAdd.TabStop = False
        '
        'gbAddPersonalDetails
        '
        Me.gbAddPersonalDetails.Controls.Add(Me.lblStaffid)
        Me.gbAddPersonalDetails.Controls.Add(Me.btnAddBrowse)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtAddStaffICs)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffIC)
        Me.gbAddPersonalDetails.Controls.Add(Me.pbAddProfilePicture)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtPassword)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtUserName)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblPassword)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblUserName)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffIDs)
        Me.gbAddPersonalDetails.Controls.Add(Me.cbAddEmailType)
        Me.gbAddPersonalDetails.Controls.Add(Me.cbAddAreaCode)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffName)
        Me.gbAddPersonalDetails.Controls.Add(Me.cbAddStaffPosition)
        Me.gbAddPersonalDetails.Controls.Add(Me.rdFemale)
        Me.gbAddPersonalDetails.Controls.Add(Me.rdMale)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtAddStaffContactNumber)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffContact)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffPosition)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddStaffGender)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddAddress)
        Me.gbAddPersonalDetails.Controls.Add(Me.lblAddEmailAddress)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtAddStaffAddress)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtAddStaffEmailAddress)
        Me.gbAddPersonalDetails.Controls.Add(Me.txtAddStaffName)
        Me.gbAddPersonalDetails.Location = New System.Drawing.Point(340, 6)
        Me.gbAddPersonalDetails.Name = "gbAddPersonalDetails"
        Me.gbAddPersonalDetails.Size = New System.Drawing.Size(752, 385)
        Me.gbAddPersonalDetails.TabIndex = 161
        Me.gbAddPersonalDetails.TabStop = False
        Me.gbAddPersonalDetails.Text = "Personal Details"
        '
        'btnAddBrowse
        '
        Me.btnAddBrowse.Image = Global.ombak.My.Resources.Resources.browsebutton
        Me.btnAddBrowse.Location = New System.Drawing.Point(553, 291)
        Me.btnAddBrowse.Name = "btnAddBrowse"
        Me.btnAddBrowse.Size = New System.Drawing.Size(100, 50)
        Me.btnAddBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddBrowse.TabIndex = 189
        Me.btnAddBrowse.TabStop = False
        '
        'txtAddStaffICs
        '
        Me.txtAddStaffICs.Location = New System.Drawing.Point(201, 87)
        Me.txtAddStaffICs.Name = "txtAddStaffICs"
        Me.txtAddStaffICs.Size = New System.Drawing.Size(248, 26)
        Me.txtAddStaffICs.TabIndex = 186
        '
        'lblAddStaffIC
        '
        Me.lblAddStaffIC.AutoSize = True
        Me.lblAddStaffIC.Location = New System.Drawing.Point(66, 91)
        Me.lblAddStaffIC.Name = "lblAddStaffIC"
        Me.lblAddStaffIC.Size = New System.Drawing.Size(72, 20)
        Me.lblAddStaffIC.TabIndex = 185
        Me.lblAddStaffIC.Text = "Staff IC :"
        '
        'pbAddProfilePicture
        '
        Me.pbAddProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAddProfilePicture.Location = New System.Drawing.Point(477, 25)
        Me.pbAddProfilePicture.Name = "pbAddProfilePicture"
        Me.pbAddProfilePicture.Size = New System.Drawing.Size(250, 260)
        Me.pbAddProfilePicture.TabIndex = 183
        Me.pbAddProfilePicture.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(201, 353)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(254, 26)
        Me.txtPassword.TabIndex = 182
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(201, 324)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(253, 26)
        Me.txtUserName.TabIndex = 181
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(52, 359)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 20)
        Me.lblPassword.TabIndex = 180
        Me.lblPassword.Text = "Password :"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(41, 330)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(97, 20)
        Me.lblUserName.TabIndex = 179
        Me.lblUserName.Text = "User Name :"
        '
        'lblAddStaffIDs
        '
        Me.lblAddStaffIDs.AutoSize = True
        Me.lblAddStaffIDs.Location = New System.Drawing.Point(68, 20)
        Me.lblAddStaffIDs.Name = "lblAddStaffIDs"
        Me.lblAddStaffIDs.Size = New System.Drawing.Size(70, 20)
        Me.lblAddStaffIDs.TabIndex = 176
        Me.lblAddStaffIDs.Text = "Staff Id :"
        '
        'cbAddEmailType
        '
        Me.cbAddEmailType.FormattingEnabled = True
        Me.cbAddEmailType.Items.AddRange(New Object() {"@gmail.com", "@hotmail.com", "@outlook.com", "@yahoo.com", "@live.com"})
        Me.cbAddEmailType.Location = New System.Drawing.Point(324, 226)
        Me.cbAddEmailType.Name = "cbAddEmailType"
        Me.cbAddEmailType.Size = New System.Drawing.Size(131, 28)
        Me.cbAddEmailType.TabIndex = 7
        '
        'cbAddAreaCode
        '
        Me.cbAddAreaCode.FormattingEnabled = True
        Me.cbAddAreaCode.Items.AddRange(New Object() {"011", "012", "014", "016", "017", "018", "019"})
        Me.cbAddAreaCode.Location = New System.Drawing.Point(202, 190)
        Me.cbAddAreaCode.Name = "cbAddAreaCode"
        Me.cbAddAreaCode.Size = New System.Drawing.Size(72, 28)
        Me.cbAddAreaCode.TabIndex = 4
        '
        'lblAddStaffName
        '
        Me.lblAddStaffName.AutoSize = True
        Me.lblAddStaffName.Location = New System.Drawing.Point(41, 46)
        Me.lblAddStaffName.Name = "lblAddStaffName"
        Me.lblAddStaffName.Size = New System.Drawing.Size(102, 20)
        Me.lblAddStaffName.TabIndex = 144
        Me.lblAddStaffName.Text = "Staff Name : "
        '
        'cbAddStaffPosition
        '
        Me.cbAddStaffPosition.FormattingEnabled = True
        Me.cbAddStaffPosition.Items.AddRange(New Object() {"Manager", "Clerk", "Cashier"})
        Me.cbAddStaffPosition.Location = New System.Drawing.Point(201, 149)
        Me.cbAddStaffPosition.Name = "cbAddStaffPosition"
        Me.cbAddStaffPosition.Size = New System.Drawing.Size(254, 28)
        Me.cbAddStaffPosition.TabIndex = 3
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Location = New System.Drawing.Point(303, 119)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(80, 24)
        Me.rdFemale.TabIndex = 169
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Checked = True
        Me.rdMale.Location = New System.Drawing.Point(202, 119)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(61, 24)
        Me.rdMale.TabIndex = 2
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'txtAddStaffContactNumber
        '
        Me.txtAddStaffContactNumber.Location = New System.Drawing.Point(278, 190)
        Me.txtAddStaffContactNumber.Name = "txtAddStaffContactNumber"
        Me.txtAddStaffContactNumber.Size = New System.Drawing.Size(176, 26)
        Me.txtAddStaffContactNumber.TabIndex = 5
        '
        'lblAddStaffContact
        '
        Me.lblAddStaffContact.AutoSize = True
        Me.lblAddStaffContact.Location = New System.Drawing.Point(65, 192)
        Me.lblAddStaffContact.Name = "lblAddStaffContact"
        Me.lblAddStaffContact.Size = New System.Drawing.Size(73, 20)
        Me.lblAddStaffContact.TabIndex = 156
        Me.lblAddStaffContact.Text = "Contact :"
        '
        'lblAddStaffPosition
        '
        Me.lblAddStaffPosition.AutoSize = True
        Me.lblAddStaffPosition.Location = New System.Drawing.Point(65, 157)
        Me.lblAddStaffPosition.Name = "lblAddStaffPosition"
        Me.lblAddStaffPosition.Size = New System.Drawing.Size(73, 20)
        Me.lblAddStaffPosition.TabIndex = 154
        Me.lblAddStaffPosition.Text = "Position :"
        '
        'lblAddStaffGender
        '
        Me.lblAddStaffGender.AutoSize = True
        Me.lblAddStaffGender.Location = New System.Drawing.Point(68, 123)
        Me.lblAddStaffGender.Name = "lblAddStaffGender"
        Me.lblAddStaffGender.Size = New System.Drawing.Size(75, 20)
        Me.lblAddStaffGender.TabIndex = 149
        Me.lblAddStaffGender.Text = "Gender : "
        '
        'lblAddAddress
        '
        Me.lblAddAddress.AutoSize = True
        Me.lblAddAddress.Location = New System.Drawing.Point(15, 263)
        Me.lblAddAddress.Name = "lblAddAddress"
        Me.lblAddAddress.Size = New System.Drawing.Size(127, 20)
        Me.lblAddAddress.TabIndex = 148
        Me.lblAddAddress.Text = "Home Address : "
        '
        'lblAddEmailAddress
        '
        Me.lblAddEmailAddress.AutoSize = True
        Me.lblAddEmailAddress.Location = New System.Drawing.Point(20, 229)
        Me.lblAddEmailAddress.Name = "lblAddEmailAddress"
        Me.lblAddEmailAddress.Size = New System.Drawing.Size(123, 20)
        Me.lblAddEmailAddress.TabIndex = 147
        Me.lblAddEmailAddress.Text = "Email Address : "
        '
        'txtAddStaffAddress
        '
        Me.txtAddStaffAddress.Location = New System.Drawing.Point(201, 260)
        Me.txtAddStaffAddress.Multiline = True
        Me.txtAddStaffAddress.Name = "txtAddStaffAddress"
        Me.txtAddStaffAddress.Size = New System.Drawing.Size(254, 54)
        Me.txtAddStaffAddress.TabIndex = 8
        '
        'txtAddStaffEmailAddress
        '
        Me.txtAddStaffEmailAddress.Location = New System.Drawing.Point(202, 226)
        Me.txtAddStaffEmailAddress.Name = "txtAddStaffEmailAddress"
        Me.txtAddStaffEmailAddress.Size = New System.Drawing.Size(116, 26)
        Me.txtAddStaffEmailAddress.TabIndex = 6
        '
        'txtAddStaffName
        '
        Me.txtAddStaffName.Location = New System.Drawing.Point(201, 46)
        Me.txtAddStaffName.Name = "txtAddStaffName"
        Me.txtAddStaffName.Size = New System.Drawing.Size(248, 26)
        Me.txtAddStaffName.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnReadStaff)
        Me.TabPage2.Controls.Add(Me.btnCancelStaff)
        Me.TabPage2.Controls.Add(Me.gbReadPersonalDetails)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1342, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Read Staff "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnReadStaff
        '
        Me.btnReadStaff.Image = Global.ombak.My.Resources.Resources.searchbutton
        Me.btnReadStaff.Location = New System.Drawing.Point(526, 313)
        Me.btnReadStaff.Name = "btnReadStaff"
        Me.btnReadStaff.Size = New System.Drawing.Size(100, 50)
        Me.btnReadStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReadStaff.TabIndex = 190
        Me.btnReadStaff.TabStop = False
        '
        'btnCancelStaff
        '
        Me.btnCancelStaff.Image = Global.ombak.My.Resources.Resources.cancelbutton
        Me.btnCancelStaff.Location = New System.Drawing.Point(634, 313)
        Me.btnCancelStaff.Name = "btnCancelStaff"
        Me.btnCancelStaff.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelStaff.TabIndex = 189
        Me.btnCancelStaff.TabStop = False
        '
        'gbReadPersonalDetails
        '
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffICs)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffIC)
        Me.gbReadPersonalDetails.Controls.Add(Me.pbReadProfilePicture)
        Me.gbReadPersonalDetails.Controls.Add(Me.cbReadStaffID)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffAddresses)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffEmails)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffContacts)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffPositions)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffGenders)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffNames)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffContact)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffAddress)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffEmail)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffPosition)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffGender)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffId)
        Me.gbReadPersonalDetails.Controls.Add(Me.lblReadStaffName)
        Me.gbReadPersonalDetails.Location = New System.Drawing.Point(335, 6)
        Me.gbReadPersonalDetails.Name = "gbReadPersonalDetails"
        Me.gbReadPersonalDetails.Size = New System.Drawing.Size(784, 301)
        Me.gbReadPersonalDetails.TabIndex = 151
        Me.gbReadPersonalDetails.TabStop = False
        Me.gbReadPersonalDetails.Text = "Personal Details"
        '
        'lblReadStaffICs
        '
        Me.lblReadStaffICs.AutoSize = True
        Me.lblReadStaffICs.Location = New System.Drawing.Point(188, 79)
        Me.lblReadStaffICs.Name = "lblReadStaffICs"
        Me.lblReadStaffICs.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffICs.TabIndex = 175
        '
        'lblReadStaffIC
        '
        Me.lblReadStaffIC.AutoSize = True
        Me.lblReadStaffIC.Location = New System.Drawing.Point(81, 79)
        Me.lblReadStaffIC.Name = "lblReadStaffIC"
        Me.lblReadStaffIC.Size = New System.Drawing.Size(72, 20)
        Me.lblReadStaffIC.TabIndex = 174
        Me.lblReadStaffIC.Text = "Staff IC :"
        '
        'pbReadProfilePicture
        '
        Me.pbReadProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbReadProfilePicture.Location = New System.Drawing.Point(515, 25)
        Me.pbReadProfilePicture.Name = "pbReadProfilePicture"
        Me.pbReadProfilePicture.Size = New System.Drawing.Size(250, 260)
        Me.pbReadProfilePicture.TabIndex = 173
        Me.pbReadProfilePicture.TabStop = False
        '
        'cbReadStaffID
        '
        Me.cbReadStaffID.FormattingEnabled = True
        Me.cbReadStaffID.Location = New System.Drawing.Point(191, 35)
        Me.cbReadStaffID.Name = "cbReadStaffID"
        Me.cbReadStaffID.Size = New System.Drawing.Size(201, 28)
        Me.cbReadStaffID.TabIndex = 172
        '
        'lblReadStaffAddresses
        '
        Me.lblReadStaffAddresses.AutoSize = True
        Me.lblReadStaffAddresses.Location = New System.Drawing.Point(188, 263)
        Me.lblReadStaffAddresses.Name = "lblReadStaffAddresses"
        Me.lblReadStaffAddresses.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffAddresses.TabIndex = 170
        '
        'lblReadStaffEmails
        '
        Me.lblReadStaffEmails.AutoSize = True
        Me.lblReadStaffEmails.Location = New System.Drawing.Point(187, 234)
        Me.lblReadStaffEmails.Name = "lblReadStaffEmails"
        Me.lblReadStaffEmails.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffEmails.TabIndex = 169
        '
        'lblReadStaffContacts
        '
        Me.lblReadStaffContacts.AutoSize = True
        Me.lblReadStaffContacts.Location = New System.Drawing.Point(188, 204)
        Me.lblReadStaffContacts.Name = "lblReadStaffContacts"
        Me.lblReadStaffContacts.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffContacts.TabIndex = 168
        '
        'lblReadStaffPositions
        '
        Me.lblReadStaffPositions.AutoSize = True
        Me.lblReadStaffPositions.Location = New System.Drawing.Point(188, 174)
        Me.lblReadStaffPositions.Name = "lblReadStaffPositions"
        Me.lblReadStaffPositions.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffPositions.TabIndex = 167
        '
        'lblReadStaffGenders
        '
        Me.lblReadStaffGenders.AutoSize = True
        Me.lblReadStaffGenders.Location = New System.Drawing.Point(188, 144)
        Me.lblReadStaffGenders.Name = "lblReadStaffGenders"
        Me.lblReadStaffGenders.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffGenders.TabIndex = 166
        '
        'lblReadStaffNames
        '
        Me.lblReadStaffNames.AutoSize = True
        Me.lblReadStaffNames.Location = New System.Drawing.Point(188, 112)
        Me.lblReadStaffNames.Name = "lblReadStaffNames"
        Me.lblReadStaffNames.Size = New System.Drawing.Size(0, 20)
        Me.lblReadStaffNames.TabIndex = 165
        '
        'lblReadStaffContact
        '
        Me.lblReadStaffContact.AutoSize = True
        Me.lblReadStaffContact.Location = New System.Drawing.Point(80, 204)
        Me.lblReadStaffContact.Name = "lblReadStaffContact"
        Me.lblReadStaffContact.Size = New System.Drawing.Size(73, 20)
        Me.lblReadStaffContact.TabIndex = 156
        Me.lblReadStaffContact.Text = "Contact :"
        '
        'lblReadStaffAddress
        '
        Me.lblReadStaffAddress.AutoSize = True
        Me.lblReadStaffAddress.Location = New System.Drawing.Point(30, 263)
        Me.lblReadStaffAddress.Name = "lblReadStaffAddress"
        Me.lblReadStaffAddress.Size = New System.Drawing.Size(127, 20)
        Me.lblReadStaffAddress.TabIndex = 148
        Me.lblReadStaffAddress.Text = "Home Address : "
        '
        'lblReadStaffEmail
        '
        Me.lblReadStaffEmail.AutoSize = True
        Me.lblReadStaffEmail.Location = New System.Drawing.Point(34, 234)
        Me.lblReadStaffEmail.Name = "lblReadStaffEmail"
        Me.lblReadStaffEmail.Size = New System.Drawing.Size(123, 20)
        Me.lblReadStaffEmail.TabIndex = 147
        Me.lblReadStaffEmail.Text = "Email Address : "
        '
        'lblReadStaffPosition
        '
        Me.lblReadStaffPosition.AutoSize = True
        Me.lblReadStaffPosition.Location = New System.Drawing.Point(80, 174)
        Me.lblReadStaffPosition.Name = "lblReadStaffPosition"
        Me.lblReadStaffPosition.Size = New System.Drawing.Size(73, 20)
        Me.lblReadStaffPosition.TabIndex = 154
        Me.lblReadStaffPosition.Text = "Position :"
        '
        'lblReadStaffGender
        '
        Me.lblReadStaffGender.AutoSize = True
        Me.lblReadStaffGender.Location = New System.Drawing.Point(82, 144)
        Me.lblReadStaffGender.Name = "lblReadStaffGender"
        Me.lblReadStaffGender.Size = New System.Drawing.Size(75, 20)
        Me.lblReadStaffGender.TabIndex = 149
        Me.lblReadStaffGender.Text = "Gender : "
        '
        'lblReadStaffId
        '
        Me.lblReadStaffId.AutoSize = True
        Me.lblReadStaffId.Location = New System.Drawing.Point(80, 43)
        Me.lblReadStaffId.Name = "lblReadStaffId"
        Me.lblReadStaffId.Size = New System.Drawing.Size(77, 20)
        Me.lblReadStaffId.TabIndex = 143
        Me.lblReadStaffId.Text = "Staff ID : "
        '
        'lblReadStaffName
        '
        Me.lblReadStaffName.AutoSize = True
        Me.lblReadStaffName.Location = New System.Drawing.Point(55, 112)
        Me.lblReadStaffName.Name = "lblReadStaffName"
        Me.lblReadStaffName.Size = New System.Drawing.Size(102, 20)
        Me.lblReadStaffName.TabIndex = 144
        Me.lblReadStaffName.Text = "Staff Name : "
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.btnStaffUpdate)
        Me.TabPage3.Controls.Add(Me.btnCancelUpdateStaff)
        Me.TabPage3.Controls.Add(Me.gbUpdatePersonalDetails)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1342, 462)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update Staff"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnStaffUpdate
        '
        Me.btnStaffUpdate.Image = Global.ombak.My.Resources.Resources.updatebutton
        Me.btnStaffUpdate.Location = New System.Drawing.Point(592, 375)
        Me.btnStaffUpdate.Name = "btnStaffUpdate"
        Me.btnStaffUpdate.Size = New System.Drawing.Size(100, 50)
        Me.btnStaffUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnStaffUpdate.TabIndex = 190
        Me.btnStaffUpdate.TabStop = False
        '
        'btnCancelUpdateStaff
        '
        Me.btnCancelUpdateStaff.Image = Global.ombak.My.Resources.Resources.cancelbutton
        Me.btnCancelUpdateStaff.Location = New System.Drawing.Point(698, 375)
        Me.btnCancelUpdateStaff.Name = "btnCancelUpdateStaff"
        Me.btnCancelUpdateStaff.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelUpdateStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelUpdateStaff.TabIndex = 189
        Me.btnCancelUpdateStaff.TabStop = False
        '
        'gbUpdatePersonalDetails
        '
        Me.gbUpdatePersonalDetails.Controls.Add(Me.btnUpdateBrowse)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffICs)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffIC)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.pbUpdateProfilePicture)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.cbUpdateStaffPositions)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffGenders)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffNames)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.cbUpdateStaffID)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.txtUpdateStaffContacts)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.txtUpdateStaffAddresses)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffName)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffID)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.txtUpdateStaffEmails)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffGender)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffAddress)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffPosition)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffEmail)
        Me.gbUpdatePersonalDetails.Controls.Add(Me.lblUpdateStaffContact)
        Me.gbUpdatePersonalDetails.Location = New System.Drawing.Point(356, 20)
        Me.gbUpdatePersonalDetails.Name = "gbUpdatePersonalDetails"
        Me.gbUpdatePersonalDetails.Size = New System.Drawing.Size(785, 349)
        Me.gbUpdatePersonalDetails.TabIndex = 148
        Me.gbUpdatePersonalDetails.TabStop = False
        Me.gbUpdatePersonalDetails.Text = "Personal Details"
        '
        'btnUpdateBrowse
        '
        Me.btnUpdateBrowse.Image = Global.ombak.My.Resources.Resources.browsebutton
        Me.btnUpdateBrowse.Location = New System.Drawing.Point(559, 291)
        Me.btnUpdateBrowse.Name = "btnUpdateBrowse"
        Me.btnUpdateBrowse.Size = New System.Drawing.Size(100, 50)
        Me.btnUpdateBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnUpdateBrowse.TabIndex = 191
        Me.btnUpdateBrowse.TabStop = False
        '
        'lblUpdateStaffICs
        '
        Me.lblUpdateStaffICs.AutoSize = True
        Me.lblUpdateStaffICs.Location = New System.Drawing.Point(194, 96)
        Me.lblUpdateStaffICs.Name = "lblUpdateStaffICs"
        Me.lblUpdateStaffICs.Size = New System.Drawing.Size(0, 20)
        Me.lblUpdateStaffICs.TabIndex = 172
        '
        'lblUpdateStaffIC
        '
        Me.lblUpdateStaffIC.AutoSize = True
        Me.lblUpdateStaffIC.Location = New System.Drawing.Point(60, 97)
        Me.lblUpdateStaffIC.Name = "lblUpdateStaffIC"
        Me.lblUpdateStaffIC.Size = New System.Drawing.Size(72, 20)
        Me.lblUpdateStaffIC.TabIndex = 171
        Me.lblUpdateStaffIC.Text = "Staff IC :"
        '
        'pbUpdateProfilePicture
        '
        Me.pbUpdateProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbUpdateProfilePicture.Location = New System.Drawing.Point(479, 21)
        Me.pbUpdateProfilePicture.Name = "pbUpdateProfilePicture"
        Me.pbUpdateProfilePicture.Size = New System.Drawing.Size(250, 260)
        Me.pbUpdateProfilePicture.TabIndex = 170
        Me.pbUpdateProfilePicture.TabStop = False
        '
        'cbUpdateStaffPositions
        '
        Me.cbUpdateStaffPositions.FormattingEnabled = True
        Me.cbUpdateStaffPositions.Items.AddRange(New Object() {"Manager", "Clerk", "Cashier"})
        Me.cbUpdateStaffPositions.Location = New System.Drawing.Point(192, 151)
        Me.cbUpdateStaffPositions.Name = "cbUpdateStaffPositions"
        Me.cbUpdateStaffPositions.Size = New System.Drawing.Size(248, 28)
        Me.cbUpdateStaffPositions.TabIndex = 169
        '
        'lblUpdateStaffGenders
        '
        Me.lblUpdateStaffGenders.AutoSize = True
        Me.lblUpdateStaffGenders.Location = New System.Drawing.Point(195, 128)
        Me.lblUpdateStaffGenders.Name = "lblUpdateStaffGenders"
        Me.lblUpdateStaffGenders.Size = New System.Drawing.Size(0, 20)
        Me.lblUpdateStaffGenders.TabIndex = 166
        '
        'lblUpdateStaffNames
        '
        Me.lblUpdateStaffNames.AutoSize = True
        Me.lblUpdateStaffNames.Location = New System.Drawing.Point(194, 66)
        Me.lblUpdateStaffNames.Name = "lblUpdateStaffNames"
        Me.lblUpdateStaffNames.Size = New System.Drawing.Size(0, 20)
        Me.lblUpdateStaffNames.TabIndex = 165
        '
        'cbUpdateStaffID
        '
        Me.cbUpdateStaffID.FormattingEnabled = True
        Me.cbUpdateStaffID.Location = New System.Drawing.Point(192, 25)
        Me.cbUpdateStaffID.Name = "cbUpdateStaffID"
        Me.cbUpdateStaffID.Size = New System.Drawing.Size(249, 28)
        Me.cbUpdateStaffID.TabIndex = 164
        '
        'txtUpdateStaffContacts
        '
        Me.txtUpdateStaffContacts.Location = New System.Drawing.Point(193, 187)
        Me.txtUpdateStaffContacts.Name = "txtUpdateStaffContacts"
        Me.txtUpdateStaffContacts.Size = New System.Drawing.Size(247, 26)
        Me.txtUpdateStaffContacts.TabIndex = 158
        '
        'txtUpdateStaffAddresses
        '
        Me.txtUpdateStaffAddresses.Location = New System.Drawing.Point(193, 251)
        Me.txtUpdateStaffAddresses.Multiline = True
        Me.txtUpdateStaffAddresses.Name = "txtUpdateStaffAddresses"
        Me.txtUpdateStaffAddresses.Size = New System.Drawing.Size(249, 67)
        Me.txtUpdateStaffAddresses.TabIndex = 146
        '
        'lblUpdateStaffName
        '
        Me.lblUpdateStaffName.AutoSize = True
        Me.lblUpdateStaffName.Location = New System.Drawing.Point(35, 66)
        Me.lblUpdateStaffName.Name = "lblUpdateStaffName"
        Me.lblUpdateStaffName.Size = New System.Drawing.Size(102, 20)
        Me.lblUpdateStaffName.TabIndex = 144
        Me.lblUpdateStaffName.Text = "Staff Name : "
        '
        'lblUpdateStaffID
        '
        Me.lblUpdateStaffID.AutoSize = True
        Me.lblUpdateStaffID.Location = New System.Drawing.Point(60, 28)
        Me.lblUpdateStaffID.Name = "lblUpdateStaffID"
        Me.lblUpdateStaffID.Size = New System.Drawing.Size(77, 20)
        Me.lblUpdateStaffID.TabIndex = 143
        Me.lblUpdateStaffID.Text = "Staff ID : "
        '
        'txtUpdateStaffEmails
        '
        Me.txtUpdateStaffEmails.Location = New System.Drawing.Point(193, 219)
        Me.txtUpdateStaffEmails.Name = "txtUpdateStaffEmails"
        Me.txtUpdateStaffEmails.Size = New System.Drawing.Size(248, 26)
        Me.txtUpdateStaffEmails.TabIndex = 145
        '
        'lblUpdateStaffGender
        '
        Me.lblUpdateStaffGender.AutoSize = True
        Me.lblUpdateStaffGender.Location = New System.Drawing.Point(62, 129)
        Me.lblUpdateStaffGender.Name = "lblUpdateStaffGender"
        Me.lblUpdateStaffGender.Size = New System.Drawing.Size(75, 20)
        Me.lblUpdateStaffGender.TabIndex = 149
        Me.lblUpdateStaffGender.Text = "Gender : "
        '
        'lblUpdateStaffAddress
        '
        Me.lblUpdateStaffAddress.AutoSize = True
        Me.lblUpdateStaffAddress.Location = New System.Drawing.Point(8, 251)
        Me.lblUpdateStaffAddress.Name = "lblUpdateStaffAddress"
        Me.lblUpdateStaffAddress.Size = New System.Drawing.Size(127, 20)
        Me.lblUpdateStaffAddress.TabIndex = 148
        Me.lblUpdateStaffAddress.Text = "Home Address : "
        '
        'lblUpdateStaffPosition
        '
        Me.lblUpdateStaffPosition.AutoSize = True
        Me.lblUpdateStaffPosition.Location = New System.Drawing.Point(60, 156)
        Me.lblUpdateStaffPosition.Name = "lblUpdateStaffPosition"
        Me.lblUpdateStaffPosition.Size = New System.Drawing.Size(73, 20)
        Me.lblUpdateStaffPosition.TabIndex = 154
        Me.lblUpdateStaffPosition.Text = "Position :"
        '
        'lblUpdateStaffEmail
        '
        Me.lblUpdateStaffEmail.AutoSize = True
        Me.lblUpdateStaffEmail.Location = New System.Drawing.Point(12, 219)
        Me.lblUpdateStaffEmail.Name = "lblUpdateStaffEmail"
        Me.lblUpdateStaffEmail.Size = New System.Drawing.Size(123, 20)
        Me.lblUpdateStaffEmail.TabIndex = 147
        Me.lblUpdateStaffEmail.Text = "Email Address : "
        '
        'lblUpdateStaffContact
        '
        Me.lblUpdateStaffContact.AutoSize = True
        Me.lblUpdateStaffContact.Location = New System.Drawing.Point(60, 187)
        Me.lblUpdateStaffContact.Name = "lblUpdateStaffContact"
        Me.lblUpdateStaffContact.Size = New System.Drawing.Size(73, 20)
        Me.lblUpdateStaffContact.TabIndex = 156
        Me.lblUpdateStaffContact.Text = "Contact :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnStaffDelete)
        Me.TabPage4.Controls.Add(Me.gbDeletePersonalDetails)
        Me.TabPage4.Controls.Add(Me.btnCancelDeleteStaff)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1342, 462)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Delete Staff"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnStaffDelete
        '
        Me.btnStaffDelete.Image = Global.ombak.My.Resources.Resources.deletebutton
        Me.btnStaffDelete.Location = New System.Drawing.Point(622, 365)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(100, 50)
        Me.btnStaffDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnStaffDelete.TabIndex = 190
        Me.btnStaffDelete.TabStop = False
        '
        'gbDeletePersonalDetails
        '
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffICs)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffIC)
        Me.gbDeletePersonalDetails.Controls.Add(Me.pbDeleteProfilePicture)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffAddresses)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffEmails)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffcontact)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffPositions)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffGenders)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffNames)
        Me.gbDeletePersonalDetails.Controls.Add(Me.cbDeleteStaffId)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffPosition)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffAddress)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffID)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffEmail)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffName)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffGender)
        Me.gbDeletePersonalDetails.Controls.Add(Me.lblDeleteStaffContacts)
        Me.gbDeletePersonalDetails.Location = New System.Drawing.Point(348, 59)
        Me.gbDeletePersonalDetails.Name = "gbDeletePersonalDetails"
        Me.gbDeletePersonalDetails.Size = New System.Drawing.Size(768, 300)
        Me.gbDeletePersonalDetails.TabIndex = 154
        Me.gbDeletePersonalDetails.TabStop = False
        Me.gbDeletePersonalDetails.Text = "Personal Details"
        '
        'lblDeleteStaffICs
        '
        Me.lblDeleteStaffICs.AutoSize = True
        Me.lblDeleteStaffICs.Location = New System.Drawing.Point(195, 106)
        Me.lblDeleteStaffICs.Name = "lblDeleteStaffICs"
        Me.lblDeleteStaffICs.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffICs.TabIndex = 174
        '
        'lblDeleteStaffIC
        '
        Me.lblDeleteStaffIC.AutoSize = True
        Me.lblDeleteStaffIC.Location = New System.Drawing.Point(78, 106)
        Me.lblDeleteStaffIC.Name = "lblDeleteStaffIC"
        Me.lblDeleteStaffIC.Size = New System.Drawing.Size(72, 20)
        Me.lblDeleteStaffIC.TabIndex = 173
        Me.lblDeleteStaffIC.Text = "Staff IC :"
        '
        'pbDeleteProfilePicture
        '
        Me.pbDeleteProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbDeleteProfilePicture.Location = New System.Drawing.Point(496, 26)
        Me.pbDeleteProfilePicture.Name = "pbDeleteProfilePicture"
        Me.pbDeleteProfilePicture.Size = New System.Drawing.Size(250, 260)
        Me.pbDeleteProfilePicture.TabIndex = 172
        Me.pbDeleteProfilePicture.TabStop = False
        '
        'lblDeleteStaffAddresses
        '
        Me.lblDeleteStaffAddresses.AutoSize = True
        Me.lblDeleteStaffAddresses.Location = New System.Drawing.Point(195, 260)
        Me.lblDeleteStaffAddresses.Name = "lblDeleteStaffAddresses"
        Me.lblDeleteStaffAddresses.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffAddresses.TabIndex = 170
        '
        'lblDeleteStaffEmails
        '
        Me.lblDeleteStaffEmails.AutoSize = True
        Me.lblDeleteStaffEmails.Location = New System.Drawing.Point(195, 228)
        Me.lblDeleteStaffEmails.Name = "lblDeleteStaffEmails"
        Me.lblDeleteStaffEmails.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffEmails.TabIndex = 169
        '
        'lblDeleteStaffcontact
        '
        Me.lblDeleteStaffcontact.AutoSize = True
        Me.lblDeleteStaffcontact.Location = New System.Drawing.Point(195, 198)
        Me.lblDeleteStaffcontact.Name = "lblDeleteStaffcontact"
        Me.lblDeleteStaffcontact.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffcontact.TabIndex = 168
        '
        'lblDeleteStaffPositions
        '
        Me.lblDeleteStaffPositions.AutoSize = True
        Me.lblDeleteStaffPositions.Location = New System.Drawing.Point(195, 166)
        Me.lblDeleteStaffPositions.Name = "lblDeleteStaffPositions"
        Me.lblDeleteStaffPositions.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffPositions.TabIndex = 167
        '
        'lblDeleteStaffGenders
        '
        Me.lblDeleteStaffGenders.AutoSize = True
        Me.lblDeleteStaffGenders.Location = New System.Drawing.Point(195, 137)
        Me.lblDeleteStaffGenders.Name = "lblDeleteStaffGenders"
        Me.lblDeleteStaffGenders.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffGenders.TabIndex = 166
        '
        'lblDeleteStaffNames
        '
        Me.lblDeleteStaffNames.AutoSize = True
        Me.lblDeleteStaffNames.Location = New System.Drawing.Point(195, 74)
        Me.lblDeleteStaffNames.Name = "lblDeleteStaffNames"
        Me.lblDeleteStaffNames.Size = New System.Drawing.Size(0, 20)
        Me.lblDeleteStaffNames.TabIndex = 165
        '
        'cbDeleteStaffId
        '
        Me.cbDeleteStaffId.FormattingEnabled = True
        Me.cbDeleteStaffId.Location = New System.Drawing.Point(199, 34)
        Me.cbDeleteStaffId.Name = "cbDeleteStaffId"
        Me.cbDeleteStaffId.Size = New System.Drawing.Size(249, 28)
        Me.cbDeleteStaffId.TabIndex = 164
        '
        'lblDeleteStaffPosition
        '
        Me.lblDeleteStaffPosition.AutoSize = True
        Me.lblDeleteStaffPosition.Location = New System.Drawing.Point(78, 166)
        Me.lblDeleteStaffPosition.Name = "lblDeleteStaffPosition"
        Me.lblDeleteStaffPosition.Size = New System.Drawing.Size(73, 20)
        Me.lblDeleteStaffPosition.TabIndex = 154
        Me.lblDeleteStaffPosition.Text = "Position :"
        '
        'lblDeleteStaffAddress
        '
        Me.lblDeleteStaffAddress.AutoSize = True
        Me.lblDeleteStaffAddress.Location = New System.Drawing.Point(29, 260)
        Me.lblDeleteStaffAddress.Name = "lblDeleteStaffAddress"
        Me.lblDeleteStaffAddress.Size = New System.Drawing.Size(127, 20)
        Me.lblDeleteStaffAddress.TabIndex = 148
        Me.lblDeleteStaffAddress.Text = "Home Address : "
        '
        'lblDeleteStaffID
        '
        Me.lblDeleteStaffID.AutoSize = True
        Me.lblDeleteStaffID.Location = New System.Drawing.Point(78, 37)
        Me.lblDeleteStaffID.Name = "lblDeleteStaffID"
        Me.lblDeleteStaffID.Size = New System.Drawing.Size(77, 20)
        Me.lblDeleteStaffID.TabIndex = 143
        Me.lblDeleteStaffID.Text = "Staff ID : "
        '
        'lblDeleteStaffEmail
        '
        Me.lblDeleteStaffEmail.AutoSize = True
        Me.lblDeleteStaffEmail.Location = New System.Drawing.Point(33, 228)
        Me.lblDeleteStaffEmail.Name = "lblDeleteStaffEmail"
        Me.lblDeleteStaffEmail.Size = New System.Drawing.Size(123, 20)
        Me.lblDeleteStaffEmail.TabIndex = 147
        Me.lblDeleteStaffEmail.Text = "Email Address : "
        '
        'lblDeleteStaffName
        '
        Me.lblDeleteStaffName.AutoSize = True
        Me.lblDeleteStaffName.Location = New System.Drawing.Point(52, 74)
        Me.lblDeleteStaffName.Name = "lblDeleteStaffName"
        Me.lblDeleteStaffName.Size = New System.Drawing.Size(102, 20)
        Me.lblDeleteStaffName.TabIndex = 144
        Me.lblDeleteStaffName.Text = "Staff Name : "
        '
        'lblDeleteStaffGender
        '
        Me.lblDeleteStaffGender.AutoSize = True
        Me.lblDeleteStaffGender.Location = New System.Drawing.Point(79, 137)
        Me.lblDeleteStaffGender.Name = "lblDeleteStaffGender"
        Me.lblDeleteStaffGender.Size = New System.Drawing.Size(75, 20)
        Me.lblDeleteStaffGender.TabIndex = 149
        Me.lblDeleteStaffGender.Text = "Gender : "
        '
        'lblDeleteStaffContacts
        '
        Me.lblDeleteStaffContacts.AutoSize = True
        Me.lblDeleteStaffContacts.Location = New System.Drawing.Point(81, 198)
        Me.lblDeleteStaffContacts.Name = "lblDeleteStaffContacts"
        Me.lblDeleteStaffContacts.Size = New System.Drawing.Size(73, 20)
        Me.lblDeleteStaffContacts.TabIndex = 156
        Me.lblDeleteStaffContacts.Text = "Contact :"
        '
        'btnCancelDeleteStaff
        '
        Me.btnCancelDeleteStaff.Image = Global.ombak.My.Resources.Resources.cancelbutton
        Me.btnCancelDeleteStaff.Location = New System.Drawing.Point(728, 365)
        Me.btnCancelDeleteStaff.Name = "btnCancelDeleteStaff"
        Me.btnCancelDeleteStaff.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelDeleteStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelDeleteStaff.TabIndex = 189
        Me.btnCancelDeleteStaff.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(1120, 112)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffName.TabIndex = 91
        '
        'lblStaffID2
        '
        Me.lblStaffID2.AutoSize = True
        Me.lblStaffID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffID2.Location = New System.Drawing.Point(1120, 64)
        Me.lblStaffID2.Name = "lblStaffID2"
        Me.lblStaffID2.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffID2.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(953, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Staff Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(995, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Staff ID : "
        '
        'backButton
        '
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.Location = New System.Drawing.Point(12, 10)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(110, 65)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backButton.TabIndex = 92
        Me.backButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(425, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblStaffid
        '
        Me.lblStaffid.AutoSize = True
        Me.lblStaffid.Location = New System.Drawing.Point(201, 20)
        Me.lblStaffid.Name = "lblStaffid"
        Me.lblStaffid.Size = New System.Drawing.Size(0, 20)
        Me.lblStaffid.TabIndex = 190
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffID2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.btnStaffCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStaffAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAddPersonalDetails.ResumeLayout(False)
        Me.gbAddPersonalDetails.PerformLayout()
        CType(Me.btnAddBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.btnReadStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReadPersonalDetails.ResumeLayout(False)
        Me.gbReadPersonalDetails.PerformLayout()
        CType(Me.pbReadProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.btnStaffUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelUpdateStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUpdatePersonalDetails.ResumeLayout(False)
        Me.gbUpdatePersonalDetails.PerformLayout()
        CType(Me.btnUpdateBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUpdateProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.btnStaffDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDeletePersonalDetails.ResumeLayout(False)
        Me.gbDeletePersonalDetails.PerformLayout()
        CType(Me.pbDeleteProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelDeleteStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gbAddPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblAddStaffIDs As System.Windows.Forms.Label
    Friend WithEvents cbAddEmailType As System.Windows.Forms.ComboBox
    Friend WithEvents cbAddAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddStaffName As System.Windows.Forms.Label
    Friend WithEvents cbAddStaffPosition As System.Windows.Forms.ComboBox
    Friend WithEvents rdFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddStaffContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblAddStaffContact As System.Windows.Forms.Label
    Friend WithEvents lblAddStaffPosition As System.Windows.Forms.Label
    Friend WithEvents lblAddStaffGender As System.Windows.Forms.Label
    Friend WithEvents lblAddAddress As System.Windows.Forms.Label
    Friend WithEvents lblAddEmailAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddStaffAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAddStaffEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAddStaffName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents gbReadPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblReadStaffAddresses As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffEmails As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffContacts As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffPositions As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffGenders As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffNames As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffContact As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffAddress As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffEmail As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffPosition As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffGender As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffId As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffName As System.Windows.Forms.Label
    Friend WithEvents gbDeletePersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblDeleteStaffAddresses As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffEmails As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffcontact As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffPositions As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffGenders As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffNames As System.Windows.Forms.Label
    Friend WithEvents cbDeleteStaffId As System.Windows.Forms.ComboBox
    Friend WithEvents lblDeleteStaffPosition As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffAddress As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffID As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffEmail As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffName As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffGender As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffContacts As System.Windows.Forms.Label
    Friend WithEvents gbUpdatePersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblUpdateStaffGenders As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffNames As System.Windows.Forms.Label
    Friend WithEvents cbUpdateStaffID As System.Windows.Forms.ComboBox
    Friend WithEvents txtUpdateStaffContacts As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateStaffAddresses As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdateStaffName As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffID As System.Windows.Forms.Label
    Friend WithEvents txtUpdateStaffEmails As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdateStaffGender As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffAddress As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffPosition As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffEmail As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffContact As System.Windows.Forms.Label
    Friend WithEvents cbReadStaffID As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents cbUpdateStaffPositions As System.Windows.Forms.ComboBox
    Friend WithEvents pbAddProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbReadProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents pbUpdateProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents pbDeleteProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtAddStaffICs As System.Windows.Forms.TextBox
    Friend WithEvents lblAddStaffIC As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffICs As System.Windows.Forms.Label
    Friend WithEvents lblReadStaffIC As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffICs As System.Windows.Forms.Label
    Friend WithEvents lblUpdateStaffIC As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffICs As System.Windows.Forms.Label
    Friend WithEvents lblDeleteStaffIC As System.Windows.Forms.Label
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffID2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents backButton As System.Windows.Forms.PictureBox
    Friend WithEvents btnStaffAdd As System.Windows.Forms.PictureBox
    Friend WithEvents btnStaffCancel As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddBrowse As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelStaff As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelUpdateStaff As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelDeleteStaff As System.Windows.Forms.PictureBox
    Friend WithEvents btnReadStaff As System.Windows.Forms.PictureBox
    Friend WithEvents btnStaffUpdate As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpdateBrowse As System.Windows.Forms.PictureBox
    Friend WithEvents btnStaffDelete As System.Windows.Forms.PictureBox
    Friend WithEvents lblStaffid As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lklblChangePassword = New System.Windows.Forms.LinkLabel()
        Me.lklblGenerateReport = New System.Windows.Forms.LinkLabel()
        Me.lklblManageSupplier = New System.Windows.Forms.LinkLabel()
        Me.lklblManageStaff = New System.Windows.Forms.LinkLabel()
        Me.lklblPayment = New System.Windows.Forms.LinkLabel()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.profilePicture = New System.Windows.Forms.PictureBox()
        Me.lblStaffAddress = New System.Windows.Forms.Label()
        Me.lblStaffEmail = New System.Windows.Forms.Label()
        Me.lblStaffContact = New System.Windows.Forms.Label()
        Me.lblStaffPosition = New System.Windows.Forms.Label()
        Me.lblStaffGender = New System.Windows.Forms.Label()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffIC = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblLoginDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lklblManageStock = New System.Windows.Forms.LinkLabel()
        Me.lklblManagerCustomer = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lklblChangePassword
        '
        Me.lklblChangePassword.AutoSize = True
        Me.lklblChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblChangePassword.Location = New System.Drawing.Point(40, 250)
        Me.lklblChangePassword.Name = "lklblChangePassword"
        Me.lklblChangePassword.Size = New System.Drawing.Size(236, 31)
        Me.lklblChangePassword.TabIndex = 81
        Me.lklblChangePassword.TabStop = True
        Me.lklblChangePassword.Text = "Change Password"
        '
        'lklblGenerateReport
        '
        Me.lklblGenerateReport.AutoSize = True
        Me.lklblGenerateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblGenerateReport.Location = New System.Drawing.Point(38, 550)
        Me.lklblGenerateReport.Name = "lklblGenerateReport"
        Me.lklblGenerateReport.Size = New System.Drawing.Size(216, 31)
        Me.lklblGenerateReport.TabIndex = 80
        Me.lklblGenerateReport.TabStop = True
        Me.lklblGenerateReport.Text = "Generate Report"
        '
        'lklblManageSupplier
        '
        Me.lklblManageSupplier.AutoSize = True
        Me.lklblManageSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblManageSupplier.Location = New System.Drawing.Point(38, 450)
        Me.lklblManageSupplier.Name = "lklblManageSupplier"
        Me.lklblManageSupplier.Size = New System.Drawing.Size(217, 31)
        Me.lklblManageSupplier.TabIndex = 79
        Me.lklblManageSupplier.TabStop = True
        Me.lklblManageSupplier.Text = "Manage Supplier"
        '
        'lklblManageStaff
        '
        Me.lklblManageStaff.AutoSize = True
        Me.lklblManageStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblManageStaff.Location = New System.Drawing.Point(40, 300)
        Me.lklblManageStaff.Name = "lklblManageStaff"
        Me.lklblManageStaff.Size = New System.Drawing.Size(175, 31)
        Me.lklblManageStaff.TabIndex = 78
        Me.lklblManageStaff.TabStop = True
        Me.lklblManageStaff.Text = "Manage Staff"
        '
        'lklblPayment
        '
        Me.lklblPayment.AutoSize = True
        Me.lklblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblPayment.Location = New System.Drawing.Point(38, 500)
        Me.lklblPayment.Name = "lklblPayment"
        Me.lklblPayment.Size = New System.Drawing.Size(225, 31)
        Me.lklblPayment.TabIndex = 82
        Me.lklblPayment.TabStop = True
        Me.lklblPayment.Text = "Manage Payment"
        '
        'btnLogout
        '
        Me.btnLogout.Image = Global.ombak.My.Resources.Resources.logoutbutton
        Me.btnLogout.Location = New System.Drawing.Point(1238, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 50)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogout.TabIndex = 83
        Me.btnLogout.TabStop = False
        '
        'profilePicture
        '
        Me.profilePicture.Location = New System.Drawing.Point(922, 250)
        Me.profilePicture.Name = "profilePicture"
        Me.profilePicture.Size = New System.Drawing.Size(250, 260)
        Me.profilePicture.TabIndex = 108
        Me.profilePicture.TabStop = False
        '
        'lblStaffAddress
        '
        Me.lblStaffAddress.AutoSize = True
        Me.lblStaffAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffAddress.Location = New System.Drawing.Point(620, 600)
        Me.lblStaffAddress.Name = "lblStaffAddress"
        Me.lblStaffAddress.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffAddress.TabIndex = 107
        '
        'lblStaffEmail
        '
        Me.lblStaffEmail.AutoSize = True
        Me.lblStaffEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffEmail.Location = New System.Drawing.Point(620, 550)
        Me.lblStaffEmail.Name = "lblStaffEmail"
        Me.lblStaffEmail.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffEmail.TabIndex = 106
        '
        'lblStaffContact
        '
        Me.lblStaffContact.AutoSize = True
        Me.lblStaffContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffContact.Location = New System.Drawing.Point(620, 500)
        Me.lblStaffContact.Name = "lblStaffContact"
        Me.lblStaffContact.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffContact.TabIndex = 105
        '
        'lblStaffPosition
        '
        Me.lblStaffPosition.AutoSize = True
        Me.lblStaffPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffPosition.Location = New System.Drawing.Point(620, 450)
        Me.lblStaffPosition.Name = "lblStaffPosition"
        Me.lblStaffPosition.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffPosition.TabIndex = 104
        '
        'lblStaffGender
        '
        Me.lblStaffGender.AutoSize = True
        Me.lblStaffGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffGender.Location = New System.Drawing.Point(620, 400)
        Me.lblStaffGender.Name = "lblStaffGender"
        Me.lblStaffGender.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffGender.TabIndex = 103
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(620, 350)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffName.TabIndex = 102
        '
        'lblStaffIC
        '
        Me.lblStaffIC.AutoSize = True
        Me.lblStaffIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffIC.Location = New System.Drawing.Point(620, 300)
        Me.lblStaffIC.Name = "lblStaffIC"
        Me.lblStaffIC.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffIC.TabIndex = 101
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(620, 250)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffID.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(495, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 29)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Staff IC : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 600)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Staff Address : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(457, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 29)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Staff Email : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 29)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Staff Contact : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 29)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Staff Position : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Staff Gender : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Staff Name : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(495, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 29)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Staff ID : "
        '
        'lblLoginTime
        '
        Me.lblLoginTime.AutoSize = True
        Me.lblLoginTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLoginTime.Location = New System.Drawing.Point(210, 80)
        Me.lblLoginTime.Name = "lblLoginTime"
        Me.lblLoginTime.Size = New System.Drawing.Size(0, 29)
        Me.lblLoginTime.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 29)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Login Time : "
        '
        'lblLoginDate
        '
        Me.lblLoginDate.AutoSize = True
        Me.lblLoginDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLoginDate.Location = New System.Drawing.Point(210, 30)
        Me.lblLoginDate.Name = "lblLoginDate"
        Me.lblLoginDate.Size = New System.Drawing.Size(0, 29)
        Me.lblLoginDate.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 29)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Login Date : "
        '
        'lklblManageStock
        '
        Me.lklblManageStock.AutoSize = True
        Me.lklblManageStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblManageStock.Location = New System.Drawing.Point(40, 400)
        Me.lklblManageStock.Name = "lklblManageStock"
        Me.lklblManageStock.Size = New System.Drawing.Size(187, 31)
        Me.lklblManageStock.TabIndex = 114
        Me.lklblManageStock.TabStop = True
        Me.lklblManageStock.Text = "Manage Stock"
        '
        'lklblManagerCustomer
        '
        Me.lklblManagerCustomer.AutoSize = True
        Me.lklblManagerCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblManagerCustomer.Location = New System.Drawing.Point(40, 350)
        Me.lklblManagerCustomer.Name = "lklblManagerCustomer"
        Me.lklblManagerCustomer.Size = New System.Drawing.Size(236, 31)
        Me.lklblManagerCustomer.TabIndex = 113
        Me.lklblManagerCustomer.TabStop = True
        Me.lklblManagerCustomer.Text = "Manage Customer"
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 749)
        Me.Controls.Add(Me.lklblManageStock)
        Me.Controls.Add(Me.lklblManagerCustomer)
        Me.Controls.Add(Me.lblLoginTime)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblLoginDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.profilePicture)
        Me.Controls.Add(Me.lblStaffAddress)
        Me.Controls.Add(Me.lblStaffEmail)
        Me.Controls.Add(Me.lblStaffContact)
        Me.Controls.Add(Me.lblStaffPosition)
        Me.Controls.Add(Me.lblStaffGender)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffIC)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lklblPayment)
        Me.Controls.Add(Me.lklblChangePassword)
        Me.Controls.Add(Me.lklblGenerateReport)
        Me.Controls.Add(Me.lklblManageSupplier)
        Me.Controls.Add(Me.lklblManageStaff)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Manager"
        Me.Text = "Manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lklblChangePassword As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblGenerateReport As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblManageSupplier As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblManageStaff As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblPayment As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLogout As System.Windows.Forms.PictureBox
    Friend WithEvents profilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblStaffAddress As System.Windows.Forms.Label
    Friend WithEvents lblStaffEmail As System.Windows.Forms.Label
    Friend WithEvents lblStaffContact As System.Windows.Forms.Label
    Friend WithEvents lblStaffPosition As System.Windows.Forms.Label
    Friend WithEvents lblStaffGender As System.Windows.Forms.Label
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffIC As System.Windows.Forms.Label
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLoginTime As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblLoginDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lklblManageStock As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblManagerCustomer As System.Windows.Forms.LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCusAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lklblPrizeRedemption = New System.Windows.Forms.LinkLabel()
        Me.lklblDeleteCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblEditCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblViewCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblAddCustomer = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.cboxCusID = New System.Windows.Forms.ComboBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPoint = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Gender : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Age : "
        '
        'txtCusAge
        '
        Me.txtCusAge.Enabled = False
        Me.txtCusAge.Location = New System.Drawing.Point(169, 216)
        Me.txtCusAge.Name = "txtCusAge"
        Me.txtCusAge.Size = New System.Drawing.Size(166, 20)
        Me.txtCusAge.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Home Address : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Email Address : "
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(169, 296)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(166, 44)
        Me.txtAddress.TabIndex = 56
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(169, 269)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(166, 20)
        Me.txtEmail.TabIndex = 55
        '
        'lklblPrizeRedemption
        '
        Me.lklblPrizeRedemption.AutoSize = True
        Me.lklblPrizeRedemption.Location = New System.Drawing.Point(313, 106)
        Me.lklblPrizeRedemption.Name = "lklblPrizeRedemption"
        Me.lklblPrizeRedemption.Size = New System.Drawing.Size(90, 13)
        Me.lklblPrizeRedemption.TabIndex = 54
        Me.lklblPrizeRedemption.TabStop = True
        Me.lklblPrizeRedemption.Text = "Prize Redemption"
        '
        'lklblDeleteCustomer
        '
        Me.lklblDeleteCustomer.AutoSize = True
        Me.lklblDeleteCustomer.Location = New System.Drawing.Point(230, 106)
        Me.lklblDeleteCustomer.Name = "lklblDeleteCustomer"
        Me.lklblDeleteCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lklblDeleteCustomer.TabIndex = 53
        Me.lklblDeleteCustomer.TabStop = True
        Me.lklblDeleteCustomer.Text = "Delete Customer"
        '
        'lklblEditCustomer
        '
        Me.lklblEditCustomer.AutoSize = True
        Me.lklblEditCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblEditCustomer.Location = New System.Drawing.Point(149, 106)
        Me.lklblEditCustomer.Name = "lklblEditCustomer"
        Me.lklblEditCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lklblEditCustomer.TabIndex = 52
        Me.lklblEditCustomer.TabStop = True
        Me.lklblEditCustomer.Text = "Edit Customer"
        '
        'lklblViewCustomer
        '
        Me.lklblViewCustomer.AutoSize = True
        Me.lklblViewCustomer.Location = New System.Drawing.Point(76, 106)
        Me.lklblViewCustomer.Name = "lklblViewCustomer"
        Me.lklblViewCustomer.Size = New System.Drawing.Size(77, 13)
        Me.lklblViewCustomer.TabIndex = 51
        Me.lklblViewCustomer.TabStop = True
        Me.lklblViewCustomer.Text = "View Customer"
        '
        'lklblAddCustomer
        '
        Me.lklblAddCustomer.AutoSize = True
        Me.lklblAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblAddCustomer.Location = New System.Drawing.Point(6, 106)
        Me.lklblAddCustomer.Name = "lklblAddCustomer"
        Me.lklblAddCustomer.Size = New System.Drawing.Size(73, 13)
        Me.lklblAddCustomer.TabIndex = 50
        Me.lklblAddCustomer.TabStop = True
        Me.lklblAddCustomer.Text = "Add Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Edit Customer Detail"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(127, 381)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Customer Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Customer ID : "
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(169, 188)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(166, 20)
        Me.txtCusName.TabIndex = 44
        '
        'cboxCusID
        '
        Me.cboxCusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCusID.FormattingEnabled = True
        Me.cboxCusID.Items.AddRange(New Object() {"1000", "1001"})
        Me.cboxCusID.Location = New System.Drawing.Point(169, 161)
        Me.cboxCusID.Name = "cboxCusID"
        Me.cboxCusID.Size = New System.Drawing.Size(166, 21)
        Me.cboxCusID.TabIndex = 65
        '
        'txtGender
        '
        Me.txtGender.Enabled = False
        Me.txtGender.Location = New System.Drawing.Point(169, 243)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(166, 20)
        Me.txtGender.TabIndex = 66
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Point Amount : "
        '
        'txtPoint
        '
        Me.txtPoint.Enabled = False
        Me.txtPoint.Location = New System.Drawing.Point(169, 347)
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.Size = New System.Drawing.Size(166, 20)
        Me.txtPoint.TabIndex = 68
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 411)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPoint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.cboxCusID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCusAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lklblPrizeRedemption)
        Me.Controls.Add(Me.lklblDeleteCustomer)
        Me.Controls.Add(Me.lklblEditCustomer)
        Me.Controls.Add(Me.lklblViewCustomer)
        Me.Controls.Add(Me.lklblAddCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusName)
        Me.Name = "EditCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCustomer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCusAge As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lklblPrizeRedemption As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblDeleteCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblEditCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblViewCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblAddCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents cboxCusID As System.Windows.Forms.ComboBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPoint As System.Windows.Forms.TextBox
End Class

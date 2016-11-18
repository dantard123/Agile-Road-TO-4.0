<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.lklblAddCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblViewCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblDeleteCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblEditCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblPrizeRedemption = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCusAge = New System.Windows.Forms.TextBox()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.cboxEmail2 = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Add New Customer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(130, 354)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Customer Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Customer ID : "
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(169, 188)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(170, 20)
        Me.txtCusName.TabIndex = 20
        '
        'txtCusID
        '
        Me.txtCusID.Enabled = False
        Me.txtCusID.Location = New System.Drawing.Point(169, 161)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(170, 20)
        Me.txtCusID.TabIndex = 19
        '
        'lklblAddCustomer
        '
        Me.lklblAddCustomer.AutoSize = True
        Me.lklblAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblAddCustomer.Location = New System.Drawing.Point(6, 106)
        Me.lklblAddCustomer.Name = "lklblAddCustomer"
        Me.lklblAddCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lklblAddCustomer.TabIndex = 27
        Me.lklblAddCustomer.TabStop = True
        Me.lklblAddCustomer.Text = "Add Customer"
        '
        'lklblViewCustomer
        '
        Me.lklblViewCustomer.AutoSize = True
        Me.lklblViewCustomer.Location = New System.Drawing.Point(89, 106)
        Me.lklblViewCustomer.Name = "lklblViewCustomer"
        Me.lklblViewCustomer.Size = New System.Drawing.Size(77, 13)
        Me.lklblViewCustomer.TabIndex = 28
        Me.lklblViewCustomer.TabStop = True
        Me.lklblViewCustomer.Text = "View Customer"
        '
        'lklblDeleteCustomer
        '
        Me.lklblDeleteCustomer.AutoSize = True
        Me.lklblDeleteCustomer.Location = New System.Drawing.Point(230, 106)
        Me.lklblDeleteCustomer.Name = "lklblDeleteCustomer"
        Me.lklblDeleteCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lklblDeleteCustomer.TabIndex = 30
        Me.lklblDeleteCustomer.TabStop = True
        Me.lklblDeleteCustomer.Text = "Delete Customer"
        '
        'lklblEditCustomer
        '
        Me.lklblEditCustomer.AutoSize = True
        Me.lklblEditCustomer.Location = New System.Drawing.Point(162, 106)
        Me.lklblEditCustomer.Name = "lklblEditCustomer"
        Me.lklblEditCustomer.Size = New System.Drawing.Size(72, 13)
        Me.lklblEditCustomer.TabIndex = 29
        Me.lklblEditCustomer.TabStop = True
        Me.lklblEditCustomer.Text = "Edit Customer"
        '
        'lklblPrizeRedemption
        '
        Me.lklblPrizeRedemption.AutoSize = True
        Me.lklblPrizeRedemption.Location = New System.Drawing.Point(313, 106)
        Me.lklblPrizeRedemption.Name = "lklblPrizeRedemption"
        Me.lklblPrizeRedemption.Size = New System.Drawing.Size(90, 13)
        Me.lklblPrizeRedemption.TabIndex = 31
        Me.lklblPrizeRedemption.TabStop = True
        Me.lklblPrizeRedemption.Text = "Prize Redemption"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Home Address : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Email Address : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Gender : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Age : "
        '
        'txtCusAge
        '
        Me.txtCusAge.Location = New System.Drawing.Point(169, 216)
        Me.txtCusAge.Name = "txtCusAge"
        Me.txtCusAge.Size = New System.Drawing.Size(170, 20)
        Me.txtCusAge.TabIndex = 36
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(170, 244)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 40
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(227, 244)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 41
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'cboxEmail2
        '
        Me.cboxEmail2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmail2.FormattingEnabled = True
        Me.cboxEmail2.Items.AddRange(New Object() {"@hotmail.com", "@yahoo.com", "@gmail.com", "@live.com"})
        Me.cboxEmail2.Location = New System.Drawing.Point(247, 269)
        Me.cboxEmail2.Name = "cboxEmail2"
        Me.cboxEmail2.Size = New System.Drawing.Size(92, 21)
        Me.cboxEmail2.TabIndex = 131
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(170, 296)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(169, 44)
        Me.txtAddress.TabIndex = 130
        '
        'txtEmail1
        '
        Me.txtEmail1.Location = New System.Drawing.Point(169, 269)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(72, 20)
        Me.txtEmail1.TabIndex = 129
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 386)
        Me.Controls.Add(Me.cboxEmail2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCusAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lklblPrizeRedemption)
        Me.Controls.Add(Me.lklblDeleteCustomer)
        Me.Controls.Add(Me.lklblEditCustomer)
        Me.Controls.Add(Me.lklblViewCustomer)
        Me.Controls.Add(Me.lklblAddCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.txtCusID)
        Me.Name = "AddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCustomer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusID As System.Windows.Forms.TextBox
    Friend WithEvents lklblAddCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblViewCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblDeleteCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblEditCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblPrizeRedemption As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCusAge As System.Windows.Forms.TextBox
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboxEmail2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail1 As System.Windows.Forms.TextBox
End Class

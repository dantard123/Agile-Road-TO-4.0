<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrizeRedemption
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
        Me.cboxCusID = New System.Windows.Forms.ComboBox()
        Me.lklblPrizeRedemption = New System.Windows.Forms.LinkLabel()
        Me.lklblDeleteCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblEditCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblViewCustomer = New System.Windows.Forms.LinkLabel()
        Me.lklblAddCustomer = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.cboxPrize = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxCusID
        '
        Me.cboxCusID.FormattingEnabled = True
        Me.cboxCusID.Location = New System.Drawing.Point(169, 161)
        Me.cboxCusID.Name = "cboxCusID"
        Me.cboxCusID.Size = New System.Drawing.Size(154, 21)
        Me.cboxCusID.TabIndex = 86
        '
        'lklblPrizeRedemption
        '
        Me.lklblPrizeRedemption.AutoSize = True
        Me.lklblPrizeRedemption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblPrizeRedemption.Location = New System.Drawing.Point(300, 106)
        Me.lklblPrizeRedemption.Name = "lklblPrizeRedemption"
        Me.lklblPrizeRedemption.Size = New System.Drawing.Size(106, 13)
        Me.lklblPrizeRedemption.TabIndex = 77
        Me.lklblPrizeRedemption.TabStop = True
        Me.lklblPrizeRedemption.Text = "Prize Redemption"
        '
        'lklblDeleteCustomer
        '
        Me.lklblDeleteCustomer.AutoSize = True
        Me.lklblDeleteCustomer.Location = New System.Drawing.Point(217, 106)
        Me.lklblDeleteCustomer.Name = "lklblDeleteCustomer"
        Me.lklblDeleteCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lklblDeleteCustomer.TabIndex = 76
        Me.lklblDeleteCustomer.TabStop = True
        Me.lklblDeleteCustomer.Text = "Delete Customer"
        '
        'lklblEditCustomer
        '
        Me.lklblEditCustomer.AutoSize = True
        Me.lklblEditCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lklblEditCustomer.Location = New System.Drawing.Point(149, 106)
        Me.lklblEditCustomer.Name = "lklblEditCustomer"
        Me.lklblEditCustomer.Size = New System.Drawing.Size(72, 13)
        Me.lklblEditCustomer.TabIndex = 75
        Me.lklblEditCustomer.TabStop = True
        Me.lklblEditCustomer.Text = "Edit Customer"
        '
        'lklblViewCustomer
        '
        Me.lklblViewCustomer.AutoSize = True
        Me.lklblViewCustomer.Location = New System.Drawing.Point(76, 106)
        Me.lklblViewCustomer.Name = "lklblViewCustomer"
        Me.lklblViewCustomer.Size = New System.Drawing.Size(77, 13)
        Me.lklblViewCustomer.TabIndex = 74
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
        Me.lklblAddCustomer.TabIndex = 73
        Me.lklblAddCustomer.TabStop = True
        Me.lklblAddCustomer.Text = "Add Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Prize Redemption"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(130, 354)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 70
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Customer Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Customer ID : "
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(169, 188)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(154, 20)
        Me.txtCusName.TabIndex = 67
        '
        'cboxPrize
        '
        Me.cboxPrize.FormattingEnabled = True
        Me.cboxPrize.Location = New System.Drawing.Point(169, 313)
        Me.cboxPrize.Name = "cboxPrize"
        Me.cboxPrize.Size = New System.Drawing.Size(154, 21)
        Me.cboxPrize.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Select Prize : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'PrizeRedemption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 386)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboxPrize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxCusID)
        Me.Controls.Add(Me.lklblPrizeRedemption)
        Me.Controls.Add(Me.lklblDeleteCustomer)
        Me.Controls.Add(Me.lklblEditCustomer)
        Me.Controls.Add(Me.lklblViewCustomer)
        Me.Controls.Add(Me.lklblAddCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCusName)
        Me.Name = "PrizeRedemption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrizeRedemption"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxCusID As System.Windows.Forms.ComboBox
    Friend WithEvents lklblPrizeRedemption As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblDeleteCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblEditCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblViewCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents lklblAddCustomer As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents cboxPrize As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

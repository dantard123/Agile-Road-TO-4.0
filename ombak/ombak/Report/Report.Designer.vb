<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblStaffID2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbGenerateReport = New System.Windows.Forms.GroupBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboxExceptionReport2 = New System.Windows.Forms.ComboBox()
        Me.cboxSummaryReport = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxExceptionReport = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxDetailReport = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxReportType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGenerateReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.Location = New System.Drawing.Point(12, 10)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(110, 65)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backButton.TabIndex = 94
        Me.backButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ombak.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(425, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(1120, 112)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffName.TabIndex = 98
        '
        'lblStaffID2
        '
        Me.lblStaffID2.AutoSize = True
        Me.lblStaffID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStaffID2.Location = New System.Drawing.Point(1120, 64)
        Me.lblStaffID2.Name = "lblStaffID2"
        Me.lblStaffID2.Size = New System.Drawing.Size(0, 29)
        Me.lblStaffID2.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(953, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Staff Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(995, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Staff ID : "
        '
        'gbGenerateReport
        '
        Me.gbGenerateReport.Controls.Add(Me.btnGenerate)
        Me.gbGenerateReport.Controls.Add(Me.btnCancel)
        Me.gbGenerateReport.Controls.Add(Me.cboxExceptionReport2)
        Me.gbGenerateReport.Controls.Add(Me.cboxSummaryReport)
        Me.gbGenerateReport.Controls.Add(Me.Label6)
        Me.gbGenerateReport.Controls.Add(Me.cboxExceptionReport)
        Me.gbGenerateReport.Controls.Add(Me.Label5)
        Me.gbGenerateReport.Controls.Add(Me.cboxDetailReport)
        Me.gbGenerateReport.Controls.Add(Me.Label4)
        Me.gbGenerateReport.Controls.Add(Me.cboxReportType)
        Me.gbGenerateReport.Controls.Add(Me.Label1)
        Me.gbGenerateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gbGenerateReport.Location = New System.Drawing.Point(197, 195)
        Me.gbGenerateReport.Name = "gbGenerateReport"
        Me.gbGenerateReport.Size = New System.Drawing.Size(970, 434)
        Me.gbGenerateReport.TabIndex = 99
        Me.gbGenerateReport.TabStop = False
        Me.gbGenerateReport.Text = "Generate Report"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(540, 378)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(130, 50)
        Me.btnGenerate.TabIndex = 11
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(676, 376)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 50)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboxExceptionReport2
        '
        Me.cboxExceptionReport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExceptionReport2.FormattingEnabled = True
        Me.cboxExceptionReport2.Items.AddRange(New Object() {"Top 1", "Top 2", "Top 3"})
        Me.cboxExceptionReport2.Location = New System.Drawing.Point(817, 190)
        Me.cboxExceptionReport2.Name = "cboxExceptionReport2"
        Me.cboxExceptionReport2.Size = New System.Drawing.Size(129, 39)
        Me.cboxExceptionReport2.TabIndex = 9
        '
        'cboxSummaryReport
        '
        Me.cboxSummaryReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSummaryReport.FormattingEnabled = True
        Me.cboxSummaryReport.Items.AddRange(New Object() {"Stock Availability Summary Report"})
        Me.cboxSummaryReport.Location = New System.Drawing.Point(282, 250)
        Me.cboxSummaryReport.Name = "cboxSummaryReport"
        Me.cboxSummaryReport.Size = New System.Drawing.Size(524, 39)
        Me.cboxSummaryReport.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Summary Report : "
        '
        'cboxExceptionReport
        '
        Me.cboxExceptionReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExceptionReport.FormattingEnabled = True
        Me.cboxExceptionReport.Items.AddRange(New Object() {"Top Prize Redemption Exception Report "})
        Me.cboxExceptionReport.Location = New System.Drawing.Point(282, 190)
        Me.cboxExceptionReport.Name = "cboxExceptionReport"
        Me.cboxExceptionReport.Size = New System.Drawing.Size(524, 39)
        Me.cboxExceptionReport.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Exception Report : "
        '
        'cboxDetailReport
        '
        Me.cboxDetailReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDetailReport.FormattingEnabled = True
        Me.cboxDetailReport.Items.AddRange(New Object() {"Existing Staff Detail Report", "Daily Sales Detail Report"})
        Me.cboxDetailReport.Location = New System.Drawing.Point(282, 130)
        Me.cboxDetailReport.Name = "cboxDetailReport"
        Me.cboxDetailReport.Size = New System.Drawing.Size(524, 39)
        Me.cboxDetailReport.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detail Report : "
        '
        'cboxReportType
        '
        Me.cboxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxReportType.FormattingEnabled = True
        Me.cboxReportType.Items.AddRange(New Object() {"Detail Report", "Exception Report", "Summary Report"})
        Me.cboxReportType.Location = New System.Drawing.Point(282, 70)
        Me.cboxReportType.Name = "cboxReportType"
        Me.cboxReportType.Size = New System.Drawing.Size(524, 39)
        Me.cboxReportType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Type : "
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument2
        '
        '
        'PrintDocument3
        '
        '
        'PrintDocument4
        '
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.gbGenerateReport)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.lblStaffID2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGenerateReport.ResumeLayout(False)
        Me.gbGenerateReport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents lblStaffID2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbGenerateReport As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboxReportType As System.Windows.Forms.ComboBox
    Friend WithEvents cboxDetailReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboxSummaryReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboxExceptionReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboxExceptionReport2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument4 As System.Drawing.Printing.PrintDocument
End Class

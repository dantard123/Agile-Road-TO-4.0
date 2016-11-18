Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Report

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        lblStaffID2.Text = GlobalUsername.Globalstaffid
        lblStaffName.Text = GlobalUsername.Globalstaffname
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub cboxReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxReportType.SelectedIndexChanged
        If cboxReportType.SelectedItem = "Detail Report" Then
            cboxDetailReport.Enabled = True
            cboxExceptionReport.Enabled = False
            cboxExceptionReport2.Enabled = False
            cboxSummaryReport.Enabled = False
        ElseIf cboxReportType.SelectedItem = "Exception Report" Then
            cboxDetailReport.Enabled = False
            cboxExceptionReport.Enabled = True
            cboxExceptionReport2.Enabled = True
            cboxSummaryReport.Enabled = False
        Else
            cboxDetailReport.Enabled = False
            cboxExceptionReport.Enabled = False
            cboxExceptionReport2.Enabled = False
            cboxSummaryReport.Enabled = True
        End If
        cboxDetailReport.SelectedIndex = -1
        cboxExceptionReport.SelectedIndex = -1
        cboxExceptionReport2.SelectedIndex = -1
        cboxSummaryReport.SelectedIndex = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboxReportType.SelectedIndex = -1
        cboxDetailReport.SelectedIndex = -1
        cboxExceptionReport.SelectedIndex = -1
        cboxExceptionReport2.SelectedIndex = -1
        cboxSummaryReport.SelectedIndex = -1
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cboxReportType.SelectedItem = "Detail Report" Then
            If cboxDetailReport.SelectedItem = "Existing Staff Detail Report" Then
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.ShowDialog(Me)
            ElseIf cboxDetailReport.SelectedItem = "Daily Sales Detail Report" Then
                PrintPreviewDialog1.Document = PrintDocument2
                PrintPreviewDialog1.ShowDialog(Me)
            Else
                MessageBox.Show("Please select the detail report!")
            End If
        ElseIf cboxReportType.SelectedItem = "Exception Report" Then
            If cboxExceptionReport.SelectedItem = "" Or cboxExceptionReport2.SelectedItem = "" Then
                MessageBox.Show("Please select the exception report!")
            Else
                PrintPreviewDialog1.Document = PrintDocument3
                PrintPreviewDialog1.ShowDialog(Me)
            End If
        ElseIf cboxReportType.SelectedItem = "Summary Report" Then
            If cboxSummaryReport.SelectedItem = "" Then
                MessageBox.Show("Please select the summary report!")

            Else
                PrintPreviewDialog1.Document = PrintDocument4
                PrintPreviewDialog1.ShowDialog(Me)
            End If
        Else
            MessageBox.Show("Please select the report type!")
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontSubFooter As New Font("Calibri", 12)

        Dim header As String = "Existing Staff Detail Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim subHeader2 As String = String.Format("Version 1")
        Dim subHeader3 As String = String.Format("Page 1")

        Dim body As New StringBuilder
        body.AppendLine("Staff ID    Staff Name        Staff IC         Position    Contact         Email")
        body.AppendLine("----------------------------------------------------------------------------------------------------")

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Staff"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                body.AppendFormat("{0,-10}  {1,-15}   {2,-15}  {3,-10}  {4,-15} {5,-20}" & vbNewLine, dtr("StaffID").ToString(), dtr("StaffName").ToString(), dtr("StaffIC").ToString(), dtr("StaffPosition").ToString(), dtr("StaffContact").ToString(), dtr("StaffEmail").ToString())
            End While
        End If
        dtr.Close()
        conn.Close()

        With e.Graphics
            .DrawImage(My.Resources.logo, 320, 0, 180, 115)
            .DrawString(header, fontHeader, Brushes.Purple, 180, 90)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 130)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 20, 180)
            .DrawString(subHeader2, fontSubFooter, Brushes.Black, 700, 130)
            .DrawString(subHeader3, fontSubFooter, Brushes.Black, 700, 1100)
        End With
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontSubFooter As New Font("Calibri", 12)

        Dim header As String = "Daily Sales Detail Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim subHeader2 As String = String.Format("Version 1")
        Dim subHeader3 As String = String.Format("Page 1")

        Dim body As New StringBuilder
        body.AppendLine("Payment ID     Member ID      Payment Date        Total Amount(RM)")
        body.AppendLine("----------------------------------------------------------------------------------------------------")

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Payment Where PaymentDate = @PaymentDate"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
        cmdSelect.Parameters.AddWithValue("@PaymentDate", DateTime.Now.ToString("dd/MM/yyyy"))

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                body.AppendFormat("{0,-10}     {1,-10}     {2,-15}     {3,-15}" & vbNewLine, dtr("PaymentID").ToString(), dtr("MemberID").ToString(), dtr("PaymentDate").ToString(), dtr("TotalAmount").ToString())
            End While
        End If
        dtr.Close()
        conn.Close()

        With e.Graphics
            .DrawImage(My.Resources.logo, 320, 0, 180, 115)
            .DrawString(header, fontHeader, Brushes.Purple, 180, 90)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 130)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 20, 180)
            .DrawString(subHeader2, fontSubFooter, Brushes.Black, 700, 130)
            .DrawString(subHeader3, fontSubFooter, Brushes.Black, 700, 1100)
        End With
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontSubFooter As New Font("Calibri", 12)

        Dim header As String = String.Format("{0} Prize Redemption Exception Report", cboxExceptionReport2.SelectedItem)
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim subHeader2 As String = String.Format("Version 1")
        Dim subHeader3 As String = String.Format("Page 1")

        Dim body As New StringBuilder
        body.AppendLine("Prize Name                    Prize Point(Per Unit)        Prize Quantity         ")
        body.AppendLine("----------------------------------------------------------------------------------------------------")

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select " & cboxExceptionReport2.SelectedItem & " count(PrizeName) as 'PrizeQuantity', PrizeName, PrizePoint From Redeem GROUP BY PrizeName, PrizePoint ORDER BY PrizeQuantity DESC"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                body.AppendFormat("{0,-30}{1,-20}         {2,-10}  " & vbNewLine, dtr("PrizeName").ToString(), dtr("PrizePoint").ToString(), dtr("PrizeQuantity").ToString())
            End While
        End If
        dtr.Close()
        conn.Close()

        With e.Graphics
            .DrawImage(My.Resources.logo, 320, 0, 180, 115)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 90)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 130)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 20, 180)
            .DrawString(subHeader2, fontSubFooter, Brushes.Black, 700, 130)
            .DrawString(subHeader3, fontSubFooter, Brushes.Black, 700, 1100)
        End With
    End Sub

    Private Sub PrintDocument4_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)
        Dim fontSubFooter As New Font("Calibri", 12)

        Dim header As String = "Stock Availability Summary Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim subHeader2 As String = String.Format("Version 1")
        Dim subHeader3 As String = String.Format("Page 1")

        Dim body As New StringBuilder
        body.AppendLine("Product ID     Product Name                     Product Brand      Quantity     Supplier ID")
        body.AppendLine("----------------------------------------------------------------------------------------------------")

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Product"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                body.AppendFormat("{0,-10}     {1,-28}     {2,-15}     {3,-10}  {4,-10}" & vbNewLine, dtr("ProductID").ToString(), dtr("ProductName").ToString(), dtr("ProductBrand").ToString(), dtr("QuantityAvailable").ToString(), dtr("SupplierID").ToString())
            End While
        End If
        dtr.Close()
        conn.Close()

        With e.Graphics
            .DrawImage(My.Resources.logo, 320, 0, 180, 115)
            .DrawString(header, fontHeader, Brushes.Purple, 150, 90)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 130)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 20, 180)
            .DrawString(subHeader2, fontSubFooter, Brushes.Black, 700, 130)
            .DrawString(subHeader3, fontSubFooter, Brushes.Black, 700, 1100)
        End With
    End Sub
End Class
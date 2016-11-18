Imports System.Configuration
Imports System.Data.SqlClient

Public Class AdminFunction

    Private Sub AdminFunction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub refreshDGV()
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim dt As New DataTable
        dt.Clear()
        Dim da As New SqlDataAdapter
        Dim sqlCom As New SqlCommand("Select * from PaymentDetail Where PaymentID=@PaymentID", conn)
        sqlCom.Parameters.AddWithValue("@PaymentID", txtPaymentID.Text)
        da.SelectCommand = sqlCom
        da.Fill(dt)
        DGV.DataSource = dt
        conn.Close()
        setReadOnly()
    End Sub

    Sub setReadOnly()
        DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
        DGV.Columns(6).ReadOnly = True
        DGV.Columns(7).ReadOnly = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        refreshDGV()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Dim result = MessageBox.Show("Delete the selected item?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Dim conn As New SqlConnection
            Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ToString()
            conn = New SqlConnection(connstr)
            conn.Open()
            Try
                Dim strSelect As String = "Delete From PaymentDetail Where PaymentDetailID=@PaymentDetailID"
                Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)
                cmdSelect.Parameters.AddWithValue("@PaymentDetailID", DGV.Rows(e.RowIndex).Cells(0).Value)
                cmdSelect.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Failed to Delete")
            End Try
            conn.Close()
            refreshDGV()
        End If
    End Sub

    Private Sub DGV_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString()
        conn = New SqlConnection(connstr)
        conn.Open()
        Try
            Dim strInsert As String = "Update PaymentDetail Set SubTotal=@SubTotal, Quantity=@Quantity Where ProductName=@ProductName"
            Dim cmdInsert As New SqlCommand(strInsert, conn)
            cmdInsert.Parameters.AddWithValue("@ProductName", DGV.Rows(e.RowIndex).Cells(6).Value)
            cmdInsert.Parameters.AddWithValue("@SubTotal", FormatNumber((Double.Parse(DGV.Rows(e.RowIndex).Cells(4).Value) * DGV.Rows(e.RowIndex).Cells(3).Value), 2))
            cmdInsert.Parameters.AddWithValue("@Quantity", DGV.Rows(e.RowIndex).Cells(3).Value)
            cmdInsert.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Failed Update the Value!")
        End Try
        conn.Close()
        If DGV.IsCurrentRowDirty Then
            refreshDGV()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
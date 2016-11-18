Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Text

Public Class Staff

    Public Sub SetID()
        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()
        Dim strSelect As String = "Select * From Staff"
        Dim cmdSelect As SqlCommand = New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then
            While dtr.Read
                Dim staffid As Integer = dtr("StaffId").ToString() + 1
                lblStaffid.Text = staffid.ToString()
            End While
        Else
            lblStaffid.Text = "1000"
        End If

        conn.Close()
        dtr.Close()
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        lblStaffID2.Text = GlobalUsername.Globalstaffid
        lblStaffName.Text = GlobalUsername.Globalstaffname

        readStaffID()
        updateStaffID()
        deleteStaffID()
        ReloadComboBox()

        txtAddStaffName.Focus()
        cbAddStaffPosition.SelectedItem = 0
        cbAddAreaCode.SelectedItem = 0
        cbAddEmailType.SelectedItem = 0

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()
        SetID()
    End Sub

    Public Sub ReloadComboBox()
        cbReadStaffID.Items.Clear()
        cbUpdateStaffID.Items.Clear()
        cbDeleteStaffId.Items.Clear()

        Dim conn As New SqlConnection
        Dim connstr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conn = New SqlConnection(connstr)
        conn.Open()

        Dim strSelect As String = "Select * From Staff Order By StaffId"
        Dim cmdSelect As New SqlCommand(strSelect, conn)

        Dim dtr As SqlDataReader = cmdSelect.ExecuteReader()

        If dtr.HasRows Then

            While dtr.Read
                cbReadStaffID.Items.Add(dtr("StaffId").ToString())
                cbUpdateStaffID.Items.Add(dtr("StaffId").ToString())
                cbDeleteStaffId.Items.Add(dtr("StaffId").ToString())
            End While
        End If
        conn.Close()
        dtr.Close()
    End Sub

    'Add Button Event
    Private Sub btnStaffAdd_Click(sender As Object, e As EventArgs) Handles btnStaffAdd.Click

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim name As String = txtAddStaffName.Text.Trim()
        Dim ic As String = txtAddStaffICs.Text.Trim()
        Dim contact1 As String = cbAddAreaCode.SelectedItem
        Dim contact2 As String = txtAddStaffContactNumber.Text.Trim()
        Dim position As String = cbAddStaffPosition.SelectedItem
        Dim email1 As String = txtAddStaffEmailAddress.Text.Trim()
        Dim email2 As String = cbAddEmailType.SelectedItem
        Dim homeaddress As String = txtAddStaffAddress.Text.Trim()
        Dim username As String = txtUserName.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If name = "" Then
            err.AppendLine("- Name Cannot Be Empty!")
            ctr = If(ctr, txtAddStaffName)
        End If
        If ic = "" Or Not IsNumeric(ic) Or ic.Length <> 12 Then
            err.AppendLine("- Invalid customer IC, must be 12 digits!")
            ctr = If(ctr, txtAddStaffICs)
        End If
        If contact1 = "" Then
            err.AppendLine("- Invalid contact number, must be 10 or 11 digits!")
            ctr = If(ctr, cbAddAreaCode)
        End If
        If contact2 = "" Or Not IsNumeric(contact2) Or contact2.Length <> 7 And contact2.Length <> 8 Then
            err.AppendLine("- Invalid contact number, must be 10 or 11 digits!")
            ctr = If(ctr, txtAddStaffContactNumber)
        End If
        If position = "" Then
            err.AppendLine("- Invalid Position!")
            ctr = If(ctr, cbAddStaffPosition)
        End If
        If email1 = "" Or email2 = "" Then
            err.AppendLine("- Invalid Email Address!")
            ctr = If(ctr, txtAddStaffEmailAddress)
            ctr = If(ctr, cbAddEmailType)
        End If
        If homeaddress = "" Then
            err.AppendLine("- Home Address Cannot Be Empty")
            ctr = If(ctr, txtAddStaffAddress)
        End If
        If username = "" Then
            err.AppendLine("- Username Cannot Be Empty")
            ctr = If(ctr, txtUserName)
        End If
        If password = "" Then
            err.AppendLine("- Password Cannot Be Empty")
            ctr = If(ctr, txtPassword)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        'Insert Function
        Dim gender As String = Nothing
        If rdMale.Checked Then
            gender = rdMale.Text
        ElseIf rdFemale.Checked Then
            gender = rdFemale.Text
        End If
        Try
            Dim conStaff As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Dim cmdInsert As New System.Data.SqlClient.SqlCommand
            cmdInsert.CommandType = System.Data.CommandType.Text
            cmdInsert.CommandText = "INSERT INTO dbo.Staff (StaffName,StaffIC,StaffGender,StaffPosition,StaffContact,StaffEmail,StaffAddress,UserName,Password,Photo) VALUES (@Staff_Name, @Staff_IC, @Staff_Gender, @Staff_Position, @Staff_Contact, @Staff_Email, @Staff_Address, @UserName, @Password, @Photo)"
            cmdInsert.Connection = conStaff
            conStaff.Open()
            cmdInsert.Parameters.AddWithValue("@Staff_Name", Me.txtAddStaffName.Text)
            cmdInsert.Parameters.AddWithValue("@Staff_IC", txtAddStaffICs.Text)
            cmdInsert.Parameters.AddWithValue("@Staff_Gender", gender)
            cmdInsert.Parameters.AddWithValue("@Staff_Position", Me.cbAddStaffPosition.Text)
            cmdInsert.Parameters.AddWithValue("@Staff_Contact", Me.cbAddAreaCode.SelectedItem + "-" + Me.txtAddStaffContactNumber.Text)
            cmdInsert.Parameters.AddWithValue("@Staff_Email", Me.txtAddStaffEmailAddress.Text + Me.cbAddEmailType.SelectedItem)
            cmdInsert.Parameters.AddWithValue("@Staff_Address", Me.txtAddStaffAddress.Text)
            cmdInsert.Parameters.AddWithValue("@UserName", Me.txtUserName.Text)
            cmdInsert.Parameters.AddWithValue("@Password", Me.txtPassword.Text)

            'Insert Image
            Dim ms As New MemoryStream()
            pbAddProfilePicture.Image.Save(ms, pbAddProfilePicture.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = data
            cmdInsert.Parameters.Add(p)


            cmdInsert.ExecuteNonQuery()
            SetID()
            readStaffID()
            updateStaffID()
            deleteStaffID()

            MessageBox.Show("New Record has been saved", "Save", MessageBoxButtons.OK)

            txtAddStaffName.Text = ""
            rdFemale.Checked = False
            rdMale.Checked = True
            txtAddStaffICs.Text = ""
            cbAddStaffPosition.Text = ""
            cbAddAreaCode.Text = ""
            txtAddStaffContactNumber.Text = ""
            txtAddStaffEmailAddress.Text = ""
            cbAddEmailType.Text = ""
            txtAddStaffAddress.Text = ""
            txtUserName.Text = ""
            txtPassword.Text = ""
            cbAddStaffPosition.Text = ""
            pbAddProfilePicture.Image = Nothing

            conStaff.Close()
        Catch ex As Exception
            MsgBox("Please Upload Staff's Profile Picture", MsgBoxStyle.Critical)
        End Try

    End Sub


    Sub readStaffID()

        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Dim strSelect As String
        Dim cmdSelect As SqlCommand
        strSelect = "Select * From Staff"
        cmdSelect = New SqlCommand(strSelect, conStaff)
        Dim dtr As SqlDataReader
        dtr = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                cbReadStaffID.Items.Add(dtr("StaffId").ToString())
            End While
        End If
        conStaff.Close()
        dtr.Close()
        ReloadComboBox()
    End Sub

    Sub updateStaffID()

        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Dim strSelect As String = "Select * From Staff"
        Dim cmdSelect As SqlCommand
        cmdSelect = New SqlCommand(strSelect, conStaff)


        Dim dtr As SqlDataReader
        dtr = cmdSelect.ExecuteReader()
        If dtr.HasRows Then

            While dtr.Read
                If cbUpdateStaffID.SelectedItem = dtr("StaffId").ToString() Then
                    lblUpdateStaffNames.Text = dtr("StaffName").ToString()
                    lblUpdateStaffICs.Text = dtr("StaffIC").ToString()
                    lblUpdateStaffGenders.Text = dtr("StaffGender").ToString()
                    cbUpdateStaffPositions.Text = dtr("StaffPosition").ToString()
                    txtUpdateStaffContacts.Text = dtr("StaffContact").ToString()
                    txtUpdateStaffEmails.Text = dtr("StaffEmail").ToString()
                    txtUpdateStaffAddresses.Text = dtr("StaffAddress").ToString()
                    Dim data As Byte() = DirectCast(dtr("Photo"), Byte())
                    Dim ms As New MemoryStream(data)
                    pbUpdateProfilePicture.Image = Image.FromStream(ms)
                End If
            End While
        End If

        conStaff.Close()
        dtr.Close()

    End Sub

    Private Sub cbUpdateStaffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUpdateStaffID.SelectedIndexChanged
        updateStaffID()

    End Sub

    Sub deleteStaffID()
        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Dim strSelect As String
        Dim cmdSelect As SqlCommand
        strSelect = "Select * From Staff "
        cmdSelect = New SqlCommand(strSelect, conStaff)

        Dim dtr As SqlDataReader
        dtr = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read
                If cbDeleteStaffId.SelectedItem = dtr("StaffId").ToString() Then
                    lblDeleteStaffNames.Text = dtr("StaffName").ToString()
                    lblDeleteStaffICs.Text = dtr("StaffIC").ToString()
                    lblDeleteStaffGenders.Text = dtr("StaffGender").ToString()
                    lblDeleteStaffPositions.Text = dtr("StaffPosition").ToString()
                    lblDeleteStaffcontact.Text = dtr("StaffContact").ToString()
                    lblDeleteStaffEmails.Text = dtr("StaffEmail").ToString()
                    lblDeleteStaffAddresses.Text = dtr("StaffAddress").ToString()
                    Dim data As Byte() = DirectCast(dtr("Photo"), Byte())
                    Dim ms As New MemoryStream(data)
                    pbDeleteProfilePicture.Image = Image.FromStream(ms)
                End If
            End While
        Else
        End If
        conStaff.Close()
    End Sub

    Private Sub cbDeleteStaffId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDeleteStaffId.SelectedIndexChanged
        deleteStaffID()
    End Sub

    Private Sub txtCancelUpdateStaff_Click(sender As Object, e As EventArgs)
        cbUpdateStaffID.Text = ""
        lblUpdateStaffNames.Text = ""
        lblUpdateStaffICs.Text = ""
        lblUpdateStaffGenders.Text = ""
        cbUpdateStaffPositions.Text = ""
        txtUpdateStaffContacts.Text = ""
        txtUpdateStaffEmails.Text = ""
        txtUpdateStaffAddresses.Text = ""
        pbUpdateProfilePicture.Image = Nothing
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Me.Refresh()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Me.Refresh()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Me.Refresh()
    End Sub
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        Me.Refresh()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub btnStaffCancel_Click(sender As Object, e As EventArgs) Handles btnStaffCancel.Click
        txtAddStaffName.Text = ""
        rdMale.Checked = True
        rdFemale.Checked = False
        txtAddStaffICs.Text = ""
        cbAddStaffPosition.SelectedIndex = -1
        cbAddAreaCode.SelectedIndex = -1
        txtAddStaffContactNumber.Text = ""
        txtAddStaffEmailAddress.Text = ""
        cbAddEmailType.SelectedIndex = -1
        txtAddStaffAddress.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        pbAddProfilePicture.Image = Nothing
    End Sub

    Private Sub btnAddBrowse_Click(sender As Object, e As EventArgs) Handles btnAddBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp"
        OpenFileDialog1.ShowDialog()
        pbAddProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnCancelStaff_Click(sender As Object, e As EventArgs) Handles btnCancelStaff.Click
        cbReadStaffID.Text = ""
        lblReadStaffNames.Text = ""
        lblReadStaffICs.Text = ""
        lblReadStaffGenders.Text = ""
        lblReadStaffPositions.Text = ""
        lblReadStaffContacts.Text = ""
        lblReadStaffEmails.Text = ""
        lblReadStaffAddresses.Text = ""
        pbReadProfilePicture.Image = Nothing
    End Sub

    Private Sub btnReadStaff_Click(sender As Object, e As EventArgs) Handles btnReadStaff.Click
        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Dim strSelect As String
        Dim cmdSelect As SqlCommand
        strSelect = "Select * From Staff"
        cmdSelect = New SqlCommand(strSelect, conStaff)
        Dim dtr As SqlDataReader
        dtr = cmdSelect.ExecuteReader()
        If dtr.HasRows Then
            While dtr.Read

                If cbReadStaffID.SelectedItem = dtr("StaffId").ToString() Then
                    lblReadStaffNames.Text = dtr("StaffName").ToString()
                    lblReadStaffICs.Text = dtr("StaffIC").ToString()
                    lblReadStaffGenders.Text = dtr("StaffGender").ToString()
                    lblReadStaffPositions.Text = dtr("StaffPosition").ToString()
                    lblReadStaffContacts.Text = dtr("StaffContact").ToString()
                    lblReadStaffEmails.Text = dtr("StaffEmail").ToString()
                    lblReadStaffAddresses.Text = dtr("StaffAddress").ToString()
                    Dim data As Byte() = DirectCast(dtr("Photo"), Byte())
                    Dim ms As New MemoryStream(data)
                    pbReadProfilePicture.Image = Image.FromStream(ms)
                End If
            End While
        Else
        End If
        conStaff.Close()
        dtr.Close()
        ReloadComboBox()
    End Sub

    Private Sub btnCancelUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateStaff.Click
        cbUpdateStaffID.Text = ""
        lblUpdateStaffNames.Text = ""
        lblUpdateStaffICs.Text = ""
        lblUpdateStaffGenders.Text = ""
        cbUpdateStaffPositions.Text = ""
        txtUpdateStaffContacts.Text = ""
        txtUpdateStaffEmails.Text = ""
        txtUpdateStaffAddresses.Text = ""
        pbUpdateProfilePicture.Image = Nothing
    End Sub

    Private Sub btnStaffUpdate_Click(sender As Object, e As EventArgs) Handles btnStaffUpdate.Click
        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Try
            Dim strSelect As String
            Dim cmdSelect As SqlCommand
            strSelect = "Update dbo.Staff Set StaffName = @Staff_Name, StaffIC = @Staff_IC, StaffGender = @Staff_Gender, StaffPosition = @Staff_Position, StaffContact = @Staff_Contact, StaffEmail = @Staff_Email, StaffAddress = @Staff_Address, Photo = @Photo Where StaffId = @Staff_ID"
            cmdSelect = New SqlCommand(strSelect, conStaff)
            cmdSelect.Parameters.AddWithValue("@Staff_Name", lblUpdateStaffNames.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_IC", lblUpdateStaffICs.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_Gender", lblUpdateStaffGenders.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_Position", cbUpdateStaffPositions.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_Contact", txtUpdateStaffContacts.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_Email", txtUpdateStaffEmails.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_Address", txtUpdateStaffAddresses.Text)
            cmdSelect.Parameters.AddWithValue("@Staff_ID", cbUpdateStaffID.Text)
            'Insert Image
            Dim ms As New MemoryStream()
            pbUpdateProfilePicture.Image.Save(ms, pbUpdateProfilePicture.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@Photo", SqlDbType.Image)
            p.Value = data
            cmdSelect.Parameters.Add(p)
            cmdSelect.ExecuteNonQuery()
            MsgBox("Record Updated Successfully")

            lblUpdateStaffNames.Text = ""
            lblUpdateStaffICs.Text = ""
            lblUpdateStaffGenders.Text = ""
            cbUpdateStaffPositions.Text = ""
            txtUpdateStaffContacts.Text = ""
            txtUpdateStaffEmails.Text = ""
            txtUpdateStaffAddresses.Text = ""
            cbUpdateStaffID.Text = ""
            pbUpdateProfilePicture.Image = Nothing
        Catch ex As Exception
            MsgBox("Update Fail", MsgBoxStyle.Critical)
        End Try
        conStaff.Close()
        ReloadComboBox()
    End Sub

    Private Sub btnUpdateBrowse_Click(sender As Object, e As EventArgs) Handles btnUpdateBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp"
        OpenFileDialog1.ShowDialog()
        pbUpdateProfilePicture.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnCancelDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnCancelDeleteStaff.Click
        cbDeleteStaffId.Text = ""
        lblDeleteStaffNames.Text = ""
        lblDeleteStaffICs.Text = ""
        lblDeleteStaffGenders.Text = ""
        lblDeleteStaffPositions.Text = ""
        lblDeleteStaffcontact.Text = ""
        lblDeleteStaffEmails.Text = ""
        lblDeleteStaffAddresses.Text = ""
        pbDeleteProfilePicture.Image = Nothing
    End Sub

    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        Dim conStaff As New SqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("Ombakconn").ConnectionString
        conStaff = New SqlConnection(connStr)
        conStaff.Open()
        Dim strSelect As String
        Dim cmdSelect As SqlCommand
        strSelect = "Delete Staff where StaffId=@StaffID"
        cmdSelect = New SqlCommand(strSelect, conStaff)
        cmdSelect.Parameters.AddWithValue("@StaffID", SqlDbType.Int).Value = cbDeleteStaffId.SelectedItem

        Dim Box As MsgBoxResult = MsgBox("Do you sure you want to delete it?", MsgBoxStyle.YesNo)

        If Box = MsgBoxResult.Yes Then

            cmdSelect.ExecuteNonQuery()
            ReloadComboBox()
            MessageBox.Show("Details deleted successfully!")
            cbDeleteStaffId.Text = ""
            lblDeleteStaffNames.Text = ""
            lblDeleteStaffICs.Text = ""
            lblDeleteStaffGenders.Text = ""
            lblDeleteStaffPositions.Text = ""
            lblDeleteStaffcontact.Text = ""
            lblDeleteStaffEmails.Text = ""
            lblDeleteStaffAddresses.Text = ""
            pbDeleteProfilePicture.Image = Nothing
        End If
        conStaff.Close()

    End Sub
End Class


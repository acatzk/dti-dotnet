Imports System.Data.SqlClient
Imports System.IO
Public Class Search_Employee


    Dim sdr As SqlDataReader
    Private Sub btnEmploDetails_Update_Click(sender As Object, e As EventArgs) Handles btnEmploDetails_Update.Click
        ToolsEnableTrue()
    End Sub

    Private Sub btnEmploDetails_Browse_Click(sender As Object, e As EventArgs) Handles btnEmploDetails_Browse.Click
        'sa pag browse sa image
        Connection()


        Try

            Photoss.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif| All Files(*.*)|*.*"
            Photoss.Title = "Select Employee Picture"
            If Photoss.ShowDialog() = Windows.Forms.DialogResult.OK Then
                imgloc = Photoss.FileName.ToString()
                picEmployeeDetailsShow.ImageLocation = imgloc

            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub btnEmployeeDetails_Save_Click(sender As Object, e As EventArgs) Handles btnEmployeeDetails_Save.Click

        Try
            If isUPDATE("Employee_tbl",
                                    "Lastname = '" & txtEmploDetails_Lastname.Text &
                                  "' , Firstname = '" & txtEmploDetails_Firstname.Text &
                                  "' , Middle_Name = '" & txtEmploDetails_MI.Text &
                                    "' , Gender = '" & cmbxEmploDetails_Gender.Text &
                                    "', Position = '" & txtEmploDetails_Position.Text &
                                    "', Rank = '" & cmbxEmploDetails_Rank.Text &
                                    "', TypeOfAccount = '" & cmbxEmploDetails_TypeOfAccount.Text &
                                    "'",
                                        "ID_Number = '" & lblID_number.Text & "'") Then
                MsgBox("Information Update", MsgBoxStyle.Information, "Successful")
                ToolsEnableFalse() ' -- FOR ENABLE TO CLICK THE UPDATED EMPLOYEES DETAILS
            End If
           
        Catch ex As Exception

        End Try

        UpdateImage()

    End Sub


    Private Sub UpdateImage()
        Connection()

        Try
            con.Open()
            Using cmd As New SqlClient.SqlCommand("UPDATE Employee_tbl SET Photo = @Photoss where ID_Number = '" & lblID_number.Text & "'", con)
                cmd.Parameters.Add(New SqlClient.SqlParameter("@Photoss", SqlDbType.Image)).Value = IO.File.ReadAllBytes(Photoss.FileName)
                imgloc = cmd.ExecuteNonQuery
            End Using
            If (imgloc > 0) Then

            End If
            con.Close()
        Catch ex As Exception

        End Try
        
    End Sub

#Region "BACK TO DEFAULT TOOLBOX"
    Sub backDefault()
        txtEmploDetails_Firstname.Enabled = False
        txtEmploDetails_Lastname.Enabled = False
        txtEmploDetails_MI.Enabled = False
        cmbxEmploDetails_Gender.Enabled = False
        cmbxEmploDetails_Rank.Enabled = False
        txtEmploDetails_Position.Enabled = False
        cmbxEmploDetails_TypeOfAccount.Enabled = False
        picEmployeeDetailsShow.Image = Nothing


        txtEmploDetails_Firstname.Text = ""
        txtEmploDetails_Lastname.Text = ""
        txtEmploDetails_MI.Text = ""
        cmbxEmploDetails_Gender.SelectedIndex = -1
        txtEmploDetails_Position.Text = ""
        cmbxEmploDetails_TypeOfAccount.SelectedIndex = -1
        cmbxEmploDetails_Rank.Text = ""

        btnEmploDetails_Update.Enabled = False
        btnEmployeeDetails_Save.Enabled = False
        btnEmploDetails_Browse.Enabled = False
    End Sub
#End Region

    Private Sub txtSearch_OnTextChange(sender As Object, e As EventArgs) Handles txtSearch.OnTextChange
        Connection()

        Try
            If txtSearch.text.Length = 0 Then
                backDefault()
            Else
                con.Open()
                Dim query As String
                query = String.Format("SELECT * FROM Employee_tbl WHERE ID_number LIKE ('%" & txtSearch.text & "%') OR Firstname LIKE ('%" & txtSearch.text & "%') OR Lastname LIKE ('%" & txtSearch.text & "%')")
                cmd = New SqlCommand(query, con)
                sdr = cmd.ExecuteReader

                If Not sdr Is Nothing Then
                    sdr.Read()

                    Dim data As Byte() = DirectCast(sdr("Photo"), Byte())
                    Dim ms As New MemoryStream(data)
                    picEmployeeDetailsShow.Image = Image.FromStream(ms)

                    lblID_number.Text = sdr("ID_Number").ToString()
                    txtEmploDetails_Lastname.Text = sdr("Lastname").ToString()
                    txtEmploDetails_Firstname.Text = sdr("Firstname").ToString()
                    txtEmploDetails_MI.Text = sdr("Middle_Name").ToString()
                    cmbxEmploDetails_Gender.Text = sdr("Gender").ToString()
                    txtEmploDetails_Position.Text = sdr("Position").ToString()
                    cmbxEmploDetails_TypeOfAccount.Text = sdr("TypeOfAccount").ToString()
                    cmbxEmploDetails_Rank.Text = sdr("Rank").ToString()
                    btnEmploDetails_Update.Enabled = True
                Else
                    btnEmploDetails_Update.Enabled = False
                End If
                con.Close()
            End If
        Catch ex As Exception

        Finally
            con.Dispose()
        End Try

    End Sub


    Sub ToolsEnableTrue()
        txtEmploDetails_Firstname.Enabled = True
        txtEmploDetails_Lastname.Enabled = True
        txtEmploDetails_MI.Enabled = True
        txtEmploDetails_Position.Enabled = True
        cmbxEmploDetails_TypeOfAccount.Enabled = True
        btnEmployeeDetails_Save.Enabled = True
        btnEmploDetails_Browse.Enabled = True
        cmbxEmploDetails_Gender.Enabled = True
        cmbxEmploDetails_Rank.Enabled = True
    End Sub

    Sub ToolsEnableFalse()
        txtEmploDetails_Firstname.Enabled = False
        txtEmploDetails_Lastname.Enabled = False
        txtEmploDetails_MI.Enabled = False
        cmbxEmploDetails_Gender.Enabled = False
        txtEmploDetails_Position.Enabled = False
        cmbxEmploDetails_TypeOfAccount.Enabled = False
        btnEmployeeDetails_Save.Enabled = False
        btnEmploDetails_Browse.Enabled = False
        cmbxEmploDetails_Rank.Enabled = False
    End Sub

End Class

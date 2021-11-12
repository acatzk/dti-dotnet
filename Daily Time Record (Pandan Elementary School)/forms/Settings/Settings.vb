Imports System.Data.SqlClient
Imports System.IO

Public Class Settings


    Dim sda As SqlDataAdapter
    Dim sdr As SqlDataReader
    Dim dt As DataTable


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeInformation()
    End Sub

    Public Sub EmployeeInformation()
        Connection()


        Try
            con.Open()

            Dim query As String
            query = "SELECT ID_Number, Password, Lastname, Firstname, Middle_Name, Rank, TypeOfAccount FROM Employee_tbl"
            cmd = New SqlCommand(query, con)

            dt = New DataTable
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)

            dataGridEmployee.DataSource = dt
            dataGridEmployee.Refresh()

            lblCount.Text = "Number of Employees : " + dt.Rows.Count.ToString()


            con.Close()
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            con.Dispose()
        End Try
    End Sub



    Private Sub dataGridLSummaryLog_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridEmployee.CellClick
        con = New SqlConnection
        con.ConnectionString = conString()


        Try
            con.Open()
            Dim query As String
            query = "SELECT Photo FROM Employee_tbl WHERE ID_Number = '" & dataGridEmployee.Rows(e.RowIndex).Cells(0).Value & "'"
            cmd = New SqlCommand(query, con)

            Dim ms As New MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            picShow.Image = Image.FromStream(ms)
            picShow.SizeMode = PictureBoxSizeMode.StretchImage

            Dim n As Integer
            n = dataGridEmployee.SelectedRows(0).Index
            lblIDnumber1.Text = dataGridEmployee.Rows(n).Cells(0).Value.ToString()
            lblPassword1.Text = dataGridEmployee.Rows(n).Cells(1).Value.ToString()
            lblLastname1.Text = dataGridEmployee.Rows(n).Cells(2).Value.ToString()
            lblFirstname1.Text = dataGridEmployee.Rows(n).Cells(3).Value.ToString()
            lblMiddlename1.Text = dataGridEmployee.Rows(n).Cells(4).Value.ToString()
            lblRank2.Text = dataGridEmployee.Rows(n).Cells(5).Value.ToString()
            lblTypeOfAccount.Text = dataGridEmployee.Rows(n).Cells(6).Value.ToString()

            con.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        EmployeeInformation()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecords()
    End Sub

    Private Sub DeleteRecords()
        con = New SqlConnection
        con.ConnectionString = conString()

        Try





            Dim dialog As DialogResult = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "Yes/No")
            If dialog = Windows.Forms.DialogResult.Yes Then
                If isDELETE("AttendanceRecords_tbl", "ID_Number = '" & dataGridEmployee.CurrentRow.Cells(0).Value & "'") Then

                End If
                If isDELETE("Employee_tbl", "ID_Number = '" & dataGridEmployee.CurrentRow.Cells(0).Value & "'") Then
                    EmployeeInformation() ' -- Refresh the datagrid
                    Clear() ' -- For the deleting of quickview details 
                End If
                MsgBox("Deleted Successfully", MsgBoxStyle.Information, "Successful")
            Else
                Return
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub Clear()
        lblIDnumber1.Text = ""
        lblPassword1.Text = ""
        lblFirstname1.Text = ""
        lblLastname1.Text = ""
        lblMiddlename1.Text = ""
        lblRank2.Text = ""
        lblTypeOfAccount.Text = ""
    End Sub

    Private Sub txtSearchEm_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearchEm.OnValueChanged
        Try

            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("Firstname LIKE  ('%" & txtSearchEm.Text & "%') OR Lastname LIKE ('%" & txtSearchEm.Text & "%') OR ID_Number LIKE ('%" & txtSearchEm.Text & "%') ")
            dataGridEmployee.DataSource = dv

        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditRecords()
    End Sub

    Private Sub EditRecords()
        con = New SqlConnection
        con.ConnectionString = conString()

        Try
            If lblIDnumber1.Text.Length = 0 Then
                MsgBox("Please select an Employee", MsgBoxStyle.Exclamation, "Opps!!")
            Else
                Dim edite As New Edit()
                edite.lblI.Text = dataGridEmployee.CurrentRow.Cells(0).Value.ToString()
                edite.txtPass.Text = dataGridEmployee.CurrentRow.Cells(1).Value.ToString()
                edite.lblName.Text = dataGridEmployee.CurrentRow.Cells(3).Value.ToString() + " " + dataGridEmployee.CurrentRow.Cells(2).Value.ToString() + " " + dataGridEmployee.CurrentRow.Cells(4).Value.ToString()
                edite.Text = dataGridEmployee.CurrentRow.Cells(6).Value.ToString()

                con.Open()
                Dim query As String
                query = "SELECT Photo FROM Employee_tbl WHERE ID_Number = '" & dataGridEmployee.CurrentRow.Cells(0).Value & "'"
                cmd = New SqlCommand(query, con)

                Dim ms As New MemoryStream(CType(cmd.ExecuteScalar, Byte()))
                edite.picEmployeeDetailsShow.Image = Image.FromStream(ms)
                edite.picEmployeeDetailsShow.SizeMode = PictureBoxSizeMode.StretchImage

                con.Close()

                edite.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub

End Class
Imports System.Data.SqlClient
Public Class Admin_Access

    Dim sda As SqlDataAdapter
    Dim sdr As SqlDataReader
    Dim dt As DataTable

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        con = New SqlConnection
        con.ConnectionString = conString()
        Try
            If txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtPassword, "Pass Code is Requird to Acces")
            Else
                con.Open()
                Dim query As String
                query = "SELECT * FROM Security_Admin WHERE PassCode = '" & txtPassword.Text & "'"
                cmd = New SqlCommand(query, con)

                sdr = cmd.ExecuteReader
                If sdr.HasRows Then
                    Dim sett As New Settings
                    Me.Hide()
                    sett.Show()
                Else
                    MsgBox("Invalid Passcode!", MsgBoxStyle.Critical, "Warning!!")

                End If

                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            txtPassword.Text = ""
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class
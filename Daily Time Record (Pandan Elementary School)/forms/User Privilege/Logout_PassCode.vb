Imports System.Data.SqlClient
Public Class Logout_PassCode

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sdr As SqlDataReader

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Daily_Attendance_Interface.Show()
        Me.Hide()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        con = New SqlConnection
        con.ConnectionString = conString()

        Try
            If txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtPassCode, "PassCode is Required!")
            Else
                ErrorProvider1.Dispose()
                con.Open()
                Dim query As String
                query = "SELECT * FROM Security_Admin WHERE PassCode = '" & txtPassword.Text & "'"

                cmd = New SqlCommand(query, con)
                sdr = cmd.ExecuteReader

                If sdr.HasRows Then
                    Login.Show()
                    Me.Hide()
                Else
                    MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "WARNING!")
                End If
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            txtPassword.Text = ""
        End Try
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Edit


    Private Sub btnEmploDetails_Update_Click(sender As Object, e As EventArgs) Handles btnEmploDetails_Update.Click
        Try
            If txtPass.Text = "" Then
                ErrorProvider1.SetError(txtPass, "You want to change something?")
            Else
                If isUPDATE_Employee("Employee_tbl", "Password = '" & txtNewPass.Text & "'", "ID_Number = '" & lblI.Text & "'") Then
                    MsgBox("New Password Updated Successfully!", MsgBoxStyle.Information, "UPDATED")
                    ErrorProvider1.Clear()
                    txtNewPass.Enabled = False
                    Dim se As New Settings()
                    Me.Hide()
                    se.Show()
                Else
                    MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Error")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Edit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Edit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Settings.Show()
    End Sub
End Class
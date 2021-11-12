Public Class AttedanceTab

    Private Sub lblAttendance_Click(sender As Object, e As EventArgs) Handles lblAttendance.Click
        line.Width = lblAttendance.Width
        line.Left = lblAttendance.Left

        '  Attendance1.Visible = True
        '  Log_Records1.Visible = False
        '   Dtr1.Visible = False
    End Sub

    Private Sub lblLog_Click(sender As Object, e As EventArgs)
        '   line.Width = lblLog.Width
        '  line.Left = lblLog.Left

        ' Attendance1.Visible = False
        '  Log_Records1.Visible = True
        'Dtr1.Visible = False
    End Sub


   
 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            lblTime.Text = "Time : " + TimeOfDay
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

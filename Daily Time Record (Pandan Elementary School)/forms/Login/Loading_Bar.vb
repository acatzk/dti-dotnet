Public Class Loading_Bar

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape2.Width += 1
            If RectangleShape2.Width >= 469 Then
                Timer1.Stop()
                MainForm.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

 
End Class
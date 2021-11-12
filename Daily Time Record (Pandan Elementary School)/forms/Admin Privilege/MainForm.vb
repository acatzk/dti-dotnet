Public Class MainForm

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As New DialogResult
        dialog = MsgBox("Would you like to Logout?", MsgBoxStyle.YesNo, "Yes/No")
        If dialog = Windows.Forms.DialogResult.Yes Then
            Dim login As New Login()
            login.Show()
            Me.Hide()
        Else
            Return
        End If
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If sideMenu.Width = 47 Then
            sideMenu.Visible = False
            sideMenu.Width = 248
            panelAnimator.ShowSync(sideMenu)

        Else
            sideMenu.Visible = False
            sideMenu.Width = 47
            panelAnimator.ShowSync(sideMenu)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        HomeTab1.Visible = True
        RegistrationTab1.Visible = False
        SearchTab1.Visible = False
        AttedanceTab1.Visible = False
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs)
        Dim attend As New Daily_Attendance_Interface
        attend.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs)
        HomeTab1.Visible = False
        RegistrationTab1.Visible = True
        SearchTab1.Visible = False
        AttedanceTab1.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        HomeTab1.Visible = False
        RegistrationTab1.Visible = False
        SearchTab1.Visible = True
        AttedanceTab1.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim dialog As New DialogResult
        dialog = MsgBox("Would you like to Logout?", MsgBoxStyle.YesNo, "Yes/No")
        If dialog = Windows.Forms.DialogResult.Yes Then
            Dim login As New Login()
            login.Show()
            Me.Hide()
        Else
            Return
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim ad As New Admin_Access
        Me.Hide()
        ad.Show()
    End Sub
End Class
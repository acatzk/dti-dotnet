Public Class Login


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As New DialogResult
        dialog = MsgBox("Would you like to Exit?", MsgBoxStyle.YesNo, "Yes/No?")
        If dialog = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Connection()
            If txtIDnumber.Text.Length = 0 Then
                ErrorProvider1.SetError(txtIDnumber, "Username is required!")
            ElseIf txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtIDnumber, "Password is required!")
            Else

                con.Open()
                sql = "SELECT * FROM Employee_tbl WHERE ID_Number = '" & txtIDnumber.Text & "' AND Password = '" & txtPassword.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, con)
                reader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    Dim account = reader("TypeOfAccount")
                    If account = "Administrator" Then
                        Dim l As New Loading_Bar
                        Me.Hide()
                        l.RectangleShape2.Width = 1
                        l.Show()
                    Else
                        Me.Hide()
                        Daily_Attendance_Interface.Show()
                    End If
                Else
                    MsgBox("' " & txtIDnumber.Text & " ' and password combination is invalid.", MsgBoxStyle.Critical, "Opps!")
                End If
                con.Close()
              
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            If BunifuCheckbox1.Checked Then
                txtPassword.Text = txtPassword.Text
                txtIDnumber.Text = ""
            Else
                txtPassword.Text = ""
                txtIDnumber.Text = ""
            End If
            txtIDnumber.Focus()
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If sideMenu.Width = 40 Then
            sideMenu.Visible = False
            sideMenu.Width = 322
            panelAnimator.ShowSync(sideMenu)
            LogoAnimator.ShowSync(Logo)

            attendanceAnimator.ShowSync(lblAttendance)
            monitoringAnimator.ShowSync(lblMonitoring)
            sogodSPEDanimator.ShowSync(lblSogodSpeed)
        Else
            attendanceAnimator.Hide(lblAttendance)
            monitoringAnimator.Hide(lblMonitoring)
            sogodSPEDanimator.Hide(lblSogodSpeed)
            LogoAnimator.Hide(Logo)
            sideMenu.Visible = False
            sideMenu.Width = 40
            panelAnimator.ShowSync(sideMenu)


        End If

    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub
End Class

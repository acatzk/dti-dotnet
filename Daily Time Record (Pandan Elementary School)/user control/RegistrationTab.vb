Public Class RegistrationTab


#Region "FOR REGISTRATION EMPLOYEE"
    Private Sub btnEmployeesRegister_Click(sender As Object, e As EventArgs) Handles btnEmployeesRegister.Click

        Try
            If txtRegistrationID.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationID, "ID number is required!")
            ElseIf txtRegistrationPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationPassword, "Password is required!")
            ElseIf txtRegistrationLastname.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationLastname, "Lastname is required!")
            ElseIf txtRegistrationFirstname.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationFirstname, "Firstname is required!")
            ElseIf txtRegistrationMI.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationMI, "Middlename is required!")
            ElseIf cmbxRegistrationGender.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxRegistrationGender, "Gender is required!")
            ElseIf txtRegistrationPosition.Text.Length = 0 Then
                ErrorProvider1.SetError(txtRegistrationPosition, "Position is required!")
            ElseIf cmbxRegistrationTypeOfAccout.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxRegistrationTypeOfAccout, "Type of Account is required!")
            Else
                ErrorProvider1.Dispose()
                ErrorProvider1.Clear()

                If isSELECT("*", "Employee_tbl", "ID_number = '" & txtRegistrationID.Text &
                                                 "' OR (Lastname = '" & txtRegistrationLastname.Text &
                                                 "' AND Firstname = '" & txtRegistrationFirstname.Text &
                                                 "' AND Middle_Name = '" & txtRegistrationMI.Text & "')") Then
                    MsgBox("Duplicate Entry Found!", MsgBoxStyle.Critical, "Either ID or Fullname")
                Else
                    If isINSERT("Employee_tbl", "'" & txtRegistrationID.Text & "', '" &
                                                      txtRegistrationPassword.Text & "', '" &
                                                      txtRegistrationLastname.Text & "','" &
                                                      txtRegistrationFirstname.Text & "', '" &
                                                      txtRegistrationMI.Text & "', '" &
                                                      cmbxRegistrationGender.Text & "', '" &
                                                      txtRegistrationPosition.Text & "', '" &
                                                      cmbxRegistration_Rank.Text & "', '" &
                                                      cmbxRegistrationTypeOfAccout.Text & "', @Photo ") Then

                        MsgBox("Information Saved", MsgBoxStyle.Information, "Successful")
                        employeeClear() ' -- REGISTRATION CLEARED
                    End If

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

    Sub employeeClear() ' -- TO CLEAR THE FIELD IN REGISTRATION
        ErrorProvider1.Dispose()
        ErrorProvider2.Dispose()
        txtRegistrationID.Text = ""
        txtRegistrationPassword.Text = ""
        txtRegistrationFirstname.Text = ""
        txtRegistrationLastname.Text = ""
        txtRegistrationMI.Text = ""
        cmbxRegistrationGender.SelectedIndex = -1
        cmbxRegistrationTypeOfAccout.Text = ""
        cmbxRegistrationTypeOfAccout.SelectedIndex = -1
        picRegistrationImage.Image = Nothing
        cmbxRegistration_Rank.SelectedIndex = -1
        txtRegistrationPosition.Text = ""
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try

            Photos.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif| All Files(*.*)|*.*"
            Photos.Title = "Select  Employee Pic"
            If Photos.ShowDialog() = Windows.Forms.DialogResult.OK Then
                imgloc = Photos.FileName.ToString()
                picRegistrationImage.ImageLocation = imgloc

            End If

        Catch ex As Exception
            MsgBox("Insert a Photo of the Employee", MsgBoxStyle.YesNo)
        End Try
    End Sub

    Private Sub txtRegistrationPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtRegistrationPassword.OnValueChanged
        txtRegistrationPassword.isPassword = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        employeeClear()
    End Sub
End Class

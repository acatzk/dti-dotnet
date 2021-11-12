Imports System.Data.SqlClient
Public Class Date_Selection_Verification

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sdr As SqlDataReader
    Dim sda As SqlDataAdapter

    Dim month As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con = New SqlConnection
        con.ConnectionString = conString()

        If cmbxMonth.Text = "January" Then
            month = "1"
        ElseIf cmbxMonth.Text = "February" Then
            month = "2"
        ElseIf cmbxMonth.Text = "March" Then
            month = "3"
        ElseIf cmbxMonth.Text = "April" Then
            month = "4"
        ElseIf cmbxMonth.Text = "May" Then
            month = "5"
        ElseIf cmbxMonth.Text = "June" Then
            month = "6"
        ElseIf cmbxMonth.Text = "July" Then
            month = "7"
        ElseIf cmbxMonth.Text = "August" Then
            month = "8"
        ElseIf cmbxMonth.Text = "September" Then
            month = "9"
        ElseIf cmbxMonth.Text = "October" Then
            month = "10"
        ElseIf cmbxMonth.Text = "November" Then
            month = "11"
        ElseIf cmbxMonth.Text = "December" Then
            month = "12"
        End If

        Try
            If cmbxMonth.Text.Length = 0 Or cmbxMonth.Text = "Month" Then
                ErrorProvider1.SetError(cmbxMonth, "Month Selection is Required!")
            ElseIf cmbxYear.Text.Length = 0 Or cmbxYear.Text = "Year" Then
                ErrorProvider1.SetError(cmbxYear, "Year Selection is Required!")
            Else
                ErrorProvider1.Dispose()
                con.Open()
               
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.IO

Public Class SearchTab

  
    Private Sub lblSearchEmployee_Click(sender As Object, e As EventArgs) Handles lblSearchEmployee.Click
        line.Width = lblSearchEmployee.Width
        line.Left = lblSearchEmployee.Left

        Search_Employee1.Visible = True
        Search_DTR1.Visible = False
    End Sub

    Private Sub lblSearchDTR_Click(sender As Object, e As EventArgs) Handles lblSearchDTR.Click
        line.Width = lblSearchDTR.Width
        line.Left = lblSearchDTR.Left

        Search_DTR1.Visible = True
        Search_Employee1.Visible = False
    End Sub
End Class

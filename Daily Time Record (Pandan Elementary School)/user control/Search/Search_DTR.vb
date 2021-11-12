Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing
Public Class Search_DTR


    Dim sda As SqlDataAdapter
    Dim sdr As SqlDataReader
    Dim month As String
    Dim dayy As Integer

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Connection()

        Try

            If txtIDnumber.Text.Length = 0 Then
                ErrorProvider1.SetError(txtIDnumber, "ID number is required!")
            ElseIf cmbxMonth.Text = "Month" Or cmbxMonth.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxMonth, "Month is required! Please Select")
            ElseIf cmbxYear.Text = "Year" Or cmbxYear.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxYear, "Year is required! Please Select")
            Else
                ErrorProvider1.Dispose()

                con.Open()

                Dim query2 As String
                query2 = "SELECT * FROM Employee_tbl WHERE ID_Number = '" & txtIDnumber.Text & "'"

                cmd = New SqlCommand(query2, con)
                sdr = cmd.ExecuteReader

                If Not sdr Is Nothing Then
                    sdr.Read()

                    Dim data As Byte() = DirectCast(sdr("Photo"), Byte())
                    Dim ms As New MemoryStream(data)
                    picShow.Image = Image.FromStream(ms)

                    lblIDnumber.Text = sdr("ID_Number").ToString()
                    lblEmployeeName.Text = sdr("Firstname").ToString + " " + sdr("Middle_Name").ToString + _
                        " " + sdr("Lastname").ToString

                    lblTypeOfAccount.Text = sdr("TypeOfAccount").ToString()
                Else
                    MsgBox("Invalid Id number", MsgBoxStyle.Exclamation, "Try/Again")
                    Clear()
                End If

                con.Close()

                con.Open()
                Dim query As String

                If cmbxMonth.Text = "January" Then
                    Month = "1"
                ElseIf cmbxMonth.Text = "February" Then
                    Month = "2"
                ElseIf cmbxMonth.Text = "March" Then
                    Month = "3"
                ElseIf cmbxMonth.Text = "April" Then
                    Month = "4"
                ElseIf cmbxMonth.Text = "May" Then
                    Month = "5"
                ElseIf cmbxMonth.Text = "June" Then
                    Month = "6"
                ElseIf cmbxMonth.Text = "July" Then
                    Month = "7"
                ElseIf cmbxMonth.Text = "August" Then
                    Month = "8"
                ElseIf cmbxMonth.Text = "September" Then
                    Month = "9"
                ElseIf cmbxMonth.Text = "October" Then
                    Month = "10"
                ElseIf cmbxMonth.Text = "November" Then
                    Month = "11"
                ElseIf cmbxMonth.Text = "December" Then
                    Month = "12"
                End If

                query = "SELECT Dates, Morning_In, Morning_Out, Afternoon_In, Afternoon_Out, AM_TotalHours, " _
                    & " PM_TotalHours, Undertime FROM AttendanceRecords_tbl WHERE ID_Number = '" & txtIDnumber.Text _
                    & "' AND Dates LIKE '" & month.ToString & "/%' AND Dates LIKE '%/" & cmbxYear.Text & "' "

                cmd = New SqlCommand(query, con)
                sda = New SqlDataAdapter(cmd)
                dt = New DataTable
                sda.Fill(dt)

                dataGridLRecordsEmploo.Rows.Clear()
                For Each item As DataRow In dt.Rows
                    Dim n As Integer = dataGridLRecordsEmploo.Rows.Add()
                    dataGridLRecordsEmploo.Rows(n).Cells(0).Value = item("Dates").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                    dataGridLRecordsEmploo.Rows(n).Cells(7).Value = item("Undertime").ToString()
                Next
                con.Close()
            End If

        Catch ex As Exception
            MsgBox("Invalid! Please Check your ID number, Month and Year of Selection!", MsgBoxStyle.Exclamation, "Something went wrong!")
            Clear()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Clear()
        lblIDnumber.Text = ".."
        lblEmployeeName.Text = ".."
        lblTypeOfAccount.Text = ".."
        cmbxMonth.Text = "Month"
        cmbxYear.Text = "Year"
        picShow.Image = Nothing
    End Sub


    Private Sub Year()
        Try
            Dim year = Date.Today.Year
            cmbxYear.Items.Add(year)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnPrintDTR_Click(sender As Object, e As EventArgs) Handles btnPrintDTR.Click
        Try
            If txtIDnumber.Text.Length = 0 Then
                ErrorProvider1.SetError(txtIDnumber, "ID number is required!")
            ElseIf cmbxMonth.Text = "Month" Or cmbxMonth.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxMonth, "Month is required! Please Select")
            ElseIf cmbxYear.Text = "Year" Or cmbxYear.Text.Length = 0 Then
                ErrorProvider1.SetError(cmbxYear, "Year is required! Please Select")
            Else
                If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

                    Dim PageSetup As New PageSettings
                    With PageSetup
                        .Margins.Left = 0
                        .Margins.Right = 0
                        .Margins.Top = 0
                        .Margins.Bottom = 0
                        .Landscape = False

                    End With

                    PrintDocument1.DefaultPageSettings = PageSetup
                End If
                PrintPreviewDialog1.Document = PrintDocument1
                PrintPreviewDialog1.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            'para sa pagprint sa dtr
            Dim width As Integer = 0
            Dim margin_bottom As Integer = 167
            Dim i As Integer = 0
            Dim p = New Pen(Brushes.Black, 0.5F)
            Dim pb = New Pen(Brushes.Black, 1.5F)
            Dim Header As Font = New Drawing.Font("Times New Roman", 7, FontStyle.Bold)
            Dim Header1 As Font = New Drawing.Font("Times New Roman", 11, FontStyle.Bold)
            Dim Header2 As Font = New Drawing.Font("Times New Roman", 8, FontStyle.Italic Or FontStyle.Bold)
            Dim Header3 As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
            Dim Header4 As Font = New Drawing.Font("Times New Roman", 6, FontStyle.Bold)
            Dim Header5 As Font = New Drawing.Font("Times New Roman", 5, FontStyle.Bold)
            Dim Header6 As Font = New Drawing.Font("Times New Roman", 9, FontStyle.Regular Or FontStyle.Bold)
            Dim Header7 As Font = New Drawing.Font("Times New Roman", 6, FontStyle.Regular Or FontStyle.Bold)
            Dim Header8 As Font = New Drawing.Font("Times New Roman", 7, FontStyle.Italic Or FontStyle.Bold)
            Dim Header9 As Font = New Drawing.Font("Times New Roman", 7, FontStyle.Bold)

            'ibabaw
            e.Graphics.DrawString("CIVIL SERVICE FORM No. 48", Header, Brushes.Black, 10, 20)
            e.Graphics.DrawString("DAILY TIME RECORD", Header1, Brushes.Black, 61, 38)

            e.Graphics.DrawString(lblEmployeeName.Text, Header3, Brushes.Black, 61, 68) 'name of employee
            e.Graphics.DrawString("______________________________", Header1, Brushes.Black, 25, 70)
            e.Graphics.DrawString("(Name)", Header, Brushes.Black, 118, 88)

            e.Graphics.DrawString(cmbxMonth.Text & " " & cmbxYear.Text, Header3, Brushes.Black, 120, 110) 'Month and year
            e.Graphics.DrawString("For the month of ________________________________", Header2, Brushes.Black, 10, 115)
            e.Graphics.DrawString("Official hours for arrival           (Regular days  ________", Header2, Brushes.Black, 10, 132)
            e.Graphics.DrawString("and departure                      (Saturdays  __________", Header2, Brushes.Black, 33, 149)
            e.Graphics.DrawString(" ______________________________________________ ", Header2, Brushes.Black, 10, 153)
            e.Graphics.DrawString(" ______________________________________________ ", Header2, Brushes.Black, 10, 155)

            'Day
            e.Graphics.DrawString("Day", Header4, Brushes.Black, 25, 181)

            ' A.M
            e.Graphics.DrawString("A.M.", Header4, Brushes.Black, 73, 173)
            e.Graphics.DrawRectangle(p, New Rectangle(45, margin_bottom, 78, 20))
            ' P.M
            e.Graphics.DrawString("P.M.", Header4, Brushes.Black, 155, 173)
            e.Graphics.DrawRectangle(p, New Rectangle(123, margin_bottom, 78, 20))
            '  UNDERTIME
            e.Graphics.DrawString("UNDERTIME", Header4, Brushes.Black, 210, 173)
            e.Graphics.DrawString("____________", Header2, Brushes.Black, 201, 175)

            ' Arrival
            e.Graphics.DrawString("Arrival", Header4, Brushes.Black, 50, 193)
            e.Graphics.DrawString("________", Header4, Brushes.Black, 10, 198)
            e.Graphics.DrawRectangle(p, New Rectangle(45, 187, 39, 20))

            'Departure
            e.Graphics.DrawString("Depar-", Header4, Brushes.Black, 91, 188)
            e.Graphics.DrawString("ture", Header4, Brushes.Black, 95, 196)
            e.Graphics.DrawRectangle(p, New Rectangle(84, 187, 39, 20))

            'Arrival
            e.Graphics.DrawString("Arrival", Header4, Brushes.Black, 128, 193)
            e.Graphics.DrawRectangle(p, New Rectangle(123, 187, 39, 20))

            'Departure
            e.Graphics.DrawString("Depar-", Header4, Brushes.Black, 168, 188)
            e.Graphics.DrawString("ture", Header4, Brushes.Black, 172, 196)
            e.Graphics.DrawRectangle(p, New Rectangle(162, 187, 39, 20))

            'Hours
            e.Graphics.DrawString("Hour", Header4, Brushes.Black, 209, 193)
            e.Graphics.DrawRectangle(p, New Rectangle(201, 187, 39, 20))

            'Minute
            e.Graphics.DrawString("Min-", Header4, Brushes.Black, 248, 188)
            e.Graphics.DrawString("utes", Header4, Brushes.Black, 248, 196)
            e.Graphics.DrawString("____________", Header2, Brushes.Black, 201, 195)

            'First stand
            e.Graphics.DrawRectangle(pb, New Rectangle(45, 167, 1, 506))
            'Second stand
            e.Graphics.DrawRectangle(pb, New Rectangle(122, 167, 1, 506))
            'Third stand
            e.Graphics.DrawRectangle(pb, New Rectangle(200, 167, 1, 524))


            Dim height As Integer = 212
            'pagloop



            Dim dateValue As String
            Do While (i < dataGridLRecordsEmploo.Rows.Count)

                height += dataGridLRecordsEmploo.Rows(0).Height

                dateValue = dataGridLRecordsEmploo.Rows(i).Cells(0).FormattedValue.ToString()

                '  e.Graphics.DrawString(dateValue, Header, Brushes.Black, New Rectangle(45, height, dataGridLRecordsEmploo.Columns(0).Width, dataGridLRecordsEmploo.Rows(0).Height))
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

                If isSELECT("*", "AttendanceRecords_tbl", "Dates LIKE '" & month.ToString _
                            & "/%' AND Dates LIKE '%/" & dateValue _
                            & "/%' AND Dates LIKE '%/" & cmbxYear.Text & "'") Then
                    dateValue = dataGridLRecordsEmploo.Rows(i).Cells(1).FormattedValue.ToString()
                    'e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height) ' days
                    'If dateValue = "1" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height) ' days
                    'ElseIf dateValue = "2" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "3" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "4" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "5" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "6" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "7" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "8" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "9" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "10" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "11" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "12" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "13" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "14" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "15" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "16" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "17" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "18" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "19" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "20" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "21" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "22" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "23" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "24" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "25" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "26" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "27" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "28" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "29" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "30" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'ElseIf dateValue = "31" Then
                    '    e.Graphics.DrawString(dateValue, Header, Brushes.Black, 45, height)
                    'End If

                End If

                i = i + 1
            Loop
 
            ' --- FOR DESING FORMAT OF DTR
            For index As Integer = 1 To 31
                If index = 1 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 212) ' days
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 207, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 207, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 207, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 207, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 207, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 214.5) ' last underline
                ElseIf index = 2 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 226)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 222, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 222, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 222, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 222, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 222, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 229.5) ' last underline
                ElseIf index = 3 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 240)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 237, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 237, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 237, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 237, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 237, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 244.5) ' last underline
                ElseIf index = 4 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 254)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 252, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 252, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 252, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 252, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 252, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 259.5) ' last underline
                ElseIf index = 5 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 270)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 267, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 267, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 267, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 267, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 267, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 274.5) ' last underline
                ElseIf index = 6 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 285)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 282, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 282, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 282, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 282, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 282, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 289.5) ' last underline
                ElseIf index = 7 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 300)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 297, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 297, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 297, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 297, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 297, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 304.5) ' last underline
                ElseIf index = 8 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 314)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 312, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 312, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 312, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 312, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 312, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 319) ' last underline
                ElseIf index = 9 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 330)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 327, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 327, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 327, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 327, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 327, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 334.5) ' last underline
                ElseIf index = 10 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 346)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 342, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 342, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 342, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 342, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 342, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 349) ' last underline
                ElseIf index = 11 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 360)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 357, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 357, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 357, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 357, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 357, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 364.5) ' last underline
                ElseIf index = 12 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 376)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 372, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 372, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 372, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 372, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 372, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 379) ' last underline
                ElseIf index = 13 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 390)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 387, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 387, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 387, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 387, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 387, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 394.5) ' last underline
                ElseIf index = 14 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 404)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 402, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 402, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 402, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 402, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 402, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 408.7) ' last underline
                ElseIf index = 15 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 420)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 417, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 417, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 417, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 417, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 417, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 424) ' last underline
                ElseIf index = 16 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 436)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 432, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 432, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 432, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 432, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 432, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 439.5) ' last underline
                ElseIf index = 17 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 450)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 447, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 447, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 447, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 447, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 447, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 454.5) ' last underline
                ElseIf index = 18 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 464)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 462, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 462, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 462, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 462, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 462, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 469.5) ' last underline
                ElseIf index = 19 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 480)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 477, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 477, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 477, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 477, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 477, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 484.5) ' last underline
                ElseIf index = 20 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 496)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 492, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 492, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 492, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 492, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 492, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 499.5) ' last underline
                ElseIf index = 21 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 510)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 507, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 507, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 507, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 507, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 507, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 514.5) ' last underline
                ElseIf index = 22 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 526)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 522, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 522, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 522, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 522, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 522, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 529.5) ' last underline
                ElseIf index = 23 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 541)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 537, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 537, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 537, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 537, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 537, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 544.5) ' last underline
                ElseIf index = 24 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 555)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 552, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 552, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 552, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 552, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 552, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 559.5) ' last underline
                ElseIf index = 25 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 570)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 567, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 567, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 567, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 567, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 567, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 574) ' last underline
                ElseIf index = 26 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 585)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 582, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 582, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 582, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 582, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 582, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 589.5) ' last underline
                ElseIf index = 27 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 600)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 597, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 597, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 597, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 597, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 597, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 604) ' last underline
                ElseIf index = 28 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 615)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 612, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 612, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 612, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 612, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 612, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 619.5) ' last underline
                ElseIf index = 29 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 629)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 627, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 627, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 627, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 627, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 627, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 634) ' last underline
                ElseIf index = 30 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 646)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 642, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 642, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 642, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 642, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 642, 39, 15)) ' square shape Hour
                    e.Graphics.DrawString("_________", Header5, Brushes.Black, 238, 649.5) ' last underline
                ElseIf index = 31 Then
                    e.Graphics.DrawString(index, Header, Brushes.Black, 27, 660)
                    e.Graphics.DrawRectangle(p, New Rectangle(45, 657, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(84, 657, 39, 15)) ' square shape morning
                    e.Graphics.DrawRectangle(p, New Rectangle(123, 657, 39, 15)) ' squre shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(162, 657, 39, 15)) ' square shape afternoon
                    e.Graphics.DrawRectangle(p, New Rectangle(201, 657, 39, 15)) ' square shape Hour
                End If

            Next
            e.Graphics.DrawString("T  O  T  A  L", Header6, Brushes.Black, 90, 677)
            e.Graphics.DrawString(" _____________________________________________", Header2, Brushes.Black, 10, 660.5)
            e.Graphics.DrawRectangle(p, New Rectangle(201, 672, 39, 20)) ' square shape
            e.Graphics.DrawString(" _____________________________________________", Header2, Brushes.Black, 10, 679.5)
            e.Graphics.DrawString(" _____________________________________________", Header2, Brushes.Black, 10, 682.5)
            e.Graphics.DrawString("I CERTIFY", Header7, Brushes.Black, 33, 698)
            e.Graphics.DrawString("on my honor that the above is a true and correct", Header8, Brushes.Black, 77, 698)
            e.Graphics.DrawString("report  of  the hours  of  work performed, record  of  which was", Header8, Brushes.Black, 18, 708)
            e.Graphics.DrawString("made daily  at  the time of arrival at and departure from office.", Header8, Brushes.Black, 18, 718)
            e.Graphics.DrawString("_____________________________  ", Header2, Brushes.Black, 100, 732)
            e.Graphics.DrawString(" _____________________________________________", Header2, Brushes.Black, 10, 736)
            e.Graphics.DrawString(" _____________________________________________", Header2, Brushes.Black, 10, 740)
            e.Graphics.DrawString("Verify  as  to  the prescribed office hours.", Header8, Brushes.Black, 37, 756)
            e.Graphics.DrawString("_____________________________  ", Header2, Brushes.Black, 100, 772)
            e.Graphics.DrawString("In-Charge", Header8, Brushes.Black, 168, 785)
            e.Graphics.DrawString("(See Instruction on back)", Header9, Brushes.Black, 79, 808)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Search_DTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year()
    End Sub
End Class

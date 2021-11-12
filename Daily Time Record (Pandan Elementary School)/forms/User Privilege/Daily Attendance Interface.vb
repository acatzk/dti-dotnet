Imports System.Data.SqlClient
Imports System.IO
Public Class Daily_Attendance_Interface

   
    Dim sdr As SqlDataReader
    Dim sda As SqlDataAdapter
    Dim bs As BindingSource
    Dim query As String  ' -- FOR THE QUERY


    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Dim ad As New Logout_PassCode
        ad.ShowDialog()
    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs)
        txtPassword.isPassword = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Connection()

        Try
            If txtIDnumber.text.Length = 0 Then
                ErrorProvider1.SetError(txtIDnumber, "ID number is required!")
            ElseIf txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtPassword, "Password is required!")
            Else
                ErrorProvider1.Dispose()
                con.Open()
                Dim query As String
                query = "SELECT * FROM Employee_tbl WHERE ID_Number = '" &
                    txtIDnumber.text & "' AND Password = '" & txtPassword.Text & "'"

                cmd = New SqlCommand(query, con)
                sdr = cmd.ExecuteReader

                If sdr.HasRows Then
                    '  DailyAttendanceRecords() ' -- FOR DAILY TIME ATTENDANCE FUNCTION
                    If Not sdr Is Nothing Then
                        sdr.Read()

                        lblIDnumber.Text = sdr("ID_Number").ToString()
                        lblEmployeeName.Text = sdr("Firstname").ToString + " " + " " + sdr("Middle_Name").ToString + " " + sdr("Lastname").ToString
                        lblTypeOfAccount.Text = sdr("TypeOfAccount").ToString()
                        lblYourDTR.Text = sdr("Firstname").ToString + " " + " " + sdr("Middle_Name").ToString + " " + sdr("Lastname").ToString

                        Dim data As Byte() = DirectCast(sdr("Photo"), Byte())
                        Dim ms As New MemoryStream(data)
                        picShow.Image = Image.FromStream(ms)
                        picDTR.Image = Image.FromStream(ms)

                        loader.Visible = True
                        EmployeeDailyData()

                        clear() ' -- to clear the login

                        con.Close() ' -- CONNECTION CLOSE
                    End If
                Else
                    MsgBox("Unauthorized Personnel are Strictly PROHIBITED!", MsgBoxStyle.Critical, "WARNING!!")
                    loader.Visible = False
                    clear()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        Finally
            con.Dispose()
        End Try


    End Sub


    Sub clear()
        txtIDnumber.text = ""
        txtPassword.Text = ""
        txtIDnumber.Focus()
    End Sub

    Dim daily_log As String
    Private Sub btnINorOut_Click(sender As Object, e As EventArgs) Handles btnINorOut.Click
        ' DailyAttendanceRecords() ' FOR THE ATTENDANCE RECORDS 
        DailyAttendanceRecords2()
    End Sub

#Region " DAILY TIME RECORD CONDITIONS FUNCTION"
    Private Sub DailyAttendanceRecords2()
        Try

            If DateTime.Now.TimeOfDay >= New TimeSpan(6, 0, 0) AndAlso DateTime.Now.TimeOfDay <= New TimeSpan(12, 30, 0) Then

                Connection()

                con.Open()
                Dim query As String
                query = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                cmd = New SqlCommand(query, con)

                sda = New SqlDataAdapter(cmd)
                dt = New DataTable
                sda.Fill(dt)

                dataGridEmployee.Rows.Clear()
                For Each item As DataRow In dt.Rows
                    Dim n As Integer = dataGridEmployee.Rows.Add()
                    dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                    dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                    dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                    dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                    dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                    dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                    dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                    dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
                Next

                If dt.Rows.Count = 0 Then ' --  IF MORNING IN EMPTY

                    ' -- morning login query
                    Dim morning_in As String
                    morning_in = "INSERT INTO AttendanceRecords_tbl (ID_Number, Dates, Morning_In) VALUES ('" & lblIDnumber.Text & "', '" & FormatDateTime(Now, DateFormat.ShortDate) & "', '" & TimeOfDay.ToShortTimeString & "') "
                    cmd = New SqlCommand(morning_in, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData()

                    con.Close()

                    con.Close()

                    ' -- log status summary query
                    Connection()
                    con.Open()
                    Dim log As String = "Log-in AM"
                    Dim login_morning As String
                    login_morning = "INSERT INTO Daily_Log (Dates, name, Time, Log_Status) VALUES ('" & lblDate.Text & "', '" & lblEmployeeName.Text & "', '" & TimeOfDay.ToShortTimeString & "', '" & log.ToString & "')"
                    cmd = New SqlCommand(login_morning, con)
                    cmd.ExecuteNonQuery()
                    SummaryAttendance() ' -- for Automatic Summary
                    con.Close()



                ElseIf dt.Rows(0)(2).ToString <> "" And dt.Rows(0)(3).ToString = "" Then  ' --  IF MORNING IN IS not EMPTY AND MORNING OUT IS EMPTY


                    con.Close()

                    Connection()
                    con.Open()

                    ' -- morning out query
                    Dim morning_out As String
                    morning_out = "UPDATE AttendanceRecords_tbl SET Morning_Out = '" & TimeOfDay.ToShortTimeString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(morning_out, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)

                    con.Close()


                    con.Close()

                    ' -- total morning query
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()

                    Dim totalAM As TimeSpan
                    Dim totalquery As String
                    Dim q As String
                    q = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(q, con)
                    sda = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    sda.Fill(dt)

                    dataGridEmployee.Rows.Clear()
                    For Each item As DataRow In dt.Rows
                        Dim n As Integer = dataGridEmployee.Rows.Add()
                        dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                        dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                        dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                        dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
                    Next

                    totalAM = dt.Rows(0)(3) - dt.Rows(0)(2)

                    totalquery = "UPDATE AttendanceRecords_tbl SET AM_TotalHours = '" & totalAM.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(totalquery, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)

                    con.Close()


                    con.Close()

                    ' -- Log summary query
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    Dim log As String = "Log-out AM"
                    log = "INSERT INTO Daily_Log (Dates, name, Time, Log_Status) VALUES ('" & lblDate.Text & "', '" & lblEmployeeName.Text & "', '" & TimeOfDay.ToShortTimeString & "', '" & log.ToString & "')"
                    cmd = New SqlCommand(log, con)
                    cmd.ExecuteNonQuery()
                    SummaryAttendance() ' -- for Automatic Summary
                    con.Close()

                    con.Close()

                    ' -- Undertime
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    Dim un As TimeSpan
                    Dim under1 As String

                    Dim qq As String
                    qq = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(qq, con)
                    sda = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    sda.Fill(dt)

                    dataGridEmployee.Rows.Clear()
                    For Each item As DataRow In dt.Rows
                        Dim n As Integer = dataGridEmployee.Rows.Add()
                        dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                        dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                        dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                        dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
                    Next

                    un = dt.Rows(0)(9) - dt.Rows(0)(6)

                    under1 = "UPDATE AttendanceRecords_tbl SET Undertime = '" & un.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(under1, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)
                    con.Close()



                End If

            Else

                con = New SqlConnection
                con.ConnectionString = conString()

                con.Open()
                Dim query1 As String
                query1 = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                cmd = New SqlCommand(query1, con)

                sda = New SqlDataAdapter(cmd)
                dt = New DataTable
                sda.Fill(dt)


                If dt.Rows.Count = 0 Then ' --  IF MORNING IN EMPTY

                    Dim afternoon_in As String


                    afternoon_in = "INSERT INTO AttendanceRecords_tbl (ID_Number, Dates, Afternoon_In) VALUES ('" & lblIDnumber.Text & "', '" & FormatDateTime(Now, DateFormat.ShortDate) & "', '" & TimeOfDay.ToShortTimeString & "') "
                    cmd = New SqlCommand(afternoon_in, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData()

                    con.Close()

                    con.Close()

                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    Dim log As String = "Log-in PM"
                    Dim login_morning As String
                    login_morning = "INSERT INTO Daily_Log (Dates, name, Time, Log_Status) VALUES  ('" & lblDate.Text & "', '" & lblEmployeeName.Text & "', '" & TimeOfDay.ToShortTimeString & "', '" & log.ToString & "')"
                    cmd = New SqlCommand(login_morning, con)
                    cmd.ExecuteNonQuery()
                    SummaryAttendance() ' -- for Automatic Summary
                    con.Close()


                ElseIf dt.Rows(0)(4).ToString = "" Then

                    con.Close()

                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    '-----------------------------------------------------------------------

                    Dim afternoon_in As String
                    afternoon_in = "UPDATE AttendanceRecords_tbl SET Afternoon_In = '" & TimeOfDay.ToShortTimeString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(afternoon_in, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)

                    con.Close()

                    con.Close()
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    Dim log As String = "Log-in PM"
                    log = "INSERT INTO Daily_Log (Dates, name, Time, Log_Status) VALUES ('" & lblDate.Text & "', '" & lblEmployeeName.Text & "', '" & TimeOfDay.ToShortTimeString & "', '" & log.ToString & "')"
                    cmd = New SqlCommand(log, con)
                    cmd.ExecuteNonQuery()
                    SummaryAttendance() ' -- for Automatic Summary
                    con.Close()

                ElseIf dt.Rows(0)(4).ToString <> "" And dt.Rows(0)(5).ToString = "" Then

                    con.Close()

                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()

                    Dim afternoon_out As String
                    afternoon_out = "UPDATE AttendanceRecords_tbl SET Afternoon_Out = '" & TimeOfDay.ToShortTimeString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(afternoon_out, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)

                    con.Close()


                    ' -- total afternoon query
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()

                    Dim totalPM As TimeSpan
                    Dim totalquery As String
                    Dim q As String
                    q = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(q, con)
                    sda = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    sda.Fill(dt)

                    dataGridEmployee.Rows.Clear()
                    For Each item As DataRow In dt.Rows
                        Dim n As Integer = dataGridEmployee.Rows.Add()
                        dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                        dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                        dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                        dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
                    Next


                    totalPM = (dt.Rows(0)(5) - dt.Rows(0)(4))

                    totalquery = "UPDATE AttendanceRecords_tbl SET PM_TotalHours = '" & totalPM.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(totalquery, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)

                    con.Close()


                    con.Close()

                    ' -- for Total Number of Hours
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()

                    Dim totalHours As TimeSpan

                    q = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(q, con)
                    sda = New SqlDataAdapter(cmd)
                    dt = New DataTable
                    sda.Fill(dt)

                    dataGridEmployee.Rows.Clear()
                    For Each item As DataRow In dt.Rows
                        Dim n As Integer = dataGridEmployee.Rows.Add()
                        dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                        dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                        dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                        dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                        dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                        dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
                    Next

                    If dt.Rows(0)(6).ToString = "" Then
                        totalHours = dt.Rows(0)(7)

                        Dim query As String
                        query = "UPDATE AttendanceRecords_tbl SET Total_Number_Hours = '" & totalHours.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                        cmd = New SqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)
                        con.Close()
                    Else
                        totalHours = (dt.Rows(0)(6) + dt.Rows(0)(7))

                        Dim query As String
                        query = "UPDATE AttendanceRecords_tbl SET Total_Number_Hours = '" & totalHours.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                        cmd = New SqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)
                        con.Close()
                    End If

                    con.Close()

                    ' -------query for Undertime
                    UnderTime()
                    '------- end of undertime


                    ' -- for summary log
                    con.Close()
                    con = New SqlConnection
                    con.ConnectionString = conString()
                    con.Open()
                    Dim log As String = "Log-out PM"
                    log = "INSERT INTO Daily_Log (Dates, name, Time, Log_Status) VALUES ('" & lblDate.Text & "', '" & lblEmployeeName.Text & "', '" & TimeOfDay.ToShortTimeString & "', '" & log.ToString & "')"
                    cmd = New SqlCommand(log, con)
                    cmd.ExecuteNonQuery()
                    SummaryAttendance() ' -- for Automatic Summary

                    con.Close()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            panel_log.Visible = True
            loader.Visible = False
        End Try

    End Sub

#End Region


#Region " DAILY TIME RECORD CONDITIONS"
    Private Sub DailyAttendanceRecords()
        lblSUmmary.Text = FormatDateTime(Now, DateFormat.ShortDate).ToString
        ' Try
        Dim time As String = Now.Hour & ":" & Now.Minute
        If isSELECT("*", "AttendanceRecords_tbl", "ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'") Then

            Dim attend As New Attendance
            attend.getAttendance(lblIDnumber.Text, FormatDateTime(Now, DateFormat.ShortDate))

            If attend.Time_Out_AM = "" And attend.Time_In_AM <> "" Then

                If Now.Hour <= 12 And Now.Hour >= 9 Then
                    Connection()
                    con.Open()
                    sql = "UPDATE AttendanceRecords_tbl SET Morning_Out = '" & time & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData()
                    con.Close()
                End If

            ElseIf attend.Time_In_PM = "" And attend.Time_Out_AM <> "" Then
                If Now.Hour <= 14 And Now.Hour >= 12 Then
                    Connection()
                    con.Open()
                    sql = "UPDATE AttendanceRecords_tbl SET Afternoon_In = '" & time & "'  WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData()
                    con.Close()
                End If
            ElseIf attend.Time_Out_PM = "" And attend.Time_In_PM <> "" Then
                'out sa udto
                If Now.Hour <= 17 And Now.Hour >= 14 Then
                    Connection()
                    con.Open()
                    sql = "UPDATE AttendanceRecords_tbl SET Afternoon_Out = '" & time & "'  WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
                    cmd = New SqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    EmployeeDailyData()
                    con.Close()
                End If

            End If
        Else
            time = Now.Hour & ":" & Now.Minute

            If Now.Hour <= 9 And Now.Hour >= 1 Then
                con = New SqlConnection
                con.ConnectionString = conString()
                con.Open()
                sql = "INSERT INTO AttendanceRecords_tbl (ID_Number, Morning_In, Dates) VALUES ('" & lblIDnumber.Text & "' ,'" & time & "','" & FormatDateTime(Now, DateFormat.ShortDate) & "')"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                EmployeeDailyData()
                MsgBox("Success")
                con.Close()
            ElseIf Now.Hour <= 14 And Now.Hour >= 12 Then
                Connection()
                con.Open()
                sql = "INSERT INTO AttendanceRecords_tbl (ID_Number, Afternoon_In, Dates) VALUES ('" & lblIDnumber.Text & "' ,'" & time & "','" & FormatDateTime(Now, DateFormat.ShortDate) & "')"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                EmployeeDailyData()
                MsgBox("Success")
                con.Close()
            End If
        End If
        '  Catch ex As Exception

        'MsgBox(ex.Message)
        'Finally
        'con.Dispose()
        'End Try



    End Sub

    Private Sub EmployeeDailyData()
        con = New SqlConnection
        con.ConnectionString = conString()

        Try
            con.Open()
            Dim query As String
           
            query = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates LIKE '" & Label1.Text & "/%' AND Dates LIKE '%/" & Label2.Text & "'"
            cmd = New SqlCommand(query, con)

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable
            sda.Fill(dt)

            dataGridEmployee.Rows.Clear()
            For Each item As DataRow In dt.Rows
                Dim n As Integer = dataGridEmployee.Rows.Add()
                dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
                dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
                dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
                dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
                dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
                dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
                dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
                dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
            Next
            ' dataGridEmployee.DataSource = dt
            dataGridLSummaryLog.Update()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

#End Region

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim log As New Logout_PassCode
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Daily_Attendance_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer2.Enabled = True
            Timer4.Enabled = True

            Label1.Text = Date.Today.Month
            Label2.Text = Date.Today.Year
            '  SummaryAttendance() ' -- FOR THE SUMMARY
            dataGridLSummaryLog.Font = New System.Drawing.Font("Century Gothic", 9.0F)
            dataGridEmployee.Font = New System.Drawing.Font("Century Gothic", 9.0F)
        Catch ex As Exception

        End Try
     
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            lblDate.Text = Date.Now.ToString("dd MMM yyy")
            lblTime.Text = TimeOfDay
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ' -- FOR SUMMARY DATAGRIDVIEW
    Sub SummaryAttendance()

        con = New SqlConnection
        con.ConnectionString = conString()

        Try
            con.Open()

            Dim query As String
            query = "SELECT name, Time, Log_Status FROM Daily_Log WHERE Dates = '" & lblDate.Text & "' ORDER BY Recordnum DESC"
            cmd = New SqlCommand(query, con)

            dt = New DataTable
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)

            dataGridLSummaryLog.Rows.Clear()
            For Each item As DataRow In dt.Rows
                Dim n As Integer = dataGridLSummaryLog.Rows.Add()
                dataGridLSummaryLog.Rows(n).Cells(0).Value = item("Name").ToString()
                dataGridLSummaryLog.Rows(n).Cells(1).Value = item("Time").ToString()
                dataGridLSummaryLog.Rows(n).Cells(2).Value = item("Log_Status").ToString()
            Next
            dataGridLSummaryLog.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub UnderTime()

        con = New SqlConnection
        con.ConnectionString = conString()
        con.Open()
        Dim d As String
        d = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
        cmd = New SqlCommand(d, con)
        sda = New SqlDataAdapter(cmd)
        dt = New DataTable
        sda.Fill(dt)

        dataGridEmployee.Rows.Clear()
        For Each item As DataRow In dt.Rows
            Dim n As Integer = dataGridEmployee.Rows.Add()
            dataGridEmployee.Rows(n).Cells(0).Value = item("Dates").ToString()
            dataGridEmployee.Rows(n).Cells(1).Value = item("Morning_In").ToString()
            dataGridEmployee.Rows(n).Cells(2).Value = item("Morning_Out").ToString()
            dataGridEmployee.Rows(n).Cells(3).Value = item("Afternoon_In").ToString()
            dataGridEmployee.Rows(n).Cells(4).Value = item("Afternoon_Out").ToString()
            dataGridEmployee.Rows(n).Cells(5).Value = item("AM_TotalHours").ToString()
            dataGridEmployee.Rows(n).Cells(6).Value = item("PM_TotalHours").ToString()
            dataGridEmployee.Rows(n).Cells(7).Value = item("Undertime").ToString()
        Next

        Dim undertime As TimeSpan

        If dt.Rows(0)(8) >= dt.Rows(0)(9) Then
            Dim noUndertime As New TimeSpan(0, 0, 0)

            Dim querrr As String
            querrr = "UPDATE AttendanceRecords_tbl SET Undertime = '" & noUndertime.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
            cmd = New SqlCommand(querrr, con)
            cmd.ExecuteNonQuery()
            EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)
        Else

            undertime = (dt.Rows(0)(9) - dt.Rows(0)(8))
            Dim queryy As String
            queryy = "UPDATE AttendanceRecords_tbl SET Undertime = '" & undertime.ToString & "' WHERE ID_Number = '" & lblIDnumber.Text & "' AND Dates = '" & FormatDateTime(Now, DateFormat.ShortDate) & "'"
            cmd = New SqlCommand(queryy, con)
            cmd.ExecuteNonQuery()
            EmployeeDailyData() ' -- for their specific daily time Records (Datagridview show)
        End If

        con.Close()

    End Sub

  


  
    Private Sub btnMenuAdmin_Click(sender As Object, e As EventArgs) Handles btnMenuAdmin.Click
        ContextMenuStrip1.Show(btnMenuAdmin, 0, btnMenuAdmin.Height)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        panel_log.Visible = False
    End Sub
End Class
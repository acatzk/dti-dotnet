Imports System.Data.SqlClient
Public Class Attendance

    Dim result As New ArrayList()
    Dim c As String = 0

    Public Sub getAttendance(id As String, datee As String)
        Connection()

        Try
            con.Open()
            sql = "SELECT * FROM AttendanceRecords_tbl WHERE ID_Number = " & id & " AND Dates = " & datee & ""
            cmd = New SqlCommand(sql, con)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (reader.FieldCount - 1)
                    dict.Add(reader.GetName(count), reader(count))
                Next
                result.Add(dict)
            End While

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Public Function Id_Number() As String
        Try
            For Each dat As Dictionary(Of String, Object) In result
                c = dat("ID_Number")
            Next
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Public Function Time_In_AM()
        Try
            For Each dat As Dictionary(Of String, Object) In result
                c = dat("Morning_In")
            Next
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Public Function Time_In_PM() As String
        Dim c As String = 0
        Try
            For Each dat As Dictionary(Of String, Object) In result
                c = dat("Afternoon_In")
            Next
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Public Function Time_Out_AM() As String
        Try
            For Each dat As Dictionary(Of String, Object) In result
                c = dat("Morning_Out")
            Next
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Public Function Time_Out_PM() As String
        Try
            For Each dat As Dictionary(Of String, Object) In result
                c = dat("Afternoon_Out")
            Next
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

End Class

Imports System.Data.SqlClient
Module functions

    Public Function conString()
        'conString = "Data Source=(localdb)\Projects;Initial Catalog=DailyTimeRecordPANDAN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
        ' conString = "Data Source=(LocalDB)\v11.0;Integrated Security=True"
        conString = "Data Source=(LocalDB)\v11.0;Initial Catalog=DailyTimeRecordPANDAN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        Return conString
    End Function

    Public Sub Connection()
        con = New SqlConnection
        con.ConnectionString = conString()
    End Sub

    Public Function isSELECT(column As String, table As String, condition As String) As Boolean
        Connection()

        isSELECT = False
        Try

            con.Open()
            sql = "SELECT " & column & " FROM " & table & " WHERE " & condition & ""
            cmd = New SqlCommand(sql, con)
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                isSELECT = True
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Function

    Public Function isINSERT(table As String, column As String) As Boolean
        Connection()

        isINSERT = False

        Try
            con.Open()
            sql = "INSERT INTO " & table & " VALUES (" & column & ")"

            cmd = New SqlCommand(sql, con)
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Photo", SqlDbType.Image)).Value = IO.File.ReadAllBytes(Photos.FileName)

            If cmd.ExecuteNonQuery() Then
                isINSERT = True
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Function

    Public Function isUPDATE(table As String, column As String, condition As String) As Boolean
        Connection()
        isUPDATE = False

        Try
            con.Open()

            sql = "UPDATE " & table & " SET " & column & " WHERE " & condition & ""
            cmd = New SqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                isUPDATE = True
            End If

            con.Close()


        Catch ex As Exception
            MsgBox("Duplicate Fullname Found!", MsgBoxStyle.Critical, "Opps!")
        Finally
            con.Dispose()
        End Try
    End Function

    Public Function isUPDATE_Employee(table As String, column As String, condition As String) As Boolean
        Connection()
        isUPDATE_Employee = False

        Try
            con.Open()

            sql = "UPDATE " & table & " SET " & column & " WHERE " & condition & ""
            cmd = New SqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                isUPDATE_Employee = True
            End If

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Function



    Public Function isDataShow(column As String, table As String, condition As String) As Boolean
        Connection()
        isDataShow = False
        Try
            con.Open()

            isDataShow = True
            sql = "SELECT " & column & " FROM " & table & " WHERE " & condition & ""
            cmd = New SqlCommand(sql, con)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dt)

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function isDELETE(table As String, condition As String) As Boolean
        Connection()
        isDELETE = False
        Try
            con.Open()

            isDELETE = True
            sql = "DELETE FROM " & table & " WHERE " & condition & ""
            cmd = New SqlCommand(sql, con)
            If cmd.ExecuteNonQuery Then
                isDELETE = True
            End If

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function





End Module

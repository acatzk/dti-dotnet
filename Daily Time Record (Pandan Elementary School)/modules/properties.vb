Imports System.Data.SqlClient
Imports System.IO
Module properties

    Public cmd As SqlCommand
    Public con As SqlConnection
    Public adapter As SqlDataAdapter
    Public dt As DataTable
    Public sql As String = ""
    Public reader As SqlDataReader
    Public Photos As OpenFileDialog = New OpenFileDialog
    Public imgloc As String
    Public tempdate As Date
    Public tempdatehired As Date
    Public Photoss As OpenFileDialog = New OpenFileDialog

End Module

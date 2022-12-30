Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient


Public Class JenisMobil
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sewamobil"

    Private jenis As String

    Property GSJenis As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property

    Public Function getDataKoleksiDatabase() As DataTable

        Dim result As New DataTable

        dbConn.ConnectionString = "server" + server + ";" + "user id" + username + ";" + "password" + password + ";" + "database" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id as 'ID', jenis_mobil as 'Jenis Mobil' FROM `jenis mobil`"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


End Class

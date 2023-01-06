Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient


Public Class JenisMobil
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlQuery As String

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

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id as 'ID', jenis_mobil as 'Jenis Mobil', created_at AS 'Tanggal ditambahkan' FROM `jenis mobil`"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function



    Public Function inputData(jenis As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO `jenis mobil` (jenis_mobil, created_at) VALUE('" & jenis & "','" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function deleteData(id As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM `jenis mobil` WHERE id = '" & id & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class


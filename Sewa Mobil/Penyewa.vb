Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Penyewa
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sewamobil"

    Private nama, alamat As String
    Private nik As Integer

    Property GSNIK As Integer
        Get
            Return nik
        End Get
        Set(value As Integer)
            nik = value
        End Set
    End Property

    Property GSNama As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Property GSAlamat As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property


    Public Function getDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penyewa as 'ID', nik as 'NIK', nama AS 'Nama', alamat AS 'Alamat' FROM penyewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function getDataKoleksiDatabaseByID(id As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penyewa, nik, nama, alamat FROM penyewa WHERE id_penyewa = '" & id & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read

            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function inputData(nik As Integer, nama As String, alamat As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO penyewa (nik, nama, alamat) VALUE(" & nik & ",'" & nama & "','" & alamat & "')"
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

    Public Function updateData(id As Integer, nik As Integer, nama As String, alamat As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE penyewa SET nik = " & nik & ", nama ='" & nama & "' , alamat = '" & alamat & "' WHERE id_penyewa = '" & id & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'FormPerpustakaan.SqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()



        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function deleteData(id As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM penyewa WHERE id_penyewa = '" & id & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.Message)

        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class

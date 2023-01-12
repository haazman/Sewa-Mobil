Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class SewaMobil

    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sewamobil"

    Public Function getDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database + ";Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT sewa.id as 'ID', mobil.merek as 'Merek Mobil', penyewa.nama 'Nama', rencana_pinjam 'Rencana Pinjam', tanggal_pinjam 'Tanggal Pinjam',tanggal_kembali 'Tanggal Kembali', total_biaya_sewa as 'Total Biaya',biaya_kelebihan_pinjam as 'Kembalian', total_bayar as 'Total Bayar', status_sewa as 'Status Sewa'  FROM sewa INNER JOIN `mobil` ON sewa.merek =`mobil`.id INNER JOIN penyewa ON sewa.penyewa = penyewa.id_penyewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function inputData(merek As Integer, penyewa As Integer, rencanaPinjam As String, tanggalPinjam As String, tanggalKembali As String, statusSewa As String, total_bayar As Integer, total_biaya As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Dim biaya_kelebihan_pinjam = total_bayar - total_biaya
        Try
            Dim harga As String = getHargaMobil(merek)
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "insert into sewa (merek, penyewa,rencana_pinjam,tanggal_pinjam,tanggal_kembali, total_biaya_sewa,biaya_kelebihan_pinjam, total_bayar, status_sewa) value('" & merek & "','" & penyewa & "','" & rencanaPinjam & "','" & tanggalPinjam & "','" & tanggalKembali & "','" & total_biaya & "','" & biaya_kelebihan_pinjam & "','" & total_bayar & "','" & statusSewa & "')"
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


    Public Function getHargaMobil(merek As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT harga_sewa from mobil where id = '" & merek & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim harga_sewa
            While sqlRead.Read()
                harga_sewa = sqlRead.GetString(0)
            End While
            dbConn.Close()
            Return harga_sewa

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
            sqlQuery = "DELETE FROM `sewa` WHERE id = '" & id & "'"
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

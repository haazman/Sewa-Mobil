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
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT sewa.id, mobil.merek , penyewa.nama, rencana_pinjam, tanggal_pinjam,tanggal_kembali, total_biaya_sewa FROM sewa INNER JOIN `mobil` ON sewa.merek =`mobil`.id INNER JOIN penyewa ON sewa.penyewa = penyewa.id_penyewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
End Class

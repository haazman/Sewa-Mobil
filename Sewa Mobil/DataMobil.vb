Imports System.Runtime.Intrinsics.X86
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataMobil
    Private jenis As String
    Private foto_mobil As String
    Private merek As String
    Private jumlah As Integer
    Private harga_sewa As Decimal
    Private tahun_pembuatan As Integer
    Private tanggal_data_masuk As Date
    Private status_sewa As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "sewamobil"

    Public Property GSjenis() As Integer
        Get
            Return jenis
        End Get
        Set(value As Integer)
            jenis = value
        End Set
    End Property

    Public Property GSfoto() As String
        Get
            Return foto_mobil
        End Get
        Set(value As String)
            foto_mobil = value
        End Set
    End Property

    Public Property GSmerek() As String
        Get
            Return merek
        End Get
        Set(value As String)
            merek = value
        End Set
    End Property

    Public Property GSjumlah() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property GSharga() As Decimal
        Get
            Return harga_sewa
        End Get
        Set(value As Decimal)
            harga_sewa = value
        End Set
    End Property

    Public Property GStahun() As Integer
        Get
            Return tahun_pembuatan
        End Get
        Set(value As Integer)
            tahun_pembuatan = value
        End Set
    End Property

    Public Property GStanggal() As String
        Get
            Return tanggal_data_masuk
        End Get
        Set(value As String)
            tanggal_data_masuk = value
        End Set
    End Property

    Public Property GSstatus() As String
        Get
            Return status_sewa
        End Get
        Set(value As String)
            status_sewa = value
        End Set
    End Property

    Public Function GetDataMobilDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT mobil.id AS 'ID',
                                  jenis_mobil AS 'Jenis',
                                  foto_mobil AS 'Foto Mobil',
                                  merek AS 'Merek Mobil',
                                  jumlah AS 'Jumlah',
                                  harga_sewa AS 'Harga Sewa',
                                  tahun_pembuatan AS 'Tahun Pembuatan',
                                  tanggal_data_masuk AS 'Tanggal Masuk',
                                  status_sewa AS 'Status'
                                  FROM mobil INNER JOIN `jenis mobil` ON mobil.jenis = `jenis mobil`.id"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function



    Public Function AddDataKoleksiDatabase(
                                        jenis As String,
                                        foto As String,
                                        merek_mobil As String,
                                        jumlah_mobil As Integer,
                                        harga_sewa_mobil As Decimal,
                                        tahun_pembuatan As String,
                                        tanggal_masuk As Date,
                                        status_sewa As String
                                        )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO MOBIL (jenis, foto_mobil, merek, jumlah, harga_sewa, tahun_pembuatan, tanggal_data_masuk, status_sewa) 
                        VALUE('" _
                        & jenis & "', '" _
                        & foto & "', '" _
                        & merek_mobil & "', '" _
                        & jumlah_mobil & "', '" _
                        & harga_sewa_mobil & "',  '" _
                        & tahun_pembuatan & "', '" _
                        & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                        & status_sewa & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'FormPerpustakaan.SqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime = " + "True" + ";" + "Allow Zero Datetime = " + "True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT mobil.id,
                                  jenis,
                                  foto_mobil,
                                  merek,
                                  jumlah,
                                  harga_sewa,
                                  tahun_pembuatan,
                                  tanggal_data_masuk,
                                  status_sewa
                                  FROM mobil INNER JOIN `jenis mobil` ON mobil.jenis = `jenis mobil`.id
                                  WHERE mobil.id ='" & ID & "' "
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function  

    Public Function UpdateDataMobilByIDDatabase(
                                        id As Integer,
                                        jenis As String,
                                        foto As String,
                                        merek_mobil As String,
                                        jumlah_mobil As Integer,
                                        harga_sewa_mobil As Decimal,
                                        tahun_pembuatan As String,
                                        tanggal_masuk As Date,
                                        status_sewa As String
                                        )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE mobil SET " &
                        "jenis= '" & jenis & "',  " &
                        "foto_mobil= '" & foto & "',  " &
                        "merek= '" & merek_mobil & "',  " &
                        "jumlah= '" & jumlah_mobil & "',  " &
                        "harga_sewa= '" & harga_sewa_mobil & "',  " &
                        "tahun_pembuatan= '" & tahun_pembuatan & "',  " &
                        "tanggal_data_masuk= '" & tanggal_masuk.ToString("yyyy/MM/dd") & "',  " &
                        "status_sewa= '" & status_sewa & "'  " &
                        "WHERE mobil.id= '" & id & "'"

            Debug.Print(sqlQuery)
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


    Public Function DeleteDataMobilByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM mobil " &
                "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex
        Finally
            dbConn.Dispose()
        End Try

    End Function
End Class

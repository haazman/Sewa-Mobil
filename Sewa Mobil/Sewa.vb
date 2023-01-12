Imports System.Security.Cryptography.X509Certificates

Public Class Sewa
    Public Shared sewa As New SewaMobil
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Shared selectedTableKoleksiStatus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa = New SewaMobil()
        reloadDataTableDatabase()

    End Sub

    Private Sub Sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Public Sub reloadDataTableDatabase()
        DataGridSewa.DataSource = sewa.getDataKoleksiDatabase()
    End Sub

    Private Sub btntambahsewa_Click(sender As Object, e As EventArgs) Handles btntambahsewa.Click
        Dim tambahSewa = New TambahSewa()
        tambahSewa.Show()
    End Sub

    Private Sub btndeletesewa_Click(sender As Object, e As EventArgs) Handles btndeletesewa.Click
        Dim hapusSewa = New HapusSewa()
        hapusSewa.Show()
    End Sub

    Private Sub DataGridSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSewa.CellClick
        Dim a As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Try
            selectedRow = DataGridSewa.Rows(a)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
            selectedTableKoleksiStatus = selectedRow.Cells(9).Value

        Catch ex As Exception
            MessageBox.Show(String.Format(ex.Message))
        End Try
    End Sub

    Private Sub btneditsewa_Click(sender As Object, e As EventArgs) Handles btneditsewa.Click
        sewa.GSstatus = selectedTableKoleksiStatus
        Ubah_Status_Sewa.Show()
    End Sub
End Class
Imports Org.BouncyCastle.Asn1.IsisMtt

Public Class Jenis_Mobil
    Public Shared jenisMobil As JenisMobil
    Public selectedJenis As Integer
    Public selectedJenisNama As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisMobil = New JenisMobil()
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        dataGridJenis.DataSource = jenisMobil.getDataKoleksiDatabase()
    End Sub

    Private Sub Jenis_Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim tambahJenis As Tambah_Jenis
        tambahJenis = New Tambah_Jenis()
        tambahJenis.Show()
    End Sub

    Private Sub dataGridJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridJenis.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dataGridJenis.Rows(index)

        selectedJenis = selectedRow.Cells(0).Value
        selectedJenisNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        If selectedJenis Then
            Dim hapusJenis = New Hapus_jenis()
            hapusJenis.Show()
        Else
            MessageBox.Show("Dipilih Dulu Kak")
        End If

    End Sub
End Class
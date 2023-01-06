Public Class FormPenyewa
    Public Shared penyewa As New Penyewa
    Public Shared selectedPenyewa As Integer
    Public Shared selectedNamaPenyewa As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        penyewa = New Penyewa()
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        dataGridPenyewa.DataSource = penyewa.getDataKoleksiDatabase()
    End Sub

    Private Sub FormPenyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub

    Private Sub FormPenyewa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim mainMenu = New mainMenu()
        mainMenu.Show()
    End Sub

    Private Sub btnPenyewa_Click(sender As Object, e As EventArgs) Handles btnPenyewa.Click
        Dim tambahMenu = New Tambah_Penyewa()
        tambahMenu.Show()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim selectedData As List(Of String) = penyewa.getDataKoleksiDatabaseByID(selectedPenyewa)

        penyewa.GSNIK = selectedData(1)
        penyewa.GSNama = selectedData(2)
        penyewa.GSAlamat = selectedData(3)

        Dim ubahPenyewa = New Ubah_Penyewa
        ubahPenyewa.Show()
    End Sub

    Private Sub dataGridPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridPenyewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dataGridPenyewa.Rows(index)

        selectedPenyewa = selectedRow.Cells(0).Value
        selectedNamaPenyewa = selectedRow.Cells(1).Value
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hapusJenis = New Hapus_jenis()
        hapusJenis.ShowDialog()
    End Sub
End Class
Public Class Jenis_Mobil
    Dim jenisMobil As JenisMobil

<<<<<<< Updated upstream
=======
Public Class Jenis_Mobil
    Public Shared jenisMobil As New JenisMobil
    Public selectedJenis As Integer
    Public selectedJenisNama As String
>>>>>>> Stashed changes
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


<<<<<<< Updated upstream
=======
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

    Private Sub Jenis_Mobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainMenu.Show()
    End Sub
>>>>>>> Stashed changes
End Class
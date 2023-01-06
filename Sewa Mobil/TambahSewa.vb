Public Class TambahSewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dataTableMobil = mobil.DataMobil.GetDataMobilDatabase
        cbmerk.DataSource = dataTableMobil
        cbmerk.DisplayMember = "Merek Mobil"
        cbmerk.ValueMember = "ID"
        Dim dataTablePenyewa = FormPenyewa.penyewa.getDataKoleksiDatabase
        cbpenyewa.DataSource = dataTablePenyewa
        cbpenyewa.DisplayMember = "Nama"
        cbpenyewa.ValueMember = "ID"
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim merek = cbmerk.SelectedValue
        Dim penyewa = cbpenyewa.SelectedValue
        Dim rencanaPinjam = numRencana.Value
        Dim tanggal_pinjam = datepinjam.Value.ToString("dd-MM-yyyy")
        Dim tanggal_kembali = datekembali.Value.ToString("dd-MM-yyyy")
        Dim total_bayar = txtbayar.value
        Dim status_sewa As String
        If rbtersedia.Checked = True Then
            status_sewa = "Tersedia"
        End If
        If rbtidaktersedia.Checked = True Then
            status_sewa = "Tidak Tersedia"
        End If

        Sewa.sewa.inputData(merek, penyewa, rencanaPinjam, tanggal_pinjam, tanggal_kembali, status_sewa)
    End Sub

End Class
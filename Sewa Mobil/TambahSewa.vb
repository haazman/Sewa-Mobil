Public Class TambahSewa
    Dim hargaInt As Integer
    Dim totalHarga As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dataTableMobil = mobil.DataMobil.GetDataMobilDatabaseWhereTersedia
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
        Dim tanggal_pinjam = datepinjam.Value.ToString("yyyy-MM-dd")
        Dim tanggal_kembali = datekembali.Value.ToString("yyyy-MM-dd")
        Dim total_bayar = Convert.ToInt32(txtBayar.Text)
        Dim status_sewa As String
        status_sewa = "Disewa"


        If hargaInt * numRencana.Value > total_bayar Then
            MessageBox.Show("Total Bayar Kurang")
        Else
            Sewa.sewa.inputData(merek, penyewa, rencanaPinjam, tanggal_pinjam, tanggal_kembali, status_sewa, total_bayar, totalHarga)
            Me.Close()
        End If


    End Sub

    Private Sub cbmerk_ValueMemberChanged(sender As Object, e As EventArgs) Handles cbmerk.ValueMemberChanged
        Dim harga = Sewa.sewa.getHargaMobil(cbmerk.SelectedValue)
        lblBiaya.Text = "RP. " & numRencana.Value * harga & ",00"
    End Sub

    Private Sub cbmerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmerk.SelectedIndexChanged
        Dim harga = Sewa.sewa.getHargaMobil(cbmerk.SelectedValue.ToString)
        hargaInt = Convert.ToInt32(harga)
        totalHarga = hargaInt * numRencana.Value

        lblBiaya.Text = "RP. " & totalHarga & ",00"
    End Sub

    Private Sub numRencana_TextChanged(sender As Object, e As EventArgs) Handles numRencana.TextChanged
        lblBiaya.Text = "RP. " & hargaInt * numRencana.Value & ",00"
        totalHarga = hargaInt * numRencana.Value
    End Sub
End Class
Public Class TambahSewa
    Dim hargaInt As Integer
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
        Dim total_bayar = txtbayar.Value
        Dim status_sewa As String
        If rbtersedia.Checked = True Then
            status_sewa = "Tersedia"
        End If
        If rbtidaktersedia.Checked = True Then
            status_sewa = "Tidak Tersedia"
        End If

        If hargaInt * numRencana.Value > total_bayar Then
            MessageBox.Show("Total Bayar Kurang")
        Else
            'Sewa.sewa.inputData(merek, penyewa, rencanaPinjam, tanggal_pinjam, tanggal_kembali, status_sewa, total_bayar)
        End If


    End Sub

    Private Sub cbmerk_ValueMemberChanged(sender As Object, e As EventArgs) Handles cbmerk.ValueMemberChanged
        Dim harga = Sewa.sewa.getHargaMobil(cbmerk.SelectedValue)
        MessageBox.Show(cbmerk.SelectedValue)
        lblBiaya.Text = "RP. " & numRencana.Value * harga & ",00"
    End Sub

    Private Sub cbmerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmerk.SelectedIndexChanged
        Dim harga = Sewa.sewa.getHargaMobil(cbmerk.SelectedValue.ToString)
        hargaInt = Convert.ToInt32(harga)

        lblBiaya.Text = "RP. " & hargaInt * numRencana.Value & ",00"
    End Sub

    Private Sub numRencana_TextChanged(sender As Object, e As EventArgs) Handles numRencana.TextChanged
        lblBiaya.Text = "RP. " & hargaInt * numRencana.Value & ",00"
    End Sub
End Class
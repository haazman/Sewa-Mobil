Public Class EditMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fotoMobil.Load(mobil.DataMobil.GSfoto)
        fotoMobil.SizeMode = PictureBoxSizeMode.StretchImage
        dtpTanggalMasuk.Format = DateTimePickerFormat.Custom
        dtpTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        tbMerek.Text = mobil.DataMobil.GSmerek
        tbHargaSewa.Text = mobil.DataMobil.GSharga
        tbTahunPembuatan.Text = mobil.DataMobil.GStahun

        GetDataJenis()
    End Sub


    Public Sub GetDataJenis()
        cbJenis.DataSource = Jenis_Mobil.jenisMobil.getDataKoleksiDatabase()
        cbJenis.ValueMember = "ID"
        cbJenis.DisplayMember = "Jenis Mobil"
        cbJenis.SelectedValue = mobil.DataMobil.GSjenis
    End Sub


    Private Sub editCarBtn_Click(sender As Object, e As EventArgs) Handles editCarBtn.Click
        mobil.DataMobil.GSjenis = Integer.Parse(cbJenis.SelectedValue)
        mobil.DataMobil.GSmerek = tbMerek.Text.ToString()
        mobil.DataMobil.GSharga = Double.Parse(tbHargaSewa.Text)
        mobil.DataMobil.GStahun = Integer.Parse(tbTahunPembuatan.Text)
        mobil.DataMobil.GStanggal = dtpTanggalMasuk.Value.ToString("yyyy/MM/dd")

        If (tbTahunPembuatan.Text >= 1901) Then
            mobil.DataMobil.UpdateDataMobilByIDDatabase(mobil.selectedTableKoleksi, mobil.DataMobil.GSjenis, mobil.DataMobil.GSfoto,
                                             mobil.DataMobil.GSmerek, mobil.DataMobil.GSharga,
                                             mobil.DataMobil.GStahun, mobil.DataMobil.GStanggal)
            Me.Close()
            mobil.Show()
        Else
            MessageBox.Show("Add a Valid Year!")
        End If
    End Sub

    Private Sub EditMobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mobil.Show()
    End Sub

    Private Sub fotoMobil_Click(sender As Object, e As EventArgs) Handles fotoMobil.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.JPG|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        fotoMobil.Load(OpenFileDialog1.FileName)
        fotoMobil.SizeMode = PictureBoxSizeMode.StretchImage
        mobil.DataMobil.GSfoto = OpenFileDialog1.FileName.ToString()
        mobil.DataMobil.GSfoto = mobil.DataMobil.GSfoto.Replace("\", "/")
    End Sub
End Class
Public Class TambahDataMobil


    Public Shared foto_mobil
    Public Shared JenisMobil As New Jenis_Mobil()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetDataJenis()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GetDataJenis()
        cbJenis.DataSource = Jenis_Mobil.jenisMobil.getDataKoleksiDatabase()
        cbJenis.ValueMember = "ID"
        cbJenis.DisplayMember = "Jenis Mobil"
    End Sub

    Private Sub TambahDataMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub fotoMobil_Click(sender As Object, e As EventArgs) Handles fotoMobil.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.JPG|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        foto_mobil = OpenFileDialog1.FileName
        fotoMobil.Load(foto_mobil)
        fotoMobil.SizeMode = PictureBoxSizeMode.StretchImage
        mobil.DataMobil.GSfoto = foto_mobil.ToString()
        mobil.DataMobil.GSfoto = mobil.DataMobil.GSfoto.Replace("\", "/")
    End Sub

    Private Sub addCarBtn_Click(sender As Object, e As EventArgs) Handles addCarBtn.Click
        Try
            mobil.DataMobil.GSjenis = cbJenis.SelectedValue
            mobil.DataMobil.GSmerek = tbMerek.Text
            mobil.DataMobil.GSharga = tbHargaSewa.Text
            mobil.DataMobil.GStahun = tbTahunPembuatan.Text
            mobil.DataMobil.GStanggal = dtpTanggalMasuk.Value.ToString("yyyy/MM/dd")

            If (tbTahunPembuatan.Text >= 1901 And foto_mobil IsNot Nothing) Then
                mobil.DataMobil.AddDataKoleksiDatabase(mobil.DataMobil.GSjenis, mobil.DataMobil.GSfoto,
                                             mobil.DataMobil.GSmerek, mobil.DataMobil.GSharga,
                                            mobil.DataMobil.GStahun, mobil.DataMobil.GStanggal)
                foto_mobil = Nothing
                Me.Close()
                mobil.Show()
            ElseIf tbTahunPembuatan.Text < 1901 Then
                MessageBox.Show("Add a Valid Year!")
            ElseIf foto_mobil Is Nothing Then
                MessageBox.Show("Masukkan Foto!")
            End If

        Catch ex As Exception
            MessageBox.Show("Input data!")
        End Try


    End Sub

    Private Sub tbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim Ch As Char = e.KeyChar

        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbTahunPembuatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTahunPembuatan.KeyPress
        Dim Ch As Char = e.KeyChar

        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbHargaSewa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHargaSewa.KeyPress
        Dim Ch As Char = e.KeyChar

        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TambahDataMobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mobil.Show()
    End Sub

End Class
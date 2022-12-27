Public Class Tambah_Jenis
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim jenis = txtJenis.Text
        Jenis_Mobil.jenisMobil.inputData(jenis)
        Me.Close()
    End Sub
End Class
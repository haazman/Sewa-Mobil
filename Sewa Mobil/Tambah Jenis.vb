Public Class Tambah_Jenis
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim jenis = txtJenis.Text
        Jenis_Mobil.jenisMobil.inputData(jenis)
        Me.Close()
    End Sub

    Private Sub Tambah_Jenis_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Jenis_Mobil.Show()
    End Sub
End Class
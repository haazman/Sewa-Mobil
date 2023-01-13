Imports Org.BouncyCastle.Math

Public Class Tambah_Penyewa
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nik = Convert.ToInt32(txtNIK.Text)
        Dim nama = txtNama.Text
        Dim alamat = RtxtAlamat.Text
        FormPenyewa.penyewa.inputData(nik, nama, alamat)
        Me.Close()
    End Sub

    Private Sub Tambah_Penyewa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPenyewa.Show()
    End Sub
End Class
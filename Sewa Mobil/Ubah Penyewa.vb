Public Class Ubah_Penyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtNIK.Text = FormPenyewa.penyewa.GSNIK
        txtNama.Text = FormPenyewa.penyewa.GSNama
        RtxtAlamat.Text = FormPenyewa.penyewa.GSAlamat
    End Sub

    Private Sub Ubah_Penyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtNIK.Text = FormPenyewa.penyewa.GSNIK
        txtNama.Text = FormPenyewa.penyewa.GSNama
        RtxtAlamat.Text = FormPenyewa.penyewa.GSAlamat
    End Sub


    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim id = FormPenyewa.selectedPenyewa
        Dim nik = txtNIK.Text
        Dim nama = txtNama.Text
        Dim alamat = RtxtAlamat.Text
        FormPenyewa.penyewa.updateData(id, nik, nama, alamat)
        Me.Close()
    End Sub
End Class
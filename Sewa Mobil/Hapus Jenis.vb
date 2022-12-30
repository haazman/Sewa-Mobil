Public Class Hapus_jenis
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblNama.Text = Jenis_Mobil.selectedJenisNama + " ?"
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Jenis_Mobil.jenisMobil.deleteData(Jenis_Mobil.selectedJenis)
        Me.Close()
    End Sub


    Private Sub Hapus_jenis_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Jenis_Mobil.Show()
    End Sub

End Class
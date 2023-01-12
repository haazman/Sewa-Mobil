Public Class HapusSewa
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblhapus.Text = Sewa.selectedTableKoleksiNama + " ?"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub lblhapus_Click(sender As Object, e As EventArgs) Handles lblhapus.Click

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Sewa.sewa.deleteData(Sewa.selectedTableKoleksi)

        Me.Close()
    End Sub
End Class
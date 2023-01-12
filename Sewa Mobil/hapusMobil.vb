Public Class hapusMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHapus.Text = mobil.selectedTableKoleksiNama + "?"
    End Sub

    Private Sub lblHapus_Click(sender As Object, e As EventArgs) Handles lblHapus.Click

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        mobil.DataMobil.DeleteDataMobilByIDDatabase(mobil.selectedTableKoleksi)

        Me.Close()
    End Sub
End Class
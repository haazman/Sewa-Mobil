Public Class Hapus_Penyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHapus.Text = FormPenyewa.selectedNamaPenyewa + " ?"
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim id = FormPenyewa.selectedPenyewa
        FormPenyewa.penyewa.deleteData(id)
        Me.Close()
    End Sub

    Private Sub Hapus_Penyewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Hapus_Penyewa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPenyewa.Show()
    End Sub
End Class
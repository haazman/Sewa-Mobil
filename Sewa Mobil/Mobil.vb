Public Class mobil
    Public Shared DataMobil = New DataMobil()
    Private Sub mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridMobil.DataSource = DataMobil.GetDataMobilDatabase()
    End Sub

    Private Sub mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub addCarBtn_Click(sender As Object, e As EventArgs) Handles addCarBtn.Click
        Me.Hide()
        TambahDataMobil.Show()
    End Sub
End Class
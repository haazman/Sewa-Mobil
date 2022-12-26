Public Class Jenis_Mobil
    Dim jenisMobil As JenisMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisMobil = New JenisMobil()
        reloadDataTableDatabase()
    End Sub

    Private Sub reloadDataTableDatabase()
        dataGridJenis.DataSource = jenisMobil.getDataKoleksiDatabase()
    End Sub

    Private Sub Jenis_Mobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadDataTableDatabase()
    End Sub


End Class
Public Class Sewa
    Public Shared sewa As New SewaMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa = New SewaMobil()
        reloadDataTableDatabase()

    End Sub

    Private Sub Sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridSewa.DataSource = sewa.getDataKoleksiDatabase()
    End Sub

    Public Sub reloadDataTableDatabase()
        DataGridSewa.DataSource = sewa.getDataKoleksiDatabase()
    End Sub

    Private Sub btntambahsewa_Click(sender As Object, e As EventArgs) Handles btntambahsewa.Click
        Dim tambahSewa = New TambahSewa()
        tambahSewa.Show()
    End Sub
End Class
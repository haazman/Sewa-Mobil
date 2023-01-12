Imports MySql.Data.MySqlClient

Public Class mobil
    Public Shared DataMobil As New DataMobil
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataMobil = New DataMobil()
    End Sub

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

    Private Sub editCarBtn_Click(sender As Object, e As EventArgs) Handles editCarBtn.Click
        Dim selectedData As List(Of String) = DataMobil.GetDataMobilByIDDatabase(selectedTableKoleksi)
        Try
            DataMobil.GSfoto = selectedData(2)

            DataMobil.GSjenis = selectedData(1)
            DataMobil.GSmerek = selectedData(3)
            DataMobil.GSharga = selectedData(4)
            DataMobil.GStahun = selectedData(5)
            DataMobil.GStanggal = selectedData(6)

            Me.Hide()
            EditMobil.Show()
        Catch ex As Exception
            MessageBox.Show(String.Format(ex.Message))
        End Try
    End Sub

    Private Sub DataGridMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMobil.CellClick
        Dim i As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Try
            selectedRow = DataGridMobil.Rows(i)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(3).Value
        Catch ex As Exception
            MessageBox.Show(String.Format(ex.Message))
        End Try
    End Sub

    Private Sub deleteCarBtn_Click(sender As Object, e As EventArgs) Handles deleteCarBtn.Click
        hapusMobil.Show()
    End Sub

    Private Sub mobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainMenu.Show()
    End Sub
End Class
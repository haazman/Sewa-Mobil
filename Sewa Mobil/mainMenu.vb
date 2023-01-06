Public Class mainMenu
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        SignIn.Show()


    End Sub

    Private Sub jenisBtn_Click(sender As Object, e As EventArgs) Handles jenisBtn.Click
        Dim jenisMobil = New Jenis_Mobil()
        jenisMobil.Show()
        Me.Hide()
    End Sub

    Private Sub penyewaBtn_Click(sender As Object, e As EventArgs) Handles penyewaBtn.Click
        Dim penyewa = New FormPenyewa()
        penyewa.Show()
        Me.Hide()
    End Sub
End Class
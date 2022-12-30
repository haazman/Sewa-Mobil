Public Class mainMenu
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        SignIn.Show()


    End Sub

    Private Sub mobilBtn_Click(sender As Object, e As EventArgs) Handles mobilBtn.Click
        Me.Hide()

        mobil.Show()
    End Sub

    Private Sub jenisBtn_Click(sender As Object, e As EventArgs) Handles jenisBtn.Click
        Me.Hide()
        Jenis_Mobil.Show()
    End Sub
End Class
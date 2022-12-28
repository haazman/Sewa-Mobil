Public Class mainMenu
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        SignIn.Show()


    End Sub
End Class
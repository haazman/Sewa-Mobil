Imports Microsoft.VisualBasic.Logging

Public Class SignUp

    Public Shared foto

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbPass.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles fotoUser.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.JPG|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        foto = OpenFileDialog1.FileName

        fotoUser.Load(foto)
        fotoUser.SizeMode = PictureBoxSizeMode.StretchImage
        SignIn.Users.GSfoto = foto.ToString()
        SignIn.Users.GSfoto = SignIn.Users.GSFoto.Replace("\", "/")
    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        If tbUsername.Text.Length > 0 And tbPassword.Text.Length > 0 Then
            SignIn.Users.AddUsersDatabase(tbUsername.Text, tbEmail.Text, tbPass.Text, SignIn.Users.GSFoto)
            Me.Hide()

            Me.Controls.Clear()
            Me.InitializeComponent()

            SignIn.Show()
        Else
            MessageBox.Show("Insert Data!")
        End If
    End Sub

    Private Sub backText_Click(sender As Object, e As EventArgs) Handles backText.Click
        Me.Hide()
        SignIn.Show()

        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub showPassCheck_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheck.CheckedChanged
        tbPass.UseSystemPasswordChar = Not showPassCheck.Checked
    End Sub
End Class
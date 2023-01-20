Imports System.Net.Mail
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
            If tbPass.Text.Length >= 8 Then
                Try
                    Dim testAddress = New MailAddress(tbEmail.Text)
                    SignIn.Users.AddUsersDatabase(tbUsername.Text, tbEmail.Text, tbPass.Text, SignIn.Users.GSFoto)
                    Me.Hide()

                    Me.Controls.Clear()
                    Me.InitializeComponent()

                    SignIn.Show()
                Catch ex As FormatException
                    MessageBox.Show("Not a valid email address")
                End Try

            Else
                MessageBox.Show("Password must be at least 8 characters long!")
            End If
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

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged

    End Sub

    Private Sub tbUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUsername.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
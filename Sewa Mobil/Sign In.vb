Public Class SignIn
    Public Shared Users = New Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbPassword.UseSystemPasswordChar = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim plainUsername As String = tbUsername.Text
        Dim plainPassword As String = tbPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSusername = data_user(1)
            Me.Hide()
            mainMenu.Show()

            Me.Controls.Clear()
            Me.InitializeComponent()
            tbPassword.UseSystemPasswordChar = Not showPassCheck.Checked
        Else
            MessageBox.Show("Wrong Username or Password")
        End If

    End Sub


    Private Sub signUpText_Click(sender As Object, e As EventArgs) Handles signUpText.Click
        SignUp.Show()
        Me.Hide()

        Me.Controls.Clear()
        Me.InitializeComponent()
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub showPassCheck_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheck.CheckedChanged
        tbPassword.UseSystemPasswordChar = Not showPassCheck.Checked
    End Sub

End Class
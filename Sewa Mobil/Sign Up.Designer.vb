<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fotoUser = New System.Windows.Forms.PictureBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signUpBtn = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.backText = New System.Windows.Forms.Label()
        Me.showPassCheck = New System.Windows.Forms.CheckBox()
        CType(Me.fotoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fotoUser
        '
        Me.fotoUser.Location = New System.Drawing.Point(6, 16)
        Me.fotoUser.Name = "fotoUser"
        Me.fotoUser.Size = New System.Drawing.Size(90, 108)
        Me.fotoUser.TabIndex = 0
        Me.fotoUser.TabStop = False
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(80, 284)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(188, 23)
        Me.tbPass.TabIndex = 13
        '
        'tbPassword
        '
        Me.tbPassword.AutoSize = True
        Me.tbPassword.Location = New System.Drawing.Point(80, 265)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(57, 15)
        Me.tbPassword.TabIndex = 12
        Me.tbPassword.Text = "Password"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(80, 167)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(188, 23)
        Me.tbUsername.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'signUpBtn
        '
        Me.signUpBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.signUpBtn.Location = New System.Drawing.Point(197, 342)
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.Size = New System.Drawing.Size(71, 25)
        Me.signUpBtn.TabIndex = 9
        Me.signUpBtn.Text = "Sign Up"
        Me.signUpBtn.UseVisualStyleBackColor = False

        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(80, 222)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(188, 23)
        Me.tbEmail.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fotoUser)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)

        Me.GroupBox1.Location = New System.Drawing.Point(125, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 134)

        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Your Picture Here"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'backText
        '
        Me.backText.AutoSize = True
        Me.backText.Cursor = System.Windows.Forms.Cursors.Hand

        Me.backText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText

        Me.backText.Location = New System.Drawing.Point(4, 7)
        Me.backText.Name = "backText"
        Me.backText.Size = New System.Drawing.Size(43, 15)
        Me.backText.TabIndex = 17
        Me.backText.Text = "< Back"
        '
        'showPassCheck
        '
        Me.showPassCheck.AutoSize = True
        Me.showPassCheck.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.showPassCheck.Location = New System.Drawing.Point(80, 313)
        Me.showPassCheck.Name = "showPassCheck"
        Me.showPassCheck.Size = New System.Drawing.Size(86, 16)
        Me.showPassCheck.TabIndex = 18
        Me.showPassCheck.Text = "Show Password"
        Me.showPassCheck.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 389)
        Me.Controls.Add(Me.showPassCheck)
        Me.Controls.Add(Me.backText)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signUpBtn)

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        Me.Text = "Sign Up"
        CType(Me.fotoUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fotoUser As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tbPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents signUpBtn As Button
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents backText As Label
    Friend WithEvents showPassCheck As CheckBox
End Class

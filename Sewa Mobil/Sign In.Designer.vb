<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.signUpText = New System.Windows.Forms.Label()
        Me.showPassCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.loginBtn.Location = New System.Drawing.Point(208, 216)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(86, 29)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Log In"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(106, 154)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(188, 23)
        Me.tbPassword.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(40, 160)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 15)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Password"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(106, 86)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(188, 23)
        Me.tbUsername.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(117, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subur Makmur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(140, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Car Rental"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Don't have an account?"
        '
        'signUpText
        '
        Me.signUpText.AutoSize = True
        Me.signUpText.BackColor = System.Drawing.Color.Transparent
        Me.signUpText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signUpText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.signUpText.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.signUpText.Location = New System.Drawing.Point(126, 256)
        Me.signUpText.Name = "signUpText"
        Me.signUpText.Size = New System.Drawing.Size(48, 13)
        Me.signUpText.TabIndex = 13
        Me.signUpText.Text = "Sign Up"
        '
        'showPassCheck
        '
        Me.showPassCheck.AutoSize = True
        Me.showPassCheck.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.showPassCheck.Location = New System.Drawing.Point(106, 183)
        Me.showPassCheck.Name = "showPassCheck"
        Me.showPassCheck.Size = New System.Drawing.Size(86, 16)
        Me.showPassCheck.TabIndex = 14
        Me.showPassCheck.Text = "Show Password"
        Me.showPassCheck.UseVisualStyleBackColor = True
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 287)
        Me.Controls.Add(Me.showPassCheck)
        Me.Controls.Add(Me.signUpText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginBtn As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents signUpText As Label
    Friend WithEvents showPassCheck As CheckBox
End Class
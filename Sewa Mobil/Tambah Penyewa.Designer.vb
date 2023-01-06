<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Penyewa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.RtxtAlamat = New System.Windows.Forms.RichTextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(129, 25)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(247, 27)
        Me.txtNIK.TabIndex = 3
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(129, 66)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(247, 27)
        Me.txtNama.TabIndex = 4
        '
        'RtxtAlamat
        '
        Me.RtxtAlamat.Location = New System.Drawing.Point(129, 113)
        Me.RtxtAlamat.Name = "RtxtAlamat"
        Me.RtxtAlamat.Size = New System.Drawing.Size(247, 151)
        Me.RtxtAlamat.TabIndex = 5
        Me.RtxtAlamat.Text = ""
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(129, 284)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(101, 35)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Tambah_Penyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 384)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.RtxtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tambah_Penyewa"
        Me.Text = "Tambah Penyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents RtxtAlamat As RichTextBox
    Friend WithEvents btnTambah As Button
End Class

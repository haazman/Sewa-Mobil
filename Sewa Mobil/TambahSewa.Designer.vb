<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahSewa
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrencana = New System.Windows.Forms.TextBox()
        Me.datepinjam = New System.Windows.Forms.DateTimePicker()
        Me.datekembali = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.cbpenyewa = New System.Windows.Forms.ComboBox()
        Me.cbmerk = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penyewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(33, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rencana Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Peminjaman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(33, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Kembali"
        '
        'txtrencana
        '
        Me.txtrencana.Location = New System.Drawing.Point(214, 198)
        Me.txtrencana.Name = "txtrencana"
        Me.txtrencana.Size = New System.Drawing.Size(208, 23)
        Me.txtrencana.TabIndex = 7
        '
        'datepinjam
        '
        Me.datepinjam.Location = New System.Drawing.Point(214, 256)
        Me.datepinjam.Name = "datepinjam"
        Me.datepinjam.Size = New System.Drawing.Size(200, 23)
        Me.datepinjam.TabIndex = 8
        '
        'datekembali
        '
        Me.datekembali.Location = New System.Drawing.Point(214, 305)
        Me.datekembali.Name = "datekembali"
        Me.datekembali.Size = New System.Drawing.Size(200, 23)
        Me.datekembali.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(33, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tambah Sewa"
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(347, 358)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 11
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'cbpenyewa
        '
        Me.cbpenyewa.FormattingEnabled = True
        Me.cbpenyewa.Location = New System.Drawing.Point(214, 138)
        Me.cbpenyewa.Name = "cbpenyewa"
        Me.cbpenyewa.Size = New System.Drawing.Size(208, 23)
        Me.cbpenyewa.TabIndex = 12
        '
        'cbmerk
        '
        Me.cbmerk.FormattingEnabled = True
        Me.cbmerk.Location = New System.Drawing.Point(214, 85)
        Me.cbmerk.Name = "cbmerk"
        Me.cbmerk.Size = New System.Drawing.Size(208, 23)
        Me.cbmerk.TabIndex = 13
        '
        'TambahSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 404)
        Me.Controls.Add(Me.cbmerk)
        Me.Controls.Add(Me.cbpenyewa)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datekembali)
        Me.Controls.Add(Me.datepinjam)
        Me.Controls.Add(Me.txtrencana)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahSewa"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtrencana As TextBox
    Friend WithEvents datepinjam As DateTimePicker
    Friend WithEvents datekembali As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents cbpenyewa As ComboBox
    Friend WithEvents cbmerk As ComboBox
End Class

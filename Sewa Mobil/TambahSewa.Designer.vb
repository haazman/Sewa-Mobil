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
        Me.datepinjam = New System.Windows.Forms.DateTimePicker()
        Me.datekembali = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.cbpenyewa = New System.Windows.Forms.ComboBox()
        Me.cbmerk = New System.Windows.Forms.ComboBox()
        Me.numRencana = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        CType(Me.numRencana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(38, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(38, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penyewa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(38, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rencana Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Peminjaman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(38, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Kembali"
        '
        'datepinjam
        '
        Me.datepinjam.Location = New System.Drawing.Point(245, 341)
        Me.datepinjam.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datepinjam.Name = "datepinjam"
        Me.datepinjam.Size = New System.Drawing.Size(228, 27)
        Me.datepinjam.TabIndex = 8
        '
        'datekembali
        '
        Me.datekembali.Location = New System.Drawing.Point(245, 407)
        Me.datekembali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datekembali.Name = "datekembali"
        Me.datekembali.Size = New System.Drawing.Size(228, 27)
        Me.datekembali.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(38, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tambah Sewa"
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(396, 545)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(86, 31)
        Me.btntambah.TabIndex = 11
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'cbpenyewa
        '
        Me.cbpenyewa.FormattingEnabled = True
        Me.cbpenyewa.Location = New System.Drawing.Point(245, 184)
        Me.cbpenyewa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbpenyewa.Name = "cbpenyewa"
        Me.cbpenyewa.Size = New System.Drawing.Size(237, 28)
        Me.cbpenyewa.TabIndex = 12
        '
        'cbmerk
        '
        Me.cbmerk.FormattingEnabled = True
        Me.cbmerk.Location = New System.Drawing.Point(245, 113)
        Me.cbmerk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbmerk.Name = "cbmerk"
        Me.cbmerk.Size = New System.Drawing.Size(237, 28)
        Me.cbmerk.TabIndex = 13
        '
        'numRencana
        '
        Me.numRencana.Location = New System.Drawing.Point(245, 264)
        Me.numRencana.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numRencana.Name = "numRencana"
        Me.numRencana.Size = New System.Drawing.Size(238, 27)
        Me.numRencana.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(47, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 28)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(47, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 28)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Total Biaya"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBiaya.Location = New System.Drawing.Point(245, 454)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(59, 28)
        Me.lblBiaya.TabIndex = 23
        Me.lblBiaya.Text = "Biaya"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(245, 498)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(228, 27)
        Me.txtBayar.TabIndex = 24
        '
        'TambahSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 589)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numRencana)
        Me.Controls.Add(Me.cbmerk)
        Me.Controls.Add(Me.cbpenyewa)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datekembali)
        Me.Controls.Add(Me.datepinjam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TambahSewa"
        Me.Text = "v"
        CType(Me.numRencana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datepinjam As DateTimePicker
    Friend WithEvents datekembali As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents cbpenyewa As ComboBox
    Friend WithEvents cbmerk As ComboBox
    Friend WithEvents numRencana As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents txtBayar As TextBox
End Class

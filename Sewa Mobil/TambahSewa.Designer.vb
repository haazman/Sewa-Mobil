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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numRencana = New System.Windows.Forms.NumericUpDown()
        Me.rbtersedia = New System.Windows.Forms.RadioButton()
        Me.rbtidaktersedia = New System.Windows.Forms.RadioButton()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        CType(Me.numRencana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        CType(Me.txtbayar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btntambah.Location = New System.Drawing.Point(339, 528)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(33, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Status Sewa"
        '
        'numRencana
        '
        Me.numRencana.Location = New System.Drawing.Point(214, 198)
        Me.numRencana.Name = "numRencana"
        Me.numRencana.Size = New System.Drawing.Size(208, 23)
        Me.numRencana.TabIndex = 16
        '
        'rbtersedia
        '
        Me.rbtersedia.AutoSize = True
        Me.rbtersedia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbtersedia.Location = New System.Drawing.Point(15, 22)
        Me.rbtersedia.Name = "rbtersedia"
        Me.rbtersedia.Size = New System.Drawing.Size(68, 19)
        Me.rbtersedia.TabIndex = 17
        Me.rbtersedia.TabStop = True
        Me.rbtersedia.Text = "Tersedia"
        Me.rbtersedia.UseVisualStyleBackColor = True
        '
        'rbtidaktersedia
        '
        Me.rbtidaktersedia.AutoSize = True
        Me.rbtidaktersedia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbtidaktersedia.Location = New System.Drawing.Point(15, 47)
        Me.rbtidaktersedia.Name = "rbtidaktersedia"
        Me.rbtidaktersedia.Size = New System.Drawing.Size(100, 19)
        Me.rbtidaktersedia.TabIndex = 18
        Me.rbtidaktersedia.TabStop = True
        Me.rbtidaktersedia.Text = "Tidak Tersedia"
        Me.rbtidaktersedia.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.rbtidaktersedia)
        Me.GroupBox.Controls.Add(Me.rbtersedia)
        Me.GroupBox.Location = New System.Drawing.Point(214, 357)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox.TabIndex = 19
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(41, 496)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Bayar"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(214, 499)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(208, 23)
        Me.txtbayar.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(41, 466)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 21)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Total Biaya"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBiaya.Location = New System.Drawing.Point(214, 466)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(48, 21)
        Me.lblBiaya.TabIndex = 23
        Me.lblBiaya.Text = "Biaya"
        '
        'TambahSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 582)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numRencana)
        Me.Controls.Add(Me.Label7)
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
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "TambahSewa"
        Me.Text = "v"
        CType(Me.numRencana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.txtbayar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents numRencana As NumericUpDown
    Friend WithEvents rbtersedia As RadioButton
    Friend WithEvents rbtidaktersedia As RadioButton
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbayar As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBiaya As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahDataMobil
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fotoMobil = New System.Windows.Forms.PictureBox()
        Me.tbMerek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHargaSewa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addCarBtn = New System.Windows.Forms.Button()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fotoMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fotoMobil)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 155)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Your Picture Here"
        '
        'fotoMobil
        '
        Me.fotoMobil.Location = New System.Drawing.Point(1, 13)
        Me.fotoMobil.Name = "fotoMobil"
        Me.fotoMobil.Size = New System.Drawing.Size(105, 140)
        Me.fotoMobil.TabIndex = 0
        Me.fotoMobil.TabStop = False
        '
        'tbMerek
        '
        Me.tbMerek.Location = New System.Drawing.Point(29, 210)
        Me.tbMerek.Name = "tbMerek"
        Me.tbMerek.Size = New System.Drawing.Size(188, 23)
        Me.tbMerek.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Merek Mobil"
        '
        'tbHargaSewa
        '
        Me.tbHargaSewa.Location = New System.Drawing.Point(29, 269)
        Me.tbHargaSewa.Name = "tbHargaSewa"
        Me.tbHargaSewa.Size = New System.Drawing.Size(188, 23)
        Me.tbHargaSewa.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Harga Sewa"
        '
        'tbTahunPembuatan
        '
        Me.tbTahunPembuatan.Location = New System.Drawing.Point(254, 210)
        Me.tbTahunPembuatan.Name = "tbTahunPembuatan"
        Me.tbTahunPembuatan.Size = New System.Drawing.Size(188, 23)
        Me.tbTahunPembuatan.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Tahun Pembuatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tanggal Masuk"
        '
        'addCarBtn
        '
        Me.addCarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.addCarBtn.Location = New System.Drawing.Point(303, 323)
        Me.addCarBtn.Name = "addCarBtn"
        Me.addCarBtn.Size = New System.Drawing.Size(106, 33)
        Me.addCarBtn.TabIndex = 32
        Me.addCarBtn.Text = "Add Car"
        Me.addCarBtn.UseVisualStyleBackColor = False
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(29, 329)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(188, 23)
        Me.cbJenis.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Jenis"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(254, 269)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(188, 23)
        Me.dtpTanggalMasuk.TabIndex = 35
        '
        'TambahDataMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 379)
        Me.Controls.Add(Me.dtpTanggalMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.addCarBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTahunPembuatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbHargaSewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbMerek)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahDataMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TambahDataMobil"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fotoMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox

    Friend WithEvents fotoMobil As PictureBox
    Friend WithEvents tbMerek As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbHargaSewa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTahunPembuatan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addCarBtn As Button

    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dtpTanggalMasuk As DateTimePicker
End Class

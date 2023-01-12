<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMobil
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
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.editCarBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHargaSewa = New System.Windows.Forms.TextBox()
        Me.tbMerek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fotoMobil = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.fotoMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(252, 278)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(188, 23)
        Me.dtpTanggalMasuk.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Jenis"
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(27, 338)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(188, 23)
        Me.cbJenis.TabIndex = 49
        '
        'editCarBtn
        '
        Me.editCarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.editCarBtn.Location = New System.Drawing.Point(296, 332)
        Me.editCarBtn.Name = "editCarBtn"
        Me.editCarBtn.Size = New System.Drawing.Size(106, 33)
        Me.editCarBtn.TabIndex = 48
        Me.editCarBtn.Text = "Edit Car"
        Me.editCarBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Tanggal Masuk"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tbTahunPembuatan
        '
        Me.tbTahunPembuatan.Location = New System.Drawing.Point(252, 219)
        Me.tbTahunPembuatan.Name = "tbTahunPembuatan"
        Me.tbTahunPembuatan.Size = New System.Drawing.Size(188, 23)
        Me.tbTahunPembuatan.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Tahun Pembuatan"
        '
        'tbHargaSewa
        '
        Me.tbHargaSewa.Location = New System.Drawing.Point(27, 278)
        Me.tbHargaSewa.Name = "tbHargaSewa"
        Me.tbHargaSewa.Size = New System.Drawing.Size(188, 23)
        Me.tbHargaSewa.TabIndex = 42
        '
        'tbMerek
        '
        Me.tbMerek.Location = New System.Drawing.Point(27, 219)
        Me.tbMerek.Name = "tbMerek"
        Me.tbMerek.Size = New System.Drawing.Size(188, 23)
        Me.tbMerek.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Merek Mobil"
        '
        'fotoMobil
        '
        Me.fotoMobil.Location = New System.Drawing.Point(6, 13)
        Me.fotoMobil.Name = "fotoMobil"
        Me.fotoMobil.Size = New System.Drawing.Size(105, 140)
        Me.fotoMobil.TabIndex = 0
        Me.fotoMobil.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Harga Sewa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fotoMobil)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 158)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Your Picture Here"
        '
        'EditMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 370)
        Me.Controls.Add(Me.dtpTanggalMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.editCarBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTahunPembuatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbHargaSewa)
        Me.Controls.Add(Me.tbMerek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditMobil"
        CType(Me.fotoMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpTanggalMasuk As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents addCarBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tbTahunPembuatan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbHargaSewa As TextBox
    Friend WithEvents tbMerek As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fotoMobil As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents editCarBtn As Button
End Class

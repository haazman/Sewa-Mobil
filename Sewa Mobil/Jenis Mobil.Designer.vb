<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jenis_Mobil
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
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dataGridJenis = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(459, 313)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(171, 68)
        Me.btnKurang.TabIndex = 5
        Me.btnKurang.Text = "Kurang"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(171, 313)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(171, 68)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dataGridJenis
        '
        Me.dataGridJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridJenis.Location = New System.Drawing.Point(214, 69)
        Me.dataGridJenis.Name = "dataGridJenis"
        Me.dataGridJenis.RowHeadersWidth = 51
        Me.dataGridJenis.RowTemplate.Height = 29
        Me.dataGridJenis.Size = New System.Drawing.Size(390, 188)
        Me.dataGridJenis.TabIndex = 3
        '
        'Jenis_Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dataGridJenis)
        Me.Name = "Jenis_Mobil"
        Me.Text = "Jenis_Mobil"
        CType(Me.dataGridJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKurang As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dataGridJenis As DataGridView
End Class

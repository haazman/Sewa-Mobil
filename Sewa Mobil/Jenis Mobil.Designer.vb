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
        Me.dataGridJenis = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        CType(Me.dataGridJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridJenis
        '
        Me.dataGridJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridJenis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.jenis})
        Me.dataGridJenis.Location = New System.Drawing.Point(221, 28)
        Me.dataGridJenis.Name = "dataGridJenis"
        Me.dataGridJenis.RowHeadersWidth = 51
        Me.dataGridJenis.RowTemplate.Height = 29
        Me.dataGridJenis.Size = New System.Drawing.Size(300, 188)
        Me.dataGridJenis.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'jenis
        '
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.MinimumWidth = 6
        Me.jenis.Name = "jenis"
        Me.jenis.Width = 125
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(144, 272)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(171, 68)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(432, 272)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(171, 68)
        Me.btnKurang.TabIndex = 2
        Me.btnKurang.Text = "Kurang"
        Me.btnKurang.UseVisualStyleBackColor = True
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

    Friend WithEvents dataGridJenis As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents jenis As DataGridViewTextBoxColumn
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
End Class

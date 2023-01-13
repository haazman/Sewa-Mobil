<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenyewa
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
        Me.dataGridPenyewa = New System.Windows.Forms.DataGridView()
        Me.btnPenyewa = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.dataGridPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridPenyewa
        '
        Me.dataGridPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPenyewa.Location = New System.Drawing.Point(51, 11)
        Me.dataGridPenyewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dataGridPenyewa.Name = "dataGridPenyewa"
        Me.dataGridPenyewa.RowHeadersWidth = 51
        Me.dataGridPenyewa.RowTemplate.Height = 29
        Me.dataGridPenyewa.Size = New System.Drawing.Size(455, 258)
        Me.dataGridPenyewa.TabIndex = 0
        '
        'btnPenyewa
        '
        Me.btnPenyewa.Location = New System.Drawing.Point(23, 286)
        Me.btnPenyewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPenyewa.Name = "btnPenyewa"
        Me.btnPenyewa.Size = New System.Drawing.Size(130, 50)
        Me.btnPenyewa.TabIndex = 1
        Me.btnPenyewa.Text = "Tambah Penyewa"
        Me.btnPenyewa.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(221, 286)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(128, 50)
        Me.btnUbah.TabIndex = 2
        Me.btnUbah.Text = "Ubah Penyewa"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(412, 286)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(124, 50)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus Penyewa"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'FormPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 356)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnPenyewa)
        Me.Controls.Add(Me.dataGridPenyewa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPenyewa"
        Me.Text = "FormPenyewa"
        CType(Me.dataGridPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataGridPenyewa As DataGridView
    Friend WithEvents btnPenyewa As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnGantiStatus As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnHapus As Button
End Class

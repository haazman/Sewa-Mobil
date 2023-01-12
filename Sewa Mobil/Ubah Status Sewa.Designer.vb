<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_Status_Sewa
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
        Me.rdbdisewa = New System.Windows.Forms.RadioButton()
        Me.rdbselesai = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(61, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mengganti Status Sewa"
        '
        'rdbdisewa
        '
        Me.rdbdisewa.AutoSize = True
        Me.rdbdisewa.Location = New System.Drawing.Point(6, 22)
        Me.rdbdisewa.Name = "rdbdisewa"
        Me.rdbdisewa.Size = New System.Drawing.Size(62, 19)
        Me.rdbdisewa.TabIndex = 1
        Me.rdbdisewa.TabStop = True
        Me.rdbdisewa.Text = "Disewa"
        Me.rdbdisewa.UseVisualStyleBackColor = True
        '
        'rdbselesai
        '
        Me.rdbselesai.AutoSize = True
        Me.rdbselesai.Location = New System.Drawing.Point(6, 47)
        Me.rdbselesai.Name = "rdbselesai"
        Me.rdbselesai.Size = New System.Drawing.Size(60, 19)
        Me.rdbselesai.TabIndex = 2
        Me.rdbselesai.TabStop = True
        Me.rdbselesai.Text = "Selesai"
        Me.rdbselesai.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbdisewa)
        Me.GroupBox1.Controls.Add(Me.rdbselesai)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(168, 161)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 3
        Me.BtnUbah.Text = "OK"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'Ubah_Status_Sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 196)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ubah_Status_Sewa"
        Me.Text = "'"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdbdisewa As RadioButton
    Friend WithEvents rdbselesai As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUbah As Button
End Class

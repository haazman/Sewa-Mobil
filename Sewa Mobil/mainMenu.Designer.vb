<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.mobilBtn = New System.Windows.Forms.Button()
        Me.jenisBtn = New System.Windows.Forms.Button()
        Me.penyewaBtn = New System.Windows.Forms.Button()
        Me.sewaBtn = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(135, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'mobilBtn
        '
        Me.mobilBtn.Location = New System.Drawing.Point(135, 112)
        Me.mobilBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mobilBtn.Name = "mobilBtn"
        Me.mobilBtn.Size = New System.Drawing.Size(166, 35)
        Me.mobilBtn.TabIndex = 1
        Me.mobilBtn.Text = "Mobil"
        Me.mobilBtn.UseVisualStyleBackColor = True
        '
        'jenisBtn
        '
        Me.jenisBtn.Location = New System.Drawing.Point(135, 187)
        Me.jenisBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.jenisBtn.Name = "jenisBtn"
        Me.jenisBtn.Size = New System.Drawing.Size(166, 35)
        Me.jenisBtn.TabIndex = 2
        Me.jenisBtn.Text = "Jenis Mobil"
        Me.jenisBtn.UseVisualStyleBackColor = True
        '
        'penyewaBtn
        '
        Me.penyewaBtn.Location = New System.Drawing.Point(135, 265)
        Me.penyewaBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.penyewaBtn.Name = "penyewaBtn"
        Me.penyewaBtn.Size = New System.Drawing.Size(166, 35)
        Me.penyewaBtn.TabIndex = 3
        Me.penyewaBtn.Text = "Penyewa"
        Me.penyewaBtn.UseVisualStyleBackColor = True
        '
        'sewaBtn
        '
        Me.sewaBtn.Location = New System.Drawing.Point(135, 343)
        Me.sewaBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sewaBtn.Name = "sewaBtn"
        Me.sewaBtn.Size = New System.Drawing.Size(166, 35)
        Me.sewaBtn.TabIndex = 4
        Me.sewaBtn.Text = "Sewa"
        Me.sewaBtn.UseVisualStyleBackColor = True
        '
        'logoutBtn
        '
        Me.logoutBtn.Location = New System.Drawing.Point(14, 16)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(69, 37)
        Me.logoutBtn.TabIndex = 5
        Me.logoutBtn.Text = "Log Out"
        Me.logoutBtn.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 416)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.sewaBtn)
        Me.Controls.Add(Me.penyewaBtn)
        Me.Controls.Add(Me.jenisBtn)
        Me.Controls.Add(Me.mobilBtn)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainMenu"
        Me.Text = "mainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mobilBtn As Button
    Friend WithEvents jenisBtn As Button
    Friend WithEvents penyewaBtn As Button
    Friend WithEvents sewaBtn As Button
    Friend WithEvents logoutBtn As Button
End Class

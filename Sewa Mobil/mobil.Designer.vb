<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mobil
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
        Me.DataGridMobil = New System.Windows.Forms.DataGridView()
        Me.addCarBtn = New System.Windows.Forms.Button()
        Me.editCarBtn = New System.Windows.Forms.Button()
        Me.deleteCarBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car"
        '
        'DataGridMobil
        '
        Me.DataGridMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMobil.Location = New System.Drawing.Point(0, 55)
        Me.DataGridMobil.Name = "DataGridMobil"
        Me.DataGridMobil.RowTemplate.Height = 25
        Me.DataGridMobil.Size = New System.Drawing.Size(638, 278)
        Me.DataGridMobil.TabIndex = 1
        '
        'addCarBtn
        '
        Me.addCarBtn.Location = New System.Drawing.Point(403, 365)
        Me.addCarBtn.Name = "addCarBtn"
        Me.addCarBtn.Size = New System.Drawing.Size(87, 31)
        Me.addCarBtn.TabIndex = 2
        Me.addCarBtn.Text = "Add Car"
        Me.addCarBtn.UseVisualStyleBackColor = True
        '
        'editCarBtn
        '
        Me.editCarBtn.Location = New System.Drawing.Point(278, 365)
        Me.editCarBtn.Name = "editCarBtn"
        Me.editCarBtn.Size = New System.Drawing.Size(87, 31)
        Me.editCarBtn.TabIndex = 3
        Me.editCarBtn.Text = "Edit Car"
        Me.editCarBtn.UseVisualStyleBackColor = True
        '
        'deleteCarBtn
        '
        Me.deleteCarBtn.Location = New System.Drawing.Point(153, 365)
        Me.deleteCarBtn.Name = "deleteCarBtn"
        Me.deleteCarBtn.Size = New System.Drawing.Size(87, 31)
        Me.deleteCarBtn.TabIndex = 4
        Me.deleteCarBtn.Text = "Delete Car"
        Me.deleteCarBtn.UseVisualStyleBackColor = True
        '
        'mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 423)
        Me.Controls.Add(Me.deleteCarBtn)
        Me.Controls.Add(Me.editCarBtn)
        Me.Controls.Add(Me.addCarBtn)
        Me.Controls.Add(Me.DataGridMobil)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mobil"
        CType(Me.DataGridMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridMobil As DataGridView
    Friend WithEvents addCarBtn As Button
    Friend WithEvents editCarBtn As Button
    Friend WithEvents deleteCarBtn As Button
End Class

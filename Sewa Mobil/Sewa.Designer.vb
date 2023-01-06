<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridSewa = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndeletesewa = New System.Windows.Forms.Button()
        Me.btneditsewa = New System.Windows.Forms.Button()
        Me.btntambahsewa = New System.Windows.Forms.Button()
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridSewa
        '
        Me.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSewa.Location = New System.Drawing.Point(1, 80)
        Me.DataGridSewa.Name = "DataGridSewa"
        Me.DataGridSewa.RowTemplate.Height = 25
        Me.DataGridSewa.Size = New System.Drawing.Size(638, 278)
        Me.DataGridSewa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sewa"
        '
        'btndeletesewa
        '
        Me.btndeletesewa.Location = New System.Drawing.Point(156, 391)
        Me.btndeletesewa.Name = "btndeletesewa"
        Me.btndeletesewa.Size = New System.Drawing.Size(87, 31)
        Me.btndeletesewa.TabIndex = 7
        Me.btndeletesewa.Text = "Delete"
        Me.btndeletesewa.UseVisualStyleBackColor = True
        '
        'btneditsewa
        '
        Me.btneditsewa.Location = New System.Drawing.Point(281, 391)
        Me.btneditsewa.Name = "btneditsewa"
        Me.btneditsewa.Size = New System.Drawing.Size(87, 31)
        Me.btneditsewa.TabIndex = 6
        Me.btneditsewa.Text = "Edit"
        Me.btneditsewa.UseVisualStyleBackColor = True
        '
        'btntambahsewa
        '
        Me.btntambahsewa.Location = New System.Drawing.Point(406, 391)
        Me.btntambahsewa.Name = "btntambahsewa"
        Me.btntambahsewa.Size = New System.Drawing.Size(87, 31)
        Me.btntambahsewa.TabIndex = 5
        Me.btntambahsewa.Text = "Add"
        Me.btntambahsewa.UseVisualStyleBackColor = True
        '
        'Sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 441)
        Me.Controls.Add(Me.btndeletesewa)
        Me.Controls.Add(Me.btneditsewa)
        Me.Controls.Add(Me.btntambahsewa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridSewa)
        Me.Name = "Sewa"
        Me.Text = "Sewa"
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridSewa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btndeletesewa As Button
    Friend WithEvents btneditsewa As Button
    Friend WithEvents btntambahsewa As Button
End Class

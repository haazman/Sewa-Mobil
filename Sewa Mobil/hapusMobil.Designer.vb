<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapusMobil
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
        Me.lblHapus = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHapus
        '
        Me.lblHapus.AutoSize = True
        Me.lblHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHapus.Location = New System.Drawing.Point(6, 52)
        Me.lblHapus.Name = "lblHapus"
        Me.lblHapus.Size = New System.Drawing.Size(56, 21)
        Me.lblHapus.TabIndex = 1
        Me.lblHapus.Text = "Label2"
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.deleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.deleteBtn.Location = New System.Drawing.Point(199, 142)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(79, 32)
        Me.deleteBtn.TabIndex = 2
        Me.deleteBtn.Text = "Yes"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(98, 142)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(79, 32)
        Me.cancelBtn.TabIndex = 3
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHapus)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(356, 124)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Are you sure you want to delete"
        '
        'hapusMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "hapusMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "hapusMobil"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHapus As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class

Public Class Ubah_Status_Sewa
    Dim status

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Sewa.sewa.GSstatus = "Disewa" Then
            rdbdisewa.Checked = True
        End If
        If Sewa.sewa.GSstatus = "Selesai" Then
            rdbselesai.Checked = True
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If rdbdisewa.Checked() Then
            status = "Disewa"
        End If
        If rdbselesai.Checked() Then
            status = "Selesai"
        End If

        Sewa.sewa.updateData(Sewa.selectedTableKoleksi, status)
        Me.Close ()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
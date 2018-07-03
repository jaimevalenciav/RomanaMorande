Public Class frmSeleccionaFecha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dpfechaguia.Text <> "" Then
            frmVendimiaPesajeAutomatico.dpfechaguia.Value = dpfechaguia.Value
            Me.Close()
        Else
            MsgBox("La fecha no puede ser vacía")
            dpfechaguia.Select()
        End If
    End Sub



    Private Sub frmSeleccionaFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpfechaguia.Select()
    End Sub

    Private Sub Label1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Label1.KeyPress
        If dpfechaguia.Text <> "" Then
            frmVendimiaPesajeAutomatico.dpfechaguia.Value = dpfechaguia.Value
            Me.Close()
        Else
            MsgBox("La fecha no puede ser vacía")
            dpfechaguia.Select()
        End If
    End Sub
End Class
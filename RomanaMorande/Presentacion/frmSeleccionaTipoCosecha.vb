Public Class frmSeleccionaTipoCosecha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmVendimiaPesajeAutomatico.rbManual.Checked = True
        frmVendimiaPesajeAutomatico.rbMecanica.Checked = False
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmVendimiaPesajeAutomatico.rbManual.Checked = False
        frmVendimiaPesajeAutomatico.rbMecanica.Checked = True
        Me.Close()
    End Sub


End Class
Public Class frmSeleccionTipoEnvase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmenvases.txtflag.Text = txtflag2.Text
        frmenvases.ShowDialog()
        txtcantenv.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtflag.Text = 0 Then
            frmVendimiaPesajeAutomatico.txttipoenv.Text = txtidenvase.Text
            frmVendimiaPesajeAutomatico.txtnomtipoenv.Text = txtnomenvase.Text
            frmVendimiaPesajeAutomatico.txtcantenvin.Text = txtcantenv.Text
            frmVendimiaPesajeAutomatico.txtdifkgenv.Text = (Val(txtcantenv.Text) * Val(txtkgenv.Text))
            txtidenvase.Text = ""
            txtnomenvase.Text = ""
            txtcantenv.Text = ""
            Me.Close()
        ElseIf txtflag.Text = 1 Then
            frmVendimiaPesajeAutomatico.txttipoenvout.Text = txtidenvase.Text
            frmVendimiaPesajeAutomatico.txtnomtipoenvout.Text = txtnomenvase.Text
            frmVendimiaPesajeAutomatico.txtcantenvout.Text = txtcantenv.Text
            frmVendimiaPesajeAutomatico.txtdifkgenv.Text = Val(frmVendimiaPesajeAutomatico.txtdifkgenv.Text) - (Val(txtcantenv.Text) * Val(txtkgenv.Text))
            txtidenvase.Text = ""
            txtnomenvase.Text = ""
            txtcantenv.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub frmSeleccionTipoEnvase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidenvase.ReadOnly = True
        txtnomenvase.ReadOnly = True
    End Sub
End Class
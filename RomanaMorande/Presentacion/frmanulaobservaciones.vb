Public Class frmanulaobservaciones
    Private Sub frmanulaobservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumpesaje.Text = frmpesajesindestaremanual.txtnumpesaje.Text
        txtpatente.Text = frmpesajesindestaremanual.txtpatente.Text
    End Sub

    Private Sub btnanular_Click(sender As Object, e As EventArgs) Handles btnanular.Click
        Try
            Dim dts As New vpesajesindestareM
            Dim func As New fpesajesindestareM
            dts.gidpesaje = txtnumpesaje.Text
            dts.gobservaciones = txtobservaciones.Text

            If func.anular(dts) Then
                MessageBox.Show("Pesaje Anulado Correctamente", "Anular Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                frmpesajesindestaremanual.Close()
                frmpesajesindestaremanual.ShowDialog()
            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                frmpesajesindestaremanual.Close()
                frmpesajesindestaremanual.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
        frmpesajesindestaremanual.Close()
        frmpesajesindestaremanual.ShowDialog()
    End Sub
End Class
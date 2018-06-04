Public Class frmanulaobservacionesnormal

    Private Sub frmanulaobservacionesnormal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtnumpesaje.Text = frmpesajedestareautomatico.txtnumpesaje.Text
        txtpatente.Text = frmpesajedestareautomatico.txtpatente.Text
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
                frmpesajedestareautomatico.Close()
                frmpesajedestareautomatico.ShowDialog()
            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                frmpesajedestareautomatico.Close()
                frmpesajedestareautomatico.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
End Class
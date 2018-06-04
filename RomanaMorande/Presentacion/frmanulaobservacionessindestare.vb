Public Class frmanulaobservacionessindestare
    Private Sub frmanulaobservacionessindestare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtnumpesaje.Text = frmpesajesindestareautomatico.txtnumpesaje.Text
        txtpatente.Text = frmpesajesindestareautomatico.txtpatente.Text
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
                frmpesajesindestareautomatico.Close()
                frmpesajesindestareautomatico.ShowDialog()
            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                frmpesajesindestareautomatico.Close()
                frmpesajesindestareautomatico.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
        frmpesajesindestareautomatico.Close()
        frmpesajesindestareautomatico.ShowDialog()
    End Sub

End Class
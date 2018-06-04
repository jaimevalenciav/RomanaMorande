Public Class frmanulaobservacionesautosindestare

    Private Sub frmanulaobservacionessindestare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtnumpesaje.Text = frmpesajedestaremanual.txtnumpesaje.Text
        txtpatente.Text = frmpesajedestaremanual.txtpatente.Text
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
                frmpesajedestaremanual.Close()
                frmpesajedestaremanual.ShowDialog()
            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                frmpesajedestaremanual.Close()
                frmpesajedestaremanual.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
        frmpesajedestaremanual.Close()
        frmpesajedestaremanual.ShowDialog()
    End Sub


End Class
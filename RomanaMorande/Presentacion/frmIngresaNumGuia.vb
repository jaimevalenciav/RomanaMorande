Public Class frmIngresaNumGuia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txtnumguia.Text) Then
            MsgBox("El Numero de Guía no puede ser CERO ni vacío")
            txtnumguia.Select()
        Else

            frmVendimiaPesajeAutomatico.txtnumguia.Text = txtnumguia.Text
            Me.Close()
        End If
    End Sub

    Private Sub frmIngresaNumGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumguia.Text = ""
        txtnumguia.Select()
    End Sub

    Private Sub txtnumguia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnumguia.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If String.IsNullOrEmpty(txtnumguia.Text) Then
                    MsgBox("El Numero de Guía no puede ser CERO ni vacío")
                    txtnumguia.Select()
                Else

                    frmVendimiaPesajeAutomatico.txtnumguia.Text = txtnumguia.Text
                    Me.Close()
                End If
        End Select
    End Sub
End Class
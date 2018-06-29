Public Class frmIngresaNumGuia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtnumguia.Text <> "" Or txtnumguia.Text <> "0" Then
            frmVendimiaPesajeAutomatico.txtnumguia.Text = txtnumguia.Text
            Me.Close()
        Else
            MsgBox("El Numero de Guía no puede ser CERO ni vacío")
            txtnumguia.Select()
        End If
    End Sub

    Private Sub frmIngresaNumGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumguia.Text = ""
        txtnumguia.Select()
    End Sub
End Class
Public Class frmVendimiaPesajeAutomatico


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmVendimiaPesajeAutomatico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer2.Interval = 1000  ' Un segundo
        Timer2.Start()

        'rbManual.Checked = True

        'bloquear campos que no deben ser modificables
        txtnumpesaje.ReadOnly = True
        txtpatente.ReadOnly = True
        txtidbodega.ReadOnly = True
        txtbodega.ReadOnly = True

        'cambio de color de campos bloqueados
        txtnumpesaje.BackColor = Color.White
        txtpatente.BackColor = Color.White
        txtidbodega.BackColor = Color.White
        txtbodega.BackColor = Color.White
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
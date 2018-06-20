Public Class frmVendimiaPesajeAutomatico
    Private dt As New DataTable

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

        mostrar()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub

    Private Sub btnnuevopesaje_Click(sender As Object, e As EventArgs) Handles btnnuevopesaje.Click
        frmCreaPesajeVendimia.ShowDialog()
    End Sub

    Private Sub mostrar()

        Try
            Dim func As New fpesajevendimia
            dt = func.mostrar
            dpfechaguia.Value = Date.Today

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt


            Else
                DataListado.DataSource = Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
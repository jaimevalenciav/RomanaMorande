Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmContratos
    Private dt As New DataTable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fcontratos
            dt = func.mostrar
            'datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                'datalistado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                'datalistado.DefaultCellStyle.SelectionForeColor = Color.White

            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'btnguardar.Visible = True
        btnEditar.Visible = False

    End Sub



    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag.Text = 1 Then
            frmVendimiaPesajeAutomatico.txtnumcontrato.Text = datalistado.SelectedCells.Item(1).Value
            frmVendimiaPesajeAutomatico.txtrutprov.Text = datalistado.SelectedCells.Item(2).Value
            frmVendimiaPesajeAutomatico.txtnomprov.Text = datalistado.SelectedCells.Item(3).Value
            frmVendimiaPesajeAutomatico.txtidcontratos.Text = datalistado.SelectedCells.Item(5).Value
            Me.Close()
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class
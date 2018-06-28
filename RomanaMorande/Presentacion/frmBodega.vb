Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmBodega
    Private dt As New DataTable
    Private Sub frmBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fbodega
            dt = func.mostrar
            DataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.ColumnHeadersVisible = True
                'DataListado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                'DataListado.DefaultCellStyle.SelectionForeColor = Color.White
                inexistente.Visible = False
            Else
                DataListado.DataSource = Nothing
                DataListado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnguardar.Visible = True
        btnEditar.Visible = False

    End Sub


    Private Sub DataListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentDoubleClick
        If txtflag.Text = 1 Then


        ElseIf txtflag.Text = 2 Then
            frmVendimiaPesajeAutomatico.txtidbodega.Text = DataListado.SelectedCells.Item(2).Value
            frmVendimiaPesajeAutomatico.txtcodbodega.Text = DataListado.SelectedCells.Item(1).Value
            frmVendimiaPesajeAutomatico.txtbodega.Text = DataListado.SelectedCells.Item(3).Value
            Me.Close()
        End If
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub
End Class
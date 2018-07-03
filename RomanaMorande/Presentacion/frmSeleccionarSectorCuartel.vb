Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSeleccionarSectorCuartel
    Private dt As New DataTable
    Private Sub frmSeleccionarSectorCuartel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim dts As New vSeleccionSectorCuartel
        Dim func As New fseleccionsectorcuartel
        dt = func.mostrar
        datalistado.DataSource = dt
    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        frmVendimiaPesajeAutomatico.txtidsectorcuartel.Text = datalistado.SelectedCells.Item(9).Value
        frmVendimiaPesajeAutomatico.txtidsector.Text = datalistado.SelectedCells.Item(3).Value
        frmVendimiaPesajeAutomatico.txtnomsector.Text = datalistado.SelectedCells.Item(4).Value
        frmVendimiaPesajeAutomatico.txtidcuartel.Text = datalistado.SelectedCells.Item(5).Value
        frmVendimiaPesajeAutomatico.txtnomcuartel.Text = datalistado.SelectedCells.Item(6).Value
        If datalistado.SelectedCells.Item(7).Value = 0 Then
            frmVendimiaPesajeAutomatico.txtidsubcuartel.Text = ""
        Else
            frmVendimiaPesajeAutomatico.txtidsubcuartel.Text = datalistado.SelectedCells.Item(7).Value
        End If
        If datalistado.SelectedCells.Item(8).Value = "" Then
            frmVendimiaPesajeAutomatico.txtnomsubcuartel.Text = ""
        Else
            frmVendimiaPesajeAutomatico.txtnomsubcuartel.Text = datalistado.SelectedCells.Item(8).Value
        End If
        Me.Close()
    End Sub
End Class
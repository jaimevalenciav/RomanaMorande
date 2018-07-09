Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSeleccionaVariedad
    Private dt As New DataTable
    Private Sub frmSeleccionaVariedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Dim dts As New vseleccionavariedad
        Dim func As New fseleccionavariedad
        dt = func.mostrar
        datalistado.DataSource = dt

        datalistado.Columns(0).Width = 80
        datalistado.Columns(1).Width = 85
        datalistado.Columns(2).Width = 100
        datalistado.Columns(3).Width = 300
        datalistado.Columns(4).Width = 95
        datalistado.Columns(5).Width = 150

        datalistado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datalistado.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datalistado.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'datalistado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datalistado.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        datalistado.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        datalistado.Columns(6).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(8).Visible = False
    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        frmVendimiaPesajeAutomatico.txtcoduva.Text = datalistado.SelectedCells.Item(2).Value
        frmVendimiaPesajeAutomatico.txtnomuva.Text = datalistado.SelectedCells.Item(3).Value
        frmVendimiaPesajeAutomatico.txtcodcalidad.Text = datalistado.SelectedCells.Item(4).Value
        frmVendimiaPesajeAutomatico.txtcalidad.Text = datalistado.SelectedCells(5).Value
        frmVendimiaPesajeAutomatico.txtidvariedad.Text = datalistado.SelectedCells(6).Value
        frmVendimiaPesajeAutomatico.txtidcalidad.Text = datalistado.SelectedCells(7).Value
        frmVendimiaPesajeAutomatico.txtiddetcontrato.Text = datalistado.SelectedCells(8).Value
        Me.Close()
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class
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
End Class
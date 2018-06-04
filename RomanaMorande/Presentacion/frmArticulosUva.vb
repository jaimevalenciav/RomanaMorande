Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Public Class frmArticulosUva
    Private dt As New DataTable
    Private Sub frmArticulosUva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()

        Try
            Dim func As New farticulosuva
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
            Else
                DataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataListado.Columns(0).Width = 110
        DataListado.Columns(1).Width = 400
        DataListado.Columns(2).Width = 150
        DataListado.Columns(3).Width = 180

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
Imports Microsoft.Reporting.WinForms
Public Class frmReporteRecepUva
    Private Sub frmReporteRecepUva_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'pesajeDataSet2.reporte_pesaje' Puede moverla o quitarla según sea necesario.
        Me.reporte_pesajeTableAdapter.Fill(Me.pesajeDataSet8.reporte_pesaje, idpesaje:=txtidpesajev.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
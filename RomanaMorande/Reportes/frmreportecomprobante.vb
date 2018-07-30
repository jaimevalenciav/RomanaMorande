Imports Microsoft.Reporting.WinForms

Public Class frmreportecomprobante
    Private Sub frmreportecomprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim usuario As New ReportParameter("usuario", frmPrincipal.lbluser.Text)
        ReportViewer1.LocalReport.SetParameters(usuario)

        'TODO: esta línea de código carga datos en la tabla 'pesajeDataSet2.reporte_pesaje' Puede moverla o quitarla según sea necesario.
        Me.reporte_pesajeTableAdapter.Fill(Me.pesajeDataSet8.reporte_pesaje, idpesaje:=txtidpesaje.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class
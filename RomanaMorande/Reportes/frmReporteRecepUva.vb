Imports Microsoft.Reporting.WinForms
Public Class frmReporteRecepUva
    Private Sub frmReporteRecepUva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportePesajeUva1.mostrar_reportepesajesvendimia' Puede moverla o quitarla según sea necesario.
        Dim usuario As New ReportParameter("promenv", frmVendimiaPesajeAutomatico.txtpromenv.Text)
        ReportViewer1.LocalReport.SetParameters(usuario)
        Me.mostrar_reportepesajesvendimiaTableAdapter.Fill(Me.ReportePesajeUva1.mostrar_reportepesajesvendimia, idpesajev:=txtidpesajev.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
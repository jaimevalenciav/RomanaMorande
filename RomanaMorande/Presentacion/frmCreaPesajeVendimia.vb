Public Class frmCreaPesajeVendimia
    Private Sub frmCreaPesajeVendimia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtidvehiculo.Text = ""
        txtpatente.Text = ""
        txttipoenvase.Text = ""
        txttransportista.Text = ""
        txttipovehiculo.Text = ""
        txttara.Text = ""
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPatenteVendimia.Show()
    End Sub
End Class
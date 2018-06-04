Public Class frmPrincipal
    Private Sub TipoVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoVehiculosToolStripMenuItem.Click
        frmTipoVehiculo.Show()

    End Sub

    Private Sub TransportistasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportistasToolStripMenuItem.Click
        frmTransportistas.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PatentesVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatentesVehículosToolStripMenuItem.Click
        frmMaestroPatentes.Show()

    End Sub

    Private Sub PesajeSinDestareToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PesajeSinDestareToolStripMenuItem1.Click
        frmclavemanualSinDestare.Show()
    End Sub

    Private Sub PesajeSinDestareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesajeSinDestareToolStripMenuItem.Click
        frmpesajesindestareautomatico.show()
    End Sub

    Private Sub PesajeNormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PesajeNormalToolStripMenuItem1.Click
        frmanulamanualDestare.Show()
    End Sub

    Private Sub PesajeNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesajeNormalToolStripMenuItem.Click
        frmpesajedestareautomatico.Show()

    End Sub

    Private Sub PesajesPorPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesajesPorPatenteToolStripMenuItem.Click
        frmconsultapatente.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub EnvasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvasesToolStripMenuItem.Click
        frmenvases.ShowDialog()
    End Sub

    Private Sub TablaBaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaBaToolStripMenuItem.Click

    End Sub

    Private Sub CalidadesUvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalidadesUvaToolStripMenuItem.Click
        frmCalidad.ShowDialog()
    End Sub

    Private Sub ContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem.Click
        frmContratos.ShowDialog()
    End Sub

    Private Sub VariedadesUvaEnSAPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariedadesUvaEnSAPToolStripMenuItem.Click
        frmArticulosUva.ShowDialog()
    End Sub


End Class
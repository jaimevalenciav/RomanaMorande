Public Class frmVendimiaPesajeAutomatico
    Private dt As New DataTable

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmVendimiaPesajeAutomatico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer2.Interval = 1000  ' Un segundo
        Timer2.Start()

        'rbManual.Checked = True

        'bloquear campos que no deben ser modificables
        txtnumpesaje.ReadOnly = True
        txtpatente.ReadOnly = True
        txtcodbodega.ReadOnly = True
        txtbodega.ReadOnly = True

        'cambio de color de campos bloqueados
        txtnumpesaje.BackColor = Color.White
        txtpatente.BackColor = Color.White
        txtcodbodega.BackColor = Color.White
        txtbodega.BackColor = Color.White

        txtnumcontrato.ReadOnly = True
        txtrutprov.ReadOnly = True
        txtnomprov.ReadOnly = True

        rbManual.Checked = False
        rbMecanica.Checked = False

        mostrar()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscarVariedad.Click

        frmSeleccionaVariedad.ShowDialog()
    End Sub



    Private Sub btnnuevopesaje_Click(sender As Object, e As EventArgs) Handles btnnuevopesaje.Click
        frmCreaPesajeVendimia.ShowDialog()
    End Sub

    Private Sub mostrar()

        Try
            Dim func As New fpesajevendimia
            dt = func.mostrar
            dpfechaguia.Value = Date.Today

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
            Else
                DataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        txtnumpesaje.Text = DataListado.SelectedCells.Item(1).Value
        txtpatente.Text = DataListado.SelectedCells.Item(4).Value
        txtcodbodega.Text = DataListado.SelectedCells.Item(18).Value
        txtbodega.Text = DataListado.SelectedCells.Item(19).Value
        txtnumcontrato.Text = DataListado.SelectedCells.Item(26).Value
        txtrutprov.Text = DataListado.SelectedCells.Item(28).Value
        txtnomprov.Text = DataListado.SelectedCells.Item(29).Value
        txtnumguia.Text = DataListado.SelectedCells.Item(2).Value
        txtidtransportista.Text = DataListado.SelectedCells.Item(5).Value
        txtnomtrans.Text = DataListado.SelectedCells.Item(6).Value
        txttara.Text = DataListado.SelectedCells.Item(46).Value
        txtidbodega.Text = DataListado.SelectedCells.Item(17).Value
        If DataListado.SelectedCells.Item(24).Value.ToString = "M" Then
            rbManual.Checked = True
        ElseIf DataListado.SelectedCells.Item(24).Value.ToString = "Q" Then
            rbMecanica.Checked = True
        End If
        txttipoenv.Text = DataListado.SelectedCells.Item(20).Value
        txtnomtipoenv.Text = DataListado.SelectedCells.Item(21).Value
        txtcantenvin.Text = DataListado.SelectedCells.Item(22).Value
        txtcantenvout.Text = DataListado.SelectedCells.Item(23).Value
        txtestadopesaje.Text = DataListado.SelectedCells.Item(15).Value

        btnBuscarBodega.Enabled = True
        btnBuscarContrato.Enabled = True
        btnBuscarVariedad.Enabled = True
        btnBuscarSector.Enabled = True

        If txtestadopesaje.Text = 0 Then
            'MsgBox("Debe elejir un contrato para el pesaje seleccionado")
            frmContratos.txtflag.Text = 1
            frmContratos.ShowDialog()
            frmBodega.txtflag.Text = 2
            frmBodega.ShowDialog()
            frmSeleccionaTipoCosecha.ShowDialog()
            frmSeleccionaFecha.ShowDialog()
            frmIngresaNumGuia.ShowDialog()
            frmSeleccionaVariedad.ShowDialog()
            btncapturapesobruto.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarContrato.Click
        frmContratos.txtflag.Text = "1"
        frmContratos.ShowDialog()
    End Sub

    Private Sub btnBuscarTransportista_Click(sender As Object, e As EventArgs) Handles btnBuscarBodega.Click
        frmBodega.txtflag.Text = 2
        frmBodega.ShowDialog()
    End Sub


End Class
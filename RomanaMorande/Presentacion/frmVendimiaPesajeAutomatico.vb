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
        txtobservaciones.Text = DataListado.SelectedCells.Item(14).Value
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
        txtbrix.Text = DataListado.SelectedCells.Item(38).Value
        txtdensidad.Text = DataListado.SelectedCells.Item(39).Value
        txttemp.Text = DataListado.SelectedCells.Item(40).Value
        txtapb.Text = DataListado.SelectedCells.Item(41).Value
        txtcastigo.Text = DataListado.SelectedCells.Item(42).Value

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
            frmSeleccionarSectorCuartel.ShowDialog()
            btncapturapesobruto.Visible = True
            btnanula.Visible = True

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

    Private Sub btnBuscarSector_Click(sender As Object, e As EventArgs) Handles btnBuscarSector.Click
        frmSeleccionarSectorCuartel.ShowDialog()
    End Sub

    Private Sub btncapturapesobruto_Click(sender As Object, e As EventArgs) Handles btncapturapesobruto.Click
        txtpesajebruto.Text = "0"
        While txtpesajebruto.Text = 0
            Dim buffer As String
            sppuerto.Close()
            buffer = ""
            Try
                With sppuerto
                    .BaudRate = 4800
                    .DataBits = 7
                    .Parity = IO.Ports.Parity.Even
                    .StopBits = 1
                    .PortName = "COM1"
                    .Open()
                    If .IsOpen Then
                        buffer = sppuerto.ReadExisting
                        txtpesajebruto.Text = ""
                        buffer = Mid(buffer, 6, 5)
                        'MsgBox(buffer)
                        If Val(buffer) <= 60000 Then
                            txtpesajebruto.Text = Val(buffer)
                            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
                            sppuerto.Close()
                        End If
                    Else
                        MsgBox("No es posible hacer lectura de la Báscula", MsgBoxStyle.Exclamation)
                    End If
                    .Close()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
            End Try
        End While
    End Sub

    Private Sub btncapturapesotara_Click(sender As Object, e As EventArgs) Handles btncapturapesotara.Click
        txtpesajetara.Text = "0"
        While txtpesajetara.Text = 0
            Dim buffer As String
            sppuerto.Close()
            buffer = ""
            Try
                With sppuerto
                    .BaudRate = 4800
                    .DataBits = 7
                    .Parity = IO.Ports.Parity.Even
                    .StopBits = 1
                    .PortName = "COM1"
                    .Open()
                    If .IsOpen Then
                        buffer = sppuerto.ReadExisting
                        txtpesajetara.Text = ""
                        buffer = Mid(buffer, 6, 5)
                        'MsgBox(buffer)
                        If Val(buffer) <= 60000 Then
                            txtpesajetara.Text = Val(buffer)
                            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
                            sppuerto.Close()
                        End If
                    Else
                        MsgBox("No es posible hacer lectura de la Báscula", MsgBoxStyle.Exclamation)
                    End If
                    .Close()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
            End Try
        End While
    End Sub

    Private Sub btnGuardarpesaje_Click(sender As Object, e As EventArgs) Handles btnGuardarpesaje.Click
        Dim validar As Integer = 0

        If validar = 1 Or txtestadopesaje.Text = 0 Then
            Try
                If txtnumpesaje.Text <> "" Or txtpesajetara.Text <> "" Or txtpesajebruto.Text <> "" Or Val(txtpesajeneto.Text > 0) Then
                    Try
                        Dim dts As New vpesajevendimia
                        Dim func As New fpesajevendimia
                        dts.gidpesajev = txtnumpesaje.Text
                        'dts.ganiovendimia = txt.Text
                        'dts.gidsap = txtdocsap.Text
                        dts.gpesajeneto = txtpesajeneto.Text
                        dts.gpesajebruto = txtpesajebruto.Text
                        dts.gpesajetara = txtpesajetara.Text


                        If Val(txtestadopesaje.Text) = 0 Then
                            dts.gestadopesaje = 1 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            dts.gobservaciones = txtobservaciones.Text
                            If func.editarIn(dts) Then
                                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mostrar()
                                mostrar2()
                                limpiar()
                            Else
                                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar()
                                mostrar2()
                                limpiar()
                            End If
                        ElseIf Val(txtestadopesaje.Text) = 1 Then
                            'Validar contenido DocSAP, GuiaDespacho y Observaciones
                            If txtdocsap.Text.Length <= 1 Or txtguiadespacho.Text.Length <= 1 Or txtobservaciones.Text.Length <= 1 Or txtTaraContenedor.Text.Length < 1 Then
                                Dim mensaje As String = "El campo DocSAP, Guía Despacho, Tara Contenedor u Observaciones se encuentra sin información. Desea continuar con la operación?"
                                Dim caption As String = "Campos sin información."
                                Dim botones As MessageBoxButtons = MessageBoxButtons.YesNo
                                Dim Result As DialogResult
                                Result = MessageBox.Show(mensaje, caption, botones, MessageBoxIcon.Exclamation)
                                If Result = System.Windows.Forms.DialogResult.No Then
                                    txtdocsap.Select()
                                Else
                                    dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                                    dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                                    If func.editarOut(dts) Then
                                        MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        If txtestadopesaje.Text = 1 Then
                                            frmreportecomprobante.txtidpesaje.Text = Me.txtnumpesaje.Text
                                            frmreportecomprobante.ShowDialog()
                                        End If
                                        mostrar()
                                        mostrar2()
                                        limpiar()
                                    Else
                                        MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        mostrar()
                                        mostrar2()
                                        limpiar()
                                    End If
                                End If
                            Else
                                dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                                dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                                If func.editarOut(dts) Then
                                    MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    If txtestadopesaje.Text = 1 Then
                                        frmreportecomprobante.txtidpesaje.Text = Me.txtnumpesaje.Text
                                        frmreportecomprobante.ShowDialog()
                                    End If
                                    mostrar()
                                    mostrar2()
                                    limpiar()
                                Else
                                    MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    mostrar()
                                    mostrar2()
                                    limpiar()
                                End If
                            End If
                        End If
                        dts.gvisible = 1 '0:NoVisible 1:Visible
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Debe Seleccionar un registro de pesaje, o ingresar un valor para el pesaje, o pesaje debe ser mayor que 0", "Romana Morandé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("El pesaje neto NO puede ser menor a 0, verifique los pesajes", "Romana Morandé", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
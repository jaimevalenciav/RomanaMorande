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
        txtpesajebruto.ReadOnly = True
        txtpesajetara.ReadOnly = True
        txtpesajeneto.ReadOnly = True

        rbManual.Checked = False
        rbMecanica.Checked = False

        limpiar()

        If frmPrincipal.lbluser.Text = "jvalencia" Then
            chkemular.Visible = True
            chkemular.Checked = True
        End If
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

        DataListado.Columns(3).Visible = False
        DataListado.Columns(5).Visible = False
        DataListado.Columns(7).Visible = False
        DataListado.Columns(9).Visible = False
        DataListado.Columns(10).Visible = False
        DataListado.Columns(14).Visible = False
        DataListado.Columns(15).Visible = False
        DataListado.Columns(16).Visible = False
        DataListado.Columns(17).Visible = False
        DataListado.Columns(20).Visible = False
        DataListado.Columns(21).Visible = False
        DataListado.Columns(22).Visible = False
        DataListado.Columns(23).Visible = False
        DataListado.Columns(24).Visible = False
        DataListado.Columns(26).Visible = False
        DataListado.Columns(27).Visible = False
        DataListado.Columns(30).Visible = False
        DataListado.Columns(31).Visible = False
        DataListado.Columns(32).Visible = False
        DataListado.Columns(34).Visible = False
        DataListado.Columns(36).Visible = False
        DataListado.Columns(38).Visible = False
        DataListado.Columns(39).Visible = False
        DataListado.Columns(40).Visible = False
        DataListado.Columns(41).Visible = False
        DataListado.Columns(42).Visible = False
        DataListado.Columns(43).Visible = False
        DataListado.Columns(53).Visible = False
        DataListado.Columns(44).Visible = False
        DataListado.Columns(45).Visible = False
        DataListado.Columns(46).Visible = False
        DataListado.Columns(47).Visible = False
        DataListado.Columns(48).Visible = False
        DataListado.Columns(49).Visible = False
        DataListado.Columns(51).Visible = False
        DataListado.Columns(53).Visible = False


    End Sub

    Private Sub mostrar2()

        Try
            Dim func As New fpesajevendimia
            dt = func.mostrar2
            dpfechaguia.Value = Date.Today

            If dt.Rows.Count <> 0 Then
                datalistado2.DataSource = dt
            Else
                datalistado2.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub limpiar()
        txtidcontratos.Text = ""
        txtestadopesaje.Text = ""
        txtidbodega.Text = ""
        txtnumpesaje.Text = ""
        txtpatente.Text = ""
        txtcodbodega.Text = ""
        txtbodega.Text = ""
        txtnumcontrato.Text = ""
        txtrutprov.Text = ""
        txtnomprov.Text = ""
        dpfechaguia.Value = Now()
        txtnumguia.Text = 0
        txtidtransportista.Text = ""
        txtnomtrans.Text = ""
        txttara.Text = ""
        txttipoenv.Text = ""
        txtnomtipoenv.Text = ""
        txtcantenvin.Text = ""
        txtcantenvout.Text = ""
        rbManual.Checked = False
        rbMecanica.Checked = False
        txtiddetcontrato.Text = ""
        txtcoduva.Text = ""
        txtnomuva.Text = ""
        txtcodcalidad.Text = ""
        txtcalidad.Text = ""
        txtidcalidad.Text = ""
        txtbrix.Text = ""
        txtdensidad.Text = ""
        txtidsector.Text = ""
        txtnomsector.Text = ""
        txtidsectorcuartel.Text = ""
        txttemp.Text = ""
        txtapb.Text = ""
        txtidcuartel.Text = ""
        txtnomcuartel.Text = ""
        txtcastigo.Text = ""
        txtidsubcuartel.Text = ""
        txtnomsubcuartel.Text = ""
        txtobservaciones.Text = ""
        txtpesajebruto.Text = "0"
        txtpesajetara.Text = "0"
        txtpesajeneto.Text = "0"
        btncapturapesobruto.Visible = False
        btncapturapesotara.Visible = False
        btnanula.Visible = False
        mostrar()
        mostrar2()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        txtnumpesaje.Text = DataListado.SelectedCells.Item(1).Value
        txtpatente.Text = DataListado.SelectedCells.Item(4).Value
        txtcodbodega.Text = DataListado.SelectedCells.Item(18).Value
        txtbodega.Text = DataListado.SelectedCells.Item(19).Value
        txtidcontratos.Text = DataListado.SelectedCells.Item(26).Value
        txtnumcontrato.Text = DataListado.SelectedCells.Item(53).Value
        txtrutprov.Text = DataListado.SelectedCells.Item(28).Value
        txtnomprov.Text = DataListado.SelectedCells.Item(29).Value
        txtnumguia.Text = DataListado.SelectedCells.Item(2).Value
        txtidtransportista.Text = DataListado.SelectedCells.Item(5).Value
        txtnomtrans.Text = DataListado.SelectedCells.Item(6).Value
        txttara.Text = DataListado.SelectedCells.Item(47).Value
        txtidbodega.Text = DataListado.SelectedCells.Item(17).Value
        txtobservaciones.Text = DataListado.SelectedCells.Item(14).Value
        If DataListado.SelectedCells.Item(25).Value.ToString = "M" Then
            rbManual.Checked = True
        ElseIf DataListado.SelectedCells.Item(25).Value.ToString = "Q" Then
            rbMecanica.Checked = True
        End If
        txttipoenv.Text = DataListado.SelectedCells.Item(20).Value
        txtnomtipoenv.Text = DataListado.SelectedCells.Item(21).Value
        txtcantenvin.Text = DataListado.SelectedCells.Item(22).Value
        txtcantenvout.Text = DataListado.SelectedCells.Item(23).Value
        txtestadopesaje.Text = DataListado.SelectedCells.Item(15).Value
        txtiddetcontrato.Text = DataListado.SelectedCells.Item(30).Value
        txtidvariedad.Text = DataListado.SelectedCells.Item(48).Value
        txtcoduva.Text = DataListado.SelectedCells.Item(49).Value
        txtnomuva.Text = DataListado.SelectedCells.Item(50).Value
        txtcodcalidad.Text = DataListado.SelectedCells.Item(51).Value
        txtcalidad.Text = DataListado.SelectedCells.Item(52).Value
        txtidcalidad.Text = DataListado.SelectedCells.Item(38).Value
        txtidsector.Text = DataListado.SelectedCells.Item(32).Value
        txtnomsector.Text = DataListado.SelectedCells.Item(33).Value
        txtidsectorcuartel.Text = DataListado.SelectedCells.Item(31).Value
        txtidcuartel.Text = DataListado.SelectedCells.Item(34).Value
        txtnomcuartel.Text = DataListado.SelectedCells.Item(35).Value
        txtidsubcuartel.Text = DataListado.SelectedCells.Item(36).Value
        txtnomsubcuartel.Text = DataListado.SelectedCells.Item(37).Value
        txtbrix.Text = DataListado.SelectedCells.Item(39).Value
        txtdensidad.Text = DataListado.SelectedCells.Item(40).Value
        txttemp.Text = DataListado.SelectedCells.Item(41).Value
        txtapb.Text = DataListado.SelectedCells.Item(42).Value
        txtcastigo.Text = DataListado.SelectedCells.Item(43).Value
        txtobservaciones.Text = DataListado.SelectedCells.Item(14).Value
        txtpesajebruto.Text = DataListado.SelectedCells.Item(12).Value
        txtpesajetara.Text = DataListado.SelectedCells.Item(11).Value
        txtpesajeneto.Text = DataListado.SelectedCells.Item(13).Value



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
            btncapturapesotara.Visible = False
            btnanula.Visible = True
        ElseIf txtestadopesaje.Text = 1 Then
            frmContratos.txtflag.Text = 1
            frmBodega.txtflag.Text = 2
            btncapturapesotara.Visible = True
            btncapturapesobruto.Visible = False
        End If
        btnanula.Visible = True
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
    Public Sub emularbruto()

        Dim rnd1 As New Random()
        Dim N1 As Integer = rnd1.Next(25000, 45000)
        txtpesajebruto.Text = N1
    End Sub

    Public Sub emulartara()

        Dim rnd2 As New Random()
        Dim N2 As Integer = rnd2.Next(1000, 15000)
        txtpesajetara.Text = N2
    End Sub
    Private Sub btncapturapesobruto_Click(sender As Object, e As EventArgs) Handles btncapturapesobruto.Click
        If chkemular.Checked = True Then
            'Si checkbox emular se encuentra activado, emula un pesaje
            emularbruto()
            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
        Else
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
        End If
    End Sub

    Private Sub btncapturapesotara_Click(sender As Object, e As EventArgs) Handles btncapturapesotara.Click
        If chkemular.Checked = True Then
            'Si checkbox emular se encuentra activado, emula un pesaje
            emulartara()
            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
        Else

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
        End If
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
                        dts.gidcontrato = txtidcontratos.Text
                        'dts.ganiovendimia = txt.Text
                        'dts.gidsap = txtdocsap.Text
                        dts.gpesajeneto = txtpesajeneto.Text
                        dts.gpesajebruto = txtpesajebruto.Text
                        dts.gpesajetara = txtpesajetara.Text
                        dts.gidcontratovariedad = txtiddetcontrato.Text
                        dts.gidcontratosectorcuartel = txtidsectorcuartel.Text
                        dts.gnumguia = txtnumguia.Text
                        dts.gidbodega = txtidbodega.Text
                        If rbManual.Checked = True Then
                            dts.gtipocosecha = "M"
                        ElseIf rbMecanica.Checked = True Then
                            dts.gtipocosecha = "Q"
                        End If


                        If Val(txtestadopesaje.Text) = 0 Then
                            dts.gestadopesaje = 1 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            dts.gobservaciones = txtobservaciones.Text
                            If func.editarIn(dts) Then
                                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                mostrar()
                                mostrar2()
                                ' limpiar()
                            Else
                                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar()
                                mostrar2()
                                'limpiar()
                            End If
                            'ElseIf Val(txtestadopesaje.Text) = 1 Then
                            'Validar contenido DocSAP, GuiaDespacho y Observaciones
                            '    If txtdocsap.Text.Length <= 1 Or txtguiadespacho.Text.Length <= 1 Or txtobservaciones.Text.Length <= 1 Or txtTaraContenedor.Text.Length < 1 Then
                            '        Dim mensaje As String = "El campo DocSAP, Guía Despacho, Tara Contenedor u Observaciones se encuentra sin información. Desea continuar con la operación?"
                            '        Dim caption As String = "Campos sin información."
                            '        Dim botones As MessageBoxButtons = MessageBoxButtons.YesNo
                            '        Dim Result As DialogResult
                            '        Result = MessageBox.Show(mensaje, caption, botones, MessageBoxIcon.Exclamation)
                            '        If Result = System.Windows.Forms.DialogResult.No Then
                            '            txtdocsap.Select()
                            '        Else
                            '            dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            '            dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                            '            If func.editarOut(dts) Then
                            '                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '                If txtestadopesaje.Text = 1 Then
                            '                    frmreportecomprobante.txtidpesaje.Text = Me.txtnumpesaje.Text
                            '                    frmreportecomprobante.ShowDialog()
                            '                End If
                            '                mostrar()
                            '                mostrar2()
                            '                limpiar()
                            '            Else
                            '                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '                mostrar()
                            '                mostrar2()
                            '                limpiar()
                            '            End If
                            '        End If
                            '    Else
                            '        dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            '        dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                            '        If func.editarOut(dts) Then
                            '            MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '            If txtestadopesaje.Text = 1 Then
                            '                frmreportecomprobante.txtidpesaje.Text = Me.txtnumpesaje.Text
                            '                frmreportecomprobante.ShowDialog()
                            '            End If
                            '            mostrar()
                            '            mostrar2()
                            '            limpiar()
                            '        Else
                            '            MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '            mostrar()
                            '            mostrar2()
                            '            limpiar()
                            '        End If
                            '    End If
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
        limpiar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnanula_Click(sender As Object, e As EventArgs) Handles btnanula.Click


        Try
            Dim dts As New vpesajevendimia
            Dim func As New fpesajevendimia
            dts.gidpesajev = txtnumpesaje.Text
            'dts.gobservaciones = txtobservaciones.Text

            If func.anular(dts) Then
                MessageBox.Show("Pesaje Anulado Correctamente", "Anular Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Close()
                limpiar()
                'frmpesajedestareautomatico.Close()
                'frmpesajedestareautomatico.ShowDialog()
            Else
                MessageBox.Show("Pesaje no fue Anulado", "Anular Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.Close()
                limpiar()
                'frmpesajedestareautomatico.Close()
                'frmpesajedestareautomatico.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Public Class frmpesajesindestareautomatico
    Private dt As New DataTable
    Private Sub frmpesajesindestaremanual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'programar label de reloj
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        mostrar()
        mostrar2()
        btnanula.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub btnnuevopesaje_Click(sender As Object, e As EventArgs) Handles btnnuevopesaje.Click
        frmcreapesaje.ShowDialog()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpesajesindestareM
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                DataListado.DefaultCellStyle.SelectionForeColor = Color.White
            Else
                DataListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrar2()
        Try
            Dim func As New fpesajesindestareM
            dt = func.mostrar2
            If dt.Rows.Count <> 0 Then
                datalistado2.DataSource = dt
                datalistado2.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                datalistado2.DefaultCellStyle.SelectionForeColor = Color.White
            Else
                datalistado2.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txtnumpesaje.Text = ""
        txtpatente.Text = ""
        txtmarca.Text = ""
        txtidtipovehiculo.Text = ""
        txtnombretipovehiculo.Text = ""
        txtdocsap.Text = ""
        txtidtransportista.Text = ""
        txtnomtrans.Text = ""
        txttara.Text = ""
        txttipo.Text = ""
        txtobservaciones.Text = ""
        txtpesaje.Text = "0"
        btncapturapeso.Enabled = False
        btnanula.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        txtnumpesaje.Text = DataListado.SelectedCells.Item(1).Value
        txtdocsap.Text = DataListado.SelectedCells.Item(2).Value
        txtpatente.Text = DataListado.SelectedCells.Item(4).Value
        txtmarca.Text = DataListado.SelectedCells.Item(5).Value
        txtidtipovehiculo.Text = DataListado.SelectedCells.Item(6).Value
        txtnombretipovehiculo.Text = DataListado.SelectedCells.Item(7).Value
        txtidtransportista.Text = DataListado.SelectedCells.Item(8).Value
        txtnomtrans.Text = DataListado.SelectedCells.Item(9).Value
        txttara.Text = DataListado.SelectedCells.Item(10).Value
        txttipo.Text = DataListado.SelectedCells.Item(14).Value
        txtobservaciones.Text = DataListado.SelectedCells.Item(16).Value
        txtep.Text = DataListado.SelectedCells.Item(17).Value
        btncapturapeso.Enabled = True
        btncapturapeso.Visible = True
        btnanula.Visible = True
    End Sub
    Private Sub txttipo_TextChanged(sender As Object, e As EventArgs) Handles txttipo.TextChanged
        Try
            If txttipo.Text = 1 Then
                txtnomtipo.Text = "Pesaje Servicio"
            ElseIf txttipo.Text = 0 Then
                txtnomtipo.Text = "Pesaje Interno"
            Else
                txtnomtipo.Text = "Sin Información"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Private Sub btnGuardarpesaje_Click(sender As Object, e As EventArgs) Handles btnGuardarpesaje.Click

        Try
            If txtnumpesaje.Text <> "" Or txtpesaje.Text <> "" Or Val(txtpesaje.Text) > 0 Then
                If txtdocsap.Text.Length <= 1 Or txtguiadespacho.Text.Length <= 1 Or txtobservaciones.Text.Length <= 1 Then
                    Dim mensaje As String = "El campo DocSAP, Guía Despacho u Observaciones se encuentra sin información. Desea continuar con la operación?"
                    Dim caption As String = "Campos sin información."
                    Dim botones As MessageBoxButtons = MessageBoxButtons.YesNo
                    Dim Result As DialogResult
                    Result = MessageBox.Show(mensaje, caption, botones, MessageBoxIcon.Exclamation)

                    If Result = System.Windows.Forms.DialogResult.No Then

                        txtdocsap.Select()

                    Else
                        Try
                            Dim dts As New vpesajesindestareM
                            Dim func As New fpesajesindestareM

                            dts.gidpesaje = txtnumpesaje.Text
                            dts.gidsap = txtdocsap.Text
                            dts.gpesajeneto = txtpesaje.Text
                            dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                            dts.gnumguia = txtguiadespacho.Text
                            'If Val(txtep.Text) = 0 Then
                            '    dts.gestadopesaje = 1 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            'ElseIf (txtep.Text) = 2 Then
                            dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                            'End If
                            dts.gvisible = 1 '0:NoVisible 1:Visible


                            If func.editar(dts) Then
                                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


                                frmreportecomprobantesindestare.txtidpesaje.Text = Me.txtnumpesaje.Text
                                frmreportecomprobantesindestare.ShowDialog()

                                mostrar()
                                mostrar2()
                                limpiar()

                            Else
                                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                mostrar()
                                mostrar2()
                                limpiar()


                            End If
                        Catch ex As Exception

                            MsgBox(ex.Message)

                        End Try
                    End If
                Else
                    Try
                        Dim dts As New vpesajesindestareM
                        Dim func As New fpesajesindestareM

                        dts.gidpesaje = txtnumpesaje.Text
                        dts.gidsap = txtdocsap.Text
                        dts.gpesajeneto = txtpesaje.Text
                        dts.gobservaciones = txtobservaciones.Text & ". Pesado por: " & frmPrincipal.lbluser.Text
                        dts.gnumguia = txtguiadespacho.Text
                        'If Val(txtep.Text) = 0 Then
                        '    dts.gestadopesaje = 1 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                        'ElseIf (txtep.Text) = 2 Then
                        dts.gestadopesaje = 2 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
                        'End If
                        dts.gvisible = 1 '0:NoVisible 1:Visible


                        If func.editar(dts) Then
                            MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


                            frmreportecomprobantesindestare.txtidpesaje.Text = Me.txtnumpesaje.Text
                            frmreportecomprobantesindestare.ShowDialog()

                            mostrar()
                            mostrar2()
                            limpiar()

                        Else
                            MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            mostrar2()
                            limpiar()


                        End If
                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try


                End If

            Else
                MessageBox.Show("Debe Seleccionar un registro de pesaje, o ingresar un valor para el pesaje, o pesaje debe ser mayor que 0", "Romana Morandé", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncapturapeso_Click(sender As Object, e As EventArgs) Handles btncapturapeso.Click
        txtpesaje.Text = "0"
        While txtpesaje.Text = 0
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
                        txtpesaje.Text = ""
                        buffer = Mid(buffer, 6, 5)
                        'MsgBox(buffer)
                        If Val(buffer) <= 60000 Then
                            txtpesaje.Text = Val(buffer)
                            sppuerto.Close()
                            'ElseIf Val(buffer) > 60000 Then
                            'MsgBox("Por diseño de la romana, el pesaje capturado no puede exceder los 60.000 Kg", MsgBoxStyle.Exclamation)
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

    Private Sub btnanula_Click(sender As Object, e As EventArgs) Handles btnanula.Click
        frmanulaautomaticoSinDestare.ShowDialog()
    End Sub

    Private Sub txtdocsap_GotFocus(sender As Object, e As EventArgs) Handles txtdocsap.GotFocus
        If txtdocsap.Text = "0" Then
            txtdocsap.Text = ""
        End If
    End Sub

    Private Sub txtguiadespacho_GotFocus(sender As Object, e As EventArgs) Handles txtguiadespacho.GotFocus
        If txtguiadespacho.Text = "0" Then
            txtguiadespacho.Text = ""
        End If
    End Sub

    Private Sub txtguiadespacho_LostFocus(sender As Object, e As EventArgs) Handles txtguiadespacho.LostFocus
        If txtguiadespacho.Text = "" Then
            txtguiadespacho.Text = "0"
        End If
    End Sub

    Private Sub txtdocsap_LostFocus(sender As Object, e As EventArgs) Handles txtdocsap.LostFocus
        If txtdocsap.Text = "" Then
            txtdocsap.Text = "0"
        End If
    End Sub

End Class
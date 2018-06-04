Public Class frmpesajedestaremanual

    Private dt As New DataTable
    Private Sub frmpesajedestaremanual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'programar label de reloj
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
        mostrar()
        mostrar2()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblhora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub btnnuevopesaje_Click(sender As Object, e As EventArgs) Handles btnnuevopesaje.Click
        frmcreapesajedestareM.ShowDialog()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpesajedestareM
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
            Dim func As New fpesajedestareM
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
        txtguiadespacho.Text = ""
        txtidtransportista.Text = ""
        txtnomtrans.Text = ""
        txttara.Text = ""
        txttipo.Text = ""
        txtobservaciones.Text = ""
        txtpesajeneto.Text = ""
        txtpesajetara.Text = ""
        txtpesajebruto.Text = ""
        btnanula.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub



    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        txtnumpesaje.Text = DataListado.SelectedCells.Item(1).Value
        txtdocsap.Text = DataListado.SelectedCells.Item(2).Value
        txtguiadespacho.Text = DataListado.SelectedCells.Item(3).Value
        txtpatente.Text = DataListado.SelectedCells.Item(4).Value
        txtmarca.Text = DataListado.SelectedCells.Item(5).Value
        txtidtipovehiculo.Text = DataListado.SelectedCells.Item(6).Value
        txtnombretipovehiculo.Text = DataListado.SelectedCells.Item(7).Value
        txtidtransportista.Text = DataListado.SelectedCells.Item(8).Value
        txtnomtrans.Text = DataListado.SelectedCells.Item(9).Value
        txtpesajetara.Text = DataListado.SelectedCells.Item(10).Value
        txtpesajebruto.Text = DataListado.SelectedCells.Item(11).Value
        txtpesajeneto.Text = DataListado.SelectedCells.Item(12).Value
        txttara.Text = DataListado.SelectedCells.Item(16).Value
        txttipo.Text = DataListado.SelectedCells.Item(15).Value
        txtobservaciones.Text = DataListado.SelectedCells.Item(17).Value
        txtTaraContenedor.Text = DataListado.SelectedCells.Item(19).Value
        txtVgm.Text = DataListado.SelectedCells.Item(13).Value
        btnanula.Visible = True
        txtestadopesaje.Text = DataListado.SelectedCells.Item(18).Value
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
        txtVgm.Text = Val(txtpesajeneto.Text) + Val(txtTaraContenedor.Text)
        Dim validar As Integer = 0
        If txtestadopesaje.Text = "1" And Val(txtpesajeneto.Text) > 0 Then
            validar = 1
        End If

        If validar = 1 Or txtestadopesaje.Text = 0 Then
            Try
                If txtnumpesaje.Text <> "" Or txtpesajetara.Text <> "" Or txtpesajebruto.Text <> "" Or Val(txtpesajeneto.Text > 0) Then
                    Try
                        Dim dts As New vpesajedestareM
                        Dim func As New fpesajedestareM
                        dts.gidpesaje = txtnumpesaje.Text
                        dts.gnumguia = txtguiadespacho.Text
                        dts.gidsap = txtdocsap.Text
                        dts.gpesajeneto = txtpesajeneto.Text
                        dts.gpesajebruto = txtpesajebruto.Text
                        dts.gpesajetara = txtpesajetara.Text
                        dts.gtaracont = txtTaraContenedor.Text
                        dts.gvgm = txtVgm.Text

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
    
    Private Sub txtpesajetara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesajetara.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
        txtVgm.Text = Val(txtpesajeneto.Text) + Val(txtTaraContenedor.Text)
    End Sub

    Private Sub txtpesajebruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesajebruto.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
        txtVgm.Text = Val(txtpesajeneto.Text) + Val(txtTaraContenedor.Text)
    End Sub
    
    Private Sub txtpesajetara_LostFocus(sender As Object, e As EventArgs) Handles txtpesajetara.LostFocus
        If txtpesajetara.Text = "" Then
            txtpesajetara.Text = "0"
        End If
        If Val(txtpesajeneto.Text) <= 60000 Then
            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
            txtVgm.Text = Val(txtpesajeneto.Text) + Val(txtTaraContenedor.Text)
        Else
            MsgBox("Por diseño de la romana, el pesaje ingresado no puede exceder los 60.000 Kg", MsgBoxStyle.Exclamation)
        End If
    End Sub
    
    Private Sub txtpesajebruto_LostFocus(sender As Object, e As EventArgs) Handles txtpesajebruto.LostFocus
        If txtpesajebruto.Text = "" Then
            txtpesajebruto.Text = "0"
        End If
        If Val(txtpesajeneto.Text) <= 60000 Then
            txtpesajeneto.Text = Val(txtpesajebruto.Text) - Val(txtpesajetara.Text)
            txtVgm.Text = Val(txtpesajeneto.Text) + Val(txtTaraContenedor.Text)
        Else
            MsgBox("Por diseño de la romana, el pesaje ingresado no puede exceder los 60.000 Kg", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnanula_Click(sender As Object, e As EventArgs) Handles btnanula.Click
        frmanulapesajecondestare.ShowDialog()
    End Sub

    Private Sub DataListado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataListado.CellFormatting
        For i As Integer = 0 To DataListado.Rows.Count - 1
            If DataListado.Rows(i).Cells(18).Value = 1 Then
                DataListado.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
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




    Private Sub txtTaraContenedor_LostFocus(sender As Object, e As EventArgs) Handles txtTaraContenedor.LostFocus
        If txtTaraContenedor.Text = "" Then
            txtTaraContenedor.Text = "0"
        End If
    End Sub
End Class
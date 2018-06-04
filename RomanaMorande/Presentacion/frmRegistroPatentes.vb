Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient

Public Class frmRegistroPatentes
    Private dt As New DataTable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
    Private Sub btnBuscarTransportista_Click(sender As Object, e As EventArgs) Handles btnBuscarTransportista.Click
        frmTransportistas.txtflag.Text = "1"
        frmTransportistas.ShowDialog()
    End Sub

    Private Sub btnBuscarTipoVehiculo_Click(sender As Object, e As EventArgs) Handles btnBuscarTipoVehiculo.Click
        frmTipoVehiculo.txtflag.Text = "1"
        frmTipoVehiculo.ShowDialog()
    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
        btnNuevo.Visible = False

        txtidvehiculo.Text = ""
        txtpatente.Text = ""
        txtmarca.Text = ""
        txtIdTransportista.Text = ""
        txtNombreTrasportista.Text = ""
        txtIdTipoVehiculo.Text = ""
        txtNombreTipoVehiculo.Text = ""
        txtTara.Text = "0"
        txtbuscapatente.Text = ""

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()

    End Sub

    Private Sub frmRegistroPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpatente
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.ColumnHeadersVisible = True
                DataListado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                DataListado.DefaultCellStyle.SelectionForeColor = Color.White
            Else
                DataListado.DataSource = Nothing
                DataListado.ColumnHeadersVisible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnguardar.Visible = True
        btnEditar.Visible = False
        buscarpatente()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtpatente.Text <> "" And txtmarca.Text <> "" And txtIdTransportista.Text <> "" And txtIdTipoVehiculo.Text <> "" And txtTara.Text <> "" Then
            Try
                Dim dts As New vpatente
                Dim func As New fpatente

                dts.gpatente = txtpatente.Text
                dts.gmarca = txtmarca.Text
                dts.gidtransportista = CType(Val(txtIdTransportista.Text), Integer)
                dts.gidtipovehiculo = CType(Val(txtIdTipoVehiculo.Text), Integer)
                dts.gtara = Val(txtTara.Text)

                If func.insertar(dts) Then
                    MessageBox.Show("Patente Registrada Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else

                    MessageBox.Show("Patente no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        mostrar()
        limpiar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar el registro?", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtpatente.Text <> "" Then
                Try
                    Dim dts As New vpatente
                    Dim func As New fpatente

                    dts.gidvehiculo = txtidvehiculo.Text
                    dts.gpatente = txtpatente.Text
                    dts.gmarca = txtmarca.Text
                    dts.gidtransportista = txtIdTransportista.Text
                    dts.gidvehiculo = txtidvehiculo.Text
                    dts.gtara = txtTara.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Patente Editada Correctamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Patente no fue Editada, intente nuevamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        limpiar()
        mostrar()
    End Sub


    '-------VALIDA LOS CAMPOS CON ALERTAS
    Private Sub txtpatente_Validating(sender As Object, e As CancelEventArgs) Handles txtpatente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Patente")
        End If
    End Sub

    Private Sub txtmarca_Validating(sender As Object, e As CancelEventArgs) Handles txtmarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Nombre Marca")
        End If
    End Sub

    Private Sub txtNombreTrasportista_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreTrasportista.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione Transportista")
        End If
    End Sub

    Private Sub txtNombreTipoVehiculo_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreTipoVehiculo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione Tipo de Vehículo")
        End If
    End Sub

    Private Sub txttara_Validating(sender As Object, e As CancelEventArgs) Handles txtTara.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Tara de la Patente")
        End If
    End Sub

    Private Sub txtpatente_TextChanged(sender As Object, e As EventArgs) Handles txtpatente.TextChanged
        txtpatente.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtmarca_TextChanged(sender As Object, e As EventArgs) Handles txtmarca.TextChanged
        txtmarca.CharacterCasing = CharacterCasing.Upper
    End Sub



    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        frmcreapesajedestareM.txtidvehiculo.Text = DataListado.SelectedCells.Item(0).Value
        frmcreapesajedestareM.txtpatente.Text = DataListado.SelectedCells.Item(1).Value
        frmcreapesajedestareM.txtmarca.Text = DataListado.SelectedCells.Item(2).Value
        frmcreapesajedestareM.txttransportista.Text = DataListado.SelectedCells.Item(3).Value
        frmcreapesajedestareM.txttipovehiculo.Text = DataListado.SelectedCells.Item(4).Value
        frmcreapesajedestareM.txttara.Text = DataListado.SelectedCells.Item(5).Value


        frmcreapesaje.txtidvehiculo.Text = DataListado.SelectedCells.Item(0).Value
        frmcreapesaje.txtpatente.Text = DataListado.SelectedCells.Item(1).Value
        frmcreapesaje.txtmarca.Text = DataListado.SelectedCells.Item(2).Value
        frmcreapesaje.txttransportista.Text = DataListado.SelectedCells.Item(3).Value
        frmcreapesaje.txttipovehiculo.Text = DataListado.SelectedCells.Item(4).Value
        frmcreapesaje.txttara.Text = DataListado.SelectedCells.Item(5).Value



        Me.Close()
    End Sub



    Private Sub txtTara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTara.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTara_TextChanged(sender As Object, e As EventArgs) Handles txtTara.TextChanged

    End Sub

    Private Sub txtbuscapatente_TextChanged(sender As Object, e As EventArgs) Handles txtbuscapatente.TextChanged
        buscarpatente()
    End Sub
    Private Sub buscarpatente()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "Patente like '" & txtbuscapatente.Text & "%'"

            DataListado.DataSource = dv
            DataListado.Update()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
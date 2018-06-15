Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPatenteVendimia
    Private dt As New DataTable

    Public Sub limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
        btnNuevo.Visible = False

        txtidvehiculo.Text = ""
        txtpatente.Text = ""
        txtIdTransportista.Text = ""
        txtNombreTrasportista.Text = ""
        txtIdTipoVehiculo.Text = ""
        txtNombreTipoVehiculo.Text = ""
        txtTara.Text = "0"
        txtbuscapatente.Text = ""
        txtidtipoenvase.Text = ""
        txtnombretipoenvase.Text = ""
        txtcantenvase.Text = ""

    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fpatentevendimia
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
        limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
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



    Private Sub btnBuscarTransportista_Click(sender As Object, e As EventArgs) Handles btnBuscarTransportista.Click
        frmTransportistas.txtflag.Text = 2
        frmTransportistas.ShowDialog()
    End Sub

    Private Sub btnBuscarTipoVehiculo_Click(sender As Object, e As EventArgs) Handles btnBuscarTipoVehiculo.Click
        frmTipoVehiculo.txtflag.Text = "2"
        frmTipoVehiculo.ShowDialog()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtpatente.Text <> "" And txtIdTransportista.Text <> "" And txtIdTipoVehiculo.Text <> "" And txtTara.Text <> "" Then
            Try
                Dim dts As New vpatentevendimia
                Dim func As New fpatentevendimia

                dts.gpatente = txtpatente.Text
                dts.gidtransportista = CType(Val(txtIdTransportista.Text), Integer)
                dts.gidtipovehiculo = CType(Val(txtIdTipoVehiculo.Text), Integer)
                dts.gtara = Val(txtTara.Text)
                dts.gtipoenvase = Val(txtidtipoenvase.Text)
                dts.gcantenv = Val(txtcantenvase.Text)


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
            MessageBox.Show("Verifique, falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        mostrar()
        limpiar()
    End Sub

    Private Sub frmPatenteVendimia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmenvases.txtflag.Text = "2"
        frmenvases.ShowDialog()
    End Sub



    Private Sub DataListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentDoubleClick
        frmCreaPesajeVendimia.txtidvehiculo.Text = DataListado.SelectedCells.Item(0).Value
        frmCreaPesajeVendimia.txtpatente.Text = DataListado.SelectedCells.Item(1).Value
        frmCreaPesajeVendimia.txttipoenvase.Text = DataListado.SelectedCells.Item(6).Value
        frmCreaPesajeVendimia.txttransportista.Text = DataListado.SelectedCells.Item(3).Value
        frmCreaPesajeVendimia.txttipovehiculo.Text = DataListado.SelectedCells.Item(5).Value
        frmCreaPesajeVendimia.txttara.Text = DataListado.SelectedCells.Item(8).Value
        frmCreaPesajeVendimia.txtcanenvases.Text = DataListado.SelectedCells.Item(7).Value

        Me.Close()
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub

    Private Sub txtbuscapatente_TextChanged(sender As Object, e As EventArgs) Handles txtbuscapatente.TextChanged
        buscarpatente()
    End Sub
End Class
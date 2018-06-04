Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTipoVehiculo
    Private dt As New DataTable

    Private Sub frmTipoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()



    End Sub





    Private Sub mostrar()
        Try
            Dim func As New ftipovehiculos
            dt = func.mostrar
            DataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.ColumnHeadersVisible = True
                DataListado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                DataListado.DefaultCellStyle.SelectionForeColor = Color.White
                inexistente.Visible = False
            Else
                DataListado.DataSource = Nothing
                DataListado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btnguardar.Visible = True
        btnEditar.Visible = False

    End Sub



    Private Sub txtNombreTipoVehiculo_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreTipoVehiculo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Nombre Tipo Vehículo")
        End If
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
        txtIdTipoVehiculo.Text = ""
        txtNombreTipoVehiculo.Text = ""

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtNombreTipoVehiculo.Text <> "" Then
            Try
                Dim dts As New vtipovehiculo
                Dim func As New ftipovehiculos

                dts.gnombrevehiculo = txtNombreTipoVehiculo.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Tipo Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Tipo no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub





    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        txtIdTipoVehiculo.Text = DataListado.SelectedCells.Item(1).Value
        txtNombreTipoVehiculo.Text = DataListado.SelectedCells.Item(2).Value
        btnEditar.Visible = True
        btnguardar.Visible = False

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

        Dim result As DialogResult
        result = MessageBox.Show("Realimente desea editar el registro?", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtNombreTipoVehiculo.Text <> "" Then
                Try
                    Dim dts As New vtipovehiculo
                    Dim func As New ftipovehiculos

                    dts.gidtipovehiculo = txtIdTipoVehiculo.Text
                    dts.gnombrevehiculo = txtNombreTipoVehiculo.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Tipo Editado Correctamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Tipo no fue Editado, intente nuevamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            DataListado.Columns.Item("Eliminar").Visible = True
        Else
            DataListado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea eliminar los tipos seleccionados?", "Eliminar...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idTipoVehiculo").Value)
                        Dim vdb As New vtipovehiculo
                        Dim func As New ftipovehiculos
                        vdb.gidtipovehiculo = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Tipo no fue eliminado, intente nuevamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()
                            limpiar()
                        End If


                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Se cancela eliminacion de registro, intente nuevamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
        cbEliminar.CheckState = CheckState.Unchecked
        mostrar()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        txtNombreTipoVehiculo.Select()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        frmRegistroPatentes.txtIdTipoVehiculo.Text = DataListado.SelectedCells.Item(1).Value
        frmRegistroPatentes.txtNombreTipoVehiculo.Text = DataListado.SelectedCells.Item(2).Value
        Me.Close()
    End Sub


End Class
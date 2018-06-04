Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTransportistas
    Private dt As New DataTable

    Private Sub frmTrasportistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()
        limpiar()


    End Sub





    Private Sub mostrar()
        Try
            Dim func As New ftransportistas
            dt = func.mostrar
            DataListado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                DataListado.DataSource = dt
                DataListado.ColumnHeadersVisible = True
                inexistente.Visible = False
                DataListado.DefaultCellStyle.SelectionBackColor = Color.DarkRed
                DataListado.DefaultCellStyle.SelectionForeColor = Color.White
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
        btnNuevo.Visible = False


    End Sub



    Private Sub txtNombreTipoVehiculo_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreTransportista.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Nombre Transportista")
        End If
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
        btnNuevo.Visible = False
        txtIdTrasportista.Text = ""
        txtrut.Text = ""
        txtdv.Text = ""
        txtNombreTransportista.Text = ""
        txtrut.Enabled = True
        txtdv.Visible = True


    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtNombreTransportista.Text <> "" Then
            Try
                Dim dts As New vtransportistas
                Dim func As New ftransportistas

                dts.gnombretransportista = txtNombreTransportista.Text
                dts.grut = txtrut.Text & "-" & txtdv.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Transportista Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Transportista no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Try
            txtIdTrasportista.Text = DataListado.SelectedCells.Item(1).Value
            txtrut.Text = DataListado.SelectedCells.Item(2).Value
            txtNombreTransportista.Text = DataListado.SelectedCells.Item(3).Value
            btnEditar.Visible = True
            btnguardar.Visible = False
            txtrut.Enabled = False
            txtdv.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar el registro?", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtNombreTransportista.Text <> "" Then
                Try
                    Dim dts As New vtransportistas
                    Dim func As New ftransportistas

                    dts.gidtransportista = txtIdTrasportista.Text
                    dts.gnombretransportista = txtNombreTransportista.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Transportista Editado Correctamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Transportista no fue Editado, intente nuevamente", "Modificando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idTransportista").Value)
                        Dim vdb As New vtransportistas
                        Dim func As New ftransportistas
                        vdb.gidtransportista = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Transportista no fue eliminado, intente nuevamente", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        txtNombreTransportista.Select()
    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmRegistroPatentes.txtIdTransportista.Text = DataListado.SelectedCells.Item(1).Value
            frmRegistroPatentes.txtNombreTrasportista.Text = DataListado.SelectedCells.Item(2).Value
            Me.Close()


        End If
    End Sub



    Function MuestraDigito(R As Long) As String
        Dim i As Integer, sum As Integer
        Dim Rut As Long

        i = 1 : sum = 0
        Do
            i = i + 1
            sum = sum + ((R Mod 10) * i)
            R = R \ 10
            If i = 7 Then i = 1
        Loop Until R = 0

        sum = sum Mod 11
        sum = 11 - sum

        Select Case sum
            Case 11
                MuestraDigito = "0"
            Case 10
                MuestraDigito = "K"
            Case Else
                MuestraDigito = sum
        End Select

    End Function



    Private Sub txtrut_LostFocus(sender As Object, e As EventArgs) Handles txtrut.LostFocus
        Try
            txtdv.Text = MuestraDigito(txtrut.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub txtrut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrut.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
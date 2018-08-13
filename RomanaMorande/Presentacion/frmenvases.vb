Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Public Class frmenvases
    Private dt As New DataTable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub envases_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()
        swactivo.Value = False
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fenvases
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



    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        txtidtipoenvase.Text = DataListado.SelectedCells.Item(1).Value
        txtnombretipoenvase.Text = DataListado.SelectedCells.Item(2).Value
        txtpesoenvase.Text = DataListado.SelectedCells.Item(3).Value
        If DataListado.SelectedCells.Item(4).Value = True Then
            swactivo.Value = True
        Else
            swactivo.Value = False
        End If
        btnEditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombretipoenvase.Text <> "" Then
            Try
                Dim dts As New venvases
                Dim func As New fenvases

                dts.gnombreenvase = txtnombretipoenvase.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Tipo Envase Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Tipo Envase no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Sub limpiar()
        btnguardar.Visible = True
        btnEditar.Visible = False
        txtidtipoenvase.Text = ""
        txtnombretipoenvase.Text = ""
        txtpesoenvase.Text = ""
        swactivo.Value = False

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar el registro?", "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombretipoenvase.Text <> "" Then
                Try
                    Dim dts As New venvases
                    Dim func As New fenvases

                    dts.gidenvase = txtidtipoenvase.Text
                    dts.gnombreenvase = txtnombretipoenvase.Text
                    dts.gpeso = txtpesoenvase.Text
                    dts.gactivo = swactivo.Value

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

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If txtflag.Text = 1 Then
            frmSeleccionTipoEnvase.txtidenvase.Text = DataListado.SelectedCells.Item(1).Value
            frmSeleccionTipoEnvase.txtnomenvase.Text = DataListado.SelectedCells.Item(2).Value
            frmSeleccionTipoEnvase.txtkgenv.Text = DataListado.SelectedCells.Item(3).Value
            frmSeleccionTipoEnvase.txtcantenv.Text = 0
            Me.Close()
        ElseIf txtflag.Text = 2 Then
            frmPatenteVendimia.txtidtipoenvase.Text = DataListado.SelectedCells.Item(1).Value
            frmPatenteVendimia.txtnombretipoenvase.Text = DataListado.SelectedCells.Item(2).Value
            frmSeleccionTipoEnvase.txtkgenv.Text = DataListado.SelectedCells.Item(3).Value
            Me.Close()
        End If
    End Sub
End Class
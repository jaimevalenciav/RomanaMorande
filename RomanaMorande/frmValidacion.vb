Imports System.Data
Imports System.Data.SqlClient

Public Class frmValidacion
    Public cnn As SqlConnection
    Public dtr As SqlDataReader
    Public cmd As SqlCommand
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtIdUsuario.Text = "" Then
                MsgBox("Por favor ingrese los datos de Usuario", MsgBoxStyle.Exclamation)
                txtIdUsuario.Focus()
            ElseIf txtPassUsuario.Text = "" Then
                MsgBox("Por favor ingrese los datos de Clave", MsgBoxStyle.Critical)
                txtPassUsuario.Focus()

            Else
                cnn = New SqlConnection("Data Source = SQLSERVER02\BCI_ERP_C; Initial Catalog= pesaje; Persist Security Info = True; user Id = pesaje; Password= sinpassword")
                cmd = New SqlCommand("sp_VerificarUsuario", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idUsuario", txtIdUsuario.Text)
                cmd.Parameters.AddWithValue("@passUsuario", txtPassUsuario.Text)
                cnn.Open()
                dtr = cmd.ExecuteReader
                If dtr.HasRows Then
                    ''Se comenta mensaje de bienvenida, no es necesario''MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information)
                    Me.Hide()
                    frmPrincipal.Show()
                    frmPrincipal.lbluser.Text = txtIdUsuario.Text
                Else
                    MsgBox("La información de Usuario o Contraseña es incorrecta, Verifique los datos ingresados", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()

    End Sub



    Private Sub txtPassUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtIdUsuario.Text = "" Then
                    MsgBox("Por favor ingrese los datos de Usuario", MsgBoxStyle.Exclamation)
                    txtIdUsuario.Focus()
                ElseIf txtPassUsuario.Text = "" Then
                    MsgBox("Por favor ingrese los datos de Clave", MsgBoxStyle.Critical)
                    txtPassUsuario.Focus()

                Else
                    cnn = New SqlConnection("Data Source = SQLSERVER02\BCI_ERP_C; Initial Catalog= pesaje; Persist Security Info = True; user Id = pesaje; Password= sinpassword")
                    cmd = New SqlCommand("sp_VerificarUsuario", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idUsuario", txtIdUsuario.Text)
                    cmd.Parameters.AddWithValue("@passUsuario", txtPassUsuario.Text)
                    cnn.Open()
                    dtr = cmd.ExecuteReader
                    If dtr.HasRows Then
                        ''Se comenta mensaje de bienvenida, no es necesario''MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information)
                        Me.Hide()
                        frmPrincipal.Show()
                        frmPrincipal.lbluser.Text = txtIdUsuario.Text
                    Else
                        MsgBox("La información de Usuario o Contraseña es incorrecta, Verifique los datos ingresados", MsgBoxStyle.Critical)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub



    Private Sub txtIdUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtIdUsuario.Text = "" Then
                    MsgBox("Por favor ingrese los datos de Usuario", MsgBoxStyle.Exclamation)
                    txtIdUsuario.Focus()
                ElseIf txtPassUsuario.Text = "" Then
                    MsgBox("Por favor ingrese los datos de Clave", MsgBoxStyle.Critical)
                    txtPassUsuario.Focus()

                Else
                    cnn = New SqlConnection("Data Source = SQLSERVER02\BCI_ERP_C; Initial Catalog= pesaje; Persist Security Info = True; user Id = pesaje; Password= sinpassword")
                    cmd = New SqlCommand("sp_VerificarUsuario", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idUsuario", txtIdUsuario.Text)
                    cmd.Parameters.AddWithValue("@passUsuario", txtPassUsuario.Text)
                    cnn.Open()
                    dtr = cmd.ExecuteReader
                    If dtr.HasRows Then
                        ''Se comenta mensaje de bienvenida, no es necesario''MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information)
                        Me.Hide()
                        frmPrincipal.Show()
                        frmPrincipal.lbluser.Text = txtIdUsuario.Text
                    Else
                        MsgBox("La información de Usuario o Contraseña es incorrecta, Verifique los datos ingresados", MsgBoxStyle.Critical)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub


End Class

Imports System.Data.SqlClient
Public Class fpesajedestareM
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pesajescondestare")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try

    End Function


    Public Function mostrar2() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pesajescondestare2")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try

    End Function

    Public Function mostrar3() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pesajestodos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try

    End Function

    Public Function insertar(ByVal dts As vpesajedestareM) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pesajesdestareM")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idsap", dts.gidsap)
            cmd.Parameters.AddWithValue("@numguia", dts.gnumguia)
            cmd.Parameters.AddWithValue("@idvehiculo", dts.gidvehiculo)
            'cmd.Parameters.AddWithValue("@fechacreacion", dts.gfechacreacion)
            'cmd.Parameters.AddWithValue("@fechapesajein", dts.gfechapesajein)
            'cmd.Parameters.AddWithValue("@horapesajein", dts.ghorapesajein)
            'cmd.Parameters.AddWithValue("@fechapesajeout", dts.gfechapesajeout)
            'cmd.Parameters.AddWithValue("@horapesajeout", dts.ghorapesajeout)
            cmd.Parameters.AddWithValue("@pesajein1", dts.gpesajein1)
            cmd.Parameters.AddWithValue("@pesajein2", dts.gpesajein2)
            cmd.Parameters.AddWithValue("@pesajein3", dts.gpesajein3)
            cmd.Parameters.AddWithValue("@pesajein4", dts.gpesajein4)
            cmd.Parameters.AddWithValue("@pesajeout1", dts.gpesajeout1)
            cmd.Parameters.AddWithValue("@pesajeout2", dts.gpesajeout2)
            cmd.Parameters.AddWithValue("@pesajeout3", dts.gpesajeout3)
            cmd.Parameters.AddWithValue("@pesajeout4", dts.gpesajeout4)
            cmd.Parameters.AddWithValue("@pesajetara", dts.gpesajetara)
            cmd.Parameters.AddWithValue("@pesajebruto", dts.gpesajebruto)
            cmd.Parameters.AddWithValue("@pesajeneto", dts.gpesajeneto)
            cmd.Parameters.AddWithValue("@pesaje", dts.gpesaje)
            cmd.Parameters.AddWithValue("@tipopesaje", dts.gtipopesaje)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@estadopesaje", dts.gestadopesaje)
            cmd.Parameters.AddWithValue("@visible", dts.gvisible)
            cmd.Parameters.AddWithValue("@taracont", dts.gtaracont)
            cmd.Parameters.AddWithValue("@vgm", dts.gvgm)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function editarIn(ByVal dts As vpesajedestareM) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pesajesdestareM")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpesaje", dts.gidpesaje)
            cmd.Parameters.AddWithValue("@numguia", dts.gnumguia)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@pesajeneto", dts.gpesajeneto)
            cmd.Parameters.AddWithValue("@pesajetara", dts.gpesajetara)
            cmd.Parameters.AddWithValue("@pesajebruto", dts.gpesajebruto)
            cmd.Parameters.AddWithValue("@idsap", dts.gidsap)
            cmd.Parameters.AddWithValue("@estadopesaje", dts.gestadopesaje)
            cmd.Parameters.AddWithValue("@taracont", dts.gtaracont)
            cmd.Parameters.AddWithValue("@vgm", dts.gvgm)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function editarOut(ByVal dts As vpesajedestareM) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pesajesdestareMSalida")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpesaje", dts.gidpesaje)
            cmd.Parameters.AddWithValue("@numguia", dts.gnumguia)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@pesajeneto", dts.gpesajeneto)
            cmd.Parameters.AddWithValue("@pesajetara", dts.gpesajetara)
            cmd.Parameters.AddWithValue("@pesajebruto", dts.gpesajebruto)
            cmd.Parameters.AddWithValue("@idsap", dts.gidsap)
            cmd.Parameters.AddWithValue("@estadopesaje", dts.gestadopesaje)
            cmd.Parameters.AddWithValue("@taracont", dts.gtaracont)
            cmd.Parameters.AddWithValue("@vgm", dts.gvgm)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    'Public Function eliminar(ByVal dts As vtipovehiculo) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("eliminar_tipovehiculo")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        cmd.Parameters.Add("@idtipovehiculo", SqlDbType.NVarChar, 50).Value = dts.gidtipovehiculo


    '        If cmd.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()

    '    End Try


    'End Function
End Class

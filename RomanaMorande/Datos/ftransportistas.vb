Imports System.Data.SqlClient
Public Class ftransportistas
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_transportistas")
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

    Public Function insertar(ByVal dts As vtransportistas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_transportistas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@rut", dts.grut)
            cmd.Parameters.AddWithValue("@nombretransportista", dts.gnombretransportista)
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

    Public Function editar(ByVal dts As vtransportistas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_transportista")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idtransportista", dts.gidtransportista)
            cmd.Parameters.AddWithValue("@rut", dts.grut)
            cmd.Parameters.AddWithValue("@nombretransportista", dts.gnombretransportista)
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

    Public Function eliminar(ByVal dts As vtransportistas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_transportista")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idtransportista", SqlDbType.NVarChar, 50).Value = dts.gidtransportista


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



End Class

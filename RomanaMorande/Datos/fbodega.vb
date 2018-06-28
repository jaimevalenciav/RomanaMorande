Imports System.Data.SqlClient
Public Class fbodega
    Inherits conexion
    Dim cmd As SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_bodega")
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

    Public Function insertar(ByVal dts As vbodega) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_bodega")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombrebodega", dts.gnombrebodega)
            cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)

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

    Public Function editar(ByVal dts As vbodega) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_bodega")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombrebodega", dts.gnombrebodega)
            cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)
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

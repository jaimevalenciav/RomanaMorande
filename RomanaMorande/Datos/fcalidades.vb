Imports System.Data.SqlClient
Public Class fcalidades
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_calidades")
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


    Public Function insertar(ByVal dts As vcalidades) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_calidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcalidad", dts.gidcalidad)
            cmd.Parameters.AddWithValue("@nomcalidad", dts.gnomcalidad)
            cmd.Parameters.AddWithValue("@nomcorto", dts.gnomcorto)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)
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

    Public Function editar(ByVal dts As vcalidades) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_calidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idcalidad", dts.gidcalidad)
            cmd.Parameters.AddWithValue("@nomcalidad", dts.gnomcalidad)
            cmd.Parameters.AddWithValue("@nomcorto", dts.gnomcorto)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)
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

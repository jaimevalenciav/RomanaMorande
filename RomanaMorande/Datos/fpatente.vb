Imports System.Data.SqlClient
Public Class fpatente
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_patentes")
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
            cmd = New SqlCommand("mostrar_patentes2")
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

    Public Function insertar(ByVal dts As vpatente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_patentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@patente", dts.gpatente)
            cmd.Parameters.AddWithValue("@marca", dts.gmarca)
            cmd.Parameters.AddWithValue("@idTransportista", dts.gidtransportista)
            cmd.Parameters.AddWithValue("@idTipoVehiculo", dts.gidtipovehiculo)
            cmd.Parameters.AddWithValue("@tara", dts.gtara)
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

    Public Function editar(ByVal dts As vpatente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_patentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idVehiculo", dts.gidvehiculo)
            cmd.Parameters.AddWithValue("@patente", dts.gpatente)
            cmd.Parameters.AddWithValue("@marca", dts.gmarca)
            cmd.Parameters.AddWithValue("@idTransportista", dts.gidtransportista)
            cmd.Parameters.AddWithValue("@idTipoVehiculo", dts.gidtipovehiculo)
            cmd.Parameters.AddWithValue("@tara", dts.gtara)
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

    Public Function eliminar(ByVal dts As vpatente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_patentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idVehiculo", SqlDbType.NVarChar, 50).Value = dts.gidvehiculo


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

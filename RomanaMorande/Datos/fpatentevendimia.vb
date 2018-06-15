Imports System.Data.SqlClient
Public Class fpatentevendimia
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_camionesvendimia")
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

    Public Function insertar(ByVal dts As vpatentevendimia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_patentesvendimia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@patente", dts.gpatente)
            cmd.Parameters.AddWithValue("@idTransportista", dts.gidtransportista)
            cmd.Parameters.AddWithValue("@idTipoVehiculo", dts.gidtipovehiculo)
            cmd.Parameters.AddWithValue("@tara", dts.gtara)
            cmd.Parameters.AddWithValue("@tipoenvase", dts.gtipoenvase)
            cmd.Parameters.AddWithValue("@cantenv", dts.gcantenv)
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

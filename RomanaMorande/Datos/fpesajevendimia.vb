Imports System.Data.SqlClient
Public Class fpesajevendimia
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function insertar(ByVal dts As vpesajevendimia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_pesajevendimia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpesajev", dts.gidpesajev)
            cmd.Parameters.AddWithValue("@aniovendimia", dts.ganiovendimia)
            cmd.Parameters.AddWithValue("@idsapv", dts.gidsapv)
            cmd.Parameters.AddWithValue("@idvehiculo", dts.gidvehiculo)
            'cmd.Parameters.AddWithValue("@fechacreacion", dts.gfechacreacion)
            'cmd.Parameters.AddWithValue("@fechapesajein", dts.gfechapesajein)
            'cmd.Parameters.AddWithValue("@fechapesajeout", dts.gfechapesajeout)
            cmd.Parameters.AddWithValue("@pesajetara", dts.gpesajetara)
            cmd.Parameters.AddWithValue("@pesajebruto", dts.gpesajebruto)
            cmd.Parameters.AddWithValue("@pesajeneto", dts.gpesajeneto)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@estadopesaje", dts.gestadopesaje)
            cmd.Parameters.AddWithValue("@visible", dts.gvisible)
            cmd.Parameters.AddWithValue("@numguia", dts.gnumguia)
            cmd.Parameters.AddWithValue("@idbodega", dts.gidbodega)
            cmd.Parameters.AddWithValue("@idenvase", dts.gidenvase)
            cmd.Parameters.AddWithValue("@cantenvin", dts.gcantenvin)
            cmd.Parameters.AddWithValue("@cantenvout", dts.gcantenvout)
            cmd.Parameters.AddWithValue("@diftaraenvases", dts.gdiftaraenvases)
            cmd.Parameters.AddWithValue("@tipocosecha", dts.gtipocosecha)
            cmd.Parameters.AddWithValue("@idcontrato", dts.gidcontrato)
            cmd.Parameters.AddWithValue("@idcontratovariedad", dts.gidcontratovariedad)
            cmd.Parameters.AddWithValue("@sector", dts.gsector)
            cmd.Parameters.AddWithValue("@nomsector", dts.gnomsector)
            cmd.Parameters.AddWithValue("@cuartel", dts.gcuartel)
            cmd.Parameters.AddWithValue("@nomcuartel", dts.gnomcuartel)
            cmd.Parameters.AddWithValue("@subcuartel", dts.gsubcuartel)
            cmd.Parameters.AddWithValue("@nomsubcuartel", dts.gnomsubcuartel)
            cmd.Parameters.AddWithValue("@idcalidad", dts.gidcalidad)
            cmd.Parameters.AddWithValue("@brix", dts.gbrix)
            cmd.Parameters.AddWithValue("@densidad", dts.gdensidad)
            cmd.Parameters.AddWithValue("@temp", dts.gtemp)
            cmd.Parameters.AddWithValue("@apb", dts.gapb)
            cmd.Parameters.AddWithValue("@porccastigo", dts.gporccastigo)
            cmd.Parameters.AddWithValue("@kiloscastigo", dts.gkiloscastigo)
            cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
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

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pesajesvendimia")
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

    Public Function editarIN(ByVal dts As vpesajevendimia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pesajevendimiaIN")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idpesaje", dts.gidpesajev)



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

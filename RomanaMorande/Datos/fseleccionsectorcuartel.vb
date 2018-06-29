Imports System.Data.SqlClient
Public Class fseleccionsectorcuartel
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_sectorcuartel")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@contrato", frmVendimiaPesajeAutomatico.txtnumcontrato.Text)
            cmd.Parameters.AddWithValue("@variedad", frmVendimiaPesajeAutomatico.txtcoduva.Text)
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

End Class

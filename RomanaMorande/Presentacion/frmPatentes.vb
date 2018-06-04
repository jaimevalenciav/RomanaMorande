Imports System.Data
Imports System.Data.SqlClient
Public Class frmPatentes
    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PesajeDataSet1.TipoVehiculos' Puede moverla o quitarla según sea necesario.
        Me.TipoVehiculosTableAdapter.Fill(Me.PesajeDataSet1.TipoVehiculos)
        'TODO: esta línea de código carga datos en la tabla 'PesajeDataSet1.Transportistas' Puede moverla o quitarla según sea necesario.
        Me.TransportistasTableAdapter.Fill(Me.PesajeDataSet1.Transportistas)
        'TODO: esta línea de código carga datos en la tabla 'PesajeDataSet1.Vehiculos' Puede moverla o quitarla según sea necesario.
        Me.VehiculosTableAdapter.Fill(Me.PesajeDataSet1.Vehiculos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As SqlConnection
        Dim misqlstring As SqlCommand
        Dim dr As SqlDataReader
        Dim dr1 As SqlDataReader
        Dim ra As Integer
        Dim dt As New DataTable
        Dim conexion As String = "Server=SQLSERVER02\BCI_ERP_C; Database=pesaje; user Id = sa; Password= sinpassword"
        conn = New SqlConnection("Server=SQLSERVER02\BCI_ERP_C; Database=pesaje; user Id = sa; Password= sinpassword")
        Dim tara As Integer = CInt(tara = txtTara.Text)



        tara = txtTara.Text



        If txtPatente.Text <> "" And txtMarca.Text <> "" And txtTara.Text <> "" Then
            MsgBox("Revise datos faltantes: Patente, Marca, Tara.", MessageBoxIcon.Warning)
            conn.Open()
            misqlstring = New SqlCommand("insert into Vehiculos([Patente],[Marca],[idTransportista],[idTipoVehiculo],[Tara]) values ('" & txtPatente.Text & "','" & txtMarca.Text & "',(select idtransportista from Transportistas where Nombre ='" & cmbTransportista.SelectedText & "'),'" & cmbVehiculo.SelectedText & "','" & tara & "')", conn)

            misqlstring.ExecuteNonQuery()

            MessageBox.Show("Nuevo registro insertado")
            txtPatente.Text = ""
            txtMarca.Text = ""
            txtTara.Text = ""
            conn.Close()
            Try

                Using adaptador As New SqlDataAdapter("Select * from Transportistas", conexion)
                    adaptador.Fill(dt)

                End Using
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MsgBox("Revise datos faltantes: Patente, Marca, Tara.", MessageBoxIcon.Warning)
        End If

    End Sub
End Class
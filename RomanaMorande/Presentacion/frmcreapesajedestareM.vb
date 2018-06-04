Public Class frmcreapesajedestareM
    Private dt As New DataTable
    Private Sub frmcreapesaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtidvehiculo.Text = ""
        txtpatente.Text = ""
        txtmarca.Text = ""
        txttransportista.Text = ""
        txttipovehiculo.Text = ""
        txttara.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRegistroPatentes.Show()
    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim dts As New vpesajedestareM
            Dim func As New fpesajedestareM


            dts.gidsap = 0
            dts.gidvehiculo = txtidvehiculo.Text
            'dts.gfechacreacion = 
            'dts.gfechapesajein = ""
            'dts.ghorapesajein = ""
            'dts.gfechapesajeout = ""
            'dts.ghorapesajeout = ""
            dts.gpesajein1 = 0
            dts.gpesajein2 = 0
            dts.gpesajein3 = 0
            dts.gpesajein4 = 0
            dts.gpesajeout1 = 0
            dts.gpesajeout2 = 0
            dts.gpesajeout3 = 0
            dts.gpesajeout4 = 0
            dts.gpesajetara = 0
            dts.gpesajebruto = 0
            dts.gpesajeneto = 0
            dts.gpesaje = 0 '0:Interno 1:Servicio
            dts.gtipopesaje = 1 '0:Automatico 1:Manual
            dts.gobservaciones = ""
            dts.gestadopesaje = 0 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
            dts.gvisible = 1 '0:NoVisible 1:Visible
            dts.gtaracont = 0
            dts.gvgm = 0



            If func.insertar(dts) Then
                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                mostrar()

            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrar()
                Me.Close()
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub mostrar()

        Try
            Dim func As New fpesajedestareM
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                frmpesajedestaremanual.DataListado.DataSource = dt


            Else
                frmpesajedestaremanual.DataListado.DataSource = Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim func As New fpesajedestareM
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                frmpesajedestaremanual.DataListado.DataSource = dt


            Else
                frmpesajedestaremanual.DataListado.DataSource = Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim func As New fpesajedestareM
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                frmpesajedestareautomatico.DataListado.DataSource = dt


            Else
                frmpesajedestareautomatico.DataListado.DataSource = Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnguardar.Visible = True




    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub
End Class
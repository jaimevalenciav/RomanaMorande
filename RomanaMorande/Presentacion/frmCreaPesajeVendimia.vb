Public Class frmCreaPesajeVendimia
    Private dt As New DataTable

    Private Sub frmCreaPesajeVendimia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtidvehiculo.Text = ""
        txtpatente.Text = ""
        txttipoenvase.Text = ""
        txttransportista.Text = ""
        txttipovehiculo.Text = ""
        txttara.Text = ""
        txtcanenvases.Text = ""
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPatenteVendimia.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim dts As New vpesajevendimia
            Dim func As New fpesajevendimia

            'dts.gidpesajev =
            'dts.ganiovendimia =
            dts.gidsapv = "0"
            dts.gidvehiculo = txtidvehiculo.Text
            'dts.gfechacreacion =
            'dts.gfechapesajein =
            'dts.gfechapesajeout =
            dts.gpesajetara = 0
            dts.gpesajebruto = 0
            dts.gpesajeneto = 0
            dts.gobservaciones = "Pesado por: " & frmPrincipal.lbluser.Text & ". "
            dts.gestadopesaje = 0 '0:SinPesaje 1:PesajeTara 2:PesajeBruto
            dts.gvisible = 1
            dts.gnumguia = 0
            dts.gidbodega = 0
            dts.gidenvase = 0
            dts.gcantenvin = txtcanenvases.Text
            dts.gcantenvout = 0
            dts.gdiftaraenvases = 0
            dts.gtipocosecha = ""
            dts.gidcontrato = 0
            dts.gidcontratovariedad = 1
            dts.gidcontrato = ""
            'dts.gsector = 0
            ' dts.gnomsector = "Sin Información"
            ' dts.gcuartel = "0"
            'dts.gnomcuartel = "Sin Información"
            'dts.gsubcuartel = "0"
            'dts.gnomsubcuartel = "Sin Información"
            'dts.gidcalidad = 0
            dts.gbrix = 0
            dts.gdensidad = 0
            dts.gtemp = 0
            dts.gapb = 0
            dts.gporccastigo = 0
            dts.gkiloscastigo = 0
            dts.ganulado = 0
            dts.gactivo = 1

            If func.insertar(dts) Then
                MessageBox.Show("Pesaje Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                mostrar()

            Else
                MessageBox.Show("Pesaje no fue Registrado, intente nuevamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub mostrar()

        Try
            Dim func As New fpesajevendimia
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                frmVendimiaPesajeAutomatico.DataListado.DataSource = dt


            Else
                frmVendimiaPesajeAutomatico.DataListado.DataSource = Nothing


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
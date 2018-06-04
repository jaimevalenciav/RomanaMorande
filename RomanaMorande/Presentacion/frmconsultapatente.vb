
Public Class frmconsultapatente
    Private dt As New DataTable

    Private Sub frmconsultapatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechainicio.Value = Date.Now.AddDays(-Now.Day + 1)
        fechatermino.Value = Date.Now.AddDays(-Now.Day + 1).AddMonths(1).AddDays(-1)
        mostrar2()
        txtpatente.Text = ""
        rbfechain.Checked = True
        buscarfechaIn()


    End Sub
    Private Sub mostrar2()

        Try
            Dim func As New fpesajedestareM
            dt = func.mostrar3
            If dt.Rows.Count <> 0 Then
                datalistado2.DataSource = dt
            Else
                datalistado2.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub pintanulos()
        datalistado2.EnableHeadersVisualStyles = False
        datalistado2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datalistado2.ColumnHeadersDefaultCellStyle.BackColor = Color.Peru
        datalistado2.DefaultCellStyle.SelectionBackColor = Color.DarkRed
        datalistado2.DefaultCellStyle.SelectionForeColor = Color.White
        For Each Row As DataGridViewRow In datalistado2.Rows

            If Row.Cells("Estado").Value = "NULO" Then
                Row.DefaultCellStyle.BackColor = Color.Bisque
            End If

        Next
    End Sub



    Private Sub datalistado2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado2.CellContentClick
        Try
            txtnumpesaje.Text = datalistado2.SelectedCells.Item(3).Value
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        frmreportecomprobante.txtidpesaje.Text = Me.txtnumpesaje.Text
        frmreportecomprobante.ShowDialog()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        txtpatente.Text = ""
        cmbtipopesaje.Text = "Todos"
        mostrar2()
        pintanulos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Excel (*.xls)|*.xls"
            If fichero.ShowDialog() = DialogResult.OK Then
                Dim aplicacion As Microsoft.Office.Interop.Excel.Application
                Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
                Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
                aplicacion = New Microsoft.Office.Interop.Excel.Application()
                libros_trabajo = aplicacion.Workbooks.Add()
                hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
                'Recorremos el DataGridView rellenando la hoja de trabajo
                Dim columnsCount As Integer = datalistado2.Columns.Count
                For i As Integer = 0 To datalistado2.Rows.Count - 2
                    For j As Integer = 0 To datalistado2.Columns.Count - 1
                        If i = 0 Then 'pintamos cabecera
                            hoja_trabajo.Cells(i + 1, j + 1) = datalistado2.Columns(j).HeaderText
                        Else 'pintamos datos
                            hoja_trabajo.Cells(i + 1, j + 1) = datalistado2.Rows(i).Cells(j).Value.ToString()
                        End If
                    Next
                Next
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
                libros_trabajo.Close(True)
                'aplicacion.Quit()

            End If
            MessageBox.Show("Archivo Exportado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnfiltrar_Click(sender As Object, e As EventArgs) Handles btnfiltrar.Click

    End Sub

    Private Sub btnbuscapatente_Click(sender As Object, e As EventArgs)
        frmRegistroPatentes.ShowDialog()
    End Sub

    Private Sub buscarpatente()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = "patente like '" & txtpatente.Text & "%'"

            datalistado2.DataSource = dv
            datalistado2.Update()
            pintanulos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buscarfechaIn()
        If fechatermino.Value < fechainicio.Value Then
            MessageBox.Show("Revise las fechas, la fecha HASTA no puede ser menor a la Fecha DESDE del filtro", "Sistema Romana", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim ds As New DataSet
                Dim fechadesde As DateTime = fechainicio.Value.ToShortDateString
                Dim fechahasta As DateTime = fechatermino.Value.AddDays(1).ToShortDateString 'se agrega 1 para filtrar menor al dia siguiente
                'MsgBox("Busca fechaIN:" + fechadesde)
                'MsgBox("Busca fechaIN:" + fechahasta)
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))

                If cmbtipopesaje.Text = "Todos" Then
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "'"
                ElseIf cmbtipopesaje.Text = "Normal" Then
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "' and TipoPesaje='Normal'"
                Else
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "' and TipoPesaje='Sin Destare'"
                End If


                datalistado2.DataSource = dv
                datalistado2.Update()
                pintanulos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub buscarfechaOut()
        If fechatermino.Value < fechainicio.Value Then
            MessageBox.Show("Revise las fechas, la fecha HASTA no puede ser menor a la Fecha DESDE del filtro", "Sistema Romana", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                Dim ds As New DataSet
                Dim fechadesde As DateTime = fechainicio.Value.ToShortDateString
                Dim fechahasta As DateTime = fechatermino.Value.AddDays(1).ToShortDateString 'se agrega 1 para filtrar menor al dia siguiente
                'MsgBox("Busca fechaOUT:" + fechadesde)
                'MsgBox("Busca fechaOUT:" + fechahasta)
                ds.Tables.Add(dt.Copy)
                Dim dv As New DataView(ds.Tables(0))
                If cmbtipopesaje.Text = "Todos" Then
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "'"
                ElseIf cmbtipopesaje.Text = "Normal" Then
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "' and TipoPesaje='Normal'"
                Else
                    dv.RowFilter = "FechaIN >= '" & fechadesde & "' AND  FechaIN <= '" & fechahasta & "' and TipoPesaje='Sin Destare'"
                End If

                datalistado2.DataSource = dv
                datalistado2.Update()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub txtpatente_TextChanged(sender As Object, e As EventArgs) Handles txtpatente.TextChanged
        buscarpatente()
    End Sub


    Private Sub fechainicio_ValueChanged(sender As Object, e As EventArgs) Handles fechainicio.ValueChanged
        If fechainicio.Value > fechatermino.Value Then
            MessageBox.Show("Revise las fechas, la fecha HASTA no puede ser menor a la Fecha DESDE del filtro", "Sistema Romana", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub fechatermino_ValueChanged(sender As Object, e As EventArgs) Handles fechatermino.ValueChanged
        If fechatermino.Value < fechainicio.Value Then
            MessageBox.Show("Revise las fechas, la fecha HASTA no puede ser menor a la Fecha DESDE del filtro", "Sistema Romana", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        End If
    End Sub

    Private Sub btnactualizafiltro_Click(sender As Object, e As EventArgs) Handles btnactualizafiltro.Click
        If rbfechain.Checked = True Then
            buscarfechaIn()
            pintanulos()
        ElseIf rbfechaout.Checked = True Then
            buscarfechaOut()
            pintanulos()
        End If
    End Sub


End Class
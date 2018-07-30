<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmreportecomprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportecomprobante))
        Me.mostrar_reportepesajesvendimiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportRecepUva = New RomanaMorande.ReportRecepUva()
        Me.reporte_pesajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pesajeDataSet8 = New RomanaMorande.pesajeDataSet8()
        Me.txtidpesaje = New System.Windows.Forms.TextBox()
        Me.Reporte_pesajeTableAdapter1 = New RomanaMorande.pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.reporte_pesajeTableAdapter = New RomanaMorande.pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter()
        Me.pesajebckDataSet = New RomanaMorande.pesajebckDataSet()
        Me.mostrar_reportepesajesvendimiaTableAdapter = New RomanaMorande.ReportRecepUvaTableAdapters.mostrar_reportepesajesvendimiaTableAdapter()
        CType(Me.mostrar_reportepesajesvendimiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportRecepUva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporte_pesajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajeDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajebckDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_reportepesajesvendimiaBindingSource
        '
        Me.mostrar_reportepesajesvendimiaBindingSource.DataMember = "mostrar_reportepesajesvendimia"
        Me.mostrar_reportepesajesvendimiaBindingSource.DataSource = Me.ReportRecepUva
        '
        'ReportRecepUva
        '
        Me.ReportRecepUva.DataSetName = "ReportRecepUva"
        Me.ReportRecepUva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_pesajeBindingSource
        '
        Me.reporte_pesajeBindingSource.DataMember = "reporte_pesaje"
        Me.reporte_pesajeBindingSource.DataSource = Me.pesajeDataSet8
        '
        'pesajeDataSet8
        '
        Me.pesajeDataSet8.DataSetName = "pesajebckDataSet"
        Me.pesajeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtidpesaje
        '
        Me.txtidpesaje.Location = New System.Drawing.Point(368, 98)
        Me.txtidpesaje.Name = "txtidpesaje"
        Me.txtidpesaje.Size = New System.Drawing.Size(93, 20)
        Me.txtidpesaje.TabIndex = 1
        Me.txtidpesaje.Visible = False
        '
        'Reporte_pesajeTableAdapter1
        '
        Me.Reporte_pesajeTableAdapter1.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RomanaMorande.VoucherPesajeNuevo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(907, 476)
        Me.ReportViewer1.TabIndex = 2
        '
        'reporte_pesajeTableAdapter
        '
        Me.reporte_pesajeTableAdapter.ClearBeforeFill = True
        '
        'pesajebckDataSet
        '
        Me.pesajebckDataSet.DataSetName = "pesajebckDataSet"
        Me.pesajebckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_reportepesajesvendimiaTableAdapter
        '
        Me.mostrar_reportepesajesvendimiaTableAdapter.ClearBeforeFill = True
        '
        'frmreportecomprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 476)
        Me.Controls.Add(Me.txtidpesaje)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreportecomprobante"
        Me.Text = "Comprobante de Pesaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mostrar_reportepesajesvendimiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportRecepUva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporte_pesajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajeDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajebckDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pesajeDataSet2 As pesajeDataSet8
    Friend WithEvents txtidpesaje As TextBox
    Friend WithEvents Reporte_pesajeTableAdapter1 As pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents reporte_pesajeBindingSource As BindingSource
    Friend WithEvents pesajeDataSet8 As pesajeDataSet8
    Friend WithEvents reporte_pesajeTableAdapter As pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter
    Friend WithEvents pesajebckDataSet As pesajebckDataSet
    Friend WithEvents mostrar_reportepesajesvendimiaBindingSource As BindingSource
    Friend WithEvents ReportRecepUva As ReportRecepUva
    Friend WithEvents mostrar_reportepesajesvendimiaTableAdapter As ReportRecepUvaTableAdapters.mostrar_reportepesajesvendimiaTableAdapter
End Class

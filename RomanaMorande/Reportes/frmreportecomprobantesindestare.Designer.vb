<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportecomprobantesindestare
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportecomprobantesindestare))
        Me.ReportepesajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesajeDataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesajeDataSet8 = New RomanaMorande.pesajeDataSet8()
        Me.reporte_pesajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pesajeDataSet6 = New RomanaMorande.pesajeDataSet8()
        Me.reporte_pesajeTableAdapter = New RomanaMorande.pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter()
        Me.txtidpesaje = New System.Windows.Forms.TextBox()
        Me.pesajeDataSet7 = New RomanaMorande.pesajeDataSet7()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pesajebckDataSet = New RomanaMorande.pesajebckDataSet()
        CType(Me.ReportepesajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporte_pesajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajeDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajeDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesajebckDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportepesajeBindingSource
        '
        Me.ReportepesajeBindingSource.DataMember = "reporte_pesaje"
        Me.ReportepesajeBindingSource.DataSource = Me.PesajeDataSet8BindingSource
        '
        'PesajeDataSet8BindingSource
        '
        Me.PesajeDataSet8BindingSource.DataSource = Me.PesajeDataSet8
        Me.PesajeDataSet8BindingSource.Position = 0
        '
        'PesajeDataSet8
        '
        Me.PesajeDataSet8.DataSetName = "pesajeDataSet8"
        Me.PesajeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_pesajeBindingSource
        '
        Me.reporte_pesajeBindingSource.DataMember = "reporte_pesaje"
        Me.reporte_pesajeBindingSource.DataSource = Me.pesajeDataSet6
        '
        'pesajeDataSet6
        '
        Me.pesajeDataSet6.DataSetName = "pesajeDataSet6"
        Me.pesajeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reporte_pesajeTableAdapter
        '
        Me.reporte_pesajeTableAdapter.ClearBeforeFill = True
        '
        'txtidpesaje
        '
        Me.txtidpesaje.Location = New System.Drawing.Point(377, 222)
        Me.txtidpesaje.Name = "txtidpesaje"
        Me.txtidpesaje.Size = New System.Drawing.Size(93, 20)
        Me.txtidpesaje.TabIndex = 2
        Me.txtidpesaje.Visible = False
        '
        'pesajeDataSet7
        '
        Me.pesajeDataSet7.DataSetName = "pesajeDataSet7"
        Me.pesajeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Reporte"
        ReportDataSource1.Value = Me.reporte_pesajeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RomanaMorande.VoucherPesajeNuevo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(847, 464)
        Me.ReportViewer1.TabIndex = 3
        '
        'pesajebckDataSet
        '
        Me.pesajebckDataSet.DataSetName = "pesajebckDataSet"
        Me.pesajebckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmreportecomprobantesindestare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 464)
        Me.Controls.Add(Me.txtidpesaje)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreportecomprobantesindestare"
        Me.Text = "Comprobante de Pesaje Sin Destare"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ReportepesajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporte_pesajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajeDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajeDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesajebckDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reporte_pesajeBindingSource As BindingSource
    Friend WithEvents pesajeDataSet6 As pesajeDataSet8
    Friend WithEvents reporte_pesajeTableAdapter As pesajeDataSet8TableAdapters.reporte_pesajeTableAdapter
    Friend WithEvents txtidpesaje As TextBox
    Friend WithEvents pesajeDataSet7 As pesajeDataSet7
    Friend WithEvents PesajeDataSet8BindingSource As BindingSource
    Friend WithEvents PesajeDataSet8 As pesajeDataSet8
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportepesajeBindingSource As BindingSource
    Friend WithEvents pesajebckDataSet As pesajebckDataSet
End Class

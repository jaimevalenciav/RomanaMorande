<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteRecepUva
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteRecepUva))
        Me.txtidpesajev = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportePesajeUva1 = New RomanaMorande.ReportePesajeUva1()
        Me.mostrar_reportepesajesvendimiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_reportepesajesvendimiaTableAdapter = New RomanaMorande.ReportePesajeUva1TableAdapters.mostrar_reportepesajesvendimiaTableAdapter()
        CType(Me.ReportePesajeUva1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_reportepesajesvendimiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidpesajev
        '
        Me.txtidpesajev.Location = New System.Drawing.Point(368, 98)
        Me.txtidpesajev.Name = "txtidpesajev"
        Me.txtidpesajev.Size = New System.Drawing.Size(93, 20)
        Me.txtidpesajev.TabIndex = 3
        Me.txtidpesajev.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReportePesajeVendimia"
        ReportDataSource1.Value = Me.mostrar_reportepesajesvendimiaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RomanaMorande.VoucherPesajeUva.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(701, 319)
        Me.ReportViewer1.TabIndex = 4
        '
        'ReportePesajeUva1
        '
        Me.ReportePesajeUva1.DataSetName = "ReportePesajeUva1"
        Me.ReportePesajeUva1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_reportepesajesvendimiaBindingSource
        '
        Me.mostrar_reportepesajesvendimiaBindingSource.DataMember = "mostrar_reportepesajesvendimia"
        Me.mostrar_reportepesajesvendimiaBindingSource.DataSource = Me.ReportePesajeUva1
        '
        'mostrar_reportepesajesvendimiaTableAdapter
        '
        Me.mostrar_reportepesajesvendimiaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteRecepUva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 319)
        Me.Controls.Add(Me.txtidpesajev)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteRecepUva"
        Me.Text = "Reporte Recepción Uva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ReportePesajeUva1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_reportepesajesvendimiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidpesajev As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_reportepesajesvendimiaBindingSource As BindingSource
    Friend WithEvents ReportePesajeUva1 As ReportePesajeUva1
    Friend WithEvents mostrar_reportepesajesvendimiaTableAdapter As ReportePesajeUva1TableAdapters.mostrar_reportepesajesvendimiaTableAdapter
End Class

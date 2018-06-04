<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatentes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTransportista = New System.Windows.Forms.ComboBox()
        Me.TransportistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesajeDataSet1 = New RomanaMorande.pesajeDataSet1()
        Me.cmbVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTara = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculosTableAdapter = New RomanaMorande.pesajeDataSet1TableAdapters.VehiculosTableAdapter()
        Me.TransportistasTableAdapter = New RomanaMorande.pesajeDataSet1TableAdapters.TransportistasTableAdapter()
        Me.TipoVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoVehiculosTableAdapter = New RomanaMorande.pesajeDataSet1TableAdapters.TipoVehiculosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TransportistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 417)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vehículos"
        '
        'dgv
        '
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 25)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 50
        Me.dgv.Size = New System.Drawing.Size(404, 380)
        Me.dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patente"
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(17, 51)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(102, 20)
        Me.txtPatente.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTransportista)
        Me.GroupBox2.Controls.Add(Me.cmbVehiculo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTara)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPatente)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(456, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 350)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Transportista"
        '
        'cmbTransportista
        '
        Me.cmbTransportista.DataSource = Me.TransportistasBindingSource
        Me.cmbTransportista.DisplayMember = "Nombre"
        Me.cmbTransportista.FormattingEnabled = True
        Me.cmbTransportista.Location = New System.Drawing.Point(17, 155)
        Me.cmbTransportista.Name = "cmbTransportista"
        Me.cmbTransportista.Size = New System.Drawing.Size(212, 21)
        Me.cmbTransportista.TabIndex = 12
        Me.cmbTransportista.ValueMember = "Nombre"
        '
        'TransportistasBindingSource
        '
        Me.TransportistasBindingSource.DataMember = "Transportistas"
        Me.TransportistasBindingSource.DataSource = Me.PesajeDataSet1
        '
        'PesajeDataSet1
        '
        Me.PesajeDataSet1.DataSetName = "pesajeDataSet1"
        Me.PesajeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.DataSource = Me.TipoVehiculosBindingSource
        Me.cmbVehiculo.DisplayMember = "NombreVehiculo"
        Me.cmbVehiculo.FormattingEnabled = True
        Me.cmbVehiculo.Location = New System.Drawing.Point(17, 207)
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(212, 21)
        Me.cmbVehiculo.TabIndex = 11
        Me.cmbVehiculo.ValueMember = "idTipoVehiculo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Vehículo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tara"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Transportista"
        '
        'txtTara
        '
        Me.txtTara.Location = New System.Drawing.Point(17, 254)
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(102, 20)
        Me.txtTara.TabIndex = 6
        Me.txtTara.Text = "0"
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(17, 99)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(212, 20)
        Me.txtMarca.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Marca Vehículo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Insertar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(476, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 51)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VehiculosBindingSource
        '
        Me.VehiculosBindingSource.DataMember = "Vehiculos"
        Me.VehiculosBindingSource.DataSource = Me.PesajeDataSet1
        '
        'VehiculosTableAdapter
        '
        Me.VehiculosTableAdapter.ClearBeforeFill = True
        '
        'TransportistasTableAdapter
        '
        Me.TransportistasTableAdapter.ClearBeforeFill = True
        '
        'TipoVehiculosBindingSource
        '
        Me.TipoVehiculosBindingSource.DataMember = "TipoVehiculos"
        Me.TipoVehiculosBindingSource.DataSource = Me.PesajeDataSet1
        '
        'TipoVehiculosTableAdapter
        '
        Me.TipoVehiculosTableAdapter.ClearBeforeFill = True
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVehiculos"
        Me.Text = "Vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TransportistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatente As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PesajeDataSet1 As pesajeDataSet1
    Friend WithEvents VehiculosBindingSource As BindingSource
    Friend WithEvents VehiculosTableAdapter As pesajeDataSet1TableAdapters.VehiculosTableAdapter
    Friend WithEvents cmbVehiculo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTara As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTransportista As ComboBox
    Friend WithEvents TransportistasBindingSource As BindingSource
    Friend WithEvents TransportistasTableAdapter As pesajeDataSet1TableAdapters.TransportistasTableAdapter
    Friend WithEvents TipoVehiculosBindingSource As BindingSource
    Friend WithEvents TipoVehiculosTableAdapter As pesajeDataSet1TableAdapters.TipoVehiculosTableAdapter
End Class

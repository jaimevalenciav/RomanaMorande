<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransportistas))
        Me.TransportistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesajeDataSet1 = New RomanaMorande.pesajeDataSet1()
        Me.PesajeDataSet = New RomanaMorande.pesajeDataSet()
        Me.PesajeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportistasTableAdapter = New RomanaMorande.pesajeDataSet1TableAdapters.TransportistasTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrut = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdTrasportista = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreTransportista = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEliminar = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtflag = New System.Windows.Forms.TextBox()
        CType(Me.TransportistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesajeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PesajeDataSet
        '
        Me.PesajeDataSet.DataSetName = "pesajeDataSet"
        Me.PesajeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PesajeDataSetBindingSource
        '
        Me.PesajeDataSetBindingSource.DataSource = Me.PesajeDataSet
        Me.PesajeDataSetBindingSource.Position = 0
        '
        'TransportistasTableAdapter
        '
        Me.TransportistasTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(462, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtdv)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtrut)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtIdTrasportista)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNombreTransportista)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Location = New System.Drawing.Point(462, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 296)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Transportista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "-"
        '
        'txtdv
        '
        Me.txtdv.Enabled = False
        Me.txtdv.Location = New System.Drawing.Point(119, 107)
        Me.txtdv.Name = "txtdv"
        Me.txtdv.Size = New System.Drawing.Size(24, 20)
        Me.txtdv.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "RUT Transportista (Sin dv, ni puntos ni guión)"
        '
        'txtrut
        '
        Me.txtrut.Location = New System.Drawing.Point(20, 107)
        Me.txtrut.Name = "txtrut"
        Me.txtrut.Size = New System.Drawing.Size(86, 20)
        Me.txtrut.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(29, 194)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(85, 75)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID Transportista"
        '
        'txtIdTrasportista
        '
        Me.txtIdTrasportista.Enabled = False
        Me.txtIdTrasportista.Location = New System.Drawing.Point(20, 62)
        Me.txtIdTrasportista.Name = "txtIdTrasportista"
        Me.txtIdTrasportista.Size = New System.Drawing.Size(86, 20)
        Me.txtIdTrasportista.TabIndex = 6
        '
        'btnguardar
        '
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(120, 194)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(85, 75)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre Transportista"
        '
        'txtNombreTransportista
        '
        Me.txtNombreTransportista.Location = New System.Drawing.Point(20, 153)
        Me.txtNombreTransportista.Name = "txtNombreTransportista"
        Me.txtNombreTransportista.Size = New System.Drawing.Size(254, 20)
        Me.txtNombreTransportista.TabIndex = 2
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(211, 194)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 75)
        Me.btnEditar.TabIndex = 0
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.inexistente)
        Me.GroupBox1.Controls.Add(Me.DataListado)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 417)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Trasportistas"
        '
        'cbEliminar
        '
        Me.cbEliminar.AutoSize = True
        Me.cbEliminar.Location = New System.Drawing.Point(13, 23)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbEliminar.TabIndex = 6
        Me.cbEliminar.Text = "Eliminar"
        Me.cbEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(12, 375)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 36)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(188, 195)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(69, 13)
        Me.inexistente.TabIndex = 1
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Sin Registros"
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataListado.Location = New System.Drawing.Point(12, 46)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersVisible = False
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(412, 323)
        Me.DataListado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(729, 335)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(35, 20)
        Me.txtflag.TabIndex = 10
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'frmTransportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 457)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransportistas"
        Me.Text = "Transportistas"
        CType(Me.TransportistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesajeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PesajeDataSet As pesajeDataSet
    Friend WithEvents PesajeDataSetBindingSource As BindingSource
    Friend WithEvents PesajeDataSet1 As pesajeDataSet1
    Friend WithEvents TransportistasBindingSource As BindingSource
    Friend WithEvents TransportistasTableAdapter As pesajeDataSet1TableAdapters.TransportistasTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdTrasportista As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreTransportista As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEliminar As CheckBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtflag As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrut As TextBox
    Friend WithEvents txtdv As TextBox
    Friend WithEvents Label4 As Label
End Class

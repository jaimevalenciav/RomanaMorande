﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatenteVendimia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatenteVendimia))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnombretipoenvase = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtidtipoenvase = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcantenvase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTara = New System.Windows.Forms.TextBox()
        Me.btnBuscarTipoVehiculo = New System.Windows.Forms.Button()
        Me.txtNombreTipoVehiculo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdTipoVehiculo = New System.Windows.Forms.TextBox()
        Me.btnBuscarTransportista = New System.Windows.Forms.Button()
        Me.txtNombreTrasportista = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdTransportista = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidvehiculo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtbuscapatente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtnombretipoenvase)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtidtipoenvase)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtcantenvase)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTara)
        Me.GroupBox2.Controls.Add(Me.btnBuscarTipoVehiculo)
        Me.GroupBox2.Controls.Add(Me.txtNombreTipoVehiculo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtIdTipoVehiculo)
        Me.GroupBox2.Controls.Add(Me.btnBuscarTransportista)
        Me.GroupBox2.Controls.Add(Me.txtNombreTrasportista)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtIdTransportista)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtidvehiculo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtpatente)
        Me.GroupBox2.Location = New System.Drawing.Point(802, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 360)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Patente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 20)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnombretipoenvase
        '
        Me.txtnombretipoenvase.Enabled = False
        Me.txtnombretipoenvase.Location = New System.Drawing.Point(68, 191)
        Me.txtnombretipoenvase.Name = "txtnombretipoenvase"
        Me.txtnombretipoenvase.Size = New System.Drawing.Size(160, 20)
        Me.txtnombretipoenvase.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Tipo Envase"
        '
        'txtidtipoenvase
        '
        Me.txtidtipoenvase.Enabled = False
        Me.txtidtipoenvase.Location = New System.Drawing.Point(9, 191)
        Me.txtidtipoenvase.Name = "txtidtipoenvase"
        Me.txtidtipoenvase.Size = New System.Drawing.Size(53, 20)
        Me.txtidtipoenvase.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Cant. Env."
        '
        'txtcantenvase
        '
        Me.txtcantenvase.Location = New System.Drawing.Point(68, 217)
        Me.txtcantenvase.Name = "txtcantenvase"
        Me.txtcantenvase.Size = New System.Drawing.Size(58, 20)
        Me.txtcantenvase.TabIndex = 24
        Me.txtcantenvase.Text = "0"
        Me.txtcantenvase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tara"
        '
        'txtTara
        '
        Me.txtTara.Location = New System.Drawing.Point(173, 217)
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(86, 20)
        Me.txtTara.TabIndex = 6
        Me.txtTara.Text = "0"
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBuscarTipoVehiculo
        '
        Me.btnBuscarTipoVehiculo.Location = New System.Drawing.Point(229, 152)
        Me.btnBuscarTipoVehiculo.Name = "btnBuscarTipoVehiculo"
        Me.btnBuscarTipoVehiculo.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscarTipoVehiculo.TabIndex = 5
        Me.btnBuscarTipoVehiculo.Text = "..."
        Me.btnBuscarTipoVehiculo.UseVisualStyleBackColor = True
        '
        'txtNombreTipoVehiculo
        '
        Me.txtNombreTipoVehiculo.Enabled = False
        Me.txtNombreTipoVehiculo.Location = New System.Drawing.Point(68, 152)
        Me.txtNombreTipoVehiculo.Name = "txtNombreTipoVehiculo"
        Me.txtNombreTipoVehiculo.Size = New System.Drawing.Size(160, 20)
        Me.txtNombreTipoVehiculo.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tipo Vehículo"
        '
        'txtIdTipoVehiculo
        '
        Me.txtIdTipoVehiculo.Enabled = False
        Me.txtIdTipoVehiculo.Location = New System.Drawing.Point(9, 152)
        Me.txtIdTipoVehiculo.Name = "txtIdTipoVehiculo"
        Me.txtIdTipoVehiculo.Size = New System.Drawing.Size(53, 20)
        Me.txtIdTipoVehiculo.TabIndex = 18
        '
        'btnBuscarTransportista
        '
        Me.btnBuscarTransportista.Location = New System.Drawing.Point(229, 113)
        Me.btnBuscarTransportista.Name = "btnBuscarTransportista"
        Me.btnBuscarTransportista.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscarTransportista.TabIndex = 4
        Me.btnBuscarTransportista.Text = "..."
        Me.btnBuscarTransportista.UseVisualStyleBackColor = True
        '
        'txtNombreTrasportista
        '
        Me.txtNombreTrasportista.Enabled = False
        Me.txtNombreTrasportista.Location = New System.Drawing.Point(68, 113)
        Me.txtNombreTrasportista.Name = "txtNombreTrasportista"
        Me.txtNombreTrasportista.Size = New System.Drawing.Size(160, 20)
        Me.txtNombreTrasportista.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Transportista"
        '
        'txtIdTransportista
        '
        Me.txtIdTransportista.Enabled = False
        Me.txtIdTransportista.Location = New System.Drawing.Point(9, 113)
        Me.txtIdTransportista.Name = "txtIdTransportista"
        Me.txtIdTransportista.Size = New System.Drawing.Size(53, 20)
        Me.txtIdTransportista.TabIndex = 14
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(29, 279)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(85, 75)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(120, 279)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(85, 75)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(211, 279)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 75)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Id Patente"
        '
        'txtidvehiculo
        '
        Me.txtidvehiculo.Enabled = False
        Me.txtidvehiculo.Location = New System.Drawing.Point(9, 32)
        Me.txtidvehiculo.Name = "txtidvehiculo"
        Me.txtidvehiculo.Size = New System.Drawing.Size(86, 20)
        Me.txtidvehiculo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patente  (AABB99)"
        '
        'txtpatente
        '
        Me.txtpatente.Location = New System.Drawing.Point(9, 71)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(254, 20)
        Me.txtpatente.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(802, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 51)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(12, 46)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersVisible = False
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(766, 323)
        Me.DataListado.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Buscar Patente"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(12, 375)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 36)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtbuscapatente
        '
        Me.txtbuscapatente.Location = New System.Drawing.Point(214, 19)
        Me.txtbuscapatente.Name = "txtbuscapatente"
        Me.txtbuscapatente.Size = New System.Drawing.Size(86, 20)
        Me.txtbuscapatente.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscapatente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.DataListado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 417)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Patentes"
        '
        'frmPatenteVendimia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 439)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPatenteVendimia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patente Camión Vendimia"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtnombretipoenvase As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtidtipoenvase As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcantenvase As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTara As TextBox
    Friend WithEvents btnBuscarTipoVehiculo As Button
    Friend WithEvents txtNombreTipoVehiculo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdTipoVehiculo As TextBox
    Friend WithEvents btnBuscarTransportista As Button
    Friend WithEvents txtNombreTrasportista As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdTransportista As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidvehiculo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpatente As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscapatente As TextBox
End Class
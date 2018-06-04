<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpesajesindestareautomatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpesajesindestareautomatico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtnomtipo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnomtrans = New System.Windows.Forms.TextBox()
        Me.txtidtransportista = New System.Windows.Forms.TextBox()
        Me.txtpesaje = New System.Windows.Forms.TextBox()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarpesaje = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnanula = New System.Windows.Forms.Button()
        Me.txtep = New System.Windows.Forms.TextBox()
        Me.txtguiadespacho = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btncapturapeso = New System.Windows.Forms.Button()
        Me.txtnombretipovehiculo = New System.Windows.Forms.TextBox()
        Me.txtidtipovehiculo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdocsap = New System.Windows.Forms.TextBox()
        Me.txtnumpesaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datalistado2 = New System.Windows.Forms.DataGridView()
        Me.btnnuevopesaje = New System.Windows.Forms.Button()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Observaciones"
        '
        'txttipo
        '
        Me.txttipo.Enabled = False
        Me.txttipo.Location = New System.Drawing.Point(102, 269)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(29, 20)
        Me.txttipo.TabIndex = 39
        '
        'txtnomtipo
        '
        Me.txtnomtipo.Enabled = False
        Me.txtnomtipo.Location = New System.Drawing.Point(137, 269)
        Me.txtnomtipo.Name = "txtnomtipo"
        Me.txtnomtipo.Size = New System.Drawing.Size(137, 20)
        Me.txtnomtipo.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Pesaje"
        '
        'txttara
        '
        Me.txttara.Enabled = False
        Me.txttara.Location = New System.Drawing.Point(102, 236)
        Me.txttara.Name = "txttara"
        Me.txttara.Size = New System.Drawing.Size(137, 20)
        Me.txttara.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tara Registrada"
        '
        'txtnomtrans
        '
        Me.txtnomtrans.Enabled = False
        Me.txtnomtrans.Location = New System.Drawing.Point(137, 206)
        Me.txtnomtrans.Name = "txtnomtrans"
        Me.txtnomtrans.Size = New System.Drawing.Size(217, 20)
        Me.txtnomtrans.TabIndex = 34
        '
        'txtidtransportista
        '
        Me.txtidtransportista.Enabled = False
        Me.txtidtransportista.Location = New System.Drawing.Point(102, 206)
        Me.txtidtransportista.Name = "txtidtransportista"
        Me.txtidtransportista.Size = New System.Drawing.Size(29, 20)
        Me.txtidtransportista.TabIndex = 33
        '
        'txtpesaje
        '
        Me.txtpesaje.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpesaje.Enabled = False
        Me.txtpesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesaje.ForeColor = System.Drawing.SystemColors.Info
        Me.txtpesaje.Location = New System.Drawing.Point(10, 388)
        Me.txtpesaje.Name = "txtpesaje"
        Me.txtpesaje.Size = New System.Drawing.Size(369, 80)
        Me.txtpesaje.TabIndex = 34
        Me.txtpesaje.Text = "0"
        Me.txtpesaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(102, 299)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(395, 59)
        Me.txtobservaciones.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Transportista"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(155, 492)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 77)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarpesaje
        '
        Me.btnGuardarpesaje.Image = CType(resources.GetObject("btnGuardarpesaje.Image"), System.Drawing.Image)
        Me.btnGuardarpesaje.Location = New System.Drawing.Point(48, 492)
        Me.btnGuardarpesaje.Name = "btnGuardarpesaje"
        Me.btnGuardarpesaje.Size = New System.Drawing.Size(101, 77)
        Me.btnGuardarpesaje.TabIndex = 7
        Me.btnGuardarpesaje.Text = "Guardar Pesaje"
        Me.btnGuardarpesaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarpesaje.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(170, 361)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(193, 24)
        Me.lbltitulo.TabIndex = 30
        Me.lbltitulo.Text = "PESO AUTOMATICO"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(262, 492)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 77)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnanula)
        Me.GroupBox3.Controls.Add(Me.txtep)
        Me.GroupBox3.Controls.Add(Me.txtguiadespacho)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btncapturapeso)
        Me.GroupBox3.Controls.Add(Me.txtpesaje)
        Me.GroupBox3.Controls.Add(Me.txtobservaciones)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txttipo)
        Me.GroupBox3.Controls.Add(Me.txtnomtipo)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txttara)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtnomtrans)
        Me.GroupBox3.Controls.Add(Me.txtidtransportista)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtnombretipovehiculo)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnGuardarpesaje)
        Me.GroupBox3.Controls.Add(Me.lbltitulo)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.txtidtipovehiculo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtmarca)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtpatente)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtdocsap)
        Me.GroupBox3.Controls.Add(Me.txtnumpesaje)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblhora)
        Me.GroupBox3.Controls.Add(Me.lblfecha)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.fecha)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(521, 575)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesaje"
        '
        'btnanula
        '
        Me.btnanula.BackColor = System.Drawing.Color.Red
        Me.btnanula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnanula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnanula.Image = CType(resources.GetObject("btnanula.Image"), System.Drawing.Image)
        Me.btnanula.Location = New System.Drawing.Point(369, 492)
        Me.btnanula.Name = "btnanula"
        Me.btnanula.Size = New System.Drawing.Size(101, 77)
        Me.btnanula.TabIndex = 10
        Me.btnanula.Text = "Anular Pesaje"
        Me.btnanula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnanula.UseVisualStyleBackColor = False
        Me.btnanula.Visible = False
        '
        'txtep
        '
        Me.txtep.Location = New System.Drawing.Point(401, 233)
        Me.txtep.Name = "txtep"
        Me.txtep.Size = New System.Drawing.Size(38, 20)
        Me.txtep.TabIndex = 52
        Me.txtep.Visible = False
        '
        'txtguiadespacho
        '
        Me.txtguiadespacho.Location = New System.Drawing.Point(360, 173)
        Me.txtguiadespacho.Name = "txtguiadespacho"
        Me.txtguiadespacho.Size = New System.Drawing.Size(123, 20)
        Me.txtguiadespacho.TabIndex = 4
        Me.txtguiadespacho.Text = "0"
        Me.txtguiadespacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(245, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "N° Guía Despacho"
        '
        'btncapturapeso
        '
        Me.btncapturapeso.Image = CType(resources.GetObject("btncapturapeso.Image"), System.Drawing.Image)
        Me.btncapturapeso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncapturapeso.Location = New System.Drawing.Point(385, 388)
        Me.btncapturapeso.Name = "btncapturapeso"
        Me.btncapturapeso.Size = New System.Drawing.Size(130, 80)
        Me.btncapturapeso.TabIndex = 6
        Me.btncapturapeso.Text = "Capturar Pesaje"
        Me.btncapturapeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapturapeso.UseVisualStyleBackColor = True
        Me.btncapturapeso.Visible = False
        '
        'txtnombretipovehiculo
        '
        Me.txtnombretipovehiculo.Enabled = False
        Me.txtnombretipovehiculo.Location = New System.Drawing.Point(360, 143)
        Me.txtnombretipovehiculo.Name = "txtnombretipovehiculo"
        Me.txtnombretipovehiculo.Size = New System.Drawing.Size(123, 20)
        Me.txtnombretipovehiculo.TabIndex = 31
        '
        'txtidtipovehiculo
        '
        Me.txtidtipovehiculo.Enabled = False
        Me.txtidtipovehiculo.Location = New System.Drawing.Point(325, 143)
        Me.txtidtipovehiculo.Name = "txtidtipovehiculo"
        Me.txtidtipovehiculo.Size = New System.Drawing.Size(29, 20)
        Me.txtidtipovehiculo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Tipo Vehículo"
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Location = New System.Drawing.Point(102, 143)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(137, 20)
        Me.txtmarca.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Marca"
        '
        'txtpatente
        '
        Me.txtpatente.Enabled = False
        Me.txtpatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatente.Location = New System.Drawing.Point(347, 78)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(136, 38)
        Me.txtpatente.TabIndex = 20
        Me.txtpatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Patente"
        '
        'txtdocsap
        '
        Me.txtdocsap.Location = New System.Drawing.Point(102, 173)
        Me.txtdocsap.Name = "txtdocsap"
        Me.txtdocsap.Size = New System.Drawing.Size(137, 20)
        Me.txtdocsap.TabIndex = 3
        Me.txtdocsap.Text = "0"
        '
        'txtnumpesaje
        '
        Me.txtnumpesaje.Enabled = False
        Me.txtnumpesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumpesaje.Location = New System.Drawing.Point(102, 78)
        Me.txtnumpesaje.Name = "txtnumpesaje"
        Me.txtnumpesaje.Size = New System.Drawing.Size(137, 38)
        Me.txtnumpesaje.TabIndex = 17
        Me.txtnumpesaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Doc. SAP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "N° Pesaje"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblhora.Location = New System.Drawing.Point(340, 22)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(91, 37)
        Me.lblhora.TabIndex = 12
        Me.lblhora.Text = "Hora"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblfecha.Location = New System.Drawing.Point(95, 22)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(111, 37)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(302, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hora"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fecha.Location = New System.Drawing.Point(29, 37)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(40, 13)
        Me.fecha.TabIndex = 9
        Me.fecha.Text = "Fecha:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datalistado2)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 315)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesajes Destarados"
        '
        'datalistado2
        '
        Me.datalistado2.AllowUserToAddRows = False
        Me.datalistado2.AllowUserToDeleteRows = False
        Me.datalistado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado2.Location = New System.Drawing.Point(12, 29)
        Me.datalistado2.Name = "datalistado2"
        Me.datalistado2.ReadOnly = True
        Me.datalistado2.RowHeadersVisible = False
        Me.datalistado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado2.Size = New System.Drawing.Size(665, 280)
        Me.datalistado2.TabIndex = 12
        '
        'btnnuevopesaje
        '
        Me.btnnuevopesaje.Image = CType(resources.GetObject("btnnuevopesaje.Image"), System.Drawing.Image)
        Me.btnnuevopesaje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevopesaje.Location = New System.Drawing.Point(6, 209)
        Me.btnnuevopesaje.Name = "btnnuevopesaje"
        Me.btnnuevopesaje.Size = New System.Drawing.Size(146, 41)
        Me.btnnuevopesaje.TabIndex = 2
        Me.btnnuevopesaje.Text = "Nuevo Pesaje"
        Me.btnnuevopesaje.UseVisualStyleBackColor = True
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(6, 22)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersVisible = False
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(671, 186)
        Me.DataListado.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnnuevopesaje)
        Me.GroupBox1.Controls.Add(Me.DataListado)
        Me.GroupBox1.Location = New System.Drawing.Point(562, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 254)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesajes x Realizar"
        '
        'sppuerto
        '
        Me.sppuerto.BaudRate = 4800
        Me.sppuerto.DataBits = 7
        Me.sppuerto.Parity = System.IO.Ports.Parity.Even
        '
        'frmpesajesindestareautomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 725)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpesajesindestareautomatico"
        Me.Text = "Pesaje Sin Destare Automático"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtnomtipo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttara As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnomtrans As TextBox
    Friend WithEvents txtidtransportista As TextBox
    Friend WithEvents txtpesaje As TextBox
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarpesaje As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtnombretipovehiculo As TextBox
    Friend WithEvents txtidtipovehiculo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpatente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdocsap As TextBox
    Friend WithEvents txtnumpesaje As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fecha As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents datalistado2 As DataGridView
    Friend WithEvents btnnuevopesaje As Button
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncapturapeso As Button
    Friend WithEvents sppuerto As IO.Ports.SerialPort
    Friend WithEvents txtguiadespacho As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtep As TextBox
    Friend WithEvents btnanula As Button
End Class

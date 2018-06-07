<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendimiaPesajeAutomatico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendimiaPesajeAutomatico))
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btncapturapesobruto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnnuevopesaje = New System.Windows.Forms.Button()
        Me.btncapturapesotara = New System.Windows.Forms.Button()
        Me.txtguiadespacho = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtestadopesaje = New System.Windows.Forms.TextBox()
        Me.txtpesajeneto = New System.Windows.Forms.TextBox()
        Me.btnanula = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datalistado2 = New System.Windows.Forms.DataGridView()
        Me.txtpesajebruto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtnomtipo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnomtrans = New System.Windows.Forms.TextBox()
        Me.txtpesajetara = New System.Windows.Forms.TextBox()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.txtidtransportista = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombretipovehiculo = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarpesaje = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtidtipovehiculo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnumpesaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBuscarTransportista = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtdocsap = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataListado
        '
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.AllowUserToDeleteRows = False
        Me.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado.Location = New System.Drawing.Point(6, 22)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RowHeadersVisible = False
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(671, 186)
        Me.DataListado.TabIndex = 1
        '
        'txtuser
        '
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(379, 142)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(96, 20)
        Me.txtuser.TabIndex = 54
        Me.txtuser.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(266, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Cantidad Envases"
        Me.Label15.Visible = False
        '
        'btncapturapesobruto
        '
        Me.btncapturapesobruto.Image = CType(resources.GetObject("btncapturapesobruto.Image"), System.Drawing.Image)
        Me.btncapturapesobruto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncapturapesobruto.Location = New System.Drawing.Point(376, 480)
        Me.btncapturapesobruto.Name = "btncapturapesobruto"
        Me.btncapturapesobruto.Size = New System.Drawing.Size(171, 72)
        Me.btncapturapesobruto.TabIndex = 52
        Me.btncapturapesobruto.Text = "Capturar Pesaje Cargado"
        Me.btncapturapesobruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapturapesobruto.UseVisualStyleBackColor = True
        Me.btncapturapesobruto.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnnuevopesaje)
        Me.GroupBox1.Controls.Add(Me.DataListado)
        Me.GroupBox1.Location = New System.Drawing.Point(620, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 254)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesajes x Realizar"
        '
        'btnnuevopesaje
        '
        Me.btnnuevopesaje.Image = CType(resources.GetObject("btnnuevopesaje.Image"), System.Drawing.Image)
        Me.btnnuevopesaje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevopesaje.Location = New System.Drawing.Point(6, 210)
        Me.btnnuevopesaje.Name = "btnnuevopesaje"
        Me.btnnuevopesaje.Size = New System.Drawing.Size(146, 41)
        Me.btnnuevopesaje.TabIndex = 2
        Me.btnnuevopesaje.Text = "Nuevo Pesaje"
        Me.btnnuevopesaje.UseVisualStyleBackColor = True
        '
        'btncapturapesotara
        '
        Me.btncapturapesotara.Image = CType(resources.GetObject("btncapturapesotara.Image"), System.Drawing.Image)
        Me.btncapturapesotara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncapturapesotara.Location = New System.Drawing.Point(376, 407)
        Me.btncapturapesotara.Name = "btncapturapesotara"
        Me.btncapturapesotara.Size = New System.Drawing.Size(171, 72)
        Me.btncapturapesotara.TabIndex = 51
        Me.btncapturapesotara.Text = "Capturar Pesaje Vacio"
        Me.btncapturapesotara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapturapesotara.UseVisualStyleBackColor = True
        Me.btncapturapesotara.Visible = False
        '
        'txtguiadespacho
        '
        Me.txtguiadespacho.Location = New System.Drawing.Point(351, 98)
        Me.txtguiadespacho.Name = "txtguiadespacho"
        Me.txtguiadespacho.Size = New System.Drawing.Size(123, 20)
        Me.txtguiadespacho.TabIndex = 4
        Me.txtguiadespacho.Text = "0"
        Me.txtguiadespacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(238, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "N° Guía Despacho"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(457, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Estado Pesaje"
        Me.Label13.Visible = False
        '
        'txtestadopesaje
        '
        Me.txtestadopesaje.Enabled = False
        Me.txtestadopesaje.Location = New System.Drawing.Point(537, 10)
        Me.txtestadopesaje.Name = "txtestadopesaje"
        Me.txtestadopesaje.Size = New System.Drawing.Size(29, 20)
        Me.txtestadopesaje.TabIndex = 46
        Me.txtestadopesaje.Visible = False
        '
        'txtpesajeneto
        '
        Me.txtpesajeneto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpesajeneto.Enabled = False
        Me.txtpesajeneto.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesajeneto.ForeColor = System.Drawing.SystemColors.Window
        Me.txtpesajeneto.Location = New System.Drawing.Point(185, 553)
        Me.txtpesajeneto.Name = "txtpesajeneto"
        Me.txtpesajeneto.Size = New System.Drawing.Size(189, 71)
        Me.txtpesajeneto.TabIndex = 45
        Me.txtpesajeneto.Text = "0"
        Me.txtpesajeneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnanula
        '
        Me.btnanula.BackColor = System.Drawing.Color.Red
        Me.btnanula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnanula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnanula.Location = New System.Drawing.Point(437, 626)
        Me.btnanula.Name = "btnanula"
        Me.btnanula.Size = New System.Drawing.Size(127, 48)
        Me.btnanula.TabIndex = 50
        Me.btnanula.Text = "Anular Pesaje"
        Me.btnanula.UseVisualStyleBackColor = False
        Me.btnanula.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datalistado2)
        Me.GroupBox2.Location = New System.Drawing.Point(620, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 315)
        Me.GroupBox2.TabIndex = 39
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
        'txtpesajebruto
        '
        Me.txtpesajebruto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpesajebruto.Enabled = False
        Me.txtpesajebruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesajebruto.ForeColor = System.Drawing.SystemColors.Window
        Me.txtpesajebruto.Location = New System.Drawing.Point(185, 481)
        Me.txtpesajebruto.Name = "txtpesajebruto"
        Me.txtpesajebruto.Size = New System.Drawing.Size(189, 71)
        Me.txtpesajebruto.TabIndex = 7
        Me.txtpesajebruto.Text = "0"
        Me.txtpesajebruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 572)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "NETO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 501)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "BRUTO"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(86, 344)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(484, 59)
        Me.txtobservaciones.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Observaciones"
        '
        'txttipo
        '
        Me.txttipo.Enabled = False
        Me.txttipo.Location = New System.Drawing.Point(94, 142)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(29, 20)
        Me.txttipo.TabIndex = 39
        '
        'txtnomtipo
        '
        Me.txtnomtipo.Enabled = False
        Me.txtnomtipo.Location = New System.Drawing.Point(125, 142)
        Me.txtnomtipo.Name = "txtnomtipo"
        Me.txtnomtipo.Size = New System.Drawing.Size(105, 20)
        Me.txtnomtipo.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Pesaje"
        '
        'txttara
        '
        Me.txttara.Enabled = False
        Me.txttara.Location = New System.Drawing.Point(379, 120)
        Me.txttara.Name = "txttara"
        Me.txttara.Size = New System.Drawing.Size(96, 20)
        Me.txttara.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tara Estimada"
        '
        'txtnomtrans
        '
        Me.txtnomtrans.Enabled = False
        Me.txtnomtrans.Location = New System.Drawing.Point(125, 120)
        Me.txtnomtrans.Name = "txtnomtrans"
        Me.txtnomtrans.Size = New System.Drawing.Size(159, 20)
        Me.txtnomtrans.TabIndex = 34
        '
        'txtpesajetara
        '
        Me.txtpesajetara.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpesajetara.Enabled = False
        Me.txtpesajetara.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesajetara.ForeColor = System.Drawing.SystemColors.Window
        Me.txtpesajetara.Location = New System.Drawing.Point(185, 408)
        Me.txtpesajetara.Name = "txtpesajetara"
        Me.txtpesajetara.Size = New System.Drawing.Size(189, 71)
        Me.txtpesajetara.TabIndex = 6
        Me.txtpesajetara.Text = "0"
        Me.txtpesajetara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtidtransportista
        '
        Me.txtidtransportista.Enabled = False
        Me.txtidtransportista.Location = New System.Drawing.Point(94, 120)
        Me.txtidtransportista.Name = "txtidtransportista"
        Me.txtidtransportista.Size = New System.Drawing.Size(29, 20)
        Me.txtidtransportista.TabIndex = 33
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnBuscarTransportista)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtuser)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btncapturapesobruto)
        Me.GroupBox3.Controls.Add(Me.btncapturapesotara)
        Me.GroupBox3.Controls.Add(Me.btnanula)
        Me.GroupBox3.Controls.Add(Me.txtguiadespacho)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtestadopesaje)
        Me.GroupBox3.Controls.Add(Me.txtpesajeneto)
        Me.GroupBox3.Controls.Add(Me.txtpesajebruto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtpesajetara)
        Me.GroupBox3.Controls.Add(Me.txtobservaciones)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txttipo)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtnomtipo)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txttara)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtnomtrans)
        Me.GroupBox3.Controls.Add(Me.Label17)
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
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtnumpesaje)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblhora)
        Me.GroupBox3.Controls.Add(Me.lblfecha)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.fecha)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 681)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesaje"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(8, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(587, 173)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la Uva"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Transportista"
        '
        'txtnombretipovehiculo
        '
        Me.txtnombretipovehiculo.Enabled = False
        Me.txtnombretipovehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombretipovehiculo.Location = New System.Drawing.Point(408, 46)
        Me.txtnombretipovehiculo.Name = "txtnombretipovehiculo"
        Me.txtnombretipovehiculo.Size = New System.Drawing.Size(152, 26)
        Me.txtnombretipovehiculo.TabIndex = 31
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(151, 626)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(137, 48)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarpesaje
        '
        Me.btnGuardarpesaje.Image = CType(resources.GetObject("btnGuardarpesaje.Image"), System.Drawing.Image)
        Me.btnGuardarpesaje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarpesaje.Location = New System.Drawing.Point(8, 627)
        Me.btnGuardarpesaje.Name = "btnGuardarpesaje"
        Me.btnGuardarpesaje.Size = New System.Drawing.Size(137, 48)
        Me.btnGuardarpesaje.TabIndex = 8
        Me.btnGuardarpesaje.Text = "Guardar Pesaje"
        Me.btnGuardarpesaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarpesaje.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(88, 435)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(61, 24)
        Me.lbltitulo.TabIndex = 30
        Me.lbltitulo.Text = "TARA"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(294, 626)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(137, 48)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtidtipovehiculo
        '
        Me.txtidtipovehiculo.Enabled = False
        Me.txtidtipovehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidtipovehiculo.Location = New System.Drawing.Point(377, 46)
        Me.txtidtipovehiculo.Name = "txtidtipovehiculo"
        Me.txtidtipovehiculo.Size = New System.Drawing.Size(29, 26)
        Me.txtidtipovehiculo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Bodega"
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Location = New System.Drawing.Point(94, 76)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(69, 20)
        Me.txtmarca.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "N° Contrato"
        '
        'txtpatente
        '
        Me.txtpatente.Enabled = False
        Me.txtpatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatente.Location = New System.Drawing.Point(212, 46)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(100, 26)
        Me.txtpatente.TabIndex = 20
        Me.txtpatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(171, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Patente"
        '
        'txtnumpesaje
        '
        Me.txtnumpesaje.Enabled = False
        Me.txtnumpesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumpesaje.Location = New System.Drawing.Point(66, 46)
        Me.txtnumpesaje.Name = "txtnumpesaje"
        Me.txtnumpesaje.Size = New System.Drawing.Size(97, 26)
        Me.txtnumpesaje.TabIndex = 17
        Me.txtnumpesaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fecha Guía D."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "N° Pesaje"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblhora.Location = New System.Drawing.Point(332, 12)
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
        Me.lblfecha.Location = New System.Drawing.Point(87, 12)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(111, 37)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(294, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hora"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fecha.Location = New System.Drawing.Point(12, 27)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(40, 13)
        Me.fecha.TabIndex = 9
        Me.fecha.Text = "Fecha:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnBuscarTransportista
        '
        Me.btnBuscarTransportista.Location = New System.Drawing.Point(562, 45)
        Me.btnBuscarTransportista.Name = "btnBuscarTransportista"
        Me.btnBuscarTransportista.Size = New System.Drawing.Size(33, 28)
        Me.btnBuscarTransportista.TabIndex = 56
        Me.btnBuscarTransportista.Text = "..."
        Me.btnBuscarTransportista.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 22)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Fecha Guía D."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Transportista"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(296, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Tara Estimada"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 146)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Tipo Envase"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(622, 593)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Usuario Pesaje"
        Me.Label20.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(708, 589)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(123, 20)
        Me.TextBox7.TabIndex = 54
        Me.TextBox7.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.RadioButton1)
        Me.GroupBox6.Location = New System.Drawing.Point(481, 97)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 63)
        Me.GroupBox6.TabIndex = 58
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo Cosecha"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manual"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Máquina"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 22)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtdocsap
        '
        Me.txtdocsap.Location = New System.Drawing.Point(94, 98)
        Me.txtdocsap.Name = "txtdocsap"
        Me.txtdocsap.Size = New System.Drawing.Size(69, 20)
        Me.txtdocsap.TabIndex = 3
        Me.txtdocsap.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(202, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Productor"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(252, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 20)
        Me.TextBox1.TabIndex = 61
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(339, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 20)
        Me.TextBox2.TabIndex = 62
        Me.TextBox2.Visible = False
        '
        'frmVendimiaPesajeAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 739)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label20)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendimiaPesajeAutomatico"
        Me.Text = "Pesaje Uva Vinífera"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataListado As DataGridView
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btncapturapesobruto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnnuevopesaje As Button
    Friend WithEvents btncapturapesotara As Button
    Friend WithEvents txtguiadespacho As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtestadopesaje As TextBox
    Friend WithEvents txtpesajeneto As TextBox
    Friend WithEvents btnanula As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents datalistado2 As DataGridView
    Friend WithEvents txtpesajebruto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtnomtipo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttara As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnomtrans As TextBox
    Friend WithEvents txtpesajetara As TextBox
    Friend WithEvents sppuerto As IO.Ports.SerialPort
    Friend WithEvents txtidtransportista As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombretipovehiculo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarpesaje As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtidtipovehiculo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpatente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnumpesaje As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBuscarTransportista As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtdocsap As TextBox
End Class

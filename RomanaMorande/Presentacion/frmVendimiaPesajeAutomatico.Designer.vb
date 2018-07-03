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
        Me.txtcantenvin = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btncapturapesobruto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnnuevopesaje = New System.Windows.Forms.Button()
        Me.btncapturapesotara = New System.Windows.Forms.Button()
        Me.txtnumguia = New System.Windows.Forms.TextBox()
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
        Me.txttipoenv = New System.Windows.Forms.TextBox()
        Me.txtnomtipoenv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnomtrans = New System.Windows.Forms.TextBox()
        Me.txtpesajetara = New System.Windows.Forms.TextBox()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.txtidtransportista = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtidbodega = New System.Windows.Forms.TextBox()
        Me.txtcantenvout = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dpfechaguia = New System.Windows.Forms.DateTimePicker()
        Me.txtnomprov = New System.Windows.Forms.TextBox()
        Me.txtrutprov = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbMecanica = New System.Windows.Forms.RadioButton()
        Me.rbManual = New System.Windows.Forms.RadioButton()
        Me.btnBuscarContrato = New System.Windows.Forms.Button()
        Me.btnBuscarBodega = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtidcontrato = New System.Windows.Forms.TextBox()
        Me.txtidvariedad = New System.Windows.Forms.TextBox()
        Me.txtidcalidad = New System.Windows.Forms.TextBox()
        Me.btnBuscarSector = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtcastigo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtapb = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txttemp = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtdensidad = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtbrix = New System.Windows.Forms.TextBox()
        Me.txtnomsubcuartel = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtidsubcuartel = New System.Windows.Forms.TextBox()
        Me.txtnomcuartel = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtidcuartel = New System.Windows.Forms.TextBox()
        Me.txtnomsector = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtidsector = New System.Windows.Forms.TextBox()
        Me.txtcalidad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnBuscarVariedad = New System.Windows.Forms.Button()
        Me.txtcodcalidad = New System.Windows.Forms.TextBox()
        Me.txtnomuva = New System.Windows.Forms.TextBox()
        Me.txtcoduva = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbodega = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarpesaje = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtcodbodega = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumcontrato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnumpesaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtidsectorcuartel = New System.Windows.Forms.TextBox()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'txtcantenvin
        '
        Me.txtcantenvin.Enabled = False
        Me.txtcantenvin.Location = New System.Drawing.Point(318, 143)
        Me.txtcantenvin.Name = "txtcantenvin"
        Me.txtcantenvin.Size = New System.Drawing.Size(53, 20)
        Me.txtcantenvin.TabIndex = 54
        Me.txtcantenvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(281, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "EnvIN"
        '
        'btncapturapesobruto
        '
        Me.btncapturapesobruto.Image = CType(resources.GetObject("btncapturapesobruto.Image"), System.Drawing.Image)
        Me.btncapturapesobruto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncapturapesobruto.Location = New System.Drawing.Point(375, 408)
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
        Me.btncapturapesotara.Location = New System.Drawing.Point(375, 480)
        Me.btncapturapesotara.Name = "btncapturapesotara"
        Me.btncapturapesotara.Size = New System.Drawing.Size(171, 72)
        Me.btncapturapesotara.TabIndex = 51
        Me.btncapturapesotara.Text = "Capturar Pesaje Vacio"
        Me.btncapturapesotara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapturapesotara.UseVisualStyleBackColor = True
        Me.btncapturapesotara.Visible = False
        '
        'txtnumguia
        '
        Me.txtnumguia.Location = New System.Drawing.Point(379, 98)
        Me.txtnumguia.Name = "txtnumguia"
        Me.txtnumguia.Size = New System.Drawing.Size(95, 20)
        Me.txtnumguia.TabIndex = 4
        Me.txtnumguia.Text = "0"
        Me.txtnumguia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "N° Guía Despacho"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(378, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Estado Pesaje"
        Me.Label13.Visible = False
        '
        'txtestadopesaje
        '
        Me.txtestadopesaje.Enabled = False
        Me.txtestadopesaje.Location = New System.Drawing.Point(458, 0)
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
        Me.txtpesajebruto.Location = New System.Drawing.Point(185, 409)
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
        Me.Label12.Location = New System.Drawing.Point(114, 572)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "NETO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(103, 429)
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
        'txttipoenv
        '
        Me.txttipoenv.Enabled = False
        Me.txttipoenv.Location = New System.Drawing.Point(89, 142)
        Me.txttipoenv.Name = "txttipoenv"
        Me.txttipoenv.Size = New System.Drawing.Size(29, 20)
        Me.txttipoenv.TabIndex = 39
        Me.txttipoenv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomtipoenv
        '
        Me.txtnomtipoenv.Enabled = False
        Me.txtnomtipoenv.Location = New System.Drawing.Point(120, 142)
        Me.txtnomtipoenv.Name = "txtnomtipoenv"
        Me.txtnomtipoenv.Size = New System.Drawing.Size(126, 20)
        Me.txtnomtipoenv.TabIndex = 38
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
        Me.txttara.Size = New System.Drawing.Size(95, 20)
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
        Me.txtnomtrans.Location = New System.Drawing.Point(120, 120)
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
        Me.txtpesajetara.Location = New System.Drawing.Point(185, 481)
        Me.txtpesajetara.Name = "txtpesajetara"
        Me.txtpesajetara.Size = New System.Drawing.Size(189, 71)
        Me.txtpesajetara.TabIndex = 6
        Me.txtpesajetara.Text = "0"
        Me.txtpesajetara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtidtransportista
        '
        Me.txtidtransportista.Enabled = False
        Me.txtidtransportista.Location = New System.Drawing.Point(89, 120)
        Me.txtidtransportista.Name = "txtidtransportista"
        Me.txtidtransportista.Size = New System.Drawing.Size(29, 20)
        Me.txtidtransportista.TabIndex = 33
        Me.txtidtransportista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.txtidbodega)
        Me.GroupBox3.Controls.Add(Me.txtcantenvout)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.dpfechaguia)
        Me.GroupBox3.Controls.Add(Me.txtnomprov)
        Me.GroupBox3.Controls.Add(Me.txtrutprov)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.btnBuscarContrato)
        Me.GroupBox3.Controls.Add(Me.btnBuscarBodega)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtcantenvin)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btncapturapesobruto)
        Me.GroupBox3.Controls.Add(Me.btncapturapesotara)
        Me.GroupBox3.Controls.Add(Me.btnanula)
        Me.GroupBox3.Controls.Add(Me.txtnumguia)
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
        Me.GroupBox3.Controls.Add(Me.txttipoenv)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtnomtipoenv)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txttara)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtnomtrans)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtidtransportista)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtbodega)
        Me.GroupBox3.Controls.Add(Me.btnCancelar)
        Me.GroupBox3.Controls.Add(Me.btnGuardarpesaje)
        Me.GroupBox3.Controls.Add(Me.lbltitulo)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.txtcodbodega)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtnumcontrato)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtpatente)
        Me.GroupBox3.Controls.Add(Me.Label5)
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
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(501, 3)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "CodBodega"
        Me.Label33.Visible = False
        '
        'txtidbodega
        '
        Me.txtidbodega.Enabled = False
        Me.txtidbodega.Location = New System.Drawing.Point(567, 0)
        Me.txtidbodega.Name = "txtidbodega"
        Me.txtidbodega.Size = New System.Drawing.Size(29, 20)
        Me.txtidbodega.TabIndex = 66
        Me.txtidbodega.Visible = False
        '
        'txtcantenvout
        '
        Me.txtcantenvout.Enabled = False
        Me.txtcantenvout.Location = New System.Drawing.Point(421, 143)
        Me.txtcantenvout.Name = "txtcantenvout"
        Me.txtcantenvout.Size = New System.Drawing.Size(53, 20)
        Me.txtcantenvout.TabIndex = 65
        Me.txtcantenvout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(374, 146)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 64
        Me.Label32.Text = "EnvOUT"
        '
        'dpfechaguia
        '
        Me.dpfechaguia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpfechaguia.Location = New System.Drawing.Point(89, 98)
        Me.dpfechaguia.Name = "dpfechaguia"
        Me.dpfechaguia.Size = New System.Drawing.Size(82, 20)
        Me.dpfechaguia.TabIndex = 63
        '
        'txtnomprov
        '
        Me.txtnomprov.Location = New System.Drawing.Point(339, 76)
        Me.txtnomprov.Name = "txtnomprov"
        Me.txtnomprov.Size = New System.Drawing.Size(256, 20)
        Me.txtnomprov.TabIndex = 62
        '
        'txtrutprov
        '
        Me.txtrutprov.Location = New System.Drawing.Point(265, 76)
        Me.txtrutprov.Name = "txtrutprov"
        Me.txtrutprov.Size = New System.Drawing.Size(73, 20)
        Me.txtrutprov.TabIndex = 61
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(206, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Productor"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 22)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbMecanica)
        Me.GroupBox6.Controls.Add(Me.rbManual)
        Me.GroupBox6.Location = New System.Drawing.Point(480, 99)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 66)
        Me.GroupBox6.TabIndex = 58
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo Cosecha"
        '
        'rbMecanica
        '
        Me.rbMecanica.AutoSize = True
        Me.rbMecanica.Location = New System.Drawing.Point(10, 38)
        Me.rbMecanica.Name = "rbMecanica"
        Me.rbMecanica.Size = New System.Drawing.Size(72, 17)
        Me.rbMecanica.TabIndex = 1
        Me.rbMecanica.TabStop = True
        Me.rbMecanica.Text = "Mecánica"
        Me.rbMecanica.UseVisualStyleBackColor = True
        '
        'rbManual
        '
        Me.rbManual.AutoSize = True
        Me.rbManual.Location = New System.Drawing.Point(10, 19)
        Me.rbManual.Name = "rbManual"
        Me.rbManual.Size = New System.Drawing.Size(60, 17)
        Me.rbManual.TabIndex = 0
        Me.rbManual.TabStop = True
        Me.rbManual.Text = "Manual"
        Me.rbManual.UseVisualStyleBackColor = True
        '
        'btnBuscarContrato
        '
        Me.btnBuscarContrato.Enabled = False
        Me.btnBuscarContrato.Location = New System.Drawing.Point(158, 75)
        Me.btnBuscarContrato.Name = "btnBuscarContrato"
        Me.btnBuscarContrato.Size = New System.Drawing.Size(33, 22)
        Me.btnBuscarContrato.TabIndex = 57
        Me.btnBuscarContrato.Text = "..."
        Me.btnBuscarContrato.UseVisualStyleBackColor = True
        '
        'btnBuscarBodega
        '
        Me.btnBuscarBodega.Enabled = False
        Me.btnBuscarBodega.Location = New System.Drawing.Point(562, 45)
        Me.btnBuscarBodega.Name = "btnBuscarBodega"
        Me.btnBuscarBodega.Size = New System.Drawing.Size(33, 28)
        Me.btnBuscarBodega.TabIndex = 56
        Me.btnBuscarBodega.Text = "..."
        Me.btnBuscarBodega.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtidsectorcuartel)
        Me.GroupBox4.Controls.Add(Me.txtidcontrato)
        Me.GroupBox4.Controls.Add(Me.txtidvariedad)
        Me.GroupBox4.Controls.Add(Me.txtidcalidad)
        Me.GroupBox4.Controls.Add(Me.btnBuscarSector)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtcastigo)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.txtapb)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txttemp)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtdensidad)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtbrix)
        Me.GroupBox4.Controls.Add(Me.txtnomsubcuartel)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.txtidsubcuartel)
        Me.GroupBox4.Controls.Add(Me.txtnomcuartel)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtidcuartel)
        Me.GroupBox4.Controls.Add(Me.txtnomsector)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtidsector)
        Me.GroupBox4.Controls.Add(Me.txtcalidad)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.btnBuscarVariedad)
        Me.GroupBox4.Controls.Add(Me.txtcodcalidad)
        Me.GroupBox4.Controls.Add(Me.txtnomuva)
        Me.GroupBox4.Controls.Add(Me.txtcoduva)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(587, 173)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de la Uva"
        '
        'txtidcontrato
        '
        Me.txtidcontrato.Location = New System.Drawing.Point(98, 2)
        Me.txtidcontrato.Name = "txtidcontrato"
        Me.txtidcontrato.Size = New System.Drawing.Size(39, 20)
        Me.txtidcontrato.TabIndex = 90
        Me.txtidcontrato.Visible = False
        '
        'txtidvariedad
        '
        Me.txtidvariedad.Location = New System.Drawing.Point(476, 24)
        Me.txtidvariedad.Name = "txtidvariedad"
        Me.txtidvariedad.Size = New System.Drawing.Size(39, 20)
        Me.txtidvariedad.TabIndex = 89
        Me.txtidvariedad.Visible = False
        '
        'txtidcalidad
        '
        Me.txtidcalidad.Location = New System.Drawing.Point(321, 54)
        Me.txtidcalidad.Name = "txtidcalidad"
        Me.txtidcalidad.Size = New System.Drawing.Size(39, 20)
        Me.txtidcalidad.TabIndex = 85
        Me.txtidcalidad.Visible = False
        '
        'btnBuscarSector
        '
        Me.btnBuscarSector.Enabled = False
        Me.btnBuscarSector.Location = New System.Drawing.Point(284, 79)
        Me.btnBuscarSector.Name = "btnBuscarSector"
        Me.btnBuscarSector.Size = New System.Drawing.Size(33, 22)
        Me.btnBuscarSector.TabIndex = 64
        Me.btnBuscarSector.Text = "..."
        Me.btnBuscarSector.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(344, 109)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 13)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "% Castigo"
        '
        'txtcastigo
        '
        Me.txtcastigo.Location = New System.Drawing.Point(400, 105)
        Me.txtcastigo.Name = "txtcastigo"
        Me.txtcastigo.Size = New System.Drawing.Size(39, 20)
        Me.txtcastigo.TabIndex = 84
        Me.txtcastigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(471, 83)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 13)
        Me.Label30.TabIndex = 81
        Me.Label30.Text = "APB"
        '
        'txtapb
        '
        Me.txtapb.Location = New System.Drawing.Point(502, 79)
        Me.txtapb.Name = "txtapb"
        Me.txtapb.Size = New System.Drawing.Size(50, 20)
        Me.txtapb.TabIndex = 82
        Me.txtapb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(379, 83)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 13)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "T°"
        '
        'txttemp
        '
        Me.txttemp.Location = New System.Drawing.Point(400, 79)
        Me.txttemp.Name = "txttemp"
        Me.txttemp.Size = New System.Drawing.Size(39, 20)
        Me.txttemp.TabIndex = 80
        Me.txttemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(447, 57)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 13)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "Densidad"
        '
        'txtdensidad
        '
        Me.txtdensidad.Location = New System.Drawing.Point(502, 54)
        Me.txtdensidad.Name = "txtdensidad"
        Me.txtdensidad.Size = New System.Drawing.Size(66, 20)
        Me.txtdensidad.TabIndex = 78
        Me.txtdensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(373, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 13)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Brix"
        '
        'txtbrix
        '
        Me.txtbrix.Location = New System.Drawing.Point(400, 54)
        Me.txtbrix.Name = "txtbrix"
        Me.txtbrix.Size = New System.Drawing.Size(39, 20)
        Me.txtbrix.TabIndex = 76
        Me.txtbrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomsubcuartel
        '
        Me.txtnomsubcuartel.Location = New System.Drawing.Point(115, 131)
        Me.txtnomsubcuartel.Name = "txtnomsubcuartel"
        Me.txtnomsubcuartel.Size = New System.Drawing.Size(202, 20)
        Me.txtnomsubcuartel.TabIndex = 74
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 134)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 72
        Me.Label26.Text = "Sub-Cuartel"
        '
        'txtidsubcuartel
        '
        Me.txtidsubcuartel.Location = New System.Drawing.Point(75, 131)
        Me.txtidsubcuartel.Name = "txtidsubcuartel"
        Me.txtidsubcuartel.Size = New System.Drawing.Size(39, 20)
        Me.txtidsubcuartel.TabIndex = 73
        Me.txtidsubcuartel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomcuartel
        '
        Me.txtnomcuartel.Location = New System.Drawing.Point(115, 106)
        Me.txtnomcuartel.Name = "txtnomcuartel"
        Me.txtnomcuartel.Size = New System.Drawing.Size(202, 20)
        Me.txtnomcuartel.TabIndex = 71
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 109)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "Cuartel"
        '
        'txtidcuartel
        '
        Me.txtidcuartel.Location = New System.Drawing.Point(75, 106)
        Me.txtidcuartel.Name = "txtidcuartel"
        Me.txtidcuartel.Size = New System.Drawing.Size(39, 20)
        Me.txtidcuartel.TabIndex = 70
        Me.txtidcuartel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomsector
        '
        Me.txtnomsector.Location = New System.Drawing.Point(115, 80)
        Me.txtnomsector.Name = "txtnomsector"
        Me.txtnomsector.Size = New System.Drawing.Size(168, 20)
        Me.txtnomsector.TabIndex = 68
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Sector"
        '
        'txtidsector
        '
        Me.txtidsector.Location = New System.Drawing.Point(75, 80)
        Me.txtidsector.Name = "txtidsector"
        Me.txtidsector.Size = New System.Drawing.Size(39, 20)
        Me.txtidsector.TabIndex = 67
        Me.txtidsector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcalidad
        '
        Me.txtcalidad.Location = New System.Drawing.Point(115, 54)
        Me.txtcalidad.Name = "txtcalidad"
        Me.txtcalidad.Size = New System.Drawing.Size(202, 20)
        Me.txtcalidad.TabIndex = 65
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Calidad"
        '
        'btnBuscarVariedad
        '
        Me.btnBuscarVariedad.Enabled = False
        Me.btnBuscarVariedad.Location = New System.Drawing.Point(516, 24)
        Me.btnBuscarVariedad.Name = "btnBuscarVariedad"
        Me.btnBuscarVariedad.Size = New System.Drawing.Size(52, 22)
        Me.btnBuscarVariedad.TabIndex = 63
        Me.btnBuscarVariedad.Text = "..."
        Me.btnBuscarVariedad.UseVisualStyleBackColor = True
        '
        'txtcodcalidad
        '
        Me.txtcodcalidad.Location = New System.Drawing.Point(75, 54)
        Me.txtcodcalidad.Name = "txtcodcalidad"
        Me.txtcodcalidad.Size = New System.Drawing.Size(39, 20)
        Me.txtcodcalidad.TabIndex = 64
        Me.txtcodcalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomuva
        '
        Me.txtnomuva.Location = New System.Drawing.Point(153, 25)
        Me.txtnomuva.Name = "txtnomuva"
        Me.txtnomuva.Size = New System.Drawing.Size(362, 20)
        Me.txtnomuva.TabIndex = 64
        '
        'txtcoduva
        '
        Me.txtcoduva.Location = New System.Drawing.Point(75, 25)
        Me.txtcoduva.Name = "txtcoduva"
        Me.txtcoduva.Size = New System.Drawing.Size(77, 20)
        Me.txtcoduva.TabIndex = 63
        Me.txtcoduva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Variedad"
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(296, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Tara Estimada"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Transportista"
        '
        'txtbodega
        '
        Me.txtbodega.Enabled = False
        Me.txtbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbodega.Location = New System.Drawing.Point(408, 46)
        Me.txtbodega.Name = "txtbodega"
        Me.txtbodega.Size = New System.Drawing.Size(152, 26)
        Me.txtbodega.TabIndex = 31
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
        Me.lbltitulo.Location = New System.Drawing.Point(117, 508)
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
        'txtcodbodega
        '
        Me.txtcodbodega.Enabled = False
        Me.txtcodbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodbodega.Location = New System.Drawing.Point(377, 46)
        Me.txtcodbodega.Name = "txtcodbodega"
        Me.txtcodbodega.Size = New System.Drawing.Size(29, 26)
        Me.txtcodbodega.TabIndex = 25
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
        'txtnumcontrato
        '
        Me.txtnumcontrato.Location = New System.Drawing.Point(89, 76)
        Me.txtnumcontrato.Name = "txtnumcontrato"
        Me.txtnumcontrato.Size = New System.Drawing.Size(69, 20)
        Me.txtnumcontrato.TabIndex = 23
        Me.txtnumcontrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Fecha Guía D."
        '
        'txtnumpesaje
        '
        Me.txtnumpesaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtnumpesaje.Enabled = False
        Me.txtnumpesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumpesaje.Location = New System.Drawing.Point(70, 46)
        Me.txtnumpesaje.Name = "txtnumpesaje"
        Me.txtnumpesaje.ReadOnly = True
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
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'txtidsectorcuartel
        '
        Me.txtidsectorcuartel.Location = New System.Drawing.Point(321, 80)
        Me.txtidsectorcuartel.Name = "txtidsectorcuartel"
        Me.txtidsectorcuartel.Size = New System.Drawing.Size(39, 20)
        Me.txtidsectorcuartel.TabIndex = 91
        Me.txtidsectorcuartel.Visible = False
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataListado As DataGridView
    Friend WithEvents txtcantenvin As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btncapturapesobruto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnnuevopesaje As Button
    Friend WithEvents btncapturapesotara As Button
    Friend WithEvents txtnumguia As TextBox
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
    Friend WithEvents txttipoenv As TextBox
    Friend WithEvents txtnomtipoenv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttara As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnomtrans As TextBox
    Friend WithEvents txtpesajetara As TextBox
    Friend WithEvents sppuerto As IO.Ports.SerialPort
    Friend WithEvents txtidtransportista As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbodega As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarpesaje As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtcodbodega As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnumcontrato As TextBox
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
    Friend WithEvents rbMecanica As RadioButton
    Friend WithEvents rbManual As RadioButton
    Friend WithEvents btnBuscarContrato As Button
    Friend WithEvents btnBuscarBodega As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtnomprov As TextBox
    Friend WithEvents txtrutprov As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtdensidad As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtbrix As TextBox
    Friend WithEvents txtnomsubcuartel As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtidsubcuartel As TextBox
    Friend WithEvents txtnomcuartel As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtidcuartel As TextBox
    Friend WithEvents txtnomsector As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtidsector As TextBox
    Friend WithEvents txtcalidad As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnBuscarVariedad As Button
    Friend WithEvents txtcodcalidad As TextBox
    Friend WithEvents txtnomuva As TextBox
    Friend WithEvents txtcoduva As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtcastigo As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtapb As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txttemp As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents dpfechaguia As DateTimePicker
    Friend WithEvents btnBuscarSector As Button
    Friend WithEvents txtcantenvout As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtidbodega As TextBox
    Friend WithEvents txtidvariedad As TextBox
    Friend WithEvents txtidcalidad As TextBox
    Friend WithEvents txtidcontrato As TextBox
    Friend WithEvents txtidsectorcuartel As TextBox
End Class

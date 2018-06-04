<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmconsultapatente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconsultapatente))
        Me.datalistado2 = New System.Windows.Forms.DataGridView()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.btnfiltrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.txtnumpesaje = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtipopesaje = New System.Windows.Forms.ComboBox()
        Me.btnactualizafiltro = New System.Windows.Forms.Button()
        Me.rbfechaout = New System.Windows.Forms.RadioButton()
        Me.rbfechain = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechatermino = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fechainicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'datalistado2
        '
        Me.datalistado2.AllowUserToAddRows = False
        Me.datalistado2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado2.Location = New System.Drawing.Point(23, 94)
        Me.datalistado2.Name = "datalistado2"
        Me.datalistado2.ReadOnly = True
        Me.datalistado2.RowHeadersVisible = False
        Me.datalistado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado2.Size = New System.Drawing.Size(1127, 502)
        Me.datalistado2.TabIndex = 13
        '
        'txtpatente
        '
        Me.txtpatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatente.Location = New System.Drawing.Point(9, 21)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(122, 29)
        Me.txtpatente.TabIndex = 15
        '
        'btnfiltrar
        '
        Me.btnfiltrar.Image = CType(resources.GetObject("btnfiltrar.Image"), System.Drawing.Image)
        Me.btnfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfiltrar.Location = New System.Drawing.Point(1093, 31)
        Me.btnfiltrar.Name = "btnfiltrar"
        Me.btnfiltrar.Size = New System.Drawing.Size(121, 38)
        Me.btnfiltrar.TabIndex = 17
        Me.btnfiltrar.Text = "Filtrar"
        Me.btnfiltrar.UseVisualStyleBackColor = True
        Me.btnfiltrar.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(707, 628)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 54)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 606)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Descarga a Excel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(774, 606)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Re-Imprimir Voucher"
        '
        'btnprint
        '
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.Location = New System.Drawing.Point(804, 628)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(42, 54)
        Me.btnprint.TabIndex = 21
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'txtnumpesaje
        '
        Me.txtnumpesaje.Enabled = False
        Me.txtnumpesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumpesaje.Location = New System.Drawing.Point(852, 653)
        Me.txtnumpesaje.Name = "txtnumpesaje"
        Me.txtnumpesaje.Size = New System.Drawing.Size(64, 29)
        Me.txtnumpesaje.TabIndex = 22
        Me.txtnumpesaje.Text = "0"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(1013, 608)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(137, 48)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Image = CType(resources.GetObject("btnreset.Image"), System.Drawing.Image)
        Me.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreset.Location = New System.Drawing.Point(967, 30)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(120, 47)
        Me.btnreset.TabIndex = 24
        Me.btnreset.Text = "Borrar Filtro"
        Me.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(849, 637)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "N°Pesaje"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpatente)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 66)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro Patente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbtipopesaje)
        Me.GroupBox2.Controls.Add(Me.btnactualizafiltro)
        Me.GroupBox2.Controls.Add(Me.rbfechaout)
        Me.GroupBox2.Controls.Add(Me.rbfechain)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.fechatermino)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.fechainicio)
        Me.GroupBox2.Location = New System.Drawing.Point(169, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(677, 65)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro Fechas IN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tipo de Pesaje"
        '
        'cmbtipopesaje
        '
        Me.cmbtipopesaje.FormattingEnabled = True
        Me.cmbtipopesaje.Items.AddRange(New Object() {"Todos", "Normal", "Sin Destare"})
        Me.cmbtipopesaje.Location = New System.Drawing.Point(370, 36)
        Me.cmbtipopesaje.Name = "cmbtipopesaje"
        Me.cmbtipopesaje.Size = New System.Drawing.Size(151, 21)
        Me.cmbtipopesaje.TabIndex = 34
        Me.cmbtipopesaje.Text = "Todos"
        '
        'btnactualizafiltro
        '
        Me.btnactualizafiltro.Image = CType(resources.GetObject("btnactualizafiltro.Image"), System.Drawing.Image)
        Me.btnactualizafiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactualizafiltro.Location = New System.Drawing.Point(538, 18)
        Me.btnactualizafiltro.Name = "btnactualizafiltro"
        Me.btnactualizafiltro.Size = New System.Drawing.Size(124, 38)
        Me.btnactualizafiltro.TabIndex = 33
        Me.btnactualizafiltro.Text = "Filtrar"
        Me.btnactualizafiltro.UseVisualStyleBackColor = True
        '
        'rbfechaout
        '
        Me.rbfechaout.AutoSize = True
        Me.rbfechaout.Location = New System.Drawing.Point(241, 36)
        Me.rbfechaout.Name = "rbfechaout"
        Me.rbfechaout.Size = New System.Drawing.Size(87, 17)
        Me.rbfechaout.TabIndex = 32
        Me.rbfechaout.TabStop = True
        Me.rbfechaout.Text = "Fecha Salida"
        Me.rbfechaout.UseVisualStyleBackColor = True
        '
        'rbfechain
        '
        Me.rbfechain.AutoSize = True
        Me.rbfechain.Location = New System.Drawing.Point(241, 16)
        Me.rbfechain.Name = "rbfechain"
        Me.rbfechain.Size = New System.Drawing.Size(95, 17)
        Me.rbfechain.TabIndex = 31
        Me.rbfechain.TabStop = True
        Me.rbfechain.Text = "Fecha Entrada"
        Me.rbfechain.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Hasta"
        '
        'fechatermino
        '
        Me.fechatermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechatermino.Location = New System.Drawing.Point(111, 36)
        Me.fechatermino.Name = "fechatermino"
        Me.fechatermino.Size = New System.Drawing.Size(91, 20)
        Me.fechatermino.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Desde"
        '
        'fechainicio
        '
        Me.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechainicio.Location = New System.Drawing.Point(9, 36)
        Me.fechainicio.Name = "fechainicio"
        Me.fechainicio.Size = New System.Drawing.Size(91, 20)
        Me.fechainicio.TabIndex = 0
        Me.fechainicio.Value = New Date(2017, 1, 1, 10, 25, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 2)
        Me.Panel2.TabIndex = 29
        '
        'frmconsultapatente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 724)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtnumpesaje)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnfiltrar)
        Me.Controls.Add(Me.datalistado2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmconsultapatente"
        Me.Text = "Consulta Pesaje por Patente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datalistado2 As DataGridView
    Friend WithEvents txtpatente As TextBox
    Friend WithEvents btnfiltrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents txtnumpesaje As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fechatermino As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents fechainicio As DateTimePicker
    Friend WithEvents rbfechaout As RadioButton
    Friend WithEvents rbfechain As RadioButton
    Friend WithEvents btnactualizafiltro As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtipopesaje As ComboBox
    Friend WithEvents Panel2 As Panel
End Class

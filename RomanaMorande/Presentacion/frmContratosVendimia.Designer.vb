<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratosVendimia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratosVendimia))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtnumcontrato = New System.Windows.Forms.TextBox()
        Me.txtnomproductor = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrutproductor = New System.Windows.Forms.TextBox()
        Me.txtidproductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtreplegal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.btnagrega = New System.Windows.Forms.Button()
        Me.btnquita = New System.Windows.Forms.Button()
        Me.btnanular = New System.Windows.Forms.Button()
        Me.btnsectores = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(807, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(666, 5)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(153, 46)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "Nuevo Contrato"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(666, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(666, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtnumcontrato
        '
        Me.txtnumcontrato.Location = New System.Drawing.Point(104, 25)
        Me.txtnumcontrato.Name = "txtnumcontrato"
        Me.txtnumcontrato.Size = New System.Drawing.Size(122, 20)
        Me.txtnumcontrato.TabIndex = 4
        '
        'txtnomproductor
        '
        Me.txtnomproductor.Location = New System.Drawing.Point(204, 49)
        Me.txtnomproductor.Name = "txtnomproductor"
        Me.txtnomproductor.Size = New System.Drawing.Size(300, 20)
        Me.txtnomproductor.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(510, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(58, 22)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Numero Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Productor"
        '
        'txtrutproductor
        '
        Me.txtrutproductor.Location = New System.Drawing.Point(104, 49)
        Me.txtrutproductor.Name = "txtrutproductor"
        Me.txtrutproductor.Size = New System.Drawing.Size(97, 20)
        Me.txtrutproductor.TabIndex = 5
        '
        'txtidproductor
        '
        Me.txtidproductor.Location = New System.Drawing.Point(574, 49)
        Me.txtidproductor.Name = "txtidproductor"
        Me.txtidproductor.Size = New System.Drawing.Size(86, 20)
        Me.txtidproductor.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dirección"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(104, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 20)
        Me.TextBox2.TabIndex = 12
        '
        'txtciudad
        '
        Me.txtciudad.Location = New System.Drawing.Point(510, 73)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(150, 20)
        Me.txtciudad.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Rep. Legal"
        '
        'txtreplegal
        '
        Me.txtreplegal.Location = New System.Drawing.Point(104, 97)
        Me.txtreplegal.Name = "txtreplegal"
        Me.txtreplegal.Size = New System.Drawing.Size(284, 20)
        Me.txtreplegal.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Teléfono"
        '
        'txtfono
        '
        Me.txtfono.Location = New System.Drawing.Point(448, 97)
        Me.txtfono.Name = "txtfono"
        Me.txtfono.Size = New System.Drawing.Size(150, 20)
        Me.txtfono.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "E-mail"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(104, 121)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(284, 20)
        Me.txtmail.TabIndex = 19
        '
        'btnagrega
        '
        Me.btnagrega.Location = New System.Drawing.Point(12, 160)
        Me.btnagrega.Name = "btnagrega"
        Me.btnagrega.Size = New System.Drawing.Size(96, 29)
        Me.btnagrega.TabIndex = 20
        Me.btnagrega.Text = "+ Variedad"
        Me.btnagrega.UseVisualStyleBackColor = True
        '
        'btnquita
        '
        Me.btnquita.Location = New System.Drawing.Point(114, 160)
        Me.btnquita.Name = "btnquita"
        Me.btnquita.Size = New System.Drawing.Size(96, 29)
        Me.btnquita.TabIndex = 21
        Me.btnquita.Text = "- Variedad"
        Me.btnquita.UseVisualStyleBackColor = True
        '
        'btnanular
        '
        Me.btnanular.BackColor = System.Drawing.Color.Red
        Me.btnanular.ForeColor = System.Drawing.Color.White
        Me.btnanular.Location = New System.Drawing.Point(666, 97)
        Me.btnanular.Name = "btnanular"
        Me.btnanular.Size = New System.Drawing.Size(153, 46)
        Me.btnanular.TabIndex = 22
        Me.btnanular.Text = "Anular Contrato"
        Me.btnanular.UseVisualStyleBackColor = False
        '
        'btnsectores
        '
        Me.btnsectores.Location = New System.Drawing.Point(347, 160)
        Me.btnsectores.Name = "btnsectores"
        Me.btnsectores.Size = New System.Drawing.Size(197, 29)
        Me.btnsectores.TabIndex = 23
        Me.btnsectores.Text = "Sectores y Cuarteles del Contrato"
        Me.btnsectores.UseVisualStyleBackColor = True
        '
        'frmContratosVendimia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 529)
        Me.Controls.Add(Me.btnsectores)
        Me.Controls.Add(Me.btnanular)
        Me.Controls.Add(Me.btnquita)
        Me.Controls.Add(Me.btnagrega)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtreplegal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtidproductor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtnomproductor)
        Me.Controls.Add(Me.txtrutproductor)
        Me.Controls.Add(Me.txtnumcontrato)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContratosVendimia"
        Me.Text = "Contratos Vendimia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtnumcontrato As TextBox
    Friend WithEvents txtnomproductor As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrutproductor As TextBox
    Friend WithEvents txtidproductor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtreplegal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents btnagrega As Button
    Friend WithEvents btnquita As Button
    Friend WithEvents btnanular As Button
    Friend WithEvents btnsectores As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreaPesajeVendimia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreaPesajeVendimia))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.txttipovehiculo = New System.Windows.Forms.TextBox()
        Me.txttransportista = New System.Windows.Forms.TextBox()
        Me.txttipoenvase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtidvehiculo = New System.Windows.Forms.TextBox()
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcanenvases = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.Location = New System.Drawing.Point(242, 224)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(92, 41)
        Me.btncerrar.TabIndex = 48
        Me.btncerrar.Text = "Cancelar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.Location = New System.Drawing.Point(129, 224)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 41)
        Me.btnguardar.TabIndex = 47
        Me.btnguardar.Text = "Aceptar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txttara
        '
        Me.txttara.Enabled = False
        Me.txttara.Location = New System.Drawing.Point(118, 163)
        Me.txttara.Name = "txttara"
        Me.txttara.Size = New System.Drawing.Size(122, 20)
        Me.txttara.TabIndex = 46
        '
        'txttipovehiculo
        '
        Me.txttipovehiculo.Enabled = False
        Me.txttipovehiculo.Location = New System.Drawing.Point(118, 111)
        Me.txttipovehiculo.Name = "txttipovehiculo"
        Me.txttipovehiculo.Size = New System.Drawing.Size(282, 20)
        Me.txttipovehiculo.TabIndex = 45
        '
        'txttransportista
        '
        Me.txttransportista.Enabled = False
        Me.txttransportista.Location = New System.Drawing.Point(118, 85)
        Me.txttransportista.Name = "txttransportista"
        Me.txttransportista.Size = New System.Drawing.Size(282, 20)
        Me.txttransportista.TabIndex = 44
        '
        'txttipoenvase
        '
        Me.txttipoenvase.Enabled = False
        Me.txttipoenvase.Location = New System.Drawing.Point(118, 137)
        Me.txttipoenvase.Name = "txttipoenvase"
        Me.txttipoenvase.Size = New System.Drawing.Size(122, 20)
        Me.txttipoenvase.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Tara:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Tipo Vehículo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Transportista:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Tipo Envases"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidvehiculo
        '
        Me.txtidvehiculo.AcceptsReturn = True
        Me.txtidvehiculo.Enabled = False
        Me.txtidvehiculo.Location = New System.Drawing.Point(118, 59)
        Me.txtidvehiculo.Name = "txtidvehiculo"
        Me.txtidvehiculo.Size = New System.Drawing.Size(53, 20)
        Me.txtidvehiculo.TabIndex = 37
        '
        'txtpatente
        '
        Me.txtpatente.Enabled = False
        Me.txtpatente.Location = New System.Drawing.Point(177, 59)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(122, 20)
        Me.txtpatente.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Patente:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(115, 29)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 34
        Me.lblfecha.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Cantidad Envases"
        '
        'txtcanenvases
        '
        Me.txtcanenvases.Location = New System.Drawing.Point(338, 137)
        Me.txtcanenvases.Name = "txtcanenvases"
        Me.txtcanenvases.Size = New System.Drawing.Size(62, 20)
        Me.txtcanenvases.TabIndex = 50
        '
        'frmCreaPesajeVendimia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 287)
        Me.Controls.Add(Me.txtcanenvases)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txttara)
        Me.Controls.Add(Me.txttipovehiculo)
        Me.Controls.Add(Me.txttransportista)
        Me.Controls.Add(Me.txttipoenvase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtidvehiculo)
        Me.Controls.Add(Me.txtpatente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreaPesajeVendimia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Pesaje Vendimia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txttara As TextBox
    Friend WithEvents txttipovehiculo As TextBox
    Friend WithEvents txttransportista As TextBox
    Friend WithEvents txttipoenvase As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtidvehiculo As TextBox
    Friend WithEvents txtpatente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcanenvases As TextBox
End Class

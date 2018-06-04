<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcreapesajedestareM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcreapesajedestareM))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.txttipovehiculo = New System.Windows.Forms.TextBox()
        Me.txttransportista = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.Location = New System.Drawing.Point(308, 235)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(92, 41)
        Me.btncerrar.TabIndex = 32
        Me.btncerrar.Text = "Cancelar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.Location = New System.Drawing.Point(158, 235)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 41)
        Me.btnguardar.TabIndex = 31
        Me.btnguardar.Text = "Aceptar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txttara
        '
        Me.txttara.Enabled = False
        Me.txttara.Location = New System.Drawing.Point(158, 190)
        Me.txttara.Name = "txttara"
        Me.txttara.Size = New System.Drawing.Size(122, 20)
        Me.txttara.TabIndex = 30
        '
        'txttipovehiculo
        '
        Me.txttipovehiculo.Enabled = False
        Me.txttipovehiculo.Location = New System.Drawing.Point(158, 156)
        Me.txttipovehiculo.Name = "txttipovehiculo"
        Me.txttipovehiculo.Size = New System.Drawing.Size(261, 20)
        Me.txttipovehiculo.TabIndex = 29
        '
        'txttransportista
        '
        Me.txttransportista.Enabled = False
        Me.txttransportista.Location = New System.Drawing.Point(158, 123)
        Me.txttransportista.Name = "txttransportista"
        Me.txttransportista.Size = New System.Drawing.Size(261, 20)
        Me.txttransportista.TabIndex = 28
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Location = New System.Drawing.Point(158, 87)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(261, 20)
        Me.txtmarca.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tara:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tipo Vehículo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Transportista:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Marca:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidvehiculo
        '
        Me.txtidvehiculo.AcceptsReturn = True
        Me.txtidvehiculo.Enabled = False
        Me.txtidvehiculo.Location = New System.Drawing.Point(159, 55)
        Me.txtidvehiculo.Name = "txtidvehiculo"
        Me.txtidvehiculo.Size = New System.Drawing.Size(53, 20)
        Me.txtidvehiculo.TabIndex = 21
        '
        'txtpatente
        '
        Me.txtpatente.Enabled = False
        Me.txtpatente.Location = New System.Drawing.Point(218, 55)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(122, 20)
        Me.txtpatente.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Patente:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(156, 25)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 18
        Me.lblfecha.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha:"
        '
        'frmcreapesajedestareM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 298)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txttara)
        Me.Controls.Add(Me.txttipovehiculo)
        Me.Controls.Add(Me.txttransportista)
        Me.Controls.Add(Me.txtmarca)
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
        Me.Name = "frmcreapesajedestareM"
        Me.Text = "Crear Pesaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txttara As TextBox
    Friend WithEvents txttipovehiculo As TextBox
    Friend WithEvents txttransportista As TextBox
    Friend WithEvents txtmarca As TextBox
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
End Class

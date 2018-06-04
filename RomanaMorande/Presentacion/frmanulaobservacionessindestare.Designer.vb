<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmanulaobservacionessindestare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmanulaobservacionessindestare))
        Me.txtpatente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumpesaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnanular = New System.Windows.Forms.Button()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtpatente
        '
        Me.txtpatente.Enabled = False
        Me.txtpatente.Location = New System.Drawing.Point(369, 9)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.Size = New System.Drawing.Size(140, 20)
        Me.txtpatente.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patente"
        '
        'txtnumpesaje
        '
        Me.txtnumpesaje.Enabled = False
        Me.txtnumpesaje.Location = New System.Drawing.Point(88, 9)
        Me.txtnumpesaje.Name = "txtnumpesaje"
        Me.txtnumpesaje.Size = New System.Drawing.Size(140, 20)
        Me.txtnumpesaje.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "N°Pesaje"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(443, 229)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(113, 37)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnanular
        '
        Me.btnanular.Location = New System.Drawing.Point(325, 229)
        Me.btnanular.Name = "btnanular"
        Me.btnanular.Size = New System.Drawing.Size(114, 37)
        Me.btnanular.TabIndex = 8
        Me.btnanular.Text = "Anular"
        Me.btnanular.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(26, 68)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservaciones.Size = New System.Drawing.Size(530, 155)
        Me.txtobservaciones.TabIndex = 7
        Me.txtobservaciones.Text = "ANULADO POR: "
        '
        'frmanulaobservacionessindestare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 278)
        Me.Controls.Add(Me.txtpatente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnumpesaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnanular)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmanulaobservacionessindestare"
        Me.Text = "Observaciones Anula Pesaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpatente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumpesaje As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnanular As Button
    Friend WithEvents txtobservaciones As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeleccionTipoEnvase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionTipoEnvase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidenvase = New System.Windows.Forms.TextBox()
        Me.txtnomenvase = New System.Windows.Forms.TextBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcantenv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.txtkgenv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo Envase y Cantidad"
        '
        'txtidenvase
        '
        Me.txtidenvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidenvase.Location = New System.Drawing.Point(12, 76)
        Me.txtidenvase.Name = "txtidenvase"
        Me.txtidenvase.Size = New System.Drawing.Size(92, 53)
        Me.txtidenvase.TabIndex = 5
        Me.txtidenvase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnomenvase
        '
        Me.txtnomenvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomenvase.Location = New System.Drawing.Point(107, 76)
        Me.txtnomenvase.Name = "txtnomenvase"
        Me.txtnomenvase.Size = New System.Drawing.Size(367, 53)
        Me.txtnomenvase.TabIndex = 6
        '
        'txtflag
        '
        Me.txtflag.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtflag.Location = New System.Drawing.Point(13, 157)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(56, 53)
        Me.txtflag.TabIndex = 7
        Me.txtflag.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(479, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcantenv
        '
        Me.txtcantenv.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantenv.Location = New System.Drawing.Point(547, 76)
        Me.txtcantenv.Name = "txtcantenv"
        Me.txtcantenv.Size = New System.Drawing.Size(132, 53)
        Me.txtcantenv.TabIndex = 9
        Me.txtcantenv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo Envase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(562, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(241, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(268, 107)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Listo!"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Flag1"
        Me.Label4.Visible = False
        '
        'txtflag2
        '
        Me.txtflag2.Enabled = False
        Me.txtflag2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtflag2.Location = New System.Drawing.Point(90, 157)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(32, 53)
        Me.txtflag2.TabIndex = 14
        Me.txtflag2.Text = "1"
        Me.txtflag2.Visible = False
        '
        'txtkgenv
        '
        Me.txtkgenv.Enabled = False
        Me.txtkgenv.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkgenv.Location = New System.Drawing.Point(547, 170)
        Me.txtkgenv.Name = "txtkgenv"
        Me.txtkgenv.Size = New System.Drawing.Size(132, 53)
        Me.txtkgenv.TabIndex = 15
        Me.txtkgenv.Text = "0"
        Me.txtkgenv.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(542, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Kilos Envase"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Flag2"
        Me.Label6.Visible = False
        '
        'frmSeleccionTipoEnvase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 261)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtkgenv)
        Me.Controls.Add(Me.txtflag2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcantenv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.txtnomenvase)
        Me.Controls.Add(Me.txtidenvase)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeleccionTipoEnvase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Tipo Envase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtidenvase As TextBox
    Friend WithEvents txtnomenvase As TextBox
    Friend WithEvents txtflag As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcantenv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtflag2 As TextBox
    Friend WithEvents txtkgenv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

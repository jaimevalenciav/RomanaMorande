<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransportistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatentesVehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDePesajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaBaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalidadesUvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariedadesUvaEnSAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RomanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeAutomáticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeSinDestareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeManualRequiereClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeNormalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeSinDestareToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendimiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeAutomáticoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeEnvasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaDeEnvasesAProductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaSaldoDeEnvasesXProductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajesPorPatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajesVendimiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.BodegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(992, 504)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.DefinicionesToolStripMenuItem, Me.RomanaToolStripMenuItem, Me.VendimiaToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1132, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DefinicionesToolStripMenuItem
        '
        Me.DefinicionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoVehiculosToolStripMenuItem, Me.TransportistasToolStripMenuItem, Me.PatentesVehículosToolStripMenuItem, Me.TipoDePesajeToolStripMenuItem, Me.MaestrosToolStripMenuItem})
        Me.DefinicionesToolStripMenuItem.Name = "DefinicionesToolStripMenuItem"
        Me.DefinicionesToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.DefinicionesToolStripMenuItem.Text = "Definiciones"
        '
        'TipoVehiculosToolStripMenuItem
        '
        Me.TipoVehiculosToolStripMenuItem.Image = CType(resources.GetObject("TipoVehiculosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoVehiculosToolStripMenuItem.Name = "TipoVehiculosToolStripMenuItem"
        Me.TipoVehiculosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoVehiculosToolStripMenuItem.Text = "Tipo Vehículos"
        '
        'TransportistasToolStripMenuItem
        '
        Me.TransportistasToolStripMenuItem.Image = CType(resources.GetObject("TransportistasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransportistasToolStripMenuItem.Name = "TransportistasToolStripMenuItem"
        Me.TransportistasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TransportistasToolStripMenuItem.Text = "Transportistas"
        '
        'PatentesVehículosToolStripMenuItem
        '
        Me.PatentesVehículosToolStripMenuItem.Image = CType(resources.GetObject("PatentesVehículosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PatentesVehículosToolStripMenuItem.Name = "PatentesVehículosToolStripMenuItem"
        Me.PatentesVehículosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PatentesVehículosToolStripMenuItem.Text = "Patentes Vehículos"
        '
        'TipoDePesajeToolStripMenuItem
        '
        Me.TipoDePesajeToolStripMenuItem.Image = CType(resources.GetObject("TipoDePesajeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoDePesajeToolStripMenuItem.Name = "TipoDePesajeToolStripMenuItem"
        Me.TipoDePesajeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TipoDePesajeToolStripMenuItem.Text = "Tipos de Pesaje"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnvasesToolStripMenuItem, Me.TablaBaToolStripMenuItem, Me.CalidadesUvaToolStripMenuItem, Me.ContratosToolStripMenuItem, Me.VariedadesUvaEnSAPToolStripMenuItem, Me.BodegasToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Image = CType(resources.GetObject("MaestrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MaestrosToolStripMenuItem.Text = "Maestros Vendimia"
        '
        'EnvasesToolStripMenuItem
        '
        Me.EnvasesToolStripMenuItem.Image = CType(resources.GetObject("EnvasesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnvasesToolStripMenuItem.Name = "EnvasesToolStripMenuItem"
        Me.EnvasesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EnvasesToolStripMenuItem.Text = "Envases"
        '
        'TablaBaToolStripMenuItem
        '
        Me.TablaBaToolStripMenuItem.Image = CType(resources.GetObject("TablaBaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TablaBaToolStripMenuItem.Name = "TablaBaToolStripMenuItem"
        Me.TablaBaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.TablaBaToolStripMenuItem.Text = "Tabla Baumé"
        '
        'CalidadesUvaToolStripMenuItem
        '
        Me.CalidadesUvaToolStripMenuItem.Image = CType(resources.GetObject("CalidadesUvaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalidadesUvaToolStripMenuItem.Name = "CalidadesUvaToolStripMenuItem"
        Me.CalidadesUvaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CalidadesUvaToolStripMenuItem.Text = "Calidades Uva"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Image = CType(resources.GetObject("ContratosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'VariedadesUvaEnSAPToolStripMenuItem
        '
        Me.VariedadesUvaEnSAPToolStripMenuItem.Image = CType(resources.GetObject("VariedadesUvaEnSAPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VariedadesUvaEnSAPToolStripMenuItem.Name = "VariedadesUvaEnSAPToolStripMenuItem"
        Me.VariedadesUvaEnSAPToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VariedadesUvaEnSAPToolStripMenuItem.Text = "Variedades Uva en SAP"
        '
        'RomanaToolStripMenuItem
        '
        Me.RomanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesajeAutomáticoToolStripMenuItem, Me.PesajeManualRequiereClaveToolStripMenuItem})
        Me.RomanaToolStripMenuItem.Name = "RomanaToolStripMenuItem"
        Me.RomanaToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.RomanaToolStripMenuItem.Text = "Romana"
        '
        'PesajeAutomáticoToolStripMenuItem
        '
        Me.PesajeAutomáticoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesajeNormalToolStripMenuItem, Me.PesajeSinDestareToolStripMenuItem})
        Me.PesajeAutomáticoToolStripMenuItem.Image = CType(resources.GetObject("PesajeAutomáticoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajeAutomáticoToolStripMenuItem.Name = "PesajeAutomáticoToolStripMenuItem"
        Me.PesajeAutomáticoToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.PesajeAutomáticoToolStripMenuItem.Text = "Pesaje Automático"
        '
        'PesajeNormalToolStripMenuItem
        '
        Me.PesajeNormalToolStripMenuItem.Image = CType(resources.GetObject("PesajeNormalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajeNormalToolStripMenuItem.Name = "PesajeNormalToolStripMenuItem"
        Me.PesajeNormalToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PesajeNormalToolStripMenuItem.Text = "Pesaje Normal"
        '
        'PesajeSinDestareToolStripMenuItem
        '
        Me.PesajeSinDestareToolStripMenuItem.Image = CType(resources.GetObject("PesajeSinDestareToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajeSinDestareToolStripMenuItem.Name = "PesajeSinDestareToolStripMenuItem"
        Me.PesajeSinDestareToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PesajeSinDestareToolStripMenuItem.Text = "Pesaje Sin Destare"
        '
        'PesajeManualRequiereClaveToolStripMenuItem
        '
        Me.PesajeManualRequiereClaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesajeNormalToolStripMenuItem1, Me.PesajeSinDestareToolStripMenuItem1})
        Me.PesajeManualRequiereClaveToolStripMenuItem.Image = CType(resources.GetObject("PesajeManualRequiereClaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajeManualRequiereClaveToolStripMenuItem.Name = "PesajeManualRequiereClaveToolStripMenuItem"
        Me.PesajeManualRequiereClaveToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.PesajeManualRequiereClaveToolStripMenuItem.Text = "Pesaje Manual (Requiere Clave)"
        '
        'PesajeNormalToolStripMenuItem1
        '
        Me.PesajeNormalToolStripMenuItem1.Image = CType(resources.GetObject("PesajeNormalToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PesajeNormalToolStripMenuItem1.Name = "PesajeNormalToolStripMenuItem1"
        Me.PesajeNormalToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.PesajeNormalToolStripMenuItem1.Text = "Pesaje Normal"
        '
        'PesajeSinDestareToolStripMenuItem1
        '
        Me.PesajeSinDestareToolStripMenuItem1.Image = CType(resources.GetObject("PesajeSinDestareToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PesajeSinDestareToolStripMenuItem1.Name = "PesajeSinDestareToolStripMenuItem1"
        Me.PesajeSinDestareToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.PesajeSinDestareToolStripMenuItem1.Text = "Pesaje Sin Destare"
        '
        'VendimiaToolStripMenuItem
        '
        Me.VendimiaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesajeAutomáticoToolStripMenuItem1, Me.PesajeManualToolStripMenuItem, Me.ControlDeEnvasesToolStripMenuItem})
        Me.VendimiaToolStripMenuItem.Name = "VendimiaToolStripMenuItem"
        Me.VendimiaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.VendimiaToolStripMenuItem.Text = "Vendimia"
        '
        'PesajeAutomáticoToolStripMenuItem1
        '
        Me.PesajeAutomáticoToolStripMenuItem1.Image = CType(resources.GetObject("PesajeAutomáticoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PesajeAutomáticoToolStripMenuItem1.Name = "PesajeAutomáticoToolStripMenuItem1"
        Me.PesajeAutomáticoToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.PesajeAutomáticoToolStripMenuItem1.Text = "Pesaje Uva Vinífera"
        '
        'PesajeManualToolStripMenuItem
        '
        Me.PesajeManualToolStripMenuItem.Image = CType(resources.GetObject("PesajeManualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajeManualToolStripMenuItem.Name = "PesajeManualToolStripMenuItem"
        Me.PesajeManualToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PesajeManualToolStripMenuItem.Text = "Pesaje Manual"
        '
        'ControlDeEnvasesToolStripMenuItem
        '
        Me.ControlDeEnvasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregaDeEnvasesAProductorToolStripMenuItem, Me.ConsultaSaldoDeEnvasesXProductorToolStripMenuItem})
        Me.ControlDeEnvasesToolStripMenuItem.Image = CType(resources.GetObject("ControlDeEnvasesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControlDeEnvasesToolStripMenuItem.Name = "ControlDeEnvasesToolStripMenuItem"
        Me.ControlDeEnvasesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ControlDeEnvasesToolStripMenuItem.Text = "Control de Envases"
        '
        'EntregaDeEnvasesAProductorToolStripMenuItem
        '
        Me.EntregaDeEnvasesAProductorToolStripMenuItem.Name = "EntregaDeEnvasesAProductorToolStripMenuItem"
        Me.EntregaDeEnvasesAProductorToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.EntregaDeEnvasesAProductorToolStripMenuItem.Text = "Entrega de Envases a Productor"
        '
        'ConsultaSaldoDeEnvasesXProductorToolStripMenuItem
        '
        Me.ConsultaSaldoDeEnvasesXProductorToolStripMenuItem.Name = "ConsultaSaldoDeEnvasesXProductorToolStripMenuItem"
        Me.ConsultaSaldoDeEnvasesXProductorToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ConsultaSaldoDeEnvasesXProductorToolStripMenuItem.Text = "Consulta Saldo de Envases x Productor"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesajesPorPatenteToolStripMenuItem, Me.PesajesVendimiaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PesajesPorPatenteToolStripMenuItem
        '
        Me.PesajesPorPatenteToolStripMenuItem.Image = CType(resources.GetObject("PesajesPorPatenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajesPorPatenteToolStripMenuItem.Name = "PesajesPorPatenteToolStripMenuItem"
        Me.PesajesPorPatenteToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PesajesPorPatenteToolStripMenuItem.Text = "Pesajes por Patente"
        '
        'PesajesVendimiaToolStripMenuItem
        '
        Me.PesajesVendimiaToolStripMenuItem.Image = CType(resources.GetObject("PesajesVendimiaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PesajesVendimiaToolStripMenuItem.Name = "PesajesVendimiaToolStripMenuItem"
        Me.PesajesVendimiaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PesajesVendimiaToolStripMenuItem.Text = "Pesajes Vendimia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(955, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(1007, 76)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(39, 13)
        Me.lbluser.TabIndex = 3
        Me.lbluser.Text = "Label2"
        '
        'BodegasToolStripMenuItem
        '
        Me.BodegasToolStripMenuItem.Image = CType(resources.GetObject("BodegasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BodegasToolStripMenuItem.Name = "BodegasToolStripMenuItem"
        Me.BodegasToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BodegasToolStripMenuItem.Text = "Bodegas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 553)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Pesaje de Camiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefinicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoVehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransportistasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatentesVehículosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDePesajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RomanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeAutomáticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeNormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeSinDestareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeManualRequiereClaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeNormalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PesajeSinDestareToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajesPorPatenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents VendimiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajeAutomáticoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PesajeManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeEnvasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaDeEnvasesAProductorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaSaldoDeEnvasesXProductorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesajesVendimiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablaBaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalidadesUvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VariedadesUvaEnSAPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BodegasToolStripMenuItem As ToolStripMenuItem
End Class

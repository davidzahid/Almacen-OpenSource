<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Entradas = New System.Windows.Forms.ToolStripMenuItem()
        Me.entradaProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.entregasAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.salidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.salidasProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.salidasAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.proveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.proveedoresDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.empleadosDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportesProduccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportesAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.verAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.acercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.EntradasToolStripMenuItem, Me.Ayuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Entradas, Me.salidas, Me.proveedores, Me.empleados, Me.reportes})
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.EntradasToolStripMenuItem.Text = "Operaciones"
        '
        'Entradas
        '
        Me.Entradas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.entradaProduccion, Me.entregasAlmacen})
        Me.Entradas.Name = "Entradas"
        Me.Entradas.Size = New System.Drawing.Size(139, 22)
        Me.Entradas.Text = "Entradas"
        '
        'entradaProduccion
        '
        Me.entradaProduccion.Name = "entradaProduccion"
        Me.entradaProduccion.Size = New System.Drawing.Size(135, 22)
        Me.entradaProduccion.Text = "Producción"
        '
        'entregasAlmacen
        '
        Me.entregasAlmacen.Name = "entregasAlmacen"
        Me.entregasAlmacen.Size = New System.Drawing.Size(135, 22)
        Me.entregasAlmacen.Text = "Almacen"
        '
        'salidas
        '
        Me.salidas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.salidasProduccion, Me.salidasAlmacen})
        Me.salidas.Name = "salidas"
        Me.salidas.Size = New System.Drawing.Size(139, 22)
        Me.salidas.Text = "Salidas"
        '
        'salidasProduccion
        '
        Me.salidasProduccion.Name = "salidasProduccion"
        Me.salidasProduccion.Size = New System.Drawing.Size(135, 22)
        Me.salidasProduccion.Text = "Producción"
        '
        'salidasAlmacen
        '
        Me.salidasAlmacen.Name = "salidasAlmacen"
        Me.salidasAlmacen.Size = New System.Drawing.Size(135, 22)
        Me.salidasAlmacen.Text = "Almacen"
        '
        'proveedores
        '
        Me.proveedores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.proveedoresDetalle})
        Me.proveedores.Name = "proveedores"
        Me.proveedores.Size = New System.Drawing.Size(139, 22)
        Me.proveedores.Text = "Proveedores"
        '
        'proveedoresDetalle
        '
        Me.proveedoresDetalle.Name = "proveedoresDetalle"
        Me.proveedoresDetalle.Size = New System.Drawing.Size(194, 22)
        Me.proveedoresDetalle.Text = "Detalle de Proveedores"
        '
        'empleados
        '
        Me.empleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.empleadosDetalle})
        Me.empleados.Name = "empleados"
        Me.empleados.Size = New System.Drawing.Size(139, 22)
        Me.empleados.Text = "Empleados"
        '
        'empleadosDetalle
        '
        Me.empleadosDetalle.Name = "empleadosDetalle"
        Me.empleadosDetalle.Size = New System.Drawing.Size(192, 22)
        Me.empleadosDetalle.Text = "Detalles de Empleados"
        '
        'reportes
        '
        Me.reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.reportesProduccion, Me.reportesAlmacen})
        Me.reportes.Name = "reportes"
        Me.reportes.Size = New System.Drawing.Size(139, 22)
        Me.reportes.Text = "Reportes"
        '
        'reportesProduccion
        '
        Me.reportesProduccion.Name = "reportesProduccion"
        Me.reportesProduccion.Size = New System.Drawing.Size(135, 22)
        Me.reportesProduccion.Text = "Producción"
        '
        'reportesAlmacen
        '
        Me.reportesAlmacen.Name = "reportesAlmacen"
        Me.reportesAlmacen.Size = New System.Drawing.Size(135, 22)
        Me.reportesAlmacen.Text = "Almacen"
        '
        'Ayuda
        '
        Me.Ayuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.verAyuda, Me.acercaDe})
        Me.Ayuda.Name = "Ayuda"
        Me.Ayuda.Size = New System.Drawing.Size(53, 20)
        Me.Ayuda.Text = "Ayuda"
        '
        'verAyuda
        '
        Me.verAyuda.Name = "verAyuda"
        Me.verAyuda.Size = New System.Drawing.Size(140, 22)
        Me.verAyuda.Text = "Ver la Ayuda"
        '
        'acercaDe
        '
        Me.acercaDe.Name = "acercaDe"
        Me.acercaDe.Size = New System.Drawing.Size(140, 22)
        Me.acercaDe.Text = "Acerca de"
        '
        'Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 459)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Panel"
        Me.Text = "Panel de Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Entradas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents verAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents acercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents entradaProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents entregasAlmacen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salidasProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salidasAlmacen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents proveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents proveedoresDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empleadosDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reportesProduccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reportesAlmacen As System.Windows.Forms.ToolStripMenuItem

End Class

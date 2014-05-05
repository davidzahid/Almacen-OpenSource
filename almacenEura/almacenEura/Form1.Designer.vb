<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.AlmaceneuraDataSet = New almacenEura.almaceneuraDataSet()
        Me.EntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasTableAdapter = New almacenEura.almaceneuraDataSetTableAdapters.entradasTableAdapter()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmaceneuraDataSet1 = New almacenEura.almaceneuraDataSet1()
        Me.EmpleadosTableAdapter = New almacenEura.almaceneuraDataSet1TableAdapters.empleadosTableAdapter()
        CType(Me.AlmaceneuraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmaceneuraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmaceneuraDataSet
        '
        Me.AlmaceneuraDataSet.DataSetName = "almaceneuraDataSet"
        Me.AlmaceneuraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EntradasBindingSource
        '
        Me.EntradasBindingSource.DataMember = "entradas"
        Me.EntradasBindingSource.DataSource = Me.AlmaceneuraDataSet
        '
        'EntradasTableAdapter
        '
        Me.EntradasTableAdapter.ClearBeforeFill = True
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(almacenEura.Form1)
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpleadosBindingSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(200, 192)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.AlmaceneuraDataSet1
        '
        'AlmaceneuraDataSet1
        '
        Me.AlmaceneuraDataSet1.DataSetName = "almaceneuraDataSet1"
        Me.AlmaceneuraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 443)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AlmaceneuraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmaceneuraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Form1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlmaceneuraDataSet As almacenEura.almaceneuraDataSet
    Friend WithEvents EntradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradasTableAdapter As almacenEura.almaceneuraDataSetTableAdapters.entradasTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AlmaceneuraDataSet1 As almacenEura.almaceneuraDataSet1
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As almacenEura.almaceneuraDataSet1TableAdapters.empleadosTableAdapter

End Class

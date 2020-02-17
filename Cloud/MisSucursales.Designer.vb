<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MisSucursales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboSucursal = New System.Windows.Forms.ComboBox()
        Me.ClientessucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSet = New sgcomercial.siscomDataSet()
        Me.ClientessucursalesTableAdapter = New sgcomercial.siscomDataSetTableAdapters.clientessucursalesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboInforme = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientessucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComboInforme)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboSucursal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sucursal:"
        '
        'ComboSucursal
        '
        Me.ComboSucursal.DataSource = Me.ClientessucursalesBindingSource
        Me.ComboSucursal.DisplayMember = "nombre"
        Me.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.Location = New System.Drawing.Point(40, 54)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(257, 24)
        Me.ComboSucursal.TabIndex = 0
        Me.ComboSucursal.ValueMember = "idsucursal"
        '
        'ClientessucursalesBindingSource
        '
        Me.ClientessucursalesBindingSource.DataMember = "clientessucursales"
        Me.ClientessucursalesBindingSource.DataSource = Me.SiscomDataSet
        '
        'SiscomDataSet
        '
        Me.SiscomDataSet.DataSetName = "siscomDataSet"
        Me.SiscomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientessucursalesTableAdapter
        '
        Me.ClientessucursalesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Informe:"
        '
        'ComboInforme
        '
        Me.ComboInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboInforme.FormattingEnabled = True
        Me.ComboInforme.Items.AddRange(New Object() {"Libro Ventas", "Stock General"})
        Me.ComboInforme.Location = New System.Drawing.Point(319, 54)
        Me.ComboInforme.Name = "ComboInforme"
        Me.ComboInforme.Size = New System.Drawing.Size(289, 24)
        Me.ComboInforme.TabIndex = 3
        '
        'MisSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 144)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MisSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MisSucursales"
        Me.Text = "Mis Sucursales en la Nube"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientessucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboSucursal As ComboBox
    Friend WithEvents SiscomDataSet As siscomDataSet
    Friend WithEvents ClientessucursalesBindingSource As BindingSource
    Friend WithEvents ClientessucursalesTableAdapter As siscomDataSetTableAdapters.clientessucursalesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboInforme As ComboBox
    Friend WithEvents Label2 As Label
End Class

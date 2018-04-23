<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizacionPrecios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizacionPrecios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListamarcasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ListamarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListamarcasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listamarcasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ListarubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListarubrosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listarubrosTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.RubrosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListamarcasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListamarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListarubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ListamarcasDataGridView)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(370, 338)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Restar (-)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aplicar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(264, 337)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 27)
        Me.TextBox1.TabIndex = 5
        '
        'ListamarcasDataGridView
        '
        Me.ListamarcasDataGridView.AllowUserToAddRows = False
        Me.ListamarcasDataGridView.AllowUserToDeleteRows = False
        Me.ListamarcasDataGridView.AllowUserToResizeRows = False
        Me.ListamarcasDataGridView.AutoGenerateColumns = False
        Me.ListamarcasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListamarcasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarcaDataGridViewTextBoxColumn})
        Me.ListamarcasDataGridView.DataSource = Me.ListamarcasBindingSource
        Me.ListamarcasDataGridView.Location = New System.Drawing.Point(15, 74)
        Me.ListamarcasDataGridView.MultiSelect = False
        Me.ListamarcasDataGridView.Name = "ListamarcasDataGridView"
        Me.ListamarcasDataGridView.ReadOnly = True
        Me.ListamarcasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ListamarcasDataGridView.RowTemplate.Height = 24
        Me.ListamarcasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListamarcasDataGridView.Size = New System.Drawing.Size(437, 220)
        Me.ListamarcasDataGridView.TabIndex = 4
        '
        'ListamarcasBindingSource
        '
        Me.ListamarcasBindingSource.DataMember = "listamarcas"
        Me.ListamarcasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Marca", "Rubro"})
        Me.ComboBox2.Location = New System.Drawing.Point(15, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Productos por"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio por"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Porcentaje", "Monto fijo"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 338)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn12})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(6, 21)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(709, 409)
        Me.ProductosDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.RubrosBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rubro"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "idrubro"
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "rubros"
        Me.RubrosBindingSource.DataSource = Me.ComercialDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Presentación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Precio venta"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(526, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(721, 436)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'ListamarcasTableAdapter
        '
        Me.ListamarcasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ListarubrosBindingSource
        '
        Me.ListarubrosBindingSource.DataMember = "listarubros"
        Me.ListarubrosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListarubrosTableAdapter
        '
        Me.ListarubrosTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'RubrosTableAdapter
        '
        Me.RubrosTableAdapter.ClearBeforeFill = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActualizacionPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 454)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ActualizacionPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de precios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListamarcasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListamarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListarubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListamarcasBindingSource As BindingSource
    Friend WithEvents ListamarcasTableAdapter As comercialDataSetTableAdapters.listamarcasTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListamarcasDataGridView As DataGridView
    Friend WithEvents ListarubrosBindingSource As BindingSource
    Friend WithEvents ListarubrosTableAdapter As comercialDataSetTableAdapters.listarubrosTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RubrosBindingSource As BindingSource
    Friend WithEvents RubrosTableAdapter As comercialDataSetTableAdapters.rubrosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

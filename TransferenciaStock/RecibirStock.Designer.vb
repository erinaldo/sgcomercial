<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibirStock
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RemitosdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdremitodetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdremitoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadmedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventamayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventagranelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadmedida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciocosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventamayorista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventagranel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdremitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiporemitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechabajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariocargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.sucursalesTableAdapter()
        Me.RemitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.remitosTableAdapter()
        Me.RemitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.remitosdetalleTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RemitosdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 564)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(817, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Finalizar Recepción"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(316, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 30)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Confirmar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemitosdetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.DataGridViewProductos)
        Me.GroupBox2.Controls.Add(Me.RemitosDataGridView)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(817, 436)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mercaderías"
        '
        'RemitosdetalleDataGridView
        '
        Me.RemitosdetalleDataGridView.AllowUserToAddRows = False
        Me.RemitosdetalleDataGridView.AllowUserToDeleteRows = False
        Me.RemitosdetalleDataGridView.AutoGenerateColumns = False
        Me.RemitosdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemitosdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdremitodetalleDataGridViewTextBoxColumn, Me.IdremitoDataGridViewTextBoxColumn1, Me.IdproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.UnidadmedidaDataGridViewTextBoxColumn, Me.MedidaDataGridViewTextBoxColumn, Me.CodigoproductoDataGridViewTextBoxColumn, Me.PreciocostoDataGridViewTextBoxColumn, Me.PrecioventaDataGridViewTextBoxColumn, Me.PrecioventamayoristaDataGridViewTextBoxColumn, Me.PrecioventagranelDataGridViewTextBoxColumn})
        Me.RemitosdetalleDataGridView.DataSource = Me.RemitosdetalleBindingSource
        Me.RemitosdetalleDataGridView.Location = New System.Drawing.Point(564, 21)
        Me.RemitosdetalleDataGridView.Name = "RemitosdetalleDataGridView"
        Me.RemitosdetalleDataGridView.ReadOnly = True
        Me.RemitosdetalleDataGridView.RowTemplate.Height = 24
        Me.RemitosdetalleDataGridView.Size = New System.Drawing.Size(32, 23)
        Me.RemitosdetalleDataGridView.TabIndex = 4
        Me.RemitosdetalleDataGridView.Visible = False
        '
        'IdremitodetalleDataGridViewTextBoxColumn
        '
        Me.IdremitodetalleDataGridViewTextBoxColumn.DataPropertyName = "idremitodetalle"
        Me.IdremitodetalleDataGridViewTextBoxColumn.HeaderText = "idremitodetalle"
        Me.IdremitodetalleDataGridViewTextBoxColumn.Name = "IdremitodetalleDataGridViewTextBoxColumn"
        Me.IdremitodetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdremitoDataGridViewTextBoxColumn1
        '
        Me.IdremitoDataGridViewTextBoxColumn1.DataPropertyName = "idremito"
        Me.IdremitoDataGridViewTextBoxColumn1.HeaderText = "idremito"
        Me.IdremitoDataGridViewTextBoxColumn1.Name = "IdremitoDataGridViewTextBoxColumn1"
        Me.IdremitoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadmedidaDataGridViewTextBoxColumn
        '
        Me.UnidadmedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadmedida"
        Me.UnidadmedidaDataGridViewTextBoxColumn.HeaderText = "unidadmedida"
        Me.UnidadmedidaDataGridViewTextBoxColumn.Name = "UnidadmedidaDataGridViewTextBoxColumn"
        Me.UnidadmedidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedidaDataGridViewTextBoxColumn
        '
        Me.MedidaDataGridViewTextBoxColumn.DataPropertyName = "medida"
        Me.MedidaDataGridViewTextBoxColumn.HeaderText = "medida"
        Me.MedidaDataGridViewTextBoxColumn.Name = "MedidaDataGridViewTextBoxColumn"
        Me.MedidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoproductoDataGridViewTextBoxColumn
        '
        Me.CodigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.HeaderText = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.Name = "CodigoproductoDataGridViewTextBoxColumn"
        Me.CodigoproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciocostoDataGridViewTextBoxColumn
        '
        Me.PreciocostoDataGridViewTextBoxColumn.DataPropertyName = "preciocosto"
        Me.PreciocostoDataGridViewTextBoxColumn.HeaderText = "preciocosto"
        Me.PreciocostoDataGridViewTextBoxColumn.Name = "PreciocostoDataGridViewTextBoxColumn"
        Me.PreciocostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventaDataGridViewTextBoxColumn
        '
        Me.PrecioventaDataGridViewTextBoxColumn.DataPropertyName = "precioventa"
        Me.PrecioventaDataGridViewTextBoxColumn.HeaderText = "precioventa"
        Me.PrecioventaDataGridViewTextBoxColumn.Name = "PrecioventaDataGridViewTextBoxColumn"
        Me.PrecioventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventamayoristaDataGridViewTextBoxColumn
        '
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.DataPropertyName = "precioventamayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.HeaderText = "precioventamayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.Name = "PrecioventamayoristaDataGridViewTextBoxColumn"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventagranelDataGridViewTextBoxColumn
        '
        Me.PrecioventagranelDataGridViewTextBoxColumn.DataPropertyName = "precioventagranel"
        Me.PrecioventagranelDataGridViewTextBoxColumn.HeaderText = "precioventagranel"
        Me.PrecioventagranelDataGridViewTextBoxColumn.Name = "PrecioventagranelDataGridViewTextBoxColumn"
        Me.PrecioventagranelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemitosdetalleBindingSource
        '
        Me.RemitosdetalleBindingSource.DataMember = "remitosdetalle"
        Me.RemitosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.codigoproducto, Me.descripcion, Me.cantidad, Me.unidadmedida, Me.medida, Me.preciocosto, Me.precioventa, Me.precioventamayorista, Me.precioventagranel})
        Me.DataGridViewProductos.Location = New System.Drawing.Point(6, 63)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowTemplate.Height = 24
        Me.DataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductos.Size = New System.Drawing.Size(805, 367)
        Me.DataGridViewProductos.TabIndex = 1
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "ID"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'codigoproducto
        '
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Width = 150
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 300
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'unidadmedida
        '
        Me.unidadmedida.DataSource = Me.UnidadesmedidaBindingSource
        Me.unidadmedida.DisplayMember = "descripcion"
        Me.unidadmedida.HeaderText = "Unidad Medida"
        Me.unidadmedida.Name = "unidadmedida"
        Me.unidadmedida.ReadOnly = True
        Me.unidadmedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.unidadmedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.unidadmedida.ValueMember = "idunidadmedida"
        '
        'UnidadesmedidaBindingSource
        '
        Me.UnidadesmedidaBindingSource.DataMember = "unidadesmedida"
        Me.UnidadesmedidaBindingSource.DataSource = Me.ComercialDataSet
        '
        'medida
        '
        Me.medida.HeaderText = "Medida"
        Me.medida.Name = "medida"
        Me.medida.ReadOnly = True
        '
        'preciocosto
        '
        Me.preciocosto.HeaderText = "Precio Costo"
        Me.preciocosto.Name = "preciocosto"
        Me.preciocosto.ReadOnly = True
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "Precio Vta. Pub."
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'precioventamayorista
        '
        Me.precioventamayorista.HeaderText = "Precio Vta. mayorista"
        Me.precioventamayorista.Name = "precioventamayorista"
        Me.precioventamayorista.ReadOnly = True
        '
        'precioventagranel
        '
        Me.precioventagranel.HeaderText = "Precio Vta. granel"
        Me.precioventagranel.Name = "precioventagranel"
        Me.precioventagranel.ReadOnly = True
        '
        'RemitosDataGridView
        '
        Me.RemitosDataGridView.AllowUserToAddRows = False
        Me.RemitosDataGridView.AllowUserToDeleteRows = False
        Me.RemitosDataGridView.AutoGenerateColumns = False
        Me.RemitosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemitosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdremitoDataGridViewTextBoxColumn, Me.TiporemitoDataGridViewTextBoxColumn, Me.IdsucursalDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.UsuariocargaDataGridViewTextBoxColumn})
        Me.RemitosDataGridView.DataSource = Me.RemitosBindingSource
        Me.RemitosDataGridView.Location = New System.Drawing.Point(526, 22)
        Me.RemitosDataGridView.Name = "RemitosDataGridView"
        Me.RemitosDataGridView.ReadOnly = True
        Me.RemitosDataGridView.RowTemplate.Height = 24
        Me.RemitosDataGridView.Size = New System.Drawing.Size(32, 23)
        Me.RemitosDataGridView.TabIndex = 3
        Me.RemitosDataGridView.Visible = False
        '
        'IdremitoDataGridViewTextBoxColumn
        '
        Me.IdremitoDataGridViewTextBoxColumn.DataPropertyName = "idremito"
        Me.IdremitoDataGridViewTextBoxColumn.HeaderText = "idremito"
        Me.IdremitoDataGridViewTextBoxColumn.Name = "IdremitoDataGridViewTextBoxColumn"
        Me.IdremitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TiporemitoDataGridViewTextBoxColumn
        '
        Me.TiporemitoDataGridViewTextBoxColumn.DataPropertyName = "tiporemito"
        Me.TiporemitoDataGridViewTextBoxColumn.HeaderText = "tiporemito"
        Me.TiporemitoDataGridViewTextBoxColumn.Name = "TiporemitoDataGridViewTextBoxColumn"
        Me.TiporemitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdsucursalDataGridViewTextBoxColumn
        '
        Me.IdsucursalDataGridViewTextBoxColumn.DataPropertyName = "idsucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.HeaderText = "idsucursal"
        Me.IdsucursalDataGridViewTextBoxColumn.Name = "IdsucursalDataGridViewTextBoxColumn"
        Me.IdsucursalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechabajaDataGridViewTextBoxColumn
        '
        Me.FechabajaDataGridViewTextBoxColumn.DataPropertyName = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.HeaderText = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.Name = "FechabajaDataGridViewTextBoxColumn"
        Me.FechabajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuariocargaDataGridViewTextBoxColumn
        '
        Me.UsuariocargaDataGridViewTextBoxColumn.DataPropertyName = "usuariocarga"
        Me.UsuariocargaDataGridViewTextBoxColumn.HeaderText = "usuariocarga"
        Me.UsuariocargaDataGridViewTextBoxColumn.Name = "UsuariocargaDataGridViewTextBoxColumn"
        Me.UsuariocargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemitosBindingSource
        '
        Me.RemitosBindingSource.DataMember = "remitos"
        Me.RemitosBindingSource.DataSource = Me.ComercialDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sucursal Origen:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SucursalesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(355, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 24)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "idsucursal"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "sucursales"
        Me.SucursalesBindingSource.DataSource = Me.ComercialDataSet
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'RemitosTableAdapter
        '
        Me.RemitosTableAdapter.ClearBeforeFill = True
        '
        'RemitosdetalleTableAdapter
        '
        Me.RemitosdetalleTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'UnidadesmedidaTableAdapter
        '
        Me.UnidadesmedidaTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'RecibirStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "RecibirStock"
        Me.Tag = "RecibirStock"
        Me.Text = "Recibir Stock"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.RemitosdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RemitosdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents RemitosDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As comercialDataSetTableAdapters.sucursalesTableAdapter
    Friend WithEvents RemitosBindingSource As BindingSource
    Friend WithEvents RemitosTableAdapter As comercialDataSetTableAdapters.remitosTableAdapter
    Friend WithEvents IdremitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiporemitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechabajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuariocargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemitosdetalleBindingSource As BindingSource
    Friend WithEvents RemitosdetalleTableAdapter As comercialDataSetTableAdapters.remitosdetalleTableAdapter
    Friend WithEvents IdremitodetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdremitoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadmedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventamayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventagranelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents UnidadesmedidaBindingSource As BindingSource
    Friend WithEvents UnidadesmedidaTableAdapter As comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents unidadmedida As DataGridViewComboBoxColumn
    Friend WithEvents medida As DataGridViewTextBoxColumn
    Friend WithEvents preciocosto As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents precioventamayorista As DataGridViewTextBoxColumn
    Friend WithEvents precioventagranel As DataGridViewTextBoxColumn
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviarStock
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RemitosdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SucursalesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.sucursalesTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.RemitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.remitosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.RemitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.remitosdetalleTableAdapter()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listaremitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaremitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosTableAdapter()
        Me.listaremitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaremitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosdetalleTableAdapter()
        Me.StockgeneralTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockgeneralTableAdapter()
        Me.BGWStockClowd = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RemitosdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sucursal de destino:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SucursalesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(328, 44)
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
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemitosdetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.DataGridViewProductos)
        Me.GroupBox2.Controls.Add(Me.RemitosDataGridView)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(817, 436)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mercaderías"
        '
        'RemitosdetalleDataGridView
        '
        Me.RemitosdetalleDataGridView.AutoGenerateColumns = False
        Me.RemitosdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemitosdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.RemitosdetalleDataGridView.DataSource = Me.RemitosdetalleBindingSource
        Me.RemitosdetalleDataGridView.Location = New System.Drawing.Point(564, 21)
        Me.RemitosdetalleDataGridView.Name = "RemitosdetalleDataGridView"
        Me.RemitosdetalleDataGridView.RowTemplate.Height = 24
        Me.RemitosdetalleDataGridView.Size = New System.Drawing.Size(32, 23)
        Me.RemitosdetalleDataGridView.TabIndex = 4
        Me.RemitosdetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idremitodetalle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idremitodetalle"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idremito"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idremito"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn12.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn13.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'RemitosdetalleBindingSource
        '
        Me.RemitosdetalleBindingSource.DataMember = "remitosdetalle"
        Me.RemitosdetalleBindingSource.DataSource = Me.ComercialDataSet
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
        Me.preciocosto.HeaderText = "preciocosto"
        Me.preciocosto.Name = "preciocosto"
        Me.preciocosto.ReadOnly = True
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "precioventa"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'precioventamayorista
        '
        Me.precioventamayorista.HeaderText = "precioventamayorista"
        Me.precioventamayorista.Name = "precioventamayorista"
        Me.precioventamayorista.ReadOnly = True
        '
        'precioventagranel
        '
        Me.precioventagranel.HeaderText = "precioventagranel"
        Me.precioventagranel.Name = "precioventagranel"
        Me.precioventagranel.ReadOnly = True
        '
        'RemitosDataGridView
        '
        Me.RemitosDataGridView.AutoGenerateColumns = False
        Me.RemitosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemitosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.RemitosDataGridView.DataSource = Me.RemitosBindingSource
        Me.RemitosDataGridView.Location = New System.Drawing.Point(526, 22)
        Me.RemitosDataGridView.Name = "RemitosDataGridView"
        Me.RemitosDataGridView.RowTemplate.Height = 24
        Me.RemitosDataGridView.Size = New System.Drawing.Size(32, 23)
        Me.RemitosDataGridView.TabIndex = 3
        Me.RemitosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idremito"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idremito"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tiporemito"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tiporemito"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idsucursal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idsucursal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 560)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(817, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Finalizar Envío"
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
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
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
        'RemitosTableAdapter
        '
        Me.RemitosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosproveedoresTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Me.RemitosdetalleTableAdapter
        Me.TableAdapterManager.remitosTableAdapter = Me.RemitosTableAdapter
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.sucursalesTableAdapter = Me.SucursalesTableAdapter
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Me.UnidadesmedidaTableAdapter
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'RemitosdetalleTableAdapter
        '
        Me.RemitosdetalleTableAdapter.ClearBeforeFill = True
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.ComercialDataSet
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listaremitosBindingSource
        '
        Me.listaremitosBindingSource.DataMember = "listaremitos"
        Me.listaremitosBindingSource.DataSource = Me.ComercialDataSet
        '
        'listaremitosTableAdapter
        '
        Me.listaremitosTableAdapter.ClearBeforeFill = True
        '
        'listaremitosdetalleBindingSource
        '
        Me.listaremitosdetalleBindingSource.DataMember = "listaremitosdetalle"
        Me.listaremitosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'listaremitosdetalleTableAdapter
        '
        Me.listaremitosdetalleTableAdapter.ClearBeforeFill = True
        '
        'StockgeneralTableAdapter
        '
        Me.StockgeneralTableAdapter.ClearBeforeFill = True
        '
        'BGWStockClowd
        '
        '
        'EnviarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "EnviarStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar Stock a Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.RemitosdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As comercialDataSetTableAdapters.sucursalesTableAdapter
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents UnidadesmedidaBindingSource As BindingSource
    Friend WithEvents UnidadesmedidaTableAdapter As comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents RemitosBindingSource As BindingSource
    Friend WithEvents RemitosTableAdapter As comercialDataSetTableAdapters.remitosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RemitosdetalleTableAdapter As comercialDataSetTableAdapters.remitosdetalleTableAdapter
    Friend WithEvents RemitosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents RemitosdetalleBindingSource As BindingSource
    Friend WithEvents RemitosdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
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
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents listaremitosBindingSource As BindingSource
    Friend WithEvents listaremitosdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listaremitosTableAdapter As comercialDataSetTableAdapters.listaremitosTableAdapter
    Friend WithEvents listaremitosdetalleTableAdapter As comercialDataSetTableAdapters.listaremitosdetalleTableAdapter
    Friend WithEvents StockgeneralTableAdapter As comercialDataSetTableAdapters.stockgeneralTableAdapter
    Friend WithEvents BGWStockClowd As System.ComponentModel.BackgroundWorker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaStockRemotoProducto
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StockgeneralDataGridView = New System.Windows.Forms.DataGridView()
        Me.idsucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Envasado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockgeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLDataSet = New sgcomercial.MySQLDataSet()
        Me.GroupBoxRemoto = New System.Windows.Forms.GroupBox()
        Me.SucursalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.StockgeneralTableAdapter = New sgcomercial.MySQLDataSetTableAdapters.stockgeneralTableAdapter()
        Me.TableAdapterManager = New sgcomercial.MySQLDataSetTableAdapters.TableAdapterManager()
        Me.SucursalesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.sucursalesTableAdapter()
        Me.TableAdapterManager1 = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBoxLocal = New System.Windows.Forms.GroupBox()
        Me.StockgeneralBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockgeneralTableAdapter1 = New sgcomercial.comercialDataSetTableAdapters.stockgeneralTableAdapter()
        Me.StockgeneralDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRemoto.SuspendLayout()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLocal.SuspendLayout()
        CType(Me.StockgeneralBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StockgeneralDataGridView
        '
        Me.StockgeneralDataGridView.AllowUserToAddRows = False
        Me.StockgeneralDataGridView.AllowUserToDeleteRows = False
        Me.StockgeneralDataGridView.AllowUserToResizeColumns = False
        Me.StockgeneralDataGridView.AllowUserToResizeRows = False
        Me.StockgeneralDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockgeneralDataGridView.AutoGenerateColumns = False
        Me.StockgeneralDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StockgeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockgeneralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsucursal, Me.codigoproducto, Me.medida, Me.DataGridViewTextBoxColumn9, Me.Envasado, Me.NombreSucursal})
        Me.StockgeneralDataGridView.DataSource = Me.StockgeneralBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StockgeneralDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.StockgeneralDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.StockgeneralDataGridView.Location = New System.Drawing.Point(16, 21)
        Me.StockgeneralDataGridView.Name = "StockgeneralDataGridView"
        Me.StockgeneralDataGridView.ReadOnly = True
        Me.StockgeneralDataGridView.RowTemplate.Height = 24
        Me.StockgeneralDataGridView.Size = New System.Drawing.Size(972, 225)
        Me.StockgeneralDataGridView.TabIndex = 1
        '
        'idsucursal
        '
        Me.idsucursal.DataPropertyName = "idsucursal"
        Me.idsucursal.HeaderText = "Sucursal"
        Me.idsucursal.Name = "idsucursal"
        Me.idsucursal.ReadOnly = True
        Me.idsucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idsucursal.Width = 92
        '
        'NombreSucursal
        '
        Me.NombreSucursal.HeaderText = "Nombre Sucursal"
        Me.NombreSucursal.Name = "NombreSucursal"
        Me.NombreSucursal.ReadOnly = True
        Me.NombreSucursal.Width = 134
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Width = 75
        '
        'medida
        '
        Me.medida.DataPropertyName = "medida"
        Me.medida.HeaderText = "Unidad de Medida"
        Me.medida.Name = "medida"
        Me.medida.ReadOnly = True
        Me.medida.ToolTipText = "Unidad de Medida"
        Me.medida.Width = 139
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "disponible"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Disponible"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 103
        '
        'Envasado
        '
        Me.Envasado.DataPropertyName = "unidades"
        Me.Envasado.HeaderText = "Unidades Envasadas"
        Me.Envasado.Name = "Envasado"
        Me.Envasado.ReadOnly = True
        Me.Envasado.Width = 156
        '
        'StockgeneralBindingSource
        '
        Me.StockgeneralBindingSource.DataMember = "stockgeneral"
        Me.StockgeneralBindingSource.DataSource = Me.MySQLDataSet
        '
        'MySQLDataSet
        '
        Me.MySQLDataSet.DataSetName = "MySQLDataSet"
        Me.MySQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxRemoto
        '
        Me.GroupBoxRemoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRemoto.Controls.Add(Me.SucursalesDataGridView)
        Me.GroupBoxRemoto.Controls.Add(Me.StockgeneralDataGridView)
        Me.GroupBoxRemoto.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxRemoto.Name = "GroupBoxRemoto"
        Me.GroupBoxRemoto.Size = New System.Drawing.Size(1007, 270)
        Me.GroupBoxRemoto.TabIndex = 2
        Me.GroupBoxRemoto.TabStop = False
        Me.GroupBoxRemoto.Text = "Consulta de Stock Remoto"
        '
        'SucursalesDataGridView
        '
        Me.SucursalesDataGridView.AutoGenerateColumns = False
        Me.SucursalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SucursalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SucursalesDataGridView.DataSource = Me.SucursalesBindingSource
        Me.SucursalesDataGridView.Location = New System.Drawing.Point(209, -8)
        Me.SucursalesDataGridView.Name = "SucursalesDataGridView"
        Me.SucursalesDataGridView.RowTemplate.Height = 24
        Me.SucursalesDataGridView.Size = New System.Drawing.Size(27, 23)
        Me.SucursalesDataGridView.TabIndex = 2
        Me.SucursalesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idsucursal"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idsucursal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        'StockgeneralTableAdapter
        '
        Me.StockgeneralTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.libroventasTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockgeneralTableAdapter = Me.StockgeneralTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.MySQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.alumnosTableAdapter = Nothing
        Me.TableAdapterManager1.auventascanceladasTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager1.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager1.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager1.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager1.cajasTableAdapter = Nothing
        Me.TableAdapterManager1.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager1.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager1.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager1.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager1.clientesTableAdapter = Nothing
        Me.TableAdapterManager1.criteriosventaproductosTableAdapter = Nothing
        Me.TableAdapterManager1.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager1.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager1.criteriosventaTableAdapter = Nothing
        Me.TableAdapterManager1.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager1.depositosTableAdapter = Nothing
        Me.TableAdapterManager1.errorlogTableAdapter = Nothing
        Me.TableAdapterManager1.estadosaiTableAdapter = Nothing
        Me.TableAdapterManager1.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.estadosordenmesaTableAdapter = Nothing
        Me.TableAdapterManager1.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager1.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager1.funcionesTableAdapter = Nothing
        Me.TableAdapterManager1.gastosTableAdapter = Nothing
        Me.TableAdapterManager1.gradosalumnosTableAdapter = Nothing
        Me.TableAdapterManager1.gradosTableAdapter = Nothing
        Me.TableAdapterManager1.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager1.localidadesTableAdapter = Nothing
        Me.TableAdapterManager1.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager1.lotesvencimientoTableAdapter = Nothing
        Me.TableAdapterManager1.mesasTableAdapter = Nothing
        Me.TableAdapterManager1.modulosTableAdapter = Nothing
        Me.TableAdapterManager1.motivostockTableAdapter = Nothing
        Me.TableAdapterManager1.mozosTableAdapter = Nothing
        Me.TableAdapterManager1.ordenesmesasTableAdapter = Nothing
        Me.TableAdapterManager1.pagosimputacionesTableAdapter = Nothing
        Me.TableAdapterManager1.pagosTableAdapter = Nothing
        Me.TableAdapterManager1.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager1.pedidosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager1.pedidosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.pedidosTableAdapter = Nothing
        Me.TableAdapterManager1.perfilesTableAdapter = Nothing
        Me.TableAdapterManager1.permisosTableAdapter = Nothing
        Me.TableAdapterManager1.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager1.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager1.productosproveedoresTableAdapter = Nothing
        Me.TableAdapterManager1.productosTableAdapter = Nothing
        Me.TableAdapterManager1.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager1.provinciasTableAdapter = Nothing
        Me.TableAdapterManager1.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.remitosTableAdapter = Nothing
        Me.TableAdapterManager1.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.rubrosTableAdapter = Nothing
        Me.TableAdapterManager1.salonesTableAdapter = Nothing
        Me.TableAdapterManager1.serviciosTableAdapter = Nothing
        Me.TableAdapterManager1.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager1.stockTableAdapter = Nothing
        Me.TableAdapterManager1.sucursalesTableAdapter = Me.SucursalesTableAdapter
        Me.TableAdapterManager1.synclogTableAdapter = Nothing
        Me.TableAdapterManager1.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager1.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager1.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager1.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager1.tipodocumentosTableAdapter = Nothing
        Me.TableAdapterManager1.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager1.tipogastosTableAdapter = Nothing
        Me.TableAdapterManager1.tipoivaTableAdapter = Nothing
        Me.TableAdapterManager1.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager1.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager1.transportesTableAdapter = Nothing
        Me.TableAdapterManager1.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.usuariosTableAdapter = Nothing
        Me.TableAdapterManager1.valesTableAdapter = Nothing
        Me.TableAdapterManager1.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.ventasTableAdapter = Nothing
        '
        'GroupBoxLocal
        '
        Me.GroupBoxLocal.Controls.Add(Me.StockgeneralDataGridView1)
        Me.GroupBoxLocal.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxLocal.Name = "GroupBoxLocal"
        Me.GroupBoxLocal.Size = New System.Drawing.Size(1007, 270)
        Me.GroupBoxLocal.TabIndex = 3
        Me.GroupBoxLocal.TabStop = False
        Me.GroupBoxLocal.Text = "Consulta de Stock Local"
        '
        'StockgeneralBindingSource1
        '
        Me.StockgeneralBindingSource1.DataMember = "stockgeneral"
        Me.StockgeneralBindingSource1.DataSource = Me.ComercialDataSet
        '
        'StockgeneralTableAdapter1
        '
        Me.StockgeneralTableAdapter1.ClearBeforeFill = True
        '
        'StockgeneralDataGridView1
        '
        Me.StockgeneralDataGridView1.AllowUserToAddRows = False
        Me.StockgeneralDataGridView1.AllowUserToDeleteRows = False
        Me.StockgeneralDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockgeneralDataGridView1.AutoGenerateColumns = False
        Me.StockgeneralDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StockgeneralDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockgeneralDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.StockgeneralDataGridView1.DataSource = Me.StockgeneralBindingSource1
        Me.StockgeneralDataGridView1.Location = New System.Drawing.Point(15, 21)
        Me.StockgeneralDataGridView1.Name = "StockgeneralDataGridView1"
        Me.StockgeneralDataGridView1.ReadOnly = True
        Me.StockgeneralDataGridView1.RowTemplate.Height = 24
        Me.StockgeneralDataGridView1.Size = New System.Drawing.Size(972, 225)
        Me.StockgeneralDataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "rubro"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rubro"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 76
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 94
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Medida"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 83
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "unidades"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Stock Disponible"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "disponible"
        Me.DataGridViewTextBoxColumn6.HeaderText = "A Granel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "proveedor"
        Me.DataGridViewTextBoxColumn15.HeaderText = "proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'ConsultaStockRemotoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 297)
        Me.Controls.Add(Me.GroupBoxLocal)
        Me.Controls.Add(Me.GroupBoxRemoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaStockRemotoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ConsultaStockRemotoProducto"
        Me.Text = "Consulta Stock"
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRemoto.ResumeLayout(False)
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxLocal.ResumeLayout(False)
        CType(Me.StockgeneralBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MySQLDataSet As MySQLDataSet
    Friend WithEvents StockgeneralBindingSource As BindingSource
    Friend WithEvents StockgeneralTableAdapter As MySQLDataSetTableAdapters.stockgeneralTableAdapter
    Friend WithEvents TableAdapterManager As MySQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockgeneralDataGridView As DataGridView
    Friend WithEvents GroupBoxRemoto As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents SucursalesTableAdapter As comercialDataSetTableAdapters.sucursalesTableAdapter
    Friend WithEvents SucursalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents idsucursal As DataGridViewTextBoxColumn
    Friend WithEvents NombreSucursal As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents medida As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Envasado As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxLocal As GroupBox
    Friend WithEvents StockgeneralBindingSource1 As BindingSource
    Friend WithEvents StockgeneralTableAdapter1 As comercialDataSetTableAdapters.stockgeneralTableAdapter
    Friend WithEvents StockgeneralDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
End Class

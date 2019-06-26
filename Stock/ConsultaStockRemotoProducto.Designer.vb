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
        Me.StockgeneralDataGridView = New System.Windows.Forms.DataGridView()
        Me.StockgeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLDataSet = New sgcomercial.MySQLDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.idsucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Envasado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StockgeneralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsucursal, Me.NombreSucursal, Me.codigoproducto, Me.medida, Me.DataGridViewTextBoxColumn9, Me.Envasado})
        Me.StockgeneralDataGridView.DataSource = Me.StockgeneralBindingSource
        Me.StockgeneralDataGridView.Location = New System.Drawing.Point(16, 21)
        Me.StockgeneralDataGridView.Name = "StockgeneralDataGridView"
        Me.StockgeneralDataGridView.ReadOnly = True
        Me.StockgeneralDataGridView.RowTemplate.Height = 24
        Me.StockgeneralDataGridView.Size = New System.Drawing.Size(967, 205)
        Me.StockgeneralDataGridView.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SucursalesDataGridView)
        Me.GroupBox1.Controls.Add(Me.StockgeneralDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 250)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        Me.TableAdapterManager1.clientesTableAdapter = Nothing
        Me.TableAdapterManager1.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager1.errorlogTableAdapter = Nothing
        Me.TableAdapterManager1.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager1.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager1.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager1.funcionesTableAdapter = Nothing
        Me.TableAdapterManager1.gastosTableAdapter = Nothing
        Me.TableAdapterManager1.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager1.localidadesTableAdapter = Nothing
        Me.TableAdapterManager1.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager1.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager1.modulosTableAdapter = Nothing
        Me.TableAdapterManager1.motivostockTableAdapter = Nothing
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
        Me.TableAdapterManager1.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager1.stockTableAdapter = Nothing
        Me.TableAdapterManager1.sucursalesTableAdapter = Me.SucursalesTableAdapter
        Me.TableAdapterManager1.synclogTableAdapter = Nothing
        Me.TableAdapterManager1.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager1.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager1.tipocondicionivaTableAdapter = Nothing
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
        Me.codigoproducto.Width = 81
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
        'ConsultaStockRemotoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 277)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaStockRemotoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ConsultaStockRemotoProducto"
        Me.Text = "Consulta Stock Remoto"
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MySQLDataSet As MySQLDataSet
    Friend WithEvents StockgeneralBindingSource As BindingSource
    Friend WithEvents StockgeneralTableAdapter As MySQLDataSetTableAdapters.stockgeneralTableAdapter
    Friend WithEvents TableAdapterManager As MySQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockgeneralDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
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
End Class

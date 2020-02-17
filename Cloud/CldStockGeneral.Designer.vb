<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CldStockGeneral
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockgeneralDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idsucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockgeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLDataSet = New sgcomercial.MySQLDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StockgeneralTableAdapter = New sgcomercial.MySQLDataSetTableAdapters.stockgeneralTableAdapter()
        Me.TableAdapterManager = New sgcomercial.MySQLDataSetTableAdapters.TableAdapterManager()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.StockgeneralremotoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockgeneralremotoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockgeneralremotoTableAdapter()
        Me.TableAdapterManager1 = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.StockgeneralremotoDataGridView = New System.Windows.Forms.DataGridView()
        Me.sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralremotoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockgeneralremotoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.StockgeneralDataGridView)
        Me.GroupBox1.Controls.Add(Me.StockgeneralremotoDataGridView)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'StockgeneralDataGridView
        '
        Me.StockgeneralDataGridView.AllowUserToAddRows = False
        Me.StockgeneralDataGridView.AllowUserToDeleteRows = False
        Me.StockgeneralDataGridView.AutoGenerateColumns = False
        Me.StockgeneralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockgeneralDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.idsucursal, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.codigoproducto, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.disponible, Me.unidades, Me.DataGridViewTextBoxColumn11})
        Me.StockgeneralDataGridView.DataSource = Me.StockgeneralBindingSource
        Me.StockgeneralDataGridView.Location = New System.Drawing.Point(19, 21)
        Me.StockgeneralDataGridView.Name = "StockgeneralDataGridView"
        Me.StockgeneralDataGridView.ReadOnly = True
        Me.StockgeneralDataGridView.RowTemplate.Height = 24
        Me.StockgeneralDataGridView.Size = New System.Drawing.Size(25, 22)
        Me.StockgeneralDataGridView.TabIndex = 2
        Me.StockgeneralDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idstockgeneral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idstockgeneral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'idsucursal
        '
        Me.idsucursal.DataPropertyName = "idsucursal"
        Me.idsucursal.HeaderText = "idsucursal"
        Me.idsucursal.Name = "idsucursal"
        Me.idsucursal.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "codigoproducto"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "rubro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "rubro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn8.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'disponible
        '
        Me.disponible.DataPropertyName = "disponible"
        Me.disponible.HeaderText = "disponible"
        Me.disponible.Name = "disponible"
        Me.disponible.ReadOnly = True
        '
        'unidades
        '
        Me.unidades.DataPropertyName = "unidades"
        Me.unidades.HeaderText = "unidades"
        Me.unidades.Name = "unidades"
        Me.unidades.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(424, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 22)
        Me.TextBox1.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Sucursal", "Código", "Producto"})
        Me.ComboBox1.Location = New System.Drawing.Point(264, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtrar por:"
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
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockgeneralremotoBindingSource
        '
        Me.StockgeneralremotoBindingSource.DataMember = "stockgeneralremoto"
        Me.StockgeneralremotoBindingSource.DataSource = Me.ComercialDataSet
        '
        'StockgeneralremotoTableAdapter
        '
        Me.StockgeneralremotoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.Connection = Nothing
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
        Me.TableAdapterManager1.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager1.synclogTableAdapter = Nothing
        Me.TableAdapterManager1.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager1.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager1.tipoestadosTableAdapter = Nothing
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
        'StockgeneralremotoDataGridView
        '
        Me.StockgeneralremotoDataGridView.AllowUserToAddRows = False
        Me.StockgeneralremotoDataGridView.AllowUserToDeleteRows = False
        Me.StockgeneralremotoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockgeneralremotoDataGridView.AutoGenerateColumns = False
        Me.StockgeneralremotoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StockgeneralremotoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockgeneralremotoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sucursal, Me.codigo, Me.producto, Me.DataGridViewTextBoxColumn10})
        Me.StockgeneralremotoDataGridView.DataSource = Me.StockgeneralremotoBindingSource
        Me.StockgeneralremotoDataGridView.Location = New System.Drawing.Point(50, 21)
        Me.StockgeneralremotoDataGridView.Name = "StockgeneralremotoDataGridView"
        Me.StockgeneralremotoDataGridView.ReadOnly = True
        Me.StockgeneralremotoDataGridView.RowTemplate.Height = 24
        Me.StockgeneralremotoDataGridView.Size = New System.Drawing.Size(89, 22)
        Me.StockgeneralremotoDataGridView.TabIndex = 1
        Me.StockgeneralremotoDataGridView.Visible = False
        '
        'sucursal
        '
        Me.sucursal.DataPropertyName = "sucursal"
        Me.sucursal.HeaderText = "Sucursal"
        Me.sucursal.Name = "sucursal"
        Me.sucursal.ReadOnly = True
        Me.sucursal.ToolTipText = "Sucursal"
        Me.sucursal.Width = 92
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigoproducto"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.codigo.ToolTipText = "Código"
        Me.codigo.Width = 81
        '
        'producto
        '
        Me.producto.DataPropertyName = "producto"
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.ToolTipText = "Producto"
        Me.producto.Width = 94
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "disponible"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cant. Disponible"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Cant. Disponible"
        Me.DataGridViewTextBoxColumn10.Width = 128
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "stockgeneralremoto"
        ReportDataSource2.Value = Me.StockgeneralremotoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.repStockGRemoto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1083, 475)
        Me.ReportViewer1.TabIndex = 2
        '
        'CldStockGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 569)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CldStockGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CldStockGeneral"
        Me.Text = "Consulta de Stock en Sucursales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StockgeneralDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralremotoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockgeneralremotoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MySQLDataSet As MySQLDataSet
    Friend WithEvents StockgeneralBindingSource As BindingSource
    Friend WithEvents StockgeneralTableAdapter As MySQLDataSetTableAdapters.stockgeneralTableAdapter
    Friend WithEvents TableAdapterManager As MySQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockgeneralDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idsucursal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents disponible As DataGridViewTextBoxColumn
    Friend WithEvents unidades As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents StockgeneralremotoBindingSource As BindingSource
    Friend WithEvents StockgeneralremotoTableAdapter As comercialDataSetTableAdapters.stockgeneralremotoTableAdapter
    Friend WithEvents TableAdapterManager1 As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockgeneralremotoDataGridView As DataGridView
    Friend WithEvents sucursal As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewLinkColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As ReportViewer
End Class

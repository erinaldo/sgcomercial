<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarProductoaProveedorMasivo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProductosproveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListaproductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosproveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductocompuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaproductosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ProductosproveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosproveedoresTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaproductosproveedoresvinculadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaproductosproveedoresvinculadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaproductosproveedoresvinculadosTableAdapter()
        Me.nombreproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductocompuestoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductosproveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosproveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosproveedoresvinculadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 99)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(862, 401)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeColumns = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreproveedor, Me.codigoproducto, Me.DescripcionDataGridViewTextBoxColumn1, Me.ProductocompuestoDataGridViewTextBoxColumn1, Me.precioventa, Me.idproducto})
        Me.ProductosDataGridView.DataSource = Me.ListaproductosproveedoresvinculadosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(19, 31)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(818, 347)
        Me.ProductosDataGridView.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProductosproveedoresDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ListaproductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(862, 79)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'ProductosproveedoresDataGridView
        '
        Me.ProductosproveedoresDataGridView.AutoGenerateColumns = False
        Me.ProductosproveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosproveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProductosproveedoresDataGridView.DataSource = Me.ProductosproveedoresBindingSource
        Me.ProductosproveedoresDataGridView.Location = New System.Drawing.Point(72, 21)
        Me.ProductosproveedoresDataGridView.Name = "ProductosproveedoresDataGridView"
        Me.ProductosproveedoresDataGridView.RowTemplate.Height = 24
        Me.ProductosproveedoresDataGridView.Size = New System.Drawing.Size(26, 16)
        Me.ProductosproveedoresDataGridView.TabIndex = 8
        Me.ProductosproveedoresDataGridView.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(678, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListaproductosDataGridView
        '
        Me.ListaproductosDataGridView.AutoGenerateColumns = False
        Me.ListaproductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaproductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ProductocompuestoDataGridViewTextBoxColumn})
        Me.ListaproductosDataGridView.DataSource = Me.ListaproductosBindingSource
        Me.ListaproductosDataGridView.Location = New System.Drawing.Point(23, 28)
        Me.ListaproductosDataGridView.Name = "ListaproductosDataGridView"
        Me.ListaproductosDataGridView.RowTemplate.Height = 24
        Me.ListaproductosDataGridView.Size = New System.Drawing.Size(39, 39)
        Me.ListaproductosDataGridView.TabIndex = 5
        Me.ListaproductosDataGridView.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(323, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Código", "Descripción"})
        Me.ComboBox1.Location = New System.Drawing.Point(154, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'ListaproductosBindingSource
        '
        Me.ListaproductosBindingSource.DataMember = "listaproductos"
        Me.ListaproductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idproductoproveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idproductoproveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "volumen1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "volumen1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descuento1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "descuento1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "volumen2"
        Me.DataGridViewTextBoxColumn7.HeaderText = "volumen2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descuento2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "descuento2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ProductosproveedoresBindingSource
        '
        Me.ProductosproveedoresBindingSource.DataMember = "productosproveedores"
        Me.ProductosproveedoresBindingSource.DataSource = Me.ComercialDataSet
        '
        'CodigoproductoDataGridViewTextBoxColumn
        '
        Me.CodigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.HeaderText = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.Name = "CodigoproductoDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductocompuestoDataGridViewTextBoxColumn
        '
        Me.ProductocompuestoDataGridViewTextBoxColumn.DataPropertyName = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn.HeaderText = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn.Name = "ProductocompuestoDataGridViewTextBoxColumn"
        '
        'ListaproductosTableAdapter
        '
        Me.ListaproductosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productosproveedoresTableAdapter = Me.ProductosproveedoresTableAdapter
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ProductosproveedoresTableAdapter
        '
        Me.ProductosproveedoresTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListaproductosproveedoresvinculadosBindingSource
        '
        Me.ListaproductosproveedoresvinculadosBindingSource.DataMember = "listaproductosproveedoresvinculados"
        Me.ListaproductosproveedoresvinculadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListaproductosproveedoresvinculadosTableAdapter
        '
        Me.ListaproductosproveedoresvinculadosTableAdapter.ClearBeforeFill = True
        '
        'nombreproveedor
        '
        Me.nombreproveedor.DataPropertyName = "nombreproveedor"
        Me.nombreproveedor.HeaderText = "Proveedor"
        Me.nombreproveedor.Name = "nombreproveedor"
        Me.nombreproveedor.ReadOnly = True
        Me.nombreproveedor.ToolTipText = "Proveedor"
        Me.nombreproveedor.Width = 103
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.ToolTipText = "Código"
        Me.codigoproducto.Width = 81
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn1.ToolTipText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Width = 111
        '
        'ProductocompuestoDataGridViewTextBoxColumn1
        '
        Me.ProductocompuestoDataGridViewTextBoxColumn1.DataPropertyName = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.HeaderText = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Name = "ProductocompuestoDataGridViewTextBoxColumn1"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Visible = False
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Width = 162
        '
        'precioventa
        '
        Me.precioventa.DataPropertyName = "precioventa"
        Me.precioventa.HeaderText = "precioventa"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        Me.precioventa.Visible = False
        Me.precioventa.Width = 111
        '
        'idproducto
        '
        Me.idproducto.DataPropertyName = "idproducto"
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        Me.idproducto.Width = 104
        '
        'AgregarProductoaProveedorMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 521)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AgregarProductoaProveedorMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "AgregarProductoaProveedorMasivo"
        Me.Text = "Vincular productos a Proveedor"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductosproveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosproveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosproveedoresvinculadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListaproductosBindingSource As BindingSource
    Friend WithEvents ListaproductosTableAdapter As comercialDataSetTableAdapters.listaproductosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListaproductosDataGridView As DataGridView
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductocompuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductosproveedoresTableAdapter As comercialDataSetTableAdapters.productosproveedoresTableAdapter
    Friend WithEvents ProductosproveedoresBindingSource As BindingSource
    Friend WithEvents ProductosproveedoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ListaproductosproveedoresvinculadosBindingSource As BindingSource
    Friend WithEvents ListaproductosproveedoresvinculadosTableAdapter As comercialDataSetTableAdapters.listaproductosproveedoresvinculadosTableAdapter
    Friend WithEvents nombreproveedor As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductocompuestoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
End Class

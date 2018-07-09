<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMProductos
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
        Dim IdproductoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim PresentacionLabel As System.Windows.Forms.Label
        Dim UnidadmedidaLabel As System.Windows.Forms.Label
        Dim MedidaLabel As System.Windows.Forms.Label
        Dim ImagenLabel As System.Windows.Forms.Label
        Dim PreciounitarioLabel As System.Windows.Forms.Label
        Dim PrecioventaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioventagranelLabel As System.Windows.Forms.Label
        Dim PrecioventamayoristaLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMProductos))
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.editbtn = New System.Windows.Forms.ToolStripButton()
        Me.cancelbtn = New System.Windows.Forms.ToolStripButton()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.idrubro = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet1 = New sgcomercial.comercialDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PrecioventadistribuidorTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventamayoristaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventagranelTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBoxCalidacodigo = New System.Windows.Forms.PictureBox()
        Me.MedidaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.PresentacionTextBox = New System.Windows.Forms.TextBox()
        Me.PreciocostoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventaTextBox = New System.Windows.Forms.TextBox()
        Me.stockminimotextbox = New System.Windows.Forms.TextBox()
        Me.codigoproductoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.IdproductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextFiltro = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RubrosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter()
        IdproductoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        PresentacionLabel = New System.Windows.Forms.Label()
        UnidadmedidaLabel = New System.Windows.Forms.Label()
        MedidaLabel = New System.Windows.Forms.Label()
        ImagenLabel = New System.Windows.Forms.Label()
        PreciounitarioLabel = New System.Windows.Forms.Label()
        PrecioventaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioventagranelLabel = New System.Windows.Forms.Label()
        PrecioventamayoristaLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxCalidacodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdproductoLabel
        '
        IdproductoLabel.AutoSize = True
        IdproductoLabel.Location = New System.Drawing.Point(48, 81)
        IdproductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdproductoLabel.Name = "IdproductoLabel"
        IdproductoLabel.Size = New System.Drawing.Size(102, 17)
        IdproductoLabel.TabIndex = 1
        IdproductoLabel.Text = "Cod. Producto:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(99, 113)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(51, 17)
        MarcaLabel.TabIndex = 3
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(81, 145)
        ModeloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(69, 17)
        ModeloLabel.TabIndex = 5
        ModeloLabel.Text = "Producto:"
        '
        'PresentacionLabel
        '
        PresentacionLabel.AutoSize = True
        PresentacionLabel.Location = New System.Drawing.Point(56, 177)
        PresentacionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PresentacionLabel.Name = "PresentacionLabel"
        PresentacionLabel.Size = New System.Drawing.Size(95, 17)
        PresentacionLabel.TabIndex = 7
        PresentacionLabel.Text = "Presentación:"
        '
        'UnidadmedidaLabel
        '
        UnidadmedidaLabel.AutoSize = True
        UnidadmedidaLabel.Location = New System.Drawing.Point(23, 209)
        UnidadmedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UnidadmedidaLabel.Name = "UnidadmedidaLabel"
        UnidadmedidaLabel.Size = New System.Drawing.Size(127, 17)
        UnidadmedidaLabel.TabIndex = 9
        UnidadmedidaLabel.Text = "Unidad de Medida:"
        '
        'MedidaLabel
        '
        MedidaLabel.AutoSize = True
        MedidaLabel.Location = New System.Drawing.Point(92, 241)
        MedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MedidaLabel.Name = "MedidaLabel"
        MedidaLabel.Size = New System.Drawing.Size(58, 17)
        MedidaLabel.TabIndex = 11
        MedidaLabel.Text = "Medida:"
        '
        'ImagenLabel
        '
        ImagenLabel.AutoSize = True
        ImagenLabel.Location = New System.Drawing.Point(669, 83)
        ImagenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImagenLabel.Name = "ImagenLabel"
        ImagenLabel.Size = New System.Drawing.Size(58, 17)
        ImagenLabel.TabIndex = 17
        ImagenLabel.Text = "Imagen:"
        '
        'PreciounitarioLabel
        '
        PreciounitarioLabel.AutoSize = True
        PreciounitarioLabel.Location = New System.Drawing.Point(42, 219)
        PreciounitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PreciounitarioLabel.Name = "PreciounitarioLabel"
        PreciounitarioLabel.Size = New System.Drawing.Size(92, 17)
        PreciounitarioLabel.TabIndex = 110
        PreciounitarioLabel.Text = "Precio Costo:"
        '
        'PrecioventaLabel
        '
        PrecioventaLabel.AccessibleDescription = "Precio Vta. público (empaque cerrado):"
        PrecioventaLabel.AccessibleName = "Precio Vta. público (empaque cerrado):"
        PrecioventaLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        PrecioventaLabel.AutoSize = True
        PrecioventaLabel.Location = New System.Drawing.Point(4, 252)
        PrecioventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioventaLabel.Name = "PrecioventaLabel"
        PrecioventaLabel.Size = New System.Drawing.Size(130, 17)
        PrecioventaLabel.TabIndex = 109
        PrecioventaLabel.Text = "Precio Vta. público:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(403, 69)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(95, 17)
        Label3.TabIndex = 102
        Label3.Text = "Stock Mínimo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(403, 20)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 17)
        Label2.TabIndex = 101
        Label2.Text = "Rubro:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(405, 121)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 108
        DescripcionLabel.Text = "Descripción:"
        '
        'PrecioventagranelLabel
        '
        PrecioventagranelLabel.AutoSize = True
        PrecioventagranelLabel.Location = New System.Drawing.Point(297, 219)
        PrecioventagranelLabel.Name = "PrecioventagranelLabel"
        PrecioventagranelLabel.Size = New System.Drawing.Size(137, 17)
        PrecioventagranelLabel.TabIndex = 112
        PrecioventagranelLabel.Text = "Precio Vta. a granel:"
        '
        'PrecioventamayoristaLabel
        '
        PrecioventamayoristaLabel.AutoSize = True
        PrecioventamayoristaLabel.Location = New System.Drawing.Point(285, 252)
        PrecioventamayoristaLabel.Name = "PrecioventamayoristaLabel"
        PrecioventamayoristaLabel.Size = New System.Drawing.Size(149, 17)
        PrecioventamayoristaLabel.TabIndex = 113
        PrecioventamayoristaLabel.Text = "Precio Vta. por mayor:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(574, 218)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(113, 17)
        Label4.TabIndex = 115
        Label4.Text = "Precio Vta. Dist.:"
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Nothing
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem, Me.editbtn, Me.cancelbtn})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Nothing
        Me.ProductosBindingNavigator.MoveLastItem = Nothing
        Me.ProductosBindingNavigator.MoveNextItem = Nothing
        Me.ProductosBindingNavigator.MovePreviousItem = Nothing
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Nothing
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(1164, 47)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(111, 44)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.ProductosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ProductosBindingNavigatorSaveItem.Visible = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(52, 44)
        Me.editbtn.Text = "Editar"
        Me.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cancelbtn
        '
        Me.cancelbtn.Image = CType(resources.GetObject("cancelbtn.Image"), System.Drawing.Image)
        Me.cancelbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(70, 44)
        Me.cancelbtn.Text = "Cancelar"
        Me.cancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BackColor = System.Drawing.Color.White
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(897, 83)
        Me.ImagenPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(236, 214)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 18
        Me.ImagenPictureBox.TabStop = False
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idrubro, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(27, 412)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.MultiSelect = False
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(1106, 234)
        Me.ProductosDataGridView.TabIndex = 19
        '
        'idrubro
        '
        Me.idrubro.DataPropertyName = "idrubro"
        Me.idrubro.DataSource = Me.RubrosBindingSource
        Me.idrubro.DisplayMember = "descripcion"
        Me.idrubro.HeaderText = "Rubro"
        Me.idrubro.Name = "idrubro"
        Me.idrubro.ReadOnly = True
        Me.idrubro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idrubro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.idrubro.ValueMember = "idrubro"
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "rubros"
        Me.RubrosBindingSource.DataSource = Me.ComercialDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Presentación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'UnidadesmedidaBindingSource
        '
        Me.UnidadesmedidaBindingSource.DataMember = "unidadesmedida"
        Me.UnidadesmedidaBindingSource.DataSource = Me.ComercialDataSet1
        '
        'ComercialDataSet1
        '
        Me.ComercialDataSet1.DataSetName = "comercialDataSet"
        Me.ComercialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(897, 299)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cargar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
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
        'UnidadesmedidaTableAdapter
        '
        Me.UnidadesmedidaTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PrecioventadistribuidorTextBox)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(PrecioventamayoristaLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioventamayoristaTextBox)
        Me.GroupBox1.Controls.Add(PrecioventagranelLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioventagranelTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureBoxCalidacodigo)
        Me.GroupBox1.Controls.Add(Me.MedidaTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox1.Controls.Add(Me.ModeloTextBox)
        Me.GroupBox1.Controls.Add(Me.PresentacionTextBox)
        Me.GroupBox1.Controls.Add(PreciounitarioLabel)
        Me.GroupBox1.Controls.Add(Me.PreciocostoTextBox)
        Me.GroupBox1.Controls.Add(PrecioventaLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioventaTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.stockminimotextbox)
        Me.GroupBox1.Controls.Add(Me.codigoproductoTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.IdproductoTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1135, 287)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'PrecioventadistribuidorTextBox
        '
        Me.PrecioventadistribuidorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventadistribuidor", True))
        Me.PrecioventadistribuidorTextBox.Location = New System.Drawing.Point(692, 216)
        Me.PrecioventadistribuidorTextBox.Name = "PrecioventadistribuidorTextBox"
        Me.PrecioventadistribuidorTextBox.Size = New System.Drawing.Size(116, 22)
        Me.PrecioventadistribuidorTextBox.TabIndex = 116
        Me.PrecioventadistribuidorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventamayoristaTextBox
        '
        Me.PrecioventamayoristaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventamayorista", True))
        Me.PrecioventamayoristaTextBox.Location = New System.Drawing.Point(440, 249)
        Me.PrecioventamayoristaTextBox.Name = "PrecioventamayoristaTextBox"
        Me.PrecioventamayoristaTextBox.Size = New System.Drawing.Size(116, 22)
        Me.PrecioventamayoristaTextBox.TabIndex = 114
        Me.PrecioventamayoristaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventagranelTextBox
        '
        Me.PrecioventagranelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventagranel", True))
        Me.PrecioventagranelTextBox.Location = New System.Drawing.Point(440, 213)
        Me.PrecioventagranelTextBox.Name = "PrecioventagranelTextBox"
        Me.PrecioventagranelTextBox.Size = New System.Drawing.Size(116, 22)
        Me.PrecioventagranelTextBox.TabIndex = 113
        Me.PrecioventagranelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBoxCalidacodigo
        '
        Me.PictureBoxCalidacodigo.AccessibleName = "Validar código"
        Me.PictureBoxCalidacodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCalidacodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCalidacodigo.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxCalidacodigo.Location = New System.Drawing.Point(368, 15)
        Me.PictureBoxCalidacodigo.Name = "PictureBoxCalidacodigo"
        Me.PictureBoxCalidacodigo.Size = New System.Drawing.Size(26, 26)
        Me.PictureBoxCalidacodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCalidacodigo.TabIndex = 112
        Me.PictureBoxCalidacodigo.TabStop = False
        Me.PictureBoxCalidacodigo.Tag = "Validar código"
        '
        'MedidaTextBox
        '
        Me.MedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "medida", True))
        Me.MedidaTextBox.Location = New System.Drawing.Point(144, 181)
        Me.MedidaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MedidaTextBox.Name = "MedidaTextBox"
        Me.MedidaTextBox.Size = New System.Drawing.Size(251, 22)
        Me.MedidaTextBox.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "unidadmedida", True))
        Me.ComboBox1.DataSource = Me.UnidadesmedidaBindingSource
        Me.ComboBox1.DisplayMember = "descripcion"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(141, 143)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "idunidadmedida"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(141, 48)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(251, 22)
        Me.MarcaTextBox.TabIndex = 2
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(141, 80)
        Me.ModeloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(251, 22)
        Me.ModeloTextBox.TabIndex = 3
        '
        'PresentacionTextBox
        '
        Me.PresentacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PresentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "presentacion", True))
        Me.PresentacionTextBox.Location = New System.Drawing.Point(141, 112)
        Me.PresentacionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PresentacionTextBox.Name = "PresentacionTextBox"
        Me.PresentacionTextBox.Size = New System.Drawing.Size(251, 22)
        Me.PresentacionTextBox.TabIndex = 4
        '
        'PreciocostoTextBox
        '
        Me.PreciocostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "preciocosto", True))
        Me.PreciocostoTextBox.Location = New System.Drawing.Point(143, 213)
        Me.PreciocostoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PreciocostoTextBox.Name = "PreciocostoTextBox"
        Me.PreciocostoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PreciocostoTextBox.TabIndex = 7
        Me.PreciocostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventaTextBox
        '
        Me.PrecioventaTextBox.AccessibleDescription = "Precio Vta. público (empaque cerrado):"
        Me.PrecioventaTextBox.AccessibleName = "Precio Vta. público (empaque cerrado):"
        Me.PrecioventaTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PrecioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventa", True))
        Me.PrecioventaTextBox.Location = New System.Drawing.Point(143, 249)
        Me.PrecioventaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioventaTextBox.Name = "PrecioventaTextBox"
        Me.PrecioventaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PrecioventaTextBox.TabIndex = 8
        Me.PrecioventaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'stockminimotextbox
        '
        Me.stockminimotextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stockminimo", True))
        Me.stockminimotextbox.Location = New System.Drawing.Point(407, 92)
        Me.stockminimotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.stockminimotextbox.Name = "stockminimotextbox"
        Me.stockminimotextbox.Size = New System.Drawing.Size(132, 22)
        Me.stockminimotextbox.TabIndex = 10
        Me.stockminimotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'codigoproductoTextBox
        '
        Me.codigoproductoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codigoproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigoproducto", True))
        Me.codigoproductoTextBox.Location = New System.Drawing.Point(141, 17)
        Me.codigoproductoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigoproductoTextBox.Name = "codigoproductoTextBox"
        Me.codigoproductoTextBox.Size = New System.Drawing.Size(222, 22)
        Me.codigoproductoTextBox.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idrubro", True))
        Me.ComboBox3.DataSource = Me.RubrosBindingSource
        Me.ComboBox3.DisplayMember = "descripcion"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(407, 39)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(151, 24)
        Me.ComboBox3.TabIndex = 9
        Me.ComboBox3.ValueMember = "idrubro"
        '
        'IdproductoTextBox
        '
        Me.IdproductoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "idproducto", True))
        Me.IdproductoTextBox.Location = New System.Drawing.Point(285, 145)
        Me.IdproductoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdproductoTextBox.Name = "IdproductoTextBox"
        Me.IdproductoTextBox.Size = New System.Drawing.Size(108, 22)
        Me.IdproductoTextBox.TabIndex = 111
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(409, 144)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(304, 22)
        Me.DescripcionTextBox.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextFiltro)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 356)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1135, 303)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Todos los productos"
        '
        'TextFiltro
        '
        Me.TextFiltro.Location = New System.Drawing.Point(385, 16)
        Me.TextFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.TextFiltro.Name = "TextFiltro"
        Me.TextFiltro.Size = New System.Drawing.Size(221, 22)
        Me.TextFiltro.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Código", "Marca", "Producto"})
        Me.ComboBox2.Location = New System.Drawing.Point(252, 16)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtrar por:"
        '
        'RubrosTableAdapter
        '
        Me.RubrosTableAdapter.ClearBeforeFill = True
        '
        'ABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(IdproductoLabel)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(PresentacionLabel)
        Me.Controls.Add(UnidadmedidaLabel)
        Me.Controls.Add(MedidaLabel)
        Me.Controls.Add(ImagenLabel)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Productos"
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxCalidacodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As sgcomercial.comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImagenPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UnidadesmedidaTableAdapter As sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents ComercialDataSet1 As sgcomercial.comercialDataSet
    Friend WithEvents UnidadesmedidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editbtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancelbtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RubrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RubrosTableAdapter As sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresentacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreciocostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stockminimotextbox As System.Windows.Forms.TextBox
    Friend WithEvents codigoproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents IdproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxCalidacodigo As PictureBox
    Friend WithEvents PrecioventamayoristaTextBox As TextBox
    Friend WithEvents PrecioventagranelTextBox As TextBox
    Friend WithEvents idrubro As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventadistribuidorTextBox As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCriterioVenta
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
        Dim IdcriterioventaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim FechadesdeLabel As System.Windows.Forms.Label
        Dim FechahastaLabel As System.Windows.Forms.Label
        Dim CantidaddisponibletotalLabel As System.Windows.Forms.Label
        Dim CantidadmaximaporclienteLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CriteriosventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriosventaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventaTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.IdcriterioventaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.FechadesdeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechahastaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidaddisponibletotalTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadmaximaporclienteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CriteriosventaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriosventaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventaproductosTableAdapter()
        Me.CriteriosventaproductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxRangos = New System.Windows.Forms.GroupBox()
        Me.GroupBoxRegalos = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonConfirmar = New System.Windows.Forms.Button()
        Me.ButtonFinalizar = New System.Windows.Forms.Button()
        IdcriterioventaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        FechadesdeLabel = New System.Windows.Forms.Label()
        FechahastaLabel = New System.Windows.Forms.Label()
        CantidaddisponibletotalLabel = New System.Windows.Forms.Label()
        CantidadmaximaporclienteLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriosventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProductos.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CriteriosventaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriosventaproductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRangos.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonFinalizar)
        Me.GroupBox1.Controls.Add(Me.ButtonConfirmar)
        Me.GroupBox1.Controls.Add(Me.GroupBoxRegalos)
        Me.GroupBox1.Controls.Add(Me.GroupBoxRangos)
        Me.GroupBox1.Controls.Add(Me.GroupBoxProductos)
        Me.GroupBox1.Controls.Add(IdcriterioventaLabel)
        Me.GroupBox1.Controls.Add(Me.IdcriterioventaTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(FechadesdeLabel)
        Me.GroupBox1.Controls.Add(Me.FechadesdeDateTimePicker)
        Me.GroupBox1.Controls.Add(FechahastaLabel)
        Me.GroupBox1.Controls.Add(Me.FechahastaDateTimePicker)
        Me.GroupBox1.Controls.Add(CantidaddisponibletotalLabel)
        Me.GroupBox1.Controls.Add(Me.CantidaddisponibletotalTextBox)
        Me.GroupBox1.Controls.Add(CantidadmaximaporclienteLabel)
        Me.GroupBox1.Controls.Add(Me.CantidadmaximaporclienteTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 609)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CriteriosventaBindingSource
        '
        Me.CriteriosventaBindingSource.DataMember = "criteriosventa"
        Me.CriteriosventaBindingSource.DataSource = Me.ComercialDataSet
        '
        'CriteriosventaTableAdapter
        '
        Me.CriteriosventaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.auventascanceladasTableAdapter = Nothing
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
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaproductosTableAdapter = Me.CriteriosventaproductosTableAdapter
        Me.TableAdapterManager.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaTableAdapter = Me.CriteriosventaTableAdapter
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadosaiTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadosordenmesaTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.gradosalumnosTableAdapter = Nothing
        Me.TableAdapterManager.gradosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.lotesvencimientoTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
        Me.TableAdapterManager.pagosimputacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.salonesTableAdapter = Nothing
        Me.TableAdapterManager.serviciosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipodocumentosTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipogastosTableAdapter = Nothing
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
        'IdcriterioventaLabel
        '
        IdcriterioventaLabel.AutoSize = True
        IdcriterioventaLabel.Location = New System.Drawing.Point(3, 76)
        IdcriterioventaLabel.Name = "IdcriterioventaLabel"
        IdcriterioventaLabel.Size = New System.Drawing.Size(101, 17)
        IdcriterioventaLabel.TabIndex = 0
        IdcriterioventaLabel.Text = "idcriterioventa:"
        IdcriterioventaLabel.Visible = False
        '
        'IdcriterioventaTextBox
        '
        Me.IdcriterioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "idcriterioventa", True))
        Me.IdcriterioventaTextBox.Location = New System.Drawing.Point(107, 73)
        Me.IdcriterioventaTextBox.Name = "IdcriterioventaTextBox"
        Me.IdcriterioventaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdcriterioventaTextBox.TabIndex = 1
        Me.IdcriterioventaTextBox.Visible = False
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(308, 17)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(402, 14)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'FechadesdeLabel
        '
        FechadesdeLabel.AutoSize = True
        FechadesdeLabel.Location = New System.Drawing.Point(341, 46)
        FechadesdeLabel.Name = "FechadesdeLabel"
        FechadesdeLabel.Size = New System.Drawing.Size(53, 17)
        FechadesdeLabel.TabIndex = 4
        FechadesdeLabel.Text = "Desde:"
        '
        'FechadesdeDateTimePicker
        '
        Me.FechadesdeDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechadesdeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CriteriosventaBindingSource, "fechadesde", True))
        Me.FechadesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechadesdeDateTimePicker.Location = New System.Drawing.Point(402, 42)
        Me.FechadesdeDateTimePicker.Name = "FechadesdeDateTimePicker"
        Me.FechadesdeDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.FechadesdeDateTimePicker.TabIndex = 5
        '
        'FechahastaLabel
        '
        FechahastaLabel.AutoSize = True
        FechahastaLabel.Location = New System.Drawing.Point(345, 74)
        FechahastaLabel.Name = "FechahastaLabel"
        FechahastaLabel.Size = New System.Drawing.Size(49, 17)
        FechahastaLabel.TabIndex = 6
        FechahastaLabel.Text = "Hasta:"
        '
        'FechahastaDateTimePicker
        '
        Me.FechahastaDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechahastaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CriteriosventaBindingSource, "fechahasta", True))
        Me.FechahastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechahastaDateTimePicker.Location = New System.Drawing.Point(402, 70)
        Me.FechahastaDateTimePicker.Name = "FechahastaDateTimePicker"
        Me.FechahastaDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.FechahastaDateTimePicker.TabIndex = 7
        '
        'CantidaddisponibletotalLabel
        '
        CantidaddisponibletotalLabel.AutoSize = True
        CantidaddisponibletotalLabel.Location = New System.Drawing.Point(220, 101)
        CantidaddisponibletotalLabel.Name = "CantidaddisponibletotalLabel"
        CantidaddisponibletotalLabel.Size = New System.Drawing.Size(174, 17)
        CantidaddisponibletotalLabel.TabIndex = 8
        CantidaddisponibletotalLabel.Text = "Cantidad Disponible Total:"
        '
        'CantidaddisponibletotalTextBox
        '
        Me.CantidaddisponibletotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "cantidaddisponibletotal", True))
        Me.CantidaddisponibletotalTextBox.Location = New System.Drawing.Point(402, 98)
        Me.CantidaddisponibletotalTextBox.Name = "CantidaddisponibletotalTextBox"
        Me.CantidaddisponibletotalTextBox.Size = New System.Drawing.Size(75, 22)
        Me.CantidaddisponibletotalTextBox.TabIndex = 9
        '
        'CantidadmaximaporclienteLabel
        '
        CantidadmaximaporclienteLabel.AutoSize = True
        CantidadmaximaporclienteLabel.Location = New System.Drawing.Point(203, 129)
        CantidadmaximaporclienteLabel.Name = "CantidadmaximaporclienteLabel"
        CantidadmaximaporclienteLabel.Size = New System.Drawing.Size(191, 17)
        CantidadmaximaporclienteLabel.TabIndex = 10
        CantidadmaximaporclienteLabel.Text = "Cantidad Máxima por Cliente:"
        '
        'CantidadmaximaporclienteTextBox
        '
        Me.CantidadmaximaporclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "cantidadmaximaporcliente", True))
        Me.CantidadmaximaporclienteTextBox.Location = New System.Drawing.Point(402, 126)
        Me.CantidadmaximaporclienteTextBox.Name = "CantidadmaximaporclienteTextBox"
        Me.CantidadmaximaporclienteTextBox.Size = New System.Drawing.Size(75, 22)
        Me.CantidadmaximaporclienteTextBox.TabIndex = 11
        '
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxProductos.Controls.Add(Me.CriteriosventaproductosDataGridView)
        Me.GroupBoxProductos.Controls.Add(Me.ToolStrip1)
        Me.GroupBoxProductos.Location = New System.Drawing.Point(6, 192)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Size = New System.Drawing.Size(814, 185)
        Me.GroupBoxProductos.TabIndex = 12
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Grupo de Productos"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(808, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(151, 24)
        Me.ToolStripButton1.Tag = "Agregar Producto"
        Me.ToolStripButton1.Text = "Agregar Producto"
        Me.ToolStripButton1.ToolTipText = "AgregarProducto"
        '
        'CriteriosventaproductosBindingSource
        '
        Me.CriteriosventaproductosBindingSource.DataMember = "criteriosventaproductos"
        Me.CriteriosventaproductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CriteriosventaproductosTableAdapter
        '
        Me.CriteriosventaproductosTableAdapter.ClearBeforeFill = True
        '
        'CriteriosventaproductosDataGridView
        '
        Me.CriteriosventaproductosDataGridView.AllowUserToAddRows = False
        Me.CriteriosventaproductosDataGridView.AllowUserToDeleteRows = False
        Me.CriteriosventaproductosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CriteriosventaproductosDataGridView.AutoGenerateColumns = False
        Me.CriteriosventaproductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CriteriosventaproductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CriteriosventaproductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.codigoproducto, Me.DataGridViewTextBoxColumn3})
        Me.CriteriosventaproductosDataGridView.DataSource = Me.CriteriosventaproductosBindingSource
        Me.CriteriosventaproductosDataGridView.Location = New System.Drawing.Point(6, 48)
        Me.CriteriosventaproductosDataGridView.Name = "CriteriosventaproductosDataGridView"
        Me.CriteriosventaproductosDataGridView.ReadOnly = True
        Me.CriteriosventaproductosDataGridView.RowTemplate.Height = 24
        Me.CriteriosventaproductosDataGridView.Size = New System.Drawing.Size(802, 123)
        Me.CriteriosventaproductosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcriteriosventaproductos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idcriteriosventaproductos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Cód. Producto"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ToolTipText = "codigoproducto"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidadmaxima"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad Maxima cada Venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Cantidad Maxima cada Venta"
        '
        'GroupBoxRangos
        '
        Me.GroupBoxRangos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRangos.Controls.Add(Me.ToolStrip2)
        Me.GroupBoxRangos.Location = New System.Drawing.Point(6, 383)
        Me.GroupBoxRangos.Name = "GroupBoxRangos"
        Me.GroupBoxRangos.Size = New System.Drawing.Size(545, 172)
        Me.GroupBoxRangos.TabIndex = 13
        Me.GroupBoxRangos.TabStop = False
        Me.GroupBoxRangos.Text = "Rangos Según Cantidad"
        '
        'GroupBoxRegalos
        '
        Me.GroupBoxRegalos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRegalos.Location = New System.Drawing.Point(557, 383)
        Me.GroupBoxRegalos.Name = "GroupBoxRegalos"
        Me.GroupBoxRegalos.Size = New System.Drawing.Size(263, 172)
        Me.GroupBoxRegalos.TabIndex = 14
        Me.GroupBoxRegalos.TabStop = False
        Me.GroupBoxRegalos.Text = "Regalo del Rango"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AllowMerge = False
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(539, 27)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(138, 24)
        Me.ToolStripButton2.Tag = "AgregarRango"
        Me.ToolStripButton2.Text = " Agregar Rango"
        Me.ToolStripButton2.ToolTipText = "Agregar Rango"
        '
        'ButtonConfirmar
        '
        Me.ButtonConfirmar.Location = New System.Drawing.Point(333, 160)
        Me.ButtonConfirmar.Name = "ButtonConfirmar"
        Me.ButtonConfirmar.Size = New System.Drawing.Size(160, 31)
        Me.ButtonConfirmar.TabIndex = 15
        Me.ButtonConfirmar.Text = "Confirmar y Continuar"
        Me.ButtonConfirmar.UseVisualStyleBackColor = True
        '
        'ButtonFinalizar
        '
        Me.ButtonFinalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFinalizar.Location = New System.Drawing.Point(288, 561)
        Me.ButtonFinalizar.Name = "ButtonFinalizar"
        Me.ButtonFinalizar.Size = New System.Drawing.Size(251, 41)
        Me.ButtonFinalizar.TabIndex = 16
        Me.ButtonFinalizar.Tag = "Finalizar"
        Me.ButtonFinalizar.Text = "Finalizar"
        Me.ButtonFinalizar.UseVisualStyleBackColor = True
        '
        'NuevoCriterioVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 617)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NuevoCriterioVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "NuevoCriterioVenta"
        Me.Text = "Nuevo Criterio de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriosventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CriteriosventaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriosventaproductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRangos.ResumeLayout(False)
        Me.GroupBoxRangos.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents CriteriosventaBindingSource As BindingSource
    Friend WithEvents CriteriosventaTableAdapter As comercialDataSetTableAdapters.criteriosventaTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents IdcriterioventaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents FechadesdeDateTimePicker As DateTimePicker
    Friend WithEvents FechahastaDateTimePicker As DateTimePicker
    Friend WithEvents CantidaddisponibletotalTextBox As TextBox
    Friend WithEvents CantidadmaximaporclienteTextBox As TextBox
    Friend WithEvents CriteriosventaproductosTableAdapter As comercialDataSetTableAdapters.criteriosventaproductosTableAdapter
    Friend WithEvents CriteriosventaproductosBindingSource As BindingSource
    Friend WithEvents GroupBoxRegalos As GroupBox
    Friend WithEvents GroupBoxRangos As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents CriteriosventaproductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents ButtonFinalizar As Button
End Class

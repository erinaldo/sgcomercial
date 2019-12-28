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
        Me.ButtonFinalizar = New System.Windows.Forms.Button()
        Me.ButtonConfirmar = New System.Windows.Forms.Button()
        Me.GroupBoxRegalos = New System.Windows.Forms.GroupBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.CriteriosventaregalorangoDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxRangos = New System.Windows.Forms.GroupBox()
        Me.CriteriosventarangosDataGridView = New System.Windows.Forms.DataGridView()
        Me.AgregarRegalo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.CriteriosventaproductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.QuitarProducto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IdcriterioventaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.FechadesdeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechahastaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidaddisponibletotalTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadmaximaporclienteTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriosventaregalorangoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentajedescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproductoadescontar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriosventarangosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.idcriteriosventaproductos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriosventaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriosventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriteriosventaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventaTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CriteriosventaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventaproductosTableAdapter()
        Me.CriteriosventarangosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventarangosTableAdapter()
        Me.CriteriosventaregalorangoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.criteriosventaregalorangoTableAdapter()
        IdcriterioventaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        FechadesdeLabel = New System.Windows.Forms.Label()
        FechahastaLabel = New System.Windows.Forms.Label()
        CantidaddisponibletotalLabel = New System.Windows.Forms.Label()
        CantidadmaximaporclienteLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxRegalos.SuspendLayout()
        CType(Me.CriteriosventaregalorangoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRangos.SuspendLayout()
        CType(Me.CriteriosventarangosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBoxProductos.SuspendLayout()
        CType(Me.CriteriosventaproductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CriteriosventaregalorangoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriosventarangosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriosventaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriteriosventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(308, 17)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción:"
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
        'FechahastaLabel
        '
        FechahastaLabel.AutoSize = True
        FechahastaLabel.Location = New System.Drawing.Point(345, 74)
        FechahastaLabel.Name = "FechahastaLabel"
        FechahastaLabel.Size = New System.Drawing.Size(49, 17)
        FechahastaLabel.TabIndex = 6
        FechahastaLabel.Text = "Hasta:"
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
        'CantidadmaximaporclienteLabel
        '
        CantidadmaximaporclienteLabel.AutoSize = True
        CantidadmaximaporclienteLabel.Location = New System.Drawing.Point(203, 129)
        CantidadmaximaporclienteLabel.Name = "CantidadmaximaporclienteLabel"
        CantidadmaximaporclienteLabel.Size = New System.Drawing.Size(191, 17)
        CantidadmaximaporclienteLabel.TabIndex = 10
        CantidadmaximaporclienteLabel.Text = "Cantidad Máxima por Cliente:"
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
        Me.GroupBox1.Size = New System.Drawing.Size(906, 611)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ButtonFinalizar
        '
        Me.ButtonFinalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFinalizar.Location = New System.Drawing.Point(288, 563)
        Me.ButtonFinalizar.Name = "ButtonFinalizar"
        Me.ButtonFinalizar.Size = New System.Drawing.Size(331, 41)
        Me.ButtonFinalizar.TabIndex = 16
        Me.ButtonFinalizar.Tag = "Finalizar"
        Me.ButtonFinalizar.Text = "Finalizar"
        Me.ButtonFinalizar.UseVisualStyleBackColor = True
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
        'GroupBoxRegalos
        '
        Me.GroupBoxRegalos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRegalos.Controls.Add(Me.ToolStrip3)
        Me.GroupBoxRegalos.Controls.Add(Me.CriteriosventaregalorangoDataGridView)
        Me.GroupBoxRegalos.Location = New System.Drawing.Point(557, 385)
        Me.GroupBoxRegalos.Name = "GroupBoxRegalos"
        Me.GroupBoxRegalos.Size = New System.Drawing.Size(343, 172)
        Me.GroupBoxRegalos.TabIndex = 14
        Me.GroupBoxRegalos.TabStop = False
        Me.GroupBoxRegalos.Text = "Regalo del Rango Seleccionado"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AllowMerge = False
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(337, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'CriteriosventaregalorangoDataGridView
        '
        Me.CriteriosventaregalorangoDataGridView.AutoGenerateColumns = False
        Me.CriteriosventaregalorangoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CriteriosventaregalorangoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CriteriosventaregalorangoDataGridView.DataSource = Me.CriteriosventaregalorangoBindingSource
        Me.CriteriosventaregalorangoDataGridView.Location = New System.Drawing.Point(23, 48)
        Me.CriteriosventaregalorangoDataGridView.Name = "CriteriosventaregalorangoDataGridView"
        Me.CriteriosventaregalorangoDataGridView.RowTemplate.Height = 24
        Me.CriteriosventaregalorangoDataGridView.Size = New System.Drawing.Size(300, 118)
        Me.CriteriosventaregalorangoDataGridView.TabIndex = 0
        '
        'GroupBoxRangos
        '
        Me.GroupBoxRangos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxRangos.Controls.Add(Me.CriteriosventarangosDataGridView)
        Me.GroupBoxRangos.Controls.Add(Me.ToolStrip2)
        Me.GroupBoxRangos.Location = New System.Drawing.Point(6, 385)
        Me.GroupBoxRangos.Name = "GroupBoxRangos"
        Me.GroupBoxRangos.Size = New System.Drawing.Size(545, 172)
        Me.GroupBoxRangos.TabIndex = 13
        Me.GroupBoxRangos.TabStop = False
        Me.GroupBoxRangos.Text = "Rangos Según Cantidad"
        '
        'CriteriosventarangosDataGridView
        '
        Me.CriteriosventarangosDataGridView.AllowUserToAddRows = False
        Me.CriteriosventarangosDataGridView.AllowUserToDeleteRows = False
        Me.CriteriosventarangosDataGridView.AutoGenerateColumns = False
        Me.CriteriosventarangosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CriteriosventarangosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.desde, Me.hasta, Me.porcentajedescuento, Me.codigoproductoadescontar, Me.AgregarRegalo})
        Me.CriteriosventarangosDataGridView.DataSource = Me.CriteriosventarangosBindingSource
        Me.CriteriosventarangosDataGridView.Location = New System.Drawing.Point(6, 48)
        Me.CriteriosventarangosDataGridView.Name = "CriteriosventarangosDataGridView"
        Me.CriteriosventarangosDataGridView.ReadOnly = True
        Me.CriteriosventarangosDataGridView.RowTemplate.Height = 24
        Me.CriteriosventarangosDataGridView.Size = New System.Drawing.Size(527, 118)
        Me.CriteriosventarangosDataGridView.TabIndex = 1
        '
        'AgregarRegalo
        '
        Me.AgregarRegalo.DataPropertyName = "idcriterioventarango"
        Me.AgregarRegalo.HeaderText = ""
        Me.AgregarRegalo.Name = "AgregarRegalo"
        Me.AgregarRegalo.ReadOnly = True
        Me.AgregarRegalo.Text = "AgregarRegalo"
        Me.AgregarRegalo.ToolTipText = "AgregarRegalo"
        Me.AgregarRegalo.UseColumnTextForButtonValue = True
        Me.AgregarRegalo.Width = 150
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
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxProductos.Controls.Add(Me.CriteriosventaproductosDataGridView)
        Me.GroupBoxProductos.Controls.Add(Me.ToolStrip1)
        Me.GroupBoxProductos.Location = New System.Drawing.Point(6, 194)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Size = New System.Drawing.Size(894, 185)
        Me.GroupBoxProductos.TabIndex = 12
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Grupo de Productos"
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
        Me.CriteriosventaproductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcriteriosventaproductos, Me.codigoproducto, Me.DataGridViewTextBoxColumn3, Me.QuitarProducto})
        Me.CriteriosventaproductosDataGridView.DataSource = Me.CriteriosventaproductosBindingSource
        Me.CriteriosventaproductosDataGridView.Location = New System.Drawing.Point(6, 48)
        Me.CriteriosventaproductosDataGridView.Name = "CriteriosventaproductosDataGridView"
        Me.CriteriosventaproductosDataGridView.ReadOnly = True
        Me.CriteriosventaproductosDataGridView.RowTemplate.Height = 24
        Me.CriteriosventaproductosDataGridView.Size = New System.Drawing.Size(882, 123)
        Me.CriteriosventaproductosDataGridView.TabIndex = 1
        '
        'QuitarProducto
        '
        Me.QuitarProducto.DataPropertyName = "idcriteriosventaproductos"
        Me.QuitarProducto.HeaderText = "Quitar Producto"
        Me.QuitarProducto.Name = "QuitarProducto"
        Me.QuitarProducto.ReadOnly = True
        Me.QuitarProducto.Text = "Quitar Producto"
        Me.QuitarProducto.ToolTipText = "Quitar Producto"
        Me.QuitarProducto.UseColumnTextForButtonValue = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(888, 27)
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
        'IdcriterioventaTextBox
        '
        Me.IdcriterioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "idcriterioventa", True))
        Me.IdcriterioventaTextBox.Location = New System.Drawing.Point(107, 73)
        Me.IdcriterioventaTextBox.Name = "IdcriterioventaTextBox"
        Me.IdcriterioventaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdcriterioventaTextBox.TabIndex = 1
        Me.IdcriterioventaTextBox.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(402, 14)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DescripcionTextBox.TabIndex = 3
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
        'CantidaddisponibletotalTextBox
        '
        Me.CantidaddisponibletotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "cantidaddisponibletotal", True))
        Me.CantidaddisponibletotalTextBox.Location = New System.Drawing.Point(402, 98)
        Me.CantidaddisponibletotalTextBox.Name = "CantidaddisponibletotalTextBox"
        Me.CantidaddisponibletotalTextBox.Size = New System.Drawing.Size(75, 22)
        Me.CantidaddisponibletotalTextBox.TabIndex = 9
        '
        'CantidadmaximaporclienteTextBox
        '
        Me.CantidadmaximaporclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriteriosventaBindingSource, "cantidadmaximaporcliente", True))
        Me.CantidadmaximaporclienteTextBox.Location = New System.Drawing.Point(402, 126)
        Me.CantidadmaximaporclienteTextBox.Name = "CantidadmaximaporclienteTextBox"
        Me.CantidadmaximaporclienteTextBox.Size = New System.Drawing.Size(75, 22)
        Me.CantidadmaximaporclienteTextBox.TabIndex = 11
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idcriteriosventaregalorango"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idcriteriosventaregalorango"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idcriterioventa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idcriterioventa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idrangocriterioventa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idrangocriterioventa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cód. Producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Código Producto"
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ToolTipText = "Cantidad"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'CriteriosventaregalorangoBindingSource
        '
        Me.CriteriosventaregalorangoBindingSource.DataMember = "criteriosventaregalorango"
        Me.CriteriosventaregalorangoBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcriterioventarango"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idcriterioventarango"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idcriterioventa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idcriterioventa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'desde
        '
        Me.desde.DataPropertyName = "desde"
        Me.desde.HeaderText = "Desde"
        Me.desde.Name = "desde"
        Me.desde.ReadOnly = True
        '
        'hasta
        '
        Me.hasta.DataPropertyName = "hasta"
        Me.hasta.HeaderText = "Hasta"
        Me.hasta.Name = "hasta"
        Me.hasta.ReadOnly = True
        '
        'porcentajedescuento
        '
        Me.porcentajedescuento.DataPropertyName = "porcentajedescuento"
        Me.porcentajedescuento.HeaderText = "% Desc."
        Me.porcentajedescuento.Name = "porcentajedescuento"
        Me.porcentajedescuento.ReadOnly = True
        Me.porcentajedescuento.ToolTipText = "% Desc."
        '
        'codigoproductoadescontar
        '
        Me.codigoproductoadescontar.DataPropertyName = "codigoproductoadescontar"
        Me.codigoproductoadescontar.HeaderText = "Cód. Producto a descontar"
        Me.codigoproductoadescontar.Name = "codigoproductoadescontar"
        Me.codigoproductoadescontar.ReadOnly = True
        Me.codigoproductoadescontar.ToolTipText = "Cód. Producto a descontar"
        Me.codigoproductoadescontar.Visible = False
        Me.codigoproductoadescontar.Width = 200
        '
        'CriteriosventarangosBindingSource
        '
        Me.CriteriosventarangosBindingSource.DataMember = "criteriosventarangos"
        Me.CriteriosventarangosBindingSource.DataSource = Me.ComercialDataSet
        '
        'idcriteriosventaproductos
        '
        Me.idcriteriosventaproductos.DataPropertyName = "idcriteriosventaproductos"
        Me.idcriteriosventaproductos.HeaderText = "idcriteriosventaproductos"
        Me.idcriteriosventaproductos.Name = "idcriteriosventaproductos"
        Me.idcriteriosventaproductos.ReadOnly = True
        Me.idcriteriosventaproductos.Visible = False
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Cód. Producto"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.ToolTipText = "codigoproducto"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidadmaxima"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad Maxima cada Venta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Cantidad Maxima cada Venta"
        '
        'CriteriosventaproductosBindingSource
        '
        Me.CriteriosventaproductosBindingSource.DataMember = "criteriosventaproductos"
        Me.CriteriosventaproductosBindingSource.DataSource = Me.ComercialDataSet
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
        'CriteriosventaproductosTableAdapter
        '
        Me.CriteriosventaproductosTableAdapter.ClearBeforeFill = True
        '
        'CriteriosventarangosTableAdapter
        '
        Me.CriteriosventarangosTableAdapter.ClearBeforeFill = True
        '
        'CriteriosventaregalorangoTableAdapter
        '
        Me.CriteriosventaregalorangoTableAdapter.ClearBeforeFill = True
        '
        'NuevoCriterioVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 619)
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
        Me.GroupBoxRegalos.ResumeLayout(False)
        Me.GroupBoxRegalos.PerformLayout()
        CType(Me.CriteriosventaregalorangoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRangos.ResumeLayout(False)
        Me.GroupBoxRangos.PerformLayout()
        CType(Me.CriteriosventarangosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        CType(Me.CriteriosventaproductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CriteriosventaregalorangoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriosventarangosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriosventaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriteriosventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents ButtonFinalizar As Button
    Friend WithEvents idcriteriosventaproductos As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents QuitarProducto As DataGridViewButtonColumn
    Friend WithEvents CriteriosventarangosBindingSource As BindingSource
    Friend WithEvents CriteriosventarangosTableAdapter As comercialDataSetTableAdapters.criteriosventarangosTableAdapter
    Friend WithEvents CriteriosventarangosDataGridView As DataGridView
    Friend WithEvents CriteriosventaregalorangoBindingSource As BindingSource
    Friend WithEvents CriteriosventaregalorangoTableAdapter As comercialDataSetTableAdapters.criteriosventaregalorangoTableAdapter
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents CriteriosventaregalorangoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents desde As DataGridViewTextBoxColumn
    Friend WithEvents hasta As DataGridViewTextBoxColumn
    Friend WithEvents porcentajedescuento As DataGridViewTextBoxColumn
    Friend WithEvents codigoproductoadescontar As DataGridViewTextBoxColumn
    Friend WithEvents AgregarRegalo As DataGridViewButtonColumn
End Class

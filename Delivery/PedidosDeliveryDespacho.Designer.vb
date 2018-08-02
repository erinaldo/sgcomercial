<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDeliveryDespacho
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListapedidosdeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importepagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PedidosdeliverydetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListapedidosdeliveryDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PedidosdeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotesenviosdetalleDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotesenviosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxResponsables = New System.Windows.Forms.ComboBox()
        Me.ResponsablesdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotesenviosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotesenviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonAsignar = New System.Windows.Forms.Button()
        Me.LotesEnviosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.idloteenvio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpedidodelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idclienteventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ResponsablesdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.responsablesdeliveryTableAdapter()
        Me.LotesenviosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosTableAdapter()
        Me.LotesenviosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter()
        Me.PedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliveryTableAdapter()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listalotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listalotesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesTableAdapter()
        Me.listalotesdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listalotesdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesdetalleTableAdapter()
        Me.PedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter()
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListapedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosdeliveryDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosdetalleDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponsablesdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesEnviosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listalotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListapedidosdeliveryDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1118, 343)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listos para despacho"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(472, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtrar por Cliente"
        '
        'ListapedidosdeliveryDataGridView
        '
        Me.ListapedidosdeliveryDataGridView.AllowUserToAddRows = False
        Me.ListapedidosdeliveryDataGridView.AllowUserToDeleteRows = False
        Me.ListapedidosdeliveryDataGridView.AllowUserToResizeColumns = False
        Me.ListapedidosdeliveryDataGridView.AllowUserToResizeRows = False
        Me.ListapedidosdeliveryDataGridView.AutoGenerateColumns = False
        Me.ListapedidosdeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListapedidosdeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.agregar, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.idcliente, Me.importepagado, Me.montototal})
        Me.ListapedidosdeliveryDataGridView.DataSource = Me.ListapedidosdeliveryBindingSource
        Me.ListapedidosdeliveryDataGridView.Location = New System.Drawing.Point(14, 67)
        Me.ListapedidosdeliveryDataGridView.MultiSelect = False
        Me.ListapedidosdeliveryDataGridView.Name = "ListapedidosdeliveryDataGridView"
        Me.ListapedidosdeliveryDataGridView.ReadOnly = True
        Me.ListapedidosdeliveryDataGridView.RowTemplate.Height = 24
        Me.ListapedidosdeliveryDataGridView.Size = New System.Drawing.Size(1077, 256)
        Me.ListapedidosdeliveryDataGridView.TabIndex = 2
        '
        'agregar
        '
        Me.agregar.HeaderText = "Agregar a lote"
        Me.agregar.Name = "agregar"
        Me.agregar.ReadOnly = True
        Me.agregar.Text = "Agregar a lote"
        Me.agregar.ToolTipText = "Agregar a lote"
        Me.agregar.UseColumnTextForButtonValue = True
        Me.agregar.Width = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pedido N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha alta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nombretransporte"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "referencias"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Referencias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nombreprovincia"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'importepagado
        '
        Me.importepagado.DataPropertyName = "importepagado"
        Me.importepagado.HeaderText = "Importe pagado"
        Me.importepagado.Name = "importepagado"
        Me.importepagado.ReadOnly = True
        '
        'montototal
        '
        Me.montototal.DataPropertyName = "montototal"
        Me.montototal.HeaderText = "montototal"
        Me.montototal.Name = "montototal"
        Me.montototal.ReadOnly = True
        Me.montototal.Visible = False
        '
        'ListapedidosdeliveryBindingSource
        '
        Me.ListapedidosdeliveryBindingSource.DataMember = "listapedidosdelivery"
        Me.ListapedidosdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PedidosdeliverydetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.ListapedidosdeliveryDataGridView1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PedidosdeliveryDataGridView)
        Me.GroupBox2.Controls.Add(Me.LotesenviosdetalleDataGridView1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxResponsables)
        Me.GroupBox2.Controls.Add(Me.LotesenviosDataGridView)
        Me.GroupBox2.Controls.Add(Me.ButtonAsignar)
        Me.GroupBox2.Controls.Add(Me.LotesEnviosDetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1118, 291)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lote de pedidos"
        '
        'PedidosdeliverydetalleDataGridView
        '
        Me.PedidosdeliverydetalleDataGridView.AllowUserToAddRows = False
        Me.PedidosdeliverydetalleDataGridView.AllowUserToDeleteRows = False
        Me.PedidosdeliverydetalleDataGridView.AutoGenerateColumns = False
        Me.PedidosdeliverydetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdeliverydetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52})
        Me.PedidosdeliverydetalleDataGridView.DataSource = Me.PedidosdeliverydetalleBindingSource
        Me.PedidosdeliverydetalleDataGridView.Location = New System.Drawing.Point(1086, 51)
        Me.PedidosdeliverydetalleDataGridView.Name = "PedidosdeliverydetalleDataGridView"
        Me.PedidosdeliverydetalleDataGridView.ReadOnly = True
        Me.PedidosdeliverydetalleDataGridView.RowTemplate.Height = 24
        Me.PedidosdeliverydetalleDataGridView.Size = New System.Drawing.Size(26, 29)
        Me.PedidosdeliverydetalleDataGridView.TabIndex = 3
        Me.PedidosdeliverydetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn46.HeaderText = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn47.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn48.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn49.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn50.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn51.HeaderText = "recargo"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "idlistaprecio"
        Me.DataGridViewTextBoxColumn52.HeaderText = "idlistaprecio"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'PedidosdeliverydetalleBindingSource
        '
        Me.PedidosdeliverydetalleBindingSource.DataMember = "pedidosdeliverydetalle"
        Me.PedidosdeliverydetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListapedidosdeliveryDataGridView1
        '
        Me.ListapedidosdeliveryDataGridView1.AllowUserToAddRows = False
        Me.ListapedidosdeliveryDataGridView1.AllowUserToDeleteRows = False
        Me.ListapedidosdeliveryDataGridView1.AutoGenerateColumns = False
        Me.ListapedidosdeliveryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListapedidosdeliveryDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45})
        Me.ListapedidosdeliveryDataGridView1.DataSource = Me.ListapedidosdeliveryBindingSource
        Me.ListapedidosdeliveryDataGridView1.Location = New System.Drawing.Point(1054, 51)
        Me.ListapedidosdeliveryDataGridView1.Name = "ListapedidosdeliveryDataGridView1"
        Me.ListapedidosdeliveryDataGridView1.ReadOnly = True
        Me.ListapedidosdeliveryDataGridView1.RowTemplate.Height = 24
        Me.ListapedidosdeliveryDataGridView1.Size = New System.Drawing.Size(26, 29)
        Me.ListapedidosdeliveryDataGridView1.TabIndex = 3
        Me.ListapedidosdeliveryDataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn29.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn30.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "pagoesperado"
        Me.DataGridViewTextBoxColumn31.HeaderText = "pagoesperado"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn32.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn33.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn34.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "cuit"
        Me.DataGridViewTextBoxColumn35.HeaderText = "cuit"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn36.HeaderText = "email"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "nombretransporte"
        Me.DataGridViewTextBoxColumn37.HeaderText = "nombretransporte"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn38.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "referencias"
        Me.DataGridViewTextBoxColumn39.HeaderText = "referencias"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "nombreprovincia"
        Me.DataGridViewTextBoxColumn40.HeaderText = "nombreprovincia"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn41.HeaderText = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn42.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "montototal"
        Me.DataGridViewTextBoxColumn43.HeaderText = "montototal"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn44.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "importepagado"
        Me.DataGridViewTextBoxColumn45.HeaderText = "importepagado"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(882, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Responsable:"
        '
        'PedidosdeliveryDataGridView
        '
        Me.PedidosdeliveryDataGridView.AutoGenerateColumns = False
        Me.PedidosdeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.PedidosdeliveryDataGridView.DataSource = Me.PedidosdeliveryBindingSource
        Me.PedidosdeliveryDataGridView.Location = New System.Drawing.Point(1016, 51)
        Me.PedidosdeliveryDataGridView.Name = "PedidosdeliveryDataGridView"
        Me.PedidosdeliveryDataGridView.RowTemplate.Height = 24
        Me.PedidosdeliveryDataGridView.Size = New System.Drawing.Size(26, 29)
        Me.PedidosdeliveryDataGridView.TabIndex = 3
        Me.PedidosdeliveryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn18.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn20.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "idtransporte"
        Me.DataGridViewTextBoxColumn21.HeaderText = "idtransporte"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "iddomicilio"
        Me.DataGridViewTextBoxColumn22.HeaderText = "iddomicilio"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "pagoesperado"
        Me.DataGridViewTextBoxColumn23.HeaderText = "pagoesperado"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn24.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn25.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn26.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn27.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn28.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'PedidosdeliveryBindingSource
        '
        Me.PedidosdeliveryBindingSource.DataMember = "pedidosdelivery"
        Me.PedidosdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'LotesenviosdetalleDataGridView1
        '
        Me.LotesenviosdetalleDataGridView1.AutoGenerateColumns = False
        Me.LotesenviosdetalleDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LotesenviosdetalleDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.LotesenviosdetalleDataGridView1.DataSource = Me.LotesenviosdetalleBindingSource
        Me.LotesenviosdetalleDataGridView1.Location = New System.Drawing.Point(969, 51)
        Me.LotesenviosdetalleDataGridView1.Name = "LotesenviosdetalleDataGridView1"
        Me.LotesenviosdetalleDataGridView1.RowTemplate.Height = 24
        Me.LotesenviosdetalleDataGridView1.Size = New System.Drawing.Size(26, 29)
        Me.LotesenviosdetalleDataGridView1.TabIndex = 3
        Me.LotesenviosdetalleDataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idloteenviodetalle"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idloteenviodetalle"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn16.HeaderText = "idloteenvio"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn17.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'LotesenviosdetalleBindingSource
        '
        Me.LotesenviosdetalleBindingSource.DataMember = "lotesenviosdetalle"
        Me.LotesenviosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBoxResponsables
        '
        Me.ComboBoxResponsables.DataSource = Me.ResponsablesdeliveryBindingSource
        Me.ComboBoxResponsables.DisplayMember = "nombre"
        Me.ComboBoxResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxResponsables.FormattingEnabled = True
        Me.ComboBoxResponsables.Location = New System.Drawing.Point(879, 129)
        Me.ComboBoxResponsables.Name = "ComboBoxResponsables"
        Me.ComboBoxResponsables.Size = New System.Drawing.Size(216, 24)
        Me.ComboBoxResponsables.TabIndex = 2
        Me.ComboBoxResponsables.ValueMember = "idresponsable"
        '
        'ResponsablesdeliveryBindingSource
        '
        Me.ResponsablesdeliveryBindingSource.DataMember = "responsablesdelivery"
        Me.ResponsablesdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'LotesenviosDataGridView
        '
        Me.LotesenviosDataGridView.AutoGenerateColumns = False
        Me.LotesenviosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LotesenviosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.LotesenviosDataGridView.DataSource = Me.LotesenviosBindingSource
        Me.LotesenviosDataGridView.Location = New System.Drawing.Point(924, 51)
        Me.LotesenviosDataGridView.Name = "LotesenviosDataGridView"
        Me.LotesenviosDataGridView.RowTemplate.Height = 24
        Me.LotesenviosDataGridView.Size = New System.Drawing.Size(26, 29)
        Me.LotesenviosDataGridView.TabIndex = 3
        Me.LotesenviosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idloteenvio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idresponsableentrega"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idresponsableentrega"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechaasignacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechaasignacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'LotesenviosBindingSource
        '
        Me.LotesenviosBindingSource.DataMember = "lotesenvios"
        Me.LotesenviosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ButtonAsignar
        '
        Me.ButtonAsignar.Location = New System.Drawing.Point(879, 160)
        Me.ButtonAsignar.Name = "ButtonAsignar"
        Me.ButtonAsignar.Size = New System.Drawing.Size(216, 34)
        Me.ButtonAsignar.TabIndex = 1
        Me.ButtonAsignar.Text = "Asignar Lote"
        Me.ButtonAsignar.UseVisualStyleBackColor = True
        '
        'LotesEnviosDetalleDataGridView
        '
        Me.LotesEnviosDetalleDataGridView.AllowUserToAddRows = False
        Me.LotesEnviosDetalleDataGridView.AllowUserToDeleteRows = False
        Me.LotesEnviosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LotesEnviosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idloteenvio, Me.idpedidodelivery, Me.cliente, Me.direccion, Me.idclienteventa, Me.pagado})
        Me.LotesEnviosDetalleDataGridView.Location = New System.Drawing.Point(14, 33)
        Me.LotesEnviosDetalleDataGridView.Name = "LotesEnviosDetalleDataGridView"
        Me.LotesEnviosDetalleDataGridView.ReadOnly = True
        Me.LotesEnviosDetalleDataGridView.RowTemplate.Height = 24
        Me.LotesEnviosDetalleDataGridView.Size = New System.Drawing.Size(834, 242)
        Me.LotesEnviosDetalleDataGridView.TabIndex = 0
        '
        'idloteenvio
        '
        Me.idloteenvio.HeaderText = "Lote N°"
        Me.idloteenvio.Name = "idloteenvio"
        Me.idloteenvio.ReadOnly = True
        Me.idloteenvio.Visible = False
        '
        'idpedidodelivery
        '
        Me.idpedidodelivery.HeaderText = "Pedido N°"
        Me.idpedidodelivery.Name = "idpedidodelivery"
        Me.idpedidodelivery.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 250
        '
        'direccion
        '
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 300
        '
        'idclienteventa
        '
        Me.idclienteventa.HeaderText = "idclienteventa"
        Me.idclienteventa.Name = "idclienteventa"
        Me.idclienteventa.ReadOnly = True
        Me.idclienteventa.Visible = False
        '
        'pagado
        '
        Me.pagado.HeaderText = "pagado"
        Me.pagado.Name = "pagado"
        Me.pagado.ReadOnly = True
        Me.pagado.Visible = False
        '
        'ListapedidosdeliveryTableAdapter
        '
        Me.ListapedidosdeliveryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.productosTableAdapter = Nothing
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
        'ResponsablesdeliveryTableAdapter
        '
        Me.ResponsablesdeliveryTableAdapter.ClearBeforeFill = True
        '
        'LotesenviosTableAdapter
        '
        Me.LotesenviosTableAdapter.ClearBeforeFill = True
        '
        'LotesenviosdetalleTableAdapter
        '
        Me.LotesenviosdetalleTableAdapter.ClearBeforeFill = True
        '
        'PedidosdeliveryTableAdapter
        '
        Me.PedidosdeliveryTableAdapter.ClearBeforeFill = True
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
        'listalotesBindingSource
        '
        Me.listalotesBindingSource.DataMember = "listalotes"
        Me.listalotesBindingSource.DataSource = Me.ComercialDataSet
        '
        'listalotesTableAdapter
        '
        Me.listalotesTableAdapter.ClearBeforeFill = True
        '
        'listalotesdetalleBindingSource
        '
        Me.listalotesdetalleBindingSource.DataMember = "listalotesdetalle"
        Me.listalotesdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'listalotesdetalleTableAdapter
        '
        Me.listalotesdetalleTableAdapter.ClearBeforeFill = True
        '
        'PedidosdeliverydetalleTableAdapter
        '
        Me.PedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'VentasdetalleTableAdapter
        '
        Me.VentasdetalleTableAdapter.ClearBeforeFill = True
        '
        'PedidosDeliveryDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 672)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidosDeliveryDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PedidosDeliveryDespacho"
        Me.Text = "Despacho de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListapedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosdeliveryDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosdetalleDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponsablesdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesEnviosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listalotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListapedidosdeliveryBindingSource As BindingSource
    Friend WithEvents ListapedidosdeliveryTableAdapter As comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListapedidosdeliveryDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LotesEnviosDetalleDataGridView As DataGridView
    Friend WithEvents ComboBoxResponsables As ComboBox
    Friend WithEvents ButtonAsignar As Button
    Friend WithEvents ResponsablesdeliveryBindingSource As BindingSource
    Friend WithEvents ResponsablesdeliveryTableAdapter As comercialDataSetTableAdapters.responsablesdeliveryTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LotesenviosBindingSource As BindingSource
    Friend WithEvents LotesenviosTableAdapter As comercialDataSetTableAdapters.lotesenviosTableAdapter
    Friend WithEvents LotesenviosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents LotesenviosdetalleBindingSource As BindingSource
    Friend WithEvents LotesenviosdetalleTableAdapter As comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter
    Friend WithEvents LotesenviosdetalleDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents PedidosdeliveryBindingSource As BindingSource
    Friend WithEvents PedidosdeliveryTableAdapter As comercialDataSetTableAdapters.pedidosdeliveryTableAdapter
    Friend WithEvents PedidosdeliveryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents listalotesBindingSource As BindingSource
    Friend WithEvents listalotesdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listalotesTableAdapter As comercialDataSetTableAdapters.listalotesTableAdapter
    Friend WithEvents listalotesdetalleTableAdapter As comercialDataSetTableAdapters.listalotesdetalleTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents agregar As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents importepagado As DataGridViewTextBoxColumn
    Friend WithEvents montototal As DataGridViewTextBoxColumn
    Friend WithEvents ListapedidosdeliveryDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents PedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents PedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter
    Friend WithEvents PedidosdeliverydetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents VentasdetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents idloteenvio As DataGridViewTextBoxColumn
    Friend WithEvents idpedidodelivery As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents idclienteventa As DataGridViewTextBoxColumn
    Friend WithEvents pagado As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim FechaventaLabel As System.Windows.Forms.Label
        Dim IdformapagoLabel As System.Windows.Forms.Label
        Dim IdtipocomprobanteLabel As System.Windows.Forms.Label
        Dim NrocomprobanteLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarVenta))
        Me.BtnNueva = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.stockdisp = New System.Windows.Forms.Label()
        Me.Labelproducto = New System.Windows.Forms.Label()
        Me.codigotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VentasdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.codproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.listasprecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FechavencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NrocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.labelcliente = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Idtipocomprobantecombo = New System.Windows.Forms.ComboBox()
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.idformapagocombo = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxVale = New System.Windows.Forms.CheckBox()
        Me.LabelTotalVisible = New System.Windows.Forms.Label()
        Me.BtnDescuento = New System.Windows.Forms.Button()
        Me.vueltotextbox = New System.Windows.Forms.TextBox()
        Me.LabelVuelto = New System.Windows.Forms.Label()
        Me.pagotextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.PermisosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.permisosTableAdapter()
        Me.ValesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.valesTableAdapter()
        Me.ListaspreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaspreciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaspreciosTableAdapter()
        Me.GFP2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxFP2 = New System.Windows.Forms.CheckBox()
        Me.NrocomprobanteTextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelMontoFP2 = New System.Windows.Forms.Label()
        Me.pagotextbox2 = New System.Windows.Forms.TextBox()
        Me.idformapagocombo2 = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        FechaventaLabel = New System.Windows.Forms.Label()
        IdformapagoLabel = New System.Windows.Forms.Label()
        IdtipocomprobanteLabel = New System.Windows.Forms.Label()
        NrocomprobanteLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GFP2.SuspendLayout()
        CType(Me.FormaspagoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(9, 30)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 2
        IdclienteLabel.Text = "N° Cliente:"
        '
        'FechaventaLabel
        '
        FechaventaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(556, 82)
        FechaventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(92, 17)
        FechaventaLabel.TabIndex = 11
        FechaventaLabel.Text = "Fecha Venta:"
        '
        'IdformapagoLabel
        '
        IdformapagoLabel.AutoSize = True
        IdformapagoLabel.Location = New System.Drawing.Point(9, 121)
        IdformapagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdformapagoLabel.Name = "IdformapagoLabel"
        IdformapagoLabel.Size = New System.Drawing.Size(89, 17)
        IdformapagoLabel.TabIndex = 13
        IdformapagoLabel.Text = "Forma Pago:"
        '
        'IdtipocomprobanteLabel
        '
        IdtipocomprobanteLabel.AutoSize = True
        IdtipocomprobanteLabel.Location = New System.Drawing.Point(9, 82)
        IdtipocomprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdtipocomprobanteLabel.Name = "IdtipocomprobanteLabel"
        IdtipocomprobanteLabel.Size = New System.Drawing.Size(129, 17)
        IdtipocomprobanteLabel.TabIndex = 15
        IdtipocomprobanteLabel.Text = "Tipo Comprobante:"
        '
        'NrocomprobanteLabel
        '
        NrocomprobanteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NrocomprobanteLabel.AutoSize = True
        NrocomprobanteLabel.Location = New System.Drawing.Point(312, 121)
        NrocomprobanteLabel.Name = "NrocomprobanteLabel"
        NrocomprobanteLabel.Size = New System.Drawing.Size(117, 17)
        NrocomprobanteLabel.TabIndex = 17
        NrocomprobanteLabel.Text = "N° Comprobante:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(37, 32)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(89, 17)
        Label2.TabIndex = 14
        Label2.Text = "Forma Pago:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(693, 32)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(117, 17)
        Label7.TabIndex = 19
        Label7.Text = "N° Comprobante:"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(567, 121)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(76, 17)
        Label5.TabIndex = 19
        Label5.Text = "Fecha Vto."
        '
        'BtnNueva
        '
        Me.BtnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueva.Location = New System.Drawing.Point(33, 24)
        Me.BtnNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(133, 30)
        Me.BtnNueva.TabIndex = 0
        Me.BtnNueva.Text = "Nueva (F1)"
        Me.BtnNueva.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnNueva)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 155)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(152, 134)
        Me.StockDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(24, 15)
        Me.StockDataGridView.TabIndex = 5
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "idstock"
        Me.DataGridViewTextBoxColumn29.HeaderText = "idstock"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn30.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn31.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "fechamovimiento"
        Me.DataGridViewTextBoxColumn32.HeaderText = "fechamovimiento"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn33.HeaderText = "fechacarga"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn34.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn35.HeaderText = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(120, 134)
        Me.CajasoperacionesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(24, 15)
        Me.CajasoperacionesDataGridView.TabIndex = 5
        Me.CajasoperacionesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "idoperacion"
        Me.DataGridViewTextBoxColumn23.HeaderText = "idoperacion"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn24.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn25.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "idgastos"
        Me.DataGridViewTextBoxColumn26.HeaderText = "idgastos"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn27.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn28.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn17})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(56, 134)
        Me.CajaseventosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(24, 15)
        Me.CajaseventosDataGridView.TabIndex = 4
        Me.CajaseventosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idcaja"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idcaja"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaapertura"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaapertura"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "saldoinicial"
        Me.DataGridViewTextBoxColumn5.HeaderText = "saldoinicial"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "saldofinal"
        Me.DataGridViewTextBoxColumn17.HeaderText = "saldofinal"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(24, 134)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(24, 15)
        Me.ProductosDataGridView.TabIndex = 3
        Me.ProductosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn6.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn9.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn10.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn15.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(33, 101)
        Me.BtnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(133, 30)
        Me.BtnConfirmar.TabIndex = 2
        Me.BtnConfirmar.Text = "Confirmar (F3)"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(33, 62)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(133, 30)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar (F2)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.stockdisp)
        Me.GroupBox2.Controls.Add(Me.Labelproducto)
        Me.GroupBox2.Controls.Add(Me.codigotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.VentasdetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 163)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1028, 355)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Búsqueda manual (F4)"
        Me.PictureBox1.AccessibleName = "Búsqueda manual (F4)"
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.manual
        Me.PictureBox1.Location = New System.Drawing.Point(314, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Búsqueda manual"
        '
        'stockdisp
        '
        Me.stockdisp.AutoSize = True
        Me.stockdisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockdisp.Location = New System.Drawing.Point(717, 29)
        Me.stockdisp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.stockdisp.Name = "stockdisp"
        Me.stockdisp.Size = New System.Drawing.Size(62, 20)
        Me.stockdisp.TabIndex = 4
        Me.stockdisp.Text = "Stock:"
        '
        'Labelproducto
        '
        Me.Labelproducto.AutoSize = True
        Me.Labelproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelproducto.Location = New System.Drawing.Point(344, 26)
        Me.Labelproducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelproducto.Name = "Labelproducto"
        Me.Labelproducto.Size = New System.Drawing.Size(82, 20)
        Me.Labelproducto.TabIndex = 3
        Me.Labelproducto.Text = "producto"
        '
        'codigotextbox
        '
        Me.codigotextbox.Location = New System.Drawing.Point(173, 25)
        Me.codigotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigotextbox.Name = "codigotextbox"
        Me.codigotextbox.Size = New System.Drawing.Size(132, 23)
        Me.codigotextbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. Producto:"
        '
        'VentasdetalleDataGridView
        '
        Me.VentasdetalleDataGridView.AllowUserToAddRows = False
        Me.VentasdetalleDataGridView.AllowUserToDeleteRows = False
        Me.VentasdetalleDataGridView.AllowUserToResizeColumns = False
        Me.VentasdetalleDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        Me.VentasdetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VentasdetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentasdetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codproducto, Me.descripcion, Me.cantidad, Me.precioventa, Me.descuento, Me.subtotal, Me.eliminar, Me.listasprecios})
        Me.VentasdetalleDataGridView.Location = New System.Drawing.Point(16, 58)
        Me.VentasdetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.VentasdetalleDataGridView.MultiSelect = False
        Me.VentasdetalleDataGridView.Name = "VentasdetalleDataGridView"
        Me.VentasdetalleDataGridView.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasdetalleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.VentasdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasdetalleDataGridView.Size = New System.Drawing.Size(991, 278)
        Me.VentasdetalleDataGridView.TabIndex = 0
        '
        'codproducto
        '
        Me.codproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.codproducto.HeaderText = "Cod. Producto"
        Me.codproducto.Name = "codproducto"
        Me.codproducto.ReadOnly = True
        Me.codproducto.Width = 70
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 350
        '
        'cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precioventa
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.precioventa.DefaultCellStyle = DataGridViewCellStyle3
        Me.precioventa.HeaderText = "Precio Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'descuento
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle4
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        '
        'subtotal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'eliminar
        '
        Me.eliminar.HeaderText = ""
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Text = "Quitar"
        Me.eliminar.UseColumnTextForButtonValue = True
        '
        'listasprecios
        '
        Me.listasprecios.HeaderText = "Lista de Precios"
        Me.listasprecios.Name = "listasprecios"
        Me.listasprecios.ReadOnly = True
        Me.listasprecios.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listasprecios.Visible = False
        '
        'VentasdetalleBindingSource
        '
        Me.VentasdetalleBindingSource.DataMember = "ventasdetalle"
        Me.VentasdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.FechavencimientoDateTimePicker)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(NrocomprobanteLabel)
        Me.GroupBox3.Controls.Add(Me.NrocomprobanteTextBox)
        Me.GroupBox3.Controls.Add(Me.labelcliente)
        Me.GroupBox3.Controls.Add(Me.Idtipocomprobantecombo)
        Me.GroupBox3.Controls.Add(IdtipocomprobanteLabel)
        Me.GroupBox3.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox3.Controls.Add(Me.idformapagocombo)
        Me.GroupBox3.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox3.Controls.Add(IdclienteLabel)
        Me.GroupBox3.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox3.Controls.Add(IdformapagoLabel)
        Me.GroupBox3.Controls.Add(FechaventaLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 5)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(820, 163)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta"
        '
        'FechavencimientoDateTimePicker
        '
        Me.FechavencimientoDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechavencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechavencimiento", True))
        Me.FechavencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechavencimientoDateTimePicker.Location = New System.Drawing.Point(653, 118)
        Me.FechavencimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechavencimientoDateTimePicker.Name = "FechavencimientoDateTimePicker"
        Me.FechavencimientoDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.FechavencimientoDateTimePicker.TabIndex = 20
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.ComercialDataSet
        '
        'NrocomprobanteTextBox
        '
        Me.NrocomprobanteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NrocomprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nrocomprobante", True))
        Me.NrocomprobanteTextBox.Location = New System.Drawing.Point(435, 118)
        Me.NrocomprobanteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NrocomprobanteTextBox.Name = "NrocomprobanteTextBox"
        Me.NrocomprobanteTextBox.Size = New System.Drawing.Size(123, 23)
        Me.NrocomprobanteTextBox.TabIndex = 18
        '
        'labelcliente
        '
        Me.labelcliente.AutoSize = True
        Me.labelcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelcliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.labelcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcliente.Location = New System.Drawing.Point(220, 27)
        Me.labelcliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelcliente.Name = "labelcliente"
        Me.labelcliente.Size = New System.Drawing.Size(2, 22)
        Me.labelcliente.TabIndex = 17
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'Idtipocomprobantecombo
        '
        Me.Idtipocomprobantecombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Idtipocomprobantecombo.DataSource = Me.TipocomprobantesBindingSource
        Me.Idtipocomprobantecombo.DisplayMember = "descripcion"
        Me.Idtipocomprobantecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idtipocomprobantecombo.FormattingEnabled = True
        Me.Idtipocomprobantecombo.Location = New System.Drawing.Point(140, 78)
        Me.Idtipocomprobantecombo.Margin = New System.Windows.Forms.Padding(4)
        Me.Idtipocomprobantecombo.Name = "Idtipocomprobantecombo"
        Me.Idtipocomprobantecombo.Size = New System.Drawing.Size(215, 25)
        Me.Idtipocomprobantecombo.TabIndex = 5
        Me.Idtipocomprobantecombo.ValueMember = "idtipocomprobante"
        '
        'TipocomprobantesBindingSource
        '
        Me.TipocomprobantesBindingSource.DataMember = "tipocomprobantes"
        Me.TipocomprobantesBindingSource.DataSource = Me.ComercialDataSet
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(181, 23)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 30)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 15
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'idformapagocombo
        '
        Me.idformapagocombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idformapagocombo.DataSource = Me.FormaspagoBindingSource
        Me.idformapagocombo.DisplayMember = "descripcion"
        Me.idformapagocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo.FormattingEnabled = True
        Me.idformapagocombo.Location = New System.Drawing.Point(100, 117)
        Me.idformapagocombo.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo.Name = "idformapagocombo"
        Me.idformapagocombo.Size = New System.Drawing.Size(201, 25)
        Me.idformapagocombo.TabIndex = 7
        Me.idformapagocombo.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(88, 24)
        Me.IdclienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(84, 23)
        Me.IdclienteTextBox.TabIndex = 4
        '
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechaventa", True))
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(653, 79)
        Me.FechaventaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.FechaventaDateTimePicker.TabIndex = 6
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Me.VentasdetalleTableAdapter
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'VentasdetalleTableAdapter
        '
        Me.VentasdetalleTableAdapter.ClearBeforeFill = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'TipocomprobantesTableAdapter
        '
        Me.TipocomprobantesTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.CheckBoxVale)
        Me.GroupBox4.Controls.Add(Me.LabelTotalVisible)
        Me.GroupBox4.Controls.Add(Me.BtnDescuento)
        Me.GroupBox4.Controls.Add(Me.vueltotextbox)
        Me.GroupBox4.Controls.Add(Me.LabelVuelto)
        Me.GroupBox4.Controls.Add(Me.pagotextbox)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.labeltotal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 520)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1028, 62)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen"
        '
        'CheckBoxVale
        '
        Me.CheckBoxVale.AutoSize = True
        Me.CheckBoxVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBoxVale.Location = New System.Drawing.Point(953, 24)
        Me.CheckBoxVale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxVale.Name = "CheckBoxVale"
        Me.CheckBoxVale.Size = New System.Drawing.Size(58, 22)
        Me.CheckBoxVale.TabIndex = 1
        Me.CheckBoxVale.Text = "Vale"
        Me.CheckBoxVale.UseVisualStyleBackColor = True
        '
        'LabelTotalVisible
        '
        Me.LabelTotalVisible.AutoSize = True
        Me.LabelTotalVisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotalVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalVisible.Location = New System.Drawing.Point(221, 27)
        Me.LabelTotalVisible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalVisible.Name = "LabelTotalVisible"
        Me.LabelTotalVisible.Size = New System.Drawing.Size(21, 22)
        Me.LabelTotalVisible.TabIndex = 10
        Me.LabelTotalVisible.Text = "$"
        Me.LabelTotalVisible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnDescuento
        '
        Me.BtnDescuento.Location = New System.Drawing.Point(21, 23)
        Me.BtnDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDescuento.Name = "BtnDescuento"
        Me.BtnDescuento.Size = New System.Drawing.Size(141, 30)
        Me.BtnDescuento.TabIndex = 9
        Me.BtnDescuento.Text = "Aplicar Descuento"
        Me.BtnDescuento.UseVisualStyleBackColor = True
        Me.BtnDescuento.Visible = False
        '
        'vueltotextbox
        '
        Me.vueltotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vueltotextbox.Location = New System.Drawing.Point(717, 22)
        Me.vueltotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.vueltotextbox.Name = "vueltotextbox"
        Me.vueltotextbox.ReadOnly = True
        Me.vueltotextbox.Size = New System.Drawing.Size(132, 26)
        Me.vueltotextbox.TabIndex = 0
        Me.vueltotextbox.TabStop = False
        Me.vueltotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelVuelto
        '
        Me.LabelVuelto.AutoSize = True
        Me.LabelVuelto.Location = New System.Drawing.Point(637, 28)
        Me.LabelVuelto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVuelto.Name = "LabelVuelto"
        Me.LabelVuelto.Size = New System.Drawing.Size(73, 17)
        Me.LabelVuelto.TabIndex = 6
        Me.LabelVuelto.Text = "Su Vuelto:"
        '
        'pagotextbox
        '
        Me.pagotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagotextbox.Location = New System.Drawing.Point(405, 22)
        Me.pagotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.pagotextbox.Name = "pagotextbox"
        Me.pagotextbox.Size = New System.Drawing.Size(132, 26)
        Me.pagotextbox.TabIndex = 0
        Me.pagotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Paga con:"
        '
        'labeltotal
        '
        Me.labeltotal.AutoSize = True
        Me.labeltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labeltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.Location = New System.Drawing.Point(251, 27)
        Me.labeltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(2, 22)
        Me.labeltotal.TabIndex = 2
        Me.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.labeltotal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(104, 138)
        Me.PagosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.Size = New System.Drawing.Size(24, 15)
        Me.PagosDataGridView.TabIndex = 4
        Me.PagosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn18.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn19.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn20.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn21.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fechapago"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fechapago"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'ValesTableAdapter
        '
        Me.ValesTableAdapter.ClearBeforeFill = True
        '
        'ListaspreciosBindingSource
        '
        Me.ListaspreciosBindingSource.DataMember = "listasprecios"
        Me.ListaspreciosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListaspreciosTableAdapter
        '
        Me.ListaspreciosTableAdapter.ClearBeforeFill = True
        '
        'GFP2
        '
        Me.GFP2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GFP2.Controls.Add(Me.CheckBoxFP2)
        Me.GFP2.Controls.Add(Label7)
        Me.GFP2.Controls.Add(Me.NrocomprobanteTextBox2)
        Me.GFP2.Controls.Add(Me.LabelMontoFP2)
        Me.GFP2.Controls.Add(Me.pagotextbox2)
        Me.GFP2.Controls.Add(Label2)
        Me.GFP2.Controls.Add(Me.idformapagocombo2)
        Me.GFP2.Location = New System.Drawing.Point(16, 584)
        Me.GFP2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GFP2.Name = "GFP2"
        Me.GFP2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GFP2.Size = New System.Drawing.Size(1028, 62)
        Me.GFP2.TabIndex = 5
        Me.GFP2.TabStop = False
        Me.GFP2.Text = "Segundo medio de pago"
        '
        'CheckBoxFP2
        '
        Me.CheckBoxFP2.AutoSize = True
        Me.CheckBoxFP2.Location = New System.Drawing.Point(12, 32)
        Me.CheckBoxFP2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxFP2.Name = "CheckBoxFP2"
        Me.CheckBoxFP2.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxFP2.TabIndex = 21
        Me.CheckBoxFP2.UseVisualStyleBackColor = True
        '
        'NrocomprobanteTextBox2
        '
        Me.NrocomprobanteTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nrocomprobante", True))
        Me.NrocomprobanteTextBox2.Enabled = False
        Me.NrocomprobanteTextBox2.Location = New System.Drawing.Point(816, 29)
        Me.NrocomprobanteTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NrocomprobanteTextBox2.Name = "NrocomprobanteTextBox2"
        Me.NrocomprobanteTextBox2.Size = New System.Drawing.Size(144, 23)
        Me.NrocomprobanteTextBox2.TabIndex = 20
        '
        'LabelMontoFP2
        '
        Me.LabelMontoFP2.AccessibleDescription = "Click para autocompletar el monto"
        Me.LabelMontoFP2.AutoSize = True
        Me.LabelMontoFP2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelMontoFP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMontoFP2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelMontoFP2.Location = New System.Drawing.Point(424, 32)
        Me.LabelMontoFP2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMontoFP2.Name = "LabelMontoFP2"
        Me.LabelMontoFP2.Size = New System.Drawing.Size(61, 18)
        Me.LabelMontoFP2.TabIndex = 16
        Me.LabelMontoFP2.Text = "Monto:"
        '
        'pagotextbox2
        '
        Me.pagotextbox2.Enabled = False
        Me.pagotextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagotextbox2.Location = New System.Drawing.Point(493, 27)
        Me.pagotextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.pagotextbox2.Name = "pagotextbox2"
        Me.pagotextbox2.Size = New System.Drawing.Size(132, 26)
        Me.pagotextbox2.TabIndex = 15
        Me.pagotextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'idformapagocombo2
        '
        Me.idformapagocombo2.DataSource = Me.FormaspagoBindingSource1
        Me.idformapagocombo2.DisplayMember = "descripcion"
        Me.idformapagocombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo2.Enabled = False
        Me.idformapagocombo2.FormattingEnabled = True
        Me.idformapagocombo2.Location = New System.Drawing.Point(133, 28)
        Me.idformapagocombo2.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo2.Name = "idformapagocombo2"
        Me.idformapagocombo2.Size = New System.Drawing.Size(201, 25)
        Me.idformapagocombo2.TabIndex = 8
        Me.idformapagocombo2.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource1
        '
        Me.FormaspagoBindingSource1.DataMember = "formaspago"
        Me.FormaspagoBindingSource1.DataSource = Me.ComercialDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(822, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Buscar producto (F4)"
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 651)
        Me.Controls.Add(Me.GFP2)
        Me.Controls.Add(Me.PagosDataGridView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Venta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GFP2.ResumeLayout(False)
        Me.GFP2.PerformLayout()
        CType(Me.FormaspagoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNueva As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasdetalleTableAdapter As sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents VentasdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasdetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents idformapagocombo As System.Windows.Forms.ComboBox
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaventaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FormaspagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaspagoTableAdapter As sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureSeleccionarCliente As System.Windows.Forms.PictureBox
    Friend WithEvents Idtipocomprobantecombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipocomprobantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipocomprobantesTableAdapter As sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents codigotextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Labelproducto As System.Windows.Forms.Label
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As sgcomercial.comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents labeltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelcliente As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents CajaseventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajaseventosTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents CajaseventosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vueltotextbox As System.Windows.Forms.TextBox
    Friend WithEvents LabelVuelto As System.Windows.Forms.Label
    Friend WithEvents pagotextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosTableAdapter As sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents PagosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasoperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasoperacionesTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents CajasoperacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As sgcomercial.comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stockdisp As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDescuento As System.Windows.Forms.Button
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents LabelTotalVisible As Label
    Friend WithEvents NrocomprobanteTextBox As TextBox
    Friend WithEvents CheckBoxVale As CheckBox
    Friend WithEvents PermisosTableAdapter As comercialDataSetTableAdapters.permisosTableAdapter
    Friend WithEvents ValesTableAdapter As comercialDataSetTableAdapters.valesTableAdapter
    Friend WithEvents ListaspreciosBindingSource As BindingSource
    Friend WithEvents ListaspreciosTableAdapter As comercialDataSetTableAdapters.listaspreciosTableAdapter
    Friend WithEvents GFP2 As GroupBox
    Friend WithEvents NrocomprobanteTextBox2 As TextBox
    Friend WithEvents LabelMontoFP2 As Label
    Friend WithEvents pagotextbox2 As TextBox
    Friend WithEvents idformapagocombo2 As ComboBox
    Friend WithEvents CheckBoxFP2 As CheckBox
    Friend WithEvents FormaspagoBindingSource1 As BindingSource
    Friend WithEvents FechavencimientoDateTimePicker As DateTimePicker
    Friend WithEvents codproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents listasprecios As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
End Class

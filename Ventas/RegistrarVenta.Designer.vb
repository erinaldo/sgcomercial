<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarVenta
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
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim IdtipocomprobanteLabel As System.Windows.Forms.Label
        Dim IdformapagoLabel As System.Windows.Forms.Label
        Dim NrocomprobanteLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim FechaventaLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim LabelDocumento As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim LabelIVA As System.Windows.Forms.Label
        Dim LabelEmail As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim LabelDocTipo As System.Windows.Forms.Label
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarVenta))
        Me.ListaclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNueva = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ContextMenuConfirmar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListaspreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelproducto = New System.Windows.Forms.Label()
        Me.codigotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VentasdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.codproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.listasprecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEditarCliente = New System.Windows.Forms.PictureBox()
        Me.ButtonDescuentoDefecto = New System.Windows.Forms.Button()
        Me.labelcliente = New System.Windows.Forms.Label()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxFE = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.PermisosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.permisosTableAdapter()
        Me.ValesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.valesTableAdapter()
        Me.ListaspreciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaspreciosTableAdapter()
        Me.GFP2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxFP2 = New System.Windows.Forms.CheckBox()
        Me.NrocomprobanteTextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelMontoFP2 = New System.Windows.Forms.Label()
        Me.pagotextbox2 = New System.Windows.Forms.TextBox()
        Me.idformapagocombo2 = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BackgroundSyncLibroventasClowd = New System.ComponentModel.BackgroundWorker()
        Me.BGWStockClowd = New System.ComponentModel.BackgroundWorker()
        Me.Idtipocomprobantecombo = New System.Windows.Forms.ComboBox()
        Me.idformapagocombo = New System.Windows.Forms.ComboBox()
        Me.ComboConcepto = New System.Windows.Forms.ComboBox()
        Me.TipoconceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NrocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.FechavencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerPeriodoHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerPeriodoDesde = New System.Windows.Forms.DateTimePicker()
        Me.ComercialDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoconceptosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipoconceptosTableAdapter()
        Me.ListaclientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaclientesTableAdapter()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ActivarDesactivarFacturaElectrónicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Articulos = New System.Windows.Forms.TabPage()
        Me.otrostributos = New System.Windows.Forms.TabPage()
        Me.BtnAgregarOT = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewOT = New System.Windows.Forms.DataGridView()
        Me.otdescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otdetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otbaseimponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otalicuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otimporta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oteliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        IdclienteLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        IdtipocomprobanteLabel = New System.Windows.Forms.Label()
        IdformapagoLabel = New System.Windows.Forms.Label()
        NrocomprobanteLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        FechaventaLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        LabelDocumento = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        LabelIVA = New System.Windows.Forms.Label()
        LabelEmail = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        LabelDocTipo = New System.Windows.Forms.Label()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuConfirmar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBoxFE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GFP2.SuspendLayout()
        CType(Me.FormaspagoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoconceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Articulos.SuspendLayout()
        Me.otrostributos.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridViewOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(9, 25)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 2
        IdclienteLabel.Text = "N° Cliente:"
        AddHandler IdclienteLabel.Click, AddressOf Me.IdclienteLabel_Click
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
        'IdtipocomprobanteLabel
        '
        IdtipocomprobanteLabel.AutoSize = True
        IdtipocomprobanteLabel.Location = New System.Drawing.Point(6, 26)
        IdtipocomprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdtipocomprobanteLabel.Name = "IdtipocomprobanteLabel"
        IdtipocomprobanteLabel.Size = New System.Drawing.Size(40, 17)
        IdtipocomprobanteLabel.TabIndex = 19
        IdtipocomprobanteLabel.Text = "Tipo:"
        '
        'IdformapagoLabel
        '
        IdformapagoLabel.AutoSize = True
        IdformapagoLabel.Location = New System.Drawing.Point(6, 91)
        IdformapagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdformapagoLabel.Name = "IdformapagoLabel"
        IdformapagoLabel.Size = New System.Drawing.Size(89, 17)
        IdformapagoLabel.TabIndex = 18
        IdformapagoLabel.Text = "Forma Pago:"
        '
        'NrocomprobanteLabel
        '
        NrocomprobanteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NrocomprobanteLabel.AutoSize = True
        NrocomprobanteLabel.Location = New System.Drawing.Point(226, 88)
        NrocomprobanteLabel.Name = "NrocomprobanteLabel"
        NrocomprobanteLabel.Size = New System.Drawing.Size(117, 17)
        NrocomprobanteLabel.TabIndex = 24
        NrocomprobanteLabel.Text = "N° Cbte. Externo:"
        NrocomprobanteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 59)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(72, 17)
        Label8.TabIndex = 23
        Label8.Text = "Concepto:"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(263, 55)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 17)
        Label5.TabIndex = 29
        Label5.Text = "Fecha Vto.:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FechaventaLabel
        '
        FechaventaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(251, 23)
        FechaventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(92, 17)
        FechaventaLabel.TabIndex = 28
        FechaventaLabel.Text = "Fecha Venta:"
        FechaventaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(9, 80)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(84, 17)
        Label9.TabIndex = 22
        Label9.Text = "Documento:"
        '
        'LabelDocumento
        '
        LabelDocumento.AutoSize = True
        LabelDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "docnro", True))
        LabelDocumento.Location = New System.Drawing.Point(147, 80)
        LabelDocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LabelDocumento.Name = "LabelDocumento"
        LabelDocumento.Size = New System.Drawing.Size(96, 17)
        LabelDocumento.TabIndex = 22
        LabelDocumento.Text = "___________"
        '
        'ListaclientesBindingSource
        '
        Me.ListaclientesBindingSource.DataMember = "listaclientes"
        Me.ListaclientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(9, 105)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(33, 17)
        Label11.TabIndex = 22
        Label11.Text = "IVA:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(9, 130)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(46, 17)
        Label12.TabIndex = 22
        Label12.Text = "Email:"
        '
        'LabelIVA
        '
        LabelIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LabelIVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "condicioniva", True))
        LabelIVA.Location = New System.Drawing.Point(50, 103)
        LabelIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LabelIVA.Name = "LabelIVA"
        LabelIVA.Size = New System.Drawing.Size(335, 19)
        LabelIVA.TabIndex = 22
        LabelIVA.Text = "_________________________________"
        '
        'LabelEmail
        '
        LabelEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LabelEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        LabelEmail.Location = New System.Drawing.Point(60, 131)
        LabelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New System.Drawing.Size(325, 17)
        LabelEmail.TabIndex = 22
        LabelEmail.Text = "_____________________________________"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(9, 55)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(62, 17)
        Label10.TabIndex = 22
        Label10.Text = "Nombre:"
        '
        'Label15
        '
        Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(294, 128)
        Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(49, 17)
        Label15.TabIndex = 31
        Label15.Text = "Hasta:"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(6, 128)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(174, 17)
        Label13.TabIndex = 32
        Label13.Text = "Periodo Facturado Desde:"
        '
        'LabelDocTipo
        '
        LabelDocTipo.AutoSize = True
        LabelDocTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "doctipo", True))
        LabelDocTipo.Location = New System.Drawing.Point(101, 80)
        LabelDocTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LabelDocTipo.Name = "LabelDocTipo"
        LabelDocTipo.Size = New System.Drawing.Size(40, 17)
        LabelDocTipo.TabIndex = 22
        LabelDocTipo.Text = "____"
        '
        'BtnNueva
        '
        Me.BtnNueva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueva.Location = New System.Drawing.Point(33, 24)
        Me.BtnNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(130, 30)
        Me.BtnNueva.TabIndex = 0
        Me.BtnNueva.Text = "Nueva (F1)"
        Me.BtnNueva.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PagosDataGridView)
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnNueva)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 163)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(14, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Buscar producto (F4)"
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(88, 135)
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
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.ComercialDataSet
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
        Me.BtnConfirmar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConfirmar.ContextMenuStrip = Me.ContextMenuConfirmar
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(33, 101)
        Me.BtnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(130, 30)
        Me.BtnConfirmar.TabIndex = 2
        Me.BtnConfirmar.Text = "Confirmar (F3)"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'ContextMenuConfirmar
        '
        Me.ContextMenuConfirmar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuConfirmar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPresupuestoToolStripMenuItem})
        Me.ContextMenuConfirmar.Name = "ContextMenuConfirmar"
        Me.ContextMenuConfirmar.Size = New System.Drawing.Size(215, 28)
        '
        'GenerarPresupuestoToolStripMenuItem
        '
        Me.GenerarPresupuestoToolStripMenuItem.Name = "GenerarPresupuestoToolStripMenuItem"
        Me.GenerarPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.GenerarPresupuestoToolStripMenuItem.Tag = "GenerarPresupuesto"
        Me.GenerarPresupuestoToolStripMenuItem.Text = "Generar Presupuesto"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(33, 62)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(130, 30)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar (F2)"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Labelproducto)
        Me.GroupBox2.Controls.Add(Me.codigotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.VentasdetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1080, 208)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ListaspreciosBindingSource
        Me.ComboBox1.DisplayMember = "descripcion"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(873, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 28)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "idlistaprecio"
        '
        'ListaspreciosBindingSource
        '
        Me.ListaspreciosBindingSource.DataMember = "listasprecios"
        Me.ListaspreciosBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(826, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Lista:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Búsqueda manual (F4)"
        Me.PictureBox1.AccessibleName = "Búsqueda manual (F4)"
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.manual
        Me.PictureBox1.Location = New System.Drawing.Point(314, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Búsqueda manual"
        '
        'Labelproducto
        '
        Me.Labelproducto.AutoSize = True
        Me.Labelproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelproducto.Location = New System.Drawing.Point(341, 21)
        Me.Labelproducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelproducto.Name = "Labelproducto"
        Me.Labelproducto.Size = New System.Drawing.Size(82, 20)
        Me.Labelproducto.TabIndex = 3
        Me.Labelproducto.Text = "producto"
        '
        'codigotextbox
        '
        Me.codigotextbox.Location = New System.Drawing.Point(173, 20)
        Me.codigotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigotextbox.Name = "codigotextbox"
        Me.codigotextbox.Size = New System.Drawing.Size(132, 26)
        Me.codigotextbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
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
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.GhostWhite
        Me.VentasdetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.VentasdetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentasdetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.VentasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codproducto, Me.descripcion, Me.cantidad, Me.precioventa, Me.descuento, Me.recargo, Me.subtotal, Me.eliminar, Me.listasprecios})
        Me.VentasdetalleDataGridView.Location = New System.Drawing.Point(5, 51)
        Me.VentasdetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.VentasdetalleDataGridView.MultiSelect = False
        Me.VentasdetalleDataGridView.Name = "VentasdetalleDataGridView"
        Me.VentasdetalleDataGridView.ReadOnly = True
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasdetalleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.VentasdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasdetalleDataGridView.Size = New System.Drawing.Size(1070, 149)
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
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle16
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 104
        '
        'precioventa
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.precioventa.DefaultCellStyle = DataGridViewCellStyle17
        Me.precioventa.HeaderText = "Precio Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        Me.precioventa.Width = 134
        '
        'descuento
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle18
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Width = 119
        '
        'recargo
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.recargo.DefaultCellStyle = DataGridViewCellStyle19
        Me.recargo.HeaderText = "Recargo"
        Me.recargo.Name = "recargo"
        Me.recargo.ReadOnly = True
        Me.recargo.Width = 101
        '
        'subtotal
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C2"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle20
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 109
        '
        'eliminar
        '
        Me.eliminar.HeaderText = ""
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Text = "Quitar"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 5
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
        Me.GroupBox3.Controls.Add(Me.PictureBoxEditarCliente)
        Me.GroupBox3.Controls.Add(LabelEmail)
        Me.GroupBox3.Controls.Add(LabelIVA)
        Me.GroupBox3.Controls.Add(LabelDocTipo)
        Me.GroupBox3.Controls.Add(LabelDocumento)
        Me.GroupBox3.Controls.Add(Label12)
        Me.GroupBox3.Controls.Add(Label11)
        Me.GroupBox3.Controls.Add(Label10)
        Me.GroupBox3.Controls.Add(Label9)
        Me.GroupBox3.Controls.Add(Me.ButtonDescuentoDefecto)
        Me.GroupBox3.Controls.Add(Me.labelcliente)
        Me.GroupBox3.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox3.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox3.Controls.Add(IdclienteLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(219, 26)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(403, 163)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'PictureBoxEditarCliente
        '
        Me.PictureBoxEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEditarCliente.Image = CType(resources.GetObject("PictureBoxEditarCliente.Image"), System.Drawing.Image)
        Me.PictureBoxEditarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxEditarCliente.Location = New System.Drawing.Point(172, 20)
        Me.PictureBoxEditarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxEditarCliente.Name = "PictureBoxEditarCliente"
        Me.PictureBoxEditarCliente.Size = New System.Drawing.Size(27, 26)
        Me.PictureBoxEditarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEditarCliente.TabIndex = 39
        Me.PictureBoxEditarCliente.TabStop = False
        Me.PictureBoxEditarCliente.Visible = False
        '
        'ButtonDescuentoDefecto
        '
        Me.ButtonDescuentoDefecto.Location = New System.Drawing.Point(199, 22)
        Me.ButtonDescuentoDefecto.Name = "ButtonDescuentoDefecto"
        Me.ButtonDescuentoDefecto.Size = New System.Drawing.Size(205, 23)
        Me.ButtonDescuentoDefecto.TabIndex = 21
        Me.ButtonDescuentoDefecto.Text = "Aplicar Descuento Automático"
        Me.ButtonDescuentoDefecto.UseVisualStyleBackColor = True
        Me.ButtonDescuentoDefecto.Visible = False
        '
        'labelcliente
        '
        Me.labelcliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelcliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.labelcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcliente.Location = New System.Drawing.Point(78, 52)
        Me.labelcliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelcliente.Name = "labelcliente"
        Me.labelcliente.Size = New System.Drawing.Size(307, 20)
        Me.labelcliente.TabIndex = 17
        Me.labelcliente.Text = "____________________________________"
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(141, 20)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(27, 27)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 15
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(78, 22)
        Me.IdclienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(54, 23)
        Me.IdclienteTextBox.TabIndex = 4
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.ComercialDataSet
        '
        'TipocomprobantesBindingSource
        '
        Me.TipocomprobantesBindingSource.DataMember = "tipocomprobantes"
        Me.TipocomprobantesBindingSource.DataSource = Me.ComercialDataSet
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
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
        Me.GroupBox4.Controls.Add(Me.PictureBoxFE)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.CheckBoxVale)
        Me.GroupBox4.Controls.Add(Me.LabelTotalVisible)
        Me.GroupBox4.Controls.Add(Me.BtnDescuento)
        Me.GroupBox4.Controls.Add(Me.vueltotextbox)
        Me.GroupBox4.Controls.Add(Me.LabelVuelto)
        Me.GroupBox4.Controls.Add(Me.pagotextbox)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.labeltotal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 447)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1096, 62)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen"
        '
        'PictureBoxFE
        '
        Me.PictureBoxFE.Image = Global.sgcomercial.My.Resources.Resources.FEAFIP_OFF
        Me.PictureBoxFE.Location = New System.Drawing.Point(912, 9)
        Me.PictureBoxFE.Name = "PictureBoxFE"
        Me.PictureBoxFE.Size = New System.Drawing.Size(178, 44)
        Me.PictureBoxFE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFE.TabIndex = 23
        Me.PictureBoxFE.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "CAE"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CheckBoxVale
        '
        Me.CheckBoxVale.AutoSize = True
        Me.CheckBoxVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBoxVale.Location = New System.Drawing.Point(856, 24)
        Me.CheckBoxVale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxVale.Name = "CheckBoxVale"
        Me.CheckBoxVale.Size = New System.Drawing.Size(58, 22)
        Me.CheckBoxVale.TabIndex = 1
        Me.CheckBoxVale.Text = "Vale"
        Me.CheckBoxVale.UseVisualStyleBackColor = True
        Me.CheckBoxVale.Visible = False
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
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
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
        Me.GFP2.Location = New System.Drawing.Point(16, 500)
        Me.GFP2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GFP2.Name = "GFP2"
        Me.GFP2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GFP2.Size = New System.Drawing.Size(1096, 73)
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
        'BackgroundSyncLibroventasClowd
        '
        '
        'BGWStockClowd
        '
        '
        'Idtipocomprobantecombo
        '
        Me.Idtipocomprobantecombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Idtipocomprobantecombo.DataSource = Me.TipocomprobantesBindingSource
        Me.Idtipocomprobantecombo.DisplayMember = "descripcion"
        Me.Idtipocomprobantecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idtipocomprobantecombo.FormattingEnabled = True
        Me.Idtipocomprobantecombo.Location = New System.Drawing.Point(48, 22)
        Me.Idtipocomprobantecombo.Margin = New System.Windows.Forms.Padding(4)
        Me.Idtipocomprobantecombo.Name = "Idtipocomprobantecombo"
        Me.Idtipocomprobantecombo.Size = New System.Drawing.Size(166, 25)
        Me.Idtipocomprobantecombo.TabIndex = 16
        Me.Idtipocomprobantecombo.ValueMember = "idtipocomprobante"
        '
        'idformapagocombo
        '
        Me.idformapagocombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idformapagocombo.DataSource = Me.FormaspagoBindingSource
        Me.idformapagocombo.DisplayMember = "descripcion"
        Me.idformapagocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo.FormattingEnabled = True
        Me.idformapagocombo.Location = New System.Drawing.Point(100, 87)
        Me.idformapagocombo.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo.Name = "idformapagocombo"
        Me.idformapagocombo.Size = New System.Drawing.Size(114, 25)
        Me.idformapagocombo.TabIndex = 17
        Me.idformapagocombo.ValueMember = "idformapago"
        '
        'ComboConcepto
        '
        Me.ComboConcepto.DataSource = Me.TipoconceptosBindingSource
        Me.ComboConcepto.DisplayMember = "descripción"
        Me.ComboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboConcepto.FormattingEnabled = True
        Me.ComboConcepto.Location = New System.Drawing.Point(82, 55)
        Me.ComboConcepto.Name = "ComboConcepto"
        Me.ComboConcepto.Size = New System.Drawing.Size(155, 25)
        Me.ComboConcepto.TabIndex = 26
        Me.ComboConcepto.ValueMember = "idtipoconcepto"
        '
        'TipoconceptosBindingSource
        '
        Me.TipoconceptosBindingSource.DataMember = "tipoconceptos"
        Me.TipoconceptosBindingSource.DataSource = Me.ComercialDataSet
        '
        'NrocomprobanteTextBox
        '
        Me.NrocomprobanteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NrocomprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "nrocomprobante", True))
        Me.NrocomprobanteTextBox.Location = New System.Drawing.Point(343, 85)
        Me.NrocomprobanteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NrocomprobanteTextBox.Name = "NrocomprobanteTextBox"
        Me.NrocomprobanteTextBox.Size = New System.Drawing.Size(112, 23)
        Me.NrocomprobanteTextBox.TabIndex = 25
        '
        'FechavencimientoDateTimePicker
        '
        Me.FechavencimientoDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechavencimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechavencimiento", True))
        Me.FechavencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechavencimientoDateTimePicker.Location = New System.Drawing.Point(343, 52)
        Me.FechavencimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechavencimientoDateTimePicker.Name = "FechavencimientoDateTimePicker"
        Me.FechavencimientoDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.FechavencimientoDateTimePicker.TabIndex = 30
        '
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechaventa", True))
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(343, 20)
        Me.FechaventaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.FechaventaDateTimePicker.TabIndex = 27
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.DateTimePickerPeriodoHasta)
        Me.GroupBox5.Controls.Add(Me.DateTimePickerPeriodoDesde)
        Me.GroupBox5.Controls.Add(Label15)
        Me.GroupBox5.Controls.Add(Label13)
        Me.GroupBox5.Controls.Add(IdtipocomprobanteLabel)
        Me.GroupBox5.Controls.Add(Me.FechavencimientoDateTimePicker)
        Me.GroupBox5.Controls.Add(Label5)
        Me.GroupBox5.Controls.Add(Me.Idtipocomprobantecombo)
        Me.GroupBox5.Controls.Add(Label8)
        Me.GroupBox5.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox5.Controls.Add(FechaventaLabel)
        Me.GroupBox5.Controls.Add(NrocomprobanteLabel)
        Me.GroupBox5.Controls.Add(Me.ComboConcepto)
        Me.GroupBox5.Controls.Add(IdformapagoLabel)
        Me.GroupBox5.Controls.Add(Me.idformapagocombo)
        Me.GroupBox5.Controls.Add(Me.NrocomprobanteTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(634, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(478, 163)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Comprobante"
        '
        'DateTimePickerPeriodoHasta
        '
        Me.DateTimePickerPeriodoHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerPeriodoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechaventa", True))
        Me.DateTimePickerPeriodoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPeriodoHasta.Location = New System.Drawing.Point(343, 125)
        Me.DateTimePickerPeriodoHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerPeriodoHasta.Name = "DateTimePickerPeriodoHasta"
        Me.DateTimePickerPeriodoHasta.Size = New System.Drawing.Size(112, 23)
        Me.DateTimePickerPeriodoHasta.TabIndex = 34
        '
        'DateTimePickerPeriodoDesde
        '
        Me.DateTimePickerPeriodoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerPeriodoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fechaventa", True))
        Me.DateTimePickerPeriodoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPeriodoDesde.Location = New System.Drawing.Point(181, 125)
        Me.DateTimePickerPeriodoDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerPeriodoDesde.Name = "DateTimePickerPeriodoDesde"
        Me.DateTimePickerPeriodoDesde.Size = New System.Drawing.Size(112, 23)
        Me.DateTimePickerPeriodoDesde.TabIndex = 33
        '
        'ComercialDataSetBindingSource
        '
        Me.ComercialDataSetBindingSource.DataSource = Me.ComercialDataSet
        Me.ComercialDataSetBindingSource.Position = 0
        '
        'TipoconceptosTableAdapter
        '
        Me.TipoconceptosTableAdapter.ClearBeforeFill = True
        '
        'ListaclientesTableAdapter
        '
        Me.ListaclientesTableAdapter.ClearBeforeFill = True
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.AllowMerge = False
        Me.MainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivarDesactivarFacturaElectrónicaToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(1127, 28)
        Me.MainMenuStrip.TabIndex = 32
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'ActivarDesactivarFacturaElectrónicaToolStripMenuItem
        '
        Me.ActivarDesactivarFacturaElectrónicaToolStripMenuItem.Name = "ActivarDesactivarFacturaElectrónicaToolStripMenuItem"
        Me.ActivarDesactivarFacturaElectrónicaToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.ActivarDesactivarFacturaElectrónicaToolStripMenuItem.Text = "Activar Factura Electrónica"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.Articulos)
        Me.TabControl.Controls.Add(Me.otrostributos)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl.Location = New System.Drawing.Point(16, 195)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1099, 254)
        Me.TabControl.TabIndex = 33
        '
        'Articulos
        '
        Me.Articulos.Controls.Add(Me.GroupBox2)
        Me.Articulos.Location = New System.Drawing.Point(4, 29)
        Me.Articulos.Name = "Articulos"
        Me.Articulos.Padding = New System.Windows.Forms.Padding(3)
        Me.Articulos.Size = New System.Drawing.Size(1091, 221)
        Me.Articulos.TabIndex = 0
        Me.Articulos.Text = "Artículos"
        Me.Articulos.UseVisualStyleBackColor = True
        '
        'otrostributos
        '
        Me.otrostributos.Controls.Add(Me.BtnAgregarOT)
        Me.otrostributos.Controls.Add(Me.GroupBox6)
        Me.otrostributos.Location = New System.Drawing.Point(4, 29)
        Me.otrostributos.Name = "otrostributos"
        Me.otrostributos.Padding = New System.Windows.Forms.Padding(3)
        Me.otrostributos.Size = New System.Drawing.Size(1091, 221)
        Me.otrostributos.TabIndex = 1
        Me.otrostributos.Text = "Otros Tributos"
        Me.otrostributos.UseVisualStyleBackColor = True
        '
        'BtnAgregarOT
        '
        Me.BtnAgregarOT.Location = New System.Drawing.Point(425, 11)
        Me.BtnAgregarOT.Name = "BtnAgregarOT"
        Me.BtnAgregarOT.Size = New System.Drawing.Size(240, 29)
        Me.BtnAgregarOT.TabIndex = 1
        Me.BtnAgregarOT.Text = "Agregar Otro Tributo"
        Me.BtnAgregarOT.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridViewOT)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1079, 179)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'DataGridViewOT
        '
        Me.DataGridViewOT.AllowUserToAddRows = False
        Me.DataGridViewOT.AllowUserToDeleteRows = False
        Me.DataGridViewOT.AllowUserToResizeColumns = False
        Me.DataGridViewOT.AllowUserToResizeRows = False
        Me.DataGridViewOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewOT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.otdescripcion, Me.otdetalle, Me.otbaseimponible, Me.otalicuota, Me.otimporta, Me.oteliminar})
        Me.DataGridViewOT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewOT.Location = New System.Drawing.Point(3, 22)
        Me.DataGridViewOT.Name = "DataGridViewOT"
        Me.DataGridViewOT.RowTemplate.Height = 24
        Me.DataGridViewOT.Size = New System.Drawing.Size(1073, 154)
        Me.DataGridViewOT.TabIndex = 0
        '
        'otdescripcion
        '
        Me.otdescripcion.HeaderText = "Descripción"
        Me.otdescripcion.Name = "otdescripcion"
        '
        'otdetalle
        '
        Me.otdetalle.HeaderText = "Detalle"
        Me.otdetalle.Name = "otdetalle"
        '
        'otbaseimponible
        '
        Me.otbaseimponible.HeaderText = "Base Imponible"
        Me.otbaseimponible.Name = "otbaseimponible"
        '
        'otalicuota
        '
        Me.otalicuota.HeaderText = "Alícuota"
        Me.otalicuota.Name = "otalicuota"
        '
        'otimporta
        '
        Me.otimporta.HeaderText = "Importe"
        Me.otimporta.Name = "otimporta"
        '
        'oteliminar
        '
        Me.oteliminar.HeaderText = ""
        Me.oteliminar.Name = "oteliminar"
        Me.oteliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.oteliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.oteliminar.Text = "Eliminar"
        Me.oteliminar.UseColumnTextForButtonValue = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1073, 154)
        Me.DataGridView1.TabIndex = 0
        '
        'RegistrarVenta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1127, 578)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GFP2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Venta"
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuConfirmar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBoxFE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GFP2.ResumeLayout(False)
        Me.GFP2.PerformLayout()
        CType(Me.FormaspagoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoconceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.Articulos.ResumeLayout(False)
        Me.otrostributos.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridViewOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormaspagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaspagoTableAdapter As sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureSeleccionarCliente As System.Windows.Forms.PictureBox
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDescuento As System.Windows.Forms.Button
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents LabelTotalVisible As Label
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
    Friend WithEvents Label6 As Label
    Friend WithEvents codproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents recargo As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents listasprecios As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundSyncLibroventasClowd As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonDescuentoDefecto As Button
    Friend WithEvents BGWStockClowd As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuConfirmar As ContextMenuStrip
    Friend WithEvents GenerarPresupuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Idtipocomprobantecombo As ComboBox
    Friend WithEvents idformapagocombo As ComboBox
    Friend WithEvents ComboConcepto As ComboBox
    Friend WithEvents NrocomprobanteTextBox As TextBox
    Friend WithEvents FechavencimientoDateTimePicker As DateTimePicker
    Friend WithEvents FechaventaDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DateTimePickerPeriodoHasta As DateTimePicker
    Friend WithEvents DateTimePickerPeriodoDesde As DateTimePicker
    Friend WithEvents ComercialDataSetBindingSource As BindingSource
    Friend WithEvents TipoconceptosBindingSource As BindingSource
    Friend WithEvents TipoconceptosTableAdapter As comercialDataSetTableAdapters.tipoconceptosTableAdapter
    Friend WithEvents ListaclientesBindingSource As BindingSource
    Friend WithEvents ListaclientesTableAdapter As comercialDataSetTableAdapters.listaclientesTableAdapter
    Friend WithEvents PictureBoxEditarCliente As PictureBox
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents ActivarDesactivarFacturaElectrónicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxFE As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents Articulos As TabPage
    Friend WithEvents otrostributos As TabPage
    Friend WithEvents BtnAgregarOT As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents otdescripcion As DataGridViewTextBoxColumn
    Friend WithEvents otdetalle As DataGridViewTextBoxColumn
    Friend WithEvents otbaseimponible As DataGridViewTextBoxColumn
    Friend WithEvents otalicuota As DataGridViewTextBoxColumn
    Friend WithEvents otimporta As DataGridViewTextBoxColumn
    Friend WithEvents oteliminar As DataGridViewButtonColumn
    Friend WithEvents DataGridViewOT As DataGridView
End Class

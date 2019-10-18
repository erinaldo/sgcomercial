<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdmOrdenes
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
        Dim IdtipocomprobanteLabel As System.Windows.Forms.Label
        Dim IdformapagoLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmOrdenes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaÓrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListamesasestadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.idsalon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idmesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pendientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListamesasestadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ListaordenesmesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.idordenmesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idlistaprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaordenesmesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMesa = New System.Windows.Forms.ComboBox()
        Me.MesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxSalon = New System.Windows.Forms.ComboBox()
        Me.SalonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesmesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MozosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalonesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.salonesTableAdapter()
        Me.MesasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mesasTableAdapter()
        Me.MozosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mozosTableAdapter()
        Me.ListaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaproductosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ParametrosgeneralesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ParametrosgeneralesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBoxFP2 = New System.Windows.Forms.CheckBox()
        Me.VentasdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NrocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idformapagocombo = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Idtipocomprobantecombo = New System.Windows.Forms.ComboBox()
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBoxEditarCliente = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.LabelMESA = New System.Windows.Forms.Label()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListaclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularMesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.OrdenesmesasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ordenesmesasTableAdapter()
        Me.ListaordenesmesaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaordenesmesaTableAdapter()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.ListaclientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaclientesTableAdapter()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.ListamesasestadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listamesasestadosTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        IdtipocomprobanteLabel = New System.Windows.Forms.Label()
        IdformapagoLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListamesasestadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListamesasestadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaordenesmesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaordenesmesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesmesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdtipocomprobanteLabel
        '
        IdtipocomprobanteLabel.AutoSize = True
        IdtipocomprobanteLabel.Location = New System.Drawing.Point(20, 274)
        IdtipocomprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdtipocomprobanteLabel.Name = "IdtipocomprobanteLabel"
        IdtipocomprobanteLabel.Size = New System.Drawing.Size(77, 17)
        IdtipocomprobanteLabel.TabIndex = 42
        IdtipocomprobanteLabel.Text = "Cbte. Tipo:"
        '
        'IdformapagoLabel
        '
        IdformapagoLabel.AutoSize = True
        IdformapagoLabel.Location = New System.Drawing.Point(8, 308)
        IdformapagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdformapagoLabel.Name = "IdformapagoLabel"
        IdformapagoLabel.Size = New System.Drawing.Size(89, 17)
        IdformapagoLabel.TabIndex = 44
        IdformapagoLabel.Text = "Forma Pago:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(36, 343)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(61, 17)
        Label6.TabIndex = 44
        Label6.Text = "Cbte. N°"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaÓrdenToolStripMenuItem, Me.AnularOrdenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 576)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaÓrdenToolStripMenuItem
        '
        Me.NuevaÓrdenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NuevaÓrdenToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.NuevaÓrdenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.NuevaÓrdenToolStripMenuItem.Name = "NuevaÓrdenToolStripMenuItem"
        Me.NuevaÓrdenToolStripMenuItem.Size = New System.Drawing.Size(140, 52)
        Me.NuevaÓrdenToolStripMenuItem.Text = "Nueva Orden"
        Me.NuevaÓrdenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnularOrdenToolStripMenuItem
        '
        Me.AnularOrdenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AnularOrdenToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.AnularOrdenToolStripMenuItem.Name = "AnularOrdenToolStripMenuItem"
        Me.AnularOrdenToolStripMenuItem.Size = New System.Drawing.Size(141, 52)
        Me.AnularOrdenToolStripMenuItem.Text = "Anular Orden"
        Me.AnularOrdenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListamesasestadosDataGridView)
        Me.GroupBox1.Controls.Add(Me.ListaordenesmesaDataGridView)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMesa)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSalon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 635)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'ListamesasestadosDataGridView
        '
        Me.ListamesasestadosDataGridView.AllowUserToAddRows = False
        Me.ListamesasestadosDataGridView.AllowUserToDeleteRows = False
        Me.ListamesasestadosDataGridView.AllowUserToResizeColumns = False
        Me.ListamesasestadosDataGridView.AllowUserToResizeRows = False
        Me.ListamesasestadosDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListamesasestadosDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListamesasestadosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListamesasestadosDataGridView.ColumnHeadersHeight = 42
        Me.ListamesasestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ListamesasestadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsalon, Me.idmesa, Me.pendientes})
        Me.ListamesasestadosDataGridView.DataSource = Me.ListamesasestadosBindingSource
        Me.ListamesasestadosDataGridView.Location = New System.Drawing.Point(6, 79)
        Me.ListamesasestadosDataGridView.Name = "ListamesasestadosDataGridView"
        Me.ListamesasestadosDataGridView.ReadOnly = True
        Me.ListamesasestadosDataGridView.RowHeadersVisible = False
        Me.ListamesasestadosDataGridView.RowHeadersWidth = 55
        Me.ListamesasestadosDataGridView.RowTemplate.Height = 42
        Me.ListamesasestadosDataGridView.Size = New System.Drawing.Size(74, 494)
        Me.ListamesasestadosDataGridView.TabIndex = 6
        '
        'idsalon
        '
        Me.idsalon.DataPropertyName = "idsalon"
        Me.idsalon.HeaderText = "idsalon"
        Me.idsalon.Name = "idsalon"
        Me.idsalon.ReadOnly = True
        Me.idsalon.Visible = False
        '
        'idmesa
        '
        Me.idmesa.DataPropertyName = "idmesa"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idmesa.DefaultCellStyle = DataGridViewCellStyle6
        Me.idmesa.HeaderText = "Mesa"
        Me.idmesa.Name = "idmesa"
        Me.idmesa.ReadOnly = True
        Me.idmesa.ToolTipText = "Mesa"
        Me.idmesa.Width = 71
        '
        'pendientes
        '
        Me.pendientes.DataPropertyName = "pendientes"
        Me.pendientes.HeaderText = "pendientes"
        Me.pendientes.Name = "pendientes"
        Me.pendientes.ReadOnly = True
        Me.pendientes.Visible = False
        '
        'ListamesasestadosBindingSource
        '
        Me.ListamesasestadosBindingSource.DataMember = "listamesasestados"
        Me.ListamesasestadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaordenesmesaDataGridView
        '
        Me.ListaordenesmesaDataGridView.AllowUserToAddRows = False
        Me.ListaordenesmesaDataGridView.AllowUserToDeleteRows = False
        Me.ListaordenesmesaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaordenesmesaDataGridView.AutoGenerateColumns = False
        Me.ListaordenesmesaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListaordenesmesaDataGridView.ColumnHeadersHeight = 42
        Me.ListaordenesmesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ListaordenesmesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idordenmesa, Me.DataGridViewTextBoxColumn2, Me.idproducto, Me.codigoproducto, Me.producto, Me.cantidad, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.descuento, Me.idlistaprecio, Me.precioventa, Me.recargo, Me.DataGridViewTextBoxColumn16, Me.subtotal})
        Me.ListaordenesmesaDataGridView.DataSource = Me.ListaordenesmesaBindingSource
        Me.ListaordenesmesaDataGridView.Location = New System.Drawing.Point(86, 79)
        Me.ListaordenesmesaDataGridView.MultiSelect = False
        Me.ListaordenesmesaDataGridView.Name = "ListaordenesmesaDataGridView"
        Me.ListaordenesmesaDataGridView.ReadOnly = True
        Me.ListaordenesmesaDataGridView.RowTemplate.Height = 24
        Me.ListaordenesmesaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaordenesmesaDataGridView.Size = New System.Drawing.Size(542, 494)
        Me.ListaordenesmesaDataGridView.TabIndex = 5
        '
        'idordenmesa
        '
        Me.idordenmesa.DataPropertyName = "idordenmesa"
        Me.idordenmesa.HeaderText = "idordenmesa"
        Me.idordenmesa.Name = "idordenmesa"
        Me.idordenmesa.ReadOnly = True
        Me.idordenmesa.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idmesa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idmesa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'idproducto
        '
        Me.idproducto.DataPropertyName = "idproducto"
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Cod."
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        '
        'producto
        '
        Me.producto.DataPropertyName = "producto"
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechaentrega"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechaentrega"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn11.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'descuento
        '
        Me.descuento.DataPropertyName = "descuento"
        Me.descuento.HeaderText = "descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Visible = False
        '
        'idlistaprecio
        '
        Me.idlistaprecio.DataPropertyName = "idlistaprecio"
        Me.idlistaprecio.HeaderText = "idlistaprecio"
        Me.idlistaprecio.Name = "idlistaprecio"
        Me.idlistaprecio.ReadOnly = True
        Me.idlistaprecio.Visible = False
        '
        'precioventa
        '
        Me.precioventa.DataPropertyName = "precioventa"
        Me.precioventa.HeaderText = "Precio U."
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'recargo
        '
        Me.recargo.DataPropertyName = "recargo"
        Me.recargo.HeaderText = "recargo"
        Me.recargo.Name = "recargo"
        Me.recargo.ReadOnly = True
        Me.recargo.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn16.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "SubTotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'ListaordenesmesaBindingSource
        '
        Me.ListaordenesmesaBindingSource.DataMember = "listaordenesmesa"
        Me.ListaordenesmesaBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mesa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salón:"
        '
        'ComboBoxMesa
        '
        Me.ComboBoxMesa.DataSource = Me.MesasBindingSource
        Me.ComboBoxMesa.DisplayMember = "idmesa"
        Me.ComboBoxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMesa.FormattingEnabled = True
        Me.ComboBoxMesa.Location = New System.Drawing.Point(206, 38)
        Me.ComboBoxMesa.Name = "ComboBoxMesa"
        Me.ComboBoxMesa.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxMesa.TabIndex = 0
        Me.ComboBoxMesa.ValueMember = "idmesa"
        '
        'MesasBindingSource
        '
        Me.MesasBindingSource.DataMember = "mesas"
        Me.MesasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBoxSalon
        '
        Me.ComboBoxSalon.DataSource = Me.SalonesBindingSource
        Me.ComboBoxSalon.DisplayMember = "descripcion"
        Me.ComboBoxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSalon.FormattingEnabled = True
        Me.ComboBoxSalon.Location = New System.Drawing.Point(32, 38)
        Me.ComboBoxSalon.Name = "ComboBoxSalon"
        Me.ComboBoxSalon.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxSalon.TabIndex = 0
        Me.ComboBoxSalon.ValueMember = "idsalon"
        '
        'SalonesBindingSource
        '
        Me.SalonesBindingSource.DataMember = "salones"
        Me.SalonesBindingSource.DataSource = Me.ComercialDataSet
        '
        'OrdenesmesasBindingSource
        '
        Me.OrdenesmesasBindingSource.DataMember = "ordenesmesas"
        Me.OrdenesmesasBindingSource.DataSource = Me.ComercialDataSet
        '
        'MozosBindingSource
        '
        Me.MozosBindingSource.DataMember = "mozos"
        Me.MozosBindingSource.DataSource = Me.ComercialDataSet
        '
        'SalonesTableAdapter
        '
        Me.SalonesTableAdapter.ClearBeforeFill = True
        '
        'MesasTableAdapter
        '
        Me.MesasTableAdapter.ClearBeforeFill = True
        '
        'MozosTableAdapter
        '
        Me.MozosTableAdapter.ClearBeforeFill = True
        '
        'ListaproductosBindingSource
        '
        Me.ListaproductosBindingSource.DataMember = "listaproductos"
        Me.ListaproductosBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.estadosaiTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadosordenmesaTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Me.MesasTableAdapter
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Me.MozosTableAdapter
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
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
        Me.TableAdapterManager.salonesTableAdapter = Me.SalonesTableAdapter
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ParametrosgeneralesDataGridView)
        Me.GroupBox2.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox2.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox2.Controls.Add(Me.PagosDataGridView)
        Me.GroupBox2.Controls.Add(Me.CheckBoxFP2)
        Me.GroupBox2.Controls.Add(Me.VentasdetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.NrocomprobanteTextBox)
        Me.GroupBox2.Controls.Add(Me.VentasDataGridView)
        Me.GroupBox2.Controls.Add(Me.TextBoxImporteTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(IdformapagoLabel)
        Me.GroupBox2.Controls.Add(Me.idformapagocombo)
        Me.GroupBox2.Controls.Add(IdtipocomprobanteLabel)
        Me.GroupBox2.Controls.Add(Me.Idtipocomprobantecombo)
        Me.GroupBox2.Controls.Add(Me.PictureBoxEditarCliente)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox2.Controls.Add(Me.LabelMESA)
        Me.GroupBox2.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.MenuStrip2)
        Me.GroupBox2.Location = New System.Drawing.Point(660, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 635)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'ParametrosgeneralesDataGridView
        '
        Me.ParametrosgeneralesDataGridView.AutoGenerateColumns = False
        Me.ParametrosgeneralesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParametrosgeneralesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewImageColumn1})
        Me.ParametrosgeneralesDataGridView.DataSource = Me.ParametrosgeneralesBindingSource
        Me.ParametrosgeneralesDataGridView.Location = New System.Drawing.Point(40, 42)
        Me.ParametrosgeneralesDataGridView.Name = "ParametrosgeneralesDataGridView"
        Me.ParametrosgeneralesDataGridView.RowTemplate.Height = 24
        Me.ParametrosgeneralesDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.ParametrosgeneralesDataGridView.TabIndex = 48
        Me.ParametrosgeneralesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prgid"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prgid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prgclave"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prgclave"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "prgvalor1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "prgvalor1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "prgstring1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "prgstring1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "prgdecimal1"
        Me.DataGridViewTextBoxColumn15.HeaderText = "prgdecimal1"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "prgimagen1"
        Me.DataGridViewImageColumn1.HeaderText = "prgimagen1"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ParametrosgeneralesBindingSource
        '
        Me.ParametrosgeneralesBindingSource.DataMember = "parametrosgenerales"
        Me.ParametrosgeneralesBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(11, 42)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.RowTemplate.Height = 24
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.CajaseventosDataGridView.TabIndex = 48
        Me.CajaseventosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn62.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "idcaja"
        Me.DataGridViewTextBoxColumn63.HeaderText = "idcaja"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "fechaapertura"
        Me.DataGridViewTextBoxColumn64.HeaderText = "fechaapertura"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn65.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "saldoinicial"
        Me.DataGridViewTextBoxColumn66.HeaderText = "saldoinicial"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "saldofinal"
        Me.DataGridViewTextBoxColumn67.HeaderText = "saldofinal"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "usuarioapertura"
        Me.DataGridViewTextBoxColumn68.HeaderText = "usuarioapertura"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "usuariocierre"
        Me.DataGridViewTextBoxColumn69.HeaderText = "usuariocierre"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "emailed"
        Me.DataGridViewTextBoxColumn70.HeaderText = "emailed"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(92, 21)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.RowTemplate.Height = 24
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.CajasoperacionesDataGridView.TabIndex = 48
        Me.CajasoperacionesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "idoperacion"
        Me.DataGridViewTextBoxColumn48.HeaderText = "idoperacion"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn49.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn50.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "idgastos"
        Me.DataGridViewTextBoxColumn51.HeaderText = "idgastos"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn52.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn53.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn54.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn55.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn56.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn57.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "idextracciones"
        Me.DataGridViewTextBoxColumn58.HeaderText = "idextracciones"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "idvale"
        Me.DataGridViewTextBoxColumn59.HeaderText = "idvale"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn60.HeaderText = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn61.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(66, 21)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowTemplate.Height = 24
        Me.PagosDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.PagosDataGridView.TabIndex = 48
        Me.PagosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn38.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn39.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn40.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn41.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "fechapago"
        Me.DataGridViewTextBoxColumn42.HeaderText = "fechapago"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn43.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "nrocomprobante"
        Me.DataGridViewTextBoxColumn44.HeaderText = "nrocomprobante"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "idpagosweb"
        Me.DataGridViewTextBoxColumn45.HeaderText = "idpagosweb"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn46.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn47.HeaderText = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CheckBoxFP2
        '
        Me.CheckBoxFP2.AutoSize = True
        Me.CheckBoxFP2.Location = New System.Drawing.Point(339, 306)
        Me.CheckBoxFP2.Name = "CheckBoxFP2"
        Me.CheckBoxFP2.Size = New System.Drawing.Size(145, 21)
        Me.CheckBoxFP2.TabIndex = 48
        Me.CheckBoxFP2.Text = "Forma de Pago 2°"
        Me.CheckBoxFP2.UseVisualStyleBackColor = True
        Me.CheckBoxFP2.Visible = False
        '
        'VentasdetalleDataGridView
        '
        Me.VentasdetalleDataGridView.AutoGenerateColumns = False
        Me.VentasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.VentasdetalleDataGridView.DataSource = Me.VentasdetalleBindingSource
        Me.VentasdetalleDataGridView.Location = New System.Drawing.Point(40, 21)
        Me.VentasdetalleDataGridView.Name = "VentasdetalleDataGridView"
        Me.VentasdetalleDataGridView.RowTemplate.Height = 24
        Me.VentasdetalleDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.VentasdetalleDataGridView.TabIndex = 47
        Me.VentasdetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "idventadetalle"
        Me.DataGridViewTextBoxColumn29.HeaderText = "idventadetalle"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn30.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn31.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn32.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn33.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "idlistaprecio"
        Me.DataGridViewTextBoxColumn34.HeaderText = "idlistaprecio"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn35.HeaderText = "recargo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "ivaventasdetalle"
        Me.DataGridViewTextBoxColumn36.HeaderText = "ivaventasdetalle"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "descuento"
        Me.DataGridViewTextBoxColumn37.HeaderText = "descuento"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'VentasdetalleBindingSource
        '
        Me.VentasdetalleBindingSource.DataMember = "ventasdetalle"
        Me.VentasdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'NrocomprobanteTextBox
        '
        Me.NrocomprobanteTextBox.Location = New System.Drawing.Point(105, 340)
        Me.NrocomprobanteTextBox.Name = "NrocomprobanteTextBox"
        Me.NrocomprobanteTextBox.Size = New System.Drawing.Size(213, 22)
        Me.NrocomprobanteTextBox.TabIndex = 47
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(11, 21)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.RowTemplate.Height = 24
        Me.VentasDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.VentasDataGridView.TabIndex = 3
        Me.VentasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "fechaventa"
        Me.DataGridViewTextBoxColumn17.HeaderText = "fechaventa"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn18.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "idtipocomprobante"
        Me.DataGridViewTextBoxColumn19.HeaderText = "idtipocomprobante"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn20.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "nrocomprobante"
        Me.DataGridViewTextBoxColumn21.HeaderText = "nrocomprobante"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "idventasweb"
        Me.DataGridViewTextBoxColumn22.HeaderText = "idventasweb"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "fechavencimiento"
        Me.DataGridViewTextBoxColumn23.HeaderText = "fechavencimiento"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "ptovta"
        Me.DataGridViewTextBoxColumn24.HeaderText = "ptovta"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CAE"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CAE"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "idconcepto"
        Me.DataGridViewTextBoxColumn26.HeaderText = "idconcepto"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CAEFchVto"
        Me.DataGridViewTextBoxColumn27.HeaderText = "CAEFchVto"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "cbtnro"
        Me.DataGridViewTextBoxColumn28.HeaderText = "cbtnro"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.ComercialDataSet
        '
        'TextBoxImporteTotal
        '
        Me.TextBoxImporteTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBoxImporteTotal.Location = New System.Drawing.Point(161, 522)
        Me.TextBoxImporteTotal.Name = "TextBoxImporteTotal"
        Me.TextBoxImporteTotal.Size = New System.Drawing.Size(379, 45)
        Me.TextBoxImporteTotal.TabIndex = 46
        Me.TextBoxImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(9, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 39)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "TOTAL:"
        '
        'idformapagocombo
        '
        Me.idformapagocombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idformapagocombo.DataSource = Me.FormaspagoBindingSource
        Me.idformapagocombo.DisplayMember = "descripcion"
        Me.idformapagocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo.FormattingEnabled = True
        Me.idformapagocombo.Location = New System.Drawing.Point(105, 304)
        Me.idformapagocombo.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo.Name = "idformapagocombo"
        Me.idformapagocombo.Size = New System.Drawing.Size(269, 24)
        Me.idformapagocombo.TabIndex = 43
        Me.idformapagocombo.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
        '
        'Idtipocomprobantecombo
        '
        Me.Idtipocomprobantecombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Idtipocomprobantecombo.DataSource = Me.TipocomprobantesBindingSource
        Me.Idtipocomprobantecombo.DisplayMember = "descripcion"
        Me.Idtipocomprobantecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idtipocomprobantecombo.FormattingEnabled = True
        Me.Idtipocomprobantecombo.Location = New System.Drawing.Point(105, 270)
        Me.Idtipocomprobantecombo.Margin = New System.Windows.Forms.Padding(4)
        Me.Idtipocomprobantecombo.Name = "Idtipocomprobantecombo"
        Me.Idtipocomprobantecombo.Size = New System.Drawing.Size(269, 24)
        Me.Idtipocomprobantecombo.TabIndex = 41
        Me.Idtipocomprobantecombo.ValueMember = "idtipocomprobante"
        '
        'TipocomprobantesBindingSource
        '
        Me.TipocomprobantesBindingSource.DataMember = "tipocomprobantes"
        Me.TipocomprobantesBindingSource.DataSource = Me.ComercialDataSet
        '
        'PictureBoxEditarCliente
        '
        Me.PictureBoxEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEditarCliente.Image = CType(resources.GetObject("PictureBoxEditarCliente.Image"), System.Drawing.Image)
        Me.PictureBoxEditarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxEditarCliente.Location = New System.Drawing.Point(161, 177)
        Me.PictureBoxEditarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxEditarCliente.Name = "PictureBoxEditarCliente"
        Me.PictureBoxEditarCliente.Size = New System.Drawing.Size(27, 26)
        Me.PictureBoxEditarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEditarCliente.TabIndex = 40
        Me.PictureBoxEditarCliente.TabStop = False
        Me.PictureBoxEditarCliente.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MozosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(382, 36)
        Me.ComboBox1.TabIndex = 21
        Me.ComboBox1.ValueMember = "idmozo"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(218, 179)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdclienteTextBox.TabIndex = 20
        Me.IdclienteTextBox.TabStop = False
        Me.IdclienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMESA
        '
        Me.LabelMESA.AutoSize = True
        Me.LabelMESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelMESA.Location = New System.Drawing.Point(246, 18)
        Me.LabelMESA.Name = "LabelMESA"
        Me.LabelMESA.Size = New System.Drawing.Size(39, 39)
        Me.LabelMESA.TabIndex = 17
        Me.LabelMESA.Text = "--"
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(126, 177)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(27, 27)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "nombre", True))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(8, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(532, 41)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-------------"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListaclientesBindingSource
        '
        Me.ListaclientesBindingSource.DataMember = "listaclientes"
        Me.ListaclientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 39)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 39)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MOZO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MESA:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AllowMerge = False
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.AnularMesaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 576)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(540, 56)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CerrarToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources._22_512
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(147, 52)
        Me.CerrarToolStripMenuItem.Text = "Finalizar Mesa"
        Me.CerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnularMesaToolStripMenuItem
        '
        Me.AnularMesaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AnularMesaToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.AnularMesaToolStripMenuItem.Name = "AnularMesaToolStripMenuItem"
        Me.AnularMesaToolStripMenuItem.Size = New System.Drawing.Size(132, 52)
        Me.AnularMesaToolStripMenuItem.Text = "Anular Mesa"
        Me.AnularMesaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'OrdenesmesasTableAdapter
        '
        Me.OrdenesmesasTableAdapter.ClearBeforeFill = True
        '
        'ListaordenesmesaTableAdapter
        '
        Me.ListaordenesmesaTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ListaclientesTableAdapter
        '
        Me.ListaclientesTableAdapter.ClearBeforeFill = True
        '
        'TipocomprobantesTableAdapter
        '
        Me.TipocomprobantesTableAdapter.ClearBeforeFill = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'VentasdetalleTableAdapter
        '
        Me.VentasdetalleTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'ListamesasestadosTableAdapter
        '
        Me.ListamesasestadosTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(446, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "[F12] -Pantalla Completa"
        '
        'AdmOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1218, 640)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Ordenes de Mesa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListamesasestadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListamesasestadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaordenesmesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaordenesmesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesmesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaÓrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxMesa As ComboBox
    Friend WithEvents ComboBoxSalon As ComboBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SalonesBindingSource As BindingSource
    Friend WithEvents SalonesTableAdapter As comercialDataSetTableAdapters.salonesTableAdapter
    Friend WithEvents MesasBindingSource As BindingSource
    Friend WithEvents MesasTableAdapter As comercialDataSetTableAdapters.mesasTableAdapter
    Friend WithEvents MozosBindingSource As BindingSource
    Friend WithEvents MozosTableAdapter As comercialDataSetTableAdapters.mozosTableAdapter
    Friend WithEvents ListaproductosBindingSource As BindingSource
    Friend WithEvents ListaproductosTableAdapter As comercialDataSetTableAdapters.listaproductosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularMesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents LabelMESA As Label
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents OrdenesmesasTableAdapter As comercialDataSetTableAdapters.ordenesmesasTableAdapter
    Friend WithEvents OrdenesmesasBindingSource As BindingSource
    Friend WithEvents ListaordenesmesaBindingSource As BindingSource
    Friend WithEvents ListaordenesmesaTableAdapter As comercialDataSetTableAdapters.listaordenesmesaTableAdapter
    Friend WithEvents ListaordenesmesaDataGridView As DataGridView
    Friend WithEvents AnularOrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ListaclientesTableAdapter As comercialDataSetTableAdapters.listaclientesTableAdapter
    Friend WithEvents ListaclientesBindingSource As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBoxEditarCliente As PictureBox
    Friend WithEvents Idtipocomprobantecombo As ComboBox
    Friend WithEvents idformapagocombo As ComboBox
    Friend WithEvents TextBoxImporteTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TipocomprobantesBindingSource As BindingSource
    Friend WithEvents TipocomprobantesTableAdapter As comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
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
    Friend WithEvents NrocomprobanteTextBox As TextBox
    Friend WithEvents VentasdetalleBindingSource As BindingSource
    Friend WithEvents VentasdetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents VentasdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxFP2 As CheckBox
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents CajasoperacionesBindingSource As BindingSource
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents CajasoperacionesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents CajaseventosBindingSource As BindingSource
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents CajaseventosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As DataGridViewTextBoxColumn
    Friend WithEvents idordenmesa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents idlistaprecio As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents recargo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents ParametrosgeneralesBindingSource As BindingSource
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents ParametrosgeneralesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ListamesasestadosBindingSource As BindingSource
    Friend WithEvents ListamesasestadosTableAdapter As comercialDataSetTableAdapters.listamesasestadosTableAdapter
    Friend WithEvents ListamesasestadosDataGridView As DataGridView
    Friend WithEvents idsalon As DataGridViewTextBoxColumn
    Friend WithEvents idmesa As DataGridViewTextBoxColumn
    Friend WithEvents pendientes As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
End Class

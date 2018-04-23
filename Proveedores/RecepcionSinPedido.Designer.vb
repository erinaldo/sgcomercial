<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionSinPedido
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
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Dim FechaaltaLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecepcionSinPedido))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labeltotalvisible = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PedidoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelproducto = New System.Windows.Forms.Label()
        Me.codigotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LabelProveedor = New System.Windows.Forms.Label()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.LabelNombreProveedor = New System.Windows.Forms.Label()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.FechaaltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PedidosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdetalleTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.ProveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.proveedoresTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosreporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListapedidosreporteTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosreporteTableAdapter()
        Me.ListapedidosreporteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.MiComercioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciocosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.umedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdproveedorLabel = New System.Windows.Forms.Label()
        FechaaltaLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PedidoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosreporteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdproveedorLabel
        '
        IdproveedorLabel.AutoSize = True
        IdproveedorLabel.Location = New System.Drawing.Point(10, 39)
        IdproveedorLabel.Name = "IdproveedorLabel"
        IdproveedorLabel.Size = New System.Drawing.Size(78, 17)
        IdproveedorLabel.TabIndex = 2
        IdproveedorLabel.Text = "Proveedor:"
        '
        'FechaaltaLabel
        '
        FechaaltaLabel.AutoSize = True
        FechaaltaLabel.Location = New System.Drawing.Point(580, 39)
        FechaaltaLabel.Name = "FechaaltaLabel"
        FechaaltaLabel.Size = New System.Drawing.Size(51, 17)
        FechaaltaLabel.TabIndex = 4
        FechaaltaLabel.Text = "Fecha:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.labeltotalvisible)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 486)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(761, 69)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Monto:"
        '
        'labeltotalvisible
        '
        Me.labeltotalvisible.AutoSize = True
        Me.labeltotalvisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotalvisible.Location = New System.Drawing.Point(599, 25)
        Me.labeltotalvisible.Name = "labeltotalvisible"
        Me.labeltotalvisible.Size = New System.Drawing.Size(60, 20)
        Me.labeltotalvisible.TabIndex = 4
        Me.labeltotalvisible.Text = "$ 0,00"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PedidoDetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Labelproducto)
        Me.GroupBox2.Controls.Add(Me.codigotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 378)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PedidoDetalleDataGridView
        '
        Me.PedidoDetalleDataGridView.AllowUserToAddRows = False
        Me.PedidoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PedidoDetalleDataGridView.AllowUserToResizeColumns = False
        Me.PedidoDetalleDataGridView.AllowUserToResizeRows = False
        Me.PedidoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.descripción, Me.cantidad, Me.preciocosto, Me.subtotal, Me.umedida, Me.cproducto})
        Me.PedidoDetalleDataGridView.Location = New System.Drawing.Point(16, 61)
        Me.PedidoDetalleDataGridView.Name = "PedidoDetalleDataGridView"
        Me.PedidoDetalleDataGridView.ReadOnly = True
        Me.PedidoDetalleDataGridView.RowTemplate.Height = 24
        Me.PedidoDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PedidoDetalleDataGridView.Size = New System.Drawing.Size(732, 303)
        Me.PedidoDetalleDataGridView.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Búsqueda manual"
        Me.PictureBox1.AccessibleName = "Búsqueda manual"
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.manual
        Me.PictureBox1.Location = New System.Drawing.Point(266, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Búsqueda manual"
        '
        'Labelproducto
        '
        Me.Labelproducto.AutoSize = True
        Me.Labelproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelproducto.Location = New System.Drawing.Point(296, 22)
        Me.Labelproducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelproducto.Name = "Labelproducto"
        Me.Labelproducto.Size = New System.Drawing.Size(82, 20)
        Me.Labelproducto.TabIndex = 6
        Me.Labelproducto.Text = "producto"
        '
        'codigotextbox
        '
        Me.codigotextbox.Location = New System.Drawing.Point(121, 21)
        Me.codigotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigotextbox.Name = "codigotextbox"
        Me.codigotextbox.Size = New System.Drawing.Size(132, 22)
        Me.codigotextbox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cod. Producto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Controls.Add(Me.LabelProveedor)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.LabelNombreProveedor)
        Me.GroupBox1.Controls.Add(IdproveedorLabel)
        Me.GroupBox1.Controls.Add(Me.IdproveedorTextBox)
        Me.GroupBox1.Controls.Add(FechaaltaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaaltaDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 84)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedido"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 39
        ReportDataSource1.Name = "listapedidosreporte"
        ReportDataSource1.Value = Nothing
        ReportDataSource2.Name = "MiComercio"
        ReportDataSource2.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportPedido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(412, 8)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(45, 76)
        Me.ReportViewer1.TabIndex = 19
        Me.ReportViewer1.Visible = False
        '
        'LabelProveedor
        '
        Me.LabelProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.LabelProveedor.Location = New System.Drawing.Point(214, 38)
        Me.LabelProveedor.Name = "LabelProveedor"
        Me.LabelProveedor.Size = New System.Drawing.Size(360, 23)
        Me.LabelProveedor.TabIndex = 18
        Me.LabelProveedor.Text = "Proveedor"
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(179, 35)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 28)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'LabelNombreProveedor
        '
        Me.LabelNombreProveedor.AutoSize = True
        Me.LabelNombreProveedor.Location = New System.Drawing.Point(224, 39)
        Me.LabelNombreProveedor.Name = "LabelNombreProveedor"
        Me.LabelNombreProveedor.Size = New System.Drawing.Size(0, 17)
        Me.LabelNombreProveedor.TabIndex = 6
        '
        'IdproveedorTextBox
        '
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(95, 38)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(77, 22)
        Me.IdproveedorTextBox.TabIndex = 3
        '
        'FechaaltaDateTimePicker
        '
        Me.FechaaltaDateTimePicker.Enabled = False
        Me.FechaaltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaaltaDateTimePicker.Location = New System.Drawing.Point(637, 36)
        Me.FechaaltaDateTimePicker.Name = "FechaaltaDateTimePicker"
        Me.FechaaltaDateTimePicker.Size = New System.Drawing.Size(111, 22)
        Me.FechaaltaDateTimePicker.TabIndex = 5
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Me.PedidosdetalleTableAdapter
        Me.TableAdapterManager.pedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'PedidosdetalleTableAdapter
        '
        Me.PedidosdetalleTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PedidosDataGridView.DataSource = Me.PedidosBindingSource
        Me.PedidosDataGridView.Location = New System.Drawing.Point(779, 155)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.RowTemplate.Height = 24
        Me.PedidosDataGridView.Size = New System.Drawing.Size(142, 26)
        Me.PedidosDataGridView.TabIndex = 7
        Me.PedidosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechafin"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechafin"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ListapedidosreporteBindingSource
        '
        Me.ListapedidosreporteBindingSource.DataMember = "listapedidosreporte"
        Me.ListapedidosreporteBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListapedidosreporteTableAdapter
        '
        Me.ListapedidosreporteTableAdapter.ClearBeforeFill = True
        '
        'ListapedidosreporteDataGridView
        '
        Me.ListapedidosreporteDataGridView.AutoGenerateColumns = False
        Me.ListapedidosreporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListapedidosreporteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.ListapedidosreporteDataGridView.DataSource = Me.ListapedidosreporteBindingSource
        Me.ListapedidosreporteDataGridView.Location = New System.Drawing.Point(779, 187)
        Me.ListapedidosreporteDataGridView.Name = "ListapedidosreporteDataGridView"
        Me.ListapedidosreporteDataGridView.RowTemplate.Height = 24
        Me.ListapedidosreporteDataGridView.Size = New System.Drawing.Size(144, 27)
        Me.ListapedidosreporteDataGridView.TabIndex = 6
        Me.ListapedidosreporteDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cuitcuil"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cuitcuil"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn10.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn11.HeaderText = "email"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "personacontacto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "personacontacto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn15.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn16.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "recibido"
        Me.DataGridViewTextBoxColumn17.HeaderText = "recibido"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
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
        'MiComercioDataGridView
        '
        Me.MiComercioDataGridView.AutoGenerateColumns = False
        Me.MiComercioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiComercioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewImageColumn1})
        Me.MiComercioDataGridView.DataSource = Me.MiComercioBindingSource
        Me.MiComercioDataGridView.Location = New System.Drawing.Point(779, 89)
        Me.MiComercioDataGridView.Name = "MiComercioDataGridView"
        Me.MiComercioDataGridView.RowTemplate.Height = 24
        Me.MiComercioDataGridView.Size = New System.Drawing.Size(145, 31)
        Me.MiComercioDataGridView.TabIndex = 6
        Me.MiComercioDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "comercio"
        Me.DataGridViewTextBoxColumn18.HeaderText = "comercio"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NombreComercio"
        Me.DataGridViewTextBoxColumn19.HeaderText = "NombreComercio"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CuitCuil"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CuitCuil"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Dirección"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Logo"
        Me.DataGridViewImageColumn1.HeaderText = "Logo"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(779, 57)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.RowTemplate.Height = 24
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(143, 26)
        Me.ProveedoresDataGridView.TabIndex = 6
        Me.ProveedoresDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn23.HeaderText = "idproveedor"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn24.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "cuitcuil"
        Me.DataGridViewTextBoxColumn25.HeaderText = "cuitcuil"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn26.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn27.HeaderText = "email"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "condicioniva"
        Me.DataGridViewTextBoxColumn28.HeaderText = "condicioniva"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "personacontacto"
        Me.DataGridViewTextBoxColumn29.HeaderText = "personacontacto"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'PedidosdetalleBindingSource
        '
        Me.PedidosdetalleBindingSource.DataMember = "pedidosdetalle"
        Me.PedidosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'PedidosdetalleDataGridView
        '
        Me.PedidosdetalleDataGridView.AutoGenerateColumns = False
        Me.PedidosdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.PedidosdetalleDataGridView.DataSource = Me.PedidosdetalleBindingSource
        Me.PedidosdetalleDataGridView.Location = New System.Drawing.Point(779, 126)
        Me.PedidosdetalleDataGridView.Name = "PedidosdetalleDataGridView"
        Me.PedidosdetalleDataGridView.RowTemplate.Height = 24
        Me.PedidosdetalleDataGridView.Size = New System.Drawing.Size(144, 23)
        Me.PedidosdetalleDataGridView.TabIndex = 6
        Me.PedidosdetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "idpedidodetalle"
        Me.DataGridViewTextBoxColumn30.HeaderText = "idpedidodetalle"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn31.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn32.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn33.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn34.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "recibido"
        Me.DataGridViewTextBoxColumn35.HeaderText = "recibido"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(779, 19)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(148, 32)
        Me.ProductosDataGridView.TabIndex = 6
        Me.ProductosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn36.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn37.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn38.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn39.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn40.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn41.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn2.HeaderText = "imagen"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn42.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn43.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn44.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn45.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn46.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn47.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "productocompuesto"
        Me.DataGridViewTextBoxColumn48.HeaderText = "productocompuesto"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn49.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(779, 220)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.RowTemplate.Height = 24
        Me.StockDataGridView.Size = New System.Drawing.Size(141, 30)
        Me.StockDataGridView.TabIndex = 9
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "idstock"
        Me.DataGridViewTextBoxColumn50.HeaderText = "idstock"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn51.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn52.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "fechamovimiento"
        Me.DataGridViewTextBoxColumn53.HeaderText = "fechamovimiento"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn54.HeaderText = "fechacarga"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn55.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn56.HeaderText = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn57.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn58.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn59.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'descripción
        '
        Me.descripción.HeaderText = "Descripción"
        Me.descripción.Name = "descripción"
        Me.descripción.ReadOnly = True
        Me.descripción.Width = 275
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'preciocosto
        '
        Me.preciocosto.HeaderText = "Precio costo"
        Me.preciocosto.Name = "preciocosto"
        Me.preciocosto.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'umedida
        '
        Me.umedida.HeaderText = "umedida"
        Me.umedida.Name = "umedida"
        Me.umedida.ReadOnly = True
        Me.umedida.Visible = False
        '
        'cproducto
        '
        Me.cproducto.HeaderText = "cproducto"
        Me.cproducto.Name = "cproducto"
        Me.cproducto.ReadOnly = True
        Me.cproducto.Visible = False
        '
        'RecepcionSinPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 575)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.ListapedidosreporteDataGridView)
        Me.Controls.Add(Me.PedidosdetalleDataGridView)
        Me.Controls.Add(Me.PedidosDataGridView)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.MiComercioDataGridView)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecepcionSinPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "RecepcionSinPedido"
        Me.Text = "Recepcion de Mercaderías Sin Pedido"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PedidoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosreporteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labeltotalvisible As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PedidoDetalleDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelproducto As Label
    Friend WithEvents codigotextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents LabelProveedor As Label
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents LabelNombreProveedor As Label
    Friend WithEvents IdproveedorTextBox As TextBox
    Friend WithEvents FechaaltaDateTimePicker As DateTimePicker
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As comercialDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ListapedidosreporteBindingSource As BindingSource
    Friend WithEvents ListapedidosreporteTableAdapter As comercialDataSetTableAdapters.listapedidosreporteTableAdapter
    Friend WithEvents ListapedidosreporteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents MiComercioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ProveedoresTableAdapter As comercialDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents PedidosdetalleTableAdapter As comercialDataSetTableAdapters.pedidosdetalleTableAdapter
    Friend WithEvents PedidosdetalleBindingSource As BindingSource
    Friend WithEvents PedidosdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockDataGridView As DataGridView
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
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripción As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents preciocosto As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents umedida As DataGridViewTextBoxColumn
    Friend WithEvents cproducto As DataGridViewTextBoxColumn
End Class

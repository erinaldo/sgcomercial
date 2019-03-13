<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMPedidos
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
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Dim FechaaltaLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMPedidos))
        Me.listapedidosreporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listapedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LabelProveedor = New System.Windows.Forms.Label()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.LabelNombreProveedor = New System.Windows.Forms.Label()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaaltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PedidoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciocosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelproducto = New System.Windows.Forms.Label()
        Me.codigotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labeltotalvisible = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PedidosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdetalleTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.ProveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.proveedoresTableAdapter()
        Me.listapedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosTableAdapter()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listapedidosreporteTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosreporteTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        IdproveedorLabel = New System.Windows.Forms.Label()
        FechaaltaLabel = New System.Windows.Forms.Label()
        CType(Me.listapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PedidoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'listapedidosreporteBindingSource
        '
        Me.listapedidosreporteBindingSource.DataMember = "listapedidosreporte"
        Me.listapedidosreporteBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.ComercialDataSet
        '
        'listapedidosBindingSource
        '
        Me.listapedidosBindingSource.DataMember = "listapedidos"
        Me.listapedidosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
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
        Me.GroupBox1.Size = New System.Drawing.Size(825, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(273, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "- CARGAR DESDE STOCK CRÍTICO - "
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 26
        ReportDataSource1.Name = "listapedidosreporte"
        ReportDataSource1.Value = Me.listapedidosreporteBindingSource
        ReportDataSource2.Name = "MiComercio"
        ReportDataSource2.Value = Me.MiComercioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportPedido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(787, 11)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(32, 15)
        Me.ReportViewer1.TabIndex = 19
        Me.ReportViewer1.Visible = False
        '
        'LabelProveedor
        '
        Me.LabelProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nombre", True))
        Me.LabelProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.LabelProveedor.Location = New System.Drawing.Point(214, 38)
        Me.LabelProveedor.Name = "LabelProveedor"
        Me.LabelProveedor.Size = New System.Drawing.Size(360, 23)
        Me.LabelProveedor.TabIndex = 18
        Me.LabelProveedor.Text = "Proveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ComercialDataSet
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
        Me.IdproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "idproveedor", True))
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(95, 38)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(77, 22)
        Me.IdproveedorTextBox.TabIndex = 3
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.ComercialDataSet
        '
        'FechaaltaDateTimePicker
        '
        Me.FechaaltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fechaalta", True))
        Me.FechaaltaDateTimePicker.Enabled = False
        Me.FechaaltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaaltaDateTimePicker.Location = New System.Drawing.Point(637, 36)
        Me.FechaaltaDateTimePicker.Name = "FechaaltaDateTimePicker"
        Me.FechaaltaDateTimePicker.Size = New System.Drawing.Size(111, 22)
        Me.FechaaltaDateTimePicker.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PedidoDetalleDataGridView)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Labelproducto)
        Me.GroupBox2.Controls.Add(Me.codigotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(825, 413)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PedidoDetalleDataGridView
        '
        Me.PedidoDetalleDataGridView.AllowUserToAddRows = False
        Me.PedidoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PedidoDetalleDataGridView.AllowUserToResizeColumns = False
        Me.PedidoDetalleDataGridView.AllowUserToResizeRows = False
        Me.PedidoDetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PedidoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.descripcion, Me.actual, Me.cantidad, Me.preciocosto, Me.subtotal})
        Me.PedidoDetalleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.PedidoDetalleDataGridView.Location = New System.Drawing.Point(16, 61)
        Me.PedidoDetalleDataGridView.MultiSelect = False
        Me.PedidoDetalleDataGridView.Name = "PedidoDetalleDataGridView"
        Me.PedidoDetalleDataGridView.RowTemplate.Height = 24
        Me.PedidoDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PedidoDetalleDataGridView.Size = New System.Drawing.Size(796, 338)
        Me.PedidoDetalleDataGridView.TabIndex = 8
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 275
        '
        'actual
        '
        Me.actual.HeaderText = "Cant. en Stock"
        Me.actual.Name = "actual"
        Me.actual.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad Pedida"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ToolTipText = "Cantidad Pedida"
        '
        'preciocosto
        '
        Me.preciocosto.HeaderText = "Precio costo"
        Me.preciocosto.Name = "preciocosto"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.labeltotalvisible)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 521)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 69)
        Me.GroupBox3.TabIndex = 3
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
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.pedidosTableAdapter = Me.PedidosTableAdapter
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
        Me.TableAdapterManager.synclogTableAdapter = Nothing
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
        'PedidosdetalleBindingSource
        '
        Me.PedidosdetalleBindingSource.DataMember = "pedidosdetalle"
        Me.PedidosdetalleBindingSource.DataSource = Me.ComercialDataSet
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
        'listapedidosTableAdapter
        '
        Me.listapedidosTableAdapter.ClearBeforeFill = True
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listapedidosreporteTableAdapter
        '
        Me.listapedidosreporteTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ABMPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 598)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMPedidos"
        Me.Text = "ABM Pedidos"
        CType(Me.listapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PedidoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As comercialDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LabelNombreProveedor As Label
    Friend WithEvents IdproveedorTextBox As TextBox
    Friend WithEvents FechaaltaDateTimePicker As DateTimePicker
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents codigotextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelproducto As Label
    Friend WithEvents PedidosdetalleBindingSource As BindingSource
    Friend WithEvents PedidosdetalleTableAdapter As comercialDataSetTableAdapters.pedidosdetalleTableAdapter
    Friend WithEvents PedidoDetalleDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As comercialDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents LabelProveedor As Label
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents listapedidosBindingSource As BindingSource
    Friend WithEvents listapedidosTableAdapter As comercialDataSetTableAdapters.listapedidosTableAdapter
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listapedidosreporteBindingSource As BindingSource
    Friend WithEvents listapedidosreporteTableAdapter As comercialDataSetTableAdapters.listapedidosreporteTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents labeltotalvisible As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents actual As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents preciocosto As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class

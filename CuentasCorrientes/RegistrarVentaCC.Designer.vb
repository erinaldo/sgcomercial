<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVentaCC
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalVisible = New System.Windows.Forms.Label()
        Me.BtnDescuento = New System.Windows.Forms.Button()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxVale = New System.Windows.Forms.CheckBox()
        Me.vueltotextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pagotextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.labelcliente = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.listasprecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNueva = New System.Windows.Forms.Button()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.PermisosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.permisosTableAdapter()
        Me.ValesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.valesTableAdapter()
        Me.ListaspreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaspreciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaspreciosTableAdapter()
        Me.TextboxRecargoCC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        FechaventaLabel = New System.Windows.Forms.Label()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(26, 28)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 2
        IdclienteLabel.Text = "N° Cliente:"
        '
        'FechaventaLabel
        '
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(20, 65)
        FechaventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(92, 17)
        FechaventaLabel.TabIndex = 11
        FechaventaLabel.Text = "Fecha Venta:"
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Location = New System.Drawing.Point(88, 23)
        Me.PagosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.Size = New System.Drawing.Size(24, 14)
        Me.PagosDataGridView.TabIndex = 8
        Me.PagosDataGridView.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TextboxRecargoCC)
        Me.GroupBox4.Controls.Add(Me.LabelTotalVisible)
        Me.GroupBox4.Controls.Add(Me.BtnDescuento)
        Me.GroupBox4.Controls.Add(Me.labeltotal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 509)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(859, 58)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen"
        '
        'LabelTotalVisible
        '
        Me.LabelTotalVisible.AutoSize = True
        Me.LabelTotalVisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotalVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalVisible.Location = New System.Drawing.Point(390, 26)
        Me.LabelTotalVisible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalVisible.Name = "LabelTotalVisible"
        Me.LabelTotalVisible.Size = New System.Drawing.Size(21, 22)
        Me.LabelTotalVisible.TabIndex = 10
        Me.LabelTotalVisible.Text = "$"
        Me.LabelTotalVisible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnDescuento
        '
        Me.BtnDescuento.Location = New System.Drawing.Point(135, 23)
        Me.BtnDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDescuento.Name = "BtnDescuento"
        Me.BtnDescuento.Size = New System.Drawing.Size(141, 28)
        Me.BtnDescuento.TabIndex = 9
        Me.BtnDescuento.Text = "Aplicar Descuento"
        Me.BtnDescuento.UseVisualStyleBackColor = True
        '
        'labeltotal
        '
        Me.labeltotal.AutoSize = True
        Me.labeltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labeltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.Location = New System.Drawing.Point(420, 26)
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
        Me.Label3.Location = New System.Drawing.Point(292, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Monto Total:"
        '
        'CheckBoxVale
        '
        Me.CheckBoxVale.AutoSize = True
        Me.CheckBoxVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckBoxVale.Location = New System.Drawing.Point(659, 597)
        Me.CheckBoxVale.Name = "CheckBoxVale"
        Me.CheckBoxVale.Size = New System.Drawing.Size(58, 22)
        Me.CheckBoxVale.TabIndex = 1
        Me.CheckBoxVale.Text = "Vale"
        Me.CheckBoxVale.UseVisualStyleBackColor = True
        '
        'vueltotextbox
        '
        Me.vueltotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vueltotextbox.Location = New System.Drawing.Point(512, 595)
        Me.vueltotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.vueltotextbox.Name = "vueltotextbox"
        Me.vueltotextbox.ReadOnly = True
        Me.vueltotextbox.Size = New System.Drawing.Size(132, 26)
        Me.vueltotextbox.TabIndex = 0
        Me.vueltotextbox.TabStop = False
        Me.vueltotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 600)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Su Vuelto:"
        '
        'pagotextbox
        '
        Me.pagotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagotextbox.Location = New System.Drawing.Point(283, 595)
        Me.pagotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.pagotextbox.Name = "pagotextbox"
        Me.pagotextbox.Size = New System.Drawing.Size(132, 26)
        Me.pagotextbox.TabIndex = 0
        Me.pagotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 600)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Paga con:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.labelcliente)
        Me.GroupBox3.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox3.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox3.Controls.Add(IdclienteLabel)
        Me.GroupBox3.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox3.Controls.Add(FechaventaLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 72)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(859, 96)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta"
        '
        'labelcliente
        '
        Me.labelcliente.AutoSize = True
        Me.labelcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelcliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.labelcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcliente.Location = New System.Drawing.Point(237, 25)
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
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(198, 22)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 28)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 15
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Location = New System.Drawing.Point(105, 23)
        Me.IdclienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(84, 22)
        Me.IdclienteTextBox.TabIndex = 4
        '
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(117, 60)
        Me.FechaventaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(144, 22)
        Me.FechaventaDateTimePicker.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.stockdisp)
        Me.GroupBox2.Controls.Add(Me.Labelproducto)
        Me.GroupBox2.Controls.Add(Me.codigotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.VentasdetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(859, 334)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Búsqueda manual"
        Me.PictureBox1.AccessibleName = "Búsqueda manual"
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.manual
        Me.PictureBox1.Location = New System.Drawing.Point(261, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Búsqueda manual"
        '
        'stockdisp
        '
        Me.stockdisp.AutoSize = True
        Me.stockdisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockdisp.Location = New System.Drawing.Point(717, 27)
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
        Me.Labelproducto.Location = New System.Drawing.Point(291, 25)
        Me.Labelproducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelproducto.Name = "Labelproducto"
        Me.Labelproducto.Size = New System.Drawing.Size(82, 20)
        Me.Labelproducto.TabIndex = 3
        Me.Labelproducto.Text = "producto"
        '
        'codigotextbox
        '
        Me.codigotextbox.Location = New System.Drawing.Point(120, 22)
        Me.codigotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigotextbox.Name = "codigotextbox"
        Me.codigotextbox.Size = New System.Drawing.Size(132, 22)
        Me.codigotextbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. Producto:"
        '
        'VentasdetalleDataGridView
        '
        Me.VentasdetalleDataGridView.AllowUserToAddRows = False
        Me.VentasdetalleDataGridView.AllowUserToDeleteRows = False
        Me.VentasdetalleDataGridView.AllowUserToResizeRows = False
        Me.VentasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codproducto, Me.descripcion, Me.cantidad, Me.precioventa, Me.subtotal, Me.eliminar, Me.listasprecios})
        Me.VentasdetalleDataGridView.Location = New System.Drawing.Point(16, 55)
        Me.VentasdetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.VentasdetalleDataGridView.MultiSelect = False
        Me.VentasdetalleDataGridView.Name = "VentasdetalleDataGridView"
        Me.VentasdetalleDataGridView.ReadOnly = True
        Me.VentasdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasdetalleDataGridView.Size = New System.Drawing.Size(832, 262)
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
        Me.descripcion.Width = 300
        '
        'cantidad
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precioventa
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.precioventa.DefaultCellStyle = DataGridViewCellStyle8
        Me.precioventa.HeaderText = "Precio Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'subtotal
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle9
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.PagosDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnNueva)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(859, 59)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Location = New System.Drawing.Point(152, 23)
        Me.StockDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(24, 14)
        Me.StockDataGridView.TabIndex = 5
        Me.StockDataGridView.Visible = False
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(120, 23)
        Me.CajasoperacionesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(24, 14)
        Me.CajasoperacionesDataGridView.TabIndex = 5
        Me.CajasoperacionesDataGridView.Visible = False
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(56, 23)
        Me.CajaseventosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(24, 14)
        Me.CajaseventosDataGridView.TabIndex = 4
        Me.CajaseventosDataGridView.Visible = False
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Location = New System.Drawing.Point(24, 23)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(24, 14)
        Me.ProductosDataGridView.TabIndex = 3
        Me.ProductosDataGridView.Visible = False
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(504, 18)
        Me.BtnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(133, 28)
        Me.BtnConfirmar.TabIndex = 2
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(363, 18)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(133, 28)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNueva
        '
        Me.BtnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueva.Location = New System.Drawing.Point(222, 18)
        Me.BtnNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(133, 28)
        Me.BtnNueva.TabIndex = 0
        Me.BtnNueva.Text = "Nueva"
        Me.BtnNueva.UseVisualStyleBackColor = True
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'VentasdetalleBindingSource
        '
        Me.VentasdetalleBindingSource.DataMember = "ventasdetalle"
        Me.VentasdetalleBindingSource.DataSource = Me.ComercialDataSet
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
        'TextboxRecargoCC
        '
        Me.TextboxRecargoCC.AutoSize = True
        Me.TextboxRecargoCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextboxRecargoCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxRecargoCC.Location = New System.Drawing.Point(721, 26)
        Me.TextboxRecargoCC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextboxRecargoCC.Name = "TextboxRecargoCC"
        Me.TextboxRecargoCC.Size = New System.Drawing.Size(2, 22)
        Me.TextboxRecargoCC.TabIndex = 11
        Me.TextboxRecargoCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(540, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Monto a Cuenta Corriente:"
        '
        'RegistrarVentaCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 575)
        Me.Controls.Add(Me.CheckBoxVale)
        Me.Controls.Add(Me.pagotextbox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.vueltotextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrarVentaCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "RegistrarVentaCC"
        Me.Text = "Registrar Venta a Cuenta Corriente"
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBoxVale As CheckBox
    Friend WithEvents LabelTotalVisible As Label
    Friend WithEvents BtnDescuento As Button
    Friend WithEvents vueltotextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pagotextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents labeltotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents labelcliente As Label
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents FechaventaDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents stockdisp As Label
    Friend WithEvents Labelproducto As Label
    Friend WithEvents codigotextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VentasdetalleDataGridView As DataGridView
    Friend WithEvents codproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents listasprecios As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents CajasoperacionesDataGridView As DataGridView
    Friend WithEvents CajaseventosDataGridView As DataGridView
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNueva As Button
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents CajasoperacionesBindingSource As BindingSource
    Friend WithEvents CajaseventosBindingSource As BindingSource
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents VentasdetalleBindingSource As BindingSource
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents TipocomprobantesBindingSource As BindingSource
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasdetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents FormaspagoTableAdapter As comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents TipocomprobantesTableAdapter As comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents PermisosTableAdapter As comercialDataSetTableAdapters.permisosTableAdapter
    Friend WithEvents ValesTableAdapter As comercialDataSetTableAdapters.valesTableAdapter
    Friend WithEvents ListaspreciosBindingSource As BindingSource
    Friend WithEvents ListaspreciosTableAdapter As comercialDataSetTableAdapters.listaspreciosTableAdapter
    Friend WithEvents TextboxRecargoCC As Label
    Friend WithEvents Label2 As Label
End Class

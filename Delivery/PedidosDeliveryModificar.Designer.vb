<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDeliveryModificar
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NombretransporteLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ReferenciasLabel As System.Windows.Forms.Label
        Dim NombreprovinciaLabel As System.Windows.Forms.Label
        Dim NombrelocalidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosDeliveryModificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ListapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IdpedidodeliveryTextBox = New System.Windows.Forms.TextBox()
        Me.NombreprovinciaTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NombrelocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciasTextBox = New System.Windows.Forms.TextBox()
        Me.NombretransporteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListapedidosdeliverydetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpedidodelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.idlistaprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEditarDomicilios = New System.Windows.Forms.PictureBox()
        Me.PedidosdeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliveryTableAdapter()
        Me.PedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter()
        Me.ListapedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NombretransporteLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ReferenciasLabel = New System.Windows.Forms.Label()
        NombreprovinciaLabel = New System.Windows.Forms.Label()
        NombrelocalidadLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListapedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxEditarDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(99, 18)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 16
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(6, 63)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Teléfono:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(212, 63)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(43, 17)
        CuitLabel.TabIndex = 20
        CuitLabel.Text = "CUIT:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 128)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 17)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "E-mail:"
        '
        'NombretransporteLabel
        '
        NombretransporteLabel.AutoSize = True
        NombretransporteLabel.Location = New System.Drawing.Point(366, 108)
        NombretransporteLabel.Name = "NombretransporteLabel"
        NombretransporteLabel.Size = New System.Drawing.Size(82, 17)
        NombretransporteLabel.TabIndex = 24
        NombretransporteLabel.Text = "Transporte:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(6, 18)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 26
        DireccionLabel.Text = "Dirección:"
        '
        'ReferenciasLabel
        '
        ReferenciasLabel.AutoSize = True
        ReferenciasLabel.Location = New System.Drawing.Point(366, 18)
        ReferenciasLabel.Name = "ReferenciasLabel"
        ReferenciasLabel.Size = New System.Drawing.Size(88, 17)
        ReferenciasLabel.TabIndex = 28
        ReferenciasLabel.Text = "Referencias:"
        '
        'NombreprovinciaLabel
        '
        NombreprovinciaLabel.AutoSize = True
        NombreprovinciaLabel.Location = New System.Drawing.Point(7, 63)
        NombreprovinciaLabel.Name = "NombreprovinciaLabel"
        NombreprovinciaLabel.Size = New System.Drawing.Size(70, 17)
        NombreprovinciaLabel.TabIndex = 30
        NombreprovinciaLabel.Text = "Provincia:"
        '
        'NombrelocalidadLabel
        '
        NombrelocalidadLabel.AutoSize = True
        NombrelocalidadLabel.Location = New System.Drawing.Point(7, 108)
        NombrelocalidadLabel.Name = "NombrelocalidadLabel"
        NombrelocalidadLabel.Size = New System.Drawing.Size(73, 17)
        NombrelocalidadLabel.TabIndex = 32
        NombrelocalidadLabel.Text = "Localidad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.IdClienteTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.IdpedidodeliveryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBox1.Location = New System.Drawing.Point(341, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "idcliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(371, 13)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(25, 22)
        Me.IdClienteTextBox.TabIndex = 24
        Me.IdClienteTextBox.Visible = False
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
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(63, 128)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(316, 22)
        Me.EmailTextBox.TabIndex = 23
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "cuit", True))
        Me.CuitTextBox.Enabled = False
        Me.CuitTextBox.Location = New System.Drawing.Point(215, 83)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(181, 22)
        Me.CuitTextBox.TabIndex = 21
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "telefono", True))
        Me.TelefonoTextBox.Enabled = False
        Me.TelefonoTextBox.Location = New System.Drawing.Point(6, 83)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedido Nº:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(102, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(294, 22)
        Me.NombreTextBox.TabIndex = 17
        '
        'IdpedidodeliveryTextBox
        '
        Me.IdpedidodeliveryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "idpedidodelivery", True))
        Me.IdpedidodeliveryTextBox.Enabled = False
        Me.IdpedidodeliveryTextBox.Location = New System.Drawing.Point(6, 38)
        Me.IdpedidodeliveryTextBox.Name = "IdpedidodeliveryTextBox"
        Me.IdpedidodeliveryTextBox.Size = New System.Drawing.Size(86, 22)
        Me.IdpedidodeliveryTextBox.TabIndex = 3
        Me.IdpedidodeliveryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NombreprovinciaTextBox
        '
        Me.NombreprovinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombreprovincia", True))
        Me.NombreprovinciaTextBox.Enabled = False
        Me.NombreprovinciaTextBox.Location = New System.Drawing.Point(10, 83)
        Me.NombreprovinciaTextBox.Name = "NombreprovinciaTextBox"
        Me.NombreprovinciaTextBox.Size = New System.Drawing.Size(335, 22)
        Me.NombreprovinciaTextBox.TabIndex = 31
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "direccion", True))
        Me.DireccionTextBox.Enabled = False
        Me.DireccionTextBox.Location = New System.Drawing.Point(9, 38)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(336, 22)
        Me.DireccionTextBox.TabIndex = 27
        '
        'NombrelocalidadTextBox
        '
        Me.NombrelocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombrelocalidad", True))
        Me.NombrelocalidadTextBox.Enabled = False
        Me.NombrelocalidadTextBox.Location = New System.Drawing.Point(10, 128)
        Me.NombrelocalidadTextBox.Name = "NombrelocalidadTextBox"
        Me.NombrelocalidadTextBox.Size = New System.Drawing.Size(335, 22)
        Me.NombrelocalidadTextBox.TabIndex = 33
        '
        'ReferenciasTextBox
        '
        Me.ReferenciasTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferenciasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "referencias", True))
        Me.ReferenciasTextBox.Enabled = False
        Me.ReferenciasTextBox.Location = New System.Drawing.Point(366, 38)
        Me.ReferenciasTextBox.Multiline = True
        Me.ReferenciasTextBox.Name = "ReferenciasTextBox"
        Me.ReferenciasTextBox.Size = New System.Drawing.Size(448, 67)
        Me.ReferenciasTextBox.TabIndex = 29
        '
        'NombretransporteTextBox
        '
        Me.NombretransporteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombretransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombretransporte", True))
        Me.NombretransporteTextBox.Enabled = False
        Me.NombretransporteTextBox.Location = New System.Drawing.Point(366, 130)
        Me.NombretransporteTextBox.Name = "NombretransporteTextBox"
        Me.NombretransporteTextBox.Size = New System.Drawing.Size(448, 22)
        Me.NombretransporteTextBox.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ListapedidosdeliverydetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1251, 420)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(444, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(363, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListapedidosdeliverydetalleDataGridView
        '
        Me.ListapedidosdeliverydetalleDataGridView.AllowUserToAddRows = False
        Me.ListapedidosdeliverydetalleDataGridView.AllowUserToDeleteRows = False
        Me.ListapedidosdeliverydetalleDataGridView.AllowUserToResizeColumns = False
        Me.ListapedidosdeliverydetalleDataGridView.AllowUserToResizeRows = False
        Me.ListapedidosdeliverydetalleDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListapedidosdeliverydetalleDataGridView.AutoGenerateColumns = False
        Me.ListapedidosdeliverydetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListapedidosdeliverydetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListapedidosdeliverydetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.idpedidodelivery, Me.idproducto, Me.DataGridViewTextBoxColumn16, Me.precioventa, Me.cantidad, Me.subtotal, Me.modificar, Me.eliminar, Me.idlistaprecio})
        Me.ListapedidosdeliverydetalleDataGridView.DataSource = Me.ListapedidosdeliverydetalleBindingSource
        Me.ListapedidosdeliverydetalleDataGridView.Location = New System.Drawing.Point(20, 32)
        Me.ListapedidosdeliverydetalleDataGridView.MultiSelect = False
        Me.ListapedidosdeliverydetalleDataGridView.Name = "ListapedidosdeliverydetalleDataGridView"
        Me.ListapedidosdeliverydetalleDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListapedidosdeliverydetalleDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListapedidosdeliverydetalleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListapedidosdeliverydetalleDataGridView.RowTemplate.Height = 24
        Me.ListapedidosdeliverydetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListapedidosdeliverydetalleDataGridView.Size = New System.Drawing.Size(1208, 329)
        Me.ListapedidosdeliverydetalleDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 182
        '
        'idpedidodelivery
        '
        Me.idpedidodelivery.DataPropertyName = "idpedidodelivery"
        Me.idpedidodelivery.HeaderText = "idpedidodelivery"
        Me.idpedidodelivery.Name = "idpedidodelivery"
        Me.idpedidodelivery.ReadOnly = True
        Me.idpedidodelivery.Visible = False
        Me.idpedidodelivery.Width = 140
        '
        'idproducto
        '
        Me.idproducto.DataPropertyName = "idproducto"
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        Me.idproducto.Width = 104
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.ToolTipText = "Producto"
        Me.DataGridViewTextBoxColumn16.Width = 94
        '
        'precioventa
        '
        Me.precioventa.DataPropertyName = "precioventa"
        Me.precioventa.HeaderText = "Precio"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        Me.precioventa.Width = 77
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 93
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 89
        '
        'modificar
        '
        Me.modificar.HeaderText = ""
        Me.modificar.Name = "modificar"
        Me.modificar.ReadOnly = True
        Me.modificar.Text = "Modificar"
        Me.modificar.UseColumnTextForButtonValue = True
        Me.modificar.Width = 5
        '
        'eliminar
        '
        Me.eliminar.HeaderText = ""
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 5
        '
        'idlistaprecio
        '
        Me.idlistaprecio.DataPropertyName = "idlistaprecio"
        Me.idlistaprecio.HeaderText = "idlistaprecio"
        Me.idlistaprecio.Name = "idlistaprecio"
        Me.idlistaprecio.ReadOnly = True
        Me.idlistaprecio.Visible = False
        Me.idlistaprecio.Width = 112
        '
        'ListapedidosdeliverydetalleBindingSource
        '
        Me.ListapedidosdeliverydetalleBindingSource.DataMember = "listapedidosdeliverydetalle"
        Me.ListapedidosdeliverydetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PictureBoxEditarDomicilios)
        Me.GroupBox3.Controls.Add(DireccionLabel)
        Me.GroupBox3.Controls.Add(NombreprovinciaLabel)
        Me.GroupBox3.Controls.Add(Me.NombrelocalidadTextBox)
        Me.GroupBox3.Controls.Add(Me.ReferenciasTextBox)
        Me.GroupBox3.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox3.Controls.Add(Me.NombreprovinciaTextBox)
        Me.GroupBox3.Controls.Add(ReferenciasLabel)
        Me.GroupBox3.Controls.Add(NombrelocalidadLabel)
        Me.GroupBox3.Controls.Add(NombretransporteLabel)
        Me.GroupBox3.Controls.Add(Me.NombretransporteTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(426, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(837, 165)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrega"
        '
        'PictureBoxEditarDomicilios
        '
        Me.PictureBoxEditarDomicilios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxEditarDomicilios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEditarDomicilios.Image = CType(resources.GetObject("PictureBoxEditarDomicilios.Image"), System.Drawing.Image)
        Me.PictureBoxEditarDomicilios.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxEditarDomicilios.Location = New System.Drawing.Point(186, 9)
        Me.PictureBoxEditarDomicilios.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxEditarDomicilios.Name = "PictureBoxEditarDomicilios"
        Me.PictureBoxEditarDomicilios.Size = New System.Drawing.Size(23, 26)
        Me.PictureBoxEditarDomicilios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEditarDomicilios.TabIndex = 39
        Me.PictureBoxEditarDomicilios.TabStop = False
        '
        'PedidosdeliveryDataGridView
        '
        Me.PedidosdeliveryDataGridView.AutoGenerateColumns = False
        Me.PedidosdeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PedidosdeliveryDataGridView.DataSource = Me.PedidosdeliveryBindingSource
        Me.PedidosdeliveryDataGridView.Location = New System.Drawing.Point(227, -4)
        Me.PedidosdeliveryDataGridView.Name = "PedidosdeliveryDataGridView"
        Me.PedidosdeliveryDataGridView.RowTemplate.Height = 24
        Me.PedidosdeliveryDataGridView.Size = New System.Drawing.Size(30, 23)
        Me.PedidosdeliveryDataGridView.TabIndex = 34
        Me.PedidosdeliveryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idtransporte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idtransporte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "iddomicilio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "iddomicilio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pagoesperado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pagoesperado"
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
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn10.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idpedidosdeliveryweb"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idpedidosdeliveryweb"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'PedidosdeliveryBindingSource
        '
        Me.PedidosdeliveryBindingSource.DataMember = "pedidosdelivery"
        Me.PedidosdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(969, 0)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(19, 19)
        Me.ProductosDataGridView.TabIndex = 34
        Me.ProductosDataGridView.Visible = False
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
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn17.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn19.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn20.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn21.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn22.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn23.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn24.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn25.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn26.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "productocompuesto"
        Me.DataGridViewTextBoxColumn27.HeaderText = "productocompuesto"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn28.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "precioventagranel"
        Me.DataGridViewTextBoxColumn29.HeaderText = "precioventagranel"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "precioventamayorista"
        Me.DataGridViewTextBoxColumn30.HeaderText = "precioventamayorista"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "precioventadistribuidor"
        Me.DataGridViewTextBoxColumn31.HeaderText = "precioventadistribuidor"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn32.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PedidosdeliverydetalleBindingSource
        '
        Me.PedidosdeliverydetalleBindingSource.DataMember = "pedidosdeliverydetalle"
        Me.PedidosdeliverydetalleBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'PedidosdeliveryTableAdapter
        '
        Me.PedidosdeliveryTableAdapter.ClearBeforeFill = True
        '
        'PedidosdeliverydetalleTableAdapter
        '
        Me.PedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'ListapedidosdeliverydetalleTableAdapter
        '
        Me.ListapedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'VentasdetalleTableAdapter
        '
        Me.VentasdetalleTableAdapter.ClearBeforeFill = True
        '
        'PedidosDeliveryModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 615)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.PedidosdeliveryDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidosDeliveryModificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PedidosDeliveryModificar"
        Me.Text = "Modificar Pedido Delivery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListapedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxEditarDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListapedidosdeliveryBindingSource As BindingSource
    Friend WithEvents ListapedidosdeliveryTableAdapter As comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdpedidodeliveryTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NombretransporteTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ReferenciasTextBox As TextBox
    Friend WithEvents NombreprovinciaTextBox As TextBox
    Friend WithEvents NombrelocalidadTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxEditarDomicilios As PictureBox
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents PedidosdeliveryBindingSource As BindingSource
    Friend WithEvents PedidosdeliveryTableAdapter As comercialDataSetTableAdapters.pedidosdeliveryTableAdapter
    Friend WithEvents PedidosdeliveryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents PedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter
    Friend WithEvents ListapedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents ListapedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter
    Friend WithEvents ListapedidosdeliverydetalleDataGridView As DataGridView
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents VentasdetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents idpedidodelivery As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents modificar As DataGridViewButtonColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents idlistaprecio As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionPedido
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
        Dim CuitcuilLabel As System.Windows.Forms.Label
        Dim PersonacontactoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecepcionPedido))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ButtonComenzar = New System.Windows.Forms.Button()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.TextBoxIdPedido = New System.Windows.Forms.TextBox()
        Me.PersonacontactoLabel1 = New System.Windows.Forms.Label()
        Me.ListapedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CuitcuilLabel1 = New System.Windows.Forms.Label()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoDetalleConfirmarDataGridView = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recibido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PedidosdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechabajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitcuilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonacontactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PedidosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdetalleTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.PedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        CuitcuilLabel = New System.Windows.Forms.Label()
        PersonacontactoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoDetalleConfirmarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(153, 23)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(78, 17)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Proveedor:"
        '
        'CuitcuilLabel
        '
        CuitcuilLabel.AutoSize = True
        CuitcuilLabel.Location = New System.Drawing.Point(436, 23)
        CuitcuilLabel.Name = "CuitcuilLabel"
        CuitcuilLabel.Size = New System.Drawing.Size(77, 17)
        CuitcuilLabel.TabIndex = 2
        CuitcuilLabel.Text = "CUIT/CUIL:"
        '
        'PersonacontactoLabel
        '
        PersonacontactoLabel.AutoSize = True
        PersonacontactoLabel.Location = New System.Drawing.Point(566, 23)
        PersonacontactoLabel.Name = "PersonacontactoLabel"
        PersonacontactoLabel.Size = New System.Drawing.Size(143, 17)
        PersonacontactoLabel.TabIndex = 4
        PersonacontactoLabel.Text = "Persona de contacto:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 23)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 17)
        Label1.TabIndex = 7
        Label1.Text = "N° Pedido:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.ButtonComenzar)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxIdPedido)
        Me.GroupBox1.Controls.Add(PersonacontactoLabel)
        Me.GroupBox1.Controls.Add(Me.PersonacontactoLabel1)
        Me.GroupBox1.Controls.Add(CuitcuilLabel)
        Me.GroupBox1.Controls.Add(Me.CuitcuilLabel1)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedido"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(504, 79)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(184, 28)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'ButtonComenzar
        '
        Me.ButtonComenzar.Location = New System.Drawing.Point(124, 79)
        Me.ButtonComenzar.Name = "ButtonComenzar"
        Me.ButtonComenzar.Size = New System.Drawing.Size(184, 28)
        Me.ButtonComenzar.TabIndex = 17
        Me.ButtonComenzar.Text = "Comenzar"
        Me.ButtonComenzar.UseVisualStyleBackColor = True
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(99, 40)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 28)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Enabled = False
        Me.BtnConfirmar.Location = New System.Drawing.Point(314, 79)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(184, 28)
        Me.BtnConfirmar.TabIndex = 9
        Me.BtnConfirmar.Text = "Confirmar Recepción"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'TextBoxIdPedido
        '
        Me.TextBoxIdPedido.Location = New System.Drawing.Point(21, 43)
        Me.TextBoxIdPedido.Name = "TextBoxIdPedido"
        Me.TextBoxIdPedido.Size = New System.Drawing.Size(71, 22)
        Me.TextBoxIdPedido.TabIndex = 6
        '
        'PersonacontactoLabel1
        '
        Me.PersonacontactoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosBindingSource, "personacontacto", True))
        Me.PersonacontactoLabel1.Location = New System.Drawing.Point(566, 43)
        Me.PersonacontactoLabel1.Name = "PersonacontactoLabel1"
        Me.PersonacontactoLabel1.Size = New System.Drawing.Size(221, 23)
        Me.PersonacontactoLabel1.TabIndex = 5
        Me.PersonacontactoLabel1.Text = ".............................................."
        '
        'ListapedidosBindingSource
        '
        Me.ListapedidosBindingSource.DataMember = "listapedidos"
        Me.ListapedidosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuitcuilLabel1
        '
        Me.CuitcuilLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosBindingSource, "cuitcuil", True))
        Me.CuitcuilLabel1.Location = New System.Drawing.Point(436, 43)
        Me.CuitcuilLabel1.Name = "CuitcuilLabel1"
        Me.CuitcuilLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CuitcuilLabel1.TabIndex = 3
        Me.CuitcuilLabel1.Text = ".............................................."
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosBindingSource, "nombre", True))
        Me.NombreLabel1.Location = New System.Drawing.Point(153, 43)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(273, 23)
        Me.NombreLabel1.TabIndex = 1
        Me.NombreLabel1.Text = "......................................................................"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox2.Controls.Add(Me.PedidoDetalleConfirmarDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(813, 467)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(48, 379)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(55, 50)
        Me.ProductosDataGridView.TabIndex = 4
        Me.ProductosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn1.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn4.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn16.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn17.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "productocompuesto"
        Me.DataGridViewTextBoxColumn18.HeaderText = "productocompuesto"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn19.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PedidoDetalleConfirmarDataGridView
        '
        Me.PedidoDetalleConfirmarDataGridView.AllowUserToAddRows = False
        Me.PedidoDetalleConfirmarDataGridView.AllowUserToDeleteRows = False
        Me.PedidoDetalleConfirmarDataGridView.AllowUserToResizeColumns = False
        Me.PedidoDetalleConfirmarDataGridView.AllowUserToResizeRows = False
        Me.PedidoDetalleConfirmarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidoDetalleConfirmarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.descripcion, Me.cantidad, Me.precio, Me.recibido})
        Me.PedidoDetalleConfirmarDataGridView.Enabled = False
        Me.PedidoDetalleConfirmarDataGridView.Location = New System.Drawing.Point(18, 42)
        Me.PedidoDetalleConfirmarDataGridView.MultiSelect = False
        Me.PedidoDetalleConfirmarDataGridView.Name = "PedidoDetalleConfirmarDataGridView"
        Me.PedidoDetalleConfirmarDataGridView.ReadOnly = True
        Me.PedidoDetalleConfirmarDataGridView.RowTemplate.Height = 24
        Me.PedidoDetalleConfirmarDataGridView.Size = New System.Drawing.Size(774, 410)
        Me.PedidoDetalleConfirmarDataGridView.TabIndex = 0
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 400
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'recibido
        '
        Me.recibido.FalseValue = "0"
        Me.recibido.HeaderText = "Recibido Si/No"
        Me.recibido.IndeterminateValue = ""
        Me.recibido.Name = "recibido"
        Me.recibido.ReadOnly = True
        Me.recibido.ToolTipText = "Recibido Si/No"
        Me.recibido.TrueValue = "1"
        '
        'PedidosdetalleDataGridView
        '
        Me.PedidosdetalleDataGridView.AllowUserToAddRows = False
        Me.PedidosdetalleDataGridView.AllowUserToDeleteRows = False
        Me.PedidosdetalleDataGridView.AutoGenerateColumns = False
        Me.PedidosdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PedidosdetalleDataGridView.DataSource = Me.PedidosdetalleBindingSource
        Me.PedidosdetalleDataGridView.Location = New System.Drawing.Point(831, 91)
        Me.PedidosdetalleDataGridView.Name = "PedidosdetalleDataGridView"
        Me.PedidosdetalleDataGridView.ReadOnly = True
        Me.PedidosdetalleDataGridView.RowTemplate.Height = 24
        Me.PedidosdetalleDataGridView.Size = New System.Drawing.Size(514, 432)
        Me.PedidosdetalleDataGridView.TabIndex = 2
        Me.PedidosdetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idpedidodetalle"
        Me.DataGridViewTextBoxColumn10.HeaderText = "idpedidodetalle"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn11.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn14.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'PedidosdetalleBindingSource
        '
        Me.PedidosdetalleBindingSource.DataMember = "pedidosdetalle"
        Me.PedidosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpedidoDataGridViewTextBoxColumn, Me.IdproveedorDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CuitcuilDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.PersonacontactoDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListapedidosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(869, 278)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.Visible = False
        '
        'IdpedidoDataGridViewTextBoxColumn
        '
        Me.IdpedidoDataGridViewTextBoxColumn.DataPropertyName = "idpedido"
        Me.IdpedidoDataGridViewTextBoxColumn.HeaderText = "idpedido"
        Me.IdpedidoDataGridViewTextBoxColumn.Name = "IdpedidoDataGridViewTextBoxColumn"
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        '
        'FechabajaDataGridViewTextBoxColumn
        '
        Me.FechabajaDataGridViewTextBoxColumn.DataPropertyName = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.HeaderText = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.Name = "FechabajaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CuitcuilDataGridViewTextBoxColumn
        '
        Me.CuitcuilDataGridViewTextBoxColumn.DataPropertyName = "cuitcuil"
        Me.CuitcuilDataGridViewTextBoxColumn.HeaderText = "cuitcuil"
        Me.CuitcuilDataGridViewTextBoxColumn.Name = "CuitcuilDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'PersonacontactoDataGridViewTextBoxColumn
        '
        Me.PersonacontactoDataGridViewTextBoxColumn.DataPropertyName = "personacontacto"
        Me.PersonacontactoDataGridViewTextBoxColumn.HeaderText = "personacontacto"
        Me.PersonacontactoDataGridViewTextBoxColumn.Name = "PersonacontactoDataGridViewTextBoxColumn"
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "fechafin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        '
        'ListapedidosTableAdapter
        '
        Me.ListapedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Me.PedidosdetalleTableAdapter
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
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
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'RecepcionPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 621)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PedidosdetalleDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecepcionPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción de mercaderías con pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoDetalleConfirmarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListapedidosBindingSource As BindingSource
    Friend WithEvents ListapedidosTableAdapter As comercialDataSetTableAdapters.listapedidosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidosdetalleTableAdapter As comercialDataSetTableAdapters.pedidosdetalleTableAdapter
    Friend WithEvents PedidosdetalleBindingSource As BindingSource
    Friend WithEvents TextBoxIdPedido As TextBox
    Friend WithEvents PersonacontactoLabel1 As Label
    Friend WithEvents CuitcuilLabel1 As Label
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents PedidoDetalleConfirmarDataGridView As DataGridView
    Friend WithEvents PedidosdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents recibido As DataGridViewCheckBoxColumn
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents PedidosTableAdapter As comercialDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents ButtonComenzar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechabajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitcuilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonacontactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

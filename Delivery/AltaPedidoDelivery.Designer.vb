﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPedidoDelivery
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCuit = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
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
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBoxNuevoCliente = New System.Windows.Forms.CheckBox()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ClientesdomiciliosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesdomiciliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxLocalidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxTransporte = New System.Windows.Forms.ComboBox()
        Me.TransportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.TextBoxReferencias = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ClientesdomiciliosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
        Me.LocalidadesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.localidadesTableAdapter()
        Me.ProvinciasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.provinciasTableAdapter()
        Me.TransportesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.transportesTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VentasdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidadmedida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.ListaspreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaspreciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaspreciosTableAdapter()
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        IdclienteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ClientesdomiciliosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(9, 27)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 18
        IdclienteLabel.Text = "N° Cliente:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(22, 57)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 17)
        Label1.TabIndex = 22
        Label1.Text = "Nombre:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 87)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 17)
        Label2.TabIndex = 23
        Label2.Text = "Teléfono:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(33, 117)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 17)
        Label3.TabIndex = 25
        Label3.Text = "E-mail:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 24)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(71, 17)
        Label4.TabIndex = 26
        Label4.Text = "Dirección:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(303, 24)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(88, 17)
        Label5.TabIndex = 27
        Label5.Text = "Referencias:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 117)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(82, 17)
        Label6.TabIndex = 29
        Label6.Text = "Transporte:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(557, 24)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(99, 17)
        Label7.TabIndex = 30
        Label7.Text = "Código Postal:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(301, 116)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(70, 17)
        Label8.TabIndex = 33
        Label8.Text = "Provincia:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(503, 116)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(73, 17)
        Label9.TabIndex = 34
        Label9.Text = "Localidad:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(230, 87)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(90, 17)
        Label12.TabIndex = 28
        Label12.Text = "DNI/Cuit/Cuil:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(101, 22)
        Me.IdclienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(84, 22)
        Me.IdclienteTextBox.TabIndex = 19
        Me.IdclienteTextBox.TabStop = False
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(194, 19)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 28)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 20
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxCuit)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.CheckBoxNuevoCliente)
        Me.GroupBox1.Controls.Add(Me.ClientesDataGridView)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelefono)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombreCliente)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'TextBoxCuit
        '
        Me.TextBoxCuit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TextBoxCuit.Location = New System.Drawing.Point(321, 84)
        Me.TextBoxCuit.Name = "TextBoxCuit"
        Me.TextBoxCuit.Size = New System.Drawing.Size(114, 22)
        Me.TextBoxCuit.TabIndex = 29
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
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(369, 141)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(30, 23)
        Me.ProductosDataGridView.TabIndex = 3
        Me.ProductosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn26.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn27.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn28.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn29.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn30.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn31.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn32.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn33.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn34.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn35.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn36.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "productocompuesto"
        Me.DataGridViewTextBoxColumn37.HeaderText = "productocompuesto"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn38.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "precioventamayorista"
        Me.DataGridViewTextBoxColumn39.HeaderText = "precioventamayorista"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "precioventagranel"
        Me.DataGridViewTextBoxColumn40.HeaderText = "precioventagranel"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn41.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(405, 141)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.RowTemplate.Height = 24
        Me.StockDataGridView.Size = New System.Drawing.Size(30, 23)
        Me.StockDataGridView.TabIndex = 3
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idstock"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idstock"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fechamovimiento"
        Me.DataGridViewTextBoxColumn18.HeaderText = "fechamovimiento"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn19.HeaderText = "fechacarga"
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
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn21.HeaderText = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn23.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn24.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "idremito"
        Me.DataGridViewTextBoxColumn25.HeaderText = "idremito"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'CheckBoxNuevoCliente
        '
        Me.CheckBoxNuevoCliente.AutoSize = True
        Me.CheckBoxNuevoCliente.Location = New System.Drawing.Point(314, 23)
        Me.CheckBoxNuevoCliente.Name = "CheckBoxNuevoCliente"
        Me.CheckBoxNuevoCliente.Size = New System.Drawing.Size(121, 21)
        Me.CheckBoxNuevoCliente.TabIndex = 27
        Me.CheckBoxNuevoCliente.Text = "Nuevo Cliente!"
        Me.CheckBoxNuevoCliente.UseVisualStyleBackColor = True
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(6, 141)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.RowTemplate.Height = 24
        Me.ClientesDataGridView.Size = New System.Drawing.Size(30, 23)
        Me.ClientesDataGridView.TabIndex = 3
        Me.ClientesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cuit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cuit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        Me.TextBoxEmail.Location = New System.Drawing.Point(101, 114)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(334, 22)
        Me.TextBoxEmail.TabIndex = 26
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(101, 84)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(118, 22)
        Me.TextBoxTelefono.TabIndex = 24
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(101, 54)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(334, 22)
        Me.TextBoxNombreCliente.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClientesdomiciliosDataGridView)
        Me.GroupBox2.Controls.Add(Me.ComboBoxLocalidad)
        Me.GroupBox2.Controls.Add(Me.ComboBoxProvincia)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBoxTransporte)
        Me.GroupBox2.Controls.Add(Me.TextBoxCP)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxReferencias)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxDireccion)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'ClientesdomiciliosDataGridView
        '
        Me.ClientesdomiciliosDataGridView.AutoGenerateColumns = False
        Me.ClientesdomiciliosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesdomiciliosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.ClientesdomiciliosDataGridView.DataSource = Me.ClientesdomiciliosBindingSource
        Me.ClientesdomiciliosDataGridView.Location = New System.Drawing.Point(6, 137)
        Me.ClientesdomiciliosDataGridView.Name = "ClientesdomiciliosDataGridView"
        Me.ClientesdomiciliosDataGridView.RowTemplate.Height = 24
        Me.ClientesdomiciliosDataGridView.Size = New System.Drawing.Size(30, 23)
        Me.ClientesdomiciliosDataGridView.TabIndex = 3
        Me.ClientesdomiciliosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "iddomicilio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "iddomicilio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "referencias"
        Me.DataGridViewTextBoxColumn10.HeaderText = "referencias"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idprovincia"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idprovincia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idlocalidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idlocalidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cp"
        Me.DataGridViewTextBoxColumn14.HeaderText = "cp"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'ClientesdomiciliosBindingSource
        '
        Me.ClientesdomiciliosBindingSource.DataMember = "clientesdomicilios"
        Me.ClientesdomiciliosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBoxLocalidad
        '
        Me.ComboBoxLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesdomiciliosBindingSource, "idlocalidad", True))
        Me.ComboBoxLocalidad.DataSource = Me.LocalidadesBindingSource
        Me.ComboBoxLocalidad.DisplayMember = "nombrelocalidad"
        Me.ComboBoxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLocalidad.FormattingEnabled = True
        Me.ComboBoxLocalidad.Location = New System.Drawing.Point(580, 112)
        Me.ComboBoxLocalidad.Name = "ComboBoxLocalidad"
        Me.ComboBoxLocalidad.Size = New System.Drawing.Size(112, 24)
        Me.ComboBoxLocalidad.TabIndex = 36
        Me.ComboBoxLocalidad.ValueMember = "idlocalidad"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBoxProvincia
        '
        Me.ComboBoxProvincia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesdomiciliosBindingSource, "idprovincia", True))
        Me.ComboBoxProvincia.DataSource = Me.ProvinciasBindingSource
        Me.ComboBoxProvincia.DisplayMember = "nombreprovincia"
        Me.ComboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProvincia.FormattingEnabled = True
        Me.ComboBoxProvincia.Location = New System.Drawing.Point(373, 112)
        Me.ComboBoxProvincia.Name = "ComboBoxProvincia"
        Me.ComboBoxProvincia.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxProvincia.TabIndex = 35
        Me.ComboBoxProvincia.ValueMember = "idprovincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "provincias"
        Me.ProvinciasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBoxTransporte
        '
        Me.ComboBoxTransporte.DataSource = Me.TransportesBindingSource
        Me.ComboBoxTransporte.DisplayMember = "nombretransporte"
        Me.ComboBoxTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTransporte.FormattingEnabled = True
        Me.ComboBoxTransporte.Location = New System.Drawing.Point(96, 113)
        Me.ComboBoxTransporte.Name = "ComboBoxTransporte"
        Me.ComboBoxTransporte.Size = New System.Drawing.Size(197, 24)
        Me.ComboBoxTransporte.TabIndex = 32
        Me.ComboBoxTransporte.ValueMember = "idtransporte"
        '
        'TransportesBindingSource
        '
        Me.TransportesBindingSource.DataMember = "transportes"
        Me.TransportesBindingSource.DataSource = Me.ComercialDataSet
        '
        'TextBoxCP
        '
        Me.TextBoxCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "cp", True))
        Me.TextBoxCP.Location = New System.Drawing.Point(560, 48)
        Me.TextBoxCP.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(84, 22)
        Me.TextBoxCP.TabIndex = 31
        '
        'TextBoxReferencias
        '
        Me.TextBoxReferencias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "referencias", True))
        Me.TextBoxReferencias.Location = New System.Drawing.Point(306, 48)
        Me.TextBoxReferencias.Multiline = True
        Me.TextBoxReferencias.Name = "TextBoxReferencias"
        Me.TextBoxReferencias.Size = New System.Drawing.Size(240, 47)
        Me.TextBoxReferencias.TabIndex = 28
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "direccion", True))
        Me.TextBoxDireccion.Location = New System.Drawing.Point(10, 48)
        Me.TextBoxDireccion.Multiline = True
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(283, 47)
        Me.TextBoxDireccion.TabIndex = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Me.ClientesdomiciliosTableAdapter
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Me.LocalidadesTableAdapter
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
        Me.TableAdapterManager.provinciasTableAdapter = Me.ProvinciasTableAdapter
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
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
        'ClientesdomiciliosTableAdapter
        '
        Me.ClientesdomiciliosTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'TransportesTableAdapter
        '
        Me.TransportesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.VentasdetalleDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1140, 362)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle del pedido"
        '
        'VentasdetalleDataGridView
        '
        Me.VentasdetalleDataGridView.AllowUserToAddRows = False
        Me.VentasdetalleDataGridView.AllowUserToDeleteRows = False
        Me.VentasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.codigoproducto, Me.descripcion, Me.cantidad, Me.unidadmedida, Me.medida, Me.precioventa, Me.SubTotal})
        Me.VentasdetalleDataGridView.Location = New System.Drawing.Point(11, 21)
        Me.VentasdetalleDataGridView.MultiSelect = False
        Me.VentasdetalleDataGridView.Name = "VentasdetalleDataGridView"
        Me.VentasdetalleDataGridView.ReadOnly = True
        Me.VentasdetalleDataGridView.RowTemplate.Height = 24
        Me.VentasdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasdetalleDataGridView.Size = New System.Drawing.Size(1123, 335)
        Me.VentasdetalleDataGridView.TabIndex = 0
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "ID"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        '
        'codigoproducto
        '
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 500
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'unidadmedida
        '
        Me.unidadmedida.DataSource = Me.UnidadesmedidaBindingSource
        Me.unidadmedida.DisplayMember = "descripcion"
        Me.unidadmedida.HeaderText = "U. Medida"
        Me.unidadmedida.Name = "unidadmedida"
        Me.unidadmedida.ReadOnly = True
        Me.unidadmedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.unidadmedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.unidadmedida.ToolTipText = "U. Medida"
        Me.unidadmedida.ValueMember = "idunidadmedida"
        Me.unidadmedida.Width = 120
        '
        'UnidadesmedidaBindingSource
        '
        Me.UnidadesmedidaBindingSource.DataMember = "unidadesmedida"
        Me.UnidadesmedidaBindingSource.DataSource = Me.ComercialDataSet
        '
        'medida
        '
        Me.medida.HeaderText = "Medida"
        Me.medida.Name = "medida"
        Me.medida.ReadOnly = True
        Me.medida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medida.ToolTipText = "Medida"
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "Precio Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
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
        'UnidadesmedidaTableAdapter
        '
        Me.UnidadesmedidaTableAdapter.ClearBeforeFill = True
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotal.Location = New System.Drawing.Point(1041, 597)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(106, 23)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Label10"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1018, 600)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(953, 599)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 18)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "TOTAL"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(508, 588)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(162, 29)
        Me.BtnConfirmar.TabIndex = 7
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'AltaPedidoDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 642)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AltaPedidoDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Pedido"
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ClientesdomiciliosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.VentasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaspreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxNombreCliente As TextBox
    Friend WithEvents CheckBoxNuevoCliente As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxLocalidad As ComboBox
    Friend WithEvents ComboBoxProvincia As ComboBox
    Friend WithEvents ComboBoxTransporte As ComboBox
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents TextBoxReferencias As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesdomiciliosTableAdapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesdomiciliosBindingSource As BindingSource
    Friend WithEvents ProvinciasTableAdapter As comercialDataSetTableAdapters.provinciasTableAdapter
    Friend WithEvents ClientesdomiciliosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents LocalidadesTableAdapter As comercialDataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents TransportesBindingSource As BindingSource
    Friend WithEvents TransportesTableAdapter As comercialDataSetTableAdapters.transportesTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents VentasdetalleDataGridView As DataGridView
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
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
    Friend WithEvents ListaspreciosBindingSource As BindingSource
    Friend WithEvents ListaspreciosTableAdapter As comercialDataSetTableAdapters.listaspreciosTableAdapter
    Friend WithEvents UnidadesmedidaBindingSource As BindingSource
    Friend WithEvents UnidadesmedidaTableAdapter As comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents unidadmedida As DataGridViewComboBoxColumn
    Friend WithEvents medida As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxCuit As TextBox
    Friend WithEvents BtnConfirmar As Button
End Class

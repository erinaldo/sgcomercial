<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadoCuentaCorriente
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
        Dim CuitLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListacuentascorrientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anular = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.fechavencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListacuentascorrientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListacuentascorrientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listacuentascorrientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTipoSaldo = New System.Windows.Forms.Label()
        Me.Labeltotalgeneral = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Labeltotalhaber = New System.Windows.Forms.Label()
        Me.Labeltotaldebe = New System.Windows.Forms.Label()
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListacuentascorrientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(207, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 18
        NombreLabel.Text = "Nombre:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(587, 31)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(70, 17)
        CuitLabel.TabIndex = 24
        CuitLabel.Text = "DNI/CUIT:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(210, 48)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(357, 22)
        Me.NombreTextBox.TabIndex = 19
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
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cuit", True))
        Me.CuitTextBox.Enabled = False
        Me.CuitTextBox.Location = New System.Drawing.Point(587, 48)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(138, 22)
        Me.CuitTextBox.TabIndex = 25
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(162, 48)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(24, 22)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente N°:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(85, 48)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(70, 22)
        Me.IdclienteTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListacuentascorrientesDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 340)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de Cuenta"
        '
        'ListacuentascorrientesDataGridView
        '
        Me.ListacuentascorrientesDataGridView.AllowUserToAddRows = False
        Me.ListacuentascorrientesDataGridView.AllowUserToDeleteRows = False
        Me.ListacuentascorrientesDataGridView.AllowUserToResizeColumns = False
        Me.ListacuentascorrientesDataGridView.AllowUserToResizeRows = False
        Me.ListacuentascorrientesDataGridView.AutoGenerateColumns = False
        Me.ListacuentascorrientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListacuentascorrientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcliente, Me.DataGridViewTextBoxColumn8, Me.descripcion, Me.nro, Me.debe, Me.haber, Me.saldo, Me.idventa, Me.idpagos, Me.Anular, Me.fechavencimiento})
        Me.ListacuentascorrientesDataGridView.DataSource = Me.ListacuentascorrientesBindingSource
        Me.ListacuentascorrientesDataGridView.Location = New System.Drawing.Point(17, 21)
        Me.ListacuentascorrientesDataGridView.MultiSelect = False
        Me.ListacuentascorrientesDataGridView.Name = "ListacuentascorrientesDataGridView"
        Me.ListacuentascorrientesDataGridView.ReadOnly = True
        Me.ListacuentascorrientesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.ListacuentascorrientesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListacuentascorrientesDataGridView.RowTemplate.Height = 24
        Me.ListacuentascorrientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListacuentascorrientesDataGridView.Size = New System.Drawing.Size(1030, 299)
        Me.ListacuentascorrientesDataGridView.TabIndex = 0
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 250
        '
        'nro
        '
        Me.nro.DataPropertyName = "nro"
        Me.nro.HeaderText = "Nº"
        Me.nro.Name = "nro"
        Me.nro.ReadOnly = True
        Me.nro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nro.Width = 90
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle1
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle2
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.saldo.ToolTipText = "Click para cargar pago"
        '
        'idventa
        '
        Me.idventa.DataPropertyName = "idventa"
        Me.idventa.HeaderText = "idventa"
        Me.idventa.Name = "idventa"
        Me.idventa.ReadOnly = True
        Me.idventa.Visible = False
        '
        'idpagos
        '
        Me.idpagos.DataPropertyName = "idpagos"
        Me.idpagos.HeaderText = "idpagos"
        Me.idpagos.Name = "idpagos"
        Me.idpagos.ReadOnly = True
        Me.idpagos.Visible = False
        '
        'Anular
        '
        Me.Anular.HeaderText = "Anular"
        Me.Anular.Name = "Anular"
        Me.Anular.ReadOnly = True
        Me.Anular.Text = "Anular"
        Me.Anular.ToolTipText = "Anular"
        Me.Anular.UseColumnTextForButtonValue = True
        '
        'fechavencimiento
        '
        Me.fechavencimiento.DataPropertyName = "fechavencimiento"
        Me.fechavencimiento.HeaderText = "Fecha Vto."
        Me.fechavencimiento.Name = "fechavencimiento"
        Me.fechavencimiento.ReadOnly = True
        Me.fechavencimiento.ToolTipText = "Fecha Vto."
        '
        'ListacuentascorrientesBindingSource
        '
        Me.ListacuentascorrientesBindingSource.DataMember = "listacuentascorrientes"
        Me.ListacuentascorrientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListacuentascorrientesTableAdapter
        '
        Me.ListacuentascorrientesTableAdapter.ClearBeforeFill = True
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
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PagosDataGridView)
        Me.GroupBox3.Controls.Add(Me.VentasDataGridView)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LabelTipoSaldo)
        Me.GroupBox3.Controls.Add(Me.Labeltotalgeneral)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Labeltotalhaber)
        Me.GroupBox3.Controls.Add(Me.Labeltotaldebe)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1065, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen"
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(66, 27)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowTemplate.Height = 24
        Me.PagosDataGridView.Size = New System.Drawing.Size(41, 20)
        Me.PagosDataGridView.TabIndex = 16
        Me.PagosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn16.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "fechapago"
        Me.DataGridViewTextBoxColumn17.HeaderText = "fechapago"
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
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "nrocomprobante"
        Me.DataGridViewTextBoxColumn19.HeaderText = "nrocomprobante"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "idpagosweb"
        Me.DataGridViewTextBoxColumn20.HeaderText = "idpagosweb"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn21.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.ComercialDataSet
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(19, 27)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.RowTemplate.Height = 24
        Me.VentasDataGridView.Size = New System.Drawing.Size(41, 20)
        Me.VentasDataGridView.TabIndex = 16
        Me.VentasDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idventa"
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechaventa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechaventa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idtipocomprobante"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idtipocomprobante"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn10.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nrocomprobante"
        Me.DataGridViewTextBoxColumn11.HeaderText = "nrocomprobante"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idventasweb"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idventasweb"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(662, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Haber"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Debe"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTipoSaldo
        '
        Me.LabelTipoSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTipoSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoSaldo.Location = New System.Drawing.Point(662, 75)
        Me.LabelTipoSaldo.Name = "LabelTipoSaldo"
        Me.LabelTipoSaldo.Size = New System.Drawing.Size(102, 23)
        Me.LabelTipoSaldo.TabIndex = 14
        Me.LabelTipoSaldo.Text = "---------"
        Me.LabelTipoSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labeltotalgeneral
        '
        Me.Labeltotalgeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotalgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Labeltotalgeneral.Location = New System.Drawing.Point(556, 75)
        Me.Labeltotalgeneral.Name = "Labeltotalgeneral"
        Me.Labeltotalgeneral.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotalgeneral.TabIndex = 13
        Me.Labeltotalgeneral.Text = "00000000"
        Me.Labeltotalgeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(300, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SALDO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(300, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TOTALES:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labeltotalhaber
        '
        Me.Labeltotalhaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotalhaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Labeltotalhaber.Location = New System.Drawing.Point(662, 43)
        Me.Labeltotalhaber.Name = "Labeltotalhaber"
        Me.Labeltotalhaber.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotalhaber.TabIndex = 10
        Me.Labeltotalhaber.Text = "00000000"
        Me.Labeltotalhaber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labeltotaldebe
        '
        Me.Labeltotaldebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotaldebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotaldebe.Location = New System.Drawing.Point(556, 43)
        Me.Labeltotaldebe.Name = "Labeltotaldebe"
        Me.Labeltotaldebe.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotaldebe.TabIndex = 9
        Me.Labeltotaldebe.Text = "00000000"
        Me.Labeltotaldebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'EstadoCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 597)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EstadoCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta Corriente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListacuentascorrientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListacuentascorrientesBindingSource As BindingSource
    Friend WithEvents ListacuentascorrientesTableAdapter As comercialDataSetTableAdapters.listacuentascorrientesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListacuentascorrientesDataGridView As DataGridView
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTipoSaldo As Label
    Friend WithEvents Labeltotalgeneral As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Labeltotalhaber As Label
    Friend WithEvents Labeltotaldebe As Label
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents nro As DataGridViewLinkColumn
    Friend WithEvents debe As DataGridViewTextBoxColumn
    Friend WithEvents haber As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewLinkColumn
    Friend WithEvents idventa As DataGridViewTextBoxColumn
    Friend WithEvents idpagos As DataGridViewTextBoxColumn
    Friend WithEvents Anular As DataGridViewButtonColumn
    Friend WithEvents fechavencimiento As DataGridViewTextBoxColumn
End Class

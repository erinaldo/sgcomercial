<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotePedidosDeliveryRendir
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
        Dim IdloteenvioLabel As System.Windows.Forms.Label
        Dim FechaasignacionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PedidosdeliverydetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idlistaprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ListalotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaasignacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ListalotesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListalotesdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.EstadosentregadeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListalotesdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.ListalotesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.LotesenviosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosTableAdapter()
        Me.ListalotesdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesdetalleTableAdapter()
        Me.EstadosentregadeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.estadosentregadeliveryTableAdapter()
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.PedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliveryTableAdapter()
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.LotesenviosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter()
        Me.VentasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasdetalleTableAdapter()
        Me.idloteenviodetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpedidodelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombretransporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoentrega = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.montoapagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importepagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdloteenvioLabel = New System.Windows.Forms.Label()
        FechaasignacionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListalotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListalotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListalotesdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosentregadeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdloteenvioLabel
        '
        IdloteenvioLabel.AutoSize = True
        IdloteenvioLabel.Location = New System.Drawing.Point(87, 28)
        IdloteenvioLabel.Name = "IdloteenvioLabel"
        IdloteenvioLabel.Size = New System.Drawing.Size(60, 17)
        IdloteenvioLabel.TabIndex = 1
        IdloteenvioLabel.Text = "Lote N°:"
        '
        'FechaasignacionLabel
        '
        FechaasignacionLabel.AutoSize = True
        FechaasignacionLabel.Location = New System.Drawing.Point(415, 28)
        FechaasignacionLabel.Name = "FechaasignacionLabel"
        FechaasignacionLabel.Size = New System.Drawing.Size(123, 17)
        FechaasignacionLabel.TabIndex = 9
        FechaasignacionLabel.Text = "Fecha asignación:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(686, 28)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(95, 17)
        NombreLabel.TabIndex = 10
        NombreLabel.Text = "Responsable:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PedidosdeliverydetalleDataGridView)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(FechaasignacionLabel)
        Me.GroupBox1.Controls.Add(Me.FechaasignacionDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ListalotesDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(IdloteenvioLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1315, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lote"
        '
        'PedidosdeliverydetalleDataGridView
        '
        Me.PedidosdeliverydetalleDataGridView.AutoGenerateColumns = False
        Me.PedidosdeliverydetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosdeliverydetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.idlistaprecio})
        Me.PedidosdeliverydetalleDataGridView.DataSource = Me.PedidosdeliverydetalleBindingSource
        Me.PedidosdeliverydetalleDataGridView.Location = New System.Drawing.Point(1171, 23)
        Me.PedidosdeliverydetalleDataGridView.Name = "PedidosdeliverydetalleDataGridView"
        Me.PedidosdeliverydetalleDataGridView.RowTemplate.Height = 24
        Me.PedidosdeliverydetalleDataGridView.Size = New System.Drawing.Size(34, 27)
        Me.PedidosdeliverydetalleDataGridView.TabIndex = 3
        Me.PedidosdeliverydetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idpedidodeliverydetalle"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn11.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "recargo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'idlistaprecio
        '
        Me.idlistaprecio.DataPropertyName = "idlistaprecio"
        Me.idlistaprecio.HeaderText = "idlistaprecio"
        Me.idlistaprecio.Name = "idlistaprecio"
        '
        'PedidosdeliverydetalleBindingSource
        '
        Me.PedidosdeliverydetalleBindingSource.DataMember = "pedidosdeliverydetalle"
        Me.PedidosdeliverydetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListalotesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(788, 25)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(345, 22)
        Me.NombreTextBox.TabIndex = 11
        '
        'ListalotesBindingSource
        '
        Me.ListalotesBindingSource.DataMember = "listalotes"
        Me.ListalotesBindingSource.DataSource = Me.ComercialDataSet
        '
        'FechaasignacionDateTimePicker
        '
        Me.FechaasignacionDateTimePicker.CustomFormat = "dd/mm/yyyy"
        Me.FechaasignacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ListalotesBindingSource, "fechaasignacion", True))
        Me.FechaasignacionDateTimePicker.Enabled = False
        Me.FechaasignacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaasignacionDateTimePicker.Location = New System.Drawing.Point(544, 25)
        Me.FechaasignacionDateTimePicker.Name = "FechaasignacionDateTimePicker"
        Me.FechaasignacionDateTimePicker.Size = New System.Drawing.Size(112, 22)
        Me.FechaasignacionDateTimePicker.TabIndex = 10
        '
        'ListalotesDataGridView
        '
        Me.ListalotesDataGridView.AllowUserToAddRows = False
        Me.ListalotesDataGridView.AllowUserToDeleteRows = False
        Me.ListalotesDataGridView.AutoGenerateColumns = False
        Me.ListalotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListalotesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ListalotesDataGridView.DataSource = Me.ListalotesBindingSource
        Me.ListalotesDataGridView.Location = New System.Drawing.Point(6, 34)
        Me.ListalotesDataGridView.Name = "ListalotesDataGridView"
        Me.ListalotesDataGridView.ReadOnly = True
        Me.ListalotesDataGridView.RowTemplate.Height = 24
        Me.ListalotesDataGridView.Size = New System.Drawing.Size(19, 16)
        Me.ListalotesDataGridView.TabIndex = 9
        Me.ListalotesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idloteenvio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaasignacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fechaasignacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Comenzar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListalotesdetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1315, 482)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'ListalotesdetalleDataGridView
        '
        Me.ListalotesdetalleDataGridView.AllowUserToAddRows = False
        Me.ListalotesdetalleDataGridView.AllowUserToDeleteRows = False
        Me.ListalotesdetalleDataGridView.AutoGenerateColumns = False
        Me.ListalotesdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListalotesdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idloteenviodetalle, Me.idpedidodelivery, Me.DataGridViewTextBoxColumn13, Me.nombretransporte, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.montototal, Me.estadoentrega, Me.montoapagar, Me.nroguia, Me.DataGridViewTextBoxColumn5, Me.idcliente, Me.importepagado, Me.saldo})
        Me.ListalotesdetalleDataGridView.DataSource = Me.ListalotesdetalleBindingSource
        Me.ListalotesdetalleDataGridView.Location = New System.Drawing.Point(16, 21)
        Me.ListalotesdetalleDataGridView.MultiSelect = False
        Me.ListalotesdetalleDataGridView.Name = "ListalotesdetalleDataGridView"
        Me.ListalotesdetalleDataGridView.RowTemplate.Height = 24
        Me.ListalotesdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListalotesdetalleDataGridView.Size = New System.Drawing.Size(1279, 445)
        Me.ListalotesdetalleDataGridView.TabIndex = 0
        '
        'EstadosentregadeliveryBindingSource
        '
        Me.EstadosentregadeliveryBindingSource.DataMember = "estadosentregadelivery"
        Me.EstadosentregadeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListalotesdetalleBindingSource
        '
        Me.ListalotesdetalleBindingSource.DataMember = "listalotesdetalle"
        Me.ListalotesdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(596, 589)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(158, 35)
        Me.BtnFinalizar.TabIndex = 2
        Me.BtnFinalizar.Text = " Finalizar Lote"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'ListalotesTableAdapter
        '
        Me.ListalotesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'LotesenviosTableAdapter
        '
        Me.LotesenviosTableAdapter.ClearBeforeFill = True
        '
        'ListalotesdetalleTableAdapter
        '
        Me.ListalotesdetalleTableAdapter.ClearBeforeFill = True
        '
        'EstadosentregadeliveryTableAdapter
        '
        Me.EstadosentregadeliveryTableAdapter.ClearBeforeFill = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'PedidosdeliveryTableAdapter
        '
        Me.PedidosdeliveryTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'LotesenviosdetalleTableAdapter
        '
        Me.LotesenviosdetalleTableAdapter.ClearBeforeFill = True
        '
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'PedidosdeliverydetalleTableAdapter
        '
        Me.PedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'VentasdetalleTableAdapter
        '
        Me.VentasdetalleTableAdapter.ClearBeforeFill = True
        '
        'idloteenviodetalle
        '
        Me.idloteenviodetalle.DataPropertyName = "idloteenviodetalle"
        Me.idloteenviodetalle.HeaderText = "idloteenviodetalle"
        Me.idloteenviodetalle.Name = "idloteenviodetalle"
        Me.idloteenviodetalle.ReadOnly = True
        Me.idloteenviodetalle.Visible = False
        '
        'idpedidodelivery
        '
        Me.idpedidodelivery.DataPropertyName = "idpedidodelivery"
        Me.idpedidodelivery.HeaderText = "Pedido N°"
        Me.idpedidodelivery.Name = "idpedidodelivery"
        Me.idpedidodelivery.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'nombretransporte
        '
        Me.nombretransporte.DataPropertyName = "nombretransporte"
        Me.nombretransporte.HeaderText = "Transporte"
        Me.nombretransporte.Name = "nombretransporte"
        Me.nombretransporte.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "nombreprovincia"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'montototal
        '
        Me.montototal.DataPropertyName = "montototal"
        Me.montototal.HeaderText = "Monto total"
        Me.montototal.Name = "montototal"
        Me.montototal.ReadOnly = True
        '
        'estadoentrega
        '
        Me.estadoentrega.DataSource = Me.EstadosentregadeliveryBindingSource
        Me.estadoentrega.DisplayMember = "descripcion"
        Me.estadoentrega.HeaderText = "Estado Entrega"
        Me.estadoentrega.Name = "estadoentrega"
        Me.estadoentrega.ValueMember = "idestadoentregadelivery"
        Me.estadoentrega.Width = 230
        '
        'montoapagar
        '
        Me.montoapagar.HeaderText = "Monto a pagar"
        Me.montoapagar.Name = "montoapagar"
        '
        'nroguia
        '
        Me.nroguia.HeaderText = "N° Guia"
        Me.nroguia.Name = "nroguia"
        Me.nroguia.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idloteenvio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'importepagado
        '
        Me.importepagado.DataPropertyName = "importepagado"
        Me.importepagado.HeaderText = "Pago previo"
        Me.importepagado.Name = "importepagado"
        Me.importepagado.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        Me.saldo.HeaderText = "saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Visible = False
        '
        'LotePedidosDeliveryRendir
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 644)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LotePedidosDeliveryRendir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RendirLotePedidosDelivery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PedidosdeliverydetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListalotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListalotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListalotesdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosentregadeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListalotesBindingSource As BindingSource
    Friend WithEvents ListalotesTableAdapter As comercialDataSetTableAdapters.listalotesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents FechaasignacionDateTimePicker As DateTimePicker
    Friend WithEvents ListalotesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents LotesenviosTableAdapter As comercialDataSetTableAdapters.lotesenviosTableAdapter
    Friend WithEvents ListalotesdetalleBindingSource As BindingSource
    Friend WithEvents ListalotesdetalleTableAdapter As comercialDataSetTableAdapters.listalotesdetalleTableAdapter
    Friend WithEvents ListalotesdetalleDataGridView As DataGridView
    Friend WithEvents EstadosentregadeliveryBindingSource As BindingSource
    Friend WithEvents EstadosentregadeliveryTableAdapter As comercialDataSetTableAdapters.estadosentregadeliveryTableAdapter
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents PedidosdeliveryTableAdapter As comercialDataSetTableAdapters.pedidosdeliveryTableAdapter
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents LotesenviosdetalleTableAdapter As comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents PedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents PedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter
    Friend WithEvents PedidosdeliverydetalleDataGridView As DataGridView
    Friend WithEvents VentasdetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents idlistaprecio As DataGridViewTextBoxColumn
    Friend WithEvents idloteenviodetalle As DataGridViewTextBoxColumn
    Friend WithEvents idpedidodelivery As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents nombretransporte As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents montototal As DataGridViewTextBoxColumn
    Friend WithEvents estadoentrega As DataGridViewComboBoxColumn
    Friend WithEvents montoapagar As DataGridViewTextBoxColumn
    Friend WithEvents nroguia As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents importepagado As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
End Class

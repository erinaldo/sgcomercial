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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmOrdenes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaÓrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListaordenesmesaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ListaordenesmesaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
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
        Me.TextBoxImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idformapagocombo = New System.Windows.Forms.ComboBox()
        Me.Idtipocomprobantecombo = New System.Windows.Forms.ComboBox()
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
        Me.idordenmesa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdtipocomprobanteLabel = New System.Windows.Forms.Label()
        IdformapagoLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListaordenesmesaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaordenesmesaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesmesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaÓrdenToolStripMenuItem, Me.AnularOrdenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 506)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 56)
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
        Me.GroupBox1.Controls.Add(Me.ListaordenesmesaDataGridView)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMesa)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSalon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 565)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        Me.ListaordenesmesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaordenesmesaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idordenmesa, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.producto, Me.cantidad, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.precioventa, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.subtotal})
        Me.ListaordenesmesaDataGridView.DataSource = Me.ListaordenesmesaBindingSource
        Me.ListaordenesmesaDataGridView.Location = New System.Drawing.Point(6, 79)
        Me.ListaordenesmesaDataGridView.MultiSelect = False
        Me.ListaordenesmesaDataGridView.Name = "ListaordenesmesaDataGridView"
        Me.ListaordenesmesaDataGridView.ReadOnly = True
        Me.ListaordenesmesaDataGridView.RowTemplate.Height = 24
        Me.ListaordenesmesaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaordenesmesaDataGridView.Size = New System.Drawing.Size(655, 424)
        Me.ListaordenesmesaDataGridView.TabIndex = 5
        '
        'ListaordenesmesaBindingSource
        '
        Me.ListaordenesmesaBindingSource.DataMember = "listaordenesmesa"
        Me.ListaordenesmesaBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GroupBox2.Controls.Add(Me.TextBoxImporteTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
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
        Me.GroupBox2.Location = New System.Drawing.Point(685, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 565)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'TextBoxImporteTotal
        '
        Me.TextBoxImporteTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBoxImporteTotal.Location = New System.Drawing.Point(161, 452)
        Me.TextBoxImporteTotal.Name = "TextBoxImporteTotal"
        Me.TextBoxImporteTotal.Size = New System.Drawing.Size(236, 45)
        Me.TextBoxImporteTotal.TabIndex = 46
        Me.TextBoxImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(9, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 39)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "TOTAL:"
        '
        'idformapagocombo
        '
        Me.idformapagocombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idformapagocombo.DisplayMember = "descripcion"
        Me.idformapagocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo.FormattingEnabled = True
        Me.idformapagocombo.Location = New System.Drawing.Point(105, 304)
        Me.idformapagocombo.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo.Name = "idformapagocombo"
        Me.idformapagocombo.Size = New System.Drawing.Size(152, 24)
        Me.idformapagocombo.TabIndex = 43
        Me.idformapagocombo.ValueMember = "idformapago"
        '
        'Idtipocomprobantecombo
        '
        Me.Idtipocomprobantecombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Idtipocomprobantecombo.DisplayMember = "descripcion"
        Me.Idtipocomprobantecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idtipocomprobantecombo.FormattingEnabled = True
        Me.Idtipocomprobantecombo.Location = New System.Drawing.Point(105, 270)
        Me.Idtipocomprobantecombo.Margin = New System.Windows.Forms.Padding(4)
        Me.Idtipocomprobantecombo.Name = "Idtipocomprobantecombo"
        Me.Idtipocomprobantecombo.Size = New System.Drawing.Size(166, 24)
        Me.Idtipocomprobantecombo.TabIndex = 41
        Me.Idtipocomprobantecombo.ValueMember = "idtipocomprobante"
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
        Me.Label8.Size = New System.Drawing.Size(389, 41)
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
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 506)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(397, 56)
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cod."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "descuento"
        Me.DataGridViewTextBoxColumn12.HeaderText = "descuento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idlistaprecio"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idlistaprecio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'precioventa
        '
        Me.precioventa.DataPropertyName = "precioventa"
        Me.precioventa.HeaderText = "Precio U."
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "recargo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
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
        'AdmOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 570)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdmOrdenes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListaordenesmesaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaordenesmesaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesmesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents idordenmesa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class

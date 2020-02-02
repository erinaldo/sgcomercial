<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMObrasSociales
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim AporteporcentajeLabel As System.Windows.Forms.Label
        Dim RetencionporcentajeLabel As System.Windows.Forms.Label
        Dim AportemontofijoLabel As System.Windows.Forms.Label
        Dim RetencionmontofijoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMObrasSociales))
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.IdobrasocialTextBox = New System.Windows.Forms.TextBox()
        Me.ObrassocialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.AporteporcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.RetencionporcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.AportemontofijoTextBox = New System.Windows.Forms.TextBox()
        Me.RetencionmontofijoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.ObrassocialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrassocialesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.obrassocialesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ObrassocialesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.BtnListar = New System.Windows.Forms.ToolStripButton()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CodigopostalLabel = New System.Windows.Forms.Label()
        AporteporcentajeLabel = New System.Windows.Forms.Label()
        RetencionporcentajeLabel = New System.Windows.Forms.Label()
        AportemontofijoLabel = New System.Windows.Forms.Label()
        RetencionmontofijoLabel = New System.Windows.Forms.Label()
        Me.GroupABM.SuspendLayout()
        CType(Me.ObrassocialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListado.SuspendLayout()
        CType(Me.ObrassocialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrassocialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObrassocialesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(210, 81)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(201, 109)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Dirección:"
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.Location = New System.Drawing.Point(242, 137)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(30, 17)
        CodigopostalLabel.TabIndex = 6
        CodigopostalLabel.Text = "CP:"
        '
        'AporteporcentajeLabel
        '
        AporteporcentajeLabel.AutoSize = True
        AporteporcentajeLabel.Location = New System.Drawing.Point(202, 165)
        AporteporcentajeLabel.Name = "AporteporcentajeLabel"
        AporteporcentajeLabel.Size = New System.Drawing.Size(70, 17)
        AporteporcentajeLabel.TabIndex = 8
        AporteporcentajeLabel.Text = "% Aporte:"
        '
        'RetencionporcentajeLabel
        '
        RetencionporcentajeLabel.AutoSize = True
        RetencionporcentajeLabel.Location = New System.Drawing.Point(180, 193)
        RetencionporcentajeLabel.Name = "RetencionporcentajeLabel"
        RetencionporcentajeLabel.Size = New System.Drawing.Size(92, 17)
        RetencionporcentajeLabel.TabIndex = 10
        RetencionporcentajeLabel.Text = "% Retención:"
        '
        'AportemontofijoLabel
        '
        AportemontofijoLabel.AutoSize = True
        AportemontofijoLabel.Location = New System.Drawing.Point(153, 221)
        AportemontofijoLabel.Name = "AportemontofijoLabel"
        AportemontofijoLabel.Size = New System.Drawing.Size(119, 17)
        AportemontofijoLabel.TabIndex = 12
        AportemontofijoLabel.Text = "Monto ($) Aporte:"
        '
        'RetencionmontofijoLabel
        '
        RetencionmontofijoLabel.AutoSize = True
        RetencionmontofijoLabel.Location = New System.Drawing.Point(131, 249)
        RetencionmontofijoLabel.Name = "RetencionmontofijoLabel"
        RetencionmontofijoLabel.Size = New System.Drawing.Size(141, 17)
        RetencionmontofijoLabel.TabIndex = 14
        RetencionmontofijoLabel.Text = "Monto ($) Retención:"
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(Me.IdobrasocialTextBox)
        Me.GroupABM.Controls.Add(NombreLabel)
        Me.GroupABM.Controls.Add(Me.NombreTextBox)
        Me.GroupABM.Controls.Add(DireccionLabel)
        Me.GroupABM.Controls.Add(Me.DireccionTextBox)
        Me.GroupABM.Controls.Add(CodigopostalLabel)
        Me.GroupABM.Controls.Add(Me.CodigopostalTextBox)
        Me.GroupABM.Controls.Add(AporteporcentajeLabel)
        Me.GroupABM.Controls.Add(Me.AporteporcentajeTextBox)
        Me.GroupABM.Controls.Add(RetencionporcentajeLabel)
        Me.GroupABM.Controls.Add(Me.RetencionporcentajeTextBox)
        Me.GroupABM.Controls.Add(AportemontofijoLabel)
        Me.GroupABM.Controls.Add(Me.AportemontofijoTextBox)
        Me.GroupABM.Controls.Add(RetencionmontofijoLabel)
        Me.GroupABM.Controls.Add(Me.RetencionmontofijoTextBox)
        Me.GroupABM.Location = New System.Drawing.Point(12, 50)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(708, 346)
        Me.GroupABM.TabIndex = 0
        Me.GroupABM.TabStop = False
        '
        'IdobrasocialTextBox
        '
        Me.IdobrasocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "idobrasocial", True))
        Me.IdobrasocialTextBox.Location = New System.Drawing.Point(15, 21)
        Me.IdobrasocialTextBox.Name = "IdobrasocialTextBox"
        Me.IdobrasocialTextBox.Size = New System.Drawing.Size(39, 22)
        Me.IdobrasocialTextBox.TabIndex = 1
        Me.IdobrasocialTextBox.Visible = False
        '
        'ObrassocialesBindingSource
        '
        Me.ObrassocialesBindingSource.DataMember = "obrassociales"
        Me.ObrassocialesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(275, 78)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(275, 22)
        Me.NombreTextBox.TabIndex = 3
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(275, 106)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(275, 22)
        Me.DireccionTextBox.TabIndex = 5
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "codigopostal", True))
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(275, 134)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(84, 22)
        Me.CodigopostalTextBox.TabIndex = 7
        '
        'AporteporcentajeTextBox
        '
        Me.AporteporcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "aporteporcentaje", True))
        Me.AporteporcentajeTextBox.Location = New System.Drawing.Point(275, 162)
        Me.AporteporcentajeTextBox.Name = "AporteporcentajeTextBox"
        Me.AporteporcentajeTextBox.Size = New System.Drawing.Size(84, 22)
        Me.AporteporcentajeTextBox.TabIndex = 9
        '
        'RetencionporcentajeTextBox
        '
        Me.RetencionporcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "retencionporcentaje", True))
        Me.RetencionporcentajeTextBox.Location = New System.Drawing.Point(275, 190)
        Me.RetencionporcentajeTextBox.Name = "RetencionporcentajeTextBox"
        Me.RetencionporcentajeTextBox.Size = New System.Drawing.Size(84, 22)
        Me.RetencionporcentajeTextBox.TabIndex = 11
        '
        'AportemontofijoTextBox
        '
        Me.AportemontofijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "aportemontofijo", True))
        Me.AportemontofijoTextBox.Location = New System.Drawing.Point(275, 218)
        Me.AportemontofijoTextBox.Name = "AportemontofijoTextBox"
        Me.AportemontofijoTextBox.Size = New System.Drawing.Size(84, 22)
        Me.AportemontofijoTextBox.TabIndex = 13
        '
        'RetencionmontofijoTextBox
        '
        Me.RetencionmontofijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrassocialesBindingSource, "retencionmontofijo", True))
        Me.RetencionmontofijoTextBox.Location = New System.Drawing.Point(275, 246)
        Me.RetencionmontofijoTextBox.Name = "RetencionmontofijoTextBox"
        Me.RetencionmontofijoTextBox.Size = New System.Drawing.Size(84, 22)
        Me.RetencionmontofijoTextBox.TabIndex = 15
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.ObrassocialesDataGridView)
        Me.GroupListado.Location = New System.Drawing.Point(12, 50)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(708, 346)
        Me.GroupListado.TabIndex = 1
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'ObrassocialesDataGridView
        '
        Me.ObrassocialesDataGridView.AllowUserToAddRows = False
        Me.ObrassocialesDataGridView.AllowUserToDeleteRows = False
        Me.ObrassocialesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObrassocialesDataGridView.AutoGenerateColumns = False
        Me.ObrassocialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObrassocialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ObrassocialesDataGridView.DataSource = Me.ObrassocialesBindingSource
        Me.ObrassocialesDataGridView.Location = New System.Drawing.Point(15, 21)
        Me.ObrassocialesDataGridView.Name = "ObrassocialesDataGridView"
        Me.ObrassocialesDataGridView.ReadOnly = True
        Me.ObrassocialesDataGridView.RowTemplate.Height = 24
        Me.ObrassocialesDataGridView.Size = New System.Drawing.Size(674, 305)
        Me.ObrassocialesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idobrasocial"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idobrasocial"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Nombre"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Dirección"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codigopostal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "CP"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "aporteporcentaje"
        Me.DataGridViewTextBoxColumn5.HeaderText = "aporteporcentaje"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "retencionporcentaje"
        Me.DataGridViewTextBoxColumn6.HeaderText = "retencionporcentaje"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "aportemontofijo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "aportemontofijo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "retencionmontofijo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "retencionmontofijo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'ObrassocialesTableAdapter
        '
        Me.ObrassocialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.auventascanceladasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.categoriasempleadosTableAdapter = Nothing
        Me.TableAdapterManager.centroscostoTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaproductosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadosaiTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadosordenmesaTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.gradosalumnosTableAdapter = Nothing
        Me.TableAdapterManager.gradosTableAdapter = Nothing
        Me.TableAdapterManager.gruposjerarquicosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.lotesvencimientoTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.obrassocialesTableAdapter = Me.ObrassocialesTableAdapter
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
        Me.TableAdapterManager.pagosimputacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.salonesTableAdapter = Nothing
        Me.TableAdapterManager.serviciosTableAdapter = Nothing
        Me.TableAdapterManager.sindicatosTableAdapter = Nothing
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
        'ObrassocialesBindingNavigator
        '
        Me.ObrassocialesBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.ObrassocialesBindingNavigator.BindingSource = Me.ObrassocialesBindingSource
        Me.ObrassocialesBindingNavigator.CountItem = Nothing
        Me.ObrassocialesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ObrassocialesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ObrassocialesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnEditar, Me.BtnCancelar, Me.BtnListar})
        Me.ObrassocialesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ObrassocialesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ObrassocialesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ObrassocialesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ObrassocialesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ObrassocialesBindingNavigator.Name = "ObrassocialesBindingNavigator"
        Me.ObrassocialesBindingNavigator.PositionItem = Nothing
        Me.ObrassocialesBindingNavigator.Size = New System.Drawing.Size(732, 47)
        Me.ObrassocialesBindingNavigator.TabIndex = 2
        Me.ObrassocialesBindingNavigator.Text = "BindingNavigator1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.RightToLeftAutoMirrorImage = True
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 44)
        Me.BtnNuevo.Text = "Agregar"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(67, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 47)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 44)
        Me.BtnGuardar.Tag = "Guardar"
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 44)
        Me.BtnEditar.Tag = "Editar"
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 44)
        Me.BtnCancelar.Tag = "Cancelar"
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnListar
        '
        Me.BtnListar.Image = Global.sgcomercial.My.Resources.Resources.CheckList
        Me.BtnListar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(48, 44)
        Me.BtnListar.Tag = "Listar"
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ABMObrasSociales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 403)
        Me.Controls.Add(Me.ObrassocialesBindingNavigator)
        Me.Controls.Add(Me.GroupABM)
        Me.Controls.Add(Me.GroupListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMObrasSociales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMObrasSociales"
        Me.Text = "Alta, Baja y Modificación de Obras Sociales"
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        CType(Me.ObrassocialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListado.ResumeLayout(False)
        CType(Me.ObrassocialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrassocialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObrassocialesBindingNavigator.ResumeLayout(False)
        Me.ObrassocialesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ObrassocialesBindingSource As BindingSource
    Friend WithEvents ObrassocialesTableAdapter As comercialDataSetTableAdapters.obrassocialesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObrassocialesBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents IdobrasocialTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents CodigopostalTextBox As TextBox
    Friend WithEvents AporteporcentajeTextBox As TextBox
    Friend WithEvents RetencionporcentajeTextBox As TextBox
    Friend WithEvents AportemontofijoTextBox As TextBox
    Friend WithEvents RetencionmontofijoTextBox As TextBox
    Friend WithEvents ObrassocialesDataGridView As DataGridView
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents BtnListar As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class

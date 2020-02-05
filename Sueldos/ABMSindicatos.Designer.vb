<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMSindicatos
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
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim AporteporcentajeLabel As System.Windows.Forms.Label
        Dim RetencionporcentajeLabel As System.Windows.Forms.Label
        Dim AportemontofijoLabel As System.Windows.Forms.Label
        Dim RetencionmontofijoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMSindicatos))
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.SindicatosDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.SindicatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.IdsindicatoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.AporteporcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.RetencionporcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.AportemontofijoTextBox = New System.Windows.Forms.TextBox()
        Me.RetencionmontofijoTextBox = New System.Windows.Forms.TextBox()
        Me.SindicatosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.sindicatosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.SindicatosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.BtnListar = New System.Windows.Forms.ToolStripButton()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        CodigopostalLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        AporteporcentajeLabel = New System.Windows.Forms.Label()
        RetencionporcentajeLabel = New System.Windows.Forms.Label()
        AportemontofijoLabel = New System.Windows.Forms.Label()
        RetencionmontofijoLabel = New System.Windows.Forms.Label()
        Me.GroupListado.SuspendLayout()
        CType(Me.SindicatosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupABM.SuspendLayout()
        CType(Me.SindicatosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SindicatosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(216, 50)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(207, 78)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Dirección:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(213, 106)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(65, 17)
        LocalidadLabel.TabIndex = 6
        LocalidadLabel.Text = "Localida:"
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.Location = New System.Drawing.Point(248, 134)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(30, 17)
        CodigopostalLabel.TabIndex = 8
        CodigopostalLabel.Text = "CP:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(210, 162)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Teléfono:"
        '
        'AporteporcentajeLabel
        '
        AporteporcentajeLabel.AutoSize = True
        AporteporcentajeLabel.Location = New System.Drawing.Point(208, 190)
        AporteporcentajeLabel.Name = "AporteporcentajeLabel"
        AporteporcentajeLabel.Size = New System.Drawing.Size(70, 17)
        AporteporcentajeLabel.TabIndex = 12
        AporteporcentajeLabel.Text = "% Aporte:"
        '
        'RetencionporcentajeLabel
        '
        RetencionporcentajeLabel.AutoSize = True
        RetencionporcentajeLabel.Location = New System.Drawing.Point(186, 218)
        RetencionporcentajeLabel.Name = "RetencionporcentajeLabel"
        RetencionporcentajeLabel.Size = New System.Drawing.Size(92, 17)
        RetencionporcentajeLabel.TabIndex = 14
        RetencionporcentajeLabel.Text = "% Retención:"
        '
        'AportemontofijoLabel
        '
        AportemontofijoLabel.AutoSize = True
        AportemontofijoLabel.Location = New System.Drawing.Point(159, 246)
        AportemontofijoLabel.Name = "AportemontofijoLabel"
        AportemontofijoLabel.Size = New System.Drawing.Size(119, 17)
        AportemontofijoLabel.TabIndex = 16
        AportemontofijoLabel.Text = "Monto ($) Aporte:"
        '
        'RetencionmontofijoLabel
        '
        RetencionmontofijoLabel.AutoSize = True
        RetencionmontofijoLabel.Location = New System.Drawing.Point(137, 274)
        RetencionmontofijoLabel.Name = "RetencionmontofijoLabel"
        RetencionmontofijoLabel.Size = New System.Drawing.Size(141, 17)
        RetencionmontofijoLabel.TabIndex = 18
        RetencionmontofijoLabel.Text = "Monto ($) Retención:"
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.SindicatosDataGridView)
        Me.GroupListado.Location = New System.Drawing.Point(12, 53)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(708, 341)
        Me.GroupListado.TabIndex = 0
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'SindicatosDataGridView
        '
        Me.SindicatosDataGridView.AllowUserToAddRows = False
        Me.SindicatosDataGridView.AllowUserToDeleteRows = False
        Me.SindicatosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SindicatosDataGridView.AutoGenerateColumns = False
        Me.SindicatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SindicatosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SindicatosDataGridView.DataSource = Me.SindicatosBindingSource
        Me.SindicatosDataGridView.Location = New System.Drawing.Point(6, 21)
        Me.SindicatosDataGridView.Name = "SindicatosDataGridView"
        Me.SindicatosDataGridView.ReadOnly = True
        Me.SindicatosDataGridView.RowTemplate.Height = 24
        Me.SindicatosDataGridView.Size = New System.Drawing.Size(696, 314)
        Me.SindicatosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idsindicato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idsindicato"
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
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "localidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "codigopostal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "codigopostal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "aporteporcentaje"
        Me.DataGridViewTextBoxColumn7.HeaderText = "aporteporcentaje"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "retencionporcentaje"
        Me.DataGridViewTextBoxColumn8.HeaderText = "retencionporcentaje"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "aportemontofijo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "aportemontofijo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "retencionmontofijo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "retencionmontofijo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'SindicatosBindingSource
        '
        Me.SindicatosBindingSource.DataMember = "sindicatos"
        Me.SindicatosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(Me.IdsindicatoTextBox)
        Me.GroupABM.Controls.Add(NombreLabel)
        Me.GroupABM.Controls.Add(Me.NombreTextBox)
        Me.GroupABM.Controls.Add(DireccionLabel)
        Me.GroupABM.Controls.Add(Me.DireccionTextBox)
        Me.GroupABM.Controls.Add(LocalidadLabel)
        Me.GroupABM.Controls.Add(Me.LocalidadTextBox)
        Me.GroupABM.Controls.Add(CodigopostalLabel)
        Me.GroupABM.Controls.Add(Me.CodigopostalTextBox)
        Me.GroupABM.Controls.Add(TelefonoLabel)
        Me.GroupABM.Controls.Add(Me.TelefonoTextBox)
        Me.GroupABM.Controls.Add(AporteporcentajeLabel)
        Me.GroupABM.Controls.Add(Me.AporteporcentajeTextBox)
        Me.GroupABM.Controls.Add(RetencionporcentajeLabel)
        Me.GroupABM.Controls.Add(Me.RetencionporcentajeTextBox)
        Me.GroupABM.Controls.Add(AportemontofijoLabel)
        Me.GroupABM.Controls.Add(Me.AportemontofijoTextBox)
        Me.GroupABM.Controls.Add(RetencionmontofijoLabel)
        Me.GroupABM.Controls.Add(Me.RetencionmontofijoTextBox)
        Me.GroupABM.Location = New System.Drawing.Point(12, 53)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(708, 341)
        Me.GroupABM.TabIndex = 1
        Me.GroupABM.TabStop = False
        '
        'IdsindicatoTextBox
        '
        Me.IdsindicatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "idsindicato", True))
        Me.IdsindicatoTextBox.Location = New System.Drawing.Point(6, 21)
        Me.IdsindicatoTextBox.Name = "IdsindicatoTextBox"
        Me.IdsindicatoTextBox.Size = New System.Drawing.Size(28, 22)
        Me.IdsindicatoTextBox.TabIndex = 1
        Me.IdsindicatoTextBox.Visible = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(284, 47)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(288, 22)
        Me.NombreTextBox.TabIndex = 3
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(284, 75)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(288, 22)
        Me.DireccionTextBox.TabIndex = 5
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(284, 103)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(176, 22)
        Me.LocalidadTextBox.TabIndex = 7
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "codigopostal", True))
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(284, 131)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(68, 22)
        Me.CodigopostalTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(284, 159)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(176, 22)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'AporteporcentajeTextBox
        '
        Me.AporteporcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "aporteporcentaje", True))
        Me.AporteporcentajeTextBox.Location = New System.Drawing.Point(284, 187)
        Me.AporteporcentajeTextBox.Name = "AporteporcentajeTextBox"
        Me.AporteporcentajeTextBox.Size = New System.Drawing.Size(68, 22)
        Me.AporteporcentajeTextBox.TabIndex = 13
        '
        'RetencionporcentajeTextBox
        '
        Me.RetencionporcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "retencionporcentaje", True))
        Me.RetencionporcentajeTextBox.Location = New System.Drawing.Point(284, 215)
        Me.RetencionporcentajeTextBox.Name = "RetencionporcentajeTextBox"
        Me.RetencionporcentajeTextBox.Size = New System.Drawing.Size(68, 22)
        Me.RetencionporcentajeTextBox.TabIndex = 15
        '
        'AportemontofijoTextBox
        '
        Me.AportemontofijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "aportemontofijo", True))
        Me.AportemontofijoTextBox.Location = New System.Drawing.Point(284, 243)
        Me.AportemontofijoTextBox.Name = "AportemontofijoTextBox"
        Me.AportemontofijoTextBox.Size = New System.Drawing.Size(68, 22)
        Me.AportemontofijoTextBox.TabIndex = 17
        '
        'RetencionmontofijoTextBox
        '
        Me.RetencionmontofijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SindicatosBindingSource, "retencionmontofijo", True))
        Me.RetencionmontofijoTextBox.Location = New System.Drawing.Point(284, 271)
        Me.RetencionmontofijoTextBox.Name = "RetencionmontofijoTextBox"
        Me.RetencionmontofijoTextBox.Size = New System.Drawing.Size(68, 22)
        Me.RetencionmontofijoTextBox.TabIndex = 19
        '
        'SindicatosTableAdapter
        '
        Me.SindicatosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.obrassocialesTableAdapter = Nothing
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
        Me.TableAdapterManager.sindicatosTableAdapter = Me.SindicatosTableAdapter
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
        'SindicatosBindingNavigator
        '
        Me.SindicatosBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.SindicatosBindingNavigator.BindingSource = Me.SindicatosBindingSource
        Me.SindicatosBindingNavigator.CountItem = Nothing
        Me.SindicatosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SindicatosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SindicatosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnEditar, Me.BtnCancelar, Me.BtnListar})
        Me.SindicatosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SindicatosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SindicatosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SindicatosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SindicatosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SindicatosBindingNavigator.Name = "SindicatosBindingNavigator"
        Me.SindicatosBindingNavigator.PositionItem = Nothing
        Me.SindicatosBindingNavigator.Size = New System.Drawing.Size(732, 47)
        Me.SindicatosBindingNavigator.TabIndex = 2
        Me.SindicatosBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 47)
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
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 44)
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 44)
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnListar
        '
        Me.BtnListar.Image = Global.sgcomercial.My.Resources.Resources.CheckList
        Me.BtnListar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(48, 44)
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ABMSindicatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 406)
        Me.Controls.Add(Me.SindicatosBindingNavigator)
        Me.Controls.Add(Me.GroupABM)
        Me.Controls.Add(Me.GroupListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMSindicatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMSindicatos"
        Me.Text = "Alta, Baja y Modificación de Sindicatos"
        Me.GroupListado.ResumeLayout(False)
        CType(Me.SindicatosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        CType(Me.SindicatosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SindicatosBindingNavigator.ResumeLayout(False)
        Me.SindicatosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SindicatosBindingSource As BindingSource
    Friend WithEvents SindicatosTableAdapter As comercialDataSetTableAdapters.sindicatosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SindicatosBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents SindicatosDataGridView As DataGridView
    Friend WithEvents IdsindicatoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents CodigopostalTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents AporteporcentajeTextBox As TextBox
    Friend WithEvents RetencionporcentajeTextBox As TextBox
    Friend WithEvents AportemontofijoTextBox As TextBox
    Friend WithEvents RetencionmontofijoTextBox As TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class

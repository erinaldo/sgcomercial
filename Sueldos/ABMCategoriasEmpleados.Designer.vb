<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCategoriasEmpleados
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
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim Adicional1Label As System.Windows.Forms.Label
        Dim Adicional2Label As System.Windows.Forms.Label
        Dim HorasnormalesLabel As System.Windows.Forms.Label
        Dim HorasminimasimponiblesLabel As System.Windows.Forms.Label
        Dim DiasminimosimponiblesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCategoriasEmpleados))
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.IdcategoriaempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriasempleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.Adicional1TextBox = New System.Windows.Forms.TextBox()
        Me.Adicional2TextBox = New System.Windows.Forms.TextBox()
        Me.HorasnormalesTextBox = New System.Windows.Forms.TextBox()
        Me.HorasminimasimponiblesTextBox = New System.Windows.Forms.TextBox()
        Me.DiasminimosimponiblesTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.CategoriasempleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasempleadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.categoriasempleadosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CategoriasempleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        CategoriaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        Adicional1Label = New System.Windows.Forms.Label()
        Adicional2Label = New System.Windows.Forms.Label()
        HorasnormalesLabel = New System.Windows.Forms.Label()
        HorasminimasimponiblesLabel = New System.Windows.Forms.Label()
        DiasminimosimponiblesLabel = New System.Windows.Forms.Label()
        Me.GroupABM.SuspendLayout()
        CType(Me.CategoriasempleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupListado.SuspendLayout()
        CType(Me.CategoriasempleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasempleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriasempleadosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(231, 64)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(73, 17)
        CategoriaLabel.TabIndex = 2
        CategoriaLabel.Text = "Categoría:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(218, 92)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripción:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(245, 120)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(59, 17)
        ImporteLabel.TabIndex = 6
        ImporteLabel.Text = "Importe:"
        '
        'Adicional1Label
        '
        Adicional1Label.AutoSize = True
        Adicional1Label.Location = New System.Drawing.Point(223, 148)
        Adicional1Label.Name = "Adicional1Label"
        Adicional1Label.Size = New System.Drawing.Size(81, 17)
        Adicional1Label.TabIndex = 8
        Adicional1Label.Text = "Adicional 1:"
        '
        'Adicional2Label
        '
        Adicional2Label.AutoSize = True
        Adicional2Label.Location = New System.Drawing.Point(223, 176)
        Adicional2Label.Name = "Adicional2Label"
        Adicional2Label.Size = New System.Drawing.Size(81, 17)
        Adicional2Label.TabIndex = 10
        Adicional2Label.Text = "Adicional 2:"
        '
        'HorasnormalesLabel
        '
        HorasnormalesLabel.AutoSize = True
        HorasnormalesLabel.Location = New System.Drawing.Point(190, 204)
        HorasnormalesLabel.Name = "HorasnormalesLabel"
        HorasnormalesLabel.Size = New System.Drawing.Size(114, 17)
        HorasnormalesLabel.TabIndex = 12
        HorasnormalesLabel.Text = "Horas Normales:"
        '
        'HorasminimasimponiblesLabel
        '
        HorasminimasimponiblesLabel.AutoSize = True
        HorasminimasimponiblesLabel.Location = New System.Drawing.Point(128, 232)
        HorasminimasimponiblesLabel.Name = "HorasminimasimponiblesLabel"
        HorasminimasimponiblesLabel.Size = New System.Drawing.Size(176, 17)
        HorasminimasimponiblesLabel.TabIndex = 14
        HorasminimasimponiblesLabel.Text = "Horas Minimas Imponibles:"
        '
        'DiasminimosimponiblesLabel
        '
        DiasminimosimponiblesLabel.AutoSize = True
        DiasminimosimponiblesLabel.Location = New System.Drawing.Point(138, 260)
        DiasminimosimponiblesLabel.Name = "DiasminimosimponiblesLabel"
        DiasminimosimponiblesLabel.Size = New System.Drawing.Size(166, 17)
        DiasminimosimponiblesLabel.TabIndex = 16
        DiasminimosimponiblesLabel.Text = "Días Minimos Imponibles:"
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(Me.IdcategoriaempleadoTextBox)
        Me.GroupABM.Controls.Add(CategoriaLabel)
        Me.GroupABM.Controls.Add(Me.CategoriaTextBox)
        Me.GroupABM.Controls.Add(DescripcionLabel)
        Me.GroupABM.Controls.Add(Me.DescripcionTextBox)
        Me.GroupABM.Controls.Add(ImporteLabel)
        Me.GroupABM.Controls.Add(Me.ImporteTextBox)
        Me.GroupABM.Controls.Add(Adicional1Label)
        Me.GroupABM.Controls.Add(Me.Adicional1TextBox)
        Me.GroupABM.Controls.Add(Adicional2Label)
        Me.GroupABM.Controls.Add(Me.Adicional2TextBox)
        Me.GroupABM.Controls.Add(HorasnormalesLabel)
        Me.GroupABM.Controls.Add(Me.HorasnormalesTextBox)
        Me.GroupABM.Controls.Add(HorasminimasimponiblesLabel)
        Me.GroupABM.Controls.Add(Me.HorasminimasimponiblesTextBox)
        Me.GroupABM.Controls.Add(DiasminimosimponiblesLabel)
        Me.GroupABM.Controls.Add(Me.DiasminimosimponiblesTextBox)
        Me.GroupABM.Location = New System.Drawing.Point(12, 51)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(708, 340)
        Me.GroupABM.TabIndex = 0
        Me.GroupABM.TabStop = False
        '
        'IdcategoriaempleadoTextBox
        '
        Me.IdcategoriaempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "idcategoriaempleado", True))
        Me.IdcategoriaempleadoTextBox.Location = New System.Drawing.Point(17, 41)
        Me.IdcategoriaempleadoTextBox.Name = "IdcategoriaempleadoTextBox"
        Me.IdcategoriaempleadoTextBox.Size = New System.Drawing.Size(35, 22)
        Me.IdcategoriaempleadoTextBox.TabIndex = 1
        Me.IdcategoriaempleadoTextBox.Visible = False
        '
        'CategoriasempleadosBindingSource
        '
        Me.CategoriasempleadosBindingSource.DataMember = "categoriasempleados"
        Me.CategoriasempleadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(310, 61)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(271, 22)
        Me.CategoriaTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(310, 89)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(271, 22)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "importe", True))
        Me.ImporteTextBox.Location = New System.Drawing.Point(310, 117)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(81, 22)
        Me.ImporteTextBox.TabIndex = 7
        '
        'Adicional1TextBox
        '
        Me.Adicional1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "adicional1", True))
        Me.Adicional1TextBox.Location = New System.Drawing.Point(310, 145)
        Me.Adicional1TextBox.Name = "Adicional1TextBox"
        Me.Adicional1TextBox.Size = New System.Drawing.Size(81, 22)
        Me.Adicional1TextBox.TabIndex = 9
        '
        'Adicional2TextBox
        '
        Me.Adicional2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "adicional2", True))
        Me.Adicional2TextBox.Location = New System.Drawing.Point(310, 173)
        Me.Adicional2TextBox.Name = "Adicional2TextBox"
        Me.Adicional2TextBox.Size = New System.Drawing.Size(81, 22)
        Me.Adicional2TextBox.TabIndex = 11
        '
        'HorasnormalesTextBox
        '
        Me.HorasnormalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "horasnormales", True))
        Me.HorasnormalesTextBox.Location = New System.Drawing.Point(310, 201)
        Me.HorasnormalesTextBox.Name = "HorasnormalesTextBox"
        Me.HorasnormalesTextBox.Size = New System.Drawing.Size(81, 22)
        Me.HorasnormalesTextBox.TabIndex = 13
        '
        'HorasminimasimponiblesTextBox
        '
        Me.HorasminimasimponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "horasminimasimponibles", True))
        Me.HorasminimasimponiblesTextBox.Location = New System.Drawing.Point(310, 229)
        Me.HorasminimasimponiblesTextBox.Name = "HorasminimasimponiblesTextBox"
        Me.HorasminimasimponiblesTextBox.Size = New System.Drawing.Size(81, 22)
        Me.HorasminimasimponiblesTextBox.TabIndex = 15
        '
        'DiasminimosimponiblesTextBox
        '
        Me.DiasminimosimponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasempleadosBindingSource, "diasminimosimponibles", True))
        Me.DiasminimosimponiblesTextBox.Location = New System.Drawing.Point(310, 257)
        Me.DiasminimosimponiblesTextBox.Name = "DiasminimosimponiblesTextBox"
        Me.DiasminimosimponiblesTextBox.Size = New System.Drawing.Size(81, 22)
        Me.DiasminimosimponiblesTextBox.TabIndex = 17
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.CategoriasempleadosDataGridView)
        Me.GroupListado.Location = New System.Drawing.Point(12, 51)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(708, 340)
        Me.GroupListado.TabIndex = 0
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'CategoriasempleadosDataGridView
        '
        Me.CategoriasempleadosDataGridView.AllowUserToAddRows = False
        Me.CategoriasempleadosDataGridView.AllowUserToDeleteRows = False
        Me.CategoriasempleadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoriasempleadosDataGridView.AutoGenerateColumns = False
        Me.CategoriasempleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriasempleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CategoriasempleadosDataGridView.DataSource = Me.CategoriasempleadosBindingSource
        Me.CategoriasempleadosDataGridView.Location = New System.Drawing.Point(17, 26)
        Me.CategoriasempleadosDataGridView.Name = "CategoriasempleadosDataGridView"
        Me.CategoriasempleadosDataGridView.ReadOnly = True
        Me.CategoriasempleadosDataGridView.RowTemplate.Height = 24
        Me.CategoriasempleadosDataGridView.Size = New System.Drawing.Size(673, 294)
        Me.CategoriasempleadosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcategoriaempleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idcategoriaempleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn4.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "adicional1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "adicional1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "adicional2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "adicional2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "horasnormales"
        Me.DataGridViewTextBoxColumn7.HeaderText = "horasnormales"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "horasminimasimponibles"
        Me.DataGridViewTextBoxColumn8.HeaderText = "horasminimasimponibles"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "diasminimosimponibles"
        Me.DataGridViewTextBoxColumn9.HeaderText = "diasminimosimponibles"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'CategoriasempleadosTableAdapter
        '
        Me.CategoriasempleadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.categoriasempleadosTableAdapter = Me.CategoriasempleadosTableAdapter
        Me.TableAdapterManager.centroscostoTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.conceptossueldosTableAdapter = Nothing
        Me.TableAdapterManager.condicionempleoTableAdapter = Nothing
        Me.TableAdapterManager.convenioempleoTableAdapter = Nothing
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
        Me.TableAdapterManager.incapacidadesTableAdapter = Nothing
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
        Me.TableAdapterManager.sindicatosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosueldoTableAdapter = Nothing
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
        'CategoriasempleadosBindingNavigator
        '
        Me.CategoriasempleadosBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.CategoriasempleadosBindingNavigator.BindingSource = Me.CategoriasempleadosBindingSource
        Me.CategoriasempleadosBindingNavigator.CountItem = Nothing
        Me.CategoriasempleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoriasempleadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CategoriasempleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnEditar, Me.BtnCancelar, Me.BtnListar})
        Me.CategoriasempleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriasempleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoriasempleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoriasempleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoriasempleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoriasempleadosBindingNavigator.Name = "CategoriasempleadosBindingNavigator"
        Me.CategoriasempleadosBindingNavigator.PositionItem = Nothing
        Me.CategoriasempleadosBindingNavigator.Size = New System.Drawing.Size(732, 47)
        Me.CategoriasempleadosBindingNavigator.TabIndex = 1
        Me.CategoriasempleadosBindingNavigator.Text = "BindingNavigator1"
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
        'ABMCategoriasEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 403)
        Me.Controls.Add(Me.CategoriasempleadosBindingNavigator)
        Me.Controls.Add(Me.GroupABM)
        Me.Controls.Add(Me.GroupListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMCategoriasEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta, Baja y Modificación de Categorías"
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        CType(Me.CategoriasempleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupListado.ResumeLayout(False)
        CType(Me.CategoriasempleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasempleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriasempleadosBindingNavigator.ResumeLayout(False)
        Me.CategoriasempleadosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents CategoriasempleadosBindingSource As BindingSource
    Friend WithEvents CategoriasempleadosTableAdapter As comercialDataSetTableAdapters.categoriasempleadosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriasempleadosBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents IdcategoriaempleadoTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents ImporteTextBox As TextBox
    Friend WithEvents Adicional1TextBox As TextBox
    Friend WithEvents Adicional2TextBox As TextBox
    Friend WithEvents HorasnormalesTextBox As TextBox
    Friend WithEvents HorasminimasimponiblesTextBox As TextBox
    Friend WithEvents DiasminimosimponiblesTextBox As TextBox
    Friend WithEvents CategoriasempleadosDataGridView As DataGridView
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
End Class

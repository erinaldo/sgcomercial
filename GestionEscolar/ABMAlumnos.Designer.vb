<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMAlumnos
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
        Dim IdalumnoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FechanacimientoLabel As System.Windows.Forms.Label
        Dim IdtipodocumentoLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMAlumnos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdalumnoTextBox = New System.Windows.Forms.TextBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.FechanacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdtipodocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.TipodocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.AlumnosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.TipodocumentosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipodocumentosTableAdapter()
        Me.AlumnosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlumnosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.filtrotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlumnosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdalumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        FechanacimientoLabel = New System.Windows.Forms.Label()
        IdtipodocumentoLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlumnosBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdalumnoLabel
        '
        IdalumnoLabel.AutoSize = True
        IdalumnoLabel.Location = New System.Drawing.Point(214, 35)
        IdalumnoLabel.Name = "IdalumnoLabel"
        IdalumnoLabel.Size = New System.Drawing.Size(25, 17)
        IdalumnoLabel.TabIndex = 0
        IdalumnoLabel.Text = "ID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(112, 63)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(127, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Apellido y Nombre:"
        '
        'FechanacimientoLabel
        '
        FechanacimientoLabel.AutoSize = True
        FechanacimientoLabel.Location = New System.Drawing.Point(114, 92)
        FechanacimientoLabel.Name = "FechanacimientoLabel"
        FechanacimientoLabel.Size = New System.Drawing.Size(125, 17)
        FechanacimientoLabel.TabIndex = 4
        FechanacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'IdtipodocumentoLabel
        '
        IdtipodocumentoLabel.AutoSize = True
        IdtipodocumentoLabel.Location = New System.Drawing.Point(123, 119)
        IdtipodocumentoLabel.Name = "IdtipodocumentoLabel"
        IdtipodocumentoLabel.Size = New System.Drawing.Size(116, 17)
        IdtipodocumentoLabel.TabIndex = 6
        IdtipodocumentoLabel.Text = "Tipo Documento:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(155, 150)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(84, 17)
        DocumentoLabel.TabIndex = 8
        DocumentoLabel.Text = "Documento:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(IdalumnoLabel)
        Me.GroupBox1.Controls.Add(Me.IdalumnoTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(FechanacimientoLabel)
        Me.GroupBox1.Controls.Add(Me.FechanacimientoDateTimePicker)
        Me.GroupBox1.Controls.Add(IdtipodocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.IdtipodocumentoComboBox)
        Me.GroupBox1.Controls.Add(DocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.DocumentoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'IdalumnoTextBox
        '
        Me.IdalumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "idalumno", True))
        Me.IdalumnoTextBox.Enabled = False
        Me.IdalumnoTextBox.Location = New System.Drawing.Point(244, 32)
        Me.IdalumnoTextBox.Name = "IdalumnoTextBox"
        Me.IdalumnoTextBox.Size = New System.Drawing.Size(58, 22)
        Me.IdalumnoTextBox.TabIndex = 0
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(244, 60)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(445, 22)
        Me.NombreTextBox.TabIndex = 1
        '
        'FechanacimientoDateTimePicker
        '
        Me.FechanacimientoDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechanacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "fechanacimiento", True))
        Me.FechanacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechanacimientoDateTimePicker.Location = New System.Drawing.Point(244, 88)
        Me.FechanacimientoDateTimePicker.Name = "FechanacimientoDateTimePicker"
        Me.FechanacimientoDateTimePicker.Size = New System.Drawing.Size(147, 22)
        Me.FechanacimientoDateTimePicker.TabIndex = 2
        '
        'IdtipodocumentoComboBox
        '
        Me.IdtipodocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AlumnosBindingSource, "idtipodocumento", True))
        Me.IdtipodocumentoComboBox.DataSource = Me.TipodocumentosBindingSource
        Me.IdtipodocumentoComboBox.DisplayMember = "descripcion"
        Me.IdtipodocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdtipodocumentoComboBox.FormattingEnabled = True
        Me.IdtipodocumentoComboBox.Location = New System.Drawing.Point(244, 116)
        Me.IdtipodocumentoComboBox.Name = "IdtipodocumentoComboBox"
        Me.IdtipodocumentoComboBox.Size = New System.Drawing.Size(223, 24)
        Me.IdtipodocumentoComboBox.TabIndex = 3
        Me.IdtipodocumentoComboBox.ValueMember = "idtipodocumento"
        '
        'TipodocumentosBindingSource
        '
        Me.TipodocumentosBindingSource.DataMember = "tipodocumentos"
        Me.TipodocumentosBindingSource.DataSource = Me.ComercialDataSet
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(244, 147)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(110, 22)
        Me.DocumentoTextBox.TabIndex = 4
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Me.AlumnosTableAdapter
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
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
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
        Me.TableAdapterManager.gradosalumnosTableAdapter = Nothing
        Me.TableAdapterManager.gradosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
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
        Me.TableAdapterManager.salonesTableAdapter = Nothing
        Me.TableAdapterManager.serviciosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipodocumentosTableAdapter = Me.TipodocumentosTableAdapter
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
        'TipodocumentosTableAdapter
        '
        Me.TipodocumentosTableAdapter.ClearBeforeFill = True
        '
        'AlumnosBindingNavigator
        '
        Me.AlumnosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlumnosBindingNavigator.BindingSource = Me.AlumnosBindingSource
        Me.AlumnosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlumnosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlumnosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AlumnosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlumnosBindingNavigatorSaveItem, Me.ToolStripButtonEditar, Me.ToolStripButtonEliminar, Me.ToolStripButtonCancelar})
        Me.AlumnosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlumnosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlumnosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlumnosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlumnosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlumnosBindingNavigator.Name = "AlumnosBindingNavigator"
        Me.AlumnosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlumnosBindingNavigator.Size = New System.Drawing.Size(740, 47)
        Me.AlumnosBindingNavigator.TabIndex = 1
        Me.AlumnosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(111, 44)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 44)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "-"
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
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        'AlumnosBindingNavigatorSaveItem
        '
        Me.AlumnosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlumnosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlumnosBindingNavigatorSaveItem.Name = "AlumnosBindingNavigatorSaveItem"
        Me.AlumnosBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.AlumnosBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.AlumnosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.sgcomercial.My.Resources.Resources.editar
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(52, 44)
        Me.ToolStripButtonEditar.Text = "Editar"
        Me.ToolStripButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonEliminar
        '
        Me.ToolStripButtonEliminar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.ToolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEliminar.Name = "ToolStripButtonEliminar"
        Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(67, 44)
        Me.ToolStripButtonEliminar.Text = "Eliminar"
        Me.ToolStripButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonCancelar
        '
        Me.ToolStripButtonCancelar.Image = Global.sgcomercial.My.Resources.Resources.reload_512
        Me.ToolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCancelar.Name = "ToolStripButtonCancelar"
        Me.ToolStripButtonCancelar.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButtonCancelar.Text = "Cancelar"
        Me.ToolStripButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.filtrotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.AlumnosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(716, 320)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'filtrotextbox
        '
        Me.filtrotextbox.Location = New System.Drawing.Point(290, 34)
        Me.filtrotextbox.Name = "filtrotextbox"
        Me.filtrotextbox.Size = New System.Drawing.Size(294, 22)
        Me.filtrotextbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtrar por Nombre:"
        '
        'AlumnosDataGridView
        '
        Me.AlumnosDataGridView.AllowUserToAddRows = False
        Me.AlumnosDataGridView.AllowUserToDeleteRows = False
        Me.AlumnosDataGridView.AutoGenerateColumns = False
        Me.AlumnosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlumnosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AlumnosDataGridView.DataSource = Me.AlumnosBindingSource
        Me.AlumnosDataGridView.Location = New System.Drawing.Point(24, 72)
        Me.AlumnosDataGridView.Name = "AlumnosDataGridView"
        Me.AlumnosDataGridView.ReadOnly = True
        Me.AlumnosDataGridView.RowTemplate.Height = 24
        Me.AlumnosDataGridView.Size = New System.Drawing.Size(673, 228)
        Me.AlumnosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idalumno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idalumno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 87
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechanacimiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechanacimiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idtipodocumento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idtipodocumento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "documento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Documento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 109
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn7.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'ABMAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 575)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AlumnosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "RegistroAlumnos"
        Me.Text = "Registro de Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlumnosBindingNavigator.ResumeLayout(False)
        Me.AlumnosBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AlumnosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As comercialDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlumnosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AlumnosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdalumnoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents FechanacimientoDateTimePicker As DateTimePicker
    Friend WithEvents IdtipodocumentoComboBox As ComboBox
    Friend WithEvents DocumentoTextBox As TextBox
    Friend WithEvents TipodocumentosTableAdapter As comercialDataSetTableAdapters.tipodocumentosTableAdapter
    Friend WithEvents TipodocumentosBindingSource As BindingSource
    Friend WithEvents ToolStripButtonEditar As ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents filtrotextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AlumnosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class

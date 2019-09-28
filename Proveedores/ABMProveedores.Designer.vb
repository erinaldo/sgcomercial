<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMProveedores
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
        Dim IdproveedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuitcuilLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PersonacontactoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMProveedores))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.proveedoresTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboCondicionIVA = New System.Windows.Forms.ComboBox()
        Me.TipocondicionivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet1 = New sgcomercial.comercialDataSet()
        Me.IdproveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CuitcuilTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PersonacontactoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComercialDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipocondicionivaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocondicionivaTableAdapter()
        IdproveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CuitcuilLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PersonacontactoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdproveedorLabel
        '
        IdproveedorLabel.AutoSize = True
        IdproveedorLabel.Location = New System.Drawing.Point(141, 30)
        IdproveedorLabel.Name = "IdproveedorLabel"
        IdproveedorLabel.Size = New System.Drawing.Size(88, 17)
        IdproveedorLabel.TabIndex = 16
        IdproveedorLabel.Text = "idproveedor:"
        IdproveedorLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(168, 58)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 18
        NombreLabel.Text = "Nombre:"
        '
        'CuitcuilLabel
        '
        CuitcuilLabel.AutoSize = True
        CuitcuilLabel.Location = New System.Drawing.Point(167, 86)
        CuitcuilLabel.Name = "CuitcuilLabel"
        CuitcuilLabel.Size = New System.Drawing.Size(63, 17)
        CuitcuilLabel.TabIndex = 20
        CuitcuilLabel.Text = "Cuit/Cuil:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(163, 114)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 22
        TelefonoLabel.Text = "Teléfono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(184, 142)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "Email:"
        '
        'PersonacontactoLabel
        '
        PersonacontactoLabel.AutoSize = True
        PersonacontactoLabel.Location = New System.Drawing.Point(87, 172)
        PersonacontactoLabel.Name = "PersonacontactoLabel"
        PersonacontactoLabel.Size = New System.Drawing.Size(143, 17)
        PersonacontactoLabel.TabIndex = 28
        PersonacontactoLabel.Text = "Persona de contacto:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(133, 204)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(95, 17)
        Label1.TabIndex = 30
        Label1.Text = "Condición IVA"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ComercialDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.salonesTableAdapter = Nothing
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
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Nothing
        Me.ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedoresBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Nothing
        Me.ProveedoresBindingNavigator.MoveLastItem = Nothing
        Me.ProveedoresBindingNavigator.MoveNextItem = Nothing
        Me.ProveedoresBindingNavigator.MovePreviousItem = Nothing
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Nothing
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(982, 27)
        Me.ProveedoresBindingNavigator.TabIndex = 0
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(131, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'ProveedoresBindingNavigatorSaveItem
        '
        Me.ProveedoresBindingNavigatorSaveItem.Enabled = False
        Me.ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedoresBindingNavigatorSaveItem.Name = "ProveedoresBindingNavigatorSaveItem"
        Me.ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.sgcomercial.My.Resources.Resources.editar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 24)
        Me.ToolStripButton1.Text = "Editar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(90, 24)
        Me.ToolStripButton2.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.ComboCondicionIVA)
        Me.GroupBox1.Controls.Add(IdproveedorLabel)
        Me.GroupBox1.Controls.Add(Me.IdproveedorTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(CuitcuilLabel)
        Me.GroupBox1.Controls.Add(Me.CuitcuilTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(PersonacontactoLabel)
        Me.GroupBox1.Controls.Add(Me.PersonacontactoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(958, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'ComboCondicionIVA
        '
        Me.ComboCondicionIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProveedoresBindingSource, "condicioniva", True))
        Me.ComboCondicionIVA.DataSource = Me.TipocondicionivaBindingSource
        Me.ComboCondicionIVA.DisplayMember = "descripcion"
        Me.ComboCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCondicionIVA.FormattingEnabled = True
        Me.ComboCondicionIVA.Location = New System.Drawing.Point(237, 199)
        Me.ComboCondicionIVA.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboCondicionIVA.Name = "ComboCondicionIVA"
        Me.ComboCondicionIVA.Size = New System.Drawing.Size(336, 24)
        Me.ComboCondicionIVA.TabIndex = 29
        Me.ComboCondicionIVA.ValueMember = "idtipocondicioniva"
        '
        'TipocondicionivaBindingSource
        '
        Me.TipocondicionivaBindingSource.DataMember = "tipocondicioniva"
        Me.TipocondicionivaBindingSource.DataSource = Me.ComercialDataSet1
        '
        'ComercialDataSet1
        '
        Me.ComercialDataSet1.DataSetName = "comercialDataSet"
        Me.ComercialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdproveedorTextBox
        '
        Me.IdproveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "idproveedor", True))
        Me.IdproveedorTextBox.Location = New System.Drawing.Point(237, 27)
        Me.IdproveedorTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdproveedorTextBox.Name = "IdproveedorTextBox"
        Me.IdproveedorTextBox.Size = New System.Drawing.Size(175, 22)
        Me.IdproveedorTextBox.TabIndex = 0
        Me.IdproveedorTextBox.Visible = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(237, 55)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(339, 22)
        Me.NombreTextBox.TabIndex = 1
        '
        'CuitcuilTextBox
        '
        Me.CuitcuilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "cuitcuil", True))
        Me.CuitcuilTextBox.Location = New System.Drawing.Point(237, 82)
        Me.CuitcuilTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CuitcuilTextBox.Name = "CuitcuilTextBox"
        Me.CuitcuilTextBox.Size = New System.Drawing.Size(103, 22)
        Me.CuitcuilTextBox.TabIndex = 2
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(237, 111)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(103, 22)
        Me.TelefonoTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(237, 139)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(253, 22)
        Me.EmailTextBox.TabIndex = 4
        '
        'PersonacontactoTextBox
        '
        Me.PersonacontactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "personacontacto", True))
        Me.PersonacontactoTextBox.Location = New System.Drawing.Point(237, 169)
        Me.PersonacontactoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PersonacontactoTextBox.Name = "PersonacontactoTextBox"
        Me.PersonacontactoTextBox.Size = New System.Drawing.Size(339, 22)
        Me.PersonacontactoTextBox.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProveedoresDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(958, 263)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Proveedores"
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(13, 30)
        Me.ProveedoresDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProveedoresDataGridView.MultiSelect = False
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.ReadOnly = True
        Me.ProveedoresDataGridView.RowTemplate.Height = 24
        Me.ProveedoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(931, 212)
        Me.ProveedoresDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idproveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idproveedor"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cuitcuil"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cuit/Cuil"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 88
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 93
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 71
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "personacontacto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 93
        '
        'ComercialDataSet1BindingSource
        '
        Me.ComercialDataSet1BindingSource.DataSource = Me.ComercialDataSet1
        Me.ComercialDataSet1BindingSource.Position = 0
        '
        'TipocondicionivaTableAdapter
        '
        Me.TipocondicionivaTableAdapter.ClearBeforeFill = True
        '
        'ABMProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMProveedores"
        Me.Text = "Agenda de Proveedores - Altas, Bajas y Modificación de Proveedores"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As comercialDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdproveedorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CuitcuilTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PersonacontactoTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProveedoresDataGridView As DataGridView
    Friend WithEvents ComercialDataSet1BindingSource As BindingSource
    Friend WithEvents ComercialDataSet1 As comercialDataSet
    Friend WithEvents TipocondicionivaBindingSource As BindingSource
    Friend WithEvents TipocondicionivaTableAdapter As comercialDataSetTableAdapters.tipocondicionivaTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ComboCondicionIVA As ComboBox
End Class

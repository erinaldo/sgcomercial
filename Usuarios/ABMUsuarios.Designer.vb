<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Dim IdusuarioLabel As System.Windows.Forms.Label
        Dim FechaaltaLabel As System.Windows.Forms.Label
        Dim FechabajaLabel As System.Windows.Forms.Label
        Dim FechamodificacionLabel As System.Windows.Forms.Label
        Dim UsuarioaltaLabel As System.Windows.Forms.Label
        Dim UsuariobajaLabel As System.Windows.Forms.Label
        Dim UsuariomodificacionLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim IdperfilLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMUsuarios))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PerfilesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.perfilesTableAdapter()
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdusuarioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaaltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechabajaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechamodificacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsuarioaltaTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariobajaTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariomodificacionTextBox = New System.Windows.Forms.TextBox()
        Me.PerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdperfilComboBox = New System.Windows.Forms.ComboBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Reactivar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.usuarioalta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewButtonColumn()
        IdusuarioLabel = New System.Windows.Forms.Label()
        FechaaltaLabel = New System.Windows.Forms.Label()
        FechabajaLabel = New System.Windows.Forms.Label()
        FechamodificacionLabel = New System.Windows.Forms.Label()
        UsuarioaltaLabel = New System.Windows.Forms.Label()
        UsuariobajaLabel = New System.Windows.Forms.Label()
        UsuariomodificacionLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        IdperfilLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdusuarioLabel
        '
        IdusuarioLabel.AutoSize = True
        IdusuarioLabel.Location = New System.Drawing.Point(666, 27)
        IdusuarioLabel.Name = "IdusuarioLabel"
        IdusuarioLabel.Size = New System.Drawing.Size(70, 17)
        IdusuarioLabel.TabIndex = 2
        IdusuarioLabel.Text = "idusuario:"
        IdusuarioLabel.Visible = False
        '
        'FechaaltaLabel
        '
        FechaaltaLabel.AutoSize = True
        FechaaltaLabel.Location = New System.Drawing.Point(666, 56)
        FechaaltaLabel.Name = "FechaaltaLabel"
        FechaaltaLabel.Size = New System.Drawing.Size(70, 17)
        FechaaltaLabel.TabIndex = 8
        FechaaltaLabel.Text = "fechaalta:"
        FechaaltaLabel.Visible = False
        '
        'FechabajaLabel
        '
        FechabajaLabel.AutoSize = True
        FechabajaLabel.Location = New System.Drawing.Point(662, 198)
        FechabajaLabel.Name = "FechabajaLabel"
        FechabajaLabel.Size = New System.Drawing.Size(74, 17)
        FechabajaLabel.TabIndex = 10
        FechabajaLabel.Text = "fechabaja:"
        FechabajaLabel.Visible = False
        '
        'FechamodificacionLabel
        '
        FechamodificacionLabel.AutoSize = True
        FechamodificacionLabel.Location = New System.Drawing.Point(611, 89)
        FechamodificacionLabel.Name = "FechamodificacionLabel"
        FechamodificacionLabel.Size = New System.Drawing.Size(125, 17)
        FechamodificacionLabel.TabIndex = 12
        FechamodificacionLabel.Text = "fechamodificacion:"
        FechamodificacionLabel.Visible = False
        '
        'UsuarioaltaLabel
        '
        UsuarioaltaLabel.AutoSize = True
        UsuarioaltaLabel.Location = New System.Drawing.Point(654, 116)
        UsuarioaltaLabel.Name = "UsuarioaltaLabel"
        UsuarioaltaLabel.Size = New System.Drawing.Size(82, 17)
        UsuarioaltaLabel.TabIndex = 14
        UsuarioaltaLabel.Text = "usuarioalta:"
        UsuarioaltaLabel.Visible = False
        '
        'UsuariobajaLabel
        '
        UsuariobajaLabel.AutoSize = True
        UsuariobajaLabel.Location = New System.Drawing.Point(650, 144)
        UsuariobajaLabel.Name = "UsuariobajaLabel"
        UsuariobajaLabel.Size = New System.Drawing.Size(86, 17)
        UsuariobajaLabel.TabIndex = 16
        UsuariobajaLabel.Text = "usuariobaja:"
        UsuariobajaLabel.Visible = False
        '
        'UsuariomodificacionLabel
        '
        UsuariomodificacionLabel.AutoSize = True
        UsuariomodificacionLabel.Location = New System.Drawing.Point(599, 172)
        UsuariomodificacionLabel.Name = "UsuariomodificacionLabel"
        UsuariomodificacionLabel.Size = New System.Drawing.Size(137, 17)
        UsuariomodificacionLabel.TabIndex = 18
        UsuariomodificacionLabel.Text = "usuariomodificacion:"
        UsuariomodificacionLabel.Visible = False
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(248, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(61, 17)
        UsernameLabel.TabIndex = 23
        UsernameLabel.Text = "Usuario:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(248, 52)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(47, 17)
        PasswordLabel.TabIndex = 25
        PasswordLabel.Text = "Clave:"
        '
        'IdperfilLabel
        '
        IdperfilLabel.AutoSize = True
        IdperfilLabel.Location = New System.Drawing.Point(248, 83)
        IdperfilLabel.Name = "IdperfilLabel"
        IdperfilLabel.Size = New System.Drawing.Size(44, 17)
        IdperfilLabel.TabIndex = 27
        IdperfilLabel.Text = "Perfil:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ComercialDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.perfilesTableAdapter = Me.PerfilesTableAdapter
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
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'PerfilesTableAdapter
        '
        Me.PerfilesTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Nothing
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorAddNewItem, Me.UsuariosBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuariosBindingNavigator.MoveFirstItem = Nothing
        Me.UsuariosBindingNavigator.MoveLastItem = Nothing
        Me.UsuariosBindingNavigator.MoveNextItem = Nothing
        Me.UsuariosBindingNavigator.MovePreviousItem = Nothing
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Nothing
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(833, 27)
        Me.UsuariosBindingNavigator.TabIndex = 0
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdusuarioTextBox
        '
        Me.IdusuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "idusuario", True))
        Me.IdusuarioTextBox.Location = New System.Drawing.Point(742, 27)
        Me.IdusuarioTextBox.Name = "IdusuarioTextBox"
        Me.IdusuarioTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdusuarioTextBox.TabIndex = 3
        Me.IdusuarioTextBox.Visible = False
        '
        'FechaaltaDateTimePicker
        '
        Me.FechaaltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "fechaalta", True))
        Me.FechaaltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaaltaDateTimePicker.Location = New System.Drawing.Point(742, 55)
        Me.FechaaltaDateTimePicker.Name = "FechaaltaDateTimePicker"
        Me.FechaaltaDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.FechaaltaDateTimePicker.TabIndex = 9
        Me.FechaaltaDateTimePicker.Visible = False
        '
        'FechabajaDateTimePicker
        '
        Me.FechabajaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "fechabaja", True))
        Me.FechabajaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechabajaDateTimePicker.Location = New System.Drawing.Point(742, 200)
        Me.FechabajaDateTimePicker.Name = "FechabajaDateTimePicker"
        Me.FechabajaDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.FechabajaDateTimePicker.TabIndex = 11
        Me.FechabajaDateTimePicker.Visible = False
        '
        'FechamodificacionDateTimePicker
        '
        Me.FechamodificacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsuariosBindingSource, "fechamodificacion", True))
        Me.FechamodificacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechamodificacionDateTimePicker.Location = New System.Drawing.Point(742, 88)
        Me.FechamodificacionDateTimePicker.Name = "FechamodificacionDateTimePicker"
        Me.FechamodificacionDateTimePicker.Size = New System.Drawing.Size(113, 22)
        Me.FechamodificacionDateTimePicker.TabIndex = 13
        Me.FechamodificacionDateTimePicker.Visible = False
        '
        'UsuarioaltaTextBox
        '
        Me.UsuarioaltaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuarioalta", True))
        Me.UsuarioaltaTextBox.Location = New System.Drawing.Point(742, 116)
        Me.UsuarioaltaTextBox.Name = "UsuarioaltaTextBox"
        Me.UsuarioaltaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.UsuarioaltaTextBox.TabIndex = 15
        Me.UsuarioaltaTextBox.Visible = False
        '
        'UsuariobajaTextBox
        '
        Me.UsuariobajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuariobaja", True))
        Me.UsuariobajaTextBox.Location = New System.Drawing.Point(742, 144)
        Me.UsuariobajaTextBox.Name = "UsuariobajaTextBox"
        Me.UsuariobajaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.UsuariobajaTextBox.TabIndex = 17
        Me.UsuariobajaTextBox.Visible = False
        '
        'UsuariomodificacionTextBox
        '
        Me.UsuariomodificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuariomodificacion", True))
        Me.UsuariomodificacionTextBox.Location = New System.Drawing.Point(742, 172)
        Me.UsuariomodificacionTextBox.Name = "UsuariomodificacionTextBox"
        Me.UsuariomodificacionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.UsuariomodificacionTextBox.TabIndex = 19
        Me.UsuariomodificacionTextBox.Visible = False
        '
        'PerfilesBindingSource
        '
        Me.PerfilesBindingSource.DataMember = "perfiles"
        Me.PerfilesBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.IdperfilComboBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(IdperfilLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'IdperfilComboBox
        '
        Me.IdperfilComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "idperfil", True))
        Me.IdperfilComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuariosBindingSource, "idperfil", True))
        Me.IdperfilComboBox.DataSource = Me.PerfilesBindingSource
        Me.IdperfilComboBox.DisplayMember = "idperfil"
        Me.IdperfilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdperfilComboBox.FormattingEnabled = True
        Me.IdperfilComboBox.Location = New System.Drawing.Point(329, 80)
        Me.IdperfilComboBox.Name = "IdperfilComboBox"
        Me.IdperfilComboBox.Size = New System.Drawing.Size(227, 24)
        Me.IdperfilComboBox.TabIndex = 2
        Me.IdperfilComboBox.ValueMember = "idperfil"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(329, 24)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(227, 22)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(329, 52)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(227, 22)
        Me.PasswordTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.UsuariosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 265)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Eliminar, Me.Reactivar, Me.usuarioalta, Me.editar})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(12, 26)
        Me.UsuariosDataGridView.MultiSelect = False
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.RowTemplate.Height = 24
        Me.UsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(786, 222)
        Me.UsuariosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idusuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idusuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 86
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 72
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha alta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 103
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha baja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 107
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechamodificacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechamodificacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "usuariomodificacion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "usuariomodificacion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idperfil"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Perfil"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 69
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 64
        '
        'Reactivar
        '
        Me.Reactivar.HeaderText = "Reactivar"
        Me.Reactivar.Name = "Reactivar"
        Me.Reactivar.ReadOnly = True
        Me.Reactivar.Text = "Reactivar"
        Me.Reactivar.ToolTipText = "Reactivar"
        Me.Reactivar.UseColumnTextForButtonValue = True
        Me.Reactivar.Width = 74
        '
        'usuarioalta
        '
        Me.usuarioalta.DataPropertyName = "usuarioalta"
        Me.usuarioalta.HeaderText = "usuarioalta"
        Me.usuarioalta.Name = "usuarioalta"
        Me.usuarioalta.ReadOnly = True
        Me.usuarioalta.Visible = False
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Name = "editar"
        Me.editar.ReadOnly = True
        Me.editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.editar.Text = "Editar"
        Me.editar.ToolTipText = "Editar"
        Me.editar.UseColumnTextForButtonValue = True
        Me.editar.Width = 74
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IdusuarioLabel)
        Me.Controls.Add(Me.IdusuarioTextBox)
        Me.Controls.Add(FechaaltaLabel)
        Me.Controls.Add(Me.FechaaltaDateTimePicker)
        Me.Controls.Add(FechabajaLabel)
        Me.Controls.Add(Me.FechabajaDateTimePicker)
        Me.Controls.Add(FechamodificacionLabel)
        Me.Controls.Add(Me.FechamodificacionDateTimePicker)
        Me.Controls.Add(UsuarioaltaLabel)
        Me.Controls.Add(Me.UsuarioaltaTextBox)
        Me.Controls.Add(UsuariobajaLabel)
        Me.Controls.Add(Me.UsuariobajaTextBox)
        Me.Controls.Add(UsuariomodificacionLabel)
        Me.Controls.Add(Me.UsuariomodificacionTextBox)
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMUsuarios"
        Me.Text = "ABM Usuarios"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As comercialDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdusuarioTextBox As TextBox
    Friend WithEvents FechaaltaDateTimePicker As DateTimePicker
    Friend WithEvents FechabajaDateTimePicker As DateTimePicker
    Friend WithEvents FechamodificacionDateTimePicker As DateTimePicker
    Friend WithEvents UsuarioaltaTextBox As TextBox
    Friend WithEvents UsuariobajaTextBox As TextBox
    Friend WithEvents UsuariomodificacionTextBox As TextBox
    Friend WithEvents PerfilesTableAdapter As comercialDataSetTableAdapters.perfilesTableAdapter
    Friend WithEvents PerfilesBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdperfilComboBox As ComboBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Reactivar As DataGridViewButtonColumn
    Friend WithEvents usuarioalta As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewButtonColumn
End Class

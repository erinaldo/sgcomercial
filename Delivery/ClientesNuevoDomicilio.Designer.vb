<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesNuevoDomicilio
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
        Dim IddomicilioLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ReferenciasLabel As System.Windows.Forms.Label
        Dim IdprovinciaLabel As System.Windows.Forms.Label
        Dim IdlocalidadLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesNuevoDomicilio))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ClientesdomiciliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesdomiciliosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.localidadesTableAdapter()
        Me.ProvinciasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.provinciasTableAdapter()
        Me.ClientesdomiciliosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesdomiciliosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IddomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciasTextBox = New System.Windows.Forms.TextBox()
        Me.CpTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        IddomicilioLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ReferenciasLabel = New System.Windows.Forms.Label()
        IdprovinciaLabel = New System.Windows.Forms.Label()
        IdlocalidadLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesdomiciliosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesdomiciliosBindingNavigator.SuspendLayout()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IddomicilioLabel
        '
        IddomicilioLabel.AutoSize = True
        IddomicilioLabel.Location = New System.Drawing.Point(393, 30)
        IddomicilioLabel.Name = "IddomicilioLabel"
        IddomicilioLabel.Size = New System.Drawing.Size(77, 17)
        IddomicilioLabel.TabIndex = 1
        IddomicilioLabel.Text = "iddomicilio:"
        IddomicilioLabel.Visible = False
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(95, 50)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 3
        IdclienteLabel.Text = "Cliente N°:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(88, 78)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Dirección:"
        '
        'ReferenciasLabel
        '
        ReferenciasLabel.AutoSize = True
        ReferenciasLabel.Location = New System.Drawing.Point(71, 106)
        ReferenciasLabel.Name = "ReferenciasLabel"
        ReferenciasLabel.Size = New System.Drawing.Size(88, 17)
        ReferenciasLabel.TabIndex = 7
        ReferenciasLabel.Text = "Referencias:"
        '
        'IdprovinciaLabel
        '
        IdprovinciaLabel.AutoSize = True
        IdprovinciaLabel.Location = New System.Drawing.Point(89, 134)
        IdprovinciaLabel.Name = "IdprovinciaLabel"
        IdprovinciaLabel.Size = New System.Drawing.Size(70, 17)
        IdprovinciaLabel.TabIndex = 9
        IdprovinciaLabel.Text = "Provincia:"
        '
        'IdlocalidadLabel
        '
        IdlocalidadLabel.AutoSize = True
        IdlocalidadLabel.Location = New System.Drawing.Point(86, 165)
        IdlocalidadLabel.Name = "IdlocalidadLabel"
        IdlocalidadLabel.Size = New System.Drawing.Size(73, 17)
        IdlocalidadLabel.TabIndex = 11
        IdlocalidadLabel.Text = "Localidad:"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(60, 196)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(99, 17)
        CpLabel.TabIndex = 13
        CpLabel.Text = "Código Postal:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesdomiciliosBindingSource
        '
        Me.ClientesdomiciliosBindingSource.DataMember = "clientesdomicilios"
        Me.ClientesdomiciliosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ClientesdomiciliosTableAdapter
        '
        Me.ClientesdomiciliosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.clientesTableAdapter = Nothing
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
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'ClientesdomiciliosBindingNavigator
        '
        Me.ClientesdomiciliosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesdomiciliosBindingNavigator.BindingSource = Me.ClientesdomiciliosBindingSource
        Me.ClientesdomiciliosBindingNavigator.CountItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesdomiciliosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClientesdomiciliosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesdomiciliosBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.ClientesdomiciliosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesdomiciliosBindingNavigator.MoveFirstItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.MoveLastItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.MoveNextItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.MovePreviousItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.Name = "ClientesdomiciliosBindingNavigator"
        Me.ClientesdomiciliosBindingNavigator.PositionItem = Nothing
        Me.ClientesdomiciliosBindingNavigator.Size = New System.Drawing.Size(470, 27)
        Me.ClientesdomiciliosBindingNavigator.TabIndex = 0
        Me.ClientesdomiciliosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(131, 24)
        Me.BindingNavigatorAddNewItem.Tag = "Agregar nuevo"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ClientesdomiciliosBindingNavigatorSaveItem
        '
        Me.ClientesdomiciliosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesdomiciliosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesdomiciliosBindingNavigatorSaveItem.Name = "ClientesdomiciliosBindingNavigatorSaveItem"
        Me.ClientesdomiciliosBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.ClientesdomiciliosBindingNavigatorSaveItem.Tag = "Guardar datos"
        Me.ClientesdomiciliosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(109, 24)
        Me.ToolStripButton1.Tag = "Seleccionar"
        Me.ToolStripButton1.Text = "Seleccionar"
        '
        'IddomicilioTextBox
        '
        Me.IddomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "iddomicilio", True))
        Me.IddomicilioTextBox.Location = New System.Drawing.Point(433, 5)
        Me.IddomicilioTextBox.Name = "IddomicilioTextBox"
        Me.IddomicilioTextBox.Size = New System.Drawing.Size(25, 22)
        Me.IddomicilioTextBox.TabIndex = 6
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(171, 47)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(56, 22)
        Me.IdclienteTextBox.TabIndex = 0
        Me.IdclienteTextBox.TabStop = False
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(171, 75)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(240, 22)
        Me.DireccionTextBox.TabIndex = 1
        '
        'ReferenciasTextBox
        '
        Me.ReferenciasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "referencias", True))
        Me.ReferenciasTextBox.Location = New System.Drawing.Point(171, 103)
        Me.ReferenciasTextBox.Name = "ReferenciasTextBox"
        Me.ReferenciasTextBox.Size = New System.Drawing.Size(240, 22)
        Me.ReferenciasTextBox.TabIndex = 2
        '
        'CpTextBox
        '
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "cp", True))
        Me.CpTextBox.Location = New System.Drawing.Point(171, 193)
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CpTextBox.TabIndex = 5
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "provincias"
        Me.ProvinciasBindingSource.DataSource = Me.ComercialDataSet
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesdomiciliosBindingSource, "idprovincia", True))
        Me.ComboBox1.DataSource = Me.ProvinciasBindingSource
        Me.ComboBox1.DisplayMember = "nombreprovincia"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 24)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "idprovincia"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesdomiciliosBindingSource, "idlocalidad", True))
        Me.ComboBox2.DataSource = Me.LocalidadesBindingSource
        Me.ComboBox2.DisplayMember = "nombrelocalidad"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(171, 162)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(222, 24)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.ValueMember = "idlocalidad"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.ClientesdomiciliosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator3, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator4})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 235)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(470, 27)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ClientesNuevoDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 262)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IddomicilioLabel)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ReferenciasLabel)
        Me.Controls.Add(Me.ReferenciasTextBox)
        Me.Controls.Add(IdprovinciaLabel)
        Me.Controls.Add(IdlocalidadLabel)
        Me.Controls.Add(CpLabel)
        Me.Controls.Add(Me.CpTextBox)
        Me.Controls.Add(Me.ClientesdomiciliosBindingNavigator)
        Me.Controls.Add(Me.IddomicilioTextBox)
        Me.Name = "ClientesNuevoDomicilio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesNuevoDomicilio"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesdomiciliosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesdomiciliosBindingNavigator.ResumeLayout(False)
        Me.ClientesdomiciliosBindingNavigator.PerformLayout()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ClientesdomiciliosBindingSource As BindingSource
    Friend WithEvents ClientesdomiciliosTableAdapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesdomiciliosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents ClientesdomiciliosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IddomicilioTextBox As TextBox
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ReferenciasTextBox As TextBox
    Friend WithEvents CpTextBox As TextBox
    Friend WithEvents ProvinciasTableAdapter As comercialDataSetTableAdapters.provinciasTableAdapter
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents LocalidadesTableAdapter As comercialDataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

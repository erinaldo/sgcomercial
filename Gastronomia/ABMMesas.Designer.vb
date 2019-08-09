<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMMesas
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
        Dim IdmesaLabel As System.Windows.Forms.Label
        Dim IdsalonLabel As System.Windows.Forms.Label
        Dim CapacidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMMesas))
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.MesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MesasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mesasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.SalonesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.salonesTableAdapter()
        Me.MesasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MesasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCancelar = New System.Windows.Forms.ToolStripButton()
        Me.IdmesaTextBox = New System.Windows.Forms.TextBox()
        Me.IdsalonComboBox = New System.Windows.Forms.ComboBox()
        Me.SalonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CapacidadComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.ComercialDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosaiTableAdapter = New sgcomercial.comercialDataSetTableAdapters.estadosaiTableAdapter()
        IdmesaLabel = New System.Windows.Forms.Label()
        IdsalonLabel = New System.Windows.Forms.Label()
        CapacidadLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MesasBindingNavigator.SuspendLayout()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdmesaLabel
        '
        IdmesaLabel.AutoSize = True
        IdmesaLabel.Location = New System.Drawing.Point(183, 57)
        IdmesaLabel.Name = "IdmesaLabel"
        IdmesaLabel.Size = New System.Drawing.Size(62, 17)
        IdmesaLabel.TabIndex = 1
        IdmesaLabel.Text = "Mesa N°"
        '
        'IdsalonLabel
        '
        IdsalonLabel.AutoSize = True
        IdsalonLabel.Location = New System.Drawing.Point(183, 87)
        IdsalonLabel.Name = "IdsalonLabel"
        IdsalonLabel.Size = New System.Drawing.Size(64, 17)
        IdsalonLabel.TabIndex = 3
        IdsalonLabel.Text = "Salón N°"
        '
        'CapacidadLabel
        '
        CapacidadLabel.AutoSize = True
        CapacidadLabel.Location = New System.Drawing.Point(84, 118)
        CapacidadLabel.Name = "CapacidadLabel"
        CapacidadLabel.Size = New System.Drawing.Size(163, 17)
        CapacidadLabel.TabIndex = 5
        CapacidadLabel.Text = "Capacidad de Personas:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MesasBindingSource
        '
        Me.MesasBindingSource.DataMember = "mesas"
        Me.MesasBindingSource.DataSource = Me.ComercialDataSet
        '
        'MesasTableAdapter
        '
        Me.MesasTableAdapter.ClearBeforeFill = True
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
        'SalonesTableAdapter
        '
        Me.SalonesTableAdapter.ClearBeforeFill = True
        '
        'MesasBindingNavigator
        '
        Me.MesasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MesasBindingNavigator.BindingSource = Me.MesasBindingSource
        Me.MesasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MesasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MesasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MesasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.MesasBindingNavigatorSaveItem, Me.ToolStripEditar, Me.ToolStripCancelar, Me.BindingNavigatorDeleteItem})
        Me.MesasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MesasBindingNavigator.MoveFirstItem = Nothing
        Me.MesasBindingNavigator.MoveLastItem = Nothing
        Me.MesasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MesasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MesasBindingNavigator.Name = "MesasBindingNavigator"
        Me.MesasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MesasBindingNavigator.Size = New System.Drawing.Size(651, 47)
        Me.MesasBindingNavigator.TabIndex = 0
        Me.MesasBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(67, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Anterior"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(75, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Siguiente"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'MesasBindingNavigatorSaveItem
        '
        Me.MesasBindingNavigatorSaveItem.Image = CType(resources.GetObject("MesasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MesasBindingNavigatorSaveItem.Name = "MesasBindingNavigatorSaveItem"
        Me.MesasBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.MesasBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.MesasBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripEditar
        '
        Me.ToolStripEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.ToolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditar.Name = "ToolStripEditar"
        Me.ToolStripEditar.Size = New System.Drawing.Size(52, 44)
        Me.ToolStripEditar.Text = "Editar"
        Me.ToolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripCancelar
        '
        Me.ToolStripCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.ToolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCancelar.Name = "ToolStripCancelar"
        Me.ToolStripCancelar.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripCancelar.Text = "Cancelar"
        Me.ToolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdmesaTextBox
        '
        Me.IdmesaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesasBindingSource, "idmesa", True))
        Me.IdmesaTextBox.Enabled = False
        Me.IdmesaTextBox.Location = New System.Drawing.Point(266, 54)
        Me.IdmesaTextBox.Name = "IdmesaTextBox"
        Me.IdmesaTextBox.Size = New System.Drawing.Size(70, 22)
        Me.IdmesaTextBox.TabIndex = 2
        Me.IdmesaTextBox.TabStop = False
        '
        'IdsalonComboBox
        '
        Me.IdsalonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MesasBindingSource, "idsalon", True))
        Me.IdsalonComboBox.DataSource = Me.SalonesBindingSource
        Me.IdsalonComboBox.DisplayMember = "descripcion"
        Me.IdsalonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdsalonComboBox.FormattingEnabled = True
        Me.IdsalonComboBox.Location = New System.Drawing.Point(266, 84)
        Me.IdsalonComboBox.Name = "IdsalonComboBox"
        Me.IdsalonComboBox.Size = New System.Drawing.Size(145, 24)
        Me.IdsalonComboBox.TabIndex = 4
        Me.IdsalonComboBox.ValueMember = "idsalon"
        '
        'SalonesBindingSource
        '
        Me.SalonesBindingSource.DataMember = "salones"
        Me.SalonesBindingSource.DataSource = Me.ComercialDataSet
        '
        'CapacidadComboBox
        '
        Me.CapacidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MesasBindingSource, "capacidad", True))
        Me.CapacidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CapacidadComboBox.FormattingEnabled = True
        Me.CapacidadComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CapacidadComboBox.Location = New System.Drawing.Point(266, 118)
        Me.CapacidadComboBox.Name = "CapacidadComboBox"
        Me.CapacidadComboBox.Size = New System.Drawing.Size(87, 24)
        Me.CapacidadComboBox.TabIndex = 6
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(192, 154)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(56, 17)
        EstadoLabel.TabIndex = 7
        EstadoLabel.Text = "Estado:"
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MesasBindingSource, "estado", True))
        Me.EstadoComboBox.DataSource = Me.EstadosaiBindingSource
        Me.EstadoComboBox.DisplayMember = "descripcion"
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Location = New System.Drawing.Point(266, 151)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(145, 24)
        Me.EstadoComboBox.TabIndex = 8
        Me.EstadoComboBox.ValueMember = "idestadoai"
        '
        'ComercialDataSetBindingSource
        '
        Me.ComercialDataSetBindingSource.DataSource = Me.ComercialDataSet
        Me.ComercialDataSetBindingSource.Position = 0
        '
        'EstadosaiBindingSource
        '
        Me.EstadosaiBindingSource.DataMember = "estadosai"
        Me.EstadosaiBindingSource.DataSource = Me.ComercialDataSetBindingSource
        '
        'EstadosaiTableAdapter
        '
        Me.EstadosaiTableAdapter.ClearBeforeFill = True
        '
        'ABMMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 190)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(IdmesaLabel)
        Me.Controls.Add(Me.IdmesaTextBox)
        Me.Controls.Add(IdsalonLabel)
        Me.Controls.Add(Me.IdsalonComboBox)
        Me.Controls.Add(CapacidadLabel)
        Me.Controls.Add(Me.CapacidadComboBox)
        Me.Controls.Add(Me.MesasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ABMMesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMMesas"
        Me.Text = "Altas, Bajas y Modificación de Mesas"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MesasBindingNavigator.ResumeLayout(False)
        Me.MesasBindingNavigator.PerformLayout()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents MesasBindingSource As BindingSource
    Friend WithEvents MesasTableAdapter As comercialDataSetTableAdapters.mesasTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MesasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MesasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdmesaTextBox As TextBox
    Friend WithEvents IdsalonComboBox As ComboBox
    Friend WithEvents CapacidadComboBox As ComboBox
    Friend WithEvents SalonesTableAdapter As comercialDataSetTableAdapters.salonesTableAdapter
    Friend WithEvents SalonesBindingSource As BindingSource
    Friend WithEvents ToolStripEditar As ToolStripButton
    Friend WithEvents ToolStripCancelar As ToolStripButton
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents ComercialDataSetBindingSource As BindingSource
    Friend WithEvents EstadosaiBindingSource As BindingSource
    Friend WithEvents EstadosaiTableAdapter As comercialDataSetTableAdapters.estadosaiTableAdapter
End Class

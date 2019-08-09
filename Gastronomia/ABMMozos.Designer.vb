<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMMozos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMMozos))
        Dim IdmozoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.MozosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MozosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mozosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.MozosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MozosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdmozoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadosaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosaiTableAdapter = New sgcomercial.comercialDataSetTableAdapters.estadosaiTableAdapter()
        Me.ToolStripEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        IdmozoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MozosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MozosBindingNavigator.SuspendLayout()
        CType(Me.EstadosaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MozosBindingSource
        '
        Me.MozosBindingSource.DataMember = "mozos"
        Me.MozosBindingSource.DataSource = Me.ComercialDataSet
        '
        'MozosTableAdapter
        '
        Me.MozosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.estadosaiTableAdapter = Me.EstadosaiTableAdapter
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
        'MozosBindingNavigator
        '
        Me.MozosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MozosBindingNavigator.BindingSource = Me.MozosBindingSource
        Me.MozosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MozosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MozosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MozosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.MozosBindingNavigatorSaveItem, Me.ToolStripEditar, Me.ToolStripButton1, Me.BindingNavigatorDeleteItem})
        Me.MozosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MozosBindingNavigator.MoveFirstItem = Nothing
        Me.MozosBindingNavigator.MoveLastItem = Nothing
        Me.MozosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MozosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MozosBindingNavigator.Name = "MozosBindingNavigator"
        Me.MozosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MozosBindingNavigator.Size = New System.Drawing.Size(679, 47)
        Me.MozosBindingNavigator.TabIndex = 0
        Me.MozosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 44)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(95, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Siguiente"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 47)
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
        'MozosBindingNavigatorSaveItem
        '
        Me.MozosBindingNavigatorSaveItem.Image = CType(resources.GetObject("MozosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MozosBindingNavigatorSaveItem.Name = "MozosBindingNavigatorSaveItem"
        Me.MozosBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.MozosBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.MozosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdmozoLabel
        '
        IdmozoLabel.AutoSize = True
        IdmozoLabel.Location = New System.Drawing.Point(246, 57)
        IdmozoLabel.Name = "IdmozoLabel"
        IdmozoLabel.Size = New System.Drawing.Size(45, 17)
        IdmozoLabel.TabIndex = 1
        IdmozoLabel.Text = "ID N°:"
        '
        'IdmozoTextBox
        '
        Me.IdmozoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MozosBindingSource, "idmozo", True))
        Me.IdmozoTextBox.Enabled = False
        Me.IdmozoTextBox.Location = New System.Drawing.Point(312, 54)
        Me.IdmozoTextBox.Name = "IdmozoTextBox"
        Me.IdmozoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdmozoTextBox.TabIndex = 2
        Me.IdmozoTextBox.TabStop = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(172, 85)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MozosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(238, 82)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(268, 22)
        Me.NombreTextBox.TabIndex = 4
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(246, 113)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(56, 17)
        EstadoLabel.TabIndex = 5
        EstadoLabel.Text = "Estado:"
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MozosBindingSource, "estado", True))
        Me.EstadoComboBox.DataSource = Me.EstadosaiBindingSource
        Me.EstadoComboBox.DisplayMember = "descripcion"
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Location = New System.Drawing.Point(312, 110)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(121, 24)
        Me.EstadoComboBox.TabIndex = 6
        Me.EstadoComboBox.ValueMember = "idestadoai"
        '
        'EstadosaiBindingSource
        '
        Me.EstadosaiBindingSource.DataMember = "estadosai"
        Me.EstadosaiBindingSource.DataSource = Me.ComercialDataSet
        '
        'EstadosaiTableAdapter
        '
        Me.EstadosaiTableAdapter.ClearBeforeFill = True
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton1.Text = "Cancelar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ABMMozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 151)
        Me.Controls.Add(IdmozoLabel)
        Me.Controls.Add(Me.IdmozoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(Me.MozosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ABMMozos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta, Baja y Modificación de Mozos"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MozosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MozosBindingNavigator.ResumeLayout(False)
        Me.MozosBindingNavigator.PerformLayout()
        CType(Me.EstadosaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents MozosBindingSource As BindingSource
    Friend WithEvents MozosTableAdapter As comercialDataSetTableAdapters.mozosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MozosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MozosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstadosaiTableAdapter As comercialDataSetTableAdapters.estadosaiTableAdapter
    Friend WithEvents IdmozoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents EstadosaiBindingSource As BindingSource
    Friend WithEvents ToolStripEditar As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

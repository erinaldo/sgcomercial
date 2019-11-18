<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMGrados
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
        Dim IdgradoLabel As System.Windows.Forms.Label
        Dim GradoLabel As System.Windows.Forms.Label
        Dim DivisionLabel As System.Windows.Forms.Label
        Dim TurnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMGrados))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gradosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GradosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GradosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdgradoTextBox = New System.Windows.Forms.TextBox()
        Me.GradoTextBox = New System.Windows.Forms.TextBox()
        Me.DivisionTextBox = New System.Windows.Forms.TextBox()
        Me.TurnoComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        IdgradoLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        DivisionLabel = New System.Windows.Forms.Label()
        TurnoLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdgradoLabel
        '
        IdgradoLabel.AutoSize = True
        IdgradoLabel.Location = New System.Drawing.Point(170, 94)
        IdgradoLabel.Name = "IdgradoLabel"
        IdgradoLabel.Size = New System.Drawing.Size(25, 17)
        IdgradoLabel.TabIndex = 1
        IdgradoLabel.Text = "ID:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Location = New System.Drawing.Point(143, 122)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(52, 17)
        GradoLabel.TabIndex = 3
        GradoLabel.Text = "Grado:"
        '
        'DivisionLabel
        '
        DivisionLabel.AutoSize = True
        DivisionLabel.Location = New System.Drawing.Point(134, 150)
        DivisionLabel.Name = "DivisionLabel"
        DivisionLabel.Size = New System.Drawing.Size(61, 17)
        DivisionLabel.TabIndex = 5
        DivisionLabel.Text = "División:"
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Location = New System.Drawing.Point(150, 178)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(50, 17)
        TurnoLabel.TabIndex = 7
        TurnoLabel.Text = "Turno:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradosBindingSource
        '
        Me.GradosBindingSource.DataMember = "grados"
        Me.GradosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GradosTableAdapter
        '
        Me.GradosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
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
        Me.TableAdapterManager.gradosTableAdapter = Me.GradosTableAdapter
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
        'GradosBindingNavigator
        '
        Me.GradosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GradosBindingNavigator.BindingSource = Me.GradosBindingSource
        Me.GradosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GradosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GradosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GradosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GradosBindingNavigatorSaveItem, Me.ToolStripButtonEditar, Me.ToolStripButtonCancelar})
        Me.GradosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GradosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GradosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GradosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GradosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GradosBindingNavigator.Name = "GradosBindingNavigator"
        Me.GradosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GradosBindingNavigator.Size = New System.Drawing.Size(643, 47)
        Me.GradosBindingNavigator.TabIndex = 0
        Me.GradosBindingNavigator.Text = "BindingNavigator1"
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
        'GradosBindingNavigatorSaveItem
        '
        Me.GradosBindingNavigatorSaveItem.Image = CType(resources.GetObject("GradosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GradosBindingNavigatorSaveItem.Name = "GradosBindingNavigatorSaveItem"
        Me.GradosBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.GradosBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.GradosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdgradoTextBox
        '
        Me.IdgradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradosBindingSource, "idgrado", True))
        Me.IdgradoTextBox.Enabled = False
        Me.IdgradoTextBox.Location = New System.Drawing.Point(201, 91)
        Me.IdgradoTextBox.Name = "IdgradoTextBox"
        Me.IdgradoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdgradoTextBox.TabIndex = 2
        '
        'GradoTextBox
        '
        Me.GradoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradosBindingSource, "grado", True))
        Me.GradoTextBox.Location = New System.Drawing.Point(201, 119)
        Me.GradoTextBox.Name = "GradoTextBox"
        Me.GradoTextBox.Size = New System.Drawing.Size(307, 22)
        Me.GradoTextBox.TabIndex = 4
        '
        'DivisionTextBox
        '
        Me.DivisionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DivisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradosBindingSource, "division", True))
        Me.DivisionTextBox.Location = New System.Drawing.Point(201, 147)
        Me.DivisionTextBox.Name = "DivisionTextBox"
        Me.DivisionTextBox.Size = New System.Drawing.Size(121, 22)
        Me.DivisionTextBox.TabIndex = 6
        '
        'TurnoComboBox
        '
        Me.TurnoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradosBindingSource, "turno", True))
        Me.TurnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TurnoComboBox.FormattingEnabled = True
        Me.TurnoComboBox.Items.AddRange(New Object() {"M", "T"})
        Me.TurnoComboBox.Location = New System.Drawing.Point(201, 175)
        Me.TurnoComboBox.Name = "TurnoComboBox"
        Me.TurnoComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TurnoComboBox.TabIndex = 8
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
        'ToolStripButtonCancelar
        '
        Me.ToolStripButtonCancelar.Image = Global.sgcomercial.My.Resources.Resources.reload_512
        Me.ToolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCancelar.Name = "ToolStripButtonCancelar"
        Me.ToolStripButtonCancelar.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButtonCancelar.Text = "Cancelar"
        Me.ToolStripButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ABMGrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 291)
        Me.Controls.Add(IdgradoLabel)
        Me.Controls.Add(Me.IdgradoTextBox)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(Me.GradoTextBox)
        Me.Controls.Add(DivisionLabel)
        Me.Controls.Add(Me.DivisionTextBox)
        Me.Controls.Add(TurnoLabel)
        Me.Controls.Add(Me.TurnoComboBox)
        Me.Controls.Add(Me.GradosBindingNavigator)
        Me.Name = "ABMGrados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ConfiguracionGrados"
        Me.Text = "Configuración de Grados"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradosBindingNavigator.ResumeLayout(False)
        Me.GradosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents GradosBindingSource As BindingSource
    Friend WithEvents GradosTableAdapter As comercialDataSetTableAdapters.gradosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GradosBindingNavigator As BindingNavigator
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
    Friend WithEvents GradosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdgradoTextBox As TextBox
    Friend WithEvents GradoTextBox As TextBox
    Friend WithEvents DivisionTextBox As TextBox
    Friend WithEvents TurnoComboBox As ComboBox
    Friend WithEvents ToolStripButtonEditar As ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCajas
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
        Dim IdcajaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCajas))
        Me.CajasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioaccesoDataSet = New sgcomercial.comercialDataSet()
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
        Me.CajasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdcajaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CajasestadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdcajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CajasestadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasestadosTableAdapter()
        IdcajaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.CajasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CajasBindingNavigator.SuspendLayout()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioaccesoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasestadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdcajaLabel
        '
        IdcajaLabel.AutoSize = True
        IdcajaLabel.Location = New System.Drawing.Point(249, 70)
        IdcajaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdcajaLabel.Name = "IdcajaLabel"
        IdcajaLabel.Size = New System.Drawing.Size(27, 17)
        IdcajaLabel.TabIndex = 1
        IdcajaLabel.Text = "Nº:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(195, 102)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(82, 17)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(225, 134)
        EstadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(52, 17)
        EstadoLabel.TabIndex = 5
        EstadoLabel.Text = "Estado"
        '
        'CajasBindingNavigator
        '
        Me.CajasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CajasBindingNavigator.BindingSource = Me.CajasBindingSource
        Me.CajasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CajasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CajasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CajasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CajasBindingNavigatorSaveItem})
        Me.CajasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CajasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CajasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CajasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CajasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CajasBindingNavigator.Name = "CajasBindingNavigator"
        Me.CajasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CajasBindingNavigator.Size = New System.Drawing.Size(636, 47)
        Me.CajasBindingNavigator.TabIndex = 0
        Me.CajasBindingNavigator.Text = "BindingNavigator1"
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
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.BioaccesoDataSet
        '
        'BioaccesoDataSet
        '
        Me.BioaccesoDataSet.DataSetName = "bioaccesoDataSet"
        Me.BioaccesoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        'CajasBindingNavigatorSaveItem
        '
        Me.CajasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CajasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CajasBindingNavigatorSaveItem.Name = "CajasBindingNavigatorSaveItem"
        Me.CajasBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.CajasBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.CajasBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdcajaTextBox
        '
        Me.IdcajaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "idcaja", True))
        Me.IdcajaTextBox.Location = New System.Drawing.Point(280, 66)
        Me.IdcajaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdcajaTextBox.Name = "IdcajaTextBox"
        Me.IdcajaTextBox.ReadOnly = True
        Me.IdcajaTextBox.Size = New System.Drawing.Size(160, 22)
        Me.IdcajaTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajasBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(280, 98)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(160, 22)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CajasBindingSource, "estado", True))
        Me.EstadoComboBox.DataSource = Me.CajasestadosBindingSource
        Me.EstadoComboBox.DisplayMember = "descripcion"
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Location = New System.Drawing.Point(280, 130)
        Me.EstadoComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(160, 24)
        Me.EstadoComboBox.TabIndex = 6
        Me.EstadoComboBox.ValueMember = "descripcion"
        '
        'CajasestadosBindingSource
        '
        Me.CajasestadosBindingSource.DataMember = "cajasestados"
        Me.CajasestadosBindingSource.DataSource = Me.BioaccesoDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcajaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CajasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 186)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(508, 185)
        Me.DataGridView1.TabIndex = 7
        '
        'IdcajaDataGridViewTextBoxColumn
        '
        Me.IdcajaDataGridViewTextBoxColumn.DataPropertyName = "idcaja"
        Me.IdcajaDataGridViewTextBoxColumn.HeaderText = "Nº"
        Me.IdcajaDataGridViewTextBoxColumn.Name = "IdcajaDataGridViewTextBoxColumn"
        Me.IdcajaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Me.CajasTableAdapter
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'CajasestadosTableAdapter
        '
        Me.CajasestadosTableAdapter.ClearBeforeFill = True
        '
        'ABMCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 390)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IdcajaLabel)
        Me.Controls.Add(Me.IdcajaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(Me.CajasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMCajas"
        Me.Text = "ABM Cajas"
        CType(Me.CajasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CajasBindingNavigator.ResumeLayout(False)
        Me.CajasBindingNavigator.PerformLayout()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioaccesoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasestadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BioaccesoDataSet As comercialDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As comercialDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CajasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdcajaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdcajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasestadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasestadosTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasestadosTableAdapter
End Class

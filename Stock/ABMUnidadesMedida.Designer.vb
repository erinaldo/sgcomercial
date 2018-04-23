<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUnidadesMedida
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
        Dim IdunidadmedidaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMUnidadesMedida))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.UnidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.UnidadesmedidaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UnidadesmedidaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdunidadmedidaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesmedidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdunidadmedidaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnidadesmedidaBindingNavigator.SuspendLayout()
        CType(Me.UnidadesmedidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdunidadmedidaLabel
        '
        IdunidadmedidaLabel.AutoSize = True
        IdunidadmedidaLabel.Location = New System.Drawing.Point(79, 23)
        IdunidadmedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdunidadmedidaLabel.Name = "IdunidadmedidaLabel"
        IdunidadmedidaLabel.Size = New System.Drawing.Size(112, 17)
        IdunidadmedidaLabel.TabIndex = 1
        IdunidadmedidaLabel.Text = "idunidadmedida:"
        IdunidadmedidaLabel.Visible = False
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(96, 70)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnidadesmedidaBindingSource
        '
        Me.UnidadesmedidaBindingSource.DataMember = "unidadesmedida"
        Me.UnidadesmedidaBindingSource.DataSource = Me.ComercialDataSet
        '
        'UnidadesmedidaTableAdapter
        '
        Me.UnidadesmedidaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
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
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Me.UnidadesmedidaTableAdapter
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'UnidadesmedidaBindingNavigator
        '
        Me.UnidadesmedidaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UnidadesmedidaBindingNavigator.BindingSource = Me.UnidadesmedidaBindingSource
        Me.UnidadesmedidaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UnidadesmedidaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UnidadesmedidaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UnidadesmedidaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UnidadesmedidaBindingNavigatorSaveItem})
        Me.UnidadesmedidaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UnidadesmedidaBindingNavigator.MoveFirstItem = Nothing
        Me.UnidadesmedidaBindingNavigator.MoveLastItem = Nothing
        Me.UnidadesmedidaBindingNavigator.MoveNextItem = Nothing
        Me.UnidadesmedidaBindingNavigator.MovePreviousItem = Nothing
        Me.UnidadesmedidaBindingNavigator.Name = "UnidadesmedidaBindingNavigator"
        Me.UnidadesmedidaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UnidadesmedidaBindingNavigator.Size = New System.Drawing.Size(417, 47)
        Me.UnidadesmedidaBindingNavigator.TabIndex = 0
        Me.UnidadesmedidaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(55, 44)
        Me.BindingNavigatorAddNewItem.Text = "Nueva"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'UnidadesmedidaBindingNavigatorSaveItem
        '
        Me.UnidadesmedidaBindingNavigatorSaveItem.Image = CType(resources.GetObject("UnidadesmedidaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UnidadesmedidaBindingNavigatorSaveItem.Name = "UnidadesmedidaBindingNavigatorSaveItem"
        Me.UnidadesmedidaBindingNavigatorSaveItem.Size = New System.Drawing.Size(70, 44)
        Me.UnidadesmedidaBindingNavigatorSaveItem.Text = "Guardar "
        Me.UnidadesmedidaBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IdunidadmedidaTextBox
        '
        Me.IdunidadmedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesmedidaBindingSource, "idunidadmedida", True))
        Me.IdunidadmedidaTextBox.Location = New System.Drawing.Point(199, 20)
        Me.IdunidadmedidaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdunidadmedidaTextBox.Name = "IdunidadmedidaTextBox"
        Me.IdunidadmedidaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdunidadmedidaTextBox.TabIndex = 2
        Me.IdunidadmedidaTextBox.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesmedidaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(188, 66)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'UnidadesmedidaDataGridView
        '
        Me.UnidadesmedidaDataGridView.AllowUserToAddRows = False
        Me.UnidadesmedidaDataGridView.AllowUserToDeleteRows = False
        Me.UnidadesmedidaDataGridView.AllowUserToResizeRows = False
        Me.UnidadesmedidaDataGridView.AutoGenerateColumns = False
        Me.UnidadesmedidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnidadesmedidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.UnidadesmedidaDataGridView.DataSource = Me.UnidadesmedidaBindingSource
        Me.UnidadesmedidaDataGridView.Location = New System.Drawing.Point(35, 118)
        Me.UnidadesmedidaDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UnidadesmedidaDataGridView.MultiSelect = False
        Me.UnidadesmedidaDataGridView.Name = "UnidadesmedidaDataGridView"
        Me.UnidadesmedidaDataGridView.ReadOnly = True
        Me.UnidadesmedidaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UnidadesmedidaDataGridView.Size = New System.Drawing.Size(347, 271)
        Me.UnidadesmedidaDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idunidadmedida"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idunidadmedida"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'ABMUnidadesMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 406)
        Me.Controls.Add(Me.UnidadesmedidaDataGridView)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.UnidadesmedidaBindingNavigator)
        Me.Controls.Add(IdunidadmedidaLabel)
        Me.Controls.Add(Me.IdunidadmedidaTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMUnidadesMedida"
        Me.Text = "ABMUnidadesMedida"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnidadesmedidaBindingNavigator.ResumeLayout(False)
        Me.UnidadesmedidaBindingNavigator.PerformLayout()
        CType(Me.UnidadesmedidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents UnidadesmedidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadesmedidaTableAdapter As sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UnidadesmedidaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UnidadesmedidaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdunidadmedidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadesmedidaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

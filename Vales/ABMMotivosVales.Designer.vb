<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMMotivosVales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMMotivosVales))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.TipomotivosvalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipomotivosvalesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipomotivosvalesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.TipomotivosvalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TipomotivosvalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TipomotivosvalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipomotivosvalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipomotivosvalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipomotivosvalesBindingNavigator.SuspendLayout()
        CType(Me.TipomotivosvalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipomotivosvalesBindingSource
        '
        Me.TipomotivosvalesBindingSource.DataMember = "tipomotivosvales"
        Me.TipomotivosvalesBindingSource.DataSource = Me.ComercialDataSet
        '
        'TipomotivosvalesTableAdapter
        '
        Me.TipomotivosvalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
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
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Me.TipomotivosvalesTableAdapter
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'TipomotivosvalesBindingNavigator
        '
        Me.TipomotivosvalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TipomotivosvalesBindingNavigator.BindingSource = Me.TipomotivosvalesBindingSource
        Me.TipomotivosvalesBindingNavigator.CountItem = Nothing
        Me.TipomotivosvalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TipomotivosvalesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TipomotivosvalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TipomotivosvalesBindingNavigatorSaveItem})
        Me.TipomotivosvalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TipomotivosvalesBindingNavigator.MoveFirstItem = Nothing
        Me.TipomotivosvalesBindingNavigator.MoveLastItem = Nothing
        Me.TipomotivosvalesBindingNavigator.MoveNextItem = Nothing
        Me.TipomotivosvalesBindingNavigator.MovePreviousItem = Nothing
        Me.TipomotivosvalesBindingNavigator.Name = "TipomotivosvalesBindingNavigator"
        Me.TipomotivosvalesBindingNavigator.PositionItem = Nothing
        Me.TipomotivosvalesBindingNavigator.Size = New System.Drawing.Size(352, 47)
        Me.TipomotivosvalesBindingNavigator.TabIndex = 0
        Me.TipomotivosvalesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'TipomotivosvalesBindingNavigatorSaveItem
        '
        Me.TipomotivosvalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TipomotivosvalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TipomotivosvalesBindingNavigatorSaveItem.Name = "TipomotivosvalesBindingNavigatorSaveItem"
        Me.TipomotivosvalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.TipomotivosvalesBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.TipomotivosvalesBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TipomotivosvalesDataGridView
        '
        Me.TipomotivosvalesDataGridView.AllowUserToAddRows = False
        Me.TipomotivosvalesDataGridView.AllowUserToDeleteRows = False
        Me.TipomotivosvalesDataGridView.AutoGenerateColumns = False
        Me.TipomotivosvalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipomotivosvalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TipomotivosvalesDataGridView.DataSource = Me.TipomotivosvalesBindingSource
        Me.TipomotivosvalesDataGridView.Location = New System.Drawing.Point(12, 64)
        Me.TipomotivosvalesDataGridView.Name = "TipomotivosvalesDataGridView"
        Me.TipomotivosvalesDataGridView.RowTemplate.Height = 24
        Me.TipomotivosvalesDataGridView.Size = New System.Drawing.Size(328, 266)
        Me.TipomotivosvalesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idtipomotivovale"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idtipomotivovale"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "motivo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Motivo"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'ABMMotivosVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 342)
        Me.Controls.Add(Me.TipomotivosvalesDataGridView)
        Me.Controls.Add(Me.TipomotivosvalesBindingNavigator)
        Me.MinimizeBox = False
        Me.Name = "ABMMotivosVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMMotivosVales"
        Me.Text = "ABM Motivos Vales"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipomotivosvalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipomotivosvalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipomotivosvalesBindingNavigator.ResumeLayout(False)
        Me.TipomotivosvalesBindingNavigator.PerformLayout()
        CType(Me.TipomotivosvalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipomotivosvalesBindingSource As BindingSource
    Friend WithEvents TipomotivosvalesTableAdapter As comercialDataSetTableAdapters.tipomotivosvalesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipomotivosvalesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents TipomotivosvalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TipomotivosvalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class

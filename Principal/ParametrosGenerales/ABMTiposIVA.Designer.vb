<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMTiposIVA
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
        Dim IdtipoivaLabel As System.Windows.Forms.Label
        Dim AlicuotaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMTiposIVA))
        Me.TipoivaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TipoivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TipoivaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TipoivaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoivaTextBox = New System.Windows.Forms.TextBox()
        Me.AlicuotaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoestadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoivaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipoivaTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.TipoestadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipoestadosTableAdapter()
        IdtipoivaLabel = New System.Windows.Forms.Label()
        AlicuotaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me.TipoivaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoivaBindingNavigator.SuspendLayout()
        CType(Me.TipoivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoivaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoestadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdtipoivaLabel
        '
        IdtipoivaLabel.AutoSize = True
        IdtipoivaLabel.Enabled = False
        IdtipoivaLabel.Location = New System.Drawing.Point(169, 42)
        IdtipoivaLabel.Name = "IdtipoivaLabel"
        IdtipoivaLabel.Size = New System.Drawing.Size(25, 17)
        IdtipoivaLabel.TabIndex = 2
        IdtipoivaLabel.Text = "ID:"
        IdtipoivaLabel.Visible = False
        '
        'AlicuotaLabel
        '
        AlicuotaLabel.AutoSize = True
        AlicuotaLabel.Location = New System.Drawing.Point(106, 70)
        AlicuotaLabel.Name = "AlicuotaLabel"
        AlicuotaLabel.Size = New System.Drawing.Size(88, 17)
        AlicuotaLabel.TabIndex = 4
        AlicuotaLabel.Text = "Alícuota (%):"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(108, 98)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 6
        DescripcionLabel.Text = "Descripción:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(138, 126)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(56, 17)
        EstadoLabel.TabIndex = 8
        EstadoLabel.Text = "Estado:"
        '
        'TipoivaBindingNavigator
        '
        Me.TipoivaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TipoivaBindingNavigator.BindingSource = Me.TipoivaBindingSource
        Me.TipoivaBindingNavigator.CountItem = Nothing
        Me.TipoivaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TipoivaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TipoivaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TipoivaBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.TipoivaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TipoivaBindingNavigator.MoveFirstItem = Nothing
        Me.TipoivaBindingNavigator.MoveLastItem = Nothing
        Me.TipoivaBindingNavigator.MoveNextItem = Nothing
        Me.TipoivaBindingNavigator.MovePreviousItem = Nothing
        Me.TipoivaBindingNavigator.Name = "TipoivaBindingNavigator"
        Me.TipoivaBindingNavigator.PositionItem = Nothing
        Me.TipoivaBindingNavigator.Size = New System.Drawing.Size(460, 27)
        Me.TipoivaBindingNavigator.TabIndex = 0
        Me.TipoivaBindingNavigator.Text = "BindingNavigator1"
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
        'TipoivaBindingSource
        '
        Me.TipoivaBindingSource.DataMember = "tipoiva"
        Me.TipoivaBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TipoivaBindingNavigatorSaveItem
        '
        Me.TipoivaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TipoivaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TipoivaBindingNavigatorSaveItem.Name = "TipoivaBindingNavigatorSaveItem"
        Me.TipoivaBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.TipoivaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.sgcomercial.My.Resources.Resources.editar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 24)
        Me.ToolStripButton1.Text = "Editar"
        '
        'TipoivaDataGridView
        '
        Me.TipoivaDataGridView.AllowUserToAddRows = False
        Me.TipoivaDataGridView.AllowUserToDeleteRows = False
        Me.TipoivaDataGridView.AllowUserToResizeColumns = False
        Me.TipoivaDataGridView.AllowUserToResizeRows = False
        Me.TipoivaDataGridView.AutoGenerateColumns = False
        Me.TipoivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipoivaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TipoivaDataGridView.DataSource = Me.TipoivaBindingSource
        Me.TipoivaDataGridView.Location = New System.Drawing.Point(12, 187)
        Me.TipoivaDataGridView.MultiSelect = False
        Me.TipoivaDataGridView.Name = "TipoivaDataGridView"
        Me.TipoivaDataGridView.ReadOnly = True
        Me.TipoivaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.TipoivaDataGridView.RowTemplate.Height = 24
        Me.TipoivaDataGridView.Size = New System.Drawing.Size(436, 220)
        Me.TipoivaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idtipoiva"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idtipoiva"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "alicuota"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Alícuota"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Alícuota"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Descripción"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Estado"
        '
        'IdtipoivaTextBox
        '
        Me.IdtipoivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoivaBindingSource, "idtipoiva", True))
        Me.IdtipoivaTextBox.Enabled = False
        Me.IdtipoivaTextBox.Location = New System.Drawing.Point(199, 39)
        Me.IdtipoivaTextBox.Name = "IdtipoivaTextBox"
        Me.IdtipoivaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdtipoivaTextBox.TabIndex = 3
        Me.IdtipoivaTextBox.Visible = False
        '
        'AlicuotaTextBox
        '
        Me.AlicuotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoivaBindingSource, "alicuota", True))
        Me.AlicuotaTextBox.Location = New System.Drawing.Point(199, 67)
        Me.AlicuotaTextBox.Name = "AlicuotaTextBox"
        Me.AlicuotaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AlicuotaTextBox.TabIndex = 5
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoivaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(199, 95)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DescripcionTextBox.TabIndex = 7
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoivaBindingSource, "estado", True))
        Me.EstadoComboBox.DataSource = Me.TipoestadosBindingSource
        Me.EstadoComboBox.DisplayMember = "idestado"
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Location = New System.Drawing.Point(199, 126)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(100, 24)
        Me.EstadoComboBox.TabIndex = 10
        Me.EstadoComboBox.ValueMember = "descripcion"
        '
        'TipoestadosBindingSource
        '
        Me.TipoestadosBindingSource.DataMember = "tipoestados"
        Me.TipoestadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'TipoivaTableAdapter
        '
        Me.TipoivaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Me.TipoivaTableAdapter
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
        'TipoestadosTableAdapter
        '
        Me.TipoestadosTableAdapter.ClearBeforeFill = True
        '
        'ABMTiposIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 427)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(IdtipoivaLabel)
        Me.Controls.Add(Me.IdtipoivaTextBox)
        Me.Controls.Add(AlicuotaLabel)
        Me.Controls.Add(Me.AlicuotaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.TipoivaDataGridView)
        Me.Controls.Add(Me.TipoivaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMTiposIVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMTiposIVA"
        Me.Text = "ABM TiposIVA"
        CType(Me.TipoivaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoivaBindingNavigator.ResumeLayout(False)
        Me.TipoivaBindingNavigator.PerformLayout()
        CType(Me.TipoivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoivaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoestadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipoivaBindingSource As BindingSource
    Friend WithEvents TipoivaTableAdapter As comercialDataSetTableAdapters.tipoivaTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipoivaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents TipoivaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TipoivaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IdtipoivaTextBox As TextBox
    Friend WithEvents AlicuotaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents TipoestadosBindingSource As BindingSource
    Friend WithEvents TipoestadosTableAdapter As comercialDataSetTableAdapters.tipoestadosTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

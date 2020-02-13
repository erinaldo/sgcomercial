<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMRubros
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
        Dim IdrubroLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ComerciableLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMRubros))
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.RubrosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.IdrubroTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ComerciableComboBox = New System.Windows.Forms.ComboBox()
        Me.RubrosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.RubrosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.BtnListar = New System.Windows.Forms.ToolStripButton()
        IdrubroLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ComerciableLabel = New System.Windows.Forms.Label()
        Me.GroupListado.SuspendLayout()
        CType(Me.RubrosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupABM.SuspendLayout()
        CType(Me.RubrosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RubrosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdrubroLabel
        '
        IdrubroLabel.AutoSize = True
        IdrubroLabel.Location = New System.Drawing.Point(20, 31)
        IdrubroLabel.Name = "IdrubroLabel"
        IdrubroLabel.Size = New System.Drawing.Size(57, 17)
        IdrubroLabel.TabIndex = 0
        IdrubroLabel.Text = "idrubro:"
        IdrubroLabel.Visible = False
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(107, 171)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción:"
        '
        'ComerciableLabel
        '
        ComerciableLabel.AutoSize = True
        ComerciableLabel.Location = New System.Drawing.Point(107, 199)
        ComerciableLabel.Name = "ComerciableLabel"
        ComerciableLabel.Size = New System.Drawing.Size(90, 17)
        ComerciableLabel.TabIndex = 4
        ComerciableLabel.Text = "Comerciable:"
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.RubrosDataGridView)
        Me.GroupListado.Location = New System.Drawing.Point(12, 67)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(543, 348)
        Me.GroupListado.TabIndex = 0
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'RubrosDataGridView
        '
        Me.RubrosDataGridView.AllowUserToAddRows = False
        Me.RubrosDataGridView.AllowUserToDeleteRows = False
        Me.RubrosDataGridView.AutoGenerateColumns = False
        Me.RubrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RubrosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.RubrosDataGridView.DataSource = Me.RubrosBindingSource
        Me.RubrosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RubrosDataGridView.Location = New System.Drawing.Point(3, 18)
        Me.RubrosDataGridView.Name = "RubrosDataGridView"
        Me.RubrosDataGridView.ReadOnly = True
        Me.RubrosDataGridView.RowTemplate.Height = 24
        Me.RubrosDataGridView.Size = New System.Drawing.Size(537, 327)
        Me.RubrosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "comerciable"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comerciable"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "rubros"
        Me.RubrosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(IdrubroLabel)
        Me.GroupABM.Controls.Add(Me.IdrubroTextBox)
        Me.GroupABM.Controls.Add(DescripcionLabel)
        Me.GroupABM.Controls.Add(Me.DescripcionTextBox)
        Me.GroupABM.Controls.Add(ComerciableLabel)
        Me.GroupABM.Controls.Add(Me.ComerciableComboBox)
        Me.GroupABM.Location = New System.Drawing.Point(12, 67)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(543, 348)
        Me.GroupABM.TabIndex = 1
        Me.GroupABM.TabStop = False
        '
        'IdrubroTextBox
        '
        Me.IdrubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubrosBindingSource, "idrubro", True))
        Me.IdrubroTextBox.Location = New System.Drawing.Point(114, 28)
        Me.IdrubroTextBox.Name = "IdrubroTextBox"
        Me.IdrubroTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdrubroTextBox.TabIndex = 1
        Me.IdrubroTextBox.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubrosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(201, 168)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(235, 22)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'ComerciableComboBox
        '
        Me.ComerciableComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubrosBindingSource, "comerciable", True))
        Me.ComerciableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComerciableComboBox.FormattingEnabled = True
        Me.ComerciableComboBox.Items.AddRange(New Object() {"S", "N"})
        Me.ComerciableComboBox.Location = New System.Drawing.Point(201, 196)
        Me.ComerciableComboBox.Name = "ComerciableComboBox"
        Me.ComerciableComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ComerciableComboBox.TabIndex = 5
        '
        'RubrosTableAdapter
        '
        Me.RubrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.auventascanceladasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.categoriasempleadosTableAdapter = Nothing
        Me.TableAdapterManager.centroscostoTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.conceptossueldosTableAdapter = Nothing
        Me.TableAdapterManager.condicionempleoTableAdapter = Nothing
        Me.TableAdapterManager.convenioempleoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaproductosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
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
        Me.TableAdapterManager.gradosTableAdapter = Nothing
        Me.TableAdapterManager.gruposjerarquicosTableAdapter = Nothing
        Me.TableAdapterManager.incapacidadesTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.lotesvencimientoTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.obrassocialesTableAdapter = Nothing
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
        Me.TableAdapterManager.pagosimputacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.rubrosTableAdapter = Me.RubrosTableAdapter
        Me.TableAdapterManager.salonesTableAdapter = Nothing
        Me.TableAdapterManager.serviciosTableAdapter = Nothing
        Me.TableAdapterManager.sindicatosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosueldoTableAdapter = Nothing
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
        'RubrosBindingNavigator
        '
        Me.RubrosBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.RubrosBindingNavigator.BindingSource = Me.RubrosBindingSource
        Me.RubrosBindingNavigator.CountItem = Nothing
        Me.RubrosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RubrosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RubrosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnEditar, Me.BtnCancelar, Me.BtnListar})
        Me.RubrosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RubrosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RubrosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RubrosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RubrosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RubrosBindingNavigator.Name = "RubrosBindingNavigator"
        Me.RubrosBindingNavigator.PositionItem = Nothing
        Me.RubrosBindingNavigator.Size = New System.Drawing.Size(569, 47)
        Me.RubrosBindingNavigator.TabIndex = 2
        Me.RubrosBindingNavigator.Text = "BindingNavigator1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.RightToLeftAutoMirrorImage = True
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 44)
        Me.BtnNuevo.Text = "Agregar"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 44)
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 44)
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 44)
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnListar
        '
        Me.BtnListar.Image = Global.sgcomercial.My.Resources.Resources.CheckList
        Me.BtnListar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(48, 44)
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ABMRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 435)
        Me.Controls.Add(Me.RubrosBindingNavigator)
        Me.Controls.Add(Me.GroupListado)
        Me.Controls.Add(Me.GroupABM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Altas, Bajas y Modificación de Rubros"
        Me.GroupListado.ResumeLayout(False)
        CType(Me.RubrosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        CType(Me.RubrosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RubrosBindingNavigator.ResumeLayout(False)
        Me.RubrosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents RubrosBindingSource As BindingSource
    Friend WithEvents RubrosTableAdapter As comercialDataSetTableAdapters.rubrosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RubrosBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents RubrosDataGridView As DataGridView
    Friend WithEvents IdrubroTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents ComerciableComboBox As ComboBox
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents BtnListar As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class

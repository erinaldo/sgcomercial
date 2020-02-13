<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMGruposJerarquicos
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMGruposJerarquicos))
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GruposjerarquicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposjerarquicosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gruposjerarquicosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GruposjerarquicosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.NavFirst = New System.Windows.Forms.ToolStripButton()
        Me.NavPrev = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NavNext = New System.Windows.Forms.ToolStripButton()
        Me.NavLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnListar = New System.Windows.Forms.ToolStripButton()
        Me.IdgrupojerarquicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposjerarquicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposjerarquicosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruposjerarquicosBindingNavigator.SuspendLayout()
        Me.GroupABM.SuspendLayout()
        Me.GroupListado.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(118, 92)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripción:"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposjerarquicosBindingSource
        '
        Me.GruposjerarquicosBindingSource.DataMember = "gruposjerarquicos"
        Me.GruposjerarquicosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GruposjerarquicosTableAdapter
        '
        Me.GruposjerarquicosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.gruposjerarquicosTableAdapter = Me.GruposjerarquicosTableAdapter
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
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
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
        'GruposjerarquicosBindingNavigator
        '
        Me.GruposjerarquicosBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.GruposjerarquicosBindingNavigator.BindingSource = Me.GruposjerarquicosBindingSource
        Me.GruposjerarquicosBindingNavigator.CountItem = Nothing
        Me.GruposjerarquicosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GruposjerarquicosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GruposjerarquicosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavFirst, Me.NavPrev, Me.BindingNavigatorSeparator1, Me.NavNext, Me.NavLast, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnCancelar, Me.BtnEditar, Me.BtnListar})
        Me.GruposjerarquicosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GruposjerarquicosBindingNavigator.MoveFirstItem = Me.NavFirst
        Me.GruposjerarquicosBindingNavigator.MoveLastItem = Me.NavLast
        Me.GruposjerarquicosBindingNavigator.MoveNextItem = Me.NavNext
        Me.GruposjerarquicosBindingNavigator.MovePreviousItem = Me.NavPrev
        Me.GruposjerarquicosBindingNavigator.Name = "GruposjerarquicosBindingNavigator"
        Me.GruposjerarquicosBindingNavigator.PositionItem = Nothing
        Me.GruposjerarquicosBindingNavigator.Size = New System.Drawing.Size(589, 47)
        Me.GruposjerarquicosBindingNavigator.TabIndex = 1
        Me.GruposjerarquicosBindingNavigator.Text = "BindingNavigator1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.RightToLeftAutoMirrorImage = True
        Me.BtnNuevo.Size = New System.Drawing.Size(111, 44)
        Me.BtnNuevo.Tag = "Agregar nuevo"
        Me.BtnNuevo.Text = "Agregar nuevo"
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
        'NavFirst
        '
        Me.NavFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NavFirst.Image = CType(resources.GetObject("NavFirst.Image"), System.Drawing.Image)
        Me.NavFirst.Name = "NavFirst"
        Me.NavFirst.RightToLeftAutoMirrorImage = True
        Me.NavFirst.Size = New System.Drawing.Size(24, 44)
        Me.NavFirst.Text = "Mover primero"
        '
        'NavPrev
        '
        Me.NavPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NavPrev.Image = CType(resources.GetObject("NavPrev.Image"), System.Drawing.Image)
        Me.NavPrev.Name = "NavPrev"
        Me.NavPrev.RightToLeftAutoMirrorImage = True
        Me.NavPrev.Size = New System.Drawing.Size(24, 44)
        Me.NavPrev.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'NavNext
        '
        Me.NavNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NavNext.Image = CType(resources.GetObject("NavNext.Image"), System.Drawing.Image)
        Me.NavNext.Name = "NavNext"
        Me.NavNext.RightToLeftAutoMirrorImage = True
        Me.NavNext.Size = New System.Drawing.Size(24, 44)
        Me.NavNext.Text = "Mover siguiente"
        '
        'NavLast
        '
        Me.NavLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NavLast.Image = CType(resources.GetObject("NavLast.Image"), System.Drawing.Image)
        Me.NavLast.Name = "NavLast"
        Me.NavLast.RightToLeftAutoMirrorImage = True
        Me.NavLast.Size = New System.Drawing.Size(24, 44)
        Me.NavLast.Text = "Mover último"
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
        Me.BtnGuardar.Tag = "Guardar"
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 44)
        Me.BtnCancelar.Tag = "Cancelar"
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 44)
        Me.BtnEditar.Tag = "Editar"
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'IdgrupojerarquicoTextBox
        '
        Me.IdgrupojerarquicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposjerarquicosBindingSource, "idgrupojerarquico", True))
        Me.IdgrupojerarquicoTextBox.Location = New System.Drawing.Point(542, 18)
        Me.IdgrupojerarquicoTextBox.Name = "IdgrupojerarquicoTextBox"
        Me.IdgrupojerarquicoTextBox.Size = New System.Drawing.Size(22, 22)
        Me.IdgrupojerarquicoTextBox.TabIndex = 3
        Me.IdgrupojerarquicoTextBox.Visible = False
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposjerarquicosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(225, 89)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(222, 22)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(Me.IdgrupojerarquicoTextBox)
        Me.GroupABM.Controls.Add(DescripcionLabel)
        Me.GroupABM.Controls.Add(Me.DescripcionTextBox)
        Me.GroupABM.Location = New System.Drawing.Point(12, 54)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(565, 201)
        Me.GroupABM.TabIndex = 8
        Me.GroupABM.TabStop = False
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.DataGridView1)
        Me.GroupListado.Location = New System.Drawing.Point(12, 54)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(565, 201)
        Me.GroupListado.TabIndex = 9
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdgrupojerarquicoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GruposjerarquicosBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(559, 180)
        Me.DataGridView1.TabIndex = 0
        '
        'IdgrupojerarquicoDataGridViewTextBoxColumn
        '
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn.DataPropertyName = "idgrupojerarquico"
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn.HeaderText = "idgrupojerarquico"
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn.Name = "IdgrupojerarquicoDataGridViewTextBoxColumn"
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdgrupojerarquicoDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.ToolTipText = "Descripción"
        '
        'ABMGruposJerarquicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 267)
        Me.Controls.Add(Me.GruposjerarquicosBindingNavigator)
        Me.Controls.Add(Me.GroupABM)
        Me.Controls.Add(Me.GroupListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMGruposJerarquicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMGruposJerarquicos"
        Me.Text = "Alta, Baja y Modificación de Grupos Jerárquicos"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposjerarquicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposjerarquicosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruposjerarquicosBindingNavigator.ResumeLayout(False)
        Me.GruposjerarquicosBindingNavigator.PerformLayout()
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        Me.GroupListado.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents GruposjerarquicosBindingSource As BindingSource
    Friend WithEvents GruposjerarquicosTableAdapter As comercialDataSetTableAdapters.gruposjerarquicosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GruposjerarquicosBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents NavFirst As ToolStripButton
    Friend WithEvents NavPrev As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents NavNext As ToolStripButton
    Friend WithEvents NavLast As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents IdgrupojerarquicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdgrupojerarquicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnListar As ToolStripButton
End Class

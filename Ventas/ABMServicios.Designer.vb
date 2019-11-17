<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMServicios
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
        Dim IdservicioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioventaLabel As System.Windows.Forms.Label
        Dim DiasvigenciaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMServicios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdservicioTextBox = New System.Windows.Forms.TextBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventaTextBox = New System.Windows.Forms.TextBox()
        Me.DiasvigenciaTextBox = New System.Windows.Forms.TextBox()
        Me.ServiciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.serviciosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ServiciosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ServiciosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        IdservicioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioventaLabel = New System.Windows.Forms.Label()
        DiasvigenciaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiciosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdservicioLabel
        '
        IdservicioLabel.AutoSize = True
        IdservicioLabel.Location = New System.Drawing.Point(267, 43)
        IdservicioLabel.Name = "IdservicioLabel"
        IdservicioLabel.Size = New System.Drawing.Size(25, 17)
        IdservicioLabel.TabIndex = 0
        IdservicioLabel.Text = "ID:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(210, 71)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(82, 17)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripción"
        '
        'PrecioventaLabel
        '
        PrecioventaLabel.AutoSize = True
        PrecioventaLabel.Location = New System.Drawing.Point(199, 99)
        PrecioventaLabel.Name = "PrecioventaLabel"
        PrecioventaLabel.Size = New System.Drawing.Size(93, 17)
        PrecioventaLabel.TabIndex = 4
        PrecioventaLabel.Text = "Precio Venta:"
        '
        'DiasvigenciaLabel
        '
        DiasvigenciaLabel.AutoSize = True
        DiasvigenciaLabel.Location = New System.Drawing.Point(194, 127)
        DiasvigenciaLabel.Name = "DiasvigenciaLabel"
        DiasvigenciaLabel.Size = New System.Drawing.Size(98, 17)
        DiasvigenciaLabel.TabIndex = 6
        DiasvigenciaLabel.Text = "Dias Vigencia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdservicioLabel)
        Me.GroupBox1.Controls.Add(Me.IdservicioTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(PrecioventaLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioventaTextBox)
        Me.GroupBox1.Controls.Add(DiasvigenciaLabel)
        Me.GroupBox1.Controls.Add(Me.DiasvigenciaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'IdservicioTextBox
        '
        Me.IdservicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "idservicio", True))
        Me.IdservicioTextBox.Enabled = False
        Me.IdservicioTextBox.Location = New System.Drawing.Point(301, 40)
        Me.IdservicioTextBox.Name = "IdservicioTextBox"
        Me.IdservicioTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdservicioTextBox.TabIndex = 1
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "servicios"
        Me.ServiciosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(301, 68)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'PrecioventaTextBox
        '
        Me.PrecioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "precioventa", True))
        Me.PrecioventaTextBox.Location = New System.Drawing.Point(301, 96)
        Me.PrecioventaTextBox.Name = "PrecioventaTextBox"
        Me.PrecioventaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PrecioventaTextBox.TabIndex = 5
        '
        'DiasvigenciaTextBox
        '
        Me.DiasvigenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "diasvigencia", True))
        Me.DiasvigenciaTextBox.Location = New System.Drawing.Point(301, 124)
        Me.DiasvigenciaTextBox.Name = "DiasvigenciaTextBox"
        Me.DiasvigenciaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DiasvigenciaTextBox.TabIndex = 7
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
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
        'Me.TableAdapterManager.clientesalumnosTableAdapter = Nothing
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
        Me.TableAdapterManager.gradosTableAdapter = Nothing
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
        Me.TableAdapterManager.serviciosTableAdapter = Me.ServiciosTableAdapter
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
        'ServiciosBindingNavigator
        '
        Me.ServiciosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ServiciosBindingNavigator.BindingSource = Me.ServiciosBindingSource
        Me.ServiciosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ServiciosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ServiciosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ServiciosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ServiciosBindingNavigatorSaveItem, Me.ToolStripButtonEditar, Me.ToolStripButtonCancelar})
        Me.ServiciosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ServiciosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ServiciosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ServiciosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ServiciosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ServiciosBindingNavigator.Name = "ServiciosBindingNavigator"
        Me.ServiciosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ServiciosBindingNavigator.Size = New System.Drawing.Size(619, 47)
        Me.ServiciosBindingNavigator.TabIndex = 1
        Me.ServiciosBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "-"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ServiciosBindingNavigatorSaveItem
        '
        Me.ServiciosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ServiciosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ServiciosBindingNavigatorSaveItem.Name = "ServiciosBindingNavigatorSaveItem"
        Me.ServiciosBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 44)
        Me.ServiciosBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.ServiciosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.sgcomercial.My.Resources.Resources.editar
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(52, 44)
        Me.ToolStripButtonEditar.Tag = "ToolStripButtonEditar"
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
        'ABMServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 248)
        Me.Controls.Add(Me.ServiciosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMServicios"
        Me.Text = "Alta, Baja y Modificación de Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiciosBindingNavigator.ResumeLayout(False)
        Me.ServiciosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As comercialDataSetTableAdapters.serviciosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServiciosBindingNavigator As BindingNavigator
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
    Friend WithEvents ServiciosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdservicioTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioventaTextBox As TextBox
    Friend WithEvents DiasvigenciaTextBox As TextBox
    Friend WithEvents ToolStripButtonEditar As ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As ToolStripButton
End Class

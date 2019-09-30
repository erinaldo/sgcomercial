<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StkMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StkMovimientos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DPHasta = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxFiltro = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DPDesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StkmovimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripGrilla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StkmovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.StkmovimientosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stkmovimientosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StkmovimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripGrilla.SuspendLayout()
        CType(Me.StkmovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnConsultar)
        Me.GroupBox1.Controls.Add(Me.DPHasta)
        Me.GroupBox1.Controls.Add(Me.ComboBoxFiltro)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DPDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1108, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DPHasta
        '
        Me.DPHasta.CustomFormat = "dd/MM/yyyy"
        Me.DPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPHasta.Location = New System.Drawing.Point(356, 23)
        Me.DPHasta.Name = "DPHasta"
        Me.DPHasta.Size = New System.Drawing.Size(115, 22)
        Me.DPHasta.TabIndex = 20
        '
        'ComboBoxFiltro
        '
        Me.ComboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFiltro.FormattingEnabled = True
        Me.ComboBoxFiltro.Items.AddRange(New Object() {"Código", "Producto (Nombre)"})
        Me.ComboBoxFiltro.Location = New System.Drawing.Point(682, 46)
        Me.ComboBoxFiltro.Name = "ComboBoxFiltro"
        Me.ComboBoxFiltro.Size = New System.Drawing.Size(152, 24)
        Me.ComboBoxFiltro.TabIndex = 19
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(20, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 21)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "A fecha"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 62)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(84, 21)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.Text = "Historico"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(1058, 44)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(29, 28)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(843, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'DPDesde
        '
        Me.DPDesde.CustomFormat = "dd/MM/yyyy"
        Me.DPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPDesde.Location = New System.Drawing.Point(170, 23)
        Me.DPDesde.Name = "DPDesde"
        Me.DPDesde.Size = New System.Drawing.Size(115, 22)
        Me.DPDesde.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.StkmovimientosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1108, 478)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'StkmovimientosDataGridView
        '
        Me.StkmovimientosDataGridView.AllowUserToAddRows = False
        Me.StkmovimientosDataGridView.AllowUserToDeleteRows = False
        Me.StkmovimientosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StkmovimientosDataGridView.AutoGenerateColumns = False
        Me.StkmovimientosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StkmovimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StkmovimientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.codigoproducto, Me.producto, Me.cantidad, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.motivo, Me.fecha})
        Me.StkmovimientosDataGridView.ContextMenuStrip = Me.ContextMenuStripGrilla
        Me.StkmovimientosDataGridView.DataSource = Me.StkmovimientosBindingSource
        Me.StkmovimientosDataGridView.Location = New System.Drawing.Point(20, 21)
        Me.StkmovimientosDataGridView.Name = "StkmovimientosDataGridView"
        Me.StkmovimientosDataGridView.ReadOnly = True
        Me.StkmovimientosDataGridView.RowTemplate.Height = 24
        Me.StkmovimientosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StkmovimientosDataGridView.Size = New System.Drawing.Size(1067, 438)
        Me.StkmovimientosDataGridView.TabIndex = 0
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 93
        '
        'motivo
        '
        Me.motivo.DataPropertyName = "motivo"
        Me.motivo.HeaderText = "Motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.ToolTipText = "Motivo"
        Me.motivo.Width = 78
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Visible = False
        Me.fecha.Width = 72
        '
        'ContextMenuStripGrilla
        '
        Me.ContextMenuStripGrilla.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripGrilla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnActualizar})
        Me.ContextMenuStripGrilla.Name = "ContextMenuStripGrilla"
        Me.ContextMenuStripGrilla.Size = New System.Drawing.Size(173, 30)
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Image = Global.sgcomercial.My.Resources.Resources.refresh_icon
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.BtnActualizar.Size = New System.Drawing.Size(172, 26)
        Me.BtnActualizar.Text = "Actualizar"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Carga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Fecha Carga"
        Me.DataGridViewTextBoxColumn3.Width = 118
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Código Producto"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.codigoproducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.codigoproducto.ToolTipText = "Click para copiar código al cuadro de filtrado"
        Me.codigoproducto.Width = 130
        '
        'producto
        '
        Me.producto.DataPropertyName = "producto"
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.ToolTipText = "Producto"
        Me.producto.Width = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tipomovimiento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo Movimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Tipo Movimiento"
        Me.DataGridViewTextBoxColumn1.Width = 128
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "origen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Origen Movimiento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Origen"
        Me.DataGridViewTextBoxColumn2.Width = 142
        '
        'StkmovimientosBindingSource
        '
        Me.StkmovimientosBindingSource.DataMember = "stkmovimientos"
        Me.StkmovimientosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StkmovimientosTableAdapter
        '
        Me.StkmovimientosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(492, 22)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(90, 23)
        Me.BtnConsultar.TabIndex = 21
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(681, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Filtrar:"
        '
        'StkMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StkMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "StkMovimientos"
        Me.Text = "Movimientos de Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.StkmovimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripGrilla.ResumeLayout(False)
        CType(Me.StkmovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DPDesde As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents StkmovimientosBindingSource As BindingSource
    Friend WithEvents StkmovimientosTableAdapter As comercialDataSetTableAdapters.stkmovimientosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StkmovimientosDataGridView As DataGridView
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ContextMenuStripGrilla As ContextMenuStrip
    Friend WithEvents BtnActualizar As ToolStripMenuItem
    Friend WithEvents ComboBoxFiltro As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents codigoproducto As DataGridViewLinkColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents motivo As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents DPHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Label3 As Label
End Class

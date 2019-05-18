<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaPedidos))
        Me.listapedidosreporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdpedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechabajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finalizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitcuilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonacontactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.proveedoresTableAdapter()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listapedidosreporteTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosreporteTableAdapter()
        Me.ListapedidosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SoloCantidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.listapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listapedidosreporteBindingSource
        '
        Me.listapedidosreporteBindingSource.DataMember = "listapedidosreporte"
        Me.listapedidosreporteBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PedidosDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 513)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pedidos"
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.AllowUserToAddRows = False
        Me.PedidosDataGridView.AllowUserToDeleteRows = False
        Me.PedidosDataGridView.AllowUserToResizeColumns = False
        Me.PedidosDataGridView.AllowUserToResizeRows = False
        Me.PedidosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpedidoDataGridViewTextBoxColumn, Me.IdproveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.Finalizado, Me.CuitcuilDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.PersonacontactoDataGridViewTextBoxColumn})
        Me.PedidosDataGridView.DataSource = Me.ListapedidosBindingSource
        Me.PedidosDataGridView.Location = New System.Drawing.Point(11, 33)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.ReadOnly = True
        Me.PedidosDataGridView.RowTemplate.Height = 24
        Me.PedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PedidosDataGridView.Size = New System.Drawing.Size(726, 456)
        Me.PedidosDataGridView.TabIndex = 2
        '
        'IdpedidoDataGridViewTextBoxColumn
        '
        Me.IdpedidoDataGridViewTextBoxColumn.DataPropertyName = "idpedido"
        Me.IdpedidoDataGridViewTextBoxColumn.HeaderText = "N° Pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.Name = "IdpedidoDataGridViewTextBoxColumn"
        Me.IdpedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdpedidoDataGridViewTextBoxColumn.ToolTipText = "N° Pedido"
        Me.IdpedidoDataGridViewTextBoxColumn.Width = 75
        '
        'IdproveedorDataGridViewTextBoxColumn
        '
        Me.IdproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor"
        Me.IdproveedorDataGridViewTextBoxColumn.Name = "IdproveedorDataGridViewTextBoxColumn"
        Me.IdproveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdproveedorDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.ToolTipText = "Proveedor"
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "Alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaaltaDataGridViewTextBoxColumn.ToolTipText = "Alta"
        '
        'FechabajaDataGridViewTextBoxColumn
        '
        Me.FechabajaDataGridViewTextBoxColumn.DataPropertyName = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.HeaderText = "Baja"
        Me.FechabajaDataGridViewTextBoxColumn.Name = "FechabajaDataGridViewTextBoxColumn"
        Me.FechabajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechabajaDataGridViewTextBoxColumn.ToolTipText = "Baja"
        '
        'Finalizado
        '
        Me.Finalizado.DataPropertyName = "fechafin"
        Me.Finalizado.HeaderText = "Finalizado"
        Me.Finalizado.Name = "Finalizado"
        Me.Finalizado.ReadOnly = True
        '
        'CuitcuilDataGridViewTextBoxColumn
        '
        Me.CuitcuilDataGridViewTextBoxColumn.DataPropertyName = "cuitcuil"
        Me.CuitcuilDataGridViewTextBoxColumn.HeaderText = "CUIT/CUIL"
        Me.CuitcuilDataGridViewTextBoxColumn.Name = "CuitcuilDataGridViewTextBoxColumn"
        Me.CuitcuilDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuitcuilDataGridViewTextBoxColumn.ToolTipText = "CUIT/CUIL"
        Me.CuitcuilDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Tel."
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.ToolTipText = "Tel."
        Me.TelefonoDataGridViewTextBoxColumn.Visible = False
        '
        'PersonacontactoDataGridViewTextBoxColumn
        '
        Me.PersonacontactoDataGridViewTextBoxColumn.DataPropertyName = "personacontacto"
        Me.PersonacontactoDataGridViewTextBoxColumn.HeaderText = "personacontacto"
        Me.PersonacontactoDataGridViewTextBoxColumn.Name = "PersonacontactoDataGridViewTextBoxColumn"
        Me.PersonacontactoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonacontactoDataGridViewTextBoxColumn.Visible = False
        '
        'ListapedidosBindingSource
        '
        Me.ListapedidosBindingSource.DataMember = "listapedidos"
        Me.ListapedidosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
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
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ComercialDataSet
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listapedidosreporteTableAdapter
        '
        Me.listapedidosreporteTableAdapter.ClearBeforeFill = True
        '
        'ListapedidosTableAdapter
        '
        Me.ListapedidosTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloCantidadesToolStripMenuItem, Me.DetalladoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(187, 52)
        '
        'SoloCantidadesToolStripMenuItem
        '
        Me.SoloCantidadesToolStripMenuItem.Name = "SoloCantidadesToolStripMenuItem"
        Me.SoloCantidadesToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.SoloCantidadesToolStripMenuItem.Text = "Solo Cantidades"
        '
        'DetalladoToolStripMenuItem
        '
        Me.DetalladoToolStripMenuItem.Name = "DetalladoToolStripMenuItem"
        Me.DetalladoToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.DetalladoToolStripMenuItem.Text = "Detallado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "<< Click en el pedido para ver el detalle >>"
        '
        'ListaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 529)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ListaPedidos"
        Me.Text = "Lista Pedidos"
        CType(Me.listapedidosreporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresTableAdapter As comercialDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PedidosDataGridView As DataGridView
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listapedidosreporteBindingSource As BindingSource
    Friend WithEvents listapedidosreporteTableAdapter As comercialDataSetTableAdapters.listapedidosreporteTableAdapter
    Friend WithEvents ListapedidosBindingSource As BindingSource
    Friend WithEvents ListapedidosTableAdapter As comercialDataSetTableAdapters.listapedidosTableAdapter
    Friend WithEvents IdpedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechabajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Finalizado As DataGridViewTextBoxColumn
    Friend WithEvents CuitcuilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonacontactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SoloCantidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class

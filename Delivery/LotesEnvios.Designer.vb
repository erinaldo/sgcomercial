<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotesEnvios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.LotesenviosdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotesenviosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotesenviosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechacierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaconfirmacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.rendicion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Confirmar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LotesenviosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotesenviosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.LotesenviosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesenviosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Controls.Add(Me.LotesenviosdetalleDataGridView)
        Me.GroupBox1.Controls.Add(Me.LotesenviosDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1112, 567)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Lotes"
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(143, 21)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.RowTemplate.Height = 24
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(23, 20)
        Me.CajaseventosDataGridView.TabIndex = 1
        Me.CajaseventosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idcaja"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idcaja"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fechaapertura"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fechaapertura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "saldoinicial"
        Me.DataGridViewTextBoxColumn16.HeaderText = "saldoinicial"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "saldofinal"
        Me.DataGridViewTextBoxColumn17.HeaderText = "saldofinal"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "usuarioapertura"
        Me.DataGridViewTextBoxColumn18.HeaderText = "usuarioapertura"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "usuariocierre"
        Me.DataGridViewTextBoxColumn19.HeaderText = "usuariocierre"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LotesenviosdetalleDataGridView
        '
        Me.LotesenviosdetalleDataGridView.AutoGenerateColumns = False
        Me.LotesenviosdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LotesenviosdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.LotesenviosdetalleDataGridView.DataSource = Me.LotesenviosdetalleBindingSource
        Me.LotesenviosdetalleDataGridView.Location = New System.Drawing.Point(115, 21)
        Me.LotesenviosdetalleDataGridView.Name = "LotesenviosdetalleDataGridView"
        Me.LotesenviosdetalleDataGridView.RowTemplate.Height = 24
        Me.LotesenviosdetalleDataGridView.Size = New System.Drawing.Size(22, 22)
        Me.LotesenviosdetalleDataGridView.TabIndex = 1
        Me.LotesenviosdetalleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idloteenviodetalle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idloteenviodetalle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idloteenvio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idpedidodelivery"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "estadoentrega"
        Me.DataGridViewTextBoxColumn10.HeaderText = "estadoentrega"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nroguia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "nroguia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'LotesenviosdetalleBindingSource
        '
        Me.LotesenviosdetalleBindingSource.DataMember = "lotesenviosdetalle"
        Me.LotesenviosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'LotesenviosDataGridView
        '
        Me.LotesenviosDataGridView.AllowUserToAddRows = False
        Me.LotesenviosDataGridView.AllowUserToDeleteRows = False
        Me.LotesenviosDataGridView.AllowUserToResizeColumns = False
        Me.LotesenviosDataGridView.AllowUserToResizeRows = False
        Me.LotesenviosDataGridView.AutoGenerateColumns = False
        Me.LotesenviosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LotesenviosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.fechacierre, Me.fechaconfirmacion, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Ver, Me.rendicion, Me.Confirmar})
        Me.LotesenviosDataGridView.DataSource = Me.LotesenviosBindingSource
        Me.LotesenviosDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.LotesenviosDataGridView.MultiSelect = False
        Me.LotesenviosDataGridView.Name = "LotesenviosDataGridView"
        Me.LotesenviosDataGridView.ReadOnly = True
        Me.LotesenviosDataGridView.RowTemplate.Height = 24
        Me.LotesenviosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LotesenviosDataGridView.Size = New System.Drawing.Size(1081, 520)
        Me.LotesenviosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idloteenvio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaasignacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Asignado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'fechacierre
        '
        Me.fechacierre.DataPropertyName = "fechacierre"
        Me.fechacierre.HeaderText = "Cierre"
        Me.fechacierre.Name = "fechacierre"
        Me.fechacierre.ReadOnly = True
        Me.fechacierre.Width = 150
        '
        'fechaconfirmacion
        '
        Me.fechaconfirmacion.DataPropertyName = "fechaconfirmacion"
        Me.fechaconfirmacion.HeaderText = "Confirmación"
        Me.fechaconfirmacion.Name = "fechaconfirmacion"
        Me.fechaconfirmacion.ReadOnly = True
        Me.fechaconfirmacion.ToolTipText = "Fecha Confirmación"
        Me.fechaconfirmacion.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Baja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "usuariocierre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Usuario Cierre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Usuario Baja"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'Ver
        '
        Me.Ver.HeaderText = "Ver lote"
        Me.Ver.Name = "Ver"
        Me.Ver.ReadOnly = True
        Me.Ver.Text = "Ver/Imprimir"
        Me.Ver.ToolTipText = "Ver/Imprimir"
        Me.Ver.UseColumnTextForButtonValue = True
        Me.Ver.Width = 150
        '
        'rendicion
        '
        Me.rendicion.DataPropertyName = "idloteenvio"
        Me.rendicion.HeaderText = "Ver rendición"
        Me.rendicion.Name = "rendicion"
        Me.rendicion.ReadOnly = True
        Me.rendicion.Text = "Ver rendición"
        Me.rendicion.ToolTipText = "Ver rendición"
        Me.rendicion.UseColumnTextForButtonValue = True
        Me.rendicion.Width = 150
        '
        'Confirmar
        '
        Me.Confirmar.DataPropertyName = "idloteenvio"
        Me.Confirmar.HeaderText = "Confirmar($)"
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.ReadOnly = True
        Me.Confirmar.Text = "Confirmar"
        Me.Confirmar.ToolTipText = "Confirmar"
        Me.Confirmar.UseColumnTextForButtonValue = True
        Me.Confirmar.Width = 150
        '
        'LotesenviosBindingSource
        '
        Me.LotesenviosBindingSource.DataMember = "lotesenvios"
        Me.LotesenviosBindingSource.DataSource = Me.ComercialDataSet
        '
        'LotesenviosTableAdapter
        '
        Me.LotesenviosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.lotesenviosTableAdapter = Me.LotesenviosTableAdapter
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
        'LotesenviosdetalleTableAdapter
        '
        Me.LotesenviosdetalleTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'LotesEnvios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 590)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LotesEnvios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes de Envíos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesenviosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents LotesenviosBindingSource As BindingSource
    Friend WithEvents LotesenviosTableAdapter As comercialDataSetTableAdapters.lotesenviosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LotesenviosDataGridView As DataGridView
    Friend WithEvents LotesenviosdetalleBindingSource As BindingSource
    Friend WithEvents LotesenviosdetalleTableAdapter As comercialDataSetTableAdapters.lotesenviosdetalleTableAdapter
    Friend WithEvents LotesenviosdetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents CajaseventosBindingSource As BindingSource
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents CajaseventosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents fechacierre As DataGridViewTextBoxColumn
    Friend WithEvents fechaconfirmacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
    Friend WithEvents rendicion As DataGridViewButtonColumn
    Friend WithEvents Confirmar As DataGridViewButtonColumn
End Class

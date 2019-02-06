<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtasCtesPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtasCtesPagar))
        Me.nrocomprobante = New System.Windows.Forms.TextBox()
        Me.ComboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ComboFormapago = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagotextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMontoaPagar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ParametrosgeneralesTableAdapter1 = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.CajasmovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasmovimientosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasmovimientosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByPagosaCCToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByPagosaCCToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByPagosaCCToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'nrocomprobante
        '
        Me.nrocomprobante.Location = New System.Drawing.Point(236, 138)
        Me.nrocomprobante.Name = "nrocomprobante"
        Me.nrocomprobante.Size = New System.Drawing.Size(217, 22)
        Me.nrocomprobante.TabIndex = 12
        '
        'ComboTipoComprobante
        '
        Me.ComboTipoComprobante.DataSource = Me.TipocomprobantesBindingSource
        Me.ComboTipoComprobante.DisplayMember = "descripcion"
        Me.ComboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipoComprobante.FormattingEnabled = True
        Me.ComboTipoComprobante.Location = New System.Drawing.Point(236, 75)
        Me.ComboTipoComprobante.Name = "ComboTipoComprobante"
        Me.ComboTipoComprobante.Size = New System.Drawing.Size(217, 24)
        Me.ComboTipoComprobante.TabIndex = 10
        Me.ComboTipoComprobante.ValueMember = "idtipocomprobante"
        '
        'TipocomprobantesBindingSource
        '
        Me.TipocomprobantesBindingSource.DataMember = "tipocomprobantes"
        Me.TipocomprobantesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboFormapago
        '
        Me.ComboFormapago.DataSource = Me.FormaspagoBindingSource
        Me.ComboFormapago.DisplayMember = "descripcion"
        Me.ComboFormapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFormapago.FormattingEnabled = True
        Me.ComboFormapago.Location = New System.Drawing.Point(236, 105)
        Me.ComboFormapago.Name = "ComboFormapago"
        Me.ComboFormapago.Size = New System.Drawing.Size(217, 24)
        Me.ComboFormapago.TabIndex = 11
        Me.ComboFormapago.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
        '
        'pagotextbox
        '
        Me.pagotextbox.Location = New System.Drawing.Point(236, 169)
        Me.pagotextbox.Name = "pagotextbox"
        Me.pagotextbox.Size = New System.Drawing.Size(112, 22)
        Me.pagotextbox.TabIndex = 14
        Me.pagotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Monto pagado:"
        '
        'TextBoxMontoaPagar
        '
        Me.TextBoxMontoaPagar.Enabled = False
        Me.TextBoxMontoaPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMontoaPagar.Location = New System.Drawing.Point(236, 42)
        Me.TextBoxMontoaPagar.Name = "TextBoxMontoaPagar"
        Me.TextBoxMontoaPagar.Size = New System.Drawing.Size(112, 24)
        Me.TextBoxMontoaPagar.TabIndex = 5
        Me.TextBoxMontoaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "N° Comprobante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Forma pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo comprobante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Monto deuda:"
        '
        'TipocomprobantesTableAdapter
        '
        Me.TipocomprobantesTableAdapter.ClearBeforeFill = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ParametrosgeneralesTableAdapter1
        '
        Me.ParametrosgeneralesTableAdapter1.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'CajasmovimientosBindingSource
        '
        Me.CajasmovimientosBindingSource.DataMember = "cajasmovimientos"
        Me.CajasmovimientosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasmovimientosTableAdapter
        '
        Me.CajasmovimientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Me.CajaseventosTableAdapter
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Me.CajasoperacionesTableAdapter
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
        Me.TableAdapterManager.formaspagoTableAdapter = Me.FormaspagoTableAdapter
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Me.PagosTableAdapter
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Me.ParametrosgeneralesTableAdapter1
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
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Me.TipocomprobantesTableAdapter
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
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.RowTemplate.Height = 24
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(29, 14)
        Me.CajasoperacionesDataGridView.TabIndex = 15
        Me.CajasoperacionesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idoperacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idoperacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idgastos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idgastos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn10.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idextracciones"
        Me.DataGridViewTextBoxColumn11.HeaderText = "idextracciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "idvale"
        Me.DataGridViewTextBoxColumn12.HeaderText = "idvale"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idcambiodevolucion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'FillByPagosaCCToolStrip
        '
        Me.FillByPagosaCCToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByPagosaCCToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPagosaCCToolStripButton})
        Me.FillByPagosaCCToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPagosaCCToolStrip.Name = "FillByPagosaCCToolStrip"
        Me.FillByPagosaCCToolStrip.Size = New System.Drawing.Size(552, 27)
        Me.FillByPagosaCCToolStrip.TabIndex = 16
        Me.FillByPagosaCCToolStrip.Text = "FillByPagosaCCToolStrip"
        Me.FillByPagosaCCToolStrip.Visible = False
        '
        'FillByPagosaCCToolStripButton
        '
        Me.FillByPagosaCCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPagosaCCToolStripButton.Name = "FillByPagosaCCToolStripButton"
        Me.FillByPagosaCCToolStripButton.Size = New System.Drawing.Size(113, 24)
        Me.FillByPagosaCCToolStripButton.Text = "FillByPagosaCC"
        '
        'CtasCtesPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 284)
        Me.Controls.Add(Me.FillByPagosaCCToolStrip)
        Me.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nrocomprobante)
        Me.Controls.Add(Me.ComboTipoComprobante)
        Me.Controls.Add(Me.ComboFormapago)
        Me.Controls.Add(Me.pagotextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMontoaPagar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtasCtesPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CtasCtesPagar"
        Me.Text = "Pagar cuenta"
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByPagosaCCToolStrip.ResumeLayout(False)
        Me.FillByPagosaCCToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nrocomprobante As TextBox
    Friend WithEvents ComboTipoComprobante As ComboBox
    Friend WithEvents ComboFormapago As ComboBox
    Friend WithEvents pagotextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMontoaPagar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipocomprobantesBindingSource As BindingSource
    Friend WithEvents TipocomprobantesTableAdapter As comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ParametrosgeneralesTableAdapter1 As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents CajasmovimientosBindingSource As BindingSource
    Friend WithEvents CajasmovimientosTableAdapter As comercialDataSetTableAdapters.cajasmovimientosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents CajasoperacionesBindingSource As BindingSource
    Friend WithEvents CajasoperacionesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents FillByPagosaCCToolStrip As ToolStrip
    Friend WithEvents FillByPagosaCCToolStripButton As ToolStripButton
End Class

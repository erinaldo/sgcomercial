<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaDetallePagosRealizados
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
        Dim FechaventaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim TipocomprobanteLabel As System.Windows.Forms.Label
        Dim IdventaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.TipocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.IdventaTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.LibroventasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListapagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListapagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListapagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapagosTableAdapter()
        FechaventaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        TipocomprobanteLabel = New System.Windows.Forms.Label()
        IdventaLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListapagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaventaLabel
        '
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(194, 34)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(51, 17)
        FechaventaLabel.TabIndex = 1
        FechaventaLabel.Text = "Fecha:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(31, 75)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(415, 75)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(36, 17)
        CuitLabel.TabIndex = 5
        CuitLabel.Text = "Cuit:"
        '
        'TipocomprobanteLabel
        '
        TipocomprobanteLabel.AutoSize = True
        TipocomprobanteLabel.Location = New System.Drawing.Point(31, 117)
        TipocomprobanteLabel.Name = "TipocomprobanteLabel"
        TipocomprobanteLabel.Size = New System.Drawing.Size(97, 17)
        TipocomprobanteLabel.TabIndex = 7
        TipocomprobanteLabel.Text = "Comprobante:"
        '
        'IdventaLabel
        '
        IdventaLabel.AutoSize = True
        IdventaLabel.Location = New System.Drawing.Point(31, 34)
        IdventaLabel.Name = "IdventaLabel"
        IdventaLabel.Size = New System.Drawing.Size(27, 17)
        IdventaLabel.TabIndex = 9
        IdventaLabel.Text = "Nº:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(402, 117)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(59, 17)
        ImporteLabel.TabIndex = 11
        ImporteLabel.Text = "Importe:"
        '
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.FechaventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibroventasBindingSource, "fechaventa", True))
        Me.FechaventaDateTimePicker.Enabled = False
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(251, 31)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(210, 22)
        Me.FechaventaDateTimePicker.TabIndex = 2
        Me.FechaventaDateTimePicker.TabStop = False
        '
        'LibroventasBindingSource
        '
        Me.LibroventasBindingSource.DataMember = "libroventas"
        Me.LibroventasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(97, 72)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(298, 22)
        Me.NombreTextBox.TabIndex = 4
        Me.NombreTextBox.TabStop = False
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "cuit", True))
        Me.CuitTextBox.Enabled = False
        Me.CuitTextBox.Location = New System.Drawing.Point(457, 72)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CuitTextBox.TabIndex = 6
        Me.CuitTextBox.TabStop = False
        '
        'TipocomprobanteTextBox
        '
        Me.TipocomprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "tipocomprobante", True))
        Me.TipocomprobanteTextBox.Enabled = False
        Me.TipocomprobanteTextBox.Location = New System.Drawing.Point(134, 114)
        Me.TipocomprobanteTextBox.Name = "TipocomprobanteTextBox"
        Me.TipocomprobanteTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TipocomprobanteTextBox.TabIndex = 8
        Me.TipocomprobanteTextBox.TabStop = False
        '
        'IdventaTextBox
        '
        Me.IdventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "idventa", True))
        Me.IdventaTextBox.Enabled = False
        Me.IdventaTextBox.Location = New System.Drawing.Point(64, 31)
        Me.IdventaTextBox.Name = "IdventaTextBox"
        Me.IdventaTextBox.Size = New System.Drawing.Size(118, 22)
        Me.IdventaTextBox.TabIndex = 10
        Me.IdventaTextBox.TabStop = False
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "importe", True))
        Me.ImporteTextBox.Enabled = False
        Me.ImporteTextBox.Location = New System.Drawing.Point(467, 114)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(106, 22)
        Me.ImporteTextBox.TabIndex = 12
        Me.ImporteTextBox.TabStop = False
        '
        'LibroventasTableAdapter
        '
        Me.LibroventasTableAdapter.ClearBeforeFill = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdventaLabel)
        Me.GroupBox1.Controls.Add(FechaventaLabel)
        Me.GroupBox1.Controls.Add(Me.ImporteTextBox)
        Me.GroupBox1.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox1.Controls.Add(ImporteLabel)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.IdventaTextBox)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.TipocomprobanteTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(TipocomprobanteLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 154)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListapagosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 293)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pagos asociados"
        '
        'ListapagosDataGridView
        '
        Me.ListapagosDataGridView.AllowUserToAddRows = False
        Me.ListapagosDataGridView.AllowUserToDeleteRows = False
        Me.ListapagosDataGridView.AllowUserToResizeColumns = False
        Me.ListapagosDataGridView.AllowUserToResizeRows = False
        Me.ListapagosDataGridView.AutoGenerateColumns = False
        Me.ListapagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListapagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ListapagosDataGridView.DataSource = Me.ListapagosBindingSource
        Me.ListapagosDataGridView.Location = New System.Drawing.Point(15, 36)
        Me.ListapagosDataGridView.Name = "ListapagosDataGridView"
        Me.ListapagosDataGridView.ReadOnly = True
        Me.ListapagosDataGridView.RowTemplate.Height = 24
        Me.ListapagosDataGridView.Size = New System.Drawing.Size(782, 239)
        Me.ListapagosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Nº"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Importe"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nrocomprobante"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nº comprobante"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechapago"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Forma Pago"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 170
        '
        'ListapagosBindingSource
        '
        Me.ListapagosBindingSource.DataMember = "listapagos"
        Me.ListapagosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListapagosTableAdapter
        '
        Me.ListapagosTableAdapter.ClearBeforeFill = True
        '
        'VentaDetallePagosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 477)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentaDetallePagosRealizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de pagos asociados"
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListapagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents LibroventasBindingSource As BindingSource
    Friend WithEvents LibroventasTableAdapter As comercialDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FechaventaDateTimePicker As DateTimePicker
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents TipocomprobanteTextBox As TextBox
    Friend WithEvents IdventaTextBox As TextBox
    Friend WithEvents ImporteTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListapagosBindingSource As BindingSource
    Friend WithEvents ListapagosTableAdapter As comercialDataSetTableAdapters.listapagosTableAdapter
    Friend WithEvents ListapagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class

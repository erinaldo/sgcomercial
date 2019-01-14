<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cajasmovimientos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajasmovimientos))
        Me.ingresosGraphBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.v_gastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdeventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaperturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechacierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imprimircierre = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasmovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VgastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerfilesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.perfilesTableAdapter()
        Me.GastosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gastosTableAdapter()
        Me.CajasmovimientosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasmovimientosTableAdapter()
        Me.V_gastosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.v_gastosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ingresosGraphTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ingresosGraphTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ingresosGraphBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.v_gastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VgastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingresosGraphBindingSource
        '
        Me.ingresosGraphBindingSource.DataMember = "ingresosGraph"
        Me.ingresosGraphBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'v_gastosBindingSource
        '
        Me.v_gastosBindingSource.DataMember = "v_gastos"
        Me.v_gastosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 413)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eventos de Caja"
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(768, 104)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(72, 62)
        Me.CajasoperacionesDataGridView.TabIndex = 5
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
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(676, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Ver Estado Caja"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtrar por Fecha Apertura:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(529, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Limpiar Filtro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(392, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 24)
        Me.DateTimePicker1.TabIndex = 2
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AllowUserToAddRows = False
        Me.CajaseventosDataGridView.AllowUserToDeleteRows = False
        Me.CajaseventosDataGridView.AllowUserToResizeColumns = False
        Me.CajaseventosDataGridView.AllowUserToResizeRows = False
        Me.CajaseventosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdeventoDataGridViewTextBoxColumn, Me.idcaja, Me.FechaaperturaDataGridViewTextBoxColumn, Me.FechacierreDataGridViewTextBoxColumn, Me.SaldoinicialDataGridViewTextBoxColumn, Me.SaldofinalDataGridViewTextBoxColumn, Me.imprimircierre})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(6, 69)
        Me.CajaseventosDataGridView.MultiSelect = False
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.ReadOnly = True
        Me.CajaseventosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(808, 338)
        Me.CajaseventosDataGridView.TabIndex = 1
        '
        'IdeventoDataGridViewTextBoxColumn
        '
        Me.IdeventoDataGridViewTextBoxColumn.DataPropertyName = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn.HeaderText = "N° Evento"
        Me.IdeventoDataGridViewTextBoxColumn.Name = "IdeventoDataGridViewTextBoxColumn"
        Me.IdeventoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdeventoDataGridViewTextBoxColumn.Width = 104
        '
        'idcaja
        '
        Me.idcaja.DataPropertyName = "idcaja"
        Me.idcaja.HeaderText = "Caja"
        Me.idcaja.Name = "idcaja"
        Me.idcaja.ReadOnly = True
        Me.idcaja.Width = 67
        '
        'FechaaperturaDataGridViewTextBoxColumn
        '
        Me.FechaaperturaDataGridViewTextBoxColumn.DataPropertyName = "fechaapertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.HeaderText = "Apertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.Name = "FechaaperturaDataGridViewTextBoxColumn"
        Me.FechaaperturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaaperturaDataGridViewTextBoxColumn.Width = 92
        '
        'FechacierreDataGridViewTextBoxColumn
        '
        Me.FechacierreDataGridViewTextBoxColumn.DataPropertyName = "fechacierre"
        Me.FechacierreDataGridViewTextBoxColumn.HeaderText = "Cierre"
        Me.FechacierreDataGridViewTextBoxColumn.Name = "FechacierreDataGridViewTextBoxColumn"
        Me.FechacierreDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechacierreDataGridViewTextBoxColumn.Width = 77
        '
        'SaldoinicialDataGridViewTextBoxColumn
        '
        Me.SaldoinicialDataGridViewTextBoxColumn.DataPropertyName = "saldoinicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.HeaderText = "Saldo Inicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.Name = "SaldoinicialDataGridViewTextBoxColumn"
        Me.SaldoinicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoinicialDataGridViewTextBoxColumn.Width = 115
        '
        'SaldofinalDataGridViewTextBoxColumn
        '
        Me.SaldofinalDataGridViewTextBoxColumn.DataPropertyName = "saldofinal"
        Me.SaldofinalDataGridViewTextBoxColumn.HeaderText = "Saldo Final"
        Me.SaldofinalDataGridViewTextBoxColumn.Name = "SaldofinalDataGridViewTextBoxColumn"
        Me.SaldofinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldofinalDataGridViewTextBoxColumn.Width = 110
        '
        'imprimircierre
        '
        Me.imprimircierre.HeaderText = "Imprimir"
        Me.imprimircierre.Name = "imprimircierre"
        Me.imprimircierre.ReadOnly = True
        Me.imprimircierre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.imprimircierre.Text = "Imprimir"
        Me.imprimircierre.ToolTipText = "Imprimir Cierre"
        Me.imprimircierre.UseColumnTextForButtonValue = True
        Me.imprimircierre.Width = 67
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasmovimientosBindingSource
        '
        Me.CajasmovimientosBindingSource.DataMember = "cajasmovimientos"
        Me.CajasmovimientosBindingSource.DataSource = Me.ComercialDataSet
        '
        'VgastosBindingSource
        '
        Me.VgastosBindingSource.DataMember = "v_gastos"
        Me.VgastosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GastosBindingSource
        '
        Me.GastosBindingSource.DataMember = "gastos"
        Me.GastosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'PerfilesBindingSource
        '
        Me.PerfilesBindingSource.DataMember = "perfiles"
        Me.PerfilesBindingSource.DataSource = Me.ComercialDataSet
        '
        'PerfilesTableAdapter
        '
        Me.PerfilesTableAdapter.ClearBeforeFill = True
        '
        'GastosTableAdapter
        '
        Me.GastosTableAdapter.ClearBeforeFill = True
        '
        'CajasmovimientosTableAdapter
        '
        Me.CajasmovimientosTableAdapter.ClearBeforeFill = True
        '
        'V_gastosTableAdapter
        '
        Me.V_gastosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Me.CajaseventosTableAdapter
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
        Me.TableAdapterManager.gastosTableAdapter = Me.GastosTableAdapter
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
        Me.TableAdapterManager.perfilesTableAdapter = Me.PerfilesTableAdapter
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
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "ingresosgraph"
        ReportDataSource1.Value = Me.ingresosGraphBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphIngresos.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(836, 23)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ShowToolBar = False
        Me.ReportViewer2.Size = New System.Drawing.Size(305, 403)
        Me.ReportViewer2.TabIndex = 6
        '
        'ingresosGraphTableAdapter
        '
        Me.ingresosGraphTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(1154, 391)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 35)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Detalle Egresos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "v_gastos"
        ReportDataSource2.Value = Me.v_gastosBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphEgresos.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(1154, 23)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ShowToolBar = False
        Me.ReportViewer3.Size = New System.Drawing.Size(305, 403)
        Me.ReportViewer3.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(836, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 35)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Detalle Ingresos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cajasmovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 434)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Cajasmovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de Caja"
        CType(Me.ingresosGraphBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.v_gastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VgastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CajaseventosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents CajaseventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajaseventosTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents PerfilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PerfilesTableAdapter As sgcomercial.comercialDataSetTableAdapters.perfilesTableAdapter
    Friend WithEvents GastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastosTableAdapter As sgcomercial.comercialDataSetTableAdapters.gastosTableAdapter
    Friend WithEvents CajasmovimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasmovimientosTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasmovimientosTableAdapter
    Friend WithEvents VgastosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_gastosTableAdapter As sgcomercial.comercialDataSetTableAdapters.v_gastosTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajasoperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasoperacionesTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents CajasoperacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdeventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idcaja As DataGridViewTextBoxColumn
    Friend WithEvents FechaaperturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechacierreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoinicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldofinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents imprimircierre As DataGridViewButtonColumn
    Friend WithEvents ReportViewer2 As ReportViewer
    Friend WithEvents ingresosGraphBindingSource As BindingSource
    Friend WithEvents ingresosGraphTableAdapter As comercialDataSetTableAdapters.ingresosGraphTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents ReportViewer3 As ReportViewer
    Friend WithEvents v_gastosBindingSource As BindingSource
    Friend WithEvents Button3 As Button
End Class

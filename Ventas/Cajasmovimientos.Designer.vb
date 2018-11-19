<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajasmovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajasmovimientos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MovimientoscajasDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblgastos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.V_gastosDataGridView = New System.Windows.Forms.DataGridView()
        Me.idevento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anulargasto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VgastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CajasmovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerfilesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.perfilesTableAdapter()
        Me.GastosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gastosTableAdapter()
        Me.CajasmovimientosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasmovimientosTableAdapter()
        Me.V_gastosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.v_gastosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.IdeventoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anular = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.idoperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdeventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaperturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechacierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imprimircierre = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MovimientoscajasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.V_gastosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VgastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1095, 312)
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
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdeventoDataGridViewTextBoxColumn, Me.idcaja, Me.FechaaperturaDataGridViewTextBoxColumn, Me.FechacierreDataGridViewTextBoxColumn, Me.SaldoinicialDataGridViewTextBoxColumn, Me.SaldofinalDataGridViewTextBoxColumn, Me.imprimircierre})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(6, 69)
        Me.CajaseventosDataGridView.MultiSelect = False
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.ReadOnly = True
        Me.CajaseventosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(987, 237)
        Me.CajaseventosDataGridView.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.MovimientoscajasDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1100, 207)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbltotal.Location = New System.Drawing.Point(963, 113)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(84, 25)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "TOTAL"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(927, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Ingresos:"
        '
        'MovimientoscajasDataGridView
        '
        Me.MovimientoscajasDataGridView.AllowUserToAddRows = False
        Me.MovimientoscajasDataGridView.AllowUserToDeleteRows = False
        Me.MovimientoscajasDataGridView.AllowUserToResizeColumns = False
        Me.MovimientoscajasDataGridView.AllowUserToResizeRows = False
        Me.MovimientoscajasDataGridView.AutoGenerateColumns = False
        Me.MovimientoscajasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovimientoscajasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdeventoDataGridViewTextBoxColumn1, Me.idventa, Me.idpagos, Me.idcliente, Me.nombre, Me.monto, Me.anular, Me.idoperacion})
        Me.MovimientoscajasDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MovimientoscajasDataGridView.DataSource = Me.CajasmovimientosBindingSource
        Me.MovimientoscajasDataGridView.Location = New System.Drawing.Point(18, 25)
        Me.MovimientoscajasDataGridView.MultiSelect = False
        Me.MovimientoscajasDataGridView.Name = "MovimientoscajasDataGridView"
        Me.MovimientoscajasDataGridView.ReadOnly = True
        Me.MovimientoscajasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MovimientoscajasDataGridView.Size = New System.Drawing.Size(886, 173)
        Me.MovimientoscajasDataGridView.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblgastos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.V_gastosDataGridView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 535)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1100, 207)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Egresos"
        '
        'lblgastos
        '
        Me.lblgastos.AutoSize = True
        Me.lblgastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgastos.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblgastos.Location = New System.Drawing.Point(963, 118)
        Me.lblgastos.Name = "lblgastos"
        Me.lblgastos.Size = New System.Drawing.Size(84, 25)
        Me.lblgastos.TabIndex = 3
        Me.lblgastos.Text = "TOTAL"
        Me.lblgastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(927, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Egresos:"
        '
        'V_gastosDataGridView
        '
        Me.V_gastosDataGridView.AllowUserToAddRows = False
        Me.V_gastosDataGridView.AllowUserToDeleteRows = False
        Me.V_gastosDataGridView.AllowUserToResizeColumns = False
        Me.V_gastosDataGridView.AllowUserToResizeRows = False
        Me.V_gastosDataGridView.AutoGenerateColumns = False
        Me.V_gastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.V_gastosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idevento, Me.DataGridViewTextBoxColumn7, Me.DescripcionDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.anulargasto})
        Me.V_gastosDataGridView.DataSource = Me.VgastosBindingSource
        Me.V_gastosDataGridView.Location = New System.Drawing.Point(18, 28)
        Me.V_gastosDataGridView.MultiSelect = False
        Me.V_gastosDataGridView.Name = "V_gastosDataGridView"
        Me.V_gastosDataGridView.ReadOnly = True
        Me.V_gastosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.V_gastosDataGridView.Size = New System.Drawing.Size(886, 164)
        Me.V_gastosDataGridView.TabIndex = 0
        '
        'idevento
        '
        Me.idevento.DataPropertyName = "idevento"
        Me.idevento.HeaderText = "idevento"
        Me.idevento.Name = "idevento"
        Me.idevento.ReadOnly = True
        Me.idevento.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idoperacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idoperacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'anulargasto
        '
        Me.anulargasto.HeaderText = "Anular"
        Me.anulargasto.Name = "anulargasto"
        Me.anulargasto.ReadOnly = True
        Me.anulargasto.Text = "Anular"
        Me.anulargasto.ToolTipText = "Anular"
        Me.anulargasto.UseColumnTextForButtonValue = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 350
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VgastosBindingSource
        '
        Me.VgastosBindingSource.DataMember = "v_gastos"
        Me.VgastosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajasmovimientosBindingSource
        '
        Me.CajasmovimientosBindingSource.DataMember = "cajasmovimientos"
        Me.CajasmovimientosBindingSource.DataSource = Me.ComercialDataSet
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
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
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
        'IdeventoDataGridViewTextBoxColumn1
        '
        Me.IdeventoDataGridViewTextBoxColumn1.DataPropertyName = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn1.HeaderText = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn1.Name = "IdeventoDataGridViewTextBoxColumn1"
        Me.IdeventoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdeventoDataGridViewTextBoxColumn1.Visible = False
        '
        'idventa
        '
        Me.idventa.DataPropertyName = "idventa"
        Me.idventa.HeaderText = "Vta. N°"
        Me.idventa.Name = "idventa"
        Me.idventa.ReadOnly = True
        Me.idventa.ToolTipText = "Vta. N°"
        Me.idventa.Width = 70
        '
        'idpagos
        '
        Me.idpagos.DataPropertyName = "idpagos"
        Me.idpagos.HeaderText = "idpagos"
        Me.idpagos.Name = "idpagos"
        Me.idpagos.ReadOnly = True
        Me.idpagos.Visible = False
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre/Razón Social"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 350
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'anular
        '
        Me.anular.HeaderText = "Anular"
        Me.anular.Name = "anular"
        Me.anular.ReadOnly = True
        Me.anular.Text = "Anular"
        Me.anular.ToolTipText = "Anular Operación"
        Me.anular.UseColumnTextForButtonValue = True
        '
        'idoperacion
        '
        Me.idoperacion.DataPropertyName = "idoperacion"
        Me.idoperacion.HeaderText = "idoperacion"
        Me.idoperacion.Name = "idoperacion"
        Me.idoperacion.ReadOnly = True
        Me.idoperacion.Visible = False
        '
        'IdeventoDataGridViewTextBoxColumn
        '
        Me.IdeventoDataGridViewTextBoxColumn.DataPropertyName = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn.HeaderText = "N° Evento"
        Me.IdeventoDataGridViewTextBoxColumn.Name = "IdeventoDataGridViewTextBoxColumn"
        Me.IdeventoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'idcaja
        '
        Me.idcaja.DataPropertyName = "idcaja"
        Me.idcaja.HeaderText = "Caja"
        Me.idcaja.Name = "idcaja"
        Me.idcaja.ReadOnly = True
        '
        'FechaaperturaDataGridViewTextBoxColumn
        '
        Me.FechaaperturaDataGridViewTextBoxColumn.DataPropertyName = "fechaapertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.HeaderText = "Apertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.Name = "FechaaperturaDataGridViewTextBoxColumn"
        Me.FechaaperturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechacierreDataGridViewTextBoxColumn
        '
        Me.FechacierreDataGridViewTextBoxColumn.DataPropertyName = "fechacierre"
        Me.FechacierreDataGridViewTextBoxColumn.HeaderText = "Cierre"
        Me.FechacierreDataGridViewTextBoxColumn.Name = "FechacierreDataGridViewTextBoxColumn"
        Me.FechacierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoinicialDataGridViewTextBoxColumn
        '
        Me.SaldoinicialDataGridViewTextBoxColumn.DataPropertyName = "saldoinicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.HeaderText = "Saldo Inicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.Name = "SaldoinicialDataGridViewTextBoxColumn"
        Me.SaldoinicialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldofinalDataGridViewTextBoxColumn
        '
        Me.SaldofinalDataGridViewTextBoxColumn.DataPropertyName = "saldofinal"
        Me.SaldofinalDataGridViewTextBoxColumn.HeaderText = "Saldo Final"
        Me.SaldofinalDataGridViewTextBoxColumn.Name = "SaldofinalDataGridViewTextBoxColumn"
        Me.SaldofinalDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'Cajasmovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 752)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cajasmovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MovimientoscajasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.V_gastosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VgastosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasmovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MovimientoscajasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblgastos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents V_gastosDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents idevento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents anulargasto As DataGridViewButtonColumn
    Friend WithEvents IdeventoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents idventa As DataGridViewTextBoxColumn
    Friend WithEvents idpagos As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents anular As DataGridViewButtonColumn
    Friend WithEvents idoperacion As DataGridViewTextBoxColumn
    Friend WithEvents IdeventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idcaja As DataGridViewTextBoxColumn
    Friend WithEvents FechaaperturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechacierreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoinicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldofinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents imprimircierre As DataGridViewButtonColumn
End Class

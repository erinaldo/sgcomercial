<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajaArqueoFinal
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
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioaccesoDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numEgresos = New System.Windows.Forms.NumericUpDown()
        Me.numIngresos = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericDevolucionef = New System.Windows.Forms.NumericUpDown()
        Me.Numericextracciones = New System.Windows.Forms.NumericUpDown()
        Me.NumericGastos = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericdepositosEF = New System.Windows.Forms.NumericUpDown()
        Me.Numericdepositos = New System.Windows.Forms.NumericUpDown()
        Me.Numericcheques = New System.Windows.Forms.NumericUpDown()
        Me.Numerictransferencias = New System.Windows.Forms.NumericUpDown()
        Me.Numericcreditos = New System.Windows.Forms.NumericUpDown()
        Me.Numericdebitos = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Enteros = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NumericEfectivoEnCaja = New System.Windows.Forms.NumericUpDown()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioaccesoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericDevolucionef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numericextracciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericdepositosEF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numericdepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numericcheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numerictransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numericcreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numericdebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericEfectivoEnCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(0, -1)
        Me.CajasoperacionesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(213, 34)
        Me.CajasoperacionesDataGridView.TabIndex = 10
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idformapago"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idformapago"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idgastos"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idgastos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.BioaccesoDataSet
        '
        'BioaccesoDataSet
        '
        Me.BioaccesoDataSet.DataSetName = "bioaccesoDataSet"
        Me.BioaccesoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.NumericEfectivoEnCaja)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.numEgresos)
        Me.GroupBox1.Controls.Add(Me.numIngresos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.NumericDevolucionef)
        Me.GroupBox1.Controls.Add(Me.Numericextracciones)
        Me.GroupBox1.Controls.Add(Me.NumericGastos)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.NumericdepositosEF)
        Me.GroupBox1.Controls.Add(Me.Numericdepositos)
        Me.GroupBox1.Controls.Add(Me.Numericcheques)
        Me.GroupBox1.Controls.Add(Me.Numerictransferencias)
        Me.GroupBox1.Controls.Add(Me.Numericcreditos)
        Me.GroupBox1.Controls.Add(Me.Numericdebitos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Enteros)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(702, 393)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(197, 415)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 30)
        Me.NumericUpDown1.TabIndex = 34
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(51, 422)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Monto Inicial:"
        Me.Label4.Visible = False
        '
        'numEgresos
        '
        Me.numEgresos.DecimalPlaces = 2
        Me.numEgresos.Enabled = False
        Me.numEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numEgresos.Location = New System.Drawing.Point(527, 395)
        Me.numEgresos.Margin = New System.Windows.Forms.Padding(4)
        Me.numEgresos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.numEgresos.Name = "numEgresos"
        Me.numEgresos.ReadOnly = True
        Me.numEgresos.Size = New System.Drawing.Size(160, 30)
        Me.numEgresos.TabIndex = 36
        Me.numEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numEgresos.Visible = False
        '
        'numIngresos
        '
        Me.numIngresos.DecimalPlaces = 2
        Me.numIngresos.Enabled = False
        Me.numIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numIngresos.Location = New System.Drawing.Point(527, 347)
        Me.numIngresos.Margin = New System.Windows.Forms.Padding(4)
        Me.numIngresos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.numIngresos.Name = "numIngresos"
        Me.numIngresos.ReadOnly = True
        Me.numIngresos.Size = New System.Drawing.Size(160, 30)
        Me.numIngresos.TabIndex = 35
        Me.numIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numIngresos.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(422, 397)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Egresos:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(422, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Ingresos:"
        Me.Label2.Visible = False
        '
        'Label14
        '
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(364, 135)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 86)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Devolución Efvo. por Cambio:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(421, 98)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Extracciones:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(466, 61)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 18)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Gastos:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericDevolucionef
        '
        Me.NumericDevolucionef.DecimalPlaces = 2
        Me.NumericDevolucionef.Enabled = False
        Me.NumericDevolucionef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericDevolucionef.Location = New System.Drawing.Point(544, 130)
        Me.NumericDevolucionef.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericDevolucionef.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NumericDevolucionef.Name = "NumericDevolucionef"
        Me.NumericDevolucionef.Size = New System.Drawing.Size(136, 30)
        Me.NumericDevolucionef.TabIndex = 9
        Me.NumericDevolucionef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericDevolucionef.ThousandsSeparator = True
        '
        'Numericextracciones
        '
        Me.Numericextracciones.DecimalPlaces = 2
        Me.Numericextracciones.Enabled = False
        Me.Numericextracciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numericextracciones.Location = New System.Drawing.Point(544, 93)
        Me.Numericextracciones.Margin = New System.Windows.Forms.Padding(4)
        Me.Numericextracciones.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numericextracciones.Name = "Numericextracciones"
        Me.Numericextracciones.Size = New System.Drawing.Size(136, 30)
        Me.Numericextracciones.TabIndex = 8
        Me.Numericextracciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numericextracciones.ThousandsSeparator = True
        '
        'NumericGastos
        '
        Me.NumericGastos.DecimalPlaces = 2
        Me.NumericGastos.Enabled = False
        Me.NumericGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericGastos.Location = New System.Drawing.Point(544, 56)
        Me.NumericGastos.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericGastos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NumericGastos.Name = "NumericGastos"
        Me.NumericGastos.Size = New System.Drawing.Size(136, 30)
        Me.NumericGastos.TabIndex = 7
        Me.NumericGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericGastos.ThousandsSeparator = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(562, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "EGRESOS"
        '
        'NumericdepositosEF
        '
        Me.NumericdepositosEF.DecimalPlaces = 2
        Me.NumericdepositosEF.Enabled = False
        Me.NumericdepositosEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericdepositosEF.Location = New System.Drawing.Point(204, 308)
        Me.NumericdepositosEF.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericdepositosEF.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NumericdepositosEF.Name = "NumericdepositosEF"
        Me.NumericdepositosEF.Size = New System.Drawing.Size(136, 30)
        Me.NumericdepositosEF.TabIndex = 6
        Me.NumericdepositosEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericdepositosEF.ThousandsSeparator = True
        '
        'Numericdepositos
        '
        Me.Numericdepositos.DecimalPlaces = 2
        Me.Numericdepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numericdepositos.Location = New System.Drawing.Point(204, 266)
        Me.Numericdepositos.Margin = New System.Windows.Forms.Padding(4)
        Me.Numericdepositos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numericdepositos.Name = "Numericdepositos"
        Me.Numericdepositos.Size = New System.Drawing.Size(136, 30)
        Me.Numericdepositos.TabIndex = 5
        Me.Numericdepositos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numericdepositos.ThousandsSeparator = True
        '
        'Numericcheques
        '
        Me.Numericcheques.DecimalPlaces = 2
        Me.Numericcheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numericcheques.Location = New System.Drawing.Point(204, 224)
        Me.Numericcheques.Margin = New System.Windows.Forms.Padding(4)
        Me.Numericcheques.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numericcheques.Name = "Numericcheques"
        Me.Numericcheques.Size = New System.Drawing.Size(136, 30)
        Me.Numericcheques.TabIndex = 4
        Me.Numericcheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numericcheques.ThousandsSeparator = True
        '
        'Numerictransferencias
        '
        Me.Numerictransferencias.DecimalPlaces = 2
        Me.Numerictransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numerictransferencias.Location = New System.Drawing.Point(204, 182)
        Me.Numerictransferencias.Margin = New System.Windows.Forms.Padding(4)
        Me.Numerictransferencias.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numerictransferencias.Name = "Numerictransferencias"
        Me.Numerictransferencias.Size = New System.Drawing.Size(136, 30)
        Me.Numerictransferencias.TabIndex = 3
        Me.Numerictransferencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numerictransferencias.ThousandsSeparator = True
        '
        'Numericcreditos
        '
        Me.Numericcreditos.DecimalPlaces = 2
        Me.Numericcreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numericcreditos.Location = New System.Drawing.Point(204, 140)
        Me.Numericcreditos.Margin = New System.Windows.Forms.Padding(4)
        Me.Numericcreditos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numericcreditos.Name = "Numericcreditos"
        Me.Numericcreditos.Size = New System.Drawing.Size(136, 30)
        Me.Numericcreditos.TabIndex = 2
        Me.Numericcreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numericcreditos.ThousandsSeparator = True
        '
        'Numericdebitos
        '
        Me.Numericdebitos.DecimalPlaces = 2
        Me.Numericdebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Numericdebitos.Location = New System.Drawing.Point(204, 98)
        Me.Numericdebitos.Margin = New System.Windows.Forms.Padding(4)
        Me.Numericdebitos.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Numericdebitos.Name = "Numericdebitos"
        Me.Numericdebitos.Size = New System.Drawing.Size(136, 30)
        Me.Numericdebitos.TabIndex = 1
        Me.Numericdebitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Numericdebitos.ThousandsSeparator = True
        '
        'Label15
        '
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(9, 296)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(176, 64)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Depósitos (Efvo. en CAJA):"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Enteros
        '
        Me.Enteros.DecimalPlaces = 2
        Me.Enteros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Enteros.Location = New System.Drawing.Point(204, 56)
        Me.Enteros.Margin = New System.Windows.Forms.Padding(4)
        Me.Enteros.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Enteros.Name = "Enteros"
        Me.Enteros.Size = New System.Drawing.Size(136, 30)
        Me.Enteros.TabIndex = 0
        Me.Enteros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Enteros.ThousandsSeparator = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(20, 271)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Depósitos (Pagos):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(95, 229)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cheques:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(53, 187)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Transferencias:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(107, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Crédito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(113, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Débito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(213, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "INGRESOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(33, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Efectivo en caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(533, 285)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(395, 285)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(203, -14)
        Me.CajaseventosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(152, 32)
        Me.CajaseventosDataGridView.TabIndex = 13
        Me.CajaseventosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idcaja"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idcaja"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechaapertura"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechaapertura"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "saldoinicial"
        Me.DataGridViewTextBoxColumn11.HeaderText = "saldoinicial"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "saldofinal"
        Me.DataGridViewTextBoxColumn12.HeaderText = "saldofinal"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.BioaccesoDataSet
        '
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Me.CajasoperacionesTableAdapter
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
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(375, 210)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 71)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Deja Efectivo en CAJA:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericEfectivoEnCaja
        '
        Me.NumericEfectivoEnCaja.DecimalPlaces = 2
        Me.NumericEfectivoEnCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericEfectivoEnCaja.Location = New System.Drawing.Point(544, 230)
        Me.NumericEfectivoEnCaja.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericEfectivoEnCaja.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.NumericEfectivoEnCaja.Name = "NumericEfectivoEnCaja"
        Me.NumericEfectivoEnCaja.Size = New System.Drawing.Size(136, 30)
        Me.NumericEfectivoEnCaja.TabIndex = 38
        Me.NumericEfectivoEnCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericEfectivoEnCaja.ThousandsSeparator = True
        '
        'CajaArqueoFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 418)
        Me.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CajaArqueoFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arqueo de Cierre"
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioaccesoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericDevolucionef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numericextracciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericdepositosEF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numericdepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numericcheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numerictransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numericcreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numericdebitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericEfectivoEnCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BioaccesoDataSet As comercialDataSet
    Friend WithEvents CajasoperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajasoperacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CajaseventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents CajaseventosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enteros As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Numericdepositos As NumericUpDown
    Friend WithEvents Numericcheques As NumericUpDown
    Friend WithEvents Numerictransferencias As NumericUpDown
    Friend WithEvents Numericcreditos As NumericUpDown
    Friend WithEvents Numericdebitos As NumericUpDown
    Friend WithEvents NumericGastos As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericDevolucionef As NumericUpDown
    Friend WithEvents Numericextracciones As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numEgresos As NumericUpDown
    Friend WithEvents numIngresos As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericdepositosEF As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents NumericEfectivoEnCaja As NumericUpDown
    Friend WithEvents Label16 As Label
End Class

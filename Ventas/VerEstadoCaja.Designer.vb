<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerEstadoCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerEstadoCaja))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numEgresos = New System.Windows.Forms.NumericUpDown()
        Me.numIngresos = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CajasoperacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdoperacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdeventoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpagosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdgastosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdformapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechabajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariobajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Enteros = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdeventoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaperturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechacierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoinicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioaperturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariocierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasoperacionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(198, 80)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 30)
        Me.NumericUpDown1.TabIndex = 25
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(54, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Monto Inicial:"
        '
        'numEgresos
        '
        Me.numEgresos.DecimalPlaces = 2
        Me.numEgresos.Enabled = False
        Me.numEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numEgresos.Location = New System.Drawing.Point(198, 156)
        Me.numEgresos.Margin = New System.Windows.Forms.Padding(4)
        Me.numEgresos.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numEgresos.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.numEgresos.Name = "numEgresos"
        Me.numEgresos.ReadOnly = True
        Me.numEgresos.Size = New System.Drawing.Size(160, 30)
        Me.numEgresos.TabIndex = 27
        Me.numEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numIngresos
        '
        Me.numIngresos.DecimalPlaces = 2
        Me.numIngresos.Enabled = False
        Me.numIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.numIngresos.Location = New System.Drawing.Point(198, 118)
        Me.numIngresos.Margin = New System.Windows.Forms.Padding(4)
        Me.numIngresos.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numIngresos.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.numIngresos.Name = "numIngresos"
        Me.numIngresos.ReadOnly = True
        Me.numIngresos.Size = New System.Drawing.Size(160, 30)
        Me.numIngresos.TabIndex = 26
        Me.numIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(91, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Gastos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(88, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Ingresos:"
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdoperacionDataGridViewTextBoxColumn, Me.IdeventoDataGridViewTextBoxColumn, Me.IdpagosDataGridViewTextBoxColumn, Me.IdgastosDataGridViewTextBoxColumn, Me.IdformapagoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.UsuarioaltaDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.UsuariobajaDataGridViewTextBoxColumn})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(8, 264)
        Me.CajasoperacionesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajasoperacionesDataGridView.Name = "CajasoperacionesDataGridView"
        Me.CajasoperacionesDataGridView.Size = New System.Drawing.Size(44, 28)
        Me.CajasoperacionesDataGridView.TabIndex = 20
        Me.CajasoperacionesDataGridView.Visible = False
        '
        'IdoperacionDataGridViewTextBoxColumn
        '
        Me.IdoperacionDataGridViewTextBoxColumn.DataPropertyName = "idoperacion"
        Me.IdoperacionDataGridViewTextBoxColumn.HeaderText = "idoperacion"
        Me.IdoperacionDataGridViewTextBoxColumn.Name = "IdoperacionDataGridViewTextBoxColumn"
        Me.IdoperacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdeventoDataGridViewTextBoxColumn
        '
        Me.IdeventoDataGridViewTextBoxColumn.DataPropertyName = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn.HeaderText = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn.Name = "IdeventoDataGridViewTextBoxColumn"
        '
        'IdpagosDataGridViewTextBoxColumn
        '
        Me.IdpagosDataGridViewTextBoxColumn.DataPropertyName = "idpagos"
        Me.IdpagosDataGridViewTextBoxColumn.HeaderText = "idpagos"
        Me.IdpagosDataGridViewTextBoxColumn.Name = "IdpagosDataGridViewTextBoxColumn"
        '
        'IdgastosDataGridViewTextBoxColumn
        '
        Me.IdgastosDataGridViewTextBoxColumn.DataPropertyName = "idgastos"
        Me.IdgastosDataGridViewTextBoxColumn.HeaderText = "idgastos"
        Me.IdgastosDataGridViewTextBoxColumn.Name = "IdgastosDataGridViewTextBoxColumn"
        '
        'IdformapagoDataGridViewTextBoxColumn
        '
        Me.IdformapagoDataGridViewTextBoxColumn.DataPropertyName = "idformapago"
        Me.IdformapagoDataGridViewTextBoxColumn.HeaderText = "idformapago"
        Me.IdformapagoDataGridViewTextBoxColumn.Name = "IdformapagoDataGridViewTextBoxColumn"
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'FechabajaDataGridViewTextBoxColumn
        '
        Me.FechabajaDataGridViewTextBoxColumn.DataPropertyName = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.HeaderText = "fechabaja"
        Me.FechabajaDataGridViewTextBoxColumn.Name = "FechabajaDataGridViewTextBoxColumn"
        '
        'UsuarioaltaDataGridViewTextBoxColumn
        '
        Me.UsuarioaltaDataGridViewTextBoxColumn.DataPropertyName = "usuarioalta"
        Me.UsuarioaltaDataGridViewTextBoxColumn.HeaderText = "usuarioalta"
        Me.UsuarioaltaDataGridViewTextBoxColumn.Name = "UsuarioaltaDataGridViewTextBoxColumn"
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "fechaalta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        '
        'UsuariobajaDataGridViewTextBoxColumn
        '
        Me.UsuariobajaDataGridViewTextBoxColumn.DataPropertyName = "usuariobaja"
        Me.UsuariobajaDataGridViewTextBoxColumn.HeaderText = "usuariobaja"
        Me.UsuariobajaDataGridViewTextBoxColumn.Name = "UsuariobajaDataGridViewTextBoxColumn"
        '
        'CajasoperacionesBindingSource
        '
        Me.CajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.CajasoperacionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Enteros)
        Me.GroupBox1.Controls.Add(Me.numEgresos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numIngresos)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 320)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen de Caja"
        '
        'Enteros
        '
        Me.Enteros.DecimalPlaces = 2
        Me.Enteros.Enabled = False
        Me.Enteros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Enteros.Location = New System.Drawing.Point(198, 211)
        Me.Enteros.Margin = New System.Windows.Forms.Padding(4)
        Me.Enteros.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Enteros.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.Enteros.Name = "Enteros"
        Me.Enteros.ReadOnly = True
        Me.Enteros.Size = New System.Drawing.Size(160, 30)
        Me.Enteros.TabIndex = 17
        Me.Enteros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Enteros.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(61, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Monto Final:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(210, 264)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 36)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(72, 264)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 36)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdeventoDataGridViewTextBoxColumn1, Me.IdcajaDataGridViewTextBoxColumn, Me.FechaaperturaDataGridViewTextBoxColumn, Me.FechacierreDataGridViewTextBoxColumn, Me.SaldoinicialDataGridViewTextBoxColumn, Me.SaldofinalDataGridViewTextBoxColumn, Me.UsuarioaperturaDataGridViewTextBoxColumn, Me.UsuariocierreDataGridViewTextBoxColumn})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(203, -14)
        Me.CajaseventosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(152, 32)
        Me.CajaseventosDataGridView.TabIndex = 13
        Me.CajaseventosDataGridView.Visible = False
        '
        'IdeventoDataGridViewTextBoxColumn1
        '
        Me.IdeventoDataGridViewTextBoxColumn1.DataPropertyName = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn1.HeaderText = "idevento"
        Me.IdeventoDataGridViewTextBoxColumn1.Name = "IdeventoDataGridViewTextBoxColumn1"
        Me.IdeventoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IdcajaDataGridViewTextBoxColumn
        '
        Me.IdcajaDataGridViewTextBoxColumn.DataPropertyName = "idcaja"
        Me.IdcajaDataGridViewTextBoxColumn.HeaderText = "idcaja"
        Me.IdcajaDataGridViewTextBoxColumn.Name = "IdcajaDataGridViewTextBoxColumn"
        '
        'FechaaperturaDataGridViewTextBoxColumn
        '
        Me.FechaaperturaDataGridViewTextBoxColumn.DataPropertyName = "fechaapertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.HeaderText = "fechaapertura"
        Me.FechaaperturaDataGridViewTextBoxColumn.Name = "FechaaperturaDataGridViewTextBoxColumn"
        '
        'FechacierreDataGridViewTextBoxColumn
        '
        Me.FechacierreDataGridViewTextBoxColumn.DataPropertyName = "fechacierre"
        Me.FechacierreDataGridViewTextBoxColumn.HeaderText = "fechacierre"
        Me.FechacierreDataGridViewTextBoxColumn.Name = "FechacierreDataGridViewTextBoxColumn"
        '
        'SaldoinicialDataGridViewTextBoxColumn
        '
        Me.SaldoinicialDataGridViewTextBoxColumn.DataPropertyName = "saldoinicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.HeaderText = "saldoinicial"
        Me.SaldoinicialDataGridViewTextBoxColumn.Name = "SaldoinicialDataGridViewTextBoxColumn"
        '
        'SaldofinalDataGridViewTextBoxColumn
        '
        Me.SaldofinalDataGridViewTextBoxColumn.DataPropertyName = "saldofinal"
        Me.SaldofinalDataGridViewTextBoxColumn.HeaderText = "saldofinal"
        Me.SaldofinalDataGridViewTextBoxColumn.Name = "SaldofinalDataGridViewTextBoxColumn"
        '
        'UsuarioaperturaDataGridViewTextBoxColumn
        '
        Me.UsuarioaperturaDataGridViewTextBoxColumn.DataPropertyName = "usuarioapertura"
        Me.UsuarioaperturaDataGridViewTextBoxColumn.HeaderText = "usuarioapertura"
        Me.UsuarioaperturaDataGridViewTextBoxColumn.Name = "UsuarioaperturaDataGridViewTextBoxColumn"
        '
        'UsuariocierreDataGridViewTextBoxColumn
        '
        Me.UsuariocierreDataGridViewTextBoxColumn.DataPropertyName = "usuariocierre"
        Me.UsuariocierreDataGridViewTextBoxColumn.HeaderText = "usuariocierre"
        Me.UsuariocierreDataGridViewTextBoxColumn.Name = "UsuariocierreDataGridViewTextBoxColumn"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasoperacionesTableAdapter
        '
        Me.CajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'VerEstadoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 351)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerEstadoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Actual de Caja"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numEgresos As NumericUpDown
    Friend WithEvents numIngresos As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CajasoperacionesDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Enteros As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CajaseventosDataGridView As DataGridView
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents CajasoperacionesBindingSource As BindingSource
    Friend WithEvents CajasoperacionesTableAdapter As comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents IdoperacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdeventoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpagosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdgastosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdformapagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechabajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuariobajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CajaseventosBindingSource As BindingSource
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents IdeventoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdcajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaaperturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechacierreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoinicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldofinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioaperturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuariocierreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

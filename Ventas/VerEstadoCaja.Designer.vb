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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerEstadoCaja))
        Me.cajaresumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.cajaresumenTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaresumenTableAdapter()
        CType(Me.cajaresumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cajaresumenBindingSource
        '
        Me.cajaresumenBindingSource.DataMember = "cajaresumen"
        Me.cajaresumenBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajasoperacionesDataGridView
        '
        Me.CajasoperacionesDataGridView.AutoGenerateColumns = False
        Me.CajasoperacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasoperacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdoperacionDataGridViewTextBoxColumn, Me.IdeventoDataGridViewTextBoxColumn, Me.IdpagosDataGridViewTextBoxColumn, Me.IdgastosDataGridViewTextBoxColumn, Me.IdformapagoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.FechabajaDataGridViewTextBoxColumn, Me.UsuarioaltaDataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn, Me.UsuariobajaDataGridViewTextBoxColumn})
        Me.CajasoperacionesDataGridView.DataSource = Me.CajasoperacionesBindingSource
        Me.CajasoperacionesDataGridView.Location = New System.Drawing.Point(182, 396)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Controls.Add(Me.CajasoperacionesDataGridView)
        Me.GroupBox1.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1304, 455)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen de Caja"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "cajaresumen"
        ReportDataSource1.Value = Me.cajaresumenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepCajaResumen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1296, 424)
        Me.ReportViewer1.TabIndex = 21
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdeventoDataGridViewTextBoxColumn1, Me.IdcajaDataGridViewTextBoxColumn, Me.FechaaperturaDataGridViewTextBoxColumn, Me.FechacierreDataGridViewTextBoxColumn, Me.SaldoinicialDataGridViewTextBoxColumn, Me.SaldofinalDataGridViewTextBoxColumn, Me.UsuarioaperturaDataGridViewTextBoxColumn, Me.UsuariocierreDataGridViewTextBoxColumn})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(8, 396)
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
        'cajaresumenTableAdapter
        '
        Me.cajaresumenTableAdapter.ClearBeforeFill = True
        '
        'VerEstadoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 481)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerEstadoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Actual de Caja"
        CType(Me.cajaresumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CajasoperacionesDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents cajaresumenBindingSource As BindingSource
    Friend WithEvents cajaresumenTableAdapter As comercialDataSetTableAdapters.cajaresumenTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValorizacionStock
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.stockgeneralvaluacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValpreciocostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValprecioventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.stockgeneralvaluacionTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockgeneralvaluacionTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.stockgeneralvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stockgeneralvaluacionBindingSource
        '
        Me.stockgeneralvaluacionBindingSource.DataMember = "stockgeneralvaluacion"
        Me.stockgeneralvaluacionBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1006, 421)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.CodigoproductoDataGridViewTextBoxColumn, Me.RubroDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.UnidadesDataGridViewTextBoxColumn, Me.PreciocostoDataGridViewTextBoxColumn, Me.PrecioventaDataGridViewTextBoxColumn, Me.ValpreciocostoDataGridViewTextBoxColumn, Me.ValprecioventaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.stockgeneralvaluacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(994, 394)
        Me.DataGridView1.TabIndex = 1
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "idproducto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdproductoDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoproductoDataGridViewTextBoxColumn
        '
        Me.CodigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoproductoDataGridViewTextBoxColumn.Name = "CodigoproductoDataGridViewTextBoxColumn"
        Me.CodigoproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RubroDataGridViewTextBoxColumn
        '
        Me.RubroDataGridViewTextBoxColumn.DataPropertyName = "rubro"
        Me.RubroDataGridViewTextBoxColumn.HeaderText = "Rubro"
        Me.RubroDataGridViewTextBoxColumn.Name = "RubroDataGridViewTextBoxColumn"
        Me.RubroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 300
        '
        'UnidadesDataGridViewTextBoxColumn
        '
        Me.UnidadesDataGridViewTextBoxColumn.DataPropertyName = "unidades"
        Me.UnidadesDataGridViewTextBoxColumn.HeaderText = "Unidades"
        Me.UnidadesDataGridViewTextBoxColumn.Name = "UnidadesDataGridViewTextBoxColumn"
        Me.UnidadesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciocostoDataGridViewTextBoxColumn
        '
        Me.PreciocostoDataGridViewTextBoxColumn.DataPropertyName = "preciocosto"
        Me.PreciocostoDataGridViewTextBoxColumn.HeaderText = "Precio Costo"
        Me.PreciocostoDataGridViewTextBoxColumn.Name = "PreciocostoDataGridViewTextBoxColumn"
        Me.PreciocostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventaDataGridViewTextBoxColumn
        '
        Me.PrecioventaDataGridViewTextBoxColumn.DataPropertyName = "precioventa"
        Me.PrecioventaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.PrecioventaDataGridViewTextBoxColumn.Name = "PrecioventaDataGridViewTextBoxColumn"
        Me.PrecioventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValpreciocostoDataGridViewTextBoxColumn
        '
        Me.ValpreciocostoDataGridViewTextBoxColumn.DataPropertyName = "valpreciocosto"
        Me.ValpreciocostoDataGridViewTextBoxColumn.HeaderText = "Valuación en Precio Costo"
        Me.ValpreciocostoDataGridViewTextBoxColumn.Name = "ValpreciocostoDataGridViewTextBoxColumn"
        Me.ValpreciocostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValprecioventaDataGridViewTextBoxColumn
        '
        Me.ValprecioventaDataGridViewTextBoxColumn.DataPropertyName = "valprecioventa"
        Me.ValprecioventaDataGridViewTextBoxColumn.HeaderText = "Valuación en Precio Venta"
        Me.ValprecioventaDataGridViewTextBoxColumn.Name = "ValprecioventaDataGridViewTextBoxColumn"
        Me.ValprecioventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "stockgeneralvaluacion"
        ReportDataSource2.Value = Me.stockgeneralvaluacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepValorizacionStock.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1000, 400)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'stockgeneralvaluacionTableAdapter
        '
        Me.stockgeneralvaluacionTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtrar por Producto:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(445, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 22)
        Me.TextBox1.TabIndex = 2
        '
        'ViewerReporteValorizacionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 497)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewerReporteValorizacionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ReporteValorizacionStock"
        Me.Text = "Valorizacion de Stock"
        CType(Me.stockgeneralvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents stockgeneralvaluacionBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents stockgeneralvaluacionTableAdapter As comercialDataSetTableAdapters.stockgeneralvaluacionTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RubroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValpreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValprecioventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
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
        Me.valpreciocosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valprecioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.stockgeneralvaluacionTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockgeneralvaluacionTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxFiltro = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalPrecioVenta = New System.Windows.Forms.Label()
        Me.LabelTotalPrecioCosto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        CType(Me.stockgeneralvaluacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1174, 360)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.CodigoproductoDataGridViewTextBoxColumn, Me.RubroDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.UnidadesDataGridViewTextBoxColumn, Me.PreciocostoDataGridViewTextBoxColumn, Me.PrecioventaDataGridViewTextBoxColumn, Me.valpreciocosto, Me.valprecioventa})
        Me.DataGridView1.DataSource = Me.stockgeneralvaluacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1162, 333)
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
        'valpreciocosto
        '
        Me.valpreciocosto.DataPropertyName = "valpreciocosto"
        Me.valpreciocosto.HeaderText = "Valuación en Precio Costo"
        Me.valpreciocosto.Name = "valpreciocosto"
        Me.valpreciocosto.ReadOnly = True
        '
        'valprecioventa
        '
        Me.valprecioventa.DataPropertyName = "valprecioventa"
        Me.valprecioventa.HeaderText = "Valuación en Precio Venta"
        Me.valprecioventa.Name = "valprecioventa"
        Me.valprecioventa.ReadOnly = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "stockgeneralvaluacion"
        ReportDataSource1.Value = Me.stockgeneralvaluacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepValorizacionStock.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1168, 339)
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
        Me.Label1.Location = New System.Drawing.Point(184, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtrar por:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(396, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 22)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBoxFiltro
        '
        Me.ComboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFiltro.FormattingEnabled = True
        Me.ComboBoxFiltro.Items.AddRange(New Object() {"Producto", "Rubro", "Código"})
        Me.ComboBoxFiltro.Location = New System.Drawing.Point(261, 29)
        Me.ComboBoxFiltro.Name = "ComboBoxFiltro"
        Me.ComboBoxFiltro.Size = New System.Drawing.Size(129, 24)
        Me.ComboBoxFiltro.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelTotalPrecioVenta)
        Me.GroupBox2.Controls.Add(Me.LabelTotalPrecioCosto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 427)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1135, 58)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'LabelTotalPrecioVenta
        '
        Me.LabelTotalPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrecioVenta.Location = New System.Drawing.Point(853, 29)
        Me.LabelTotalPrecioVenta.Name = "LabelTotalPrecioVenta"
        Me.LabelTotalPrecioVenta.Size = New System.Drawing.Size(131, 20)
        Me.LabelTotalPrecioVenta.TabIndex = 1
        Me.LabelTotalPrecioVenta.Text = "......................."
        Me.LabelTotalPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTotalPrecioCosto
        '
        Me.LabelTotalPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrecioCosto.Location = New System.Drawing.Point(387, 29)
        Me.LabelTotalPrecioCosto.Name = "LabelTotalPrecioCosto"
        Me.LabelTotalPrecioCosto.Size = New System.Drawing.Size(145, 20)
        Me.LabelTotalPrecioCosto.TabIndex = 1
        Me.LabelTotalPrecioCosto.Text = "......................."
        Me.LabelTotalPrecioCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(599, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Valuación total en Precio Venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valuación total en Precio Costo:"
        '
        'BtnExcel
        '
        Me.BtnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcel.Image = Global.sgcomercial.My.Resources.Resources.Excel_ico_40
        Me.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcel.Location = New System.Drawing.Point(1018, 21)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(168, 40)
        Me.BtnExcel.TabIndex = 5
        Me.BtnExcel.Text = "Exportar a Excel"
        Me.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnPdf
        '
        Me.BtnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPdf.Image = Global.sgcomercial.My.Resources.Resources.PDF_ico_40
        Me.BtnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPdf.Location = New System.Drawing.Point(838, 20)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(168, 40)
        Me.BtnPdf.TabIndex = 5
        Me.BtnPdf.Text = "Exportar a Excel"
        Me.BtnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPdf.UseVisualStyleBackColor = True
        Me.BtnPdf.Visible = False
        '
        'ValorizacionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 497)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBoxFiltro)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ValorizacionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ReporteValorizacionStock"
        Me.Text = "Valorización de Stock"
        CType(Me.stockgeneralvaluacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents ComboBoxFiltro As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelTotalPrecioCosto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RubroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents valpreciocosto As DataGridViewTextBoxColumn
    Friend WithEvents valprecioventa As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotalPrecioVenta As Label
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnPdf As Button
End Class

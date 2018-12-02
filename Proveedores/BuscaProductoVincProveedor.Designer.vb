<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaProductoVincProveedor
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListaproductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ListaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaproductosTableAdapter()
        Me.CodigoproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductocompuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductocompuestoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListaproductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 99)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(862, 401)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeColumns = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoproducto, Me.DescripcionDataGridViewTextBoxColumn1, Me.ProductocompuestoDataGridViewTextBoxColumn1})
        Me.ProductosDataGridView.DataSource = Me.ListaproductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(19, 31)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.MultiSelect = False
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(818, 347)
        Me.ProductosDataGridView.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListaproductosDataGridView)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(862, 79)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'ListaproductosDataGridView
        '
        Me.ListaproductosDataGridView.AutoGenerateColumns = False
        Me.ListaproductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaproductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ProductocompuestoDataGridViewTextBoxColumn})
        Me.ListaproductosDataGridView.DataSource = Me.ListaproductosBindingSource
        Me.ListaproductosDataGridView.Location = New System.Drawing.Point(717, 21)
        Me.ListaproductosDataGridView.Name = "ListaproductosDataGridView"
        Me.ListaproductosDataGridView.RowTemplate.Height = 24
        Me.ListaproductosDataGridView.Size = New System.Drawing.Size(39, 39)
        Me.ListaproductosDataGridView.TabIndex = 5
        Me.ListaproductosDataGridView.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(323, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Código", "Descripción"})
        Me.ComboBox1.Location = New System.Drawing.Point(154, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaproductosBindingSource
        '
        Me.ListaproductosBindingSource.DataMember = "listaproductos"
        Me.ListaproductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListaproductosTableAdapter
        '
        Me.ListaproductosTableAdapter.ClearBeforeFill = True
        '
        'CodigoproductoDataGridViewTextBoxColumn
        '
        Me.CodigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.HeaderText = "codigoproducto"
        Me.CodigoproductoDataGridViewTextBoxColumn.Name = "CodigoproductoDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductocompuestoDataGridViewTextBoxColumn
        '
        Me.ProductocompuestoDataGridViewTextBoxColumn.DataPropertyName = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn.HeaderText = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn.Name = "ProductocompuestoDataGridViewTextBoxColumn"
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.ToolTipText = "Código"
        Me.codigoproducto.Width = 81
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn1.ToolTipText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Width = 111
        '
        'ProductocompuestoDataGridViewTextBoxColumn1
        '
        Me.ProductocompuestoDataGridViewTextBoxColumn1.DataPropertyName = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.HeaderText = "productocompuesto"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Name = "ProductocompuestoDataGridViewTextBoxColumn1"
        Me.ProductocompuestoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Visible = False
        Me.ProductocompuestoDataGridViewTextBoxColumn1.Width = 162
        '
        'BuscaProductoVincProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BuscaProductoVincProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "BuscaProductoVincProveedor"
        Me.Text = "Busca Producto"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListaproductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListaproductosDataGridView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListaproductosBindingSource As BindingSource
    Friend WithEvents ListaproductosTableAdapter As comercialDataSetTableAdapters.listaproductosTableAdapter
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductocompuestoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductocompuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

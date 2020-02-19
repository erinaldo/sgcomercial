<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMProductos
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
        Dim ImagenLabel As System.Windows.Forms.Label
        Dim PreciounitarioLabel As System.Windows.Forms.Label
        Dim PrecioventaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim FabricanteLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim IdproductoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim PresentacionLabel As System.Windows.Forms.Label
        Dim UnidadmedidaLabel As System.Windows.Forms.Label
        Dim MedidaLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMProductos))
        Dim PrecioventagranelLabel As System.Windows.Forms.Label
        Dim PrecioventamayoristaLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.editbtn = New System.Windows.Forms.ToolStripButton()
        Me.cancelbtn = New System.Windows.Forms.ToolStripButton()
        Me.GuardarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripGrilla = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActivarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesactivarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet1 = New sgcomercial.comercialDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.UnidadesmedidaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboProveedores = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.IvaComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stockinicialtextbox = New System.Windows.Forms.TextBox()
        Me.BPC4 = New System.Windows.Forms.Button()
        Me.BPC3 = New System.Windows.Forms.Button()
        Me.BPC2 = New System.Windows.Forms.Button()
        Me.BPC1 = New System.Windows.Forms.Button()
        Me.PrecioventadistribuidorTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventamayoristaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventagranelTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBoxCalidacodigo = New System.Windows.Forms.PictureBox()
        Me.MedidaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.PresentacionTextBox = New System.Windows.Forms.TextBox()
        Me.PreciocostoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventaTextBox = New System.Windows.Forms.TextBox()
        Me.stockminimotextbox = New System.Windows.Forms.TextBox()
        Me.codigoproductoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.IdproductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStripTextBoxCantidad = New System.Windows.Forms.Label()
        Me.TextFiltro = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RubrosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter()
        Me.StockTableAdapter = New sgcomercial.MySQLDataSetTableAdapters.stockTableAdapter()
        Me.StockTableAdapter1 = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.TipoivaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipoivaTableAdapter()
        Me.ProveedoresTableAdapter = New sgcomercial.comercialDataSetTableAdapters.proveedoresTableAdapter()
        ImagenLabel = New System.Windows.Forms.Label()
        PreciounitarioLabel = New System.Windows.Forms.Label()
        PrecioventaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        FabricanteLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        IdproductoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        PresentacionLabel = New System.Windows.Forms.Label()
        UnidadmedidaLabel = New System.Windows.Forms.Label()
        MedidaLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        PrecioventagranelLabel = New System.Windows.Forms.Label()
        PrecioventamayoristaLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripGrilla.SuspendLayout()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCalidacodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImagenLabel
        '
        ImagenLabel.AutoSize = True
        ImagenLabel.Location = New System.Drawing.Point(878, 20)
        ImagenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImagenLabel.Name = "ImagenLabel"
        ImagenLabel.Size = New System.Drawing.Size(58, 17)
        ImagenLabel.TabIndex = 17
        ImagenLabel.Text = "Imagen:"
        '
        'PreciounitarioLabel
        '
        PreciounitarioLabel.AutoSize = True
        PreciounitarioLabel.BackColor = System.Drawing.Color.Transparent
        PreciounitarioLabel.Location = New System.Drawing.Point(51, 215)
        PreciounitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PreciounitarioLabel.Name = "PreciounitarioLabel"
        PreciounitarioLabel.Size = New System.Drawing.Size(92, 17)
        PreciounitarioLabel.TabIndex = 110
        PreciounitarioLabel.Text = "Precio Costo:"
        PreciounitarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioventaLabel
        '
        PrecioventaLabel.AccessibleDescription = "Precio Vta. público (empaque cerrado):"
        PrecioventaLabel.AccessibleName = "Precio Vta. público (empaque cerrado):"
        PrecioventaLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        PrecioventaLabel.AutoSize = True
        PrecioventaLabel.BackColor = System.Drawing.Color.Transparent
        PrecioventaLabel.Location = New System.Drawing.Point(13, 251)
        PrecioventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioventaLabel.Name = "PrecioventaLabel"
        PrecioventaLabel.Size = New System.Drawing.Size(130, 17)
        PrecioventaLabel.TabIndex = 109
        PrecioventaLabel.Text = "Precio Vta. público:"
        PrecioventaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(414, 83)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(95, 17)
        Label3.TabIndex = 102
        Label3.Text = "Stock Mínimo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(414, 20)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 17)
        Label2.TabIndex = 101
        Label2.Text = "Rubro:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Location = New System.Drawing.Point(414, 121)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 108
        DescripcionLabel.Text = "Descripción:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(614, 83)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 17)
        Label5.TabIndex = 121
        Label5.Text = "Stock Inicial:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Location = New System.Drawing.Point(611, 252)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(113, 17)
        Label6.TabIndex = 123
        Label6.Tag = "Precio Vta. Distribuidores y comercios"
        Label6.Text = "Alícuota IVA (%):"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FabricanteLabel
        '
        FabricanteLabel.AutoSize = True
        FabricanteLabel.BackColor = System.Drawing.Color.Transparent
        FabricanteLabel.Location = New System.Drawing.Point(414, 51)
        FabricanteLabel.Name = "FabricanteLabel"
        FabricanteLabel.Size = New System.Drawing.Size(79, 17)
        FabricanteLabel.TabIndex = 124
        FabricanteLabel.Text = "Fabricante:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(639, 51)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(78, 17)
        Label7.TabIndex = 124
        Label7.Text = "Proveedor:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Red
        Label11.Location = New System.Drawing.Point(720, 0)
        Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(150, 17)
        Label11.TabIndex = 125
        Label11.Text = "(*) Dato Obligatorio"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Red
        Label8.Location = New System.Drawing.Point(26, 20)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(14, 17)
        Label8.TabIndex = 126
        Label8.Text = "*"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.Red
        Label9.Location = New System.Drawing.Point(79, 50)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(14, 17)
        Label9.TabIndex = 127
        Label9.Text = "*"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Red
        Label10.Location = New System.Drawing.Point(61, 83)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(14, 17)
        Label10.TabIndex = 127
        Label10.Text = "*"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Red
        Label12.Location = New System.Drawing.Point(32, 116)
        Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(14, 17)
        Label12.TabIndex = 128
        Label12.Text = "*"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.Red
        Label13.Location = New System.Drawing.Point(21, 147)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(14, 17)
        Label13.TabIndex = 129
        Label13.Text = "*"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.Color.Red
        Label14.Location = New System.Drawing.Point(71, 186)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(14, 17)
        Label14.TabIndex = 130
        Label14.Text = "*"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.Red
        Label15.Location = New System.Drawing.Point(38, 217)
        Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(14, 17)
        Label15.TabIndex = 131
        Label15.Text = "*"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.Color.Red
        Label16.Location = New System.Drawing.Point(1, 251)
        Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(14, 17)
        Label16.TabIndex = 132
        Label16.Text = "*"
        '
        'IdproductoLabel
        '
        IdproductoLabel.AutoSize = True
        IdproductoLabel.BackColor = System.Drawing.Color.Transparent
        IdproductoLabel.Location = New System.Drawing.Point(40, 20)
        IdproductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdproductoLabel.Name = "IdproductoLabel"
        IdproductoLabel.Size = New System.Drawing.Size(102, 17)
        IdproductoLabel.TabIndex = 133
        IdproductoLabel.Text = "Cod. Producto:"
        IdproductoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.Location = New System.Drawing.Point(91, 52)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(51, 17)
        MarcaLabel.TabIndex = 134
        MarcaLabel.Text = "Marca:"
        MarcaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Location = New System.Drawing.Point(73, 84)
        ModeloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(69, 17)
        ModeloLabel.TabIndex = 135
        ModeloLabel.Text = "Producto:"
        ModeloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PresentacionLabel
        '
        PresentacionLabel.AutoSize = True
        PresentacionLabel.BackColor = System.Drawing.Color.Transparent
        PresentacionLabel.Location = New System.Drawing.Point(48, 116)
        PresentacionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PresentacionLabel.Name = "PresentacionLabel"
        PresentacionLabel.Size = New System.Drawing.Size(95, 17)
        PresentacionLabel.TabIndex = 136
        PresentacionLabel.Text = "Presentación:"
        PresentacionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnidadmedidaLabel
        '
        UnidadmedidaLabel.AutoSize = True
        UnidadmedidaLabel.BackColor = System.Drawing.Color.Transparent
        UnidadmedidaLabel.Location = New System.Drawing.Point(36, 146)
        UnidadmedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UnidadmedidaLabel.Name = "UnidadmedidaLabel"
        UnidadmedidaLabel.Size = New System.Drawing.Size(107, 17)
        UnidadmedidaLabel.TabIndex = 137
        UnidadmedidaLabel.Text = "Unidad Medida:"
        UnidadmedidaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MedidaLabel
        '
        MedidaLabel.AutoSize = True
        MedidaLabel.BackColor = System.Drawing.Color.Transparent
        MedidaLabel.Location = New System.Drawing.Point(84, 184)
        MedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MedidaLabel.Name = "MedidaLabel"
        MedidaLabel.Size = New System.Drawing.Size(58, 17)
        MedidaLabel.TabIndex = 138
        MedidaLabel.Text = "Medida:"
        MedidaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.ForeColor = System.Drawing.Color.Red
        Label17.Location = New System.Drawing.Point(401, 20)
        Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(14, 17)
        Label17.TabIndex = 139
        Label17.Text = "*"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.ForeColor = System.Drawing.Color.Red
        Label18.Location = New System.Drawing.Point(316, 216)
        Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(14, 17)
        Label18.TabIndex = 141
        Label18.Text = "*"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.ForeColor = System.Drawing.Color.Red
        Label19.Location = New System.Drawing.Point(303, 252)
        Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(14, 17)
        Label19.TabIndex = 142
        Label19.Text = "*"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.ForeColor = System.Drawing.Color.Red
        Label20.Location = New System.Drawing.Point(609, 217)
        Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(14, 17)
        Label20.TabIndex = 143
        Label20.Text = "*"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.ForeColor = System.Drawing.Color.Red
        Label21.Location = New System.Drawing.Point(603, 251)
        Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(14, 17)
        Label21.TabIndex = 144
        Label21.Text = "*"
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Nothing
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem, Me.editbtn, Me.cancelbtn, Me.GuardarNuevo})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Nothing
        Me.ProductosBindingNavigator.MoveLastItem = Nothing
        Me.ProductosBindingNavigator.MoveNextItem = Nothing
        Me.ProductosBindingNavigator.MovePreviousItem = Nothing
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Nothing
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(1164, 47)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(111, 44)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(128, 44)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar Cambios"
        Me.ProductosBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ProductosBindingNavigatorSaveItem.Visible = False
        '
        'editbtn
        '
        Me.editbtn.Image = CType(resources.GetObject("editbtn.Image"), System.Drawing.Image)
        Me.editbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(52, 44)
        Me.editbtn.Text = "Editar"
        Me.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cancelbtn
        '
        Me.cancelbtn.Image = CType(resources.GetObject("cancelbtn.Image"), System.Drawing.Image)
        Me.cancelbtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(70, 44)
        Me.cancelbtn.Text = "Cancelar"
        Me.cancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GuardarNuevo
        '
        Me.GuardarNuevo.Image = CType(resources.GetObject("GuardarNuevo.Image"), System.Drawing.Image)
        Me.GuardarNuevo.Name = "GuardarNuevo"
        Me.GuardarNuevo.Size = New System.Drawing.Size(177, 44)
        Me.GuardarNuevo.Text = "Guardar Nuevo Producto"
        Me.GuardarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GuardarNuevo.Visible = False
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BackColor = System.Drawing.Color.White
        Me.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductosBindingSource, "imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(897, 83)
        Me.ImagenPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(197, 197)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPictureBox.TabIndex = 18
        Me.ImagenPictureBox.TabStop = False
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
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.estado, Me.codigoproducto, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.idproducto})
        Me.ProductosDataGridView.ContextMenuStrip = Me.ContextMenuStripGrilla
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(27, 380)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.MultiSelect = False
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(1106, 234)
        Me.ProductosDataGridView.TabIndex = 19
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.FalseValue = "I"
        Me.estado.HeaderText = "Activo/Inactivo"
        Me.estado.IndeterminateValue = "N"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.estado.ToolTipText = "Activo/Inactivo"
        Me.estado.TrueValue = "A"
        Me.estado.Width = 127
        '
        'codigoproducto
        '
        Me.codigoproducto.DataPropertyName = "codigoproducto"
        Me.codigoproducto.HeaderText = "Cod. Producto"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Width = 127
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 76
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 94
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Presentación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'idproducto
        '
        Me.idproducto.DataPropertyName = "idproducto"
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.ReadOnly = True
        Me.idproducto.Visible = False
        Me.idproducto.Width = 104
        '
        'ContextMenuStripGrilla
        '
        Me.ContextMenuStripGrilla.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripGrilla.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivarTodosToolStripMenuItem, Me.DesactivarTodosToolStripMenuItem})
        Me.ContextMenuStripGrilla.Name = "ContextMenuStripGrilla"
        Me.ContextMenuStripGrilla.Size = New System.Drawing.Size(192, 52)
        '
        'ActivarTodosToolStripMenuItem
        '
        Me.ActivarTodosToolStripMenuItem.Name = "ActivarTodosToolStripMenuItem"
        Me.ActivarTodosToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ActivarTodosToolStripMenuItem.Text = "Activar Todos"
        '
        'DesactivarTodosToolStripMenuItem
        '
        Me.DesactivarTodosToolStripMenuItem.Name = "DesactivarTodosToolStripMenuItem"
        Me.DesactivarTodosToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.DesactivarTodosToolStripMenuItem.Text = "Desactivar Todos"
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "rubros"
        Me.RubrosBindingSource.DataSource = Me.ComercialDataSet
        '
        'UnidadesmedidaBindingSource
        '
        Me.UnidadesmedidaBindingSource.DataMember = "unidadesmedida"
        Me.UnidadesmedidaBindingSource.DataSource = Me.ComercialDataSet1
        '
        'ComercialDataSet1
        '
        Me.ComercialDataSet1.DataSetName = "comercialDataSet"
        Me.ComercialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(881, 247)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.Tag = "Cargar Foto"
        Me.Button1.Text = "Cargar Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
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
        'UnidadesmedidaTableAdapter
        '
        Me.UnidadesmedidaTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PrecioventagranelLabel)
        Me.GroupBox1.Controls.Add(PrecioventamayoristaLabel)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label21)
        Me.GroupBox1.Controls.Add(Label20)
        Me.GroupBox1.Controls.Add(Label19)
        Me.GroupBox1.Controls.Add(Label18)
        Me.GroupBox1.Controls.Add(Label17)
        Me.GroupBox1.Controls.Add(Label16)
        Me.GroupBox1.Controls.Add(Label15)
        Me.GroupBox1.Controls.Add(Label14)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.ComboProveedores)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(FabricanteLabel)
        Me.GroupBox1.Controls.Add(Me.FabricanteTextBox)
        Me.GroupBox1.Controls.Add(Me.IvaComboBox)
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.stockinicialtextbox)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.BPC4)
        Me.GroupBox1.Controls.Add(Me.BPC3)
        Me.GroupBox1.Controls.Add(Me.BPC2)
        Me.GroupBox1.Controls.Add(Me.BPC1)
        Me.GroupBox1.Controls.Add(Me.PrecioventadistribuidorTextBox)
        Me.GroupBox1.Controls.Add(Me.PrecioventamayoristaTextBox)
        Me.GroupBox1.Controls.Add(Me.PrecioventagranelTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureBoxCalidacodigo)
        Me.GroupBox1.Controls.Add(Me.MedidaTextBox)
        Me.GroupBox1.Controls.Add(ImagenLabel)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.MarcaTextBox)
        Me.GroupBox1.Controls.Add(Me.ModeloTextBox)
        Me.GroupBox1.Controls.Add(Me.PresentacionTextBox)
        Me.GroupBox1.Controls.Add(Me.PreciocostoTextBox)
        Me.GroupBox1.Controls.Add(Me.PrecioventaTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.stockminimotextbox)
        Me.GroupBox1.Controls.Add(Me.codigoproductoTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.IdproductoTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(PreciounitarioLabel)
        Me.GroupBox1.Controls.Add(PrecioventaLabel)
        Me.GroupBox1.Controls.Add(IdproductoLabel)
        Me.GroupBox1.Controls.Add(MarcaLabel)
        Me.GroupBox1.Controls.Add(ModeloLabel)
        Me.GroupBox1.Controls.Add(PresentacionLabel)
        Me.GroupBox1.Controls.Add(UnidadmedidaLabel)
        Me.GroupBox1.Controls.Add(MedidaLabel)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1135, 288)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'ComboProveedores
        '
        Me.ComboProveedores.DataSource = Me.ProveedoresBindingSource
        Me.ComboProveedores.DisplayMember = "nombre"
        Me.ComboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ComboProveedores.FormattingEnabled = True
        Me.ComboProveedores.Location = New System.Drawing.Point(717, 47)
        Me.ComboProveedores.Name = "ComboProveedores"
        Me.ComboProveedores.Size = New System.Drawing.Size(158, 24)
        Me.ComboProveedores.TabIndex = 14
        Me.ComboProveedores.ValueMember = "idproveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ComercialDataSetBindingSource
        '
        'ComercialDataSetBindingSource
        '
        Me.ComercialDataSetBindingSource.DataSource = Me.ComercialDataSet
        Me.ComercialDataSetBindingSource.Position = 0
        '
        'FabricanteTextBox
        '
        Me.FabricanteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FabricanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "fabricante", True))
        Me.FabricanteTextBox.Location = New System.Drawing.Point(494, 48)
        Me.FabricanteTextBox.Name = "FabricanteTextBox"
        Me.FabricanteTextBox.Size = New System.Drawing.Size(141, 22)
        Me.FabricanteTextBox.TabIndex = 13
        '
        'IvaComboBox
        '
        Me.IvaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "iva", True))
        Me.IvaComboBox.DataSource = Me.TipoivaBindingSource
        Me.IvaComboBox.DisplayMember = "alicuota"
        Me.IvaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IvaComboBox.FormattingEnabled = True
        Me.IvaComboBox.Location = New System.Drawing.Point(723, 249)
        Me.IvaComboBox.Name = "IvaComboBox"
        Me.IvaComboBox.Size = New System.Drawing.Size(108, 24)
        Me.IvaComboBox.TabIndex = 11
        Me.IvaComboBox.ValueMember = "alicuota"
        '
        'TipoivaBindingSource
        '
        Me.TipoivaBindingSource.DataMember = "tipoiva"
        Me.TipoivaBindingSource.DataSource = Me.ComercialDataSet
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(793, 81)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.RowTemplate.Height = 24
        Me.StockDataGridView.Size = New System.Drawing.Size(21, 21)
        Me.StockDataGridView.TabIndex = 122
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idstock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idstock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechamovimiento"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechamovimiento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechacarga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn11.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn12.HeaderText = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn13.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn14.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "idpedido"
        Me.DataGridViewTextBoxColumn15.HeaderText = "idpedido"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "idremito"
        Me.DataGridViewTextBoxColumn16.HeaderText = "idremito"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'stockinicialtextbox
        '
        Me.stockinicialtextbox.Location = New System.Drawing.Point(696, 80)
        Me.stockinicialtextbox.Name = "stockinicialtextbox"
        Me.stockinicialtextbox.Size = New System.Drawing.Size(91, 22)
        Me.stockinicialtextbox.TabIndex = 16
        '
        'BPC4
        '
        Me.BPC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPC4.Location = New System.Drawing.Point(832, 212)
        Me.BPC4.Name = "BPC4"
        Me.BPC4.Size = New System.Drawing.Size(26, 24)
        Me.BPC4.TabIndex = 120
        Me.BPC4.Text = "%"
        Me.BPC4.UseVisualStyleBackColor = True
        '
        'BPC3
        '
        Me.BPC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPC3.Location = New System.Drawing.Point(557, 248)
        Me.BPC3.Name = "BPC3"
        Me.BPC3.Size = New System.Drawing.Size(26, 24)
        Me.BPC3.TabIndex = 119
        Me.BPC3.Text = "%"
        Me.BPC3.UseVisualStyleBackColor = True
        '
        'BPC2
        '
        Me.BPC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPC2.Location = New System.Drawing.Point(557, 212)
        Me.BPC2.Name = "BPC2"
        Me.BPC2.Size = New System.Drawing.Size(26, 24)
        Me.BPC2.TabIndex = 118
        Me.BPC2.Text = "%"
        Me.BPC2.UseVisualStyleBackColor = True
        '
        'BPC1
        '
        Me.BPC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPC1.Location = New System.Drawing.Point(252, 248)
        Me.BPC1.Name = "BPC1"
        Me.BPC1.Size = New System.Drawing.Size(26, 24)
        Me.BPC1.TabIndex = 117
        Me.BPC1.Text = "%"
        Me.BPC1.UseVisualStyleBackColor = True
        '
        'PrecioventadistribuidorTextBox
        '
        Me.PrecioventadistribuidorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventadistribuidor", True))
        Me.PrecioventadistribuidorTextBox.Location = New System.Drawing.Point(742, 213)
        Me.PrecioventadistribuidorTextBox.Name = "PrecioventadistribuidorTextBox"
        Me.PrecioventadistribuidorTextBox.Size = New System.Drawing.Size(89, 22)
        Me.PrecioventadistribuidorTextBox.TabIndex = 10
        Me.PrecioventadistribuidorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventamayoristaTextBox
        '
        Me.PrecioventamayoristaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventamayorista", True))
        Me.PrecioventamayoristaTextBox.Location = New System.Drawing.Point(467, 249)
        Me.PrecioventamayoristaTextBox.Name = "PrecioventamayoristaTextBox"
        Me.PrecioventamayoristaTextBox.Size = New System.Drawing.Size(89, 22)
        Me.PrecioventamayoristaTextBox.TabIndex = 9
        Me.PrecioventamayoristaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventagranelTextBox
        '
        Me.PrecioventagranelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventagranel", True))
        Me.PrecioventagranelTextBox.Location = New System.Drawing.Point(467, 213)
        Me.PrecioventagranelTextBox.Name = "PrecioventagranelTextBox"
        Me.PrecioventagranelTextBox.Size = New System.Drawing.Size(89, 22)
        Me.PrecioventagranelTextBox.TabIndex = 8
        Me.PrecioventagranelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBoxCalidacodigo
        '
        Me.PictureBoxCalidacodigo.AccessibleName = "Validar código"
        Me.PictureBoxCalidacodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCalidacodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCalidacodigo.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxCalidacodigo.Location = New System.Drawing.Point(368, 15)
        Me.PictureBoxCalidacodigo.Name = "PictureBoxCalidacodigo"
        Me.PictureBoxCalidacodigo.Size = New System.Drawing.Size(26, 26)
        Me.PictureBoxCalidacodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCalidacodigo.TabIndex = 112
        Me.PictureBoxCalidacodigo.TabStop = False
        Me.PictureBoxCalidacodigo.Tag = "Validar código"
        '
        'MedidaTextBox
        '
        Me.MedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "medida", True))
        Me.MedidaTextBox.Location = New System.Drawing.Point(144, 181)
        Me.MedidaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MedidaTextBox.Name = "MedidaTextBox"
        Me.MedidaTextBox.Size = New System.Drawing.Size(251, 22)
        Me.MedidaTextBox.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "unidadmedida", True))
        Me.ComboBox1.DataSource = Me.UnidadesmedidaBindingSource
        Me.ComboBox1.DisplayMember = "descripcion"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(141, 143)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "idunidadmedida"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(141, 48)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(251, 22)
        Me.MarcaTextBox.TabIndex = 1
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(141, 80)
        Me.ModeloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(251, 22)
        Me.ModeloTextBox.TabIndex = 2
        '
        'PresentacionTextBox
        '
        Me.PresentacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PresentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "presentacion", True))
        Me.PresentacionTextBox.Location = New System.Drawing.Point(141, 112)
        Me.PresentacionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PresentacionTextBox.Name = "PresentacionTextBox"
        Me.PresentacionTextBox.Size = New System.Drawing.Size(251, 22)
        Me.PresentacionTextBox.TabIndex = 3
        '
        'PreciocostoTextBox
        '
        Me.PreciocostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "preciocosto", True))
        Me.PreciocostoTextBox.Location = New System.Drawing.Point(143, 213)
        Me.PreciocostoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PreciocostoTextBox.Name = "PreciocostoTextBox"
        Me.PreciocostoTextBox.Size = New System.Drawing.Size(108, 22)
        Me.PreciocostoTextBox.TabIndex = 6
        Me.PreciocostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioventaTextBox
        '
        Me.PrecioventaTextBox.AccessibleDescription = "Precio Vta. público (empaque cerrado):"
        Me.PrecioventaTextBox.AccessibleName = "Precio Vta. público (empaque cerrado):"
        Me.PrecioventaTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PrecioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precioventa", True))
        Me.PrecioventaTextBox.Location = New System.Drawing.Point(143, 249)
        Me.PrecioventaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioventaTextBox.Name = "PrecioventaTextBox"
        Me.PrecioventaTextBox.Size = New System.Drawing.Size(108, 22)
        Me.PrecioventaTextBox.TabIndex = 7
        Me.PrecioventaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'stockminimotextbox
        '
        Me.stockminimotextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "stockminimo", True))
        Me.stockminimotextbox.Location = New System.Drawing.Point(513, 80)
        Me.stockminimotextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.stockminimotextbox.Name = "stockminimotextbox"
        Me.stockminimotextbox.Size = New System.Drawing.Size(91, 22)
        Me.stockminimotextbox.TabIndex = 15
        Me.stockminimotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'codigoproductoTextBox
        '
        Me.codigoproductoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codigoproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigoproducto", True))
        Me.codigoproductoTextBox.Location = New System.Drawing.Point(141, 17)
        Me.codigoproductoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigoproductoTextBox.Name = "codigoproductoTextBox"
        Me.codigoproductoTextBox.Size = New System.Drawing.Size(222, 22)
        Me.codigoproductoTextBox.TabIndex = 0
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idrubro", True))
        Me.ComboBox3.DataSource = Me.RubrosBindingSource
        Me.ComboBox3.DisplayMember = "descripcion"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(467, 16)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(238, 24)
        Me.ComboBox3.TabIndex = 12
        Me.ComboBox3.ValueMember = "idrubro"
        '
        'IdproductoTextBox
        '
        Me.IdproductoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "idproducto", True))
        Me.IdproductoTextBox.Location = New System.Drawing.Point(323, 145)
        Me.IdproductoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdproductoTextBox.Name = "IdproductoTextBox"
        Me.IdproductoTextBox.Size = New System.Drawing.Size(70, 22)
        Me.IdproductoTextBox.TabIndex = 111
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(418, 144)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(449, 53)
        Me.DescripcionTextBox.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStripTextBoxCantidad)
        Me.GroupBox2.Controls.Add(Me.TextFiltro)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 336)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1135, 289)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Todos los productos"
        '
        'ToolStripTextBoxCantidad
        '
        Me.ToolStripTextBoxCantidad.Location = New System.Drawing.Point(881, 20)
        Me.ToolStripTextBoxCantidad.Name = "ToolStripTextBoxCantidad"
        Me.ToolStripTextBoxCantidad.Size = New System.Drawing.Size(236, 17)
        Me.ToolStripTextBoxCantidad.TabIndex = 3
        Me.ToolStripTextBoxCantidad.Text = "................................................"
        Me.ToolStripTextBoxCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextFiltro
        '
        Me.TextFiltro.Location = New System.Drawing.Point(385, 16)
        Me.TextFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.TextFiltro.Name = "TextFiltro"
        Me.TextFiltro.Size = New System.Drawing.Size(221, 22)
        Me.TextFiltro.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Código", "Marca", "Producto"})
        Me.ComboBox2.Location = New System.Drawing.Point(252, 16)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtrar por:"
        '
        'RubrosTableAdapter
        '
        Me.RubrosTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'TipoivaTableAdapter
        '
        Me.TipoivaTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'PrecioventagranelLabel
        '
        PrecioventagranelLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrecioventagranelLabel.AutoSize = True
        PrecioventagranelLabel.BackColor = System.Drawing.Color.Transparent
        PrecioventagranelLabel.Cursor = System.Windows.Forms.Cursors.Hand
        PrecioventagranelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        PrecioventagranelLabel.ForeColor = System.Drawing.SystemColors.Highlight
        PrecioventagranelLabel.Location = New System.Drawing.Point(333, 216)
        PrecioventagranelLabel.Name = "PrecioventagranelLabel"
        PrecioventagranelLabel.Size = New System.Drawing.Size(140, 17)
        PrecioventagranelLabel.TabIndex = 145
        PrecioventagranelLabel.Text = "Precio Vta. a Granel:"
        PrecioventagranelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioventamayoristaLabel
        '
        PrecioventamayoristaLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrecioventamayoristaLabel.AutoSize = True
        PrecioventamayoristaLabel.BackColor = System.Drawing.Color.Transparent
        PrecioventamayoristaLabel.Cursor = System.Windows.Forms.Cursors.Hand
        PrecioventamayoristaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        PrecioventamayoristaLabel.ForeColor = System.Drawing.SystemColors.Highlight
        PrecioventamayoristaLabel.Location = New System.Drawing.Point(319, 251)
        PrecioventamayoristaLabel.Name = "PrecioventamayoristaLabel"
        PrecioventamayoristaLabel.Size = New System.Drawing.Size(155, 17)
        PrecioventamayoristaLabel.TabIndex = 146
        PrecioventamayoristaLabel.Text = "P. Vta. Com./Mayorista:"
        PrecioventamayoristaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Label4.Location = New System.Drawing.Point(619, 216)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(130, 17)
        Label4.TabIndex = 147
        Label4.Tag = "Precio Vta. Distribuidores y comercios"
        Label4.Text = "P. Vta. Distribuidor:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 632)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMProductos"
        Me.Text = "Alta, Baja y Modificación de Productos"
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripGrilla.ResumeLayout(False)
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCalidacodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As sgcomercial.comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImagenPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UnidadesmedidaTableAdapter As sgcomercial.comercialDataSetTableAdapters.unidadesmedidaTableAdapter
    Friend WithEvents ComercialDataSet1 As sgcomercial.comercialDataSet
    Friend WithEvents UnidadesmedidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editbtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancelbtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RubrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RubrosTableAdapter As sgcomercial.comercialDataSetTableAdapters.rubrosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresentacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreciocostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stockminimotextbox As System.Windows.Forms.TextBox
    Friend WithEvents codigoproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents IdproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxCalidacodigo As PictureBox
    Friend WithEvents PrecioventamayoristaTextBox As TextBox
    Friend WithEvents PrecioventagranelTextBox As TextBox
    Friend WithEvents PrecioventadistribuidorTextBox As TextBox
    Friend WithEvents BPC4 As Button
    Friend WithEvents BPC3 As Button
    Friend WithEvents BPC2 As Button
    Friend WithEvents BPC1 As Button
    Friend WithEvents stockinicialtextbox As TextBox
    Friend WithEvents StockTableAdapter As MySQLDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter1 As comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents GuardarNuevo As ToolStripButton
    Friend WithEvents IvaComboBox As ComboBox
    Friend WithEvents TipoivaBindingSource As BindingSource
    Friend WithEvents TipoivaTableAdapter As comercialDataSetTableAdapters.tipoivaTableAdapter
    Friend WithEvents FabricanteTextBox As TextBox
    Friend WithEvents ContextMenuStripGrilla As ContextMenuStrip
    Friend WithEvents ActivarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesactivarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxCantidad As Label
    Friend WithEvents ComboProveedores As ComboBox
    Friend WithEvents ComercialDataSetBindingSource As BindingSource
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As comercialDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents estado As DataGridViewCheckBoxColumn
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
End Class

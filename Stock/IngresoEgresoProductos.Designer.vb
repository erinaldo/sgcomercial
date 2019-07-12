<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ingresoegresoproductos
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
        Dim IdproductoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim TipomovimientostockLabel As System.Windows.Forms.Label
        Dim FechamovimientoLabel As System.Windows.Forms.Label
        Dim FechacargaLabel As System.Windows.Forms.Label
        Dim UsuariocargaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresoegresoproductos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboMotivoStock = New System.Windows.Forms.ComboBox()
        Me.MotivostockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.TextBoxMedida = New System.Windows.Forms.TextBox()
        Me.ComboUnidad = New System.Windows.Forms.ComboBox()
        Me.ProductoscomponentesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoscomponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxEnvasado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textstockminimo = New System.Windows.Forms.TextBox()
        Me.textdisponible = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Labeldescripcion = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.codigoproductoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.TipomovimientostockComboBox = New System.Windows.Forms.ComboBox()
        Me.TipomovimientostockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechamovimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechacargaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsuariocargaTextBox = New System.Windows.Forms.TextBox()
        Me.TipomovimientostockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipomovimientostockTableAdapter()
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.StockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.stockTableAdapter()
        Me.ProductoscomponentesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productoscomponentesTableAdapter()
        Me.BGWStockClowd = New System.ComponentModel.BackgroundWorker()
        Me.MotivostockTableAdapter = New sgcomercial.comercialDataSetTableAdapters.motivostockTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        IdproductoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        TipomovimientostockLabel = New System.Windows.Forms.Label()
        FechamovimientoLabel = New System.Windows.Forms.Label()
        FechacargaLabel = New System.Windows.Forms.Label()
        UsuariocargaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MotivostockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoscomponentesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoscomponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipomovimientostockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdproductoLabel
        '
        IdproductoLabel.AutoSize = True
        IdproductoLabel.Location = New System.Drawing.Point(104, 29)
        IdproductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdproductoLabel.Name = "IdproductoLabel"
        IdproductoLabel.Size = New System.Drawing.Size(102, 17)
        IdproductoLabel.TabIndex = 2
        IdproductoLabel.Text = "Cod. Producto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(138, 88)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(68, 17)
        CantidadLabel.TabIndex = 4
        CantidadLabel.Text = "Cantidad:"
        '
        'TipomovimientostockLabel
        '
        TipomovimientostockLabel.AutoSize = True
        TipomovimientostockLabel.Location = New System.Drawing.Point(91, 120)
        TipomovimientostockLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipomovimientostockLabel.Name = "TipomovimientostockLabel"
        TipomovimientostockLabel.Size = New System.Drawing.Size(115, 17)
        TipomovimientostockLabel.TabIndex = 6
        TipomovimientostockLabel.Text = "Tipo Movimiento:"
        '
        'FechamovimientoLabel
        '
        FechamovimientoLabel.AutoSize = True
        FechamovimientoLabel.Location = New System.Drawing.Point(80, 154)
        FechamovimientoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechamovimientoLabel.Name = "FechamovimientoLabel"
        FechamovimientoLabel.Size = New System.Drawing.Size(126, 17)
        FechamovimientoLabel.TabIndex = 8
        FechamovimientoLabel.Text = "Fecha Movimiento:"
        '
        'FechacargaLabel
        '
        FechacargaLabel.AutoSize = True
        FechacargaLabel.Location = New System.Drawing.Point(113, 186)
        FechacargaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechacargaLabel.Name = "FechacargaLabel"
        FechacargaLabel.Size = New System.Drawing.Size(93, 17)
        FechacargaLabel.TabIndex = 10
        FechacargaLabel.Text = "Fecha Carga:"
        '
        'UsuariocargaLabel
        '
        UsuariocargaLabel.AutoSize = True
        UsuariocargaLabel.Location = New System.Drawing.Point(103, 217)
        UsuariocargaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UsuariocargaLabel.Name = "UsuariocargaLabel"
        UsuariocargaLabel.Size = New System.Drawing.Size(103, 17)
        UsuariocargaLabel.TabIndex = 12
        UsuariocargaLabel.Text = "Usuario Carga:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(488, 88)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(132, 17)
        Label3.TabIndex = 20
        Label3.Text = "Medida (Kg, Lt, Mt):"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(153, 248)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(53, 17)
        Label5.TabIndex = 12
        Label5.Text = "Motivo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.ComboMotivoStock)
        Me.GroupBox1.Controls.Add(Me.TextBoxMedida)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.ComboUnidad)
        Me.GroupBox1.Controls.Add(Me.ProductoscomponentesDataGridView)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.StockDataGridView)
        Me.GroupBox1.Controls.Add(Me.Labeldescripcion)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ProductosDataGridView)
        Me.GroupBox1.Controls.Add(IdproductoLabel)
        Me.GroupBox1.Controls.Add(Me.codigoproductoTextBox)
        Me.GroupBox1.Controls.Add(CantidadLabel)
        Me.GroupBox1.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox1.Controls.Add(TipomovimientostockLabel)
        Me.GroupBox1.Controls.Add(Me.TipomovimientostockComboBox)
        Me.GroupBox1.Controls.Add(FechamovimientoLabel)
        Me.GroupBox1.Controls.Add(Me.FechamovimientoDateTimePicker)
        Me.GroupBox1.Controls.Add(FechacargaLabel)
        Me.GroupBox1.Controls.Add(Me.FechacargaDateTimePicker)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(UsuariocargaLabel)
        Me.GroupBox1.Controls.Add(Me.UsuariocargaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 481)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimiento de Stock"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(132, 438)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 28)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Desactivar Producto"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(436, 438)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 28)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Resetear a Cero"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboMotivoStock
        '
        Me.ComboMotivoStock.DataSource = Me.MotivostockBindingSource
        Me.ComboMotivoStock.DisplayMember = "descripcion"
        Me.ComboMotivoStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMotivoStock.FormattingEnabled = True
        Me.ComboMotivoStock.Location = New System.Drawing.Point(216, 245)
        Me.ComboMotivoStock.Name = "ComboMotivoStock"
        Me.ComboMotivoStock.Size = New System.Drawing.Size(265, 24)
        Me.ComboMotivoStock.TabIndex = 22
        Me.ComboMotivoStock.ValueMember = "idmotivostock"
        '
        'MotivostockBindingSource
        '
        Me.MotivostockBindingSource.DataMember = "motivostock"
        Me.MotivostockBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxMedida
        '
        Me.TextBoxMedida.Location = New System.Drawing.Point(618, 85)
        Me.TextBoxMedida.Name = "TextBoxMedida"
        Me.TextBoxMedida.ReadOnly = True
        Me.TextBoxMedida.Size = New System.Drawing.Size(72, 22)
        Me.TextBoxMedida.TabIndex = 21
        Me.TextBoxMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboUnidad
        '
        Me.ComboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUnidad.FormattingEnabled = True
        Me.ComboUnidad.Items.AddRange(New Object() {"Fraccionado", "Unidades"})
        Me.ComboUnidad.Location = New System.Drawing.Point(216, 84)
        Me.ComboUnidad.Name = "ComboUnidad"
        Me.ComboUnidad.Size = New System.Drawing.Size(112, 24)
        Me.ComboUnidad.TabIndex = 2
        '
        'ProductoscomponentesDataGridView
        '
        Me.ProductoscomponentesDataGridView.AutoGenerateColumns = False
        Me.ProductoscomponentesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoscomponentesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.ProductoscomponentesDataGridView.DataSource = Me.ProductoscomponentesBindingSource
        Me.ProductoscomponentesDataGridView.Location = New System.Drawing.Point(8, 29)
        Me.ProductoscomponentesDataGridView.Name = "ProductoscomponentesDataGridView"
        Me.ProductoscomponentesDataGridView.RowTemplate.Height = 24
        Me.ProductoscomponentesDataGridView.Size = New System.Drawing.Size(40, 23)
        Me.ProductoscomponentesDataGridView.TabIndex = 15
        Me.ProductoscomponentesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "idproductocomposicion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "idproductocomposicion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn18.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "idcomponente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "idcomponente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn20.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'ProductoscomponentesBindingSource
        '
        Me.ProductoscomponentesBindingSource.DataMember = "productoscomponentes"
        Me.ProductoscomponentesBindingSource.DataSource = Me.ComercialDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Búsqueda manual"
        Me.PictureBox1.AccessibleName = "Búsqueda manual"
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.manual
        Me.PictureBox1.Location = New System.Drawing.Point(489, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Búsqueda manual"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxEnvasado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.textstockminimo)
        Me.GroupBox2.Controls.Add(Me.textdisponible)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 301)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(696, 115)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado actual en Stock"
        '
        'TextBoxEnvasado
        '
        Me.TextBoxEnvasado.Enabled = False
        Me.TextBoxEnvasado.Location = New System.Drawing.Point(570, 34)
        Me.TextBoxEnvasado.Name = "TextBoxEnvasado"
        Me.TextBoxEnvasado.ReadOnly = True
        Me.TextBoxEnvasado.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxEnvasado.TabIndex = 4
        Me.TextBoxEnvasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unidades Envasadas:"
        '
        'textstockminimo
        '
        Me.textstockminimo.Enabled = False
        Me.textstockminimo.Location = New System.Drawing.Point(215, 68)
        Me.textstockminimo.Margin = New System.Windows.Forms.Padding(4)
        Me.textstockminimo.Name = "textstockminimo"
        Me.textstockminimo.ReadOnly = True
        Me.textstockminimo.Size = New System.Drawing.Size(132, 26)
        Me.textstockminimo.TabIndex = 2
        Me.textstockminimo.TabStop = False
        Me.textstockminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textdisponible
        '
        Me.textdisponible.Enabled = False
        Me.textdisponible.Location = New System.Drawing.Point(215, 34)
        Me.textdisponible.Margin = New System.Windows.Forms.Padding(4)
        Me.textdisponible.Name = "textdisponible"
        Me.textdisponible.ReadOnly = True
        Me.textdisponible.Size = New System.Drawing.Size(132, 26)
        Me.textdisponible.TabIndex = 1
        Me.textdisponible.TabStop = False
        Me.textdisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock mínimo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disponible (Kg, Lt, Mt):"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(15, 59)
        Me.StockDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(33, 32)
        Me.StockDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idstock"
        Me.DataGridViewTextBoxColumn10.HeaderText = "idstock"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn13.HeaderText = "tipomovimientostock"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fechamovimiento"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fechamovimiento"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fechacarga"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fechacarga"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn16.HeaderText = "usuariocarga"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.ComercialDataSet
        '
        'Labeldescripcion
        '
        Me.Labeldescripcion.AutoSize = True
        Me.Labeldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescripcion.Location = New System.Drawing.Point(216, 57)
        Me.Labeldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeldescripcion.Name = "Labeldescripcion"
        Me.Labeldescripcion.Size = New System.Drawing.Size(213, 17)
        Me.Labeldescripcion.TabIndex = 16
        Me.Labeldescripcion.Text = "........................................."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(284, 438)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn9})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(15, 105)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(33, 32)
        Me.ProductosDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn5.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn6.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'codigoproductoTextBox
        '
        Me.codigoproductoTextBox.Location = New System.Drawing.Point(216, 27)
        Me.codigoproductoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.codigoproductoTextBox.Name = "codigoproductoTextBox"
        Me.codigoproductoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.codigoproductoTextBox.TabIndex = 0
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(335, 85)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(146, 22)
        Me.CantidadTextBox.TabIndex = 1
        '
        'TipomovimientostockComboBox
        '
        Me.TipomovimientostockComboBox.DataSource = Me.TipomovimientostockBindingSource
        Me.TipomovimientostockComboBox.DisplayMember = "descripcion"
        Me.TipomovimientostockComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipomovimientostockComboBox.FormattingEnabled = True
        Me.TipomovimientostockComboBox.Location = New System.Drawing.Point(216, 118)
        Me.TipomovimientostockComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TipomovimientostockComboBox.Name = "TipomovimientostockComboBox"
        Me.TipomovimientostockComboBox.Size = New System.Drawing.Size(265, 24)
        Me.TipomovimientostockComboBox.TabIndex = 3
        Me.TipomovimientostockComboBox.ValueMember = "idtipomovimientostock"
        '
        'TipomovimientostockBindingSource
        '
        Me.TipomovimientostockBindingSource.DataMember = "tipomovimientostock"
        Me.TipomovimientostockBindingSource.DataSource = Me.ComercialDataSet
        '
        'FechamovimientoDateTimePicker
        '
        Me.FechamovimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechamovimientoDateTimePicker.Location = New System.Drawing.Point(216, 151)
        Me.FechamovimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechamovimientoDateTimePicker.Name = "FechamovimientoDateTimePicker"
        Me.FechamovimientoDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.FechamovimientoDateTimePicker.TabIndex = 4
        Me.FechamovimientoDateTimePicker.TabStop = False
        '
        'FechacargaDateTimePicker
        '
        Me.FechacargaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechacargaDateTimePicker.Location = New System.Drawing.Point(216, 183)
        Me.FechacargaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechacargaDateTimePicker.Name = "FechacargaDateTimePicker"
        Me.FechacargaDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.FechacargaDateTimePicker.TabIndex = 5
        Me.FechacargaDateTimePicker.TabStop = False
        '
        'UsuariocargaTextBox
        '
        Me.UsuariocargaTextBox.Location = New System.Drawing.Point(216, 215)
        Me.UsuariocargaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsuariocargaTextBox.Name = "UsuariocargaTextBox"
        Me.UsuariocargaTextBox.Size = New System.Drawing.Size(265, 22)
        Me.UsuariocargaTextBox.TabIndex = 6
        Me.UsuariocargaTextBox.TabStop = False
        '
        'TipomovimientostockTableAdapter
        '
        Me.TipomovimientostockTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
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
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
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
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ProductoscomponentesTableAdapter
        '
        Me.ProductoscomponentesTableAdapter.ClearBeforeFill = True
        '
        'BGWStockClowd
        '
        '
        'MotivostockTableAdapter
        '
        Me.MotivostockTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(453, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ver Stock en Sucursales"
        '
        'ingresoegresoproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingresoegresoproductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso / Egreso de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MotivostockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoscomponentesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoscomponentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipomovimientostockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents codigoproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipomovimientostockComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechamovimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechacargaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents UsuariocargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents TipomovimientostockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipomovimientostockTableAdapter As sgcomercial.comercialDataSetTableAdapters.tipomovimientostockTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As sgcomercial.comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Labeldescripcion As System.Windows.Forms.Label
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As sgcomercial.comercialDataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents textstockminimo As System.Windows.Forms.TextBox
    Friend WithEvents textdisponible As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProductoscomponentesBindingSource As BindingSource
    Friend WithEvents ProductoscomponentesTableAdapter As comercialDataSetTableAdapters.productoscomponentesTableAdapter
    Friend WithEvents ProductoscomponentesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents ComboUnidad As ComboBox
    Friend WithEvents TextBoxMedida As TextBox
    Friend WithEvents TextBoxEnvasado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BGWStockClowd As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboMotivoStock As ComboBox
    Friend WithEvents MotivostockBindingSource As BindingSource
    Friend WithEvents MotivostockTableAdapter As comercialDataSetTableAdapters.motivostockTableAdapter
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
End Class

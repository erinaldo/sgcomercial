<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiComercio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiComercio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texttelefono = New System.Windows.Forms.TextBox()
        Me.textdireccion = New System.Windows.Forms.TextBox()
        Me.textcuitcuil = New System.Windows.Forms.TextBox()
        Me.textnombrecomercio = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ParametrosgeneralesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ParametrosgeneralesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ParametrosgeneralesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ParametrosgeneralesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radiopreguntar = New System.Windows.Forms.RadioButton()
        Me.Radiosiempre = New System.Windows.Forms.RadioButton()
        Me.Radionunca = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CajaRBPreguntar = New System.Windows.Forms.RadioButton()
        Me.CajaRBSiempre = New System.Windows.Forms.RadioButton()
        Me.CajaRBNunca = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSaltoCarro = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxvalidarstock = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBoxRecargoTC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxRecargoCC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.balprefix = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.EmailCierreCajaTo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxComandaDefault = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ComboModPV = New System.Windows.Forms.ComboBox()
        Me.GroupBoxFEAFIP = New System.Windows.Forms.GroupBox()
        Me.ComboFEAutoCAEAFIP = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParametrosgeneralesBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBoxFEAFIP.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.texttelefono)
        Me.GroupBox1.Controls.Add(Me.textdireccion)
        Me.GroupBox1.Controls.Add(Me.textcuitcuil)
        Me.GroupBox1.Controls.Add(Me.textnombrecomercio)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ParametrosgeneralesDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Mi Comercio"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(475, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cuit / Cuil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre Comercio"
        '
        'texttelefono
        '
        Me.texttelefono.Location = New System.Drawing.Point(6, 210)
        Me.texttelefono.Name = "texttelefono"
        Me.texttelefono.Size = New System.Drawing.Size(147, 22)
        Me.texttelefono.TabIndex = 3
        '
        'textdireccion
        '
        Me.textdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textdireccion.Location = New System.Drawing.Point(6, 157)
        Me.textdireccion.Name = "textdireccion"
        Me.textdireccion.Size = New System.Drawing.Size(357, 22)
        Me.textdireccion.TabIndex = 2
        '
        'textcuitcuil
        '
        Me.textcuitcuil.Location = New System.Drawing.Point(6, 104)
        Me.textcuitcuil.Name = "textcuitcuil"
        Me.textcuitcuil.Size = New System.Drawing.Size(147, 22)
        Me.textcuitcuil.TabIndex = 1
        '
        'textnombrecomercio
        '
        Me.textnombrecomercio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textnombrecomercio.Location = New System.Drawing.Point(6, 51)
        Me.textnombrecomercio.Name = "textnombrecomercio"
        Me.textnombrecomercio.Size = New System.Drawing.Size(357, 22)
        Me.textnombrecomercio.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ParametrosgeneralesBindingSource, "prgimagen1", True))
        Me.PictureBox1.Location = New System.Drawing.Point(434, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ParametrosgeneralesBindingSource
        '
        Me.ParametrosgeneralesBindingSource.DataMember = "parametrosgenerales"
        Me.ParametrosgeneralesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParametrosgeneralesDataGridView
        '
        Me.ParametrosgeneralesDataGridView.AutoGenerateColumns = False
        Me.ParametrosgeneralesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParametrosgeneralesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1})
        Me.ParametrosgeneralesDataGridView.DataSource = Me.ParametrosgeneralesBindingSource
        Me.ParametrosgeneralesDataGridView.Location = New System.Drawing.Point(385, 27)
        Me.ParametrosgeneralesDataGridView.Name = "ParametrosgeneralesDataGridView"
        Me.ParametrosgeneralesDataGridView.RowTemplate.Height = 24
        Me.ParametrosgeneralesDataGridView.Size = New System.Drawing.Size(24, 35)
        Me.ParametrosgeneralesDataGridView.TabIndex = 2
        Me.ParametrosgeneralesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "prgid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "prgid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "prgclave"
        Me.DataGridViewTextBoxColumn2.HeaderText = "prgclave"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prgvalor1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prgvalor1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prgstring1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prgstring1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prgdecimal1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "prgdecimal1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "prgimagen1"
        Me.DataGridViewImageColumn1.HeaderText = "prgimagen1"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ParametrosgeneralesBindingNavigator
        '
        Me.ParametrosgeneralesBindingNavigator.AddNewItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.BindingSource = Me.ParametrosgeneralesBindingSource
        Me.ParametrosgeneralesBindingNavigator.CountItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.DeleteItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ParametrosgeneralesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosgeneralesBindingNavigatorSaveItem})
        Me.ParametrosgeneralesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParametrosgeneralesBindingNavigator.MoveFirstItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MoveLastItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MoveNextItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MovePreviousItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.Name = "ParametrosgeneralesBindingNavigator"
        Me.ParametrosgeneralesBindingNavigator.PositionItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.Size = New System.Drawing.Size(1141, 27)
        Me.ParametrosgeneralesBindingNavigator.TabIndex = 1
        Me.ParametrosgeneralesBindingNavigator.Text = "BindingNavigator1"
        '
        'ParametrosgeneralesBindingNavigatorSaveItem
        '
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParametrosgeneralesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Name = "ParametrosgeneralesBindingNavigatorSaveItem"
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Me.ParametrosgeneralesTableAdapter
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
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Radiopreguntar)
        Me.GroupBox2.Controls.Add(Me.Radiosiempre)
        Me.GroupBox2.Controls.Add(Me.Radionunca)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(657, 68)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Impresion de ticket al finalizar venta"
        '
        'Radiopreguntar
        '
        Me.Radiopreguntar.AutoSize = True
        Me.Radiopreguntar.Location = New System.Drawing.Point(464, 27)
        Me.Radiopreguntar.Name = "Radiopreguntar"
        Me.Radiopreguntar.Size = New System.Drawing.Size(148, 21)
        Me.Radiopreguntar.TabIndex = 2
        Me.Radiopreguntar.TabStop = True
        Me.Radiopreguntar.Text = "Preguntar Siempre"
        Me.Radiopreguntar.UseVisualStyleBackColor = True
        '
        'Radiosiempre
        '
        Me.Radiosiempre.AutoSize = True
        Me.Radiosiempre.Location = New System.Drawing.Point(237, 27)
        Me.Radiosiempre.Name = "Radiosiempre"
        Me.Radiosiempre.Size = New System.Drawing.Size(134, 21)
        Me.Radiosiempre.TabIndex = 1
        Me.Radiosiempre.TabStop = True
        Me.Radiosiempre.Text = "Imprimir Siempre"
        Me.Radiosiempre.UseVisualStyleBackColor = True
        '
        'Radionunca
        '
        Me.Radionunca.AutoSize = True
        Me.Radionunca.Location = New System.Drawing.Point(44, 27)
        Me.Radionunca.Name = "Radionunca"
        Me.Radionunca.Size = New System.Drawing.Size(100, 21)
        Me.Radionunca.TabIndex = 0
        Me.Radionunca.TabStop = True
        Me.Radionunca.Text = "No Imprimir"
        Me.Radionunca.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CajaRBPreguntar)
        Me.GroupBox3.Controls.Add(Me.CajaRBSiempre)
        Me.GroupBox3.Controls.Add(Me.CajaRBNunca)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(657, 68)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ver reporte de cierre al cerrar caja"
        '
        'CajaRBPreguntar
        '
        Me.CajaRBPreguntar.AutoSize = True
        Me.CajaRBPreguntar.Location = New System.Drawing.Point(464, 27)
        Me.CajaRBPreguntar.Name = "CajaRBPreguntar"
        Me.CajaRBPreguntar.Size = New System.Drawing.Size(148, 21)
        Me.CajaRBPreguntar.TabIndex = 2
        Me.CajaRBPreguntar.TabStop = True
        Me.CajaRBPreguntar.Text = "Preguntar Siempre"
        Me.CajaRBPreguntar.UseVisualStyleBackColor = True
        '
        'CajaRBSiempre
        '
        Me.CajaRBSiempre.AutoSize = True
        Me.CajaRBSiempre.Location = New System.Drawing.Point(237, 27)
        Me.CajaRBSiempre.Name = "CajaRBSiempre"
        Me.CajaRBSiempre.Size = New System.Drawing.Size(134, 21)
        Me.CajaRBSiempre.TabIndex = 1
        Me.CajaRBSiempre.TabStop = True
        Me.CajaRBSiempre.Text = "Imprimir Siempre"
        Me.CajaRBSiempre.UseVisualStyleBackColor = True
        '
        'CajaRBNunca
        '
        Me.CajaRBNunca.AutoSize = True
        Me.CajaRBNunca.Location = New System.Drawing.Point(44, 27)
        Me.CajaRBNunca.Name = "CajaRBNunca"
        Me.CajaRBNunca.Size = New System.Drawing.Size(100, 21)
        Me.CajaRBNunca.TabIndex = 0
        Me.CajaRBNunca.TabStop = True
        Me.CajaRBNunca.Text = "No Imprimir"
        Me.CajaRBNunca.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBoxSaltoCarro)
        Me.GroupBox4.Location = New System.Drawing.Point(672, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(457, 68)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lector de códigos de barra - Salto de carro"
        '
        'ComboBoxSaltoCarro
        '
        Me.ComboBoxSaltoCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSaltoCarro.FormattingEnabled = True
        Me.ComboBoxSaltoCarro.Items.AddRange(New Object() {"Sin Salto", "Con Salto"})
        Me.ComboBoxSaltoCarro.Location = New System.Drawing.Point(225, 27)
        Me.ComboBoxSaltoCarro.Name = "ComboBoxSaltoCarro"
        Me.ComboBoxSaltoCarro.Size = New System.Drawing.Size(207, 24)
        Me.ComboBoxSaltoCarro.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBoxvalidarstock)
        Me.GroupBox5.Location = New System.Drawing.Point(674, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(455, 68)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Validar existencia de stock al registrar venta"
        '
        'ComboBoxvalidarstock
        '
        Me.ComboBoxvalidarstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxvalidarstock.FormattingEnabled = True
        Me.ComboBoxvalidarstock.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboBoxvalidarstock.Location = New System.Drawing.Point(225, 27)
        Me.ComboBoxvalidarstock.Name = "ComboBoxvalidarstock"
        Me.ComboBoxvalidarstock.Size = New System.Drawing.Size(207, 24)
        Me.ComboBoxvalidarstock.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBoxRecargoTC)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(674, 189)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(455, 68)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Recargo Venta Tarjeta de Crédito"
        '
        'TextBoxRecargoTC
        '
        Me.TextBoxRecargoTC.Location = New System.Drawing.Point(363, 31)
        Me.TextBoxRecargoTC.Name = "TextBoxRecargoTC"
        Me.TextBoxRecargoTC.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxRecargoTC.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Indicar el porcentaje (%):"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxRecargoCC)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Location = New System.Drawing.Point(674, 263)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(455, 68)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Recargo Venta Cuenta Corriente"
        '
        'TextBoxRecargoCC
        '
        Me.TextBoxRecargoCC.Location = New System.Drawing.Point(363, 31)
        Me.TextBoxRecargoCC.Name = "TextBoxRecargoCC"
        Me.TextBoxRecargoCC.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxRecargoCC.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Indicar el porcentaje (%):"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.balprefix)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(674, 337)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(455, 68)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Prefijo de código de balanza"
        '
        'balprefix
        '
        Me.balprefix.Location = New System.Drawing.Point(363, 31)
        Me.balprefix.Name = "balprefix"
        Me.balprefix.Size = New System.Drawing.Size(44, 22)
        Me.balprefix.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Indicar un (1) caracter:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.EmailCierreCajaTo)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Location = New System.Drawing.Point(9, 461)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(657, 65)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "E-Mail Automatico al cerrar la Caja"
        '
        'EmailCierreCajaTo
        '
        Me.EmailCierreCajaTo.Location = New System.Drawing.Point(237, 28)
        Me.EmailCierreCajaTo.Name = "EmailCierreCajaTo"
        Me.EmailCierreCajaTo.Size = New System.Drawing.Size(339, 22)
        Me.EmailCierreCajaTo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Dirección de E-Mail:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ComboBoxComandaDefault)
        Me.GroupBox10.Location = New System.Drawing.Point(674, 411)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(455, 68)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Formato de Comanda (por defecto)"
        '
        'ComboBoxComandaDefault
        '
        Me.ComboBoxComandaDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxComandaDefault.FormattingEnabled = True
        Me.ComboBoxComandaDefault.Items.AddRange(New Object() {"58MM", "80MM", "A4"})
        Me.ComboBoxComandaDefault.Location = New System.Drawing.Point(113, 27)
        Me.ComboBoxComandaDefault.Name = "ComboBoxComandaDefault"
        Me.ComboBoxComandaDefault.Size = New System.Drawing.Size(228, 24)
        Me.ComboBoxComandaDefault.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.ComboModPV)
        Me.GroupBox11.Location = New System.Drawing.Point(674, 485)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(457, 68)
        Me.GroupBox11.TabIndex = 11
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Permitir Modificar Precio venta en ventana de Venta"
        '
        'ComboModPV
        '
        Me.ComboModPV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboModPV.FormattingEnabled = True
        Me.ComboModPV.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboModPV.Location = New System.Drawing.Point(225, 27)
        Me.ComboModPV.Name = "ComboModPV"
        Me.ComboModPV.Size = New System.Drawing.Size(207, 24)
        Me.ComboModPV.TabIndex = 2
        '
        'GroupBoxFEAFIP
        '
        Me.GroupBoxFEAFIP.Controls.Add(Me.ComboFEAutoCAEAFIP)
        Me.GroupBoxFEAFIP.Location = New System.Drawing.Point(9, 532)
        Me.GroupBoxFEAFIP.Name = "GroupBoxFEAFIP"
        Me.GroupBoxFEAFIP.Size = New System.Drawing.Size(657, 68)
        Me.GroupBoxFEAFIP.TabIndex = 12
        Me.GroupBoxFEAFIP.TabStop = False
        Me.GroupBoxFEAFIP.Text = "Facturación Electrónica AFIP - CAE Automático"
        '
        'ComboFEAutoCAEAFIP
        '
        Me.ComboFEAutoCAEAFIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFEAutoCAEAFIP.FormattingEnabled = True
        Me.ComboFEAutoCAEAFIP.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboFEAutoCAEAFIP.Location = New System.Drawing.Point(225, 27)
        Me.ComboFEAutoCAEAFIP.Name = "ComboFEAutoCAEAFIP"
        Me.ComboFEAutoCAEAFIP.Size = New System.Drawing.Size(207, 24)
        Me.ComboFEAutoCAEAFIP.TabIndex = 2
        '
        'MiComercio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 622)
        Me.Controls.Add(Me.GroupBoxFEAFIP)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ParametrosgeneralesBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MiComercio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Comercio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParametrosgeneralesBindingNavigator.ResumeLayout(False)
        Me.ParametrosgeneralesBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBoxFEAFIP.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ParametrosgeneralesBindingSource As BindingSource
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParametrosgeneralesBindingNavigator As BindingNavigator
    Friend WithEvents ParametrosgeneralesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ParametrosgeneralesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents texttelefono As TextBox
    Friend WithEvents textdireccion As TextBox
    Friend WithEvents textcuitcuil As TextBox
    Friend WithEvents textnombrecomercio As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Radiopreguntar As RadioButton
    Friend WithEvents Radiosiempre As RadioButton
    Friend WithEvents Radionunca As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CajaRBPreguntar As RadioButton
    Friend WithEvents CajaRBSiempre As RadioButton
    Friend WithEvents CajaRBNunca As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBoxSaltoCarro As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ComboBoxvalidarstock As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBoxRecargoTC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBoxRecargoCC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents balprefix As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents EmailCierreCajaTo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents ComboBoxComandaDefault As ComboBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ComboModPV As ComboBox
    Friend WithEvents GroupBoxFEAFIP As GroupBox
    Friend WithEvents ComboFEAutoCAEAFIP As ComboBox
End Class

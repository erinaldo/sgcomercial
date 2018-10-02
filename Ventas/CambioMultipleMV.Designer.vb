<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambioMultipleMV
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.codigoproducto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MontoDiferencia = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 347)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mercadería entrante"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoproducto, Me.descripcion, Me.cantidad, Me.monto, Me.subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 79)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(614, 249)
        Me.DataGridView1.TabIndex = 2
        '
        'codigoproducto
        '
        Me.codigoproducto.HeaderText = "Código"
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Sub-total"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.PictureBox1.Location = New System.Drawing.Point(299, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(650, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 347)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mercadería saliente"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoproducto2, Me.descripcion2, Me.cantidad2, Me.monto2, Me.subtotal2})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(614, 249)
        Me.DataGridView2.TabIndex = 3
        '
        'codigoproducto2
        '
        Me.codigoproducto2.HeaderText = "Código"
        Me.codigoproducto2.Name = "codigoproducto2"
        Me.codigoproducto2.ReadOnly = True
        '
        'descripcion2
        '
        Me.descripcion2.HeaderText = "Descripción"
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.ReadOnly = True
        '
        'cantidad2
        '
        Me.cantidad2.HeaderText = "Cantidad"
        Me.cantidad2.Name = "cantidad2"
        '
        'monto2
        '
        Me.monto2.HeaderText = "Monto"
        Me.monto2.Name = "monto2"
        '
        'subtotal2
        '
        Me.subtotal2.HeaderText = "Sub-total"
        Me.subtotal2.Name = "subtotal2"
        Me.subtotal2.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agregar Producto"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.PictureBox2.Location = New System.Drawing.Point(323, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
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
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
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
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(159, -5)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(39, 21)
        Me.ProductosDataGridView.TabIndex = 3
        Me.ProductosDataGridView.Visible = False
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigoproducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "codigoproducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "presentacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "presentacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "unidadmedida"
        Me.DataGridViewTextBoxColumn6.HeaderText = "unidadmedida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "medida"
        Me.DataGridViewTextBoxColumn7.HeaderText = "medida"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn10.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "imagen"
        Me.DataGridViewImageColumn1.HeaderText = "imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idrubro"
        Me.DataGridViewTextBoxColumn11.HeaderText = "idrubro"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "stockminimo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "stockminimo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "productocompuesto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "productocompuesto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "precioventagranel"
        Me.DataGridViewTextBoxColumn15.HeaderText = "precioventagranel"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "precioventamayorista"
        Me.DataGridViewTextBoxColumn16.HeaderText = "precioventamayorista"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "precioventadistribuidor"
        Me.DataGridViewTextBoxColumn17.HeaderText = "precioventadistribuidor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn18.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnConfirmar)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 365)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1264, 123)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MontoDiferencia)
        Me.GroupBox4.Location = New System.Drawing.Point(207, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(419, 76)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Diferencia: (+) a favor del comercio  (-) a favor del cliente"
        '
        'MontoDiferencia
        '
        Me.MontoDiferencia.Location = New System.Drawing.Point(4, 19)
        Me.MontoDiferencia.Name = "MontoDiferencia"
        Me.MontoDiferencia.Size = New System.Drawing.Size(411, 27)
        Me.MontoDiferencia.TabIndex = 0
        Me.MontoDiferencia.Text = "$ -------"
        Me.MontoDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.Location = New System.Drawing.Point(1081, 44)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(162, 34)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "Confirmar Cámbio"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'CambioMultipleMV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 504)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CambioMultipleMV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CambioMultipleMV"
        Me.Text = "Cámbio de Mercaderías Varias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents codigoproducto2 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion2 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad2 As DataGridViewTextBoxColumn
    Friend WithEvents monto2 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MontoDiferencia As Label
    Friend WithEvents btnConfirmar As Button
End Class

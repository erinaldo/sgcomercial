<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarServicio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxfiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ServiciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diasvigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idservicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ServiciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.serviciosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBoxfiltro)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(627, 79)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nuevo Servicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Descripción"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBoxfiltro
        '
        Me.TextBoxfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxfiltro.Location = New System.Drawing.Point(248, 28)
        Me.TextBoxfiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxfiltro.Name = "TextBoxfiltro"
        Me.TextBoxfiltro.Size = New System.Drawing.Size(204, 22)
        Me.TextBoxfiltro.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ServiciosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 364)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ServiciosDataGridView
        '
        Me.ServiciosDataGridView.AllowUserToAddRows = False
        Me.ServiciosDataGridView.AllowUserToDeleteRows = False
        Me.ServiciosDataGridView.AutoGenerateColumns = False
        Me.ServiciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.precioventa, Me.diasvigencia, Me.idservicio})
        Me.ServiciosDataGridView.DataSource = Me.ServiciosBindingSource
        Me.ServiciosDataGridView.Location = New System.Drawing.Point(16, 21)
        Me.ServiciosDataGridView.Name = "ServiciosDataGridView"
        Me.ServiciosDataGridView.ReadOnly = True
        Me.ServiciosDataGridView.RowTemplate.Height = 24
        Me.ServiciosDataGridView.Size = New System.Drawing.Size(591, 327)
        Me.ServiciosDataGridView.TabIndex = 0
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'precioventa
        '
        Me.precioventa.DataPropertyName = "precioventa"
        Me.precioventa.HeaderText = "Precio Venta"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        '
        'diasvigencia
        '
        Me.diasvigencia.DataPropertyName = "diasvigencia"
        Me.diasvigencia.HeaderText = "diasvigencia"
        Me.diasvigencia.Name = "diasvigencia"
        Me.diasvigencia.ReadOnly = True
        Me.diasvigencia.Visible = False
        '
        'idservicio
        '
        Me.idservicio.DataPropertyName = "idservicio"
        Me.idservicio.HeaderText = "idservicio"
        Me.idservicio.Name = "idservicio"
        Me.idservicio.ReadOnly = True
        Me.idservicio.Visible = False
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "servicios"
        Me.ServiciosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        'Me.TableAdapterManager.clientesalumnosTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
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
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
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
        Me.TableAdapterManager.serviciosTableAdapter = Me.ServiciosTableAdapter
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
        'SeleccionarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 475)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SeleccionarServicio"
        Me.Text = "Seleccionar Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ServiciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBoxfiltro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As comercialDataSetTableAdapters.serviciosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServiciosDataGridView As DataGridView
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents diasvigencia As DataGridViewTextBoxColumn
    Friend WithEvents idservicio As DataGridViewTextBoxColumn
End Class

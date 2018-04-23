<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarVenta
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
        Dim FechaventaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim FormapagoLabel As System.Windows.Forms.Label
        Dim TipocomprobanteLabel As System.Windows.Forms.Label
        Dim NrocomprobanteLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NrocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.FormapagoTextBox = New System.Windows.Forms.TextBox()
        Me.TipocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LibroventasdetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroventasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibroventasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.LibroventasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasdetalleTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.totaltextbox = New System.Windows.Forms.TextBox()
        Me.cantidadtextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ventasTableAdapter()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        Me.PagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FechaventaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        FormapagoLabel = New System.Windows.Forms.Label()
        TipocomprobanteLabel = New System.Windows.Forms.Label()
        NrocomprobanteLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibroventasdetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaventaLabel
        '
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(2, 32)
        FechaventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(92, 17)
        FechaventaLabel.TabIndex = 11
        FechaventaLabel.Text = "Fecha Venta:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(34, 63)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 13
        NombreLabel.Text = "Nombre:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(60, 95)
        CuitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(36, 17)
        CuitLabel.TabIndex = 15
        CuitLabel.Text = "Cuit:"
        '
        'FormapagoLabel
        '
        FormapagoLabel.AutoSize = True
        FormapagoLabel.Location = New System.Drawing.Point(368, 31)
        FormapagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FormapagoLabel.Name = "FormapagoLabel"
        FormapagoLabel.Size = New System.Drawing.Size(89, 17)
        FormapagoLabel.TabIndex = 17
        FormapagoLabel.Text = "Forma Pago:"
        '
        'TipocomprobanteLabel
        '
        TipocomprobanteLabel.AutoSize = True
        TipocomprobanteLabel.Location = New System.Drawing.Point(403, 63)
        TipocomprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipocomprobanteLabel.Name = "TipocomprobanteLabel"
        TipocomprobanteLabel.Size = New System.Drawing.Size(129, 17)
        TipocomprobanteLabel.TabIndex = 19
        TipocomprobanteLabel.Text = "Tipo Comprobante:"
        '
        'NrocomprobanteLabel
        '
        NrocomprobanteLabel.AutoSize = True
        NrocomprobanteLabel.Location = New System.Drawing.Point(413, 93)
        NrocomprobanteLabel.Name = "NrocomprobanteLabel"
        NrocomprobanteLabel.Size = New System.Drawing.Size(117, 17)
        NrocomprobanteLabel.TabIndex = 20
        NrocomprobanteLabel.Text = "N° Comprobante:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PagosDataGridView)
        Me.GroupBox1.Controls.Add(Me.NrocomprobanteTextBox)
        Me.GroupBox1.Controls.Add(NrocomprobanteLabel)
        Me.GroupBox1.Controls.Add(FechaventaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(FormapagoLabel)
        Me.GroupBox1.Controls.Add(Me.FormapagoTextBox)
        Me.GroupBox1.Controls.Add(TipocomprobanteLabel)
        Me.GroupBox1.Controls.Add(Me.TipocomprobanteTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(672, 143)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la venta"
        '
        'NrocomprobanteTextBox
        '
        Me.NrocomprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "nrocomprobante", True))
        Me.NrocomprobanteTextBox.Enabled = False
        Me.NrocomprobanteTextBox.Location = New System.Drawing.Point(536, 92)
        Me.NrocomprobanteTextBox.Name = "NrocomprobanteTextBox"
        Me.NrocomprobanteTextBox.Size = New System.Drawing.Size(128, 22)
        Me.NrocomprobanteTextBox.TabIndex = 21
        '
        'LibroventasBindingSource
        '
        Me.LibroventasBindingSource.DataMember = "libroventas"
        Me.LibroventasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LibroventasBindingSource, "fechaventa", True))
        Me.FechaventaDateTimePicker.Enabled = False
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(104, 27)
        Me.FechaventaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(106, 22)
        Me.FechaventaDateTimePicker.TabIndex = 12
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(104, 60)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(290, 22)
        Me.NombreTextBox.TabIndex = 14
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "cuit", True))
        Me.CuitTextBox.Enabled = False
        Me.CuitTextBox.Location = New System.Drawing.Point(104, 91)
        Me.CuitTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(106, 22)
        Me.CuitTextBox.TabIndex = 16
        '
        'FormapagoTextBox
        '
        Me.FormapagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "formapago", True))
        Me.FormapagoTextBox.Enabled = False
        Me.FormapagoTextBox.Location = New System.Drawing.Point(464, 27)
        Me.FormapagoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FormapagoTextBox.Name = "FormapagoTextBox"
        Me.FormapagoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FormapagoTextBox.TabIndex = 18
        '
        'TipocomprobanteTextBox
        '
        Me.TipocomprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroventasBindingSource, "tipocomprobante", True))
        Me.TipocomprobanteTextBox.Enabled = False
        Me.TipocomprobanteTextBox.Location = New System.Drawing.Point(535, 60)
        Me.TipocomprobanteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TipocomprobanteTextBox.Name = "TipocomprobanteTextBox"
        Me.TipocomprobanteTextBox.Size = New System.Drawing.Size(129, 22)
        Me.TipocomprobanteTextBox.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LibroventasdetalleDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 159)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(672, 393)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'LibroventasdetalleDataGridView
        '
        Me.LibroventasdetalleDataGridView.AllowUserToAddRows = False
        Me.LibroventasdetalleDataGridView.AllowUserToDeleteRows = False
        Me.LibroventasdetalleDataGridView.AllowUserToResizeColumns = False
        Me.LibroventasdetalleDataGridView.AllowUserToResizeRows = False
        Me.LibroventasdetalleDataGridView.AutoGenerateColumns = False
        Me.LibroventasdetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibroventasdetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.LibroventasdetalleDataGridView.DataSource = Me.LibroventasdetalleBindingSource
        Me.LibroventasdetalleDataGridView.Location = New System.Drawing.Point(23, 26)
        Me.LibroventasdetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.LibroventasdetalleDataGridView.MultiSelect = False
        Me.LibroventasdetalleDataGridView.Name = "LibroventasdetalleDataGridView"
        Me.LibroventasdetalleDataGridView.ReadOnly = True
        Me.LibroventasdetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LibroventasdetalleDataGridView.Size = New System.Drawing.Size(627, 344)
        Me.LibroventasdetalleDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sub Total ($)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'LibroventasdetalleBindingSource
        '
        Me.LibroventasdetalleBindingSource.DataMember = "libroventasdetalle"
        Me.LibroventasdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'LibroventasTableAdapter
        '
        Me.LibroventasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'LibroventasdetalleTableAdapter
        '
        Me.LibroventasdetalleTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.totaltextbox)
        Me.GroupBox3.Controls.Add(Me.cantidadtextbox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 560)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(671, 70)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'totaltextbox
        '
        Me.totaltextbox.Enabled = False
        Me.totaltextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltextbox.Location = New System.Drawing.Point(521, 25)
        Me.totaltextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.totaltextbox.Name = "totaltextbox"
        Me.totaltextbox.Size = New System.Drawing.Size(121, 30)
        Me.totaltextbox.TabIndex = 3
        '
        'cantidadtextbox
        '
        Me.cantidadtextbox.Enabled = False
        Me.cantidadtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadtextbox.Location = New System.Drawing.Point(275, 25)
        Me.cantidadtextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.cantidadtextbox.Name = "cantidadtextbox"
        Me.cantidadtextbox.Size = New System.Drawing.Size(75, 30)
        Me.cantidadtextbox.TabIndex = 2
        Me.cantidadtextbox.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de productos:"
        Me.Label1.Visible = False
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.ComercialDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "pagos"
        Me.PagosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'PagosDataGridView
        '
        Me.PagosDataGridView.AutoGenerateColumns = False
        Me.PagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PagosDataGridView.DataSource = Me.PagosBindingSource
        Me.PagosDataGridView.Location = New System.Drawing.Point(276, 95)
        Me.PagosDataGridView.Name = "PagosDataGridView"
        Me.PagosDataGridView.RowTemplate.Height = 24
        Me.PagosDataGridView.Size = New System.Drawing.Size(34, 34)
        Me.PagosDataGridView.TabIndex = 13
        Me.PagosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idpagos"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idpagos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn9.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechapago"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechapago"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ConsultarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 650)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibroventasdetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents LibroventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibroventasTableAdapter As sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FechaventaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormapagoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipocomprobanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LibroventasdetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibroventasdetalleTableAdapter As sgcomercial.comercialDataSetTableAdapters.libroventasdetalleTableAdapter
    Friend WithEvents LibroventasdetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents totaltextbox As System.Windows.Forms.TextBox
    Friend WithEvents cantidadtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents NrocomprobanteTextBox As TextBox
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
    Friend WithEvents PagosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class

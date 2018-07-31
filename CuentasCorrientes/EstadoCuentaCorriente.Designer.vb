<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadoCuentaCorriente
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListacuentascorrientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ListacuentascorrientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListacuentascorrientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listacuentascorrientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.idventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idpagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTipoSaldo = New System.Windows.Forms.Label()
        Me.Labeltotalgeneral = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Labeltotalhaber = New System.Windows.Forms.Label()
        Me.Labeltotaldebe = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListacuentascorrientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(207, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 18
        NombreLabel.Text = "Nombre:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(587, 31)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(70, 17)
        CuitLabel.TabIndex = 24
        CuitLabel.Text = "DNI/CUIT:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(210, 48)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(357, 22)
        Me.NombreTextBox.TabIndex = 19
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cuit", True))
        Me.CuitTextBox.Enabled = False
        Me.CuitTextBox.Location = New System.Drawing.Point(587, 48)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(138, 22)
        Me.CuitTextBox.TabIndex = 25
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(162, 48)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(24, 22)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente N°:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(85, 48)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(70, 22)
        Me.IdclienteTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListacuentascorrientesDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 340)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de Cuenta"
        '
        'ListacuentascorrientesDataGridView
        '
        Me.ListacuentascorrientesDataGridView.AllowUserToAddRows = False
        Me.ListacuentascorrientesDataGridView.AllowUserToDeleteRows = False
        Me.ListacuentascorrientesDataGridView.AutoGenerateColumns = False
        Me.ListacuentascorrientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListacuentascorrientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcliente, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.nro, Me.debe, Me.haber, Me.saldo, Me.idventa, Me.idpagos})
        Me.ListacuentascorrientesDataGridView.DataSource = Me.ListacuentascorrientesBindingSource
        Me.ListacuentascorrientesDataGridView.Location = New System.Drawing.Point(17, 21)
        Me.ListacuentascorrientesDataGridView.Name = "ListacuentascorrientesDataGridView"
        Me.ListacuentascorrientesDataGridView.ReadOnly = True
        Me.ListacuentascorrientesDataGridView.RowTemplate.Height = 24
        Me.ListacuentascorrientesDataGridView.Size = New System.Drawing.Size(1030, 299)
        Me.ListacuentascorrientesDataGridView.TabIndex = 0
        '
        'ListacuentascorrientesBindingSource
        '
        Me.ListacuentascorrientesBindingSource.DataMember = "listacuentascorrientes"
        Me.ListacuentascorrientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListacuentascorrientesTableAdapter
        '
        Me.ListacuentascorrientesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.productosTableAdapter = Nothing
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
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'nro
        '
        Me.nro.DataPropertyName = "nro"
        Me.nro.HeaderText = "Nº"
        Me.nro.Name = "nro"
        Me.nro.ReadOnly = True
        Me.nro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nro.Width = 90
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle7
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle8
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Red
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle9
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.saldo.ToolTipText = "Click para cargar pago"
        '
        'idventa
        '
        Me.idventa.DataPropertyName = "idventa"
        Me.idventa.HeaderText = "idventa"
        Me.idventa.Name = "idventa"
        Me.idventa.ReadOnly = True
        Me.idventa.Visible = False
        '
        'idpagos
        '
        Me.idpagos.DataPropertyName = "idpagos"
        Me.idpagos.HeaderText = "idpagos"
        Me.idpagos.Name = "idpagos"
        Me.idpagos.ReadOnly = True
        Me.idpagos.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LabelTipoSaldo)
        Me.GroupBox3.Controls.Add(Me.Labeltotalgeneral)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Labeltotalhaber)
        Me.GroupBox3.Controls.Add(Me.Labeltotaldebe)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1065, 113)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(662, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Haber"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Debe"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTipoSaldo
        '
        Me.LabelTipoSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTipoSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoSaldo.Location = New System.Drawing.Point(662, 75)
        Me.LabelTipoSaldo.Name = "LabelTipoSaldo"
        Me.LabelTipoSaldo.Size = New System.Drawing.Size(102, 23)
        Me.LabelTipoSaldo.TabIndex = 14
        Me.LabelTipoSaldo.Text = "---------"
        Me.LabelTipoSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labeltotalgeneral
        '
        Me.Labeltotalgeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotalgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Labeltotalgeneral.Location = New System.Drawing.Point(556, 75)
        Me.Labeltotalgeneral.Name = "Labeltotalgeneral"
        Me.Labeltotalgeneral.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotalgeneral.TabIndex = 13
        Me.Labeltotalgeneral.Text = "00000000"
        Me.Labeltotalgeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(300, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SALDO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(300, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TOTALES:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labeltotalhaber
        '
        Me.Labeltotalhaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotalhaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Labeltotalhaber.Location = New System.Drawing.Point(662, 43)
        Me.Labeltotalhaber.Name = "Labeltotalhaber"
        Me.Labeltotalhaber.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotalhaber.TabIndex = 10
        Me.Labeltotalhaber.Text = "00000000"
        Me.Labeltotalhaber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labeltotaldebe
        '
        Me.Labeltotaldebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labeltotaldebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotaldebe.Location = New System.Drawing.Point(556, 43)
        Me.Labeltotaldebe.Name = "Labeltotaldebe"
        Me.Labeltotaldebe.Size = New System.Drawing.Size(102, 23)
        Me.Labeltotaldebe.TabIndex = 9
        Me.Labeltotaldebe.Text = "00000000"
        Me.Labeltotaldebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EstadoCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 583)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EstadoCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta Corriente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ListacuentascorrientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListacuentascorrientesBindingSource As BindingSource
    Friend WithEvents ListacuentascorrientesTableAdapter As comercialDataSetTableAdapters.listacuentascorrientesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListacuentascorrientesDataGridView As DataGridView
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents nro As DataGridViewLinkColumn
    Friend WithEvents debe As DataGridViewTextBoxColumn
    Friend WithEvents haber As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewLinkColumn
    Friend WithEvents idventa As DataGridViewTextBoxColumn
    Friend WithEvents idpagos As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTipoSaldo As Label
    Friend WithEvents Labeltotalgeneral As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Labeltotalhaber As Label
    Friend WithEvents Labeltotaldebe As Label
End Class

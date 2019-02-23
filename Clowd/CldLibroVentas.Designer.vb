<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CldLibroVentas
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
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LibroventasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLDataSet = New sgcomercial.MySQLDataSet()
        Me.LibroventasTableAdapter = New sgcomercial.MySQLDataSetTableAdapters.libroventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.MySQLDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibroventasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(931, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelTotal
        '
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Green
        Me.LabelTotal.Location = New System.Drawing.Point(570, 44)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(150, 23)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "-----------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(411, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto Total:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(228, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 30)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(151, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LibroventasDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(931, 559)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'LibroventasDataGridView
        '
        Me.LibroventasDataGridView.AllowUserToAddRows = False
        Me.LibroventasDataGridView.AllowUserToDeleteRows = False
        Me.LibroventasDataGridView.AutoGenerateColumns = False
        Me.LibroventasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LibroventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibroventasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.importe, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.LibroventasDataGridView.DataSource = Me.LibroventasBindingSource
        Me.LibroventasDataGridView.Location = New System.Drawing.Point(6, 21)
        Me.LibroventasDataGridView.Name = "LibroventasDataGridView"
        Me.LibroventasDataGridView.ReadOnly = True
        Me.LibroventasDataGridView.RowTemplate.Height = 24
        Me.LibroventasDataGridView.Size = New System.Drawing.Size(1021, 518)
        Me.LibroventasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idlibroventas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idlibroventas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 117
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idsucursal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idsucursal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "N°"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 53
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaventa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 76
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cuit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 61
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "condicionivadescripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cond. Fte. al IVA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 111
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipocomprobante"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo Comprobante"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 141
        '
        'importe
        '
        Me.importe.DataPropertyName = "importe"
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 84
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ivaventas"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 58
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "condicioniva"
        Me.DataGridViewTextBoxColumn11.HeaderText = "condicioniva"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 115
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "formapago"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Forma Pago"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 105
        '
        'LibroventasBindingSource
        '
        Me.LibroventasBindingSource.DataMember = "libroventas"
        Me.LibroventasBindingSource.DataSource = Me.MySQLDataSet
        '
        'MySQLDataSet
        '
        Me.MySQLDataSet.DataSetName = "MySQLDataSet"
        Me.MySQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibroventasTableAdapter
        '
        Me.LibroventasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.libroventasTableAdapter = Me.LibroventasTableAdapter
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.MySQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'CldLibroVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 683)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CldLibroVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CldLibroVentas"
        Me.Text = "Libro de ventas en Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LibroventasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MySQLDataSet As MySQLDataSet
    Friend WithEvents LibroventasBindingSource As BindingSource
    Friend WithEvents LibroventasTableAdapter As MySQLDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents TableAdapterManager As MySQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibroventasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCMisComprobantes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LibroventasDataGridView = New System.Windows.Forms.DataGridView()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSet = New sgcomercial.siscomDataSet()
        Me.LibroventasTableAdapter = New sgcomercial.siscomDataSetTableAdapters.libroventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.siscomDataSetTableAdapters.TableAdapterManager()
        Me.idventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VER = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibroventasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LibroventasDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 445)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LibroventasDataGridView
        '
        Me.LibroventasDataGridView.AllowUserToAddRows = False
        Me.LibroventasDataGridView.AllowUserToDeleteRows = False
        Me.LibroventasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibroventasDataGridView.AutoGenerateColumns = False
        Me.LibroventasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LibroventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibroventasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idventas, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.VER})
        Me.LibroventasDataGridView.DataSource = Me.LibroventasBindingSource
        Me.LibroventasDataGridView.Location = New System.Drawing.Point(19, 21)
        Me.LibroventasDataGridView.Name = "LibroventasDataGridView"
        Me.LibroventasDataGridView.ReadOnly = True
        Me.LibroventasDataGridView.RowTemplate.Height = 24
        Me.LibroventasDataGridView.Size = New System.Drawing.Size(738, 405)
        Me.LibroventasDataGridView.TabIndex = 0
        '
        'LibroventasBindingSource
        '
        Me.LibroventasBindingSource.DataMember = "libroventas"
        Me.LibroventasBindingSource.DataSource = Me.SiscomDataSet
        '
        'SiscomDataSet
        '
        Me.SiscomDataSet.DataSetName = "siscomDataSet"
        Me.SiscomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibroventasTableAdapter
        '
        Me.LibroventasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientessucursalesTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.licenciasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesmodulosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.siscomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'idventas
        '
        Me.idventas.DataPropertyName = "idventas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idventas.DefaultCellStyle = DataGridViewCellStyle1
        Me.idventas.HeaderText = "Comprobante N°"
        Me.idventas.Name = "idventas"
        Me.idventas.ReadOnly = True
        Me.idventas.ToolTipText = "Comprobante N°"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaventa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Venta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Fecha Venta"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Baja"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Fecha Baja"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechavencimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Vencimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Fecha Vencimiento"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.ToolTipText = "Nombre"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cuil"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cuil"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "mensaje"
        Me.DataGridViewTextBoxColumn10.HeaderText = "mensaje"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'VER
        '
        Me.VER.DataPropertyName = "idventas"
        Me.VER.HeaderText = "VER"
        Me.VER.Name = "VER"
        Me.VER.ReadOnly = True
        Me.VER.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VER.Text = "VER"
        Me.VER.ToolTipText = "VER"
        Me.VER.UseColumnTextForButtonValue = True
        '
        'SCMisComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCMisComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SCMisComprobantes"
        Me.Text = "Mis Comprobantes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LibroventasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SiscomDataSet As siscomDataSet
    Friend WithEvents LibroventasBindingSource As BindingSource
    Friend WithEvents LibroventasTableAdapter As siscomDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents TableAdapterManager As siscomDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibroventasDataGridView As DataGridView
    Friend WithEvents idventas As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents VER As DataGridViewButtonColumn
End Class

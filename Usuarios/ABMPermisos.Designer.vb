<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMPermisos
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalPermisos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PermisosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FuncionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desactivar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalFunciones = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FuncionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PermisosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.permisosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.FuncionesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.funcionesTableAdapter()
        Me.PerfilesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.perfilesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PermisosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FuncionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Perfil"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PerfilesBindingSource
        Me.ComboBox1.DisplayMember = "idperfil"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(245, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "idperfil"
        '
        'PerfilesBindingSource
        '
        Me.PerfilesBindingSource.DataMember = "perfiles"
        Me.PerfilesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelTotalPermisos)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PermisosDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 423)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Funciones habilitadas"
        '
        'LabelTotalPermisos
        '
        Me.LabelTotalPermisos.AutoSize = True
        Me.LabelTotalPermisos.Location = New System.Drawing.Point(496, 33)
        Me.LabelTotalPermisos.Name = "LabelTotalPermisos"
        Me.LabelTotalPermisos.Size = New System.Drawing.Size(16, 17)
        Me.LabelTotalPermisos.TabIndex = 3
        Me.LabelTotalPermisos.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'PermisosDataGridView
        '
        Me.PermisosDataGridView.AllowUserToAddRows = False
        Me.PermisosDataGridView.AllowUserToDeleteRows = False
        Me.PermisosDataGridView.AutoGenerateColumns = False
        Me.PermisosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.desactivar})
        Me.PermisosDataGridView.DataSource = Me.PermisosBindingSource
        Me.PermisosDataGridView.Location = New System.Drawing.Point(20, 68)
        Me.PermisosDataGridView.MultiSelect = False
        Me.PermisosDataGridView.Name = "PermisosDataGridView"
        Me.PermisosDataGridView.ReadOnly = True
        Me.PermisosDataGridView.RowTemplate.Height = 24
        Me.PermisosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PermisosDataGridView.Size = New System.Drawing.Size(496, 328)
        Me.PermisosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idpermisos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idpermisos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idfunciones"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.FuncionesBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Descripción"
        Me.DataGridViewTextBoxColumn2.ValueMember = "idfunciones"
        Me.DataGridViewTextBoxColumn2.Width = 260
        '
        'FuncionesBindingSource
        '
        Me.FuncionesBindingSource.DataMember = "funciones"
        Me.FuncionesBindingSource.DataSource = Me.ComercialDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idperfil"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idperfil"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "menuname"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Objeto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'desactivar
        '
        Me.desactivar.HeaderText = "Desactivar"
        Me.desactivar.Name = "desactivar"
        Me.desactivar.ReadOnly = True
        Me.desactivar.Text = "Desactivar"
        Me.desactivar.ToolTipText = "Desactivar"
        Me.desactivar.UseColumnTextForButtonValue = True
        '
        'PermisosBindingSource
        '
        Me.PermisosBindingSource.DataMember = "permisos"
        Me.PermisosBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelTotalFunciones)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.FuncionesDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(558, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 497)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Todas las funciones"
        '
        'LabelTotalFunciones
        '
        Me.LabelTotalFunciones.AutoSize = True
        Me.LabelTotalFunciones.Location = New System.Drawing.Point(503, 18)
        Me.LabelTotalFunciones.Name = "LabelTotalFunciones"
        Me.LabelTotalFunciones.Size = New System.Drawing.Size(16, 17)
        Me.LabelTotalFunciones.TabIndex = 5
        Me.LabelTotalFunciones.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'FuncionesDataGridView
        '
        Me.FuncionesDataGridView.AllowUserToAddRows = False
        Me.FuncionesDataGridView.AllowUserToDeleteRows = False
        Me.FuncionesDataGridView.AutoGenerateColumns = False
        Me.FuncionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.habilitar})
        Me.FuncionesDataGridView.DataSource = Me.FuncionesBindingSource
        Me.FuncionesDataGridView.Location = New System.Drawing.Point(20, 50)
        Me.FuncionesDataGridView.MultiSelect = False
        Me.FuncionesDataGridView.Name = "FuncionesDataGridView"
        Me.FuncionesDataGridView.ReadOnly = True
        Me.FuncionesDataGridView.RowTemplate.Height = 24
        Me.FuncionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FuncionesDataGridView.Size = New System.Drawing.Size(510, 419)
        Me.FuncionesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idfunciones"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idfunciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "menuname"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Objeto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'habilitar
        '
        Me.habilitar.HeaderText = "Hablitar"
        Me.habilitar.Name = "habilitar"
        Me.habilitar.ReadOnly = True
        Me.habilitar.Text = "Hablitar"
        Me.habilitar.ToolTipText = "Hablitar"
        Me.habilitar.UseColumnTextForButtonValue = True
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Me.FuncionesTableAdapter
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Me.PerfilesTableAdapter
        Me.TableAdapterManager.permisosTableAdapter = Me.PermisosTableAdapter
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'FuncionesTableAdapter
        '
        Me.FuncionesTableAdapter.ClearBeforeFill = True
        '
        'PerfilesTableAdapter
        '
        Me.PerfilesTableAdapter.ClearBeforeFill = True
        '
        'ABMPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 521)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABMPermisos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PermisosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FuncionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents PermisosBindingSource As BindingSource
    Friend WithEvents PermisosTableAdapter As comercialDataSetTableAdapters.permisosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PermisosDataGridView As DataGridView
    Friend WithEvents FuncionesTableAdapter As comercialDataSetTableAdapters.funcionesTableAdapter
    Friend WithEvents FuncionesBindingSource As BindingSource
    Friend WithEvents FuncionesDataGridView As DataGridView
    Friend WithEvents PerfilesTableAdapter As comercialDataSetTableAdapters.perfilesTableAdapter
    Friend WithEvents PerfilesBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents habilitar As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents desactivar As DataGridViewButtonColumn
    Friend WithEvents LabelTotalPermisos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTotalFunciones As Label
    Friend WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CajaAperturaCierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CajaAperturaCierre))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.LblEstadocaja = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CajaseventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaseventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.CajasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdcajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajasTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCaja)
        Me.GroupBox1.Controls.Add(Me.LblEstadocaja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCerrar)
        Me.GroupBox1.Controls.Add(Me.BtnAbrir)
        Me.GroupBox1.Location = New System.Drawing.Point(465, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(521, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(220, 36)
        Me.lblCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(51, 17)
        Me.lblCaja.TabIndex = 10
        Me.lblCaja.Text = "Label2"
        '
        'LblEstadocaja
        '
        Me.LblEstadocaja.AutoSize = True
        Me.LblEstadocaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblEstadocaja.Location = New System.Drawing.Point(275, 74)
        Me.LblEstadocaja.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblEstadocaja.Name = "LblEstadocaja"
        Me.LblEstadocaja.Size = New System.Drawing.Size(64, 20)
        Me.LblEstadocaja.TabIndex = 9
        Me.LblEstadocaja.Text = "evento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(144, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Estado actual:"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(105, 192)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(309, 43)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Cerrar Caja"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Location = New System.Drawing.Point(105, 134)
        Me.BtnAbrir.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(309, 43)
        Me.BtnAbrir.TabIndex = 6
        Me.BtnAbrir.Text = "Abrir Caja"
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CajaseventosDataGridView)
        Me.GroupBox2.Controls.Add(Me.CajasDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(441, 310)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cajas Disponibles"
        '
        'CajaseventosDataGridView
        '
        Me.CajaseventosDataGridView.AutoGenerateColumns = False
        Me.CajaseventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajaseventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CajaseventosDataGridView.DataSource = Me.CajaseventosBindingSource
        Me.CajaseventosDataGridView.Location = New System.Drawing.Point(449, 167)
        Me.CajaseventosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajaseventosDataGridView.Name = "CajaseventosDataGridView"
        Me.CajaseventosDataGridView.Size = New System.Drawing.Size(25, 22)
        Me.CajaseventosDataGridView.TabIndex = 1
        Me.CajaseventosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idevento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idevento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idcaja"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idcaja"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaapertura"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaapertura"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechacierre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechacierre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "saldoinicial"
        Me.DataGridViewTextBoxColumn5.HeaderText = "saldoinicial"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "saldofinal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "saldofinal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CajaseventosBindingSource
        '
        Me.CajaseventosBindingSource.DataMember = "cajaseventos"
        Me.CajaseventosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajasDataGridView
        '
        Me.CajasDataGridView.AllowUserToAddRows = False
        Me.CajasDataGridView.AllowUserToDeleteRows = False
        Me.CajasDataGridView.AutoGenerateColumns = False
        Me.CajasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcajaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.CajasDataGridView.DataSource = Me.CajasBindingSource
        Me.CajasDataGridView.Location = New System.Drawing.Point(24, 52)
        Me.CajasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CajasDataGridView.MultiSelect = False
        Me.CajasDataGridView.Name = "CajasDataGridView"
        Me.CajasDataGridView.ReadOnly = True
        Me.CajasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CajasDataGridView.Size = New System.Drawing.Size(392, 235)
        Me.CajasDataGridView.TabIndex = 0
        '
        'IdcajaDataGridViewTextBoxColumn
        '
        Me.IdcajaDataGridViewTextBoxColumn.DataPropertyName = "idcaja"
        Me.IdcajaDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.IdcajaDataGridViewTextBoxColumn.Name = "IdcajaDataGridViewTextBoxColumn"
        Me.IdcajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcajaDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CajasBindingSource
        '
        Me.CajasBindingSource.DataMember = "cajas"
        Me.CajasBindingSource.DataSource = Me.ComercialDataSet
        '
        'CajasTableAdapter
        '
        Me.CajasTableAdapter.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Me.CajaseventosTableAdapter
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Me.CajasTableAdapter
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
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
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'CajaAperturaCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 340)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CajaAperturaCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura / Cierre de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CajaseventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajaseventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents LblEstadocaja As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnAbrir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CajasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents CajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajasTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasTableAdapter
    Friend WithEvents IdcajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaseventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajaseventosTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajaseventosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
End Class

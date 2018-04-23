<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaRemitos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ListaremitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaremitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListaremitosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaremitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listaremitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosdetalleTableAdapter()
        Me.ListaremitosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaremitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListaremitosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaremitosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaremitosBindingSource
        '
        Me.ListaremitosBindingSource.DataMember = "listaremitos"
        Me.ListaremitosBindingSource.DataSource = Me.ComercialDataSet
        '
        'listaremitosdetalleBindingSource
        '
        Me.listaremitosdetalleBindingSource.DataMember = "listaremitosdetalle"
        Me.listaremitosdetalleBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListaremitosDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 623)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListaremitosDataGridView
        '
        Me.ListaremitosDataGridView.AllowUserToAddRows = False
        Me.ListaremitosDataGridView.AllowUserToDeleteRows = False
        Me.ListaremitosDataGridView.AllowUserToResizeColumns = False
        Me.ListaremitosDataGridView.AllowUserToResizeRows = False
        Me.ListaremitosDataGridView.AutoGenerateColumns = False
        Me.ListaremitosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaremitosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ListaremitosDataGridView.DataSource = Me.ListaremitosBindingSource1
        Me.ListaremitosDataGridView.Location = New System.Drawing.Point(15, 30)
        Me.ListaremitosDataGridView.MultiSelect = False
        Me.ListaremitosDataGridView.Name = "ListaremitosDataGridView"
        Me.ListaremitosDataGridView.ReadOnly = True
        Me.ListaremitosDataGridView.RowTemplate.Height = 24
        Me.ListaremitosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaremitosDataGridView.Size = New System.Drawing.Size(391, 580)
        Me.ListaremitosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idremito"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Remito N°"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tiporemito"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "usuariocarga"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ListaremitosTableAdapter
        '
        Me.ListaremitosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
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
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "MiComercio"
        ReportDataSource1.Value = Me.MiComercioBindingSource
        ReportDataSource2.Name = "listaremitos"
        ReportDataSource2.Value = Me.ListaremitosBindingSource
        ReportDataSource3.Name = "listaremitosdetalle"
        ReportDataSource3.Value = Me.listaremitosdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(443, 30)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(844, 592)
        Me.ReportViewer1.TabIndex = 1
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listaremitosdetalleTableAdapter
        '
        Me.listaremitosdetalleTableAdapter.ClearBeforeFill = True
        '
        'ListaremitosBindingSource1
        '
        Me.ListaremitosBindingSource1.DataMember = "listaremitos"
        Me.ListaremitosBindingSource1.DataSource = Me.ComercialDataSet
        '
        'ListaRemitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 644)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ListaRemitos"
        Me.Tag = "ListaRemitos"
        Me.Text = "Lista Remitos"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaremitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ListaremitosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaremitosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListaremitosBindingSource As BindingSource
    Friend WithEvents ListaremitosTableAdapter As comercialDataSetTableAdapters.listaremitosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListaremitosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents listaremitosdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listaremitosdetalleTableAdapter As comercialDataSetTableAdapters.listaremitosdetalleTableAdapter
    Friend WithEvents ListaremitosBindingSource1 As BindingSource
End Class

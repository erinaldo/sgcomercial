<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FondoAplicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FondoAplicacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ParametrosgeneralesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ParametrosgeneralesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ParametrosgeneralesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParametrosgeneralesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosgeneralesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParametrosgeneralesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ParametrosgeneralesDataGridView)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 379)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ParametrosgeneralesDataGridView
        '
        Me.ParametrosgeneralesDataGridView.AutoGenerateColumns = False
        Me.ParametrosgeneralesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParametrosgeneralesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1})
        Me.ParametrosgeneralesDataGridView.DataSource = Me.ParametrosgeneralesBindingSource
        Me.ParametrosgeneralesDataGridView.Location = New System.Drawing.Point(158, 109)
        Me.ParametrosgeneralesDataGridView.Name = "ParametrosgeneralesDataGridView"
        Me.ParametrosgeneralesDataGridView.RowTemplate.Height = 24
        Me.ParametrosgeneralesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ParametrosgeneralesDataGridView.TabIndex = 4
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
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ParametrosgeneralesBindingSource, "prgimagen1", True))
        Me.PictureBox1.Location = New System.Drawing.Point(13, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(703, 341)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ParametrosgeneralesBindingNavigator
        '
        Me.ParametrosgeneralesBindingNavigator.AddNewItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.BindingSource = Me.ParametrosgeneralesBindingSource
        Me.ParametrosgeneralesBindingNavigator.CountItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.DeleteItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ParametrosgeneralesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator1, Me.ParametrosgeneralesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.ParametrosgeneralesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParametrosgeneralesBindingNavigator.MoveFirstItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MoveLastItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MoveNextItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.MovePreviousItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.Name = "ParametrosgeneralesBindingNavigator"
        Me.ParametrosgeneralesBindingNavigator.PositionItem = Nothing
        Me.ParametrosgeneralesBindingNavigator.Size = New System.Drawing.Size(758, 27)
        Me.ParametrosgeneralesBindingNavigator.TabIndex = 1
        Me.ParametrosgeneralesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ParametrosgeneralesBindingNavigatorSaveItem
        '
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParametrosgeneralesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Name = "ParametrosgeneralesBindingNavigatorSaveItem"
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.ParametrosgeneralesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(163, 24)
        Me.ToolStripButton1.Text = "Seleccionar Imagen"
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Me.ParametrosgeneralesTableAdapter
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
        'FondoAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 411)
        Me.Controls.Add(Me.ParametrosgeneralesBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FondoAplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fondo Aplicacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ParametrosgeneralesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosgeneralesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParametrosgeneralesBindingNavigator.ResumeLayout(False)
        Me.ParametrosgeneralesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ParametrosgeneralesBindingSource As BindingSource
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParametrosgeneralesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents ParametrosgeneralesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ParametrosgeneralesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCventas
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
        Me.idventas = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VER = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSet = New sgcomercial.siscomDataSet()
        Me.LibroventasTableAdapter = New sgcomercial.siscomDataSetTableAdapters.libroventasTableAdapter()
        Me.TableAdapterManager = New sgcomercial.siscomDataSetTableAdapters.TableAdapterManager()
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
        Me.GroupBox1.Size = New System.Drawing.Size(779, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LibroventasDataGridView
        '
        Me.LibroventasDataGridView.AllowUserToAddRows = False
        Me.LibroventasDataGridView.AllowUserToDeleteRows = False
        Me.LibroventasDataGridView.AllowUserToResizeColumns = False
        Me.LibroventasDataGridView.AllowUserToResizeRows = False
        Me.LibroventasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibroventasDataGridView.AutoGenerateColumns = False
        Me.LibroventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibroventasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idventas, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.VER})
        Me.LibroventasDataGridView.DataSource = Me.LibroventasBindingSource
        Me.LibroventasDataGridView.Location = New System.Drawing.Point(16, 21)
        Me.LibroventasDataGridView.Name = "LibroventasDataGridView"
        Me.LibroventasDataGridView.ReadOnly = True
        Me.LibroventasDataGridView.RowTemplate.Height = 24
        Me.LibroventasDataGridView.Size = New System.Drawing.Size(743, 264)
        Me.LibroventasDataGridView.TabIndex = 0
        '
        'idventas
        '
        Me.idventas.DataPropertyName = "idventas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idventas.DefaultCellStyle = DataGridViewCellStyle1
        Me.idventas.HeaderText = "N°"
        Me.idventas.Name = "idventas"
        Me.idventas.ReadOnly = True
        Me.idventas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idventas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.idventas.ToolTipText = "Número Comprobante"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaventa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Fecha"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechavencimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vencimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Vencimiento"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'VER
        '
        Me.VER.HeaderText = "Ver/Imprimir"
        Me.VER.Name = "VER"
        Me.VER.ReadOnly = True
        Me.VER.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VER.Text = "Ver/Imprimir"
        Me.VER.ToolTipText = "Ver/Imprimir"
        Me.VER.UseColumnTextForButtonValue = True
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
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesmodulosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.siscomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'SCventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SCventas"
        Me.Text = "Mis Comprobantes"
        Me.TopMost = True
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
    Friend WithEvents idventas As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents VER As DataGridViewButtonColumn
End Class
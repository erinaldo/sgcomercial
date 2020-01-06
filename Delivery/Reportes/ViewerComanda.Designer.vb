<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewerComanda
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
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource12 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listapedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.listapedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDobleA5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComandera80 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listapedidosdeliveryBindingSource
        '
        Me.listapedidosdeliveryBindingSource.DataMember = "listapedidosdelivery"
        Me.listapedidosdeliveryBindingSource.DataSource = Me.comercialDataSet
        '
        'listapedidosdeliverydetalleBindingSource
        '
        Me.listapedidosdeliverydetalleBindingSource.DataMember = "listapedidosdeliverydetalle"
        Me.listapedidosdeliverydetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        ReportDataSource10.Name = "MiComercio"
        ReportDataSource10.Value = Me.MiComercioBindingSource
        ReportDataSource11.Name = "ListaPedidosDelivery"
        ReportDataSource11.Value = Me.listapedidosdeliveryBindingSource
        ReportDataSource12.Name = "ListaPedidosDeliveryDetalle"
        ReportDataSource12.Value = Me.listapedidosdeliverydetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource12)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportComanda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 526)
        Me.ReportViewer1.TabIndex = 0
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listapedidosdeliveryTableAdapter
        '
        Me.listapedidosdeliveryTableAdapter.ClearBeforeFill = True
        '
        'listapedidosdeliverydetalleTableAdapter
        '
        Me.listapedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDobleA5, Me.ToolStripComandera80})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(682, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDobleA5
        '
        Me.ToolStripDobleA5.Name = "ToolStripDobleA5"
        Me.ToolStripDobleA5.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripDobleA5.Text = "Orden Doble A5"
        '
        'ToolStripComandera80
        '
        Me.ToolStripComandera80.Name = "ToolStripComandera80"
        Me.ToolStripComandera80.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripComandera80.Text = "Orden 80mm"
        '
        'ViewerComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 554)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewerComanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "VisorComanda"
        Me.Text = "Vista previa de orden"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents listapedidosdeliveryBindingSource As BindingSource
    Friend WithEvents listapedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listapedidosdeliveryTableAdapter As comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter
    Friend WithEvents listapedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDobleA5 As ToolStripLabel
    Friend WithEvents ToolStripComandera80 As ToolStripLabel
End Class

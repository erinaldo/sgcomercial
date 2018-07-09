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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listapedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.listapedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MiComercio"
        ReportDataSource1.Value = Me.MiComercioBindingSource
        ReportDataSource2.Name = "ListaPedidosDelivery"
        ReportDataSource2.Value = Me.listapedidosdeliveryBindingSource
        ReportDataSource3.Name = "ListaPedidosDeliveryDetalle"
        ReportDataSource3.Value = Me.listapedidosdeliverydetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportComanda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1468, 670)
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
        'ViewerComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1468, 670)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ViewerComanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "VisorComanda"
        Me.Text = "Vista previa de orden"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents listapedidosdeliveryBindingSource As BindingSource
    Friend WithEvents listapedidosdeliverydetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listapedidosdeliveryTableAdapter As comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter
    Friend WithEvents listapedidosdeliverydetalleTableAdapter As comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter
End Class

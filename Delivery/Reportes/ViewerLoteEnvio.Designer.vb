<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerLoteEnvio
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listalotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listalotesdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listalotesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesTableAdapter()
        Me.listalotesdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listalotesdetalleTableAdapter()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listalotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'listalotesBindingSource
        '
        Me.listalotesBindingSource.DataMember = "listalotes"
        Me.listalotesBindingSource.DataSource = Me.comercialDataSet
        '
        'listalotesdetalleBindingSource
        '
        Me.listalotesdetalleBindingSource.DataMember = "listalotesdetalle"
        Me.listalotesdetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "MiComercio"
        ReportDataSource4.Value = Me.MiComercioBindingSource
        ReportDataSource5.Name = "listalotes"
        ReportDataSource5.Value = Me.listalotesBindingSource
        ReportDataSource6.Name = "listalotesdetalle"
        ReportDataSource6.Value = Me.listalotesdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportLoteEnvio.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1336, 684)
        Me.ReportViewer1.TabIndex = 0
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listalotesTableAdapter
        '
        Me.listalotesTableAdapter.ClearBeforeFill = True
        '
        'listalotesdetalleTableAdapter
        '
        Me.listalotesdetalleTableAdapter.ClearBeforeFill = True
        '
        'ViewerLoteEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 684)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ViewerLoteEnvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa Lote de Envío"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listalotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listalotesdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents listalotesBindingSource As BindingSource
    Friend WithEvents listalotesdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listalotesTableAdapter As comercialDataSetTableAdapters.listalotesTableAdapter
    Friend WithEvents listalotesdetalleTableAdapter As comercialDataSetTableAdapters.listalotesdetalleTableAdapter
End Class

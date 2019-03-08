<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerRemito
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
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listaremitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaremitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listaremitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosTableAdapter()
        Me.listaremitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosdetalleTableAdapter()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'listaremitosBindingSource
        '
        Me.listaremitosBindingSource.DataMember = "listaremitos"
        Me.listaremitosBindingSource.DataSource = Me.comercialDataSet
        '
        'listaremitosdetalleBindingSource
        '
        Me.listaremitosdetalleBindingSource.DataMember = "listaremitosdetalle"
        Me.listaremitosdetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MiComercio"
        ReportDataSource1.Value = Me.MiComercioBindingSource
        ReportDataSource2.Name = "listaremitos"
        ReportDataSource2.Value = Me.listaremitosBindingSource
        ReportDataSource3.Name = "listaremitosdetalle"
        ReportDataSource3.Value = Me.listaremitosdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(970, 747)
        Me.ReportViewer1.TabIndex = 0
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listaremitosTableAdapter
        '
        Me.listaremitosTableAdapter.ClearBeforeFill = True
        '
        'listaremitosdetalleTableAdapter
        '
        Me.listaremitosdetalleTableAdapter.ClearBeforeFill = True
        '
        'ViewerRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 747)
        Me.Controls.Add(Me.ReportViewer1)
        Me.KeyPreview = True
        Me.Name = "ViewerRemito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa Remito"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents listaremitosBindingSource As BindingSource
    Friend WithEvents listaremitosdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listaremitosTableAdapter As comercialDataSetTableAdapters.listaremitosTableAdapter
    Friend WithEvents listaremitosdetalleTableAdapter As comercialDataSetTableAdapters.listaremitosdetalleTableAdapter
End Class

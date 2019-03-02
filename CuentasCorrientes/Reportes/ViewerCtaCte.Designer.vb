<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerCtaCte
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listacuentascorrientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.listapedidosdeliverydetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listapedidosdeliverydetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliverydetalleTableAdapter()
        Me.listacuentascorrientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listacuentascorrientesTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloDeudasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'listacuentascorrientesBindingSource
        '
        Me.listacuentascorrientesBindingSource.DataMember = "listacuentascorrientes"
        Me.listacuentascorrientesBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "MiComercio"
        ReportDataSource3.Value = Me.MiComercioBindingSource
        ReportDataSource4.Name = "listacuentascorrientes"
        ReportDataSource4.Value = Me.listacuentascorrientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepResumenCtaCte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(971, 593)
        Me.ReportViewer1.TabIndex = 0
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listapedidosdeliveryBindingSource
        '
        Me.listapedidosdeliveryBindingSource.DataMember = "listapedidosdelivery"
        Me.listapedidosdeliveryBindingSource.DataSource = Me.comercialDataSet
        '
        'listapedidosdeliveryTableAdapter
        '
        Me.listapedidosdeliveryTableAdapter.ClearBeforeFill = True
        '
        'listapedidosdeliverydetalleBindingSource
        '
        Me.listapedidosdeliverydetalleBindingSource.DataMember = "listapedidosdeliverydetalle"
        Me.listapedidosdeliverydetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'listapedidosdeliverydetalleTableAdapter
        '
        Me.listapedidosdeliverydetalleTableAdapter.ClearBeforeFill = True
        '
        'listacuentascorrientesTableAdapter
        '
        Me.listacuentascorrientesTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoricoToolStripMenuItem, Me.SoloDeudasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(971, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HistoricoToolStripMenuItem
        '
        Me.HistoricoToolStripMenuItem.Name = "HistoricoToolStripMenuItem"
        Me.HistoricoToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.HistoricoToolStripMenuItem.Text = "Histórico"
        '
        'SoloDeudasToolStripMenuItem
        '
        Me.SoloDeudasToolStripMenuItem.Name = "SoloDeudasToolStripMenuItem"
        Me.SoloDeudasToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.SoloDeudasToolStripMenuItem.Text = "Solo Deudas"
        '
        'ViewerCtaCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 621)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewerCtaCte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ViewerCtaCte"
        Me.Text = "Vista Previa Cuenta Corriente"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listacuentascorrientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listapedidosdeliverydetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents listacuentascorrientesBindingSource As BindingSource
    Friend WithEvents listacuentascorrientesTableAdapter As comercialDataSetTableAdapters.listacuentascorrientesTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HistoricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloDeudasToolStripMenuItem As ToolStripMenuItem
End Class

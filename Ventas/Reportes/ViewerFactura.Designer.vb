<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewerFactura
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.libroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.libroventasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ivaresumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libroventasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasdetalleTableAdapter()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.libroventasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter()
        Me.ivaresumenTableAdapter = New sgcomercial.comercialDataSetTableAdapters.ivaresumenTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Comanda80mmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Comanda58mmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaA4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivaresumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'libroventasBindingSource
        '
        Me.libroventasBindingSource.DataMember = "libroventas"
        Me.libroventasBindingSource.DataSource = Me.comercialDataSet
        '
        'libroventasdetalleBindingSource
        '
        Me.libroventasdetalleBindingSource.DataMember = "libroventasdetalle"
        Me.libroventasdetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'ivaresumenBindingSource
        '
        Me.ivaresumenBindingSource.DataMember = "ivaresumen"
        Me.ivaresumenBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "MiComercio"
        ReportDataSource5.Value = Me.MiComercioBindingSource
        ReportDataSource6.Name = "libroventas"
        ReportDataSource6.Value = Me.libroventasBindingSource
        ReportDataSource7.Name = "libroventasdetalle"
        ReportDataSource7.Value = Me.libroventasdetalleBindingSource
        ReportDataSource8.Name = "ivaresumen"
        ReportDataSource8.Value = Me.ivaresumenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaIVA.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(732, 675)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.TabStop = False
        '
        'libroventasdetalleTableAdapter
        '
        Me.libroventasdetalleTableAdapter.ClearBeforeFill = True
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'libroventasTableAdapter
        '
        Me.libroventasTableAdapter.ClearBeforeFill = True
        '
        'ivaresumenTableAdapter
        '
        Me.ivaresumenTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Comanda80mmToolStripMenuItem, Me.Comanda58mmToolStripMenuItem, Me.HojaA4ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(732, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Comanda80mmToolStripMenuItem
        '
        Me.Comanda80mmToolStripMenuItem.Name = "Comanda80mmToolStripMenuItem"
        Me.Comanda80mmToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.Comanda80mmToolStripMenuItem.Text = "Comanda 80mm"
        '
        'Comanda58mmToolStripMenuItem
        '
        Me.Comanda58mmToolStripMenuItem.Name = "Comanda58mmToolStripMenuItem"
        Me.Comanda58mmToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.Comanda58mmToolStripMenuItem.Text = "Comanda 58mm"
        '
        'HojaA4ToolStripMenuItem
        '
        Me.HojaA4ToolStripMenuItem.Name = "HojaA4ToolStripMenuItem"
        Me.HojaA4ToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.HojaA4ToolStripMenuItem.Text = "Hoja A4"
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'ViewerFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 703)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ViewerFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura - Vista Previa "
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivaresumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents libroventasdetalleBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents libroventasdetalleTableAdapter As comercialDataSetTableAdapters.libroventasdetalleTableAdapter
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents libroventasBindingSource As BindingSource
    Friend WithEvents libroventasTableAdapter As comercialDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents ivaresumenBindingSource As BindingSource
    Friend WithEvents ivaresumenTableAdapter As comercialDataSetTableAdapters.ivaresumenTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Comanda80mmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Comanda58mmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HojaA4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
End Class

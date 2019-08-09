<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerPresupuestos
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
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.libropresupuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.libropresupuestosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.libropresupuestosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libropresupuestosTableAdapter()
        Me.libropresupuestosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libropresupuestosdetalleTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.A4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Comanda80mmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libropresupuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libropresupuestosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'libropresupuestosBindingSource
        '
        Me.libropresupuestosBindingSource.DataMember = "libropresupuestos"
        Me.libropresupuestosBindingSource.DataSource = Me.comercialDataSet
        '
        'libropresupuestosdetalleBindingSource
        '
        Me.libropresupuestosdetalleBindingSource.DataMember = "libropresupuestosdetalle"
        Me.libropresupuestosdetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource7.Name = "MiComercio"
        ReportDataSource7.Value = Me.MiComercioBindingSource
        ReportDataSource8.Name = "libropresupuestos"
        ReportDataSource8.Value = Me.libropresupuestosBindingSource
        ReportDataSource9.Name = "libropresupuestosdetalle"
        ReportDataSource9.Value = Me.libropresupuestosdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepPresupuesto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(874, 596)
        Me.ReportViewer1.TabIndex = 0
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'libropresupuestosTableAdapter
        '
        Me.libropresupuestosTableAdapter.ClearBeforeFill = True
        '
        'libropresupuestosdetalleTableAdapter
        '
        Me.libropresupuestosdetalleTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.A4ToolStripMenuItem, Me.Comanda80mmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'A4ToolStripMenuItem
        '
        Me.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem"
        Me.A4ToolStripMenuItem.Size = New System.Drawing.Size(39, 24)
        Me.A4ToolStripMenuItem.Text = "A4"
        '
        'Comanda80mmToolStripMenuItem
        '
        Me.Comanda80mmToolStripMenuItem.Name = "Comanda80mmToolStripMenuItem"
        Me.Comanda80mmToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.Comanda80mmToolStripMenuItem.Text = "Comanda 80mm"
        '
        'ViewerPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 624)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ViewerPresupuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ViewerPresupuestos"
        Me.Text = "Vista Previa Presupuestos"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libropresupuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libropresupuestosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents libropresupuestosBindingSource As BindingSource
    Friend WithEvents libropresupuestosdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents libropresupuestosTableAdapter As comercialDataSetTableAdapters.libropresupuestosTableAdapter
    Friend WithEvents libropresupuestosdetalleTableAdapter As comercialDataSetTableAdapters.libropresupuestosdetalleTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents A4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Comanda80mmToolStripMenuItem As ToolStripMenuItem
End Class

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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.listaremitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.listaremitosdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listaremitosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosTableAdapter()
        Me.listaremitosdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaremitosdetalleTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OcultarCostosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarCostosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarTotalEnvasadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ReportDataSource4.Name = "MiComercio"
        ReportDataSource4.Value = Me.MiComercioBindingSource
        ReportDataSource5.Name = "listaremitos"
        ReportDataSource5.Value = Me.listaremitosBindingSource
        ReportDataSource6.Name = "listaremitosdetalle"
        ReportDataSource6.Value = Me.listaremitosdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(970, 719)
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OcultarCostosToolStripMenuItem, Me.MostrarCostosToolStripMenuItem, Me.MostrarTotalEnvasadoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(970, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OcultarCostosToolStripMenuItem
        '
        Me.OcultarCostosToolStripMenuItem.Name = "OcultarCostosToolStripMenuItem"
        Me.OcultarCostosToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.OcultarCostosToolStripMenuItem.Text = "Ocultar Costos"
        '
        'MostrarCostosToolStripMenuItem
        '
        Me.MostrarCostosToolStripMenuItem.Name = "MostrarCostosToolStripMenuItem"
        Me.MostrarCostosToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.MostrarCostosToolStripMenuItem.Text = "Mostrar Costos"
        '
        'MostrarTotalEnvasadoToolStripMenuItem
        '
        Me.MostrarTotalEnvasadoToolStripMenuItem.Name = "MostrarTotalEnvasadoToolStripMenuItem"
        Me.MostrarTotalEnvasadoToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.MostrarTotalEnvasadoToolStripMenuItem.Text = "Mostrar Total Envasado"
        '
        'ViewerRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 747)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ViewerRemito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vista Previa Remito"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaremitosdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents listaremitosBindingSource As BindingSource
    Friend WithEvents listaremitosdetalleBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listaremitosTableAdapter As comercialDataSetTableAdapters.listaremitosTableAdapter
    Friend WithEvents listaremitosdetalleTableAdapter As comercialDataSetTableAdapters.listaremitosdetalleTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OcultarCostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarCostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarTotalEnvasadoToolStripMenuItem As ToolStripMenuItem
End Class

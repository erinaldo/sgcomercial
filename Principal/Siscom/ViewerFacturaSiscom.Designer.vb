<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerFacturaSiscom
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
        Me.libroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.siscomDataSet = New sgcomercial.siscomDataSet()
        Me.libroventasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libroventasTableAdapter = New sgcomercial.siscomDataSetTableAdapters.libroventasTableAdapter()
        Me.libroventasdetalleTableAdapter = New sgcomercial.siscomDataSetTableAdapters.libroventasdetalleTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EnviarPorEMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.siscomDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'libroventasBindingSource
        '
        Me.libroventasBindingSource.DataMember = "libroventas"
        Me.libroventasBindingSource.DataSource = Me.siscomDataSet
        '
        'siscomDataSet
        '
        Me.siscomDataSet.DataSetName = "siscomDataSet"
        Me.siscomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'libroventasdetalleBindingSource
        '
        Me.libroventasdetalleBindingSource.DataMember = "libroventasdetalle"
        Me.libroventasdetalleBindingSource.DataSource = Me.siscomDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "libroventas"
        ReportDataSource3.Value = Me.libroventasBindingSource
        ReportDataSource4.Name = "libroventasdetalle"
        ReportDataSource4.Value = Me.libroventasdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaSC.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 28)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1028, 614)
        Me.ReportViewer1.TabIndex = 0
        '
        'libroventasTableAdapter
        '
        Me.libroventasTableAdapter.ClearBeforeFill = True
        '
        'libroventasdetalleTableAdapter
        '
        Me.libroventasdetalleTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarPorEMailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EnviarPorEMailToolStripMenuItem
        '
        Me.EnviarPorEMailToolStripMenuItem.Name = "EnviarPorEMailToolStripMenuItem"
        Me.EnviarPorEMailToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.EnviarPorEMailToolStripMenuItem.Text = "Enviar por E-Mail"
        '
        'ViewerFacturaSiscom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 642)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewerFacturaSiscom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ViewerFacturaSiscom"
        Me.Text = "Vista Previa"
        Me.TopMost = True
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.siscomDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents libroventasBindingSource As BindingSource
    Friend WithEvents siscomDataSet As siscomDataSet
    Friend WithEvents libroventasdetalleBindingSource As BindingSource
    Friend WithEvents libroventasTableAdapter As siscomDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents libroventasdetalleTableAdapter As siscomDataSetTableAdapters.libroventasdetalleTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EnviarPorEMailToolStripMenuItem As ToolStripMenuItem
End Class

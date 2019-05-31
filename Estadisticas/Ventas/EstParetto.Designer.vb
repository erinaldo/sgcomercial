<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstParetto
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.EstABCResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstABCResumenTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstABCResumenTableAdapter()
        Me.EstClasificacionParetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstClasificacionParetoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(858, 579)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EstABCResumen"
        ReportDataSource1.Value = Me.EstABCResumenBindingSource
        ReportDataSource2.Name = "EstClasificacionPareto"
        ReportDataSource2.Value = Me.EstClasificacionParetoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphPareto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(852, 558)
        Me.ReportViewer1.TabIndex = 0
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstABCResumenBindingSource
        '
        Me.EstABCResumenBindingSource.DataMember = "EstABCResumen"
        Me.EstABCResumenBindingSource.DataSource = Me.comercialDataSet
        '
        'EstABCResumenTableAdapter
        '
        Me.EstABCResumenTableAdapter.ClearBeforeFill = True
        '
        'EstClasificacionParetoBindingSource
        '
        Me.EstClasificacionParetoBindingSource.DataMember = "EstClasificacionPareto"
        Me.EstClasificacionParetoBindingSource.DataSource = Me.comercialDataSet
        '
        'EstClasificacionParetoTableAdapter
        '
        Me.EstClasificacionParetoTableAdapter.ClearBeforeFill = True
        '
        'EstParetto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 603)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EstParetto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "EstParetto"
        Me.Text = "Principio de Paretto / Clasificación ABC"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents EstABCResumenBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents EstClasificacionParetoBindingSource As BindingSource
    Friend WithEvents EstABCResumenTableAdapter As comercialDataSetTableAdapters.EstABCResumenTableAdapter
    Friend WithEvents EstClasificacionParetoTableAdapter As comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter
End Class

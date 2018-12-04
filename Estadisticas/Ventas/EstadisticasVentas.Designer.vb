<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasVentas
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
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EstParetoParticipacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEstadistica = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstParetoParticipacionTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstParetoParticipacionTableAdapter()
        Me.EstABCResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstABCResumenTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstABCResumenTableAdapter()
        Me.EstClasificacionParetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstClasificacionParetoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter()
        IdclienteLabel = New System.Windows.Forms.Label()
        CType(Me.EstParetoParticipacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(17, 25)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(132, 17)
        IdclienteLabel.TabIndex = 16
        IdclienteLabel.Text = "Seleccione Informe:"
        '
        'EstParetoParticipacionBindingSource
        '
        Me.EstParetoParticipacionBindingSource.DataMember = "EstParetoParticipacion"
        Me.EstParetoParticipacionBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxEstadistica)
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'ComboBoxEstadistica
        '
        Me.ComboBoxEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstadistica.FormattingEnabled = True
        Me.ComboBoxEstadistica.Items.AddRange(New Object() {"Principio de Pareto"})
        Me.ComboBoxEstadistica.Location = New System.Drawing.Point(155, 22)
        Me.ComboBoxEstadistica.Name = "ComboBoxEstadistica"
        Me.ComboBoxEstadistica.Size = New System.Drawing.Size(155, 24)
        Me.ComboBoxEstadistica.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 526)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "EstABCResumen"
        ReportDataSource5.Value = Me.EstABCResumenBindingSource
        ReportDataSource6.Name = "EstClasificacionPareto"
        ReportDataSource6.Value = Me.EstClasificacionParetoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphPareto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(805, 505)
        Me.ReportViewer1.TabIndex = 0
        '
        'EstParetoParticipacionTableAdapter
        '
        Me.EstParetoParticipacionTableAdapter.ClearBeforeFill = True
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
        'EstadisticasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 612)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EstadisticasVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "EstadisticasVentas"
        Me.Text = "Estadisticas Ventas"
        CType(Me.EstParetoParticipacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxEstadistica As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents EstParetoParticipacionBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents EstParetoParticipacionTableAdapter As comercialDataSetTableAdapters.EstParetoParticipacionTableAdapter
    Friend WithEvents EstABCResumenBindingSource As BindingSource
    Friend WithEvents EstClasificacionParetoBindingSource As BindingSource
    Friend WithEvents EstABCResumenTableAdapter As comercialDataSetTableAdapters.EstABCResumenTableAdapter
    Friend WithEvents EstClasificacionParetoTableAdapter As comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibroDiario
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
        Me.librodiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New SGComercial.comercialDataSet()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxReporte = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cajasoperacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cajasoperacionesTableAdapter = New SGComercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Me.librodiarioTableAdapter = New SGComercial.comercialDataSetTableAdapters.librodiarioTableAdapter()
        Me.LibrodiarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New SGComercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.cajaresumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cajaresumenTableAdapter = New SGComercial.comercialDataSetTableAdapters.cajaresumenTableAdapter()
        CType(Me.librodiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrodiarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cajaresumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'librodiarioBindingSource
        '
        Me.librodiarioBindingSource.DataMember = "librodiario"
        Me.librodiarioBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.comercialDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxReporte)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(738, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Reporte:"
        '
        'ComboBoxReporte
        '
        Me.ComboBoxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReporte.FormattingEnabled = True
        Me.ComboBoxReporte.Items.AddRange(New Object() {"Ventas", "Gastos", "Extracciones"})
        Me.ComboBoxReporte.Location = New System.Drawing.Point(259, 44)
        Me.ComboBoxReporte.Name = "ComboBoxReporte"
        Me.ComboBoxReporte.Size = New System.Drawing.Size(154, 24)
        Me.ComboBoxReporte.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 45)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 112)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(738, 562)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SGComercial.RepLibroDiario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 23)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(722, 525)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.WaitControlDisplayAfter = 1
        '
        'cajasoperacionesBindingSource
        '
        Me.cajasoperacionesBindingSource.DataMember = "cajasoperaciones"
        Me.cajasoperacionesBindingSource.DataSource = Me.comercialDataSet
        '
        'cajasoperacionesTableAdapter
        '
        Me.cajasoperacionesTableAdapter.ClearBeforeFill = True
        '
        'librodiarioTableAdapter
        '
        Me.librodiarioTableAdapter.ClearBeforeFill = True
        '
        'LibrodiarioBindingSource1
        '
        Me.LibrodiarioBindingSource1.DataMember = "librodiario"
        Me.LibrodiarioBindingSource1.DataSource = Me.comercialDataSet
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'cajaresumenBindingSource
        '
        Me.cajaresumenBindingSource.DataMember = "cajaresumen"
        Me.cajaresumenBindingSource.DataSource = Me.comercialDataSet
        '
        'cajaresumenTableAdapter
        '
        Me.cajaresumenTableAdapter.ClearBeforeFill = True
        '
        'LibroDiario
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 683)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LibroDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Diario"
        CType(Me.librodiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.cajasoperacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrodiarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cajaresumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cajasoperacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents cajasoperacionesTableAdapter As sgcomercial.comercialDataSetTableAdapters.cajasoperacionesTableAdapter
    Friend WithEvents librodiarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents librodiarioTableAdapter As sgcomercial.comercialDataSetTableAdapters.librodiarioTableAdapter
    Friend WithEvents LibrodiarioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents ComboBoxReporte As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cajaresumenBindingSource As BindingSource
    Friend WithEvents cajaresumenTableAdapter As comercialDataSetTableAdapters.cajaresumenTableAdapter
End Class

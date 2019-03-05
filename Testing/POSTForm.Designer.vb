<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSTForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.libroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.libroventasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter()
        Me.libroventasdetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.libroventasdetalleTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasdetalleTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(348, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ENVIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(455, 114)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(453, 166)
        Me.WebBrowser1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 114)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(437, 166)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HTML"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Navegador"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(348, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Enviar Mail"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 325)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(896, 65)
        Me.DataGridView1.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 25)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cargar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(63, 495)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 38)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Imprimir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM9"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(261, 539)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(81, 45)
        Me.RichTextBox2.TabIndex = 9
        Me.RichTextBox2.Text = ""
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(261, 495)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 38)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Imprimir 2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PrintDocument
        '
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(296, 446)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "MiComercio"
        ReportDataSource1.Value = Me.MiComercioBindingSource
        ReportDataSource2.Name = "libroventas"
        ReportDataSource2.Value = Me.libroventasBindingSource
        ReportDataSource3.Name = "libroventasdetalle"
        ReportDataSource3.Value = Me.libroventasdetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(430, 396)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(483, 215)
        Me.ReportViewer1.TabIndex = 12
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
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'libroventasBindingSource
        '
        Me.libroventasBindingSource.DataMember = "libroventas"
        Me.libroventasBindingSource.DataSource = Me.comercialDataSet
        '
        'libroventasTableAdapter
        '
        Me.libroventasTableAdapter.ClearBeforeFill = True
        '
        'libroventasdetalleBindingSource
        '
        Me.libroventasdetalleBindingSource.DataMember = "libroventasdetalle"
        Me.libroventasdetalleBindingSource.DataSource = Me.comercialDataSet
        '
        'libroventasdetalleTableAdapter
        '
        Me.libroventasdetalleTableAdapter.ClearBeforeFill = True
        '
        'POSTForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 623)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "POSTForm"
        Me.Text = "POSTForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libroventasdetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents Button6 As Button
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents libroventasBindingSource As BindingSource
    Friend WithEvents libroventasdetalleBindingSource As BindingSource
    Friend WithEvents libroventasTableAdapter As comercialDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents libroventasdetalleTableAdapter As comercialDataSetTableAdapters.libroventasdetalleTableAdapter
End Class

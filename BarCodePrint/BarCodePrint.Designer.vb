<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BarCodePrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarCodePrint))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EAN132 = New System.Windows.Forms.Label()
        Me.labelcodev = New System.Windows.Forms.Label()
        Me.codev = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.productosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.BtnImprimir)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.EAN132)
        Me.GroupBox2.Controls.Add(Me.labelcodev)
        Me.GroupBox2.Controls.Add(Me.codev)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'LabelDescripcion
        '
        resources.ApplyResources(Me.LabelDescripcion, "LabelDescripcion")
        Me.LabelDescripcion.Name = "LabelDescripcion"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'PictureSeleccionarCliente
        '
        resources.ApplyResources(Me.PictureSeleccionarCliente, "PictureSeleccionarCliente")
        Me.PictureSeleccionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4"), resources.GetString("ComboBox1.Items5"), resources.GetString("ComboBox1.Items6")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'BtnImprimir
        '
        resources.ApplyResources(Me.BtnImprimir, "BtnImprimir")
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'EAN132
        '
        resources.ApplyResources(Me.EAN132, "EAN132")
        Me.EAN132.BackColor = System.Drawing.Color.White
        Me.EAN132.Name = "EAN132"
        '
        'labelcodev
        '
        resources.ApplyResources(Me.labelcodev, "labelcodev")
        Me.labelcodev.Name = "labelcodev"
        '
        'codev
        '
        resources.ApplyResources(Me.codev, "codev")
        Me.codev.Name = "codev"
        Me.codev.ReadOnly = True
        '
        'ReportViewer1
        '
        resources.ApplyResources(Me.ReportViewer1, "ReportViewer1")
        Me.ReportViewer1.IsDocumentMapWidthFixed = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepPlantillaBarCode.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.UseWaitCursor = True
        Me.ReportViewer1.WaitControlDisplayAfter = 1
        '
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BarCodePrint
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarCodePrint"
        Me.Tag = "BarCodePrint"
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EAN132 As Label
    Friend WithEvents labelcodev As Label
    Friend WithEvents codev As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents productosBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents productosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents Label3 As Label
End Class

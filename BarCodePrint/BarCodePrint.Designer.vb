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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.productosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.productosTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
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
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.ReportViewer1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Controls.Add(Me.ReportViewer2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBox1.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "productos"
        ReportDataSource2.Value = Me.productosBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEtiq3x6.rdlc"
        resources.ApplyResources(Me.ReportViewer2, "ReportViewer2")
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ShowBackButton = False
        Me.ReportViewer2.ShowContextMenu = False
        Me.ReportViewer2.ShowCredentialPrompts = False
        Me.ReportViewer2.ShowDocumentMapButton = False
        Me.ReportViewer2.ShowFindControls = False
        Me.ReportViewer2.ShowPageNavigationControls = False
        Me.ReportViewer2.ShowParameterPrompts = False
        Me.ReportViewer2.ShowPromptAreaButton = False
        Me.ReportViewer2.ShowStopButton = False
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
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'BarCodePrint
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarCodePrint"
        Me.Tag = "BarCodePrint"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ReportViewer2 As ReportViewer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
End Class

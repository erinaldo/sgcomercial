<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeConf
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TAFIPPTOVTA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TCUIT = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PATHP = New System.Windows.Forms.Label()
        Me.PATH = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TipocondicionivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.TWSFEV1P = New System.Windows.Forms.TextBox()
        Me.TWSFEV1H = New System.Windows.Forms.TextBox()
        Me.TWSAAP = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TWSAAH = New System.Windows.Forms.TextBox()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.TipocondicionivaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocondicionivaTableAdapter()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextIIBB = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextIIBB)
        Me.GroupBox1.Controls.Add(Me.TAFIPPTOVTA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TCUIT)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PATHP)
        Me.GroupBox1.Controls.Add(Me.PATH)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.TWSFEV1P)
        Me.GroupBox1.Controls.Add(Me.TWSFEV1H)
        Me.GroupBox1.Controls.Add(Me.TWSAAP)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TWSAAH)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TAFIPPTOVTA
        '
        Me.TAFIPPTOVTA.Location = New System.Drawing.Point(705, 36)
        Me.TAFIPPTOVTA.Name = "TAFIPPTOVTA"
        Me.TAFIPPTOVTA.Size = New System.Drawing.Size(63, 22)
        Me.TAFIPPTOVTA.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(627, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "PtoVta N°"
        '
        'TCUIT
        '
        Me.TCUIT.Location = New System.Drawing.Point(442, 36)
        Me.TCUIT.Name = "TCUIT"
        Me.TCUIT.Size = New System.Drawing.Size(179, 22)
        Me.TCUIT.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(227, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 26)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Seleccionar..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(368, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Solicitar TRA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PATHP
        '
        Me.PATHP.Location = New System.Drawing.Point(384, 318)
        Me.PATHP.Name = "PATHP"
        Me.PATHP.Size = New System.Drawing.Size(384, 23)
        Me.PATHP.TabIndex = 8
        Me.PATHP.Text = "..."
        Me.PATHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PATH
        '
        Me.PATH.Location = New System.Drawing.Point(384, 282)
        Me.PATH.Name = "PATH"
        Me.PATH.Size = New System.Drawing.Size(384, 23)
        Me.PATH.TabIndex = 8
        Me.PATH.Text = "..."
        Me.PATH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Seleccionar..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.TipocondicionivaBindingSource
        Me.ComboBox2.DisplayMember = "descripcion"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(227, 246)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(325, 24)
        Me.ComboBox2.TabIndex = 6
        Me.ComboBox2.ValueMember = "idtipocondicioniva"
        '
        'TipocondicionivaBindingSource
        '
        Me.TipocondicionivaBindingSource.DataMember = "tipocondicioniva"
        Me.TipocondicionivaBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TWSFEV1P
        '
        Me.TWSFEV1P.Location = New System.Drawing.Point(227, 210)
        Me.TWSFEV1P.Name = "TWSFEV1P"
        Me.TWSFEV1P.Size = New System.Drawing.Size(541, 22)
        Me.TWSFEV1P.TabIndex = 5
        '
        'TWSFEV1H
        '
        Me.TWSFEV1H.Location = New System.Drawing.Point(227, 174)
        Me.TWSFEV1H.Name = "TWSFEV1H"
        Me.TWSFEV1H.Size = New System.Drawing.Size(541, 22)
        Me.TWSFEV1H.TabIndex = 4
        '
        'TWSAAP
        '
        Me.TWSAAP.Location = New System.Drawing.Point(227, 138)
        Me.TWSAAP.Name = "TWSAAP"
        Me.TWSAAP.Size = New System.Drawing.Size(541, 22)
        Me.TWSAAP.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DESACTIVADO", "HOMOLOGACION", "PRODUCCION"})
        Me.ComboBox1.Location = New System.Drawing.Point(227, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "WSDL WSAA Producción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "WSDL FEV1 Producción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "WSDL FEV1 Homologación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WSDL WSAA Homologación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Certificado Producción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Certificado Homologación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mi Condicion Fte IVA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "CUIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modulo Facturación Electrónica"
        '
        'TWSAAH
        '
        Me.TWSAAH.Location = New System.Drawing.Point(227, 102)
        Me.TWSAAH.Name = "TWSAAH"
        Me.TWSAAH.Size = New System.Drawing.Size(540, 22)
        Me.TWSAAH.TabIndex = 0
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'TipocondicionivaTableAdapter
        '
        Me.TipocondicionivaTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(91, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "N° Inscripción IIBB"
        '
        'TextIIBB
        '
        Me.TextIIBB.Location = New System.Drawing.Point(227, 69)
        Me.TextIIBB.Name = "TextIIBB"
        Me.TextIIBB.Size = New System.Drawing.Size(209, 22)
        Me.TextIIBB.TabIndex = 15
        '
        'FeConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "FeConf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "FeConf"
        Me.Text = "Configuración Factura Electrónica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TWSFEV1P As TextBox
    Friend WithEvents TWSFEV1H As TextBox
    Friend WithEvents TWSAAP As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TWSAAH As TextBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipocondicionivaBindingSource As BindingSource
    Friend WithEvents TipocondicionivaTableAdapter As comercialDataSetTableAdapters.tipocondicionivaTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents PATH As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PATHP As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TCUIT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TAFIPPTOVTA As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextIIBB As TextBox
    Friend WithEvents Label11 As Label
End Class

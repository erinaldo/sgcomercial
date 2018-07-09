<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtasCtesPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtasCtesPagar))
        Me.nrocomprobante = New System.Windows.Forms.TextBox()
        Me.ComboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ComboFormapago = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pagotextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMontoaPagar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ParametrosgeneralesTableAdapter1 = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.CajaseventosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.cajaseventosTableAdapter()
        Me.PagosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.pagosTableAdapter()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nrocomprobante
        '
        Me.nrocomprobante.Location = New System.Drawing.Point(236, 138)
        Me.nrocomprobante.Name = "nrocomprobante"
        Me.nrocomprobante.Size = New System.Drawing.Size(217, 22)
        Me.nrocomprobante.TabIndex = 12
        '
        'ComboTipoComprobante
        '
        Me.ComboTipoComprobante.DataSource = Me.TipocomprobantesBindingSource
        Me.ComboTipoComprobante.DisplayMember = "descripcion"
        Me.ComboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipoComprobante.FormattingEnabled = True
        Me.ComboTipoComprobante.Location = New System.Drawing.Point(236, 75)
        Me.ComboTipoComprobante.Name = "ComboTipoComprobante"
        Me.ComboTipoComprobante.Size = New System.Drawing.Size(217, 24)
        Me.ComboTipoComprobante.TabIndex = 10
        Me.ComboTipoComprobante.ValueMember = "idtipocomprobante"
        '
        'TipocomprobantesBindingSource
        '
        Me.TipocomprobantesBindingSource.DataMember = "tipocomprobantes"
        Me.TipocomprobantesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboFormapago
        '
        Me.ComboFormapago.DataSource = Me.FormaspagoBindingSource
        Me.ComboFormapago.DisplayMember = "descripcion"
        Me.ComboFormapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFormapago.FormattingEnabled = True
        Me.ComboFormapago.Location = New System.Drawing.Point(236, 105)
        Me.ComboFormapago.Name = "ComboFormapago"
        Me.ComboFormapago.Size = New System.Drawing.Size(217, 24)
        Me.ComboFormapago.TabIndex = 11
        Me.ComboFormapago.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
        '
        'pagotextbox
        '
        Me.pagotextbox.Location = New System.Drawing.Point(236, 169)
        Me.pagotextbox.Name = "pagotextbox"
        Me.pagotextbox.Size = New System.Drawing.Size(112, 22)
        Me.pagotextbox.TabIndex = 14
        Me.pagotextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Monto pagado:"
        '
        'TextBoxMontoaPagar
        '
        Me.TextBoxMontoaPagar.Enabled = False
        Me.TextBoxMontoaPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMontoaPagar.Location = New System.Drawing.Point(236, 42)
        Me.TextBoxMontoaPagar.Name = "TextBoxMontoaPagar"
        Me.TextBoxMontoaPagar.Size = New System.Drawing.Size(112, 24)
        Me.TextBoxMontoaPagar.TabIndex = 5
        Me.TextBoxMontoaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "N° Comprobante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Forma pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo comprobante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Monto deuda:"
        '
        'TipocomprobantesTableAdapter
        '
        Me.TipocomprobantesTableAdapter.ClearBeforeFill = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ParametrosgeneralesTableAdapter1
        '
        Me.ParametrosgeneralesTableAdapter1.ClearBeforeFill = True
        '
        'CajaseventosTableAdapter
        '
        Me.CajaseventosTableAdapter.ClearBeforeFill = True
        '
        'PagosTableAdapter
        '
        Me.PagosTableAdapter.ClearBeforeFill = True
        '
        'CtasCtesPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 284)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nrocomprobante)
        Me.Controls.Add(Me.ComboTipoComprobante)
        Me.Controls.Add(Me.ComboFormapago)
        Me.Controls.Add(Me.pagotextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMontoaPagar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtasCtesPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CtasCtesPagar"
        Me.Text = "Pagar cuenta"
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nrocomprobante As TextBox
    Friend WithEvents ComboTipoComprobante As ComboBox
    Friend WithEvents ComboFormapago As ComboBox
    Friend WithEvents pagotextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMontoaPagar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipocomprobantesBindingSource As BindingSource
    Friend WithEvents TipocomprobantesTableAdapter As comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ParametrosgeneralesTableAdapter1 As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
    Friend WithEvents CajaseventosTableAdapter As comercialDataSetTableAdapters.cajaseventosTableAdapter
    Friend WithEvents PagosTableAdapter As comercialDataSetTableAdapters.pagosTableAdapter
End Class

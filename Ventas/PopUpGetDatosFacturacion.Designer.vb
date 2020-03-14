<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpGetDatosFacturacion
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
        Dim Label15 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim IdtipocomprobanteLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim FechaventaLabel As System.Windows.Forms.Label
        Dim NrocomprobanteLabel As System.Windows.Forms.Label
        Dim IdformapagoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBoxImporte = New System.Windows.Forms.TextBox()
        Me.DateTimePickerPeriodoHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerPeriodoDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechavencimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Idtipocomprobantecombo = New System.Windows.Forms.ComboBox()
        Me.TipocomprobantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.FechaventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboConcepto = New System.Windows.Forms.ComboBox()
        Me.TipoconceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.idformapagocombo = New System.Windows.Forms.ComboBox()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NrocomprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.TipocomprobantesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocomprobantesTableAdapter()
        Me.TipoconceptosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipoconceptosTableAdapter()
        Me.FormaspagoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.formaspagoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        IdtipocomprobanteLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        FechaventaLabel = New System.Windows.Forms.Label()
        NrocomprobanteLabel = New System.Windows.Forms.Label()
        IdformapagoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoconceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(294, 233)
        Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(49, 17)
        Label15.TabIndex = 31
        Label15.Text = "Hasta:"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Label15.Visible = False
        '
        'Label13
        '
        Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(6, 233)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(174, 17)
        Label13.TabIndex = 32
        Label13.Text = "Periodo Facturado Desde:"
        Label13.Visible = False
        '
        'IdtipocomprobanteLabel
        '
        IdtipocomprobanteLabel.AutoSize = True
        IdtipocomprobanteLabel.Location = New System.Drawing.Point(6, 34)
        IdtipocomprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdtipocomprobanteLabel.Name = "IdtipocomprobanteLabel"
        IdtipocomprobanteLabel.Size = New System.Drawing.Size(40, 17)
        IdtipocomprobanteLabel.TabIndex = 19
        IdtipocomprobanteLabel.Text = "Tipo:"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(263, 77)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 17)
        Label5.TabIndex = 29
        Label5.Text = "Fecha Vto.:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 161)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(72, 17)
        Label8.TabIndex = 23
        Label8.Text = "Concepto:"
        '
        'FechaventaLabel
        '
        FechaventaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FechaventaLabel.AutoSize = True
        FechaventaLabel.Location = New System.Drawing.Point(251, 34)
        FechaventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaventaLabel.Name = "FechaventaLabel"
        FechaventaLabel.Size = New System.Drawing.Size(92, 17)
        FechaventaLabel.TabIndex = 28
        FechaventaLabel.Text = "Fecha Venta:"
        FechaventaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NrocomprobanteLabel
        '
        NrocomprobanteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NrocomprobanteLabel.AutoSize = True
        NrocomprobanteLabel.Location = New System.Drawing.Point(6, 121)
        NrocomprobanteLabel.Name = "NrocomprobanteLabel"
        NrocomprobanteLabel.Size = New System.Drawing.Size(105, 17)
        NrocomprobanteLabel.TabIndex = 24
        NrocomprobanteLabel.Text = "N° Lote/Cupón:"
        NrocomprobanteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdformapagoLabel
        '
        IdformapagoLabel.AutoSize = True
        IdformapagoLabel.Location = New System.Drawing.Point(6, 77)
        IdformapagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdformapagoLabel.Name = "IdformapagoLabel"
        IdformapagoLabel.Size = New System.Drawing.Size(89, 17)
        IdformapagoLabel.TabIndex = 18
        IdformapagoLabel.Text = "Forma Pago:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(284, 121)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 24
        Label1.Text = "Importe:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.TextBoxImporte)
        Me.GroupBox5.Controls.Add(Me.DateTimePickerPeriodoHasta)
        Me.GroupBox5.Controls.Add(Me.DateTimePickerPeriodoDesde)
        Me.GroupBox5.Controls.Add(Label15)
        Me.GroupBox5.Controls.Add(Label13)
        Me.GroupBox5.Controls.Add(IdtipocomprobanteLabel)
        Me.GroupBox5.Controls.Add(Me.FechavencimientoDateTimePicker)
        Me.GroupBox5.Controls.Add(Label5)
        Me.GroupBox5.Controls.Add(Me.Idtipocomprobantecombo)
        Me.GroupBox5.Controls.Add(Label8)
        Me.GroupBox5.Controls.Add(Me.FechaventaDateTimePicker)
        Me.GroupBox5.Controls.Add(FechaventaLabel)
        Me.GroupBox5.Controls.Add(Label1)
        Me.GroupBox5.Controls.Add(NrocomprobanteLabel)
        Me.GroupBox5.Controls.Add(Me.ComboConcepto)
        Me.GroupBox5.Controls.Add(IdformapagoLabel)
        Me.GroupBox5.Controls.Add(Me.idformapagocombo)
        Me.GroupBox5.Controls.Add(Me.NrocomprobanteTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(478, 242)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Comprobante"
        '
        'TextBoxImporte
        '
        Me.TextBoxImporte.Enabled = False
        Me.TextBoxImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImporte.Location = New System.Drawing.Point(343, 117)
        Me.TextBoxImporte.Name = "TextBoxImporte"
        Me.TextBoxImporte.Size = New System.Drawing.Size(112, 24)
        Me.TextBoxImporte.TabIndex = 35
        Me.TextBoxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePickerPeriodoHasta
        '
        Me.DateTimePickerPeriodoHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerPeriodoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPeriodoHasta.Location = New System.Drawing.Point(343, 230)
        Me.DateTimePickerPeriodoHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerPeriodoHasta.Name = "DateTimePickerPeriodoHasta"
        Me.DateTimePickerPeriodoHasta.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePickerPeriodoHasta.TabIndex = 34
        Me.DateTimePickerPeriodoHasta.Visible = False
        '
        'DateTimePickerPeriodoDesde
        '
        Me.DateTimePickerPeriodoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerPeriodoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPeriodoDesde.Location = New System.Drawing.Point(181, 230)
        Me.DateTimePickerPeriodoDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerPeriodoDesde.Name = "DateTimePickerPeriodoDesde"
        Me.DateTimePickerPeriodoDesde.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePickerPeriodoDesde.TabIndex = 33
        Me.DateTimePickerPeriodoDesde.Visible = False
        '
        'FechavencimientoDateTimePicker
        '
        Me.FechavencimientoDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechavencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechavencimientoDateTimePicker.Location = New System.Drawing.Point(343, 74)
        Me.FechavencimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechavencimientoDateTimePicker.Name = "FechavencimientoDateTimePicker"
        Me.FechavencimientoDateTimePicker.Size = New System.Drawing.Size(112, 22)
        Me.FechavencimientoDateTimePicker.TabIndex = 30
        '
        'Idtipocomprobantecombo
        '
        Me.Idtipocomprobantecombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Idtipocomprobantecombo.DataSource = Me.TipocomprobantesBindingSource
        Me.Idtipocomprobantecombo.DisplayMember = "descripcion"
        Me.Idtipocomprobantecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idtipocomprobantecombo.FormattingEnabled = True
        Me.Idtipocomprobantecombo.Location = New System.Drawing.Point(48, 30)
        Me.Idtipocomprobantecombo.Margin = New System.Windows.Forms.Padding(4)
        Me.Idtipocomprobantecombo.Name = "Idtipocomprobantecombo"
        Me.Idtipocomprobantecombo.Size = New System.Drawing.Size(187, 24)
        Me.Idtipocomprobantecombo.TabIndex = 16
        Me.Idtipocomprobantecombo.ValueMember = "idtipocomprobante"
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
        'FechaventaDateTimePicker
        '
        Me.FechaventaDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaventaDateTimePicker.Location = New System.Drawing.Point(343, 31)
        Me.FechaventaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaventaDateTimePicker.Name = "FechaventaDateTimePicker"
        Me.FechaventaDateTimePicker.Size = New System.Drawing.Size(112, 22)
        Me.FechaventaDateTimePicker.TabIndex = 27
        '
        'ComboConcepto
        '
        Me.ComboConcepto.DataSource = Me.TipoconceptosBindingSource
        Me.ComboConcepto.DisplayMember = "descripción"
        Me.ComboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboConcepto.FormattingEnabled = True
        Me.ComboConcepto.Location = New System.Drawing.Point(80, 157)
        Me.ComboConcepto.Name = "ComboConcepto"
        Me.ComboConcepto.Size = New System.Drawing.Size(155, 24)
        Me.ComboConcepto.TabIndex = 26
        Me.ComboConcepto.ValueMember = "idtipoconcepto"
        '
        'TipoconceptosBindingSource
        '
        Me.TipoconceptosBindingSource.DataMember = "tipoconceptos"
        Me.TipoconceptosBindingSource.DataSource = Me.ComercialDataSet
        '
        'idformapagocombo
        '
        Me.idformapagocombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idformapagocombo.DataSource = Me.FormaspagoBindingSource
        Me.idformapagocombo.DisplayMember = "descripcion"
        Me.idformapagocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.idformapagocombo.FormattingEnabled = True
        Me.idformapagocombo.Location = New System.Drawing.Point(100, 73)
        Me.idformapagocombo.Margin = New System.Windows.Forms.Padding(4)
        Me.idformapagocombo.Name = "idformapagocombo"
        Me.idformapagocombo.Size = New System.Drawing.Size(135, 24)
        Me.idformapagocombo.TabIndex = 17
        Me.idformapagocombo.ValueMember = "idformapago"
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.ComercialDataSet
        '
        'NrocomprobanteTextBox
        '
        Me.NrocomprobanteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NrocomprobanteTextBox.Location = New System.Drawing.Point(118, 118)
        Me.NrocomprobanteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NrocomprobanteTextBox.Name = "NrocomprobanteTextBox"
        Me.NrocomprobanteTextBox.Size = New System.Drawing.Size(136, 22)
        Me.NrocomprobanteTextBox.TabIndex = 25
        '
        'TipocomprobantesTableAdapter
        '
        Me.TipocomprobantesTableAdapter.ClearBeforeFill = True
        '
        'TipoconceptosTableAdapter
        '
        Me.TipoconceptosTableAdapter.ClearBeforeFill = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(77, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "<< ENTER para confirmar y ESC para cancelar >>"
        '
        'PopUpGetDatosFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 266)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpGetDatosFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PopUpGetDatosFacturacion"
        Me.Text = "Facturación"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TipocomprobantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoconceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DateTimePickerPeriodoHasta As DateTimePicker
    Friend WithEvents DateTimePickerPeriodoDesde As DateTimePicker
    Friend WithEvents FechavencimientoDateTimePicker As DateTimePicker
    Friend WithEvents Idtipocomprobantecombo As ComboBox
    Friend WithEvents FechaventaDateTimePicker As DateTimePicker
    Friend WithEvents ComboConcepto As ComboBox
    Friend WithEvents idformapagocombo As ComboBox
    Friend WithEvents NrocomprobanteTextBox As TextBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents TipocomprobantesBindingSource As BindingSource
    Friend WithEvents TipocomprobantesTableAdapter As comercialDataSetTableAdapters.tipocomprobantesTableAdapter
    Friend WithEvents TipoconceptosBindingSource As BindingSource
    Friend WithEvents TipoconceptosTableAdapter As comercialDataSetTableAdapters.tipoconceptosTableAdapter
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As comercialDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents TextBoxImporte As TextBox
    Friend WithEvents Label2 As Label
End Class

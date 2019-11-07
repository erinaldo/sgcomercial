<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCRegistrarVenta
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSet = New sgcomercial.siscomDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxMensaje = New System.Windows.Forms.RichTextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New sgcomercial.siscomDataSetTableAdapters.clientesTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewDetalle = New System.Windows.Forms.DataGridView()
        Me.idproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idlistaprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechadesde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechahasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiscomDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(67, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "idclientes"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.SiscomDataSetBindingSource
        '
        'SiscomDataSetBindingSource
        '
        Me.SiscomDataSetBindingSource.DataSource = Me.SiscomDataSet
        Me.SiscomDataSetBindingSource.Position = 0
        '
        'SiscomDataSet
        '
        Me.SiscomDataSet.DataSetName = "siscomDataSet"
        Me.SiscomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBoxMensaje)
        Me.GroupBox1.Controls.Add(Me.LabelEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RichTextBoxMensaje
        '
        Me.RichTextBoxMensaje.Location = New System.Drawing.Point(83, 69)
        Me.RichTextBoxMensaje.Name = "RichTextBoxMensaje"
        Me.RichTextBoxMensaje.Size = New System.Drawing.Size(592, 57)
        Me.RichTextBoxMensaje.TabIndex = 5
        Me.RichTextBoxMensaje.Text = ""
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        Me.LabelEmail.Location = New System.Drawing.Point(394, 34)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(156, 17)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "....................................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mensaje:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'DateTimePickerVencimiento
        '
        Me.DateTimePickerVencimiento.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerVencimiento.Location = New System.Drawing.Point(835, 34)
        Me.DateTimePickerVencimiento.Name = "DateTimePickerVencimiento"
        Me.DateTimePickerVencimiento.Size = New System.Drawing.Size(113, 22)
        Me.DateTimePickerVencimiento.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(744, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Vecimiento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DataGridViewDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 274)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Location = New System.Drawing.Point(772, 243)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxTotal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(722, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total:"
        '
        'DataGridViewDetalle
        '
        Me.DataGridViewDetalle.AllowUserToAddRows = False
        Me.DataGridViewDetalle.AllowUserToDeleteRows = False
        Me.DataGridViewDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idproducto, Me.cantidad, Me.precioventa, Me.idlistaprecio, Me.descuento, Me.recargo, Me.fechadesde, Me.fechahasta, Me.subtotal})
        Me.DataGridViewDetalle.Location = New System.Drawing.Point(9, 21)
        Me.DataGridViewDetalle.Name = "DataGridViewDetalle"
        Me.DataGridViewDetalle.RowTemplate.Height = 24
        Me.DataGridViewDetalle.Size = New System.Drawing.Size(949, 206)
        Me.DataGridViewDetalle.TabIndex = 0
        '
        'idproducto
        '
        Me.idproducto.HeaderText = "idproducto"
        Me.idproducto.Name = "idproducto"
        Me.idproducto.Width = 104
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 91
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "precioventa"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.Width = 111
        '
        'idlistaprecio
        '
        Me.idlistaprecio.HeaderText = "idlistaprecio"
        Me.idlistaprecio.Name = "idlistaprecio"
        Me.idlistaprecio.Visible = False
        Me.idlistaprecio.Width = 112
        '
        'descuento
        '
        Me.descuento.HeaderText = "descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.Width = 103
        '
        'recargo
        '
        Me.recargo.HeaderText = "recargo"
        Me.recargo.Name = "recargo"
        Me.recargo.Width = 86
        '
        'fechadesde
        '
        Me.fechadesde.HeaderText = "fechadesde"
        Me.fechadesde.Name = "fechadesde"
        Me.fechadesde.Width = 111
        '
        'fechahasta
        '
        Me.fechahasta.HeaderText = "fechahasta"
        Me.fechahasta.Name = "fechahasta"
        Me.fechahasta.Width = 107
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Width = 87
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(964, 78)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SCRegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 520)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCRegistrarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SCRegistrarVenta"
        Me.Text = "Sistemas Comerciales - RegistrarVenta"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiscomDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SiscomDataSetBindingSource As BindingSource
    Friend WithEvents SiscomDataSet As siscomDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As siscomDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewDetalle As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idproducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents idlistaprecio As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents recargo As DataGridViewTextBoxColumn
    Friend WithEvents fechadesde As DataGridViewTextBoxColumn
    Friend WithEvents fechahasta As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePickerVencimiento As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBoxMensaje As RichTextBox
    Friend WithEvents Label5 As Label
End Class

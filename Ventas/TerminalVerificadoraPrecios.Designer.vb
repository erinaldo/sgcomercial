<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TerminalVerificadoraPrecios
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaprecioscajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ListaprecioscajaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaprecioscajaTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBoxProducto = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.et = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PreciokiloTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ListaprecioscajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(711, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(708, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código:"
        '
        'ListaprecioscajaBindingSource
        '
        Me.ListaprecioscajaBindingSource.DataMember = "listaprecioscaja"
        Me.ListaprecioscajaBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaprecioscajaTableAdapter
        '
        Me.ListaprecioscajaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'GroupBoxProducto
        '
        Me.GroupBoxProducto.Controls.Add(Me.Label6)
        Me.GroupBoxProducto.Controls.Add(Me.kt)
        Me.GroupBoxProducto.Controls.Add(Me.Label7)
        Me.GroupBoxProducto.Controls.Add(Me.et)
        Me.GroupBoxProducto.Controls.Add(Me.Label5)
        Me.GroupBoxProducto.Controls.Add(Me.Label4)
        Me.GroupBoxProducto.Controls.Add(Me.Label3)
        Me.GroupBoxProducto.Controls.Add(Me.Label2)
        Me.GroupBoxProducto.Controls.Add(Me.PreciokiloTextBox)
        Me.GroupBoxProducto.Controls.Add(Me.PrecioventaTextBox)
        Me.GroupBoxProducto.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBoxProducto.Location = New System.Drawing.Point(28, 154)
        Me.GroupBoxProducto.Name = "GroupBoxProducto"
        Me.GroupBoxProducto.Size = New System.Drawing.Size(1651, 808)
        Me.GroupBoxProducto.TabIndex = 8
        Me.GroupBoxProducto.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 640)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 146)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Descuento en efectivo:"
        '
        'kt
        '
        Me.kt.Font = New System.Drawing.Font("Exo 2.0 Medium", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.kt.Location = New System.Drawing.Point(1111, 651)
        Me.kt.Name = "kt"
        Me.kt.Size = New System.Drawing.Size(527, 103)
        Me.kt.TabIndex = 18
        Me.kt.TabStop = False
        Me.kt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(883, 666)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 56)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tarjeta:"
        '
        'et
        '
        Me.et.Font = New System.Drawing.Font("Exo 2.0 Medium", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.et.Location = New System.Drawing.Point(1111, 298)
        Me.et.Name = "et"
        Me.et.Size = New System.Drawing.Size(527, 103)
        Me.et.TabIndex = 15
        Me.et.TabStop = False
        Me.et.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(883, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 56)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tarjeta:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 146)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Descuento en efectivo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(684, 569)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 70)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Por Kilo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(662, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 70)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Envasado"
        '
        'PreciokiloTextBox
        '
        Me.PreciokiloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaprecioscajaBindingSource, "preciokilo", True))
        Me.PreciokiloTextBox.Font = New System.Drawing.Font("Exo 2.0 Medium", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreciokiloTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PreciokiloTextBox.Location = New System.Drawing.Point(353, 651)
        Me.PreciokiloTextBox.Name = "PreciokiloTextBox"
        Me.PreciokiloTextBox.Size = New System.Drawing.Size(439, 103)
        Me.PreciokiloTextBox.TabIndex = 0
        Me.PreciokiloTextBox.TabStop = False
        Me.PreciokiloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecioventaTextBox
        '
        Me.PrecioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaprecioscajaBindingSource, "precioventa", True))
        Me.PrecioventaTextBox.Font = New System.Drawing.Font("Exo 2.0 Medium", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PrecioventaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrecioventaTextBox.Location = New System.Drawing.Point(353, 298)
        Me.PrecioventaTextBox.Name = "PrecioventaTextBox"
        Me.PrecioventaTextBox.Size = New System.Drawing.Size(439, 103)
        Me.PrecioventaTextBox.TabIndex = 0
        Me.PrecioventaTextBox.TabStop = False
        Me.PrecioventaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.Color.White
        Me.DescripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaprecioscajaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Bookman Old Style", 34.0!, System.Drawing.FontStyle.Bold)
        Me.DescripcionTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(6, 32)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(1589, 67)
        Me.DescripcionTextBox.TabIndex = 8
        Me.DescripcionTextBox.TabStop = False
        Me.DescripcionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TerminalVerificadoraPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1691, 974)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TerminalVerificadoraPrecios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListaprecioscajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProducto.ResumeLayout(False)
        Me.GroupBoxProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListaprecioscajaBindingSource As BindingSource
    Friend WithEvents ListaprecioscajaTableAdapter As comercialDataSetTableAdapters.listaprecioscajaTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBoxProducto As GroupBox
    Friend WithEvents PreciokiloTextBox As TextBox
    Friend WithEvents PrecioventaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents et As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class

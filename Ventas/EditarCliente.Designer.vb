<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarCliente))
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim IdclientewebLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.IdclientewebTextBox = New System.Windows.Forms.TextBox()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        IdclientewebLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(IdclientewebLabel)
        Me.GroupBox1.Controls.Add(Me.IdclientewebTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.pagosTableAdapter = Nothing
        Me.TableAdapterManager.parametrosgeneralesTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.pedidosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.pedidosTableAdapter = Nothing
        Me.TableAdapterManager.perfilesTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.presupuestosTableAdapter = Nothing
        Me.TableAdapterManager.productoscomponentesTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipomotivosvalesTableAdapter = Nothing
        Me.TableAdapterManager.tipomovimientostockTableAdapter = Nothing
        Me.TableAdapterManager.transportesTableAdapter = Nothing
        Me.TableAdapterManager.unidadesmedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sgcomercial.comercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Nothing
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Nothing
        Me.ClientesBindingNavigator.MoveLastItem = Nothing
        Me.ClientesBindingNavigator.MoveNextItem = Nothing
        Me.ClientesBindingNavigator.MovePreviousItem = Nothing
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Nothing
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(497, 27)
        Me.ClientesBindingNavigator.TabIndex = 1
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(127, 24)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(33, 174)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(64, 17)
        IdclienteLabel.TabIndex = 0
        IdclienteLabel.Text = "idcliente:"
        IdclienteLabel.Visible = False
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(128, 171)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(311, 22)
        Me.IdclienteTextBox.TabIndex = 1
        Me.IdclienteTextBox.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(50, 34)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(118, 31)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(311, 22)
        Me.NombreTextBox.TabIndex = 3
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(44, 62)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 4
        TelefonoLabel.Text = "Teléfono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(118, 59)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(311, 22)
        Me.TelefonoTextBox.TabIndex = 5
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(66, 90)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(118, 87)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(311, 22)
        Me.EmailTextBox.TabIndex = 7
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(76, 118)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(36, 17)
        CuitLabel.TabIndex = 8
        CuitLabel.Text = "Cuit:"
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cuit", True))
        Me.CuitTextBox.Location = New System.Drawing.Point(118, 115)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(311, 22)
        Me.CuitTextBox.TabIndex = 9
        '
        'IdclientewebLabel
        '
        IdclientewebLabel.AutoSize = True
        IdclientewebLabel.Location = New System.Drawing.Point(33, 146)
        IdclientewebLabel.Name = "IdclientewebLabel"
        IdclientewebLabel.Size = New System.Drawing.Size(89, 17)
        IdclientewebLabel.TabIndex = 10
        IdclientewebLabel.Text = "idclienteweb:"
        IdclientewebLabel.Visible = False
        '
        'IdclientewebTextBox
        '
        Me.IdclientewebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idclienteweb", True))
        Me.IdclientewebTextBox.Location = New System.Drawing.Point(128, 143)
        Me.IdclientewebTextBox.Name = "IdclientewebTextBox"
        Me.IdclientewebTextBox.Size = New System.Drawing.Size(311, 22)
        Me.IdclientewebTextBox.TabIndex = 11
        Me.IdclientewebTextBox.Visible = False
        '
        'EditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 205)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "EditarCliente"
        Me.Text = "Editar Información de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents IdclientewebTextBox As TextBox
End Class

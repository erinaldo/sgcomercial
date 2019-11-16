<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaInscripcion
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
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaInscripcion))
        Dim LabelNombre As System.Windows.Forms.Label
        Dim LabelTelefono As System.Windows.Forms.Label
        Dim LabelDocumento As System.Windows.Forms.Label
        Dim LabelEmail As System.Windows.Forms.Label
        Dim LabelDocTipo As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBoxEditarCliente = New System.Windows.Forms.PictureBox()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListaclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ListaclientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaclientesTableAdapter()
        Me.PictureEditarAlumno = New System.Windows.Forms.PictureBox()
        Me.PictureSeleccionarAlumno = New System.Windows.Forms.PictureBox()
        Me.TextBoxIDAlumno = New System.Windows.Forms.TextBox()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        LabelNombre = New System.Windows.Forms.Label()
        LabelTelefono = New System.Windows.Forms.Label()
        LabelDocumento = New System.Windows.Forms.Label()
        LabelEmail = New System.Windows.Forms.Label()
        LabelDocTipo = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEditarAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LabelDocTipo)
        Me.GroupBox1.Controls.Add(Me.PictureBoxEditarCliente)
        Me.GroupBox1.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Controls.Add(LabelNombre)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(LabelTelefono)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(LabelEmail)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(LabelDocumento)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Tutor"
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(21, 33)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(75, 17)
        IdclienteLabel.TabIndex = 0
        IdclienteLabel.Text = "N° Cliente:"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(102, 30)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(54, 22)
        Me.IdclienteTextBox.TabIndex = 1
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(34, 66)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(28, 94)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 4
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(461, 66)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(423, 30)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(84, 17)
        CuitLabel.TabIndex = 8
        CuitLabel.Text = "Documento:"
        '
        'PictureBoxEditarCliente
        '
        Me.PictureBoxEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEditarCliente.Image = CType(resources.GetObject("PictureBoxEditarCliente.Image"), System.Drawing.Image)
        Me.PictureBoxEditarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxEditarCliente.Location = New System.Drawing.Point(213, 25)
        Me.PictureBoxEditarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxEditarCliente.Name = "PictureBoxEditarCliente"
        Me.PictureBoxEditarCliente.Size = New System.Drawing.Size(27, 27)
        Me.PictureBoxEditarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEditarCliente.TabIndex = 41
        Me.PictureBoxEditarCliente.TabStop = False
        Me.PictureBoxEditarCliente.Visible = False
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(182, 25)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(27, 27)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 40
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'LabelNombre
        '
        LabelNombre.AutoSize = True
        LabelNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "nombre", True))
        LabelNombre.Location = New System.Drawing.Point(99, 66)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New System.Drawing.Size(224, 17)
        LabelNombre.TabIndex = 2
        LabelNombre.Text = "___________________________"
        '
        'LabelTelefono
        '
        LabelTelefono.AutoSize = True
        LabelTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "telefono", True))
        LabelTelefono.Location = New System.Drawing.Point(99, 94)
        LabelTelefono.Name = "LabelTelefono"
        LabelTelefono.Size = New System.Drawing.Size(224, 17)
        LabelTelefono.TabIndex = 4
        LabelTelefono.Text = "___________________________"
        '
        'LabelDocumento
        '
        LabelDocumento.AutoSize = True
        LabelDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "docnro", True))
        LabelDocumento.Location = New System.Drawing.Point(570, 30)
        LabelDocumento.Name = "LabelDocumento"
        LabelDocumento.Size = New System.Drawing.Size(224, 17)
        LabelDocumento.TabIndex = 8
        LabelDocumento.Text = "___________________________"
        '
        'LabelEmail
        '
        LabelEmail.AutoSize = True
        LabelEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        LabelEmail.Location = New System.Drawing.Point(513, 66)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New System.Drawing.Size(224, 17)
        LabelEmail.TabIndex = 6
        LabelEmail.Text = "___________________________"
        '
        'LabelDocTipo
        '
        LabelDocTipo.AutoSize = True
        LabelDocTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaclientesBindingSource, "doctipo", True))
        LabelDocTipo.Location = New System.Drawing.Point(513, 30)
        LabelDocTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LabelDocTipo.Name = "LabelDocTipo"
        LabelDocTipo.Size = New System.Drawing.Size(40, 17)
        LabelDocTipo.TabIndex = 42
        LabelDocTipo.Text = "____"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxIDAlumno)
        Me.GroupBox2.Controls.Add(Me.PictureEditarAlumno)
        Me.GroupBox2.Controls.Add(Me.PictureSeleccionarAlumno)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 294)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Alumno"
        '
        'ListaclientesBindingSource
        '
        Me.ListaclientesBindingSource.DataMember = "listaclientes"
        Me.ListaclientesBindingSource.DataSource = Me.ComercialDataSet
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
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesalumnosTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
        Me.TableAdapterManager.estadosaiTableAdapter = Nothing
        Me.TableAdapterManager.estadosentregadeliveryTableAdapter = Nothing
        Me.TableAdapterManager.estadosordenmesaTableAdapter = Nothing
        Me.TableAdapterManager.estadospedidodeliveryTableAdapter = Nothing
        Me.TableAdapterManager.extraccionesTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.funcionesTableAdapter = Nothing
        Me.TableAdapterManager.gastosTableAdapter = Nothing
        Me.TableAdapterManager.gradosalumnosTableAdapter = Nothing
        Me.TableAdapterManager.gradosTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
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
        Me.TableAdapterManager.productosproveedoresTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.provinciasTableAdapter = Nothing
        Me.TableAdapterManager.remitosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.remitosTableAdapter = Nothing
        Me.TableAdapterManager.responsablesdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.salonesTableAdapter = Nothing
        Me.TableAdapterManager.serviciosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
        Me.TableAdapterManager.tipodocumentosTableAdapter = Nothing
        Me.TableAdapterManager.tipoestadosTableAdapter = Nothing
        Me.TableAdapterManager.tipogastosTableAdapter = Nothing
        Me.TableAdapterManager.tipoivaTableAdapter = Nothing
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
        'ListaclientesTableAdapter
        '
        Me.ListaclientesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 17)
        Label1.TabIndex = 1
        Label1.Text = "N° Alumno:"
        '
        'PictureEditarAlumno
        '
        Me.PictureEditarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEditarAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureEditarAlumno.Image = CType(resources.GetObject("PictureEditarAlumno.Image"), System.Drawing.Image)
        Me.PictureEditarAlumno.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureEditarAlumno.Location = New System.Drawing.Point(213, 26)
        Me.PictureEditarAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureEditarAlumno.Name = "PictureEditarAlumno"
        Me.PictureEditarAlumno.Size = New System.Drawing.Size(27, 27)
        Me.PictureEditarAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureEditarAlumno.TabIndex = 43
        Me.PictureEditarAlumno.TabStop = False
        Me.PictureEditarAlumno.Visible = False
        '
        'PictureSeleccionarAlumno
        '
        Me.PictureSeleccionarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeleccionarAlumno.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarAlumno.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarAlumno.Location = New System.Drawing.Point(182, 26)
        Me.PictureSeleccionarAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarAlumno.Name = "PictureSeleccionarAlumno"
        Me.PictureSeleccionarAlumno.Size = New System.Drawing.Size(27, 27)
        Me.PictureSeleccionarAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarAlumno.TabIndex = 42
        Me.PictureSeleccionarAlumno.TabStop = False
        '
        'TextBoxIDAlumno
        '
        Me.TextBoxIDAlumno.Enabled = False
        Me.TextBoxIDAlumno.Location = New System.Drawing.Point(102, 28)
        Me.TextBoxIDAlumno.Name = "TextBoxIDAlumno"
        Me.TextBoxIDAlumno.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxIDAlumno.TabIndex = 44
        '
        'AltaInscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AltaInscripcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "AltaInscripcion"
        Me.Text = "Alta Inscripcion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEditarAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdclienteTextBox As TextBox
    Friend WithEvents PictureBoxEditarCliente As PictureBox
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents ListaclientesBindingSource As BindingSource
    Friend WithEvents ListaclientesTableAdapter As comercialDataSetTableAdapters.listaclientesTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureEditarAlumno As PictureBox
    Friend WithEvents PictureSeleccionarAlumno As PictureBox
    Friend WithEvents TextBoxIDAlumno As TextBox
End Class

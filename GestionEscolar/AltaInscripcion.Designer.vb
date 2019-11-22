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
        Dim LabelNombre As System.Windows.Forms.Label
        Dim LabelTelefono As System.Windows.Forms.Label
        Dim LabelDocumento As System.Windows.Forms.Label
        Dim LabelEmail As System.Windows.Forms.Label
        Dim LabelDocTipo As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaInscripcion))
        Me.ListaclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEditarCliente = New System.Windows.Forms.PictureBox()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelAFechaNacimiento = New System.Windows.Forms.Label()
        Me.LibroalumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelADocumento = New System.Windows.Forms.Label()
        Me.LabelADocTipo = New System.Windows.Forms.Label()
        Me.LabelAnombre = New System.Windows.Forms.Label()
        Me.TextBoxIDAlumno = New System.Windows.Forms.TextBox()
        Me.PictureEditarAlumno = New System.Windows.Forms.PictureBox()
        Me.PictureSeleccionarAlumno = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClientesdomiciliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBoxEditarDomicilios = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelPrecioventa = New System.Windows.Forms.Label()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelServicio = New System.Windows.Forms.Label()
        Me.PictureServicio = New System.Windows.Forms.PictureBox()
        Me.TextBoxIdServicio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.ListaclientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaclientesTableAdapter()
        Me.LibroalumnosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroalumnosTableAdapter()
        Me.ClientesdomiciliosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
        Me.ServiciosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.serviciosTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelCursado = New System.Windows.Forms.Label()
        Me.GradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBoxCursado = New System.Windows.Forms.PictureBox()
        Me.TextBoxGrado = New System.Windows.Forms.TextBox()
        Me.ComboBoxCicloLectivo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCuatrimestre = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GradosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gradosTableAdapter()
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
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LibroalumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEditarAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEditarDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCursado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 17)
        Label1.TabIndex = 1
        Label1.Text = "N° Alumno:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(34, 65)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 17)
        Label2.TabIndex = 45
        Label2.Text = "Nombre:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(34, 94)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(84, 17)
        Label3.TabIndex = 46
        Label3.Text = "Documento:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(521, 65)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(125, 17)
        Label4.TabIndex = 46
        Label4.Text = "Fecha Nacimiento:"
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
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Enabled = False
        Me.IdclienteTextBox.Location = New System.Drawing.Point(102, 30)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(54, 22)
        Me.IdclienteTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelAFechaNacimiento)
        Me.GroupBox2.Controls.Add(Me.LabelADocumento)
        Me.GroupBox2.Controls.Add(Me.LabelADocTipo)
        Me.GroupBox2.Controls.Add(Me.LabelAnombre)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxIDAlumno)
        Me.GroupBox2.Controls.Add(Me.PictureEditarAlumno)
        Me.GroupBox2.Controls.Add(Me.PictureSeleccionarAlumno)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Alumno"
        '
        'LabelAFechaNacimiento
        '
        Me.LabelAFechaNacimiento.AutoSize = True
        Me.LabelAFechaNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroalumnosBindingSource, "fechanacimiento", True))
        Me.LabelAFechaNacimiento.Location = New System.Drawing.Point(652, 65)
        Me.LabelAFechaNacimiento.Name = "LabelAFechaNacimiento"
        Me.LabelAFechaNacimiento.Size = New System.Drawing.Size(72, 17)
        Me.LabelAFechaNacimiento.TabIndex = 47
        Me.LabelAFechaNacimiento.Text = "________"
        '
        'LibroalumnosBindingSource
        '
        Me.LibroalumnosBindingSource.DataMember = "libroalumnos"
        Me.LibroalumnosBindingSource.DataSource = Me.ComercialDataSet
        '
        'LabelADocumento
        '
        Me.LabelADocumento.AutoSize = True
        Me.LabelADocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroalumnosBindingSource, "documento", True))
        Me.LabelADocumento.Location = New System.Drawing.Point(189, 94)
        Me.LabelADocumento.Name = "LabelADocumento"
        Me.LabelADocumento.Size = New System.Drawing.Size(216, 17)
        Me.LabelADocumento.TabIndex = 47
        Me.LabelADocumento.Text = "__________________________"
        '
        'LabelADocTipo
        '
        Me.LabelADocTipo.AutoSize = True
        Me.LabelADocTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroalumnosBindingSource, "tipodocumento", True))
        Me.LabelADocTipo.Location = New System.Drawing.Point(124, 94)
        Me.LabelADocTipo.Name = "LabelADocTipo"
        Me.LabelADocTipo.Size = New System.Drawing.Size(80, 17)
        Me.LabelADocTipo.TabIndex = 47
        Me.LabelADocTipo.Text = "_________"
        '
        'LabelAnombre
        '
        Me.LabelAnombre.AutoSize = True
        Me.LabelAnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibroalumnosBindingSource, "nombre", True))
        Me.LabelAnombre.Location = New System.Drawing.Point(102, 65)
        Me.LabelAnombre.Name = "LabelAnombre"
        Me.LabelAnombre.Size = New System.Drawing.Size(216, 17)
        Me.LabelAnombre.TabIndex = 47
        Me.LabelAnombre.Text = "__________________________"
        '
        'TextBoxIDAlumno
        '
        Me.TextBoxIDAlumno.Enabled = False
        Me.TextBoxIDAlumno.Location = New System.Drawing.Point(102, 28)
        Me.TextBoxIDAlumno.Name = "TextBoxIDAlumno"
        Me.TextBoxIDAlumno.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxIDAlumno.TabIndex = 44
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.PictureBoxEditarDomicilios)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(826, 75)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Domicilio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesdomiciliosBindingSource, "direccion", True))
        Me.Label6.Location = New System.Drawing.Point(203, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "______________________________________"
        '
        'ClientesdomiciliosBindingSource
        '
        Me.ClientesdomiciliosBindingSource.DataMember = "clientesdomicilios"
        Me.ClientesdomiciliosBindingSource.DataSource = Me.ComercialDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Dirección:"
        '
        'PictureBoxEditarDomicilios
        '
        Me.PictureBoxEditarDomicilios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxEditarDomicilios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxEditarDomicilios.Image = CType(resources.GetObject("PictureBoxEditarDomicilios.Image"), System.Drawing.Image)
        Me.PictureBoxEditarDomicilios.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxEditarDomicilios.Location = New System.Drawing.Point(74, 27)
        Me.PictureBoxEditarDomicilios.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxEditarDomicilios.Name = "PictureBoxEditarDomicilios"
        Me.PictureBoxEditarDomicilios.Size = New System.Drawing.Size(31, 30)
        Me.PictureBoxEditarDomicilios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEditarDomicilios.TabIndex = 39
        Me.PictureBoxEditarDomicilios.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelPrecioventa)
        Me.GroupBox4.Controls.Add(Me.LabelServicio)
        Me.GroupBox4.Controls.Add(Me.PictureServicio)
        Me.GroupBox4.Controls.Add(Me.TextBoxIdServicio)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 385)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(826, 75)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tarifa / Servicio"
        '
        'LabelPrecioventa
        '
        Me.LabelPrecioventa.AutoSize = True
        Me.LabelPrecioventa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "precioventa", True))
        Me.LabelPrecioventa.Location = New System.Drawing.Point(663, 33)
        Me.LabelPrecioventa.Name = "LabelPrecioventa"
        Me.LabelPrecioventa.Size = New System.Drawing.Size(128, 17)
        Me.LabelPrecioventa.TabIndex = 43
        Me.LabelPrecioventa.Text = "_______________"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "servicios"
        Me.ServiciosBindingSource.DataSource = Me.ComercialDataSet
        '
        'LabelServicio
        '
        Me.LabelServicio.AutoSize = True
        Me.LabelServicio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "descripcion", True))
        Me.LabelServicio.Location = New System.Drawing.Point(245, 33)
        Me.LabelServicio.Name = "LabelServicio"
        Me.LabelServicio.Size = New System.Drawing.Size(320, 17)
        Me.LabelServicio.TabIndex = 42
        Me.LabelServicio.Text = "_______________________________________"
        '
        'PictureServicio
        '
        Me.PictureServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureServicio.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureServicio.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureServicio.Location = New System.Drawing.Point(182, 28)
        Me.PictureServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureServicio.Name = "PictureServicio"
        Me.PictureServicio.Size = New System.Drawing.Size(27, 27)
        Me.PictureServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureServicio.TabIndex = 41
        Me.PictureServicio.TabStop = False
        '
        'TextBoxIdServicio
        '
        Me.TextBoxIdServicio.Enabled = False
        Me.TextBoxIdServicio.Location = New System.Drawing.Point(102, 30)
        Me.TextBoxIdServicio.Name = "TextBoxIdServicio"
        Me.TextBoxIdServicio.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxIdServicio.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 546)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'LibroalumnosTableAdapter
        '
        Me.LibroalumnosTableAdapter.ClearBeforeFill = True
        '
        'ClientesdomiciliosTableAdapter
        '
        Me.ClientesdomiciliosTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelCursado)
        Me.GroupBox5.Controls.Add(Me.PictureBoxCursado)
        Me.GroupBox5.Controls.Add(Me.TextBoxGrado)
        Me.GroupBox5.Controls.Add(Me.ComboBoxCicloLectivo)
        Me.GroupBox5.Controls.Add(Me.ComboBoxCuatrimestre)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 466)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(826, 69)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cursado"
        '
        'LabelCursado
        '
        Me.LabelCursado.AutoSize = True
        Me.LabelCursado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradosBindingSource, "cursado", True))
        Me.LabelCursado.Location = New System.Drawing.Point(261, 31)
        Me.LabelCursado.Name = "LabelCursado"
        Me.LabelCursado.Size = New System.Drawing.Size(136, 17)
        Me.LabelCursado.TabIndex = 43
        Me.LabelCursado.Text = "________________"
        '
        'GradosBindingSource
        '
        Me.GradosBindingSource.DataMember = "grados"
        Me.GradosBindingSource.DataSource = Me.ComercialDataSet
        '
        'PictureBoxCursado
        '
        Me.PictureBoxCursado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxCursado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCursado.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxCursado.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBoxCursado.Location = New System.Drawing.Point(182, 26)
        Me.PictureBoxCursado.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxCursado.Name = "PictureBoxCursado"
        Me.PictureBoxCursado.Size = New System.Drawing.Size(27, 27)
        Me.PictureBoxCursado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCursado.TabIndex = 42
        Me.PictureBoxCursado.TabStop = False
        '
        'TextBoxGrado
        '
        Me.TextBoxGrado.Enabled = False
        Me.TextBoxGrado.Location = New System.Drawing.Point(102, 28)
        Me.TextBoxGrado.Name = "TextBoxGrado"
        Me.TextBoxGrado.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxGrado.TabIndex = 3
        '
        'ComboBoxCicloLectivo
        '
        Me.ComboBoxCicloLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCicloLectivo.FormattingEnabled = True
        Me.ComboBoxCicloLectivo.Items.AddRange(New Object() {"2020"})
        Me.ComboBoxCicloLectivo.Location = New System.Drawing.Point(734, 27)
        Me.ComboBoxCicloLectivo.Name = "ComboBoxCicloLectivo"
        Me.ComboBoxCicloLectivo.Size = New System.Drawing.Size(70, 24)
        Me.ComboBoxCicloLectivo.TabIndex = 2
        '
        'ComboBoxCuatrimestre
        '
        Me.ComboBoxCuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCuatrimestre.FormattingEnabled = True
        Me.ComboBoxCuatrimestre.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero"})
        Me.ComboBoxCuatrimestre.Location = New System.Drawing.Point(541, 27)
        Me.ComboBoxCuatrimestre.Name = "ComboBoxCuatrimestre"
        Me.ComboBoxCuatrimestre.Size = New System.Drawing.Size(85, 24)
        Me.ComboBoxCuatrimestre.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(638, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ciclo Lectivo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cuatrimestre:"
        '
        'GradosTableAdapter
        '
        Me.GradosTableAdapter.ClearBeforeFill = True
        '
        'AltaInscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 612)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "AltaInscripcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "AltaInscripcion"
        Me.Text = "Alta Inscripcion"
        CType(Me.ListaclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxEditarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.LibroalumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEditarAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ClientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEditarDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.GradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCursado, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LibroalumnosBindingSource As BindingSource
    Friend WithEvents LibroalumnosTableAdapter As comercialDataSetTableAdapters.libroalumnosTableAdapter
    Friend WithEvents LabelAFechaNacimiento As Label
    Friend WithEvents LabelADocumento As Label
    Friend WithEvents LabelADocTipo As Label
    Friend WithEvents LabelAnombre As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBoxEditarDomicilios As PictureBox
    Friend WithEvents ClientesdomiciliosBindingSource As BindingSource
    Friend WithEvents ClientesdomiciliosTableAdapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureServicio As PictureBox
    Friend WithEvents TextBoxIdServicio As TextBox
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As comercialDataSetTableAdapters.serviciosTableAdapter
    Friend WithEvents LabelPrecioventa As Label
    Friend WithEvents LabelServicio As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ComboBoxCuatrimestre As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxCicloLectivo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelCursado As Label
    Friend WithEvents PictureBoxCursado As PictureBox
    Friend WithEvents TextBoxGrado As TextBox
    Friend WithEvents GradosBindingSource As BindingSource
    Friend WithEvents GradosTableAdapter As comercialDataSetTableAdapters.gradosTableAdapter
End Class

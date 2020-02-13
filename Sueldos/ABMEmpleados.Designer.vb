<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMEmpleados
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
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FechaaltaLabel As System.Windows.Forms.Label
        Dim FechabajaLabel As System.Windows.Forms.Label
        Dim IdtipodocumentoLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim DomcalleLabel As System.Windows.Forms.Label
        Dim DomnumeroLabel As System.Windows.Forms.Label
        Dim DompisoLabel As System.Windows.Forms.Label
        Dim DomdeptoLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim CodigopostalLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NrojubilacionLabel As System.Windows.Forms.Label
        Dim NroinscripcionLabel As System.Windows.Forms.Label
        Dim RegimenLabel As System.Windows.Forms.Label
        Dim EstadocivilLabel As System.Windows.Forms.Label
        Dim IdincapacidadLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim FechanacimientoLabel As System.Windows.Forms.Label
        Dim IdcondicionLabel As System.Windows.Forms.Label
        Dim AdicionalfijoLabel As System.Windows.Forms.Label
        Dim SueldojornalLabel As System.Windows.Forms.Label
        Dim IdconvenioLabel As System.Windows.Forms.Label
        Dim IdobrasocialLabel As System.Windows.Forms.Label
        Dim TareaLabel As System.Windows.Forms.Label
        Dim IdsindicatoLabel As System.Windows.Forms.Label
        Dim IdgrupojerarquicoLabel As System.Windows.Forms.Label
        Dim IdcategoriaempleadoLabel As System.Windows.Forms.Label
        Dim IdcentrocostoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMEmpleados))
        Me.GroupABM = New System.Windows.Forms.GroupBox()
        Me.GroupLaborales = New System.Windows.Forms.GroupBox()
        Me.IdconvenioempleoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ConvenioempleoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdcondicionempleoComboBox = New System.Windows.Forms.ComboBox()
        Me.CondicionempleoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdgrupojerarquicoComboBox = New System.Windows.Forms.ComboBox()
        Me.GruposjerarquicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdcentrocostoComboBox = New System.Windows.Forms.ComboBox()
        Me.CentroscostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdcategoriaempleadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriasempleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdsindicatoComboBox = New System.Windows.Forms.ComboBox()
        Me.SindicatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdobrasocialComboBox = New System.Windows.Forms.ComboBox()
        Me.ObrassocialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdicionalfijoTextBox = New System.Windows.Forms.TextBox()
        Me.SueldojornalTextBox = New System.Windows.Forms.TextBox()
        Me.TareaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupDomCon = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigopostalTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.DomcalleTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.DomnumeroTextBox = New System.Windows.Forms.TextBox()
        Me.DomdeptoTextBox = New System.Windows.Forms.TextBox()
        Me.DompisoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupPersonales = New System.Windows.Forms.GroupBox()
        Me.IdincapacidadComboBox = New System.Windows.Forms.ComboBox()
        Me.IncapacidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdtipodocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.TipodocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EstadocivilTextBox = New System.Windows.Forms.TextBox()
        Me.FechanacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.GroupPrevisionales = New System.Windows.Forms.GroupBox()
        Me.NrojubilacionTextBox = New System.Windows.Forms.TextBox()
        Me.NroinscripcionTextBox = New System.Windows.Forms.TextBox()
        Me.RegimenTextBox = New System.Windows.Forms.TextBox()
        Me.IdempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaaltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechabajaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupListado = New System.Windows.Forms.GroupBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TipodocumentosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipodocumentosTableAdapter()
        Me.ObrassocialesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.obrassocialesTableAdapter()
        Me.SindicatosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.sindicatosTableAdapter()
        Me.CategoriasempleadosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.categoriasempleadosTableAdapter()
        Me.CentroscostoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.centroscostoTableAdapter()
        Me.GruposjerarquicosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.gruposjerarquicosTableAdapter()
        Me.IncapacidadesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.incapacidadesTableAdapter()
        Me.CondicionempleoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.condicionempleoTableAdapter()
        Me.ConvenioempleoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.convenioempleoTableAdapter()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        FechaaltaLabel = New System.Windows.Forms.Label()
        FechabajaLabel = New System.Windows.Forms.Label()
        IdtipodocumentoLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        DomcalleLabel = New System.Windows.Forms.Label()
        DomnumeroLabel = New System.Windows.Forms.Label()
        DompisoLabel = New System.Windows.Forms.Label()
        DomdeptoLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        CodigopostalLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NrojubilacionLabel = New System.Windows.Forms.Label()
        NroinscripcionLabel = New System.Windows.Forms.Label()
        RegimenLabel = New System.Windows.Forms.Label()
        EstadocivilLabel = New System.Windows.Forms.Label()
        IdincapacidadLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        FechanacimientoLabel = New System.Windows.Forms.Label()
        IdcondicionLabel = New System.Windows.Forms.Label()
        AdicionalfijoLabel = New System.Windows.Forms.Label()
        SueldojornalLabel = New System.Windows.Forms.Label()
        IdconvenioLabel = New System.Windows.Forms.Label()
        IdobrasocialLabel = New System.Windows.Forms.Label()
        TareaLabel = New System.Windows.Forms.Label()
        IdsindicatoLabel = New System.Windows.Forms.Label()
        IdgrupojerarquicoLabel = New System.Windows.Forms.Label()
        IdcategoriaempleadoLabel = New System.Windows.Forms.Label()
        IdcentrocostoLabel = New System.Windows.Forms.Label()
        Me.GroupABM.SuspendLayout()
        Me.GroupLaborales.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConvenioempleoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CondicionempleoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposjerarquicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroscostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasempleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrassocialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDomCon.SuspendLayout()
        Me.GroupPersonales.SuspendLayout()
        CType(Me.IncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPrevisionales.SuspendLayout()
        Me.GroupListado.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(34, 29)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(62, 17)
        ApellidoLabel.TabIndex = 2
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(34, 59)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'FechaaltaLabel
        '
        FechaaltaLabel.AutoSize = True
        FechaaltaLabel.Location = New System.Drawing.Point(547, 21)
        FechaaltaLabel.Name = "FechaaltaLabel"
        FechaaltaLabel.Size = New System.Drawing.Size(79, 17)
        FechaaltaLabel.TabIndex = 6
        FechaaltaLabel.Text = "Fecha Alta:"
        '
        'FechabajaLabel
        '
        FechabajaLabel.AutoSize = True
        FechabajaLabel.Location = New System.Drawing.Point(543, 49)
        FechabajaLabel.Name = "FechabajaLabel"
        FechabajaLabel.Size = New System.Drawing.Size(83, 17)
        FechabajaLabel.TabIndex = 8
        FechabajaLabel.Text = "Fecha Baja:"
        '
        'IdtipodocumentoLabel
        '
        IdtipodocumentoLabel.AutoSize = True
        IdtipodocumentoLabel.Location = New System.Drawing.Point(23, 88)
        IdtipodocumentoLabel.Name = "IdtipodocumentoLabel"
        IdtipodocumentoLabel.Size = New System.Drawing.Size(73, 17)
        IdtipodocumentoLabel.TabIndex = 10
        IdtipodocumentoLabel.Text = "Tipo Doc.:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(194, 88)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(84, 17)
        DocumentoLabel.TabIndex = 12
        DocumentoLabel.Text = "Documento:"
        '
        'DomcalleLabel
        '
        DomcalleLabel.AutoSize = True
        DomcalleLabel.Location = New System.Drawing.Point(41, 34)
        DomcalleLabel.Name = "DomcalleLabel"
        DomcalleLabel.Size = New System.Drawing.Size(43, 17)
        DomcalleLabel.TabIndex = 14
        DomcalleLabel.Text = "Calle:"
        '
        'DomnumeroLabel
        '
        DomnumeroLabel.AutoSize = True
        DomnumeroLabel.Location = New System.Drawing.Point(22, 63)
        DomnumeroLabel.Name = "DomnumeroLabel"
        DomnumeroLabel.Size = New System.Drawing.Size(62, 17)
        DomnumeroLabel.TabIndex = 16
        DomnumeroLabel.Text = "Número:"
        '
        'DompisoLabel
        '
        DompisoLabel.AutoSize = True
        DompisoLabel.Location = New System.Drawing.Point(135, 63)
        DompisoLabel.Name = "DompisoLabel"
        DompisoLabel.Size = New System.Drawing.Size(39, 17)
        DompisoLabel.TabIndex = 18
        DompisoLabel.Text = "Piso:"
        '
        'DomdeptoLabel
        '
        DomdeptoLabel.AutoSize = True
        DomdeptoLabel.Location = New System.Drawing.Point(240, 63)
        DomdeptoLabel.Name = "DomdeptoLabel"
        DomdeptoLabel.Size = New System.Drawing.Size(54, 17)
        DomdeptoLabel.TabIndex = 20
        DomdeptoLabel.Text = "Depto.:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(11, 95)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(73, 17)
        LocalidadLabel.TabIndex = 22
        LocalidadLabel.Text = "Localidad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(14, 123)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(70, 17)
        ProvinciaLabel.TabIndex = 24
        ProvinciaLabel.Text = "Provincia:"
        '
        'CodigopostalLabel
        '
        CodigopostalLabel.AutoSize = True
        CodigopostalLabel.Location = New System.Drawing.Point(254, 95)
        CodigopostalLabel.Name = "CodigopostalLabel"
        CodigopostalLabel.Size = New System.Drawing.Size(30, 17)
        CodigopostalLabel.TabIndex = 26
        CodigopostalLabel.Text = "CP:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(48, 149)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(36, 17)
        TelefonoLabel.TabIndex = 28
        TelefonoLabel.Text = "Tel.:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(33, 176)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 17)
        EmailLabel.TabIndex = 30
        EmailLabel.Text = "E-Mail:"
        '
        'NrojubilacionLabel
        '
        NrojubilacionLabel.AutoSize = True
        NrojubilacionLabel.Location = New System.Drawing.Point(10, 24)
        NrojubilacionLabel.Name = "NrojubilacionLabel"
        NrojubilacionLabel.Size = New System.Drawing.Size(80, 17)
        NrojubilacionLabel.TabIndex = 32
        NrojubilacionLabel.Text = "N° Jubilac.:"
        '
        'NroinscripcionLabel
        '
        NroinscripcionLabel.AutoSize = True
        NroinscripcionLabel.Location = New System.Drawing.Point(29, 52)
        NroinscripcionLabel.Name = "NroinscripcionLabel"
        NroinscripcionLabel.Size = New System.Drawing.Size(61, 17)
        NroinscripcionLabel.TabIndex = 34
        NroinscripcionLabel.Text = "N° Insc.:"
        '
        'RegimenLabel
        '
        RegimenLabel.AutoSize = True
        RegimenLabel.Location = New System.Drawing.Point(218, 24)
        RegimenLabel.Name = "RegimenLabel"
        RegimenLabel.Size = New System.Drawing.Size(68, 17)
        RegimenLabel.TabIndex = 36
        RegimenLabel.Text = "Régimen:"
        '
        'EstadocivilLabel
        '
        EstadocivilLabel.AutoSize = True
        EstadocivilLabel.Location = New System.Drawing.Point(11, 121)
        EstadocivilLabel.Name = "EstadocivilLabel"
        EstadocivilLabel.Size = New System.Drawing.Size(85, 17)
        EstadocivilLabel.TabIndex = 46
        EstadocivilLabel.Text = "Estado Civíl:"
        '
        'IdincapacidadLabel
        '
        IdincapacidadLabel.AutoSize = True
        IdincapacidadLabel.Location = New System.Drawing.Point(8, 158)
        IdincapacidadLabel.Name = "IdincapacidadLabel"
        IdincapacidadLabel.Size = New System.Drawing.Size(88, 17)
        IdincapacidadLabel.TabIndex = 48
        IdincapacidadLabel.Text = "Incapacidad:"
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(6, 186)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(90, 17)
        NacionalidadLabel.TabIndex = 50
        NacionalidadLabel.Text = "Nacionalidad"
        '
        'FechanacimientoLabel
        '
        FechanacimientoLabel.AutoSize = True
        FechanacimientoLabel.Location = New System.Drawing.Point(12, 215)
        FechanacimientoLabel.Name = "FechanacimientoLabel"
        FechanacimientoLabel.Size = New System.Drawing.Size(84, 17)
        FechanacimientoLabel.TabIndex = 52
        FechanacimientoLabel.Text = "Fecha Nac.:"
        '
        'IdcondicionLabel
        '
        IdcondicionLabel.AutoSize = True
        IdcondicionLabel.Location = New System.Drawing.Point(77, 113)
        IdcondicionLabel.Name = "IdcondicionLabel"
        IdcondicionLabel.Size = New System.Drawing.Size(74, 17)
        IdcondicionLabel.TabIndex = 71
        IdcondicionLabel.Text = "Condición:"
        '
        'AdicionalfijoLabel
        '
        AdicionalfijoLabel.AutoSize = True
        AdicionalfijoLabel.Location = New System.Drawing.Point(82, 172)
        AdicionalfijoLabel.Name = "AdicionalfijoLabel"
        AdicionalfijoLabel.Size = New System.Drawing.Size(69, 17)
        AdicionalfijoLabel.TabIndex = 75
        AdicionalfijoLabel.Text = "Adic. Fijo:"
        '
        'SueldojornalLabel
        '
        SueldojornalLabel.AutoSize = True
        SueldojornalLabel.Location = New System.Drawing.Point(52, 143)
        SueldojornalLabel.Name = "SueldojornalLabel"
        SueldojornalLabel.Size = New System.Drawing.Size(99, 17)
        SueldojornalLabel.TabIndex = 73
        SueldojornalLabel.Text = "Sueldo/Jornal:"
        '
        'IdconvenioLabel
        '
        IdconvenioLabel.AutoSize = True
        IdconvenioLabel.Location = New System.Drawing.Point(80, 82)
        IdconvenioLabel.Name = "IdconvenioLabel"
        IdconvenioLabel.Size = New System.Drawing.Size(71, 17)
        IdconvenioLabel.TabIndex = 72
        IdconvenioLabel.Text = "Convenio:"
        '
        'IdobrasocialLabel
        '
        IdobrasocialLabel.AutoSize = True
        IdobrasocialLabel.Location = New System.Drawing.Point(65, 270)
        IdobrasocialLabel.Name = "IdobrasocialLabel"
        IdobrasocialLabel.Size = New System.Drawing.Size(86, 17)
        IdobrasocialLabel.TabIndex = 79
        IdobrasocialLabel.Text = "Obra Social:"
        '
        'TareaLabel
        '
        TareaLabel.AutoSize = True
        TareaLabel.Location = New System.Drawing.Point(105, 52)
        TareaLabel.Name = "TareaLabel"
        TareaLabel.Size = New System.Drawing.Size(46, 17)
        TareaLabel.TabIndex = 77
        TareaLabel.Text = "Tarea"
        '
        'IdsindicatoLabel
        '
        IdsindicatoLabel.AutoSize = True
        IdsindicatoLabel.Location = New System.Drawing.Point(81, 300)
        IdsindicatoLabel.Name = "IdsindicatoLabel"
        IdsindicatoLabel.Size = New System.Drawing.Size(70, 17)
        IdsindicatoLabel.TabIndex = 80
        IdsindicatoLabel.Text = "Sindicato:"
        '
        'IdgrupojerarquicoLabel
        '
        IdgrupojerarquicoLabel.AutoSize = True
        IdgrupojerarquicoLabel.Location = New System.Drawing.Point(28, 22)
        IdgrupojerarquicoLabel.Name = "IdgrupojerarquicoLabel"
        IdgrupojerarquicoLabel.Size = New System.Drawing.Size(123, 17)
        IdgrupojerarquicoLabel.TabIndex = 83
        IdgrupojerarquicoLabel.Text = "Grupo Jerárquico:"
        '
        'IdcategoriaempleadoLabel
        '
        IdcategoriaempleadoLabel.AutoSize = True
        IdcategoriaempleadoLabel.Location = New System.Drawing.Point(78, 240)
        IdcategoriaempleadoLabel.Name = "IdcategoriaempleadoLabel"
        IdcategoriaempleadoLabel.Size = New System.Drawing.Size(73, 17)
        IdcategoriaempleadoLabel.TabIndex = 81
        IdcategoriaempleadoLabel.Text = "Categoría:"
        '
        'IdcentrocostoLabel
        '
        IdcentrocostoLabel.AutoSize = True
        IdcentrocostoLabel.Location = New System.Drawing.Point(57, 202)
        IdcentrocostoLabel.Name = "IdcentrocostoLabel"
        IdcentrocostoLabel.Size = New System.Drawing.Size(94, 17)
        IdcentrocostoLabel.TabIndex = 82
        IdcentrocostoLabel.Text = "Centro Costo:"
        '
        'GroupABM
        '
        Me.GroupABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupABM.Controls.Add(Me.GroupLaborales)
        Me.GroupABM.Controls.Add(Me.GroupDomCon)
        Me.GroupABM.Controls.Add(Me.GroupPersonales)
        Me.GroupABM.Controls.Add(Me.GroupPrevisionales)
        Me.GroupABM.Controls.Add(Me.IdempleadoTextBox)
        Me.GroupABM.Controls.Add(FechaaltaLabel)
        Me.GroupABM.Controls.Add(Me.FechaaltaDateTimePicker)
        Me.GroupABM.Controls.Add(FechabajaLabel)
        Me.GroupABM.Controls.Add(Me.FechabajaDateTimePicker)
        Me.GroupABM.Location = New System.Drawing.Point(12, 50)
        Me.GroupABM.Name = "GroupABM"
        Me.GroupABM.Size = New System.Drawing.Size(797, 516)
        Me.GroupABM.TabIndex = 0
        Me.GroupABM.TabStop = False
        '
        'GroupLaborales
        '
        Me.GroupLaborales.Controls.Add(Me.IdconvenioempleoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdcondicionempleoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdgrupojerarquicoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdcentrocostoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdcategoriaempleadoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdsindicatoComboBox)
        Me.GroupLaborales.Controls.Add(Me.IdobrasocialComboBox)
        Me.GroupLaborales.Controls.Add(IdcondicionLabel)
        Me.GroupLaborales.Controls.Add(Me.AdicionalfijoTextBox)
        Me.GroupLaborales.Controls.Add(AdicionalfijoLabel)
        Me.GroupLaborales.Controls.Add(Me.SueldojornalTextBox)
        Me.GroupLaborales.Controls.Add(SueldojornalLabel)
        Me.GroupLaborales.Controls.Add(IdconvenioLabel)
        Me.GroupLaborales.Controls.Add(Me.TareaTextBox)
        Me.GroupLaborales.Controls.Add(IdobrasocialLabel)
        Me.GroupLaborales.Controls.Add(TareaLabel)
        Me.GroupLaborales.Controls.Add(IdsindicatoLabel)
        Me.GroupLaborales.Controls.Add(IdgrupojerarquicoLabel)
        Me.GroupLaborales.Controls.Add(IdcategoriaempleadoLabel)
        Me.GroupLaborales.Controls.Add(IdcentrocostoLabel)
        Me.GroupLaborales.Location = New System.Drawing.Point(404, 163)
        Me.GroupLaborales.Name = "GroupLaborales"
        Me.GroupLaborales.Size = New System.Drawing.Size(380, 333)
        Me.GroupLaborales.TabIndex = 69
        Me.GroupLaborales.TabStop = False
        Me.GroupLaborales.Text = "Datos Laborales"
        '
        'IdconvenioempleoComboBox
        '
        Me.IdconvenioempleoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idcondicionempleo", True))
        Me.IdconvenioempleoComboBox.DataSource = Me.ConvenioempleoBindingSource
        Me.IdconvenioempleoComboBox.DisplayMember = "descripcion"
        Me.IdconvenioempleoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdconvenioempleoComboBox.FormattingEnabled = True
        Me.IdconvenioempleoComboBox.Location = New System.Drawing.Point(152, 78)
        Me.IdconvenioempleoComboBox.Name = "IdconvenioempleoComboBox"
        Me.IdconvenioempleoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdconvenioempleoComboBox.TabIndex = 90
        Me.IdconvenioempleoComboBox.ValueMember = "idconvenioempleo"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConvenioempleoBindingSource
        '
        Me.ConvenioempleoBindingSource.DataMember = "convenioempleo"
        Me.ConvenioempleoBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdcondicionempleoComboBox
        '
        Me.IdcondicionempleoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idcondicionempleo", True))
        Me.IdcondicionempleoComboBox.DataSource = Me.CondicionempleoBindingSource
        Me.IdcondicionempleoComboBox.DisplayMember = "descripcion"
        Me.IdcondicionempleoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdcondicionempleoComboBox.FormattingEnabled = True
        Me.IdcondicionempleoComboBox.Location = New System.Drawing.Point(152, 109)
        Me.IdcondicionempleoComboBox.Name = "IdcondicionempleoComboBox"
        Me.IdcondicionempleoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdcondicionempleoComboBox.TabIndex = 88
        Me.IdcondicionempleoComboBox.ValueMember = "idcondicionempleo"
        '
        'CondicionempleoBindingSource
        '
        Me.CondicionempleoBindingSource.DataMember = "condicionempleo"
        Me.CondicionempleoBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdgrupojerarquicoComboBox
        '
        Me.IdgrupojerarquicoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idgrupojerarquico", True))
        Me.IdgrupojerarquicoComboBox.DataSource = Me.GruposjerarquicosBindingSource
        Me.IdgrupojerarquicoComboBox.DisplayMember = "descripcion"
        Me.IdgrupojerarquicoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdgrupojerarquicoComboBox.FormattingEnabled = True
        Me.IdgrupojerarquicoComboBox.Location = New System.Drawing.Point(152, 18)
        Me.IdgrupojerarquicoComboBox.Name = "IdgrupojerarquicoComboBox"
        Me.IdgrupojerarquicoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdgrupojerarquicoComboBox.TabIndex = 87
        Me.IdgrupojerarquicoComboBox.ValueMember = "idgrupojerarquico"
        '
        'GruposjerarquicosBindingSource
        '
        Me.GruposjerarquicosBindingSource.DataMember = "gruposjerarquicos"
        Me.GruposjerarquicosBindingSource.DataSource = Me.ComercialDataSetBindingSource
        '
        'ComercialDataSetBindingSource
        '
        Me.ComercialDataSetBindingSource.DataSource = Me.ComercialDataSet
        Me.ComercialDataSetBindingSource.Position = 0
        '
        'IdcentrocostoComboBox
        '
        Me.IdcentrocostoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idcentrocosto", True))
        Me.IdcentrocostoComboBox.DataSource = Me.CentroscostoBindingSource
        Me.IdcentrocostoComboBox.DisplayMember = "descripcion"
        Me.IdcentrocostoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdcentrocostoComboBox.FormattingEnabled = True
        Me.IdcentrocostoComboBox.Location = New System.Drawing.Point(152, 198)
        Me.IdcentrocostoComboBox.Name = "IdcentrocostoComboBox"
        Me.IdcentrocostoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdcentrocostoComboBox.TabIndex = 86
        Me.IdcentrocostoComboBox.ValueMember = "idcentrocosto"
        '
        'CentroscostoBindingSource
        '
        Me.CentroscostoBindingSource.DataMember = "centroscosto"
        Me.CentroscostoBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdcategoriaempleadoComboBox
        '
        Me.IdcategoriaempleadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idcategoriaempleado", True))
        Me.IdcategoriaempleadoComboBox.DataSource = Me.CategoriasempleadosBindingSource
        Me.IdcategoriaempleadoComboBox.DisplayMember = "categoria"
        Me.IdcategoriaempleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdcategoriaempleadoComboBox.FormattingEnabled = True
        Me.IdcategoriaempleadoComboBox.Location = New System.Drawing.Point(152, 236)
        Me.IdcategoriaempleadoComboBox.Name = "IdcategoriaempleadoComboBox"
        Me.IdcategoriaempleadoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdcategoriaempleadoComboBox.TabIndex = 85
        Me.IdcategoriaempleadoComboBox.ValueMember = "idcategoriaempleado"
        '
        'CategoriasempleadosBindingSource
        '
        Me.CategoriasempleadosBindingSource.DataMember = "categoriasempleados"
        Me.CategoriasempleadosBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdsindicatoComboBox
        '
        Me.IdsindicatoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idsindicato", True))
        Me.IdsindicatoComboBox.DataSource = Me.SindicatosBindingSource
        Me.IdsindicatoComboBox.DisplayMember = "nombre"
        Me.IdsindicatoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdsindicatoComboBox.FormattingEnabled = True
        Me.IdsindicatoComboBox.Location = New System.Drawing.Point(152, 296)
        Me.IdsindicatoComboBox.Name = "IdsindicatoComboBox"
        Me.IdsindicatoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdsindicatoComboBox.TabIndex = 84
        Me.IdsindicatoComboBox.ValueMember = "idsindicato"
        '
        'SindicatosBindingSource
        '
        Me.SindicatosBindingSource.DataMember = "sindicatos"
        Me.SindicatosBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdobrasocialComboBox
        '
        Me.IdobrasocialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idobrasocial", True))
        Me.IdobrasocialComboBox.DataSource = Me.ObrassocialesBindingSource
        Me.IdobrasocialComboBox.DisplayMember = "nombre"
        Me.IdobrasocialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdobrasocialComboBox.FormattingEnabled = True
        Me.IdobrasocialComboBox.Location = New System.Drawing.Point(152, 266)
        Me.IdobrasocialComboBox.Name = "IdobrasocialComboBox"
        Me.IdobrasocialComboBox.Size = New System.Drawing.Size(200, 24)
        Me.IdobrasocialComboBox.TabIndex = 89
        Me.IdobrasocialComboBox.ValueMember = "idobrasocial"
        '
        'ObrassocialesBindingSource
        '
        Me.ObrassocialesBindingSource.DataMember = "obrassociales"
        Me.ObrassocialesBindingSource.DataSource = Me.ComercialDataSet
        '
        'AdicionalfijoTextBox
        '
        Me.AdicionalfijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "adicionalfijo", True))
        Me.AdicionalfijoTextBox.Location = New System.Drawing.Point(152, 169)
        Me.AdicionalfijoTextBox.Name = "AdicionalfijoTextBox"
        Me.AdicionalfijoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AdicionalfijoTextBox.TabIndex = 76
        '
        'SueldojornalTextBox
        '
        Me.SueldojornalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "sueldojornal", True))
        Me.SueldojornalTextBox.Location = New System.Drawing.Point(152, 140)
        Me.SueldojornalTextBox.Name = "SueldojornalTextBox"
        Me.SueldojornalTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SueldojornalTextBox.TabIndex = 74
        '
        'TareaTextBox
        '
        Me.TareaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "tarea", True))
        Me.TareaTextBox.Location = New System.Drawing.Point(152, 49)
        Me.TareaTextBox.Name = "TareaTextBox"
        Me.TareaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TareaTextBox.TabIndex = 78
        '
        'GroupDomCon
        '
        Me.GroupDomCon.Controls.Add(DomcalleLabel)
        Me.GroupDomCon.Controls.Add(Me.EmailTextBox)
        Me.GroupDomCon.Controls.Add(EmailLabel)
        Me.GroupDomCon.Controls.Add(Me.TelefonoTextBox)
        Me.GroupDomCon.Controls.Add(TelefonoLabel)
        Me.GroupDomCon.Controls.Add(Me.CodigopostalTextBox)
        Me.GroupDomCon.Controls.Add(CodigopostalLabel)
        Me.GroupDomCon.Controls.Add(Me.ProvinciaTextBox)
        Me.GroupDomCon.Controls.Add(ProvinciaLabel)
        Me.GroupDomCon.Controls.Add(Me.DomcalleTextBox)
        Me.GroupDomCon.Controls.Add(Me.LocalidadTextBox)
        Me.GroupDomCon.Controls.Add(DomnumeroLabel)
        Me.GroupDomCon.Controls.Add(LocalidadLabel)
        Me.GroupDomCon.Controls.Add(Me.DomnumeroTextBox)
        Me.GroupDomCon.Controls.Add(Me.DomdeptoTextBox)
        Me.GroupDomCon.Controls.Add(DompisoLabel)
        Me.GroupDomCon.Controls.Add(DomdeptoLabel)
        Me.GroupDomCon.Controls.Add(Me.DompisoTextBox)
        Me.GroupDomCon.Location = New System.Drawing.Point(10, 274)
        Me.GroupDomCon.Name = "GroupDomCon"
        Me.GroupDomCon.Size = New System.Drawing.Size(388, 222)
        Me.GroupDomCon.TabIndex = 68
        Me.GroupDomCon.TabStop = False
        Me.GroupDomCon.Text = "Domicilio y Contacto"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(87, 176)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 31
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(87, 148)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoTextBox.TabIndex = 29
        '
        'CodigopostalTextBox
        '
        Me.CodigopostalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigopostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "codigopostal", True))
        Me.CodigopostalTextBox.Location = New System.Drawing.Point(290, 92)
        Me.CodigopostalTextBox.Name = "CodigopostalTextBox"
        Me.CodigopostalTextBox.Size = New System.Drawing.Size(79, 22)
        Me.CodigopostalTextBox.TabIndex = 27
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(87, 120)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ProvinciaTextBox.TabIndex = 25
        '
        'DomcalleTextBox
        '
        Me.DomcalleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DomcalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "domcalle", True))
        Me.DomcalleTextBox.Location = New System.Drawing.Point(87, 34)
        Me.DomcalleTextBox.Name = "DomcalleTextBox"
        Me.DomcalleTextBox.Size = New System.Drawing.Size(282, 22)
        Me.DomcalleTextBox.TabIndex = 15
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(87, 92)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(134, 22)
        Me.LocalidadTextBox.TabIndex = 23
        '
        'DomnumeroTextBox
        '
        Me.DomnumeroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DomnumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "domnumero", True))
        Me.DomnumeroTextBox.Location = New System.Drawing.Point(87, 60)
        Me.DomnumeroTextBox.Name = "DomnumeroTextBox"
        Me.DomnumeroTextBox.Size = New System.Drawing.Size(39, 22)
        Me.DomnumeroTextBox.TabIndex = 17
        '
        'DomdeptoTextBox
        '
        Me.DomdeptoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DomdeptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "domdepto", True))
        Me.DomdeptoTextBox.Location = New System.Drawing.Point(299, 60)
        Me.DomdeptoTextBox.Name = "DomdeptoTextBox"
        Me.DomdeptoTextBox.Size = New System.Drawing.Size(70, 22)
        Me.DomdeptoTextBox.TabIndex = 21
        '
        'DompisoTextBox
        '
        Me.DompisoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DompisoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "dompiso", True))
        Me.DompisoTextBox.Location = New System.Drawing.Point(181, 60)
        Me.DompisoTextBox.Name = "DompisoTextBox"
        Me.DompisoTextBox.Size = New System.Drawing.Size(53, 22)
        Me.DompisoTextBox.TabIndex = 19
        '
        'GroupPersonales
        '
        Me.GroupPersonales.Controls.Add(Me.IdincapacidadComboBox)
        Me.GroupPersonales.Controls.Add(Me.IdtipodocumentoComboBox)
        Me.GroupPersonales.Controls.Add(ApellidoLabel)
        Me.GroupPersonales.Controls.Add(Me.DocumentoTextBox)
        Me.GroupPersonales.Controls.Add(DocumentoLabel)
        Me.GroupPersonales.Controls.Add(Me.ApellidoTextBox)
        Me.GroupPersonales.Controls.Add(IdtipodocumentoLabel)
        Me.GroupPersonales.Controls.Add(NombreLabel)
        Me.GroupPersonales.Controls.Add(Me.NombreTextBox)
        Me.GroupPersonales.Controls.Add(EstadocivilLabel)
        Me.GroupPersonales.Controls.Add(IdincapacidadLabel)
        Me.GroupPersonales.Controls.Add(Me.EstadocivilTextBox)
        Me.GroupPersonales.Controls.Add(NacionalidadLabel)
        Me.GroupPersonales.Controls.Add(Me.FechanacimientoDateTimePicker)
        Me.GroupPersonales.Controls.Add(Me.NacionalidadTextBox)
        Me.GroupPersonales.Controls.Add(FechanacimientoLabel)
        Me.GroupPersonales.Location = New System.Drawing.Point(10, 19)
        Me.GroupPersonales.Name = "GroupPersonales"
        Me.GroupPersonales.Size = New System.Drawing.Size(388, 253)
        Me.GroupPersonales.TabIndex = 67
        Me.GroupPersonales.TabStop = False
        Me.GroupPersonales.Text = "Datos Personales"
        '
        'IdincapacidadComboBox
        '
        Me.IdincapacidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idincapacidad", True))
        Me.IdincapacidadComboBox.DataSource = Me.IncapacidadesBindingSource
        Me.IdincapacidadComboBox.DisplayMember = "descripcion"
        Me.IdincapacidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdincapacidadComboBox.FormattingEnabled = True
        Me.IdincapacidadComboBox.Location = New System.Drawing.Point(98, 155)
        Me.IdincapacidadComboBox.Name = "IdincapacidadComboBox"
        Me.IdincapacidadComboBox.Size = New System.Drawing.Size(217, 24)
        Me.IdincapacidadComboBox.TabIndex = 55
        Me.IdincapacidadComboBox.ValueMember = "idincapacidad"
        '
        'IncapacidadesBindingSource
        '
        Me.IncapacidadesBindingSource.DataMember = "incapacidades"
        Me.IncapacidadesBindingSource.DataSource = Me.ComercialDataSet
        '
        'IdtipodocumentoComboBox
        '
        Me.IdtipodocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosBindingSource, "idtipodocumento", True))
        Me.IdtipodocumentoComboBox.DataSource = Me.TipodocumentosBindingSource
        Me.IdtipodocumentoComboBox.DisplayMember = "descripcion"
        Me.IdtipodocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdtipodocumentoComboBox.FormattingEnabled = True
        Me.IdtipodocumentoComboBox.Location = New System.Drawing.Point(98, 85)
        Me.IdtipodocumentoComboBox.Name = "IdtipodocumentoComboBox"
        Me.IdtipodocumentoComboBox.Size = New System.Drawing.Size(90, 24)
        Me.IdtipodocumentoComboBox.TabIndex = 54
        Me.IdtipodocumentoComboBox.ValueMember = "idtipodocumento"
        '
        'TipodocumentosBindingSource
        '
        Me.TipodocumentosBindingSource.DataMember = "tipodocumentos"
        Me.TipodocumentosBindingSource.DataSource = Me.ComercialDataSet
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(282, 85)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(94, 22)
        Me.DocumentoTextBox.TabIndex = 13
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(98, 26)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ApellidoTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(98, 54)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 5
        '
        'EstadocivilTextBox
        '
        Me.EstadocivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "estadocivil", True))
        Me.EstadocivilTextBox.Location = New System.Drawing.Point(98, 118)
        Me.EstadocivilTextBox.Name = "EstadocivilTextBox"
        Me.EstadocivilTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EstadocivilTextBox.TabIndex = 47
        '
        'FechanacimientoDateTimePicker
        '
        Me.FechanacimientoDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechanacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechanacimiento", True))
        Me.FechanacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechanacimientoDateTimePicker.Location = New System.Drawing.Point(98, 211)
        Me.FechanacimientoDateTimePicker.Name = "FechanacimientoDateTimePicker"
        Me.FechanacimientoDateTimePicker.Size = New System.Drawing.Size(109, 22)
        Me.FechanacimientoDateTimePicker.TabIndex = 53
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nacionalidad", True))
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(98, 183)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NacionalidadTextBox.TabIndex = 51
        '
        'GroupPrevisionales
        '
        Me.GroupPrevisionales.Controls.Add(Me.NrojubilacionTextBox)
        Me.GroupPrevisionales.Controls.Add(Me.NroinscripcionTextBox)
        Me.GroupPrevisionales.Controls.Add(NrojubilacionLabel)
        Me.GroupPrevisionales.Controls.Add(NroinscripcionLabel)
        Me.GroupPrevisionales.Controls.Add(RegimenLabel)
        Me.GroupPrevisionales.Controls.Add(Me.RegimenTextBox)
        Me.GroupPrevisionales.Location = New System.Drawing.Point(404, 74)
        Me.GroupPrevisionales.Name = "GroupPrevisionales"
        Me.GroupPrevisionales.Size = New System.Drawing.Size(379, 83)
        Me.GroupPrevisionales.TabIndex = 66
        Me.GroupPrevisionales.TabStop = False
        Me.GroupPrevisionales.Text = "Datos Previsionales"
        '
        'NrojubilacionTextBox
        '
        Me.NrojubilacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NrojubilacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nrojubilacion", True))
        Me.NrojubilacionTextBox.Location = New System.Drawing.Point(89, 21)
        Me.NrojubilacionTextBox.Name = "NrojubilacionTextBox"
        Me.NrojubilacionTextBox.Size = New System.Drawing.Size(112, 22)
        Me.NrojubilacionTextBox.TabIndex = 33
        '
        'NroinscripcionTextBox
        '
        Me.NroinscripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NroinscripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "nroinscripcion", True))
        Me.NroinscripcionTextBox.Location = New System.Drawing.Point(89, 49)
        Me.NroinscripcionTextBox.Name = "NroinscripcionTextBox"
        Me.NroinscripcionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NroinscripcionTextBox.TabIndex = 35
        '
        'RegimenTextBox
        '
        Me.RegimenTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RegimenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "regimen", True))
        Me.RegimenTextBox.Location = New System.Drawing.Point(291, 21)
        Me.RegimenTextBox.Name = "RegimenTextBox"
        Me.RegimenTextBox.Size = New System.Drawing.Size(54, 22)
        Me.RegimenTextBox.TabIndex = 37
        '
        'IdempleadoTextBox
        '
        Me.IdempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "idempleado", True))
        Me.IdempleadoTextBox.Location = New System.Drawing.Point(6, 11)
        Me.IdempleadoTextBox.Name = "IdempleadoTextBox"
        Me.IdempleadoTextBox.Size = New System.Drawing.Size(29, 22)
        Me.IdempleadoTextBox.TabIndex = 1
        Me.IdempleadoTextBox.Visible = False
        '
        'FechaaltaDateTimePicker
        '
        Me.FechaaltaDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechaaltaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechaalta", True))
        Me.FechaaltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaaltaDateTimePicker.Location = New System.Drawing.Point(633, 18)
        Me.FechaaltaDateTimePicker.Name = "FechaaltaDateTimePicker"
        Me.FechaaltaDateTimePicker.Size = New System.Drawing.Size(118, 22)
        Me.FechaaltaDateTimePicker.TabIndex = 7
        '
        'FechabajaDateTimePicker
        '
        Me.FechabajaDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FechabajaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechabaja", True))
        Me.FechabajaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechabajaDateTimePicker.Location = New System.Drawing.Point(632, 46)
        Me.FechabajaDateTimePicker.Name = "FechabajaDateTimePicker"
        Me.FechabajaDateTimePicker.Size = New System.Drawing.Size(118, 22)
        Me.FechabajaDateTimePicker.TabIndex = 9
        '
        'GroupListado
        '
        Me.GroupListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupListado.Controls.Add(Me.EmpleadosDataGridView)
        Me.GroupListado.Location = New System.Drawing.Point(12, 50)
        Me.GroupListado.Name = "GroupListado"
        Me.GroupListado.Size = New System.Drawing.Size(797, 516)
        Me.GroupListado.TabIndex = 1
        Me.GroupListado.TabStop = False
        Me.GroupListado.Text = "Listado"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.EmpleadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(21, 24)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.ReadOnly = True
        Me.EmpleadosDataGridView.RowTemplate.Height = 24
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(758, 486)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idempleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idempleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idtipodocumento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idtipodocumento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "documento"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Documento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "domcalle"
        Me.DataGridViewTextBoxColumn8.HeaderText = "domcalle"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "domnumero"
        Me.DataGridViewTextBoxColumn9.HeaderText = "domnumero"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "dompiso"
        Me.DataGridViewTextBoxColumn10.HeaderText = "dompiso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "domdepto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "domdepto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "localidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "localidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "provincia"
        Me.DataGridViewTextBoxColumn13.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "codigopostal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "codigopostal"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "nrojubilacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "nrojubilacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "nroinscripcion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "nroinscripcion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "regimen"
        Me.DataGridViewTextBoxColumn19.HeaderText = "regimen"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "sueldojornal"
        Me.DataGridViewTextBoxColumn22.HeaderText = "sueldojornal"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "adicionalfijo"
        Me.DataGridViewTextBoxColumn23.HeaderText = "adicionalfijo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "estadocivil"
        Me.DataGridViewTextBoxColumn24.HeaderText = "estadocivil"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "idincapacidad"
        Me.DataGridViewTextBoxColumn25.HeaderText = "idincapacidad"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "nacionalidad"
        Me.DataGridViewTextBoxColumn26.HeaderText = "nacionalidad"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "fechanacimiento"
        Me.DataGridViewTextBoxColumn27.HeaderText = "fechanacimiento"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn28.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "idobrasocial"
        Me.DataGridViewTextBoxColumn29.HeaderText = "idobrasocial"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "idsindicato"
        Me.DataGridViewTextBoxColumn30.HeaderText = "idsindicato"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "idcategoriaempleado"
        Me.DataGridViewTextBoxColumn31.HeaderText = "idcategoriaempleado"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "idcentrocosto"
        Me.DataGridViewTextBoxColumn32.HeaderText = "idcentrocosto"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "idgrupojerarquico"
        Me.DataGridViewTextBoxColumn33.HeaderText = "idgrupojerarquico"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.auventascanceladasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bultosdeliverydetalleTableAdapter = Nothing
        Me.TableAdapterManager.bultosdeliveryTableAdapter = Nothing
        Me.TableAdapterManager.cajasestadosTableAdapter = Nothing
        Me.TableAdapterManager.cajaseventosTableAdapter = Nothing
        Me.TableAdapterManager.cajasoperacionesTableAdapter = Nothing
        Me.TableAdapterManager.cajasTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevoluciondetalleTableAdapter = Nothing
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.categoriasempleadosTableAdapter = Nothing
        Me.TableAdapterManager.centroscostoTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesserviciosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.conceptossueldosTableAdapter = Nothing
        Me.TableAdapterManager.condicionempleoTableAdapter = Nothing
        Me.TableAdapterManager.convenioempleoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaproductosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Me.EmpleadosTableAdapter
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
        Me.TableAdapterManager.gruposjerarquicosTableAdapter = Nothing
        Me.TableAdapterManager.incapacidadesTableAdapter = Nothing
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.lotesvencimientoTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Nothing
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Nothing
        Me.TableAdapterManager.obrassocialesTableAdapter = Nothing
        Me.TableAdapterManager.ordenesmesasTableAdapter = Nothing
        Me.TableAdapterManager.pagosimputacionesTableAdapter = Nothing
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
        Me.TableAdapterManager.sindicatosTableAdapter = Nothing
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.ticketaccesofeTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosTableAdapter = Nothing
        Me.TableAdapterManager.tipoconceptosueldoTableAdapter = Nothing
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
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BtnNuevo
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Nothing
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnNuevo, Me.BindingNavigatorDeleteItem, Me.BtnGuardar, Me.BtnEditar, Me.BtnCancelar, Me.ToolStripButton3})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Nothing
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(821, 47)
        Me.EmpleadosBindingNavigator.TabIndex = 2
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.RightToLeftAutoMirrorImage = True
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 44)
        Me.BtnNuevo.Text = "Agregar"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 47)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 44)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 44)
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.sgcomercial.My.Resources.Resources.edit_pencil
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(52, 44)
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 44)
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.sgcomercial.My.Resources.Resources.CheckList
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(48, 44)
        Me.ToolStripButton3.Text = "Listar"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TipodocumentosTableAdapter
        '
        Me.TipodocumentosTableAdapter.ClearBeforeFill = True
        '
        'ObrassocialesTableAdapter
        '
        Me.ObrassocialesTableAdapter.ClearBeforeFill = True
        '
        'SindicatosTableAdapter
        '
        Me.SindicatosTableAdapter.ClearBeforeFill = True
        '
        'CategoriasempleadosTableAdapter
        '
        Me.CategoriasempleadosTableAdapter.ClearBeforeFill = True
        '
        'CentroscostoTableAdapter
        '
        Me.CentroscostoTableAdapter.ClearBeforeFill = True
        '
        'GruposjerarquicosTableAdapter
        '
        Me.GruposjerarquicosTableAdapter.ClearBeforeFill = True
        '
        'IncapacidadesTableAdapter
        '
        Me.IncapacidadesTableAdapter.ClearBeforeFill = True
        '
        'CondicionempleoTableAdapter
        '
        Me.CondicionempleoTableAdapter.ClearBeforeFill = True
        '
        'ConvenioempleoTableAdapter
        '
        Me.ConvenioempleoTableAdapter.ClearBeforeFill = True
        '
        'ABMEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 578)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Controls.Add(Me.GroupABM)
        Me.Controls.Add(Me.GroupListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMEmpleados"
        Me.Text = "Alta, Baja y Modificación de Empleados"
        Me.GroupABM.ResumeLayout(False)
        Me.GroupABM.PerformLayout()
        Me.GroupLaborales.ResumeLayout(False)
        Me.GroupLaborales.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConvenioempleoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CondicionempleoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposjerarquicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroscostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasempleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrassocialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDomCon.ResumeLayout(False)
        Me.GroupDomCon.PerformLayout()
        Me.GroupPersonales.ResumeLayout(False)
        Me.GroupPersonales.PerformLayout()
        CType(Me.IncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPrevisionales.ResumeLayout(False)
        Me.GroupPrevisionales.PerformLayout()
        Me.GroupListado.ResumeLayout(False)
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupABM As GroupBox
    Friend WithEvents GroupListado As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As comercialDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As BindingNavigator
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents IdempleadoTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents FechaaltaDateTimePicker As DateTimePicker
    Friend WithEvents FechabajaDateTimePicker As DateTimePicker
    Friend WithEvents DocumentoTextBox As TextBox
    Friend WithEvents DomcalleTextBox As TextBox
    Friend WithEvents DomnumeroTextBox As TextBox
    Friend WithEvents DompisoTextBox As TextBox
    Friend WithEvents DomdeptoTextBox As TextBox
    Friend WithEvents LocalidadTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents CodigopostalTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NrojubilacionTextBox As TextBox
    Friend WithEvents NroinscripcionTextBox As TextBox
    Friend WithEvents RegimenTextBox As TextBox
    Friend WithEvents EstadocivilTextBox As TextBox
    Friend WithEvents NacionalidadTextBox As TextBox
    Friend WithEvents FechanacimientoDateTimePicker As DateTimePicker
    Friend WithEvents GroupLaborales As GroupBox
    Friend WithEvents GroupDomCon As GroupBox
    Friend WithEvents GroupPersonales As GroupBox
    Friend WithEvents IdtipodocumentoComboBox As ComboBox
    Friend WithEvents GroupPrevisionales As GroupBox
    Friend WithEvents TipodocumentosBindingSource As BindingSource
    Friend WithEvents TipodocumentosTableAdapter As comercialDataSetTableAdapters.tipodocumentosTableAdapter
    Friend WithEvents IdincapacidadComboBox As ComboBox
    Friend WithEvents ObrassocialesBindingSource As BindingSource
    Friend WithEvents ObrassocialesTableAdapter As comercialDataSetTableAdapters.obrassocialesTableAdapter
    Friend WithEvents SindicatosBindingSource As BindingSource
    Friend WithEvents SindicatosTableAdapter As comercialDataSetTableAdapters.sindicatosTableAdapter
    Friend WithEvents CategoriasempleadosBindingSource As BindingSource
    Friend WithEvents CategoriasempleadosTableAdapter As comercialDataSetTableAdapters.categoriasempleadosTableAdapter
    Friend WithEvents CentroscostoBindingSource As BindingSource
    Friend WithEvents CentroscostoTableAdapter As comercialDataSetTableAdapters.centroscostoTableAdapter
    Friend WithEvents ComercialDataSetBindingSource As BindingSource
    Friend WithEvents GruposjerarquicosBindingSource As BindingSource
    Friend WithEvents GruposjerarquicosTableAdapter As comercialDataSetTableAdapters.gruposjerarquicosTableAdapter
    Friend WithEvents IncapacidadesBindingSource As BindingSource
    Friend WithEvents IncapacidadesTableAdapter As comercialDataSetTableAdapters.incapacidadesTableAdapter
    Friend WithEvents CondicionempleoBindingSource As BindingSource
    Friend WithEvents CondicionempleoTableAdapter As comercialDataSetTableAdapters.condicionempleoTableAdapter
    Friend WithEvents ConvenioempleoBindingSource As BindingSource
    Friend WithEvents ConvenioempleoTableAdapter As comercialDataSetTableAdapters.convenioempleoTableAdapter
    Friend WithEvents IdconvenioempleoComboBox As ComboBox
    Friend WithEvents IdcondicionempleoComboBox As ComboBox
    Friend WithEvents IdgrupojerarquicoComboBox As ComboBox
    Friend WithEvents IdcentrocostoComboBox As ComboBox
    Friend WithEvents IdcategoriaempleadoComboBox As ComboBox
    Friend WithEvents IdsindicatoComboBox As ComboBox
    Friend WithEvents IdobrasocialComboBox As ComboBox
    Friend WithEvents AdicionalfijoTextBox As TextBox
    Friend WithEvents SueldojornalTextBox As TextBox
    Friend WithEvents TareaTextBox As TextBox
End Class

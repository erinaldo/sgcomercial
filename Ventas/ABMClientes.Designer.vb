﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMClientes
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
        Dim RazonsocialLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMClientes))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MiComercioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.listaclientesdomiciliosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ExportarBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CUITTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditarDomicilio = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboDocTipo = New System.Windows.Forms.ComboBox()
        Me.TipodocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.porcentajedescuentoTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiasvencimientoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboCondicionIVA = New System.Windows.Forms.ComboBox()
        Me.TipocondicionivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.filtrotextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.TipocondicionivaTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipocondicionivaTableAdapter()
        Me.ProvinciasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.provinciasTableAdapter()
        Me.TipodocumentosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.tipodocumentosTableAdapter()
        Me.MiComercioTableAdapter = New sgcomercial.comercialDataSetTableAdapters.MiComercioTableAdapter()
        Me.listaclientesdomiciliosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaclientesdomiciliosTableAdapter()
        Me.BGWLCD = New System.ComponentModel.BackgroundWorker()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RazonsocialLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaclientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(211, 18)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(57, 13)
        IdclienteLabel.TabIndex = 1
        IdclienteLabel.Text = "N° Cliente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(42, 44)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'RazonsocialLabel
        '
        RazonsocialLabel.AutoSize = True
        RazonsocialLabel.Location = New System.Drawing.Point(26, 69)
        RazonsocialLabel.Name = "RazonsocialLabel"
        RazonsocialLabel.Size = New System.Drawing.Size(65, 13)
        RazonsocialLabel.TabIndex = 5
        RazonsocialLabel.Text = "Documento:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(38, 94)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "Teléfono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(54, 121)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(343, 44)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 13)
        Label2.TabIndex = 12
        Label2.Text = "Condición IVA:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(310, 69)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(111, 13)
        Label3.TabIndex = 13
        Label3.Text = "Días de vencimiento :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(303, 94)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(116, 13)
        Label5.TabIndex = 16
        Label5.Text = "Porcentaje Descuento:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(36, 148)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(54, 13)
        Label7.TabIndex = 19
        Label7.Text = "Provincia:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Red
        Label8.Location = New System.Drawing.Point(32, 44)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(12, 13)
        Label8.TabIndex = 20
        Label8.Text = "*"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.Red
        Label9.Location = New System.Drawing.Point(15, 68)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(12, 13)
        Label9.TabIndex = 20
        Label9.Text = "*"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Red
        Label10.Location = New System.Drawing.Point(332, 44)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(12, 13)
        Label10.TabIndex = 20
        Label10.Text = "*"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Red
        Label11.Location = New System.Drawing.Point(517, 0)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(116, 13)
        Label11.TabIndex = 20
        Label11.Text = "(*) Dato Obligatorio"
        '
        'MiComercioBindingSource
        '
        Me.MiComercioBindingSource.DataMember = "MiComercio"
        Me.MiComercioBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listaclientesdomiciliosBindingSource
        '
        Me.listaclientesdomiciliosBindingSource.DataMember = "listaclientesdomicilios"
        Me.listaclientesdomiciliosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ComercialDataSet
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem, Me.ToolStripButtonEditar, Me.ToolStripButton2, Me.ExportarBtn})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Nothing
        Me.ClientesBindingNavigator.MoveLastItem = Nothing
        Me.ClientesBindingNavigator.MoveNextItem = Nothing
        Me.ClientesBindingNavigator.MovePreviousItem = Nothing
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(777, 42)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(89, 39)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 39)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 39)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(85, 39)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        Me.ClientesBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ClientesBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.sgcomercial.My.Resources.Resources.editar
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(41, 39)
        Me.ToolStripButtonEditar.Text = "Editar"
        Me.ToolStripButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(57, 39)
        Me.ToolStripButton2.Text = "Cancelar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton2.Visible = False
        '
        'ExportarBtn
        '
        Me.ExportarBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ExportarBtn.Image = Global.sgcomercial.My.Resources.Resources.Export_1export
        Me.ExportarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportarBtn.Name = "ExportarBtn"
        Me.ExportarBtn.Size = New System.Drawing.Size(105, 39)
        Me.ExportarBtn.Text = "Exportar Listado"
        Me.ExportarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.Excel_ico
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.PDF_ico
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(271, 15)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.ReadOnly = True
        Me.IdclienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdclienteTextBox.TabIndex = 9
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(94, 41)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(204, 20)
        Me.NombreTextBox.TabIndex = 0
        '
        'CUITTextBox
        '
        Me.CUITTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CUITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cuit", True))
        Me.CUITTextBox.Enabled = False
        Me.CUITTextBox.Location = New System.Drawing.Point(190, 67)
        Me.CUITTextBox.Name = "CUITTextBox"
        Me.CUITTextBox.Size = New System.Drawing.Size(108, 20)
        Me.CUITTextBox.TabIndex = 2
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(94, 92)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(204, 20)
        Me.TelefonoTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(94, 119)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(204, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AllowUserToResizeRows = False
        Me.ClientesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcliente, Me.DataGridViewTextBoxColumn2, Me.cuit, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.EditarDomicilio, Me.eliminar})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(9, 59)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.RowHeadersVisible = False
        Me.ClientesDataGridView.Size = New System.Drawing.Size(731, 162)
        Me.ClientesDataGridView.TabIndex = 13
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "N°"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Width = 129
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre / Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "cuit"
        Me.cuit.HeaderText = "Cuit"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Width = 128
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 129
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 129
        '
        'EditarDomicilio
        '
        Me.EditarDomicilio.DataPropertyName = "idcliente"
        Me.EditarDomicilio.HeaderText = "Editar Domicilio"
        Me.EditarDomicilio.Name = "EditarDomicilio"
        Me.EditarDomicilio.ReadOnly = True
        Me.EditarDomicilio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditarDomicilio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditarDomicilio.Text = "Editar Domicilio"
        Me.EditarDomicilio.ToolTipText = "Editar Domicilio"
        Me.EditarDomicilio.UseColumnTextForButtonValue = True
        Me.EditarDomicilio.Width = 128
        '
        'eliminar
        '
        Me.eliminar.DataPropertyName = "idcliente"
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.ToolTipText = "Eliminar"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 129
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.ComboDocTipo)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.porcentajedescuentoTextbox)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DiasvencimientoTextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.ComboCondicionIVA)
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Controls.Add(Me.IdclienteTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(RazonsocialLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Me.CUITTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 185)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'ComboDocTipo
        '
        Me.ComboDocTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idtipodocumento", True))
        Me.ComboDocTipo.DataSource = Me.TipodocumentosBindingSource
        Me.ComboDocTipo.DisplayMember = "descripcion"
        Me.ComboDocTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDocTipo.FormattingEnabled = True
        Me.ComboDocTipo.Location = New System.Drawing.Point(94, 66)
        Me.ComboDocTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboDocTipo.Name = "ComboDocTipo"
        Me.ComboDocTipo.Size = New System.Drawing.Size(92, 21)
        Me.ComboDocTipo.TabIndex = 1
        Me.ComboDocTipo.ValueMember = "idtipodocumento"
        '
        'TipodocumentosBindingSource
        '
        Me.TipodocumentosBindingSource.DataMember = "tipodocumentos"
        Me.TipodocumentosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idprovincia", True))
        Me.ComboBox2.DataSource = Me.ProvinciasBindingSource
        Me.ComboBox2.DisplayMember = "nombreprovincia"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(94, 148)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.ValueMember = "idprovincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "provincias"
        Me.ProvinciasBindingSource.DataSource = Me.ComercialDataSetBindingSource
        '
        'ComercialDataSetBindingSource
        '
        Me.ComercialDataSetBindingSource.DataSource = Me.ComercialDataSet
        Me.ComercialDataSetBindingSource.Position = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "(por defecto aplicable al total de cada venta)"
        '
        'porcentajedescuentoTextbox
        '
        Me.porcentajedescuentoTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "porcentajedescuento", True))
        Me.porcentajedescuentoTextbox.Location = New System.Drawing.Point(422, 92)
        Me.porcentajedescuentoTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.porcentajedescuentoTextbox.Name = "porcentajedescuentoTextbox"
        Me.porcentajedescuentoTextbox.Size = New System.Drawing.Size(76, 20)
        Me.porcentajedescuentoTextbox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "(por defecto para vtas. a cta. corriente)"
        '
        'DiasvencimientoTextBox
        '
        Me.DiasvencimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "diasvencimiento", True))
        Me.DiasvencimientoTextBox.Location = New System.Drawing.Point(422, 67)
        Me.DiasvencimientoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DiasvencimientoTextBox.Name = "DiasvencimientoTextBox"
        Me.DiasvencimientoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DiasvencimientoTextBox.TabIndex = 7
        '
        'ComboCondicionIVA
        '
        Me.ComboCondicionIVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "condicioniva", True))
        Me.ComboCondicionIVA.DataSource = Me.TipocondicionivaBindingSource
        Me.ComboCondicionIVA.DisplayMember = "descripcion"
        Me.ComboCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCondicionIVA.FormattingEnabled = True
        Me.ComboCondicionIVA.Location = New System.Drawing.Point(422, 41)
        Me.ComboCondicionIVA.Name = "ComboCondicionIVA"
        Me.ComboCondicionIVA.Size = New System.Drawing.Size(213, 21)
        Me.ComboCondicionIVA.TabIndex = 6
        Me.ComboCondicionIVA.ValueMember = "idtipocondicioniva"
        '
        'TipocondicionivaBindingSource
        '
        Me.TipocondicionivaBindingSource.DataMember = "tipocondicioniva"
        Me.TipocondicionivaBindingSource.DataSource = Me.ComercialDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Controls.Add(Me.filtrotextbox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.ClientesDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 234)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de clientes"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "MiComercio"
        ReportDataSource1.Value = Me.MiComercioBindingSource
        ReportDataSource2.Name = "listaclientesdomicilios"
        ReportDataSource2.Value = Me.listaclientesdomiciliosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepListaClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 104)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(732, 117)
        Me.ReportViewer1.TabIndex = 17
        Me.ReportViewer1.Visible = False
        '
        'filtrotextbox
        '
        Me.filtrotextbox.Location = New System.Drawing.Point(275, 27)
        Me.filtrotextbox.Name = "filtrotextbox"
        Me.filtrotextbox.Size = New System.Drawing.Size(100, 20)
        Me.filtrotextbox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Filtrar por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nombre", "Cuit"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.conceptossueldosTableAdapter = Nothing
        Me.TableAdapterManager.condicionempleoTableAdapter = Nothing
        Me.TableAdapterManager.convenioempleoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaproductosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventarangosTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaregalorangoTableAdapter = Nothing
        Me.TableAdapterManager.criteriosventaTableAdapter = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.depositosTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
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
        'TipocondicionivaTableAdapter
        '
        Me.TipocondicionivaTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'TipodocumentosTableAdapter
        '
        Me.TipodocumentosTableAdapter.ClearBeforeFill = True
        '
        'MiComercioTableAdapter
        '
        Me.MiComercioTableAdapter.ClearBeforeFill = True
        '
        'listaclientesdomiciliosTableAdapter
        '
        Me.listaclientesdomiciliosTableAdapter.ClearBeforeFill = True
        '
        'BGWLCD
        '
        '
        'ABMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 476)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ABMClientes"
        Me.Text = "Agenda de Clientes - Altas, Bajas y Modificación de Clientes"
        CType(Me.MiComercioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaclientesdomiciliosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipodocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocondicionivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComercialDataSet As sgcomercial.comercialDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As sgcomercial.comercialDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As sgcomercial.comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents filtrotextbox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboCondicionIVA As ComboBox
    Friend WithEvents TipocondicionivaBindingSource As BindingSource
    Friend WithEvents TipocondicionivaTableAdapter As comercialDataSetTableAdapters.tipocondicionivaTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents DiasvencimientoTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents porcentajedescuentoTextbox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComercialDataSetBindingSource As BindingSource
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents ProvinciasTableAdapter As comercialDataSetTableAdapters.provinciasTableAdapter
    Friend WithEvents ComboDocTipo As ComboBox
    Friend WithEvents TipodocumentosBindingSource As BindingSource
    Friend WithEvents TipodocumentosTableAdapter As comercialDataSetTableAdapters.tipodocumentosTableAdapter
    Friend WithEvents ExportarBtn As ToolStripDropDownButton
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents MiComercioBindingSource As BindingSource
    Friend WithEvents MiComercioTableAdapter As comercialDataSetTableAdapters.MiComercioTableAdapter
    Friend WithEvents listaclientesdomiciliosBindingSource As BindingSource
    Friend WithEvents listaclientesdomiciliosTableAdapter As comercialDataSetTableAdapters.listaclientesdomiciliosTableAdapter
    Friend WithEvents BGWLCD As System.ComponentModel.BackgroundWorker
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EditarDomicilio As DataGridViewButtonColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
End Class

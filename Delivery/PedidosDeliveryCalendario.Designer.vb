<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDeliveryCalendario
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelCalendarHeader = New System.Windows.Forms.Panel()
        Me.CalendariopedidosdeliveryDataGridView = New System.Windows.Forms.DataGridView()
        Me.idpedidodelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaaentregardate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendariopedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.LabelCurrentDate = New System.Windows.Forms.Label()
        Me.PanelCalendarControls = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelDaysofWeek = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelDaysPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanelDay = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelDayNumber = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.CalendariopedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.calendariopedidosdeliveryTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.PanelCalendarHeader.SuspendLayout()
        CType(Me.CalendariopedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendariopedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCalendarControls.SuspendLayout()
        Me.PanelDaysofWeek.SuspendLayout()
        Me.FlowLayoutPanelDaysPanel.SuspendLayout()
        Me.FlowLayoutPanelDay.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PanelCalendarHeader
        '
        Me.PanelCalendarHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelCalendarHeader.Controls.Add(Me.CalendariopedidosdeliveryDataGridView)
        Me.PanelCalendarHeader.Controls.Add(Me.LabelCurrentDate)
        Me.PanelCalendarHeader.Controls.Add(Me.PanelCalendarControls)
        Me.PanelCalendarHeader.Controls.Add(Me.Button1)
        Me.PanelCalendarHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCalendarHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelCalendarHeader.Name = "PanelCalendarHeader"
        Me.PanelCalendarHeader.Size = New System.Drawing.Size(901, 57)
        Me.PanelCalendarHeader.TabIndex = 2
        '
        'CalendariopedidosdeliveryDataGridView
        '
        Me.CalendariopedidosdeliveryDataGridView.AllowUserToAddRows = False
        Me.CalendariopedidosdeliveryDataGridView.AllowUserToDeleteRows = False
        Me.CalendariopedidosdeliveryDataGridView.AutoGenerateColumns = False
        Me.CalendariopedidosdeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalendariopedidosdeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idpedidodelivery, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.nombre, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.fechaaentregardate})
        Me.CalendariopedidosdeliveryDataGridView.DataSource = Me.CalendariopedidosdeliveryBindingSource
        Me.CalendariopedidosdeliveryDataGridView.Location = New System.Drawing.Point(336, 21)
        Me.CalendariopedidosdeliveryDataGridView.Name = "CalendariopedidosdeliveryDataGridView"
        Me.CalendariopedidosdeliveryDataGridView.ReadOnly = True
        Me.CalendariopedidosdeliveryDataGridView.RowTemplate.Height = 24
        Me.CalendariopedidosdeliveryDataGridView.Size = New System.Drawing.Size(78, 21)
        Me.CalendariopedidosdeliveryDataGridView.TabIndex = 3
        Me.CalendariopedidosdeliveryDataGridView.Visible = False
        '
        'idpedidodelivery
        '
        Me.idpedidodelivery.DataPropertyName = "idpedidodelivery"
        Me.idpedidodelivery.HeaderText = "idpedidodelivery"
        Me.idpedidodelivery.Name = "idpedidodelivery"
        Me.idpedidodelivery.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pagoesperado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pagoesperado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idcliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idcliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn10.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cuit"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cuit"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn12.HeaderText = "email"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "nombretransporte"
        Me.DataGridViewTextBoxColumn13.HeaderText = "nombretransporte"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "referencias"
        Me.DataGridViewTextBoxColumn15.HeaderText = "referencias"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "nombreprovincia"
        Me.DataGridViewTextBoxColumn16.HeaderText = "nombreprovincia"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "nombrelocalidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "montototal"
        Me.DataGridViewTextBoxColumn18.HeaderText = "montototal"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "importepagado"
        Me.DataGridViewTextBoxColumn19.HeaderText = "importepagado"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "saldo"
        Me.DataGridViewTextBoxColumn20.HeaderText = "saldo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "obs"
        Me.DataGridViewTextBoxColumn21.HeaderText = "obs"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "origen"
        Me.DataGridViewTextBoxColumn22.HeaderText = "origen"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "fechaaentregar"
        Me.DataGridViewTextBoxColumn23.HeaderText = "fechaaentregar"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'fechaaentregardate
        '
        Me.fechaaentregardate.DataPropertyName = "fechaaentregardate"
        Me.fechaaentregardate.HeaderText = "fechaaentregardate"
        Me.fechaaentregardate.Name = "fechaaentregardate"
        Me.fechaaentregardate.ReadOnly = True
        '
        'CalendariopedidosdeliveryBindingSource
        '
        Me.CalendariopedidosdeliveryBindingSource.DataMember = "calendariopedidosdelivery"
        Me.CalendariopedidosdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelCurrentDate
        '
        Me.LabelCurrentDate.AutoSize = True
        Me.LabelCurrentDate.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelCurrentDate.Location = New System.Drawing.Point(12, 9)
        Me.LabelCurrentDate.Name = "LabelCurrentDate"
        Me.LabelCurrentDate.Size = New System.Drawing.Size(361, 47)
        Me.LabelCurrentDate.TabIndex = 1
        Me.LabelCurrentDate.Text = "LabelCurrentDate"
        '
        'PanelCalendarControls
        '
        Me.PanelCalendarControls.Controls.Add(Me.Button4)
        Me.PanelCalendarControls.Controls.Add(Me.Button3)
        Me.PanelCalendarControls.Controls.Add(Me.Button2)
        Me.PanelCalendarControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCalendarControls.Location = New System.Drawing.Point(604, 0)
        Me.PanelCalendarControls.Name = "PanelCalendarControls"
        Me.PanelCalendarControls.Size = New System.Drawing.Size(297, 57)
        Me.PanelCalendarControls.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(221, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(81, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Mes Actual"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(36, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 39)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PanelDaysofWeek
        '
        Me.PanelDaysofWeek.BackColor = System.Drawing.Color.White
        Me.PanelDaysofWeek.Controls.Add(Me.Label7)
        Me.PanelDaysofWeek.Controls.Add(Me.Label6)
        Me.PanelDaysofWeek.Controls.Add(Me.Label8)
        Me.PanelDaysofWeek.Controls.Add(Me.Label5)
        Me.PanelDaysofWeek.Controls.Add(Me.Label4)
        Me.PanelDaysofWeek.Controls.Add(Me.Label3)
        Me.PanelDaysofWeek.Controls.Add(Me.Label2)
        Me.PanelDaysofWeek.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDaysofWeek.Location = New System.Drawing.Point(0, 57)
        Me.PanelDaysofWeek.Name = "PanelDaysofWeek"
        Me.PanelDaysofWeek.Size = New System.Drawing.Size(901, 40)
        Me.PanelDaysofWeek.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(750, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sábado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(627, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Viernes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(504, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jueves"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(381, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Miercoles"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(258, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Martes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(135, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lunes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Domingo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanelDaysPanel
        '
        Me.FlowLayoutPanelDaysPanel.AutoScroll = True
        Me.FlowLayoutPanelDaysPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlowLayoutPanelDaysPanel.Controls.Add(Me.FlowLayoutPanelDay)
        Me.FlowLayoutPanelDaysPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelDaysPanel.Location = New System.Drawing.Point(0, 97)
        Me.FlowLayoutPanelDaysPanel.Name = "FlowLayoutPanelDaysPanel"
        Me.FlowLayoutPanelDaysPanel.Size = New System.Drawing.Size(901, 571)
        Me.FlowLayoutPanelDaysPanel.TabIndex = 4
        '
        'FlowLayoutPanelDay
        '
        Me.FlowLayoutPanelDay.Controls.Add(Me.LabelDayNumber)
        Me.FlowLayoutPanelDay.Controls.Add(Me.LinkLabel1)
        Me.FlowLayoutPanelDay.Controls.Add(Me.LinkLabel2)
        Me.FlowLayoutPanelDay.Controls.Add(Me.LinkLabel3)
        Me.FlowLayoutPanelDay.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanelDay.Name = "FlowLayoutPanelDay"
        Me.FlowLayoutPanelDay.Size = New System.Drawing.Size(117, 101)
        Me.FlowLayoutPanelDay.TabIndex = 0
        '
        'LabelDayNumber
        '
        Me.LabelDayNumber.Location = New System.Drawing.Point(3, 0)
        Me.LabelDayNumber.Name = "LabelDayNumber"
        Me.LabelDayNumber.Size = New System.Drawing.Size(114, 23)
        Me.LabelDayNumber.TabIndex = 0
        Me.LabelDayNumber.Text = "Label9"
        Me.LabelDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 23)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(114, 23)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 46)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(114, 23)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "LinkLabel2"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Location = New System.Drawing.Point(3, 69)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(114, 23)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "LinkLabel3"
        '
        'CalendariopedidosdeliveryTableAdapter
        '
        Me.CalendariopedidosdeliveryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        'PedidosDeliveryCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 668)
        Me.Controls.Add(Me.FlowLayoutPanelDaysPanel)
        Me.Controls.Add(Me.PanelDaysofWeek)
        Me.Controls.Add(Me.PanelCalendarHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidosDeliveryCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PedidosDeliveryCalendario"
        Me.Text = "Calendario de Eventos"
        Me.PanelCalendarHeader.ResumeLayout(False)
        Me.PanelCalendarHeader.PerformLayout()
        CType(Me.CalendariopedidosdeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendariopedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCalendarControls.ResumeLayout(False)
        Me.PanelDaysofWeek.ResumeLayout(False)
        Me.FlowLayoutPanelDaysPanel.ResumeLayout(False)
        Me.FlowLayoutPanelDay.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelCalendarHeader As Panel
    Friend WithEvents LabelCurrentDate As Label
    Friend WithEvents PanelCalendarControls As Panel
    Friend WithEvents PanelDaysofWeek As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanelDaysPanel As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelDay As FlowLayoutPanel
    Friend WithEvents LabelDayNumber As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents CalendariopedidosdeliveryBindingSource As BindingSource
    Friend WithEvents CalendariopedidosdeliveryTableAdapter As comercialDataSetTableAdapters.calendariopedidosdeliveryTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CalendariopedidosdeliveryDataGridView As DataGridView
    Friend WithEvents idpedidodelivery As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
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
    Friend WithEvents fechaaentregardate As DataGridViewTextBoxColumn
End Class

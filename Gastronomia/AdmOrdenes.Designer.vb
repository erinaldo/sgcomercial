<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmOrdenes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaÓrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMesa = New System.Windows.Forms.ComboBox()
        Me.MesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ComboBoxSalon = New System.Windows.Forms.ComboBox()
        Me.SalonesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MozosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalonesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.salonesTableAdapter()
        Me.MesasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mesasTableAdapter()
        Me.MozosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.mozosTableAdapter()
        Me.ListaproductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaproductosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listaproductosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureSeleccionarCliente = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularMesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.codigoproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaÓrdenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 489)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaÓrdenToolStripMenuItem
        '
        Me.NuevaÓrdenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NuevaÓrdenToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.green_plus_icon_13
        Me.NuevaÓrdenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.NuevaÓrdenToolStripMenuItem.Name = "NuevaÓrdenToolStripMenuItem"
        Me.NuevaÓrdenToolStripMenuItem.Size = New System.Drawing.Size(140, 52)
        Me.NuevaÓrdenToolStripMenuItem.Text = "Nueva Orden"
        Me.NuevaÓrdenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMesa)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSalon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 548)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoproducto, Me.cantidad, Me.producto, Me.precioventa, Me.preciototal})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 404)
        Me.DataGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mesa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Salón:"
        '
        'ComboBoxMesa
        '
        Me.ComboBoxMesa.DataSource = Me.MesasBindingSource
        Me.ComboBoxMesa.DisplayMember = "idmesa"
        Me.ComboBoxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMesa.FormattingEnabled = True
        Me.ComboBoxMesa.Location = New System.Drawing.Point(206, 38)
        Me.ComboBoxMesa.Name = "ComboBoxMesa"
        Me.ComboBoxMesa.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxMesa.TabIndex = 0
        Me.ComboBoxMesa.ValueMember = "idmesa"
        '
        'MesasBindingSource
        '
        Me.MesasBindingSource.DataMember = "mesas"
        Me.MesasBindingSource.DataSource = Me.ComercialDataSet
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxSalon
        '
        Me.ComboBoxSalon.DataSource = Me.SalonesBindingSource
        Me.ComboBoxSalon.DisplayMember = "descripcion"
        Me.ComboBoxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSalon.FormattingEnabled = True
        Me.ComboBoxSalon.Location = New System.Drawing.Point(32, 38)
        Me.ComboBoxSalon.Name = "ComboBoxSalon"
        Me.ComboBoxSalon.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxSalon.TabIndex = 0
        Me.ComboBoxSalon.ValueMember = "idsalon"
        '
        'SalonesBindingSource
        '
        Me.SalonesBindingSource.DataMember = "salones"
        Me.SalonesBindingSource.DataSource = Me.ComercialDataSet
        '
        'MozosBindingSource
        '
        Me.MozosBindingSource.DataMember = "mozos"
        Me.MozosBindingSource.DataSource = Me.ComercialDataSet
        '
        'SalonesTableAdapter
        '
        Me.SalonesTableAdapter.ClearBeforeFill = True
        '
        'MesasTableAdapter
        '
        Me.MesasTableAdapter.ClearBeforeFill = True
        '
        'MozosTableAdapter
        '
        Me.MozosTableAdapter.ClearBeforeFill = True
        '
        'ListaproductosBindingSource
        '
        Me.ListaproductosBindingSource.DataMember = "listaproductos"
        Me.ListaproductosBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListaproductosTableAdapter
        '
        Me.ListaproductosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.clientesTableAdapter = Nothing
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
        Me.TableAdapterManager.listaspreciosTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosdetalleTableAdapter = Nothing
        Me.TableAdapterManager.lotesenviosTableAdapter = Nothing
        Me.TableAdapterManager.mesasTableAdapter = Me.MesasTableAdapter
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
        Me.TableAdapterManager.mozosTableAdapter = Me.MozosTableAdapter
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
        Me.TableAdapterManager.salonesTableAdapter = Me.SalonesTableAdapter
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureSeleccionarCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.MenuStrip2)
        Me.GroupBox2.Location = New System.Drawing.Point(635, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 548)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBox1.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureBox1.Location = New System.Drawing.Point(118, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(246, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 39)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "--"
        '
        'PictureSeleccionarCliente
        '
        Me.PictureSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeleccionarCliente.Image = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.InitialImage = Global.sgcomercial.My.Resources.Resources.lup_
        Me.PictureSeleccionarCliente.Location = New System.Drawing.Point(126, 177)
        Me.PictureSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureSeleccionarCliente.Name = "PictureSeleccionarCliente"
        Me.PictureSeleccionarCliente.Size = New System.Drawing.Size(27, 27)
        Me.PictureSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureSeleccionarCliente.TabIndex = 16
        Me.PictureSeleccionarCliente.TabStop = False
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(8, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(389, 41)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-------------"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(389, 39)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "-------------"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 39)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(8, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 39)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MOZO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MESA:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AllowMerge = False
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.AnularMesaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 497)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(397, 48)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources._22_512
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(115, 44)
        Me.CerrarToolStripMenuItem.Text = "Finalizar Mesa"
        Me.CerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AnularMesaToolStripMenuItem
        '
        Me.AnularMesaToolStripMenuItem.Image = Global.sgcomercial.My.Resources.Resources.cancel
        Me.AnularMesaToolStripMenuItem.Name = "AnularMesaToolStripMenuItem"
        Me.AnularMesaToolStripMenuItem.Size = New System.Drawing.Size(103, 44)
        Me.AnularMesaToolStripMenuItem.Text = "Anular Mesa"
        Me.AnularMesaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'codigoproducto
        '
        Me.codigoproducto.HeaderText = "Cod."
        Me.codigoproducto.Name = "codigoproducto"
        Me.codigoproducto.ReadOnly = True
        Me.codigoproducto.Width = 66
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 93
        '
        'producto
        '
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        Me.producto.Width = 94
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "P.Unit."
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        Me.precioventa.Width = 79
        '
        'preciototal
        '
        Me.preciototal.HeaderText = "Total"
        Me.preciototal.Name = "preciototal"
        Me.preciototal.ReadOnly = True
        Me.preciototal.Width = 69
        '
        'AdmOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 553)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdmOrdenes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalonesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MozosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaproductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSeleccionarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaÓrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxMesa As ComboBox
    Friend WithEvents ComboBoxSalon As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents SalonesBindingSource As BindingSource
    Friend WithEvents SalonesTableAdapter As comercialDataSetTableAdapters.salonesTableAdapter
    Friend WithEvents MesasBindingSource As BindingSource
    Friend WithEvents MesasTableAdapter As comercialDataSetTableAdapters.mesasTableAdapter
    Friend WithEvents MozosBindingSource As BindingSource
    Friend WithEvents MozosTableAdapter As comercialDataSetTableAdapters.mozosTableAdapter
    Friend WithEvents ListaproductosBindingSource As BindingSource
    Friend WithEvents ListaproductosTableAdapter As comercialDataSetTableAdapters.listaproductosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularMesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureSeleccionarCliente As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents codigoproducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents precioventa As DataGridViewTextBoxColumn
    Friend WithEvents preciototal As DataGridViewTextBoxColumn
End Class

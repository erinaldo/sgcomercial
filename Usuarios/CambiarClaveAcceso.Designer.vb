<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClaveAcceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarClaveAcceso))
        Me.actual = New System.Windows.Forms.TextBox()
        Me.nueva1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nueva2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New sgcomercial.comercialDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
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
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'actual
        '
        Me.actual.Location = New System.Drawing.Point(186, 45)
        Me.actual.Name = "actual"
        Me.actual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.actual.Size = New System.Drawing.Size(129, 22)
        Me.actual.TabIndex = 0
        '
        'nueva1
        '
        Me.nueva1.Location = New System.Drawing.Point(186, 80)
        Me.nueva1.Name = "nueva1"
        Me.nueva1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nueva1.Size = New System.Drawing.Size(129, 22)
        Me.nueva1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contraseña actual:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nueva:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Repetir nueva:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nueva2
        '
        Me.nueva2.Location = New System.Drawing.Point(186, 115)
        Me.nueva2.Name = "nueva2"
        Me.nueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nueva2.Size = New System.Drawing.Size(129, 22)
        Me.nueva2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(34, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ComercialDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.valesTableAdapter = Nothing
        Me.TableAdapterManager.ventasdetalleTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(12, 76)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.RowTemplate.Height = 24
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(36, 23)
        Me.UsuariosDataGridView.TabIndex = 8
        Me.UsuariosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idusuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idusuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaalta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fechaalta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fechabaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fechabaja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fechamodificacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fechamodificacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "usuarioalta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "usuarioalta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "usuariobaja"
        Me.DataGridViewTextBoxColumn8.HeaderText = "usuariobaja"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "usuariomodificacion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "usuariomodificacion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idperfil"
        Me.DataGridViewTextBoxColumn10.HeaderText = "idperfil"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CambiarClaveAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 223)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nueva2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nueva1)
        Me.Controls.Add(Me.actual)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CambiarClaveAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CambiarClaveAcceso"
        Me.Text = "Cambiar Contraseña"
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents actual As TextBox
    Friend WithEvents nueva1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nueva2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As comercialDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As DataGridView
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
End Class

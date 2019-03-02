<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCAltaDispositivo
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
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiscomDataSet = New sgcomercial.siscomDataSet()
        Me.ClientesTableAdapter = New sgcomercial.siscomDataSetTableAdapters.clientesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelMachineName = New System.Windows.Forms.Label()
        Me.TerminalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerminalesTableAdapter = New sgcomercial.siscomDataSetTableAdapters.terminalesTableAdapter()
        Me.TableAdapterManager = New sgcomercial.siscomDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTvID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboSucursal = New System.Windows.Forms.ComboBox()
        Me.ClientessucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientessucursalesTableAdapter = New sgcomercial.siscomDataSetTableAdapters.clientessucursalesTableAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerminalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientessucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboCliente
        '
        Me.ComboCliente.DataSource = Me.ClientesBindingSource
        Me.ComboCliente.DisplayMember = "nombre"
        Me.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(77, 68)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(325, 24)
        Me.ComboCliente.TabIndex = 0
        Me.ComboCliente.ValueMember = "idclientes"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.SiscomDataSet
        '
        'SiscomDataSet
        '
        Me.SiscomDataSet.DataSetName = "siscomDataSet"
        Me.SiscomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equipo"
        '
        'LabelMachineName
        '
        Me.LabelMachineName.Location = New System.Drawing.Point(78, 113)
        Me.LabelMachineName.Name = "LabelMachineName"
        Me.LabelMachineName.Size = New System.Drawing.Size(324, 23)
        Me.LabelMachineName.TabIndex = 3
        Me.LabelMachineName.Text = "Label3"
        '
        'TerminalesBindingSource
        '
        Me.TerminalesBindingSource.DataMember = "terminales"
        Me.TerminalesBindingSource.DataSource = Me.SiscomDataSet
        '
        'TerminalesTableAdapter
        '
        Me.TerminalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientessucursalesTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.modulosTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesmodulosTableAdapter = Nothing
        Me.TableAdapterManager.terminalesTableAdapter = Me.TerminalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = sgcomercial.siscomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Team Viewer ID"
        '
        'TextBoxTvID
        '
        Me.TextBoxTvID.Location = New System.Drawing.Point(77, 162)
        Me.TextBoxTvID.Name = "TextBoxTvID"
        Me.TextBoxTvID.Size = New System.Drawing.Size(325, 22)
        Me.TextBoxTvID.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número de Sucursal:"
        '
        'ComboSucursal
        '
        Me.ComboSucursal.DataSource = Me.ClientessucursalesBindingSource
        Me.ComboSucursal.DisplayMember = "nombre"
        Me.ComboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.Location = New System.Drawing.Point(77, 222)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(325, 24)
        Me.ComboSucursal.TabIndex = 9
        Me.ComboSucursal.ValueMember = "idsucursal"
        '
        'ClientessucursalesBindingSource
        '
        Me.ClientessucursalesBindingSource.DataMember = "clientessucursales"
        Me.ClientessucursalesBindingSource.DataSource = Me.SiscomDataSet
        '
        'ClientessucursalesTableAdapter
        '
        Me.ClientessucursalesTableAdapter.ClearBeforeFill = True
        '
        'SCAltaDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 322)
        Me.Controls.Add(Me.ComboSucursal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxTvID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelMachineName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboCliente)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCAltaDispositivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SCAltaDispositivo"
        Me.Text = "Alta Dispositivo"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiscomDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerminalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientessucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboCliente As ComboBox
    Friend WithEvents SiscomDataSet As siscomDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As siscomDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelMachineName As Label
    Friend WithEvents TerminalesBindingSource As BindingSource
    Friend WithEvents TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
    Friend WithEvents TableAdapterManager As siscomDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTvID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboSucursal As ComboBox
    Friend WithEvents ClientessucursalesBindingSource As BindingSource
    Friend WithEvents ClientessucursalesTableAdapter As siscomDataSetTableAdapters.clientessucursalesTableAdapter
End Class

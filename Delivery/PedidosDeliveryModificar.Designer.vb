﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDeliveryModificar
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CuitLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NombretransporteLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ReferenciasLabel As System.Windows.Forms.Label
        Dim NombreprovinciaLabel As System.Windows.Forms.Label
        Dim NombrelocalidadLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComercialDataSet = New sgcomercial.comercialDataSet()
        Me.ListapedidosdeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListapedidosdeliveryTableAdapter = New sgcomercial.comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter()
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.IdpedidodeliveryTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NombretransporteTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciasTextBox = New System.Windows.Forms.TextBox()
        Me.NombreprovinciaTextBox = New System.Windows.Forms.TextBox()
        Me.NombrelocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CuitLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NombretransporteLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ReferenciasLabel = New System.Windows.Forms.Label()
        NombreprovinciaLabel = New System.Windows.Forms.Label()
        NombrelocalidadLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NombreprovinciaLabel)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.NombreprovinciaTextBox)
        Me.GroupBox1.Controls.Add(NombretransporteLabel)
        Me.GroupBox1.Controls.Add(NombrelocalidadLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(Me.NombrelocalidadTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.ReferenciasTextBox)
        Me.GroupBox1.Controls.Add(ReferenciasLabel)
        Me.GroupBox1.Controls.Add(Me.NombretransporteTextBox)
        Me.GroupBox1.Controls.Add(CuitLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.CuitTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.IdpedidodeliveryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComercialDataSet
        '
        Me.ComercialDataSet.DataSetName = "comercialDataSet"
        Me.ComercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListapedidosdeliveryBindingSource
        '
        Me.ListapedidosdeliveryBindingSource.DataMember = "listapedidosdelivery"
        Me.ListapedidosdeliveryBindingSource.DataSource = Me.ComercialDataSet
        '
        'ListapedidosdeliveryTableAdapter
        '
        Me.ListapedidosdeliveryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.cambiodevolucionTableAdapter = Nothing
        Me.TableAdapterManager.clientesdomiciliosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'IdpedidodeliveryTextBox
        '
        Me.IdpedidodeliveryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "idpedidodelivery", True))
        Me.IdpedidodeliveryTextBox.Location = New System.Drawing.Point(6, 31)
        Me.IdpedidodeliveryTextBox.Name = "IdpedidodeliveryTextBox"
        Me.IdpedidodeliveryTextBox.Size = New System.Drawing.Size(86, 22)
        Me.IdpedidodeliveryTextBox.TabIndex = 3
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(99, 11)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 16
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(102, 31)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(294, 22)
        Me.NombreTextBox.TabIndex = 17
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(6, 56)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Teléfono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(6, 76)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TelefonoTextBox.TabIndex = 19
        '
        'CuitLabel
        '
        CuitLabel.AutoSize = True
        CuitLabel.Location = New System.Drawing.Point(212, 56)
        CuitLabel.Name = "CuitLabel"
        CuitLabel.Size = New System.Drawing.Size(43, 17)
        CuitLabel.TabIndex = 20
        CuitLabel.Text = "CUIT:"
        '
        'CuitTextBox
        '
        Me.CuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "cuit", True))
        Me.CuitTextBox.Location = New System.Drawing.Point(215, 76)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(181, 22)
        Me.CuitTextBox.TabIndex = 21
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 101)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 17)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "E-mail:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(6, 121)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 23
        '
        'NombretransporteLabel
        '
        NombretransporteLabel.AutoSize = True
        NombretransporteLabel.Location = New System.Drawing.Point(622, 101)
        NombretransporteLabel.Name = "NombretransporteLabel"
        NombretransporteLabel.Size = New System.Drawing.Size(82, 17)
        NombretransporteLabel.TabIndex = 24
        NombretransporteLabel.Text = "Transporte:"
        '
        'NombretransporteTextBox
        '
        Me.NombretransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombretransporte", True))
        Me.NombretransporteTextBox.Location = New System.Drawing.Point(625, 123)
        Me.NombretransporteTextBox.Name = "NombretransporteTextBox"
        Me.NombretransporteTextBox.Size = New System.Drawing.Size(330, 22)
        Me.NombretransporteTextBox.TabIndex = 25
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(399, 11)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 26
        DireccionLabel.Text = "Dirección:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(402, 31)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DireccionTextBox.TabIndex = 27
        '
        'ReferenciasLabel
        '
        ReferenciasLabel.AutoSize = True
        ReferenciasLabel.Location = New System.Drawing.Point(622, 11)
        ReferenciasLabel.Name = "ReferenciasLabel"
        ReferenciasLabel.Size = New System.Drawing.Size(88, 17)
        ReferenciasLabel.TabIndex = 28
        ReferenciasLabel.Text = "Referencias:"
        '
        'ReferenciasTextBox
        '
        Me.ReferenciasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "referencias", True))
        Me.ReferenciasTextBox.Location = New System.Drawing.Point(625, 31)
        Me.ReferenciasTextBox.Multiline = True
        Me.ReferenciasTextBox.Name = "ReferenciasTextBox"
        Me.ReferenciasTextBox.Size = New System.Drawing.Size(330, 67)
        Me.ReferenciasTextBox.TabIndex = 29
        '
        'NombreprovinciaLabel
        '
        NombreprovinciaLabel.AutoSize = True
        NombreprovinciaLabel.Location = New System.Drawing.Point(400, 56)
        NombreprovinciaLabel.Name = "NombreprovinciaLabel"
        NombreprovinciaLabel.Size = New System.Drawing.Size(70, 17)
        NombreprovinciaLabel.TabIndex = 30
        NombreprovinciaLabel.Text = "Provincia:"
        '
        'NombreprovinciaTextBox
        '
        Me.NombreprovinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombreprovincia", True))
        Me.NombreprovinciaTextBox.Location = New System.Drawing.Point(403, 76)
        Me.NombreprovinciaTextBox.Name = "NombreprovinciaTextBox"
        Me.NombreprovinciaTextBox.Size = New System.Drawing.Size(199, 22)
        Me.NombreprovinciaTextBox.TabIndex = 31
        '
        'NombrelocalidadLabel
        '
        NombrelocalidadLabel.AutoSize = True
        NombrelocalidadLabel.Location = New System.Drawing.Point(400, 101)
        NombrelocalidadLabel.Name = "NombrelocalidadLabel"
        NombrelocalidadLabel.Size = New System.Drawing.Size(73, 17)
        NombrelocalidadLabel.TabIndex = 32
        NombrelocalidadLabel.Text = "Localidad:"
        '
        'NombrelocalidadTextBox
        '
        Me.NombrelocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListapedidosdeliveryBindingSource, "nombrelocalidad", True))
        Me.NombrelocalidadTextBox.Location = New System.Drawing.Point(403, 121)
        Me.NombrelocalidadTextBox.Name = "NombrelocalidadTextBox"
        Me.NombrelocalidadTextBox.Size = New System.Drawing.Size(199, 22)
        Me.NombrelocalidadTextBox.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedido Nº:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 430)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PedidosDeliveryModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidosDeliveryModificar"
        Me.Text = "PedidosDeliveryModificar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ComercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListapedidosdeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComercialDataSet As comercialDataSet
    Friend WithEvents ListapedidosdeliveryBindingSource As BindingSource
    Friend WithEvents ListapedidosdeliveryTableAdapter As comercialDataSetTableAdapters.listapedidosdeliveryTableAdapter
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdpedidodeliveryTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NombretransporteTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ReferenciasTextBox As TextBox
    Friend WithEvents NombreprovinciaTextBox As TextBox
    Friend WithEvents NombrelocalidadTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class

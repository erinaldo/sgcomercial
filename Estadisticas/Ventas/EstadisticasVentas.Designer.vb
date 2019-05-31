<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstadisticasVentas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EstEnviosSucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comercialDataSet = New sgcomercial.comercialDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEstadistica = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstABCResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstClasificacionParetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstHistoricoVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstParetoParticipacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstParetoParticipacionTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstParetoParticipacionTableAdapter()
        Me.EstABCResumenTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstABCResumenTableAdapter()
        Me.EstClasificacionParetoTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter()
        Me.EstHistoricoVentasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstHistoricoVentasTableAdapter()
        Me.LibroventasTableAdapter = New sgcomercial.comercialDataSetTableAdapters.libroventasTableAdapter()
        Me.LibroventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New sgcomercial.comercialDataSetTableAdapters.TableAdapterManager()
        Me.EstEnviosSucursalesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.EstEnviosSucursalesTableAdapter()
        IdclienteLabel = New System.Windows.Forms.Label()
        CType(Me.EstEnviosSucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstHistoricoVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstParetoParticipacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(17, 25)
        IdclienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(132, 17)
        IdclienteLabel.TabIndex = 16
        IdclienteLabel.Text = "Seleccione Informe:"
        '
        'EstEnviosSucursalesBindingSource
        '
        Me.EstEnviosSucursalesBindingSource.DataMember = "EstEnviosSucursales"
        Me.EstEnviosSucursalesBindingSource.DataSource = Me.comercialDataSet
        '
        'comercialDataSet
        '
        Me.comercialDataSet.DataSetName = "comercialDataSet"
        Me.comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxEstadistica)
        Me.GroupBox1.Controls.Add(IdclienteLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'ComboBoxEstadistica
        '
        Me.ComboBoxEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstadistica.FormattingEnabled = True
        Me.ComboBoxEstadistica.Items.AddRange(New Object() {"Historico Ventas", "Principio de Pareto", "Ventas por Provincia", "Envíos a sucursales"})
        Me.ComboBoxEstadistica.Location = New System.Drawing.Point(155, 22)
        Me.ComboBoxEstadistica.Name = "ComboBoxEstadistica"
        Me.ComboBoxEstadistica.Size = New System.Drawing.Size(327, 24)
        Me.ComboBoxEstadistica.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 526)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EstEnviosSucursales"
        ReportDataSource1.Value = Me.EstEnviosSucursalesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.MapTileServerConfiguration.MaxConnections = 5
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEstEnviosSucursales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(805, 505)
        Me.ReportViewer1.TabIndex = 0
        '
        'EstABCResumenBindingSource
        '
        Me.EstABCResumenBindingSource.DataMember = "EstABCResumen"
        Me.EstABCResumenBindingSource.DataSource = Me.comercialDataSet
        '
        'EstClasificacionParetoBindingSource
        '
        Me.EstClasificacionParetoBindingSource.DataMember = "EstClasificacionPareto"
        Me.EstClasificacionParetoBindingSource.DataSource = Me.comercialDataSet
        '
        'EstHistoricoVentasBindingSource
        '
        Me.EstHistoricoVentasBindingSource.DataMember = "EstHistoricoVentas"
        Me.EstHistoricoVentasBindingSource.DataSource = Me.comercialDataSet
        '
        'EstParetoParticipacionBindingSource
        '
        Me.EstParetoParticipacionBindingSource.DataMember = "EstParetoParticipacion"
        Me.EstParetoParticipacionBindingSource.DataSource = Me.comercialDataSet
        '
        'EstParetoParticipacionTableAdapter
        '
        Me.EstParetoParticipacionTableAdapter.ClearBeforeFill = True
        '
        'EstABCResumenTableAdapter
        '
        Me.EstABCResumenTableAdapter.ClearBeforeFill = True
        '
        'EstClasificacionParetoTableAdapter
        '
        Me.EstClasificacionParetoTableAdapter.ClearBeforeFill = True
        '
        'EstHistoricoVentasTableAdapter
        '
        Me.EstHistoricoVentasTableAdapter.ClearBeforeFill = True
        '
        'LibroventasTableAdapter
        '
        Me.LibroventasTableAdapter.ClearBeforeFill = True
        '
        'LibroventasBindingSource
        '
        Me.LibroventasBindingSource.DataMember = "libroventas"
        Me.LibroventasBindingSource.DataSource = Me.comercialDataSet
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.cuentascorrientesTableAdapter = Nothing
        Me.TableAdapterManager.errorlogTableAdapter = Nothing
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
        Me.TableAdapterManager.motivostockTableAdapter = Nothing
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
        Me.TableAdapterManager.stockremotoTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.sucursalesTableAdapter = Nothing
        Me.TableAdapterManager.synclogTableAdapter = Nothing
        Me.TableAdapterManager.tipocomprobantesTableAdapter = Nothing
        Me.TableAdapterManager.tipocondicionivaTableAdapter = Nothing
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
        'EstEnviosSucursalesTableAdapter
        '
        Me.EstEnviosSucursalesTableAdapter.ClearBeforeFill = True
        '
        'EstadisticasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EstadisticasVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "EstadisticasVentas"
        Me.Text = "Estadisticas Ventas"
        CType(Me.EstEnviosSucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comercialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EstABCResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstClasificacionParetoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstHistoricoVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstParetoParticipacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibroventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxEstadistica As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents EstParetoParticipacionBindingSource As BindingSource
    Friend WithEvents comercialDataSet As comercialDataSet
    Friend WithEvents EstParetoParticipacionTableAdapter As comercialDataSetTableAdapters.EstParetoParticipacionTableAdapter
    Friend WithEvents EstABCResumenBindingSource As BindingSource
    Friend WithEvents EstClasificacionParetoBindingSource As BindingSource
    Friend WithEvents EstABCResumenTableAdapter As comercialDataSetTableAdapters.EstABCResumenTableAdapter
    Friend WithEvents EstClasificacionParetoTableAdapter As comercialDataSetTableAdapters.EstClasificacionParetoTableAdapter
    Friend WithEvents EstHistoricoVentasBindingSource As BindingSource
    Friend WithEvents EstHistoricoVentasTableAdapter As comercialDataSetTableAdapters.EstHistoricoVentasTableAdapter
    Friend WithEvents LibroventasTableAdapter As comercialDataSetTableAdapters.libroventasTableAdapter
    Friend WithEvents LibroventasBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As comercialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstEnviosSucursalesBindingSource As BindingSource
    Friend WithEvents EstEnviosSucursalesTableAdapter As comercialDataSetTableAdapters.EstEnviosSucursalesTableAdapter
End Class

﻿Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Public Class Principal
    Dim permiso As Integer = 0
    Private Sub Principal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ListaprecioscajaTableAdapter.Fill(Me.ComercialDataSet.listaprecioscaja)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)
        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        '''''''''''''''''''''''''''''''''''
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
        FormPrincipal.BackgroundImage = PictureBox1.Image
        Me.Text = Me.Text + " -  [ " + ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio") + " ] "
        '''''''''''''''' carga  modulos y funciones a BD '''''''''''''''''''''''
        InsertarModulos()
        ''''''''''''''  CARGA DE PERMISOS DE USUARIO '''''''''''''''''''''
        If Not gusername = "lucasmartinbs" Then
            cargapermisos()
        End If
        ''''''''''''''''''''''''''''''''''''''  ALERTA STOCK '''''''''''''''''''''''''''''''''''''
        permiso = 0
        permiso = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "StockParent")
        If Not permiso = 0 Then
            'MsgBox("alerta")
            reloadstock()
        End If
        ''''''''''''''''''''''''''''''''''''''  FIN '''''''''''''''''''''''''''''''''''''

        CuadroBienvenida()
    End Sub
    Public Shared LastSysTime As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CuadroBienvenida()
        GBBienvenido.Visible = False
        Try
            LabelUsuario.Text = gusername
            gidcaja = 0
            gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
            If gidcaja = 0 Then
                LabelCaja.Text = "-No Configurada-"
            Else
                LabelCaja.Text = gidcaja.ToString
            End If
            LabelFecha.Text = Today
            'GBBienvenido.Left = (Me.Width / 2) - (GBBienvenido.Width / 2)
            Me.Text = " Sistema de Gestion Comercial " + " - [" + ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio") + "]" + " - Caja N°: " + LabelCaja.Text + " - Usuario: " + gusername
        Catch ex As Exception

        End Try

    End Sub

    Private Sub InsertarModulos()
        For Each miitem As ToolStripMenuItem In Me.MenuStrip1.Items
            If Not miitem.Tag = "SysConfig" Then
                ModulosTableAdapter.modulos_insertar(miitem.Tag, miitem.Name, 0)
            End If
            If Not miitem.Name = "NotificacionesToolStripMenuItem" Then
                gnombremodulo = miitem.Tag
                InsertarFunciones(miitem, gnombremodulo)
            End If
        Next
    End Sub
    Private Sub cargapermisos()
        Dim rtn As Integer
        For Each miitem As ToolStripMenuItem In Me.MenuStrip1.Items
            rtn = ModulosTableAdapter.modulos_habilitar(miitem.Tag)
            If rtn > 0 Then
                If Not miitem.Name = "NotificacionesToolStripMenuItem" Then
                    recorrer(miitem)
                End If
            Else
                miitem.Enabled = False
                miitem.Visible = False
            End If
        Next
    End Sub
    Private Sub InsertarFunciones(ByVal Oneitem As ToolStripMenuItem, ByVal modulonombre As String)

        For Each otroItem As ToolStripMenuItem In Oneitem.DropDownItems

            '**********    ACTUALIZA LAS DESCRIPCIONES DE LAS FUNCIONES EN LA BD
            If otroItem.Tag <> "Alerta1" And otroItem.Tag <> "Alerta2" And modulonombre <> "SysConfig" Then
                FuncionesTableAdapter1.funciones_insertupdate(otroItem.Text, Trim(otroItem.Tag), gnombremodulo)
            End If
            ''''''''''''   fin   '''''''''''''''''''''''''''
            'valor &= otroItem.Tag & ";"
            If otroItem.DropDownItems.Count > 0 Then InsertarFunciones(otroItem, gnombremodulo)
        Next
    End Sub
    Private Sub recorrer(ByVal Oneitem As ToolStripMenuItem)
        For Each otroItem As ToolStripMenuItem In Oneitem.DropDownItems
            ''''''''''''    CONFIGURA OPCIONES HABILITADAS PARA EL PERFIL   '''''''''''''''''''''''''''
            permiso = 0
            permiso = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, otroItem.Tag)
            If permiso = 1 Then
                otroItem.Visible = True
                otroItem.Enabled = True
            Else
                otroItem.Visible = False
                otroItem.Enabled = False
            End If
            ''''''''''''   fin   '''''''''''''''''''''''''''
            'valor &= otroItem.Tag & ";"
            If otroItem.DropDownItems.Count > 0 Then recorrer(otroItem)
        Next
    End Sub
    Public Sub reloadwallpaper()
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
        FormPrincipal.BackgroundImage = PictureBox1.Image
    End Sub
    Public Sub reloadstock()

        Me.StockalertaTableAdapter.Fill(Me.ComercialDataSet.stockalerta)
        If DataGridViewStockAlerta.RowCount > 0 Then
            If Alerta1ToolStripMenuItem.Visible = False Then
                Alerta1ToolStripMenuItem.Visible = True
                NotificacionesToolStripMenuItem.Visible = True
                Alerta1ToolStripMenuItem.Text = "Se necesita reponer productos!"
                Return
            End If
            If Alerta2ToolStripMenuItem.Visible = False Then
                NotificacionesToolStripMenuItem.Visible = True
                Alerta2ToolStripMenuItem.Visible = True
                Alerta2ToolStripMenuItem.Text = "Se necesita reponer productos!"
                Return
            End If
        Else
            NotificacionesToolStripMenuItem.Visible = False

        End If
    End Sub

    Private Sub GestionDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProductosToolStripMenuItem.Click

    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        'Dim p As CajaAperturaCierre
        'p = New CajaAperturaCierre
        CajaAperturaCierre.MdiParent = Me
        CajaAperturaCierre.Visible = True
    End Sub

    Private Sub ABMProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMProductosToolStripMenuItem.Click

    End Sub

    Private Sub IngresoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeProductosToolStripMenuItem.Click

        ingresoegresoproductos.Visible = True
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click

    End Sub

    Private Sub ControlDeStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeStockToolStripMenuItem.Click
        'Dim p As ControlStock
        'p = New ControlStock
        ControlStock.MdiParent = Me
        ControlStock.Visible = True
    End Sub

    Private Sub ABMRubrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMRubrosToolStripMenuItem.Click
        'Dim p As ABMRubros
        'p = New ABMRubros
        ABMRubros.MdiParent = Me
        ABMRubros.Visible = True
    End Sub

    Private Sub ABMUnidadesMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ABMCajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        'Dim p As Cajasmovimientos
        'p = New Cajasmovimientos
        Cajasmovimientos.MdiParent = Me
        Cajasmovimientos.Visible = True
    End Sub

    Private Sub GastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosToolStripMenuItem.Click
        'Dim p As ABMGastos
        'p = New ABMGastos
        ABMGastos.MdiParent = Me
        ABMGastos.Visible = True
    End Sub

    Private Sub RegistrarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarVentaToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        If gidcaja = 0 Then
            MsgBox("Este ordenador no esta Registrado para operar como CAJA!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        Dim idevento As Integer
        'idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        'lblCaja.Text = "Caja Nº: " + idcaja.ToString
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)

        If idevento = 0 Then
            MsgBox("Caja Cerrada. Abra la caja antes de registrar una venta", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            RegistrarVenta.MdiParent = Me
            RegistrarVenta.Visible = True
        End If
        '***************    FIN consultar el estado de caja *************

    End Sub

    Private Sub ABMClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMClientesToolStripMenuItem.Click
        'Dim p As ABMClientes
        'p = New ABMClientes
        ABMClientes.MdiParent = Me
        ABMClientes.Visible = True
    End Sub

    Private Sub VentasPorDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasPorDiaToolStripMenuItem.Click
        'Dim p As LibroDiario
        'p = New LibroDiario
        LibroDiario.MdiParent = Me
        LibroDiario.Visible = True
    End Sub

    Private Sub LibroMayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibroMayorToolStripMenuItem.Click
        'Dim p As LibroMayor
        'p = New LibroMayor
        LibroMayor.MdiParent = Me
        LibroMayor.Visible = True
    End Sub

    Private Sub AcercaDeSGComercialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeSGComercialToolStripMenuItem.Click
        'Dim p As AcercaDe
        'p = New AcercaDe
        AcercaDe.ShowDialog()
    End Sub

    Private Sub MiComercioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiComercioToolStripMenuItem.Click
        'Dim p As MiComercio
        'p = New MiComercio
        MiComercio.ShowDialog()
    End Sub

    Private Sub FondoAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondoAplicaciónToolStripMenuItem.Click
        'Dim p As FondoAplicacion
        'p = New FondoAplicacion
        FondoAplicacion.ShowDialog()
    End Sub

    Private Sub ParametrosgeneralesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ParametrosgeneralesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub StockEnAlertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockEnAlertaToolStripMenuItem.Click
        'Dim p As StockAlerta
        'p = New StockAlerta
        StockAlerta.MdiParent = Me
        StockAlerta.Visible = True
    End Sub

    Private Sub AlertaStockLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Alerta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Alerta1ToolStripMenuItem.Click
        Select Case Alerta1ToolStripMenuItem.Text
            Case "Se necesita reponer productos!"
                'Dim p As StockAlerta
                'p = New StockAlerta
                StockAlerta.ShowDialog()
        End Select
    End Sub

    Private Sub ActualizacionDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionDePreciosToolStripMenuItem.Click
        'Dim p As ActualizacionPrecios
        'p = New ActualizacionPrecios
        ActualizacionPrecios.ShowDialog()
    End Sub

    Private Sub ProductoEstandarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoEstandarToolStripMenuItem.Click
        'Dim p As ABMProductos
        'p = New ABMProductos
        ABMProductos.MdiParent = Me
        ABMProductos.Visible = True
    End Sub

    Private Sub ProductoCompuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoCompuestoToolStripMenuItem.Click
        'Dim p As ABMProductoscompuestos
        'p = New ABMProductoscompuestos
        ABMProductosCompuestos.MdiParent = Me
        ABMProductosCompuestos.Visible = True
    End Sub

    Private Sub AsignarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABMUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMUsuariosToolStripMenuItem.Click
        ABMUsuarios.MdiParent = Me
        ABMUsuarios.Visible = True
    End Sub

    Private Sub ABMPermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPermisosToolStripMenuItem.Click
        ABMPermisos.MdiParent = Me
        ABMPermisos.Visible = True
    End Sub



    Private Sub ABMProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProveedoresToolStripMenuItem.Click
        'ABMProveedores.MdiParent = Me
        ABMProveedores.ShowDialog()
    End Sub

    Private Sub Principal_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ''''''''''''''  CARGA INFORMACION DE CAJA HABILITADA '''''''''''''''''''''
        CuadroBienvenida()
        ''''''''''''''  CARGA DE PERMISOS DE USUARIO '''''''''''''''''''''
        If Not gusername = "lucasmartinbs" Then
            cargapermisos()
        End If
    End Sub

    Private Sub ABMPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPedidosToolStripMenuItem.Click
        ABMPedidos.MdiParent = Me
        ABMPedidos.Visible = True
    End Sub

    Private Sub ListaDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePedidosToolStripMenuItem.Click
        ListaPedidos.MdiParent = Me
        ListaPedidos.Visible = True
    End Sub

    Private Sub RecepciónDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepciónDePedidoToolStripMenuItem.Click
        RecepcionPedido.MdiParent = Me
        RecepcionPedido.Visible = True
    End Sub

    Private Sub ImpresiónEtiquetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónEtiquetasToolStripMenuItem.Click
        BarCodePrint.ShowDialog()

    End Sub

    Private Sub RecepciónSinPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepciónSinPedidoToolStripMenuItem.Click
        RecepcionSinPedido.MdiParent = Me
        RecepcionSinPedido.Visible = True
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        CambiarClaveAcceso.MdiParent = Me
        CambiarClaveAcceso.Visible = True

    End Sub

    Private Sub Principal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'GBBienvenido.Left = (Me.Width / 2) - (GBBienvenido.Width / 2)
    End Sub

    Private Sub ExtraccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraccionesToolStripMenuItem.Click
        'Dim p As ABMGastos
        'p = New ABMGastos
        ABMExtracciones.MdiParent = Me
        ABMExtracciones.Visible = True
    End Sub

    Private Sub AsignarCajaToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AsignarCajaToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles AsignarCajaToolStripMenuItem.Click
        AsignarCaja.MdiParent = Me
        AsignarCaja.Visible = True
    End Sub

    Private Sub ABMUnidadesMedidaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ABMUnidadesMedidaToolStripMenuItem.Click
        ABMUnidadesMedida.MdiParent = Me
        ABMUnidadesMedida.Visible = True
    End Sub

    Private Sub ModulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulosToolStripMenuItem.Click
        ADModulos.MdiParent = Me
        ADModulos.Visible = True
    End Sub

    Private Sub EmitirValeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmitirValeToolStripMenuItem.Click
        ABMVales.MdiParent = Me
        ABMVales.Visible = True
    End Sub

    Private Sub ABMMotivosValesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMMotivosValesToolStripMenuItem.Click
        'ABMMotivosVales.MdiParent = Me
        ABMMotivosVales.ShowDialog()
    End Sub

    Private Sub AdministrarValesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarValesToolStripMenuItem.Click
        ADMVales.ShowDialog()

    End Sub

    Private Sub ABMCajasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABMCajasToolStripMenuItem1.Click
        'Dim p As ABMCajas
        'p = New ABMCajas
        ABMCajas.MdiParent = Me
        ABMCajas.Visible = True
    End Sub

    Private Sub ConsultarPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPreciosToolStripMenuItem.Click
        ConsultarPrecios.MdiParent = Me
        ConsultarPrecios.Visible = True
    End Sub

    Private Sub TerminalVerificadoraDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminalVerificadoraDePreciosToolStripMenuItem.Click
        TerminalVerificadoraPrecios.Visible = True
    End Sub

    Private Sub CodificarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodificarProductosToolStripMenuItem.Click
        CodificarProductos.MdiParent = Me
        CodificarProductos.Visible = True
    End Sub

    Private Sub CambioMercaderíaVendidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioMercaderíaVendidaToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        If gidcaja = 0 Then
            MsgBox("Este ordenador no esta Registrado para operar como CAJA!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        Dim idevento As Integer
        'idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        'lblCaja.Text = "Caja Nº: " + idcaja.ToString
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        gidevento = idevento
        If idevento = 0 Then
            MsgBox("Caja Cerrada. Abra la caja antes de registrar una venta", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            'RegistrarVenta.MdiParent = Me
            'RegistrarVenta.Visible = True
            CambioMercaderiaVendida.MdiParent = Me
            CambioMercaderiaVendida.Visible = True
        End If
        '***************    FIN consultar el estado de caja *************


    End Sub

    Private Sub EnviarStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarStockToolStripMenuItem.Click
        EnviarStock.MdiParent = Me
        EnviarStock.Visible = True
    End Sub

    Private Sub ABMSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMSucursalesToolStripMenuItem.Click
        ABMSucursales.MdiParent = Me
        ABMSucursales.Visible = True
    End Sub

    Private Sub ListaRemitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaRemitosToolStripMenuItem.Click
        ListaRemitos.MdiParent = Me
        ListaRemitos.Visible = True
    End Sub

    Private Sub RecibirStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibirStockToolStripMenuItem.Click
        RecibirStock.MdiParent = Me
        RecibirStock.Visible = True
    End Sub

    Private Sub AltaPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPedidoToolStripMenuItem.Click
        AltaPedidoDelivery.MdiParent = Me
        AltaPedidoDelivery.Visible = True
    End Sub

    Private Sub RecibidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibidosToolStripMenuItem.Click
        'PedidosDeliveryRecibidos.MdiParent = Me
        'PedidosDeliveryRecibidos.Visible = True
    End Sub
End Class
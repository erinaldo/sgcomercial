Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class Principal
    Dim gNotificacionesAlertasTableAdapter As New comercialDataSetTableAdapters.notificacionesalertasTableAdapter()
    Dim gNotificacionesAlertasDataTable As New comercialDataSet.notificacionesalertasDataTable
    Dim CountAlertas As Long
    Dim xi As LoadingForm
    Dim permiso As Integer = 0
    Dim ModuloSeleccionado As New ToolStripMenuItem()
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim PrincipalSizeWindow As String
    Dim TimeSliderTimer As Integer
    Private Sub Principal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub
    Sub PrincipalTituloPrincipal()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   TITULO DE LA VENTANA PRINCIPAL
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            gNombreComercio = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio")
            Me.Text = " Electronic Point of Sale " + " - [" + gNombreComercio + "]" + " - Caja N°: [" + gidcaja.ToString + "] - Usuario: [" + gusername + "] - Sucursal N°: [" + gMiSucursal.ToString + "]" + " - Versión: [" + SoftwareVersion + "]" + " - Facturación Electrónica: [" + GFEAFIPENTORNO + "]"
            PrincipalTitle.Text = " Electronic Point of Sale " + " - [" + gNombreComercio + "]" + " - Caja N°: [" + gidcaja.ToString + "] - Usuario: [" + gusername + "] - Sucursal N°: [" + gMiSucursal.ToString + "]" + " - Versión: [" + SoftwareVersion + "]" + " - Facturación Electrónica: [" + GFEAFIPENTORNO + "]"
            If gIsOnline = False Then
                Me.Text = PrincipalTitle.Text + " - [SIN INTERNET]"
                PrincipalTitle.Text = PrincipalTitle.Text + " - [SIN INTERNET]"
            End If
            'Me.Text = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = SCAPPICON
        PanelSlider.Width = 50
        PrincipalSizeWindow = "NORMAL"
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim hi As LoadingForm
        hi = New LoadingForm
        hi.Show()
        hi.ProgressBar.Maximum = 2
        Cursor.Current = Cursors.WaitCursor
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Cargando Permisos de usuario..."
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)
        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
        '''''''''''''''''''''''''''''''''''
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
        FormPrincipal.BackgroundImage = PictureBox1.Image
        '======================================
        FeAFIPLoad()
        '======================================
        '   TITULO DE LA VENTANA PRINCIPAL
        PrincipalTituloPrincipal()
        '''''''''''''''' carga  modulos y funciones a BD '''''''''''''''''''''''
        InsertarModulos()
        ''''''''''''''  CARGA DE PERMISOS DE USUARIO '''''''''''''''''''''
        If Not gusername = "lucasmartinbs" Then
            cargapermisos()
            MenuStripMain.Visible = False
        Else
            MenuStripMain.Visible = False
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Cargando Notificaciones de Usuario..."
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Not BGWAlertas.IsBusy Then
            BGWAlertas.RunWorkerAsync()
        End If
        '================= BACKGROUND WORKERS   ==========================
        CheckModulesAuth()
        If gModuloCloud = 1 Then
            'BackgroundSyncLibroventasClowd.RunWorkerAsync()
            'BGWStock.RunWorkerAsync()
        End If
        '======================================
        Cursor.Current = Cursors.Default
        hi.Dispose()
        '======================================
        Dim elast As Char
        elast = CajaseventosTableAdapter.cajaseventos_emailedlast()
        If elast = "N" Then
            ShowPopUp("Recuerda enviar el ultimo CIERRE DE CAJA!", 400)
        End If
        '********************************************************
        PrincipalMaximizar()
    End Sub
    Public Sub EjecutarAlertas()
        '====================================================================
        ''''''''''''''''''''''''''''''''''''''  ALERTASSSSSSSSSSSS '''''''''''''''''''''''''''''''''''''
        CountAlertas = gNotificacionesAlertasTableAdapter.notificacionesalertas_count()
        ModuloNotificaciones.Visible = True
        If CountAlertas > 0 Then
            'ModuloNotificaciones.Image = sgcomercial.My.Resources.Resources.Alert_warning_orange
            FlatBtnModuloNotificaciones.Image = sgcomercial.My.Resources.Resources.Alert_warning_orange_39
        Else
            'ModuloNotificaciones.Image = sgcomercial.My.Resources.Resources.Alert_check_blue
            FlatBtnModuloNotificaciones.Image = sgcomercial.My.Resources.Resources.Alert_warning_white_39
        End If
        gNotificacionesAlertasDataTable = gNotificacionesAlertasTableAdapter.GetData
        Try
            'ModuloNotificaciones.Text = "Notificaciones (" + CountAlertas.ToString + ")"
            FlatBtnModuloNotificaciones.Text = "Notificaciones (" + CountAlertas.ToString + ")"
        Catch ex As Exception

        End Try

        '====================================================================
        ''''''''''''''''''''''''''''''''''''''  FIN '''''''''''''''''''''''''''''''''''''
        '====================================================================
    End Sub

    Public Shared LastSysTime As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub InsertarModulos()
        For Each miitem As ToolStripMenuItem In Me.MenuStripMain.Items
            If Not miitem.Tag = "SysConfig" Then
                ModulosTableAdapter.modulos_insertar(miitem.Tag, miitem.Name, 0)
            End If
            If Not miitem.Name = "NotificacionesToolStripMenuItem" Then
                gnombremodulo = miitem.Tag
                'If Not gusername = "lucasmartinbs" Then
                '    miitem.Enabled = False
                'End If
                InsertarFunciones(miitem, gnombremodulo)
            End If
        Next
    End Sub
    Public Sub cargapermisos()
        'If gReloadPermisos = True Then
        Try
            Dim rtn As Integer
            For Each miitem As ToolStripMenuItem In Me.MenuStripMain.Items
                rtn = ModulosTableAdapter.modulos_habilitar(miitem.Tag)
                If rtn > 0 Then
                    ''''''''''''    MODULOS OCULTOS POR DEFECTO  '''''''''''''''''''''''''''
                    If miitem.Name = "NotificacionesToolStripMenuItem" Or miitem.Name = "PedidosWebToolStripMenuItem" Or miitem.Name = "PedidosMovilToolStripMenuItem" Then
                        miitem.Visible = False
                        Continue For
                    End If
                    '''' HABILITA FLAT MENU
                    FlatMenuEnableButton(miitem.Tag, True)
                    '''' RECORRE SUBMENU Y HABILITA FUNCIONES
                    recorrer(miitem)
                Else
                    '''' NO ESTA HABLILITADO
                    FlatMenuEnableButton(miitem.Tag, False)
                    miitem.Visible = False
                    miitem.Enabled = False
                End If
            Next
            ''''''''''''''''''''''''''''''''''''''  Permiso Venta CC '''''''''''''''''''''''''''''''''''''
            PermisoVtaCC = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "RegistrarVentaCuentaCorriente")
            gReloadPermisos = False
        Catch ex As Exception
            MsgEx("Ocurrio un excepción mientras se realizaba la acción:" + ex.Message)
        End Try
        'End If



    End Sub
    Private Sub InsertarFunciones(ByVal Oneitem As ToolStripMenuItem, ByVal modulonombre As String)

        For Each otroItem As ToolStripMenuItem In Oneitem.DropDownItems

            '**********    ACTUALIZA LAS DESCRIPCIONES DE LAS FUNCIONES EN LA BD
            If otroItem.Tag <> "Alerta1" And otroItem.Tag <> "Alerta2" And modulonombre <> "SysConfig" Then
                FuncionesTableAdapter1.funciones_insertupdate(otroItem.Text, Trim(otroItem.Tag), gnombremodulo)
            End If
            ''''''''''''   fin   '''''''''''''''''''''''''''
            If Not gusername = "lucasmartinbs" Then
                otroItem.Enabled = False
            End If

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
            ''''''''''''    ACCESOS OCULTOS POR DEFECTO  '''''''''''''''''''''''''''
            If otroItem.Name = "RegistrarVentaACuentaCorrienteToolStripMenuItem" Or otroItem.Name = "RegistrarPresupuestoToolStripMenuItem" Or otroItem.Name = "PedidosRecibidosVerTodosToolStripMenuItem" Then
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



    Private Sub GestionDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloVentas.Click

    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloStock.Click

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
        ingresoegresoproductos.MdiParent = Me
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
        '-----------------------------------------
        If GetEstadoCaja() = 0 Then
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
        AcercaDe.MdiParent = Me
        AcercaDe.Visible = True
    End Sub

    Private Sub MiComercioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiComercioToolStripMenuItem.Click
        'Dim p As MiComercio
        'p = New MiComercio
        MiComercio.TopMost = True
        MiComercio.ShowDialog()
    End Sub

    Private Sub FondoAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondoAplicaciónToolStripMenuItem.Click
        'Dim p As FondoAplicacion
        'p = New FondoAplicacion
        FondoAplicacion.TopMost = True
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



    Private Sub ActualizacionDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionDePreciosToolStripMenuItem.Click
        ActualizacionPrecios.MdiParent = Me
        ActualizacionPrecios.Visible = True
        'Dim p As ActualizacionPrecios
        'p = New ActualizacionPrecios
        'p.ShowDialog()
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
        ABMProveedores.TopMost = True
        ABMProveedores.ShowDialog()
    End Sub

    Private Sub Principal_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ''''''''''''''  CARGA DE PERMISOS DE USUARIO '''''''''''''''''''''
        'If Not gusername = "lucasmartinbs" Then
        '    cargapermisos()
        'End If
        'EjecutarAlertas()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
        BarCodePrint.TopMost = True
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
        ABMMotivosVales.TopMost = True
        ABMMotivosVales.ShowDialog()
    End Sub

    Private Sub AdministrarValesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarValesToolStripMenuItem.Click
        ADMVales.TopMost = True
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

    Private Sub TerminalVerificadoraDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodificarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodificarProductosToolStripMenuItem.Click
        permiso = 0
        permiso = ModulosTableAdapter.modulos_consultarestado("ModuloUtilidades")
        If permiso = 1 Then
            CodificarProductos.MdiParent = Me
            CodificarProductos.Visible = True
        Else
            MsgErrPopUp("Función No disponible en tu versión")
        End If

    End Sub

    Private Sub CambioMercaderíaVendidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioMercaderíaVendidaToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        '-----------------------------------------
        If GetEstadoCaja() = 0 Then
            CambioMultipleMV.MdiParent = Me
            CambioMultipleMV.Visible = True
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
        PedidosDeliveryRecibidos.MdiParent = Me
        PedidosDeliveryRecibidos.Visible = True
    End Sub

    Private Sub DespachoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespachoToolStripMenuItem.Click

        PedidosDeliveryDespacho.MdiParent = Me
        PedidosDeliveryDespacho.Visible = True
    End Sub

    Private Sub ABMProvinciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProvinciasToolStripMenuItem.Click
        ABMProvincias.MdiParent = Me
        ABMProvincias.Visible = True
    End Sub

    Private Sub ABMLocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ABMLocalidades.MdiParent = Me
        ABMLocalidades.Visible = True
    End Sub

    Private Sub EntregasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasToolStripMenuItem.Click
        Dim idevento As Long = 0

        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)

        If idevento = 0 Then
            MsgExPopUp("Para poder operar debe abrir la caja", "CAC")
            Return
        Else
            LotePedidosDeliveryRendir.MdiParent = Me
            LotePedidosDeliveryRendir.Visible = True
        End If

    End Sub

    Private Sub EstadoDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
        EstadoCuentaCorriente.MdiParent = Me
        EstadoCuentaCorriente.Visible = True
    End Sub

    Private Sub LotesDeEnvìosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesDeEnvìosToolStripMenuItem.Click
        LotesEnvios.MdiParent = Me
        LotesEnvios.Visible = True
    End Sub

    Private Sub Principal_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub



    Private Sub SincronizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AltaTerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaTerminalToolStripMenuItem.Click
        SCAltaDispositivo.TopMost = True
        SCAltaDispositivo.ShowDialog()

    End Sub

    Private Sub LibroVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroVentasToolStripMenuItem.Click
        LibroVentasDetalladas.MdiParent = Me
        LibroVentasDetalladas.Visible = True
    End Sub

    Private Sub ABMPerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPerfilesToolStripMenuItem.Click
        ABMPerfiles.MdiParent = Me
        ABMPerfiles.Visible = True
    End Sub

    Private Sub ABMTransportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTransportesToolStripMenuItem.Click
        ABMTransportes.MdiParent = Me
        ABMTransportes.Visible = True
    End Sub

    Private Sub POSTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub POSTFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSTFormToolStripMenuItem.Click
        POSTForm.MdiParent = Me
        POSTForm.Visible = True
    End Sub

    Private Sub LibroDeCuentasCorrientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDeCuentasCorrientesToolStripMenuItem.Click
        LibroCuentasCorrientes.MdiParent = Me
        LibroCuentasCorrientes.Visible = True
    End Sub

    Private Sub RegistrarVentaACuentaCorrienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentaACuentaCorrienteToolStripMenuItem.Click

    End Sub

    Private Sub MovimientosDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeStockToolStripMenuItem.Click
        StkMovimientos.MdiParent = Me
        StkMovimientos.Visible = True
    End Sub

    Private Sub ListasDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasDePreciosToolStripMenuItem.Click
        'ABMListasprecios.MdiParent = Me
        ABMListasprecios.ShowDialog()

    End Sub

    Private Sub CambioMultipleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioMultipleToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        '-----------------------------------------
        If GetEstadoCaja() = 0 Then
            CambioMultipleMV.MdiParent = Me
            CambioMultipleMV.Visible = True
        End If
        '***************    FIN consultar el estado de caja *************

    End Sub


    'Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    'holamundo?
    'End Sub

    Private Sub ABMTiposIVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposIVAToolStripMenuItem.Click
        ABMTiposIVA.ShowDialog()
    End Sub

    Private Sub TerminalVerificadoraDePreciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TerminalVerificadoraDePreciosToolStripMenuItem1.Click
        TerminalVerificadoraPrecios.Visible = True
    End Sub

    Private Sub ImportarProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ImportarProductos.MdiParent = Me
        ImportarProductos.Visible = True
    End Sub

    Private Sub AsignaciónDeIVAMasivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónDeIVAMasivoToolStripMenuItem.Click
        AsignacionIVAMasivo.ShowDialog()

    End Sub

    Private Sub LibroIVAVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroIVAVentasToolStripMenuItem.Click
        'LibroIVAVentas.ShowDialog()
        LibroIVAVentas.MdiParent = Me
        LibroIVAVentas.Visible = True

    End Sub

    Private Sub LibroIVAComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroIVAComprasToolStripMenuItem.Click
        'LibroIVACompras.ShowDialog()
        LibroIVACompras.MdiParent = Me
        LibroIVACompras.Visible = True
    End Sub



    'Private Sub Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    'End Sub


    'Private Sub Principal_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

    'End Sub

    'Private Sub Principal_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    'End Sub

    'Private Sub Principal_CausesValidationChanged(sender As Object, e As EventArgs) Handles Me.CausesValidationChanged

    'End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgQues("    Seguro desea salir del sistema?   ") = False Then
            e.Cancel = True
        Else
            ''********************************************************
            'Dim TerminalesTableadapter As siscomDataSetTableAdapters.terminalesTableAdapter
            'TerminalesTableadapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            ''********************************************************
            'Dim forceupdate As Integer = 0
            'Try
            '    forceupdate = TerminalesTableadapter.terminales_getforceupdate(gmacadress)
            'Catch ex As Exception
            '    forceupdate = 0
            'End Try
            'If gAutoUpdater = 1 And forceupdate = 1 Then
            '    e.Cancel = True
            '    DownloadSGC()
            'Else
            '    End
            'End If
        End If
    End Sub

    'Private Sub ImprimirPlantillasToolStripMenuItem_Click(sender As Object, e As EventArgs)


    'End Sub

    'Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub ImprimirPlantillasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ImprimirPlantillasToolStripMenuItem.Click
        ImprimirPlantillas.MdiParent = Me
        ImprimirPlantillas.Visible = True
    End Sub

    Private Sub ProductosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorProveedorToolStripMenuItem.Click
        ProductosProveedores.MdiParent = Me
        ProductosProveedores.Visible = True
    End Sub

    Private Sub MisClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisClientesToolStripMenuItem.Click

    End Sub

    Private Sub MisProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisProveedoresToolStripMenuItem.Click
        EstadisticasProveedor.MdiParent = Me
        EstadisticasProveedor.Visible = True
    End Sub

    Private Sub MisVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisVentasToolStripMenuItem.Click
        'EstadisticasVentas.MdiParent = Me
        'EstadisticasVentas.Visible = True
    End Sub

    Private Sub DescargarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarProductosToolStripMenuItem.Click
        If MsgQues("Este procedimiento tardará varios minutos, seguro desea continuar?") = True Then
            Dim CODERROR As Long
            Dim MSGERROR As String = ""
            DescargarProductosClowd(CODERROR, MSGERROR)
            If CODERROR = 0 Then
                MsgInfo("Sincronización de productos completa!")
            Else
                MsgEx(MSGERROR)
            End If
        End If
    End Sub

    Private Sub SubirProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirProductosToolStripMenuItem.Click
        If MsgBox("Este procedimiento tardará varios minutos, seguro desea continuar?", MsgBoxStyle.YesNo, "ADVERTENCIA! - Subir productos a la Nube") = MsgBoxResult.Yes Then
            Dim CODERROR As Long
            Dim MSGERROR As String = ""
            MySQLModule.SubirProductosClowd(CODERROR, MSGERROR)
            If CODERROR = 0 Then
                MsgInfo("Sincronización de productos completa!")
            Else
                MsgEx(MSGERROR)
            End If
        End If
    End Sub

    Private Sub Principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If (e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control) Then
            Dim retrylogin = New loginform
            Me.Hide()
            retrylogin.Show()
        End If
        '====================   WEB CONFIG ==================
        If (e.KeyCode = Keys.K AndAlso e.Control AndAlso e.Shift) Then
            Dim su As SUAuth
            su = New SUAuth
            gSUToken = Nothing
            su.ShowDialog()
            If gSUToken = True Then
                Dim conf As WebConf
                conf = New WebConf
                conf.ShowDialog()
                Dim retrylogin = New loginform
                Me.Hide()
                retrylogin.Show()
            End If
        End If
        ''''''''''***************************   POR DEFECTO **************************************
        If (e.KeyCode = Keys.S AndAlso e.Control AndAlso e.Shift) Then
            gSUToken = False
            Dim suauth As New SUAuth
            suauth.ShowDialog()
            If gSUToken = True Then
                LoadModuloMenuTOPSysConfig("SysConfig")
            End If
        End If
        '''''''''*************************** 
        '''''''''*************************** 
        If e.KeyCode = Keys.F5 Then
            EjecutarAlertas()
            'MostrarAlertas()
        End If
        '*********************************************************
        '*********************************************************
        If (e.KeyCode = Keys.R AndAlso e.Control AndAlso e.Shift) Then
            gSUToken = False
            Dim suauth As New SUAuth
            If Not gusername = "lucasmartinbs" Then
                suauth.ShowDialog()
            Else
                gSUToken = True
            End If
            '*********************************************************
            If gSUToken = True Then
                SCventas.MdiParent = Me
                SCventas.Visible = True
            End If
        End If
    End Sub

    Private Sub DescargarPedidosWEBToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BACKGROUNDSYNCLIBROVENTASCLOWD_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundSyncLibroventasClowd.DoWork
        'Dim SynLibroVentasStatus As Boolean
        Dim coderror As Integer
        Dim msgerror As String = ""
        'gMiSucursal = 1
        SynLibroVentas(coderror, msgerror)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub MisSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisSucursalesToolStripMenuItem.Click
        If Not My.Computer.Network.IsAvailable Then
            MsgExPopUp("No puede utilizar funciones basadas en la nube sin conexión a internet")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        Dim status As Boolean
        conectarSisCom(status)
        If status = True Then
            MisSucursales.MdiParent = Me
            MisSucursales.Visible = True
        End If
    End Sub

    Private Sub LibroDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDePedidosToolStripMenuItem.Click
        PedidosDeliveryLibro.MdiParent = Me
        PedidosDeliveryLibro.Visible = True
    End Sub

    Private Sub RepararMedidasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand
        Dim qry As String = "update productos set medida = 2"
        Try
            myConn2.Open()
            mycommand = New SqlCommand(qry, myConn2)
            myConn2.Close()
            myConn2.Dispose()
        Catch ex As Exception
            MsgEx("Ocurrio un problema: " + ex.Message)
        End Try
    End Sub

    Private Sub SubirStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirStockToolStripMenuItem.Click
        If Not BGWStock.IsBusy Then
            BGWStock.RunWorkerAsync()
            MsgInfoPopUp("El proceso ha comenzado, te avisaremos cuando finalice!")
        End If
    End Sub

    Private Sub BGWStock_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWStock.DoWork
        Dim coderror As Integer
        Dim msgerror As String = ""
        '*************  stock    **************************************
        Dim StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
        StockTableAdapter = New comercialDataSetTableAdapters.stockTableAdapter
        Try
            ' todos aquellos productos que se hayan vendido en negativo vuelven a cero
            StockTableAdapter.stock_resetproductosmasivo()
        Catch ex As Exception
            MessageBox.Show("No se pudo completar una operación de rutina, contacte al proveedor de sistema: BGWStock - stock_resetproductosmasivo - notfound -", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        '*******************************************************************************
        SynStockGeneral(coderror, msgerror)
    End Sub

    Private Sub BGWStock_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWStock.RunWorkerCompleted
        MsgSuccessPopUp("Stock cargado en la NUBE exitosamente!")
    End Sub

    Private Sub RegistrarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPresupuestoToolStripMenuItem.Click

    End Sub

    Private Sub PresupuestosGeneradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestosGeneradosToolStripMenuItem.Click
        PresupuestosGenerados.MdiParent = Me
        PresupuestosGenerados.Visible = True
    End Sub

    Private Sub VentasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorUsuarioToolStripMenuItem.Click
        VentasPorUsuario.MdiParent = Me
        VentasPorUsuario.Visible = True
    End Sub

    Private Sub LibroDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDeGastosToolStripMenuItem.Click
        MsgErrPopUp("Temporalmente no disponible")
    End Sub

    Private Sub BGWAlertas_DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub

    Private Sub HistoricoVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoVentasToolStripMenuItem.Click
        EstHistoricoVentas.MdiParent = Me
        EstHistoricoVentas.Visible = True
    End Sub

    Private Sub EnvíosPorSucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvíosPorSucursalesToolStripMenuItem.Click
        EstEnviosRecepcionesSucursales.MdiParent = Me
        EstEnviosRecepcionesSucursales.Visible = True
    End Sub

    Private Sub PrincipioDeParetoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipioDeParetoToolStripMenuItem.Click
        EstParetto.MdiParent = Me
        EstParetto.Visible = True
    End Sub

    Private Sub VentasPorProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorProvinciaToolStripMenuItem.Click
        EstVentasProvincias.MdiParent = Me
        EstVentasProvincias.Visible = True
    End Sub

    Private Sub ABMTipoComprobantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTipoComprobantesToolStripMenuItem.Click
        ABMTipoComprobantes.MdiParent = Me
        ABMTipoComprobantes.Visible = True
    End Sub

    Private Sub RankingDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingDeVentasToolStripMenuItem.Click

        EstRankingCantVentas.MdiParent = Me
        EstRankingCantVentas.Visible = True

    End Sub

    Private Sub FacturaElectrónicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaElectrónicaToolStripMenuItem.Click
        Dim fe As New FeConf()
        fe.TopMost = True
        fe.ShowDialog()
        PrincipalTituloPrincipal()
    End Sub

    Private Sub MailServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailServerToolStripMenuItem.Click
        MailServerConf.MdiParent = Me
        MailServerConf.Visible = True
    End Sub

    Private Sub RecargarPermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecargarPermisosToolStripMenuItem.Click
        cargapermisos()
        FeAFIPLoad()
    End Sub

    Private Sub ComprobanesEmitidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobanesEmitidosToolStripMenuItem.Click
        FeAFIPLoad()

        Select Case GFEAFIPENTORNO
            Case "HOMOLOGACION"
                ComprobantesEmitidos.MdiParent = Me
                ComprobantesEmitidos.Visible = True
            Case "PRODUCCION"
                ComprobantesEmitidos.MdiParent = Me
                ComprobantesEmitidos.Visible = True
            Case Else
                MessageBox.Show("Módulo de Facturación Electrónica INACTIVO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        '-----------------------------------------
        If GetEstadoCaja() = 0 Then
            AdmOrdenes.MdiParent = Me
            AdmOrdenes.Visible = True
        End If
        '***************    FIN consultar el estado de caja *************

    End Sub

    Private Sub SalonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalonesToolStripMenuItem.Click
        GGAdmSalones.MdiParent = Me
        GGAdmSalones.Visible = True
    End Sub

    Private Sub BGWClientes_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWClientes.DoWork
        'Dim coderror As Integer
        'Dim msgerror As String = ""
        '*************  clientes    **************************************
        Try
            SynClientes()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema al tratar de sincronizar Clientes en la nube: " + ex.Message, "Advertencia - BGWClientes ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        '*******************************************************************************
        'SynStockGeneral(coderror, msgerror)
    End Sub

    Private Sub BGWAlertas_DoWork_1(sender As Object, e As DoWorkEventArgs) Handles BGWAlertas.DoWork
        EjecutarAlertas()
    End Sub
    Public Sub MostrarAlertas()
        For i = 0 To gNotificacionesAlertasDataTable.Count
            Try
                Dim xd As frmAlert = New frmAlert
                Dim msg As String = gNotificacionesAlertasDataTable.Rows(i).Item(gNotificacionesAlertasDataTable.msgalertaColumn)
                Dim codalerta As String = gNotificacionesAlertasDataTable.Rows(i).Item(gNotificacionesAlertasDataTable.codalertaColumn)
                xd.setAlert(msg, codalerta, frmAlert.alertTypeEnum.Warning)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ConfiguraciónesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónesToolStripMenuItem.Click
        ConfiguracionesFranquicia.MdiParent = Me
        ConfiguracionesFranquicia.Visible = True
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        ReporteVentasFranquicia.MdiParent = Me
        ReporteVentasFranquicia.Visible = True
    End Sub

    Private Sub SincronizarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If gModuloCloud = 1 Then
            BGWClientes.RunWorkerAsync()
        End If
    End Sub

    Private Sub BGWClientes_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWClientes.RunWorkerCompleted
        MessageBox.Show("Sincronizacion de Clientes en la Nube Completa!", "BGWClientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ConfiguraciónDeGradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónDeGradosToolStripMenuItem.Click
        ABMGrados.MdiParent = Me
        ABMGrados.Visible = True
    End Sub

    Private Sub AltaInscripciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaInscripciónToolStripMenuItem.Click
        AltaInscripcion.MdiParent = Me
        AltaInscripcion.Visible = True
    End Sub

    Private Sub RegistroDeInscripciónesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeInscripciónesToolStripMenuItem.Click

        RegistroInscripciones.MdiParent = Me
        RegistroInscripciones.Visible = True
    End Sub

    Private Sub ConfigurarMembreteYFirmaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarMembreteYFirmaToolStripMenuItem.Click
        CFGMembreteFirmante.MdiParent = Me
        CFGMembreteFirmante.Visible = True
    End Sub

    Private Sub ReporteDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeGastosToolStripMenuItem.Click
        ReporteGastos.MdiParent = Me
        ReporteGastos.Visible = True
    End Sub

    Private Sub Principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Cursor = Cursors.WaitCursor
        BackUpDataBase()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LotesDeVencimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesDeVencimientoToolStripMenuItem.Click
        LotesVencimiento.MdiParent = Me
        LotesVencimiento.Visible = True
    End Sub

    Private Sub LibroVentasCanceladasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroVentasCanceladasToolStripMenuItem.Click
        LibroVentasCanceladas.MdiParent = Me
        LibroVentasCanceladas.Visible = True
    End Sub

    Private Sub DefinirCriteriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinirCriteriosToolStripMenuItem.Click
        DefinirCriteriosVenta.MdiParent = Me
        DefinirCriteriosVenta.Visible = True
    End Sub

    Private Sub ConsumoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumoClienteToolStripMenuItem.Click

        EstadisticasCliente.MdiParent = Me
        EstadisticasCliente.Visible = True
    End Sub

    Private Sub RankingClientesPorImporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingClientesPorImporteToolStripMenuItem.Click
        RankingClientesPorImporte.MdiParent = Me
        RankingClientesPorImporte.Visible = True
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModuloNotificaciones.Click
        If CountAlertas = 0 Then
            MsgSuccessPopUp("Tenés [0] notificaciones! Nada de que preocuparse...")
        Else
            MostrarAlertas()
        End If
    End Sub

    Private Sub SincronizarClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SincronizarClientesToolStripMenuItem1.Click
        If Not BGWClientes.IsBusy Then
            BGWClientes.RunWorkerAsync()
        End If
    End Sub

    Private Sub GruposJerarquicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposJerarquicosToolStripMenuItem.Click
        'ABMGruposJerarquicos.MdiParent = Me
        'ABMGruposJerarquicos.Visible = True
        Dim GJ As New ABMGruposJerarquicos()
        GJ.ShowDialog()
    End Sub

    Private Sub CentrosDeCostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosDeCostoToolStripMenuItem.Click
        Dim CC As New ABMCentroscosto()
        CC.ShowDialog()
    End Sub

    Private Sub ObrasSocialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObrasSocialesToolStripMenuItem.Click
        Dim OS As New ABMObrasSociales()
        OS.ShowDialog()
    End Sub

    Private Sub SindicatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SindicatosToolStripMenuItem.Click
        Dim sin As New ABMSindicatos()
        sin.ShowDialog()

    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasToolStripMenuItem.Click
        Dim ce As New ABMCategoriasEmpleados()
        ce.ShowDialog()
    End Sub

    Private Sub LegajosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LegajosToolStripMenuItem.Click
        Dim AE As New ABMEmpleados()
        AE.ShowDialog()
    End Sub

    Private Sub AMBIncapacidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMBIncapacidadesToolStripMenuItem.Click
        Dim AI As New ABMIncapacidades()
        AI.ShowDialog()
    End Sub

    Private Sub QRTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRTestToolStripMenuItem.Click
        QRTest.ShowDialog()

    End Sub

    Private Sub ExportarListaDePreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarListaDePreciosToolStripMenuItem.Click
        Dim x As New ExportarListaPrecios()
        'x.MdiParent = Me
        x.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureMenu.Click
        If PanelSlider.Width = 50 Then
            PanelSlider.Width = 250
        Else
            PanelSlider.Width = 50
        End If
    End Sub

    Private Sub FlowLayoutPanelBotonera_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanelBotonera.Paint

    End Sub

    Private Sub FlowLayoutPanelBotonera_MouseWheel(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanelBotonera.MouseWheel
        Dim myview As Point = Me.FlowLayoutPanelBotonera.AutoScrollPosition
        If e.Delta > 0 Then
            'sube
            If myview.Y = 0 Then Return
            myview.Y = (myview.Y + 50)
        Else
            'baja
            If myview.Y < 0 Then Return
            myview.Y = (myview.Y + 50)
        End If
        FlowLayoutPanelBotonera.AutoScrollPosition = myview
    End Sub
    Private Sub LoadModuloMenuTOP(tag As String)
        '/**************************************************************/
        '/*     CARGA LAS FUNCIONES DISPONIBLES PARA EL MODULO                                                 */
        '*********************************************************************
        MenuStripTop.AutoSize = True
        Try
            Dim modulo As ToolStripMenuItem
            modulo = MenuStripMain.Items(tag)
            Dim colorBG As New Color
            Dim colorFore As New Color
            colorBG = MenuStripMain.BackColor
            colorFore = Color.White 'Color.FromArgb(255, 121, 70) ' 'Color.White
            MenuStripTop.ForeColor = colorFore
            MenuStripTop.Items.Clear()
            For i = 0 To modulo.DropDownItems.Count - 1
                Dim submenu As New ToolStripMenuItem()
                Dim submenuinsertado As New ToolStripMenuItem()
                If modulo.DropDownItems(i).Enabled = False Then Continue For
                submenu = modulo.DropDownItems(i)
                If submenu.HasDropDown Then
                    submenu.ForeColor = MenuStripTop.ForeColor
                    submenu.BackColor = MenuStripTop.BackColor
                    submenuinsertado = MenuStripTop.Items.Add(modulo.DropDownItems(i).Text, modulo.DropDownItems(i).Image, AddressOf modulo.DropDownItems(i).PerformClick)
                    submenuinsertado.BackColor = colorBG
                    submenuinsertado.ForeColor = colorFore
                    For j = 0 To submenu.DropDownItems.Count - 1
                        If submenu.DropDownItems(j).Enabled = False Then Continue For
                        Dim subsubmenu As New ToolStripMenuItem()
                        subsubmenu = submenuinsertado.DropDownItems.Add(submenu.DropDownItems(j).Text, submenu.DropDownItems(j).Image, AddressOf submenu.DropDownItems(j).PerformClick)
                        subsubmenu.ForeColor = colorFore
                        subsubmenu.BackColor = colorBG
                    Next
                Else
                    MenuStripTop.Items.Add(modulo.DropDownItems(i).Text, modulo.DropDownItems(i).Image, AddressOf modulo.DropDownItems(i).PerformClick)
                End If
            Next
            MenuStripTop.Refresh()
        Catch ex As Exception
            MsgExPopUp("No se pudo cargar el módulo seleccionado: [" + tag + "]")
        End Try
    End Sub
    Private Sub LoadModuloMenuTOPSysConfig(tag As String)
        '/**************************************************************/
        '/*     CARGA LAS FUNCIONES DISPONIBLES PARA EL MODULO                                                 */
        '*********************************************************************
        MenuStripTop.AutoSize = True
        Try
            Dim modulo As ToolStripMenuItem
            modulo = MenuStripMain.Items(tag)
            Dim color As New Color
            color = Color.Black
            MenuStripTop.ForeColor = MenuStripMain.ForeColor
            MenuStripTop.BackColor = MenuStripMain.BackColor
            MenuStripTop.Items.Clear()
            For i = 0 To modulo.DropDownItems.Count - 1
                Dim submenu As New ToolStripMenuItem()
                Dim submenuinsertado As New ToolStripMenuItem()
                modulo.DropDownItems(i).Enabled = True
                submenu = modulo.DropDownItems(i)
                If submenu.HasDropDown Then
                    submenu.ForeColor = MenuStripTop.ForeColor
                    submenu.BackColor = MenuStripTop.BackColor
                    submenuinsertado = MenuStripTop.Items.Add(modulo.DropDownItems(i).Text, modulo.DropDownItems(i).Image, AddressOf modulo.DropDownItems(i).PerformClick)
                    For j = 0 To submenu.DropDownItems.Count - 1
                        submenu.DropDownItems(j).Enabled = True
                        submenuinsertado.DropDownItems.Add(submenu.DropDownItems(j).Text, submenu.DropDownItems(j).Image, AddressOf submenu.DropDownItems(j).PerformClick)
                        submenuinsertado.ForeColor = MenuStripTop.ForeColor
                        submenuinsertado.BackColor = MenuStripTop.BackColor
                    Next
                Else
                    MenuStripTop.Items.Add(modulo.DropDownItems(i).Text, modulo.DropDownItems(i).Image, AddressOf modulo.DropDownItems(i).PerformClick)
                End If
            Next
            MenuStripTop.Refresh()
        Catch ex As Exception
            MsgExPopUp("No se pudo cargar el módulo seleccionado: [" + tag + "]")
        End Try
    End Sub

    Public Sub FlatMenuEnableButton(ByRef modulo As String, ByRef status As Boolean)
        Select Case modulo
            Case ListaModulos.ModuloVentas.ToString
                FlatBtnModuloVentas.Visible = status
            Case ListaModulos.ModuloDelivery.ToString
                FlatBtnModuloDelivery.Visible = status
            Case ListaModulos.ModuloStock.ToString
                FlatBtnModuloStock.Visible = status
            Case ListaModulos.ModuloProveedores.ToString
                FlatBtnModuloProveedores.Visible = status
            Case ListaModulos.ModuloTransferenciaStock.ToString
                FlatBtnModuloTransferenciaStock.Visible = status
            Case ListaModulos.ModuloCajas.ToString
                FlatBtnModuloCajas.Visible = status
            Case ListaModulos.ModuloVales.ToString
            Case ListaModulos.ModuloCuentasCorrientes.ToString
                FlatBtnModuloCuentasCorrientes.Visible = status
            Case ListaModulos.ModuloContabilidad.ToString
            Case ListaModulos.ModuloEstadisticas.ToString
                FlatBtnModuloEstadisticas.Visible = status
            Case ListaModulos.ModuloUtilidades.ToString
                FlatBtnModuloUtilidades.Visible = status
            Case ListaModulos.ModuloConfiguraciones.ToString
                FlatBtnModuloConfiguraciones.Visible = status
            Case ListaModulos.ModuloSeguridad.ToString
                FlatBtnModuloSeguridad.Visible = status
            Case ListaModulos.TerminalVerificadoraPrecios.ToString
                FlatBtnTerminalVerificadoraPrecios.Visible = status
            Case ListaModulos.ModuloAyuda.ToString
                FlatBtnModuloAyuda.Visible = status
            Case ListaModulos.ModuloNotificaciones.ToString
                FlatBtnModuloNotificaciones.Visible = status
            Case ListaModulos.ModuloCloud.ToString
                FlatBtnModuloCloud.Visible = status
            Case ListaModulos.ModuloSyncWeb.ToString
            Case ListaModulos.ModuloGGastronomica.ToString
                FlatBtnModuloGGastronomica.Visible = status
            Case ListaModulos.ModuloFranquicia.ToString
                FlatBtnModuloFranquicia.Visible = status
            Case ListaModulos.ModuloPreventa.ToString
            Case ListaModulos.ModuloGestionEscolar.ToString
                FlatBtnModuloGestionEscolar.Visible = status
            Case ListaModulos.ModuloPedidosWeb.ToString
            Case ListaModulos.ModuloPedidosMovil.ToString
            Case ListaModulos.ModuloSueldos.ToString
                FlatBtnModuloSueldos.Visible = status
        End Select
    End Sub

    Private Sub ImportarProductosToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImportarProductosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ImportarProductosToolStripMenuItem2.Click
        ImportarProductos.MdiParent = Me
        ImportarProductos.Visible = True
    End Sub

    Private Sub FlatBtnModuloNotificaciones_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloNotificaciones.Click
        If CountAlertas = 0 Then
            MsgSuccessPopUp("Tenés [0] notificaciones! Nada de que preocuparse...")
        Else
            MostrarAlertas()
        End If
    End Sub
    Private Sub ModuloProductos_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloStock.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloGGastronomica.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub
    Private Sub FlatBtnModuloConfiguraciones_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloConfiguraciones.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloGestionEscolar_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloGestionEscolar.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloSeguridad_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloSeguridad.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloFranquicia_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloFranquicia.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnTerminalVerificadoraPrecios_Click(sender As Object, e As EventArgs) Handles FlatBtnTerminalVerificadoraPrecios.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloUtilidades_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloUtilidades.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloAyuda_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloAyuda.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloEstadisticas_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloEstadisticas.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloCloud_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloCloud.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloContabilidad_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloContabilidad.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloCuentasCorrientes_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloCuentasCorrientes.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloModuloCajas_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloCajas.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloModuloTransferenciaStock_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloTransferenciaStock.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloProveedores_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloProveedores.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub
    Private Sub BtnModuloVentas_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloVentas.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub BtnModuloDelivery_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloDelivery.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub FlatBtnModuloSueldos_Click(sender As Object, e As EventArgs) Handles FlatBtnModuloSueldos.Click
        LoadModuloMenuTOP(CType(sender, Button).Tag)
    End Sub

    Private Sub PictureLogo_Click(sender As Object, e As EventArgs) Handles PictureLogo.Click

    End Sub

    Private Sub PictureLogo_DoubleClick(sender As Object, e As EventArgs) Handles PictureLogo.DoubleClick

    End Sub

    Private Sub ExportarProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureMenu_MouseHover(sender As Object, e As EventArgs) Handles PictureMenu.MouseHover
        PictureMenu.BackColor = SCHoverColorDark
    End Sub

    Private Sub PictureMenu_MouseLeave(sender As Object, e As EventArgs) Handles PictureMenu.MouseLeave
        PictureMenu.BackColor = SCBackColorDark
    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxClose_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseHover
        PictureBoxClose.BackColor = SCHoverColorDark
    End Sub

    Private Sub PictureBoxClose_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseLeave
        PictureBoxClose.BackColor = SCBackColorDark
    End Sub

    Private Sub PictureBoxMaximize_Click(sender As Object, e As EventArgs) Handles PictureBoxMaximize.Click
        PrincipalMaximizar()
    End Sub
    Public Sub PrincipalMaximizar()
        If PrincipalSizeWindow = "MAX" Then
            Me.Size = New Size(800, 600)
            Me.Location = New Point(0, 0)
            Me.WindowState = FormWindowState.Normal
            PrincipalSizeWindow = "NORMAL"
        Else
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location
            'Me.WindowState = FormWindowState.Maximized
            PrincipalSizeWindow = "MAX"
        End If

    End Sub

    Private Sub PictureBoxMaximize_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxMaximize.MouseHover
        PictureBoxMaximize.BackColor = SCHoverColorDark
    End Sub

    Private Sub PictureBoxMinimize_Click(sender As Object, e As EventArgs) Handles PictureBoxMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBoxMaximize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMaximize.MouseLeave
        PictureBoxMaximize.BackColor = SCBackColorDark
    End Sub

    Private Sub PictureBoxMinimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseHover
        PictureBoxMinimize.BackColor = SCHoverColorDark
    End Sub

    Private Sub PictureBoxMinimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseLeave
        PictureBoxMinimize.BackColor = SCBackColorDark
    End Sub

    Private Sub PanelControlBox_Paint(sender As Object, e As PaintEventArgs) Handles PanelControlBox.Paint

    End Sub

    Private Sub PanelControlBox_DoubleClick(sender As Object, e As EventArgs) Handles PanelControlBox.DoubleClick
        PrincipalMaximizar()
    End Sub

    Private Sub PrincipalTitle_Click(sender As Object, e As EventArgs) Handles PrincipalTitle.Click

    End Sub

    Private Sub PictureBoxAPPICON_Click(sender As Object, e As EventArgs) Handles PictureBoxAPPICON.Click

    End Sub

    Private Sub PictureBoxAPPICON_DoubleClick(sender As Object, e As EventArgs) Handles PictureBoxAPPICON.DoubleClick
        Me.Close()
    End Sub

    Private Sub PanelControlBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelControlBox.MouseDown
        Me.drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Principal_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove


    End Sub

    Private Sub PanelControlBox_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelControlBox.MouseUp
        drag = False
    End Sub

    Private Sub PanelControlBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelControlBox.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PrincipalTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PrincipalTitle.MouseDown
        Me.drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PrincipalTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles PrincipalTitle.MouseUp
        Me.drag = False
    End Sub

    Private Sub PrincipalTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PrincipalTitle.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PrincipalTitle_DoubleClick(sender As Object, e As EventArgs) Handles PrincipalTitle.DoubleClick
        PrincipalMaximizar()
    End Sub

    Private Sub TutorialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialesToolStripMenuItem.Click
        Process.Start("https://www.youtube.com/playlist?list=PLzIuuDP2FFzbS9twc_fTlYm8JtbwDJk8n")
    End Sub

    Private Sub MenuStripTop_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStripTop.ItemClicked
        TimerHideSlider.Interval = 1
        TimeSliderTimer = 0
        TimerHideSlider.Start()
    End Sub

    Private Sub TimerHideSlider_Tick(sender As Object, e As EventArgs) Handles TimerHideSlider.Tick
        If TimeSliderTimer >= 150 Or PanelSlider.Width = 50 Then
            PanelSlider.Width = 50
            TimerHideSlider.Stop()
        End If
        TimeSliderTimer += 1
    End Sub
End Class
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class Principal
    Dim xi As LoadingForm
    Dim permiso As Integer = 0
    Private Sub Principal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub
    Sub PrincipalTituloPrincipal()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   TITULO DE LA VENTANA PRINCIPAL
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            gNombreComercio = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio")
            Me.Text = " EPOS " + " - [" + gNombreComercio + "]" + " - Caja N°: [" + gidcaja.ToString + "] - Usuario: [" + gusername + "] - Sucursal N°: [" + gMiSucursal.ToString + "]" + " - Versión: [" + SoftwareVersion + "]" + " - Facturación Electrónica: [" + GFEAFIPENTORNO + "]"
            If gIsOnline = False Then
                Me.Text = Me.Text + " - [SIN INTERNET]"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If gModuloClowd = 1 Then
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
    End Sub
    Private Sub EjecutarAlertas()
        '====================================================================
        ''''''''''''''''''''''''''''''''''''''  ALERTASSSSSSSSSSSS '''''''''''''''''''''''''''''''''''''
        '====================================================================
        ''''''''''''''''''''''''''''''''''''''  ALERTA STOCK '''''''''''''''''''''''''''''''''''''
        permiso = 0
        permiso = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "StockParent")
        If Not permiso = 0 Then
            reloadstock()
        End If
        ''''''''''''''''''''''''''''''''''''''  ALERTA CUENTAS CORRIENTES '''''''''''''''''''''''''''''''''''''
        permiso = 0
        permiso = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "LibroCuentasCorrientes")
        If Not permiso = 0 Then
            AlertaCuentasCorrientes()
        End If
        '====================================================================
        '====================================================================
        If Alerta1ToolStripMenuItem.Text = "Alerta1" And Alerta2ToolStripMenuItem.Text = "Alerta2" Then
            NotificacionesToolStripMenuItem.Visible = False
        Else
            NotificacionesToolStripMenuItem.Visible = True
        End If
        '====================================================================
        ''''''''''''''''''''''''''''''''''''''  FIN '''''''''''''''''''''''''''''''''''''
        '====================================================================
    End Sub

    Public Shared LastSysTime As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub InsertarModulos()
        For Each miitem As ToolStripMenuItem In Me.MenuStrip1.Items
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
                For Each miitem As ToolStripMenuItem In Me.MenuStrip1.Items
                    rtn = ModulosTableAdapter.modulos_habilitar(miitem.Tag)
                    If rtn > 0 Then
                        If Not miitem.Name = "NotificacionesToolStripMenuItem" Then
                            recorrer(miitem)
                        End If
                    Else
                        miitem.Visible = False
                        miitem.Enabled = False
                    End If
                Next
                ''''''''''''''''''''''''''''''''''''''  Permiso Venta CC '''''''''''''''''''''''''''''''''''''
                PermisoVtaCC = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "RegistrarVentaCuentaCorriente")
                gReloadPermisos = False
            Catch ex As Exception
                MsgBox("Ocurrio un excepción mientras se realizaba la acción:" + ex.Message)
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
    Public Sub reloadstock()
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter
        '*******************************************************************************
        Try
            Me.StockalertaTableAdapter.Fill(Me.ComercialDataSet.stockalerta)
        Catch ex As Exception
            Try
                Dim myConnX As SqlConnection = New SqlConnection(gActiveSQLConnectionString)
                Dim mycommand As New SqlCommand
                myConnX.Open()
                mycommand = New SqlCommand("update productos set medida = 1 where medida is null or medida = 0", myConnX)
                mycommand.ExecuteNonQuery()
                ErrorLogTableAdapter.errorlog_insertar("AlertasStock", "Aplicacion", "reloadstock", ex.Message)
                myConnX.Close()
                myConnX.Dispose()
                'MsgBox("Ocurrio un problema al cargar las alertas de stock: " + ex.Message)
            Catch ex2 As Exception
                ErrorLogTableAdapter.errorlog_insertar("AlertasStock", "Aplicacion", "reloadstock-nivel2", ex2.Message)
            End Try
        End Try

        '=========== VERIFICO SI HAY ALERTA ACTIVA
        If Alerta1ToolStripMenuItem.Text = "Se necesita reponer productos!" Or Alerta2ToolStripMenuItem.Text = "Se necesita reponer productos!" Then
            If DataGridViewStockAlerta.RowCount > 0 Then ' SI HAY PRODUCTOS EN ALERTA ENTONCES ESTA TODO OK... SALGO
                Return
            Else ' NO HAY PRODUCTOS EN ALERTA - reseteo los menues de alerta a cero e invisible
                If Alerta1ToolStripMenuItem.Text = "Se necesita reponer productos!" Then
                    Alerta1ToolStripMenuItem.Text = "Alerta1"
                    Alerta1ToolStripMenuItem.Visible = False
                    Return
                End If
                If Alerta2ToolStripMenuItem.Text = "Se necesita reponer productos!" Then
                    Alerta2ToolStripMenuItem.Text = "Alerta2"
                    Alerta2ToolStripMenuItem.Visible = False
                    Return
                End If
            End If

        End If
        '=========== SETEO ALERTA - LAS ALERTAS ESTAN APAGADAS
        If DataGridViewStockAlerta.RowCount > 0 Then
            Try
                If Alerta1ToolStripMenuItem.Text = "Alerta1" Then
                    Alerta1ToolStripMenuItem.Visible = True
                    NotificacionesToolStripMenuItem.Visible = True
                    Alerta1ToolStripMenuItem.Text = "Se necesita reponer productos!"
                    Return
                End If
                If Alerta2ToolStripMenuItem.Text = "Alerta2" Then
                    NotificacionesToolStripMenuItem.Visible = True
                    Alerta2ToolStripMenuItem.Visible = True
                    Alerta2ToolStripMenuItem.Text = "Se necesita reponer productos!"
                    Return
                End If
            Catch ex As Exception

            End Try

        Else
            Try
                If Alerta1ToolStripMenuItem.Text = "Se necesita reponer productos!" Then
                    Alerta1ToolStripMenuItem.Text = "Alerta1"
                    Alerta1ToolStripMenuItem.Visible = True
                    Return
                End If
                If Alerta2ToolStripMenuItem.Text = "Se necesita reponer productos!" Then
                    Alerta2ToolStripMenuItem.Text = "Alerta2"
                    Alerta2ToolStripMenuItem.Visible = True
                    Return
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Sub AlertaCuentasCorrientes()
        '==================
        Try
            Me.AlertacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.alertacuentascorrientes)
        Catch ex As Exception
            MsgBox("No se pudo cargar las alertas de Cuentas Corrientes: " + ex.Message)
        End Try
        '=========== VERIFICO SI HAY ALERTA ACTIVA
        If Alerta1ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Or Alerta2ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Then
            If AlertacuentascorrientesDataGridView.RowCount > 0 Then ' SI HAY PRODUCTOS EN ALERTA ENTONCES ESTA TODO OK... SALGO
                Return
            Else ' NO HAY PRODUCTOS EN ALERTA - reseteo los menues de alerta a cero e invisible
                If Alerta1ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Then
                    Alerta1ToolStripMenuItem.Text = "Alerta1"
                    Alerta1ToolStripMenuItem.Visible = False
                    Return
                End If
                If Alerta2ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Then
                    Alerta2ToolStripMenuItem.Text = "Alerta2"
                    Alerta2ToolStripMenuItem.Visible = False
                    Return
                End If
            End If

        End If
        '=========== SETEO ALERTA - LAS ALERTAS ESTAN APAGADAS
        If AlertacuentascorrientesDataGridView.RowCount > 0 Then
            If Alerta1ToolStripMenuItem.Text = "Alerta1" Then
                Alerta1ToolStripMenuItem.Visible = True
                NotificacionesToolStripMenuItem.Visible = True
                Alerta1ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!"
                Return
            End If
            If Alerta2ToolStripMenuItem.Text = "Alerta2" Then
                NotificacionesToolStripMenuItem.Visible = True
                Alerta2ToolStripMenuItem.Visible = True
                Alerta2ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!"
                Return
            End If
        Else
            If Alerta1ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Then
                Alerta1ToolStripMenuItem.Text = "Alerta1"
                Alerta1ToolStripMenuItem.Visible = True
                Return
            End If
            If Alerta2ToolStripMenuItem.Text = "Revisar Cuentas Vencidas!" Then
                Alerta2ToolStripMenuItem.Text = "Alerta2"
                Alerta2ToolStripMenuItem.Visible = True
                Return
            End If
        End If
        '=============================
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
            MsgBox("Función No disponible en tu versión", MsgBoxStyle.Information, "Aviso")
        End If

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
            MsgBox("Para poder operar debe abrir la caja", MsgBoxStyle.Exclamation)
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
        'RegistrarVentaCC.MdiParent = Me
        'RegistrarVentaCC.Visible = True
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
            CambioMultipleMV.MdiParent = Me
            CambioMultipleMV.Visible = True
        End If
        '***************    FIN consultar el estado de caja *************
    End Sub

    Private Sub ImportarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Alerta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Alerta1ToolStripMenuItem.Click
        Select Case Alerta1ToolStripMenuItem.Text
            Case "Se necesita reponer productos!"
                'Dim p As StockAlerta
                'p = New StockAlerta
                StockAlerta.ShowDialog()
            Case "Revisar Cuentas Vencidas!"
                Dim p As AlertaCuentasCorrientes
                p = New AlertaCuentasCorrientes
                p.ShowDialog()
        End Select
    End Sub
    Private Sub Alerta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Alerta2ToolStripMenuItem.Click
        Select Case Alerta2ToolStripMenuItem.Text
            Case "Se necesita reponer productos!"
                'Dim p As StockAlerta
                'p = New StockAlerta
                StockAlerta.ShowDialog()
            Case "Revisar Cuentas Vencidas!"
                Dim p As AlertaCuentasCorrientes
                p = New AlertaCuentasCorrientes
                p.TopMost = True
                p.ShowDialog()
        End Select
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

    Private Sub ImportarProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImportarProductosToolStripMenuItem1.Click
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

    Private Sub ExportarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarProductosToolStripMenuItem.Click
        ExportarProductos.MdiParent = Me
        ExportarProductos.Visible = True
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
        If MsgBox("    Seguro desea salir del sistema?   ", MessageBoxButtons.YesNo, "Pregunta") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            '********************************************************
            Dim TerminalesTableadapter As siscomDataSetTableAdapters.terminalesTableAdapter
            TerminalesTableadapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            '********************************************************
            Dim forceupdate As Integer = 0
            Try
                forceupdate = TerminalesTableadapter.terminales_getforceupdate(gmacadress)
            Catch ex As Exception
                forceupdate = 0
            End Try
            If gAutoUpdater = 1 And forceupdate = 1 Then
                e.Cancel = True
                DownloadSGC()
            Else
                End
            End If
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
        EstadisticasCliente.MdiParent = Me
        EstadisticasCliente.Visible = True
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
        If MsgBox("Este procedimiento tardará varios minutos, seguro desea continuar?", MsgBoxStyle.YesNo, "ADVERTENCIA! - Descargar productos de la Nube") = MsgBoxResult.Yes Then
            Dim CODERROR As Long
            Dim MSGERROR As String = ""
            DescargarProductosClowd(CODERROR, MSGERROR)
            If CODERROR = 0 Then
                MsgBox("Sincronización de productos completa!", MsgBoxStyle.Information)
            Else
                MsgBox(MSGERROR, MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub SubirProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirProductosToolStripMenuItem.Click
        If MsgBox("Este procedimiento tardará varios minutos, seguro desea continuar?", MsgBoxStyle.YesNo, "ADVERTENCIA! - Subir productos a la Nube") = MsgBoxResult.Yes Then
            Dim CODERROR As Long
            Dim MSGERROR As String = ""
            MySQLModule.SubirProductosClowd(CODERROR, MSGERROR)
            If CODERROR = 0 Then
                MsgBox("Sincronización de productos completa!", MsgBoxStyle.Information)
            Else
                MsgBox(MSGERROR, MsgBoxStyle.Exclamation)
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
        'If e.KeyCode = Keys.Escape Then
        '    If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
        '        Me.Close()
        '    End If
        'End If

        ''''''''''***************************   POR DEFECTO **************************************
        If (e.KeyCode = Keys.S AndAlso e.Control AndAlso e.Shift) Then
            For Each miitem As ToolStripMenuItem In Me.MenuStrip1.Items
                If miitem.Name = "SysConfigToolStripMenuItem" Then
                    If miitem.Visible = True Then
                        miitem.Visible = False
                        miitem.Enabled = False
                        For Each otroitem As ToolStripMenuItem In miitem.DropDownItems
                            otroitem.Enabled = False
                        Next
                    Else
                        gSUToken = False
                        Dim suauth As New SUAuth
                        suauth.ShowDialog()
                        If gSUToken = True Then
                            miitem.Visible = True
                            miitem.Enabled = True
                            For Each otroitem As ToolStripMenuItem In miitem.DropDownItems
                                otroitem.Enabled = True
                            Next
                        End If
                    End If
                End If
            Next
        End If
        '''''''''*************************** 
        '''''''''*************************** 
        If e.KeyCode = Keys.F5 Then
            'MsgBox("recargando")
            EjecutarAlertas()
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

    Private Sub DescargarPedidosWEBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarPedidosWEBToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        SynClientes()
        SynPedidos()
        Cursor.Current = Cursors.Default
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
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
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
            MsgBox("Ocurrio un problema: " + ex.Message)
        End Try
    End Sub

    Private Sub SubirStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirStockToolStripMenuItem.Click
        If Not BGWStock.IsBusy Then
            BGWStock.RunWorkerAsync()
            MsgBox("El proceso ha comenzado, te avisaremos cuando finalice!", MsgBoxStyle.Information, "Aviso")
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
        'MsgBox("Stock cargado en la NUBE exitosamente!", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub RegistrarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPresupuestoToolStripMenuItem.Click
        '***************    consultar el estado de caja *************
        'gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        'If gidcaja = 0 Then
        '    MsgBox("Este ordenador no esta Registrado para operar como CAJA!", MsgBoxStyle.Exclamation, "Advertencia")
        '    Return
        'End If

        'Dim idevento As Integer
        ''idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        ''lblCaja.Text = "Caja Nº: " + idcaja.ToString
        'idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)

        'If idevento = 0 Then
        '    MsgBox("Caja Cerrada. Abra la caja antes de registrar una venta", MsgBoxStyle.Exclamation, "Advertencia")
        'Else
        '    RegistrarVenta.MdiParent = Me
        '    RegistrarVenta.Visible = True
        'End If
        '***************    FIN consultar el estado de caja *************
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
        MsgBox("Temporalmente no disponible")
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

    Private Sub ConfiguraciónesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónesToolStripMenuItem.Click
        ConfiguracionesFranquicia.MdiParent = Me
        ConfiguracionesFranquicia.Visible = True
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        ReporteVentasFranquicia.MdiParent = Me
        ReporteVentasFranquicia.Visible = True
    End Sub

    Private Sub SincronizarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SincronizarClientesToolStripMenuItem.Click
        If gModuloClowd = 1 Then
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
    'Private Sub PrivateDownloadSGC()

    '    Dim ftpClient As New WebClient
    '    Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar"
    '    Dim trnsfrpth As String = "C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar"
    '    'Dim UpdateAlertStatus As Boolean
    '    '***********************************************************
    '    'DESCARGA ACTUALIZACIÓN
    '    '***********************************************************
    '    'If UpdateAlertStatus = False Then Return
    '    Try
    '        '**********************************************
    '        Try 'ELIMINA POR COMPLETO LA CARPETA EJECUTABLE
    '            IO.Directory.Delete("C:\SGComercial\UpdatePack\Ejecutable\", True)
    '        Catch ex As Exception

    '        End Try
    '        '**********************************************
    '        ' SI NO EXISTE LA CREA
    '        If (Not System.IO.Directory.Exists("C:\SGComercial\UpdatePack\Ejecutable\")) Then
    '            System.IO.Directory.CreateDirectory("C:\SGComercial\UpdatePack\Ejecutable\")
    '        End If
    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        MsgBox("Borrando archivos " + ex.Message, MsgBoxStyle.Exclamation, "Ocurrió un evento inesperado")
    '        Return
    '    End Try
    '    '======================================
    '    gDownloadProgress = 0
    '    '=====================================
    '    'BackgroundWorker.RunWorkerAsync()
    '    '===========================
    '    AddHandler ftpClient.DownloadProgressChanged, AddressOf DownloadProgressChanged
    '    AddHandler ftpClient.DownloadFileCompleted, AddressOf DownloadComplete
    '    xi = New LoadingForm
    '    xi.Text = "Descargando última versión"
    '    xi.ProgressBar.Maximum = 100
    '    xi.ProgressBar.MarqueeAnimationSpeed = 100
    '    'xi.mensaje.TextAlign = ContentAlignment.MiddleLeft
    '    xi.mensaje.Text = "Descargando"
    '    xi.Show()
    '    'Try
    '    Try
    '        FileSystem.Kill("C:\SGComercial\UpdatePack\Ejecutable\*.rar")
    '    Catch ex As Exception

    '    End Try
    '    ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
    '    ftpClient.DownloadFileAsync(New Uri(path), trnsfrpth)
    'End Sub
    'Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
    '    'counter = counter + 1
    '    'Dim xi As LoadingForm
    '    Dim info As New IO.FileInfo("C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar")
    '    Dim length As Long
    '    length = (info.Length) / 1000
    '    gDownloadProgress = e.ProgressPercentage
    '    xi.ProgressBar.Value = gDownloadProgress
    '    xi.mensaje.Text = length.ToString + "kb " + "Descargando... "
    '    xi.Refresh()
    'End Sub
    'Private Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    '    'MsgBox("Descarga completa! " + gDownloadProgress.ToString)
    '    'Dim xi As LoadingForm
    '    xi.Dispose()
    '    'UpdateSGC(newversion)
    '    UpdateSGC()
    'End Sub
End Class
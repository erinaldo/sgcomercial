Imports MySql.Data.MySqlClient

Module MySQLModule
    '*************************  VARIABLES **********************************************************
    Public LastSyncLocalProductos As DateTime
    Public LastSyncRemoteProductos As DateTime
    'Dim da As MySqlDataAdapter
    Dim da As MySQLDataSetTableAdapters.clientesTableAdapter
    Dim ds As MySQLDataSet
    Dim dt As DataTable
    '************************************************************************************************
    '*************  errorlog    **************************************
    Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
    '************************************************************************        
    Public MySQLC As MySqlConnection
    Sub conectarMySQL(ByRef status As Boolean)
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter
        '************************************************************************ 
        Try
            If Not My.Computer.Network.IsAvailable Then
                'Cursor.Current = Cursors.Default
                'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
                status = False
                Return
            Else
                status = True
            End If
            'MySQLConn = New MySqlConnection("Data Source=sistemascomerciales.net; Database=sistema1_sgcaguadagrande; User ID=sistema1_sgcweb; Password=sgcomercial*?; Allow Zero Datetime= true; CHARSET= latin1")
            'MySQLC = New MySqlConnection(sgcomercial.My.MySettings.Default.MySQLConnectionString)
            'MySQLC.Open()
            'MsgBox("Conexión exitosa!", MsgBoxStyle.Information)
            '            status = True
            'MySQLC.Close()
            'MySQLC.Dispose()
        Catch ex As Exception
            'MsgBox("No se pudo conectar con la Nube: " + ex.Message, MsgBoxStyle.Information, "Información importante")
            MySQLC.Dispose()
            ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Conexión a la nube", "conectarMySQL", ex.Message)
            status = False
            Return
        End Try
    End Sub
    Sub conectarSisCom(ByRef status As Boolean)
        Try
            If Not My.Computer.Network.IsAvailable Then
                'Cursor.Current = Cursors.Default
                'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
                status = False
                Return
            Else
                status = True
            End If
            'MySQLConn = New MySqlConnection("Data Source=sistemascomerciales.net; Database=sistema1_sgcaguadagrande; User ID=sistema1_sgcweb; Password=sgcomercial*?; Allow Zero Datetime= true; CHARSET= latin1")
            'MySQLC = New MySqlConnection(sgcomercial.My.MySettings.Default.SCConnectionString)
            'MySQLC.Open()
            'MsgBox("Conexión exitosa!", MsgBoxStyle.Information)
            'status = True
            'MySQLC.Close()
            'MySQLC.Dispose()
        Catch ex As Exception
            'MsgBox("No se pudo conectar con el servidor remoto -SC-: " + ex.Message, MsgBoxStyle.Information)
            MySQLC.Dispose()
            ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Conexión a siscom", "conectarSisCom", ex.Message)
            status = False
            Return
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynClientes()
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            Return
        End If
        Try
            '***********************
            ds = New MySQLDataSet
            '*************  errorlog    **************************************
            Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
            ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
            '*************  --------    **************************************
            '****clientesweb********
            Dim clienteswebtableadapter As MySQLDataSetTableAdapters.clientesTableAdapter
            clienteswebtableadapter = New MySQLDataSetTableAdapters.clientesTableAdapter()
            Dim clienteswebtable As MySQLDataSet.clientesDataTable
            clienteswebtable = clienteswebtableadapter.GetDataBySync("N")
            '****   ----    ********
            '****clientesdomiciliosweb********
            Dim clientesdomicilioswebTableAdapter As MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter
            clientesdomicilioswebTableAdapter = New MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter()
            Dim clientesdomicilioswebtable As MySQLDataSet.clientesdomiciliosDataTable
            '****   ----    ********
            '****clientes local********
            Dim clientestableadapter As comercialDataSetTableAdapters.clientesTableAdapter
            clientestableadapter = New comercialDataSetTableAdapters.clientesTableAdapter()
            '****   ----    ********
            '****clientesdomicilios local********
            Dim clientesdomiciliostableadapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
            clientesdomiciliostableadapter = New comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
            '****   ----    ********

            '*****  RECORRER CLIENTES PENDIENTES DE SYNC    *****
            If clienteswebtable.Rows.Count > 0 Then
                Dim i As Long = 0
                For i = 0 To clienteswebtable.Rows.Count - 1
                    Dim idclienteweb As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.idclientewebColumn), Nothing)
                    Dim nombre As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.nombreColumn), Nothing)
                    Dim cuit As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.cuitColumn), Nothing)
                    Dim telefono As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.telefonoColumn), Nothing)
                    Dim email As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.emailColumn), Nothing)
                    Dim idclientelocal As Long = 0
                    Dim condicioniva As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.condicionivaColumn), Nothing)
                    Dim idtipodocumento As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.idtipodocumentoColumn), Nothing)
                    Try
                        idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                        '****     ins/upd  CLIENTE     **********
                        If idclientelocal = 0 Then ' el cliente no esta registrado localmente
                            idclientelocal = clientestableadapter.clientes_insertar(idclienteweb, nombre, telefono, email, cuit, idtipodocumento, condicioniva)
                        Else ' ESTA REGISTRADO LOCALMENTE - ACTUALIZO LA INFORMACION
                            clientestableadapter.clientes_updateclientefromweb(nombre, cuit, telefono, email, idclienteweb)
                        End If
                        '***    OBTENGO DOMICILIOS WEB  **********
                        clientesdomicilioswebtable = clientesdomicilioswebTableAdapter.GetDataBySync(idclienteweb, "N")
                        'MsgBox(clientesdomicilioswebtable.Rows.Count.ToString)
                        Try
                            Dim j As Long = 0
                            For j = 0 To clientesdomicilioswebtable.Rows.Count - 1
                                Dim idclientesdomiciliosweb As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idclientesdomicilioswebColumn)
                                Dim direccion As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.direccionColumn), Nothing)
                                Dim referencias As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.referenciasColumn), Nothing)
                                If IsDBNull(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idprovinciaColumn)) Or IsDBNull(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idlocalidadColumn)) Then
                                    Throw New Exception("No se puede sincronizar datos inconsistentes: clienteweb -> " + idclienteweb.ToString)
                                End If
                                Dim idprovincia As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idprovinciaColumn)
                                Dim idlocalidad As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idlocalidadColumn)
                                Dim cp As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.cpColumn), Nothing)
                                Dim rtn2 As Long = 0
                                rtn2 = clientesdomiciliostableadapter.clientesdomicilios_existedomicilioweb(idclientesdomiciliosweb)
                                If rtn2 = 0 Then ' el domicilio no esta registrado localmente
                                    clientesdomiciliostableadapter.clientesdomicilios_insertar(idclientelocal, direccion, referencias, idprovincia, idlocalidad, cp, idclientesdomiciliosweb)
                                Else
                                    clientesdomiciliostableadapter.clientesdomicilios_updatedomiciliosfromweb(direccion, referencias, idprovincia, idlocalidad, cp, idclientesdomiciliosweb)
                                End If
                                clientesdomicilioswebTableAdapter.clientesdomicilios_updatesync("S", idclientesdomiciliosweb) ' ACTUALIZO VALOR SYNC WEB
                            Next
                            If clientesdomicilioswebtable.Rows.Count > 0 Then
                                clienteswebtableadapter.clientes_updatesync("S", idclienteweb) ' ACTUALIZO VALOR SYNC WEB
                            End If
                        Catch ex As Exception
                            ErrorLogTableAdapter.errorlog_insertar("SynClientes", "DATOS", "SynClientes", "No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                            MsgBox("No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                        End Try
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("SynClientes", "DATOS", "SynClientes", "No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                        MsgBox("No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                    End Try
                    '*********************************
                Next
            End If
        Catch ex As Exception
            MsgBox("Advertencia! " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        '/*******************************************/
        '           subir clientes a la nube
        '/*******************************************/
        PushClientes()
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub PullClienteWeb(ByRef idclienteweb As Long)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            Return
        End If
        Try
            '***********************
            ds = New MySQLDataSet
            '*************  errorlog    **************************************
            Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
            ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
            '*************  --------    **************************************
            '****clientesweb********
            Dim clienteswebtableadapter As MySQLDataSetTableAdapters.clientesTableAdapter
            clienteswebtableadapter = New MySQLDataSetTableAdapters.clientesTableAdapter()
            Dim clienteswebtable As MySQLDataSet.clientesDataTable
            clienteswebtable = clienteswebtableadapter.GetDataByidclienteweb(idclienteweb)
            '****   ----    ********
            '****clientesdomiciliosweb********
            Dim clientesdomicilioswebTableAdapter As MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter
            clientesdomicilioswebTableAdapter = New MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter()
            Dim clientesdomicilioswebtable As MySQLDataSet.clientesdomiciliosDataTable
            '****   ----    ********
            '****clientes local********
            Dim clientestableadapter As comercialDataSetTableAdapters.clientesTableAdapter
            clientestableadapter = New comercialDataSetTableAdapters.clientesTableAdapter()
            '****   ----    ********
            '****clientesdomicilios local********
            Dim clientesdomiciliostableadapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
            clientesdomiciliostableadapter = New comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
            '****   ----    ********

            '*****  RECORRER CLIENTES PENDIENTES DE SYNC    *****
            If clienteswebtable.Rows.Count > 0 Then
                Dim i As Long = 0
                For i = 0 To clienteswebtable.Rows.Count - 1
                    'Dim idclienteweb As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.idclientewebColumn), Nothing)
                    Dim nombre As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.nombreColumn), Nothing)
                    Dim cuit As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.cuitColumn), Nothing)
                    Dim telefono As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.telefonoColumn), Nothing)
                    Dim email As String = Convert.ToString(clienteswebtable.Rows(i).Item(clienteswebtable.emailColumn), Nothing)
                    Dim idclientelocal As Long = 0
                    Dim condicioniva As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.condicionivaColumn), Nothing)
                    Dim idtipodocumento As Long = Convert.ToInt64(clienteswebtable.Rows(i).Item(clienteswebtable.idtipodocumentoColumn), Nothing)
                    Try
                        'idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                        ''****     ins/upd  CLIENTE     **********
                        'If idclientelocal = 0 Then ' el cliente no esta registrado localmente
                        idclientelocal = clientestableadapter.clientes_insertar(idclienteweb, nombre, telefono, email, cuit, idtipodocumento, condicioniva)
                        'Else ' ESTA REGISTRADO LOCALMENTE - ACTUALIZO LA INFORMACION
                        '    clientestableadapter.clientes_updateclientefromweb(nombre, cuit, telefono, email, idclienteweb)
                        'End If
                        '***    OBTENGO DOMICILIOS WEB  **********
                        clientesdomicilioswebtable = clientesdomicilioswebTableAdapter.GetDataByidclientesdomiciliosweb(idclienteweb)
                        'MsgBox(clientesdomicilioswebtable.Rows.Count.ToString)
                        Try
                            Dim j As Long = 0
                            For j = 0 To clientesdomicilioswebtable.Rows.Count - 1
                                Dim idclientesdomiciliosweb As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idclientesdomicilioswebColumn)
                                Dim direccion As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.direccionColumn), Nothing)
                                Dim referencias As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.referenciasColumn), Nothing)
                                If IsDBNull(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idprovinciaColumn)) Or IsDBNull(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idlocalidadColumn)) Then
                                    Throw New Exception("No se puede sincronizar datos inconsistentes: clienteweb -> " + idclienteweb.ToString)
                                End If
                                Dim idprovincia As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idprovinciaColumn)
                                Dim idlocalidad As Long = clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.idlocalidadColumn)
                                Dim cp As String = Convert.ToString(clientesdomicilioswebtable.Rows(j).Item(clientesdomicilioswebtable.cpColumn), Nothing)
                                Dim rtn2 As Long = 0
                                rtn2 = clientesdomiciliostableadapter.clientesdomicilios_existedomicilioweb(idclientesdomiciliosweb)
                                If rtn2 = 0 Then ' el domicilio no esta registrado localmente
                                    clientesdomiciliostableadapter.clientesdomicilios_insertar(idclientelocal, direccion, referencias, idprovincia, idlocalidad, cp, idclientesdomiciliosweb)
                                Else
                                    clientesdomiciliostableadapter.clientesdomicilios_updatedomiciliosfromweb(direccion, referencias, idprovincia, idlocalidad, cp, idclientesdomiciliosweb)
                                End If
                                clientesdomicilioswebTableAdapter.clientesdomicilios_updatesync("S", idclientesdomiciliosweb) ' ACTUALIZO VALOR SYNC WEB
                            Next
                            If clientesdomicilioswebtable.Rows.Count > 0 Then
                                clienteswebtableadapter.clientes_updatesync("S", idclienteweb) ' ACTUALIZO VALOR SYNC WEB
                            End If
                        Catch ex As Exception
                            ErrorLogTableAdapter.errorlog_insertar("SynClientes", "DATOS", "SynClientes", "No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                            MsgBox("No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                        End Try
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("SynClientes", "DATOS", "SynClientes", "No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                        MsgBox("No se pudo completar la Sincronización de CLIENTES: " + ex.Message)
                    End Try
                    '*********************************
                Next
            End If
        Catch ex As Exception
            MsgBox("Advertencia! " + ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynPedidos(ByRef tipo As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If tipo <> "APP" And tipo <> "WEB" Then
            MsgEx("Opción no disponible")
            Return
        End If
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            Return
        End If
        '***************************************
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        '*************  --------    **************************************
        Try ' COMIENZA LA SYNC
            '***********************
            ds = New MySQLDataSet
            '****   ProductosTableAdapter  ******** LOCAL
            Dim ProductosTableAdapter As New comercialDataSetTableAdapters.productosTableAdapter()
            '****   PedidosDeliveryWEBTableAdapter  ******** WEB
            Dim PedidosDeliveryWEBTableAdapter As MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter
            PedidosDeliveryWEBTableAdapter = New MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter()
            Dim PedidosDeliveryWEBTable As MySQLDataSet.pedidosdeliveryDataTable
            PedidosDeliveryWEBTable = PedidosDeliveryWEBTableAdapter.GetDataBySync("N", tipo)
            '****   ----    ********
            '****   PedidosDeliveryTableAdapter  ******** LOCAL
            Dim PedidosDeliveryTableAdapter As comercialDataSetTableAdapters.pedidosdeliveryTableAdapter
            PedidosDeliveryTableAdapter = New comercialDataSetTableAdapters.pedidosdeliveryTableAdapter()
            '****   -----   *********
            '****   VentasTableAdapter  ******** LOCAL
            Dim VentasTableAdapter As comercialDataSetTableAdapters.ventasTableAdapter
            VentasTableAdapter = New comercialDataSetTableAdapters.ventasTableAdapter()
            '****   -----   *********
            '****   VentasDetalleTableAdapter  ******** LOCAL
            Dim VentasDetalleTableAdapter As comercialDataSetTableAdapters.ventasdetalleTableAdapter
            VentasDetalleTableAdapter = New comercialDataSetTableAdapters.ventasdetalleTableAdapter()
            '****   -----   *********
            '****   PedidosDeliveryDetalleWEBTableAdapter  ******** WEB
            Dim PedidosDeliveryDetalleWEBTableAdapter As MySQLDataSetTableAdapters.pedidosdeliverydetallecodTableAdapter
            PedidosDeliveryDetalleWEBTableAdapter = New MySQLDataSetTableAdapters.pedidosdeliverydetallecodTableAdapter()
            Dim PedidosDeliveryDetalleWEBTable As MySQLDataSet.pedidosdeliverydetallecodDataTable
            '****   ----    ********
            '****   PedidosDeliveryWEBTableAdapter  ******** LOCAL
            Dim PedidosDeliveryDetalleTableAdapter As comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter
            PedidosDeliveryDetalleTableAdapter = New comercialDataSetTableAdapters.pedidosdeliverydetalleTableAdapter()
            '****   -----   *********
            '****clientes local********
            Dim clientestableadapter As comercialDataSetTableAdapters.clientesTableAdapter
            clientestableadapter = New comercialDataSetTableAdapters.clientesTableAdapter()
            '****   ----    ********
            ''****clientesdomicilios local********
            Dim clientesdomiciliostableadapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
            clientesdomiciliostableadapter = New comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
            ''****   ----    ********
            If PedidosDeliveryWEBTable.Rows.Count > 0 Then
                '****** recorrer pedidos pendientes de syncro   ****
                For i = 0 To PedidosDeliveryWEBTable.Rows.Count - 1
                    Dim idpedidosdeliveryweb As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idpedidodeliverywebColumn)
                    Try ' VALIDAR QUE TODOS LOS DATOS SE HAYAN CARGADO
                        For d = 0 To PedidosDeliveryWEBTable.Columns.Count - 1
                            If d = 2 Or d = 5 Or d = 8 Then
                                Continue For
                            End If
                            If IsDBNull(PedidosDeliveryWEBTable.Rows(i).Item(d)) Then
                                ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "El pedido WEB: " + idpedidosdeliveryweb.ToString + " contiene datos nulos en -> " + PedidosDeliveryWEBTable.Columns(d).ColumnName)
                                MsgBox("El pedido WEB: " + idpedidosdeliveryweb.ToString + " contiene datos nulos")
                                Throw New Exception
                            End If
                        Next
                    Catch ex As Exception
                        Continue For
                    End Try '*********************** FIN VALIDACION DE CARGA
                    Dim idclienteweb As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idclientewebColumn)
                    If IsDBNull(PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idventawebColumn)) = False Then
                        Dim idventaweb As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idventawebColumn)
                    Else
                        Dim idventaweb As Long = Nothing
                    End If
                    '*****************************
                    Dim pagoesperado As Decimal '' = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)
                    If IsDBNull(PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)) = False Then
                        pagoesperado = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idventawebColumn)
                    Else
                        pagoesperado = Nothing
                    End If
                    '**************************************

                    Dim idtransporte As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idtransporteColumn)
                    Dim iddomicilioweb As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.iddomicilioColumn)

                    Dim fechaalta As DateTime = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.fechaaltaColumn)
                    '*****************************
                    Dim obs As String '' = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)
                    If IsDBNull(PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.obsColumn)) = False Then
                        obs = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.obsColumn)
                    Else
                        obs = Nothing
                    End If
                    '/**************** FIN CARGA DE VARIABLES ****************/
                    Dim idpedidodeliverylocal As Long = 0
                    Dim idclientelocal As Long = 0
                    Dim idclientedomiciliolocal As Long = 0
                    '********   verifico si existe localmente
                    idpedidodeliverylocal = Convert.ToInt64(PedidosDeliveryTableAdapter.pedidosdelivery_existepedidoweb(idpedidosdeliveryweb), Nothing)
                    If idpedidodeliverylocal = 0 Then ' VERIFICO QUE EXISTA EL CLIENTE LOCAL Y EL DOMICILIO LOCAL
                        idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                        idclientedomiciliolocal = clientesdomiciliostableadapter.clientesdomicilios_existedomicilioweb(iddomicilioweb)
                        If idclientelocal = 0 Or idclientedomiciliolocal = 0 Then
                            PullClienteWeb(idclienteweb)
                            idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                            idclientedomiciliolocal = clientesdomiciliostableadapter.clientesdomicilios_existedomicilioweb(iddomicilioweb)
                            If idclientelocal = 0 Or idclientedomiciliolocal = 0 Then
                                ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo sincronizar el pedido WEB: " + idpedidosdeliveryweb.ToString + " (información de cliente inválida)")
                                MsgBox("No se pudo sincronizar el pedido WEB: " + idpedidosdeliveryweb.ToString + " (información de cliente inválida)", MsgBoxStyle.Exclamation)
                                Continue For
                            End If
                        End If
                    Else    ' SI YA EXISTE LO SALTO
                        Continue For
                    End If
                    'obtengo el detalle del pedido web
                    PedidosDeliveryDetalleWEBTable = PedidosDeliveryDetalleWEBTableAdapter.GetDataByIdpedidodeliveryweb(idpedidosdeliveryweb)
                    '****************   INSERTAR PEDIDO WEB A LOCAL **************
                    Dim NvoPedido
                    NvoPedido = PedidosDeliveryTableAdapter.pedidosdelivery_insertfromweb(idclientelocal, Nothing, idtransporte, idclientedomiciliolocal, pagoesperado, fechaalta, "usuarioweb", "RECIBIDO", idpedidosdeliveryweb, tipo, obs)
                    '****************   REGISTRO EL DETALLE DEL PEDIDO  **************
                    For j = 0 To PedidosDeliveryDetalleWEBTable.Rows.Count - 1
                        Dim idpedidodeliverydetalleweb As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        'Dim idventa As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        Dim codigoproducto = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.codigoproductoColumn)
                        Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(codigoproducto)
                        Dim cantidad As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.cantidadColumn)
                        Dim precioventa As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.precioventaColumn)
                        '*****************************
                        Dim recargo As Decimal '***************'' = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)
                        If IsDBNull(PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)) = False Then
                            recargo = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)
                        Else
                            recargo = Nothing
                        End If
                        '************************
                        Dim idlistaprecio As Long
                        If IsDBNull(PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)) = False Then
                            idlistaprecio = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)
                        Else
                            idlistaprecio = 1
                        End If
                        '************************
                        Try
                            PedidosDeliveryDetalleTableAdapter.pedidosdeliverydetalle_insertar(NvoPedido, idproducto, cantidad, precioventa, recargo, idlistaprecio)
                            PedidosDeliveryWEBTableAdapter.pedidosdelivery_updatesync("S", idpedidosdeliveryweb)
                        Catch ex As Exception
                            ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
                            MsgBox("No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
                        End Try
                    Next
                    '***************** REGISTRO LA VENTA    ******************************* 
                    Dim nvavta As Int64
                    nvavta = VentasTableAdapter.ventas_insertarventa(idclientelocal, Now(), Nothing, 1, "usuarioweb", Nothing, Nothing, 1)
                    '****************   REGISTRO EL DETALLE DE LA VENTA **************
                    For j = 0 To PedidosDeliveryDetalleWEBTable.Rows.Count - 1
                        Dim idpedidodeliverydetalleweb As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        Dim idproducto As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idproductoColumn)
                        Dim cantidad As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.cantidadColumn)
                        Dim precioventa As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.precioventaColumn)
                        Dim recargo As Decimal '***************'' = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)
                        If IsDBNull(PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)) = False Then
                            recargo = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)
                        Else
                            recargo = Nothing
                        End If
                        '************************
                        Dim idlistaprecio As Long
                        If IsDBNull(PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)) = False Then
                            idlistaprecio = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)
                        Else
                            idlistaprecio = 1
                        End If
                        '****************************
                        VentasDetalleTableAdapter.ventasdetalle_insertardetalle(nvavta, idproducto, cantidad, precioventa, idlistaprecio, Nothing, Nothing)
                        PedidosDeliveryTableAdapter.pedidosdelivery_updateidventa(nvavta, NvoPedido)
                    Next
                Next
            End If
            MsgSuccessPopUp("Se han sincronizado [" + PedidosDeliveryWEBTable.Rows.Count.ToString + "] pedidos")
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
            MsgBox("Advertencia! " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub UpdEstadoPedidoWeb(estado As String, idpedidoweb As Long)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            Return
        End If
        '***************************************
        '*************  errorlog    **************************************
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        '*************  --------    **************************************
        Dim pedidosdeliverywebTableAdapter As MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter
        pedidosdeliverywebTableAdapter = New MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter()

        Try ' COMIENZA LA SYNC
            '***********************
            ds = New MySQLDataSet
            pedidosdeliverywebTableAdapter.pedidosdelivery_updateestadoweb("ENPROCESO", idpedidoweb)
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("UpdEstadoPedidoWeb", "APLICACION", "UpdEstadoPedidoWeb", ex.Message)
            MsgBox("No se pudo actualizar el estado WEB del pedido: " + ex.Message)
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub PushProducto(ByVal codigoproducto As String, ByRef coderror As String, ByRef msgerror As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            coderror = 1
            msgerror = "No se pudo conectar al servidor remoto"
            Return
        End If
        Try
            Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
            ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
            Dim SyncLogWEBTableAdapter As MySQLDataSetTableAdapters.synclogTableAdapter
            SyncLogWEBTableAdapter = New MySQLDataSetTableAdapters.synclogTableAdapter()
            Dim ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
            ProductosTableAdapter = New comercialDataSetTableAdapters.productosTableAdapter()
            '-----------------------------------------------------------------------------------
            Dim ProductosTable As comercialDataSet.productosDataTable
            Dim idproductoweb As Long
            Dim idproductolocal As Long
            '-----------------------------------------------------------------------------------
            idproductoweb = ProductosWEBTableAdapter.productos_existeproducto(codigoproducto)
            idproductolocal = ProductosTableAdapter.productos_existeproducto(codigoproducto)
            ProductosTable = ProductosTableAdapter.GetDataByidproducto(idproductolocal)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For i = 0 To ProductosTable.Rows.Count - 1
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'Dim codigoproducto As String
                'codigoproducto = ProductosTable.Rows(0).Item(ProductosTable.Columns("codigoproducto"))
                Dim marca As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("marca"))) Then
                    marca = Nothing
                Else
                    marca = ProductosTable.Rows(i).Item(ProductosTable.Columns("marca"))
                End If
                '-----------------------------------------------------------------------------------
                Dim modelo As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("modelo"))) Then
                    modelo = Nothing
                Else
                    modelo = ProductosTable.Rows(i).Item(ProductosTable.Columns("modelo"))
                End If
                '-----------------------------------------------------------------------------------
                Dim presentacion As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("presentacion"))) Then
                    presentacion = Nothing
                Else
                    presentacion = ProductosTable.Rows(i).Item(ProductosTable.Columns("presentacion"))
                End If
                '-----------------------------------------------------------------------------------
                Dim unidadmedida As Int16
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("unidadmedida"))) Then
                    unidadmedida = Nothing
                Else
                    unidadmedida = ProductosTable.Rows(i).Item(ProductosTable.Columns("unidadmedida"))
                End If
                '-----------------------------------------------------------------------------------
                Dim medida As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("medida"))) Then
                    medida = Nothing
                Else
                    medida = ProductosTable.Rows(i).Item(ProductosTable.Columns("medida"))
                End If
                '-----------------------------------------------------------------------------------
                Dim descripcion As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("descripcion"))) Then
                    descripcion = Nothing
                Else
                    descripcion = ProductosTable.Rows(i).Item(ProductosTable.Columns("descripcion"))
                End If
                '-----------------------------------------------------------------------------------
                Dim preciocosto As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("preciocosto"))) Then
                    preciocosto = Nothing
                Else
                    preciocosto = ProductosTable.Rows(i).Item(ProductosTable.Columns("preciocosto"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventa As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventa"))) Then
                    precioventa = Nothing
                Else
                    precioventa = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventa"))
                End If
                '-----------------------------------------------------------------------------------
                Dim stockminimo As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("stockminimo"))) Then
                    stockminimo = Nothing
                Else
                    stockminimo = ProductosTable.Rows(i).Item(ProductosTable.Columns("stockminimo"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventamayorista As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventamayorista"))) Then
                    precioventamayorista = Nothing
                Else
                    precioventamayorista = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventamayorista"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventagranel As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventagranel"))) Then
                    precioventagranel = Nothing
                Else
                    precioventagranel = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventagranel"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventadistribuidor As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventadistribuidor"))) Then
                    precioventadistribuidor = Nothing
                Else
                    precioventadistribuidor = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventadistribuidor"))
                End If
                '-----------------------------------------------------------------------------------
                Dim idrubro As Integer
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("idrubro"))) Then
                    idrubro = 1
                Else
                    idrubro = ProductosTable.Rows(i).Item(ProductosTable.Columns("idrubro"))
                End If
                '-----------------------------------------------------------------------------------
                Dim iva As Decimal
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("iva"))) Then
                    iva = Nothing
                Else
                    iva = ProductosTable.Rows(i).Item(ProductosTable.Columns("iva"))
                End If
                '-----------------------------------------------------------------------------------
                Dim fabricante As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("fabricante"))) Then
                    fabricante = Nothing
                Else
                    fabricante = ProductosTable.Rows(i).Item(ProductosTable.Columns("fabricante"))
                End If
                '-----------------------------------------------------------------------------------
                Dim productocompuesto As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("productocompuesto"))) Then
                    productocompuesto = "N"
                Else
                    productocompuesto = ProductosTable.Rows(i).Item(ProductosTable.Columns("productocompuesto"))
                End If
                '-----------------------------------------------------------------------------------
                Dim estado As String
                If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("estado"))) Then
                    estado = "I"
                Else
                    estado = ProductosTable.Rows(i).Item(ProductosTable.Columns("estado"))
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' SI EXISTE UPDATE
                If idproductoweb > 0 Then
                    ProductosWEBTableAdapter.productosweb_update(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante, codigoproducto)
                Else ' NO EXISTE INSERT
                    ProductosWEBTableAdapter.productosweb_insertar(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante)
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                SyncLogWEBTableAdapter.synclog_update(1, Now, gmacadress, gusername, "productos")
                Cursor.Current = Cursors.Default
                coderror = 0
                msgerror = ""
            Next
            '-----------------------------------------------------------------------------------
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub PullProducto(ByVal codigoproducto As Long, ByRef coderror As String, ByRef msgerror As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            coderror = 1
            msgerror = "No se pudo conectar al servidor remoto"
            Return
        End If
        Try
            Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
            ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
            Dim ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
            ProductosTableAdapter = New comercialDataSetTableAdapters.productosTableAdapter()
            '-----------------------------------------------------------------------------------
            'Dim ProductosTable As comercialDataSet.productosDataTable
            Dim ProductosWEBTable As MySQLDataSet.productosDataTable
            Dim idproductoweb As Long
            Dim idproductolocal As Long
            '-----------------------------------------------------------------------------------
            idproductoweb = ProductosWEBTableAdapter.productos_existeproducto(codigoproducto)
            idproductolocal = ProductosTableAdapter.productos_existeproducto(codigoproducto)
            'ProductosTable = ProductosTableAdapter.GetDataByidproducto(idproductolocal)
            ProductosWEBTable = ProductosWEBTableAdapter.GetDataByIdproducto(idproductoweb)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Dim codigoproducto As String
            'codigoproducto = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("codigoproducto"))
            Dim marca As String
            marca = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("marca"))
            '-----------------------------------------------------------------------------------
            Dim modelo As String
            modelo = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("modelo"))
            '-----------------------------------------------------------------------------------
            Dim presentacion As String
            presentacion = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("presentacion"))
            '-----------------------------------------------------------------------------------
            Dim unidadmedida As Int16
            unidadmedida = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("unidadmedida"))
            '-----------------------------------------------------------------------------------
            Dim medida As Decimal
            medida = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("medida"))
            '-----------------------------------------------------------------------------------
            Dim descripcion As String
            If IsDBNull(ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("descripcion"))) Then
                descripcion = Nothing
            Else
                descripcion = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("descripcion"))
            End If
            '-----------------------------------------------------------------------------------
            Dim preciocosto As Decimal
            preciocosto = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("preciocosto"))
            '-----------------------------------------------------------------------------------
            Dim precioventa As Decimal
            precioventa = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("precioventa"))
            '-----------------------------------------------------------------------------------
            Dim stockminimo As Decimal
            stockminimo = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("stockminimo"))
            '-----------------------------------------------------------------------------------
            Dim precioventamayorista As Decimal
            precioventamayorista = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("precioventamayorista"))
            '-----------------------------------------------------------------------------------
            Dim precioventagranel As Decimal
            precioventagranel = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("precioventagranel"))
            '-----------------------------------------------------------------------------------
            Dim precioventadistribuidor As Decimal
            precioventadistribuidor = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("precioventadistribuidor"))
            '-----------------------------------------------------------------------------------
            Dim idrubro As Integer
            idrubro = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("idrubro"))
            '-----------------------------------------------------------------------------------
            Dim iva As Decimal
            If IsDBNull(ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("iva"))) Then
                iva = Nothing
            Else
                iva = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("iva"))
            End If
            '-----------------------------------------------------------------------------------
            Dim fabricante As String
            If IsDBNull(ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("fabricante"))) Then
                fabricante = Nothing
            Else
                fabricante = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("fabricante"))
            End If
            '-----------------------------------------------------------------------------------
            Dim productocompuesto As String
            If IsDBNull(ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("productocompuesto"))) Then
                productocompuesto = "N"
            Else
                productocompuesto = ProductosWEBTable.Rows(0).Item(ProductosWEBTable.Columns("productocompuesto"))
            End If
            '-----------------------------------------------------------------------------------
            ' SI EXISTE UPDATE
            If idproductolocal > 0 Then
                ProductosTableAdapter.productos_pullupdate(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante, codigoproducto, idproductolocal)
            Else ' NO EXISTE INSERT
                ProductosTableAdapter.productos_pullinsert(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante)
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Cursor.Current = Cursors.Default
            coderror = 0
            msgerror = ""
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub DescargarProductosClowd(ByRef coderror As String, ByRef msgerror As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            coderror = 1
            msgerror = "No se pudo conectar al servidor remoto"
            Return
        End If
        Try
            '-----------------------------------------------------
            Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
            ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
            Dim SyncLogTableAdapter As comercialDataSetTableAdapters.synclogTableAdapter
            SyncLogTableAdapter = New comercialDataSetTableAdapters.synclogTableAdapter()
            Dim ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
            ProductosTableAdapter = New comercialDataSetTableAdapters.productosTableAdapter()
            '-----------------------------------------------------
            Dim ProductosWEBTable As MySQLDataSet.productosDataTable
            'ProductosWEBTable = ProductosWEBTableAdapter.GetDataByActivos
            ProductosWEBTable = ProductosWEBTableAdapter.GetData
            '-------------------------------    barra de progreso----------------------------------------------------
            Dim p As SubirProductosClowd
            p = New SubirProductosClowd
            p.Show()
            p.ProgressBar1.Maximum = ProductosWEBTable.Rows.Count
            p.GroupBox1.Text = "Descargando Productos de la Nube"
            p.LabelProgress.Text = "Progreso: " + "0/" + p.ProgressBar1.Maximum.ToString
            '-----------------------------------------------------------------------------------
            Cursor.Current = Cursors.WaitCursor
            '-----------------------------------------------------------------------------------
            For i = 0 To ProductosWEBTable.Rows.Count - 1
                Dim idproductolocal As Long
                '-----------------------------------------------------------------------------------
                idproductolocal = ProductosTableAdapter.productos_existeproducto(ProductosWEBTable.Rows(i).Item(1))
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '------------------------------------------------
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim codigoproducto As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("codigoproducto"))) Then
                    codigoproducto = Nothing
                Else
                    codigoproducto = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("codigoproducto"))
                End If
                Dim marca As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("marca"))) Then
                    marca = Nothing
                Else
                    marca = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("marca"))
                End If
                '-----------------------------------------------------------------------------------
                Dim modelo As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("modelo"))) Then
                    modelo = Nothing
                Else
                    modelo = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("modelo"))
                End If
                '-----------------------------------------------------------------------------------
                Dim presentacion As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("presentacion"))) Then
                    presentacion = Nothing
                Else
                    presentacion = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("presentacion"))
                End If
                '-----------------------------------------------------------------------------------
                Dim unidadmedida As Int16
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("unidadmedida"))) Then
                    unidadmedida = Nothing
                Else
                    unidadmedida = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("unidadmedida"))
                End If
                '-----------------------------------------------------------------------------------
                Dim medida As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("medida"))) Then
                    medida = Nothing
                Else
                    If ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("medida")) = 0 Then
                        medida = 1
                    Else
                        medida = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("medida"))
                    End If
                End If
                '-----------------------------------------------------------------------------------
                Dim descripcion As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("descripcion"))) Then
                    descripcion = Nothing
                Else
                    descripcion = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("descripcion"))
                End If
                '-----------------------------------------------------------------------------------
                Dim preciocosto As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("preciocosto"))) Then
                    preciocosto = Nothing
                Else
                    preciocosto = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("preciocosto"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventa As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventa"))) Then
                    precioventa = Nothing
                Else
                    precioventa = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventa"))
                End If
                '-----------------------------------------------------------------------------------
                Dim stockminimo As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("stockminimo"))) Then
                    stockminimo = Nothing
                Else
                    stockminimo = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("stockminimo"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventamayorista As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventamayorista"))) Then
                    precioventamayorista = Nothing
                Else
                    precioventamayorista = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventamayorista"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventagranel As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventagranel"))) Then
                    precioventagranel = Nothing
                Else
                    precioventagranel = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventagranel"))
                End If
                '-----------------------------------------------------------------------------------
                Dim precioventadistribuidor As Decimal
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventadistribuidor"))) Then
                    precioventadistribuidor = Nothing
                Else
                    precioventadistribuidor = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("precioventadistribuidor"))
                End If
                '-----------------------------------------------------------------------------------
                Dim idrubro As Integer
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("idrubro"))) Then
                    idrubro = 1
                Else
                    Dim rubrosTableAdapter As comercialDataSetTableAdapters.rubrosTableAdapter
                    rubrosTableAdapter = New comercialDataSetTableAdapters.rubrosTableAdapter()
                    idrubro = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("idrubro"))
                    idrubro = rubrosTableAdapter.rubros_existerubro(idrubro)
                    If idrubro > 0 Then
                        idrubro = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("idrubro"))
                    Else
                        idrubro = 1
                    End If
                End If
                '-----------------------------------------------------------------------------------
                Dim iva As Double
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("iva"))) Then
                    iva = Nothing
                Else
                    iva = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("iva"))
                End If
                '-----------------------------------------------------------------------------------
                Dim fabricante As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("fabricante"))) Then
                    fabricante = Nothing
                Else
                    fabricante = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("fabricante"))
                End If
                '-----------------------------------------------------------------------------------
                Dim productocompuesto As String
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("productocompuesto"))) Then
                    productocompuesto = "N"
                Else
                    'productocompuesto = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("productocompuesto"))
                    productocompuesto = "N"
                End If
                '-----------------------------------------------------------------------------------
                Dim estado As String = Nothing
                If IsDBNull(ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("estado"))) Then
                    estado = "I"
                Else
                    estado = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("estado"))
                    Select Case estado
                        Case "A"
                            'estado = "A"
                        Case Else
                            estado = "I"
                    End Select
                End If
                '-----------------------------------------------------------------------------------
                ' SI EXISTE UPDATE
                If idproductolocal > 0 Then
                    Dim ProductosComponentesTableAdapter As New comercialDataSetTableAdapters.productoscomponentesTableAdapter()
                    productocompuesto = ProductosComponentesTableAdapter.productoscomponentes_existecomponente(idproductolocal)
                    ProductosTableAdapter.productos_pullupdate(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante, codigoproducto, idproductolocal)
                Else ' NO EXISTE INSERT
                    ProductosTableAdapter.productos_pullinsert(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante)
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'SyncLogTableAdapter.synclog_update(1, Now, gmacadress, gusername, "productos")
                Cursor.Current = Cursors.Default
                coderror = 0
                msgerror = ""
                '-----------------------------------------------
                'gProgressBarCounter = i
                p.ProgressBar1.Value = i
                p.LabelProgress.Text = "Progreso: " + i.ToString + "/" + p.ProgressBar1.Maximum.ToString
                p.Refresh()
                'Threading.Thread.Sleep(1)
            Next
            p.ProgressBar1.Value = p.ProgressBar1.Maximum
            '-----------------------------------------------------------------------------------
            Cursor.Current = Cursors.Default
            coderror = 0
            msgerror = ""
            SyncLogTableAdapter.synclog_update(1, Now(), gmacadress, gusername, "productos")
            p.Close()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
        End Try

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SubirProductosClowd(ByRef coderror As String, ByRef msgerror As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            coderror = 1
            msgerror = "No se pudo conectar al servidor remoto"
            Return
        End If
        Try
            My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
            'MsgEx(MySQLStrConn)
            gProgressBarCounter = 0
            Dim ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
            ProductosTableAdapter = New comercialDataSetTableAdapters.productosTableAdapter()
            '-----------------------------------------------------
            Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
            ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
            Dim SyncLogWEBTableAdapter As MySQLDataSetTableAdapters.synclogTableAdapter
            SyncLogWEBTableAdapter = New MySQLDataSetTableAdapters.synclogTableAdapter()
            '-----------------------------------------------------------------------------------
            '-----------------------------------------------------------------------------------
            Dim ProductosTable As comercialDataSet.productosDataTable
            '-----------------------------------------------------------------------------------
            ProductosTable = ProductosTableAdapter.GetData()
            '-------------------------------    barra de progreso----------------------------------------------------
            Dim p As SubirProductosClowd
            p = New SubirProductosClowd
            p.Show()
            p.ProgressBar1.Maximum = ProductosTable.Rows.Count
            p.LabelProgress.Text = "Progreso: " + "0/" + p.ProgressBar1.Maximum.ToString
            Try

                ''''''''''''''''    RECORRO TODA LA LISTA DE PRODUCTOS Y LA VOY SUBIENDO A LA NUBE'''''''''''''''''''''''''''''''''''''''''''
                For i = 0 To ProductosTable.Rows.Count - 1
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim idproductoweb As Long
                    'Dim idproductolocal As Long
                    '-----------------------------------------------------------------------------------
                    idproductoweb = ProductosWEBTableAdapter.productos_existeproducto(ProductosTable.Rows(i).Item(1))
                    'ProductosTable = ProductosTableAdapter.GetData()
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim codigoproducto As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("codigoproducto"))) Then
                        codigoproducto = Nothing
                    Else
                        codigoproducto = ProductosTable.Rows(i).Item(ProductosTable.Columns("codigoproducto"))
                    End If
                    Dim marca As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("marca"))) Then
                        marca = Nothing
                    Else
                        marca = ProductosTable.Rows(i).Item(ProductosTable.Columns("marca"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim modelo As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("modelo"))) Then
                        modelo = Nothing
                    Else
                        modelo = ProductosTable.Rows(i).Item(ProductosTable.Columns("modelo"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim presentacion As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("presentacion"))) Then
                        presentacion = Nothing
                    Else
                        presentacion = ProductosTable.Rows(i).Item(ProductosTable.Columns("presentacion"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim unidadmedida As Int16
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("unidadmedida"))) Then
                        unidadmedida = Nothing
                    Else
                        unidadmedida = ProductosTable.Rows(i).Item(ProductosTable.Columns("unidadmedida"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim medida As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("medida"))) Then
                        medida = Nothing
                    Else
                        medida = ProductosTable.Rows(i).Item(ProductosTable.Columns("medida"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim descripcion As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("descripcion"))) Then
                        descripcion = Nothing
                    Else
                        descripcion = ProductosTable.Rows(i).Item(ProductosTable.Columns("descripcion"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim preciocosto As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("preciocosto"))) Then
                        preciocosto = Nothing
                    Else
                        preciocosto = ProductosTable.Rows(i).Item(ProductosTable.Columns("preciocosto"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim precioventa As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventa"))) Then
                        precioventa = Nothing
                    Else
                        precioventa = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventa"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim stockminimo As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("stockminimo"))) Then
                        stockminimo = Nothing
                    Else
                        stockminimo = ProductosTable.Rows(i).Item(ProductosTable.Columns("stockminimo"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim precioventamayorista As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventamayorista"))) Then
                        precioventamayorista = Nothing
                    Else
                        precioventamayorista = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventamayorista"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim precioventagranel As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventagranel"))) Then
                        precioventagranel = Nothing
                    Else
                        precioventagranel = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventagranel"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim precioventadistribuidor As Decimal
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventadistribuidor"))) Then
                        precioventadistribuidor = Nothing
                    Else
                        precioventadistribuidor = ProductosTable.Rows(i).Item(ProductosTable.Columns("precioventadistribuidor"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim idrubro As Integer
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("idrubro"))) Then
                        idrubro = 1
                    Else
                        idrubro = ProductosTable.Rows(i).Item(ProductosTable.Columns("idrubro"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim iva As Double
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("iva"))) Then
                        iva = Nothing
                    Else
                        iva = ProductosTable.Rows(i).Item(ProductosTable.Columns("iva"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim fabricante As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("fabricante"))) Then
                        fabricante = Nothing
                    Else
                        fabricante = ProductosTable.Rows(i).Item(ProductosTable.Columns("fabricante"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim productocompuesto As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("productocompuesto"))) Then
                        productocompuesto = "N"
                    Else
                        productocompuesto = ProductosTable.Rows(i).Item(ProductosTable.Columns("productocompuesto"))
                    End If
                    '-----------------------------------------------------------------------------------
                    Dim estado As String
                    If IsDBNull(ProductosTable.Rows(i).Item(ProductosTable.Columns("estado"))) Then
                        estado = "I"
                    Else
                        estado = ProductosTable.Rows(i).Item(ProductosTable.Columns("estado"))
                    End If
                    '-----------------------------------------------------------------------------------
                    ' SI EXISTE UPDATE
                    If idproductoweb > 0 Then
                        ProductosWEBTableAdapter.productosweb_update(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante, codigoproducto)
                    Else ' NO EXISTE INSERT
                        ProductosWEBTableAdapter.productosweb_insertar(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, estado, precioventadistribuidor, idrubro, iva, fabricante)
                    End If
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Cursor.Current = Cursors.Default
                    coderror = 0
                    msgerror = ""
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    gProgressBarCounter = i
                    p.ProgressBar1.Value = i
                    p.LabelProgress.Text = "Progreso: " + i.ToString + "/" + p.ProgressBar1.Maximum.ToString
                    p.Refresh()
                Next
            Catch ex As Exception

            End Try
            '-----------------------------------------------------------------------------------
            SyncLogWEBTableAdapter.synclog_update(1, Now, gmacadress, gusername, "productos")
            p.ProgressBar1.Value = p.ProgressBar1.Maximum
            Cursor.Current = Cursors.Default
            coderror = 0
            msgerror = ""
            p.Close()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
        End Try

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub LoadGlobalsLastSyncProductos()
        Try
            If gModuloCloud = 1 Then
                Dim SyncLogTableAdapter As comercialDataSetTableAdapters.synclogTableAdapter
                SyncLogTableAdapter = New comercialDataSetTableAdapters.synclogTableAdapter()
                Dim SyncLogWEBTableAdapter As MySQLDataSetTableAdapters.synclogTableAdapter
                SyncLogWEBTableAdapter = New MySQLDataSetTableAdapters.synclogTableAdapter()
                '--------------------------------------------------------------------------
                LastSyncLocalProductos = SyncLogTableAdapter.synclog_lastsync("productos")
                LastSyncRemoteProductos = SyncLogWEBTableAdapter.synclog_lastsync("productos")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub NeedSyncProductos()
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            MsgBox("No se pudo conectar a la Nube para obtener las actualizaciónes de productos!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim SyncLogTableAdapter As comercialDataSetTableAdapters.synclogTableAdapter
            SyncLogTableAdapter = New comercialDataSetTableAdapters.synclogTableAdapter()
            Dim SyncLogWEBTableAdapter As MySQLDataSetTableAdapters.synclogTableAdapter
            SyncLogWEBTableAdapter = New MySQLDataSetTableAdapters.synclogTableAdapter()
            '--------------------------------------------------------------------------
            LastSyncLocalProductos = SyncLogTableAdapter.synclog_lastsync("productos")
            LastSyncRemoteProductos = SyncLogWEBTableAdapter.synclog_lastsync("productos")
            '--------------------------------------------------------------------------
            If LastSyncLocalProductos < LastSyncRemoteProductos Then
                Dim coderror As Int16
                Dim msgerror As String = ""
                MySQLModule.DescargarProductosClowd(coderror, msgerror)
                If coderror > 0 Then
                    MsgBox("No se pudo descargar el listado de productos de la nube: " + msgerror)
                Else
                    SyncLogTableAdapter.synclog_update(1, LastSyncRemoteProductos, gmacadress, gusername, "productos")
                End If
            End If
        Catch ex As Exception
            If gIsOnline = False Then
                MessageBox.Show("No se puede Sincronizar productos." + vbCr + " No hay conexión a internet!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("No se puede Sincronizar productos. Se ha perdido la conexion a internet!" + vbCr + vbCr + ex.Message + vbCr + vbCr + ex.StackTrace, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            'MsgBox("Ocurrió un problema al consultar SyncLog productos: " + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynLibroVentas(ByRef coderror As String, ByRef msgerror As String)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        If Not My.Computer.Network.IsAvailable Then
            coderror = 0
            ErrorLogTableAdapter.errorlog_insertar("SynLibroVentas", "Al verificar conexion al servidor", "SynLibroVentas", "Mensaje: No hay conexión a internet")
            'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        'Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        Try
            Dim CheckConnection As MySqlConnection
            CheckConnection = New MySqlConnection
            CheckConnection.ConnectionString = SCStrConn
            CheckConnection.Open()
            My.Settings.SetUserOverride("SCConnectionString", SCStrConn)
            Dim TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
            TerminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            gMiSucursal = TerminalesTableAdapter.terminales_consultarsucursal(gmacadress)
            CheckConnection.Close()
            CheckConnection.Dispose()
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("SynLibroVentas", "Al verificar conexion al servidor siscom para obtener idsucursal", "SynLibroVentas", "Mensaje: " + ex.Message)
            Return
        End Try
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            'coderror = 1
            'msgerror = "No se pudo conectar al servidor remoto"
            ErrorLogTableAdapter.errorlog_insertar("SynLibroVentas", "Al verificar conexion al servidor", "SynLibroVentas", "Mensaje: no se pudo conectar a la nube")
            Return
        End If
        Dim maxidventas As Long
        Try
            '-----------------------------------------------------
            Dim LibroventasWEBTableAdapter As MySQLDataSetTableAdapters.libroventasTableAdapter
            LibroventasWEBTableAdapter = New MySQLDataSetTableAdapters.libroventasTableAdapter()
            maxidventas = LibroventasWEBTableAdapter.libroventas_maxidventa(gMiSucursal)
            Dim libroventasTableAdapter As comercialDataSetTableAdapters.libroventasTableAdapter
            libroventasTableAdapter = New comercialDataSetTableAdapters.libroventasTableAdapter()
            '-----------------------------------------------------
            Dim LibroventasTable As comercialDataSet.libroventasDataTable
            LibroventasTable = libroventasTableAdapter.GetDataByMayoresAidventas(maxidventas)
            '-------------------------------    barra de progreso----------------------------------------------------
            'Dim p As SubirProductosClowd
            'p = New SubirProductosClowd
            'p.Show()
            'p.ProgressBar1.Maximum = ProductosWEBTable.Rows.Count
            'p.GroupBox1.Text = "Descargando Productos de la Nube"
            'p.LabelProgress.Text = "Progreso: " + "0/" + p.ProgressBar1.Maximum.ToString
            ''-----------------------------------------------------------------------------------
            'Cursor.Current = Cursors.WaitCursor
            ''-----------------------------------------------------------------------------------
            For i = 0 To LibroventasTable.Rows.Count - 1
                Dim idventa As Long '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("idventa"))) Then
                    idventa = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("idventa"))
                Else
                    Continue For
                End If
                Dim fechaventa As DateTime '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("fechaventa"))) Then
                    fechaventa = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("fechaventa"))
                Else
                    Continue For
                End If
                Dim nombre As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("nombre"))) Then
                    nombre = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("nombre"))
                Else
                    Continue For
                End If
                Dim cuit As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("cuit"))) Then
                    cuit = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("cuit"))
                Else
                    cuit = Nothing
                    'Continue For
                End If
                Dim tipocomprobante As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("tipocomprobante"))) Then
                    tipocomprobante = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("tipocomprobante"))
                Else
                    tipocomprobante = Nothing
                    'Continue For
                End If
                Dim importe As Decimal '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("importe"))) Then
                    importe = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("importe"))
                Else
                    Continue For
                End If
                Dim formapago As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("formapago"))) Then
                    formapago = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("formapago"))
                Else
                    formapago = Nothing
                    'Continue For
                End If
                Dim ivaventas As Decimal '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("ivaventas"))) Then
                    ivaventas = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("ivaventas"))
                Else
                    ivaventas = Nothing
                    'Continue For
                End If
                Dim condicioniva As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("condicioniva"))) Then
                    condicioniva = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("condicioniva"))
                Else
                    condicioniva = Nothing
                    'Continue For
                End If
                Dim condicionivadescripcion As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(LibroventasTable.Rows(i).Item(LibroventasTable.Columns("condicionivadescripcion"))) Then
                    condicionivadescripcion = LibroventasTable.Rows(i).Item(LibroventasTable.Columns("condicionivadescripcion"))
                Else
                    condicionivadescripcion = Nothing
                    'Continue For
                End If
                '=======================    INSERTAR REGISTRO =================
                LibroventasWEBTableAdapter.libroventas_insertar(gMiSucursal, idventa, fechaventa, nombre, cuit, condicionivadescripcion, tipocomprobante, importe, ivaventas, condicioniva, formapago)
            Next
        Catch ex As Exception
            'Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
            ErrorLogTableAdapter.errorlog_insertar("SynLibroVentas", "Al verificar conexion al servidor", "SynLibroVentas", "Mensaje: " + ex.Message)
        End Try

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynStockGeneral(ByRef coderror As String, ByRef msgerror As String)
        '/*********************************************************************************/
        '    procedimiento que actualiza TODO el stock LOCAL en la nube
        '/*********************************************************************************/
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        If Not My.Computer.Network.IsAvailable Then
            coderror = 0
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor", "SynStockGeneral", "Mensaje: No hay conexión a internet")
            'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        'Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        Try
            'Dim CheckConnection As MySqlConnection
            'CheckConnection = New MySqlConnection
            'CheckConnection.ConnectionString = SCStrConn
            'CheckConnection.Open()
            My.Settings.SetUserOverride("SCConnectionString", SCStrConn)
            Dim TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
            TerminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            gMiSucursal = TerminalesTableAdapter.terminales_consultarsucursal(gmacadress)
            'CheckConnection.Close()
            'CheckConnection.Dispose()
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor siscom para obtener idsucursal", "SynLibroVentas", "Mensaje: " + ex.Message)
            Return
        End Try
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            'coderror = 1
            'msgerror = "No se pudo conectar al servidor remoto"
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor", "SynStockGeneral", "Mensaje: no se pudo conectar a la nube")
            Return
        End If
        'Dim maxidventas As Long
        '***************************************'***************************************'***************************************
        '==========   sincronización del stock general local hacia la NUBE ============================
        '***************************************'***************************************'***************************************
        Try
            '-----------------------------------------------------
            Dim StockgeneralWEBTableAdapter As MySQLDataSetTableAdapters.stockgeneralTableAdapter
            StockgeneralWEBTableAdapter = New MySQLDataSetTableAdapters.stockgeneralTableAdapter()
            'maxidventas = LibroventasWEBTableAdapter.libroventas_maxidventa(gMiSucursal)
            Dim stockgeneralTableAdapter As comercialDataSetTableAdapters.stockgeneralTableAdapter
            stockgeneralTableAdapter = New comercialDataSetTableAdapters.stockgeneralTableAdapter()
            '-----------------------------------------------------
            Dim stockgeneral As comercialDataSet.stockgeneralDataTable
            stockgeneral = stockgeneralTableAdapter.GetData
            '-------------------------------    barra de progreso----------------------------------------------------
            'Dim p As SubirProductosClowd
            'p = New SubirProductosClowd
            'p.Show()
            'p.ProgressBar1.Maximum = ProductosWEBTable.Rows.Count
            'p.GroupBox1.Text = "Descargando Productos de la Nube"
            'p.LabelProgress.Text = "Progreso: " + "0/" + p.ProgressBar1.Maximum.ToString
            ''-----------------------------------------------------------------------------------
            'Cursor.Current = Cursors.WaitCursor
            ''-----------------------------------------------------------------------------------
            For i = 0 To stockgeneral.Rows.Count - 1
                Dim codigoproducto As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("codigoproducto"))) Then
                    codigoproducto = stockgeneral.Rows(i).Item(stockgeneral.Columns("codigoproducto"))
                Else
                    Continue For
                End If
                Dim disponible As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("disponible"))) Then
                    disponible = stockgeneral.Rows(i).Item(stockgeneral.Columns("disponible"))
                    If disponible < 0 Then
                        disponible = 0
                    End If
                Else
                    Continue For
                End If
                Dim unidades As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("unidades"))) Then
                    unidades = stockgeneral.Rows(i).Item(stockgeneral.Columns("unidades"))
                    If unidades < 0 Then
                        unidades = 0
                    End If
                Else
                    Continue For
                End If
                '=======================    INSERTAR REGISTRO =================
                StockgeneralWEBTableAdapter.stockgeneral_update(gMiSucursal, codigoproducto, disponible, unidades)
            Next
        Catch ex As Exception
            'Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
            ErrorLogTableAdapter.errorlog_insertar("SynStockgeneral", "Al verificar conexion al servidor", "SynStockgeneral", "Mensaje: " + ex.Message)
            MessageBox.Show("No se pudo completar la operación SynStockGeneral: " + ex.Message & vbCr & "Contactar al proveedor de sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynStockClowd(ByRef idventa As Long, ByRef origen As String, ByRef coderror As String, ByRef msgerror As String)
        '/*********************************************************************************/
        '    procedimiento que actualiza el stock en la nube respecto a los movimientos de una venta,remito,ajuste
        '/*********************************************************************************/
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        If Not My.Computer.Network.IsAvailable Then
            coderror = 0
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor", "SynStockGeneral", "Mensaje: No hay conexión a internet")
            'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        'Cursor.Current = Cursors.WaitCursor
        '***************************************
        '********************** verificar conexion al servidor ************************
        Try
            'Dim CheckConnection As MySqlConnection
            'CheckConnection = New MySqlConnection
            'CheckConnection.ConnectionString = SCStrConn
            'CheckConnection.Open()
            My.Settings.SetUserOverride("SCConnectionString", SCStrConn)
            Dim TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
            TerminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            gMiSucursal = TerminalesTableAdapter.terminales_consultarsucursal(gmacadress)
            'CheckConnection.Close()
            'CheckConnection.Dispose()
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor siscom para obtener idsucursal", "SynLibroVentas", "Mensaje: " + ex.Message)
            Return
        End Try
        '***************************************
        Dim status As Boolean
        conectarMySQL(status)
        If status = False Then
            'coderror = 1
            'msgerror = "No se pudo conectar al servidor remoto"
            ErrorLogTableAdapter.errorlog_insertar("SynStockGeneral", "Al verificar conexion al servidor", "SynStockGeneral", "Mensaje: no se pudo conectar a la nube")
            Return
        End If
        'Dim maxidventas As Long
        Try
            '-----------------------------------------------------
            Dim StockgeneralWEBTableAdapter As MySQLDataSetTableAdapters.stockgeneralTableAdapter
            StockgeneralWEBTableAdapter = New MySQLDataSetTableAdapters.stockgeneralTableAdapter()
            'maxidventas = LibroventasWEBTableAdapter.libroventas_maxidventa(gMiSucursal)
            Dim stockgeneralTableAdapter As comercialDataSetTableAdapters.stockgeneralTableAdapter
            stockgeneralTableAdapter = New comercialDataSetTableAdapters.stockgeneralTableAdapter()
            '-----------------------------------------------------
            Dim stockgeneral As New comercialDataSet.stockgeneralDataTable()
            Select Case origen
                Case "V"
                    stockgeneral = stockgeneralTableAdapter.GetDataByVenta(idventa)
                Case "R"
                    stockgeneral = stockgeneralTableAdapter.GetDataByRemito(idventa)
                Case "A"
                    stockgeneral = stockgeneralTableAdapter.GetDataByIDproducto(idventa)
                Case "UPD"
                    stockgeneral = stockgeneralTableAdapter.GetDataByIDproducto(idventa)
            End Select
            '-------------------------------    barra de progreso----------------------------------------------------
            'Dim p As SubirProductosClowd
            'p = New SubirProductosClowd
            'p.Show()
            'p.ProgressBar1.Maximum = ProductosWEBTable.Rows.Count
            'p.GroupBox1.Text = "Descargando Productos de la Nube"
            'p.LabelProgress.Text = "Progreso: " + "0/" + p.ProgressBar1.Maximum.ToString
            ''-----------------------------------------------------------------------------------
            'Cursor.Current = Cursors.WaitCursor
            ''-----------------------------------------------------------------------------------
            For i = 0 To stockgeneral.Rows.Count - 1
                Dim codigoproducto As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("codigoproducto"))) Then
                    codigoproducto = stockgeneral.Rows(i).Item(stockgeneral.Columns("codigoproducto"))
                Else
                    Continue For
                End If
                Dim disponible As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("disponible"))) Then
                    disponible = stockgeneral.Rows(i).Item(stockgeneral.Columns("disponible"))
                    If disponible < 0 Then
                        disponible = 0
                    End If
                Else
                    Continue For
                End If
                Dim unidades As String '''''''''''''''''''''''''''''''''
                If Not IsDBNull(stockgeneral.Rows(i).Item(stockgeneral.Columns("unidades"))) Then
                    unidades = stockgeneral.Rows(i).Item(stockgeneral.Columns("unidades"))
                    If unidades < 0 Then
                        unidades = 0
                    End If
                Else
                    Continue For
                End If
                '=======================    INSERTAR REGISTRO =================
                StockgeneralWEBTableAdapter.stockgeneral_update(gMiSucursal, codigoproducto, disponible, unidades)
            Next
        Catch ex As Exception
            'Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
            ErrorLogTableAdapter.errorlog_insertar("SynStockgeneral", "Al verificar conexion al servidor", "SynStockgeneral", "Mensaje: " + ex.Message)
        End Try
    End Sub
    '''''''''''''''''
    Sub PushCliente(ByRef idcliente As Long)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        Try
            '*************  errorlog    **************************************
            Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
            ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
            '****   ----    ********
            '****clientes local********
            Dim clientestableadapter As comercialDataSetTableAdapters.clientesTableAdapter
            clientestableadapter = New comercialDataSetTableAdapters.clientesTableAdapter()
            Dim clientestable As New comercialDataSet.clientesDataTable()
            clientestable = clientestableadapter.GetDataByIdcliente(idcliente)
            '****   ----    ********
            '****clientesweb********
            Dim clienteswebtableadapter As MySQLDataSetTableAdapters.clientesTableAdapter
            clienteswebtableadapter = New MySQLDataSetTableAdapters.clientesTableAdapter()
            '*********************

            For i = 0 To clientestable.Count - 1
                Dim webid As Long
                If IsDBNull(clientestable.Rows(i).Item(clientestable.idclientewebColumn)) Then
                    webid = clienteswebtableadapter.clientes_maxidcliente() + 1
                Else
                    webid = clientestable.Rows(i).Item(clientestable.idclientewebColumn)
                End If
                '**********************
                Dim nuevoidclienteweb As Long = webid ' clientestable.Rows(i).Item(clientestable.idclienteColumn)
                Dim idclientelocal As Long = clientestable.Rows(i).Item(clientestable.idclienteColumn)
                '*******************************
                Dim nombre As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.nombreColumn)) Then
                    nombre = " "
                Else
                    nombre = clientestable.Rows(i).Item(clientestable.nombreColumn)
                End If
                '*******************************
                Dim cuit As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.cuitColumn)) Then
                    cuit = " "
                Else
                    cuit = clientestable.Rows(i).Item(clientestable.cuitColumn)
                End If
                '*******************************
                Dim telefono As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.telefonoColumn)) Then
                    telefono = " "
                Else
                    telefono = clientestable.Rows(i).Item(clientestable.telefonoColumn)
                End If
                '*******************************
                Dim email As String
                Try
                    email = clientestable.Rows(i).Item(clientestable.emailColumn)
                Catch ex As Exception
                    email = " "
                End Try
                '*******************************
                Dim sync As String = "S"
                Dim condicioniva As Long
                Dim diasvencimiento As Long
                Dim idprovincia As Long
                Dim idtipodocumento As Long
                Dim porcentajedescuento As Integer
                '*******************************
                Try
                    idtipodocumento = clientestable.Rows(i).Item(clientestable.idtipodocumentoColumn)
                Catch ex As Exception
                    idtipodocumento = Nothing
                End Try
                '*******************************
                Try
                    idprovincia = clientestable.Rows(i).Item(clientestable.idprovinciaColumn)
                Catch ex As Exception
                    idprovincia = Nothing
                End Try
                '*******************************
                Try
                    diasvencimiento = clientestable.Rows(i).Item(clientestable.diasvencimientoColumn)
                Catch ex As Exception
                    diasvencimiento = 0
                End Try
                '*******************************
                Try
                    porcentajedescuento = clientestable.Rows(i).Item(clientestable.porcentajedescuentoColumn)
                Catch ex As Exception
                    porcentajedescuento = 0
                End Try
                '*******************************
                Try
                    condicioniva = clientestable.Rows(i).Item(clientestable.condicionivaColumn)
                Catch ex As Exception
                    condicioniva = Nothing
                End Try
                '*******************************
                clienteswebtableadapter.clientes_update(nuevoidclienteweb, nombre, cuit, telefono, email, sync, condicioniva, diasvencimiento, porcentajedescuento, idprovincia, idtipodocumento)
                ''****   ----    ********
                clientestableadapter.clientes_updateidweblocal(nuevoidclienteweb, idclientelocal)
                ''****   ----    ********
                PushClientesDomicilios(idclientelocal, nuevoidclienteweb)
            Next
        Catch ex As Exception
            MessageBox.Show("Advertencia - PushCliente: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'coderror = 1
            'msgerror = ex.Message
            ErrorLogTableAdapter.errorlog_insertar("PushClientes", "Al tratar de sincronizar Clientes en la nube", "PushClientes", "Mensaje: " + ex.Message)
        End Try
    End Sub
    ''**********************************
    Sub PushClientes()
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        Try
            '*************  errorlog    **************************************
            Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
            ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
            '****   ----    ********
            '****clientes local********
            Dim clientestableadapter As comercialDataSetTableAdapters.clientesTableAdapter
            clientestableadapter = New comercialDataSetTableAdapters.clientesTableAdapter()
            Dim clientestable As New comercialDataSet.clientesDataTable()
            clientestable = clientestableadapter.GetData()
            '****   ----    ********
            '****clientesweb********
            Dim clienteswebtableadapter As MySQLDataSetTableAdapters.clientesTableAdapter
            clienteswebtableadapter = New MySQLDataSetTableAdapters.clientesTableAdapter()
            '*********************

            For i = 0 To clientestable.Count - 1
                Dim webid As Long
                If IsDBNull(clientestable.Rows(i).Item(clientestable.idclientewebColumn)) Then
                    webid = clienteswebtableadapter.clientes_maxidcliente() + 1
                Else
                    webid = clientestable.Rows(i).Item(clientestable.idclientewebColumn)
                End If
                '**********************
                Dim nuevoidclienteweb As Long = webid ' clientestable.Rows(i).Item(clientestable.idclienteColumn)
                Dim idclientelocal As Long = clientestable.Rows(i).Item(clientestable.idclienteColumn)
                '*******************************
                Dim nombre As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.nombreColumn)) Then
                    nombre = " "
                Else
                    nombre = clientestable.Rows(i).Item(clientestable.nombreColumn)
                End If
                '*******************************
                Dim cuit As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.cuitColumn)) Then
                    cuit = " "
                Else
                    cuit = clientestable.Rows(i).Item(clientestable.cuitColumn)
                End If
                '*******************************
                Dim telefono As String
                If IsDBNull(clientestable.Rows(i).Item(clientestable.telefonoColumn)) Then
                    telefono = " "
                Else
                    telefono = clientestable.Rows(i).Item(clientestable.telefonoColumn)
                End If
                '*******************************
                Dim email As String
                Try
                    email = clientestable.Rows(i).Item(clientestable.emailColumn)
                Catch ex As Exception
                    email = " "
                End Try
                '*******************************
                Dim sync As String = "S"
                Dim condicioniva As Long
                Dim diasvencimiento As Long
                Dim idprovincia As Long
                Dim idtipodocumento As Long
                Dim porcentajedescuento As Decimal
                '*******************************
                Try
                    idtipodocumento = clientestable.Rows(i).Item(clientestable.idtipodocumentoColumn)
                Catch ex As Exception
                    idtipodocumento = Nothing
                End Try
                '*******************************
                Try
                    idprovincia = clientestable.Rows(i).Item(clientestable.idprovinciaColumn)
                Catch ex As Exception
                    idprovincia = Nothing
                End Try
                '*******************************
                Try
                    diasvencimiento = clientestable.Rows(i).Item(clientestable.diasvencimientoColumn)
                Catch ex As Exception
                    diasvencimiento = 0
                End Try
                '*******************************
                Try
                    porcentajedescuento = clientestable.Rows(i).Item(clientestable.porcentajedescuentoColumn)
                Catch ex As Exception
                    porcentajedescuento = 0
                End Try
                '*******************************
                Try
                    condicioniva = clientestable.Rows(i).Item(clientestable.condicionivaColumn)
                Catch ex As Exception
                    condicioniva = Nothing
                End Try
                '*******************************
                clienteswebtableadapter.clientes_update(nuevoidclienteweb, nombre, cuit, telefono, email, sync, condicioniva, diasvencimiento, porcentajedescuento, idprovincia, idtipodocumento)
                ''****   ----    ********
                clientestableadapter.clientes_updateidweblocal(nuevoidclienteweb, idclientelocal)
                ''****   ----    ********
                PushClientesDomicilios(idclientelocal, nuevoidclienteweb)
            Next
        Catch ex As Exception
            MessageBox.Show("Advertencia - PushClientes: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'coderror = 1
            'msgerror = ex.Message
            ErrorLogTableAdapter.errorlog_insertar("PushClientes", "Al tratar de sincronizar Clientes en la nube", "PushClientes", "Mensaje: " + ex.Message)
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub PushClientesDomicilios(ByVal idclientelocal As Long, ByRef nuevoidclienteweb As Long)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
        '****clientesdomicilios local********
        Dim clientesdomiciliostableadapter As comercialDataSetTableAdapters.clientesdomiciliosTableAdapter
        clientesdomiciliostableadapter = New comercialDataSetTableAdapters.clientesdomiciliosTableAdapter()
        Dim clientesdomiciliostable As New comercialDataSet.clientesdomiciliosDataTable()
        '****   ----    ********
        '****clientesdomiciliosweb********
        Dim clientesdomicilioswebtableadapter As MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter
        clientesdomicilioswebtableadapter = New MySQLDataSetTableAdapters.clientesdomiciliosTableAdapter()
        '*********************
        Try
            clientesdomiciliostable = clientesdomiciliostableadapter.GetDataByidcliente(idclientelocal)
            Dim idclientedomiciliosweb As Long = 0
            Dim inserted As Long = 0
            Dim iddomicilio As Long = 0
            '*********************
            If clientesdomiciliostable.Rows.Count > 0 Then
                Dim direccion As String
                Dim referencias As String
                Dim idprovinciadomicilio As Integer
                Dim idlocalidaddomicilio As Integer
                Dim cp As String
                Dim latitud As String
                Dim longitud As String
                For k = 0 To clientesdomiciliostable.Count - 1
                    iddomicilio = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.iddomicilioColumn)
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idclientesdomicilioswebColumn)) Then
                        idclientedomiciliosweb = 0
                    Else
                        idclientedomiciliosweb = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idclientesdomicilioswebColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.direccionColumn)) Then
                        direccion = Nothing
                    Else
                        direccion = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.direccionColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.referenciasColumn)) Then
                        referencias = Nothing
                    Else
                        referencias = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.referenciasColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idprovinciaColumn)) Then
                        idprovinciadomicilio = Nothing
                    Else
                        idprovinciadomicilio = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idprovinciaColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idlocalidadColumn)) Then
                        idlocalidaddomicilio = Nothing
                    Else
                        idlocalidaddomicilio = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.idlocalidadColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.cpColumn)) Then
                        cp = Nothing
                    Else
                        cp = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.cpColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------

                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.latitudColumn)) Then
                        latitud = Nothing
                    Else
                        latitud = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.latitudColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If IsDBNull(clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.longitudColumn)) Then
                        longitud = Nothing
                    Else
                        longitud = clientesdomiciliostable.Rows(k).Item(clientesdomiciliostable.longitudColumn)
                    End If
                    '---------------------------------------------------------------------------------------------------
                    If idprovinciadomicilio = 0 Or idlocalidaddomicilio = 0 Or direccion = Nothing Then
                        Continue For
                    Else
                        clientesdomicilioswebtableadapter.clientesdomicilios_update(idclientedomiciliosweb, nuevoidclienteweb, direccion, referencias, idprovinciadomicilio, idlocalidaddomicilio, cp, "S", latitud, longitud)
                        inserted = clientesdomicilioswebtableadapter.clientesdomicilios_maxidclientesdomicilios(nuevoidclienteweb)
                        clientesdomiciliostableadapter.clientesdomicilios_updateidclientesdomiciliosweb(inserted, idclientelocal, iddomicilio)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema al tratar de sincronizar Clientes en la nube", "Advertencia - PushDomicilios: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
    End Sub
End Module

Imports MySql.Data.MySqlClient

Module MySQLModule
    '*************************  VARIABLES **********************************************************
    'Dim da As MySqlDataAdapter
    Dim da As MySQLDataSetTableAdapters.clientesTableAdapter
    Dim ds As MySQLDataSet
    Dim dt As DataTable
    '************************************************************************************************
    '*************  errorlog    **************************************
    Dim ErrorLogTableAdapter As MySQLDataSetTableAdapters.errorlogTableAdapter
    '************************************************************************        
    Public MySQLC As MySqlConnection
    Sub conectarMySQL(ByRef status As Boolean)
        Try
            'MySQLConn = New MySqlConnection("Data Source=sistemascomerciales.net; Database=sistema1_sgcaguadagrande; User ID=sistema1_sgcweb; Password=sgcomercial*?; Allow Zero Datetime= true; CHARSET= latin1")
            MySQLC = New MySqlConnection(sgcomercial.My.MySettings.Default.MySQLConnectionString)
            MySQLC.Open()
            'MsgBox("Conexión exitosa!", MsgBoxStyle.Information)
            status = True
        Catch ex As Exception
            MsgBox("No se pudo conectar con el servidor remoto: " + ex.Message, MsgBoxStyle.Information)
            MySQLC.Dispose()
            status = False
        End Try
    End Sub

    Public Sub SynClientes()
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
            Dim ErrorLogTableAdapter As MySQLDataSetTableAdapters.errorlogTableAdapter
            ErrorLogTableAdapter = New MySQLDataSetTableAdapters.errorlogTableAdapter()
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
                    Try
                        idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                        '****     ins/upd  CLIENTE     **********
                        If idclientelocal = 0 Then ' el cliente no esta registrado localmente
                            idclientelocal = clientestableadapter.clientes_insertar(idclienteweb, nombre, telefono, email, cuit)
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
    End Sub
    '***************************************************************
    '********************** syncro Pedidos  ************************
    '***************************************************************
    Public Sub SynPedidos()
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
        Dim ErrorLogTableAdapter As MySQLDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New MySQLDataSetTableAdapters.errorlogTableAdapter()
        '*************  --------    **************************************
        Try ' COMIENZA LA SYNC
            '***********************
            ds = New MySQLDataSet
            '****   PedidosDeliveryWEBTableAdapter  ******** WEB
            Dim PedidosDeliveryWEBTableAdapter As MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter
            PedidosDeliveryWEBTableAdapter = New MySQLDataSetTableAdapters.pedidosdeliveryTableAdapter()
            Dim PedidosDeliveryWEBTable As MySQLDataSet.pedidosdeliveryDataTable
            PedidosDeliveryWEBTable = PedidosDeliveryWEBTableAdapter.GetDataBySync("N")
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
            Dim PedidosDeliveryDetalleWEBTableAdapter As MySQLDataSetTableAdapters.pedidosdeliverydetalleTableAdapter
            PedidosDeliveryDetalleWEBTableAdapter = New MySQLDataSetTableAdapters.pedidosdeliverydetalleTableAdapter()
            Dim PedidosDeliveryDetalleWEBTable As MySQLDataSet.pedidosdeliverydetalleDataTable
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
                            If d = 2 Or d = 8 Then
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

                    Dim idtransporte As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.idtransporteColumn)
                    Dim iddomicilioweb As Long = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.iddomicilioColumn)
                    Dim pagoesperado As Decimal = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.pagoesperadoColumn)
                    Dim fechaalta As DateTime = PedidosDeliveryWEBTable.Rows(i).Item(PedidosDeliveryWEBTable.fechaaltaColumn)
                    Dim idpedidodeliverylocal As Long = 0
                    Dim idclientelocal As Long = 0
                    Dim idclientedomiciliolocal As Long = 0
                    '********   verifico si existe localmente
                    idpedidodeliverylocal = Convert.ToInt64(PedidosDeliveryTableAdapter.pedidosdelivery_existepedidoweb(idpedidosdeliveryweb), Nothing)
                    If idpedidodeliverylocal = 0 Then ' VERIFICO QUE EXISTA EL CLIENTE LOCAL Y EL DOMICILIO LOCAL
                        idclientelocal = clientestableadapter.clientes_existeclienteweb(idclienteweb)
                        idclientedomiciliolocal = clientesdomiciliostableadapter.clientesdomicilios_existedomicilioweb(iddomicilioweb)
                        If idclientelocal = 0 Or idclientedomiciliolocal = 0 Then
                            ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo sincronizar el pedido WEB: " + idpedidosdeliveryweb.ToString + " (información de cliente inválida)")
                            MsgBox("No se pudo sincronizar el pedido WEB: " + idpedidosdeliveryweb.ToString + " (información de cliente inválida)", MsgBoxStyle.Exclamation)
                            Continue For
                        End If
                    Else    ' SI EXISTE LO CANCELA OPERACION
                        Continue For
                    End If
                    'obtengo el detalle del pedido web
                    PedidosDeliveryDetalleWEBTable = PedidosDeliveryDetalleWEBTableAdapter.GetDataByIdpedidodeliveryweb(idpedidosdeliveryweb)
                    '****************   REGISTRO EL DETALLE DEL PEDIDO  **************
                    For j = 0 To PedidosDeliveryDetalleWEBTable.Rows.Count - 1
                        Dim idpedidodeliverydetalleweb As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        'Dim idventa As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        Dim idproducto As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idproductoColumn)
                        Dim cantidad As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.cantidadColumn)
                        Dim precioventa As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.precioventaColumn)
                        Dim recargo As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)
                        Dim idlistaprecio As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)
                        Try
                            PedidosDeliveryDetalleTableAdapter.pedidosdeliverydetalle_insertar(idpedidosdeliveryweb, idproducto, cantidad, precioventa, recargo, idlistaprecio)
                            PedidosDeliveryWEBTableAdapter.pedidosdelivery_updatesync("S", idpedidosdeliveryweb)
                        Catch ex As Exception
                            ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
                            MsgBox("No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
                        End Try
                    Next
                    Dim NvoPedido
                    NvoPedido = PedidosDeliveryTableAdapter.pedidosdelivery_insertfromweb(idclientelocal, Nothing, idtransporte, idclientedomiciliolocal, pagoesperado, fechaalta, "usuarioweb", "RECIBIDO", idpedidosdeliveryweb)
                    Dim nvavta As Int64
                    '***************** REGISTRO LA VENTA    *******************************
                    nvavta = VentasTableAdapter.ventas_insertarventa(idclientelocal, Now(), Nothing, 1, "usuarioweb", Nothing, Nothing)
                    '****************   REGISTRO EL DETALLE DE LA VENTA **************
                    For j = 0 To PedidosDeliveryDetalleWEBTable.Rows.Count - 1
                        Dim idpedidodeliverydetalleweb As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idpedidosdeliverydetallewebColumn)
                        Dim idproducto As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idproductoColumn)
                        Dim cantidad As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.cantidadColumn)
                        Dim precioventa As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.precioventaColumn)
                        Dim recargo As Decimal = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.recargoColumn)
                        Dim idlistaprecio As Long = PedidosDeliveryDetalleWEBTable.Rows(j).Item(PedidosDeliveryDetalleWEBTable.idlistaprecioColumn)
                        VentasDetalleTableAdapter.ventasdetalle_insertardetalle(nvavta, idproducto, cantidad, precioventa, idlistaprecio, Nothing, Nothing)
                        PedidosDeliveryTableAdapter.pedidosdelivery_updateidventa(nvavta, NvoPedido)
                    Next
                Next
            End If
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("SynPedidos", "DATOS", "SynPedidos", "No se pudo completar la Sincronización de PEDIDOS: " + ex.Message)
            MsgBox("Advertencia! " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub UpdEstadoPedidoWeb(estado As String, idpedidoweb As Long)
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
        ErrorLogTableAdapter = New MySQLDataSetTableAdapters.errorlogTableAdapter()
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
End Module

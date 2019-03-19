Imports MySql.Data.MySqlClient

Module MySQLModule
    '*************************  VARIABLES **********************************************************
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' SI EXISTE UPDATE
                If idproductoweb > 0 Then
                    ProductosWEBTableAdapter.productosweb_update(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante, codigoproducto)
                Else ' NO EXISTE INSERT
                    ProductosWEBTableAdapter.productosweb_insertar(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante)
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
            ProductosWEBTable = ProductosWEBTableAdapter.GetDataByActivos
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
                    idrubro = ProductosWEBTable.Rows(i).Item(ProductosWEBTable.Columns("idrubro"))
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
                ' SI EXISTE UPDATE
                If idproductolocal > 0 Then
                    ProductosTableAdapter.productos_pullupdate(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante, codigoproducto, idproductolocal)
                Else ' NO EXISTE INSERT
                    ProductosTableAdapter.productos_pullinsert(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante)
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                SyncLogTableAdapter.synclog_update(1, Now, gmacadress, gusername, "productos")
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
            p.Close()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            coderror = 1
            msgerror = ex.Message
        End Try

    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SubirProductosClowd(ByRef coderror As String, ByRef msgerror As String)
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
            gProgressBarCounter = 0
            Dim ProductosTableAdapter As comercialDataSetTableAdapters.productosTableAdapter
            ProductosTableAdapter = New comercialDataSetTableAdapters.productosTableAdapter()
            '-----------------------------------------------------
            Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
            ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
            Dim SyncLogWEBTableAdapter As MySQLDataSetTableAdapters.synclogTableAdapter
            SyncLogWEBTableAdapter = New MySQLDataSetTableAdapters.synclogTableAdapter()
            '-----------------------------------------------------------------------------------
            Dim ProductosTable As comercialDataSet.productosDataTable
            '-----------------------------------------------------------------------------------
            ProductosTable = ProductosTableAdapter.GetData
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
                    ProductosTable = ProductosTableAdapter.GetData()
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
                    ' SI EXISTE UPDATE
                    If idproductoweb > 0 Then
                        ProductosWEBTableAdapter.productosweb_update(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante, codigoproducto)
                    Else ' NO EXISTE INSERT
                        ProductosWEBTableAdapter.productosweb_insertar(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, productocompuesto, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, iva, fabricante)
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
    Public Sub NeedSyncProductos()
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
            Dim LastSyncLocal As DateTime
            Dim LastSyncRemote As DateTime
            LastSyncLocal = SyncLogTableAdapter.synclog_lastsync("productos")
            LastSyncRemote = SyncLogWEBTableAdapter.synclog_lastsync("productos")
            '--------------------------------------------------------------------------
            If LastSyncLocal < LastSyncRemote Then
                Dim coderror As Int16
                Dim msgerror As String = ""
                MySQLModule.DescargarProductosClowd(coderror, msgerror)
                If coderror > 0 Then
                    MsgBox("No se pudo descargar el listado de productos de la nube: " + msgerror)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un problema al consultar SyncLog productos: " + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub SynLibroVentas(ByRef coderror As String, ByRef msgerror As String)
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
End Module

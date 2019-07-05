'Imports System
'Imports System.Collections.Generic
'Imports System.Security.Cryptography
'Imports System.Net
'Imports System.Runtime.InteropServices
'Imports System.Net
'Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Security
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.ServiceModel
Imports System.Net.Sockets
Module ModuleAFIP
    '**************************  FEAFIP GLOBALS **************************************************
    Public ID_FNC As String = "[ObtenerLoginTicketResponse]"
    Public LastSysTime As DateTime
    '---------------------------------------------------
    Public RutaDelCertificadoFirmante As String = ""
    Public GWSAADireccion As String
    Public GWSFEV1Direccion As String
    '****************************************************************************
    Public argPassword As SecureString
    Public Source As String
    Public UniqueId As UInt32 ' Entero de 32 bits sin signo que identifica el requerimiento
    Public GenerationTime As DateTime ' Momento en que fue generado el requerimiento
    Public ExpirationTime As DateTime ' Momento en el que expira la solicitud
    Public Service As String ' Identificacion del WSN para el cual se solicita el TA
    Public Sign As String ' Firma de seguridad recibida en la respuesta
    Public Token As String ' Token de seguridad recibido en la respuesta
    Public XmlLoginTicketRequest As XmlDocument = Nothing
    Public XmlLoginTicketResponse As XmlDocument = Nothing
    Public XmlStrLoginTicketRequestTemplate As String = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>"
    Public _globalUniqueID As UInt32 = 0 ' OJO! NO ES THREAD-SAFE
    Public argServicio As String = "wsfe"
    '****************************************************************************
    '----------------------------------------------------------------------------
    Public GFEAFIPENTORNO As String
    Public GFEAUTOCAEAFIP As String
    Public GTOKEN As String = ""
    Public GSIGN As String = ""
    Public GMonid As String
    Public GMonCotiz As Decimal
    Public GCUIT As String
    Public GPtoVta = 2
    Public GCantReg As Long
    Public GCbteTipo As Long
    Public GConcepto As Long
    Public GDocTipo As Long
    Public GDocNro As Long
    Public GImpTotal As Decimal = 0
    Public GImpTotConc As Decimal = 0
    Public GImpNeto As Decimal = 0
    Public GImpOpEx As Decimal = 0
    Public GImpTrib As Decimal = 0
    Public GImpIVA As Decimal = 0
    '****************************************************************************
    '-------------------------------------------------------
    Public Function GetNISTTime(ByVal host As String) As DateTime

        Dim timeStr As String = Nothing

        Try
            Dim reader As New StreamReader(New TcpClient(host, 13).GetStream)
            LastSysTime = DateTime.UtcNow()
            timeStr = reader.ReadToEnd()
            reader.Close()
        Catch ex As SocketException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim jd As Integer = Integer.Parse(timeStr.Substring(1, 5))
        Dim yr As Integer = Integer.Parse(timeStr.Substring(7, 2))
        Dim mo As Integer = Integer.Parse(timeStr.Substring(10, 2))
        Dim dy As Integer = Integer.Parse(timeStr.Substring(13, 2))
        Dim hr As Integer = Integer.Parse(timeStr.Substring(16, 2))
        Dim mm As Integer = Integer.Parse(timeStr.Substring(19, 2))
        Dim sc As Integer = Integer.Parse(timeStr.Substring(22, 2))
        Dim Temp As Integer = CInt(AscW(timeStr(7)))

        Return New DateTime(yr + 2000, mo, dy, hr, mm, sc)

    End Function
    Public Function FeAFIPLoad() As String
        'Dim result As DateTime
        'Dim host As String = "time.afip.gov.ar"
        'result = GetNISTTime(host).ToString
        Dim parametrosgeneralestableadapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralestableadapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        RutaDelCertificadoFirmante = Nothing
        Try
            GFEAFIPENTORNO = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("FEAFIP")
            GFEAUTOCAEAFIP = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("FEAutoCAEAFIP")
        Catch ex As Exception
            GFEAFIPENTORNO = "DESACTIVADO"
            GFEAUTOCAEAFIP = "NO"
            RutaDelCertificadoFirmante = Nothing
            GWSAADireccion = Nothing
            GWSFEV1Direccion = Nothing
            GCUIT = Nothing
        End Try
        '****************************************************************************
        Select Case GFEAFIPENTORNO
            Case "DESACTIVADO"
                RutaDelCertificadoFirmante = Nothing
                GWSAADireccion = Nothing
                GWSFEV1Direccion = Nothing
                GCUIT = Nothing
                GPtoVta = Nothing
            Case "HOMOLOGACION"
                Try
                    RutaDelCertificadoFirmante = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPCRTHOMO")
                    GWSAADireccion = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("WSAAH")
                    GWSFEV1Direccion = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("WSFEV1H")
                    GCUIT = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPCUIT")
                    GPtoVta = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPPTOVTA")
                Catch ex As Exception
                    RutaDelCertificadoFirmante = Nothing
                    GWSAADireccion = Nothing
                    GWSFEV1Direccion = Nothing
                    GCUIT = Nothing
                End Try
            Case "PRODUCCION"
                Try
                    RutaDelCertificadoFirmante = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPCRTPROD")
                    GWSAADireccion = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("WSAAP")
                    GWSFEV1Direccion = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("WSFEV1P")
                    GCUIT = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPCUIT")
                    GPtoVta = parametrosgeneralestableadapter.parametrosgenerales_GetPrgstring1("AFIPPTOVTA")
                Catch ex As Exception
                    RutaDelCertificadoFirmante = Nothing
                    GWSAADireccion = Nothing
                    GWSFEV1Direccion = Nothing
                    GCUIT = Nothing
                End Try
        End Select
        Return GFEAFIPENTORNO
    End Function

    Public Function GenTRA(ByRef loginTicketResponse As String) As StrError
        '---------------------
        Dim StrError As New StrError
        Dim cmsFirmadoBase64 As String
        'Dim loginTicketResponse As String = Nothing
        Dim xmlNodoUniqueId As XmlNode
        Dim xmlNodoGenerationTime As XmlNode
        Dim xmlNodoExpirationTime As XmlNode
        Dim xmlNodoService As XmlNode
        Dim argRutaCertX509Firmante As String = Nothing
        '---------------------
        ' PASO 0: Consulto si hay ticket vigente
        '---------------------
        Try
            Dim TicketAccesoFETableAdapter As New comercialDataSetTableAdapters.ticketaccesofeTableAdapter()
            Dim ticketaccesofeDataTable As New comercialDataSet.ticketaccesofeDataTable
            TicketAccesoFETableAdapter.FillByTRAVigente(ticketaccesofeDataTable)
            If ticketaccesofeDataTable.Count > 0 Then
                GTOKEN = ticketaccesofeDataTable.Rows(0).Item("token")
                GSIGN = ticketaccesofeDataTable.Rows(0).Item("sign")
                StrError.CodError = 1
                StrError.MsgError = "Ultimo Ticket Vigente"
                Return StrError
            End If
        Catch ex As Exception
            StrError.CodError = 66
            StrError.MsgError = ID_FNC + "***Error GENERANDO el LoginTicketRequest : " + ex.Message + ex.StackTrace
            Return StrError
        End Try

        '---------------------
        ' PASO 1: Genero el Login Ticket Request
        '---------------------
        Try
            _globalUniqueID += 1

            XmlLoginTicketRequest = New XmlDocument()
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate)

            xmlNodoUniqueId = XmlLoginTicketRequest.SelectSingleNode("//uniqueId")
            xmlNodoGenerationTime = XmlLoginTicketRequest.SelectSingleNode("//generationTime")
            xmlNodoExpirationTime = XmlLoginTicketRequest.SelectSingleNode("//expirationTime")
            xmlNodoService = XmlLoginTicketRequest.SelectSingleNode("//service")
            xmlNodoGenerationTime.InnerText = DateTime.Now.AddMinutes(-1).ToString("s")
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+60).ToString("s")
            xmlNodoUniqueId.InnerText = CStr(_globalUniqueID)
            xmlNodoService.InnerText = argServicio
            'Me.Service = argServicio

            'If Me._verboseMode Then
            Console.WriteLine(XmlLoginTicketRequest.OuterXml)
            'End If

        Catch excepcionAlGenerarLoginTicketRequest As Exception
            StrError.CodError = 66
            StrError.MsgError = ID_FNC + "***Error GENERANDO el LoginTicketRequest : " + excepcionAlGenerarLoginTicketRequest.Message + excepcionAlGenerarLoginTicketRequest.StackTrace
            Return StrError
        End Try
        '---------------------
        ' PASO 2: Firmo el Login Ticket Request
        '---------------------
        Try
            'If Me._verboseMode Then
            'Console.WriteLine(ID_FNC + "***Leyendo certificado: {0}", RutaDelCertificadoFirmante)
            'End If

            Dim certFirmante As X509Certificate2 = CertificadosX509Lib.ObtieneCertificadoDesdeArchivo(RutaDelCertificadoFirmante, argPassword)

            'If Me._verboseMode Then
            'Console.WriteLine(ID_FNC + "***Firmando: ")
            'Console.WriteLine(XmlLoginTicketRequest.OuterXml)
            'End If

            ' Convierto el login ticket request a bytes, firmo el msg y convierto a Base64
            Dim EncodedMsg As Encoding = Encoding.UTF8
            Dim msgBytes As Byte() = EncodedMsg.GetBytes(XmlLoginTicketRequest.OuterXml)
            Dim encodedSignedCms As Byte() = CertificadosX509Lib.FirmaBytesMensaje(msgBytes, certFirmante)
            cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms)

        Catch excepcionAlFirmar As Exception
            StrError.CodError = 66
            StrError.MsgError = ID_FNC + "***Error FIRMANDO el LoginTicketRequest: " + excepcionAlFirmar.Message
            Return StrError
        End Try

        ' PASO 3: Invoco al WSAA para obtener el Login Ticket Response

        Dim Request As WSAA.loginCmsRequest
        Request = New WSAA.loginCmsRequest()
        Dim Response As WSAA.loginCmsResponse
        Response = New WSAA.loginCmsResponse()

        Try
            Dim WSAA As New WSAA.LoginCMSClient
            '***************    CAMBIO DIRECCION DE WEBSERVICES **********************
            WSAA.Endpoint.Address = New EndpointAddress(GWSAADireccion)
            '*************************************
            Console.WriteLine(cmsFirmadoBase64)
            'Cursor = Cursors.WaitCursor
            Request.in0 = cmsFirmadoBase64
            Response = WSAA.WSAA_LoginCMS_loginCms(Request)
            'Cursor = Cursors.Default

            Console.WriteLine(ID_FNC + "***LoguinTicketResponse: ")
            Console.WriteLine(loginTicketResponse)
        Catch excepcionAlInvocarWsaa As Exception
            'Throw New Exception(ID_FNC + "***Error INVOCANDO al servicio WSAA: " + excepcionAlInvocarWsaa.Message)
            If excepcionAlInvocarWsaa.Message = "El CEE ya posee un TA valido para el acceso al WSN solicitado" Then
                Dim TicketAccesoFETableAdapter As New comercialDataSetTableAdapters.ticketaccesofeTableAdapter()
                Dim ticketaccesofeDataTable As New comercialDataSet.ticketaccesofeDataTable
                TicketAccesoFETableAdapter.FillByLastTicket(ticketaccesofeDataTable)
                GTOKEN = ticketaccesofeDataTable.Rows(0).Item("token")
                GSIGN = ticketaccesofeDataTable.Rows(0).Item("sign")
                StrError.CodError = 0
                StrError.MsgError = "Ultimo Ticket Vigente"
                Return StrError
            Else
                StrError.CodError = 66
                StrError.MsgError = ID_FNC + "***Error INVOCANDO al servicio WSAA: " + excepcionAlInvocarWsaa.Message
                Return StrError
            End If
        End Try

        ' PASO 4: Analizo el Login Ticket Response recibido del WSAA
        loginTicketResponse = Response.loginCmsReturn
        Try
            XmlLoginTicketResponse = New XmlDocument()
            XmlLoginTicketResponse.LoadXml(loginTicketResponse)
            Source = XmlLoginTicketResponse.SelectSingleNode("//source").InnerText
            UniqueId = UInt32.Parse(XmlLoginTicketResponse.SelectSingleNode("//uniqueId").InnerText)
            GenerationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText)
            ExpirationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText)
            Sign = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText
            Token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText
            GTOKEN = Token
            GSIGN = Sign
            '*******************************
            Dim ticketaccesofetableadapter As comercialDataSetTableAdapters.ticketaccesofeTableAdapter
            ticketaccesofetableadapter = New comercialDataSetTableAdapters.ticketaccesofeTableAdapter()
            Try
                ticketaccesofetableadapter.ticketaccesofe_insertar(Today, Source, UniqueId, GenerationTime, ExpirationTime, Token, Sign)
            Catch ex As Exception
            End Try
            '*******************************
        Catch excepcionAlAnalizarLoginTicketResponse As Exception
            StrError.CodError = 66
            StrError.MsgError = ID_FNC + "***Error ANALIZANDO el LoginTicketResponse: " + excepcionAlAnalizarLoginTicketResponse.Message
            Return StrError
        End Try

        StrError.CodError = 0
        StrError.MsgError = "Ticket Generado exitosamente"
        Return StrError

    End Function

    Public Sub ErrFEHandle(ByVal Err As WSFEV1.Err)
        MsgBox("Code: " + Err.Code.ToString + " Msg: " + Err.Msg, MsgBoxStyle.Exclamation, "WS Error")
    End Sub
    Public Sub UltimoCbte(ByVal PtoVta As Integer, ByVal Tipo As Integer, ByRef CbteNro As Long, ByRef Err As WSFEV1.Err)
        Dim auth As WSFEV1.FEAuthRequest
        auth = New WSFEV1.FEAuthRequest()
        If GTOKEN = Nothing Or GSIGN = Nothing Then
            'MsgBox("Generar Ticket de Acceso", MsgBoxStyle.Exclamation, "Advertencia")
            Err = New WSFEV1.Err()
            Err.Code = 404
            Err.Msg = "Primero debe Generar Ticket de Acceso"
            Return
        End If
        auth.Token = GTOKEN
        auth.Sign = GSIGN
        auth.Cuit = GCUIT
        '--------------------------------------
        Err = New WSFEV1.Err()
        '--------------------------------------
        Dim wsfev1 As WSFEV1.ServiceSoapClient
        wsfev1 = New WSFEV1.ServiceSoapClient()
        wsfev1.Endpoint.Address = New EndpointAddress(GWSFEV1Direccion)
        '--------------------------------------
        Dim response As WSFEV1.FERecuperaLastCbteResponse
        response = New WSFEV1.FERecuperaLastCbteResponse()

        ReDim response.Errors(0)
        response.Errors(0) = Err

        '--------------------------------------
        Try
            response = wsfev1.FECompUltimoAutorizado(auth, PtoVta, Tipo)
            If Not response.Errors Is Nothing Then
                Err = response.Errors(0)
            End If
        Catch ex As Exception
            MsgBox("Ocurrio una excepción al ejecutar WS: " + ex.Message)
        End Try
        '--------------------------------------
        If Err.Code = 0 Then
            CbteNro = response.CbteNro.ToString
        Else
            Err = response.Errors(0)
        End If
    End Sub
    Public Sub FECAESolicitar(ByVal FECabRequest As WSFEV1.FECAECabRequest, ByVal FECAEDetRequest As WSFEV1.FECAEDetRequest, ByRef FeCAEResponse As WSFEV1.FECAEResponse, ByRef Err As WSFEV1.Err)
        '***************    CREO y CAMBIO DIRECCION DE WEBSERVICES **********************
        Dim WSFEV1 As New WSFEV1.ServiceSoapClient
        WSFEV1.Endpoint.Address = New EndpointAddress(GWSFEV1Direccion)
        '*************************************
        Dim auth As WSFEV1.FEAuthRequest
        auth = New WSFEV1.FEAuthRequest()
        auth.Token = GTOKEN
        auth.Sign = GSIGN
        auth.Cuit = GCUIT
        '--------------------------------------
        Dim Obs As WSFEV1.Obs()
        Err = New WSFEV1.Err()
        '--------------------------------------
        '--------------------------------------
        Dim FeCAEReq As WSFEV1.FECAERequest
        FeCAEReq = New WSFEV1.FECAERequest()
        '-----------------------------------------
        FeCAEResponse = New WSFEV1.FECAEResponse()
        '--------------------------------------
        '--------------------------------------
        '--- AGREGAR CABECERA
        FeCAEReq.FeCabReq = FECabRequest
        '--- AGREGAR DETALLE
        ReDim FeCAEReq.FeDetReq(0)
        FeCAEReq.FeDetReq(0) = FECAEDetRequest

        Try
            FeCAEResponse = WSFEV1.FECAESolicitar(auth, FeCAEReq)
            If Not FeCAEResponse.Errors Is Nothing Then
                Dim ERRORES As RichTextBox
                ERRORES = New RichTextBox
                ERRORES.Text = ""
                For i = 0 To FeCAEResponse.Errors.Length - 1
                    ERRORES.Text = ERRORES.Text + FeCAEResponse.Errors(i).Code.ToString + " - " + FeCAEResponse.Errors(i).Msg.ToString + vbCr
                Next
                MsgBox(ERRORES.Text, MsgBoxStyle.Exclamation, "Hay errores la Cabecera del Cbte - Estado de solicitud: " + FeCAEResponse.FeDetResp(0).Resultado.ToString)
                Return
            End If
            If Not FeCAEResponse.FeDetResp Is Nothing Then
                If Not FeCAEResponse.FeDetResp(0).Observaciones Is Nothing Then
                    ReDim Obs(FeCAEResponse.FeDetResp(0).Observaciones.Length)
                    Obs = FeCAEResponse.FeDetResp(0).Observaciones
                    Dim observaciones As RichTextBox
                    observaciones = New RichTextBox
                    observaciones.Text = ""

                    For i = 0 To Obs.Length - 1
                        observaciones.Text = observaciones.Text + Obs(i).Code.ToString + " - " + Obs(i).Msg.ToString + vbCr
                    Next
                    MsgBox(observaciones.Text, MsgBoxStyle.Exclamation, "Hay errores en el Detalle del Cbte - Estado de solicitud: " + FeCAEResponse.FeDetResp(0).Resultado.ToString)
                    Return
                End If
            Else
                '----------- EL RESULTADO ES DEVUELTO COMO PARAMETRO A MENOS QUE OCURRA UNA EXCEPCIÓN
            End If
        Catch ex As Exception
            MsgBox("Ocurrio una excepción al ejecutar WS: " + ex.Message)
        End Try

    End Sub
    '**********************************************************************************************************************
    Public Function FECAELoadRequest(ByVal idventa As Long, ByRef FECAERequest As WSFEV1.FECAERequest) As StrError
        Dim StrError As New StrError
        Try
            Dim CbtNro As Long
            Dim Err1 As New WSFEV1.Err
            Dim Err2 As New WSFEV1.Err
            ' ----- RECUPERO LOS DATOS DE LA VENTA ------
            Dim LibroVentasTableAdapter As New comercialDataSetTableAdapters.libroventasTableAdapter()
            Dim libroventasDataTable As New comercialDataSet.libroventasDataTable
            LibroVentasTableAdapter.FillByIdventa(libroventasDataTable, idventa)
            ' ********************* COMIENZA LA ASIGNACIÓN DE PARAMETROS *********************
            '------------ CABECERA --------------------------
            Dim FECabRequest As New WSFEV1.FECAECabRequest()
            '---------------------------------------------
            FECabRequest.CantReg = 1
            FECabRequest.CbteTipo = GCbteTipo
            FECabRequest.PtoVta = GPtoVta
            FECabRequest.CbteTipo = libroventasDataTable.Rows(0).Item("idtipocomprobanteafip")
            '------------ DETALLE --------------------------
            Dim FeDetReq As New WSFEV1.FECAEDetRequest()
            '---------------------------------------------
            FeDetReq.Concepto = libroventasDataTable.Rows(0).Item("idconcepto") '------   si ES PRODUCTO , SERVICIO O AMBOS
            If IsDBNull(libroventasDataTable.Rows(0).Item("doctipo")) Then
                StrError.CodError = 1
                StrError.MsgError = "Tipo de documento INVÁLIDO"
                Return StrError
            Else
                FeDetReq.DocTipo = libroventasDataTable.Rows(0).Item("doctipo") '------ dni 96 O cuit 80
            End If
            '---------------------------------------------
            If IsDBNull(libroventasDataTable.Rows(0).Item("cuit")) Then
                StrError.CodError = 1
                StrError.MsgError = "Documento INVÁLIDO"
                Return StrError
            Else
                FeDetReq.DocNro = libroventasDataTable.Rows(0).Item("cuit") '------ cuit DEL CLIENTE
            End If

            UltimoCbte(GPtoVta, FECabRequest.CbteTipo, CbtNro, Err1)
            If Err1.Code > 0 Then
                ErrFEHandle(Err1)
                StrError.CodError = 1
                StrError.MsgError = "No se pudo obtener el último Número de comprobante"
                Return StrError
            Else
                CbtNro = CbtNro + 1
            End If
            FeDetReq.CbteDesde = CbtNro
            FeDetReq.CbteHasta = CbtNro
            Dim mydate As String
            mydate = DateTime.Now.ToString("yyyyMMdd")
            FeDetReq.CbteFch = mydate
            If FeDetReq.Concepto Then
                mydate = Nothing
            End If
            FeDetReq.FchServDesde = mydate 'opcional - (vacio) para concepto 1
            FeDetReq.FchServHasta = mydate 'opcional - (vacio) para concepto 1
            FeDetReq.FchVtoPago = mydate
            '---------- IMPORTES -------
            FeDetReq.ImpTotal = libroventasDataTable.Rows(0).Item("importe")
            '--Importe total del comprobante, Debe ser igual a:
            'Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.
            FeDetReq.ImpTotConc = libroventasDataTable.Rows(0).Item("ImpTotConc")
            ' -- Importe neto no gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. No puede ser mayor 
            'al Importe total de la operación ni menor a cero (0). Para comprobantes tipo C debe ser igual a cero (0). 
            'Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo corresponde al importe subtotal.
            FeDetReq.ImpNeto = libroventasDataTable.Rows(0).Item("ImpNeto")
            '--- Importe neto gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. 
            'Para comprobantes tipo C este campo corresponde al Importe del Sub Total. 
            'Para comprobantes tipo Bienes Usados – Emisor Monotributista no debe informarse o debe ser igual a cero (0).
            'si es mayor a cero debe informarse el objeto IVA
            If FeDetReq.ImpNeto > 0 Then
                Dim index As Integer = 0
                If libroventasDataTable.Rows(0).Item("IVA_27") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 6
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_27")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_27")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                    index = index + 1
                End If
                If libroventasDataTable.Rows(0).Item("IVA_21") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 5
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_21")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_21")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                    index = index + 1
                End If
                If libroventasDataTable.Rows(0).Item("IVA_10") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 4
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_10")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_10")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                    index = index + 1
                End If
                If libroventasDataTable.Rows(0).Item("IVA_5") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 8
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_5")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_5")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                    index = index + 1
                End If
                If libroventasDataTable.Rows(0).Item("IVA_2") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 9
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_2")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_2")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                End If
                If libroventasDataTable.Rows(0).Item("BASEIVA_0") > 0 Then
                    Dim ObjIVA As New WSFEV1.AlicIva()
                    ObjIVA.Id = 3
                    ObjIVA.Importe = libroventasDataTable.Rows(0).Item("IVA_0")
                    ObjIVA.BaseImp = libroventasDataTable.Rows(0).Item("BASEIVA_0")
                    ReDim Preserve FeDetReq.Iva(index)
                    FeDetReq.Iva(index) = ObjIVA
                End If
            End If
            FeDetReq.ImpOpEx = libroventasDataTable.Rows(0).Item("ImpOpEx")
            '--- Importe exento. Debe ser menor o igual a Importe total y no puede ser menor a cero. 
            'Para comprobantes tipo C debe ser igual a cero (0). Para comprobantes tipo Bienes Usados – 
            'Emisor Monotributista no debe informarse o debe ser igual a cero (0).
            FeDetReq.ImpTrib = libroventasDataTable.Rows(0).Item("ImpTrib") '' Suma de los importes del array de tributos
            FeDetReq.ImpIVA = libroventasDataTable.Rows(0).Item("ImpIVA") '-- Suma de los importes del array de IVA. 
            'Para comprobantes tipo C debe ser igual a cero (0). Para comprobantes tipo Bienes Usados – 
            'Emisor  Monotributista no debe informarse o debe ser igual a cero (0).
            FeDetReq.MonId = libroventasDataTable.Rows(0).Item("MonId") 'opcional
            FeDetReq.MonCotiz = libroventasDataTable.Rows(0).Item("MonCotiz") 'opcional
            '--------- Inicializar RESPUESTA ---------------------------------------------------------------
            Dim FeCAEResponse As New WSFEV1.FECAEResponse()
            '--------- SOLICITAR CAE ---------------------------------------------------------------
            FECAESolicitar(FECabRequest, FeDetReq, FeCAEResponse, Err2)
            '----------------------------------------------------------------
            If Not FeCAEResponse.FeDetResp Is Nothing Then
                'MsgBox(FeCAEResponse.FeDetResp(0).Resultado.ToString, MsgBoxStyle.Information, "Resultado de Solicitud")
                If FeCAEResponse.FeDetResp(0).Resultado.ToString = "A" Then
                    Dim VentasTableAdapter As New comercialDataSetTableAdapters.ventasTableAdapter()
                    VentasTableAdapter.ventas_registrarCAE(FeCAEResponse.FeCabResp.PtoVta, FeCAEResponse.FeDetResp(0).CbteDesde, FeCAEResponse.FeDetResp(0).CAE, FeCAEResponse.FeDetResp(0).CAEFchVto, idventa)
                    MsgBox("CAE Registrado exitosamente!", MsgBoxStyle.Information, "Resultado de Solicitud")
                    StrError.CodError = 0
                    StrError.MsgError = "Operación Realizada Exitosamente"
                    Return StrError
                Else
                    StrError.CodError = 1
                    StrError.MsgError = "NO se registró la Factura Electrónica, intente nuevamente más tarde desde la pantalla de -Comprobantes Emitidos-"
                    Return StrError
                End If
            Else
                StrError.CodError = 1
                StrError.MsgError = "NO se registró la Factura Electrónica, intente nuevamente más tarde desde la pantalla de -Comprobantes Emitidos-"
                Return StrError
            End If
        Catch ex As Exception
            StrError.CodError = 2
            StrError.MsgError = ex.Message
            Return StrError
        End Try
    End Function
    Class CertificadosX509Lib

        Public Shared VerboseMode As Boolean = False

        ''' <summary>
        ''' Firma mensaje
        ''' </summary>
        ''' <param name="argBytesMsg">Bytes del mensaje</param>
        ''' <param name="argCertFirmante">Certificado usado para firmar</param>
        ''' <returns>Bytes del mensaje firmado</returns>
        ''' <remarks></remarks>
        Public Shared Function FirmaBytesMensaje(
        ByVal argBytesMsg As Byte(),
        ByVal argCertFirmante As X509Certificate2
        ) As Byte()
            Const ID_FNC As String = "[FirmaBytesMensaje]"
            Try
                ' Pongo el mensaje en un objeto ContentInfo (requerido para construir el obj SignedCms)
                Dim infoContenido As New ContentInfo(argBytesMsg)
                Dim cmsFirmado As New SignedCms(infoContenido)

                ' Creo objeto CmsSigner que tiene las caracteristicas del firmante
                Dim cmsFirmante As New CmsSigner(argCertFirmante)
                cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly

                If VerboseMode Then
                    Console.WriteLine(ID_FNC + "***Firmando bytes del mensaje...")
                End If

                ' Firmo el mensaje PKCS #7
                cmsFirmado.ComputeSignature(cmsFirmante)

                If VerboseMode Then
                    Console.WriteLine(ID_FNC + "***OK mensaje firmado")
                End If

                ' Encodeo el mensaje PKCS #7.
                Return cmsFirmado.Encode()
            Catch excepcionAlFirmar As Exception
                Throw New Exception(ID_FNC + "***Error al firmar: " & excepcionAlFirmar.Message)
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Lee certificado de disco
        ''' </summary>
        ''' <param name="argArchivo">Ruta del certificado a leer</param>
        ''' <param name="argPassword">Password del certificado</param>
        ''' <returns>Un objeto certificado X509</returns>
        ''' <remarks></remarks>
        Public Shared Function ObtieneCertificadoDesdeArchivo(
        ByVal argArchivo As String,
        ByVal argPassword As SecureString
        ) As X509Certificate2
            Const ID_FNC As String = "[ObtieneCertificadoDesdeArchivo]"
            Dim objCert As New X509Certificate2
            Try
                'If argPassword.IsReadOnly Then
                '    objCert.Import(File.ReadAllBytes(argArchivo), argPassword, X509KeyStorageFlags.PersistKeySet)
                'Else
                objCert.Import(File.ReadAllBytes(argArchivo))
                'End If
                Return objCert
            Catch excepcionAlImportarCertificado As Exception
                Throw New Exception(ID_FNC + "***Error al leer certificado: " + excepcionAlImportarCertificado.Message)
                Return Nothing
            End Try
        End Function

    End Class
    Class StrError
        Public CodError As Integer
        Public MsgError As String
    End Class
    Public Function ValidarDatosClienteAFIP(ByVal idcliente As Long) As StrError
        Dim StrError As New StrError
        Dim ListaClientesTableAdapter As New comercialDataSetTableAdapters.listaclientesTableAdapter
        Dim ListaClientesDataTable As New comercialDataSet.listaclientesDataTable
        ListaClientesTableAdapter.FillByIdCliente(ListaClientesDataTable, idcliente)
        '-----------------------------------------------------------------------------
        If ListaClientesDataTable.Count <> 1 Then
            StrError.CodError = 2
            StrError.MsgError = "Cliente inválido"
            Return StrError
        End If
        '-----------------------------------------------------------------------------
        If IsDBNull(ListaClientesDataTable.Rows(0).Item("doctipoafip")) Then
            StrError.CodError = 2
            StrError.MsgError = "Debe indicar el tipo de documento"
            Return StrError
        End If
        '-----------------------------------------------------------------------------
        If IsDBNull(ListaClientesDataTable.Rows(0).Item("docnro")) Then
            StrError.CodError = 2
            StrError.MsgError = "Debe indicar el número de documento"
            Return StrError
        End If
        '-----------------------------------------------------------------------------
        If ListaClientesDataTable.Rows(0).Item("docnro") = "" Then
            StrError.CodError = 2
            StrError.MsgError = "Debe indicar el número de documento"
            Return StrError
        End If
        '-----------------------------------------------------------------------------
        StrError.CodError = 1
        StrError.MsgError = "OK"
        Return StrError
    End Function
End Module

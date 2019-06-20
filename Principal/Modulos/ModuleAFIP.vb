Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Net
Imports System.Security
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.Runtime.InteropServices
Module ModuleAFIP
    Public ID_FNC As String = "[ObtenerLoginTicketResponse]"
    '-------------- PARAMETROS DEL WSAA -----------------------------------------
    Public Gsrccn As String
    Public Gdscn As String
    Public Gidtra As String
    Public Ggtime As String
    Public Gxtime As String
    '****************************************************************************
    Public argPassword As SecureString = Nothing
    Public UniqueId As UInt32 ' Entero de 32 bits sin signo que identifica el requerimiento
    Public GenerationTime As DateTime ' Momento en que fue generado el requerimiento
    Public ExpirationTime As DateTime ' Momento en el que expira la solicitud
    Public Service As String ' Identificacion del WSN para el cual se solicita el TA
    Public Sign As String ' Firma de seguridad recibida en la respuesta
    Public Token As String ' Token de seguridad recibido en la respuesta
    Public XmlLoginTicketRequest As XmlDocument = Nothing
    Public XmlLoginTicketResponse As XmlDocument = Nothing
    Public RutaDelCertificadoFirmante As String = "C:/OpenSSL/bin/certificado.pfx"
    Public XmlStrLoginTicketRequestTemplate As String = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>"
    Public _globalUniqueID As UInt32 = 0 ' OJO! NO ES THREAD-SAFE
    Public argServicio As String = "wsfe"
    '------------------
    Public GTOKEN As String = ""
    Public GSIGN As String = ""
    Public GCUIT = 20337670114
    Public GPtoVta = 2
    Public GMonid As String
    Public GMonCotiz As Decimal
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

    Public Sub GenTRA(ByRef loginTicketResponse As String)
        '---------------------
        Dim cmsFirmadoBase64 As String
        'Dim loginTicketResponse As String = Nothing
        Dim xmlNodoUniqueId As XmlNode
        Dim xmlNodoGenerationTime As XmlNode
        Dim xmlNodoExpirationTime As XmlNode
        Dim xmlNodoService As XmlNode
        Dim argRutaCertX509Firmante As String = Nothing
        '---------------------
        ' PASO 1: Genero el Login Ticket Request
        Try
            _globalUniqueID += 1

            XmlLoginTicketRequest = New XmlDocument()
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate)

            xmlNodoUniqueId = XmlLoginTicketRequest.SelectSingleNode("//uniqueId")
            xmlNodoGenerationTime = XmlLoginTicketRequest.SelectSingleNode("//generationTime")
            xmlNodoExpirationTime = XmlLoginTicketRequest.SelectSingleNode("//expirationTime")
            xmlNodoService = XmlLoginTicketRequest.SelectSingleNode("//service")
            xmlNodoGenerationTime.InnerText = DateTime.Now.AddMinutes(-2).ToString("s")
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+2).ToString("s")
            xmlNodoUniqueId.InnerText = CStr(_globalUniqueID)
            xmlNodoService.InnerText = argServicio
            'Me.Service = argServicio

            'If Me._verboseMode Then
            Console.WriteLine(XmlLoginTicketRequest.OuterXml)
            'End If

        Catch excepcionAlGenerarLoginTicketRequest As Exception
            Throw New Exception(ID_FNC + "***Error GENERANDO el LoginTicketRequest : " + excepcionAlGenerarLoginTicketRequest.Message + excepcionAlGenerarLoginTicketRequest.StackTrace)
        End Try

        ' PASO 2: Firmo el Login Ticket Request
        Try
            'If Me._verboseMode Then
            Console.WriteLine(ID_FNC + "***Leyendo certificado: {0}", RutaDelCertificadoFirmante)
            'End If

            Dim certFirmante As X509Certificate2 = CertificadosX509Lib.ObtieneCertificadoDesdeArchivo(RutaDelCertificadoFirmante, argPassword)

            'If Me._verboseMode Then
            Console.WriteLine(ID_FNC + "***Firmando: ")
            Console.WriteLine(XmlLoginTicketRequest.OuterXml)
            'End If

            ' Convierto el login ticket request a bytes, firmo el msg y convierto a Base64
            Dim EncodedMsg As Encoding = Encoding.UTF8
            Dim msgBytes As Byte() = EncodedMsg.GetBytes(XmlLoginTicketRequest.OuterXml)
            Dim encodedSignedCms As Byte() = CertificadosX509Lib.FirmaBytesMensaje(msgBytes, certFirmante)
            cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms)

        Catch excepcionAlFirmar As Exception
            Throw New Exception(ID_FNC + "***Error FIRMANDO el LoginTicketRequest: " + excepcionAlFirmar.Message)
        End Try

        ' PASO 3: Invoco al WSAA para obtener el Login Ticket Response
        Dim wsaa As WSAA.LoginCMSClient
        wsaa = New WSAA.LoginCMSClient()
        Dim Request As WSAA.loginCmsRequest
        Request = New WSAA.loginCmsRequest()
        Dim Response As WSAA.loginCmsResponse
        Response = New WSAA.loginCmsResponse()
        Try
            Console.WriteLine(cmsFirmadoBase64)
            'Cursor = Cursors.WaitCursor
            Request.in0 = cmsFirmadoBase64
            Response = wsaa.WSAA_LoginCMS_loginCms(Request)
            'Cursor = Cursors.Default

            Console.WriteLine(ID_FNC + "***LoguinTicketResponse: ")
            Console.WriteLine(loginTicketResponse)
        Catch excepcionAlInvocarWsaa As Exception
            Throw New Exception(ID_FNC + "***Error INVOCANDO al servicio WSAA: " + excepcionAlInvocarWsaa.Message)
            Return
        End Try

        ' PASO 4: Analizo el Login Ticket Response recibido del WSAA
        loginTicketResponse = Response.loginCmsReturn
        Try
            XmlLoginTicketResponse = New XmlDocument()
            XmlLoginTicketResponse.LoadXml(loginTicketResponse)

            UniqueId = UInt32.Parse(XmlLoginTicketResponse.SelectSingleNode("//uniqueId").InnerText)
            GenerationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText)
            ExpirationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText)
            Sign = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText
            Token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText
            GTOKEN = Token
            GSIGN = Sign

        Catch excepcionAlAnalizarLoginTicketResponse As Exception
            Throw New Exception(ID_FNC + "***Error ANALIZANDO el LoginTicketResponse: " + excepcionAlAnalizarLoginTicketResponse.Message)
            Return
        End Try

        'Return loginTicketResponse

    End Sub

    Public Sub ErrFEHandle(ByVal Err As wsfev1.Err)
        MsgBox("Code: " + Err.Code.ToString + " Msg: " + Err.Msg, MsgBoxStyle.Exclamation, "WS Error")
    End Sub
    Public Sub UltimoCbte(ByVal PtoVta As Integer, ByVal Tipo As Integer, ByRef CbteNro As Long, ByRef Err As wsfev1.Err)
        Dim auth As wsfev1.FEAuthRequest
        auth = New wsfev1.FEAuthRequest()
        If GTOKEN = Nothing Or GSIGN = Nothing Then
            'MsgBox("Generar Ticket de Acceso", MsgBoxStyle.Exclamation, "Advertencia")
            Err = New wsfev1.Err()
            Err.Code = 404
            Err.Msg = "Generar Ticket de Acceso"
            Return
        End If
        auth.Token = GTOKEN
        auth.Sign = GSIGN
        auth.Cuit = GCUIT
        '--------------------------------------
        Err = New wsfev1.Err()
        '--------------------------------------
        Dim wsfev1 As wsfev1.ServiceSoapClient
        wsfev1 = New wsfev1.ServiceSoapClient()
        '--------------------------------------
        Dim response As wsfev1.FERecuperaLastCbteResponse
        response = New wsfev1.FERecuperaLastCbteResponse()

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
    Public Sub FECASolicitar(ByVal FECabRequest As wsfev1.FECAECabRequest, ByVal FECAEDetRequest As wsfev1.FECAEDetRequest, ByRef FeCAEResponse As wsfev1.FECAEResponse, ByRef Err As wsfev1.Err)
        Dim auth As wsfev1.FEAuthRequest
        auth = New wsfev1.FEAuthRequest()
        auth.Token = GTOKEN
        auth.Sign = GSIGN
        auth.Cuit = GCUIT
        '--------------------------------------
        Dim Obs As wsfev1.Obs()
        'Obs = New wsfev1.Obs(10)
        Err = New wsfev1.Err()
        '--------------------------------------
        Dim wsfev1 As wsfev1.ServiceSoapClient
        wsfev1 = New wsfev1.ServiceSoapClient()
        '--------------------------------------
        Dim FeCAEReq As wsfev1.FECAERequest
        FeCAEReq = New wsfev1.FECAERequest()
        '-----------------------------------------
        FeCAEResponse = New wsfev1.FECAEResponse()
        '--------------------------------------
        '--------------------------------------
        '--- AGREGAR CABECERA
        FeCAEReq.FeCabReq = FECabRequest
        '--- AGREGAR DETALLE
        ReDim FeCAEReq.FeDetReq(0)
        FeCAEReq.FeDetReq(0) = FECAEDetRequest

        Try
            FeCAEResponse = wsfev1.FECAESolicitar(auth, FeCAEReq)
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
End Module

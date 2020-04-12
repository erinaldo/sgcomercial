Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System.Security
Imports System.ComponentModel
Imports System.Text
Imports System.Management
'*********
Imports System.IO
Imports System.Net
Imports System.Net.WebRequest
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

'Imports System.IO.Compression

Module SGCModule
    Dim xi As LoadingForm
    Public gIsOnline As Boolean
    '************************************************
    Public gActiveSQLConnectionString As String
    Public gstrSheetName As New List(Of String)
    Public gstrSheetSelected As String
    '************************************************
    'Public StrSysCurrentVersion As String
    'Public SysCurrentVersion As Long
    Public gSystemDrive As String
    Public GHDSN As String
    Public GMBSN As String
    Public EmailTo As String
    Public gModPVV As String = Nothing
    Public gReloadPermisos As Boolean = False
    Public gDownloadProgress As Long
    Public SoftwareVersion As String
    Public PermisoVtaCC As Long
    Public gValidarSTK As String
    Public gbalprefix As String
    Public glistapreferida As Int16
    Public glocalidadseleccionada As Int64
    Public gprovinciaseleccionada As Int64
    Public gFechaSeleccionada As DateTime
    Public gpagocombinadoconfirmado As Boolean
    Public gModuloCloud As Long
    Public gModuloPedidosWeb As Long
    Public gModuloPedidosMovil As Long
    Public gMiFranquicia As Long
    Public gProgressBarCounter As Long
    Public gUserToken As String
    Public gSUToken As Boolean
    Public gPresupuestoFechaVigencia As Date
    Public SmtpClient As String
    Public EmailFrom As String
    Public EmailFromPwd As String
    Public EmailPort As Integer
    Public gNombreComercio As String
    Public gPublicDocumentsPath As String
    Public WaitingLicence As Boolean
    Public gFormatoCierreCaja As String
    '************************************************
    Public FormPrincipal As Principal
    '************************************************
    Public gNombreCliente As String
    Public gNombreTerminal As String
    Public gMiSucursal As Integer = 0
    Public gSucursalSeleccionada As Integer = 0
    Public gMiIDCliente As Integer = 0
    Public gTrlsPDSAC As Integer
    Public gmacadress As String
    Public gTerminal As Long
    Public gAutoUpdater As Long
    Public guserid As Integer
    Public gUsuarioSeleccionado As Long
    Public guserprofile As String
    Public gusername As String
    Public gnombremodulo As String
    Public gReporteSeleccionado As String
    Public gTipoCbtSeleccionado As Long
    '**************************************************
    Public gmontoapagar As Decimal
    Public gmontoinicial As Decimal
    Public gidevento As Long
    Public gideventoseleccionado As Long
    Public gidcaja As Integer
    '*************variables de arqueo de caja*******************************
    Public gmontofinal As Decimal
    Public gtotaldebitos As Decimal
    Public gtotalcreditos As Decimal
    Public gtotaltransferencias As Decimal
    Public gtotalcheques As Decimal
    Public gtotaldepositos As Decimal
    Public gtotaldepositosef As Decimal
    Public gtotalgastos As Decimal
    Public gtotalextracciones As Decimal
    Public gtotaldevolucionefectivo As Decimal
    Public gefectivoencaja As Decimal
    '********************************************
    Public gmontototal As Decimal
    Public gclienteseleccionado As Long
    Public galumnoseleccionado As Long
    Public gservicioseleccionado As Long
    Public gdomicilioseleccionado As Long
    Public gclientesserviciosseleccionado As Long
    Public ggradoseleccionado As Long
    Public gmontovale As Decimal
    Public gidpresupuesto As Long
    '************************************
    Public gcantidad As Decimal
    Public glistaprecio As Integer
    Public gcodigoproducto As String
    Public gidproducto As Long
    Public gproductodescripcion As String
    Public gprecioventa As String
    Public gpreciocalculado As String
    Public gpreciocosto As String
    Public gprecioventagranel As String
    Public gprecioventamayorista As String
    Public grecargoTC As Decimal
    Public grecargoCC As Decimal
    Public gidpago As Long
    Public gidcliente As Long
    Public gidCriterioSeleccionado As Long
    Public gCantidadDesde As Decimal
    Public gCantidadHasta As Decimal
    Public gPorcentaje As Decimal
    '************************************
    Public gidoperacion As Long
    Public gidventa As Long
    '*********************
    Public gdescuentopc As Decimal
    Public gdescuentoef As Decimal
    '*********************
    Public gidproveedor As Long
    Public gidpedido As Long
    '*****************************
    Public gidpedidodelivery As Long
    Public gidlote As Long
    Public gfechaaentregar As Date
    '*****************************
    Public gidremito As Long
    '**************************
    Public importarubro As Integer
    Public importadescripcion As Integer
    Public importastockminimo As Integer
    '**************************
    Public gFechaDesde As Date
    Public gFechaHasta As Date
    '**************************
    Public gUltimoProdBuscado As String
    Public gUltimoCodBuscado As String
    '************************************
    '**************************'**************************'**************************'**************************
    '**************************'**************************'**************************'**************************
    '*******************************    GLOBAL FUNCTIONS        *********************************
    '***************************    NormalizarCodigo    ***************************************************
    ' convierte un codigo numerico de longitud menor a 12 caracteres a un codigo de longitud 13 (digito verificador incluido)
    '*************************************************************************************************
    Public Sub NormalizarCodigo(ByVal codigointerno As String, ByRef codigonormal As String, ByRef rtn As Boolean)
        Dim ori, rev As String
        Dim i As Integer
        'MsgBox("recibido: " + Len(codigointerno).ToString)
        If Len(codigointerno) > 12 Then
            codigonormal = "La longitud del codigo a normalizar es demasiado grande"
            rtn = False
            Return
        End If

        If Len(Trim(codigointerno)) < 12 Then
            ori = Trim(codigointerno)
            rev = StrReverse(ori)
            'MsgBox(rev)
            For i = Len(Trim(codigointerno)) + 1 To 12
                If Not i = 12 Then
                    rev += "0"
                Else
                    rev += "3" ''''''''''''''''PREFIJO DE CODIGO INTERNO
                End If
            Next
            ori = StrReverse(rev)
            codigonormal = ori
            GetCodeWithVDigit(codigonormal)
            rtn = True
            'MsgBox(codigointerno + " | " + codigonormal)
            Return
        Else
            codigonormal = codigointerno
            GetCodeWithVDigit(codigonormal)
            rtn = True
            'MsgBox(codigointerno + " | " + codigonormal)
            Return
        End If
    End Sub

    '***********************************************************************************************
    '***************************    GetNormalCode128    ***************************************************
    ' extraigo de la base de datos los elementos que componen mi local code128 y los devuelvo
    Public Sub GetNormalCode128(ByVal codigointerno As String, ByRef barcode As String, ByRef strerror As StrError)
        Dim productosTableAdapter As New comercialDataSetTableAdapters.productosTableAdapter()
        Dim productosDataTable As New comercialDataSet.productosDataTable()
        productosDataTable = productosTableAdapter.GetDataByProductSheet(codigointerno)
        barcode = ""
        barcode = productosDataTable.Rows.Item(0)("codigoproducto") + "!"
        barcode += productosDataTable.Rows.Item(0)("presentacion") + "!"
        barcode += productosDataTable.Rows.Item(0)("talle")
    End Sub

    '***********************************************************************************************
    '***************************    GetEAN13    ***************************************************
    ' convierte un codigo numerico de 13 digitos en string barcode para representar en la fuente EAN13
    '*************************************************************************************************
    Public Sub GetEAN13(ByVal codigointerno As String, ByRef barcode As String, ByRef strerror As StrError)
        Dim normalized As String
        Dim rtn As Boolean
        Dim msg As String
        strerror = New StrError()

        strerror.CodError = 0
        '**** si el codigo ingresado tiene 13 digitos que pase a verificarlo... sino que lo normalice
        If Not Len(codigointerno) = 13 Then
            NormalizarCodigo(codigointerno, normalized, rtn)
            If rtn = False Then
                strerror.CodError = 1
                strerror.MsgError = "Error al normalizar el codigo EAN-13: " + codigointerno
                Return
            End If
        Else
            normalized = codigointerno
        End If
        '    '*************  verifica el codigo  *******************
        VerificarCodigo(normalized, msg, rtn)
        If rtn = False Then
            strerror.CodError = 1
            strerror.MsgError = "Error al VerificarCodigo el codigo EAN-13: " + msg
            Return
        End If
        '    '***************    todo correcto entonces que lo genere *****************
        Dim p1 As Integer = 0
        Dim p2 As Integer = 0
        Dim p3 As Integer = 0
        Dim p4 As Integer = 0
        Dim p5 As Integer = 0
        '****************************************
        Select Case Mid(normalized, 1, 1)
            Case 0
                p1 = 48
                p2 = 48
                p3 = 48
                p4 = 48
                p5 = 48
            Case 1
                p1 = 48
                p2 = 64
                p3 = 48
                p4 = 64
                p5 = 64
            Case 2
                p1 = 48
                p2 = 64
                p3 = 64
                p4 = 48
                p5 = 64
            Case 3
                p1 = 48
                p2 = 64
                p3 = 64
                p4 = 64
                p5 = 48
            Case 4
                p1 = 64
                p2 = 48
                p3 = 48
                p4 = 64
                p5 = 64
            Case 5
                p1 = 64
                p2 = 64
                p3 = 48
                p4 = 48
                p5 = 64
            Case 6
                p1 = 64
                p2 = 64
                p3 = 64
                p4 = 48
                p5 = 48
            Case 7
                p1 = 64
                p2 = 48
                p3 = 64
                p4 = 48
                p5 = 64
            Case 8
                p1 = 64
                p2 = 48
                p3 = 64
                p4 = 64
                p5 = 48
            Case 9
                p1 = 64
                p2 = 64
                p3 = 48
                p4 = 64
                p5 = 48
            Case Else
                p1 = 64
                p2 = 64
                p3 = 64
                p4 = 64
                p5 = 64

        End Select



        Try
            barcode = Convert.ToChar(Convert.ToInt16(Mid(normalized, 1, 1)) + 33)   '1
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 2, 1)) + 96)  '2
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 3, 1)) + p1)  '3 --------------
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 4, 1)) + p2)  '4 -----------------
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 5, 1)) + p3)  '5
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 6, 1)) + p4)  '6
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 7, 1)) + p5)  '7
            barcode += "|"
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 8, 1)) + 80)  '8
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 9, 1)) + 80)  '9
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 10, 1)) + 80) '10
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 11, 1)) + 80) '11
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 12, 1)) + 80) '12
            barcode += Convert.ToChar(Convert.ToInt16(Mid(normalized, 13, 1)) + 112) '13    

            strerror.CodError = 0
        Catch ex As Exception

            strerror.CodError = 1
            strerror.MsgError = "Ocurrió un error en la generación EAN-13"
        End Try
    End Sub
    '***********************************************************************************************
    '***************************    GetCodeWithVDigit    ***************************************************
    ' ingresa como parametro un codigo numerico de 12 digitos y lo devuelve con su respectivo digito verificador (length 13)
    '*************************************************************************************************
    Public Sub GetCodeWithVDigit(ByRef codigo As String)
        Dim code As String
        Dim doce As String
        Dim once As String
        Dim i As Integer
        Dim sum As Integer
        Dim mult As Integer
        Dim total As Integer
        Dim cielo As Integer
        Dim flt As Decimal
        Dim dv As Integer

        Try

            code = Mid(codigo, 1, 12)
            code = StrReverse(code)
            ' PASO 1
            doce = Mid(code, 1, 1)
            ' PASO 2
            sum = Convert.ToInt16(doce)
            For i = 3 To code.Length - 1 Step 2
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' PASO 3
            mult = sum * 3
            ' PASO 4
            once = Mid(code, 2, 1)
            ' PASO 5
            sum = Convert.ToInt16(once)
            For i = 4 To code.Length Step 2
                'MsgBox(sum.ToString + " + " + Mid(code, i, 1))
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' MsgBox(sum.ToString)
            ' PASO 6
            total = sum + mult
            ' PASO 7
            'MsgBox(total.ToString)
            flt = total / 10
            'MsgBox(flt)
            flt = Math.Ceiling(flt)
            'MsgBox(flt)
            cielo = flt * 10
            'MsgBox(cielo.ToString)
            dv = cielo - total
            codigo += dv.ToString

        Catch ex As Exception
            codigo = "0"

        End Try
    End Sub
    '***********************************************************************************************
    '***************************    VerificarCodigo    ***************************************************
    ' valida que el codigo de 13 digitos este generado correctamente 
    '*************************************************************************************************
    Public Sub VerificarCodigo(ByVal codigo As String, ByRef msg As String, ByRef rtn As Boolean)
        Dim dvrecibido As String
        dvrecibido = Mid(codigo, 13, 1)
        'MsgBox("VerificarCodigo: " + codigo + " - Codigo recibido: " + dvrecibido)
        If codigo.Length <> 13 Then
            rtn = False
            msg = "el codigo no tiene la longitud correcta"
            Return
        End If
        Try
            GetVDigit(codigo, rtn)
            If codigo = dvrecibido Then
                rtn = True
                'MsgBox("Codigo Correcto")
                Return
            Else
                'MsgBox("VerificarCodigo/GetVDigit: Codigo ERRONEO")
                rtn = False
                msg = "Dígito Calculado: " + codigo + " || Dígito Recibído: " + dvrecibido
                'MsgBox("VerificarCodigo/GetVDigit: Codigo ERRONEO " + codigo)
                Return
            End If
        Catch ex As Exception

        End Try
    End Sub
    '***********************************************************************************************
    '***************************    GetVDigit    ***************************************************
    ' ingresa como parametro un codigo numerico de 12 digitos y lo devuelve con su respectivo digito verificador (length 13)
    '*************************************************************************************************
    Public Sub GetVDigit(ByRef codigo As String, ByRef rtn As Boolean)
        Dim code As String
        Dim doce As String
        Dim once As String
        Dim i As Integer
        Dim sum As Integer
        Dim mult As Integer
        Dim total As Integer
        Dim cielo As Integer
        Dim flt As Decimal
        Dim dv As Integer

        Try

            code = Mid(codigo, 1, 12)
            code = StrReverse(code)
            ' PASO 1
            doce = Mid(code, 1, 1)
            ' PASO 2
            sum = Convert.ToInt16(doce)
            For i = 3 To code.Length - 1 Step 2
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' PASO 3
            mult = sum * 3
            ' PASO 4
            once = Mid(code, 2, 1)
            ' PASO 5
            sum = Convert.ToInt16(once)
            For i = 4 To code.Length Step 2
                'MsgBox(sum.ToString + " + " + Mid(code, i, 1))
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' MsgBox(sum.ToString)
            ' PASO 6
            total = sum + mult
            ' PASO 7
            'MsgBox(total.ToString)
            flt = total / 10
            'MsgBox(flt)
            flt = Math.Ceiling(flt)
            'MsgBox(flt)
            cielo = flt * 10
            'MsgBox(cielo.ToString)
            dv = cielo - total
            codigo = dv.ToString
            rtn = True
            Return
        Catch ex As Exception
            codigo = "No se pudo generar el digito verificador"
            rtn = False
            Return
        End Try
    End Sub
    Public Function LimpiarCodigo(ByRef codigo As String) As String
        codigo = Trim(codigo)
        codigo = codigo.Replace("'", "-")

        Return codigo
    End Function
    Public Sub validarcolumnasProdImportados(ByVal dgv1 As DataGridView, ByRef rtn As Boolean, ByRef msg As String)
        Dim columnas(100) As String
        Dim camposrequeridos(13) As String
        Dim camposfaltantes As List(Of String) = New List(Of String)
        Dim strfaltantes As String = ""
        '***************************************
        camposrequeridos(0) = "codigoproducto"
        camposrequeridos(1) = "marca"
        camposrequeridos(2) = "modelo"
        camposrequeridos(3) = "presentacion"
        camposrequeridos(4) = "unidadmedida"
        camposrequeridos(5) = "medida"
        camposrequeridos(6) = "preciocosto"
        camposrequeridos(7) = "precioventa"
        camposrequeridos(8) = "precioventagranel"
        camposrequeridos(9) = "precioventamayorista"
        camposrequeridos(10) = "precioventadistribuidor"
        camposrequeridos(11) = "idrubro"
        camposrequeridos(12) = "stockminimo"
        camposrequeridos(13) = "descripcion"
        'camposrequeridos(14) = "stock"
        'camposrequeridos(15) = "proveedor"
        'camposrequeridos(16) = "iva"
        'camposrequeridos(17) = "fabricante"
        '***************************************
        For i = 0 To dgv1.Columns.Count - 1
            columnas(i) = dgv1.Columns(i).Name
        Next
        ' verifico existencia de los campos en el listado de columnas
        For i = 0 To camposrequeridos.Count - 1
            If columnas.Contains(camposrequeridos(i)) Then
                'MsgBox("Existe: " + camposrequeridos(i))
            Else
                camposfaltantes.Add(camposrequeridos(i))
                'MsgBox("No existe: " + camposrequeridos(i))
            End If
        Next


        For i = 0 To camposfaltantes.Count - 1
            strfaltantes = strfaltantes + " -" + camposfaltantes.Item(i)
        Next
        If camposfaltantes.Count > 0 Then
            'MsgBox("No se han encontrado los siguientes campos requeridos: " + strfaltantes, MsgBoxStyle.Exclamation)
            msg = "No se han encontrado los siguientes campos requeridos: " + strfaltantes
            rtn = False
            Return
        Else
            'MsgBox("Todo correcto", MsgBoxStyle.Information)
            msg = "Todo Correcto"
            rtn = True
            Return
        End If
    End Sub
    Public Sub UpdateCheck(ByRef status As Boolean, ByRef currentversion As Long, ByRef newversion As Long)
        Cursor.Current = Cursors.WaitCursor
        If Not My.Computer.Network.IsAvailable Then
            Cursor.Current = Cursors.Default
            MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            status = False
            Return
        End If
        Dim TerminalesSCTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesSCTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim ProductosSCTableAdapter As siscomDataSetTableAdapters.productosTableAdapter
        ProductosSCTableAdapter = New siscomDataSetTableAdapters.productosTableAdapter()
        ''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            Dim scstatus As Boolean
            conectarSCConn(scstatus)
            If scstatus = True Then
                gTerminal = TerminalesSCTableAdapter.terminales_GetID(gmacadress)
                gAutoUpdater = TerminalesSCTableAdapter.terminales_autoupdater(gTerminal)
                If Not gTerminal > 0 Or gAutoUpdater = 0 Then
                    Cursor.Current = Cursors.Default
                    MsgBox("Dispositivo (" + gTerminal.ToString + ") no autorizado: Err" + gAutoUpdater.ToString, MsgBoxStyle.Exclamation, "Advertencia")
                    status = False
                    Return
                End If
            Else
                MsgBox("Verifique su conexión a internet: ", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("No se pudo validar su licencia (verifique su conexion a internet): " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End Try


        Try
            newversion = Val(ProductosSCTableAdapter.productos_consultarversionvigente("SGComercia"))
            currentversion = Val(TerminalesSCTableAdapter.terminales_consultarsgcversion(gTerminal))
            If newversion > currentversion Then
                status = True
            Else
                MsgBox("Tu versión de sistema se encuentra actualizada", MsgBoxStyle.Information)
                status = False
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            status = False
        End Try
        '''''''*******************
        If status = True Then
            Cursor.Current = Cursors.Default
            If MsgBox("Existe una nueva versión -" + newversion.ToString + "- para tu dispositivo " + gmacadress + " terminal N°: " + gTerminal.ToString + ", desea realizar la actualización ahora?", MsgBoxStyle.YesNo, "Control de Versión: " + currentversion.ToString) = MsgBoxResult.Yes Then
                '                UpdateSGC(newversion)
                UpdateSGC()
            End If
            'Else
            '    MsgBox("Tu versión de sistema se encuentra actualizada", MsgBoxStyle.Information)
            '    'status = False
        End If
        Cursor.Current = Cursors.Default
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Public Sub UpdateCheckPasivo(ByRef status As Boolean, ByRef currentversion As Long, ByRef newversion As Long)
        'Cursor.Current = Cursors.WaitCursor
        If Not My.Computer.Network.IsAvailable Then
            'Cursor.Current = Cursors.Default
            'MsgBox("No puede utilizar funciones basadas en la nube sin conexión a internet", MsgBoxStyle.Exclamation, "Advertencia")
            status = Nothing
            Return
        End If
        Dim TerminalesSCTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesSCTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim ProductosSCTableAdapter As siscomDataSetTableAdapters.productosTableAdapter
        ProductosSCTableAdapter = New siscomDataSetTableAdapters.productosTableAdapter()
        ''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            gTerminal = TerminalesSCTableAdapter.terminales_GetID(gmacadress)
            gAutoUpdater = TerminalesSCTableAdapter.terminales_autoupdater(gTerminal)
            gForceUpdateSC = TerminalesSCTableAdapter.terminales_forceupdate(gTerminal)
            If Not gTerminal > 0 Or gAutoUpdater = 0 Then
                'Cursor.Current = Cursors.Default
                'MsgBox("Dispositivo no autorizado", MsgBoxStyle.Exclamation, "Advertencia")
                status = False
                Return
            End If
        Catch ex As Exception
            'Cursor.Current = Cursors.Default
            'MsgBox("Dispositivo no autorizado", MsgBoxStyle.Exclamation, "Advertencia")
            'MsgBox("Dispositivo no autorizado: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End Try


        Try
            newversion = Val(ProductosSCTableAdapter.productos_consultarversionvigente("SGComercia"))
            'currentversion = Val(TerminalesSCTableAdapter.terminales_consultarsgcversion(gTerminal))
            If newversion > currentversion Then
                status = True
            Else
                'MsgBox("Tu versión de sistema se encuentra actualizada", MsgBoxStyle.Information)
                status = False
            End If
            'Cursor.Current = Cursors.Default
        Catch ex As Exception
            'Cursor.Current = Cursors.Default
            status = False
        End Try
        '''''''*******************        
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub


    Public Sub UpdateSGC()
        '============ ACTUALIZAR SISTEMA FTP DESCARGAR ACTUALIZACION =================
        'Cursor.Current = Cursors.WaitCursor
        'Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create("ftp://sistemascomerciales.net/"), FtpWebRequest)
        'ftpRequest.Credentials = New NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
        'ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory
        'Dim response As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)
        'Dim streamReader As New StreamReader(response.GetResponseStream())
        'Dim directories As New List(Of String)()

        ''Dim line As String = streamReader.ReadLine()
        ''While Not String.IsNullOrEmpty(line)
        ''    directories.Add(line)
        ''    line = streamReader.ReadLine()
        ''End While
        ''streamReader.Close()

        ''***************************    descargando la nueva version *************************
        'Using ftpClient As New WebClient()

        '    ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")

        '    'For i As Integer = 0 To directories.Count - 1
        '    '    'If  directories(i).Contains(".") Then
        '    '    If directories(i) <> "." And directories(i) <> ".." Then
        '    Try
        '        'FileSystem.Kill("C:\SGComercial\UpdatePack\Ejecutable\*.*")
        '        Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar" '+ directories(i).ToString()
        '        Dim trnsfrpth As String = "C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar" '+ directories(i).ToString()
        '        ftpClient.DownloadFile(path, trnsfrpth)
        '    Catch ex As Exception
        '        Cursor.Current = Cursors.Default
        '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Ocurrió un evento inesperado")
        '        Return
        '    End Try
        '*******************************************************'''''''''''''''''''''''''''''''''''''''''''''''
        '   *********************   CREANDO OBJETOS DE CONEXION SISCOMBD
        Dim TerminalesSCTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesSCTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '/*********************************************************/
        '   *********************   VALIDAR SUSCRIPCION A SOPORTE Y ACTUALIZACIONES
        '/*********************************************************/
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            gAutoUpdater = TerminalesSCTableAdapter.terminales_autoupdater(gTerminal)
            If gAutoUpdater = 0 Then
                Cursor.Current = Cursors.Default
                MsgEx("Tu suscripción a soporte y actualizaciones se encuentra vencida!")
                Return
            End If
        Catch ex As Exception
            MsgBox("No se pudo validar tu suscripción a SGComercial", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End Try

        '*******************************************************'''''''''''''''''''''''''''''''''''''''''''''''
        '   *********************   DESCOMPRIMIR LA NUEVA VERSION
        Try
            Module_unrar.UnRar(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\", gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar")
            Threading.Thread.Sleep(8000)
        Catch ex As Exception
            MsgBox("Ocurrió un error al descomprimir la actualización: " + ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''
        'Cursor.Current = Cursors.Default
        'MsgBox("La aplicación se cerrará para comenzar el proceso de instalación", MsgBoxStyle.Information, "Advertencia")
        'MsgInfoPopUp("La aplicación se cerrará para comenzar el proceso de instalación")
        CreateObject("WScript.Shell").Popup("La aplicación se cerrará para comenzar el proceso de instalación", 2, "Aviso!", vbInformation)
        '*******************************************************'''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '================= ACTUALIZAR OBJETOS DE BASE DE DATOS
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim status As Boolean
        Dim cod As Integer
        Dim msg As String = Nothing
        Try
            ActualizarBD(status, cod, msg)
        Catch ex As Exception

        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''   *********************   ACTUALIZAR NRO DE VERSION REMOTA 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Try
        '    TerminalesSCTableAdapter.terminales_updatesgcversion(newversion.ToString, gTerminal)
        '    parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("SysCurrentVersion", newversion, newversion.ToString, Nothing)
        'Catch ex As Exception
        '    MsgBox("Ocurrió un error: " + ex.Message, MsgBoxStyle.Exclamation)
        '    Return
        'End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'COMENZAR LA EJECUCION
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Process.Start(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\setup.exe")
        End
        'End Using
    End Sub
    Public Sub ActualizarBD(ByRef status As Boolean, ByRef cod As Integer, ByRef msg As String)
        ''''''''''''
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter
        '*******************************************************************************
        Dim fileReader As String
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
        'MsgBox(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand

        'fileReader = My.Computer.FileSystem.ReadAllText("C:\SGComercial\UpdatePack\Ejecutable\BD\test.txt")
        'MsgBox(fileReader)
        'Dim fileEntries As String() = Directory.GetFiles("C:\SGComercial\UpdatePack\Ejecutable\BD\", "*.txt")
        '' Process the list of .txt files found in the directory. '
        'Dim fileName As String

        Dim files() As String = IO.Directory.GetFiles(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\BD\")
        '==== SI EXISTEN ARCHIVOS ===
        If files.Count > 0 Then
            myConn2.Open() '==== ABRO LA CONEXION A BD ===
            For Each sFile As String In files
                fileReader = IO.File.ReadAllText(sFile)
                '            MsgBox(sFile)
                Try
                    mycommand = New SqlCommand(fileReader, myConn2)
                    mycommand.ExecuteNonQuery()
                    Try
                        FileSystem.Kill(sFile)
                    Catch ex2 As Exception

                    End Try
                    'MsgBox(sFile, MsgBoxStyle.Information, "Upgrade data base")
                Catch ex As Exception
                    ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Actualización de versión", "ActualizarBD", sFile + " - " + ex.Message)
                    status = False
                    cod = 1
                    msg = "Ocurrio un problema en: ActualizarBD() - " + sFile + " - " + ex.Message
                    'Exit For
                End Try
                status = True
                cod = 0
                msg = Nothing
            Next
        End If
        myConn2.Close()
        myConn2.Dispose()
    End Sub
    Public Sub ReparaProductosMedidas()
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand
        Dim qry As String = "update productos set medida = 1 where medida = 0 or medida is null"
        Try
            myConn2.Open()
            mycommand = New SqlCommand(qry, myConn2)
            mycommand.ExecuteNonQuery()
            'MsgBox("Medidas reparadas", MsgBoxStyle.Information, "Auto Fix measurements:")
            myConn2.Close()
            myConn2.Dispose()
        Catch ex As Exception
            MsgBox("Ocurrio un problema en ReparaProductosMedidas: " + ex.Message)
        End Try
    End Sub
    Public Sub ReparaProductosEstados()
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand
        Dim qry As String = "update productos set estado = 'I' where estado <> 'A'"
        Try
            myConn2.Open()
            mycommand = New SqlCommand(qry, myConn2)
            mycommand.ExecuteNonQuery()
            'MsgBox("Medidas reparadas", MsgBoxStyle.Information, "Auto Fix measurements:")
            myConn2.Close()
            myConn2.Dispose()
        Catch ex As Exception
            MsgBox("Ocurrio un problema en ReparaProductosMedidas: " + ex.Message)
        End Try
    End Sub
    Public Sub UpdateRemoteVersion(ByRef CurrVersion As Long, ByRef terminal As Long)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '   *********************   ACTUALIZAR NRO DE VERSION REMOTA 
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim TerminalesSCTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesSCTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        Try
            TerminalesSCTableAdapter.terminales_updatesgcversion(CurrVersion.ToString, gTerminal)
            'parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("SysCurrentVersion", newversion, newversion.ToString, Nothing)
        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub
    Public Sub GetSucursalesClowd()
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
        Dim mycommand As New SqlCommand
        myConn2.Open()
        Try
            mycommand = New SqlCommand("truncate table sucursales", myConn2)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            'ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Actualización de versión", "ActualizarBD", sFile + " - " + ex.Message)
            'status = False
            'cod = 1
            'msg = "Ocurrio un problema en: ActualizarBD() - " + sFile + " - " + ex.Message
            ''Exit For
        End Try
        myConn2.Close()
        myConn2.Dispose()
        Try
            Dim sucursalesTableAdapter As comercialDataSetTableAdapters.sucursalesTableAdapter
            sucursalesTableAdapter = New comercialDataSetTableAdapters.sucursalesTableAdapter()
            Dim clientessucursalesTableAdapter As siscomDataSetTableAdapters.clientessucursalesTableAdapter
            clientessucursalesTableAdapter = New siscomDataSetTableAdapters.clientessucursalesTableAdapter()
            Dim ClientesSucursalesTable As siscomDataSet.clientessucursalesDataTable
            ClientesSucursalesTable = clientessucursalesTableAdapter.GetDataByIDcliente(gMiIDCliente)
            If ClientesSucursalesTable.Rows.Count > 0 Then
                For i = 0 To ClientesSucursalesTable.Count - 1
                    Dim idsucursal As Long = ClientesSucursalesTable.Rows(i).Item(ClientesSucursalesTable.Columns("idsucursal"))
                    sucursalesTableAdapter.sucursales_insertar(ClientesSucursalesTable.Rows(i).Item(ClientesSucursalesTable.Columns("nombre")), ClientesSucursalesTable.Rows(i).Item(ClientesSucursalesTable.Columns("direccion")), Nothing)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DownloadSGC()
        'Dim xi As LoadingForm
        Dim ftpClient As New WebClient
        Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar"
        Dim trnsfrpth As String = gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar"
        'Dim UpdateAlertStatus As Boolean
        '***********************************************************
        'DESCARGA ACTUALIZACIÓN
        '***********************************************************
        'If UpdateAlertStatus = False Then Return
        Try
            '**********************************************
            Try 'ELIMINA POR COMPLETO LA CARPETA EJECUTABLE
                IO.Directory.Delete(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\", True)
            Catch ex As Exception

            End Try
            '**********************************************
            ' SI NO EXISTE LA CREA
            If (Not System.IO.Directory.Exists(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\")) Then
                System.IO.Directory.CreateDirectory(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\")
            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Borrando archivos " + ex.Message, MsgBoxStyle.Exclamation, "Ocurrió un evento inesperado")
            Return
        End Try
        '======================================
        gDownloadProgress = 0
        '=====================================
        'BackgroundWorker.RunWorkerAsync()
        '===========================
        AddHandler ftpClient.DownloadProgressChanged, AddressOf DownloadProgressChanged
        AddHandler ftpClient.DownloadFileCompleted, AddressOf DownloadComplete
        xi = New LoadingForm
        xi.Text = "Descargando última versión"
        xi.ProgressBar.Maximum = 100
        xi.ProgressBar.MarqueeAnimationSpeed = 100
        'xi.mensaje.TextAlign = ContentAlignment.MiddleLeft
        xi.mensaje.Text = "Descargando"
        xi.Show()
        'Try
        Try
            FileSystem.Kill(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\*.rar")
        Catch ex As Exception

        End Try
        ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
        ftpClient.DownloadFileAsync(New Uri(path), trnsfrpth)
    End Sub
    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        'counter = counter + 1
        'Dim xi As LoadingForm
        Dim info As New IO.FileInfo(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar")
        Dim length As Long
        length = (info.Length) / 1000
        gDownloadProgress = e.ProgressPercentage
        xi.ProgressBar.Value = gDownloadProgress
        xi.mensaje.Text = length.ToString + "kb " + "Descargando... "
        xi.Refresh()
    End Sub
    Private Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'MsgBox("Descarga completa! " + gDownloadProgress.ToString)
        'Dim xi As LoadingForm
        xi.Dispose()
        'UpdateSGC(newversion)
        'If MsgBox("La descarga esta lista, Desea instalar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        UpdateSGC()
        'End If

    End Sub
    Public Sub GetRangoFechas()
        gFechaDesde = Nothing
        gFechaHasta = Nothing
        Dim srf As SeleccionaRangoFechas
        srf = New SeleccionaRangoFechas
        srf.ShowDialog()

    End Sub
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        If s = Nothing Then Return False
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*[-\.\w]*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Public Sub ShowPopUp(msg As String, tiempo As Integer)
        Dim x As New WinPopUp()
        x.Label.Text = msg
        x.tiempo = tiempo
        x.Show()
    End Sub
    Public Function GetHDSN()
        Dim HDD_Serial, MB_serial As String
        Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        For Each hd In hdd.Get
            HDD_Serial = hd("SerialNumber")
            GHDSN = Trim(HDD_Serial)
            Exit For
        Next
        Dim mboard As New ManagementObjectSearcher("select * from Win32_BaseBoard")
        For Each mb In mboard.Get
            MB_serial = mb("SerialNumber")
            GMBSN = Trim(MB_serial)
        Next
        'MsgBox(MB_serial)
        Return GHDSN
    End Function
    Public Sub UpdateHDSN(ByVal idterminal As Long)
        Try
            Dim sn As String
            sn = GetHDSN()
            ''****************************************************************************
            Dim TerminalesTableAdapter As New siscomDataSetTableAdapters.terminalesTableAdapter()
            TerminalesTableAdapter.terminales_updatehdsn(GHDSN, GMBSN, idterminal)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub ForceBDChange()
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
        'MsgBox(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand

        Try
            mycommand = New SqlCommand("ALTER view  [dbo].[libroventasdetalle]
as

-- PRODUCTOS
select 
	vd.idventa,
	vd.idproducto ,
--------------------------------------------------------------------------------------------------------------------------------
	isnull(p.marca,'') +' '+
	isnull(p.modelo,'') +' '+
	isnull(p.presentacion,'') as descripcion
--------------------------------------------------------------------------------------------------------------------------------
		,vd.cantidad
		--------------------------------------------------------------------------------------------------------------------------------
		,cast(vd.precioventa as decimal (18,2) )	as precioventa,
--------------------------------------------------------------------------------------------------------------------------------
		(
		case
	--when tc.idtipocomprobanteafip = 6 then 0
	when tc.idtipocomprobanteafip = 11 then 0
	when tc.idtipocomprobanteafip = 13 then 0
	else
		CASE
			WHEN vd.ivaventasdetalle < 0 THEN 
				cast(  (vd.precioventa   - isnull(vd.descuento,0) + isnull(vd.recargo, 0))  as decimal(18,2))
			ELSE
				  cast(((vd.precioventa  - isnull(vd.descuento,0) + isnull(vd.recargo, 0)) / (1 + (vd.ivaventasdetalle/ 100)  )) as decimal(18,2))
				 
			END
	end
		)
		as  precioventasiniva 		,
--------------------------------------------------------------------------------------------------------------------------------
		isnull(vd.recargo, 0 )	as recargo
--------------------------------------------------------------------------------------------------------------------------------
		,vd.descuento 
--------------------------------------------------------------------------------------------------------------------------------
		,
		(
		case
	--when tc.idtipocomprobanteafip = 6 then 0
	when tc.idtipocomprobanteafip = 11 then 0
	when tc.idtipocomprobanteafip = 13 then 0
	else
		CASE
			WHEN vd.ivaventasdetalle < 0 THEN 
				cast(  (vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0))  as decimal(18,2))
			ELSE
				  cast(((vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0)) / (1 + (vd.ivaventasdetalle/ 100)  )) as decimal(18,2))
				 
			END
	end
		)
		as  neto 
--------------------------------------------------------------------------------------------------------------------------------
		,cast(vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0) as decimal (18,2)) 
		as  subtotal
--------------------------------------------------------------------------------------------------------------------------------
			,vd.ivaventasdetalle as iva
--------------------------------------------------------------------------------------------------------------------------------
	,case
	--when tc.idtipocomprobanteafip = 6 then 0
	when tc.idtipocomprobanteafip = 11 then 0
	when tc.idtipocomprobanteafip = 13 then 0
	else
		CASE
			WHEN vd.ivaventasdetalle < 0 THEN 0
			ELSE
				cast(cast(cast(((vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0)) / (1 + (vd.ivaventasdetalle/ 100)  )) as decimal(18,3))  * (vd.ivaventasdetalle/ 100) as decimal(18,3)) as decimal(18,2))
			END
	end as ivaventasdetalle
--------------------------------------------------------------------------------------------------------------------------------
	,cast(v.fechaventa as date) as fechaventa
--------------------------------------------------------------------------------------------------------------------------------
	,v.fechabaja
--------------------------------------------------------------------------------------------------------------------------------
,ltrim(rtrim((select letra from tipocomprobantes where tipocomprobantes.idtipocomprobante = v.idtipocomprobante))) as letra
--------------------------------------------------------------------------------------------------------------------------------
,cast(isnull(vd.precioventamayorista,0) * vd.cantidad as decimal (18,2) )	as frpreciocostomayorista
,cast(isnull(vd.precioventadistribuidor,0) * vd.cantidad as decimal (18,2) )	as frpreciocostodistribuidor
,cast(vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0) as decimal (18,2)) - cast(isnull(vd.precioventamayorista,0) * vd.cantidad as decimal (18,2) ) as frgananciamayorista
,cast(vd.precioventa * vd.cantidad  - isnull(vd.descuento,0) + isnull(vd.recargo, 0) as decimal (18,2)) - cast(isnull(vd.precioventadistribuidor,0) * vd.cantidad as decimal (18,2) ) as frgananciadistribuidor
--------------------------------------------------------------------------------------------------------------------------------
,p.unidadmedida
/*CASE
	WHEN p.unidadmedida = 1 THEN 
		cast(vd.cantidad * p.medida  as decimal(18,3)) 
	ELSE
		0
	END
	as kgpeso*/
--------------------------------------------------------------------------------------------------------------------------------
,vd.idlistaprecio
--------------------------------------------------------------------------------------------------------------------------------
,p.medida
--------------------------------------------------------------------------------------------------------------------------------
,case
when  p.unidadmedida = 1 then
	case
		when vd.idlistaprecio = 2 then cast(vd.cantidad as decimal(18,3)) 
		else
		cast( vd.cantidad * p.medida as decimal(18,3)) 
	end
else
	0
end as kilogramos
--------------------------------------------------------------------------------------------------------------------------------
,v.idtipocomprobante
--------------------------------------------------------------------------------------------------------------------------------
from 
	ventas v
	inner JOIN ventasdetalle vd ON v.idventa = vd.idventa
	 inner JOIN productos p ON vd.idproducto = p.idproducto
	 inner JOIN tipocomprobantes tc ON v.idtipocomprobante = tc.idtipocomprobante
	 where 
	 v.fechabaja is null


", myConn2)
            myConn2.Open()
            mycommand.ExecuteNonQuery()
            myConn2.Close()
            myConn2.Dispose()
        Catch ex As Exception
            'ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Actualización de versión", "ActualizarBD", sFile + " - " + ex.Message)
            'status = False
            'cod = 1
            'msg = "Ocurrio un problema en: ActualizarBD() - " + sFile + " - " + ex.Message
            ''Exit For
        End Try
        QueryBDChange("ALTER view [dbo].[libroventas]
                            as
                            select 
                            v.idventa,
                            fechaventa,
                            convert(date,fechaventa) as fechadate,
                            v.fechabaja,
                            c.idcliente,
                            c.nombre,
                            --------------------------------------------------------------------------------------------------------------------------------
                            isnull(c.cuit,'0') as cuit
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,isnull((select doctipoafip from tipodocumentos where idtipodocumento = isnull(c.idtipodocumento,0)),'99') as doctipo
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select descripcion from tipocondicioniva where idtipocondicioniva = c.condicioniva) as condicionivadescripcion
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,tc.descripcion as tipocomprobante
                            ,rtrim(ltrim(tc.letra)) as tipocomprobanteletra
                            ,tc.idtipocomprobanteafip
                            ,c.condicioniva
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,case
                                when tc.idtipocomprobanteafip = 0 then 
										(select cast(sum(libroventasdetalle.subtotal) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa) 
							else
								 (select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa) +
								 (case
									when tc.idtipocomprobanteafip = 0 then 0
									when tc.idtipocomprobanteafip = 3 then 
										(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva > 0)
									when tc.idtipocomprobanteafip = 8 then 
										(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
									when tc.idtipocomprobanteafip = 6 then 
										(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
									when tc.idtipocomprobanteafip = 11 then 
										(select sum(libroventasdetalle.subtotal) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
									when tc.idtipocomprobanteafip = 13 then 
										(select sum(libroventasdetalle.subtotal) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
									else
										(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva > 0)
								end)
							end
							as importe,
                            --------------------------------------------------------------------------------------------------------------------------------
                            (select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa) as ivaventas
                            --------------------------------------------------------------------------------------------------------------------------------
                            , case
                                when tc.idtipocomprobanteafip = 0 then 0
                                when tc.idtipocomprobanteafip = 6 then 0
                                when tc.idtipocomprobanteafip = 11 then 0
								when tc.idtipocomprobanteafip = 13 then 0
                                 else
                                (select isnull(sum(libroventasdetalle.subtotal),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = -1)  
                                end as  ImpTotConc
                            --------------------------------------------------------------------------------------------------------------------------------
                            , case
                            when tc.idtipocomprobanteafip = 0 then 0
							when tc.idtipocomprobanteafip = 3 then 
									(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva > 0)
							when tc.idtipocomprobanteafip = 8 then 
									(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
                                when tc.idtipocomprobanteafip = 6 then 
									(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
                                when tc.idtipocomprobanteafip = 11 then 
                                    (select sum(libroventasdetalle.subtotal) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
								when tc.idtipocomprobanteafip = 13 then 
                                    (select sum(libroventasdetalle.subtotal) from libroventasdetalle where libroventasdetalle.idventa = v.idventa )
								when tc.idtipocomprobanteafip = 53 then 
									(select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva > 0)
                                 else
                                    (select isnull(sum(libroventasdetalle.neto),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva > 0)
                                end as  ImpNeto
                            --------------------------------------------------------------------------------------------------------------------------------
                            , case
                                when tc.idtipocomprobanteafip = 0 then 0
								when tc.idtipocomprobanteafip = 3 then  0
								when tc.idtipocomprobanteafip = 8 then  0
                                when tc.idtipocomprobanteafip = 6 then  0
                                when tc.idtipocomprobanteafip = 11 then 0 
                                when tc.idtipocomprobanteafip = 13 then 0 
								when tc.idtipocomprobanteafip = 53 then 0 
                                else
                            (select isnull(sum(libroventasdetalle.subtotal),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 0)  
                            end as  ImpOpEx
                            --------------------------------------------------------------------------------------------------------------------------------
                            , 0 as  ImpTrib
                            --------------------------------------------------------------------------------------------------------------------------------
                            , case
                                when tc.idtipocomprobanteafip = 0 then 0
								when tc.idtipocomprobanteafip = 3 then  
								(select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa) 
								when tc.idtipocomprobanteafip = 8 then  
								(select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa) 
                                when tc.idtipocomprobanteafip = 11 then 0 
								when tc.idtipocomprobanteafip = 13 then 
								(select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa)  
								when tc.idtipocomprobanteafip = 53 then 
								(select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa)   
                                else
                                    (select sum(libroventasdetalle.ivaventasdetalle) from libroventasdetalle where libroventasdetalle.idventa = v.idventa)  
                                end as   ImpIVA
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.ivaventasdetalle),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 27) 
                             as IVA_27
                             --------------------------------------------------------------------------------------------------------------------------------
                            ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 27) 
                             as BASEIVA_27
                             --------------------------------------------------------------------------------------------------------------------------------
                            ,(select cast(isnull(sum(libroventasdetalle.ivaventasdetalle),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 21) 
                             as IVA_21
                             --------------------------------------------------------------------------------------------------------------------------------
                             ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 21) 
                             as BASEIVA_21
                             --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.ivaventasdetalle),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) = 10) 
                             as IVA_10
                              --------------------------------------------------------------------------------------------------------------------------------
                             ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) = 10) 
                             as BASEIVA_10
                             --------------------------------------------------------------------------------------------------------------------------------
                             ,(select isnull(sum(libroventasdetalle.ivaventasdetalle),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva = 5) 
                             as IVA_5
                              --------------------------------------------------------------------------------------------------------------------------------
                             ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) = 5) 
                             as BASEIVA_5
                             --------------------------------------------------------------------------------------------------------------------------------
                             ,(select isnull(sum(libroventasdetalle.ivaventasdetalle),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) = 2) 
                             as IVA_2
                              --------------------------------------------------------------------------------------------------------------------------------
                             ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) = 2) 
                             as BASEIVA_2
                             --------------------------------------------------------------------------------------------------------------------------------
                             ,0--(select isnull(sum(libroventasdetalle.subtotal),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.iva <= 0) 
                             as IVA_0
                             -------------------------------------------------------------------------------------------------------------------------------
                             ,(select cast(isnull(sum(libroventasdetalle.neto),0) as decimal(18,2)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and floor(libroventasdetalle.iva) <= 0) 
                             as BASEIVA_0
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,case 
                                when (select count(idformapago) from pagos where idventa = v.idventa) = 1 then
                                        (select descripcion from formaspago where idformapago = (select top 1 idformapago from pagos where idventa = v.idventa)) 
                                when (select count(idformapago) from pagos where idventa = v.idventa) = 0 then 'Cuenta Corriente'
                            else 'Varias'
                            end as formapago
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,v.usuariocarga
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select nombreprovincia from provincias where idprovincia = isnull(c.idprovincia,1) ) as provincia
                            ,isnull(v.idconcepto,1) as idconcepto
                            ,'PES' as MonId
                            ,1 as MonCotiz
                            ,v.cae
                            ,v.caefchvto
							,v.caefchreg
                            ,convert(date,v.caefchvto) as caefchvtodate
                            ,v.ptovta
                            ,v.cbtnro
                            ,v.fechadesde
                            ,v.fechahasta
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.frpreciocostomayorista),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa ) as frcostomayorista
                             --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.frpreciocostodistribuidor),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa ) as frcostodistribuidor
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.frgananciamayorista),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa ) as frgananciamayorista
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select isnull(sum(libroventasdetalle.frgananciadistribuidor),0) from libroventasdetalle where libroventasdetalle.idventa = v.idventa ) as frgananciadistribuidor
                            --------------------------------------------------------------------------------------------------------------------------------
                            ,(select cast(isnull(sum(libroventasdetalle.kilogramos),0) as decimal(18,3)) from libroventasdetalle where libroventasdetalle.idventa = v.idventa and libroventasdetalle.unidadmedida = 1 ) as kilogramos
from ventas v,
clientes c,
tipocomprobantes tc
where
v.idcliente = c.idcliente
and v.idtipocomprobante = tc.idtipocomprobante

")
    End Sub
    Public Sub QueryBDChange(ByVal query As String)
        Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
        'MsgBox(gActiveSQLConnectionString)
        Dim mycommand As New SqlCommand

        Try
            mycommand = New SqlCommand(query, myConn2)
            myConn2.Open()
            mycommand.ExecuteNonQuery()
            myConn2.Close()
            myConn2.Dispose()
        Catch ex As Exception
            'ErrorLogTableAdapter.errorlog_insertar("Aplicación", "Actualización de versión", "ActualizarBD", sFile + " - " + ex.Message)
            'status = False
            'cod = 1
            'msg = "Ocurrio un problema en: ActualizarBD() - " + sFile + " - " + ex.Message
            ''Exit For
        End Try
    End Sub
    Public Sub BackUpDataBase()
        Try
            Dim path As String
            Dim query As String
            path = gSystemDrive + "\SGComercial\BD\MiComercio_backup.bak"
            query = "BACKUP DATABASE comercial TO DISK = '" + path + "'"
            QueryBDChange(query)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub GBuscaProductoManual(ByRef StrRes As StrError)
        gcodigoproducto = 0
        Dim p As BuscaCodigoProductoManual
        p = New BuscaCodigoProductoManual
        p.ShowDialog()
        If Len(Trim(gcodigoproducto)) = 0 Then
            StrRes.CodError = 1
            StrRes.MsgError = "Producto no Encontrado"
            Return
        Else
            StrRes.CodError = 0
            StrRes.MsgError = gcodigoproducto
        End If
        ''codigoproductoTextBox.Text = gcodigoproducto
        ''consultardisponibles()
    End Sub
    Public Sub AuRegistrarVentaCancelada(ByRef idcliente As Int64, ByRef usuariocarga As String, ByRef importe As Decimal, ByRef observacion As String)
        Dim AuVentasCanceladas As New comercialDataSetTableAdapters.auventascanceladasTableAdapter()
        AuVentasCanceladas.auventascanceladas_insertar(idcliente, usuariocarga, importe, observacion)
    End Sub
    Public Sub MsgInfo(ByRef msg As String)
        MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgEx(ByRef msg As String)
        MessageBox.Show(msg, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Public Function MsgQues(ByRef msg As String) As Boolean
        If MessageBox.Show(msg, "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub MsgInfoPopUp(ByRef msg As String)
        Try
            Dim xd As frmAlert = New frmAlert
            Dim codalerta As String = Nothing
            xd.setAlert(msg, codalerta, frmAlert.alertTypeEnum.Info)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub MsgSuccessPopUp(ByRef msg As String)
        Try
            Dim xd As frmAlert = New frmAlert
            Dim codalerta As String = Nothing
            xd.setAlert(msg, codalerta, frmAlert.alertTypeEnum.Success)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub MsgExPopUp(ByRef msg As String, Optional ByRef codalerta As String = Nothing)
        Try
            Dim xd As frmAlert = New frmAlert
            xd.setAlert(msg, codalerta, frmAlert.alertTypeEnum.Warning)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub MsgErrPopUp(ByRef msg As String)
        Try
            Dim xd As frmAlert = New frmAlert
            Dim codalerta As String = Nothing
            xd.setAlert(msg, codalerta, frmAlert.alertTypeEnum.Err)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CheckModulesAuth()
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        Try
            gModuloCloud = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
            If gModuloCloud = 1 Then
                QueryBDChange("update modulos set estado = 1 where nombre = 'ModuloCloud'")
                QueryBDChange("update permisos set menuname = 'SubirProductosCloud' where menuname = 'SubirProductosClowd'")
                QueryBDChange("update permisos set menuname = 'SubirStockCloud' where menuname = 'SubirStockClowd'")
                QueryBDChange("update permisos set menuname = 'DescargarProductosCloud' where menuname = 'DescargarProductosClowd'")
            End If
            gModuloCloud = ModulosTableAdapter.modulos_consultarestado("ModuloCloud")
            gModuloPedidosWeb = ModulosTableAdapter.modulos_consultarestado("ModuloPedidosWeb")
            gModuloPedidosMovil = ModulosTableAdapter.modulos_consultarestado("ModuloPedidosMovil")
            gMiFranquicia = ModulosTableAdapter.modulos_consultarestado("ModuloFranquicia")
        Catch ex As Exception
            gModuloCloud = 0
            gModuloPedidosWeb = 0
            gModuloPedidosMovil = 0
            gMiFranquicia = 0
            Return
        End Try
    End Sub
    Public Sub RegLoginDate(gTerminal)
        '********************************
        '   registro LOGIN
        '********************************
        Try
            Dim TerminalesSCTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
            TerminalesSCTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
            TerminalesSCTableAdapter.terminales_updatelogin(Now(), gTerminal)
        Catch ex As Exception

        End Try
    End Sub
    Public Enum ListaModulos
        ModuloVentas
        ModuloDelivery
        ModuloStock
        ModuloImportarExportarProductos
        ModuloProveedores
        ModuloTransferenciaStock
        ModuloCajas
        ModuloVales
        ModuloCuentasCorrientes
        ModuloContabilidad
        ModuloEstadisticas
        ModuloUtilidades
        ModuloConfiguraciones
        ModuloSeguridad
        TerminalVerificadoraPrecios
        ModuloAyuda
        ModuloNotificaciones
        ModuloSyncWeb
        ModuloGGastronomica
        ModuloFranquicia
        ModuloPreventa
        ModuloGestionEscolar
        ModuloPedidosWeb
        ModuloPedidosMovil
        ModuloCloud
        ModuloSueldos
    End Enum
    Class StrDatosFacturacion
        Public Idtipocomprobante As Integer
        Public idformapago As Integer
        Public idconcepto As Integer
        Public montofacturado As Integer
        Public fechaventa As DateTime
        Public fechavencimiento As DateTime
        Public nrocbtexterno As String
        Public CodError As Integer
        Public MsgError As String
    End Class
    Public Sub ImprimirFactura(ByVal idventa As Long)
        Dim impresion As String
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Dim ErrorLogTableAdapter As New comercialDataSetTableAdapters.errorlogTableAdapter()
        impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionTicket")

        Select Case impresion
            Case "Nunca"
                    'Radionunca.Checked = True
            Case "Siempre"
                Try
                    'Dim p As ViewTicketFE
                    Dim p As New ViewerFactura
                    'p.MdiParent = Me.ParentForm
                    p.ShowInTaskbar = True
                    'p.TopMost = True
                    p.ShowDialog()
                Catch ex As Exception
                    ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                End Try
            Case "Preguntar"
                If MsgQues("Desea Imprimir el comprobante?") = True Then
                    Try
                        Dim p As New ViewerFactura
                        'p.MdiParent = Me.ParentForm
                        p.ShowInTaskbar = True
                        'p.TopMost = True
                        p.ShowDialog()
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                    End Try
                End If
        End Select
    End Sub
    Public Function GetEstadoCaja() As Long
        Dim StrError As New StrError()
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Dim CajaseventosTableAdapter As New comercialDataSetTableAdapters.cajaseventosTableAdapter()
        '***************    consultar el estado de caja *************
        gidcaja = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        If gidcaja = 0 Then
            StrError.CodError = 1
            StrError.MsgError = "Este ordenador no esta Registrado para operar como CAJA!"
            MsgExPopUp("Este ordenador no esta Registrado para operar como CAJA!")
            Return StrError.CodError
        End If

        gidevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        If gidevento = 0 Then
            StrError.CodError = 2
            StrError.MsgError = "Caja Cerrada. Abra la caja antes de registrar una venta"
            MsgExPopUp("Caja Cerrada. Abra la caja antes de registrar una venta", "CAC")
            Return StrError.CodError
        Else
            StrError.CodError = 0
            StrError.MsgError = "OK"
            Return StrError.CodError
        End If
        '***************    FIN consultar el estado de caja *************
    End Function
    Public Function isAlpha(ByVal letterChar As String) As Boolean
        Return Regex.IsMatch(letterChar, "^[^\W\d_]{1}[0-9]+$")
    End Function
End Module


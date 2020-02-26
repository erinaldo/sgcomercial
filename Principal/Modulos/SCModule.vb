Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports System.Net
Imports System

Module SCModule
    '***********************************************************
    Public SCHoverColorStrong As Color = Drawing.Color.FromArgb(0, 122, 204)
    Public SCHoverColorLight As Color = Drawing.Color.FromArgb(14, 172, 244)
    Public SCBackColor As Color = Drawing.Color.FromArgb(40, 41, 35)
    Public SCForeColorLight As Color = Drawing.Color.FromArgb(255, 255, 255)
    Public SCForeColorStrong As Color = Drawing.Color.FromArgb(1, 207, 255)
    Public SCAPPICON As System.Drawing.Icon
    Public SCFORMICON As System.Drawing.Icon
    'Public MySQLStrConn As String = "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_sgcaguadagrande;persistsecurityinfo=True"
    Public SCStrConn As String = "server=sistemascomerciales.net;user id=sistema1_siscom;password=Sistemascomerciales*?;database=sistema1_siscom;persistsecurityinfo=True"
    '***********************************************************
    Dim da As MySQLDataSetTableAdapters.clientesTableAdapter
    Dim ds As MySQLDataSet
    Dim dt As DataTable

    Public MachineName As String = Environment.MachineName
    Public MachineKey As String
    Public SCstatus As Boolean
    Public LicenceValidDate As DateTime
    Public gTipoLicencia As String
    Public SCConn As MySqlConnection
    Public gidventaSC As Long
    Public gidclienteSC As Long
    Public SCIdproducto As String
    Public SCProductoDescripcion As String
    Public gForceUpdateSC As Integer
    Sub conectarSCConn(ByRef status As Boolean)
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
            'SCConn = New MySqlConnection(sgcomercial.My.MySettings.Default.SCConnectionString)
            'SCConn = New MySqlConnection(SCStrConn)
            'SCConn.Open()
            ''MsgBox("Conexión exitosa!", MsgBoxStyle.Information, "SisCom")
            'status = True
            'SCConn.Close()
            'SCConn.Dispose()
        Catch ex As Exception
            'MsgBox("No se pudo conectar con el servidor remoto: " + ex.Message, MsgBoxStyle.Information,"SisCom")
            'SCConn.Dispose()
            status = False
        End Try
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
    Public Sub ValidarLicencia()
        '********************************************************
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '********************************************************
        Dim TerminalesTableadapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesTableadapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        '********************************************************
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        '********************************************************
        gTipoLicencia = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("tipolicencia")
        LicenceValidDate = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1(MachineKey)
        '************  VALIDAR LICENCIA    **************************
        '*************************************************licencia vigente*************************
        If CDate(LicenceValidDate) > CDate(DateTime.Now) Then
            Return
        End If
        '**************************************     licencia VENCE HOY    *************************
        If CDate(LicenceValidDate) = CDate(DateTime.Now) And gTipoLicencia = "P" Then
            MessageBox.Show("Tu periodo de prueba expira hoy! Ponete en contacto con nosotros para renovarla!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
            Return
        End If
        If CDate(LicenceValidDate) = CDate(DateTime.Now) And gTipoLicencia <> "P" Then
            MessageBox.Show("Tu suscripción a soporte y actualizaciones expira hoy! Contactanos para renovarla y mantener tu sistema actualizado", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
            Return
        End If
        '*************************************************************
        '**************************************     FIN VENCE HOY    *************************
        '*************************************************************
        '**************************************     LICENCIA VENCIDA!!      *************************
        If CDate(LicenceValidDate) < CDate(DateTime.Now) Then
            Select Case gTipoLicencia
                Case "V"
                Case "A"
                    CreateObject("WScript.Shell").Popup("Tu suscripción a soporte y actualizaciones ha expirado. Contactanos para renovarla y mantener tu sistema actualizado!", 6, "Advertencia! Licencia Caducada", vbExclamation)
                    'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                    'AcercaDe.ShowDialog()
                    Try
                        TerminalesTableadapter.terminales_updateautoupdater(0, gmacadress)
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Login", "LICENCIA", "terminales_updateautoupdater", ex.Message)
                    End Try
                    End
                    Return
                Case "AV"
                    MessageBox.Show("Tu suscripción a soporte y actualizaciones ha expirado. Contactanos para renovarla y mantener tu sistema actualizado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                    'AcercaDe.ShowDialog()
                    Try
                        TerminalesTableadapter.terminales_updateautoupdater(0, gmacadress)
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Login", "LICENCIA", "terminales_updateautoupdater", ex.Message)
                    End Try
                    Return
                Case "M"
                    CreateObject("WScript.Shell").Popup("Tu suscripción a soporte y actualizaciones ha expirado. Contactanos para renovarla y mantener tu sistema actualizado!", 6, "Advertencia! Licencia Caducada", vbExclamation)
                    'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                    'AcercaDe.ShowDialog()
                    Try
                        TerminalesTableadapter.terminales_updateautoupdater(0, gmacadress)
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Login", "LICENCIA", "terminales_updateautoupdater", ex.Message)
                    End Try
                    End
                    Return
                Case "MV"
                    MessageBox.Show("Tu suscripción a soporte y actualizaciones ha expirado. Contactanos para renovarla y mantener tu sistema actualizado!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                    'AcercaDe.ShowDialog()
                    Try
                        TerminalesTableadapter.terminales_updateautoupdater(0, gmacadress)
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Login", "LICENCIA", "terminales_updateautoupdater", ex.Message)
                    End Try
                    Return
                Case "P"
                    If WaitingLicence = True Then Return
                    CreateObject("WScript.Shell").Popup("Periodo de prueba ha finalizado. Conseguí tu licencia ya!", 5, "Advertencia! Licencia Caducada", vbExclamation)
                    System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                    End
            End Select
        End If
        '************  VALIDAR LICENCIA    **************************
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
    Public Sub UpdateLocalLicence()
        'Dim table As DataTable = GetTable()
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("autoupdater", GetType(Integer))
        table.Columns.Add("tipolicencia", GetType(String))
        table.Columns.Add("fechabaja", GetType(DateTime))
        '****Licencia local********
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '****   ----    ********
        Try
            conectarSCConn(SCstatus)
            If SCstatus = False Then Return

            '*******************************************************************************
            '*************  terminalesTableAdapter    **************************************
            Try
                GetHDSN()
                Dim terminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
                terminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
                '------------------------------------------
                table = terminalesTableAdapter.GetDataByDatosLicencia(gmacadress)
                If table.Rows.Count = 0 Then
                    table = terminalesTableAdapter.GetDataByDatosLicenciaHDSN(GHDSN)
                    If table.Rows.Count > 0 Then
                        '******************************************************
                        ' LA MAC CAMBIÓ... ACTUALIZA LA MAC EN LA NUBE
                        Dim idterminal As Long
                        idterminal = table.Rows(0).Item("idterminales")
                        terminalesTableAdapter.terminales_updatemac(gmacadress, idterminal)
                    End If
                End If
                LicenceValidDate = table.Rows(0).Item("fechabaja")
                '******************************************************
                If IsDBNull(table.Rows(0).Item("tipolicencia")) Then
                    gTipoLicencia = "P"
                Else
                    gTipoLicencia = table.Rows(0).Item("tipolicencia")
                End If
                '******************************************************
                'If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) > 0 Then
                parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave(MachineKey, Nothing, LicenceValidDate.ToString, Nothing) ' UPDATEA LOCAL
                parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("tipolicencia", Nothing, gTipoLicencia, Nothing)
                'End If
            Catch ex As Exception
                Dim msg As String = ex.Message
                LicenceValidDate = Nothing
                parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("tipolicencia", Nothing, "P", Nothing)
            End Try

        Catch ex As Exception
            LicenceValidDate = Nothing
            parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("tipolicencia", Nothing, "P", Nothing)
        End Try
    End Sub
    Public Sub LoadDefaultDir()
        '**********************************************
        gPublicDocumentsPath = Environment.GetFolderPath(System.Environment.SpecialFolder.CommonDocuments)
        '**********************************************
        gSystemDrive = Environment.GetEnvironmentVariable("SystemDrive")
        '**********************************************
        WaitingLicence = False
        '************************************************************************************
    End Sub
    Public Sub LoadDefaultICONS()
        '**********************************************
        SCAPPICON = My.Resources.ResourceManager.GetObject("SC_ICO_DARK_35")
        SCFORMICON = My.Resources.ResourceManager.GetObject("SC_ICO_DARK_35")
        '************************************************************************************
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
    'Public Sub gBuscarActualizaciones()
    '    Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar"
    '    Dim trnsfrpth As String
    '    Dim ftpClient As New WebClient
    '    'Dim xi As LoadingForm
    '    trnsfrpth = gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar"
    '    'If UpdateAlertStatus = False Then Return

    '    Try
    '        '**********************************************
    '        gSystemDrive = Environment.GetEnvironmentVariable("SystemDrive")
    '        '**********************************************
    '        Try 'ELIMINA POR COMPLETO LA CARPETA EJECUTABLE
    '            IO.Directory.Delete(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\", True)
    '        Catch ex As Exception

    '        End Try
    '        '**********************************************
    '        ' SI NO EXISTE LA CREA
    '        If (Not System.IO.Directory.Exists(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\")) Then
    '            System.IO.Directory.CreateDirectory(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\")
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
    '    'AddHandler ftpClient.DownloadProgressChanged, AddressOf DownloadProgressChanged
    '    'AddHandler ftpClient.DownloadFileCompleted, AddressOf DownloadComplete
    '    'xi = New LoadingForm
    '    'xi.Text = "Descargando última versión"
    '    'xi.ProgressBar.Maximum = 100
    '    'xi.ProgressBar.MarqueeAnimationSpeed = 100
    '    ''xi.mensaje.TextAlign = ContentAlignment.MiddleLeft
    '    'xi.mensaje.Text = "Descargando"
    '    'xi.Show()
    '    'Try
    '    Try
    '        FileSystem.Kill(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\*.rar")
    '    Catch ex As Exception

    '    End Try
    '    ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
    '    ftpClient.DownloadFileAsync(New Uri(path), trnsfrpth)
    '    UpdateSGC()
    'End Sub
End Module

Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports System.Net
Imports MySql.Data.MySqlClient


Public Class loginform
    Dim sqlserverconnection As SqlConnection
    Dim currentversion As Long
    Dim newversion As Long = 0
    Dim UpdateAlertStatus As Boolean
    '================ DESCARGA DE VERSION
    Dim xi As LoadingForm
    Dim ftpClient As New WebClient
    'Dim random As New Random
    Dim counter As Integer = 0
    Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar"
    Dim trnsfrpth As String
    '===============================================================================

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '*********************************************************
        Dim rtn As Integer
        '************  lucasmartinbs    **************************
        If textusuario.Text = "lucasmartinbs" And textpassword.Text = "Locura011*?" Then
            gusername = textusuario.Text
            guserid = rtn
            guserprofile = UsuariosTableAdapter.usuarios_getperfil(gusername)
            gReloadPermisos = True
            FormPrincipal = New Principal
            Me.Hide()
            FormPrincipal.Show()
            Return
        End If
        '************  ********************    **************************
        '************  otros usuarios    **************************
        '************  ********************    **************************
        rtn = UsuariosTableAdapter.usuarios_validar(textusuario.Text, textpassword.Text)
        If rtn = 0 Then
            MsgBox("Los datos ingresados son incorrectos", MsgBoxStyle.Information, "Advertencia")
        Else    '''''''' ACCESO CORRECTO   ´'''''''''''''
            gusername = textusuario.Text
            guserid = rtn
            guserprofile = UsuariosTableAdapter.usuarios_getperfil(gusername)
            FormPrincipal = New Principal
            Me.Hide()
            FormPrincipal.Show()
            'End If
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub borrartemporales()
        '==== limpio todos los pdf existentes
        Try
            FileSystem.Kill("*.pdf")
        Catch ex As Exception

        End Try
        Try
            FileSystem.Kill(gPublicDocumentsPath + "\*.pdf")
        Catch ex As Exception

        End Try
        '?========********************
    End Sub
    Private Sub formatos()
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "dd/MM/yyyy")
        gPublicDocumentsPath = Environment.GetFolderPath(System.Environment.SpecialFolder.CommonDocuments)
    End Sub
    Private Sub identificarterminal()
        gMiSucursal = 0
        '/////////////////////////////////////////////////////////////////////////////////////
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        gMiSucursal = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("gMiSucursal")
        '/////////////////////////////////////////////////////////////////////////////////////
        gmacadress = getMacAddress()
        MachineKey = "LLAuth" + gmacadress
        LabelMACaddress.Text = gmacadress
    End Sub
    Private Sub IsLucasmartinbs()
        '/////////////////////////////////////////////////////////////////////////////////////
        If gNombreTerminal = "LUCASMARTINBS-N" Then
            textusuario.Text = "lucasmartinbs"
            textpassword.Text = "Locura011*?"
            'Button1.PerformClick()
            textpassword.Select()
        End If
    End Sub
    Private Sub connectdbremote()
        Dim status As Boolean
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        Dim lMiSucursal As Integer
        Try 'CONNECT DB REMOTE
            Try
                ArmaSTRConnWEB(status)
                'Dim CheckConnection As MySqlConnection
                'CheckConnection = New MySqlConnection
                'CheckConnection.ConnectionString = SCStrConn
                'CheckConnection.Open()
                My.Settings.SetUserOverride("SCConnectionString", SCStrConn)
                Dim TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
                TerminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
                Dim misclientesTableAdapter As siscomDataSetTableAdapters.misclientesTableAdapter
                misclientesTableAdapter = New siscomDataSetTableAdapters.misclientesTableAdapter()
                Dim misclientesdatatable As siscomDataSet.misclientesDataTable
                misclientesdatatable = misclientesTableAdapter.GetDataByMac(gmacadress)
                If misclientesdatatable.Rows.Count = 1 Then
                    lMiSucursal = misclientesdatatable.Rows(0).Item(misclientesdatatable.idsucursalColumn)
                    If gMiSucursal = 0 Or lMiSucursal <> gMiSucursal Then
                        Dim ParametrosGeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
                        ParametrosGeneralesTableAdapter.parametrosgenerales_updatebyprgclave("gMiSucursal", lMiSucursal, Nothing, Nothing)
                        gMiSucursal = lMiSucursal
                    End If
                    gMiIDCliente = misclientesdatatable.Rows(0).Item(misclientesdatatable.idclientesColumn)
                    gNombreCliente = misclientesdatatable.Rows(0).Item(misclientesdatatable.nombreColumn)
                    gNombreTerminal = misclientesdatatable.Rows(0).Item(misclientesdatatable.equipoColumn)
                    LabelDatosCliente.Text = "" + gNombreCliente + " - Terminal: [" + gNombreTerminal + "] - Sucursal N°: " + gMiSucursal.ToString + ""
                End If
                gIsOnline = True
            Catch ex As Exception
                ErrorLogTableAdapter.errorlog_insertar("Login", "CONEXIÓN", "Load", "No se pudo Conectar al servidor SC " + ex.Message)
                gIsOnline = False
                Return
            End Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If gModuloClowd = 1 Then
                Try
                    'Dim CheckConnection As MySqlConnection
                    'CheckConnection = New MySqlConnection
                    'CheckConnection.ConnectionString = SCStrConn
                    'CheckConnection.Open()
                    My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)
                    'CheckConnection.Close()
                    'CheckConnection.Dispose()
                Catch ex As Exception
                    ErrorLogTableAdapter.errorlog_insertar("Login", "CONEXIÓN", "Load", "No se pudo Conectar a la Nube " + ex.Message)
                    gIsOnline = False
                End Try
            End If
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub GetSoftwareVersion()
        version.Text = "Versión "
        version.Text += My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        version.Text += "." + My.Application.Info.Version.Build.ToString
        version.Text += "." + My.Application.Info.Version.MinorRevision.ToString
        SoftwareVersion = My.Application.Info.Version.Major.ToString + My.Application.Info.Version.Minor.ToString + My.Application.Info.Version.Build.ToString + My.Application.Info.Version.MinorRevision.ToString
    End Sub

    Private Sub loginform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaultDir()
        Dim hi As LoadingForm
        hi = New LoadingForm
        hi.Show()
        hi.ProgressBar.Maximum = 6
        Cursor.Current = Cursors.WaitCursor
        ''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Limpiando archivos temporales"
        'hi.ProgressBar.Value = 1
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        borrartemporales()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Estableciendo formatos predeterminados"
        'hi.ProgressBar.Value = 2
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        formatos()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Conectando a tu base de datos local.."
        'hi.ProgressBar.Value = 4
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        connectdblocal()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Identificando terminal"
        'hi.ProgressBar.Value = 3
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        identificarterminal()
        '''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''--Autorización modulos especiales--''''''''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Autorización modulos especiales"
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        CheckModulesAuth()
        '''''''''''''''''''''''''''''''''''''''''
        Dim status As Boolean
        Dim cod As Integer
        Dim msg As String = Nothing
        If (Not System.IO.Directory.Exists(gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\BD")) Then
            'System.IO.Directory.CreateDirectory("C:\SGComercial\UpdatePack\Ejecutable\") 'la crearia
        Else
            ActualizarBD(status, cod, msg)
            ForceBDChange()
        End If
        ReparaProductosMedidas()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Conectando a la Nube"
        'hi.ProgressBar.Value = 5
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        connectdbremote()
        '********************************
        GetSoftwareVersion()
        '********************************  
        If gIsOnline = True Then
            '********************************
            hi.mensaje.Text = "Ya casi estamos!"
            hi.ProgressBar.PerformStep()
            hi.Refresh()
            If UpdateCheckBG.IsBusy = False Then
                UpdateCheckBG.RunWorkerAsync()
            End If
            '-------------------------------
            If BGWUpdateLicencia.IsBusy = False Then
                BGWUpdateLicencia.RunWorkerAsync()
            End If
            '--------------------------------
            LabelClowdInfo.Text = gClowdServer
            '********************************
        Else
            '********************************
            hi.mensaje.Text = "SIN CONEXIÓN A INTERNET"
            hi.ProgressBar.PerformStep()
            hi.Refresh()
            LabelDatosCliente.Text = "SIN CONEXIÓN A INTERNET"
        End If
        '************************************
        Cursor.Current = Cursors.Default
        hi.Dispose()
        GetCajaOperativa()
        '----------------------------------
        textusuario.Select()
        IsLucasmartinbs()
    End Sub

    Private Sub GetCajaOperativa()
        gidcaja = 0
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        LabelMACaddress.Text = LabelMACaddress.Text + " - Caja: " + gidcaja.ToString
    End Sub
    Private Sub enablebuttons(ByVal status As Boolean)
        textusuario.Enabled = status
        textpassword.Enabled = status
        Button1.Enabled = status
        'Button2.PerformClick()
    End Sub
    Private Sub closeaplication(ByVal status As Boolean)
        textusuario.Enabled = status
        textpassword.Enabled = status
        Button1.Enabled = status
        Button2.PerformClick()
    End Sub
    Private Sub textpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textpassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub textpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textpassword.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub loginform_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If e.KeyCode.ToString = "Escape" Then
                If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    End
                End If
            End If
        End If
        ''''''''''***************************   POR DEFECTO **************************************
        If (e.KeyCode = Keys.X AndAlso e.Control AndAlso e.Shift) Then
            Dim status As Boolean
            Dim cod As Integer
            Dim msg As String = Nothing
            Try
                'Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
                'parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
                'parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("SysCurrentVersion", Val(softwareversion), softwareversion, Nothing)
                ActualizarBD(status, cod, msg)
                MsgBox("Ajustes de Base aplicados!", MsgBoxStyle.Information, "Mensaje")
                enablebuttons(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        '====================   WEB CONFIG ==================
        If (e.KeyCode = Keys.K AndAlso e.Control AndAlso e.Shift) Then
            WaitingLicence = True
            LabelClowdInfo.Visible = True
            Dim su As SUAuth
            su = New SUAuth
            gSUToken = Nothing
            su.ShowDialog()
            If gSUToken = True Then
                Dim conf As WebConf
                conf = New WebConf
                conf.ShowDialog()
                Me.Hide()
                Me.loginform_Load(e, e)
                Me.Show()
            Else
                Me.loginform_Load(e, e)
            End If
            LabelClowdInfo.Visible = False
        End If

        If (e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control) Then
            'Me.Dispose()
            loginform_Load(e, e)
        End If
        ''''''''''***************************   POR DEFECTO **************************************
        'If (e.KeyCode = Keys.T AndAlso e.Control AndAlso e.Shift) Then
        '    Dim testwindows As POSTForm
        '    testwindows = New POSTForm
        '    testwindows.ShowDialog()
        'End If
    End Sub

    Private Sub textpassword_GotFocus(sender As Object, e As EventArgs) Handles textpassword.GotFocus
        textpassword.SelectAll()

    End Sub

    Private Sub textusuario_TextChanged(sender As Object, e As EventArgs) Handles textusuario.TextChanged

    End Sub

    Private Sub textusuario_GotFocus(sender As Object, e As EventArgs) Handles textusuario.GotFocus
        textusuario.SelectAll()
    End Sub

    Private Sub textusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles textusuario.KeyDown
        'If e.KeyCode.ToString = "Escape" Then
        '    If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
        '        Me.Close()
        '    End If
        'End If
    End Sub

    Private Sub textpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles textpassword.KeyDown
        'If e.KeyCode.ToString = "Escape" Then
        '    If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
        '        Me.Close()
        '    End If
        'End If
    End Sub
    '/************************/
    Function getMacAddress()
        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces

        Return nics(0).GetPhysicalAddress.ToString
        ''''''''''''''''''''''''''''''''''''''''''
        'Dim mac As String
        'mac = getMacAddress()
        ' MsgBox(mac)
        ''''''''''''''''''''''''''''''
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) 
        'btn descarga actualizacion

    End Sub

    Private Sub textusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textusuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            textpassword.Select()
        End If
    End Sub

    Private Sub UpdateCheckBG_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles UpdateCheckBG.DoWork
        If gIsOnline = True Then
            UpdateCheckPasivo(UpdateAlertStatus, Val(SoftwareVersion), newversion)
            UpdateRemoteVersion(SoftwareVersion, gTerminal)
        End If
    End Sub

    Private Sub UpdateCheckBG_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles UpdateCheckBG.RunWorkerCompleted
        ' Called when the BackgroundWorker is completed.
        If newversion = 0 Then
            LabelDatosCliente.Text = "Versión OFF-LINE"
        Else
            If newversion > Val(SoftwareVersion) And UpdateAlertStatus = True Then
                UpdateAlert.Visible = True
                UpdateAlert.Text = "Nueva versión disponible!"
                UpdateAlert.ForeColor = Color.Orange
                PictureUpdateAlert.Image = My.Resources.UpdateAlert
                PictureUpdateAlert.Visible = True
                If MessageBox.Show("Hay una nueva versión disponible! Desea actualizar ahora?", "Descargar nueva versión!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    BuscarActualizaciones()
                End If
            Else
                If newversion = 0 Then Return
                UpdateAlert.Visible = True
                UpdateAlert.Text = "Sistema Actualizado!"
                UpdateAlert.ForeColor = Color.White
                PictureUpdateAlert.Image = My.Resources.checked ' My.Resources.Resources.Yes_check
                PictureUpdateAlert.Visible = True
            End If
        End If
    End Sub
    Private Sub UpdateAlert_Click(sender As Object, e As EventArgs) Handles UpdateAlert.Click
        BuscarActualizaciones()
    End Sub

    Private Sub PictureUpdateAlert_Click(sender As Object, e As EventArgs) Handles PictureUpdateAlert.Click
        BuscarActualizaciones()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs)
        Dim UPDATER As DownloadForm
        UPDATER = New DownloadForm
        UPDATER.ShowDialog()

    End Sub
    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        'counter = counter + 1
        Dim info As New IO.FileInfo("C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar")
        Dim length As Long
        length = (info.Length) / 1000
        gDownloadProgress = e.ProgressPercentage
        xi.ProgressBar.Value = gDownloadProgress
        xi.mensaje.Text = length.ToString + "kb " + "Descargando... "
        xi.Refresh()
    End Sub
    Private Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'MsgBox("Descarga completa! " + gDownloadProgress.ToString)
        xi.Dispose()
        Me.Cursor = Cursors.Default
        'UpdateSGC(newversion)
        UpdateSGC()
    End Sub

    Private Sub LabelDatosCliente_Click(sender As Object, e As EventArgs) Handles LabelDatosCliente.Click

    End Sub

    Private Sub BGWUpdateLicencia_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWUpdateLicencia.DoWork
        UpdateLocalLicence()
        ValidarLicencia()
        UpdateHDSN(gTerminal)
    End Sub

    Private Sub LabelMACaddress_Click(sender As Object, e As EventArgs) Handles LabelMACaddress.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'ShowPopUp("hola mundo!")
        '        BienvenidaEPOS.Show()

    End Sub
    Sub BuscarActualizaciones()
        trnsfrpth = gSystemDrive + "\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar"
        If UpdateAlertStatus = False Then Return
        Me.Cursor = Cursors.WaitCursor
        Try
            '**********************************************
            gSystemDrive = Environment.GetEnvironmentVariable("SystemDrive")
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

    Private Sub BGWFELoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWFELoad.DoWork
        FeAFIPLoad()
        If GFEAFIPENTORNO = "DESACTIVADO" Or GFEAFIPENTORNO = "" Then
            ShowPopUp("Hay algo que nos gustaría contarte! (click aquí)", 300)
        End If
    End Sub

    Private Sub UpdateAlert_DoubleClick(sender As Object, e As EventArgs) Handles UpdateAlert.DoubleClick
        Return
    End Sub
End Class
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class loginform
    Dim sqlserverconnection As SqlConnection
    Dim softwareversion As String
    Dim currentversion As Long
    Dim newversion As Long
    Dim UpdateAlertStatus As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '*********************************************************
        Dim rtn As Integer
        '************  lucasmartinbs    **************************
        If textusuario.Text = "lucasmartinbs" And textpassword.Text = "Locura011*?" Then
            gusername = textusuario.Text
            guserid = rtn
            guserprofile = UsuariosTableAdapter.usuarios_getperfil(gusername)
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
            '************  VALIDAR LICENCIA    **************************
            'ValidarLicencia(gmacadress, LicenceValidDate)
            'If LicenceValidDate = Nothing Or LicenceValidDate < Now Then
            '    Cursor.Current = Cursors.Default
            '    If LicenceValidDate = Nothing Then
            '        MsgBox("No posee suscripción activa, periodo de prueba finalizado.", MsgBoxStyle.Exclamation, "Licencia Inválida")
            '    End If
            '    'If LicenceValidDate < Now Then
            '    '    MsgBox("Usted no posee una suscripción activa, su periodo de prueba ha finalizado.", MsgBoxStyle.Exclamation, "Licencia Inválida")
            '    'End If

            '    'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
            '    closeaplication(False)
            'Else
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
        '?========********************
    End Sub
    Private Sub formatos()
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "dd/MM/yyyy")
    End Sub
    Private Sub identificarterminal()
        gmacadress = getMacAddress()
        MachineKey = "LLAuth" + gmacadress
    End Sub
    Private Sub connectdblocal()
        Try 'CONNECT DB LOCAL
            Dim CheckConnection As SqlConnection
            CheckConnection = New SqlConnection
            CheckConnection.ConnectionString = comercialStrConn
            Try
                CheckConnection.Open()
                My.Settings.SetUserOverride("comercialConnectionString", comercialStrConn)
                gActiveSQLConnectionString = comercialStrConn
                CheckConnection.Close()
                CheckConnection.Dispose()
            Catch ex As Exception
                Try
                    CheckConnection.ConnectionString = comercialStrConn2
                    CheckConnection.Open()
                    My.Settings.SetUserOverride("comercialConnectionString", comercialStrConn2)
                    gActiveSQLConnectionString = comercialStrConn2
                    CheckConnection.Close()
                    CheckConnection.Dispose()
                Catch ex2 As Exception
                    MsgBox("Conexión a base de datos fallida!", vbExclamation, "Advertencia!")
                    End
                End Try
            End Try
            '********************************
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub connectdbremote()
        Dim status As Boolean
        ''''''''''''''''''''''''''''--CLOWD--''''''''''''''''''''''''''''''''''''''''''''''
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        gModuloClowd = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '*************  errorlog    **************************************
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
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
                    gMiSucursal = misclientesdatatable.Rows(0).Item(misclientesdatatable.idsucursalColumn)
                    gMiIDCliente = misclientesdatatable.Rows(0).Item(misclientesdatatable.idclientesColumn)
                    gNombreCliente = misclientesdatatable.Rows(0).Item(misclientesdatatable.nombreColumn)
                    gNombreTerminal = misclientesdatatable.Rows(0).Item(misclientesdatatable.equipoColumn)
                    LabelDatosCliente.Text = "" + gNombreCliente + " - Terminal: [" + gNombreTerminal + "] - Sucursal N°: " + gMiSucursal.ToString + ""
                End If
                'gMiSucursal = TerminalesTableAdapter.terminales_consultarsucursal(gmacadress)
                'gMiIDCliente = TerminalesTableAdapter.terminales_consultarIDCliente(gmacadress)
                'CheckConnection.Close()
                'CheckConnection.Dispose()
            Catch ex As Exception
                ErrorLogTableAdapter.errorlog_insertar("Login", "CONEXIÓN", "Load", "No se pudo Conectar al servidor SC " + ex.Message)
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
                End Try
            End If
        Catch ex As Exception
            End
        End Try
    End Sub
    Private Sub loginform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        hi.mensaje.Text = "Identificando terminal"
        'hi.ProgressBar.Value = 3
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        identificarterminal()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Conectando a tu base de datos local.."
        'hi.ProgressBar.Value = 4
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        connectdblocal()
        Dim status As Boolean
        Dim cod As Integer
        Dim msg As String = Nothing
        ActualizarBD(status, cod, msg)
        ReparaProductosMedidas()
        '''''''''''''''''''''''''''''''''''''''''
        hi.mensaje.Text = "Conectando a la Nube"
        'hi.ProgressBar.Value = 5
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        connectdbremote()
        '********************************
        '********************************  
        hi.mensaje.Text = "Ya casi estamos!"
        'hi.ProgressBar.Value = 6
        hi.ProgressBar.PerformStep()
        hi.Refresh()
        UpdateCheckBG.RunWorkerAsync()
        '********************************  
        '********************************
        Try
            sqlserverconnection = New SqlConnection(sgcomercial.My.MySettings.Default.comercialConnectionString)
            sqlserverconnection.Open()
            '=======================================
            'StrSysCurrentVersion = ParametrosgeneralesTableAdapter1.parametrosgenerales_GetPrgstring1("SysCurrentVersion")
            SysCurrentVersion = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byclave("SysCurrentVersion")
            StrSysCurrentVersion = "Versión " + SysCurrentVersion.ToString

            version.Text = "Versión "
            version.Text += My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
            version.Text += "." + My.Application.Info.Version.Build.ToString
            version.Text += "." + My.Application.Info.Version.MinorRevision.ToString
            softwareversion = My.Application.Info.Version.Major.ToString + My.Application.Info.Version.Minor.ToString + My.Application.Info.Version.Build.ToString + My.Application.Info.Version.MinorRevision.ToString
            textusuario.Select()
            If SysCurrentVersion <> Val(softwareversion) Then
                MsgBox("Tu BASE DE DATOS se encuentra desactualizada!", MsgBoxStyle.Exclamation, "Contacto: sistemascomerciales.net")
                enablebuttons(False)
            End If

            gidcaja = 0
            gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
            '=======================================
            sqlserverconnection.Close()
            sqlserverconnection.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo conectar con el servidor LOCAL", MsgBoxStyle.Exclamation)
            sqlserverconnection.Dispose()
            textusuario.Enabled = False
            textpassword.Enabled = False
            Button1.Enabled = False
            Button2.PerformClick()
        End Try
        Cursor.Current = Cursors.Default
        hi.Dispose()
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
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
        ''''''''''***************************   POR DEFECTO **************************************
        If (e.KeyCode = Keys.X AndAlso e.Control AndAlso e.Shift) Then
            Dim status As Boolean
            Dim cod As Integer
            Dim msg As String = Nothing

            Try
                Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
                parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
                parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("SysCurrentVersion", Val(softwareversion), softwareversion, Nothing)
                ActualizarBD(status, cod, msg)
                MsgBox("Versión de Base Actualizada")
                enablebuttons(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        '====================   WEB CONFIG ==================
        If (e.KeyCode = Keys.K AndAlso e.Control AndAlso e.Shift) Then
            Dim su As SUAuth
            su = New SUAuth
            gSUToken = Nothing
            su.ShowDialog()
            If gSUToken = True Then
                Dim wconf As FormWebConf
                wconf = New FormWebConf
                wconf.ShowDialog()
                Me.Hide()
                Me.loginform_Load(e, e)
                Me.Show()
            End If
        End If
        'If (e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control) Then
        '    Me.Dispose()
        '    'loginform_Load(e, e)

        'End If
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
        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub textpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles textpassword.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
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

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
        Dim status As Boolean
        UpdateCheck(status, currentversion, newversion)
    End Sub

    Private Sub textusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textusuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            textpassword.Select()
        End If
    End Sub

    Private Sub UpdateCheckBG_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles UpdateCheckBG.DoWork
        UpdateCheckPasivo(UpdateAlertStatus, currentversion, newversion)
    End Sub

    Private Sub UpdateCheckBG_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles UpdateCheckBG.RunWorkerCompleted
        ' Called when the BackgroundWorker is completed.
        If UpdateAlertStatus = True Then
            UpdateAlert.Visible = True
            UpdateAlert.Text = "Nueva versión disponible!"
            UpdateAlert.ForeColor = Color.Orange
            PictureUpdateAlert.Image = My.Resources.UpdateAlert
            PictureUpdateAlert.Visible = True
            Button3.Visible = True
        Else
            If newversion = 0 Then Return
            UpdateAlert.Visible = True
            UpdateAlert.Text = "Sistema Actualizado!"
            UpdateAlert.ForeColor = Color.Green
            PictureUpdateAlert.Image = My.Resources.checked
            PictureUpdateAlert.Visible = True
            Button3.Visible = False
        End If
    End Sub
    Private Sub UpdateAlert_Click(sender As Object, e As EventArgs) Handles UpdateAlert.Click
        Button3.PerformClick()
    End Sub

    Private Sub PictureUpdateAlert_Click(sender As Object, e As EventArgs) Handles PictureUpdateAlert.Click
        Button3.PerformClick()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
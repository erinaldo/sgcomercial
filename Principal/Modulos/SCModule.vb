﻿Imports MySql.Data.MySqlClient
Imports System

Module SCModule
    '***********************************************************
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
                Dim terminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
                terminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
                'LicenceValidDate = terminalesTableAdapter.terminales_validarlicencia(gmacadress)
                table = terminalesTableAdapter.GetDataByDatosLicencia(gmacadress)
                LicenceValidDate = table.Rows(0).Item("fechabaja")
                '******************************************************
                If IsDBNull(table.Rows(0).Item("tipolicencia")) Then
                    gTipoLicencia = "P"
                Else
                    gTipoLicencia = table.Rows(0).Item("tipolicencia")
                End If
                '******************************************************
                If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) > 0 Then
                    parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave(MachineKey, Nothing, LicenceValidDate.ToString, Nothing) ' UPDATEA LOCAL
                    parametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("tipolicencia", Nothing, gTipoLicencia, Nothing)
                End If
            Catch ex As Exception
                Dim msg As String = ex.Message
                LicenceValidDate = Nothing
            End Try

        Catch ex As Exception
            LicenceValidDate = Nothing
        End Try
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
End Module

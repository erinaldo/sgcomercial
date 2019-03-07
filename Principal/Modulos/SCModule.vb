Imports MySql.Data.MySqlClient
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
    Public SCConn As MySqlConnection

    Sub conectarSCConn(ByRef status As Boolean)
        Try
            'MySQLConn = New MySqlConnection("Data Source=sistemascomerciales.net; Database=sistema1_sgcaguadagrande; User ID=sistema1_sgcweb; Password=sgcomercial*?; Allow Zero Datetime= true; CHARSET= latin1")
            'SCConn = New MySqlConnection(sgcomercial.My.MySettings.Default.SCConnectionString)
            SCConn = New MySqlConnection(SCStrConn)
            SCConn.Open()
            'MsgBox("Conexión exitosa!", MsgBoxStyle.Information, "SisCom")
            status = True
        Catch ex As Exception
            'MsgBox("No se pudo conectar con el servidor remoto: " + ex.Message, MsgBoxStyle.Information,"SisCom")
            SCConn.Dispose()
            status = False
        End Try
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
    Public Sub ValidarLicencia(ByVal mac As String, ByRef validdate As DateTime)
        '****Licencia local********
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '****   ----    ********
        If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) > 0 Then 'EXISTE LICENCIA LOCAL siiii
            Try
                'consultar la licencia local
                Dim resultado As String
                resultado = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1(MachineKey)
                LicenceValidDate = Convert.ToDateTime(resultado)
                If LicenceValidDate < Now Then
                    UpdateLocalLicence()
                End If
            Catch ex2 As Exception
                LicenceValidDate = Nothing
            End Try
        Else '  NO EXISTE LICENCIA LOCAL
            Try
                conectarSCConn(SCstatus)
                If SCstatus = False Then Return
                '*******************************************************************************
                '*************  terminalesTableAdapter    **************************************
                Try
                    Dim terminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
                    terminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
                    LicenceValidDate = terminalesTableAdapter.terminales_validarlicencia(mac)
                    If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) > 0 Then
                        parametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1(MachineKey, LicenceValidDate.ToString) ' UPDATEA LOCAL
                    Else
                        parametrosgeneralesTableAdapter.parametrosgenerales_insertar(MachineKey, Nothing, LicenceValidDate, Nothing, Nothing) ' INSERT LOCAL
                    End If
                Catch ex As Exception
                    LicenceValidDate = Nothing
                End Try
            Catch ex As Exception
                LicenceValidDate = Nothing
            End Try
        End If
    End Sub
    '******************************-----------------------------------------------------------------------------------*****************************
    Public Sub UpdateLocalLicence()
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
                LicenceValidDate = terminalesTableAdapter.terminales_validarlicencia(gmacadress)
                If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) > 0 Then
                    parametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1(MachineKey, LicenceValidDate.ToString) ' UPDATEA LOCAL
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

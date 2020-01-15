Imports MySql.Data.MySqlClient
Imports System
Imports System.Data.SqlClient

Module DBCModule
    '*************************  VARIABLES **********************************************************
    Public gCloudServer As String
    Public gSCdbserverauth As String
    Public gSCdbuserauth As String
    Public gCloudUserid As String
    Public gCloudPassword As String
    Public gCloudDatabase As String
    '/************  BASE DE DATOS LOCAL  *******************************/
    Public comercialStrConn As String = "Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?;Connect Timeout=1" 'LOCALHOST'
    Public comercialStrConn2 As String = "Data Source=SERVIDOR\SERVIDOR;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?;Connect Timeout=2" 'de terminal a SERVIDOR'
    Public comercialStrConnAlt As String = "Data Source=SERVIDOR\;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?;Connect Timeout=3" 'Alternativa de terminal a SERVIDOR'
    '/************  BASE DE DATOS REMOTA    *******************************/
    Public MySQLStrConn As String = ""
    ' "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_;persistsecurityinfo=True;Connect Timeout=3"
    '==== BLANK === Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=
    '/************  MASCARA  *******************************/
    '  Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=
    '  Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?


    Public Sub ArmaSTRConnWEB(status As Boolean)
        Try
            Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
            parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            gCloudServer = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBSERVERWEB")
            gCloudDatabase = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBWEB")
            gCloudUserid = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBUSERWEB")
            gCloudPassword = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBPWDWEB")
            gSCdbserverauth = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbserverauth")
            gSCdbuserauth = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbuserauth")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            MySQLStrConn = "server=" + gCloudServer + ";" + "user id=" + gCloudUserid + ";" + "password=" + gCloudPassword + ";" + "database=" + gCloudDatabase + ";persistsecurityinfo=True;Connect Timeout=25"
            SCStrConn = "server=" + gSCdbserverauth + ";" + "user id=" + gSCdbuserauth + ";" + "password=" + gCloudPassword + ";database=sistema1_siscom;persistsecurityinfo=True;Connect Timeout=25"
        Catch ex As Exception
            MsgBox("No se pudo Construir el string de conexión al servidor remoto: " + ex.Message, MsgBoxStyle.Information, "DBWEB")
            status = False
        End Try

    End Sub


    '****   ----    ********
    'If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey)
    '====PROD===
    'Public MySQLStrConn As String = "server=innovapps.com.ar;user id=lucaspor_lcweb;password=@Lacosechaweb18;database=lucaspor_sgcaguadagrande;persistsecurityinfo=True"
    '====DESA===
    'Public MySQLStrConn As String = "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_sgcaguadagrande;persistsecurityinfo=True"
    '==== BLANK ===   server=;user id=;password=;database=;persistsecurityinfo=True
    'server=;user id=;password=;database=;persistsecurityinfo=True
    '--jorge cabrera--Public MySQLStrConn As String = "server=innovapps.com.ar;user id=lucaspor_lcweb;password=@Lacosechaweb18;database=lucaspor_sgcaguadagrande;persistsecurityinfo=True"

    'Public EntitiesStrConn As String = "metadata=res://*/Delivery.Model1.csdl|res://*/Delivery.Model1.ssdl|res://*/Delivery.Model1.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;persistsecurityinfo=True;database=sistema1_sgcaguadagrande&quot;"
    'Public EntitiesStrConn As String = "metadata=res://*/Delivery.Model1.csdl|res://*/Delivery.Model1.ssdl|res://*/Delivery.Model1.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=;user id=;password=;persistsecurityinfo=True;database=&quot;"
    Public Sub connectdblocal()
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
                    Try
                        '******************************
                        Try
                            Dim fileReader As System.IO.StreamReader
                            fileReader =
                            My.Computer.FileSystem.OpenTextFileReader(gSystemDrive + "\\SGComercial\\BD\\comercialStrConnAlt.txt")
                            comercialStrConnAlt = fileReader.ReadLine()
                            'MsgBox("The first line of the file is " & stringReader)
                        Catch exw As Exception
                            MsgBox("Conexión a base de datos fallida!", vbExclamation, "Advertencia!")
                            End
                        End Try
                        '******************************
                        CheckConnection.ConnectionString = comercialStrConnAlt
                        CheckConnection.Open()
                        My.Settings.SetUserOverride("comercialConnectionString", comercialStrConnAlt)
                        gActiveSQLConnectionString = comercialStrConnAlt
                        CheckConnection.Close()
                        CheckConnection.Dispose()
                    Catch ex3 As Exception
                        MsgBox("Conexión a base de datos fallida!", vbExclamation, "Advertencia!")
                        End
                    End Try
                    'MsgBox("Conexión a base de datos fallida!", vbExclamation, "Advertencia!")
                    'End
                End Try
            End Try
            '********************************
        Catch ex As Exception
            End
        End Try
    End Sub
End Module

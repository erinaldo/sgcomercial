Imports MySql.Data.MySqlClient
Imports System
Module DBCModule
    '/************  BASE DE DATOS LOCAL  *******************************/
    Public comercialStrConn As String = "Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?" 'AGUADA-PROD'
    '/************  BASE DE DATOS REMOTA    *******************************/
    Public MySQLStrConn As String = "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_ulala;persistsecurityinfo=True"
    '==== BLANK === Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=


    '/************  MASCARA  *******************************/
    '  Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=
    '  Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?


    Public Sub ArmaSTRConnWEB(status As Boolean)
        Try
            Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
            parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
            Dim server As String
            Dim userid As String
            Dim password As String
            Dim database As String

            server = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBSERVERWEB")
            database = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBWEB")
            userid = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBUSERWEB")
            password = parametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("DBPWDWEB")
            MySQLStrConn = "server=" + server + ";" + "user id=" + userid + ";" + "password=" + password + ";" + "database=" + database + ";persistsecurityinfo=True"

        Catch ex As Exception
            MsgBox("No se Construir el string de conexión al servidor remoto: " + ex.Message, MsgBoxStyle.Information, "DBWEB")
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
End Module

﻿Module DBCModule
    '/************  BASE DE DATOS LOCAL  *******************************/


    Public comercialStrConn As String = "Data Source=SERVIDOR\SERVIDOR;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?" 'AGUADA-PROD'
    'Public comercialStrConn As String = "Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?" 'DESA-local'
    '==== BLANK === Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=


    '/************  MASCARA  *******************************/
    '  Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=
    '  Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?


    '/************  BASE DE DATOS REMOTA    *******************************/
    '====PROD===
    'Public MySQLStrConn As String = "server=innovapps.com.ar;user id=lucaspor_lcweb;password=@Lacosechaweb18;database=lucaspor_sgcaguadagrande;persistsecurityinfo=True"
    '====DESA===
    'Public MySQLStrConn As String = "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_sgcaguadagrande;persistsecurityinfo=True"
    '==== BLANK ===   server=;user id=;password=;database=;persistsecurityinfo=True
    'server=;user id=;password=;database=;persistsecurityinfo=True
    Public MySQLStrConn As String = "server=innovapps.com.ar;user id=lucaspor_lcweb;password=@Lacosechaweb18;database=lucaspor_sgcaguadagrande;persistsecurityinfo=True"
    'Public MySQLStrConn As String = "server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;database=sistema1_sgcaguadagrande;persistsecurityinfo=True"
    'Public EntitiesStrConn As String = "metadata=res://*/Delivery.Model1.csdl|res://*/Delivery.Model1.ssdl|res://*/Delivery.Model1.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=sistemascomerciales.net;user id=sistema1_sgcweb;password=sgcomercial*?;persistsecurityinfo=True;database=sistema1_sgcaguadagrande&quot;"
    'Public EntitiesStrConn As String = "metadata=res://*/Delivery.Model1.csdl|res://*/Delivery.Model1.ssdl|res://*/Delivery.Model1.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=;user id=;password=;persistsecurityinfo=True;database=&quot;"
End Module

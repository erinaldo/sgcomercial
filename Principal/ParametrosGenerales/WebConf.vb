Public Class WebConf
    Private Sub FormWebConf_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MsgBox("Seguro desea guardar la configuración?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Try
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbserverweb", Nothing, TextBox1.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbweb", Nothing, TextBox2.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbuserweb", Nothing, TextBox3.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbpwdweb", Nothing, TextBox4.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbuserauth", Nothing, TextBox5.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbserverauth", Nothing, TextBox6.Text, Nothing)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub FormWebConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbserverweb")
        TextBox2.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbweb")
        TextBox3.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbuserweb")
        TextBox4.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbpwdweb")
        TextBox5.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbuserauth")
        TextBox6.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbserverauth")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Seguro desea guardar la configuración?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbserverweb", Nothing, TextBox1.Text, Nothing)
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbweb", Nothing, TextBox2.Text, Nothing)
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbuserweb", Nothing, TextBox3.Text, Nothing)
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbpwdweb", Nothing, TextBox4.Text, Nothing)
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbuserauth", Nothing, TextBox5.Text, Nothing)
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("dbserverauth", Nothing, TextBox6.Text, Nothing)
                connectdbremote()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub connectdbremote()
        Dim status As Boolean
        ''''''''''''''''''''''''''''--CLOWD--''''''''''''''''''''''''''''''''''''''''''''''
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        Try
            gModuloClowd = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
        Catch ex As Exception
            Return
        End Try
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
                    MsgBox("" + gNombreCliente + " - Terminal: [" + gNombreTerminal + "] - Sucursal N°: " + gMiSucursal.ToString + "", MsgBoxStyle.Information, "Auth SistemasComerciales")
                End If
                'gMiSucursal = TerminalesTableAdapter.terminales_consultarsucursal(gmacadress)
                'gMiIDCliente = TerminalesTableAdapter.terminales_consultarIDCliente(gmacadress)
                'CheckConnection.Close()
                'CheckConnection.Dispose()
            Catch ex As Exception
                ErrorLogTableAdapter.errorlog_insertar("Auth SC", "CONEXIÓN", "Load", "No se pudo Conectar al servidor SC " + ex.Message)
                MsgBox(ex.Message, vbExclamation, "No se puede conectar con SistemasComerciales")
            End Try
            Try
                Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
                ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
                Dim ProductosWEBTable As MySQLDataSet.productosDataTable
                ProductosWEBTable = ProductosWEBTableAdapter.GetData
                MsgBox("Conexión exitosa", MsgBoxStyle.Information, "Auth Clowd")
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation, "No se puede conectar con la NUBE")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sca As New SCAltaDispositivo()
        sca.ShowDialog()

    End Sub
End Class
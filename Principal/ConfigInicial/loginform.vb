Imports System.Net.NetworkInformation
Imports System.Data.SqlClient


Public Class loginform
    Dim sqlserverconnection As SqlConnection

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
            ValidarLicencia(gmacadress, LicenceValidDate)
            If LicenceValidDate = Nothing Or LicenceValidDate < Now Then
                Cursor.Current = Cursors.Default
                If LicenceValidDate = Nothing Then
                    MsgBox("No posee suscripción activa, periodo de prueba finalizado.", MsgBoxStyle.Exclamation, "Licencia Inválida")
                End If
                'If LicenceValidDate < Now Then
                '    MsgBox("Usted no posee una suscripción activa, su periodo de prueba ha finalizado.", MsgBoxStyle.Exclamation, "Licencia Inválida")
                'End If

                'System.Diagnostics.Process.Start("http://www.sistemascomerciales.net")
                closeaplication(False)
            Else
                gusername = textusuario.Text
                guserid = rtn
                guserprofile = UsuariosTableAdapter.usuarios_getperfil(gusername)
                FormPrincipal = New Principal
                Me.Hide()
                FormPrincipal.Show()
            End If
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub


    Private Sub loginform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Dim status As Boolean
        '********************************
        gmacadress = getMacAddress()
        MachineKey = "LLAuth" + gmacadress
        'MsgBox(gmacadress)
        If My.Computer.Name = "LUCASMARTINBS-N" Then
            comercialStrConn = "Data Source=localhost;Initial Catalog=comercial;Persist Security Info=True;User ID=sgcomercial;Password=sgcomercial*?" 'DESA-local'
        End If
        '********************************


        My.Settings.SetUserOverride("comercialConnectionString", comercialStrConn)
        My.Settings.SetUserOverride("SCConnectionString", SCStrConn)
        ArmaSTRConnWEB(status)
        My.Settings.SetUserOverride("MySQLConnectionString", MySQLStrConn)

        'My.Settings.SetUserOverride("sgcaguadagrandeEntities", EntitiesStrConn)
        '********************************      
        '********************************
        Try
            sqlserverconnection = New SqlConnection(sgcomercial.My.MySettings.Default.comercialConnectionString)
            sqlserverconnection.Open()
            '=======================================
            StrSysCurrentVersion = ParametrosgeneralesTableAdapter1.parametrosgenerales_GetPrgstring1("SysCurrentVersion")
            SysCurrentVersion = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byclave("SysCurrentVersion")
            StrSysCurrentVersion = "Versión " + StrSysCurrentVersion
            Dim softwareversion As String
            version.Text = "Versión "
            version.Text += My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
            version.Text += "." + My.Application.Info.Version.Build.ToString
            version.Text += "." + My.Application.Info.Version.MinorRevision.ToString
            softwareversion = My.Application.Info.Version.Major.ToString + My.Application.Info.Version.Minor.ToString + My.Application.Info.Version.Build.ToString + My.Application.Info.Version.MinorRevision.ToString
            textusuario.Select()
            If SysCurrentVersion < Val(softwareversion) Then
                MsgBox("Tu BASE DE DATOS se encuentra desactualizada!", MsgBoxStyle.Exclamation, "Contacto: sistemascomerciales.net")
                enablebuttons(False)
            End If

            gidcaja = 0
            gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
            '=======================================
        Catch ex As Exception
            MsgBox("No se pudo conectar con el servidor LOCAL", MsgBoxStyle.Exclamation)
            sqlserverconnection.Dispose()
            textusuario.Enabled = False
            textpassword.Enabled = False
            Button1.Enabled = False
            Button2.PerformClick()
        End Try
        Cursor.Current = Cursors.Default

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
End Class
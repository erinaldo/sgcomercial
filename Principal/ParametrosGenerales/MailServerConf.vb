Public Class MailServerConf
    Private Sub MailServerConf_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then

            If MsgBox("Seguro desea guardar la configuración?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Try
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("SmtpClient", Nothing, TSmtpClient.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("EmailFrom", Nothing, TEmailFrom.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("EmailFromPwd", Nothing, TEmailFromPwd.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("EmailPort", Val(TEmailPort.Text), Nothing, Nothing)
                    MsgBox("Datos Guardados!", MsgBoxStyle.Information)
                    '*************************  CONSULTO PARAMETROS DE SMTP **********************************************
                    SmtpClient = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("SmtpClient")
                    EmailFrom = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFrom")
                    EmailFromPwd = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFromPwd")
                    EmailPort = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("EmailPort")
                    '*************************  ENVIO EMAIL **********************************************
                    Me.Cursor = Cursors.WaitCursor
                    If ModuloUtilidades.clsSendMail.SendEMail(EmailFrom, "lucasmartinbs@gmail.com", "Email de Prueba", "Cuerpo del mail de Prueba", EmailFrom, EmailFromPwd, SmtpClient, Nothing) = True Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Enviado!", MsgBoxStyle.Information)
                    Else
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo enviar el Email!", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub MailServerConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TSmtpClient.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("SmtpClient")
            TEmailFrom.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFrom")
            TEmailFromPwd.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFromPwd")
            TEmailPort.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("EmailPort")
        Catch ex As Exception

        End Try
    End Sub
End Class
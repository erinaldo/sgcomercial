Public Class FormWebConf
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
End Class
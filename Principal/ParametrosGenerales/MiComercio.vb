Imports System.Text.RegularExpressions
Public Class MiComercio
    Private Sub ParametrosgeneralesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ParametrosgeneralesBindingNavigatorSaveItem.Click
        If Len(Trim(textnombrecomercio.Text)) = 0 Or Len(Trim(textcuitcuil.Text)) = 0 Or Len(Trim(texttelefono.Text)) = 0 Or Len(Trim(textdireccion.Text)) = 0 Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Información")
            Return
        End If
        '***********************        solicitar confirmación       **************************
        If MsgBox("Seguro desea guardar los datos del comercio?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Me.Validate()
            Me.ParametrosgeneralesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            Me.Close()
        Else
            MsgBox("Operación cancelada", MsgBoxStyle.Information, "Informacion")
            ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
            Return
        End If
        ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("NombreComercio", textnombrecomercio.Text)
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("MiRazonSocial", Nothing, TextRazonSocial.Text, Nothing)
        ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("CuitCuil", textcuitcuil.Text)
        ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("Telefono", texttelefono.Text)
        ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("Direccion", textdireccion.Text)
        '*************************************************************************************************
        '***************    impresion TICKET AL FINALIZAR VENTA ******************************************
        If Radionunca.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionTicket", "Nunca")
        End If
        If Radiosiempre.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionTicket", "Siempre")
        End If
        If Radiopreguntar.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionTicket", "Preguntar")
        End If
        '****************************************************************************************************
        '*************************************************************************************************
        '***************    impresion CIERRE DE CAJA AL CERRAR CAJA ******************************************
        If CajaRBNunca.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionCierreCaja", "Nunca")
        End If
        If CajaRBSiempre.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionCierreCaja", "Siempre")
        End If
        If CajaRBPreguntar.Checked = True Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("ImpresionCierreCaja", "Preguntar")
        End If
        '*************************************************************************************************
        '***************    BCScanerCR ******************************************
        Select Case gidcaja
            Case 1
                Select Case ComboBoxSaltoCarro.Text
                    Case "Sin Salto"
                        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("BCScanerCR1", 1, "Disable", Nothing)
                    Case "Con Salto"
                        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("BCScanerCR1", 1, "Enable", Nothing)
                End Select
            Case 2
                Select Case ComboBoxSaltoCarro.Text
                    Case "Sin Salto"
                        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("BCScanerCR2", 2, "Disable", Nothing)
                    Case "Con Salto"
                        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("BCScanerCR2", 2, "Enable", Nothing)
                End Select
        End Select
        '*****************************************************************************************************
        '***************    ValidarSTK ******************************************
        Select Case ComboBoxvalidarstock.Text
            Case "SI"
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("ValidarSTK", 1, "Enable", Nothing)
            Case "NO"
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("ValidarSTK", 1, "Disable", Nothing)
        End Select
        '*****************************************************************************************************
        '***************    RecargoTC   ******************************************
        Dim recargo As Decimal = TextBoxRecargoTC.Text
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("RecargoTC", Nothing, "Enable", recargo)
        '***************    -----------     FIN     ------------  ******************************************
        '***************    RecargoCC   ******************************************
        Dim recargoCC As Decimal = TextBoxRecargoCC.Text
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("RecargoCC", Nothing, "Enable", recargoCC)
        '***************    -----------     FIN     ------------  ******************************************
        '*****************************************************************************************************
        '***************    BalPrefix   ******************************************
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("BalPrefix", Nothing, balprefix.Text, Nothing)
        '***************    -----------     FIN     ------------  ******************************************
        '***************    EmailCierreCajaTo   ******************************************
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("EmailCierreCajaTo", Nothing, EmailCierreCajaTo.Text, Nothing)
        '***************    -----------     FIN     ------------  ******************************************
        '***************    ComandaDefault   ******************************************
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("ComandaDefault", Nothing, ComboBoxComandaDefault.Text, Nothing)
        '***************    -----------     FIN     ------------  ******************************************
        '***************    ComandaDefault   ******************************************
        ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("ModPVV", Nothing, ComboModPV.Text, Nothing)
        '********** FEAutoCAEAFIP
        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
            ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("FEAutoCAEAFIP", Nothing, ComboFEAutoCAEAFIP.Text, Nothing)
        End If
        '***************    -----------     FIN     ------------  ******************************************
    End Sub


    Private Sub MiComercio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.parametrosgenerales' Puede moverla o quitarla según sea necesario.
        Me.ParametrosgeneralesTableAdapter.Fill(Me.ComercialDataSet.parametrosgenerales)
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "LogoComercio")
        enablebuttons(True)

        textnombrecomercio.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio")
        TextRazonSocial.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("MiRazonSocial")
        textcuitcuil.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("CuitCuil")
        textdireccion.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("Direccion")
        texttelefono.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("Telefono")
        '****** impresion TICKET
        Dim impresion As String
        impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionTicket")
        Select Case impresion
            Case "Nunca"
                Radionunca.Checked = True
            Case "Siempre"
                Radiosiempre.Checked = True
            Case "Preguntar"
                Radiopreguntar.Checked = True
        End Select
        '********** impresion CIERRE CAJA
        impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionCierreCaja")
        Select Case impresion
            Case "Nunca"
                CajaRBNunca.Checked = True
            Case "Siempre"
                CajaRBSiempre.Checked = True
            Case "Preguntar"
                CajaRBPreguntar.Checked = True
        End Select
        '**********
        '********** BCScanerCR
        Select Case gidcaja
            Case 1
                impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BCScanerCR1")
            Case 2
                impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BCScanerCR2")
        End Select
        Select Case impresion
            Case "Enable"
                ComboBoxSaltoCarro.SelectedIndex = 1
            Case "Disable"
                ComboBoxSaltoCarro.SelectedIndex = 0
        End Select
        '**********
        '********** ValidarSTK
        impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValidarSTK")
        Select Case impresion
            Case "Enable"
                ComboBoxvalidarstock.SelectedIndex = 0
            Case "Disable"
                ComboBoxvalidarstock.SelectedIndex = 1
        End Select
        '**********
        '********** RecargoTC
        Dim recargo As Decimal
        recargo = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgdecimal1("RecargoTC")
        TextBoxRecargoTC.Text = recargo
        '**********
        '********** RecargoCC
        'Dim recargo As Decimal
        recargo = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgdecimal1("RecargoCC")
        TextBoxRecargoCC.Text = recargo
        '**********
        '********** BalPrefix
        Dim VBalPrefix As String
        VBalPrefix = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BalPrefix")
        balprefix.Text = VBalPrefix
        '**********
        '********** EmailCierreCajaTo
        Dim V_EmailCierreCajaTo As String
        V_EmailCierreCajaTo = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailCierreCajaTo")
        EmailCierreCajaTo.Text = V_EmailCierreCajaTo
        '**********
        '********** ComandaDefault
        Dim V_ComandaDefault As String
        V_ComandaDefault = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ComandaDefault")
        ComboBoxComandaDefault.Text = V_ComandaDefault
        '**********
        '********** ComandaDefault
        Dim V_ModPVV As String
        V_ModPVV = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ModPVV")
        ComboModPV.Text = V_ModPVV
        '**********
        '********** FEAutoCAEAFIP
        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
            Dim V_FEAutoCAEAFIP As String
            V_FEAutoCAEAFIP = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("FEAutoCAEAFIP")
            ComboFEAutoCAEAFIP.Text = V_FEAutoCAEAFIP
        Else
            GroupBoxFEAFIP.Enabled = False
        End If
        '**********
        textnombrecomercio.Select()
    End Sub
    Private Sub enablebuttons(ByVal status As Boolean)
        textnombrecomercio.Enabled = status
        textcuitcuil.Enabled = status
        textdireccion.Enabled = status
        texttelefono.Enabled = status
    End Sub

    Private Sub MiComercio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '*****************
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "c:\Users"
            OpenFileDialog1.Filter = "Image files (*.jpg)|*.jpg"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            '******************** codigo para leer el archivo como stream
            'Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            'MessageBox.Show(sr.ReadToEnd)
            'sr.Close()
            '******************* codigo para leer el archivo como stream
        End If
        '**********************
    End Sub

    Private Sub Radionunca_CheckedChanged(sender As Object, e As EventArgs) Handles Radionunca.CheckedChanged

    End Sub

    Private Sub TextBoxRecargoTC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecargoTC.TextChanged
        If TextBoxRecargoTC.Text = "" Then
            Return
        End If
        Try
            Convert.ToDecimal(TextBoxRecargoTC.Text)
        Catch ex As Exception
            MsgBox("ingrese un porcentaje válido!")
            TextBoxRecargoTC.SelectAll()
        End Try

    End Sub

    Private Sub TextBoxRecargoTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxRecargoTC.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBoxRecargoCC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecargoCC.TextChanged
        If TextBoxRecargoCC.Text = "" Then
            Return
        End If
        Try
            Convert.ToDecimal(TextBoxRecargoCC.Text)
        Catch ex As Exception
            MsgBox("ingrese un porcentaje válido!")
            TextBoxRecargoCC.SelectAll()
        End Try

    End Sub

    Private Sub TextBoxRecargoCC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxRecargoCC.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub
End Class
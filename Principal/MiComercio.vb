﻿Imports System.Text.RegularExpressions
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


    End Sub


    Private Sub MiComercio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.parametrosgenerales' Puede moverla o quitarla según sea necesario.
        Me.ParametrosgeneralesTableAdapter.Fill(Me.ComercialDataSet.parametrosgenerales)
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "LogoComercio")
        enablebuttons(True)

        textnombrecomercio.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("NombreComercio")
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
    End Sub
    Private Sub enablebuttons(ByVal status As Boolean)
        textnombrecomercio.Enabled = status
        textcuitcuil.Enabled = status
        textdireccion.Enabled = status
        texttelefono.Enabled = status
    End Sub

    Private Sub MiComercio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
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
End Class
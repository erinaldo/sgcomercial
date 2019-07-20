Imports System.IO
Imports System.Net.Mail

Public Class ViewerFactura
    Private Sub ViewerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim V_ComandaDefault As String
        V_ComandaDefault = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ComandaDefault")
        '**********
        Select Case V_ComandaDefault
            Case "80MM"
                Comanda80mmToolStripMenuItem.PerformClick()
            Case "58MM"
                Comanda58mmToolStripMenuItem.PerformClick()
            Case "A4"
                HojaA4ToolStripMenuItem.PerformClick()
        End Select
        Me.Select()
    End Sub

    Private Sub HojaA4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HojaA4ToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        If libroventasTableAdapter.libroventas_consultar_tipocomprobante(gidventa) = "Factura A" Then
            'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaIVA.rdlc"
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaElectronica.rdlc"
            Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Else
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaElectronica.rdlc"
            Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
            'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFactura.rdlc"
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Comanda80mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda80mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera80.rdlc"
        'Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Comanda58mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda58mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera58.rdlc"
        'Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ViewerFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            ''''''''''***************************   POR DEFECTO **************************************
            If e.KeyCode = Keys.Escape Then
                If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    Me.Close()
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                ReportViewer1.PrintDialog()
                Me.Close()
            End If
            ''''''''''''''''''''*******************************************'''''''''''''''''''''
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_KeyDown(sender As Object, e As KeyEventArgs) Handles ReportViewer1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ReportViewer1.PrintDialog()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub ViewerFactura_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print

    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin

    End Sub

    Private Sub EnviarPorEMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorEMailToolStripMenuItem.Click
        Dim p As New GetMailCliente
        p.ShowDialog()
        If IsValidEmailFormat(EmailTo) Then
            EmailTicketComprobante()
        Else
            MessageBox.Show("E-mail Inválido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Public Sub EmailTicketComprobante()
        Dim ArchivoAdjunto As String
        ArchivoAdjunto = gPublicDocumentsPath + "\TicketComprobante_" + gidventa.ToString + ".pdf"
        Try
            FileSystem.Kill(ArchivoAdjunto)
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.WaitCursor
        Try
            '*******************************
            Me.ReportViewer1.RefreshReport()
            '*******************************
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(ArchivoAdjunto, FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
        '****************** COMIENZA EL ENVIO DE MAIL   ********************
        '**********************************************************
        'CreateObject("WScript.Shell").Popup("Enviando Email... -NO APAGUE EL SISTEMA-", 1, "Aviso!", vbInformation)
        Dim emailmessage As New MailMessage()
        Dim EmailSubject As String = "Ticket de tu compra"
        Dim EmailBody As String = "Cuidamos el medio ambiente, te acercamos el ticket comprobante de tu compra. Gracias por elegirnos."
        Me.Cursor = Cursors.WaitCursor
        Try
            '*************************  CONSULTO PARAMETROS DE SMTP **********************************************
            SmtpClient = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("SmtpClient")
            EmailFrom = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFrom")
            EmailFromPwd = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFromPwd")
            EmailPort = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("EmailPort")
            '*************************  ENVIO EMAIL **********************************************
            If ModuloUtilidades.clsSendMail.SendEMail(EmailFrom, EmailTo, EmailSubject, EmailBody, EmailFrom, EmailFromPwd, SmtpClient, ArchivoAdjunto) = True Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail del cierre de caja ha sido exitoso!", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail falló! Verifíque su conexión a internet", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Me.Cursor = Cursors.Default
            EmailTo = Nothing
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EmailTo = Nothing
        End Try
    End Sub
End Class
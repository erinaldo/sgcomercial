﻿'Imports System.ComponentModel
Imports System.IO
Imports System.Net.Mail
'Imports System.Net
'Imports System.Text

Public Class ViewerReporteCC
    Private Sub ViewerReporteCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librocuentascorrientes' Puede moverla o quitarla según sea necesario.
        Me.librocuentascorrientesTableAdapter.Fill(Me.comercialDataSet.librocuentascorrientes)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub mail_LibroCC()
        Me.Cursor = Cursors.WaitCursor
        Dim ArchivoAdjunto As String
        Dim rnd As New Random
        Dim chrInt As Integer = 0
        chrInt = rnd.Next(1130, 9022)
        ArchivoAdjunto = "LibrodeCuentasCorrientes" + chrInt.ToString + ".pdf"
        Try
            '*******************************
            'Me.CajaseventosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajaseventos, gidevento)
            'Me.librodiarioTableAdapter.FillByIdevento(Me.ComercialDataSet.librodiario, gidevento)
            'Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gidevento)
            'Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

            'Me.ReportViewer1.RefreshReport()
            'Return
            Me.Cursor = Cursors.Default
            If MsgBox("Esta seguro que desea enviar el informe por Email? el proceso tomará unos segundos...", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
                MsgBox("Envío cancelado!", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            'Threading.Thread.Sleep(5000)
            '*******************************
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(ArchivoAdjunto, FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudo Crear el documento: " + ex.Message)
        End Try
        'Return
        '**********************************************************
        Dim emailmessage As New MailMessage()
        Dim EmailFrom As String
        Dim EmailFromPwd As String
        Dim EmailPort As Long
        Dim EmailCierreCajaTo As String
        Dim SmtpClient As String

        Try
            '***************************************************************
            EmailCierreCajaTo = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailCierreCajaTo")
            If EmailCierreCajaTo.Length = 0 Then
                'MsgBox("Dirección Inválida", MsgBoxStyle.Exclamation, "Envío email")
                Me.Cursor = Cursors.Default
                Return
            End If
            SmtpClient = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("SmtpClient")
            EmailFrom = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFrom")
            EmailFromPwd = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFromPwd")
            EmailPort = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("EmailPort")
            '***************************************************************
            emailmessage.From = New MailAddress(EmailFrom)
            emailmessage.To.Add(EmailCierreCajaTo)
            emailmessage.Subject = "Libro de Cuentas Corrientes " + Today.ToShortDateString
            emailmessage.Body = "Sistema de Gestión Comercial te envió el Libro de Cuentas Corrientes al dia de la fecha"
            '*************************  ADJUNTO **********************************************
            Dim fileTXT As String = ArchivoAdjunto.ToString
            Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(fileTXT)
            data.Name = ArchivoAdjunto.ToString '"CierreCaja.pdf"
            emailmessage.Attachments.Add(data)
            '*********************************************************************************
            Dim smtp As New SmtpClient(SmtpClient)
            smtp.Port = EmailPort
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(EmailFrom, EmailFromPwd)
            smtp.Timeout = 10
            'smtp.Send(emailmessage)
            smtp.SendAsync(emailmessage, gUserToken)
            Me.Cursor = Cursors.Default
            MsgBox("Operacion finalizada!", MsgBoxStyle.Information, "Envío email")

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnviarPorMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorMailToolStripMenuItem.Click
        mail_LibroCC()
    End Sub
End Class
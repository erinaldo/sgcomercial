Imports System.IO
Imports System.Net.Mail
Public Class ViewerFacturaSiscom
    Private Sub ViewerFacturaSiscom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor
            'TODO: esta línea de código carga datos en la tabla 'siscomDataSet.libroventas' Puede moverla o quitarla según sea necesario.
            Me.libroventasTableAdapter.FillByIDVenta(Me.siscomDataSet.libroventas, gidventaSC)
            'TODO: esta línea de código carga datos en la tabla 'siscomDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
            Me.libroventasdetalleTableAdapter.FillByIDVenta(Me.siscomDataSet.libroventasdetalle, gidventaSC)

            Me.ReportViewer1.RefreshReport()
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Ocurrio una excepción al consultar los datos: " + ex.Message)
        End Try

    End Sub

    Private Sub EnviarPorEMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorEMailToolStripMenuItem.Click
        EmailTo = libroventasTableAdapter.libroventas_getmailcliente(gidventaSC)
        Dim p As New GetMailCliente
        'EmailTo = Nothing
        p.ShowDialog()
        If IsValidEmailFormat(EmailTo) Then
            EmailTicketComprobante()
        Else
            MessageBox.Show("E-mail Inválido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Public Sub EmailTicketComprobante()
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
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
            If ModuloUtilidades.clsSendMail.SendEMail("Sistemas Comerciales", EmailFrom, EmailTo, EmailSubject, EmailBody, EmailFrom, EmailFromPwd, SmtpClient, ArchivoAdjunto) = True Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail ha sido exitoso!", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub ViewerFacturaSiscom_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
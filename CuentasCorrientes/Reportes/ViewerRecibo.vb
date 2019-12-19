Imports System.IO
Imports System.Net.Mail
Public Class ViewerRecibo
    Private Sub ViewerRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapagos' Puede moverla o quitarla según sea necesario.
            Me.listapagosTableAdapter.FillByIDPagos(Me.comercialDataSet.listapagos, gidpago)
            'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
            Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Excepción: " + ex.Message)
            Me.Close()
        End Try

    End Sub

    Private Sub EnviarPorMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarPorMailToolStripMenuItem.Click
        mail_Recibo()
    End Sub
    Private Sub mail_Recibo()
        Me.Cursor = Cursors.WaitCursor
        Dim ArchivoAdjunto As String = Nothing
        Dim rnd As New Random
        Dim chrInt As Integer = 0
        chrInt = rnd.Next(1130, 9022)
        Try
            '*******************************
            ArchivoAdjunto = gPublicDocumentsPath + "\ComprobantePagoRecibido" + chrInt.ToString + ".pdf"
            'Me.CajaseventosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajaseventos, gidevento)
            'Me.librodiarioTableAdapter.FillByIdevento(Me.ComercialDataSet.librodiario, gidevento)
            'Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gidevento)
            'Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

            'Me.ReportViewer1.RefreshReport()
            'Return
            'Me.Cursor = Cursors.Default

            'Me.Cursor = Cursors.WaitCursor
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
            MsgBox("No se pudo Crear el documento PDF: " + ex.Message)
            Return
        End Try
        'Return
        '**********************************************************
        Dim emailmessage As New MailMessage()
        Dim EmailFrom As String
        Dim EmailFromPwd As String
        Dim EmailCierreCajaTo As String
        Dim SmtpClient As String
        Dim EmailSubject As String
        Dim EmailBody As String
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
            'emailmessage.From = New MailAddress(EmailFrom)
            '-------------  get email address   ---------------
            gidcliente = PagosTableAdapter.pagos_GetIdCliente(gidpago)
            Dim kh As GetMailCliente
            kh = New GetMailCliente
            kh.ShowDialog()
            gidcliente = Nothing
            '------------- 
            emailmessage.To.Add(EmailTo) ' EmailCierreCajaTo
            EmailSubject = "Comprobante de Pago Recibido " + Today.ToShortDateString
            EmailBody = "Te enviamos tu comprobante de pago."
            '*************************  CONSULTO PARAMETROS DE SMTP **********************************************
            SmtpClient = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("SmtpClient")
            EmailFrom = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFrom")
            EmailFromPwd = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("EmailFromPwd")
            EmailPort = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("EmailPort")
            '*************************  ENVIO EMAIL **********************************************
            If ModuloUtilidades.clsSendMail.SendEMail(gNombreComercio, EmailFrom, EmailCierreCajaTo, EmailSubject, EmailBody, EmailFrom, EmailFromPwd, SmtpClient, ArchivoAdjunto) = True Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail ha sido exitoso!", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail falló! Verifíque su conexión a internet", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
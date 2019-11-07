Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Module ModuloUtilidades
    Public Class clsSendMail
        Public Shared Function SendEMail(ByVal strRtte As String, ByVal strOrigen As String, ByVal strDestinatario As String, ByVal strAsunto As String, ByVal strMsg As String, ByVal usuario As String, ByVal Clave As String, ByVal smtp As String, ByVal Adjunto As String) As Boolean
            Dim msg As New MailMessage()
            msg.[To].Add(New MailAddress(strDestinatario))
            msg.From = New MailAddress("no-reply@sistemascomerciales.net", strRtte)
            'msg.Headers.Add("Reply-to", "no-reply@sistemascomerciales.net")
            msg.ReplyToList.Add("no-reply@sistemascomerciales.net")
            msg.Subject = strAsunto
            msg.Body = strMsg
            'Adjuntar fichero. No se puede ajuntar el fichero tal cual, pues se queda bloqueado.
            If Not Adjunto = Nothing Then
                Dim contentAsBytes As Byte() = Encoding.UTF8.GetBytes(Adjunto)
                Dim memStream As System.IO.MemoryStream = New System.IO.MemoryStream(contentAsBytes)
                '**********************************************************************************
                Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(memStream)
                streamWriter.Flush()
                '**********************************************************************************
                memStream.Position = 0
                '*************************** ADJUNTO 1 *****************************
                'Dim thisAttachment As Attachment = New Attachment(memStream, System.Net.Mime.MediaTypeNames.Application.Octet) ' "image/jpeg") System.Net.Mime.MediaTypeNames.Application.Pdf
                'Dim F As Long
                'Dim FileNameAdjunto As String
                'F = InStrRev(Adjunto, "\")
                'If F = 0 Then
                '    FileNameAdjunto = Adjunto
                'Else
                '    FileNameAdjunto = Adjunto.Substring(F)
                'End If
                'thisAttachment.ContentDisposition.FileName = FileNameAdjunto
                '***************************************************************************
                '************************   ADJUNTO 2
                Dim fileTXT As String = Adjunto.ToString ' -----------"CierreCaja.pdf"
                Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(fileTXT)
                Dim name As String
                Try
                    name = Adjunto
                    name = name.Substring(InStrRev(name, "\"), name.Length - InStrRev(name, "\"))
                Catch ex As Exception
                    name = "ArchivoAdjunto"
                End Try
                data.Name = name
                '***************************************************************************
                msg.Attachments.Add(data)
                '***************************************************************************
                'msg.Attachments.GetEnumerator()
                Dim clienteSmtp As New SmtpClient(smtp)
                clienteSmtp.Credentials = New NetworkCredential(usuario, Clave)
                clienteSmtp.Port = EmailPort
                clienteSmtp.EnableSsl = True
                Try
                    clienteSmtp.Send(msg)
                    data.Dispose()
                    FileSystem.Kill(Adjunto)
                    Return True
                Catch ex As Exception
                    MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End Try
            Else
                Dim clienteSmtp As New SmtpClient(smtp)
                clienteSmtp.Credentials = New NetworkCredential(usuario, Clave)
                clienteSmtp.Port = EmailPort
                clienteSmtp.EnableSsl = True
                Try
                    clienteSmtp.Send(msg)
                    Return True
                Catch ex As Exception
                    MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End Try
            End If
        End Function
    End Class
End Module

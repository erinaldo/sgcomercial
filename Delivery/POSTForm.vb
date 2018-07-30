Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail

Public Class POSTForm
    Private Sub POSTForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function PostData(ByRef URL As String, ByRef POST As String, ByRef CookieContainer As CookieContainer)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        request = CType(WebRequest.Create(URL), HttpWebRequest)
        request.ContentType = "application/x-www-forum-urlencoded"
        MsgBox(POST)
        request.ContentLength = POST.Length
        request.Method = "POST"
        request.AllowAutoRedirect = False
        Dim requeststream As Stream = request.GetRequestStream()
        Dim postBytes As Byte() = Encoding.ASCII.GetBytes(POST)
        requeststream.Write(postBytes, 0, postBytes.Length)
        requeststream.Close()
        response = CType(request.GetResponse, HttpWebResponse)
        '***************

        'Dim postreqreader As New StreamReader(response.GetResponseStream())
        'RichTextBox1.Text = postreqreader.ReadToEnd
        'WebBrowser1.DocumentText = RichTextBox1.Text

        '****************
        Return New StreamReader(response.GetResponseStream()).ReadToEnd()

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim postreqreader As New StreamReader(response.GetResponseStream())
        RichTextBox1.Text = PostData("http://lacosecha.com.ar/webhooks/pedidos", "key=7f9a4812efbffc70c667ca697915a029&idpedidodeliveryweb=1&estado=DESPACHADO", New System.Net.CookieContainer)
        WebBrowser1.DocumentText = RichTextBox1.Text
        'MsgBox(PostData("http://lacosecha.com.ar/webhooks/pedidos", "key=7f9a4812efbffc70c667ca697915a029&idpedidodeliveryweb=1&estado=DESPACHADO", New System.Net.CookieContainer))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emailmessage As New MailMessage()
        Try
            emailmessage.From = New MailAddress("lacosecha@sistemascomerciales.net")
            emailmessage.To.Add("hoteldayton@gmail.com")
            emailmessage.Subject = "Email_de_prueba_asunto"
            emailmessage.Body = "Email de prueba - Cuerpo del mensaje segunda prueba"
            'Dim smtp As New SmtpClient("smtp.gmail.com")
            Dim smtp As New SmtpClient("mail.sistemascomerciales.net")
            'gmail port smtp.Port = 587
            '            smtp.Port = 465
            smtp.Port = 26
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("lacosecha@sistemascomerciales.net", "lacosecha*?")
            smtp.Send(emailmessage)
            MsgBox("Se ha enviado un email!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
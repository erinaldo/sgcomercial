Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail



Public Class POSTForm

    Private Sub POSTForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, 3)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, 3)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)



        'Dim ProductosWebTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
        'ProductosWebTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
        'Dim ProductosWebDataTable As MySQLDataSet.productosDataTable
        'ProductosWebDataTable = ProductosWebTableAdapter.GetData
        'DataGridView1.DataSource = ProductosWebDataTable
        'DataGridView1.Refresh()
        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepTicketComandera7cm.rdlc"
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
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
            emailmessage.From = New MailAddress("sgcomercial@sistemascomerciales.net")
            emailmessage.To.Add("lucasmartinbs@gmail.com")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SerialPort1.Open()

        Dim s As String = (Chr(&H1D) & "V" & Chr(66) & Chr(0))
        'check s in bytes:
        Dim b() As Byte = System.Text.Encoding.ASCII.GetBytes(s)


        SerialPort1.Write("LINEA 2")
        SerialPort1.Write(Chr(9) & Chr(9) & " tab horizontal")
        SerialPort1.Write("LINEA 1")
        'SerialPort1.Write(Chr(&HC))
        '======================
        SerialPort1.Write(Chr(&H1B) & "L")
        SerialPort1.Write(Chr(&H1B) & "W" & Chr(0) & Chr(0) & Chr(0) & Chr(0))
        SerialPort1.Write(Chr(200) & Chr(0) & Chr(144) & Chr(1))
        SerialPort1.Write(Chr(&H1D) & "V" & Chr(66) & Chr(0))


        SerialPort1.Close()





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        PrintDocument.Print()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = 0
        Dim yPos As Single = 20
        ' La fuente a usar
        Dim prFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

        ' imprimimos la cadena
        e.Graphics.DrawString(RichTextBox2.Text, prFont, Brushes.Black, xPos, yPos)
        ' indicamos que ya no hay nada más que imprimir
        e.HasMorePages = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("Dosage", GetType(Integer))
        table.Columns.Add("Drug", GetType(String))
        table.Columns.Add("Patient", GetType(String))
        table.Columns.Add("Date", GetType(DateTime))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(25, "Indocin", "David", DateTime.Now)
        table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now)
        table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now)
        table.Rows.Add(21, "Combivent", "Janet", DateTime.Now)
        table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now)
        For i = 0 To table.Rows.Count - 1
            ' Write value of first Integer.

            MsgBox(table.Rows(i)(1).ToString)
            'Console.WriteLine(row.Field(Of Integer)(0))
        Next

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)
    End Sub
End Class
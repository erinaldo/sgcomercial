Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Public Class CajaAperturaCierre
    Private Sub CajaAperturaCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        'Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.ComercialDataSet.cajas)
        Try
            Me.CajasTableAdapter.FillByACTIVA(Me.ComercialDataSet.cajas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        If CajasDataGridView.RowCount = 0 Then
            MsgBox("No se han configurado cajas para operar", MsgBoxStyle.Exclamation, "Advertencia")
            BtnAbrir.Enabled = False
            BtnCerrar.Enabled = False
            CajasDataGridView.Enabled = False
            Return
        Else
            CajasDataGridView.Rows(0).Selected = True
            '***************    consultar el estado de caja *************
            Dim idcaja As Integer
            idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
            lblCaja.Text = "Caja Nº: " + idcaja.ToString
            gidevento = CajaseventosTableAdapter.cajaseventos_isopen(idcaja)
            If CajaseventosTableAdapter.cajaseventos_isopen(idcaja) = 0 Then
                LblEstadocaja.Text = "CERRADA"
                LblEstadocaja.ForeColor = Color.Red
            Else
                LblEstadocaja.Text = "ABIERTA"
                LblEstadocaja.ForeColor = Color.Green
            End If
            '***************    FIN consultar el estado de caja *************
        End If
        Me.Select()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajasDataGridView.CellClick
        Dim idcaja As Integer
        idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        lblCaja.Text = "Caja Nº: " + idcaja.ToString
        If CajaseventosTableAdapter.cajaseventos_isopen(idcaja) = 0 Then
            LblEstadocaja.Text = "CERRADA"
            LblEstadocaja.ForeColor = Color.Red
        Else
            LblEstadocaja.Text = "ABIERTA"
            LblEstadocaja.ForeColor = Color.Green
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajasDataGridView.CellContentClick

    End Sub

    Private Sub BtnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbrir.Click
        Dim idcaja As Integer
        idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        If CajaseventosTableAdapter.cajaseventos_isopen(idcaja) = 0 Then
            'LblEstadocaja.Text = "CERRADA"
            Dim rtn As Integer
            '************ abro pantalla arqueo inicial******************
            Dim p As CajaArqueoInicial
            p = New CajaArqueoInicial
            p.ShowDialog()
            If gmontoinicial = -1 Then Return
            If MsgBox("Esta seguro que desea abrir la caja " + idcaja.ToString() + " con " + gmontoinicial.ToString + " ?", MsgBoxStyle.YesNo, "Pregunta") = vbNo Then
                MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Aviso")
                Return
            End If
            rtn = CajaseventosTableAdapter.cajaseventos_abrircaja(idcaja, Now, gmontoinicial, gusername)
            '******************************
            isopen(idcaja)
        Else
            'LblEstadocaja.Text = "ABIERTA"
            MsgBox("La caja seleccionada ya se encuentra ABIERTA", MsgBoxStyle.Exclamation, "Advertencia!")
        End If
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click

        Dim idcaja As Integer
        idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        gidevento = CajaseventosTableAdapter.cajaseventos_isopen(idcaja)
        gidcaja = idcaja
        If CajaseventosTableAdapter.cajaseventos_isopen(idcaja) > 0 Then
            'abierta
            '************ abro pantalla arqueo inicial******************
            Dim p As CajaArqueoFinal
            p = New CajaArqueoFinal
            p.ShowDialog()
            If gmontofinal = -1 Then Return
            If MsgBox("Esta seguro que desea Cerrar la caja " + idcaja.ToString() + " con " + gmontofinal.ToString + " ? ", MsgBoxStyle.YesNo, "Pregunta") = vbNo Then
                MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Aviso")
                Return
            End If

            '******************************
            Dim rtn As Integer
            Try
                rtn = CajaseventosTableAdapter.cajaseventos_cerrarcaja(Now(), gmontofinal, idcaja, gusername)
            Catch ex As Exception
                MsgBox("Ocurrió una excepción al cerrar la caja: " + ex.Message)
            End Try

            If rtn = 1 Then
                MsgBox("Caja Cerrada Exitosamente!", MsgBoxStyle.Information, "Mensaje")
                mail_cierrecaja()
                isopen(idcaja)
                '*********************************************************************
                '************ Imprimir cierre de caja ******************
                '*********************************************************************
                Dim impresion As String
                impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionCierreCaja")
                Select Case impresion
                    Case "Nunca"
                    'Radionunca.Checked = True
                    Case "Siempre"
                        Dim C As ReporteCierreCaja
                        C = New ReporteCierreCaja
                        C.ShowDialog()
                        isopen(idcaja)
                    Case "Preguntar"
                        If MsgBox("Desea Imprimir el comprobante?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                            Dim C As ReporteCierreCaja
                            C = New ReporteCierreCaja
                            C.ShowDialog()
                            isopen(idcaja)
                        End If
                End Select
                '*********************************************************************
                '*********************************************************************
            End If
        Else
            'cerrada
            MsgBox("La caja seleccionada ya se encuentra CERRADA", MsgBoxStyle.Exclamation, "Advertencia!")
        End If
    End Sub
    Private Sub isopen(ByVal idcaja As Integer)
        If CajaseventosTableAdapter.cajaseventos_isopen(idcaja) = 0 Then
            LblEstadocaja.Text = "CERRADA"
            LblEstadocaja.ForeColor = Color.Red
        Else
            LblEstadocaja.Text = "ABIERTA"
            LblEstadocaja.ForeColor = Color.Green
        End If
    End Sub

    Private Sub CajaAperturaCierre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress


    End Sub

    Private Sub CajaAperturaCierre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub mail_cierrecaja()
        Me.Cursor = Cursors.WaitCursor
        Try
            '*******************************
            Me.CajaseventosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajaseventos, gidevento)
            Me.librodiarioTableAdapter.FillByIdevento(Me.ComercialDataSet.librodiario, gidevento)
            Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gidevento)
            Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

            Me.ReportViewer1.RefreshReport()
            '*******************************
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream("CierreCaja.pdf", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
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
            emailmessage.Subject = "Cierre de caja " + Today.ToShortDateString
            emailmessage.Body = "Sistema de Gestión Comercial te envió el resumen de tu último Cierre de caja"
            '*************************  ADJUNTO **********************************************
            Dim fileTXT As String = "CierreCaja.pdf"
            Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(fileTXT)
            data.Name = "CierreCaja.pdf"
            emailmessage.Attachments.Add(data)
            '*********************************************************************************
            Dim smtp As New SmtpClient(SmtpClient)
            smtp.Port = EmailPort
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(EmailFrom, EmailFromPwd)
            smtp.Send(emailmessage)
            MsgBox("Operacion finalizada!", MsgBoxStyle.Information, "Envío email")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
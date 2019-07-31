Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Public Class ReenvioCierresCaja
    Public FechaCierre As String
    Private Sub ReenvioCierresCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ReenvioCierresCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.librodiario' Puede moverla o quitarla según sea necesario.
        'Me.librodiarioTableAdapter.Fill(Me.ComercialDataSet.librodiario)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        'Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        'Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaresumen' Puede moverla o quitarla según sea necesario.
        'Me.cajaresumenTableAdapter.Fill(Me.ComercialDataSet.cajaresumen)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.FillByCerradas(Me.ComercialDataSet.cajaseventos)
        CajaseventosDataGridView.Sort(CajaseventosDataGridView.Columns(0), ListSortDirection.Descending)
        ReportViewer1.Visible = False
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CajaseventosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CajaseventosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub CajaseventosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellContentClick

    End Sub

    Private Sub CajaseventosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellClick
        Try
            Select Case CajaseventosDataGridView.Columns(e.ColumnIndex).Name
                Case "enviar"
                    gidevento = CajaseventosDataGridView.CurrentRow.Cells(0).Value()
                    FechaCierre = CajaseventosDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn4").Value()
                    Me.CajaseventosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajaseventos, gidevento)
                    Me.librodiarioTableAdapter.FillByIdevento(Me.ComercialDataSet.librodiario, gidevento)
                    Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gidevento)
                    Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

                    Me.ReportViewer1.RefreshReport()
                    mail_cierrecaja()
                    '***********************
                    Me.CajaseventosTableAdapter.FillByCerradas(Me.ComercialDataSet.cajaseventos)
                    CajaseventosDataGridView.Sort(CajaseventosDataGridView.Columns(0), ListSortDirection.Descending)

            End Select
        Catch ex As Exception
            MsgBox("No se pudo completar la operación: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try
    End Sub
    Private Sub mail_cierrecaja()
        Me.Cursor = Cursors.WaitCursor
        Dim ArchivoAdjunto As String
        Dim rnd As New Random
        Dim chrInt As Integer = 0
        chrInt = rnd.Next(1130, 9022)
        ArchivoAdjunto = gPublicDocumentsPath + "\CierreCaja" + chrInt.ToString + ".pdf"
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
            emailmessage.Subject = "Cierre de caja " + FechaCierre 'Today.ToShortDateString
            emailmessage.Body = "Sistema de Gestión Comercial te envió el reporte Cierre de caja correspondiente a la fecha " + FechaCierre

            If clsSendMail.SendEMail(EmailFrom, EmailCierreCajaTo, emailmessage.Subject, emailmessage.Body, EmailFrom, EmailFromPwd, SmtpClient, ArchivoAdjunto) = True Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail del cierre de caja ha sido exitoso!", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CajaseventosTableAdapter.cajaseventos_updateemailed("S", gidevento)
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail falló! Verifíque su conexión a internet", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CajaseventosTableAdapter.cajaseventos_updateemailed("N", gidevento)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CajaseventosTableAdapter.cajaseventos_updateemailed("N", gidevento)
        End Try
    End Sub
End Class
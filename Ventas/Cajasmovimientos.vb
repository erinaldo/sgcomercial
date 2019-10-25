Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Mail

Public Class Cajasmovimientos
    Public FechaCierre As String
    Private Sub Cajasmovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.
        Try
            Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
            'Me.CajaseventosTableAdapter.FillByfecha(Me.ComercialDataSet.cajaseventos, DateTimePicker1.Text)
            CajaseventosDataGridView.Sort(CajaseventosDataGridView.Columns(0), ListSortDirection.Descending)
        Catch ex As Exception
            MessageBox.Show("No se pudo recuperar los ultimos eventos de caja, contacte al proveedor de sistema", "Ha ocurrido una excepción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        ''*****************************
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        'MsgBox("fechaapertura = '" + DateTimePicker1.Text + "'")
        'CajaseventosBindingSource.Filter = "fechaapertura > " + DateTimePicker1.Value.ToString + ""
        Try
            CajaseventosTableAdapter.FillByfecha(Me.ComercialDataSet.cajaseventos, DateTimePicker1.Text)
            CajasmovimientosBindingSource.Filter = "idevento = 0"
            VgastosBindingSource.Filter = "idevento = 0"
        Catch ex As Exception
            MessageBox.Show("No se pudo recuperar los ultimos eventos de caja, contacte al proveedor de sistema", "Ha ocurrido una excepción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub CajaseventosDataGridView_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CajaseventosDataGridView.BindingContextChanged

    End Sub

    Private Sub CajaseventosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellClick

        '***************************** cargar datos
        Select Case CajaseventosDataGridView.CurrentCell.ColumnIndex
            Case 6
                If IsDBNull(CajaseventosDataGridView.CurrentRow.Cells(5).Value()) Then
                    MsgBox("La caja seleccionada se encuentra abierta!")
                    Return
                End If
                gidevento = CajaseventosDataGridView.CurrentRow.Cells(0).Value()
                Dim C As ReporteCierreCaja
                C = New ReporteCierreCaja
                C.ShowDialog()
                gidevento = 0
            Case 7
                If IsDBNull(CajaseventosDataGridView.CurrentRow.Cells(5).Value()) Then
                    MsgBox("El reporte todavia no esta finalizado, antes debe cerrar la caja!")
                    Return
                End If
                gidevento = CajaseventosDataGridView.CurrentRow.Cells(0).Value()
                FechaCierre = CajaseventosDataGridView.CurrentRow.Cells("FechacierreDataGridViewTextBoxColumn").Value()
                Me.CajaseventosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajaseventos, gidevento)
                Me.librodiarioTableAdapter.FillByIdevento(Me.ComercialDataSet.librodiario, gidevento)
                Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gidevento)
                Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

                Me.ReportViewer1.RefreshReport()
                mail_cierrecaja()
        End Select

    End Sub


    Private Sub CajaseventosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        CajasmovimientosBindingSource.Filter = "idevento = 0"
        VgastosBindingSource.Filter = "idevento = 0"
        CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Selected = False
    End Sub



    Private Sub MovimientoscajasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        gideventoseleccionado = CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Cells("IdeventoDataGridViewTextBoxColumn").Value

        If gideventoseleccionado > 0 Then
            '************ abro pantalla arqueo FINAL para ver estado ******************
            Dim p As VerEstadoCaja
            p = New VerEstadoCaja
            'p.Button1.Enabled = False
            p.Text = "Estado de Caja"
            p.ShowDialog()
            gideventoseleccionado = Nothing
        Else
            MsgBox("No se puede cargar el resumen de caja", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub V_gastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim z As DetalleEgresos
            z = New DetalleEgresos
            gideventoseleccionado = CajaseventosDataGridView.CurrentRow.Cells("IdeventoDataGridViewTextBoxColumn").Value
            'MsgBox(gideventoseleccionado.ToString)
            z.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReportViewer2_CausesValidationChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer2_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer2_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub ReportViewer2_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim z As DetalleIngresos
            z = New DetalleIngresos
            gideventoseleccionado = CajaseventosDataGridView.CurrentRow.Cells("IdeventoDataGridViewTextBoxColumn").Value
            'MsgBox(gideventoseleccionado.ToString)
            z.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cajasmovimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
            '***************************************************************
            '***********************    ENVIO DE EMAIL  ****************************************
            '***************************************************************
            If clsSendMail.SendEMail(EmailFrom, EmailCierreCajaTo, emailmessage.Subject, emailmessage.Body, EmailFrom, EmailFromPwd, SmtpClient, ArchivoAdjunto) = True Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail del cierre de caja ha sido exitoso!", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("El envío de mail falló! Verifíque su conexión a internet", "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("El envío de mail falló: " + ex.Message, "Envío email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class
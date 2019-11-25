Imports System.ComponentModel

Public Class EstadoCuentaCorriente
    Private Sub EstadoCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ComercialDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.ventas' Puede moverla o quitarla según sea necesario.
        'Me.VentasTableAdapter.Fill(Me.ComercialDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listacuentascorrientes' Puede moverla o quitarla según sea necesario.
        If gclienteseleccionado > 0 Then
            filtrarcliente()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim autorizado As Int16
        autorizado = PermisosTableAdapter1.permisos_consultabymenuname(guserprofile, "EstadoCuentaCorriente")
        If Not autorizado = 1 Then
            ListacuentascorrientesDataGridView.Columns("Anular").Visible = False
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub colorear()
        'Dim fechavencimiento

        For i = 0 To ListacuentascorrientesDataGridView.RowCount - 1
            If Not IsDBNull(ListacuentascorrientesDataGridView.Rows(i).Cells("fechavencimiento").Value) Then
                If ListacuentascorrientesDataGridView.Rows(i).Cells("fechavencimiento").Value < Today Then
                    If Not ListacuentascorrientesDataGridView.Rows(i).Cells("saldo").Value = 0 Then
                        ListacuentascorrientesDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                    Else
                        ListacuentascorrientesDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                End If
            End If


            'Select Case ListacuentascorrientesDataGridView.Rows(i).Cells("estado").Value.ToString
            '    Case "ENTREGADO"
            '        ListacuentascorrientesDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
            '    Case "ENPROCESO"
            '        ListacuentascorrientesDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
            '    Case "RECIBIDO"
            '        ListacuentascorrientesDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            'End Select
        Next
        ListacuentascorrientesDataGridView.Refresh()
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString
        filtrarcliente()
    End Sub
    Public Sub filtrarcliente()
        If gclienteseleccionado > 1 Then
            Try
                'Me.ListacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.listacuentascorrientes)
                ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
                ListacuentascorrientesTableAdapter.FillByidcliente(Me.ComercialDataSet.listacuentascorrientes, gclienteseleccionado)
                '********************************************************
                Dim CcSaldoDisponibleTableAdapter As New comercialDataSetTableAdapters.ccsaldodisponibleTableAdapter()
                Dim sal As Decimal
                sal = CcSaldoDisponibleTableAdapter.ccsaldodisponible_condultardisponible(gclienteseleccionado)
                LabelSaldoPI.Text = sal.ToString
                If sal > 0 Then
                    LabelSaldoPI.ForeColor = Color.Green
                Else
                    LabelSaldoPI.ForeColor = Color.Black
                End If
                '********************************************************
                calculasaldos()
            Catch ex As Exception
                MsgBox("Ocurrió una excepción al buscar la información del cliente: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia!")
                ClientesBindingSource.Filter = "idcliente = " + "0"
                LabelSaldoPI.Text = ""
            End Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''   oculta el boton de anular en PAGOS
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Try
            '    For i = 0 To ListacuentascorrientesDataGridView.RowCount - 1
            '        Select Case ListacuentascorrientesDataGridView.Rows(i).Cells("descripcion").Value
            '            Case "Pago"
            '                ListacuentascorrientesDataGridView.Rows(i).Cells("anular") = New DataGridViewTextBoxCell()
            '        End Select
            '    Next
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        Else
            IdclienteTextBox.Text = "0"
            LabelSaldoPI = Nothing
            ClientesBindingSource.Filter = "idcliente = " + "0"
            ListacuentascorrientesTableAdapter.FillByidcliente(Me.ComercialDataSet.listacuentascorrientes, gclienteseleccionado)
            'ListacuentascorrientesBindingSource.Filter = "idcliente = " + "0"

            MsgBox("Indique un cliente válido!", MsgBoxStyle.Exclamation)

        End If
    End Sub
    Private Sub calculasaldos()
        Dim totaldebe As Decimal = 0
        Dim totalhaber As Decimal = 0
        Dim saldototal As Decimal = 0
        Dim i As Long

        For i = 0 To ListacuentascorrientesDataGridView.RowCount - 1
            Dim debe As Decimal = ListacuentascorrientesDataGridView.Rows(i).Cells("debe").Value
            Dim haber As Decimal = ListacuentascorrientesDataGridView.Rows(i).Cells("haber").Value
            totaldebe = totaldebe + debe
            totalhaber = totalhaber + haber
        Next

        Labeltotaldebe.Text = totaldebe.ToString
        Labeltotalhaber.Text = totalhaber.ToString
        saldototal = totalhaber - totaldebe
        Labeltotalgeneral.Text = Convert.ToString(totaldebe - totalhaber)
        '********************************************************
        If saldototal = 0 Then
            LabelTipoSaldo.Text = "-----"
            LabelTipoSaldo.ForeColor = Color.Black
            Labeltotalgeneral.ForeColor = Color.Black
        End If

        If saldototal < 0 Then
            LabelTipoSaldo.Text = "Deudor"
            LabelTipoSaldo.ForeColor = Color.Red
            Labeltotalgeneral.ForeColor = Color.Red
        End If

        If saldototal > 0 Then
            LabelTipoSaldo.Text = "Acreedor"
            LabelTipoSaldo.ForeColor = Color.Green
            Labeltotalgeneral.ForeColor = Color.Green
        End If
        '********************************************************
        '********************************************************
        colorear()
    End Sub

    Private Sub ListacuentascorrientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacuentascorrientesDataGridView.CellContentClick

    End Sub

    Private Sub ListacuentascorrientesDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ListacuentascorrientesDataGridView.RowsAdded

    End Sub

    Private Sub ListacuentascorrientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacuentascorrientesDataGridView.CellClick
        '*************************************************
        Try
            gidcliente = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
        Catch ex As Exception
            Return
        End Try
        '*************************************************
        If Not e.ColumnIndex >= 0 Then
            Return
        End If
        Select Case ListacuentascorrientesDataGridView.Columns(e.ColumnIndex).Name
            Case "saldo"
                If IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value) Then Return
                If ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value <> 0 Then
                    gidventa = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("nro").Value
                    Dim p As CtasCtesPagar
                    p = New CtasCtesPagar
                    p.TextBoxMontoaPagar.Text = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value '* -1
                    p.ShowDialog()
                    If gidpago > 0 Then
                        Try
                            filtrarcliente()
                        Catch ex As Exception
                            'MsgBox("Cliente no encontrado!", MsgBoxStyle.Exclamation, "catch 1")
                            'ClientesBindingSource.Filter = ""
                            'ListacuentascorrientesDataGridView.Rows.Clear()
                        End Try
                    End If
                End If
            Case "nro"
                gidpago = 0
                gidventa = 0
                If Not IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idventa").Value) Then
                    gidventa = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                End If
                If Not IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idpagos").Value) Then
                    gidpago = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idpagos").Value
                End If
                '***********************************************************
                If gidpago > 0 Then ' visualizar el pago
                    Dim p As ViewerRecibo 'ViewerFactura
                    p = New ViewerRecibo 'ViewerFactura
                    p.ShowDialog()

                End If
                If gidventa > 0 Then
                    Dim p As ConsultarVenta 'ViewerFactura
                    p = New ConsultarVenta 'ViewerFactura
                    p.ShowDialog()
                End If
                gidpago = 0
                gidventa = 0
            Case "Anular"
                '***************************** verificar si es venta o pago
                gidpago = 0
                gidventa = 0
                If Not IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idventa").Value) Then
                    gidventa = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                    Dim debe As Decimal = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("debe").Value
                    Dim saldo As Decimal = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value

                    'If MsgBox("Seguro desea anular la operación?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    '    If MsgBox("Esta operacion anulará la venta y todos sus comprobantes de pago asociados. Desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    '        CajasoperacionesTableAdapter.cajasoperaciones_bajaoperacionventa(CajasmovimientosDataGridView.CurrentRow.Cells("idoperacion").Value, gusername)
                    '    Else
                    '        MsgBox("Operacion cancelada")
                    '    End If
                    'End If
                    'debe = debe * -1
                    If Not debe = saldo Then
                        MsgBox("No es posible anular: existen pagos asociados." + vbCrLf + "Primero anule  los pagos asociados.", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    Else
                        If MsgBox("Seguro desea eliminar la venta?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                            Try
                                VentasTableAdapter.ventas_bajaventa(gidventa, gusername)
                                MsgBox("Operacion exitosa!", MsgBoxStyle.Information)
                                filtrarcliente()
                                Return
                            Catch ex As Exception
                                MsgBox("Ocurrio un error: " + ex.Message)
                            End Try
                        End If
                    End If
                End If
                '*******************    anular pagos    ******************************************************
                If Not IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idpagos").Value) Then
                    gidpago = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idpagos").Value
                    If MsgBox("Seguro desea eliminar el pago?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        Try
                            PagosTableAdapter.pagos_anular(gidpago)
                            MsgBox("Operacion exitosa!", MsgBoxStyle.Information)
                            filtrarcliente()
                            Return
                        Catch ex As Exception
                            MsgBox("Ocurrio un error: " + ex.Message)
                        End Try
                    End If
                End If
                '***********************************************************
            Case Else
        End Select
    End Sub

    Private Sub IdclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdclienteTextBox.TextChanged
        'Try
        gclienteseleccionado = IdclienteTextBox.Text
        'Catch ex As Exception

        ' End Try

    End Sub

    Private Sub ListacuentascorrientesDataGridView_Sorted(sender As Object, e As EventArgs) Handles ListacuentascorrientesDataGridView.Sorted
        colorear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As ViewerCtaCte
        j = New ViewerCtaCte
        gidcliente = Val(IdclienteTextBox.Text)
        If gidcliente > 0 Then
            j.ShowDialog()
        Else
            MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation, "Advertencia")
        End If

        gidcliente = Nothing
    End Sub

    Private Sub EstadoCuentaCorriente_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub EstadoCuentaCorriente_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub EstadoCuentaCorriente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            filtrarcliente()
        End If

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            gidcliente = Val(IdclienteTextBox.Text)
            If gidcliente > 0 Then
                Dim r As New CargarPagoaCuenta()
                r.ShowDialog()
                filtrarcliente()
            Else
                MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un cliente válido: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try

    End Sub

    Private Sub EstadoCuentaCorriente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        gclienteseleccionado = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim CcSaldoDisponibleTableAdapter As New comercialDataSetTableAdapters.ccsaldodisponibleTableAdapter()

            '--If LabelTipoSaldo.Text = "Acreedor" Then
            Dim j As New CCReimputarSaldo()
                Dim sal As Decimal
                gidcliente = Val(IdclienteTextBox.Text)
                sal = CcSaldoDisponibleTableAdapter.ccsaldodisponible_condultardisponible(gidcliente)
                If gidcliente > 0 And sal > 0 Then
                    j.ShowDialog()
                    filtrarcliente()
                End If
            '--End If
        Catch ex As Exception
            MsgBox("Ha ocurrido una excepción: " + ex.Message)
        End Try
    End Sub
End Class
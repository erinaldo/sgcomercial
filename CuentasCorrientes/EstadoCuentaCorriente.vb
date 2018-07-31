﻿Public Class EstadoCuentaCorriente
    Private Sub EstadoCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listacuentascorrientes' Puede moverla o quitarla según sea necesario.
        If gclienteseleccionado > 0 Then
            filtrarcliente()
        End If

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
                Me.ListacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.listacuentascorrientes)
                ListacuentascorrientesTableAdapter.FillByidcliente(Me.ComercialDataSet.listacuentascorrientes, gclienteseleccionado)
                ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
                ClientesBindingSource.Filter = "idcliente = " + gclienteseleccionado.ToString
                calculasaldos()
            Catch ex As Exception
                MsgBox("Cliente no encontrado!", MsgBoxStyle.Exclamation)
                ClientesBindingSource.Filter = "idcliente = " + "0"
            End Try
        Else
            ClientesBindingSource.Filter = "idcliente = " + "0"
            MsgBox("Indique un cliente válido!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub calculasaldos()
        Dim totaldebe As Decimal = 0
        Dim totalhaber As Decimal = 0
        Dim saldototal As Decimal
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
        Labeltotalgeneral.Text = Convert.ToString(totalhaber - totaldebe)
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
    End Sub

    Private Sub ListacuentascorrientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacuentascorrientesDataGridView.CellContentClick

    End Sub

    Private Sub ListacuentascorrientesDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ListacuentascorrientesDataGridView.RowsAdded

    End Sub

    Private Sub ListacuentascorrientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacuentascorrientesDataGridView.CellClick
        'If IsDBNull(ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value) = True Then
        '    Return
        'End If
        '*************************************************
        gidcliente = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
        '*************************************************
        Select Case ListacuentascorrientesDataGridView.Columns(e.ColumnIndex).Name
            Case "saldo"
                If ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value > 0 Then
                    gidventa = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("nro").Value
                    Dim p As CtasCtesPagar
                    p = New CtasCtesPagar
                    p.TextBoxMontoaPagar.Text = ListacuentascorrientesDataGridView.Rows(e.RowIndex).Cells("saldo").Value
                    p.ShowDialog()
                    If gidpago > 0 Then
                        Try
                            Me.ListacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.listacuentascorrientes)
                            ListacuentascorrientesTableAdapter.FillByidcliente(Me.ComercialDataSet.listacuentascorrientes, gclienteseleccionado)
                            ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
                            ClientesBindingSource.Filter = "idcliente = " + gclienteseleccionado.ToString
                            calculasaldos()
                        Catch ex As Exception
                            MsgBox("Cliente no encontrado!", MsgBoxStyle.Exclamation)
                            ClientesBindingSource.Filter = "idcliente = " + "0"
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
                    Return
                End If
                If gidventa > 0 Then
                    Dim p As ConsultarVenta 'ViewerFactura
                    p = New ConsultarVenta 'ViewerFactura
                    p.ShowDialog()
                End If
                gidpago = 0
                gidventa = 0
            Case Else
        End Select
    End Sub

    Private Sub IdclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdclienteTextBox.TextChanged
        gclienteseleccionado = IdclienteTextBox.Text
    End Sub
End Class
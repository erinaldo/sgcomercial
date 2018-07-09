Imports System.Text.RegularExpressions
Public Class CtasCtesPagar
    Private Sub CtasCtesPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.formaspago' Puede moverla o quitarla según sea necesario.
        Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.Fill(Me.ComercialDataSet.tipocomprobantes)

    End Sub
    Private Sub consultarestadocaja(ByRef estado As Boolean)
        '***************    consultar el estado de caja *************
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        If gidcaja = 0 Then
            MsgBox("Este ordenador no esta Registrado para operar como CAJA!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        Dim idevento As Integer
        'idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        'lblCaja.Text = "Caja Nº: " + idcaja.ToString
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)

        If idevento = 0 Then
            MsgBox("Caja Cerrada. Abra la caja antes de registrar una venta o pago", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            estado = True
        End If
        '***************    FIN consultar el estado de caja *************
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '********************** antes de cargar el pago consulto estado de la caja *****************************************
        Dim estado As Boolean = False
        consultarestadocaja(estado)
        If estado = False Then
            Return
        End If
        '***************************************************************
        If Not ComboTipoComprobante.SelectedIndex >= 0 Then
            MsgBox("Ingrese un tipo de comprobante válido!", MsgBoxStyle.Exclamation)
            ComboTipoComprobante.Select()
            Return
        End If
        If Not ComboFormapago.SelectedIndex >= 0 Then
            MsgBox("Ingrese una forma de pago válida!", MsgBoxStyle.Exclamation)
            ComboFormapago.Select()
            Return
        End If
        If Len(Trim(pagotextbox.Text)) = 0 Then
            MsgBox("Ingrese un monto válido!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim pago As Decimal = pagotextbox.Text
        ' Dim idventasdetalle As Long
        'Dim v_rtn As Long
        If pago <= 0 Then
            MsgBox("Monto inválido", MsgBoxStyle.Exclamation, "Advertencia")
            pagotextbox.Select()
            Return
        End If
        '**************************
        Try
            gidpago = PagosTableAdapter.pagos_insertarpago(gidventa, gidcliente, pago, Today(), ComboFormapago.SelectedValue, nrocomprobante.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al INSERTAR  el pago: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub pagotextbox_TextChanged(sender As Object, e As EventArgs) Handles pagotextbox.TextChanged

    End Sub

    Private Sub pagotextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pagotextbox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub
End Class
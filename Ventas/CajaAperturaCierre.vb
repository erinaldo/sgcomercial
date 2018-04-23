Public Class CajaAperturaCierre
    Private Sub CajaAperturaCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
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
            rtn = CajaseventosTableAdapter.cajaseventos_cerrarcaja(Now(), gmontofinal, idcaja, gusername)
            If rtn = 1 Then
                MsgBox("Caja Cerrada Exitosamente!", MsgBoxStyle.Information, "Mensaje")
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
        'If e.KeyCode = Keys.Escape Then
        '    Me.Close()
        'End If

        If e.KeyCode.ToString = "Escape" Then

            Me.Close()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
End Class
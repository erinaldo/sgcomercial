﻿Imports MySql.Data.MySqlClient
Public Class LotesEnvios
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Private Sub LotesEnvios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.lotesenvios' Puede moverla o quitarla según sea necesario.
        Me.LotesenviosTableAdapter.Fill(Me.ComercialDataSet.lotesenvios)
        Dim newColumn As DataGridViewColumn = LotesenviosDataGridView.Columns(0)
        LotesenviosDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        'Try
        '    'conectarMySQL()
        '    sql = "select * from pedidosdelivery"
        '    da = New MySqlDataAdapter(sql, MySQLConn)
        '    dt = New DataTable
        '    da.Fill(dt)
        '    DataGridViewPedidosdelivery.DataSource = dt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub
    Private Sub imprimirreportelote(ByVal idlote As Long)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.lotesenviosdetalle' Puede moverla o quitarla según sea necesario.
        'Me.LotesenviosdetalleTableAdapter.Fill(Me.ComercialDataSet.lotesenviosdetalle)
        'LotesenviosBindingSource.Filter = "idloteenvio = " + idlote.ToString
        'LotesenviosdetalleBindingSource.Filter = "idloteenvio = " + idlote.ToString
        'If MsgBox("Desea imprimir el reporte?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        gidlote = idlote
        ViewerLoteEnvio.ShowDialog()
        gidlote = 0
        'End If
    End Sub



    Private Sub LotesenviosDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles LotesenviosDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        'Dim comando As MySqlCommand
        'Dim sql As String


        'sql = "INSERT INTO pedidosdelivery VALUES (NULL,@idclienteweb,@idventaweb,@idtransporte,@iddomicilio,@pagoesperado,@fechaalta,@estado,@nroguia)"

        'Try
        '    comando = New MySqlCommand(sql, MySQLConn)
        '    comando.Parameters.AddWithValue("@idclienteweb", "41")
        '    comando.Parameters.AddWithValue("@idventaweb", "42")
        '    comando.Parameters.AddWithValue("@idtransporte", "43")
        '    comando.Parameters.AddWithValue("@iddomicilio", "44")
        '    comando.Parameters.AddWithValue("@pagoesperado", "4.6")
        '    comando.Parameters.AddWithValue("@fechaalta", Now())
        '    comando.Parameters.AddWithValue("@estado", "47")
        '    comando.Parameters.AddWithValue("@nroguia", "48")

        '    comando.ExecuteNonQuery()
        '    MsgBox("Datos Guardados", MsgBoxStyle.Information)
        'Catch ex As Exception
        '    MsgBox("Error al insertar: " + ex.Message)
        'End Try
    End Sub

    Private Sub LotesenviosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LotesenviosDataGridView.CellClick
        Try
            gidlote = LotesenviosDataGridView.Rows(LotesenviosDataGridView.CurrentRow.Index).Cells(0).Value
            Select Case LotesenviosDataGridView.Columns(e.ColumnIndex).Name
                Case "Ver"
                    imprimirreportelote(gidlote)
                    gidlote = Nothing
                    Me.LotesenviosTableAdapter.Fill(Me.ComercialDataSet.lotesenvios)
                Case "rendicion"
                    Dim p As ViewerLoteRendido
                    p = New ViewerLoteRendido
                    p.ShowDialog()
                    gidlote = Nothing
                    Me.LotesenviosTableAdapter.Fill(Me.ComercialDataSet.lotesenvios)
                Case "Confirmar"
                    If IsDBNull(LotesenviosDataGridView.Rows(e.RowIndex).Cells("fechacierre").Value) Then
                        MsgBox("El lote todavia se encuentra en proceso de entrega", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    End If
                    If IsDBNull(LotesenviosDataGridView.Rows(e.RowIndex).Cells("fechaconfirmacion").Value) Then
                        '***********    verifico el estado de la caja   *************
                        gidevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
                        If gidevento = 0 Then
                            MsgBox("Caja Cerrada. Abra la caja antes de confirmar el lote", MsgBoxStyle.Exclamation, "Advertencia")
                        Else
                            LotesenviosTableAdapter.lotesenvios_confirmarlote(Now(), gidevento, gusername, gidlote)
                            MsgBox("Rendición de lote CONFIRMADA!", MsgBoxStyle.Information, "Aviso")
                        End If
                    Else
                        MsgBox("El pedido ya se encuentra confirmado", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                    gidlote = Nothing
                    Me.LotesenviosTableAdapter.Fill(Me.ComercialDataSet.lotesenvios)
            End Select

        Catch ex As Exception
            ' MsgBox("Ocurrio un error: " + ex.Message)
            gidlote = Nothing
        End Try

    End Sub

    Private Sub LotesEnvios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
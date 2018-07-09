Imports MySql.Data.MySqlClient
Public Class LotesEnvios
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Private Sub LotesEnvios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.lotesenvios' Puede moverla o quitarla según sea necesario.
        Me.LotesenviosTableAdapter.Fill(Me.ComercialDataSet.lotesenvios)

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
        Select Case e.ColumnIndex
            Case 6
                imprimirreportelote(LotesenviosDataGridView.Rows(LotesenviosDataGridView.CurrentRow.Index).Cells(0).Value)
        End Select
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
End Class
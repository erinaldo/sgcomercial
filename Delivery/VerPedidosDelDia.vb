Public Class VerPedidosDelDia
    Private Sub VerPedidosDelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCAPPICON
        Me.CalendariopedidosdeliveryTableAdapter.FillByfechaaentregardate(Me.ComercialDataSet.calendariopedidosdelivery, gfechaaentregar)
    End Sub

    Private Sub CalendariopedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CalendariopedidosdeliveryDataGridView.CellContentClick

    End Sub

    Private Sub CalendariopedidosdeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CalendariopedidosdeliveryDataGridView.CellClick
        Try
            Select Case CalendariopedidosdeliveryDataGridView.Columns(e.ColumnIndex).Name
                Case "idpedidodelivery"
                    Dim p As ViewerComanda
                    p = New ViewerComanda
                    gidpedidodelivery = CalendariopedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    'Dim idpedidoweb As Long
                    'idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
                    p.ShowDialog()
                    gidpedidodelivery = Nothing
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VerPedidosDelDia_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
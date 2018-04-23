Public Class RecepcionPedido
    Private Sub RecepcionPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        Me.PedidosdetalleTableAdapter.Fill(ComercialDataSet.pedidosdetalle)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdPedido.TextChanged
        Dim vigente As Integer
        vigente = PedidosTableAdapter.pedidos_consultarpedidovigente(Val(TextBoxIdPedido.Text))
        If Not vigente = Val(TextBoxIdPedido.Text) Then
            MsgBox("El pedido ya no se encuentra vigente!", MsgBoxStyle.Exclamation, "Advertencia")
            TextBoxIdPedido.Select()
            TextBoxIdPedido.SelectionStart = 0
            TextBoxIdPedido.SelectionLength = TextBoxIdPedido.Text.Length
            Return
        End If
        revisarpedido()
    End Sub
    Private Sub resetear()
        PedidoDetalleConfirmarDataGridView.Rows.Clear()
        TextBoxIdPedido.Text = ""
    End Sub
    Public Sub revisarpedido()

        Me.ListapedidosTableAdapter.Fill(Me.ComercialDataSet.listapedidos)
        Dim i As Integer = 0
        Dim newrow As Integer = 0

        Try
            PedidoDetalleConfirmarDataGridView.Rows.Clear()
            ListapedidosBindingSource.Filter = "idpedido = " + TextBoxIdPedido.Text
            Me.PedidosdetalleTableAdapter.FillByPendientes(ComercialDataSet.pedidosdetalle, Val(TextBoxIdPedido.Text))

            If PedidosdetalleDataGridView.RowCount > 0 Then
                For i = 0 To PedidosdetalleDataGridView.RowCount - 1
                    newrow = PedidoDetalleConfirmarDataGridView.Rows.Add()
                    PedidoDetalleConfirmarDataGridView.Rows(newrow).Cells(0).Value = PedidosdetalleDataGridView.Rows(i).Cells(2).Value
                    PedidoDetalleConfirmarDataGridView.Rows(newrow).Cells(1).Value = ProductosTableAdapter.productos_consultardescripcionporidproducto(PedidosdetalleDataGridView.Rows(i).Cells(2).Value)
                    PedidoDetalleConfirmarDataGridView.Rows(newrow).Cells(2).Value = PedidosdetalleDataGridView.Rows(i).Cells(3).Value
                    PedidoDetalleConfirmarDataGridView.Rows(newrow).Cells(3).Value = PedidosdetalleDataGridView.Rows(i).Cells(4).Value
                Next

            End If
        Catch ex As Exception
            Me.ListapedidosTableAdapter.Fill(Me.ComercialDataSet.listapedidos)
            ListapedidosBindingSource.Filter = "idpedido =0"
        End Try

    End Sub

    Private Sub PedidoDetalleConfirmarDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidoDetalleConfirmarDataGridView.CellContentClick

    End Sub

    Private Sub PedidoDetalleConfirmarDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidoDetalleConfirmarDataGridView.CellClick
        Select Case e.ColumnIndex
            Case 4
                If PedidoDetalleConfirmarDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0 Then
                    PedidoDetalleConfirmarDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1
                Else
                    PedidoDetalleConfirmarDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                End If

        End Select
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gidpedido = 0
        BuscarPedido.ShowDialog()
        TextBoxIdPedido.Text = gidpedido.ToString
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        '**************** validaciones ****************
        Dim vigente As Integer
        vigente = PedidosTableAdapter.pedidos_consultarpedidovigente(Val(TextBoxIdPedido.Text))
        If Not vigente = Val(TextBoxIdPedido.Text) Then
            MsgBox("El pedido ya no se encuentra vigente!", MsgBoxStyle.Exclamation, "Advertencia")
            TextBoxIdPedido.Select()
            Return
        End If
        If MsgBox("Seguro desea confirmar recepcion del pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            Return
        End If
        '**********************************************
        Dim i As Integer = 0
        For i = 0 To PedidoDetalleConfirmarDataGridView.RowCount - 1
            If PedidoDetalleConfirmarDataGridView.Rows(i).Cells(4).Value = 1 Then
                StockTableAdapter.stock_insertarmovimientorecepcion(PedidoDetalleConfirmarDataGridView.Rows(i).Cells(0).Value, PedidoDetalleConfirmarDataGridView.Rows(i).Cells(2).Value, Today, guserid, "E", Val(TextBoxIdPedido.Text))
                PedidosdetalleTableAdapter.pedidosdetalle_confirmarecepcion(1, Val(TextBoxIdPedido.Text), PedidoDetalleConfirmarDataGridView.Rows(i).Cells(0).Value)
                'PedidosTableAdapter.pedidos_confirmarecepcion(Today, Val(TextBoxIdPedido.Text))
            Else
                PedidosdetalleTableAdapter.pedidosdetalle_confirmarecepcion(0, Val(TextBoxIdPedido.Text), PedidoDetalleConfirmarDataGridView.Rows(i).Cells(0).Value)
            End If
        Next
        '**************************************************************
        '*******    si es el ultimo item finalizar automaticamente!!!!!
        '**************************************************************
        If PedidoDetalleConfirmarDataGridView.RowCount = 1 And PedidoDetalleConfirmarDataGridView.Rows(0).Cells(4).Value = 1 Then
            PedidosTableAdapter.pedidos_finalizarpedido(Today, Val(TextBoxIdPedido.Text))
        Else
            If MsgBox("Desea finalizar el pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                PedidosTableAdapter.pedidos_finalizarpedido(Today, Val(TextBoxIdPedido.Text))
            End If
        End If
        '*************** deshabilitarbotonoes¡***************
        TextBoxIdPedido.Enabled = True
        PedidoDetalleConfirmarDataGridView.Enabled = False
        BtnConfirmar.Enabled = False
        BtnCancelar.Enabled = False
        ButtonComenzar.Enabled = True
        resetear()
    End Sub

    Private Sub ButtonComenzar_Click(sender As Object, e As EventArgs) Handles ButtonComenzar.Click

        '**************** validaciones ****************
        Dim vigente As Integer
        vigente = PedidosTableAdapter.pedidos_consultarpedidovigente(Val(TextBoxIdPedido.Text))
        If Not vigente = Val(TextBoxIdPedido.Text) Then
            MsgBox("El pedido ya no se encuentra vigente!", MsgBoxStyle.Exclamation, "Advertencia")
            TextBoxIdPedido.Select()
            Return
        End If
        '**********************************************
        TextBoxIdPedido.Enabled = False
        PedidoDetalleConfirmarDataGridView.Enabled = True
        BtnConfirmar.Enabled = True
        BtnCancelar.Enabled = True
        ButtonComenzar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TextBoxIdPedido.Enabled = True
        PedidoDetalleConfirmarDataGridView.Enabled = False
        BtnConfirmar.Enabled = False
        BtnCancelar.Enabled = False
        TextBoxIdPedido.Select()
        ButtonComenzar.Enabled = True
    End Sub
End Class
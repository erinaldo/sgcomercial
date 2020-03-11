Public Class PedidosDeliveryRecibidos
    Private Sub PedidosdeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub
    Sub reloadpedidos()
        Dim permisos As New comercialDataSetTableAdapters.permisosTableAdapter()
        Dim PedidosRecibidosVerTodosToolStripMenuItem As Integer = 0
        PedidosRecibidosVerTodosToolStripMenuItem = permisos.permisos_consultabymenuname(guserprofile, "PedidosRecibidosVerTodos")
        '******************************************************************************
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)
        If guserprofile = "ADMINISTRADOR" Or PedidosRecibidosVerTodosToolStripMenuItem > 0 Or gusername = "lucasmartinbs" Then
            Me.ListapedidosdeliveryTableAdapter.FillByRecibidos(Me.ComercialDataSet.listapedidosdelivery)
        Else
            Me.ListapedidosdeliveryTableAdapter.FillByAptosPreparacion(Me.ComercialDataSet.listapedidosdelivery)
            ListapedidosdeliveryDataGridView.Columns("Pagar").Visible = False
        End If
        'Me.ListapedidosdeliveryBindingSource.Filter = "estado <> 'ENTREGADO' and estado <> 'CANCELADO'"
    End Sub
    Public Sub colorear()
        Dim i As Integer
        For i = 0 To ListapedidosdeliveryDataGridView.RowCount - 1
            Select Case ListapedidosdeliveryDataGridView.Rows(i).Cells("estado").Value.ToString
                Case "ENTREGADO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                Case "ENPROCESO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
                Case "RECIBIDO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
        Next
        ListapedidosdeliveryDataGridView.Refresh()
    End Sub

    Private Sub PedidosRecibidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCAPPICON
        Me.Cursor = Cursors.WaitCursor
        reloadpedidos()
        colorear()
        '***************    ordenamiento por estado del pedido  **********************
        Try
            Dim newColumn As DataGridViewColumn = ListapedidosdeliveryDataGridView.Columns(1)
            ListapedidosdeliveryDataGridView.Rows(0).Cells(1).Selected = True
            ListapedidosdeliveryDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception

        End Try
        '*****************************************************************************
        ComboBox1.SelectedIndex = 1
        '*****************************************************************************
        LoadLocalSpecialFunctions()
        '*****************************************************************************
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub LoadLocalSpecialFunctions()
        '*******************
        CheckModulesAuth()
        '*******************
        If gModuloPedidosWeb = 1 Then
            ToolStripButtonPedidosWeb.Visible = True
        Else
            ToolStripButtonPedidosWeb.Visible = False
        End If
        If gModuloPedidosMovil = 1 Then
            ToolStripButtonPedidosMovil.Visible = True
        Else
            ToolStripButtonPedidosMovil.Visible = False
        End If
        IsLucasmartinbs()
    End Sub
    Private Sub IsLucasmartinbs()
        If gusername = "lucasmartinbs" Then
            ToolStripButtonPedidosMovil.Visible = True
            ToolStripButtonPedidosWeb.Visible = True
        End If
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellClick
        Dim estadopedido As String = Nothing
        Try
            If e.RowIndex >= 0 Then
                estadopedido = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("estado").Value
            End If

            Select Case ListapedidosdeliveryDataGridView.Columns(e.ColumnIndex).Name
                Case "imprimircomanda" ' imprimir orden de produccion
                    Dim p As ViewerComanda
                    p = New ViewerComanda
                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    Dim idpedidoweb As Long
                    idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
                    p.ShowDialog()
                    If estadopedido = "RECIBIDO" Then
                        Try
                            PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("ENPROCESO", gidpedidodelivery)
                            If idpedidoweb > 0 Then
                                UpdEstadoPedidoWeb("ENPROCESO", idpedidoweb)
                            End If
                        Catch ex As Exception
                            MsgEx(ex.Message)
                        End Try
                        reloadpedidos()
                        colorear()
                    End If
                Case "Pagar" ' cargar pago
                    If estadopedido = "CANCELADO" Then
                        MsgErrPopUp("Opción no disponible")
                        Return
                    End If
                    If ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("saldo").Value > 0 Then
                        Dim p As PedidosDeliveryPagar
                        p = New PedidosDeliveryPagar
                        gidpago = 0
                        gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                        gidventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(gidpedidodelivery)
                        gidcliente = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
                        p.ShowDialog()
                        gidcliente = Nothing
                        gidventa = Nothing
                        gidpedidodelivery = Nothing
                        reloadpedidos()
                        colorear()
                    Else
                        MsgSuccessPopUp("El pedido ya se encuentra pagado!")
                    End If
                Case "Baja"
                    If estadopedido = "CANCELADO" Then
                        MsgErrPopUp("Opción no disponible")
                        Return
                    End If
                    If Not estadopedido = "DESPACHADO" And Not estadopedido = "ENTREGADO" Then
                        If MsgQues("Seguro desea dar de baja el pedido seleccionado?") = True Then
                            PedidosdeliveryTableAdapter.pedidosdelivery_baja(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value)
                            reloadpedidos()
                            colorear()
                        End If
                    Else
                        MsgErrPopUp("No puede cancelar un pedido DESPACHADO/ENTREGADO")
                    End If
                Case "modificar"
                    If estadopedido = "CANCELADO" Then
                        MsgErrPopUp("Opción no disponible")
                        Return
                    End If
                    Dim j As PedidosDeliveryModificar
                    j = New PedidosDeliveryModificar
                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    j.ShowDialog()
                    gidpedidodelivery = Nothing
                    reloadpedidos()
                    colorear()
                Case Else
                    'colorear()
            End Select
        Catch ex As Exception
            MsgEx("No se pudo completar la operación: " + ex.Message)
        End Try
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliveryDataGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            reloadpedidos()
            colorear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'boton de ordenamiento
        '        ListapedidosdeliveryDataGridView.Columns(1).DisplayIndex = 0



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Sincronizando
        p = New Sincronizando
        p.Visible = True
        SynClientes()
        p.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidosDeliveryRecibidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        colorear()
        LoadLocalSpecialFunctions()
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ListapedidosdeliveryDataGridView.RowsAdded

    End Sub

    Private Sub PedidosDeliveryRecibidos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgQues("Seguro desea salir de " + Me.Text) = True Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            Me.Cursor = Cursors.WaitCursor
            reloadpedidos()
            colorear()
            Me.Cursor = Cursors.Default
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Select Case ComboBox1.Text
            Case "Pedido N°"
                Try
                    ListapedidosdeliveryBindingSource.Filter = "idpedidodelivery =" + TextBox1.Text.ToUpper
                    colorear()
                Catch ex As Exception
                    ListapedidosdeliveryBindingSource.Filter = ""
                    colorear()
                End Try

            Case "Cliente"
                Try
                    ListapedidosdeliveryBindingSource.Filter = "nombre like'%" + TextBox1.Text.ToUpper + "%'"
                    colorear()
                Catch ex As Exception
                    ListapedidosdeliveryBindingSource.Filter = ""
                    colorear()
                End Try
        End Select
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs)
        Dim y As ViewerListaProduccion
        y = New ViewerListaProduccion
        y.ShowDialog()

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_Sorted(sender As Object, e As EventArgs) Handles ListapedidosdeliveryDataGridView.Sorted
        colorear()
    End Sub

    Private Sub ToolStripButtonPedidosMobile_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPedidosMovil.Click
        If MsgQues("Esta Operación puede tomar unos minutos. Desea continuar?") = True Then
            Me.Cursor = Cursors.WaitCursor
            SynPedidos("APP")
            reloadpedidos()
            colorear()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ToolStripButtonPedidosWeb_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPedidosWeb.Click

        If MsgQues("Esta Operación puede tomar unos minutos. Desea continuar?") = True Then
            Me.Cursor = Cursors.WaitCursor
            SynPedidos("WEB")
            reloadpedidos()
            colorear()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim y As ViewerListaProduccion
        y = New ViewerListaProduccion
        y.ShowDialog()
    End Sub

    Private Sub PedidosDeliveryRecibidos_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim jaja As New PedidosDeliveryCalendario()
        jaja.Text = "Calendario de Pedidos"
        jaja.Show()

    End Sub
End Class
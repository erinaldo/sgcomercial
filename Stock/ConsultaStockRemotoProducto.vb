Public Class ConsultaStockRemotoProducto
    Private Sub StockgeneralBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultaStockRemotoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gModuloClowd = 1 Then
            ConsultaRemota()
        Else
            ConsultaLocal()
        End If
    End Sub
    Private Sub ConsultaLocal()
        GroupBoxRemoto.Visible = False
        GroupBoxLocal.Visible = True
        Try
            Me.StockgeneralTableAdapter1.FillByCodigoproducto(Me.ComercialDataSet.stockgeneral, gcodigoproducto)
        Catch ex As Exception
            MessageBox.Show("No se puede completar la consulta: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ConsultaRemota()
        GroupBoxRemoto.Visible = True
        GroupBoxLocal.Visible = False
        Try
            'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
            Me.SucursalesTableAdapter.Fill(Me.ComercialDataSet.sucursales)
            'TODO: esta línea de código carga datos en la tabla 'MySQLDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
            Me.StockgeneralTableAdapter.FillBycodigoproducto(Me.MySQLDataSet.stockgeneral, gcodigoproducto)
            Dim ProductosTableAdapter As New comercialDataSetTableAdapters.productosTableAdapter

            Dim nombre As String
            Dim unidadmedida As String
            For i = 0 To StockgeneralDataGridView.RowCount - 1
                nombre = SucursalesTableAdapter.sucursales_consultanombre(StockgeneralDataGridView.Rows(i).Cells(0).Value)
                unidadmedida = ProductosTableAdapter.productos_consultarunidadmedidadescripcion(StockgeneralDataGridView.Rows(i).Cells("codigoproducto").Value)
                StockgeneralDataGridView.Rows(i).Cells("NombreSucursal").Value = nombre
                StockgeneralDataGridView.Rows(i).Cells("medida").Value = unidadmedida
            Next
            GroupBoxRemoto.Focus()

        Catch ex As Exception
            MessageBox.Show("No se puede completar la consulta: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub ConsultaStockRemotoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            'If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Me.Close()
            'End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
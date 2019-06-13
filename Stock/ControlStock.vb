Public Class ControlStock

    Private Sub ControlStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '*************  stock    **************************************
        Dim StockTableAdapter As comercialDataSetTableAdapters.stockTableAdapter
        StockTableAdapter = New comercialDataSetTableAdapters.stockTableAdapter
        Try
            StockTableAdapter.stock_resetproductosmasivo()
        Catch ex As Exception
            MsgBox("No se pudo completar una operación de rutina, contacte al proveedor de sistema: stock_resetproductosmasivo - notfound -")
        End Try
        '*******************************************************************************
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.StockgeneralTableAdapter.Fill(Me.ComercialDataSet.stockgeneral)
        ComboBox1.SelectedIndex = 2
        TextBox1.Select()
    End Sub

    Private Sub StockgeneralDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StockgeneralDataGridView.CellContentClick

    End Sub

    Private Sub StockgeneralDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles StockgeneralDataGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
            Me.StockgeneralTableAdapter.Fill(Me.ComercialDataSet.stockgeneral)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Select Case ComboBox1.Text
            Case "Código"
                StockgeneralBindingSource.Filter = "codigoproducto like '%" + TextBox1.Text + "%'"
            Case "Rubro"
                StockgeneralBindingSource.Filter = "rubro like '%" + TextBox1.Text + "%'"
            Case "Producto"
                StockgeneralBindingSource.Filter = "producto like '%" + TextBox1.Text + "%'"
        End Select
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ViewerReporteControlStockGeneral
        p = New ViewerReporteControlStockGeneral
        p.ShowDialog()
        p.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.StockgeneralTableAdapter.Fill(Me.ComercialDataSet.stockgeneral)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
    End Sub

    Private Sub StockgeneralDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockgeneralDataGridView.CellClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As ViewerReporteRelevamientoStock
        p = New ViewerReporteRelevamientoStock
        p.ShowDialog()
        p.Close()
    End Sub

    Private Sub ControlStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        If e.KeyCode = Keys.F5 And Me.MaximizeBox = True Then
            Try
                Me.StockgeneralTableAdapter.Fill(Me.ComercialDataSet.stockgeneral)
            Catch ex As Exception

            End Try
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
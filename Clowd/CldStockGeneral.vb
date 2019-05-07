Public Class CldStockGeneral
    Private Sub StockgeneralBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.StockgeneralBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.MySQLDataSet)


    End Sub

    Private Sub CldStockGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stockgeneralremoto' Puede moverla o quitarla según sea necesario.
        Me.StockgeneralremotoTableAdapter.Fill(Me.ComercialDataSet.stockgeneralremoto)
        'TODO: esta línea de código carga datos en la tabla 'MySQLDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.StockgeneralTableAdapter.Fill(Me.MySQLDataSet.stockgeneral)
        Dim StockremotoTableAdapter As comercialDataSetTableAdapters.stockremotoTableAdapter
        StockremotoTableAdapter = New comercialDataSetTableAdapters.stockremotoTableAdapter()
        Try
            Dim existe As Integer
            For i = 0 To StockgeneralDataGridView.RowCount - 1
                existe = StockremotoTableAdapter.stockremoto_existe(StockgeneralDataGridView.Rows(i).Cells("idsucursal").Value, StockgeneralDataGridView.Rows(i).Cells("codigoproducto").Value)
                If existe = 0 Then
                    StockremotoTableAdapter.stockremoto_insertar(StockgeneralDataGridView.Rows(i).Cells("idsucursal").Value, StockgeneralDataGridView.Rows(i).Cells("codigoproducto").Value, StockgeneralDataGridView.Rows(i).Cells("disponible").Value, StockgeneralDataGridView.Rows(i).Cells("unidades").Value)
                Else
                    StockremotoTableAdapter.stockremoto_update(StockgeneralDataGridView.Rows(i).Cells("disponible").Value, StockgeneralDataGridView.Rows(i).Cells("unidades").Value, StockgeneralDataGridView.Rows(i).Cells("idsucursal").Value, StockgeneralDataGridView.Rows(i).Cells("codigoproducto").Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("Excepción: " + ex.Message)
        End Try

        Cursor.Current = Cursors.Default
        ComboBox1.SelectedIndex = 2
        TextBox1.Select()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboSucursal_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub
    'Private Sub consultar()
    '    For i = 0 To ComboSucursal.Items.Count - 1
    '        Dim col As New DataGridViewTextBoxColumn
    '        ComboSucursal.SelectedIndex = i
    '        'MsgBox(ComboSucursal.Items.Count.ToString)
    '        If ComboSucursal.SelectedValue = gMiSucursal Then
    '            Continue For
    '        End If
    '        col.DataPropertyName = ComboSucursal.SelectedValue
    '        col.HeaderText = ComboSucursal.Text
    '        col.Name = ComboSucursal.SelectedValue

    '        StockgeneralDataGridViewLOCAL.Columns.Add(col)
    '        '===================================
    '        StockgeneralBindingSource.Filter = "idsucursal = " + ComboSucursal.SelectedValue.ToString
    '        For j = 0 To StockgeneralDataGridView.RowCount - 1
    '            'StockgeneralBindingSource1.Filter = "codigoproducto ='" + StockgeneralDataGridView.Rows(j).Cells("codigoproducto").Value.ToString + "'"
    '            'StockgeneralBindingSource.Filter = "codigoproducto ='" + StockgeneralDataGridView.Rows(j).Cells("codigoproducto").Value.ToString + "'"
    '            'MsgBox(StockgeneralDataGridViewLOCAL.RowCount.ToString, MsgBoxStyle.Information, StockgeneralDataGridView.Rows(j).Cells("disponible").Value.ToString)
    '            For k = 0 To StockgeneralDataGridViewLOCAL.RowCount - 1
    '                If StockgeneralDataGridView.Rows(j).Cells("codigoproducto").Value = StockgeneralDataGridViewLOCAL.Rows(k).Cells("codigoproductolocal").Value Then
    '                    StockgeneralDataGridViewLOCAL.Rows(k).Cells(col.Name.ToString).Value = StockgeneralDataGridView.Rows(j).Cells("disponible").Value
    '                    Exit For
    '                End If
    '            Next
    '            'MsgBox(StockgeneralDataGridViewLOCAL.RowCount.ToString, MsgBoxStyle.Information, StockgeneralDataGridView.Rows(j).Cells("disponible").Value.ToString)
    '        Next
    '    Next
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'Try
        '    Select Case ComboBox1.Text
        '        Case "Código"
        '            StockgeneralBindingSource1.Filter = "codigoproductolocal like '%" + TextBox1.Text + "%'"
        '        Case "Producto"
        '            StockgeneralBindingSource1.Filter = "producto like '%" + TextBox1.Text + "%'"
        '    End Select
        'Catch ex As Exception
        '    StockgeneralBindingSource1.Filter = ""
        'End Try

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        'consultar()
    End Sub

    Private Sub StockgeneralBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockgeneralBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MySQLDataSet)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If Len(Trim(TextBox1.Text)) = 0 Then
                StockgeneralremotoBindingSource.Filter = "sucursal Like '%'"
            Else
                Select Case ComboBox1.Text
                    Case "Sucursal"
                        StockgeneralremotoBindingSource.Filter = "sucursal Like '%" + TextBox1.Text + "%'"
                    Case "Código"
                        StockgeneralremotoBindingSource.Filter = "codigoproducto = '" + TextBox1.Text + "'"
                    Case "Producto"
                        StockgeneralremotoBindingSource.Filter = "producto Like '%" + TextBox1.Text + "%'"
                End Select
                Me.ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            StockgeneralremotoBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub StockgeneralremotoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockgeneralremotoDataGridView.CellContentClick

    End Sub

    Private Sub StockgeneralremotoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockgeneralremotoDataGridView.CellClick
        Try
            'MsgBox(StockgeneralremotoDataGridView.Columns(e.ColumnIndex).Name.ToString)
            Select Case StockgeneralremotoDataGridView.Columns(e.ColumnIndex).Name
                Case "codigo"
                    ComboBox1.SelectedIndex = 1
                    TextBox1.Text = StockgeneralremotoDataGridView.Rows(e.RowIndex).Cells("codigo").Value
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
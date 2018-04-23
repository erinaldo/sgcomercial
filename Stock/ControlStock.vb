Public Class ControlStock

    Private Sub ControlStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.StockgeneralTableAdapter.Fill(Me.ComercialDataSet.stockgeneral)

    End Sub

    Private Sub StockgeneralDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StockgeneralDataGridView.CellContentClick

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
    End Sub
End Class
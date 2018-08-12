Public Class StkMovimientos
    Private Sub StkMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stkmovimientos' Puede moverla o quitarla según sea necesario.
        StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DPDesde.ValueChanged
        Try
            StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            StkmovimientosBindingSource.Filter = "codigoproducto Like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            StkmovimientosBindingSource.Filter = "tipomovimiento Like ''"
        End Try
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gcodigoproducto = 0
        'LabelDescripcion.Text = Nothing
        'gproductodescripcion = Nothing
        BuscarCodigoInterno.ShowDialog()
        If Len(Trim(gcodigoproducto)) > 0 And gcodigoproducto <> "0" Then
            TextBox1.Text = gcodigoproducto.ToString
            'LabelDescripcion.Text = gproductodescripcion
            'BtnImprimir.PerformClick()
        End If
    End Sub
End Class
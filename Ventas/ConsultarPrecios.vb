Public Class ConsultarPrecios
    Private Sub ConsultarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaprecioscaja' Puede moverla o quitarla según sea necesario.
        Me.ListaprecioscajaTableAdapter.Fill(Me.ComercialDataSet.listaprecioscaja)
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ListaprecioscajaBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception

        End Try
    End Sub
End Class
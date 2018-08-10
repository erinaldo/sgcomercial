Public Class ConsultarPrecios
    Private Sub ConsultarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaprecioscaja' Puede moverla o quitarla según sea necesario.
        Me.ListaprecioscajaTableAdapter.Fill(Me.ComercialDataSet.listaprecioscaja)
        TextBox1.Select()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Try

            Select Case ComboBox1.Text
                Case "Código"
                    ListaprecioscajaBindingSource.Filter = "codigoproducto like '%" + TextBox1.Text + "%'"
                Case "Descripción"
                    ListaprecioscajaBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
        TextBox1.SelectAll()
    End Sub
End Class
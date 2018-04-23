Public NotInheritable Class TerminalVerificadoraPrecios

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub TerminalVerificadoraPrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaprecioscaja' Puede moverla o quitarla según sea necesario.
        Me.ListaprecioscajaTableAdapter.Fill(Me.ComercialDataSet.listaprecioscaja)
        TextBox1.Left = (TextBox1.Parent.Width \ 2) - (TextBox1.Width \ 2)
        Label1.Left = (Label1.Parent.Width \ 2) - (TextBox1.Width \ 2)
        GroupBoxProducto.Left = (GroupBoxProducto.Parent.Width \ 2) - (GroupBoxProducto.Width \ 2)
        GroupBoxProducto.Top = (GroupBoxProducto.Parent.Height \ 2) - (GroupBoxProducto.Height \ 2)

        ListaprecioscajaBindingSource.Filter = "codigoproducto like 'N/A'"




    End Sub

    Private Sub TextBox1_SizeChanged(sender As Object, e As EventArgs) Handles TextBox1.SizeChanged


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Me.ListaprecioscajaTableAdapter.Fill(Me.ComercialDataSet.listaprecioscaja)
        Try
            ListaprecioscajaBindingSource.Filter = "codigoproducto = '" + TextBox1.Text + "'"

            If Not ListaprecioscajaBindingSource.Count = 1 Then
                ListaprecioscajaBindingSource.Filter = "codigoproducto like 'N/A'"
                et.Text = Nothing
                kt.Text = Nothing
                DescripcionTextBox.Text = "NO REGISTRADO"
            Else
                Dim precioventa As Decimal = PrecioventaTextBox.Text
                Dim preciokilo As Decimal = PreciokiloTextBox.Text
                et.Text = Math.Floor(precioventa * 1.1)
                kt.Text = Math.Floor(preciokilo * 1.1)
            End If

        Catch ex As Exception
            ListaprecioscajaBindingSource.Filter = "codigoproducto like 'N/A'"
            MsgBox("No se pudo realizar la consulta :" + ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_SizeChanged(sender As Object, e As EventArgs) Handles Label1.SizeChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            TextBox1.SelectAll()
        End If
    End Sub
End Class

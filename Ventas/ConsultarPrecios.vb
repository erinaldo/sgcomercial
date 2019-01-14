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

    Private Sub ConsultarPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
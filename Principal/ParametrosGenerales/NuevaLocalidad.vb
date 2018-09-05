Public Class NuevaLocalidad
    Private Sub NuevaLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = gprovinciaseleccionada
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If LocalidadesTableAdapter.localidades_existelocalidad(Trim(TextBox2.Text), gprovinciaseleccionada) = 0 Then
                LocalidadesTableAdapter.Insert(Val(TextBox1.Text), TextBox2.Text)
                Me.Close()
            Else
                MsgBox("La localidad ingresada ya existe!", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un evento inesperado: " + ex.Message)
        End Try
    End Sub
End Class
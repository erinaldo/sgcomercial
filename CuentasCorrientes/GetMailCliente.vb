Imports System.Text.RegularExpressions

Public Class GetMailCliente
    Private Sub GetMailCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                EmailTo = Nothing
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            EmailTo = TextBox1.Text
            If IsValidEmailFormat(EmailTo) = True Then
                Me.Close()
            Else
                MessageBox.Show("E-mail Inválido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                EmailTo = Nothing
            End If

        End If
    End Sub

    Private Sub GetMailCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = ClientesTableAdapter.GetEmailCliente(gidcliente)
            EmailTo = TextBox1.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class
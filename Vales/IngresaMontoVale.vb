Imports System.Text.RegularExpressions
Public Class IngresaMontoVale
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(Trim(TextBox1.Text)) = 0 Then
                MsgBox("Ingrese un monto válido")
                Return
            End If
            Dim monto As Decimal = TextBox1.Text
            gmontovale = monto
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub IngresaMontoVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gmontovale = 0
    End Sub
End Class
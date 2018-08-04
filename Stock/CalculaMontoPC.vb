Imports System.Text.RegularExpressions
Public Class CalculaMontoPC
    Private Sub CalculaMontoPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPC.Text = gpreciocosto
        TextBoxP.Select()
    End Sub

    Private Sub TextBoxP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxP.TextChanged

        Try
            If Len(Trim(TextBoxP.Text)) = 0 Or Convert.ToDecimal(TextBoxP.Text) = 0 Then
                TextBoxR.Text = Nothing
                TextBoxFinal.Text = Nothing
            End If
            calcular()

        Catch ex As Exception
            TextBoxR.Text = Nothing
            TextBoxFinal.Text = Nothing
        End Try

    End Sub
    Public Sub calcular()
        Try
            Dim ganancia As Decimal
            Dim pfinal As Decimal
            ganancia = Convert.ToDecimal(TextBoxPC.Text) * Convert.ToDecimal(TextBoxP.Text) / 100
            TextBoxR.Text = ganancia
            If rbmas.Checked = True Then
                pfinal = Convert.ToDecimal(TextBoxPC.Text) + ganancia
                pfinal = Math.Ceiling(pfinal)
                TextBoxFinal.Text = pfinal
            Else
                pfinal = Convert.ToDecimal(TextBoxPC.Text) + ganancia
                pfinal = Math.Floor(pfinal)
                TextBoxFinal.Text = pfinal
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbmenos_CheckedChanged(sender As Object, e As EventArgs) Handles rbmenos.CheckedChanged
        calcular()
    End Sub

    Private Sub rbmas_CheckedChanged(sender As Object, e As EventArgs) Handles rbmas.CheckedChanged
        calcular()
    End Sub

    Private Sub TextBoxP_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxP.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                gpreciocalculado = TextBoxFinal.Text
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
                gpreciocalculado = TextBoxFinal.Text
                Me.Close()
            Catch ex As Exception

            End Try

    End Sub

    Private Sub TextBoxP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxP.KeyPress
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
End Class
Public Class SUAuth
    Private Sub SUAuth_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            If TextBoxPwd.Text = "Locura011*?" Then
                gSUToken = True
                Me.Close()
            Else
                gSUToken = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SUAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPwd.Select()
    End Sub
End Class
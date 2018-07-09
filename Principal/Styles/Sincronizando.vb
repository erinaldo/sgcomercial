Public NotInheritable Class Sincronizando
    Dim contador As Integer


    Private Sub Sincronizando_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ProgressBar1.Value = 0
        'ProgressBar1.Maximum = 100
        'Timer1.Interval = 40
        'Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If contador < 100 Then
        '    ProgressBar1.Value = contador
        '    contador = contador + 1
        'Else
        '    contador = 0
        'End If
    End Sub

End Class

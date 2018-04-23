Public Class CajaArqueoInicial

    Private Sub CajaArqueoInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmontoinicial = 0
        Enteros.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gmontoinicial = Enteros.Value
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gmontoinicial = -1
        Me.Close()
    End Sub

 
End Class
Public Class BienvenidaEPOS
    Private Sub BienvenidaEPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        WebBrowser1.Navigate("about:blank")
        WebBrowser1.Document.OpenNew(False)
        WebBrowser1.Document.Write(My.Resources.Bienvenidaepos.ToString)
        WebBrowser1.Refresh()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class VistaPreviaInscripcion
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VistaPreviaInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("") '-- "about:blank"
        'WebBrowser1.Navigate("C:\SGComercial\sgcomercial\Resources\contrato.html")
        WebBrowser1.Document.OpenNew(True)
        WebBrowser1.Document.Write(My.Resources.contrato.ToString)
        WebBrowser1.Refresh()
        'WebBrowser1.ShowPrintPreviewDialog()
    End Sub
End Class
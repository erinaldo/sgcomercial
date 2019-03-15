Imports System.IO
Imports System.Net
Imports System.Net.WebRequest
Imports System.Threading
Imports System.Data.SqlClient
Public Class DownloadForm
    Dim xi As LoadingForm
    'Dim random As New Random
    Dim counter As Integer = 0
    Dim ftpClient As New WebClient
    Dim path As String = "ftp://sistemascomerciales.net/Ejecutable.rar" '+ directories(i).ToString()
    Dim trnsfrpth As String = "C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar" '+ directories(i).ToString()
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        AddHandler ftpClient.DownloadProgressChanged, AddressOf DownloadProgressChanged
        AddHandler ftpClient.DownloadFileCompleted, AddressOf DownloadComplete

        Try
            'FileSystem.Kill("C:\SGComercial\UpdatePack\Ejecutable\*.*")
            ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
            ftpClient.DownloadFileAsync(New Uri(path), trnsfrpth)
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Ocurrió un evento inesperado")
            Return
        End Try
    End Sub
    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        ProgressBar1.Value = gDownloadProgress
        ProgressBar1.Refresh()
        Button1.Text = gDownloadProgress
        Button1.Refresh()
        'Button1.Refresh()
        'Me.Refresh()
    End Sub


    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        'MsgBox("Descarga completa! " + gDownloadProgress.ToString)
        'ProgressBar1.Value = gDownloadProgress
        'ProgressBar1.Refresh()
        'Button1.Text = gDownloadProgress
        'Button1.Refresh()

    End Sub

    Private Sub DownloadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gDownloadProgress = 0
        '=====================================
        'BackgroundWorker.RunWorkerAsync()
        '===========================
        AddHandler ftpClient.DownloadProgressChanged, AddressOf DownloadProgressChanged
        AddHandler ftpClient.DownloadFileCompleted, AddressOf DownloadComplete
        xi = New LoadingForm
        xi.Text = "Descargando última versión"
        xi.ProgressBar.Maximum = 100
        xi.ProgressBar.MarqueeAnimationSpeed = 100
        'xi.mensaje.TextAlign = ContentAlignment.MiddleLeft
        xi.mensaje.Text = "Descargando"
        xi.Show()
        'Try
        Try
                FileSystem.Kill("C:\SGComercial\UpdatePack\Ejecutable\*.rar")
            Catch ex As Exception

            End Try
            ftpClient.Credentials = New System.Net.NetworkCredential("actualizacion@sistemascomerciales.net", "sgcomercial*?")
            ftpClient.DownloadFileAsync(New Uri(path), trnsfrpth)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Ocurrió un evento al descargar la actualización: " + ex.Message)
        '    Return
        'End Try
    End Sub
    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        'counter = counter + 1
        Dim info As New IO.FileInfo("C:\SGComercial\UpdatePack\Ejecutable\Ejecutable.rar")
        Dim length As Long
        length = (info.Length) / 1000
        gDownloadProgress = e.ProgressPercentage
        xi.ProgressBar.Value = gDownloadProgress
        xi.mensaje.Text = length.ToString + "kb " + "Descargando... "
        xi.Refresh()
    End Sub
    Private Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        MsgBox("Descarga completa! " + gDownloadProgress.ToString)
        xi.Dispose()
    End Sub
End Class
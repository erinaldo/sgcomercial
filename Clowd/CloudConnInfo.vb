Public Class CloudConnInfo
    Private Sub ClowdConnInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCloudServer.Text += " " + gCloudServer
        LabelDBName.Text += " " + gCloudDatabase
        LabelDBUser.Text += " " + gCloudUserid
        LabelSCAuthServer.Text += " " + gSCdbserverauth
        LabelSCAuthUser.Text += " " + gSCdbuserauth
    End Sub
End Class
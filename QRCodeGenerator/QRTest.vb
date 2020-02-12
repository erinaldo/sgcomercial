Public Class QRTest
    Dim QRGenerator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub QRTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            PictureBox1.Image = QRGenerator.Encode(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgEx(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
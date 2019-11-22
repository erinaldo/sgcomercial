Public Class CFGMembreteFirmante
    Dim path As String
    Private Sub ButtonCargarCabecera_Click(sender As Object, e As EventArgs) Handles ButtonCargarCabecera.Click
        '*****************
        OpenFileDialog1.InitialDirectory = "c:\Users"
        OpenFileDialog1.Filter = "Image files (*.jpg)|*.jpg"
        OpenFileDialog1.FilterIndex = 2
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            path = OpenFileDialog1.FileName 'System.IO.Path.GetFullPath(OpenFileDialog.FileName)
            PictureBoxCabecera.ImageLocation = OpenFileDialog1.FileName
        End If
        Try
            If (IO.File.Exists(OpenFileDialog1.FileName)) Then

                Dim file As New IO.FileInfo(OpenFileDialog1.FileName)
                If (IO.File.Exists(gSystemDrive + "/SGComercial/" + "cabecera.jpg")) Then
                    FileSystem.Kill(gSystemDrive + "/SGComercial/" + "cabecera.jpg")
                    file.CopyTo(gSystemDrive + "/SGComercial/" + "cabecera.jpg")
                Else
                    file.CopyTo(gSystemDrive + "/SGComercial/" + "cabecera.jpg")
                End If
                'ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTHOMO", Nothing, "C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '**********************
    End Sub

    Private Sub ButtonCargarFirmante_Click(sender As Object, e As EventArgs) Handles ButtonCargarFirmante.Click
        '*****************
        OpenFileDialog1.InitialDirectory = "c:\Users"
        OpenFileDialog1.Filter = "Image files (*.jpg)|*.jpg"
        OpenFileDialog1.FilterIndex = 2
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            path = OpenFileDialog1.FileName 'System.IO.Path.GetFullPath(OpenFileDialog.FileName)
            PictureBoxFirmante.ImageLocation = OpenFileDialog1.FileName
        End If
        Try
            If (IO.File.Exists(OpenFileDialog1.FileName)) Then

                Dim file As New IO.FileInfo(OpenFileDialog1.FileName)
                If (IO.File.Exists(gSystemDrive + "/SGComercial/" + "firmante.jpg")) Then
                    FileSystem.Kill(gSystemDrive + "/SGComercial/" + "firmante.jpg")
                    file.CopyTo(gSystemDrive + "/SGComercial/" + "firmante.jpg")
                Else
                    file.CopyTo(gSystemDrive + "/SGComercial/" + "firmante.jpg")
                End If
                'ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTHOMO", Nothing, "C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '**********************

    End Sub

    Private Sub CFGMembreteFirmante_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CFGMembreteFirmante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBoxCabecera.ImageLocation = gSystemDrive + "/SGComercial/" + "cabecera.jpg"
            PictureBoxFirmante.ImageLocation = gSystemDrive + "/SGComercial/" + "firmante.jpg"
        Catch ex As Exception

        End Try
    End Sub
End Class
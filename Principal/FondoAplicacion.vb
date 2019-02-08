Public Class FondoAplicacion
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ParametrosgeneralesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ParametrosgeneralesBindingNavigatorSaveItem.Click

        If MsgBox("Seguro desea guardar el fondo de pantalla?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Me.Validate()
            Me.ParametrosgeneralesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            FormPrincipal.reloadwallpaper()
        Else
            MsgBox("Operación cancelada", MsgBoxStyle.Information, "Informacion")
            ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
        End If


    End Sub

    Private Sub FondoAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParametrosgeneralesTableAdapter.FillByPrgclave(Me.ComercialDataSet.parametrosgenerales, "FondoAplicacion")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        '*****************
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "c:\Users"
            OpenFileDialog1.Filter = "Image files (*.jpg)|*.jpg"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            '******************** codigo para leer el archivo como stream
            'Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            'MessageBox.Show(sr.ReadToEnd)
            'sr.Close()
            '******************* codigo para leer el archivo como stream
        End If
        '**********************
    End Sub

    Private Sub FondoAplicacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
    End Sub
End Class
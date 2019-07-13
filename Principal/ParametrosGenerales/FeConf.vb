
Imports System.IO.Directory



Public Class FeConf
    Private Sub FeConf_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If MsgBox("Seguro desea guardar la configuración?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Try
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCUIT", Nothing, TCUIT.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPPTOVTA", Nothing, TAFIPPTOVTA.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("FEAFIP", Nothing, ComboBox1.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("FEAutoCAEAFIP", Nothing, "NO", Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("WSAAH", Nothing, TWSAAH.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("WSAAP", Nothing, TWSAAP.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("WSFEV1H", Nothing, TWSFEV1H.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("WSFEV1P", Nothing, TWSFEV1P.Text, Nothing)
                    ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("MiCondicionIVA", ComboBox2.SelectedValue, Nothing, Nothing)
                    'ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTHOMO", Nothing, PATH.Text, Nothing)
                    'ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTPROD", Nothing, PATHP.Text, Nothing)
                    'Me.Close()
                    MsgBox("Configuración guardada exitosamente!", MsgBoxStyle.Information, "Aviso")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub FeConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocondicioniva' Puede moverla o quitarla según sea necesario.
        Me.TipocondicionivaTableAdapter.Fill(Me.ComercialDataSet.tipocondicioniva)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipoiva' Puede moverla o quitarla según sea necesario.
        Try
            ComboBox1.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("FEAFIP")
            TCUIT.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("AFIPCUIT")
            TAFIPPTOVTA.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("AFIPPTOVTA")
            TWSAAH.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("WSAAH")
            TWSAAP.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("WSAAP")
            TWSFEV1H.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("WSFEV1H")
            TWSFEV1P.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("WSFEV1P")
            ComboBox2.SelectedValue = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("MiCondicionIVA")
            PATH.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("AFIPCRTHOMO")
            PATHP.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("AFIPCRTPROD")
        Catch ex As Exception

        End Try

        'TextBox5.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbuserauth")
        'TextBox6.Text = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("dbserverauth")
    End Sub

    Private Sub TWSAAH_DoubleClick(sender As Object, e As EventArgs) Handles TWSAAH.DoubleClick
        Try
            Dim webAddress As String = TWSAAH.Text
            Process.Start(webAddress)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TWSAAH_KeyDown(sender As Object, e As KeyEventArgs) Handles TWSAAH.KeyDown

    End Sub

    Private Sub TWSAAH_TextChanged(sender As Object, e As EventArgs) Handles TWSAAH.TextChanged

    End Sub

    Private Sub TWSAAP_DoubleClick(sender As Object, e As EventArgs) Handles TWSAAP.DoubleClick
        Try
            Dim webAddress As String = TWSAAP.Text
            Process.Start(webAddress)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TWSAAP_TextChanged(sender As Object, e As EventArgs) Handles TWSAAP.TextChanged

    End Sub

    Private Sub TWSFEV1H_DoubleClick(sender As Object, e As EventArgs) Handles TWSFEV1H.DoubleClick
        Try
            Dim webAddress As String = TWSFEV1H.Text
            Process.Start(webAddress)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TWSFEV1H_TextChanged(sender As Object, e As EventArgs) Handles TWSFEV1H.TextChanged

    End Sub

    Private Sub TWSFEV1P_DoubleClick(sender As Object, e As EventArgs) Handles TWSFEV1P.DoubleClick
        Try
            Dim webAddress As String = TWSFEV1P.Text
            Process.Start(webAddress)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TWSFEV1P_TextChanged(sender As Object, e As EventArgs) Handles TWSFEV1P.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog.InitialDirectory = "C:/OpenSSL/bin" ' My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog.Filter = "PFX files (*.pfx)|*.pfx" 'CRT files (*.crt)|*.crt|
        'OpenFileDialog.FilterIndex = 2
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            PATH.Text = OpenFileDialog.FileName 'System.IO.Path.GetFullPath(OpenFileDialog.FileName)
        End If
        Try
            If (IO.File.Exists(OpenFileDialog.FileName)) Then

                Dim file As New IO.FileInfo(OpenFileDialog.FileName)
                If (IO.File.Exists("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)) Then
                    FileSystem.Kill("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                    file.CopyTo("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                Else
                    file.CopyTo("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                End If
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTHOMO", Nothing, "C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ESTADO As String
        Dim strerror As New StrError
        Dim ticket As String = Nothing

        ESTADO = FeAFIPLoad()
        If ESTADO = "DESACTIVADO" Then
            MsgBox(ESTADO, MsgBoxStyle.Exclamation, "Modulo Facturación Electrónica")
            Return
        End If
        strerror = GenTRA(ticket)
        If strerror.CodError > 0 Then
            MsgBox(strerror.MsgError, MsgBoxStyle.Exclamation, "Advertencia!")
            Return
        End If
        MsgBox(ticket)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog.InitialDirectory = "C:/OpenSSL/bin" ' My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog.Filter = "PFX files (*.pfx)|*.pfx"
        'OpenFileDialog.FilterIndex = 2
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            PATHP.Text = OpenFileDialog.FileName 'System.IO.Path.GetFullPath(OpenFileDialog.FileName)
        End If
        Try
            If (IO.File.Exists(OpenFileDialog.FileName)) Then

                Dim file As New IO.FileInfo(OpenFileDialog.FileName)
                If (IO.File.Exists("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)) Then
                    FileSystem.Kill("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                    file.CopyTo("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                Else
                    file.CopyTo("C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString)
                End If
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("AFIPCRTPROD", Nothing, "C:/SGComercial/" + OpenFileDialog.SafeFileName.ToString, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
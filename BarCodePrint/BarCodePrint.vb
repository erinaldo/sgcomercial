Public Class BarCodePrint
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)
        'Dim strbarcode As String = ""
        'Dim rtn As Integer

        'GetEAN13(TextBox1.Text, strbarcode, rtn)
        'resultado.Text = strbarcode
        'EAN13.Text = strbarcode
    End Sub

    Private Sub BarCodePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnImprimir.Enabled = False
        LabelDescripcion.Text = Nothing
        ComboBox1.SelectedIndex = 0
        ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ComboTipoCodigo.SelectedIndex = 0

    End Sub

    Private Sub codev_TextChanged(sender As Object, e As EventArgs) Handles codev.TextChanged

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

        '******************
        'Dim value As String
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim desc As String
        '*****************
        desc = Mid(gproductodescripcion, 1, 40)

        Select Case ComboBox1.Text
            Case 4
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 8
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 12
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 16
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 20
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom5", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 24
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect6", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom5", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom6", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 28
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect6", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect7", EAN132.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom5", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom6", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom7", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
        End Select
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gcodigoproducto = 0
        'LabelDescripcion.Text = Nothing
        'gproductodescripcion = Nothing
        Dim cd As New BuscarCodigoInterno()
        cd.ShowDialog()
        If Len(Trim(gcodigoproducto)) > 0 And gcodigoproducto <> "0" Then
            Dim StrError As New StrError()
            Dim strbarcode As String = ""
            Try
                GetEAN13(gcodigoproducto, strbarcode, StrError)
                If StrError.CodError = 0 Then
                    EAN132.Text = strbarcode
                    labelcodev.Text = gcodigoproducto
                    BtnImprimir.Enabled = True
                    LabelDescripcion.Text = gproductodescripcion
                    BtnImprimir.PerformClick()
                End If
            Catch ex As Exception
                EAN132.Text = Nothing
                labelcodev.Text = Nothing
                BtnImprimir.Enabled = False
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim msg As String = ""
        Dim StrError As New StrError()
        Dim normalizedEAN As String = ""
        Dim normalized128 As String = ""
        Dim templateimage As String = ""
        Dim BC As Image
        Dim cd As New BuscarCodigoInterno()
        cd.ShowDialog()
        '/*****************************/
        Try
            If Len(Trim(gcodigoproducto)) > 0 And gcodigoproducto <> "0" Then
                Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
                Select Case ComboTipoCodigo.Text
                    Case "Code128"
                        ReportViewer2.LocalReport.EnableExternalImages = True
                        ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEtiq3x6CODE128.rdlc"
                        GetNormalCode128(gcodigoproducto, normalized128, StrError)
                        If StrError.CodError = 0 Then
                            BC = GenCode128.Code128Rendering.MakeBarcodeImage(normalized128, 2, True)
                            PictureBox2.Image = BC
                            BC.Save(Application.StartupPath + "\barcode.jpg", Imaging.ImageFormat.Jpeg)
                            templateimage = "file:\" + Application.StartupPath + "\barcode.jpg"
                            StrError.CodError = 0
                            parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("pBarcode", templateimage, False))
                        End If
                '/*******************************
                    Case "EAN-13"
                        ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEtiq3x6EAN13.rdlc"
                        GetEAN13(gcodigoproducto, normalizedEAN, StrError)
                        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("pBarcode", normalizedEAN, False))
                    Case "Ambos"
                        ReportViewer2.LocalReport.EnableExternalImages = True
                        ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEtiq3x6EAN13WC128.rdlc"
                        '/************  GET EAN 13*****************/
                        If Not isAlpha(gcodigoproducto) Then
                            GetEAN13(gcodigoproducto, normalizedEAN, StrError)
                        End If
                        '/***************   GET 128 **************/
                        StrError.CodError = 0
                        GetNormalCode128(gcodigoproducto, normalized128, StrError)
                        If StrError.CodError = 0 Then
                            BC = GenCode128.Code128Rendering.MakeBarcodeImage(normalized128, 2, True)
                            PictureBox2.Image = BC
                            BC.Save(Application.StartupPath + "\barcode.jpg", Imaging.ImageFormat.Jpeg)
                            templateimage = "file:\" + Application.StartupPath + "\barcode.jpg"
                        End If
                        '/*****************************/
                        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("pBarcode", normalizedEAN, False))
                        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("pImage", templateimage, False))
                End Select
                '/*******************************
                If StrError.CodError = 0 Then
                    '/*******************************
                    Me.ReportViewer2.LocalReport.SetParameters(parametros)
                    '/*******************************
                    Me.productosTableAdapter.FillByidproducto(Me.comercialDataSet.productos, productosTableAdapter.productos_existeproducto(gcodigoproducto.ToString))
                    Me.ReportViewer2.RefreshReport()
                Else
                    ReportViewer2.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEtiq3x6EAN13.rdlc"
                    parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("pBarcode", "", False))
                    Me.ReportViewer2.LocalReport.SetParameters(parametros)
                    Me.productosTableAdapter.FillByidproducto(Me.comercialDataSet.productos, 0)
                    Me.ReportViewer2.RefreshReport()
                    MsgExPopUp(StrError.MsgError)
                End If
                '/*********************************************
            End If
        Catch ex As Exception
            MsgEx("Ocurrió una excepción: " + ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs) Handles ReportViewer2.Load

    End Sub

    Private Sub ReportViewer2_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs) Handles ReportViewer2.RenderingComplete

    End Sub
End Class
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
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.productosTableAdapter.Fill(Me.comercialDataSet.productos)
        BtnImprimir.Enabled = False
        LabelDescripcion.Text = Nothing
        Me.ReportViewer1.RefreshReport()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub codev_TextChanged(sender As Object, e As EventArgs) Handles codev.TextChanged
        Dim interno As String = codev.Text
        Dim normal, msg As String
        Dim rtn As Boolean = False
        normal = Nothing
        msg = Nothing
        Try
            '**** si el codigo ingresado tiene 13 digitos que pase a verificarlo... sino que lo normalice
            If Not Len(interno) = 13 Then
                NormalizarCodigo(interno, normal, rtn)
                If rtn = False Then
                    EAN132.Text = Nothing
                    labelcodev.Text = Nothing
                    BtnImprimir.Enabled = False
                    MsgBox("Error al normalizar el codigo: " + normal)
                    Return
                End If
            Else
                normal = interno
            End If
            'MsgBox(normal)
            '*************  verifica el codigo  *******************
            VerificarCodigo(normal, msg, rtn)
            'MsgBox(normal)
            If rtn = False Then
                MsgBox("Ocurrio un error en VerificarCodigo: " + msg)
                EAN132.Text = Nothing
                labelcodev.Text = Nothing
                BtnImprimir.Enabled = False
                Return
            End If

            '***************    todo correcto entonces que lo genere *****************
            Dim strbarcode As String = ""
            GetEAN13(normal, strbarcode, rtn)
            EAN132.Text = strbarcode
            labelcodev.Text = strbarcode
            BtnImprimir.Enabled = True

        Catch ex As Exception
            EAN132.Text = Nothing
            labelcodev.Text = Nothing
            BtnImprimir.Enabled = False
        End Try
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
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 8
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 12
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 16
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 20
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom5", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 24
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect6", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom1", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom2", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom3", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom4", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom5", desc, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("recnom6", desc, False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
            Case 28
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect1", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect2", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect3", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect4", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect5", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect6", labelcodev.Text, False))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("rect7", labelcodev.Text, False))
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



        'Me.librodiarioTableAdapter.FillByDiarioTipo(Me.comercialDataSet.librodiario, DateTimePicker1.Text, "Venta")



        'Dim bitmap As Bitmap
        'bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        'Dim g As Graphics
        'g = Graphics.FromImage(bitmap)

        'Dim rect As Rectangle
        'rect = EAN132.RectangleToScreen(EAN132.ClientRectangle)

        'g.CopyFromScreen(EAN132.Location, EAN132.Location, bitmap.Size)


        'PictureBox1.Image = bitmap
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gcodigoproducto = 0
        'LabelDescripcion.Text = Nothing
        'gproductodescripcion = Nothing
        BuscarCodigoInterno.ShowDialog()
        If Len(Trim(gcodigoproducto)) > 0 And gcodigoproducto <> "0" Then
            codev.Text = gcodigoproducto.ToString
            LabelDescripcion.Text = gproductodescripcion
            BtnImprimir.PerformClick()
        End If


    End Sub
End Class
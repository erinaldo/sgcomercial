Public Class ConsultarVenta

    Private Sub ConsultarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LibroventasdetalleTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventasdetalle, gidventa)
            Me.LibroventasTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventas, gidventa)
            Me.PagosTableAdapter.FillByidventa(Me.ComercialDataSet.pagos, gidventa)

            calcular()
        Catch ex As Exception
            MessageBox.Show("Se encontró una excepción al cargar el reporte: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try


    End Sub

    Private Sub calcular()

        Dim total As Decimal = 0

        For i = 0 To LibroventasdetalleDataGridView.RowCount - 1
            total = total + LibroventasdetalleDataGridView.Rows(i).Cells("subtotal").Value
            'total = PagosDataGridView.Rows(0).Cells(3).Value7
        Next

        totaltextbox.Text = "$ " + total.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ViewerFactura
        p = New ViewerFactura
        p.ShowDialog()
    End Sub

    Private Sub totaltextbox_TextChanged(sender As Object, e As EventArgs) Handles totaltextbox.TextChanged

    End Sub

    Private Sub totaltextbox_Click(sender As Object, e As EventArgs) Handles totaltextbox.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim p As VentaDetallePagosRealizados
        p = New VentaDetallePagosRealizados
        p.ShowDialog()
    End Sub

    Private Sub ConsultarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
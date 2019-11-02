Public Class EditarVenta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idformapago As Integer
        Try
            Select Case ComboBox1.Text
                Case "Efectivo"
                    idformapago = 1
                Case "Débito"
                    idformapago = 2
                Case Else
                    Return
                    'idformapago = 0
            End Select
            If idformapago = 0 Then
                MessageBox.Show("Primero seleccione una forma de pago", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If MessageBox.Show("Seguro desea guardar la forma de pago seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim pagostableadapter As New comercialDataSetTableAdapters.pagosTableAdapter()
                Dim ventastableadapter As New comercialDataSetTableAdapters.ventasTableAdapter()
                ventastableadapter.ventas_updateformapago(idformapago, gidventa)
                pagostableadapter.pagos_updateformapago(idformapago, gidventa)
                MessageBox.Show("Operación exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo completar la operación: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub
End Class
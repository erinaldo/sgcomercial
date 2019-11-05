Public Class SCRegistrarVenta
    Private Sub SCRegistrarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '**********************************************
        If e.KeyCode = Keys.Escape Then
            If e.KeyCode.ToString = "Escape" Then
                If MsgBox("Seguro desea salir del sistema?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    End
                End If
            End If
        End If
        '***************************************************
        If e.KeyCode = Keys.F4 Then
            Try
                Dim row As Integer
                Dim x As New SCListaProductos()
                SCIdproducto = Nothing
                SCProductoDescripcion = Nothing
                x.ShowDialog()
                Try
                    row = DataGridViewDetalle.Rows.Add()
                    DataGridViewDetalle.Rows(row).Cells("idproducto").Value = SCIdproducto
                    DataGridViewDetalle.Rows(row).Cells("idlistaprecio").Value = 1
                    DataGridViewDetalle.Rows(row).Cells("precioventa").Value = 0
                    DataGridViewDetalle.Rows(row).Cells("cantidad").Value = 1
                    DataGridViewDetalle.Rows(row).Cells("descuento").Value = 0
                    DataGridViewDetalle.Rows(row).Cells("recargo").Value = 0
                    DataGridViewDetalle.Rows(row).Cells("fechadesde").Value = Today
                    DataGridViewDetalle.Rows(row).Cells("fechahasta").Value = Today
                    SCIdproducto = Nothing
                    SCProductoDescripcion = Nothing
                    recuento()
                    DataGridViewDetalle.Select()
                Catch ex As Exception
                    SCIdproducto = Nothing
                    SCProductoDescripcion = Nothing
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        '***************************************************
        If e.KeyCode = Keys.Delete Then
            Try
                DataGridViewDetalle.Rows.Remove(DataGridViewDetalle.CurrentRow)
                recuento()
            Catch ex As Exception

            End Try

        End If
        If e.KeyCode = Keys.Subtract Then
            Try
                DataGridViewDetalle.Rows.Remove(DataGridViewDetalle.CurrentRow)
                recuento()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SCRegistrarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SiscomDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.SiscomDataSet.clientes)
        DateTimePickerVencimiento.Value = Today.AddDays(5)
    End Sub

    Private Sub DataGridViewDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDetalle.CellContentClick

    End Sub
    Private Sub recuento()
        Try
            Dim total As Decimal
            Dim precioventa As Decimal
            Dim subtotal As Decimal
            For Each row In DataGridViewDetalle.Rows
                precioventa = row.cells("precioventa").value - row.cells("descuento").value + row.cells("recargo").value
                subtotal = row.cells("cantidad").value * precioventa
                row.cells("subtotal").value = subtotal
                total = total + subtotal
            Next
            TextBoxTotal.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridViewDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDetalle.CellEndEdit
        recuento()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Desea confirmar la Venta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        Else
            MessageBox.Show("Operación cancelada", "PreAdvertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        '**************************************************************************************************************
        Dim VentasTableAdapter As New siscomDataSetTableAdapters.ventasTableAdapter()
        Dim VentasDetalleTableAdapter As New siscomDataSetTableAdapters.ventasdetalleTableAdapter()
        Dim inserted As Long
        Try
            'VentasTableAdapter.ventas_insertar(0, ComboBox1.SelectedValue, Today, DateTimePickerVencimiento.Value)
            inserted = VentasTableAdapter.SCventas_insertar(0, ComboBox1.SelectedValue, Today, DateTimePickerVencimiento.Value)

        Catch ex As Exception

        End Try
    End Sub
End Class
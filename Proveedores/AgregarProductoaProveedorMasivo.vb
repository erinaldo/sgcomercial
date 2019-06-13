Public Class AgregarProductoaProveedorMasivo
    Private Sub AgregarProductoaProveedorMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListaproductosproveedoresvinculadosTableAdapter.FillPPByIdproveedor(Me.ComercialDataSet.listaproductosproveedoresvinculados, gidproveedor)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Proveedor"
                    ListaproductosproveedoresvinculadosBindingSource.Filter = "nombreproveedor like'%" + TextBox1.Text + "%'"
                    'If ProductosDataGridView.RowCount = 0 Then
                    '    ProductosDataGridView.Rows(0).Selected = False
                    'End If
                Case "Código"
                    ListaproductosproveedoresvinculadosBindingSource.Filter = "codigoproducto like'%" + TextBox1.Text + "%'"
                    'If ProductosDataGridView.RowCount = 0 Then
                    '    ProductosDataGridView.Rows(0).Selected = False
                    'End If
                Case "Descripción"
                    ListaproductosproveedoresvinculadosBindingSource.Filter = "descripcion like'%" + TextBox1.Text + "%'"

            End Select
        Catch ex As Exception
            ListaproductosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Seguro desea vincular los productos seleccionados?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            Return
        End If
        Try
            For Each fila As DataGridViewRow In ProductosDataGridView.Rows
                If fila.Selected = True Then
                    Dim existe As Long
                    existe = ProductosproveedoresTableAdapter.productosproveedores_existe(fila.Cells("codigoproducto").Value.ToString)
                    If Not existe = 0 Then
                        'If MsgBox("Seguro desea actualizar este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        Try
                            If ProductosproveedoresTableAdapter.productosproveedores_update(gidproveedor, Nothing, Nothing, Nothing, Nothing, Nothing, fila.Cells("idproducto").Value) Then

                            End If
                        Catch ex As Exception
                            MsgBox("No se pudo completar la acción: " + ex.Message)
                            Return
                        End Try
                        'End If
                    Else
                        'If MsgBox("Seguro desea vincular este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        Try
                            If ProductosproveedoresTableAdapter.productosproveedores_insertar(fila.Cells("idproducto").Value, gidproveedor, Nothing, Nothing, Nothing, Nothing, Nothing) Then

                            End If
                        Catch ex As Exception
                            MsgBox("No se pudo completar la acción: " + ex.Message)
                        End Try
                        'End If
                    End If
                End If
            Next
            MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
            Me.ListaproductosproveedoresvinculadosTableAdapter.FillPPByIdproveedor(Me.ComercialDataSet.listaproductosproveedoresvinculados, gidproveedor)
        Catch ex As Exception
            MsgBox("No se completó la acción seleccionada: " + ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
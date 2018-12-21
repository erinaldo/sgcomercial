Public Class ProductosProveedores
    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gidproveedor = 0
        BuscaProveedor.ShowDialog()
        If Not gidproveedor = 0 Then
            IdproveedorTextBox.Text = gidproveedor.ToString
        End If
    End Sub



    Private Sub ProductosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub IdproveedorTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdproveedorTextBox.TextChanged
        Try
            Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, Val(IdproveedorTextBox.Text))
            Me.ListaproductosproveedoresTableAdapter.FillByidproveedor(Me.ComercialDataSet.listaproductosproveedores, Val(IdproveedorTextBox.Text))
            ButtonAgregar.Enabled = True
            If ProveedoresDataGridView.RowCount = 1 Then
                ButtonAgregar.Enabled = True
            Else
                ButtonAgregar.Enabled = False
            End If
        Catch ex As Exception
            Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, 0)
            LabelProveedor.Text = Nothing

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        gidproveedor = Val(IdproveedorTextBox.Text)
        Dim p As AgregarProductoaProveedor
        p = New AgregarProductoaProveedor
        p.ShowDialog()

        Me.ListaproductosproveedoresTableAdapter.FillByidproveedor(Me.ComercialDataSet.listaproductosproveedores, Val(IdproveedorTextBox.Text))
        gidproveedor = Nothing
    End Sub

    Private Sub ListaproductosproveedoresDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosproveedoresDataGridView.CellContentClick

    End Sub

    Private Sub ListaproductosproveedoresDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosproveedoresDataGridView.CellClick
        Try
            Select Case ListaproductosproveedoresDataGridView.Columns(e.ColumnIndex).Name
                Case "desvincular"
                    Dim idproducto As Long = ListaproductosproveedoresDataGridView.Rows(e.RowIndex).Cells("idproducto").Value
                    Dim idproveedor As Long = ListaproductosproveedoresDataGridView.Rows(e.RowIndex).Cells("idproveedor").Value
                    If MsgBox("Seguro desea desvincular el producto seleccionado?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        ListaproductosproveedoresTableAdapter.listaproductosproveedores_delete(idproducto, idproveedor)
                        Me.ListaproductosproveedoresTableAdapter.FillByidproveedor(Me.ComercialDataSet.listaproductosproveedores, Val(IdproveedorTextBox.Text))
                    End If
            End Select
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub
End Class
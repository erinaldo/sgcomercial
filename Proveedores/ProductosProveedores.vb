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
        Catch ex As Exception
            Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, 0)
            LabelProveedor.Text = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As AgregarProductoaProveedor
        p = New AgregarProductoaProveedor
        p.ShowDialog()

        Me.ListaproductosproveedoresTableAdapter.FillByidproveedor(Me.ComercialDataSet.listaproductosproveedores, Val(IdproveedorTextBox.Text))
    End Sub
End Class
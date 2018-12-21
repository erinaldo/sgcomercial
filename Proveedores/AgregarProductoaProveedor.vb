Imports System.Text.RegularExpressions
Public Class AgregarProductoaProveedor
    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        Try

            gcodigoproducto = Nothing
            Dim p As BuscaProductoVincProveedor
            p = New BuscaProductoVincProveedor
            p.ShowDialog()
            TextBoxCodigoproducto.Text = gcodigoproducto
            Dim idproducto As Long = 0
            idproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
            If idproducto > 0 Then
                ProductosTableAdapter.FillByidproducto(Me.ComercialDataSet.productos, idproducto)
            End If
            gcodigoproducto = Nothing
        Catch ex As Exception
            MsgBox("No se pudo realizar la busqueda del producto: " + ex.Message)
        End Try
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub AgregarProductoaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productosproveedores' Puede moverla o quitarla según sea necesario.
        Me.ProductosproveedoresTableAdapter.Fill(Me.ComercialDataSet.productosproveedores)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

    End Sub

    Private Sub PreciocostoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PreciocostoTextBox.TextChanged

    End Sub

    Private Sub PreciocostoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PreciocostoTextBox.KeyPress
        ' Check for the flag being set in the KeyDown event.
        'If nonNumberEntered = True Then
        '    ' Stop the character from being entered into the control since it is non-numerical.
        '    e.Handled = True
        'End If
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ButtonConfirmar.Click

        Dim existe As Long
        existe = ProductosproveedoresTableAdapter.productosproveedores_existe(IdproductoTextBox.Text, gidproveedor)
        If Not existe = 0 Then
            If MsgBox("Seguro desea actualizar este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                Try
                    If ProductosproveedoresTableAdapter.productosproveedores_update(PreciocostoTextBox.Text, Nothing, Nothing, Nothing, Nothing, IdproductoTextBox.Text, gidproveedor) Then
                        MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("No se pudo completar la acción: " + ex.Message)
                    Return
                End Try
            End If
        Else
            If MsgBox("Seguro desea vincular este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                Try
                    If ProductosproveedoresTableAdapter.productosproveedores_insertar(IdproductoTextBox.Text, gidproveedor, PreciocostoTextBox.Text, Nothing, Nothing, Nothing, Nothing) Then
                        MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("No se pudo completar la acción: " + ex.Message)
                End Try
            End If
        End If




    End Sub
End Class
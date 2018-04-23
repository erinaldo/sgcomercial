Imports System.Text.RegularExpressions
Public Class SeleccionarProductoEnvio
    Private Sub SeleccionarProductoEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ListaproductosBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            ListaproductosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ListaproductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosDataGridView.CellContentClick

    End Sub

    Private Sub ListaproductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosDataGridView.CellDoubleClick
        If Len(Trim(TextBox2.Text)) = 0 Then
            MsgBox("Ingrese cantidad")
            TextBox2.Select()
            Return
        End If
        Try
            gcodigoproducto = ListaproductosDataGridView.Rows(e.RowIndex).Cells(0).Value
            gcantidad = TextBox2.Text
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If Keys.Enter = e.KeyCode Then
            If Len(Trim(TextBox2.Text)) = 0 Then
                MsgBox("Ingrese cantidad")
                TextBox2.Select()
                Return
            End If
            Try
                gcodigoproducto = ListaproductosDataGridView.Rows(ListaproductosDataGridView.CurrentRow.Index).Cells(0).Value
                gcantidad = TextBox2.Text
                Me.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListaproductosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListaproductosDataGridView.KeyDown
        If e.KeyCode = Keys.Tab Then
            TextBox1.Select()
        End If
    End Sub
End Class
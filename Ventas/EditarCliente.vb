Public Class EditarCliente
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            Me.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido el siguiente error: " + ex.Message)
        End Try
    End Sub

    Private Sub EditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        Try
            ClientesBindingSource.Filter = "idcliente = " + gclienteseleccionado.ToString
        Catch ex As Exception
            MsgBox("No se puede cargar la información del cliente: " + ex.Message)
            Me.Close()
        End Try


    End Sub
End Class
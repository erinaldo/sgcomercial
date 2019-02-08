Public Class SeleccionarDomicilio
    Private Sub ClientesdomiciliosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesdomiciliosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SeleccionarDomicilio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.ComercialDataSet.localidades)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientesdomicilios' Puede moverla o quitarla según sea necesario.
        Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
        ClientesdomiciliosBindingSource.Filter = "idcliente = " + gclienteseleccionado.ToString
    End Sub

    Private Sub ClientesdomiciliosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesdomiciliosDataGridView.CellContentClick

    End Sub

    Private Sub ClientesdomiciliosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesdomiciliosDataGridView.CellDoubleClick
        gdomicilioseleccionado = ClientesdomiciliosDataGridView.Rows(e.RowIndex).Cells(0).Value
        'MsgBox(gdomicilioseleccionado.ToString)
        Me.Close()

    End Sub
End Class
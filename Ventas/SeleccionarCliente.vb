Public Class SeleccionarCliente

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SeleccionarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        ComboBox1.Text = "Nombre"

    End Sub

    Private Sub TextBoxfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxfiltro.TextChanged
        Select Case ComboBox1.Text
            Case "Nombre"
                ClientesBindingSource.Filter = "nombre like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
            Case "Cuit"
                ClientesBindingSource.Filter = "cuit like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
            Case Else
                MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
        End Select

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub ClientesDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellDoubleClick
        gclienteseleccionado = ClientesDataGridView.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class
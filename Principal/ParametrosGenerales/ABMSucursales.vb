Public Class ABMSucursales
    Private Sub SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SucursalesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles SucursalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.ComercialDataSet.sucursales)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Try
        '    Dim clientessucursalesTableAdapter As siscomDataSetTableAdapters.clientessucursalesTableAdapter
        '    clientessucursalesTableAdapter = New siscomDataSetTableAdapters.clientessucursalesTableAdapter()
        '    Dim ClientesSucursalesTable As siscomDataSet.clientessucursalesDataTable
        '    ClientesSucursalesTable = clientessucursalesTableAdapter.GetDataByIDcliente(gMiIDCliente)
        '    If ClientesSucursalesTable.Rows.Count > 0 Then
        '        For i = 0 To ClientesSucursalesTable.Count - 1
        '            Dim idsucursal As Long = ClientesSucursalesTable.Rows(i).Item(ClientesSucursalesTable.Columns("idsucursal"))
        '            SucursalesTableAdapter.sucursales_existe(idsucursal)

        '        Next
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class
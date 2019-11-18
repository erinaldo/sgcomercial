Public Class SeleccionarGrado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ABMGrados
        p = New ABMGrados
        ggradoseleccionado = -1
        p.ShowDialog()
        Me.GradosTableAdapter.Fill(Me.ComercialDataSet.grados)
        If ggradoseleccionado > 0 Then
            'galumnoseleccionado = ClientesDataGridView.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub GradosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GradosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SeleccionarGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.grados' Puede moverla o quitarla según sea necesario.
        Me.GradosTableAdapter.Fill(Me.ComercialDataSet.grados)
    End Sub
End Class
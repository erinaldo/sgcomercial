Public Class ABMProvincias
    Private Sub ProvinciasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProvinciasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ProvinciasBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ProvinciasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProvinciasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMProvincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)

    End Sub

    Private Sub ProvinciasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProvinciasDataGridView.CellContentClick

    End Sub

    Private Sub ProvinciasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProvinciasDataGridView.CellClick
        Try
            Select Case ProvinciasDataGridView.Columns(e.ColumnIndex).Name
                Case "ver"
                    gprovinciaseleccionada = ProvinciasDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn1").Value
                    ABMLocalidades.ShowDialog()
                    gprovinciaseleccionada = Nothing
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ABMProvincias_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
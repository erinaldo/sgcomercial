Public Class SeleccionarServicio
    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServiciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SeleccionarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ABMServicios
        p = New ABMServicios
        gservicioseleccionado = -1
        p.ShowDialog()
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
        If gservicioseleccionado > 0 Then
            'gclienteseleccionado = ClientesDataGridView.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub ServiciosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataGridView.CellContentClick

    End Sub

    Private Sub ServiciosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiciosDataGridView.CellDoubleClick
        gservicioseleccionado = ServiciosDataGridView.CurrentRow.Cells("idservicio").Value
        Me.Close()
    End Sub

    Private Sub TextBoxfiltro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Select Case ComboBox1.Text
            Case "Descripción"
                ServiciosBindingSource.Filter = "descripcion like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                'Case "Cuit"
                '    ServiciosBindingSource.Filter = "cuit like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
            Case Else
                MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
        End Select
    End Sub

    Private Sub TextBoxfiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            ServiciosDataGridView.Select()
            Try
                ServiciosDataGridView.Rows(0).Selected = True
            Catch ex As Exception
                MsgBox("Debe seleccionar al menos un producto de la lista", MsgBoxStyle.Exclamation, "Advertencia!")
            End Try
        End If
    End Sub

    Private Sub ServiciosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ServiciosDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            gservicioseleccionado = ServiciosDataGridView.CurrentRow.Cells("idservicio").Value
            Me.Close()
        End If
    End Sub
End Class
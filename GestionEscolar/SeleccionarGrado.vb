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

    Private Sub GradosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GradosDataGridView.CellContentClick

    End Sub

    Private Sub GradosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GradosDataGridView.CellDoubleClick
        ggradoseleccionado = GradosDataGridView.CurrentRow.Cells("idgrado").Value
        Me.Close()
    End Sub

    Private Sub TextBoxfiltro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Grado"
                    GradosBindingSource.Filter = "grado like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case "División"
                    GradosBindingSource.Filter = "division like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case "Turno"
                    GradosBindingSource.Filter = "turno like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case Else
                    MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
                    GradosBindingSource.Filter = ""
            End Select
        Catch ex As Exception
            MsgBox("No se pudo ejecutar el filtrado: " + ex.Message)
            GradosBindingSource.Filter = ""
        End Try

    End Sub

    Private Sub SeleccionarGrado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
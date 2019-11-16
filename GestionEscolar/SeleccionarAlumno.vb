Public Class SeleccionarAlumno
    Private Sub SeleccionarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroalumnos' Puede moverla o quitarla según sea necesario.
        Me.LibroalumnosTableAdapter.Fill(Me.ComercialDataSet.libroalumnos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ABMAlumnos
        p = New ABMAlumnos
        gclienteseleccionado = -1
        p.ShowDialog()
        Me.LibroalumnosTableAdapter.Fill(Me.ComercialDataSet.libroalumnos)
        If gclienteseleccionado > 0 Then
            'gclienteseleccionado = ClientesDataGridView.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxfiltro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Select Case ComboBox1.Text
            Case "Nombre"
                LibroalumnosBindingSource.Filter = "nombre like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
            Case "Documento"
                LibroalumnosBindingSource.Filter = "documento like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
            Case Else
                MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
        End Select
    End Sub

    Private Sub LibroalumnosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroalumnosDataGridView.CellContentClick

    End Sub

    Private Sub LibroalumnosDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles LibroalumnosDataGridView.DoubleClick
        gclienteseleccionado = LibroalumnosDataGridView.CurrentRow.Cells("idalumno").Value
        Me.Close()
    End Sub
End Class
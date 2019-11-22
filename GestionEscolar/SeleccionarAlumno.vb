Public Class SeleccionarAlumno
    Private Sub SeleccionarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroalumnos' Puede moverla o quitarla según sea necesario.
        Me.LibroalumnosTableAdapter.Fill(Me.ComercialDataSet.libroalumnos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ABMAlumnos
        p = New ABMAlumnos
        galumnoseleccionado = -1
        p.ShowDialog()
        Me.LibroalumnosTableAdapter.Fill(Me.ComercialDataSet.libroalumnos)
        If galumnoseleccionado > 0 Then
            'galumnoseleccionado = ClientesDataGridView.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxfiltro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Nombre"
                    LibroalumnosBindingSource.Filter = "nombre like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case "Documento"
                    LibroalumnosBindingSource.Filter = "documento like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case Else
                    MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
                    LibroalumnosBindingSource.Filter = ""
            End Select
        Catch ex As Exception
            LibroalumnosBindingSource.Filter = ""
        End Try

    End Sub

    Private Sub LibroalumnosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroalumnosDataGridView.CellContentClick

    End Sub

    Private Sub LibroalumnosDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles LibroalumnosDataGridView.DoubleClick
        galumnoseleccionado = LibroalumnosDataGridView.CurrentRow.Cells("idalumno").Value
        Me.Close()
    End Sub

    Private Sub TextBoxfiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            LibroalumnosDataGridView.Select()
            Try
                LibroalumnosDataGridView.Rows(0).Selected = True
            Catch ex As Exception
                MsgBox("Debe seleccionar al menos un item de la lista", MsgBoxStyle.Exclamation, "Advertencia!")
            End Try
        End If
    End Sub

    Private Sub LibroalumnosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles LibroalumnosDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            galumnoseleccionado = LibroalumnosDataGridView.CurrentRow.Cells("idalumno").Value
            Me.Close()
        End If
    End Sub

    Private Sub SeleccionarAlumno_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
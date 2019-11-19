Public Class RegistroInscripciones
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            AltaInscripcion.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RegistroInscripciones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            Me.RegistroInscripcionesTableAdapter.Fill(Me.ComercialDataSet.RegistroInscripciones)
        End If
    End Sub

    Private Sub RegistroInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.RegistroInscripciones' Puede moverla o quitarla según sea necesario.
        Me.RegistroInscripcionesTableAdapter.Fill(Me.ComercialDataSet.RegistroInscripciones)
    End Sub

    Private Sub RegistroInscripcionesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegistroInscripcionesDataGridView.CellClick
        Try
            Select Case RegistroInscripcionesDataGridView.Columns(e.ColumnIndex).Name
                Case "anular"
                    MessageBox.Show("Función temporalmente no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistroInscripcionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegistroInscripcionesDataGridView.CellContentClick

    End Sub

    Private Sub RegistroInscripcionesDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegistroInscripcionesDataGridView.CellDoubleClick
        Try
            Dim xj As New VistaPreviaInscripcion()
            gclientesserviciosseleccionado = RegistroInscripcionesDataGridView.Rows(e.RowIndex).Cells("idclientesservicios").Value
            xj.ShowDialog()
            gclientesserviciosseleccionado = Nothing
        Catch ex As Exception
            MsgBox("No se pudo mostrar el contrato: " + ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Tutor"
                    RegistroInscripcionesBindingSource.Filter = "NombreCliente like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case "Alumno"
                    RegistroInscripcionesBindingSource.Filter = "ClienteDocumento like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case "Curso"
                    RegistroInscripcionesBindingSource.Filter = "cursado like '%" + String.Format("{0}%'", TextBoxfiltro.Text)
                Case Else
                    MsgBox("Seleccione el campo por el cual desea filtrar", MsgBoxStyle.Exclamation, "Advertencia")
                    RegistroInscripcionesBindingSource.Filter = ""
            End Select
        Catch ex As Exception
            RegistroInscripcionesBindingSource.Filter = ""
        End Try
    End Sub
End Class
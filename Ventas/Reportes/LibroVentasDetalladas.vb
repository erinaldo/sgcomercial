﻿Public Class LibroVentasDetalladas
    Private Sub LibroVentasDetalladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasdetalleTableAdapter.Fill(Me.ComercialDataSet.libroventasdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasTableAdapter.Fill(Me.ComercialDataSet.libroventas)
        Try
            Dim fecha As Date
            fecha = Convert.ToDateTime(DateTimePicker1.Value)
            Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fecha.ToString)
        Catch ex As Exception
            MsgBox("Excepción: ", ex.Message)
        End Try

    End Sub

    Private Sub LibroventasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellContentClick

    End Sub

    Private Sub LibroventasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellClick
        Try
            gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells(0).Value
            LibroventasdetalleTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventasdetalle, gidventa)

            Select Case LibroventasDataGridView.Columns(e.ColumnIndex).Name
                Case "Imprimir"
                    'Dim p As ConsultarVenta
                    'p = New ConsultarVenta
                    ''gidoperacion = MovimientoscajasDataGridView.CurrentRow.Cells(6).Value
                    ''gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    'p.ShowDialog()
                    '**********************
                    Dim p As ViewerFactura
                    p = New ViewerFactura
                    p.ShowDialog()
                Case "formapago"
                    Dim p As VentaDetallePagosRealizados
                    p = New VentaDetallePagosRealizados
                    p.ShowDialog()
            End Select
            gidventa = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim fecha As Date
            fecha = Convert.ToDateTime(DateTimePicker1.Value)
            Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fecha.ToString)
        Catch ex As Exception
            MsgBox("Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub LibroVentasDetalladas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g As ViewerLibroVentasDetalladas
        g = New ViewerLibroVentasDetalladas
        gFechaSeleccionada = DateTimePicker1.Value
        g.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(Trim(ComboBox1.Text)) > 0 Then
            Try
                Select Case ComboBox1.Text
                    Case "Nombre"
                        LibroventasBindingSource.Filter = "nombre like '%" + TextBox1.Text.ToUpper + "%'"
                    Case "Usuario Carga"
                        LibroventasBindingSource.Filter = "usuariocarga like '%" + TextBox1.Text.ToUpper + "%'"
                End Select
            Catch ex As Exception
                LibroventasBindingSource.Filter = ""
            End Try
        Else
            LibroventasBindingSource.Filter = ""
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
    End Sub
End Class
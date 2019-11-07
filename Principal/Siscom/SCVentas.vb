﻿Public Class SCventas
    Private Sub SCventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SiscomDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasTableAdapter.FillByIDCliente(Me.SiscomDataSet.libroventas, gMiIDCliente)
        Me.LibroventasTableAdapter.Fill(Me.SiscomDataSet.libroventas)
    End Sub

    Private Sub LibroventasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellContentClick

    End Sub

    Private Sub LibroventasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellClick
        Try
            Select Case LibroventasDataGridView.Columns(e.ColumnIndex).Name
                Case "idventas"
                    gidventaSC = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventas").Value
                    Dim j As ViewerFacturaSiscom
                    j = New ViewerFacturaSiscom
                    Cursor.Current = Cursors.WaitCursor
                    j.ShowDialog()
                    gidventaSC = Nothing
                Case "VER"
                    gidventaSC = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventas").Value
                    Dim j As ViewerFacturaSiscom
                    j = New ViewerFacturaSiscom
                    Cursor.Current = Cursors.WaitCursor
                    j.ShowDialog()
                    gidventaSC = Nothing
            End Select
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub RegistrarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentaToolStripMenuItem.Click
        Dim x As New SCRegistrarVenta()
        SCRegistrarVenta.ShowDialog()

    End Sub
End Class
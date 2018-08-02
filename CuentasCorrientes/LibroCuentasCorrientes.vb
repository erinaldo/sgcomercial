﻿Imports System.ComponentModel

Public Class LibroCuentasCorrientes
    Private Sub LibroCuentasCorrientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.librocuentascorrientes' Puede moverla o quitarla según sea necesario.
        Me.LibrocuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.librocuentascorrientes)
        LibrocuentascorrientesDataGridView.Sort(LibrocuentascorrientesDataGridView.Columns("saldo"), ListSortDirection.Descending)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            LibrocuentascorrientesBindingSource.Filter = "nombre like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            Me.LibrocuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.librocuentascorrientes)
        End Try

    End Sub

    Private Sub LibrocuentascorrientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibrocuentascorrientesDataGridView.CellContentClick

    End Sub

    Private Sub LibrocuentascorrientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibrocuentascorrientesDataGridView.CellClick
        Select Case LibrocuentascorrientesDataGridView.Columns(e.ColumnIndex).Name
            Case "nombre"
                Dim p As EstadoCuentaCorriente
                p = New EstadoCuentaCorriente
                p.IdclienteTextBox.Text = LibrocuentascorrientesDataGridView.Rows(e.RowIndex).Cells(0).Value
                gclienteseleccionado = LibrocuentascorrientesDataGridView.Rows(e.RowIndex).Cells(0).Value
                p.filtrarcliente()
                p.PictureSeleccionarCliente.Enabled = False
                p.ShowDialog()
                Me.LibrocuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.librocuentascorrientes)
                LibrocuentascorrientesDataGridView.Sort(LibrocuentascorrientesDataGridView.Columns("saldo"), ListSortDirection.Descending)
        End Select
    End Sub
End Class
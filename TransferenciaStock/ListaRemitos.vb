﻿Public Class ListaRemitos
    Private Sub ListaRemitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListaremitosTableAdapter.Fill(Me.ComercialDataSet.listaremitos)
    End Sub

    Private Sub ListaremitosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaremitosDataGridView.CellClick
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        'Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaremitosdetalle' Puede moverla o quitarla según sea necesario.
        'Me.listaremitosdetalleTableAdapter.Fill(Me.ComercialDataSet.listaremitosdetalle)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaremitos' Puede moverla o quitarla según sea necesario.


        'Me.ReportViewer1.RefreshReport()

        'Dim remito As String = ListaremitosDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
        'ListaremitosBindingSource.Filter = "idremito = " + ListaremitosDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
        'listaremitosdetalleBindingSource.Filter = "idremito = " + remito
        Try
            Dim p As ViewerRemito
            p = New ViewerRemito
            gidremito = ListaremitosDataGridView.Rows(e.RowIndex).Cells(0).Value
            p.ShowDialog()
            gidremito = Nothing
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error: " + ex.Message)
            gidremito = Nothing
        End Try


    End Sub

    Private Sub ListaremitosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaremitosDataGridView.CellContentClick

    End Sub
End Class
﻿Public Class ViewerComanda
    Private Sub ViewerComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.listapedidosdeliveryTableAdapter.Fill(Me.comercialDataSet.listapedidosdelivery)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
        Me.listapedidosdeliverydetalleTableAdapter.Fill(Me.comercialDataSet.listapedidosdeliverydetalle)

        Me.ReportViewer1.RefreshReport()


        listapedidosdeliveryBindingSource.Filter = "idpedidodelivery =" + gidpedidodelivery.ToString
        listapedidosdeliverydetalleBindingSource.Filter = "idpedidodelivery =" + gidpedidodelivery.ToString
        Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print
        Me.Close()
    End Sub

    Private Sub ViewerComanda_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
﻿Public Class CajaArqueoFinal

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gmontofinal = -1
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gmontofinal = Enteros.Value
        Me.Close()
    End Sub

    Private Sub CajaArqueoFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.BioaccesoDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.BioaccesoDataSet.cajasoperaciones)
        '---------------------------
        numIngresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalpagos(gidevento)
        numEgresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalgastos(gidevento)
        '--------------------------
        gmontofinal = 0 'CajasoperacionesTableAdapter.cajasoperaciones_montoneto(gidevento)
        'Enteros.Value = gmontofinal
        Enteros.Select()
        NumericUpDown1.Value = CajaseventosTableAdapter.cajaseventos_saldoinicial(gidcaja)
    End Sub

    Private Sub CajasoperacionesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasoperacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        gmontofinal = Enteros.Value
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        gmontofinal = -1
        Me.Close()
    End Sub
End Class
﻿Imports System.Text.RegularExpressions

Public Class ABMGastos
    Dim idevento As Long = 0
    Public Sub enablebuttons(ByVal status As Boolean)
        If status = True Then
            BtnNuevo.Enabled = False
        Else
            BtnNuevo.Enabled = True
        End If
        Button1.Enabled = status
        DescripcionTextBox.Enabled = status
        MontoTextBox.Enabled = status
        'FechagastoDateTimePicker.Enabled = status
    End Sub

    Private Sub CajaseventosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajaseventosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.gastos' Puede moverla o quitarla según sea necesario.
        'Me.GastosTableAdapter.Fill(Me.ComercialDataSet.gastos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        enablebuttons(False)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        If idevento = 0 Then
            MsgBox("La Caja se encuentra CERRADA", MsgBoxStyle.Information, "Aviso")
            enablebuttons(False)
            Return
        Else

            enablebuttons(True)
            DescripcionTextBox.Text = ""
            MontoTextBox.Text = ""
            FechagastoDateTimePicker.Value = Today

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DescripcionTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Descripción", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If MontoTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Monto", MsgBoxStyle.Information, "Aviso")
            Return
        End If

        Dim idgasto As Long

        If MsgBox("Seguro desea Guardar " + DescripcionTextBox.Text + " por un monto de: " + MontoTextBox.Text + " ?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then

            ''*******************************************************
            idgasto = GastosTableAdapter.gastos_insertar(DescripcionTextBox.Text, CDbl(MontoTextBox.Text), Now())
            'MsgBox(gusername)
            CajasoperacionesTableAdapter.cajasoperaciones_insertargasto(idevento, 1, CDbl(MontoTextBox.Text), idgasto, gusername)
            ''*******************************************************
            MsgBox("Gasto cargado exitosamente!", MsgBoxStyle.Information)
            enablebuttons(False)
            DescripcionTextBox.Text = ""
            MontoTextBox.Text = ""
            FechagastoDateTimePicker.Value = Today
        Else
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub MontoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MontoTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles MontoTextBox.TextChanged

    End Sub

    Private Sub MontoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MontoTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub
End Class
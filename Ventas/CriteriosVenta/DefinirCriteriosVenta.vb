﻿Public Class DefinirCriteriosVenta
    Private Sub CriteriosventaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CriteriosventaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub DefinirCriteriosVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub DefinirCriteriosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.criteriosventa' Puede moverla o quitarla según sea necesario.
        Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gidCriterioSeleccionado = 0
        NuevoCriterioVenta.ShowDialog()
        Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
    End Sub

    Private Sub CriteriosventaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaDataGridView.CellContentClick

    End Sub

    Private Sub CriteriosventaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaDataGridView.CellClick
        Try
            Select Case CriteriosventaDataGridView.Columns(e.ColumnIndex).Name
                Case "EditarCriterio"
                    gidCriterioSeleccionado = CriteriosventaDataGridView.Rows(e.RowIndex).Cells("idcriterioventa").Value
                    NuevoCriterioVenta.ShowDialog()
                    Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
                Case "eliminar"
                    gidCriterioSeleccionado = CriteriosventaDataGridView.Rows(e.RowIndex).Cells("idcriterioventa").Value
                    If MsgQues("Seguro desea eliminar por completo el Criterio de Venta?") = True Then
                        CriteriosventaTableAdapter.criteriosventa_eliminarcriterio(gidCriterioSeleccionado)
                        Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
                    End If
            End Select
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(Trim(TextBox1.Text)) = 0 Then
            CriteriosventaBindingSource.Filter = ""
        End If
        Try
            CriteriosventaBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            CriteriosventaBindingSource.Filter = ""
        End Try
    End Sub
End Class
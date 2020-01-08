Imports System.ComponentModel

Public Class ADModulos
    Private Sub ModulosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ModulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ADModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)

    End Sub

    Private Sub ModulosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ModulosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ModulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ADModulos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        Try
            gModuloClowd = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
            gModuloPedidosWeb = ModulosTableAdapter.modulos_consultarestado("ModuloPedidosWeb")
            gModuloPedidosMovil = ModulosTableAdapter.modulos_consultarestado("ModuloPedidosMovil")
            gMiFranquicia = ModulosTableAdapter.modulos_consultarestado("ModuloFranquicia")
        Catch ex As Exception
            gModuloClowd = 0
            gModuloPedidosWeb = 0
            gModuloPedidosMovil = 0
            gMiFranquicia = 0
            Return
        End Try
    End Sub
End Class
Public Class ABMTransportes
    Private Sub TransportesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransportesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransportesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMTransportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.transportes' Puede moverla o quitarla según sea necesario.
        Me.TransportesTableAdapter.Fill(Me.ComercialDataSet.transportes)

    End Sub

    Private Sub ABMTransportes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
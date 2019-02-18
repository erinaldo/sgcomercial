Public Class ABMRubros

    Private Sub RubrosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RubrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)

    End Sub

    Private Sub ABMRubros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
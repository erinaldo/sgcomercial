Public Class ABMUnidadesMedida

    Private Sub UnidadesmedidaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesmedidaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnidadesmedidaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMUnidadesMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)

    End Sub

    Private Sub ABMUnidadesMedida_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class
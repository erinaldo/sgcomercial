Public Class GGAdmSalones
    Private Sub SalonesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalonesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub GGAdmSalones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.mesas' Puede moverla o quitarla según sea necesario.
        'Me.MesasTableAdapter.Fill(Me.ComercialDataSet.mesas)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.salones' Puede moverla o quitarla según sea necesario.
        Me.SalonesTableAdapter.Fillbyactivos(Me.ComercialDataSet.salones)
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim x As New ABMSalones
            x.ShowDialog()
            Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim x As New ABMMesas
            x.ShowDialog()
            Try
                Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBox1.SelectedValue)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBox1.SelectedValue)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GGAdmSalones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ABMMozos.ShowDialog()
    End Sub
End Class
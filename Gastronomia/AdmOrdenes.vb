Public Class AdmOrdenes
    Private Sub AdmOrdenes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub AdmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.mozos' Puede moverla o quitarla según sea necesario.
        Me.MozosTableAdapter.Fill(Me.ComercialDataSet.mozos)
        ComboBoxSalon.SelectedIndex = -1
        Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
    End Sub

    Private Sub ComboBoxSalon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSalon.SelectedIndexChanged
        Try
            Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBoxSalon.SelectedValue)
        Catch ex As Exception
            MessageBox.Show("Aviso!", "Seleccione primero un salón", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        MsgBox("Hola")
    End Sub

    Private Sub AnularMesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularMesaToolStripMenuItem.Click
        MsgBox("Holamundo")
    End Sub
End Class
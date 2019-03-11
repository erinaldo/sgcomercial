Imports MySql.Data.MySqlClient
Public Class MisSucursales
    Private Sub MisSucursales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub MisSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Dim TerminalesTableAdapter As siscomDataSetTableAdapters.terminalesTableAdapter
        TerminalesTableAdapter = New siscomDataSetTableAdapters.terminalesTableAdapter()
        gMiIDCliente = TerminalesTableAdapter.terminales_consultarIDCliente(gmacadress)
        If ComboSucursal.Items.Count = 0 Then
            If gMiIDCliente > 0 Then
                Me.ClientessucursalesTableAdapter.FillByIDcliente(Me.SiscomDataSet.clientessucursales, gMiIDCliente)
                Cursor.Current = Cursors.Default
            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se pudo obtener el identificador de cliente", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboInforme.SelectedIndexChanged
        Select Case ComboInforme.Text
            Case "Libro Ventas"
                Dim z As CldLibroVentas
                z = New CldLibroVentas
                gSucursalSeleccionada = Val(ComboSucursal.SelectedValue)
                z.ShowDialog()
            Case "Stock General"
                MsgBox("Temporalmente no disponible", MsgBoxStyle.Exclamation, "Aviso")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSucursal.SelectedIndexChanged

    End Sub
End Class
Public Class CldLibroVentas
    Private Sub LibroventasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LibroventasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MySQLDataSet)

    End Sub

    Private Sub CldLibroVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(DateTimePicker1.Value.ToString)
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim fechadesde As DateTime = FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate)
            fechadesde = DateAdd(DateInterval.Day, 0, fechadesde)
            Dim fechahasta As DateTime = FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate)
            fechahasta = DateAdd(DateInterval.Day, 1, fechahasta)
            'MsgBox("Desde: " + fechadesde.ToString + " ------- " + fechahasta.ToString)
            Me.LibroventasTableAdapter.FillByFecha(Me.MySQLDataSet.libroventas, gSucursalSeleccionada, fechadesde, fechahasta)
            Cursor.Current = Cursors.Default
            recuento()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Cursor.Current = Cursors.WaitCursor
        Dim fechadesde As DateTime = FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate)
        fechadesde = DateAdd(DateInterval.Day, 0, fechadesde)
        Dim fechahasta As DateTime = FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate)
        fechahasta = DateAdd(DateInterval.Day, 1, fechahasta)
        'MsgBox("Desde: " + fechadesde.ToString + " ------- " + fechahasta.ToString)
        Me.LibroventasTableAdapter.FillByFecha(Me.MySQLDataSet.libroventas, gSucursalSeleccionada, fechadesde, fechahasta)
        Cursor.Current = Cursors.Default
        recuento()
    End Sub
    Private Sub recuento()
        Dim total As Decimal = 0
        For i = 0 To LibroventasDataGridView.RowCount - 1
            total = total + LibroventasDataGridView.Rows(i).Cells("importe").Value
        Next
        LabelTotal.Text = total
    End Sub

End Class
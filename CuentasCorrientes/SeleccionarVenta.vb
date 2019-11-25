Public Class SeleccionarVenta
    Private Sub SeleccionarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LibroventasccTableAdapter.FillByidclientedeudas(Me.ComercialDataSet.libroventascc, gidcliente)
        Catch ex As Exception
            MsgBox("Ha ocurrido una excepción: " + ex.Message)
        End Try
    End Sub

    Private Sub LibroventasccDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasccDataGridView.CellContentClick

    End Sub

    Private Sub LibroventasccDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasccDataGridView.CellDoubleClick

    End Sub

    Private Sub LibroventasccDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasccDataGridView.CellClick
        Try
            Select Case LibroventasccDataGridView.Columns(e.ColumnIndex).Name
                Case "seleccionar"
                    gidventa = LibroventasccDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                    gmontoapagar = LibroventasccDataGridView.Rows(e.RowIndex).Cells("saldo").Value
                    Me.Close()
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
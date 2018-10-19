Public Class SeleccionaHojaExcel
    Private Sub SeleccionaHojaExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        For i As Integer = 0 To gstrSheetName.Count - 1
            ListBox1.Items.Add(gstrSheetName(i))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        gstrSheetSelected = ListBox1.SelectedItem
        ListBox1.Items.Clear()
        Me.Close()
    End Sub

    Private Sub SeleccionaHojaExcel_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class
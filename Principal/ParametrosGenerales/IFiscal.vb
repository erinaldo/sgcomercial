Public Class IFiscal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IFiscal As New FiscalPrinterLib.HASAR
        Dim IFiscalStatus As String
        '---------------------------------------------

        IFiscal.Puerto = 6
        'IFiscal.ReintentoConstante = True
        IFiscal.Transporte = FiscalPrinterLib.TiposDeTransporte.PUERTO_SERIE
        'Dim rtn As Integer
        IFiscal.AutodetectarControlador()
        IFiscal.TratarDeCancelarTodo()
        IFiscalStatus = IFiscal.ObtenerVersionDelControlador
        Debug.Print(IFiscalStatus)
        '--------------------------------------------- FA
        'Try
        '    IFiscal.AbrirComprobanteFiscal(FiscalPrinterLib.DocumentosFiscales.FACTURA_B)
        '    IFiscal.ImprimirItem("item1", 1, 50, 21, 0)
        '    IFiscal.ImprimirItem("item2", 2, 25, 21, 0)
        '    IFiscal.Subtotal(True, 3, 2, 21, 100)
        '    IFiscal.ImprimirPago("Efectivo", 100)
        '    IFiscal.CerrarComprobanteFiscal()
        '    IFiscal.Finalizar()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try



    End Sub
End Class
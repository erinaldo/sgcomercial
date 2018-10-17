Module SGCModule
    '************************************************
    Public gValidarSTK As String
    Public gbalprefix As String
    Public glistapreferida As Int16
    Public glocalidadseleccionada As Int64
    Public gprovinciaseleccionada As Int64
    Public gpagocombinadoconfirmado As Boolean

    '************************************************
    Public FormPrincipal As Principal
    '************************************************
    Public gmacadress As String
    Public guserid As Integer
    Public guserprofile As String
    Public gusername As String
    Public gnombremodulo As String
    '**************************************************
    Public gmontoapagar As Decimal
    Public gmontoinicial As Decimal
    Public gidevento As Long
    Public gideventoseleccionado As Long
    Public gidcaja As Integer
    Public gmontofinal As Decimal
    Public gmontototal As Decimal
    Public gclienteseleccionado As Long
    Public gdomicilioseleccionado As Long
    Public gmontovale As Decimal
    '************************************
    Public gcantidad As Decimal
    Public glistaprecio As Integer
    Public gcodigoproducto As String
    Public gproductodescripcion As String
    Public gprecioventa As String
    Public gpreciocalculado As String
    Public gpreciocosto As String
    Public gprecioventagranel As String
    Public gprecioventamayorista As String
    Public grecargoTC As Decimal
    Public grecargoCC As Decimal
    Public gidpago As Long
    Public gidcliente As Long
    '************************************
    Public gidoperacion As Long
    Public gidventa As Long
    '*********************
    Public gdescuentopc As Decimal
    Public gdescuentoef As Decimal
    '*********************
    Public gidproveedor As Long
    Public gidpedido As Long
    '*****************************
    Public gidpedidodelivery As Long
    Public gidlote As Long
    '*****************************
    Public gidremito As Long

    '*******************************    GLOBAL FUNCTIONS        *********************************
    '***************************    NormalizarCodigo    ***************************************************
    ' convierte un codigo numerico de longitud menor a 12 caracteres a un codigo de longitud 13 (digito verificador incluido)
    '*************************************************************************************************
    Public Sub NormalizarCodigo(ByVal codigointerno As String, ByRef codigonormal As String, ByRef rtn As Boolean)
        Dim ori, rev As String
        Dim i As Integer
        'MsgBox("recibido: " + Len(codigointerno).ToString)
        If Len(codigointerno) > 12 Then
            codigonormal = "La longitud del codigo a normalizar es demasiado grande"
            rtn = False
            Return
        End If

        If Len(Trim(codigointerno)) < 12 Then
            ori = Trim(codigointerno)
            rev = StrReverse(ori)
            'MsgBox(rev)
            For i = Len(Trim(codigointerno)) + 1 To 12
                If Not i = 12 Then
                    rev += "0"
                Else
                    rev += "3" ''''''''''''''''PREFIJO DE CODIGO INTERNO
                End If
            Next
            ori = StrReverse(rev)
            codigonormal = ori
            GetCodeWithVDigit(codigonormal)
            rtn = True
            'MsgBox(codigointerno + " | " + codigonormal)
            Return
        Else
            codigonormal = codigointerno
            GetCodeWithVDigit(codigonormal)
            rtn = True
            'MsgBox(codigointerno + " | " + codigonormal)
            Return
        End If
    End Sub

    '***********************************************************************************************
    '***************************    GetEAN13    ***************************************************
    ' convierte un codigo numerico de 13 digitos en string barcode para representar en la fuente EAN13
    '*************************************************************************************************
    Public Sub GetEAN13(ByVal codigo As String, ByRef barcode As String, ByRef rtn As Integer)
        Dim p1 As Integer = 0
        Dim p2 As Integer = 0
        Dim p3 As Integer = 0
        Dim p4 As Integer = 0
        Dim p5 As Integer = 0



        Select Case Mid(codigo, 1, 1)
            Case 0
                p1 = 48
                p2 = 48
                p3 = 48
                p4 = 48
                p5 = 48
            Case 1
                p1 = 48
                p2 = 64
                p3 = 48
                p4 = 64
                p5 = 64
            Case 2
                p1 = 48
                p2 = 64
                p3 = 64
                p4 = 48
                p5 = 64
            Case 3
                p1 = 48
                p2 = 64
                p3 = 64
                p4 = 64
                p5 = 48
            Case 4
                p1 = 64
                p2 = 48
                p3 = 48
                p4 = 64
                p5 = 64
            Case 5
                p1 = 64
                p2 = 64
                p3 = 48
                p4 = 48
                p5 = 64
            Case 6
                p1 = 64
                p2 = 64
                p3 = 64
                p4 = 48
                p5 = 48
            Case 7
                p1 = 64
                p2 = 48
                p3 = 64
                p4 = 48
                p5 = 64
            Case 8
                p1 = 64
                p2 = 48
                p3 = 64
                p4 = 64
                p5 = 48
            Case 9
                p1 = 64
                p2 = 64
                p3 = 48
                p4 = 64
                p5 = 48
            Case Else
                p1 = 64
                p2 = 64
                p3 = 64
                p4 = 64
                p5 = 64

        End Select



        Try
            barcode = Convert.ToChar(Convert.ToInt16(Mid(codigo, 1, 1)) + 33)   '1
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 2, 1)) + 96)  '2
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 3, 1)) + p1)  '3 --------------
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 4, 1)) + p2)  '4 -----------------
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 5, 1)) + p3)  '5
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 6, 1)) + p4)  '6
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 7, 1)) + p5)  '7
            barcode += "|"
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 8, 1)) + 80)  '8
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 9, 1)) + 80)  '9
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 10, 1)) + 80) '10
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 11, 1)) + 80) '11
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 12, 1)) + 80) '12
            barcode += Convert.ToChar(Convert.ToInt16(Mid(codigo, 13, 1)) + 112) '13    
            rtn = 1
        Catch ex As Exception
            rtn = 0
        End Try
    End Sub
    '***********************************************************************************************
    '***************************    GetCodeWithVDigit    ***************************************************
    ' ingresa como parametro un codigo numerico de 12 digitos y lo devuelve con su respectivo digito verificador (length 13)
    '*************************************************************************************************
    Public Sub GetCodeWithVDigit(ByRef codigo As String)
        Dim code As String
        Dim doce As String
        Dim once As String
        Dim i As Integer
        Dim sum As Integer
        Dim mult As Integer
        Dim total As Integer
        Dim cielo As Integer
        Dim flt As Decimal
        Dim dv As Integer

        Try

            code = Mid(codigo, 1, 12)
            code = StrReverse(code)
            ' PASO 1
            doce = Mid(code, 1, 1)
            ' PASO 2
            sum = Convert.ToInt16(doce)
            For i = 3 To code.Length - 1 Step 2
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' PASO 3
            mult = sum * 3
            ' PASO 4
            once = Mid(code, 2, 1)
            ' PASO 5
            sum = Convert.ToInt16(once)
            For i = 4 To code.Length Step 2
                'MsgBox(sum.ToString + " + " + Mid(code, i, 1))
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' MsgBox(sum.ToString)
            ' PASO 6
            total = sum + mult
            ' PASO 7
            'MsgBox(total.ToString)
            flt = total / 10
            'MsgBox(flt)
            flt = Math.Ceiling(flt)
            'MsgBox(flt)
            cielo = flt * 10
            'MsgBox(cielo.ToString)
            dv = cielo - total
            codigo += dv.ToString

        Catch ex As Exception
            codigo = "0"

        End Try
    End Sub
    '***********************************************************************************************
    '***************************    VerificarCodigo    ***************************************************
    ' valida que el codigo de 13 digitos este generado correctamente 
    '*************************************************************************************************
    Public Sub VerificarCodigo(ByVal codigo As String, ByRef msg As String, ByRef rtn As Boolean)
        Dim dvrecibido As String
        dvrecibido = Mid(codigo, 13, 1)
        'MsgBox("VerificarCodigo: " + codigo + " - Codigo recibido: " + dvrecibido)
        If codigo.Length <> 13 Then
            rtn = False
            msg = "el codigo no tiene la longitud correcta"
            Return
        End If
        Try
            GetVDigit(codigo, rtn)
            If codigo = dvrecibido Then
                rtn = True
                'MsgBox("Codigo Correcto")
                Return
            Else
                'MsgBox("VerificarCodigo/GetVDigit: Codigo ERRONEO")
                rtn = False
                msg = "Dígito Calculado: " + codigo + " || Dígito Recibído: " + dvrecibido
                'MsgBox("VerificarCodigo/GetVDigit: Codigo ERRONEO " + codigo)
                Return
            End If
        Catch ex As Exception

        End Try
    End Sub
    '***********************************************************************************************
    '***************************    GetVDigit    ***************************************************
    ' ingresa como parametro un codigo numerico de 12 digitos y lo devuelve con su respectivo digito verificador (length 13)
    '*************************************************************************************************
    Public Sub GetVDigit(ByRef codigo As String, ByRef rtn As Boolean)
        Dim code As String
        Dim doce As String
        Dim once As String
        Dim i As Integer
        Dim sum As Integer
        Dim mult As Integer
        Dim total As Integer
        Dim cielo As Integer
        Dim flt As Decimal
        Dim dv As Integer

        Try

            code = Mid(codigo, 1, 12)
            code = StrReverse(code)
            ' PASO 1
            doce = Mid(code, 1, 1)
            ' PASO 2
            sum = Convert.ToInt16(doce)
            For i = 3 To code.Length - 1 Step 2
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' PASO 3
            mult = sum * 3
            ' PASO 4
            once = Mid(code, 2, 1)
            ' PASO 5
            sum = Convert.ToInt16(once)
            For i = 4 To code.Length Step 2
                'MsgBox(sum.ToString + " + " + Mid(code, i, 1))
                sum += Convert.ToInt16(Mid(code, i, 1))
            Next
            ' MsgBox(sum.ToString)
            ' PASO 6
            total = sum + mult
            ' PASO 7
            'MsgBox(total.ToString)
            flt = total / 10
            'MsgBox(flt)
            flt = Math.Ceiling(flt)
            'MsgBox(flt)
            cielo = flt * 10
            'MsgBox(cielo.ToString)
            dv = cielo - total
            codigo = dv.ToString
            rtn = True
            Return
        Catch ex As Exception
            codigo = "No se pudo generar el digito verificador"
            rtn = False
            Return
        End Try
    End Sub
    Public Function LimpiarCodigo(ByRef codigo As String) As String
        codigo = Trim(codigo)
        codigo = codigo.Replace("'", "-")

        Return codigo
    End Function
End Module

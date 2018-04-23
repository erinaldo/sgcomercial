Imports System.Text.RegularExpressions
Public Class IngresaCantidad
    Public codigoproducto As String
    Public precioventa As Decimal
    Public precioventagranel As Decimal
    Public precioventamayorista As Decimal
    Public unidadmedida As Integer
    Private Sub IngresaCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim total As Decimal
        cantidadtextbox.Text = "1"
        preciotextbox.Text = "$ " + precioventa.ToString
        gprecioventa = precioventa
        glistaprecio = 1
        total = precioventa * Val(cantidadtextbox.Text)
        totaltextbox.Text = total.ToString
        cantidadtextbox.Select()
    End Sub

    Private Sub cantidadtextbox_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        calcular()
    End Sub

    Private Sub cantidadtextbox_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        calcular()
    End Sub

    Private Sub cantidadtextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        calcular()
    End Sub
    Private Sub cantidadtextbox_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calcular()
    End Sub
    Public Sub calcular()
        Dim total As Decimal
        '        cantidadtextbox.Text = "1"
        'preciotextbox.Text = "$ " + precioventa.ToString
        precioventa = preciotextbox.Text
        total = precioventa * cantidadtextbox.Text
        totaltextbox.Text = total.ToString
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub


    Private Sub cantidadtextbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If IsNumeric(cantidadtextbox.Text) = False Then
            cantidadtextbox.Select()
        Else
            calcular()
        End If
    End Sub

    Private Sub cantidadtextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cantidadtextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cantidadtextbox.KeyDown
        If Len(Trim(cantidadtextbox.Text)) = 0 Then Return
        If e.KeyCode = Keys.Enter Then
            gprecioventa = preciotextbox.Text
            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
            gmontototal = totaltextbox.Text
            gmontototal = Decimal.Round(gmontototal, 2)
            gprecioventa = preciotextbox.Text
            Me.Close()
        End If
    End Sub

    Private Sub cantidadtextbox_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidadtextbox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cantidadtextbox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cantidadtextbox.TextChanged
        If IsNumeric(cantidadtextbox.Text) = False Then
            cantidadtextbox.Select()
        Else
            If cantidadtextbox.Focused Then
                calcular()
            End If
        End If
    End Sub

    Private Sub totaltextbox_TextChanged(sender As Object, e As EventArgs) Handles totaltextbox.TextChanged
        If Len(Trim(totaltextbox.Text)) = 0 Then Return
        If totaltextbox.Focused Then
            gmontototal = Convert.ToDecimal(totaltextbox.Text)
            precioventa = preciotextbox.Text
            gcantidad = gmontototal / precioventa
            gcantidad = Decimal.Round(gcantidad, 3)
            cantidadtextbox.Text = gcantidad
        End If
    End Sub

    Private Sub totaltextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totaltextbox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If

    End Sub

    Private Sub totaltextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles totaltextbox.KeyDown
        If Len(Trim(totaltextbox.Text)) = 0 Then Return
        If e.KeyCode = Keys.Enter Then
            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
            gmontototal = Decimal.Round(Convert.ToDecimal(totaltextbox.Text), 3)
            gprecioventa = preciotextbox.Text
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBoxListaPrecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxListaPrecios.SelectedIndexChanged
        Select Case ComboBoxListaPrecios.SelectedIndex
            Case 0
                precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigoproducto)
                preciotextbox.Text = "$ " + String.Format(precioventa)
                gprecioventa = preciotextbox.Text
                glistaprecio = 1
                'MsgBox("hola" + precioventa.ToString)
            Case 1
                precioventagranel = ProductosTableAdapter.productos_consultarpreciogranel(codigoproducto)
                Dim medida As Decimal
                medida = ProductosTableAdapter.productos_consultarmedida(codigoproducto)
                preciotextbox.Text = "$ " + String.Format(precioventagranel / medida)
                gprecioventa = preciotextbox.Text
                glistaprecio = 2
                'MsgBox("hola" + precioventagranel.ToString)
            Case 2
                precioventamayorista = ProductosTableAdapter.productos_consultarpreciomayorista(codigoproducto)
                preciotextbox.Text = "$ " + String.Format(precioventamayorista)
                gprecioventa = preciotextbox.Text
                glistaprecio = 3
                'MsgBox("hola" + precioventamayorista.ToString)
        End Select
        calcular()
    End Sub
End Class
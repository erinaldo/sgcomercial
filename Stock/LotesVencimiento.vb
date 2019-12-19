Public Class LotesVencimiento
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Dim idproducto As Long
        Dim cantidad As Decimal
        Dim ProductosTableAdapter As New comercialDataSetTableAdapters.productosTableAdapter()
        Dim LotesVencimientoTableAdapter As New comercialDataSetTableAdapters.lotesvencimientoTableAdapter()
        '************* validaciones
        If Len(Trim(codigoproductotextbox.Text)) = 0 Then
            MessageBox.Show("Debe Ingresar el Código de Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            idproducto = ProductosTableAdapter.productos_existeproducto(codigoproductotextbox.Text)
            If Not idproducto > 0 Then
                MessageBox.Show("Debe Ingresar el Código de Producto Válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                codigoproductotextbox.Select()
                Return
            End If
        End If
        If Len(Trim(cantidadtextbox.Text)) = 0 Then
            MessageBox.Show("Debe Ingresar la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Try
                cantidad = Convert.ToDecimal(cantidadtextbox.Text)
            Catch ex As Exception
                MessageBox.Show("Cantidad Incorrecta!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cantidadtextbox.Select()
                Return
            End Try

        End If
        '********************* insertar
        Try
            LotesVencimientoTableAdapter.lotesvencimiento_insertar(idproducto, cantidad, DateTimePickerVencimiento.Text, codigoexternotextbox.Text)
            enablebuttons(False)
            enablefields(False)
            MessageBox.Show("Operación Exitosa!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocurrio una excepción al insertar: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
        '*******************************************************
    End Sub

    Private Sub LotesVencimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enablebuttons(False)
        enablefields(False)
    End Sub

    Private Sub LotesVencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
    Private Sub enablebuttons(ByRef status As Boolean)
        If status = False Then
            BtnCancelar.Enabled = False
            BtnConfirmar.Enabled = False
            BtnNuevo.Enabled = True
            PictureBox1.Enabled = False
        Else
            BtnCancelar.Enabled = True
            BtnConfirmar.Enabled = True
            BtnNuevo.Enabled = False
            PictureBox1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        enablebuttons(True)
        enablefields(True)
    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        codigoproductotextbox.Enabled = status
        cantidadtextbox.Enabled = status
        DateTimePickerVencimiento.Enabled = status
        codigoexternotextbox.Enabled = status
        If status = False Then
            codigoproductotextbox.Text = Nothing
            cantidadtextbox.Text = Nothing
            DateTimePickerVencimiento.Value = Today()
            codigoexternotextbox.Text = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        enablebuttons(False)
        enablefields(False)
    End Sub

    Private Sub LibroDeVencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDeVencimientosToolStripMenuItem.Click
        Dim XD As New LibroVencimientosProductos()
        XD.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim StrRes As New StrError()
        GBuscaProductoManual(StrRes)
        If StrRes.CodError = 0 Then
            codigoproductotextbox.Text = gcodigoproducto
            gcodigoproducto = Nothing
        End If
    End Sub
End Class
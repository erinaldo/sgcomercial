Imports System.IO
Imports MySql.Data.MySqlClient
Public Class ImportarProductos


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BtnConfirmar.Enabled = False
        Try
            Dim myconnection As OleDb.OleDbConnection
            Dim HDR As String
            If CbxCabeceras.Checked Then
                HDR = "SI"
            Else
                HDR = "NO"
            End If
            Dim ds As System.Data.DataSet
            Dim myadapter As System.Data.OleDb.OleDbDataAdapter
            If radioxls.Checked = True Then ' connn for XLS file
                '*****************
                OpenFileDialog1.InitialDirectory = "c:\"
                OpenFileDialog1.Filter = "xls files (*.xls)|*.xls"
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    OpenFileDialog1.FilterIndex = 1
                    OpenFileDialog1.RestoreDirectory = True
                    'MsgBox(OpenFileDialog1.FileName)
                End If
                '**********************
                '------------   LEER HOJAS DEL EXCEL
                '**********************
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                xlApp.Workbooks.Open(OpenFileDialog1.FileName, 0, True)
                ' For the first sheet in an excel spreadsheet
                'xlWorkSheet = CType(xlApp.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                'una sola hoja
                'Dim strSheetName As String = xlWorkSheet.Name
                'MsgBox(strSheetName)
                'varias hojas
                gstrSheetName.Clear()
                For Each xlWorkSheet In xlApp.Sheets
                    gstrSheetName.Add(xlWorkSheet.Name)
                    '                    MsgBox(xlWorkSheet.Name)
                Next
                gstrSheetSelected = Nothing
                Dim p As SeleccionaHojaExcel
                p = New SeleccionaHojaExcel
                p.ShowDialog()
                If gstrSheetSelected = Nothing Then
                    p.Close()
                    Return
                End If
                p.Close()
                xlApp.Workbooks.Close()
                '**********************
                '-------------------------- FIN LEER HOJAS
                '**********************
                myconnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + OpenFileDialog1.FileName + "';Extended Properties='Excel 8.0;HDR=" + HDR + ";IMEX=1'")
            ElseIf radioxlsx.Checked = True Then ' connn for XLSX file
                '*****************
                OpenFileDialog1.InitialDirectory = "c:\"
                OpenFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx"
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    OpenFileDialog1.FilterIndex = 1
                    OpenFileDialog1.RestoreDirectory = True
                    'MsgBox(OpenFileDialog1.FileName)
                End If
                '**********************
                '**********************
                '------------   LEER HOJAS DEL EXCEL
                '**********************
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim xlApp As New Microsoft.Office.Interop.Excel.Application
                xlApp.Workbooks.Open(OpenFileDialog1.FileName, 0, True)
                ' For the first sheet in an excel spreadsheet
                'xlWorkSheet = CType(xlApp.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                'una sola hoja
                'Dim strSheetName As String = xlWorkSheet.Name
                'MsgBox(strSheetName)
                'varias hojas
                gstrSheetName.Clear()
                For Each xlWorkSheet In xlApp.Sheets
                    gstrSheetName.Add(xlWorkSheet.Name)
                    '                    MsgBox(xlWorkSheet.Name)
                Next
                gstrSheetSelected = Nothing
                Dim p As SeleccionaHojaExcel
                p = New SeleccionaHojaExcel
                p.ShowDialog()
                If gstrSheetSelected = Nothing Then
                    p.Close()
                    Return
                End If
                p.Close()
                xlApp.Workbooks.Close()
                '**********************
                '-------------------------- FIN LEER HOJAS
                '**********************
                myconnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + OpenFileDialog1.FileName + "';Extended Properties='Excel 12.0 Xml;HDR=" + HDR + ";IMEX=1'")
            End If
            myadapter = New System.Data.OleDb.OleDbDataAdapter("select * from [" + gstrSheetSelected + "$]", myconnection)
            ds = New System.Data.DataSet
            myadapter.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
            myconnection.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo procesar el archivo", MsgBoxStyle.Exclamation)
            'MsgBox("No se pudo procesar el archivo" + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p As AyudaImportarProductos
        p = New AyudaImportarProductos
        p.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim existe As Long = 0
        Dim actualizaciones As Long = 0
        Dim altas As Long = 0
        For i = 0 To DataGridView1.RowCount - 1
            Try
                existe = ProductosTableAdapter.productos_existeproducto(DataGridView1.Rows(i).Cells("codigoproducto").Value)
                If existe > 0 Then
                    actualizaciones = actualizaciones + 1
                Else
                    altas = altas + 1
                End If

            Catch ex As Exception
                Dim reg As Long
                reg = i + 1
                MsgBox("Registro N° " + reg.ToString + " el código del producto es inválido! ", MsgBoxStyle.Exclamation, "Advertencia")
                ErrorlogTableAdapter.errorlog_insertar(Today, "ImportarProductos", "Exception", "Button2_Click", "Registro N° " + reg.ToString + " el código del producto es inválido! " + ex.Message)
                Return
            End Try
        Next
        '*******************
        Dim rtn As Boolean
        Dim msg As String
        validarcolumnasProdImportados(DataGridView1, rtn, msg)
        If rtn = False Then
            MsgBox(msg, MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        '*******************
        Dim result As Boolean
        validarcampos(result)
        If result = False Then
            Return
        End If
        If MsgBox("Se encontraron " + actualizaciones.ToString + " productos para actualizar y " + altas.ToString + " producto nuevos. Desea confirmar la operación?", vbYesNo, "Pregunta") = vbYes Then
            BtnConfirmar.Enabled = True
        Else
            BtnConfirmar.Enabled = False
        End If
    End Sub
    Public Sub validarcampos(ByRef status As Boolean)
        status = False
        Dim existe As Long
        For i = 0 To DataGridView1.RowCount - 1
            Try 'comienzo a recorrer la grilla
                existe = ProductosTableAdapter.productos_existeproducto(DataGridView1.Rows(i).Cells("codigoproducto").Value)
                '************************************************************************************************
                '*****************************      ACTUALIZACIÓN DE PRODUCTOS  *******************************************************************
                '************************************************************************************************
                If existe > 0 Then
                    Dim codigoproducto As String
                    codigoproducto = DataGridView1.Rows(i).Cells("codigoproducto").Value
                    Dim marca As String
                    marca = DataGridView1.Rows(i).Cells("marca").Value
                    Dim modelo As String
                    modelo = DataGridView1.Rows(i).Cells("modelo").Value
                    Dim presentacion As String
                    presentacion = DataGridView1.Rows(i).Cells("presentacion").Value
                    '**** obtengo la unidad de medida
                    Dim unidadmedida As Long = 0
                    Dim unidadmedidastr As String
                    unidadmedidastr = DataGridView1.Rows(i).Cells("unidadmedida").Value
                    unidadmedida = UnidadesmedidaTableAdapter.unidadesmedida_existeunidad(unidadmedidastr)
                    If unidadmedida = 0 Then
                        Throw New Exception("La unidad de medida es incorrecta! -" + unidadmedidastr + "-")
                    End If
                    '**** obtengo la unidad de medida
                    Dim medida As Decimal
                    medida = DataGridView1.Rows(i).Cells("medida").Value
                    Dim descripcion As String
                    descripcion = DataGridView1.Rows(i).Cells("descripcion").Value
                    Dim preciocosto As Decimal
                    preciocosto = DataGridView1.Rows(i).Cells("preciocosto").Value
                    Dim precioventa As Decimal
                    precioventa = DataGridView1.Rows(i).Cells("preciocosto").Value
                    Dim idrubro As Long = 0
                    '*** obtengo el rubro   ******
                    idrubro = RubrosTableAdapter.rubros_getidrubro(DataGridView1.Rows(i).Cells("idrubro").Value)
                    If idrubro = 0 Then
                        Try
                            idrubro = RubrosTableAdapter.rubros_insertar_rtn(DataGridView1.Rows(i).Cells("idrubro").Value)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            idrubro = 1
                        End Try
                    End If
                    Dim stockminimo As Long
                    stockminimo = DataGridView1.Rows(i).Cells("stockminimo").Value
                    Dim precioventagranel As Decimal
                    precioventagranel = DataGridView1.Rows(i).Cells("precioventagranel").Value
                    Dim precioventamayorista As Decimal
                    precioventamayorista = DataGridView1.Rows(i).Cells("precioventamayorista").Value
                    Dim precioventadistribuidor As Decimal
                    precioventadistribuidor = DataGridView1.Rows(i).Cells("precioventadistribuidor").Value
                    '*************************************************************************************
                    'ProductosTableAdapter.productos_upd_prodimport(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, idrubro, stockminimo, precioventagranel, precioventamayorista, precioventadistribuidor, existe)
                    'actualizaciones = actualizaciones + 1
                Else
                    '************************************************************************************************
                    '*****************************      ALTA DE NUEVOS PRODUCTOS  *******************************************************************
                    '************************************************************************************************
                    Dim codigoproducto As String
                    codigoproducto = DataGridView1.Rows(i).Cells("codigoproducto").Value
                    Dim marca As String
                    marca = DataGridView1.Rows(i).Cells("marca").Value
                    Dim modelo As String
                    modelo = DataGridView1.Rows(i).Cells("modelo").Value
                    Dim presentacion As String
                    presentacion = DataGridView1.Rows(i).Cells("presentacion").Value
                    '**** obtengo la unidad de medida
                    Dim unidadmedida As Long = 0
                    Dim unidadmedidastr As String
                    unidadmedidastr = DataGridView1.Rows(i).Cells("unidadmedida").Value
                    unidadmedida = UnidadesmedidaTableAdapter.unidadesmedida_existeunidad(unidadmedidastr)
                    If unidadmedida = 0 Then
                        Throw New Exception("Producto Cod: " + codigoproducto + " la unidad de medida es incorrecta! -" + unidadmedidastr + "-")
                    End If
                    '**** obtengo la unidad de medida
                    Dim medida As Decimal
                    medida = DataGridView1.Rows(i).Cells("medida").Value
                    Dim descripcion As String
                    descripcion = DataGridView1.Rows(i).Cells("descripcion").Value
                    Dim preciocosto As Decimal
                    preciocosto = DataGridView1.Rows(i).Cells("preciocosto").Value
                    Dim precioventa As Decimal
                    precioventa = DataGridView1.Rows(i).Cells("preciocosto").Value
                    Dim idrubro As Long = 0
                    Dim idrubrostr As String = Nothing
                    '*** obtengo el rubro   ******
                    idrubrostr = DataGridView1.Rows(i).Cells("idrubro").Value
                    idrubro = RubrosTableAdapter.rubros_getidrubro(idrubrostr)
                    If idrubro = 0 Then ' el rubro no existe --- lo voy a insertar
                        Try
                            idrubro = RubrosTableAdapter.rubros_insertar_rtn(idrubrostr)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            idrubro = 1
                        End Try
                    End If
                    Dim stockminimo As Long
                    stockminimo = DataGridView1.Rows(i).Cells("stockminimo").Value
                    Dim precioventagranel As Decimal
                    precioventagranel = DataGridView1.Rows(i).Cells("precioventagranel").Value
                    Dim precioventamayorista As Decimal
                    precioventamayorista = DataGridView1.Rows(i).Cells("precioventamayorista").Value
                    Dim precioventadistribuidor As Decimal
                    precioventadistribuidor = DataGridView1.Rows(i).Cells("precioventadistribuidor").Value
                    '*************************************************************************************
                    'ProductosTableAdapter.productos_ins_prodimport(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, idrubro, stockminimo, precioventagranel, precioventamayorista, precioventadistribuidor, 1)
                End If
            Catch ex As Exception
                Dim reg As Long
                reg = i + 1
                MsgBox("Datos incorrectos en el registro N° " + reg.ToString + ": " + ex.Message)
                Return
            End Try
        Next
        status = True
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ImportarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productosproveedores' Puede moverla o quitarla según sea necesario.
        Me.ProductosproveedoresTableAdapter.Fill(Me.ComercialDataSet.productosproveedores)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.errorlog' Puede moverla o quitarla según sea necesario.
        Me.ErrorlogTableAdapter.Fill(Me.ComercialDataSet.errorlog)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Dim ProductosWebTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
        ProductosWebTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
        '****************************************
        If MsgBox("Seguro desea aplicar los cambios?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            '************************************************************************************************
            Dim existe As Long
            For i = 0 To DataGridView1.RowCount - 1
                Try 'comienzo a recorrer la grilla
                    existe = ProductosTableAdapter.productos_existeproducto(DataGridView1.Rows(i).Cells("codigoproducto").Value)
                    '************************************************************************************************
                    '*****************************      ACTUALIZACIÓN DE PRODUCTOS  *******************************************************************
                    '************************************************************************************************
                    If existe > 0 Then
                        Dim codigoproducto As String
                        codigoproducto = DataGridView1.Rows(i).Cells("codigoproducto").Value
                        Dim marca As String
                        marca = DataGridView1.Rows(i).Cells("marca").Value
                        Dim modelo As String
                        modelo = DataGridView1.Rows(i).Cells("modelo").Value
                        Dim presentacion As String
                        presentacion = DataGridView1.Rows(i).Cells("presentacion").Value
                        '**** obtengo la unidad de medida
                        Dim unidadmedida As Long = 0
                        Dim unidadmedidastr As String
                        unidadmedidastr = DataGridView1.Rows(i).Cells("unidadmedida").Value
                        unidadmedida = UnidadesmedidaTableAdapter.unidadesmedida_existeunidad(unidadmedidastr)
                        If unidadmedida = 0 Then
                            Throw New Exception("La unidad de medida es incorrecta! -" + unidadmedidastr + "-")
                        End If
                        '**** obtengo la unidad de medida
                        Dim medida As Decimal
                        medida = DataGridView1.Rows(i).Cells("medida").Value
                        Dim descripcion As String
                        descripcion = DataGridView1.Rows(i).Cells("descripcion").Value
                        Dim preciocosto As Decimal
                        preciocosto = DataGridView1.Rows(i).Cells("preciocosto").Value
                        Dim precioventa As Decimal
                        precioventa = DataGridView1.Rows(i).Cells("precioventa").Value
                        Dim idrubro As Long = 0
                        '*** obtengo el rubro   ******
                        idrubro = RubrosTableAdapter.rubros_getidrubro(DataGridView1.Rows(i).Cells("idrubro").Value)
                        If idrubro = 0 Then
                            Try
                                idrubro = RubrosTableAdapter.rubros_insertar_rtn(DataGridView1.Rows(i).Cells("idrubro").Value)
                            Catch ex As Exception
                                ErrorlogTableAdapter.errorlog_insertar(Today, "ImportarProductos", "Exception", "Button4_Click", ex.Message)
                                MsgBox(ex.Message)
                                idrubro = 1
                            End Try
                        End If
                        Dim stockminimo As Long
                        stockminimo = DataGridView1.Rows(i).Cells("stockminimo").Value
                        Dim precioventagranel As Decimal
                        precioventagranel = DataGridView1.Rows(i).Cells("precioventagranel").Value
                        Dim precioventamayorista As Decimal
                        precioventamayorista = DataGridView1.Rows(i).Cells("precioventamayorista").Value
                        Dim precioventadistribuidor As Decimal
                        precioventadistribuidor = DataGridView1.Rows(i).Cells("precioventadistribuidor").Value
                        '*************************************************************************************
                        ProductosTableAdapter.productos_upd_prodimport(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, idrubro, stockminimo, precioventagranel, precioventamayorista, precioventadistribuidor, existe)
                        ProductosWebTableAdapter.productosweb_update(marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, 0, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro, codigoproducto)
                        '*************************************************************************************
                        '====== actualizar stock actual ====
                        Try
                            Dim diferencia As Decimal
                            Dim stock As Decimal
                            stock = DataGridView1.Rows(i).Cells("stock").Value
                            If stock > 0 Then 'voy a insertar stock
                                Dim stockactual As Decimal
                                stockactual = StockTableAdapter.stock_consultardisponible(existe)
                                diferencia = stockactual - stock
                                If diferencia <> 0 Then
                                    If diferencia > 0 Then
                                        stock = Math.Abs(diferencia)
                                        StockTableAdapter.stock_insertarmovimiento(existe, stock, Today, gusername, "S", "Ajuste Stock Importación Excel")
                                    Else
                                        stock = Math.Abs(diferencia)
                                        StockTableAdapter.stock_insertarmovimiento(existe, stock, Today, gusername, "E", "Ajuste Stock Importación Excel")
                                    End If
                                End If
                            End If
                        Catch ex As Exception
                            'MsgBox("No se incluyó el stock")
                            'Return
                        End Try
                        '====== actualizar stock actual ====
                    Else
                        '************************************************************************************************
                        '*****************************      ALTA DE NUEVOS PRODUCTOS  *******************************************************************
                        '************************************************************************************************
                        Dim codigoproducto As String
                        codigoproducto = DataGridView1.Rows(i).Cells("codigoproducto").Value
                        Dim marca As String
                        marca = DataGridView1.Rows(i).Cells("marca").Value
                        Dim modelo As String
                        modelo = DataGridView1.Rows(i).Cells("modelo").Value
                        Dim presentacion As String
                        presentacion = DataGridView1.Rows(i).Cells("presentacion").Value
                        '**** obtengo la unidad de medida
                        Dim unidadmedida As Long = 0
                        Dim unidadmedidastr As String
                        unidadmedidastr = DataGridView1.Rows(i).Cells("unidadmedida").Value
                        unidadmedida = UnidadesmedidaTableAdapter.unidadesmedida_existeunidad(unidadmedidastr)
                        If unidadmedida = 0 Then
                            Throw New Exception("Producto Cod: " + codigoproducto + " la unidad de medida es incorrecta! -" + unidadmedidastr + "-")
                        End If
                        '**** obtengo la unidad de medida
                        Dim medida As Decimal
                        medida = DataGridView1.Rows(i).Cells("medida").Value
                        Dim descripcion As String
                        descripcion = DataGridView1.Rows(i).Cells("descripcion").Value
                        Dim preciocosto As Decimal
                        preciocosto = DataGridView1.Rows(i).Cells("preciocosto").Value
                        Dim precioventa As Decimal
                        precioventa = DataGridView1.Rows(i).Cells("precioventa").Value
                        Dim idrubro As Integer = 0
                        Dim idrubrostr As String = Nothing
                        '*** obtengo el rubro   ******
                        idrubrostr = DataGridView1.Rows(i).Cells("idrubro").Value
                        idrubro = RubrosTableAdapter.rubros_getidrubro(idrubrostr)
                        If idrubro = 0 Then ' el rubro no existe --- lo voy a insertar
                            Try
                                idrubro = RubrosTableAdapter.rubros_insertar_rtn(idrubrostr)
                            Catch ex As Exception
                                ErrorlogTableAdapter.errorlog_insertar(Today, "ImportarProductos", "Exception", "Button4_Click", ex.Message)
                                MsgBox(ex.Message)
                                idrubro = 1
                            End Try
                        End If
                        Dim stockminimo As Long
                        stockminimo = DataGridView1.Rows(i).Cells("stockminimo").Value
                        Dim precioventagranel As Decimal
                        precioventagranel = DataGridView1.Rows(i).Cells("precioventagranel").Value
                        Dim precioventamayorista As Decimal
                        precioventamayorista = DataGridView1.Rows(i).Cells("precioventamayorista").Value
                        Dim precioventadistribuidor As Decimal
                        precioventadistribuidor = DataGridView1.Rows(i).Cells("precioventadistribuidor").Value
                        '*************************************************************************************
                        ProductosTableAdapter.productos_ins_prodimport(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, idrubro, stockminimo, precioventagranel, precioventamayorista, precioventadistribuidor, 1)
                        'ProductosproveedoresTableAdapter.Insert()
                        ProductosWebTableAdapter.productosweb_insertar(codigoproducto, marca, modelo, presentacion, unidadmedida, medida, descripcion, preciocosto, precioventa, Nothing, stockminimo, 0, Nothing, precioventamayorista, precioventagranel, "A", precioventadistribuidor, idrubro)

                        '=========== tomo el nuevo id de producto para insertar stock
                        existe = ProductosTableAdapter.productos_existeproducto(codigoproducto) ' traigo el codigo del nuevo producto
                        '====== nuevo stock actual ====
                        Try
                            Dim stockactual As Decimal
                            stockactual = DataGridView1.Rows(i).Cells("stock").Value
                            'MsgBox("con stock")
                            If stockactual > 0 Then 'voy a insertar stock
                                StockTableAdapter.stock_insertarmovimiento(existe, stockactual, Today, gusername, "E", "Ajuste Stock Importación Excel")
                            End If
                        Catch ex As Exception
                            'MsgBox("No se incluyó el stock")
                            'Return
                        End Try
                        '====== nuevo stock actual ====
                    End If
                Catch ex As Exception
                    ErrorlogTableAdapter.errorlog_insertar(Today, "ImportarProductos", "Exception", "Button4_Click", "Error al importar: " + ex.Message)
                    MsgBox("Error al importar: " + ex.Message)
                End Try
            Next
            MsgBox("El proceso ha finalizado correctamente!", MsgBoxStyle.Information, "Aviso")
            Me.Close()
            '************************************************************************************************
        End If
    End Sub

    Private Sub radioxls_CheckedChanged(sender As Object, e As EventArgs) Handles radioxls.CheckedChanged
        BtnConfirmar.Enabled = False
    End Sub

    Private Sub radioxlsx_CheckedChanged(sender As Object, e As EventArgs) Handles radioxlsx.CheckedChanged
        BtnConfirmar.Enabled = False
    End Sub

    Private Sub CbxCabeceras_CheckedChanged(sender As Object, e As EventArgs) Handles CbxCabeceras.CheckedChanged
        BtnConfirmar.Enabled = False
    End Sub
End Class
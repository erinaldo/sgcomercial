﻿Public Class VistaPreviaInscripcion
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VistaPreviaInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RegistroInscripcionesTableAdapter As New comercialDataSetTableAdapters.RegistroInscripcionesTableAdapter()
        Dim RegistroInscripcionesDataTable As New comercialDataSet.RegistroInscripcionesDataTable()
        RegistroInscripcionesDataTable = RegistroInscripcionesTableAdapter.GetDataByidclientesservicios(gclientesserviciosseleccionado)
        Dim texto As String = My.Resources.contrato.ToString
        Dim NombreCliente As String
        Dim DocumentoCliente As String
        Dim ClienteDomicilio As String
        Dim NombreAlumno As String
        Dim Cursado As String
        Dim CicloLectivo As String = "2020"
        Dim ServicioDescripcion As String
        Dim PrecioVenta As String
        Dim DiaDelMes As String = Today.Day
        Dim MesDelAnio As String = MonthName(Today.Month)
        Dim Anio As String = Today.Year
        NombreCliente = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.NombreClienteColumn)
        ClienteDomicilio = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.domicilioColumn)
        DocumentoCliente = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.ClienteDocumentoColumn)
        NombreAlumno = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.NombreAlumnoColumn)
        ServicioDescripcion = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.descripcionColumn)
        PrecioVenta = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.precioventaColumn)
        Cursado = RegistroInscripcionesDataTable.Rows(0).Item(RegistroInscripcionesDataTable.cursadoColumn)
        '/****************************************************/
        texto = texto.Replace("&NombreCliente", NombreCliente)
        texto = texto.Replace("&ClienteDomicilio", ClienteDomicilio)
        texto = texto.Replace("&DocumentoCliente", DocumentoCliente)
        texto = texto.Replace("&NombreAlumno", NombreAlumno)
        texto = texto.Replace("&Cursado", Cursado)
        texto = texto.Replace("&CicloLectivo", CicloLectivo)
        texto = texto.Replace("&ServicioDescripcion", ServicioDescripcion)
        texto = texto.Replace("&PrecioVenta", PrecioVenta)
        texto = texto.Replace("&DiaDelMes", DiaDelMes)
        texto = texto.Replace("&MesDelAnio", MesDelAnio)
        texto = texto.Replace("&Anio", Anio)
        '/****************************************************/
        WebBrowser1.Navigate("") '-- "about:blank"
        'WebBrowser1.Navigate("C:\SGComercial\sgcomercial\Resources\contrato.html")
        WebBrowser1.Document.OpenNew(True)
        WebBrowser1.Document.Write(texto)
        WebBrowser1.Document.Title = "title"

        WebBrowser1.Refresh()
        '***********
        'WebBrowser1.ShowPrintPreviewDialog()
        gclientesserviciosseleccionado = Nothing
    End Sub

    Private Sub ToolStripButtonImprimir_Click(sender As Object, e As EventArgs) Handles ToolStripButtonImprimir.Click

        WebBrowser1.Document.Title = ""
        WebBrowser1.ShowPrintPreviewDialog()

    End Sub

    Private Sub VistaPreviaInscripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
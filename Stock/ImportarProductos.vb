Imports System.IO
Public Class ImportarProductos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                '**********************
                '-------------------------- FIN LEER HOJAS
                '**********************
                myconnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + OpenFileDialog1.FileName + "';Extended Properties='Excel 12.0 Xml;HDR=" + HDR + ";IMEX=1'")
            End If
            myadapter = New System.Data.OleDb.OleDbDataAdapter("select * from [" + gstrSheetSelected + "$]", myconnection)
            ds = New System.Data.DataSet
            myadapter.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub
End Class
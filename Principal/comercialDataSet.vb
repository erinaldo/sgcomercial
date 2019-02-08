Partial Class comercialDataSet
    Partial Public Class librodiarioDataTable
        Private Sub librodiarioDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idoperacionColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace comercialDataSetTableAdapters
    
    Partial Public Class librodiarioTableAdapter
    End Class
End Namespace

Namespace comercialDataSetTableAdapters
    Partial Public Class valesTableAdapter
    End Class
End Namespace

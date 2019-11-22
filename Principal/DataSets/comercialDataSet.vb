Partial Class comercialDataSet
    Partial Public Class EstIngUltimoscierresDataTable
        Private Sub EstIngUltimoscierresDataTable_EstIngUltimoscierresRowChanging(sender As Object, e As EstIngUltimoscierresRowChangeEvent) Handles Me.EstIngUltimoscierresRowChanging

        End Sub

    End Class

    Partial Public Class pagosDataTable
        Private Sub pagosDataTable_pagosRowChanging(sender As Object, e As pagosRowChangeEvent) Handles Me.pagosRowChanging

        End Sub

    End Class

    Partial Public Class librodiarioDataTable
        Private Sub librodiarioDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idoperacionColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace comercialDataSetTableAdapters
    Partial Public Class cajasoperacionesTableAdapter
    End Class

    Partial Public Class listaproductosTableAdapter
    End Class

    Partial Public Class listalotesdetalleTableAdapter
    End Class

    Partial Public Class listapedidosdeliveryTableAdapter
    End Class

    Partial Public Class librodiarioTableAdapter
    End Class
End Namespace

Namespace comercialDataSetTableAdapters
    Partial Public Class valesTableAdapter
    End Class
End Namespace

Namespace comercialDataSetTableAdapters
    Partial Public Class pedidosdeliveryTableAdapter
    End Class
End Namespace

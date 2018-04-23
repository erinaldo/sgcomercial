<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajaArqueoInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Enteros = New System.Windows.Forms.NumericUpDown()
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto Inicial:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Enteros
        '
        Me.Enteros.DecimalPlaces = 2
        Me.Enteros.Location = New System.Drawing.Point(151, 39)
        Me.Enteros.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.Enteros.Name = "Enteros"
        Me.Enteros.Size = New System.Drawing.Size(140, 30)
        Me.Enteros.TabIndex = 8
        Me.Enteros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Enteros.ThousandsSeparator = True
        '
        'CajaArqueoInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 156)
        Me.Controls.Add(Me.Enteros)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CajaArqueoInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CajaArqueoInicial"
        CType(Me.Enteros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Enteros As System.Windows.Forms.NumericUpDown
End Class

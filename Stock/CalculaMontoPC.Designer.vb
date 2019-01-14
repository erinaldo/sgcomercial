<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculaMontoPC
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbmenos = New System.Windows.Forms.RadioButton()
        Me.rbmas = New System.Windows.Forms.RadioButton()
        Me.TextBoxFinal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPC = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rbmenos)
        Me.GroupBox1.Controls.Add(Me.rbmas)
        Me.GroupBox1.Controls.Add(Me.TextBoxFinal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxPC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbmenos
        '
        Me.rbmenos.AutoSize = True
        Me.rbmenos.Checked = True
        Me.rbmenos.Location = New System.Drawing.Point(77, 86)
        Me.rbmenos.Name = "rbmenos"
        Me.rbmenos.Size = New System.Drawing.Size(171, 21)
        Me.rbmenos.TabIndex = 9
        Me.rbmenos.TabStop = True
        Me.rbmenos.Text = "Redondear por menos"
        Me.rbmenos.UseVisualStyleBackColor = True
        '
        'rbmas
        '
        Me.rbmas.AutoSize = True
        Me.rbmas.Location = New System.Drawing.Point(278, 86)
        Me.rbmas.Name = "rbmas"
        Me.rbmas.Size = New System.Drawing.Size(155, 21)
        Me.rbmas.TabIndex = 8
        Me.rbmas.Text = "Redondear por más"
        Me.rbmas.UseVisualStyleBackColor = True
        '
        'TextBoxFinal
        '
        Me.TextBoxFinal.Enabled = False
        Me.TextBoxFinal.Location = New System.Drawing.Point(360, 40)
        Me.TextBoxFinal.Name = "TextBoxFinal"
        Me.TextBoxFinal.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFinal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ganancia:"
        '
        'TextBoxR
        '
        Me.TextBoxR.Enabled = False
        Me.TextBoxR.Location = New System.Drawing.Point(235, 40)
        Me.TextBoxR.Name = "TextBoxR"
        Me.TextBoxR.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxR.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porcentaje:"
        '
        'TextBoxP
        '
        Me.TextBoxP.Location = New System.Drawing.Point(134, 40)
        Me.TextBoxP.Name = "TextBoxP"
        Me.TextBoxP.Size = New System.Drawing.Size(77, 22)
        Me.TextBoxP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio Costo"
        '
        'TextBoxPC
        '
        Me.TextBoxPC.Enabled = False
        Me.TextBoxPC.Location = New System.Drawing.Point(16, 40)
        Me.TextBoxPC.Name = "TextBoxPC"
        Me.TextBoxPC.Size = New System.Drawing.Size(86, 22)
        Me.TextBoxPC.TabIndex = 0
        '
        'CalculaMontoPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 180)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculaMontoPC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Monto (%)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPC As TextBox
    Friend WithEvents rbmenos As RadioButton
    Friend WithEvents rbmas As RadioButton
    Friend WithEvents TextBoxFinal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class

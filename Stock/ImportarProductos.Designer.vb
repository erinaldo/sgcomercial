<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioxlsx = New System.Windows.Forms.RadioButton()
        Me.radioxls = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxCabeceras = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbxCabeceras)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radioxlsx)
        Me.GroupBox1.Controls.Add(Me.radioxls)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 601)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importar desde excel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Formato:"
        '
        'radioxlsx
        '
        Me.radioxlsx.AutoSize = True
        Me.radioxlsx.Location = New System.Drawing.Point(183, 32)
        Me.radioxlsx.Name = "radioxlsx"
        Me.radioxlsx.Size = New System.Drawing.Size(55, 21)
        Me.radioxlsx.TabIndex = 4
        Me.radioxlsx.Text = ".xlsx"
        Me.radioxlsx.UseVisualStyleBackColor = True
        '
        'radioxls
        '
        Me.radioxls.AutoSize = True
        Me.radioxls.Checked = True
        Me.radioxls.Location = New System.Drawing.Point(116, 32)
        Me.radioxls.Name = "radioxls"
        Me.radioxls.Size = New System.Drawing.Size(49, 21)
        Me.radioxls.TabIndex = 3
        Me.radioxls.TabStop = True
        Me.radioxls.Text = ".xls"
        Me.radioxls.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(874, 503)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(819, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Examinar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cabeceras en la primer fila (?)"
        '
        'CbxCabeceras
        '
        Me.CbxCabeceras.AutoSize = True
        Me.CbxCabeceras.Checked = True
        Me.CbxCabeceras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbxCabeceras.Location = New System.Drawing.Point(516, 32)
        Me.CbxCabeceras.Name = "CbxCabeceras"
        Me.CbxCabeceras.Size = New System.Drawing.Size(72, 21)
        Me.CbxCabeceras.TabIndex = 7
        Me.CbxCabeceras.Text = "Si / No"
        Me.CbxCabeceras.UseVisualStyleBackColor = True
        '
        'ImportarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 625)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ImportarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ImportarProductos"
        Me.Text = "ImportarProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents radioxlsx As RadioButton
    Friend WithEvents radioxls As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CbxCabeceras As CheckBox
    Friend WithEvents Label2 As Label
End Class

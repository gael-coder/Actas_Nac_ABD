<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosActaFrm
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
        Me.TextBoxFOLIO = New System.Windows.Forms.TextBox()
        Me.ComboBoxOFIC = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.ComboBoxNUM_LIBRO = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FOLIO:"
        '
        'TextBoxFOLIO
        '
        Me.TextBoxFOLIO.Enabled = False
        Me.TextBoxFOLIO.Location = New System.Drawing.Point(83, 26)
        Me.TextBoxFOLIO.Name = "TextBoxFOLIO"
        Me.TextBoxFOLIO.Size = New System.Drawing.Size(93, 27)
        Me.TextBoxFOLIO.TabIndex = 1
        '
        'ComboBoxOFIC
        '
        Me.ComboBoxOFIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOFIC.FormattingEnabled = True
        Me.ComboBoxOFIC.Location = New System.Drawing.Point(282, 26)
        Me.ComboBoxOFIC.Name = "ComboBoxOFIC"
        Me.ComboBoxOFIC.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxOFIC.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(460, 205)
        Me.DataGridView1.TabIndex = 4
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(191, 393)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(94, 29)
        Me.btnIns.TabIndex = 5
        Me.btnIns.Text = "Insertar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FECHA DE REGISTRO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NUM. LIBRO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "OFICIALIA:"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(291, 393)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(94, 29)
        Me.btnMod.TabIndex = 12
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(391, 393)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(94, 29)
        Me.btnElim.TabIndex = 13
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'ComboBoxNUM_LIBRO
        '
        Me.ComboBoxNUM_LIBRO.FormattingEnabled = True
        Me.ComboBoxNUM_LIBRO.Location = New System.Drawing.Point(118, 74)
        Me.ComboBoxNUM_LIBRO.Name = "ComboBoxNUM_LIBRO"
        Me.ComboBoxNUM_LIBRO.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxNUM_LIBRO.TabIndex = 14
        '
        'DatosActaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 431)
        Me.Controls.Add(Me.ComboBoxNUM_LIBRO)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxOFIC)
        Me.Controls.Add(Me.TextBoxFOLIO)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DatosActaFrm"
        Me.Text = "DatosActaFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFOLIO As TextBox
    Friend WithEvents ComboBoxOFIC As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnIns As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMod As Button
    Friend WithEvents btnElim As Button
    Friend WithEvents ComboBoxNUM_LIBRO As ComboBox
End Class

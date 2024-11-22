<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MunicipioFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID_ESTADO = New System.Windows.Forms.TextBox()
        Me.ComboBoxESTADO = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.ComboBoxMUNICIPIO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxPais = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'TextBoxID_ESTADO
        '
        Me.TextBoxID_ESTADO.Enabled = False
        Me.TextBoxID_ESTADO.Location = New System.Drawing.Point(51, 24)
        Me.TextBoxID_ESTADO.Name = "TextBoxID_ESTADO"
        Me.TextBoxID_ESTADO.Size = New System.Drawing.Size(49, 27)
        Me.TextBoxID_ESTADO.TabIndex = 1
        '
        'ComboBoxESTADO
        '
        Me.ComboBoxESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxESTADO.FormattingEnabled = True
        Me.ComboBoxESTADO.Location = New System.Drawing.Point(358, 24)
        Me.ComboBoxESTADO.Name = "ComboBoxESTADO"
        Me.ComboBoxESTADO.Size = New System.Drawing.Size(153, 28)
        Me.ComboBoxESTADO.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(488, 162)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ESTADO:"
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(417, 263)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(94, 29)
        Me.btnElim.TabIndex = 7
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(317, 263)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(94, 29)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(217, 263)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(94, 29)
        Me.btnIns.TabIndex = 9
        Me.btnIns.Text = "Insertar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'ComboBoxMUNICIPIO
        '
        Me.ComboBoxMUNICIPIO.FormattingEnabled = True
        Me.ComboBoxMUNICIPIO.Location = New System.Drawing.Point(102, 61)
        Me.ComboBoxMUNICIPIO.Name = "ComboBoxMUNICIPIO"
        Me.ComboBoxMUNICIPIO.Size = New System.Drawing.Size(409, 28)
        Me.ComboBoxMUNICIPIO.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PAÍS:"
        '
        'cboxPais
        '
        Me.cboxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPais.FormattingEnabled = True
        Me.cboxPais.Location = New System.Drawing.Point(149, 24)
        Me.cboxPais.Name = "cboxPais"
        Me.cboxPais.Size = New System.Drawing.Size(132, 28)
        Me.cboxPais.TabIndex = 11
        '
        'MunicipioFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 307)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxPais)
        Me.Controls.Add(Me.ComboBoxMUNICIPIO)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxESTADO)
        Me.Controls.Add(Me.TextBoxID_ESTADO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MunicipioFrm"
        Me.Text = "DIRECTORIO DE MUNICIPIOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxID_ESTADO As TextBox
    Friend WithEvents ComboBoxESTADO As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnElim As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnIns As Button
    Friend WithEvents ComboBoxMUNICIPIO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxPais As ComboBox
End Class

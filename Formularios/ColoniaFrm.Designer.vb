<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColoniaFrm
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
        Me.Tex_Nom_Col = New System.Windows.Forms.TextBox()
        Me.cbox_municipio = New System.Windows.Forms.ComboBox()
        Me.dgvColonias = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tex_CP = New System.Windows.Forms.TextBox()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_Pais = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbox_Estado = New System.Windows.Forms.ComboBox()
        CType(Me.dgvColonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE:"
        '
        'Tex_Nom_Col
        '
        Me.Tex_Nom_Col.Location = New System.Drawing.Point(111, 92)
        Me.Tex_Nom_Col.Name = "Tex_Nom_Col"
        Me.Tex_Nom_Col.Size = New System.Drawing.Size(457, 27)
        Me.Tex_Nom_Col.TabIndex = 1
        '
        'cbox_municipio
        '
        Me.cbox_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_municipio.FormattingEnabled = True
        Me.cbox_municipio.Location = New System.Drawing.Point(122, 58)
        Me.cbox_municipio.Name = "cbox_municipio"
        Me.cbox_municipio.Size = New System.Drawing.Size(211, 28)
        Me.cbox_municipio.TabIndex = 2
        '
        'dgvColonias
        '
        Me.dgvColonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColonias.Location = New System.Drawing.Point(27, 125)
        Me.dgvColonias.Name = "dgvColonias"
        Me.dgvColonias.ReadOnly = True
        Me.dgvColonias.RowHeadersWidth = 51
        Me.dgvColonias.RowTemplate.Height = 29
        Me.dgvColonias.Size = New System.Drawing.Size(541, 132)
        Me.dgvColonias.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "COD. POS.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MUNICIPIO:"
        '
        'Tex_CP
        '
        Me.Tex_CP.Location = New System.Drawing.Point(431, 58)
        Me.Tex_CP.Name = "Tex_CP"
        Me.Tex_CP.Size = New System.Drawing.Size(137, 27)
        Me.Tex_CP.TabIndex = 6
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(260, 265)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(94, 29)
        Me.btnIns.TabIndex = 7
        Me.btnIns.Text = "Insertar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(360, 265)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(94, 29)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(460, 265)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(94, 29)
        Me.btnElim.TabIndex = 9
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(60, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 27)
        Me.TextBox1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PAÍS:"
        '
        'cbox_Pais
        '
        Me.cbox_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Pais.FormattingEnabled = True
        Me.cbox_Pais.Location = New System.Drawing.Point(169, 24)
        Me.cbox_Pais.Name = "cbox_Pais"
        Me.cbox_Pais.Size = New System.Drawing.Size(164, 28)
        Me.cbox_Pais.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ESTADO:"
        '
        'cbox_Estado
        '
        Me.cbox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Estado.FormattingEnabled = True
        Me.cbox_Estado.Location = New System.Drawing.Point(412, 21)
        Me.cbox_Estado.Name = "cbox_Estado"
        Me.cbox_Estado.Size = New System.Drawing.Size(156, 28)
        Me.cbox_Estado.TabIndex = 14
        '
        'ColoniaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 304)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbox_Estado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_Pais)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.Tex_CP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvColonias)
        Me.Controls.Add(Me.cbox_municipio)
        Me.Controls.Add(Me.Tex_Nom_Col)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ColoniaFrm"
        Me.Text = "DIRECTORIO DE COLONIAS"
        CType(Me.dgvColonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Tex_Nom_Col As TextBox
    Friend WithEvents cbox_municipio As ComboBox
    Friend WithEvents dgvColonias As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tex_CP As TextBox
    Friend WithEvents btnIns As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnElim As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbox_Pais As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbox_Estado As ComboBox
End Class

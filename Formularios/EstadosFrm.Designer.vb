<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadosFrm
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
        Me.cbox_Pais = New System.Windows.Forms.ComboBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.dgvEstados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        CType(Me.dgvEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAIS:"
        '
        'cbox_Pais
        '
        Me.cbox_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Pais.FormattingEnabled = True
        Me.cbox_Pais.Location = New System.Drawing.Point(69, 16)
        Me.cbox_Pais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbox_Pais.Name = "cbox_Pais"
        Me.cbox_Pais.Size = New System.Drawing.Size(163, 28)
        Me.cbox_Pais.TabIndex = 1
        '
        'txt_Id
        '
        Me.txt_Id.Enabled = False
        Me.txt_Id.Location = New System.Drawing.Point(69, 72)
        Me.txt_Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(97, 27)
        Me.txt_Id.TabIndex = 2
        '
        'dgvEstados
        '
        Me.dgvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstados.Location = New System.Drawing.Point(38, 116)
        Me.dgvEstados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEstados.Name = "dgvEstados"
        Me.dgvEstados.ReadOnly = True
        Me.dgvEstados.RowHeadersWidth = 51
        Me.dgvEstados.RowTemplate.Height = 25
        Me.dgvEstados.Size = New System.Drawing.Size(425, 204)
        Me.dgvEstados.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ESTADO:"
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(253, 65)
        Me.txt_Nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(153, 27)
        Me.txt_Nom.TabIndex = 5
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(377, 328)
        Me.btnElim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(86, 31)
        Me.btnElim.TabIndex = 7
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(285, 328)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(86, 31)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(192, 328)
        Me.btnIns.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(86, 31)
        Me.btnIns.TabIndex = 9
        Me.btnIns.Text = "Agregar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'EstadosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(482, 372)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEstados)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.cbox_Pais)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstadosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIRECTORIO DE ESTADOS"
        CType(Me.dgvEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbox_Pais As ComboBox
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents dgvEstados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Nom As TextBox
    Friend WithEvents btnElim As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnIns As Button
End Class

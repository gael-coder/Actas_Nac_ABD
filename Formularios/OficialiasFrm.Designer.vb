<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OficialiasFrm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ofic_id = New System.Windows.Forms.NumericUpDown()
        Me.ofic_contra = New System.Windows.Forms.TextBox()
        Me.dom_cbox = New System.Windows.Forms.ComboBox()
        Me.dgv_Ofic = New System.Windows.Forms.DataGridView()
        Me.elimBtn = New System.Windows.Forms.Button()
        Me.modBtn = New System.Windows.Forms.Button()
        Me.insBtn = New System.Windows.Forms.Button()
        CType(Me.ofic_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Ofic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Oficialia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'ofic_id
        '
        Me.ofic_id.Location = New System.Drawing.Point(83, 19)
        Me.ofic_id.Name = "ofic_id"
        Me.ofic_id.Size = New System.Drawing.Size(89, 23)
        Me.ofic_id.TabIndex = 3
        '
        'ofic_contra
        '
        Me.ofic_contra.Location = New System.Drawing.Point(265, 18)
        Me.ofic_contra.Name = "ofic_contra"
        Me.ofic_contra.Size = New System.Drawing.Size(120, 23)
        Me.ofic_contra.TabIndex = 4
        '
        'dom_cbox
        '
        Me.dom_cbox.FormattingEnabled = True
        Me.dom_cbox.Location = New System.Drawing.Point(88, 56)
        Me.dom_cbox.Name = "dom_cbox"
        Me.dom_cbox.Size = New System.Drawing.Size(171, 23)
        Me.dom_cbox.TabIndex = 5
        '
        'dgv_Ofic
        '
        Me.dgv_Ofic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ofic.Location = New System.Drawing.Point(20, 92)
        Me.dgv_Ofic.Name = "dgv_Ofic"
        Me.dgv_Ofic.ReadOnly = True
        Me.dgv_Ofic.RowTemplate.Height = 25
        Me.dgv_Ofic.Size = New System.Drawing.Size(366, 134)
        Me.dgv_Ofic.TabIndex = 6
        '
        'elimBtn
        '
        Me.elimBtn.Location = New System.Drawing.Point(310, 232)
        Me.elimBtn.Name = "elimBtn"
        Me.elimBtn.Size = New System.Drawing.Size(75, 23)
        Me.elimBtn.TabIndex = 7
        Me.elimBtn.Text = "Eliminar"
        Me.elimBtn.UseVisualStyleBackColor = True
        '
        'modBtn
        '
        Me.modBtn.Location = New System.Drawing.Point(220, 232)
        Me.modBtn.Name = "modBtn"
        Me.modBtn.Size = New System.Drawing.Size(75, 23)
        Me.modBtn.TabIndex = 8
        Me.modBtn.Text = "Modificar"
        Me.modBtn.UseVisualStyleBackColor = True
        '
        'insBtn
        '
        Me.insBtn.Location = New System.Drawing.Point(127, 232)
        Me.insBtn.Name = "insBtn"
        Me.insBtn.Size = New System.Drawing.Size(75, 23)
        Me.insBtn.TabIndex = 9
        Me.insBtn.Text = "Insertar"
        Me.insBtn.UseVisualStyleBackColor = True
        '
        'OficialiasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 265)
        Me.Controls.Add(Me.insBtn)
        Me.Controls.Add(Me.modBtn)
        Me.Controls.Add(Me.elimBtn)
        Me.Controls.Add(Me.dgv_Ofic)
        Me.Controls.Add(Me.dom_cbox)
        Me.Controls.Add(Me.ofic_contra)
        Me.Controls.Add(Me.ofic_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OficialiasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIRECTORIO DE OFICIALIAS"
        CType(Me.ofic_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Ofic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ofic_id As NumericUpDown
    Friend WithEvents ofic_contra As TextBox
    Friend WithEvents dom_cbox As ComboBox
    Friend WithEvents dgv_Ofic As DataGridView
    Friend WithEvents elimBtn As Button
    Friend WithEvents modBtn As Button
    Friend WithEvents insBtn As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentescoFrm
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
        Me.parentCbox = New System.Windows.Forms.ComboBox()
        Me.dgvParent = New System.Windows.Forms.DataGridView()
        Me.elimBtn = New System.Windows.Forms.Button()
        Me.modBtn = New System.Windows.Forms.Button()
        Me.insBtn = New System.Windows.Forms.Button()
        Me.txtId_paren = New System.Windows.Forms.TextBox()
        Me.resetBtn = New System.Windows.Forms.Button()
        CType(Me.dgvParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'parentCbox
        '
        Me.parentCbox.FormattingEnabled = True
        Me.parentCbox.Location = New System.Drawing.Point(255, 27)
        Me.parentCbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.parentCbox.Name = "parentCbox"
        Me.parentCbox.Size = New System.Drawing.Size(147, 28)
        Me.parentCbox.TabIndex = 3
        '
        'dgvParent
        '
        Me.dgvParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParent.Location = New System.Drawing.Point(33, 104)
        Me.dgvParent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvParent.Name = "dgvParent"
        Me.dgvParent.ReadOnly = True
        Me.dgvParent.RowHeadersWidth = 51
        Me.dgvParent.RowTemplate.Height = 25
        Me.dgvParent.Size = New System.Drawing.Size(387, 197)
        Me.dgvParent.TabIndex = 4
        '
        'elimBtn
        '
        Me.elimBtn.Location = New System.Drawing.Point(335, 321)
        Me.elimBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.elimBtn.Name = "elimBtn"
        Me.elimBtn.Size = New System.Drawing.Size(86, 31)
        Me.elimBtn.TabIndex = 5
        Me.elimBtn.Text = "Eliminar"
        Me.elimBtn.UseVisualStyleBackColor = True
        '
        'modBtn
        '
        Me.modBtn.Location = New System.Drawing.Point(242, 321)
        Me.modBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.modBtn.Name = "modBtn"
        Me.modBtn.Size = New System.Drawing.Size(86, 31)
        Me.modBtn.TabIndex = 6
        Me.modBtn.Text = "Modificar"
        Me.modBtn.UseVisualStyleBackColor = True
        '
        'insBtn
        '
        Me.insBtn.Location = New System.Drawing.Point(150, 321)
        Me.insBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.insBtn.Name = "insBtn"
        Me.insBtn.Size = New System.Drawing.Size(86, 31)
        Me.insBtn.TabIndex = 7
        Me.insBtn.Text = "Insertar"
        Me.insBtn.UseVisualStyleBackColor = True
        '
        'txtId_paren
        '
        Me.txtId_paren.Enabled = False
        Me.txtId_paren.Location = New System.Drawing.Point(63, 29)
        Me.txtId_paren.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId_paren.Name = "txtId_paren"
        Me.txtId_paren.Size = New System.Drawing.Size(107, 27)
        Me.txtId_paren.TabIndex = 8
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.IndianRed
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.resetBtn.Location = New System.Drawing.Point(33, 321)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(26, 31)
        Me.resetBtn.TabIndex = 9
        Me.resetBtn.Text = "X"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'ParentescoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 368)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.txtId_paren)
        Me.Controls.Add(Me.insBtn)
        Me.Controls.Add(Me.modBtn)
        Me.Controls.Add(Me.elimBtn)
        Me.Controls.Add(Me.dgvParent)
        Me.Controls.Add(Me.parentCbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ParentescoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParentescoFrm"
        CType(Me.dgvParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents parentCbox As ComboBox
    Friend WithEvents dgvParent As DataGridView
    Friend WithEvents elimBtn As Button
    Friend WithEvents modBtn As Button
    Friend WithEvents insBtn As Button
    Friend WithEvents txtId_paren As TextBox
    Friend WithEvents resetBtn As Button
End Class

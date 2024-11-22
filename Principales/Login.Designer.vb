<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtOfic = New System.Windows.Forms.TextBox()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NO. OFICIALIA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CONTRASEÑA:"
        '
        'txtOfic
        '
        Me.txtOfic.Location = New System.Drawing.Point(133, 28)
        Me.txtOfic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOfic.Name = "txtOfic"
        Me.txtOfic.Size = New System.Drawing.Size(171, 27)
        Me.txtOfic.TabIndex = 2
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(133, 87)
        Me.txtCont.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCont.Size = New System.Drawing.Size(171, 27)
        Me.txtCont.TabIndex = 3
        '
        'btnIng
        '
        Me.btnIng.Location = New System.Drawing.Point(185, 139)
        Me.btnIng.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(86, 31)
        Me.btnIng.TabIndex = 4
        Me.btnIng.Text = "Ingresar"
        Me.btnIng.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.IndianRed
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnX.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnX.Location = New System.Drawing.Point(278, 139)
        Me.btnX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(26, 31)
        Me.btnX.TabIndex = 5
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 208)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnIng)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtOfic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOfic As TextBox
    Friend WithEvents txtCont As TextBox
    Friend WithEvents btnIng As Button
    Friend WithEvents btnX As Button
End Class

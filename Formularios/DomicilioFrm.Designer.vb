<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DomicilioFrm
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
        Me.cbox_Col = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.dgvDomicilio = New System.Windows.Forms.DataGridView()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbox_Pais = New System.Windows.Forms.ComboBox()
        Me.cbox_estado = New System.Windows.Forms.ComboBox()
        Me.cbox_municipio = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_Col
        '
        Me.cbox_Col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Col.FormattingEnabled = True
        Me.cbox_Col.Location = New System.Drawing.Point(428, 64)
        Me.cbox_Col.Name = "cbox_Col"
        Me.cbox_Col.Size = New System.Drawing.Size(213, 28)
        Me.cbox_Col.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COLONIA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CALLE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(493, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NUM. INT.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NUM. EXT.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID DOM.:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(73, 17)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(50, 27)
        Me.txtId.TabIndex = 6
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(63, 110)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(279, 27)
        Me.txtCalle.TabIndex = 7
        '
        'txtInt
        '
        Me.txtInt.Location = New System.Drawing.Point(578, 110)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(63, 27)
        Me.txtInt.TabIndex = 8
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(428, 110)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(63, 27)
        Me.txtExt.TabIndex = 9
        '
        'dgvDomicilio
        '
        Me.dgvDomicilio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDomicilio.Location = New System.Drawing.Point(13, 152)
        Me.dgvDomicilio.Name = "dgvDomicilio"
        Me.dgvDomicilio.ReadOnly = True
        Me.dgvDomicilio.RowHeadersWidth = 51
        Me.dgvDomicilio.RowTemplate.Height = 25
        Me.dgvDomicilio.Size = New System.Drawing.Size(628, 155)
        Me.dgvDomicilio.TabIndex = 10
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(400, 324)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(73, 20)
        Me.btnIns.TabIndex = 11
        Me.btnIns.Text = "Agregar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(479, 323)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(84, 21)
        Me.btnMod.TabIndex = 12
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(569, 323)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(72, 21)
        Me.btnElim.TabIndex = 13
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.IndianRed
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Location = New System.Drawing.Point(51, 313)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(25, 31)
        Me.btnX.TabIndex = 14
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PAÍS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ESTADO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "MUNICIPIO:"
        '
        'cbox_Pais
        '
        Me.cbox_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Pais.FormattingEnabled = True
        Me.cbox_Pais.Location = New System.Drawing.Point(188, 17)
        Me.cbox_Pais.Name = "cbox_Pais"
        Me.cbox_Pais.Size = New System.Drawing.Size(178, 28)
        Me.cbox_Pais.TabIndex = 18
        '
        'cbox_estado
        '
        Me.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estado.FormattingEnabled = True
        Me.cbox_estado.Location = New System.Drawing.Point(463, 17)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(178, 28)
        Me.cbox_estado.TabIndex = 19
        '
        'cbox_municipio
        '
        Me.cbox_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_municipio.FormattingEnabled = True
        Me.cbox_municipio.Location = New System.Drawing.Point(104, 64)
        Me.cbox_municipio.Name = "cbox_municipio"
        Me.cbox_municipio.Size = New System.Drawing.Size(213, 28)
        Me.cbox_municipio.TabIndex = 20
        '
        'DomicilioFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(660, 373)
        Me.Controls.Add(Me.cbox_municipio)
        Me.Controls.Add(Me.cbox_estado)
        Me.Controls.Add(Me.cbox_Pais)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.dgvDomicilio)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox_Col)
        Me.Name = "DomicilioFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIRECTORIO DE DOMICILIOS"
        CType(Me.dgvDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_Col As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtInt As TextBox
    Friend WithEvents txtExt As TextBox
    Friend WithEvents dgvDomicilio As DataGridView
    Friend WithEvents btnIns As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnElim As Button
    Friend WithEvents btnX As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbox_Pais As ComboBox
    Friend WithEvents cbox_estado As ComboBox
    Friend WithEvents cbox_municipio As ComboBox
End Class

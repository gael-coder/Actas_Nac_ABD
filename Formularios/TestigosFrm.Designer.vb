<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestigosFrm
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
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.cbox_parent = New System.Windows.Forms.ComboBox()
        Me.link_regis = New System.Windows.Forms.LinkLabel()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_edad = New System.Windows.Forms.NumericUpDown()
        Me.txt_mat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbox_sexo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbox_pais = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.num_id_dom = New System.Windows.Forms.NumericUpDown()
        Me.link_dom = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cod_pos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ext = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_int = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_col = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvTest = New System.Windows.Forms.DataGridView()
        Me.num_id_reg = New System.Windows.Forms.NumericUpDown()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.num_edad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.num_id_dom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_id_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(155, 28)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(57, 27)
        Me.txt_id.TabIndex = 1
        '
        'cbox_parent
        '
        Me.cbox_parent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_parent.FormattingEnabled = True
        Me.cbox_parent.Location = New System.Drawing.Point(564, 28)
        Me.cbox_parent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbox_parent.Name = "cbox_parent"
        Me.cbox_parent.Size = New System.Drawing.Size(148, 28)
        Me.cbox_parent.TabIndex = 3
        '
        'link_regis
        '
        Me.link_regis.AutoSize = True
        Me.link_regis.Location = New System.Drawing.Point(261, 32)
        Me.link_regis.Name = "link_regis"
        Me.link_regis.Size = New System.Drawing.Size(119, 20)
        Me.link_regis.TabIndex = 4
        Me.link_regis.TabStop = True
        Me.link_regis.Text = "ID REGISTRADO:"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(80, 15)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(244, 27)
        Me.txt_nom.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NOMBRE:"
        '
        'txt_pat
        '
        Me.txt_pat.Location = New System.Drawing.Point(407, 15)
        Me.txt_pat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_pat.Name = "txt_pat"
        Me.txt_pat.Size = New System.Drawing.Size(141, 27)
        Me.txt_pat.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PATERNO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(560, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "MATERNO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(641, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "EDAD:"
        '
        'num_edad
        '
        Me.num_edad.Location = New System.Drawing.Point(699, 63)
        Me.num_edad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_edad.Name = "num_edad"
        Me.num_edad.Size = New System.Drawing.Size(83, 27)
        Me.num_edad.TabIndex = 14
        '
        'txt_mat
        '
        Me.txt_mat.Location = New System.Drawing.Point(641, 12)
        Me.txt_mat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mat.Name = "txt_mat"
        Me.txt_mat.Size = New System.Drawing.Size(141, 27)
        Me.txt_mat.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SEXO:"
        '
        'cbox_sexo
        '
        Me.cbox_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_sexo.FormattingEnabled = True
        Me.cbox_sexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cbox_sexo.Location = New System.Drawing.Point(77, 63)
        Me.cbox_sexo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbox_sexo.Name = "cbox_sexo"
        Me.cbox_sexo.Size = New System.Drawing.Size(141, 28)
        Me.cbox_sexo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(228, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "PAÍS:"
        '
        'cbox_pais
        '
        Me.cbox_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_pais.FormattingEnabled = True
        Me.cbox_pais.Location = New System.Drawing.Point(272, 63)
        Me.cbox_pais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbox_pais.Name = "cbox_pais"
        Me.cbox_pais.Size = New System.Drawing.Size(141, 28)
        Me.cbox_pais.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.num_id_dom)
        Me.Panel1.Controls.Add(Me.link_dom)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbox_pais)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbox_sexo)
        Me.Panel1.Controls.Add(Me.txt_mat)
        Me.Panel1.Controls.Add(Me.num_edad)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_pat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_nom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(17, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 112)
        Me.Panel1.TabIndex = 20
        '
        'num_id_dom
        '
        Me.num_id_dom.Location = New System.Drawing.Point(547, 64)
        Me.num_id_dom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_id_dom.Name = "num_id_dom"
        Me.num_id_dom.Size = New System.Drawing.Size(78, 27)
        Me.num_id_dom.TabIndex = 23
        '
        'link_dom
        '
        Me.link_dom.AutoSize = True
        Me.link_dom.Location = New System.Drawing.Point(436, 68)
        Me.link_dom.Name = "link_dom"
        Me.link_dom.Size = New System.Drawing.Size(105, 20)
        Me.link_dom.TabIndex = 22
        Me.link_dom.TabStop = True
        Me.link_dom.Text = "ID DOMICILIO:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_cod_pos)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txt_ext)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_int)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_calle)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_col)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(17, 195)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 117)
        Me.Panel2.TabIndex = 21
        '
        'txt_cod_pos
        '
        Me.txt_cod_pos.Enabled = False
        Me.txt_cod_pos.Location = New System.Drawing.Point(665, 16)
        Me.txt_cod_pos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cod_pos.Name = "txt_cod_pos"
        Me.txt_cod_pos.Size = New System.Drawing.Size(117, 27)
        Me.txt_cod_pos.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(591, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "COD. POS.:"
        '
        'txt_ext
        '
        Me.txt_ext.Enabled = False
        Me.txt_ext.Location = New System.Drawing.Point(436, 61)
        Me.txt_ext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ext.Name = "txt_ext"
        Me.txt_ext.Size = New System.Drawing.Size(116, 27)
        Me.txt_ext.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(371, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "NO. EXT.:"
        '
        'txt_int
        '
        Me.txt_int.Enabled = False
        Me.txt_int.Location = New System.Drawing.Point(241, 61)
        Me.txt_int.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_int.Name = "txt_int"
        Me.txt_int.Size = New System.Drawing.Size(116, 27)
        Me.txt_int.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(172, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 20)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "NO. INT.:"
        '
        'txt_calle
        '
        Me.txt_calle.Enabled = False
        Me.txt_calle.Location = New System.Drawing.Point(320, 16)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(265, 27)
        Me.txt_calle.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(263, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "CALLE:"
        '
        'txt_col
        '
        Me.txt_col.Enabled = False
        Me.txt_col.Location = New System.Drawing.Point(80, 16)
        Me.txt_col.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_col.Name = "txt_col"
        Me.txt_col.Size = New System.Drawing.Size(175, 27)
        Me.txt_col.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "COLONIA:"
        '
        'dgvTest
        '
        Me.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTest.Location = New System.Drawing.Point(17, 320)
        Me.dgvTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTest.Name = "dgvTest"
        Me.dgvTest.ReadOnly = True
        Me.dgvTest.RowHeadersWidth = 51
        Me.dgvTest.RowTemplate.Height = 25
        Me.dgvTest.Size = New System.Drawing.Size(795, 165)
        Me.dgvTest.TabIndex = 22
        '
        'num_id_reg
        '
        Me.num_id_reg.Location = New System.Drawing.Point(373, 29)
        Me.num_id_reg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_id_reg.Name = "num_id_reg"
        Me.num_id_reg.Size = New System.Drawing.Size(79, 27)
        Me.num_id_reg.TabIndex = 23
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(528, 493)
        Me.btnIns.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(86, 31)
        Me.btnIns.TabIndex = 24
        Me.btnIns.Text = "Insertar"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(621, 493)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(86, 31)
        Me.btnMod.TabIndex = 25
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(713, 493)
        Me.btnElim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(86, 31)
        Me.btnElim.TabIndex = 26
        Me.btnElim.Text = "Eliminar"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(460, 31)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(98, 20)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "PARENTESCO"
        '
        'TestigosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 527)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.num_id_reg)
        Me.Controls.Add(Me.dgvTest)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.link_regis)
        Me.Controls.Add(Me.cbox_parent)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TestigosFrm"
        Me.Text = "DIRECTORIO DE TESTIGOS"
        CType(Me.num_edad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_id_dom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_id_reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents cbox_parent As ComboBox
    Friend WithEvents link_regis As LinkLabel
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents num_edad As NumericUpDown
    Friend WithEvents txt_mat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbox_sexo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbox_pais As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cod_pos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ext As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_int As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_col As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents link_dom As LinkLabel
    Friend WithEvents dgvTest As DataGridView
    Friend WithEvents num_id_dom As NumericUpDown
    Friend WithEvents num_id_reg As NumericUpDown
    Friend WithEvents btnIns As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnElim As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

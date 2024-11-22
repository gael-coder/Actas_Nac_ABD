<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistradoFrm
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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ComboBoxSEXO = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.TextBoxape_paterno = New System.Windows.Forms.TextBox()
        Me.TextBoxape_materno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCOMPARECIDO = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPRESENTADO = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonDELETE = New System.Windows.Forms.Button()
        Me.ButtonINSERT = New System.Windows.Forms.Button()
        Me.ButtonACTUALIZAR = New System.Windows.Forms.Button()
        Me.ComboBoxFOLIO = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(54, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(72, 27)
        Me.txtId.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PRESENTADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FECHA NAC.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PATERNO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NOMBRE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "COMPARECIDO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "SEXO:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(139, 31)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 20)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "FOLIO:"
        '
        'ComboBoxSEXO
        '
        Me.ComboBoxSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSEXO.FormattingEnabled = True
        Me.ComboBoxSEXO.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.ComboBoxSEXO.Location = New System.Drawing.Point(368, 27)
        Me.ComboBoxSEXO.Name = "ComboBoxSEXO"
        Me.ComboBoxSEXO.Size = New System.Drawing.Size(119, 28)
        Me.ComboBoxSEXO.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 133)
        Me.DateTimePicker1.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(364, 27)
        Me.DateTimePicker1.TabIndex = 13
        Me.DateTimePicker1.Value = New Date(2022, 11, 10, 0, 0, 0, 0)
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(100, 64)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(387, 27)
        Me.TextBoxnombre.TabIndex = 15
        '
        'TextBoxape_paterno
        '
        Me.TextBoxape_paterno.Location = New System.Drawing.Point(100, 97)
        Me.TextBoxape_paterno.Name = "TextBoxape_paterno"
        Me.TextBoxape_paterno.Size = New System.Drawing.Size(148, 27)
        Me.TextBoxape_paterno.TabIndex = 16
        '
        'TextBoxape_materno
        '
        Me.TextBoxape_materno.Location = New System.Drawing.Point(339, 100)
        Me.TextBoxape_materno.Name = "TextBoxape_materno"
        Me.TextBoxape_materno.Size = New System.Drawing.Size(148, 27)
        Me.TextBoxape_materno.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "MATERNO:"
        '
        'ComboBoxCOMPARECIDO
        '
        Me.ComboBoxCOMPARECIDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCOMPARECIDO.FormattingEnabled = True
        Me.ComboBoxCOMPARECIDO.Items.AddRange(New Object() {"AMBOS", "PADRE", "MADRE", "ABUELO/A/OS", "REGISTRADO", "OTRO"})
        Me.ComboBoxCOMPARECIDO.Location = New System.Drawing.Point(368, 179)
        Me.ComboBoxCOMPARECIDO.Name = "ComboBoxCOMPARECIDO"
        Me.ComboBoxCOMPARECIDO.Size = New System.Drawing.Size(119, 28)
        Me.ComboBoxCOMPARECIDO.TabIndex = 19
        '
        'ComboBoxPRESENTADO
        '
        Me.ComboBoxPRESENTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPRESENTADO.FormattingEnabled = True
        Me.ComboBoxPRESENTADO.Items.AddRange(New Object() {"VIVO", "FINADO"})
        Me.ComboBoxPRESENTADO.Location = New System.Drawing.Point(123, 179)
        Me.ComboBoxPRESENTADO.Name = "ComboBoxPRESENTADO"
        Me.ComboBoxPRESENTADO.Size = New System.Drawing.Size(118, 28)
        Me.ComboBoxPRESENTADO.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(464, 165)
        Me.DataGridView1.TabIndex = 21
        '
        'ButtonDELETE
        '
        Me.ButtonDELETE.Location = New System.Drawing.Point(393, 398)
        Me.ButtonDELETE.Name = "ButtonDELETE"
        Me.ButtonDELETE.Size = New System.Drawing.Size(94, 29)
        Me.ButtonDELETE.TabIndex = 22
        Me.ButtonDELETE.Text = "Eliminar"
        Me.ButtonDELETE.UseVisualStyleBackColor = True
        '
        'ButtonINSERT
        '
        Me.ButtonINSERT.Location = New System.Drawing.Point(193, 398)
        Me.ButtonINSERT.Name = "ButtonINSERT"
        Me.ButtonINSERT.Size = New System.Drawing.Size(94, 29)
        Me.ButtonINSERT.TabIndex = 23
        Me.ButtonINSERT.Text = "Insertar"
        Me.ButtonINSERT.UseVisualStyleBackColor = True
        '
        'ButtonACTUALIZAR
        '
        Me.ButtonACTUALIZAR.Location = New System.Drawing.Point(293, 398)
        Me.ButtonACTUALIZAR.Name = "ButtonACTUALIZAR"
        Me.ButtonACTUALIZAR.Size = New System.Drawing.Size(94, 29)
        Me.ButtonACTUALIZAR.TabIndex = 24
        Me.ButtonACTUALIZAR.Text = "Modificar"
        Me.ButtonACTUALIZAR.UseVisualStyleBackColor = True
        '
        'ComboBoxFOLIO
        '
        Me.ComboBoxFOLIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFOLIO.FormattingEnabled = True
        Me.ComboBoxFOLIO.Location = New System.Drawing.Point(188, 27)
        Me.ComboBoxFOLIO.Name = "ComboBoxFOLIO"
        Me.ComboBoxFOLIO.Size = New System.Drawing.Size(120, 28)
        Me.ComboBoxFOLIO.TabIndex = 25
        '
        'RegistradoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 439)
        Me.Controls.Add(Me.ComboBoxFOLIO)
        Me.Controls.Add(Me.ButtonACTUALIZAR)
        Me.Controls.Add(Me.ButtonINSERT)
        Me.Controls.Add(Me.ButtonDELETE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxPRESENTADO)
        Me.Controls.Add(Me.ComboBoxCOMPARECIDO)
        Me.Controls.Add(Me.TextBoxape_materno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxape_paterno)
        Me.Controls.Add(Me.TextBoxnombre)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxSEXO)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistradoFrm"
        Me.Text = "RegistradoFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboBoxSEXO As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents TextBoxape_paterno As TextBox
    Friend WithEvents TextBoxape_materno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCOMPARECIDO As ComboBox
    Friend WithEvents ComboBoxPRESENTADO As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonDELETE As Button
    Friend WithEvents ButtonINSERT As Button
    Friend WithEvents ButtonACTUALIZAR As Button
    Friend WithEvents ComboBoxFOLIO As ComboBox
End Class

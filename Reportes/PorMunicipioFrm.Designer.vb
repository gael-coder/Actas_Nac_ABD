<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PorMunicipioFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_Pais = New System.Windows.Forms.ComboBox()
        Me.cbox_estado = New System.Windows.Forms.ComboBox()
        Me.cbox_municipio = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAÍS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ESTADO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(485, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MUNICIPIO:"
        '
        'cbox_Pais
        '
        Me.cbox_Pais.FormattingEnabled = True
        Me.cbox_Pais.Location = New System.Drawing.Point(70, 33)
        Me.cbox_Pais.Name = "cbox_Pais"
        Me.cbox_Pais.Size = New System.Drawing.Size(151, 28)
        Me.cbox_Pais.TabIndex = 3
        '
        'cbox_estado
        '
        Me.cbox_estado.FormattingEnabled = True
        Me.cbox_estado.Location = New System.Drawing.Point(309, 33)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(151, 28)
        Me.cbox_estado.TabIndex = 4
        '
        'cbox_municipio
        '
        Me.cbox_municipio.FormattingEnabled = True
        Me.cbox_municipio.Location = New System.Drawing.Point(577, 33)
        Me.cbox_municipio.Name = "cbox_municipio"
        Me.cbox_municipio.Size = New System.Drawing.Size(151, 28)
        Me.cbox_municipio.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(705, 200)
        Me.DataGridView1.TabIndex = 6
        '
        'PorMunicipioFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 334)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbox_municipio)
        Me.Controls.Add(Me.cbox_estado)
        Me.Controls.Add(Me.cbox_Pais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PorMunicipioFrm"
        Me.Text = "Reporte por Municipio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbox_Pais As ComboBox
    Friend WithEvents cbox_estado As ComboBox
    Friend WithEvents cbox_municipio As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaisesFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.dgvPaises = New System.Windows.Forms.DataGridView()
        Me.ConexionSQLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtId_Pais = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConexionSQLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE:"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(208, 39)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(178, 27)
        Me.txtPais.TabIndex = 2
        '
        'dgvPaises
        '
        Me.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaises.Location = New System.Drawing.Point(13, 77)
        Me.dgvPaises.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPaises.Name = "dgvPaises"
        Me.dgvPaises.ReadOnly = True
        Me.dgvPaises.RowHeadersWidth = 51
        Me.dgvPaises.RowTemplate.Height = 25
        Me.dgvPaises.Size = New System.Drawing.Size(374, 135)
        Me.dgvPaises.TabIndex = 3
        '
        'ConexionSQLBindingSource
        '
        Me.ConexionSQLBindingSource.DataSource = GetType(Actas_Nac_Rocio.ConexionSQL)
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(301, 220)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 31)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(208, 220)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 31)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(115, 220)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 31)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtId_Pais
        '
        Me.txtId_Pais.Enabled = False
        Me.txtId_Pais.Location = New System.Drawing.Point(74, 39)
        Me.txtId_Pais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId_Pais.Name = "txtId_Pais"
        Me.txtId_Pais.Size = New System.Drawing.Size(52, 27)
        Me.txtId_Pais.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID PAIS:"
        '
        'PaisesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId_Pais)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvPaises)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PaisesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIRECTORIO DE PAISES"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConexionSQLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtPais As TextBox
    Friend WithEvents dgvPaises As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ConexionSQLBindingSource As BindingSource
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtId_Pais As TextBox
    Friend WithEvents Label1 As Label
End Class

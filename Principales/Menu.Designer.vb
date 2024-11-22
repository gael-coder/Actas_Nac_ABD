<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ofic_num = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.direc_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DomiciliosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.per_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentescosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeActasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OficialiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.regNuevo_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.LemonChiffon
        Me.MonthCalendar1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MonthCalendar1.Location = New System.Drawing.Point(17, 59)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(10, 12, 10, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Goldenrod
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(264, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido."
        '
        'Ofic_num
        '
        Me.Ofic_num.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ofic_num.AutoSize = True
        Me.Ofic_num.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ofic_num.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Ofic_num.Location = New System.Drawing.Point(290, 183)
        Me.Ofic_num.Name = "Ofic_num"
        Me.Ofic_num.Size = New System.Drawing.Size(68, 20)
        Me.Ofic_num.TabIndex = 3
        Me.Ofic_num.Text = "OficNum"
        Me.Ofic_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LemonChiffon
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.direc_strip, Me.per_strip, Me.regNuevo_strip, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 33)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'direc_strip
        '
        Me.direc_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaisesToolStripMenuItem, Me.EstadoToolStripMenuItem, Me.MunicipioToolStripMenuItem, Me.ColoniaToolStripMenuItem, Me.DomiciliosToolStripMenuItem})
        Me.direc_strip.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.direc_strip.Name = "direc_strip"
        Me.direc_strip.Size = New System.Drawing.Size(111, 27)
        Me.direc_strip.Text = "Direcciones"
        '
        'PaisesToolStripMenuItem
        '
        Me.PaisesToolStripMenuItem.Name = "PaisesToolStripMenuItem"
        Me.PaisesToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.PaisesToolStripMenuItem.Text = "Paises"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.EstadoToolStripMenuItem.Text = "Estado"
        '
        'MunicipioToolStripMenuItem
        '
        Me.MunicipioToolStripMenuItem.Name = "MunicipioToolStripMenuItem"
        Me.MunicipioToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.MunicipioToolStripMenuItem.Text = "Municipio"
        '
        'ColoniaToolStripMenuItem
        '
        Me.ColoniaToolStripMenuItem.Name = "ColoniaToolStripMenuItem"
        Me.ColoniaToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.ColoniaToolStripMenuItem.Text = "Colonia"
        '
        'DomiciliosToolStripMenuItem
        '
        Me.DomiciliosToolStripMenuItem.Name = "DomiciliosToolStripMenuItem"
        Me.DomiciliosToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.DomiciliosToolStripMenuItem.Text = "Domicilios"
        '
        'per_strip
        '
        Me.per_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistradosToolStripMenuItem, Me.TestigosToolStripMenuItem, Me.ParentescosToolStripMenuItem, Me.DatosDeActasToolStripMenuItem, Me.OficialiasToolStripMenuItem})
        Me.per_strip.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.per_strip.Name = "per_strip"
        Me.per_strip.Size = New System.Drawing.Size(92, 27)
        Me.per_strip.Text = "Personas"
        '
        'RegistradosToolStripMenuItem
        '
        Me.RegistradosToolStripMenuItem.Name = "RegistradosToolStripMenuItem"
        Me.RegistradosToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.RegistradosToolStripMenuItem.Text = "Registrados"
        '
        'TestigosToolStripMenuItem
        '
        Me.TestigosToolStripMenuItem.Name = "TestigosToolStripMenuItem"
        Me.TestigosToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.TestigosToolStripMenuItem.Text = "Testigos"
        '
        'ParentescosToolStripMenuItem
        '
        Me.ParentescosToolStripMenuItem.Name = "ParentescosToolStripMenuItem"
        Me.ParentescosToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.ParentescosToolStripMenuItem.Text = "Parentescos"
        '
        'DatosDeActasToolStripMenuItem
        '
        Me.DatosDeActasToolStripMenuItem.Name = "DatosDeActasToolStripMenuItem"
        Me.DatosDeActasToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.DatosDeActasToolStripMenuItem.Text = "Datos de actas"
        '
        'OficialiasToolStripMenuItem
        '
        Me.OficialiasToolStripMenuItem.Name = "OficialiasToolStripMenuItem"
        Me.OficialiasToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.OficialiasToolStripMenuItem.Text = "Oficialias"
        '
        'regNuevo_strip
        '
        Me.regNuevo_strip.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.regNuevo_strip.Name = "regNuevo_strip"
        Me.regNuevo_strip.Size = New System.Drawing.Size(141, 27)
        Me.regNuevo_strip.Text = "Registro Nuevo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(14, 27)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray
        Me.LinkLabel1.Location = New System.Drawing.Point(365, 273)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 23)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Reportes"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(454, 305)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Ofic_num)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Ofic_num As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents direc_strip As ToolStripMenuItem
    Friend WithEvents PaisesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MunicipioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColoniaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DomiciliosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents per_strip As ToolStripMenuItem
    Friend WithEvents RegistradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParentescosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeActasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents regNuevo_strip As ToolStripMenuItem
    Friend WithEvents OficialiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

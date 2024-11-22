Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ofic_num.Text = "Ha ingresado como:
Oficialia no." & usuario
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        EstadosFrm.Show()
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        PaisesFrm.Show()
    End Sub

    Private Sub ParentescosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParentescosToolStripMenuItem.Click
        ParentescoFrm.Show()
    End Sub

    Private Sub OficialiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OficialiasToolStripMenuItem.Click
        OficialiasFrm.Show()
    End Sub

    Private Sub DomiciliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomiciliosToolStripMenuItem.Click
        DomicilioFrm.Show()
    End Sub

    Private Sub TestigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestigosToolStripMenuItem.Click
        TestigosFrm.Show()
    End Sub

    Private Sub ColoniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniaToolStripMenuItem.Click
        ColoniaFrm.Show()
    End Sub

    Private Sub DatosDeActasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeActasToolStripMenuItem.Click
        DatosActaFrm.Show()
    End Sub

    Private Sub MunicipioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MunicipioToolStripMenuItem.Click
        MunicipioFrm.Show()
    End Sub

    Private Sub regNuevo_strip_Click(sender As Object, e As EventArgs) Handles regNuevo_strip.Click
        RegistroNvoFrm.Show()
    End Sub

    Private Sub direc_strip_Click(sender As Object, e As EventArgs) Handles direc_strip.Click

    End Sub

    Private Sub RegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistradosToolStripMenuItem.Click
        RegistradoFrm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ReportesFrm.Show()
    End Sub
End Class

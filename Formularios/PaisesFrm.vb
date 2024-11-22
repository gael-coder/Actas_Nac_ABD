Public Class PaisesFrm

    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion

    Private Sub PaisesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load '(checar esto del)
        ' MyBase porque no se si sea el nombre default o si sea el nombre de la base de datos del vato
        ' del video
        ' cnx.Conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        cnx.Consulta("select * from paises", "paises")
        dgvPaises.DataSource = cnx.ds.Tables("paises")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        ' checa que no este vacío
        If txtPais.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            ' mete el dato
            Dim agregar As String = "insert into paises values ('" + txtPais.Text + "')"
            If (cnx.Insertar(agregar)) Then
                cnx.conexion.Close()
                MostrarDatos()
            Else
                MessageBox.Show("Error al insertar")
            End If
        End If


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        ' checa que no este vacío
        If txtPais.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            Try
                cnx.Eliminar("paises", "id_pais = " & txtId_Pais.Text)
                MostrarDatos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar")
            End Try

        End If

    End Sub

    Private Sub dgvPaises_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaises.CellContentClick
        Dim renglon As Integer
        renglon = dgvPaises.CurrentCellAddress.Y

        txtId_Pais.Text = dgvPaises.Rows(renglon).Cells(0).Value
        txtPais.Text = dgvPaises.Rows(renglon).Cells(1).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        ' checa que no este vacío
        If txtPais.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            Dim actualizar As String = "nom_pais = '" & txtPais.Text & "'"
            If (cnx.Actualizar("paises", actualizar, "id_pais=" & txtId_Pais.Text)) Then
                MostrarDatos()
            Else
                MessageBox.Show("Error al actualizar")
            End If
        End If

    End Sub

    Private Sub txtPais_TextChanged(sender As Object, e As EventArgs) Handles txtPais.TextChanged

    End Sub
End Class

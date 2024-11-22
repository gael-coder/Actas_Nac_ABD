Imports System.Data.SqlClient

Public Class EstadosFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion

    Private Sub EstadosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarCombobox()
        cnx.conexion.Close()
    End Sub

    Public Sub MostrarDatos(ByVal sql)
        ' metodo que muestra los datos 
        ' param : String
        ' si el parametro es un string vacio, se muestran todos los datos
        ' si el parametro es un string con algo (en este caso, un pais)
        ' se hace el select donde solo se muestren datos que contengan ese 
        ' pais
        Dim query As String
        If sql = "" Then
            query = "SELECT ESTADO.iD_ESTADO, PAISES.NOM_PAIS, ESTADO.NOM_EST
                                FROM PAISES INNER JOIN
                                ESTADO ON PAISES.ID_PAIS = ESTADO.PAISES_ID_PAIS"
            cnx.Consulta(query, "estado")
            dgvEstados.DataSource = cnx.ds.Tables("estado")
        Else
            query = "SELECT ESTADO.iD_ESTADO, PAISES.NOM_PAIS, ESTADO.NOM_EST
                                FROM PAISES INNER JOIN
                                ESTADO ON PAISES.ID_PAIS = ESTADO.PAISES_ID_PAIS
                                WHERE ESTADO.PAISES_ID_PAIS = " & sql
            cnx.Consulta(query, "estado")
            dgvEstados.DataSource = cnx.ds.Tables("estado")
        End If
        cnx.conexion.Close()
    End Sub

    Private Sub dgvEstados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstados.CellContentClick

        Dim renglon As Integer

        renglon = dgvEstados.CurrentCellAddress.Y

        txt_Id.Text = Convert.ToString(dgvEstados.Rows(renglon).Cells(0).Value)
        cbox_Pais.Text = Convert.ToString(dgvEstados.Rows(renglon).Cells(1).Value)
        txt_Nom.Text = Convert.ToString(dgvEstados.Rows(renglon).Cells(2).Value)

    End Sub
    Private Sub llenarCombobox() Handles MyBase.Load
        Dim command As New SqlCommand("Select * from paises", cnx.conexion)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        cbox_Pais.DataSource = table

        cbox_Pais.DisplayMember = "nom_pais"
        cbox_Pais.ValueMember = "id_pais"

        cnx.conexion.Close()


    End Sub

    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        ' metodo para insertar datos
        ' checa que no este vacío
        If txt_Nom.Text = "" Then
            MessageBox.Show("Inserte los datos necesarios.")
        Else
            ' mete el dato
            Dim agregar As String = "insert into estado(nom_est, paises_id_pais) values ('" + txt_Nom.Text + "'," + cbox_Pais.SelectedValue.ToString() + ")"
            cnx.Insertar(agregar)
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ' checa que no este vacío
        If txt_Nom.Text = "" Then
            MessageBox.Show("Escoja sus datos correctamente.")
        Else
            Dim actualizar As String = "nom_est = '" & txt_Nom.Text & "' "
            cnx.Actualizar("estado", actualizar, "id_estado = " & txt_Id.Text)
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        ' checa que no este vacío
        If txt_Nom.Text = "" Then
            MessageBox.Show("Ingrese un nombre de estado.")
        Else
            cnx.Eliminar("estado", "id_estado = " & txt_Id.Text)
        End If
        MostrarDatos("")
    End Sub

    Private Sub cboxDato() Handles cbox_Pais.SelectionChangeCommitted
        'este es el metodo que mostrará el dato que 
        ' se seleccione en el cbox
        MostrarDatos(cbox_Pais.SelectedValue.ToString)
    End Sub
End Class
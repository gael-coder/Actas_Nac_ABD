Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class ColoniaFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Dim sqlStr As String
    Dim sentencia, mensaje As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet

    Private Sub ColoniaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarCombobox()
        cnx.conexion.Close()
    End Sub

    ' Metodo que valida y evita los errores 
    Sub EjecutarSql(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, cnx.conexion)
            cnx.conexion.Open()
            cmd.ExecuteNonQuery()
            cnx.conexion.Close()

        Catch ex As Exception
            MessageBox.Show("NO SÉ PUEDE REALIZAR ESTA ACCIÓN")
        End Try
    End Sub


    Public Sub MostrarDatos(ByVal sql)
        ' Metodo que muestra los datos 
        ' param : String
        ' si el parametro es un string vacio, se muestran todos los datos
        ' si el parametro es un string con algo
        ' se hace el select donde solo se muestren datos que contengan esa colonia
        Dim query As String
        If sql = "" Then
            query = "SELECT COLONIA.iD_COL,  MUNICIPIO.NOM_MUN,  COLONIA.COD_POS,  COLONIA.NOM_COL
                          FROM COLONIA INNER JOIN
                          MUNICIPIO ON  COLONIA.iD_MUN =  MUNICIPIO.iD_MUN"
            cnx.Consulta(query, "COLONIA")
            dgvColonias.DataSource = cnx.ds.Tables("COLONIA")
        Else
            query = "Select COLONIA.iD_COL,  MUNICIPIO.NOM_MUN,  COLONIA.COD_POS,  COLONIA.NOM_COL
                          From COLONIA INNER JOIN
                          MUNICIPIO On COLONIA.iD_MUN =  MUNICIPIO.iD_MUN
                          WHERE MUNICIPIO.iD_MUN = " & sql
            cnx.Consulta(query, "COLONIA")
            dgvColonias.DataSource = cnx.ds.Tables("COLONIA")
        End If
        cnx.conexion.Close()
    End Sub

    ' Metodo que rellena automaticamente los campos vacios de formulario
    Private Sub dgvColonias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvColonias.CellContentClick

        Dim renglon As Integer

        renglon = dgvColonias.CurrentCellAddress.Y

        Tex_Nom_Col.Text = dgvColonias.Rows(renglon).Cells(3).Value
        cbox_municipio.Text = dgvColonias.Rows(renglon).Cells(1).Value
        Tex_CP.Text = dgvColonias.Rows(renglon).Cells(2).Value

    End Sub



    ' Metodo que realiza la eleminacion del registro
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        If Tex_Nom_Col.Text = "" Or Tex_CP.Text = "" Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If

        sentencia = "delete From COLONIA Where NOM_COL ='" + Tex_Nom_Col.Text + "'"
        mensaje = "Datos eliminados"
        EjecutarSql(sentencia, mensaje)
        MostrarDatos("")
    End Sub

    ' Metodo que realiza la modificacion del registro
    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If Tex_Nom_Col.Text = "" Or Tex_CP.Text = "" Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If

        sentencia = "update COLONIA set NOM_COL='" + Tex_Nom_Col.Text + "' where COD_POS='" + Tex_CP.Text + "'"
        mensaje = "Datos actualizados"
        EjecutarSql(sentencia, mensaje)
        MostrarDatos("")
    End Sub

    ' Metodo que realiza la insercion del registro
    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        If Tex_Nom_Col.Text = "" Or Tex_CP.Text = "" Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If
        sentencia = "insert into COLONIA values('" & cbox_municipio.SelectedValue.ToString & "', '" & Tex_Nom_Col.Text & "', '" & Tex_CP.Text & "')"
        mensaje = "Datos insertados"
        EjecutarSql(sentencia, mensaje)
        MostrarDatos("")
    End Sub
    ' *************** inicio de seccion de metodos de comboboxes *******************

    'metodo que se inicia al momento de cargar el forms
    Public Sub llenarCombobox()
        'llena el combobox de pais
        Dim command As New SqlCommand("Select * from paises", cnx.conexion)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        cbox_Pais.DisplayMember = "nom_pais"
        cbox_Pais.ValueMember = "id_pais"

        cbox_Pais.DataSource = table

        cnx.conexion.Close()
    End Sub
    ' metodo que manda a llamar el metodo que cambia el cbox de estados
    ' y se activa cuando se cambia el valor del cbox de pais
    Private Sub cbox_Pais_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbox_Pais.SelectionChangeCommitted
        If cbox_Pais.Text <> "" Then
            Dim id_pais As String = cbox_Pais.SelectedValue.ToString()
            Call llenaEstados(id_pais)
            cbox_Estado.SelectedIndex = 0
        End If
    End Sub
    'metodo que llena el cbox de estados
    Private Sub llenaEstados(id_pais As String)
        Dim com As New SqlCommand("select * from ESTADO WHERE PAISES_ID_PAIS = " & id_pais, cnx.conexion)
        Dim ada As New SqlDataAdapter(com)
        Dim tab As New DataTable()
        ada.Fill(tab)

        cbox_Estado.DisplayMember = "NOM_EST"
        cbox_Estado.ValueMember = "ID_ESTADO"

        cbox_Estado.DataSource = tab

        cnx.conexion.Close()
    End Sub
    ' metodo que manda a llamar el metodo que cambia el cbox de municipios
    ' y se activa cuando se cambia el valor del cbox de estados
    Private Sub cbox_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_Estado.SelectedIndexChanged
        Dim id_est As String = cbox_Estado.SelectedValue.ToString()
        Call llenaMunic(id_est)
    End Sub

    'metodo que llena el cbox de municipios
    Private Sub llenaMunic(id_est As String)
        Dim comm As New SqlCommand("select * from MUNICIPIO WHERE ID_ESTADO = " & id_est, cnx.conexion)
        Dim adap As New SqlDataAdapter(comm)
        Dim tabl As New DataTable()
        adap.Fill(tabl)

        cbox_municipio.DisplayMember = "nom_mun"
        cbox_municipio.ValueMember = "id_mun"

        cbox_municipio.DataSource = tabl

        cnx.conexion.Close()
    End Sub

    Private Sub cboxDato() Handles cbox_municipio.SelectionChangeCommitted
        'este es el metodo que mostrará el dato que 
        ' se seleccione en el combobox
        MostrarDatos(cbox_municipio.SelectedValue.ToString)
    End Sub

End Class
Imports System.Data.SqlClient

Public Class DomicilioFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Private Sub DomicilioFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarCombobox()
        cnx.conexion.Close()
    End Sub
    Public Sub MostrarDatos(ByVal sql)
        ' metodo que muestra los datos 
        ' param : String
        ' si el parametro es un string vacio, se muestran todos los datos
        ' si el parametro es un string con algo (en este caso, una colonia)
        ' se hace el select donde solo se muestren datos que contengan ese 
        ' pais
        Dim query As String
        If sql = "" Then
            query = "SELECT DOMICILIO.iD_DOM,  PAISES.NOM_PAIS,  ESTADO.NOM_EST,  MUNICIPIO.NOM_MUN,  COLONIA.NOM_COL,  DOMICILIO.CALLE,  DOMICILIO.NUM_EXT,  DOMICILIO.NUM_INT
                    FROM      PAISES INNER JOIN
                   ESTADO ON  PAISES.ID_PAIS =  ESTADO.PAISES_ID_PAIS INNER JOIN
                   MUNICIPIO ON  ESTADO.iD_ESTADO =  MUNICIPIO.ID_ESTADO INNER JOIN
                   COLONIA ON  MUNICIPIO.iD_MUN =  COLONIA.iD_MUN INNER JOIN
                   DOMICILIO ON  COLONIA.iD_COL =  DOMICILIO.ID_COL"
            cnx.Consulta(query, "domicilio")
            dgvDomicilio.DataSource = cnx.ds.Tables("domicilio")
        Else
            query = "SELECT DOMICILIO.iD_DOM,  PAISES.NOM_PAIS,  ESTADO.NOM_EST,  MUNICIPIO.NOM_MUN,  COLONIA.NOM_COL,  DOMICILIO.CALLE,  DOMICILIO.NUM_EXT,  DOMICILIO.NUM_INT
                    FROM      PAISES INNER JOIN
                   ESTADO ON  PAISES.ID_PAIS =  ESTADO.PAISES_ID_PAIS INNER JOIN
                   MUNICIPIO ON  ESTADO.iD_ESTADO =  MUNICIPIO.ID_ESTADO INNER JOIN
                   COLONIA ON  MUNICIPIO.iD_MUN =  COLONIA.iD_MUN INNER JOIN
                   DOMICILIO ON  COLONIA.iD_COL =  DOMICILIO.ID_COL
                    WHERE " & sql
            cnx.Consulta(query, "domicilio")
            dgvDomicilio.DataSource = cnx.ds.Tables("domicilio")
        End If
        cnx.conexion.Close()
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
    Private Sub cbox_Pais_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbox_Pais.SelectedIndexChanged
        If cbox_Pais.Text <> "" Then
            Dim id_pais As String = cbox_Pais.SelectedValue.ToString()
            Call llenaEstados(id_pais)
            cbox_estado.SelectedIndex = 0
        End If
    End Sub
    'metodo que llena el cbox de estados
    Private Sub llenaEstados(id_pais As String)
        Dim com As New SqlCommand("select * from ESTADO WHERE PAISES_ID_PAIS = " & id_pais, cnx.conexion)
        Dim ada As New SqlDataAdapter(com)
        Dim tab As New DataTable()
        ada.Fill(tab)

        cbox_estado.DisplayMember = "NOM_EST"
        cbox_estado.ValueMember = "ID_ESTADO"

        cbox_estado.DataSource = tab

        cnx.conexion.Close()
    End Sub
    ' metodo que manda a llamar el metodo que cambia el cbox de municipios
    ' y se activa cuando se cambia el valor del cbox de estados
    Private Sub cbox_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_estado.SelectedIndexChanged
        Dim id_est As String = cbox_estado.SelectedValue.ToString()
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

    ' metodo que manda a llamar el metodo que cambia el cbox de colonias
    ' y se activa cuando se cambia el valor del cbox de municipios
    Private Sub cbox_Col_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_municipio.SelectedIndexChanged
        Dim id_munic As String = cbox_municipio.SelectedValue.ToString()
        Call llenaCol(id_munic)
    End Sub

    Private Sub llenaCol(id_munic As String)
        Dim cmm As New SqlCommand("select * from colonia where iD_MUN = " & id_munic, cnx.conexion)
        Dim adp As New SqlDataAdapter(cmm)
        Dim tbl As New DataTable()
        adp.Fill(tbl)

        cbox_Col.DisplayMember = "nom_col"
        cbox_Col.ValueMember = "id_col"

        cbox_Col.DataSource = tbl

        cnx.conexion.Close()
    End Sub

    Private Sub cbox_Col_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbox_Col.SelectionChangeCommitted
        MostrarDatos(" COLONIA.iD_COL = " & cbox_Col.SelectedValue.ToString())
    End Sub

    ' *************** fin de seccion de metodos de comboboxes *******************

    Private Sub dgvDomicilio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDomicilio.CellContentClick
        ' metodo que rellena los campos en blanco cuando se da click en el dgv
        Dim renglon As Integer

        renglon = dgvDomicilio.CurrentCellAddress.Y

        'estos van en el orden en el que los manda a llamar el select
        ' SELECT  DOMICILIO.iD_DOM,     0
        ' PAISES.NOM_PAIS,              1
        ' ESTADO.NOM_EST,               2   
        ' MUNICIPIO.NOM_MUN,            3
        ' COLONIA.NOM_COL,              4
        ' DOMICILIO.CALLE,              5
        ' DOMICILIO.NUM_EXT,            6   
        ' DOMICILIO.NUM_INT             7


        txtId.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(0).Value)
        cbox_Pais.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(1).Value)
        cbox_estado.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(2).Value)
        cbox_municipio.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(3).Value)
        cbox_Col.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(4).Value)
        txtCalle.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(5).Value)
        txtExt.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(6).Value)
        txtInt.Text = Convert.ToString(dgvDomicilio.Rows(renglon).Cells(7).Value)


    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        ' boton que limpia los datos de los campos
        txtId.Text = ""
        txtCalle.Text = ""
        txtInt.Text = ""
        txtExt.Text = ""
    End Sub

    ' inician metodos de insertar, modificar y eliminar

    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        ' metodo para insertar datos
        'definimos variable para el sql query string
        Dim agregar As String

        ' checa que no este vacío
        If txtCalle.Text = "" Or txtExt.Text = "" Or cbox_Col.Text = "" Or cbox_estado.Text = "" Or cbox_municipio.Text = "" Or cbox_Pais.Text = "" Then
            MessageBox.Show("Inserte los datos necesarios.")
        Else
            If txtInt.Text = "" Then
                'significa que la casa no tiene numero interior, pero prefiero meter un valor "-" en vez de un valor nulo
                agregar = "INSERT INTO DOMICILIO(ID_COL, CALLE, NUM_INT, NUM_EXT) VALUES ('" & cbox_Col.SelectedValue.ToString() & "','" & txtCalle.Text & "',NULL,'" & txtExt.Text & "')"
                cnx.Insertar(agregar)

            Else
                'si la casa si cuenta con un numero interior
                ' mete el dato
                agregar = "INSERT INTO DOMICILIO(ID_COL, CALLE, NUM_INT, NUM_EXT) VALUES ('" & cbox_Col.SelectedValue.ToString() & "','" & txtCalle.Text & "','" & txtInt.Text & "', '" & txtExt.Text & "')"
                cnx.Insertar(agregar)
            End If
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ' checa que no este vacío
        If txtCalle.Text = "" Or txtExt.Text = "" Or cbox_Col.Text = "" Or cbox_estado.Text = "" Or cbox_municipio.Text = "" Or cbox_Pais.Text = "" Then
            MessageBox.Show("Inserte los datos necesarios.")
        Else
            If txtInt.Text = "" Then
                Dim actualizar As String = "calle = '" & txtCalle.Text & "', num_int = NULL" & ", num_ext = '" & txtExt.Text & "', id_col = '" & cbox_Col.SelectedValue.ToString() & "'"
                cnx.Actualizar("domicilio", actualizar, "id_dom = " & txtId.Text)
            Else
                Dim actualizar As String = "calle = '" & txtCalle.Text & "', num_int = '" & txtInt.Text & "', num_ext = '" & txtExt.Text & "', id_col = '" & cbox_Col.SelectedValue.ToString() & "'"
                cnx.Actualizar("domicilio", actualizar, "id_dom = " & txtId.Text)
            End If
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        ' checa que no este vacío
        If txtCalle.Text = "" Or txtExt.Text = "" Or cbox_Col.Text = "" Or cbox_estado.Text = "" Or cbox_municipio.Text = "" Or cbox_Pais.Text = "" Then
            MessageBox.Show("Inserte los datos necesarios.")
        Else
            cnx.Eliminar("domicilio", "id_dom = " & txtId.Text)
            cbox_Col.Text = ""
            cbox_estado.Text = ""
            cbox_municipio.Text = ""
            cbox_Pais.Text = ""
            txtId.Text = ""
            txtCalle.Text = ""
            txtInt.Text = ""
            txtExt.Text = ""
        End If
        MostrarDatos("")
    End Sub


End Class
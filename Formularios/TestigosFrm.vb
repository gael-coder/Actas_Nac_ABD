Imports System.Data.SqlClient
Public Class TestigosFrm
    Dim cnx As ConexionSQL = New ConexionSQL()
    Private Sub TestigosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'metodo que se ejecuta cuando recien se carga la ventana
        MostrarDatos("")
        Call llenarCombobox()

    End Sub

    Public Sub MostrarDatos(sql As String)
        Dim query As String
        If sql = "" Then
            'hacer select de id de testigo y id de domicilio
            query = "SELECT T.iD_TESTIGO, T.NOMBRE, T.APE_PAT, T.APE_MAT, D.iD_DOM, P.NOMBRE_ROL, R.NOMBRE , R.ID_REG 
	                FROM TESTIGOS T, REGISTRADO R, PARENTESCO P, DOMICILIO D
	                WHERE P.ID_PARENTESCO = T.ID_PARENTESCO AND 
	                R.ID_REG = T.ID_REG AND
					D.iD_DOM = T.iD_DOM"
            cnx.Consulta(query, "testigo")
            dgvTest.DataSource = cnx.ds.Tables("testigo")
        Else
            query = "SELECT T.iD_TESTIGO, T.NOMBRE, T.APE_PAT, T.APE_MAT, D.iD_DOM, P.NOMBRE_ROL, R.NOMBRE , R.ID_REG 
	                FROM TESTIGOS T, REGISTRADO R, PARENTESCO P, DOMICILIO D
	                WHERE P.ID_PARENTESCO = T.ID_PARENTESCO AND 
	                R.ID_REG = T.ID_REG AND
					D.iD_DOM = T.iD_DOM AND " & sql
            cnx.Consulta(query, "testigo")
            dgvTest.DataSource = cnx.ds.Tables("testigo")
        End If
        cnx.conexion.Close()
    End Sub

    Public Sub llenarCombobox()
        ' metodo que llena los combobox de SEXO, PAISES, PARENTESCO
        ' funciona haciendo un select de las tablas, displaying
        ' el nombre  y tomando como valor el id 

        Dim tablaD, tablaP As New DataTable()

        ' paises
        Dim paises As New SqlCommand("Select * from paises", cnx.conexion)
        Dim adapter2 As New SqlDataAdapter(paises) 'adapta el texto a sql text
        adapter2.Fill(tablaD) 'llena la tabla

        cbox_pais.DataSource = tablaD

        cbox_pais.DisplayMember = "nom_pais"
        cbox_pais.ValueMember = "id_pais"

        ' parentesco
        Dim parentesco As New SqlCommand("Select * from parentesco", cnx.conexion)
        Dim adapter3 As New SqlDataAdapter(parentesco) 'adapta el texto a sql text
        adapter3.Fill(tablaP) 'llena la tabla

        cbox_parent.DataSource = tablaP

        cbox_parent.DisplayMember = "nombre_rol"
        cbox_parent.ValueMember = "iD_PARENTESCO"

        cnx.conexion.Close()
    End Sub

    Private Sub cboxSexo() Handles cbox_sexo.SelectionChangeCommitted
        ' modifica la seleccion de datos a mostrar en el dgv dependiendo de lo que
        ' se seleccione en el cbox_sexo
        MostrarDatos("T.SEXO = '" & cbox_sexo.Text & "'")
    End Sub
    Private Sub cboxPais() Handles cbox_pais.SelectionChangeCommitted
        ' modifica la seleccion de datos a mostrar en el dgv dependiendo de lo que
        ' se seleccione en el cbox_pais
        MostrarDatos("T.ID_PAIS = " & cbox_pais.ValueMember.ToString())
    End Sub
    Private Sub cboxParentesco() Handles cbox_parent.SelectionChangeCommitted
        ' modifica la seleccion de datos a mostrar en el dgv dependiendo de lo que
        ' se seleccione en el cbox_parent
        ' MostrarDatos("T.ID_PARENTESCO = " & cbox_parent.ValueMember.ToString())
    End Sub

    Private Sub link_regis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_regis.LinkClicked
        'al dar click en el link, nos muestra la tabla de registrados
        'RegistradosFrm.Show()
    End Sub

    Private Sub link_dom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_dom.LinkClicked
        ' al dar click en este link nos muestra la tabla de domicilios
        DomicilioFrm.Show()
    End Sub

    Private Sub num_id_dom_ValueChanged(sender As Object, e As EventArgs) Handles num_id_dom.ValueChanged
        'metodo que en base al id ingreado en id domicilio,
        ' llena los campos de calle, colonia, num_int, num_ext, etc
        'se realiza el query
        Dim query2 As String = "SELECT C.NOM_COL, D.CALLE, D.NUM_INT, D.NUM_EXT, C.COD_POS
	                            FROM COLONIA C INNER JOIN DOMICILIO D
	                            ON C.ID_COL = D.ID_COL
	                            WHERE D.ID_DOM = " & num_id_dom.Value.ToString()

        'esta variable se usa para realizar el comando del query,
        Dim cmd As New SqlCommand(query2, cnx.conexion)
        'esta variable convierte el texto a texto sql que soporte la base de datos
        Dim myreader As SqlDataReader
        'se ejecuta la acción
        cnx.conexion.Open()
        Try
            myreader = cmd.ExecuteReader
            myreader.Read()
            ' le asignamos los valores a las textbox
            txt_col.Text = myreader("nom_col")
            txt_calle.Text = myreader("calle")
            txt_int.Text = Convert.ToString(myreader("num_int"))
            txt_ext.Text = myreader("num_ext")
            txt_cod_pos.Text = myreader("cod_pos")
        Catch ex As Exception
            txt_col.Text = ""
            txt_calle.Text = ""
            txt_int.Text = ""
            txt_ext.Text = ""
            txt_cod_pos.Text = ""
        Finally
            cnx.conexion.Close()
        End Try
    End Sub

    Private Sub dgvTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTest.CellContentClick
        ' metodo que rellena los campos en blanco cuando se da click en el dgv
        Dim renglon As Integer

        renglon = dgvTest.CurrentCellAddress.Y

        'estos van en el orden en el que los manda a llamar el select
        ' SELECT T.iD_TESTIGO, (0)
        ' T.NOMBRE, (1)
        ' T.APE_PAT, (2)
        ' T.APE_MAT, (3)
        ' D.iD_DOM, (4)
        ' P.NOMBRE_ROL, (5)
        ' R.NOMBRE  (6)
        ' R.ID:REG (7)
        txt_id.Text = dgvTest.Rows(renglon).Cells(0).Value
        txt_nom.Text = dgvTest.Rows(renglon).Cells(1).Value
        txt_pat.Text = Convert.ToString(dgvTest.Rows(renglon).Cells(2).Value)
        txt_mat.Text = dgvTest.Rows(renglon).Cells(3).Value
        num_id_dom.Value = Convert.ToDouble(dgvTest.Rows(renglon).Cells(4).Value)
        cbox_parent.Text = dgvTest.Rows(renglon).Cells(5).Value
        num_id_reg.Value = Convert.ToString(dgvTest.Rows(renglon).Cells(7).Value)
    End Sub
    ' comienza seccion de botones
    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        ' metodo para insertar datos
        ' checa que no este vacío
        If txt_nom.Text = "" Or txt_pat.Text = "" Or txt_mat.Text = "" Or
            num_edad.Value.ToString() > 110 Or num_edad.Value.ToString() < 18 Or num_id_reg.Value.ToString() = "" Then
            MessageBox.Show("Asegurese de que los datos ingresados esten correctos y/o esten completos")
        Else
            ' mete el dato
            Dim agregar As String = "INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & num_id_dom.Value.ToString() &'id dom
                                         "," & num_id_reg.Value.ToString() & 'id de registrado
                                         "," & cbox_parent.SelectedValue.ToString() & ' id de parentesco
                                         "," & cbox_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & txt_nom.Text & 'nombre
                                         "','" & txt_pat.Text & 'apellido paterno
                                         "','" & txt_mat.Text & 'apellido materno
                                         "','" & cbox_sexo.Text & 'sexo
                                         "'," & num_edad.Value.ToString() & 'edad
                                         ")"
            cnx.Insertar(agregar)
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ' checa que no este vacío
        Dim actualizar As String
        actualizar = "ID_DOM = " & num_id_dom.Value.ToString() &'id dom
            ", ID_REG = " & num_id_reg.Value.ToString() & 'id de registrado
            ", ID_PARENTESCO = " & cbox_parent.SelectedValue.ToString() & ' id de parentesco
            ", ID_PAIS = " & cbox_pais.SelectedValue.ToString() & 'id del pais
            ", NOMBRE =  '" & txt_nom.Text & 'nombre
            "', APE_PAT = '" & txt_pat.Text & 'apellido paterno
            "', APE_MAT = '" & txt_mat.Text & 'apellido materno
            "', SEXO = '" & cbox_sexo.Text & 'sexo
            "', EDAD = " & num_edad.Value.ToString  'edad

        If txt_nom.Text = "" Or txt_pat.Text = "" Or txt_mat.Text = "" Or
            num_edad.Value.ToString() > 110 Or num_edad.Value.ToString() < 18 Or num_id_reg.Value.ToString() = "" Then
            MessageBox.Show("Asegurese de que los datos ingresados esten correctos y/o esten completos")
        Else
            cnx.Actualizar("testigo", actualizar, "id_testigo = " & txt_id.Text)
        End If
        MostrarDatos("")
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        ' checa que no este vacío
        If txt_nom.Text = "" Then
            MessageBox.Show("Ingrese los datos necesarios.")
        Else
            cnx.Eliminar("testigo", "id_testigo = " & txt_id.Text)
        End If
        MostrarDatos("")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ParentescoFrm.Show()
    End Sub
End Class
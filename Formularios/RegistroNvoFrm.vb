Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class RegistroNvoFrm
    Dim cnx As New ConexionSQL()
    Private Sub RegistroNvoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAtiende.Text = "Le atienden en la Oficialia num: " & usuario
        hoy = Today
        dia.Text = "Hoy es " & hoy
        'llena el combobx de parentesco
        Call llenaParent()
        Call llenaPais()
    End Sub

    'metodo que llena el combobox de parentesco
    Private Sub llenaParent()
        ' parentesco
        Dim tablaP As New DataTable()

        Dim parentesco As New SqlCommand("Select * from parentesco", cnx.conexion)
        Dim adapter3 As New SqlDataAdapter(parentesco) 'adapta el texto a sql text
        adapter3.Fill(tablaP) 'llena la tabla

        cbox_parent.DataSource = tablaP

        cbox_parent.DisplayMember = "nombre_rol"
        cbox_parent.ValueMember = "iD_PARENTESCO"

        cnx.conexion.Close()
    End Sub
    Private Sub llenaPais()
        Dim command As New SqlCommand("Select * from paises", cnx.conexion)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        pad_pais.DataSource = table
        mad_pais.DataSource = table
        test_pais.DataSource = table

        pad_pais.DisplayMember = "nom_pais"
        mad_pais.DisplayMember = "nom_pais"
        test_pais.DisplayMember = "nom_pais"

        pad_pais.ValueMember = "id_pais"
        mad_pais.ValueMember = "id_pais"
        test_pais.ValueMember = "id_pais"

        cnx.conexion.Close()
    End Sub

    Public Sub MostrarDatos(sql As String)
        Dim query As String
        If sql = "" Then
            'hacer select de id de testigo y id de domicilio
            query = "SELECT T.NOMBRE, T.APE_PAT, T.APE_MAT, T.EDAD, D.iD_DOM, P.NOMBRE_ROL, R.NOMBRE	 
	                FROM TESTIGOS T, REGISTRADO R, PARENTESCO P, DOMICILIO D
	                WHERE P.ID_PARENTESCO = T.ID_PARENTESCO AND 
	                R.ID_REG = T.ID_REG AND
					D.iD_DOM = T.iD_DOM"
            cnx.Consulta(query, "regNovo")
            dgvReg.DataSource = cnx.ds.Tables("regNovo")
        Else
            query = "SELECT T.NOMBRE, T.APE_PAT, T.APE_MAT, T.EDAD, D.iD_DOM, P.NOMBRE_ROL, R.NOMBRE	 
	                FROM TESTIGOS T, REGISTRADO R, PARENTESCO P, DOMICILIO D
	                WHERE P.ID_PARENTESCO = T.ID_PARENTESCO AND 
	                R.ID_REG = T.ID_REG AND
					D.iD_DOM = T.iD_DOM AND " & sql
            cnx.Consulta(query, "regNovo")
            dgvReg.DataSource = cnx.ds.Tables("regNovo")
        End If
        cnx.conexion.Close()
    End Sub

    Private Sub dgvReg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReg.CellContentClick
        ' el algoritmo funciona de la manera, en que si se escoge un dato cuyo parentesco sea padre, se llena el texto del padre
        ' si se escoge un dato cuyo parentesco sea madre, se llena el texto de la madre
        ' y si se escoge cualquier otro, se llena abajo en el testigo


        ' metodo que rellena los campos en blanco cuando se da click en el dgv
        Dim renglon As Integer

        renglon = dgvReg.CurrentCellAddress.Y

        Dim parent As String = Convert.ToString(dgvReg.Rows(renglon).Cells(5).Value)

        If parent = "Padre" Then
            'estos van en el orden en el que los manda a llamar el select
            ' SELECT T.NOMBRE,  0
            ' T.APE_PAT,        1
            ' T.APE_MAT,        2
            ' T.EDAD,           3
            ' D.iD_DOM,         4
            ' P.NOMBRE_ROL,     5
            ' R.NOMBRE	        6


            pad_nom.Text = dgvReg.Rows(renglon).Cells(0).Value
            pad_pat.Text = Convert.ToString(dgvReg.Rows(renglon).Cells(1).Value)
            pad_mat.Text = dgvReg.Rows(renglon).Cells(2).Value
            pat_dom.Value = dgvReg.Rows(renglon).Cells(4).Value
            pat_edad.Value = Convert.ToDecimal(dgvReg.Rows(renglon).Cells(3).Value)
        ElseIf parent = "Madre" Then
            'estos van en el orden en el que los manda a llamar el select
            ' SELECT T.NOMBRE,  0
            ' T.APE_PAT,        1
            ' T.APE_MAT,        2
            ' T.EDAD,           3
            ' D.iD_DOM,         4
            ' P.NOMBRE_ROL,     5
            ' R.NOMBRE	        6


            mad_nom.Text = dgvReg.Rows(renglon).Cells(0).Value
            mad_pat.Text = Convert.ToString(dgvReg.Rows(renglon).Cells(1).Value)
            mad_mat.Text = dgvReg.Rows(renglon).Cells(2).Value
            mad_dom.Value = Convert.ToDouble(dgvReg.Rows(renglon).Cells(4).Value)
            mat_edad.Value = Convert.ToDecimal(dgvReg.Rows(renglon).Cells(3).Value)
        Else
            'estos van en el orden en el que los manda a llamar el select
            ' SELECT T.NOMBRE,  0
            ' T.APE_PAT,        1
            ' T.APE_MAT,        2
            ' T.EDAD,           3
            ' D.iD_DOM,         4
            ' P.NOMBRE_ROL,     5
            ' R.NOMBRE	        6

            test_nom.Text = dgvReg.Rows(renglon).Cells(0).Value
            test_pat.Text = Convert.ToString(dgvReg.Rows(renglon).Cells(1).Value)
            test_mat.Text = dgvReg.Rows(renglon).Cells(2).Value
            test_dom.Value = Convert.ToDouble(dgvReg.Rows(renglon).Cells(4).Value)
            cbox_parent.Text = Convert.ToString(dgvReg.Rows(renglon).Cells(5).Value)
            test_edad.Value = Convert.ToDecimal(dgvReg.Rows(renglon).Cells(3).Value)
        End If

    End Sub

    ' metodos que se modifican el dgv dependiendo del texto insertado
    'PADRE
    Private Sub pad_nom_TextChanged(sender As Object, e As EventArgs) Handles pad_nom.TextChanged
        MostrarDatos("T.NOMBRE LIKE '" & pad_nom.Text & "%'")
    End Sub

    Private Sub pad_pat_TextChanged(sender As Object, e As EventArgs) Handles pad_pat.TextChanged
        MostrarDatos("T.APE_PAT LIKE '" & pad_pat.Text & "%'")
    End Sub

    Private Sub pad_mat_TextChanged(sender As Object, e As EventArgs) Handles pad_mat.TextChanged
        MostrarDatos("T.APE_MAT LIKE '" & pad_mat.Text & "%'")
    End Sub

    ' MADRE

    Private Sub mad_nom_TextChanged(sender As Object, e As EventArgs) Handles mad_nom.TextChanged
        MostrarDatos("T.NOMBRE LIKE '" & mad_nom.Text & "%'")
    End Sub

    Private Sub mad_pat_TextChanged(sender As Object, e As EventArgs) Handles mad_pat.TextChanged
        MostrarDatos("T.APE_PAT LIKE '" & mad_pat.Text & "%'")
    End Sub

    Private Sub mad_mat_TextChanged(sender As Object, e As EventArgs) Handles mad_mat.TextChanged
        MostrarDatos("T.APE_MAT LIKE '" & mad_mat.Text & "%'")
    End Sub

    'TESTIGO

    Private Sub test_nom_TextChanged(sender As Object, e As EventArgs) Handles test_nom.TextChanged
        MostrarDatos("T.NOMBRE LIKE '" & test_nom.Text & "%'")
    End Sub

    Private Sub test_pat_TextChanged(sender As Object, e As EventArgs) Handles test_pat.TextChanged
        MostrarDatos("T.APE_PAT LIKE '" & test_pat.Text & "%'")
    End Sub

    Private Sub test_mat_TextChanged(sender As Object, e As EventArgs) Handles test_mat.TextChanged
        MostrarDatos("T.APE_MAT LIKE '" & test_mat.Text & "%'")
    End Sub

    Private Sub seleccionIdDom(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles id_dom1.LinkClicked, id_dom2.LinkClicked, id_dom3.LinkClicked
        DomicilioFrm.Show()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        'boton de insertar
        'NOTA: ESTE BOTON DE INSERTAR INSERTA 5 DATOS
        '1. EL DATO DE ACTA
        '2. EL REGISTRADO
        '3. SU PADRE
        '4. SU MADRE
        '5. EL TESTIGO

        'insercion del registrado

        ' checa que no este vacío
        If reg_nom.Text = "" Or reg_pat.Text = "" Or reg_mat.Text = "" Or cbox_sexo.Text = "" Or
            cbox_presentado.Text = "" Or cbox_compar.Text = "" Or
            pad_nom.Text = "" Or pad_mat.Text = "" Or pad_pat.Text = "" Or pat_edad.Value < 6 Or
            mad_nom.Text = "" Or mad_mat.Text = "" Or mad_pat.Text = "" Or mat_edad.Value < 6 Or
            test_nom.Text = "" Or test_mat.Text = "" Or test_pat.Text = "" Or test_edad.Value < 18 Or
            cbox_test_sexo.Text = "" Or cbox_parent.Text = "" Then
            MessageBox.Show("Inserte los datos necesarios")
        Else
            ' mete los datos

            'dato de acta
            Dim dato_acta, regist, padre, madre, testigo As String
            dato_acta = "INSERT INTO DATOS_ACTA(ID_OFIC, FECHA_REGIST, NUM_LIBRO) VALUES 
                        (" & usuario & ",'" & hoy & "'," & num_libro.Value.ToString() & ")"

            'dato de registrado
            regist = "INSERT INTO REGISTRADO(FOLIO,NOMBRE,APE_PAT,APE_MAT,FECHA_NAC,SEXO,PRESENTADO,COMPARECIDO) 
                          VALUES(" & folio &
                          ",'" & reg_nom.Text & "','" & reg_pat.Text & "','" & reg_mat.Text & "','" & hoy & "','" & cbox_sexo.Text &
                          "','" & cbox_presentado.Text & "','" & cbox_compar.Text & "')"

            'dato de padre
            padre = "INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & pat_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         ",1," & pad_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & pad_nom.Text & 'nombre
                                         "','" & pad_pat.Text & 'apellido paterno
                                         "','" & pad_mat.Text & 'apellido materno
                                         "','MASCULINO'," & pat_edad.Value.ToString() & 'edad
                                         ")"

            'dato de madre
            madre = "INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & mad_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         ",2," & mad_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & mad_nom.Text & 'nombre
                                         "','" & mad_pat.Text & 'apellido paterno
                                         "','" & mad_mat.Text & 'apellido materno
                                         "','FEMENINO'," & mat_edad.Value.ToString() & 'edad
                                         ")"

            'dato de testigo
            testigo = "INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & test_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         "," & cbox_parent.SelectedValue.ToString() & ' id de parentesco
                                         "," & test_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & test_nom.Text & 'nombre
                                         "','" & test_pat.Text & 'apellido paterno
                                         "','" & test_mat.Text & 'apellido materno
                                         "','" & cbox_sexo.Text & 'sexo
                                         "'," & test_edad.Value.ToString() & 'edad
                                         ")"

            cnx.Insertar(dato_acta)
            cnx.conexion.Close()

            Dim query As New SqlCommand("SELECT * FROM  DATOS_ACTA WHERE FOLIO = (SELECT MAX(FOLIO)  FROM DATOS_ACTA)", cnx.conexion)

            cnx.conexion.Open()
            folio = query.ExecuteScalar()
            cnx.conexion.Close()

            cnx.Insertar("INSERT INTO REGISTRADO(FOLIO,NOMBRE,APE_PAT,APE_MAT,FECHA_NAC,SEXO,PRESENTADO,COMPARECIDO) 
                          VALUES(" & folio &
                          ",'" & reg_nom.Text &
                          "','" & reg_pat.Text &
                          "','" & reg_mat.Text &
                          "','" & hoy &
                          "','" & cbox_sexo.Text &
                          "','" & cbox_presentado.Text &
                          "','" & cbox_compar.Text & "')")

            Dim query2 As New SqlCommand("SELECT ID_REG FROM REGISTRADO WHERE ID_REG = (SELECT MAX(ID_REG)  FROM REGISTRADO)", cnx.conexion)


            cnx.conexion.Open()
            registrado = query2.ExecuteScalar()
            cnx.conexion.Close()
            'padre
            cnx.Insertar("INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & pat_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         ",1," & pad_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & pad_nom.Text & 'nombre
                                         "','" & pad_pat.Text & 'apellido paterno
                                         "','" & pad_mat.Text & 'apellido materno
                                         "','MASCULINO'," & pat_edad.Value.ToString() & 'edad
                                         ")")
            cnx.Insertar("INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & mad_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         ",2," & mad_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & mad_nom.Text & 'nombre
                                         "','" & mad_pat.Text & 'apellido paterno
                                         "','" & mad_mat.Text & 'apellido materno
                                         "','FEMENINO'," & mat_edad.Value.ToString() & 'edad
                                         ")")
            cnx.Insertar("INSERT INTO TESTIGOS(ID_DOM, ID_REG, ID_PARENTESCO, ID_PAIS, NOMBRE, APE_PAT, APE_MAT, SEXO, EDAD) VALUES
                                        (" & test_dom.Value.ToString() &'id dom
                                         "," & registrado & 'id de registrado
                                         "," & cbox_parent.SelectedValue.ToString() & ' id de parentesco
                                         "," & test_pais.SelectedValue.ToString() & 'id del pais
                                         ",'" & test_nom.Text & 'nombre
                                         "','" & test_pat.Text & 'apellido paterno
                                         "','" & test_mat.Text & 'apellido materno
                                         "','" & cbox_sexo.Text & 'sexo
                                         "'," & test_edad.Value.ToString() & 'edad
                                         ")")

        End If
        MostrarDatos("")
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPais1.LinkClicked, linkPais2.LinkClicked, linkPais3.LinkClicked
        PaisesFrm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ParentescoFrm.Show()
    End Sub
End Class
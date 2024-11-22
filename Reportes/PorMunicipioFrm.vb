Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class PorMunicipioFrm
    Dim cnx As New ConexionSQL()
    Private Sub PORMUNICIPIOFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarCombobox()
    End Sub

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

    Public Sub MostrarDatos()
        Dim sql As String = "
            SELECT D.FOLIO AS N_ACTA , NOMBRE,APE_PAT,APE_MAT,FECHA_NAC, PRESENTADO, M.NOM_MUN
            FROM DATOS_ACTA D, REGISTRADO R,OFICIALIA O,DOMICILIO DO, COLONIA C, MUNICIPIO M
            WHERE D.FOLIO=R.FOLIO AND O.iD_OFIC =D.iD_OFIC AND DO.iD_DOM =  O.iD_DOM AND  C.iD_COL = DO.ID_COL AND M.iD_MUN = C.iD_MUN AND M.iD_MUN =" & cbox_municipio.SelectedValue.ToString()
        cnx.Consulta(sql, "MUNIC")
        DataGridView1.DataSource = cnx.ds.Tables("MUNIC")


    End Sub

    Private Sub cbox_municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_municipio.SelectionChangeCommitted
        MostrarDatos()
    End Sub
End Class
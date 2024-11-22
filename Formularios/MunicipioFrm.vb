Imports System.Data.SqlClient

Public Class MunicipioFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Dim sentencia, mensaje As String
    Dim tabla, tabla2 As DataTable
    Dim adapador, adapador2 As SqlDataAdapter

    'este el el codigo
    Private Sub MunicipioFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        'metodo que llena el combobox de paises  
        Call llenarCombobox()

    End Sub

    'ESTE METODO ES EL DE EJECUTA EL SQL
    Function EjecutarSql(sql As String, msg As String) As Boolean
        Try
            Dim cmd As New SqlCommand(sql, cnx.conexion)
            cnx.conexion.Open()
            cmd.ExecuteNonQuery()
            cnx.conexion.Close()
            MsgBox(msg)
            Return True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'ESTE METODO ES EL QUE REGRESA A LA PAGINA ANTERIOR
    Sub resetear()
        Me.Hide()
        Menu.Show()
    End Sub

    'ESTE METODO LLENA EL COMBOBOX DE NOMBRE DE MUNICIPIO
    Private Sub llenarCombobox() Handles MyBase.Load

        'llena el combobox de pais
        Dim command As New SqlCommand("Select * from paises", cnx.conexion)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        cboxPais.DisplayMember = "nom_pais"
        cboxPais.ValueMember = "id_pais"

        cboxPais.DataSource = table

        cnx.conexion.Close()


    End Sub
    ' metodo que cuando cambia el valor del cbox de paises, ajusta los datos del cbox de estados
    Private Sub cboxPais_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboxPais.SelectedIndexChanged
        Dim COMMAND As New SqlCommand("select * from ESTADO E WHERE PAISES_ID_PAIS = " & cboxPais.SelectedValue.ToString, cnx.conexion)
        Dim ADAPTER As New SqlDataAdapter(COMMAND)
        Dim TABLE As New DataTable()
        ADAPTER.Fill(TABLE)
        ComboBoxESTADO.DataSource = TABLE
        ComboBoxESTADO.DisplayMember = "NOM_EST"
        ComboBoxESTADO.ValueMember = "ID_ESTADO"
    End Sub


    'ESTE METODO MUESTRA EL SELECT DEL MUNICIPIO
    Sub Mostrar()
        Dim da As New SqlDataAdapter("SELECT C.ID_MUN,E.NOM_EST, C.NOM_MUN 
                                        FROM MUNICIPIO C , ESTADO E
                                    WHERE C.ID_ESTADO=E.ID_ESTADO AND E.NOM_EST='" + ComboBoxESTADO.Text + "'", cnx.conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        cnx.conexion.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' metodo que rellena los campos en blanco cuando se da click en el dgv
        Dim renglon As Integer

        renglon = DataGridView1.CurrentCellAddress.Y

        TextBoxID_ESTADO.Text = DataGridView1.Rows(renglon).Cells(0).Value
        ComboBoxESTADO.Text = DataGridView1.Rows(renglon).Cells(1).Value
        ComboBoxMUNICIPIO.Text = DataGridView1.Rows(renglon).Cells(2).Value

    End Sub

    'ESTE METODO HACE EL INSERT

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        If ComboBoxMUNICIPIO.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else

            sentencia = "insert into municipio (NOM_MUN, ID_ESTADO) values('" + ComboBoxMUNICIPIO.Text + "','" + ComboBoxESTADO.SelectedValue.ToString + "')"
            mensaje = "Datos insertados correctamente"
            EjecutarSql(sentencia, mensaje)
            Mostrar()
        End If


    End Sub


    'ESTE METODO HACE QUE SE ACUTUALIZA EL SELECT CUANDO SE SELECCIONA ALGO
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxESTADO.SelectedIndexChanged
        Mostrar()

    End Sub

    'ESTE METODO HACE EL UPDATE
    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles btnMod.Click

        sentencia = "update municipio set nom_mun='" + ComboBoxMUNICIPIO.Text + "' where id_mun='" + TextBoxID_ESTADO.Text + "' "
        mensaje = "Datos actualizados correctamente"
        EjecutarSql(sentencia, mensaje)
        Mostrar()
    End Sub

    'ESTE METODO HACE EL DELETE
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        If TextBoxID_ESTADO.Text = "" Then
            MessageBox.Show("Seleccione su dato")
        Else
            sentencia = "delete from municipio where id_mun='" + TextBoxID_ESTADO.Text + "'"
            mensaje = "Datos eliminados correctamente"
            If EjecutarSql(sentencia, mensaje) = False Then
                MsgBox("El registro esta vinculado a la tabla ESTADOS")
            End If

            Mostrar()
        End If
    End Sub




End Class
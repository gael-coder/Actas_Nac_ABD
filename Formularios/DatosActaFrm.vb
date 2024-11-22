Imports System.Data.SqlClient

Public Class DatosActaFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Dim sentencia, mensaje As String
    Dim tabla, tabla2 As DataTable
    Dim adapador, adapador2 As SqlDataAdapter
    Dim la_fecha As String


    Private Sub DatosActaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        'ESTOS CODIGOS LLENAN EL COMBOBOX DEL ID PARA QUE SE MUESTRE EL NOMBRE DEL ESTADO PERO SE USE EL ID
        Dim COMMAND As New SqlCommand("select * from oficialia", cnx.conexion)
        Dim ADAPTER As New SqlDataAdapter(COMMAND)
        Dim TABLE As New DataTable()
        ADAPTER.Fill(TABLE)
        ComboBoxOFIC.DataSource = TABLE
        ComboBoxOFIC.DisplayMember = "id_ofic"
        ComboBoxOFIC.ValueMember = "id_ofic"
        'ESTE CODIGOS LLENAN EL COMBOBOX 
        adapador2 = New SqlDataAdapter("select * from datos_acta", cnx.conexion)
        tabla2 = New DataTable
        adapador2.Fill(tabla2)
        Call llenarComboboxdatos_acta()
    End Sub



    Function EjecutarSql(sql As String, msg As String) As Boolean
        Try
            Dim cmd As New SqlCommand(sql, cnx.conexion)
            cnx.conexion.Open()
            cmd.ExecuteNonQuery()
            cnx.conexion.Close()
            MsgBox(msg)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Sub resetear()
        Me.Hide()
        Menu.Show()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        la_fecha = DateTimePicker1.Value.ToShortDateString
    End Sub
    Private Sub ButtonINSERT_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        If ComboBoxNUM_LIBRO.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else

            sentencia = "insert into datos_acta (fecha_regist, num_libro,id_ofic) values('" + la_fecha + "',
'" + ComboBoxNUM_LIBRO.Text + "','" + ComboBoxOFIC.SelectedValue.ToString + "')"
            mensaje = "datos insertados corecctamente"
            EjecutarSql(sentencia, mensaje)
            Mostrar()
        End If
    End Sub

    Private Sub ButtonACTUALIZAR_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        sentencia = "update datos_acta set fecha_regist='" + la_fecha + "',num_libro='" + ComboBoxNUM_LIBRO.Text + "'
where folio='" + TextBoxFOLIO.Text + "' "
        mensaje = "datos actualizados corecctamente"
        EjecutarSql(sentencia, mensaje)
        Mostrar()
    End Sub

    Private Sub ButtonDELETE_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        If ComboBoxNUM_LIBRO.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            sentencia = "delete from datos_acta where folio='" + TextBoxFOLIO.Text + "'"
            mensaje = "datos eliminados corecctamente"
            If EjecutarSql(sentencia, mensaje) = False Then
                MsgBox("EL REGISTRO ESTA VINCUALDO EN LA TABLA ESTADO")
            End If

            Mostrar()
        End If
    End Sub

    Private Sub ComboBoxOFIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOFIC.SelectedIndexChanged
        Mostrar()
    End Sub

    Sub Mostrar()
        Dim da As New SqlDataAdapter("SELECT FOLIO,O.iD_OFIC,FECHA_REGIST,NUM_LIBRO
FROM DATOS_ACTA A, OFICIALIA O
WHERE A.iD_OFIC=O.iD_OFIC AND O.iD_OFIC='" + ComboBoxOFIC.Text + "'", cnx.conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        cnx.conexion.Close()
    End Sub


    Private Sub llenarComboboxdatos_acta()
        For Each fila As DataRow In tabla2.Rows
            ComboBoxNUM_LIBRO.Items.Add(fila("num_libro"))
        Next

    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class OficialiasFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Dim sqlStr As String
    Dim sentencia, mensaje As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet

    ' Metodo que valida y evita los errores 
    Private Sub OficialiaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
        sqlStr = "select * from DOMICILIO"
        adapter = New System.Data.SqlClient.SqlDataAdapter(sqlStr, cnx.conexion)
        data = New DataSet
        adapter.Fill(data)
        dom_cbox.DataSource = data.Tables(0)
        dom_cbox.DisplayMember = "iD_DOM"
        dom_cbox.ValueMember = "iD_DOM"
    End Sub

    ' Metodo que valida y evita los errores 
    Sub EjecutarSql(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, cnx.conexion)
            cnx.conexion.Open()
            cmd.ExecuteNonQuery()
            cnx.conexion.Close()
            MessageBox.Show(mensaje)
        Catch ex As Exception
            MessageBox.Show("NO SÉ PUEDE REALIZAR ESTA ACCIÓN")
        End Try
    End Sub

    ' Metodo que muestra los datos 
    ' param : String
    ' si el parametro es un string vacio, se muestran todos los datos
    ' si el parametro es un string con algo 
    ' se hace el select donde solo se muestren datos que contengan esa oficialia
    Public Sub MostrarDatos()
        cnx.Consulta("select * from oficialia", "OFICIALIA")
        dgv_Ofic.DataSource = cnx.ds.Tables("OFICIALIA")
        cnx.conexion.Close()
    End Sub

    Private Sub elimBtn_Click(sender As Object, e As EventArgs) Handles elimBtn.Click
        If ofic_id.Text = "" Or ofic_contra.Text = "" Or ofic_id.Text = usuario Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If
        sentencia = "delete from OFICIALIA where iD_OFIC='" + ofic_id.Text + "'"
        mensaje = "Datos eliminados"
        EjecutarSql(sentencia, mensaje)
        MostrarDatos()
    End Sub

    Private Sub modBtn_Click(sender As Object, e As EventArgs) Handles modBtn.Click
        If ofic_id.Text = "" Or ofic_contra.Text = "" Or ofic_id.Text = usuario Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If
        sentencia = "update OFICIALIA set CONTRASEÑA=' " + ofic_contra.Text + "' where iD_OFIC='" + ofic_id.Text + "'"
        mensaje = "Datos actualizados"
        EjecutarSql(sentencia, mensaje)
        MostrarDatos()
    End Sub

    Private Sub insBtn_Click(sender As Object, e As EventArgs) Handles insBtn.Click
        If ofic_id.Text = "" Or ofic_contra.Text = "" Or ofic_id.Text = usuario Then
            MessageBox.Show("Asegurese de que sus datos esten correctos")
            Exit Sub
        End If
        Dim adaptador As New SqlCommand("insert into OFICIALIA values('" & ofic_id.Text & "', '" & dom_cbox.Text & "', '" & ofic_contra.Text & "')", cnx.conexion)
        cnx.conexion.Open()
        adaptador.ExecuteNonQuery()
        MostrarDatos()
        cnx.conexion.Close()
    End Sub

End Class

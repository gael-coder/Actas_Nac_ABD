Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ParentescoFrm
    Dim cnx As ConexionSQL = New ConexionSQL() ' variable para la conexion
    Dim sentencia, mensaje As String
    Dim tabla As DataTable
    Dim adapador As SqlDataAdapter

    Private Sub ParentescoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        adapador = New SqlDataAdapter("select * from parentesco", cnx.conexion)
        tabla = New DataTable
        adapador.Fill(tabla)
        Call llenarCombobox()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        regresar()

    End Sub
    Sub regresar()
        Me.Hide()
        Menu.Show()

    End Sub
    Sub Mostrar()
        Dim da As New SqlDataAdapter("select*from PARENTESCO", cnx.conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        dgvParent.DataSource = ds.Tables(0)
        cnx.conexion.Close()
    End Sub

    Private Sub insBtn_Click(sender As Object, e As EventArgs) Handles insBtn.Click
        If parentCbox.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            Dim cantidad As String ''para insertar el valor que el usuario seleciono
            cantidad = parentCbox.Text
            sentencia = "insert into parentesco values('" + parentCbox.Text + "')"
            cnx.Insertar(sentencia)
            Mostrar()
        End If
    End Sub

    Private Sub modBtn_Click(sender As Object, e As EventArgs) Handles modBtn.Click
        Dim cantidad As String ''para insertar el valor que el usuario seleciono
        cantidad = parentCbox.Text
        sentencia = "update parentesco set nombre_rol='" + parentCbox.Text + "' where id_parentesco='" + txtId_paren.Text + "' "
        cnx.Insertar(sentencia)

    End Sub

    Private Sub elimBtn_Click(sender As Object, e As EventArgs) Handles elimBtn.Click
        Dim cantidad As String ''para insertar el valor que el usuario seleciono
        cantidad = parentCbox.Text
        sentencia = "delete from parentesco where id_parentesco='" + txtId_paren.Text + "'"
        cnx.Insertar(sentencia)

    End Sub

    Private Sub llenarCombobox()
        For Each fila As DataRow In tabla.Rows
            parentCbox.Items.Add(fila("nombre_rol"))
        Next
    End Sub

End Class
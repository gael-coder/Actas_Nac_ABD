
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection.Metadata.Ecma335
Imports System.Windows.Forms

Public Class ConexionSQL

    Public conexion As SqlConnection = New SqlConnection("Data Source=EVOLUTION\SQLEXPRESS;Initial Catalog=ACT_NAC;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub


    Public Sub Consulta(sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        conexion.Close()
    End Sub

    Function Insertar(ByVal sql)
        ' Try
        conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
        '    Return True
        'MessageBox.Show("Datos agregados correctamente")
        'Catch ex As Exception
        'MessageBox.Show(Convert.ToString(ex))
        'Return Nothing
        'Finally
        conexion.Close()
        'End Try
    End Function

    Function Eliminar(ByVal tabla, ByVal condicion)
        Dim elimina As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, conexion)
        conexion.Open()
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Dato eliminado exitosamente")
            Return True
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar ese dato")
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        Try
            conexion.Open()
            Dim actualiza As String = "update " + tabla + " set " + campos + " where " + condicion
            comando = New SqlCommand(actualiza, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            MessageBox.Show("Datos actualizados correctamente")
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al modificar")
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


End Class




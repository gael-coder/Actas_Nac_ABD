Imports System.Data.SqlClient

Public Class PorFechaFrm
    Dim conexion As New SqlConnection("Data Source=LAPTOP-13T76ADP;Initial Catalog=ACT_NAC;Integrated Security=True;Connect Timeout=200;Pooling=true;Max Pool Size=200")
    Dim la_fecha, la_fecha2 As String

    Private Sub PORFECHAFRM_Load(sender As Object, e As EventArgs)
        la_fecha = DateTimePicker1.Value.ToShortDateString
        la_fecha2 = DateTimePicker2.Value.ToShortDateString

    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        la_fecha = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        la_fecha2 = DateTimePicker2.Value.ToShortDateString

    End Sub

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Mostrar()

    End Sub


    Function EjecutarSql(sql As String, msg As String) As Boolean
        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
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


    Sub Mostrar()
        Dim da As New SqlDataAdapter("SELECT D.FOLIO AS N_ACTA ,NOMBRE,APE_PAT,APE_MAT,FECHA_NAC,PRESENTADO,FECHA_REGIST
                        FROM DATOS_ACTA D, REGISTRADO R
                        WHERE D.FOLIO=R.FOLIO AND D.FECHA_REGIST BETWEEN '" + la_fecha + "'and '" + la_fecha2 + "'", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub


End Class
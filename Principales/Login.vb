Imports System.Data.SqlClient

Public Class Login
    Dim cnx As ConexionSQL = New ConexionSQL()
    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        ' metodo que se encarga de checar que los datos que se ingresen
        ' sean correctos

        If txtCont.Text = "" Or txtOfic.Text = "" Then ' si estan vacias las textbox
            MessageBox.Show("Asegurese de insertar todos los datos")
        Else
            ' si no estan vacias la stextbox
            Dim dato As String = ""
            Dim sqlStr As String = "Select * from OFICIALIA WHERE iD_OFIC='" & txtOfic.Text & "' and CONTRASEÑA='" & txtCont.Text & "'"
            Dim query As New SqlCommand(sqlStr, cnx.conexion)
            Try
                cnx.conexion.Open()
                dato = query.ExecuteScalar()
            Catch ex As Exception
                MessageBox.Show("Inserte solo datos permitidos")
            Finally
                cnx.conexion.Close()
            End Try

            If dato <> "" Then
                Menu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Oficialia y/o contraseña incorrectos.")
            End If
        End If

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        txtCont.Text = ""
        txtOfic.Text = ""
    End Sub
End Class
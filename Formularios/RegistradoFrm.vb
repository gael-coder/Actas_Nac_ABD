Imports System.Data.SqlClient
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class RegistradoFrm
    Dim conexion As New SqlConnection("Data Source=LAPTOP-13T76ADP;Initial Catalog=ACT_NAC;Integrated Security=True;Connect Timeout=200;Pooling=true;Max Pool Size=200")
    Dim sentencia, mensaje As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        DatosActaFrm.Show()
    End Sub

    Dim la_fecha As String
    Private Sub RegistradoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar("")
        'ESTOS CODIGOS LLENAN EL COMBOBOX DEL ID PARA QUE SE MUESTRE EL NOMBRE DEL FOLIO PERO SE USE EL ID
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        la_fecha = DateTimePicker1.Value.ToShortDateString
    End Sub



    Private Sub ButtonINSERT_Click(sender As Object, e As EventArgs) Handles ButtonINSERT.Click
        If TextBoxnombre.Text = "" Or TextBoxape_paterno.Text = "" Or TextBoxape_materno.Text = "" Or ComboBoxPRESENTADO.Text = "" Or ComboBoxPRESENTADO.Text = "" Or ComboBoxCOMPARECIDO.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto que falte.")
        Else
            Dim folio As String = "INSERT INTO DATOS_ACTA(ID_OFIC, FECHA_REGIST, NUM_LIBRO) VALUES 
                        (" & usuario & ",'" & hoy & "'," & num_libro.Value.ToString() & ")"


            sentencia = "insert into REGISTRADO (nombre,ape_pat,ape_mat,fecha_Nac,sexo,presentado,comparecido,folio) values('" + txtId.Text + "',
'" + TextBoxnombre.Text + "','" + TextBoxape_paterno.Text + "','" + TextBoxape_materno.Text + "','" + la_fecha + "','" + ComboBoxPRESENTADO.Text + "','" + ComboBoxPRESENTADO.Text + "'
,'" + ComboBoxCOMPARECIDO.Text + "','" + folio + "')"
            mensaje = "datos insertados correctamente"
            EjecutarSql(sentencia, mensaje)
            Mostrar("")
        End If
    End Sub

    Private Sub ComboBoxSEXO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSEXO.SelectionChangeCommitted
        Mostrar("R.SEXO = '" & ComboBoxSEXO.Text & "'")
    End Sub

    Private Sub ComboBoxCOMPARECIDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCOMPARECIDO.SelectedIndexChanged
        Mostrar("R.COMPARECIDO = '" & ComboBoxCOMPARECIDO.Text & "'")
    End Sub

    Private Sub TextBoxnombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxnombre.TextChanged
        Mostrar("R.NOMBRE LIKE '" & TextBoxnombre.Text & "%'")
    End Sub

    Private Sub TextBoxape_paterno_TextChanged(sender As Object, e As EventArgs) Handles TextBoxape_paterno.TextChanged
        Mostrar("R.APE_PAT LIKE '" & TextBoxape_paterno.Text & "%'")
    End Sub

    Private Sub TextBoxape_materno_TextChanged(sender As Object, e As EventArgs) Handles TextBoxape_materno.TextChanged
        Mostrar("R.APE_MAT LIKE '" & TextBoxape_materno.Text & "%'")
    End Sub

    Private Sub ComboBoxPRESENTADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPRESENTADO.SelectionChangeCommitted
        Mostrar("R.PRESENTADO = '" & ComboBoxPRESENTADO.Text & "'")
    End Sub

    Private Sub ButtonACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ButtonACTUALIZAR.Click
        sentencia = "update REGISTRADO set nombre='" + TextBoxape_paterno.Text + "',ape_pat='" + TextBoxape_paterno.Text + "',ape_mat='" + TextBoxape_materno.Text + "',
fecha_nac='" + la_fecha + "',sexo='" + ComboBoxPRESENTADO.Text + "',presentado='" + ComboBoxPRESENTADO.Text + "',comparecido='" + ComboBoxCOMPARECIDO.Text + "'
where ID_REG='" + txtId.Text + "' "
        mensaje = "datos actualizados corecctamente"
        EjecutarSql(sentencia, mensaje)
        Mostrar("")
    End Sub

    Private Sub ButtonDELETE_Click(sender As Object, e As EventArgs) Handles ButtonDELETE.Click
        If txtId.Text = "" Then
            MessageBox.Show("Inserte un dato en la caja de texto.")
        Else
            sentencia = "delete from REGISTRADO where ID_REG='" + txtId.Text + "'"
            mensaje = "datos eliminados correctamente"
            If EjecutarSql(sentencia, mensaje) = False Then
                MsgBox("EL REGISTRO ESTA VINCUALDO")
            End If

            Mostrar("")
        End If
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReg.CellContentClick
        Dim renglon As Integer

        renglon = dgvReg.CurrentCellAddress.Y

        Dim parent As String = Convert.ToString(dgvReg.Rows(renglon).Cells(5).Value)

        'estos van en el orden en el que los manda a llamar el select
        ' SELECT ID_REG,    0
        ' D.FOLIO,          1
        ' NOMBRE,           2
        ' APE_PAT,          3
        ' APE_MAT,          4
        ' FECHA_NAC,        5
        ' SEXO,             6
        ' PRESENTADO,       7
        ' COMPARECIDO       8


        txtId.Text = dgvReg.Rows(renglon).Cells(0).Value
        TextBoxnombre.Text = dgvReg.Rows(renglon).Cells(2).Value
        TextBoxape_paterno.Text = dgvReg.Rows(renglon).Cells(3).Value
        TextBoxape_materno.Text = dgvReg.Rows(renglon).Cells(4).Value
        DateTimePicker1.Value = dgvReg.Rows(renglon).Cells(5).Value
        ComboBoxSEXO.Text = dgvReg.Rows(renglon).Cells(6).Value
        ComboBoxPRESENTADO.Text = dgvReg.Rows(renglon).Cells(7).Value
        ComboBoxCOMPARECIDO.Text = dgvReg.Rows(renglon).Cells(8).Value
    End Sub

    Sub Mostrar(sql As String)
        Dim query As String
        If sql = "" Then
            query = "SELECT ID_REG,D.FOLIO,NOMBRE,APE_PAT,APE_MAT,FECHA_NAC,SEXO,PRESENTADO,COMPARECIDO
                                    FROM REGISTRADO R, DATOS_ACTA D
                                    WHERE D.FOLIO = R.FOLIO"
            cnx.Consulta(query, "registrado")
            dgvReg.DataSource = cnx.ds.Tables("registrado")
        Else
            query = "SELECT ID_REG,D.FOLIO,NOMBRE,APE_PAT,APE_MAT,FECHA_NAC,SEXO,PRESENTADO,COMPARECIDO
                                    FROM REGISTRADO R, DATOS_ACTA D
                                    WHERE D.FOLIO = R.FOLIO AND " & sql
            cnx.Consulta(query, "registrado")
            dgvReg.DataSource = cnx.ds.Tables("registrado")
        End If
    End Sub

End Class
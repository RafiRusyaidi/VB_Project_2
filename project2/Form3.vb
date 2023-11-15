Imports MySql.Data.MySqlClient

Public Class frmEdit
    Dim getId As String
    Sub MySqlConn()
        Dim ConnString As String = "server=localhost; user=root; port=3306; database=vb_project_2"
        Dim Conn As New MySqlConnection(ConnString)
    End Sub
    Sub New(val1 As String, val2 As String, val3 As String, val4 As String, val5 As String, val6 As String, val7 As String, val8 As String)

        InitializeComponent()
        getId = val1
        txtName.Text = val2
        txtNoTel.Text = val3
        txtEmail.Text = val4
        txtAddress.Text = val5

        If val6 = "M" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If

        txtUsrname.Text = val7
        txtPassword.Text = val8

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim ConnString As String = "server=localhost; user=root; port=3306; database=vb_project_2"
        Dim Conn As New MySqlConnection(ConnString)
        Dim resultReply As DialogResult = MessageBox.Show("Are you sure want to edit the data?", "Edit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim id = getId
        Dim updName As String = txtName.Text
        Dim updNumTel As String = txtNoTel.Text
        Dim updEmail As String = txtEmail.Text
        Dim updAddress As String = txtAddress.Text
        Dim updGender As String
        Dim updUsrname As String = txtUsrname.Text
        Dim updPassword As String = txtPassword.Text
        If radMale.Checked Then
            updGender = "M"
        Else
            updGender = "F"
        End If

        Try
            If resultReply = DialogResult.Yes Then
                Conn.Open()
                Dim sql As String = "UPDATE staff_detail SET sname = @updName, numTel = @updNumTel, address = @updAddress, gender = @updGender, email = @updEmail, username = @updUsrname, password = @updPassword WHERE id = @id"
                Dim sqlCmd As New MySqlCommand(sql, Conn)
                sqlCmd.Parameters.AddWithValue("@updName", updName)
                sqlCmd.Parameters.AddWithValue("@updNumTel", updNumTel)
                sqlCmd.Parameters.AddWithValue("@updAddress", updAddress)
                sqlCmd.Parameters.AddWithValue("@updEmail", updEmail)
                sqlCmd.Parameters.AddWithValue("@updGender", updGender)
                sqlCmd.Parameters.AddWithValue("@updUsrname", updUsrname)
                sqlCmd.Parameters.AddWithValue("@updPassword", updPassword)
                sqlCmd.Parameters.AddWithValue("@id", id)

                sqlCmd.ExecuteNonQuery()
                MessageBox.Show("Data updated successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                frmRegister.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmRegister.Show()
    End Sub

End Class
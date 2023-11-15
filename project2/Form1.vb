Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim ConnString As String = "server=localhost; user=root;port=3306;database=vb_project_2"
    Sub MysqlConnCheck()
        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            MsgBox("Success")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ClearInput()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
    Sub MysqlLogin()
        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            Dim chckUsername = txtUsername.Text
            Dim chckPassword = txtPassword.Text
            Dim sql As String = "SELECT * FROM admin_table WHERE dept_username = @chckUsername AND dept_password = @chckPassword"
            Dim sqlCmd As New MySqlCommand(sql, Conn)
            sqlCmd.Parameters.AddWithValue("@chckUsername", chckUsername)
            sqlCmd.Parameters.AddWithValue("@chckPassword", chckPassword)

            Dim sqlRead As MySqlDataReader
            sqlRead = sqlCmd.ExecuteReader()

            Using sqlRead
                If sqlRead.HasRows Then
                    MessageBox.Show("Login Successfull", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInput()
                    frmRegister.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Login Failed", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInput()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub btnCheckConn_Click(sender As Object, e As EventArgs) Handles btnCheckConn.Click
        MysqlConnCheck()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MysqlLogin()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub
End Class

Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim Conn As MySqlConnection
    Dim sqlCmd As MySqlCommand
    Dim sqlRead As MySqlDataReader

    Sub MySqlConn()
        Dim ConnString As String = "server=localhost; user=root;port=3306;database=vb_project_2"
        Conn = New MySqlConnection(ConnString)
    End Sub
    Sub MysqlConnCheck()
        MySqlConn()
        Try
            Conn.Open()
            MsgBox("Success")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub MysqlLogin()
        MySqlConn()
        Try
            Conn.Open()
            Dim chckUsername = txtUsername.Text
            Dim chckPassword = txtPassword.Text
            Dim sql As String = "SELECT * FROM staff_detail WHERE username = @chckUsername AND password = @chckPassword"
            sqlCmd = New MySqlCommand(sql, Conn)
            sqlCmd.Parameters.AddWithValue("@chckUsername", chckUsername)
            sqlCmd.Parameters.AddWithValue("@chckPassword", chckPassword)
            sqlRead = sqlCmd.ExecuteReader()

            Using sqlRead
                If sqlRead.HasRows Then
                    MessageBox.Show("Login Successfull")
                    frmRegister.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Login Failed")
                End If
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Message)
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
End Class

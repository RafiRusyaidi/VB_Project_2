Imports MySql.Data.MySqlClient
Public Class frmLogin
    Sub MysqlConnCheck()
        Dim ConnString As String = "server=localhost; user=root;port=3306;database=vb_project_2"
        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            MsgBox("Success")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub MysqlLogin()
        Dim ConnString As String = "server=localhost; user=root;port=3306;database=vb_project_2"
        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            Dim chckUsername = txtUsername.Text
            Dim chckPassword = txtPassword.Text
            Dim sql As String = "SELECT * FROM staff_detail WHERE username = @chckUsername AND password = @chckPassword"
            Dim sqlCmd As New MySqlCommand(sql, Conn)
            sqlCmd.Parameters.AddWithValue("@chckUsername", chckUsername)
            sqlCmd.Parameters.AddWithValue("@chckPassword", chckPassword)

            Dim sqlRead As MySqlDataReader
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class

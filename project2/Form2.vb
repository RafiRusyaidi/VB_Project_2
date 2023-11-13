Imports MySql.Data.MySqlClient
Public Class frmRegister
    Dim Conn As MySqlConnection
    Dim sqlCmd As MySqlCommand

    Function MySqlConn() As MySqlConnection
        Dim ConnString As String = "server=localhost; user=root; port=3306; database=vb_project_2"
        Conn = New MySqlConnection(ConnString)
        Return Conn

    End Function

    Sub FillDataGridView()
        Conn = MySqlConn()
        Dim dataTable As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM staff_detail", Conn)
        Try

            Conn.Open()
            adapter.Fill(dataTable)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dataTable

            DataGridView1.Columns("id").DataPropertyName = "id"
            DataGridView1.Columns("sname").DataPropertyName = "sname"
            DataGridView1.Columns("numTel").DataPropertyName = "numTel"
            DataGridView1.Columns("address").DataPropertyName = "address"
            DataGridView1.Columns("gender").DataPropertyName = "gender"
            DataGridView1.Columns("email").DataPropertyName = "email"
            DataGridView1.Columns("username").DataPropertyName = "username"
            DataGridView1.Columns("password").DataPropertyName = "password"

        Catch ex As MySqlException
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            Conn.Close()
        End Try
    End Sub
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDataGridView()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try
            Conn.Open()
            Dim passId As String = DataGridView1.CurrentRow.Cells("id").Value.ToString
            Dim passName As String = DataGridView1.CurrentRow.Cells("sname").Value.ToString
            Dim passTel As String = DataGridView1.CurrentRow.Cells("numTel").Value.ToString
            Dim passAddr As String = DataGridView1.CurrentRow.Cells("address").Value.ToString
            Dim passGender As String = DataGridView1.CurrentRow.Cells("gender").Value.ToString
            Dim passEmail As String = DataGridView1.CurrentRow.Cells("email").Value.ToString
            Dim passUsrName As String = DataGridView1.CurrentRow.Cells("username").Value.ToString
            Dim passUsrPass As String = DataGridView1.CurrentRow.Cells("password").Value.ToString

            If DataGridView1.Columns(e.ColumnIndex).Name = "edit" Then
                Dim form3 As New Form3(passId, passName, passTel, passEmail, passAddr, passGender, passUsrName, passUsrPass)
                form3.Show()

            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "delete" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim sql As String = "DELETE FROM staff_detail WHERE id = @passId"

                    Dim cmd As New MySqlCommand(sql, Conn)
                    cmd.Parameters.AddWithValue("@passId", passId)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data deletion canceled.", "Delete Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Conn.Open()
            Dim addName As String = txtName.Text
            Dim addNoTel As Integer = Int(txtNoTel.Text)
            Dim addEmail As String = txtEmail.Text
            Dim addAddress As String = rtbAddress.Text
            Dim addGender As String
            Dim addUsername As String = txtUsrname.Text
            Dim addPassword As String = txtPassword.Text

            If radMale.Checked = True Then
                addGender = "M"
            Else
                addGender = "F"
            End If

            Dim sql As String = "INSERT INTO staff_detail (sname, numTel, address, gender, email, username, password) VALUES (@addName, @addNoTel, @addAddress, @addGender, @addEmail, @addUsername, @addPassword)"
            sqlCmd = New MySqlCommand(sql, Conn)

            ' Add parameters to the command
            sqlCmd.Parameters.AddWithValue("@addName", addName)
            sqlCmd.Parameters.AddWithValue("@addNoTel", addNoTel)
            sqlCmd.Parameters.AddWithValue("@addAddress", addAddress)
            sqlCmd.Parameters.AddWithValue("@addGender", addGender)
            sqlCmd.Parameters.AddWithValue("@addEmail", addEmail)
            sqlCmd.Parameters.AddWithValue("@addUsername", addUsername)
            sqlCmd.Parameters.AddWithValue("@addPassword", addPassword)

            ' Execute the INSERT command

            sqlCmd.ExecuteNonQuery()

            MsgBox("Data inserted successfully.")
            FillDataGridView()
        Catch ex As Exception
            MsgBox($"Error executing SQL command: {ex.Message}{Environment.NewLine}{ex.StackTrace}")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FillDataGridView()
    End Sub
End Class
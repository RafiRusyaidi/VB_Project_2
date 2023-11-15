Imports MySql.Data.MySqlClient
Public Class frmRegister
    Dim ConnString As String = "server=localhost; user=root; port=3306; database=vb_project_2"
    Dim sql As String
    Sub ClearInput()
        txtName.Clear()
        txtNoTel.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        radMale.Checked = False
        radFemale.Checked = False
    End Sub

    Sub FillDataGridView()
        Dim Conn As New MySqlConnection(ConnString)
        sql = "SELECT * FROM staff_table"
        Dim dataTable As New DataTable()
        Dim adapter As New MySqlDataAdapter(sql, Conn)
        Try

            Conn.Open()
            adapter.Fill(dataTable)
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dataTable

            Dim rowNumber As Integer = 1
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Cells("num").Value = (i + 1).ToString()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            Dim passId As String = DataGridView1.CurrentRow.Cells("id").Value.ToString
            Dim passName As String = DataGridView1.CurrentRow.Cells("sname").Value.ToString
            Dim passTel As String = DataGridView1.CurrentRow.Cells("numTel").Value.ToString
            Dim passAddr As String = DataGridView1.CurrentRow.Cells("address").Value.ToString
            Dim passGender As String = DataGridView1.CurrentRow.Cells("gender").Value.ToString
            Dim passEmail As String = DataGridView1.CurrentRow.Cells("email").Value.ToString


            If DataGridView1.Columns(e.ColumnIndex).Name = "edit" Then
                Dim editForm As New frmEdit(passId, passName, passTel, passEmail, passAddr, passGender)
                editForm.Show()
                'buka form3 atau frmEdit punya form

            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "delete" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    sql = "DELETE FROM staff_table WHERE id = @passId" 'akan delete data ikut id

                    Dim sqlCmd As New MySqlCommand(sql, Conn)
                    sqlCmd.Parameters.AddWithValue("@passId", passId)

                    sqlCmd.ExecuteNonQuery()
                    MessageBox.Show("Data deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FillDataGridView()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Conn As New MySqlConnection(ConnString)
        Try
            Conn.Open()
            Dim addName As String = txtName.Text
            Dim addNoTel As Integer = Int(txtNoTel.Text)
            Dim addEmail As String = txtEmail.Text
            Dim addAddress As String = txtAddress.Text
            Dim addGender As String

            If radMale.Checked = True Then
                addGender = "M"
            Else
                addGender = "F"
            End If

            sql = "INSERT INTO staff_table (sname, numTel, address, gender, email) VALUES (@addName, @addNoTel, @addAddress, @addGender, @addEmail)"
            Dim sqlCmd As New MySqlCommand(sql, Conn)

            sqlCmd.Parameters.AddWithValue("@addName", addName)
            sqlCmd.Parameters.AddWithValue("@addNoTel", addNoTel)
            sqlCmd.Parameters.AddWithValue("@addAddress", addAddress)
            sqlCmd.Parameters.AddWithValue("@addGender", addGender)
            sqlCmd.Parameters.AddWithValue("@addEmail", addEmail)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInput()
            FillDataGridView()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDataGridView()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FillDataGridView()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class
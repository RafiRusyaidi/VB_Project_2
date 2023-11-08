Public Class frmLogin
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim secondForm As New frmRegister()
        secondForm.Show()
    End Sub
End Class

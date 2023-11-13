<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCheckConn = New Button()
        btnClear = New Button()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' btnCheckConn
        ' 
        btnCheckConn.Location = New Point(406, 360)
        btnCheckConn.Name = "btnCheckConn"
        btnCheckConn.Size = New Size(112, 34)
        btnCheckConn.TabIndex = 0
        btnCheckConn.Text = "Check Conn"
        btnCheckConn.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(250, 360)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(85, 360)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(241, 51)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 25)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username : "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(241, 192)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(101, 25)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password : "
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(202, 109)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "enter username here"
        txtUsername.Size = New Size(187, 31)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(202, 247)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "enter password here"
        txtPassword.Size = New Size(187, 31)
        txtPassword.TabIndex = 6
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(590, 450)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnLogin)
        Controls.Add(btnClear)
        Controls.Add(btnCheckConn)
        Name = "frmLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheckConn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class

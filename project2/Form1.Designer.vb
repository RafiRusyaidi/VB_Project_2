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
        lblTitle = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnClear = New Button()
        btnRegister = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(115, 41)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(338, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Welcome to Login"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.Location = New Point(86, 161)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(108, 28)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(86, 234)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(102, 28)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(200, 161)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Your Username"
        txtUsername.Size = New Size(211, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(200, 234)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter Your Password"
        txtPassword.Size = New Size(211, 31)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(86, 312)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(233, 312)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(377, 312)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(112, 34)
        btnRegister.TabIndex = 7
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(590, 450)
        Controls.Add(btnRegister)
        Controls.Add(btnClear)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblTitle)
        Name = "frmLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button
End Class

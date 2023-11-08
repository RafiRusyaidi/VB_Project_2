<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblUsername = New Label()
        lblPassword = New Label()
        lblEmail = New Label()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnOK = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(101, 49)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(390, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Welcome to Register"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(89, 130)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 28)
        lblName.TabIndex = 1
        lblName.Text = "Name :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(240, 130)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter Your Name"
        txtName.Size = New Size(228, 31)
        txtName.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.Location = New Point(89, 226)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(108, 28)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(89, 276)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(102, 28)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password :"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(89, 177)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(68, 28)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(240, 177)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Your Email"
        txtEmail.Size = New Size(228, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(240, 226)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Your Username"
        txtUsername.Size = New Size(228, 31)
        txtUsername.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(240, 276)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter Your Password"
        txtPassword.Size = New Size(228, 31)
        txtPassword.TabIndex = 8
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(129, 347)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(112, 34)
        btnOK.TabIndex = 9
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(305, 347)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 10
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 450)
        Controls.Add(btnClear)
        Controls.Add(btnOK)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Name = "frmRegister"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnClear As Button
End Class

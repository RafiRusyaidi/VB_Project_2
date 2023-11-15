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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmLogin))
        btnCheckConn = New Button()
        btnClear = New Button()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lblLogin = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCheckConn
        ' 
        btnCheckConn.Location = New Point(436, 215)
        btnCheckConn.Margin = New Padding(2)
        btnCheckConn.Name = "btnCheckConn"
        btnCheckConn.Size = New Size(94, 40)
        btnCheckConn.TabIndex = 5
        btnCheckConn.Text = "C&heck Conn"
        btnCheckConn.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(329, 215)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 40)
        btnClear.TabIndex = 4
        btnClear.Text = "&Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(222, 215)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 40)
        btnLogin.TabIndex = 3
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.Location = New Point(257, 72)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(121, 28)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username : "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.Location = New Point(257, 151)
        lblPassword.Margin = New Padding(2, 0, 2, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(114, 28)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password : "
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(382, 72)
        txtUsername.Margin = New Padding(2)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = " enter username here"
        txtUsername.Size = New Size(183, 31)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(382, 151)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = " enter password here"
        txtPassword.Size = New Size(183, 31)
        txtPassword.TabIndex = 2
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogin.Location = New Point(216, 19)
        lblLogin.Margin = New Padding(2, 0, 2, 0)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(83, 31)
        lblLogin.TabIndex = 41
        lblLogin.Text = "LOGIN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-24, -16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(278, 271)
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(607, 286)
        Controls.Add(lblLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnLogin)
        Controls.Add(btnClear)
        Controls.Add(btnCheckConn)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "frmLogin"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblLogin As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

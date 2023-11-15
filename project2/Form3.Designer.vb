<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        radFemale = New RadioButton()
        radMale = New RadioButton()
        txtPassword = New TextBox()
        txtUsrname = New TextBox()
        txtEmail = New TextBox()
        txtNoTel = New TextBox()
        txtName = New TextBox()
        lblPass = New Label()
        lblusrname = New Label()
        lblEmail = New Label()
        lblGender = New Label()
        lblAddress = New Label()
        lblNoTel = New Label()
        lblName = New Label()
        lblEditForm = New Label()
        btnConfirm = New Button()
        btnCancel = New Button()
        txtAddress = New TextBox()
        SuspendLayout()
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.Location = New Point(381, 124)
        radFemale.Margin = New Padding(2)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(78, 24)
        radFemale.TabIndex = 24
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(316, 124)
        radMale.Margin = New Padding(2)
        radMale.Name = "radMale"
        radMale.Size = New Size(63, 24)
        radMale.TabIndex = 23
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(316, 262)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(121, 27)
        txtPassword.TabIndex = 26
        ' 
        ' txtUsrname
        ' 
        txtUsrname.Location = New Point(316, 194)
        txtUsrname.Margin = New Padding(2)
        txtUsrname.Name = "txtUsrname"
        txtUsrname.Size = New Size(121, 27)
        txtUsrname.TabIndex = 25
        ' 
        ' txtEmail
        ' 
        txtEmail.CharacterCasing = CharacterCasing.Lower
        txtEmail.Location = New Point(44, 266)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(226, 27)
        txtEmail.TabIndex = 21
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(44, 190)
        txtNoTel.Margin = New Padding(2)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(226, 27)
        txtNoTel.TabIndex = 20
        ' 
        ' txtName
        ' 
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.Location = New Point(44, 121)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.Size = New Size(226, 27)
        txtName.TabIndex = 19
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(316, 239)
        lblPass.Margin = New Padding(2, 0, 2, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(81, 20)
        lblPass.TabIndex = 30
        lblPass.Text = "Password : "
        ' 
        ' lblusrname
        ' 
        lblusrname.AutoSize = True
        lblusrname.Location = New Point(316, 165)
        lblusrname.Margin = New Padding(2, 0, 2, 0)
        lblusrname.Name = "lblusrname"
        lblusrname.Size = New Size(86, 20)
        lblusrname.TabIndex = 29
        lblusrname.Text = "Username : "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(43, 243)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 20)
        lblEmail.TabIndex = 28
        lblEmail.Text = "Email : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(316, 90)
        lblGender.Margin = New Padding(2, 0, 2, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(78, 20)
        lblGender.TabIndex = 26
        lblGender.Text = "Gender : - "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(43, 315)
        lblAddress.Margin = New Padding(2, 0, 2, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(73, 20)
        lblAddress.TabIndex = 25
        lblAddress.Text = "Address : "
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(43, 168)
        lblNoTel.Margin = New Padding(2, 0, 2, 0)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(66, 20)
        lblNoTel.TabIndex = 24
        lblNoTel.Text = "No. Tel : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(43, 91)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 20)
        lblName.TabIndex = 23
        lblName.Text = "Name : "
        ' 
        ' lblEditForm
        ' 
        lblEditForm.AutoSize = True
        lblEditForm.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEditForm.Location = New Point(10, 15)
        lblEditForm.Margin = New Padding(2, 0, 2, 0)
        lblEditForm.Name = "lblEditForm"
        lblEditForm.Size = New Size(114, 28)
        lblEditForm.TabIndex = 40
        lblEditForm.Text = "EDIT FORM"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(129, 502)
        btnConfirm.Margin = New Padding(2)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(90, 27)
        btnConfirm.TabIndex = 27
        btnConfirm.Text = "&Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(282, 502)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 27)
        btnCancel.TabIndex = 28
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.CharacterCasing = CharacterCasing.Upper
        txtAddress.Location = New Point(44, 338)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(226, 116)
        txtAddress.TabIndex = 22
        ' 
        ' frmEdit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 570)
        Controls.Add(txtAddress)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(lblEditForm)
        Controls.Add(radFemale)
        Controls.Add(radMale)
        Controls.Add(txtPassword)
        Controls.Add(txtUsrname)
        Controls.Add(txtEmail)
        Controls.Add(txtNoTel)
        Controls.Add(txtName)
        Controls.Add(lblPass)
        Controls.Add(lblusrname)
        Controls.Add(lblEmail)
        Controls.Add(lblGender)
        Controls.Add(lblAddress)
        Controls.Add(lblNoTel)
        Controls.Add(lblName)
        Margin = New Padding(2)
        Name = "frmEdit"
        Text = "Edit Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsrname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblusrname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEditForm As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtAddress As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        rtbAddress = New RichTextBox()
        txtPassword = New TextBox()
        txtUsrname = New TextBox()
        txtEmail = New TextBox()
        txtNoTel = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        lblPass = New Label()
        lblusrname = New Label()
        lblEmail = New Label()
        lblGender = New Label()
        lblAddress = New Label()
        lblNoTel = New Label()
        lblName = New Label()
        lblID = New Label()
        lblEditForm = New Label()
        btnConfirm = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.Location = New Point(476, 155)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(93, 29)
        radFemale.TabIndex = 39
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(395, 155)
        radMale.Name = "radMale"
        radMale.Size = New Size(75, 29)
        radMale.TabIndex = 38
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' rtbAddress
        ' 
        rtbAddress.Location = New Point(56, 477)
        rtbAddress.Name = "rtbAddress"
        rtbAddress.Size = New Size(282, 104)
        rtbAddress.TabIndex = 37
        rtbAddress.Text = ""
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(395, 327)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 36
        ' 
        ' txtUsrname
        ' 
        txtUsrname.Location = New Point(395, 243)
        txtUsrname.Name = "txtUsrname"
        txtUsrname.Size = New Size(150, 31)
        txtUsrname.TabIndex = 35
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(56, 387)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(282, 31)
        txtEmail.TabIndex = 34
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(56, 293)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(282, 31)
        txtNoTel.TabIndex = 33
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(56, 206)
        txtName.Name = "txtName"
        txtName.Size = New Size(282, 31)
        txtName.TabIndex = 32
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(105, 113)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.ShortcutsEnabled = False
        txtID.Size = New Size(79, 31)
        txtID.TabIndex = 31
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(395, 299)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(101, 25)
        lblPass.TabIndex = 30
        lblPass.Text = "Password : "
        ' 
        ' lblusrname
        ' 
        lblusrname.AutoSize = True
        lblusrname.Location = New Point(395, 206)
        lblusrname.Name = "lblusrname"
        lblusrname.Size = New Size(105, 25)
        lblusrname.TabIndex = 29
        lblusrname.Text = "Username : "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(55, 359)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(68, 25)
        lblEmail.TabIndex = 28
        lblEmail.Text = "Email : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(395, 113)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(95, 25)
        lblGender.TabIndex = 26
        lblGender.Text = "Gender : - "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(55, 449)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(91, 25)
        lblAddress.TabIndex = 25
        lblAddress.Text = "Address : "
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(55, 265)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(79, 25)
        lblNoTel.TabIndex = 24
        lblNoTel.Text = "No. Tel : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(55, 169)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 25)
        lblName.TabIndex = 23
        lblName.Text = "Name : "
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(55, 113)
        lblID.Name = "lblID"
        lblID.Size = New Size(44, 25)
        lblID.TabIndex = 22
        lblID.Text = "ID : "
        ' 
        ' lblEditForm
        ' 
        lblEditForm.AutoSize = True
        lblEditForm.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEditForm.Location = New Point(12, 19)
        lblEditForm.Name = "lblEditForm"
        lblEditForm.Size = New Size(137, 32)
        lblEditForm.TabIndex = 40
        lblEditForm.Text = "EDIT FORM"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(161, 627)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(112, 34)
        btnConfirm.TabIndex = 41
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(352, 627)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 42
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 713)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(lblEditForm)
        Controls.Add(radFemale)
        Controls.Add(radMale)
        Controls.Add(rtbAddress)
        Controls.Add(txtPassword)
        Controls.Add(txtUsrname)
        Controls.Add(txtEmail)
        Controls.Add(txtNoTel)
        Controls.Add(txtName)
        Controls.Add(txtID)
        Controls.Add(lblPass)
        Controls.Add(lblusrname)
        Controls.Add(lblEmail)
        Controls.Add(lblGender)
        Controls.Add(lblAddress)
        Controls.Add(lblNoTel)
        Controls.Add(lblName)
        Controls.Add(lblID)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents rtbAddress As RichTextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsrname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblusrname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblEditForm As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
End Class

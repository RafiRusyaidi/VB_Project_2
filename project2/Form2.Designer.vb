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
        DataGridView1 = New DataGridView()
        num = New DataGridViewTextBoxColumn()
        id = New DataGridViewTextBoxColumn()
        sname = New DataGridViewTextBoxColumn()
        numTel = New DataGridViewTextBoxColumn()
        address = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        password = New DataGridViewTextBoxColumn()
        edit = New DataGridViewButtonColumn()
        delete = New DataGridViewButtonColumn()
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
        btnAdd = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        lblPrompt1 = New Label()
        lblRegisterForm = New Label()
        btnLogout = New Button()
        txtAddress = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {num, id, sname, numTel, address, gender, email, username, password, edit, delete})
        DataGridView1.Location = New Point(30, 475)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(654, 222)
        DataGridView1.TabIndex = 17
        ' 
        ' num
        ' 
        num.HeaderText = "No"
        num.MinimumWidth = 8
        num.Name = "num"
        num.Width = 40
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "ID"
        id.MinimumWidth = 6
        id.Name = "id"
        id.Visible = False
        id.Width = 10
        ' 
        ' sname
        ' 
        sname.DataPropertyName = "sname"
        sname.HeaderText = "Name"
        sname.MinimumWidth = 8
        sname.Name = "sname"
        sname.Width = 150
        ' 
        ' numTel
        ' 
        numTel.DataPropertyName = "numTel"
        numTel.HeaderText = "Phone Number"
        numTel.MinimumWidth = 8
        numTel.Name = "numTel"
        numTel.Width = 150
        ' 
        ' address
        ' 
        address.DataPropertyName = "address"
        address.HeaderText = "Address"
        address.MinimumWidth = 8
        address.Name = "address"
        address.Width = 150
        ' 
        ' gender
        ' 
        gender.DataPropertyName = "gender"
        gender.HeaderText = "Gender"
        gender.MinimumWidth = 8
        gender.Name = "gender"
        gender.Width = 70
        ' 
        ' email
        ' 
        email.DataPropertyName = "email"
        email.HeaderText = "Email"
        email.MinimumWidth = 8
        email.Name = "email"
        email.Width = 150
        ' 
        ' username
        ' 
        username.DataPropertyName = "username"
        username.HeaderText = "Username"
        username.MinimumWidth = 8
        username.Name = "username"
        username.Width = 150
        ' 
        ' password
        ' 
        password.DataPropertyName = "password"
        password.HeaderText = "Password"
        password.MinimumWidth = 8
        password.Name = "password"
        password.Width = 150
        ' 
        ' edit
        ' 
        edit.HeaderText = "Edit"
        edit.MinimumWidth = 8
        edit.Name = "edit"
        edit.Text = "edit"
        edit.UseColumnTextForButtonValue = True
        edit.Width = 70
        ' 
        ' delete
        ' 
        delete.HeaderText = "Delete"
        delete.MinimumWidth = 8
        delete.Name = "delete"
        delete.Text = "delete"
        delete.UseColumnTextForButtonValue = True
        delete.Width = 70
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.Location = New Point(440, 119)
        radFemale.Margin = New Padding(2)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(78, 24)
        radFemale.TabIndex = 11
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(375, 119)
        radMale.Margin = New Padding(2)
        radMale.Name = "radMale"
        radMale.Size = New Size(63, 24)
        radMale.TabIndex = 10
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(375, 262)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(121, 27)
        txtPassword.TabIndex = 13
        ' 
        ' txtUsrname
        ' 
        txtUsrname.Location = New Point(375, 187)
        txtUsrname.Margin = New Padding(2)
        txtUsrname.Name = "txtUsrname"
        txtUsrname.Size = New Size(121, 27)
        txtUsrname.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.CharacterCasing = CharacterCasing.Lower
        txtEmail.Location = New Point(90, 260)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(226, 27)
        txtEmail.TabIndex = 8
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(90, 185)
        txtNoTel.Margin = New Padding(2)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(226, 27)
        txtNoTel.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.Location = New Point(90, 116)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.Size = New Size(226, 27)
        txtName.TabIndex = 6
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(375, 238)
        lblPass.Margin = New Padding(2, 0, 2, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(81, 20)
        lblPass.TabIndex = 47
        lblPass.Text = "Password : "
        ' 
        ' lblusrname
        ' 
        lblusrname.AutoSize = True
        lblusrname.Location = New Point(375, 165)
        lblusrname.Margin = New Padding(2, 0, 2, 0)
        lblusrname.Name = "lblusrname"
        lblusrname.Size = New Size(86, 20)
        lblusrname.TabIndex = 46
        lblusrname.Text = "Username : "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(89, 238)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 20)
        lblEmail.TabIndex = 45
        lblEmail.Text = "Email : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(375, 94)
        lblGender.Margin = New Padding(2, 0, 2, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(78, 20)
        lblGender.TabIndex = 44
        lblGender.Text = "Gender : - "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(89, 310)
        lblAddress.Margin = New Padding(2, 0, 2, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(73, 20)
        lblAddress.TabIndex = 43
        lblAddress.Text = "Address : "
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(89, 163)
        lblNoTel.Margin = New Padding(2, 0, 2, 0)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(66, 20)
        lblNoTel.TabIndex = 42
        lblNoTel.Text = "No. Tel : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(89, 94)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 20)
        lblName.TabIndex = 41
        lblName.Text = "Name : "
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(564, 185)
        btnAdd.Margin = New Padding(2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 39)
        btnAdd.TabIndex = 14
        btnAdd.Text = "&ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(564, 260)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 39)
        btnClear.TabIndex = 15
        btnClear.Text = "&CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(564, 436)
        btnRefresh.Margin = New Padding(2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(120, 34)
        btnRefresh.TabIndex = 16
        btnRefresh.Text = "&Refresh Table"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblPrompt1
        ' 
        lblPrompt1.AutoSize = True
        lblPrompt1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrompt1.Location = New Point(28, 447)
        lblPrompt1.Name = "lblPrompt1"
        lblPrompt1.Size = New Size(200, 23)
        lblPrompt1.TabIndex = 60
        lblPrompt1.Text = "View - Edit - Delete Data"
        ' 
        ' lblRegisterForm
        ' 
        lblRegisterForm.AutoSize = True
        lblRegisterForm.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRegisterForm.Location = New Point(28, 24)
        lblRegisterForm.Margin = New Padding(2, 0, 2, 0)
        lblRegisterForm.Name = "lblRegisterForm"
        lblRegisterForm.Size = New Size(159, 28)
        lblRegisterForm.TabIndex = 61
        lblRegisterForm.Text = "REGISTER FORM"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(564, 18)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 34)
        btnLogout.TabIndex = 18
        btnLogout.Text = "&Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.CharacterCasing = CharacterCasing.Upper
        txtAddress.Location = New Point(90, 333)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(226, 84)
        txtAddress.TabIndex = 9
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(715, 724)
        Controls.Add(txtAddress)
        Controls.Add(btnLogout)
        Controls.Add(lblRegisterForm)
        Controls.Add(lblPrompt1)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
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
        Controls.Add(DataGridView1)
        Margin = New Padding(2)
        Name = "frmRegister"
        Text = "Register"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents lblRegisterForm As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents sname As DataGridViewTextBoxColumn
    Friend WithEvents numTel As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class

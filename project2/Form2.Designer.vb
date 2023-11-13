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
        rtbAddress = New RichTextBox()
        txtPassword = New TextBox()
        txtUsrname = New TextBox()
        txtEmail = New TextBox()
        txtNoTel = New TextBox()
        txtName = New TextBox()
        txtId = New TextBox()
        lblPass = New Label()
        lblusrname = New Label()
        lblEmail = New Label()
        lblGender = New Label()
        lblAddress = New Label()
        lblNoTel = New Label()
        lblName = New Label()
        lblID = New Label()
        btnAdd = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, sname, numTel, address, gender, email, username, password, edit, delete})
        DataGridView1.Location = New Point(25, 624)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(865, 278)
        DataGridView1.TabIndex = 1
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.MinimumWidth = 8
        id.Name = "id"
        id.Width = 50
        ' 
        ' sname
        ' 
        sname.HeaderText = "Name"
        sname.MinimumWidth = 8
        sname.Name = "sname"
        sname.Width = 150
        ' 
        ' numTel
        ' 
        numTel.HeaderText = "Phone Number"
        numTel.MinimumWidth = 8
        numTel.Name = "numTel"
        numTel.Width = 150
        ' 
        ' address
        ' 
        address.HeaderText = "Address"
        address.MinimumWidth = 8
        address.Name = "address"
        address.Width = 150
        ' 
        ' gender
        ' 
        gender.HeaderText = "Gender"
        gender.MinimumWidth = 8
        gender.Name = "gender"
        gender.Width = 150
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.MinimumWidth = 8
        email.Name = "email"
        email.Width = 150
        ' 
        ' username
        ' 
        username.HeaderText = "Username"
        username.MinimumWidth = 8
        username.Name = "username"
        username.Width = 150
        ' 
        ' password
        ' 
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
        radFemale.Location = New Point(539, 146)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(93, 29)
        radFemale.TabIndex = 56
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(458, 146)
        radMale.Name = "radMale"
        radMale.Size = New Size(75, 29)
        radMale.TabIndex = 55
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' rtbAddress
        ' 
        rtbAddress.Location = New Point(119, 468)
        rtbAddress.Name = "rtbAddress"
        rtbAddress.Size = New Size(282, 104)
        rtbAddress.TabIndex = 54
        rtbAddress.Text = ""
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(458, 319)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 53
        ' 
        ' txtUsrname
        ' 
        txtUsrname.Location = New Point(458, 223)
        txtUsrname.Name = "txtUsrname"
        txtUsrname.Size = New Size(150, 31)
        txtUsrname.TabIndex = 52
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(119, 378)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(282, 31)
        txtEmail.TabIndex = 51
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(119, 284)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(282, 31)
        txtNoTel.TabIndex = 50
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(119, 197)
        txtName.Name = "txtName"
        txtName.Size = New Size(282, 31)
        txtName.TabIndex = 49
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(168, 104)
        txtId.Name = "txtId"
        txtId.ReadOnly = True
        txtId.ShortcutsEnabled = False
        txtId.Size = New Size(79, 31)
        txtId.TabIndex = 48
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(458, 291)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(101, 25)
        lblPass.TabIndex = 47
        lblPass.Text = "Password : "
        ' 
        ' lblusrname
        ' 
        lblusrname.AutoSize = True
        lblusrname.Location = New Point(458, 195)
        lblusrname.Name = "lblusrname"
        lblusrname.Size = New Size(105, 25)
        lblusrname.TabIndex = 46
        lblusrname.Text = "Username : "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(118, 350)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(68, 25)
        lblEmail.TabIndex = 45
        lblEmail.Text = "Email : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(458, 104)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(95, 25)
        lblGender.TabIndex = 44
        lblGender.Text = "Gender : - "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(118, 440)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(91, 25)
        lblAddress.TabIndex = 43
        lblAddress.Text = "Address : "
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(118, 256)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(79, 25)
        lblNoTel.TabIndex = 42
        lblNoTel.Text = "No. Tel : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(118, 160)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 25)
        lblName.TabIndex = 41
        lblName.Text = "Name : "
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(118, 104)
        lblID.Name = "lblID"
        lblID.Size = New Size(44, 25)
        lblID.TabIndex = 40
        lblID.Text = "ID : "
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(673, 223)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 49)
        btnAdd.TabIndex = 57
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(673, 301)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 49)
        btnClear.TabIndex = 58
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(673, 537)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(150, 35)
        btnRefresh.TabIndex = 59
        btnRefresh.Text = "Refresh Table"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 929)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(radFemale)
        Controls.Add(radMale)
        Controls.Add(rtbAddress)
        Controls.Add(txtPassword)
        Controls.Add(txtUsrname)
        Controls.Add(txtEmail)
        Controls.Add(txtNoTel)
        Controls.Add(txtName)
        Controls.Add(txtId)
        Controls.Add(lblPass)
        Controls.Add(lblusrname)
        Controls.Add(lblEmail)
        Controls.Add(lblGender)
        Controls.Add(lblAddress)
        Controls.Add(lblNoTel)
        Controls.Add(lblName)
        Controls.Add(lblID)
        Controls.Add(DataGridView1)
        Name = "frmRegister"
        Text = "Register"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents rtbAddress As RichTextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsrname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblusrname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
End Class

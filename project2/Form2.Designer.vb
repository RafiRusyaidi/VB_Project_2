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
        edit = New DataGridViewButtonColumn()
        delete = New DataGridViewButtonColumn()
        radFemale = New RadioButton()
        radMale = New RadioButton()
        txtEmail = New TextBox()
        txtNoTel = New TextBox()
        txtName = New TextBox()
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {num, id, sname, numTel, address, gender, email, edit, delete})
        DataGridView1.Location = New Point(30, 401)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(654, 222)
        DataGridView1.TabIndex = 15
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
        radFemale.Location = New Point(405, 101)
        radFemale.Margin = New Padding(2)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(78, 24)
        radFemale.TabIndex = 10
        radFemale.TabStop = True
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = True
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.Location = New Point(340, 101)
        radMale.Margin = New Padding(2)
        radMale.Name = "radMale"
        radMale.Size = New Size(63, 24)
        radMale.TabIndex = 9
        radMale.TabStop = True
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.CharacterCasing = CharacterCasing.Lower
        txtEmail.Location = New Point(340, 167)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(172, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(73, 167)
        txtNoTel.Margin = New Padding(2)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(226, 27)
        txtNoTel.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.Location = New Point(73, 98)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.Size = New Size(226, 27)
        txtName.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(339, 145)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 20)
        lblEmail.TabIndex = 45
        lblEmail.Text = "Email : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(340, 76)
        lblGender.Margin = New Padding(2, 0, 2, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(78, 20)
        lblGender.TabIndex = 44
        lblGender.Text = "Gender : - "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(71, 208)
        lblAddress.Margin = New Padding(2, 0, 2, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(73, 20)
        lblAddress.TabIndex = 43
        lblAddress.Text = "Address : "
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(72, 145)
        lblNoTel.Margin = New Padding(2, 0, 2, 0)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(66, 20)
        lblNoTel.TabIndex = 42
        lblNoTel.Text = "No. Tel : "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(72, 76)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 20)
        lblName.TabIndex = 41
        lblName.Text = "Name : "
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(564, 167)
        btnAdd.Margin = New Padding(2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 39)
        btnAdd.TabIndex = 12
        btnAdd.Text = "&ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(564, 242)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 39)
        btnClear.TabIndex = 13
        btnClear.Text = "&CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(564, 362)
        btnRefresh.Margin = New Padding(2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(120, 34)
        btnRefresh.TabIndex = 14
        btnRefresh.Text = "&Refresh Table"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblPrompt1
        ' 
        lblPrompt1.AutoSize = True
        lblPrompt1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrompt1.Location = New Point(28, 373)
        lblPrompt1.Name = "lblPrompt1"
        lblPrompt1.Size = New Size(200, 23)
        lblPrompt1.TabIndex = 60
        lblPrompt1.Text = "View - Edit - Delete Data"
        ' 
        ' lblRegisterForm
        ' 
        lblRegisterForm.AutoSize = True
        lblRegisterForm.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRegisterForm.Location = New Point(11, 24)
        lblRegisterForm.Margin = New Padding(2, 0, 2, 0)
        lblRegisterForm.Name = "lblRegisterForm"
        lblRegisterForm.Size = New Size(159, 28)
        lblRegisterForm.TabIndex = 61
        lblRegisterForm.Text = "REGISTER FORM"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(564, 24)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 34)
        btnLogout.TabIndex = 16
        btnLogout.Text = "&Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.CharacterCasing = CharacterCasing.Upper
        txtAddress.Location = New Point(72, 231)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(227, 83)
        txtAddress.TabIndex = 8
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(715, 634)
        Controls.Add(txtAddress)
        Controls.Add(btnLogout)
        Controls.Add(lblRegisterForm)
        Controls.Add(lblPrompt1)
        Controls.Add(btnRefresh)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(radFemale)
        Controls.Add(radMale)
        Controls.Add(txtEmail)
        Controls.Add(txtNoTel)
        Controls.Add(txtName)
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
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTel As TextBox
    Friend WithEvents txtName As TextBox
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
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class

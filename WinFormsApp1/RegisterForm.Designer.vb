<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        pnlCard = New RoundedPanel()
        lblMessage = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        pnlUsername = New RoundedPanel()
        txtUsername = New TextBox()
        pnlFullName = New RoundedPanel()
        txtFullName = New TextBox()
        Label2 = New Label()
        Username = New Label()
        btnBack = New RoundedButton()
        btnRegister = New RoundedButton()
        pnlPassword = New RoundedPanel()
        txtPassword = New TextBox()
        lblEyePwd = New Label()
        pnlConfirmPassword = New RoundedPanel()
        txtConfirmPassword = New TextBox()
        lblEyeConfirm = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        pnlRole = New RoundedPanel()
        cmbRole = New ComboBox()
        pnlInfoIcon = New RoundedPanel()
        lblInfoGlyph = New Label()
        lblHelp = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.BorderColor = Color.FromArgb(228, 232, 240)
        pnlCard.BorderThickness = 1
        pnlCard.Controls.Add(lblHelp)
        pnlCard.Controls.Add(pnlInfoIcon)
        pnlCard.Controls.Add(btnRegister)
        pnlCard.Controls.Add(pnlRole)
        pnlCard.Controls.Add(Label7)
        pnlCard.Controls.Add(Label6)
        pnlCard.Controls.Add(Label5)
        pnlCard.Controls.Add(pnlConfirmPassword)
        pnlCard.Controls.Add(pnlPassword)
        pnlCard.Controls.Add(lblMessage)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.Controls.Add(Label3)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(pnlUsername)
        pnlCard.Controls.Add(pnlFullName)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Username)
        pnlCard.Controls.Add(btnBack)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(50, 50)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1080, 740)
        pnlCard.TabIndex = 0
        '
        ' lblMessage
        '
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Segoe UI", 11.0F)
        lblMessage.ForeColor = Color.FromArgb(200, 50, 50)
        lblMessage.Location = New Point(200, 635)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 22
        '
        ' Label4
        '
        Label4.AutoSize = False
        Label4.BackColor = Color.FromArgb(228, 232, 240)
        Label4.Location = New Point(50, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(980, 1)
        Label4.TabIndex = 21
        Label4.Text = ""
        '
        ' PictureBox1
        '
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(120, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 160)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        '
        ' Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(110, 120, 140)
        Label3.Location = New Point(320, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 30)
        Label3.TabIndex = 19
        Label3.Text = "Create Your Account"
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(15, 34, 80)
        Label1.Location = New Point(315, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 18
        Label1.Text = "Booking System"
        '
        ' pnlUsername
        '
        pnlUsername.BackColor = Color.White
        pnlUsername.BorderColor = Color.FromArgb(190, 210, 240)
        pnlUsername.BorderThickness = 1
        pnlUsername.Controls.Add(txtUsername)
        pnlUsername.CornerRadius = 0
        pnlUsername.Location = New Point(380, 305)
        pnlUsername.Name = "pnlUsername"
        pnlUsername.Size = New Size(560, 48)
        pnlUsername.TabIndex = 17
        '
        ' txtUsername
        '
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12.0F)
        txtUsername.Location = New Point(18, 12)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your username"
        txtUsername.Size = New Size(524, 22)
        txtUsername.TabIndex = 0
        '
        ' pnlFullName
        '
        pnlFullName.BackColor = Color.White
        pnlFullName.BorderColor = Color.FromArgb(190, 210, 240)
        pnlFullName.BorderThickness = 1
        pnlFullName.Controls.Add(txtFullName)
        pnlFullName.CornerRadius = 0
        pnlFullName.Location = New Point(380, 245)
        pnlFullName.Name = "pnlFullName"
        pnlFullName.Size = New Size(560, 48)
        pnlFullName.TabIndex = 16
        '
        ' txtFullName
        '
        txtFullName.BackColor = Color.White
        txtFullName.BorderStyle = BorderStyle.None
        txtFullName.Font = New Font("Segoe UI", 12.0F)
        txtFullName.Location = New Point(18, 12)
        txtFullName.Name = "txtFullName"
        txtFullName.PlaceholderText = "Enter your full name"
        txtFullName.Size = New Size(524, 22)
        txtFullName.TabIndex = 0
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(40, 50, 70)
        Label2.Location = New Point(130, 435)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 24)
        Label2.TabIndex = 15
        Label2.Text = "Confirm Password"
        '
        ' Username
        '
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Username.ForeColor = Color.FromArgb(40, 50, 70)
        Username.Location = New Point(130, 315)
        Username.Name = "Username"
        Username.Size = New Size(94, 24)
        Username.TabIndex = 14
        Username.Text = "Username"
        '
        ' btnBack
        '
        btnBack.BackColor = Color.White
        btnBack.BorderColor = Color.FromArgb(37, 99, 235)
        btnBack.BorderThickness = 2
        btnBack.CornerRadius = 0
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(37, 99, 235)
        btnBack.IconFont = New Font("Segoe MDL2 Assets", 16.0F)
        btnBack.IconGlyph = ChrW(&HE72B)
        btnBack.Location = New Point(560, 555)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(320, 60)
        btnBack.TabIndex = 13
        btnBack.Text = "Back to Login"
        btnBack.UseVisualStyleBackColor = False
        '
        ' btnRegister
        '
        btnRegister.BackColor = Color.FromArgb(37, 99, 235)
        btnRegister.CornerRadius = 0
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.IconFont = New Font("Segoe MDL2 Assets", 16.0F)
        btnRegister.IconGlyph = ChrW(&HE8FA)
        btnRegister.Location = New Point(200, 555)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(320, 60)
        btnRegister.TabIndex = 12
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        '
        ' pnlPassword
        '
        pnlPassword.BackColor = Color.White
        pnlPassword.BorderColor = Color.FromArgb(190, 210, 240)
        pnlPassword.BorderThickness = 1
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.Controls.Add(lblEyePwd)
        pnlPassword.CornerRadius = 0
        pnlPassword.Location = New Point(380, 365)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(560, 48)
        pnlPassword.TabIndex = 23
        '
        ' txtPassword
        '
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12.0F)
        txtPassword.Location = New Point(18, 12)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(488, 22)
        txtPassword.TabIndex = 0
        '
        ' lblEyePwd
        '
        lblEyePwd.AutoSize = False
        lblEyePwd.BackColor = Color.Transparent
        lblEyePwd.Font = New Font("Segoe MDL2 Assets", 14.0F)
        lblEyePwd.ForeColor = Color.FromArgb(110, 120, 140)
        lblEyePwd.Location = New Point(518, 12)
        lblEyePwd.Name = "lblEyePwd"
        lblEyePwd.Size = New Size(30, 24)
        lblEyePwd.TabIndex = 1
        lblEyePwd.Text = ChrW(&HE7B3)
        lblEyePwd.TextAlign = ContentAlignment.MiddleCenter
        '
        ' pnlConfirmPassword
        '
        pnlConfirmPassword.BackColor = Color.White
        pnlConfirmPassword.BorderColor = Color.FromArgb(190, 210, 240)
        pnlConfirmPassword.BorderThickness = 1
        pnlConfirmPassword.Controls.Add(txtConfirmPassword)
        pnlConfirmPassword.Controls.Add(lblEyeConfirm)
        pnlConfirmPassword.CornerRadius = 0
        pnlConfirmPassword.Location = New Point(380, 425)
        pnlConfirmPassword.Name = "pnlConfirmPassword"
        pnlConfirmPassword.Size = New Size(560, 48)
        pnlConfirmPassword.TabIndex = 24
        '
        ' txtConfirmPassword
        '
        txtConfirmPassword.BackColor = Color.White
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 12.0F)
        txtConfirmPassword.Location = New Point(18, 12)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(488, 22)
        txtConfirmPassword.TabIndex = 0
        '
        ' lblEyeConfirm
        '
        lblEyeConfirm.AutoSize = False
        lblEyeConfirm.BackColor = Color.Transparent
        lblEyeConfirm.Font = New Font("Segoe MDL2 Assets", 14.0F)
        lblEyeConfirm.ForeColor = Color.FromArgb(110, 120, 140)
        lblEyeConfirm.Location = New Point(518, 12)
        lblEyeConfirm.Name = "lblEyeConfirm"
        lblEyeConfirm.Size = New Size(30, 24)
        lblEyeConfirm.TabIndex = 1
        lblEyeConfirm.Text = ChrW(&HE7B3)
        lblEyeConfirm.TextAlign = ContentAlignment.MiddleCenter
        '
        ' Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(40, 50, 70)
        Label5.Location = New Point(130, 375)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 24)
        Label5.TabIndex = 26
        Label5.Text = "Password"
        '
        ' Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(40, 50, 70)
        Label6.Location = New Point(130, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 24)
        Label6.TabIndex = 27
        Label6.Text = "Full Name"
        '
        ' Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(40, 50, 70)
        Label7.Location = New Point(130, 495)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 24)
        Label7.TabIndex = 28
        Label7.Text = "Role"
        '
        ' pnlRole
        '
        pnlRole.BackColor = Color.White
        pnlRole.BorderColor = Color.FromArgb(190, 210, 240)
        pnlRole.BorderThickness = 1
        pnlRole.Controls.Add(cmbRole)
        pnlRole.CornerRadius = 0
        pnlRole.Location = New Point(380, 485)
        pnlRole.Name = "pnlRole"
        pnlRole.Size = New Size(560, 48)
        pnlRole.TabIndex = 29
        '
        ' cmbRole
        '
        cmbRole.BackColor = Color.White
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FlatStyle = FlatStyle.Flat
        cmbRole.Font = New Font("Segoe UI", 12.0F)
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(14, 10)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(532, 28)
        cmbRole.TabIndex = 0
        '
        ' pnlInfoIcon
        '
        pnlInfoIcon.BackColor = Color.FromArgb(37, 99, 235)
        pnlInfoIcon.BorderThickness = 0
        pnlInfoIcon.Controls.Add(lblInfoGlyph)
        pnlInfoIcon.CornerRadius = 0
        pnlInfoIcon.Location = New Point(50, 685)
        pnlInfoIcon.Name = "pnlInfoIcon"
        pnlInfoIcon.Size = New Size(28, 28)
        pnlInfoIcon.TabIndex = 31
        '
        ' lblInfoGlyph
        '
        lblInfoGlyph.BackColor = Color.Transparent
        lblInfoGlyph.Dock = DockStyle.Fill
        lblInfoGlyph.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblInfoGlyph.ForeColor = Color.White
        lblInfoGlyph.Location = New Point(0, 0)
        lblInfoGlyph.Name = "lblInfoGlyph"
        lblInfoGlyph.Size = New Size(28, 28)
        lblInfoGlyph.TabIndex = 0
        lblInfoGlyph.Text = "i"
        lblInfoGlyph.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblHelp
        '
        lblHelp.AutoSize = True
        lblHelp.BackColor = Color.Transparent
        lblHelp.Font = New Font("Segoe UI", 11.0F)
        lblHelp.ForeColor = Color.FromArgb(80, 90, 110)
        lblHelp.Location = New Point(90, 690)
        lblHelp.Name = "lblHelp"
        lblHelp.Size = New Size(0, 20)
        lblHelp.TabIndex = 32
        lblHelp.Text = "Please fill in all fields to create your account."
        '
        ' RegisterForm
        '
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 250)
        ClientSize = New Size(1182, 838)
        StartPosition = FormStartPosition.CenterScreen
        Controls.Add(pnlCard)
        Name = "RegisterForm"
        Text = "RegisterForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlUsername As RoundedPanel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pnlFullName As RoundedPanel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As Label
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents pnlPassword As RoundedPanel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEyePwd As Label
    Friend WithEvents pnlConfirmPassword As RoundedPanel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblEyeConfirm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlRole As RoundedPanel
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents pnlInfoIcon As RoundedPanel
    Friend WithEvents lblInfoGlyph As Label
    Friend WithEvents lblHelp As Label
End Class

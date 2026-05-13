<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        btnRegister = New RoundedButton()
        btnLogin = New RoundedButton()
        Username = New Label()
        Label2 = New Label()
        pnlUsername = New RoundedPanel()
        txtUsername = New TextBox()
        pnlPassword = New RoundedPanel()
        txtPassword = New TextBox()
        lblEye = New Label()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        lblMessage = New Label()
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
        pnlCard.Controls.Add(lblMessage)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.Controls.Add(Label3)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(pnlPassword)
        pnlCard.Controls.Add(pnlUsername)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Username)
        pnlCard.Controls.Add(btnLogin)
        pnlCard.Controls.Add(btnRegister)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(50, 50)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1080, 740)
        pnlCard.TabIndex = 0
        '
        ' btnRegister
        '
        btnRegister.BackColor = Color.White
        btnRegister.BorderColor = Color.FromArgb(37, 99, 235)
        btnRegister.BorderThickness = 2
        btnRegister.CornerRadius = 0
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnRegister.ForeColor = Color.FromArgb(37, 99, 235)
        btnRegister.IconFont = New Font("Segoe MDL2 Assets", 16.0F)
        btnRegister.IconGlyph = ChrW(&HE8FA)
        btnRegister.Location = New Point(560, 550)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(320, 60)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        '
        ' btnLogin
        '
        btnLogin.BackColor = Color.FromArgb(37, 99, 235)
        btnLogin.CornerRadius = 0
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.IconFont = New Font("Segoe MDL2 Assets", 16.0F)
        btnLogin.IconGlyph = ChrW(&HE72A)
        btnLogin.Location = New Point(200, 550)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(320, 60)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        '
        ' Username
        '
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Username.ForeColor = Color.FromArgb(40, 50, 70)
        Username.Location = New Point(130, 360)
        Username.Name = "Username"
        Username.Size = New Size(94, 24)
        Username.TabIndex = 2
        Username.Text = "Username"
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(40, 50, 70)
        Label2.Location = New Point(130, 440)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 24)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        '
        ' pnlUsername
        '
        pnlUsername.BackColor = Color.White
        pnlUsername.BorderColor = Color.FromArgb(190, 210, 240)
        pnlUsername.BorderThickness = 1
        pnlUsername.Controls.Add(txtUsername)
        pnlUsername.CornerRadius = 0
        pnlUsername.Location = New Point(380, 350)
        pnlUsername.Name = "pnlUsername"
        pnlUsername.Size = New Size(560, 50)
        pnlUsername.TabIndex = 5
        '
        ' txtUsername
        '
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12.0F)
        txtUsername.Location = New Point(18, 13)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your username"
        txtUsername.Size = New Size(524, 22)
        txtUsername.TabIndex = 0
        '
        ' pnlPassword
        '
        pnlPassword.BackColor = Color.White
        pnlPassword.BorderColor = Color.FromArgb(190, 210, 240)
        pnlPassword.BorderThickness = 1
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.Controls.Add(lblEye)
        pnlPassword.CornerRadius = 0
        pnlPassword.Location = New Point(380, 430)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(560, 50)
        pnlPassword.TabIndex = 6
        '
        ' txtPassword
        '
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12.0F)
        txtPassword.Location = New Point(18, 13)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(488, 22)
        txtPassword.TabIndex = 0
        '
        ' lblEye
        '
        lblEye.AutoSize = False
        lblEye.BackColor = Color.Transparent
        lblEye.Font = New Font("Segoe MDL2 Assets", 14.0F)
        lblEye.ForeColor = Color.FromArgb(110, 120, 140)
        lblEye.Location = New Point(518, 13)
        lblEye.Name = "lblEye"
        lblEye.Size = New Size(30, 24)
        lblEye.TabIndex = 1
        lblEye.Text = ChrW(&HE7B3)
        lblEye.TextAlign = ContentAlignment.MiddleCenter
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(15, 34, 80)
        Label1.Location = New Point(330, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 7
        Label1.Text = "Booking System"
        '
        ' Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(110, 120, 140)
        Label3.Location = New Point(335, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(276, 30)
        Label3.TabIndex = 8
        Label3.Text = "Apartment Booking Login"
        '
        ' PictureBox1
        '
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(120, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        '
        ' Label4
        '
        Label4.AutoSize = False
        Label4.BackColor = Color.FromArgb(228, 232, 240)
        Label4.Location = New Point(50, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(980, 1)
        Label4.TabIndex = 10
        Label4.Text = ""
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
        lblMessage.TabIndex = 11
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
        pnlInfoIcon.TabIndex = 13
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
        lblHelp.TabIndex = 14
        lblHelp.Text = "Please enter your credentials to sign in."
        '
        ' LoginForm
        '
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 250)
        ClientSize = New Size(1182, 838)
        StartPosition = FormStartPosition.CenterScreen
        Controls.Add(pnlCard)
        Name = "LoginForm"
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents btnRegister As RoundedButton
    Friend WithEvents btnLogin As RoundedButton
    Friend WithEvents Username As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlUsername As RoundedPanel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pnlPassword As RoundedPanel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEye As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents pnlInfoIcon As RoundedPanel
    Friend WithEvents lblInfoGlyph As Label
    Friend WithEvents lblHelp As Label
End Class

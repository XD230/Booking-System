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
        lblMessage = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        txtFullName = New TextBox()
        Label2 = New Label()
        Username = New Label()
        btnBack = New Button()
        btnRegister = New Button()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cmbRole = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(49, 557)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(26, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(749, 20)
        Label4.TabIndex = 21
        Label4.Text = "__________________________________________________________________________"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(26, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(236, 194)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(338, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 31)
        Label3.TabIndex = 19
        Label3.Text = "Create Your Account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(322, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 60)
        Label1.TabIndex = 18
        Label1.Text = "Booking System"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(244, 301)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(292, 27)
        txtUsername.TabIndex = 17
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(244, 258)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(292, 27)
        txtFullName.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(97, 400)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 16)
        Label2.TabIndex = 15
        Label2.Text = "Confirm Password"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Username.ForeColor = SystemColors.ActiveCaptionText
        Username.Location = New Point(97, 308)
        Username.Name = "Username"
        Username.Size = New Size(94, 20)
        Username.TabIndex = 14
        Username.Text = "Username"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(217, 490)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(190, 41)
        btnBack.TabIndex = 13
        btnBack.Text = "Back to Login"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(443, 490)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(190, 41)
        btnRegister.TabIndex = 12
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(244, 346)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(292, 27)
        txtPassword.TabIndex = 23
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(244, 394)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(292, 27)
        txtConfirmPassword.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(97, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 26
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(97, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 20)
        Label6.TabIndex = 27
        Label6.Text = "Full Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(97, 454)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 20)
        Label7.TabIndex = 28
        Label7.Text = "Role"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(244, 447)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(292, 28)
        cmbRole.TabIndex = 29
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 597)
        Controls.Add(btnRegister)
        Controls.Add(cmbRole)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblMessage)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(txtFullName)
        Controls.Add(Label2)
        Controls.Add(Username)
        Controls.Add(btnBack)
        Name = "RegisterForm"
        Text = "RegisterForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbRole As ComboBox
End Class

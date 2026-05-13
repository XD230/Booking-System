<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerForm
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
        btnManageApartments = New RoundedButton()
        btnViewBookings = New RoundedButton()
        btnLogout = New RoundedButton()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        lblWelcome = New Label()
        lblDescription = New Label()
        pnlFooter = New RoundedPanel()
        pnlInfoIcon = New RoundedPanel()
        lblInfoGlyph = New Label()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.BorderColor = Color.FromArgb(228, 232, 240)
        pnlCard.BorderThickness = 1
        pnlCard.Controls.Add(pnlFooter)
        pnlCard.Controls.Add(btnLogout)
        pnlCard.Controls.Add(btnViewBookings)
        pnlCard.Controls.Add(btnManageApartments)
        pnlCard.Controls.Add(lblDescription)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(50, 50)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1080, 740)
        pnlCard.TabIndex = 0
        '
        ' btnManageApartments
        '
        btnManageApartments.BackColor = Color.FromArgb(232, 241, 255)
        btnManageApartments.BorderColor = Color.FromArgb(180, 207, 240)
        btnManageApartments.BorderThickness = 2
        btnManageApartments.CornerRadius = 0
        btnManageApartments.EdgeAlignContent = True
        btnManageApartments.FlatAppearance.BorderSize = 0
        btnManageApartments.FlatStyle = FlatStyle.Flat
        btnManageApartments.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnManageApartments.ForeColor = Color.FromArgb(15, 34, 80)
        btnManageApartments.IconColor = Color.FromArgb(37, 99, 235)
        btnManageApartments.IconFont = New Font("Segoe MDL2 Assets", 22.0F)
        btnManageApartments.IconGlyph = ChrW(&HE825)
        btnManageApartments.IconPadding = 60
        btnManageApartments.Location = New Point(240, 410)
        btnManageApartments.Name = "btnManageApartments"
        btnManageApartments.Size = New Size(600, 70)
        btnManageApartments.TabIndex = 0
        btnManageApartments.Text = "Manage Apartments"
        btnManageApartments.TrailingGlyph = ChrW(&HE76C)
        btnManageApartments.TrailingPadding = 32
        btnManageApartments.UseVisualStyleBackColor = False
        '
        ' btnViewBookings
        '
        btnViewBookings.BackColor = Color.FromArgb(232, 248, 232)
        btnViewBookings.BorderColor = Color.FromArgb(180, 220, 185)
        btnViewBookings.BorderThickness = 2
        btnViewBookings.CornerRadius = 0
        btnViewBookings.EdgeAlignContent = True
        btnViewBookings.FlatAppearance.BorderSize = 0
        btnViewBookings.FlatStyle = FlatStyle.Flat
        btnViewBookings.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnViewBookings.ForeColor = Color.FromArgb(15, 34, 80)
        btnViewBookings.IconColor = Color.FromArgb(34, 139, 80)
        btnViewBookings.IconFont = New Font("Segoe MDL2 Assets", 22.0F)
        btnViewBookings.IconGlyph = ChrW(&HE8FD)
        btnViewBookings.IconPadding = 60
        btnViewBookings.Location = New Point(240, 495)
        btnViewBookings.Name = "btnViewBookings"
        btnViewBookings.Size = New Size(600, 70)
        btnViewBookings.TabIndex = 1
        btnViewBookings.Text = "View Bookings"
        btnViewBookings.TrailingGlyph = ChrW(&HE76C)
        btnViewBookings.TrailingPadding = 32
        btnViewBookings.UseVisualStyleBackColor = False
        '
        ' btnLogout
        '
        btnLogout.BackColor = Color.FromArgb(251, 232, 232)
        btnLogout.BorderColor = Color.FromArgb(230, 180, 180)
        btnLogout.BorderThickness = 2
        btnLogout.CornerRadius = 0
        btnLogout.EdgeAlignContent = True
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.FromArgb(15, 34, 80)
        btnLogout.IconColor = Color.FromArgb(220, 60, 60)
        btnLogout.IconFont = New Font("Segoe MDL2 Assets", 22.0F)
        btnLogout.IconGlyph = ChrW(&HF3B1)
        btnLogout.IconPadding = 60
        btnLogout.Location = New Point(240, 580)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(600, 70)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.TrailingGlyph = ChrW(&HE76C)
        btnLogout.TrailingPadding = 32
        btnLogout.UseVisualStyleBackColor = False
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(15, 34, 80)
        Label1.Location = New Point(290, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 3
        Label1.Text = "Booking System"
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(110, 120, 140)
        Label2.Location = New Point(295, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 30)
        Label2.TabIndex = 4
        Label2.Text = "Manager Dashboard"
        '
        ' PictureBox1
        '
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_08_153212
        PictureBox1.Location = New Point(60, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        '
        ' Label4
        '
        Label4.AutoSize = False
        Label4.BackColor = Color.FromArgb(228, 232, 240)
        Label4.Location = New Point(50, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(980, 1)
        Label4.TabIndex = 11
        Label4.Text = ""
        '
        ' lblWelcome
        '
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(15, 34, 80)
        lblWelcome.Location = New Point(50, 310)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 44)
        lblWelcome.TabIndex = 12
        lblWelcome.Text = "Welcome, Manager"
        '
        ' lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.BackColor = Color.Transparent
        lblDescription.Font = New Font("Segoe UI", 12.0F)
        lblDescription.ForeColor = Color.FromArgb(110, 120, 140)
        lblDescription.Location = New Point(50, 365)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(0, 21)
        lblDescription.TabIndex = 13
        lblDescription.Text = "Manage apartments, review bookings, and control listings from one place."
        '
        ' pnlFooter
        '
        pnlFooter.BackColor = Color.FromArgb(245, 248, 254)
        pnlFooter.BorderColor = Color.FromArgb(220, 228, 240)
        pnlFooter.BorderThickness = 1
        pnlFooter.Controls.Add(pnlInfoIcon)
        pnlFooter.Controls.Add(lblMessage)
        pnlFooter.CornerRadius = 0
        pnlFooter.Location = New Point(240, 670)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(600, 50)
        pnlFooter.TabIndex = 14
        '
        ' pnlInfoIcon
        '
        pnlInfoIcon.BackColor = Color.FromArgb(37, 99, 235)
        pnlInfoIcon.BorderThickness = 0
        pnlInfoIcon.Controls.Add(lblInfoGlyph)
        pnlInfoIcon.CornerRadius = 0
        pnlInfoIcon.Location = New Point(16, 11)
        pnlInfoIcon.Name = "pnlInfoIcon"
        pnlInfoIcon.Size = New Size(28, 28)
        pnlInfoIcon.TabIndex = 0
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
        ' lblMessage
        '
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Segoe UI", 12.0F)
        lblMessage.ForeColor = Color.FromArgb(60, 70, 90)
        lblMessage.Location = New Point(60, 14)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(225, 21)
        lblMessage.TabIndex = 1
        lblMessage.Text = "Select an option to continue."
        '
        ' ManagerForm
        '
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 250)
        ClientSize = New Size(1182, 838)
        StartPosition = FormStartPosition.CenterScreen
        Controls.Add(pnlCard)
        Name = "ManagerForm"
        Text = "ManagerForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents btnManageApartments As RoundedButton
    Friend WithEvents btnViewBookings As RoundedButton
    Friend WithEvents btnLogout As RoundedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents pnlFooter As RoundedPanel
    Friend WithEvents pnlInfoIcon As RoundedPanel
    Friend WithEvents lblInfoGlyph As Label
    Friend WithEvents lblMessage As Label
End Class

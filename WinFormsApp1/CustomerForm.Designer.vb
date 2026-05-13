<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        lblWelcome = New Label()
        lblDescription = New Label()
        btnBrowseApartments = New RoundedButton()
        btnMyBookings = New RoundedButton()
        btnLogout = New RoundedButton()
        pnlCard.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.BorderColor = Color.FromArgb(228, 232, 240)
        pnlCard.BorderThickness = 1
        pnlCard.Controls.Add(btnLogout)
        pnlCard.Controls.Add(btnMyBookings)
        pnlCard.Controls.Add(btnBrowseApartments)
        pnlCard.Controls.Add(lblDescription)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(20, 20)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1140, 800)
        pnlCard.TabIndex = 0
        '
        ' PictureBox1
        '
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(50, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(15, 34, 80)
        Label1.Location = New Point(260, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 1
        Label1.Text = "Booking System"
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(110, 120, 140)
        Label2.Location = New Point(265, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 30)
        Label2.TabIndex = 2
        Label2.Text = "Customer Dashboard"
        '
        ' Label4
        '
        Label4.BackColor = Color.FromArgb(228, 232, 240)
        Label4.Location = New Point(40, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(1060, 1)
        Label4.TabIndex = 3
        '
        ' lblWelcome
        '
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(15, 34, 80)
        lblWelcome.Location = New Point(40, 275)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 44)
        lblWelcome.TabIndex = 4
        lblWelcome.Text = "Welcome, Customer"
        '
        ' lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.BackColor = Color.Transparent
        lblDescription.Font = New Font("Segoe UI", 12.0F)
        lblDescription.ForeColor = Color.FromArgb(110, 120, 140)
        lblDescription.Location = New Point(40, 330)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(0, 21)
        lblDescription.TabIndex = 5
        lblDescription.Text = "Browse apartments, book rooms, and manage your reservations."
        '
        ' btnBrowseApartments
        '
        btnBrowseApartments.BackColor = Color.FromArgb(232, 241, 255)
        btnBrowseApartments.BorderThickness = 1
        btnBrowseApartments.CornerRadius = 0
        btnBrowseApartments.FlatAppearance.BorderSize = 0
        btnBrowseApartments.FlatStyle = FlatStyle.Flat
        btnBrowseApartments.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnBrowseApartments.ForeColor = Color.FromArgb(15, 34, 80)
        btnBrowseApartments.Location = New Point(240, 405)
        btnBrowseApartments.Name = "btnBrowseApartments"
        btnBrowseApartments.Size = New Size(660, 75)
        btnBrowseApartments.TabIndex = 6
        btnBrowseApartments.Text = "Browse Apartments"
        btnBrowseApartments.UseVisualStyleBackColor = False
        '
        ' btnMyBookings
        '
        btnMyBookings.BackColor = Color.FromArgb(232, 248, 232)
        btnMyBookings.BorderThickness = 1
        btnMyBookings.CornerRadius = 0
        btnMyBookings.FlatAppearance.BorderSize = 0
        btnMyBookings.FlatStyle = FlatStyle.Flat
        btnMyBookings.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnMyBookings.ForeColor = Color.FromArgb(15, 34, 80)
        btnMyBookings.Location = New Point(240, 500)
        btnMyBookings.Name = "btnMyBookings"
        btnMyBookings.Size = New Size(660, 75)
        btnMyBookings.TabIndex = 7
        btnMyBookings.Text = "My Bookings"
        btnMyBookings.UseVisualStyleBackColor = False
        '
        ' btnLogout
        '
        btnLogout.BackColor = Color.FromArgb(251, 232, 232)
        btnLogout.BorderThickness = 1
        btnLogout.CornerRadius = 0
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.FromArgb(15, 34, 80)
        btnLogout.Location = New Point(240, 595)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(660, 75)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        '
        ' CustomerForm
        '
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 250)
        ClientSize = New Size(1180, 840)
        Controls.Add(pnlCard)
        Name = "CustomerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomerForm"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnBrowseApartments As RoundedButton
    Friend WithEvents btnMyBookings As RoundedButton
    Friend WithEvents btnLogout As RoundedButton
End Class

Public Class CustomerForm

    Public CustomerID As Integer = 0
    Public CustomerName As String = ""

    Private pnlFooter As RoundedPanel
    Private pnlInfoIcon As RoundedPanel
    Private lblInfoGlyph As Label
    Private WithEvents lblMessage As Label


    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuildFooter()
        ApplyButtonIcons()

        If CustomerName = "" Then

            lblWelcome.Text = "Welcome, Customer"

        Else

            lblWelcome.Text = "Welcome, " & CustomerName

        End If


        lblMessage.Text = "Select an option to continue."

    End Sub


    Private Sub BuildFooter()

        lblInfoGlyph = New Label() With {
            .BackColor = Color.Transparent,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 12.0F, FontStyle.Bold),
            .ForeColor = Color.White,
            .Text = "i",
            .TextAlign = ContentAlignment.MiddleCenter
        }

        pnlInfoIcon = New RoundedPanel() With {
            .BackColor = Color.FromArgb(37, 99, 235),
            .BorderThickness = 0,
            .CornerRadius = 0,
            .Location = New Point(20, 16),
            .Size = New Size(28, 28)
        }
        pnlInfoIcon.Controls.Add(lblInfoGlyph)

        lblMessage = New Label() With {
            .AutoSize = True,
            .BackColor = Color.Transparent,
            .Font = New Font("Segoe UI", 11.0F),
            .ForeColor = Color.FromArgb(60, 70, 90),
            .Location = New Point(60, 20),
            .Text = "Select an option to continue."
        }

        pnlFooter = New RoundedPanel() With {
            .BackColor = Color.FromArgb(245, 248, 254),
            .BorderColor = Color.FromArgb(220, 228, 240),
            .BorderThickness = 1,
            .CornerRadius = 0,
            .Location = New Point(240, 700),
            .Size = New Size(660, 60)
        }
        pnlFooter.Controls.Add(pnlInfoIcon)
        pnlFooter.Controls.Add(lblMessage)

        pnlCard.Controls.Add(pnlFooter)

    End Sub


    Private Sub ApplyButtonIcons()

        Dim iconFont As New Font("Segoe MDL2 Assets", 22.0F)
        Dim chevronFont As New Font("Segoe MDL2 Assets", 18.0F)
        Dim chevron As String = ChrW(&HE76C)

        btnBrowseApartments.IconFont = iconFont
        btnBrowseApartments.IconGlyph = ChrW(&HE825)
        btnBrowseApartments.IconColor = Color.FromArgb(37, 99, 235)
        btnBrowseApartments.IconPadding = 60
        btnBrowseApartments.EdgeAlignContent = True
        btnBrowseApartments.TrailingGlyph = chevron
        btnBrowseApartments.TrailingGlyphColor = Color.FromArgb(37, 99, 235)
        btnBrowseApartments.TrailingGlyphFont = chevronFont
        btnBrowseApartments.TrailingPadding = 32
        btnBrowseApartments.BorderColor = Color.FromArgb(180, 207, 240)

        btnMyBookings.IconFont = iconFont
        btnMyBookings.IconGlyph = ChrW(&HE787)
        btnMyBookings.IconColor = Color.FromArgb(34, 139, 80)
        btnMyBookings.IconPadding = 60
        btnMyBookings.EdgeAlignContent = True
        btnMyBookings.TrailingGlyph = chevron
        btnMyBookings.TrailingGlyphColor = Color.FromArgb(37, 99, 235)
        btnMyBookings.TrailingGlyphFont = chevronFont
        btnMyBookings.TrailingPadding = 32
        btnMyBookings.BorderColor = Color.FromArgb(180, 220, 185)

        btnLogout.IconFont = iconFont
        btnLogout.IconGlyph = ChrW(&HF3B1)
        btnLogout.IconColor = Color.FromArgb(220, 60, 60)
        btnLogout.IconPadding = 60
        btnLogout.EdgeAlignContent = True
        btnLogout.TrailingGlyph = chevron
        btnLogout.TrailingGlyphColor = Color.FromArgb(37, 99, 235)
        btnLogout.TrailingGlyphFont = chevronFont
        btnLogout.TrailingPadding = 32
        btnLogout.BorderColor = Color.FromArgb(230, 180, 180)

    End Sub


    Private Sub btnBrowseApartments_Click(sender As Object, e As EventArgs) Handles btnBrowseApartments.Click

        BrowseApartmentsForm.CurrentCustomerID = CustomerID

        BrowseApartmentsForm.Show()

        Me.Hide()

    End Sub


    Private Sub btnMyBookings_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click

        MyBookingsForm.CurrentCustomerID = CustomerID

        MyBookingsForm.Show()

        Me.Hide()

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        CustomerID = 0
        CustomerName = ""

        LoginForm.Show()

        Me.Hide()

    End Sub

End Class

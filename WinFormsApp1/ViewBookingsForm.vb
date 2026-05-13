Imports System.Drawing.Drawing2D
Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class ViewBookingsForm

    Dim selectedBookingID As Integer = 0

    Private pnlFooter As RoundedPanel
    Private pnlInfoIcon As RoundedPanel
    Private lblInfoGlyph As Label
    Private WithEvents lblMessage As Label


    Private Sub ViewBookingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuildFooter()
        ApplyButtonIcons()

        LoadBookings()

        lblMessage.Text = "Select a booking to manage."

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
            .Text = "Select a booking to manage."
        }

        pnlFooter = New RoundedPanel() With {
            .BackColor = Color.FromArgb(245, 248, 254),
            .BorderColor = Color.FromArgb(220, 228, 240),
            .BorderThickness = 1,
            .CornerRadius = 0,
            .Location = New Point(40, 715),
            .Size = New Size(1060, 60)
        }
        pnlFooter.Controls.Add(pnlInfoIcon)
        pnlFooter.Controls.Add(lblMessage)

        pnlCard.Controls.Add(pnlFooter)

    End Sub


    Private Sub ApplyButtonIcons()

        Dim iconFont As New Font("Segoe MDL2 Assets", 17.0F)

        btnRefresh.IconFont = iconFont
        btnRefresh.IconGlyph = ChrW(&HE72C)
        btnRefresh.IconColor = Color.FromArgb(37, 99, 235)
        btnRefresh.IconSpacing = 16

        btnApprove.IconFont = iconFont
        btnApprove.IconGlyph = ChrW(&HE73E)
        btnApprove.IconColor = Color.FromArgb(34, 139, 80)
        btnApprove.IconSpacing = 16
        btnApprove.BorderColor = Color.FromArgb(180, 220, 185)

        btnReject.IconFont = iconFont
        btnReject.IconGlyph = ChrW(&HE894)
        btnReject.IconColor = Color.FromArgb(220, 60, 60)
        btnReject.IconSpacing = 16
        btnReject.BorderColor = Color.FromArgb(230, 180, 180)

        btnBack.IconFont = iconFont
        btnBack.IconGlyph = ChrW(&HE72B)
        btnBack.IconColor = Color.FromArgb(37, 99, 235)
        btnBack.IconSpacing = 16
        btnBack.BorderColor = Color.FromArgb(190, 210, 240)

        btnRefresh.BorderColor = Color.FromArgb(190, 210, 240)

    End Sub


    Private Function GetConnectionString() As String

        Return ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

    End Function


    Private Sub LoadBookings()

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT " &
                    "Bookings.BookingID AS [Booking ID], " &
                    "Users.FullName AS [Customer Name], " &
                    "Apartments.HotelName AS [Hotel Name], " &
                    "Apartments.ApartmentNumber AS [Apartment Number], " &
                    "Bookings.BookingDate AS [Booking Date], " &
                    "Bookings.Status AS [Status] " &
                    "FROM Bookings " &
                    "INNER JOIN Users ON Bookings.UserID = Users.UserID " &
                    "INNER JOIN Apartments ON Bookings.ApartmentID = Apartments.ApartmentID"

            Using cmd As New SqlCommand(query, con)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable()

                adapter.Fill(table)

                dgvBookings.DataSource = table

            End Using

        End Using

    End Sub


    Private Sub dgvBookings_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvBookings.CellPainting

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = dgvBookings.Columns(e.ColumnIndex).Name

        If columnName <> "Status" Then Exit Sub

        Dim statusValue As String

        If e.Value Is Nothing Then
            statusValue = ""
        Else
            statusValue = e.Value.ToString()
        End If

        Dim badgeColor As Color
        Dim textColor As Color

        Select Case statusValue

            Case "Pending"
                badgeColor = Color.FromArgb(255, 244, 200)
                textColor = Color.FromArgb(160, 109, 20)

            Case "Approved"
                badgeColor = Color.FromArgb(220, 245, 220)
                textColor = Color.FromArgb(46, 139, 71)

            Case "Rejected"
                badgeColor = Color.FromArgb(250, 220, 220)
                textColor = Color.FromArgb(192, 74, 74)

            Case Else
                Exit Sub

        End Select


        Dim isSelected As Boolean = (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected
        Dim cellBg As Color

        If isSelected Then
            cellBg = e.CellStyle.SelectionBackColor
        Else
            cellBg = e.CellStyle.BackColor
        End If

        Using bgBrush As New SolidBrush(cellBg)
            e.Graphics.FillRectangle(bgBrush, e.CellBounds)
        End Using


        Dim font As Font = e.CellStyle.Font

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        Dim textSize As SizeF = e.Graphics.MeasureString(statusValue, font)
        Dim padX As Integer = 18
        Dim padY As Integer = 6
        Dim badgeW As Integer = CInt(textSize.Width) + padX * 2
        Dim badgeH As Integer = CInt(textSize.Height) + padY * 2
        Dim badgeX As Integer = e.CellBounds.X + (e.CellBounds.Width - badgeW) \ 2
        Dim badgeY As Integer = e.CellBounds.Y + (e.CellBounds.Height - badgeH) \ 2

        Dim badgeRect As New Rectangle(badgeX, badgeY, badgeW, badgeH)

        Using path As GraphicsPath = RoundedPanel.MakePath(badgeRect, badgeH \ 2)
            Using badgeBrush As New SolidBrush(badgeColor)
                e.Graphics.FillPath(badgeBrush, path)
            End Using
        End Using


        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        Using textBrush As New SolidBrush(textColor)
            e.Graphics.DrawString(statusValue, font, textBrush, badgeRect, sf)
        End Using


        e.Paint(e.ClipBounds, DataGridViewPaintParts.Border)

        e.Handled = True

    End Sub


    Private Sub dgvBookings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookings.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = dgvBookings.Rows(e.RowIndex)

            selectedBookingID = Convert.ToInt32(row.Cells("Booking ID").Value)

            lblMessage.Text = "Selected booking ID: " & selectedBookingID.ToString()

        End If

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadBookings()

        selectedBookingID = 0

        lblMessage.Text = "Bookings refreshed."

    End Sub


    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If selectedBookingID = 0 Then

            lblMessage.Text = "Please select a booking first."

            Exit Sub

        End If


        UpdateBookingStatus("Approved")

        lblMessage.Text = "Booking approved successfully."

        LoadBookings()

    End Sub


    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        If selectedBookingID = 0 Then

            lblMessage.Text = "Please select a booking first."

            Exit Sub

        End If


        UpdateBookingStatus("Rejected")

        lblMessage.Text = "Booking rejected successfully."

        LoadBookings()

    End Sub


    Private Sub UpdateBookingStatus(status As String)

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "UPDATE Bookings SET Status = @Status WHERE BookingID = @BookingID"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Status", status)
                cmd.Parameters.AddWithValue("@BookingID", selectedBookingID)

                con.Open()

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ManagerForm.Show()

        Me.Hide()

    End Sub

End Class

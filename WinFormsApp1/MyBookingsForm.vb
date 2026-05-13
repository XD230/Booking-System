Imports System.Drawing.Drawing2D
Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class MyBookingsForm

    Public CurrentCustomerID As Integer = 0


    Private Sub MyBookingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMyBookings()

        lblMessage.Text = "Your bookings will appear here."

    End Sub


    Private Function GetConnectionString() As String

        Return ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

    End Function


    Private Sub LoadMyBookings()

        If CurrentCustomerID = 0 Then

            lblMessage.Text = "Customer information is missing. Please login again."

            Exit Sub

        End If


        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT " &
                    "Bookings.BookingID AS [Booking ID], " &
                    "Apartments.HotelName AS [Hotel Name], " &
                    "Apartments.ApartmentNumber AS [Apartment Number], " &
                    "Apartments.Location AS [Location], " &
                    "Bookings.BookingDate AS [Booking Date], " &
                    "Bookings.CheckInDate AS [Check-in Date], " &
                    "Bookings.NumberOfNights AS [Number of Nights], " &
                    "Bookings.Status AS [Status] " &
                    "FROM Bookings " &
                    "INNER JOIN Apartments ON Bookings.ApartmentID = Apartments.ApartmentID " &
                    "WHERE Bookings.UserID = @UserID"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@UserID", CurrentCustomerID)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)

                dgvMyBookings.DataSource = table

            End Using

        End Using

    End Sub


    Private Sub dgvMyBookings_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvMyBookings.CellPainting

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = dgvMyBookings.Columns(e.ColumnIndex).Name

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


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadMyBookings()

        lblMessage.Text = "Bookings refreshed."

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        CustomerForm.Show()

        Me.Hide()

    End Sub

End Class

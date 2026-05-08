Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class ViewBookingsForm

    Dim selectedBookingID As Integer = 0


    Private Sub ViewBookingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBookings()

        lblMessage.Text = "Select a booking to manage."

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
                    "Bookings.BookingID, " &
                    "Users.FullName AS CustomerName, " &
                    "Apartments.HotelName, " &
                    "Apartments.ApartmentNumber, " &
                    "Bookings.BookingDate, " &
                    "Bookings.Status " &
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


        dgvBookings.ReadOnly = True
        dgvBookings.AllowUserToAddRows = False
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub


    Private Sub dgvBookings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookings.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = dgvBookings.Rows(e.RowIndex)

            selectedBookingID = Convert.ToInt32(row.Cells("BookingID").Value)

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
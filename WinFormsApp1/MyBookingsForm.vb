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
                    "Bookings.BookingID, " &
                    "Apartments.HotelName, " &
                    "Apartments.ApartmentNumber, " &
                    "Apartments.Location, " &
                    "Bookings.BookingDate, " &
                    "Bookings.CheckInDate, " &
                    "Bookings.NumberOfNights, " &
                    "Bookings.Status " &
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


        dgvMyBookings.ReadOnly = True
        dgvMyBookings.AllowUserToAddRows = False
        dgvMyBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMyBookings.RowHeadersVisible = False

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
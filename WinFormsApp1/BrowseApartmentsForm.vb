Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class BrowseApartmentsForm

    Public CurrentCustomerID As Integer = 0

    Dim selectedApartmentID As Integer = 0
    Dim selectedPrice As Decimal = 0


    Private Sub BrowseApartmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picApartmentMain.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb1.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb2.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb3.SizeMode = PictureBoxSizeMode.StretchImage

        dtpCheckIn.MinDate = Date.Today

        numNights.Minimum = 1
        numNights.Maximum = 30
        numNights.Value = 1

        txtDescription.ReadOnly = True
        txtDescription.Multiline = True

        ClearDetails()

        LoadApartments("")

        lblMessage.Text = "Select an apartment to view details."

    End Sub


    Private Function GetConnectionString() As String

        Return ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

    End Function


    Private Sub LoadApartments(searchText As String)

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT ApartmentID, HotelName, ApartmentNumber, Location, Price, Description, MainImagePath " &
                    "FROM Apartments " &
                    "WHERE HotelName LIKE @Search OR Location LIKE @Search"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)

                dgvApartments.DataSource = table

            End Using

        End Using

        dgvApartments.ReadOnly = True
        dgvApartments.AllowUserToAddRows = False
        dgvApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        If dgvApartments.Columns.Contains("ApartmentID") Then
            dgvApartments.Columns("ApartmentID").Visible = False
        End If

        If dgvApartments.Columns.Contains("Description") Then
            dgvApartments.Columns("Description").Visible = False
        End If

        If dgvApartments.Columns.Contains("MainImagePath") Then
            dgvApartments.Columns("MainImagePath").Visible = False
        End If

    End Sub


    Private Sub dgvApartments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApartments.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = dgvApartments.Rows(e.RowIndex)

            selectedApartmentID = Convert.ToInt32(row.Cells("ApartmentID").Value)
            selectedPrice = Convert.ToDecimal(row.Cells("Price").Value)

            lblHotelValue.Text = row.Cells("HotelName").Value.ToString()
            lblApartmentNumberValue.Text = row.Cells("ApartmentNumber").Value.ToString()
            lblLocationValue.Text = row.Cells("Location").Value.ToString()
            lblPriceValue.Text = row.Cells("Price").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()

            Dim mainImagePath As String

            mainImagePath = row.Cells("MainImagePath").Value.ToString()

            If mainImagePath <> "" Then

                picApartmentMain.ImageLocation = mainImagePath

            Else

                picApartmentMain.Image = Nothing

            End If

            LoadApartmentImages(selectedApartmentID)

            lblMessage.Text = "Apartment selected."

        End If

    End Sub


    Private Sub LoadApartmentImages(apartmentID As Integer)

        picThumb1.Image = Nothing
        picThumb2.Image = Nothing
        picThumb3.Image = Nothing

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT ImagePath FROM ApartmentImages WHERE ApartmentID = @ApartmentID"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@ApartmentID", apartmentID)

                con.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    Dim count As Integer = 0

                    While reader.Read()

                        count += 1

                        If count = 1 Then

                            picThumb1.ImageLocation = reader("ImagePath").ToString()

                        ElseIf count = 2 Then

                            picThumb2.ImageLocation = reader("ImagePath").ToString()

                        ElseIf count = 3 Then

                            picThumb3.ImageLocation = reader("ImagePath").ToString()

                        End If

                    End While

                End Using

            End Using

        End Using

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        LoadApartments(txtSearch.Text.Trim())

        lblMessage.Text = "Search completed."

    End Sub


    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click

        txtSearch.Clear()

        LoadApartments("")

        ClearDetails()

        lblMessage.Text = "Search cleared."

    End Sub


    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        If CurrentCustomerID = 0 Then

            lblMessage.Text = "Customer information is missing. Please login again."

            Exit Sub

        End If


        If selectedApartmentID = 0 Then

            lblMessage.Text = "Please select an apartment first."

            Exit Sub

        End If


        Dim checkInDate As Date
        Dim numberOfNights As Integer
        Dim totalPrice As Decimal

        checkInDate = dtpCheckIn.Value.Date
        numberOfNights = Convert.ToInt32(numNights.Value)

        totalPrice = selectedPrice * numberOfNights


        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "INSERT INTO Bookings " &
                    "(UserID, ApartmentID, BookingDate, CheckInDate, NumberOfNights, TotalPrice, Status) " &
                    "VALUES " &
                    "(@UserID, @ApartmentID, @BookingDate, @CheckInDate, @NumberOfNights, @TotalPrice, @Status)"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@UserID", CurrentCustomerID)
                cmd.Parameters.AddWithValue("@ApartmentID", selectedApartmentID)
                cmd.Parameters.AddWithValue("@BookingDate", Date.Today)
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate)
                cmd.Parameters.AddWithValue("@NumberOfNights", numberOfNights)
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice)
                cmd.Parameters.AddWithValue("@Status", "Pending")

                con.Open()

                cmd.ExecuteNonQuery()

            End Using

        End Using

        MessageBox.Show("Booking request sent successfully.", "Success")

        lblMessage.Text = "Booking request sent successfully."

    End Sub


    Private Sub ClearDetails()

        selectedApartmentID = 0
        selectedPrice = 0

        lblHotelValue.Text = "-"
        lblApartmentNumberValue.Text = "-"
        lblLocationValue.Text = "-"
        lblPriceValue.Text = "-"
        txtDescription.Clear()

        picApartmentMain.Image = Nothing
        picThumb1.Image = Nothing
        picThumb2.Image = Nothing
        picThumb3.Image = Nothing

        numNights.Value = 1
        dtpCheckIn.Value = Date.Today

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        CustomerForm.Show()

        Me.Hide()

    End Sub

End Class
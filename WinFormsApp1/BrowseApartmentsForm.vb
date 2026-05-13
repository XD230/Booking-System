Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class BrowseApartmentsForm

    Public CurrentCustomerID As Integer = 0

    Dim selectedApartmentID As Integer = 0
    Dim selectedPrice As Decimal = 0

    Private pnlFooter As RoundedPanel
    Private pnlInfoIcon As RoundedPanel
    Private lblInfoGlyph As Label
    Private WithEvents lblMessage As Label


    Private Sub BrowseApartmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuildFooter()
        ApplyButtonIcons()

        dtpCheckIn.MinDate = Date.Today
        dtpCheckIn.Value = Date.Today

        numNights.Minimum = 1
        numNights.Maximum = 30
        numNights.Value = 1

        ClearDetails()

        LoadApartments("")

        lblMessage.Text = "Select an apartment to view details."

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
            .Text = "Select an apartment to view details."
        }

        pnlFooter = New RoundedPanel() With {
            .BackColor = Color.FromArgb(245, 248, 254),
            .BorderColor = Color.FromArgb(220, 228, 240),
            .BorderThickness = 1,
            .CornerRadius = 0,
            .Location = New Point(40, 980),
            .Size = New Size(1300, 60)
        }
        pnlFooter.Controls.Add(pnlInfoIcon)
        pnlFooter.Controls.Add(lblMessage)

        pnlCard.Controls.Add(pnlFooter)

    End Sub


    Private Sub ApplyButtonIcons()

        Dim iconFont As New Font("Segoe MDL2 Assets", 16.0F)
        Dim blue As Color = Color.FromArgb(37, 99, 235)
        Dim slate As Color = Color.FromArgb(60, 70, 90)

        btnSearch.IconFont = iconFont
        btnSearch.IconGlyph = ChrW(&HE721)
        btnSearch.IconColor = Color.White
        btnSearch.IconSpacing = 12

        btnClearSearch.IconFont = iconFont
        btnClearSearch.IconGlyph = ChrW(&HE894)
        btnClearSearch.IconColor = slate
        btnClearSearch.IconSpacing = 12

        btnBook.IconFont = iconFont
        btnBook.IconGlyph = ChrW(&HE787)
        btnBook.IconColor = Color.White
        btnBook.IconSpacing = 14

        btnBack.IconFont = iconFont
        btnBack.IconGlyph = ChrW(&HE72B)
        btnBack.IconColor = slate
        btnBack.IconSpacing = 14

    End Sub


    Private Function GetConnectionString() As String

        Return ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

    End Function


    Private Sub LoadApartments(searchText As String)

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT " &
                    "ApartmentID, " &
                    "HotelName AS [Hotel Name], " &
                    "ApartmentNumber AS [Apartment Number], " &
                    "Location AS [Location], " &
                    "Price AS [Price per Night], " &
                    "Description, " &
                    "MainImagePath " &
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
            selectedPrice = Convert.ToDecimal(row.Cells("Price per Night").Value)

            lblHotelValue.Text = row.Cells("Hotel Name").Value.ToString()
            lblApartmentNumberValue.Text = row.Cells("Apartment Number").Value.ToString()
            lblLocationValue.Text = row.Cells("Location").Value.ToString()
            lblPriceValue.Text = row.Cells("Price per Night").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()

            Dim mainImagePath As String

            mainImagePath = row.Cells("MainImagePath").Value.ToString()

            If mainImagePath <> "" Then

                picApartmentMain.ImageLocation = mainImagePath

            Else

                picApartmentMain.Image = Nothing

            End If

            LoadApartmentImages(selectedApartmentID)

            UpdateTotalPrice()

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


    Private Sub UpdateTotalPrice()

        Dim nights As Integer = Convert.ToInt32(numNights.Value)
        Dim total As Decimal = selectedPrice * nights

        lblTotalValue.Text = total.ToString("0.00")

    End Sub


    Private Sub numNights_ValueChanged(sender As Object, e As EventArgs) Handles numNights.ValueChanged

        UpdateTotalPrice()

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

        lblTotalValue.Text = "0.00"

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        CustomerForm.Show()

        Me.Hide()

    End Sub

End Class

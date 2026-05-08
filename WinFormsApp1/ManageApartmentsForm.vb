Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class ManageApartmentsForm

    Dim selectedApartmentID As Integer = 0

    Dim mainImagePath As String = ""
    Dim image1Path As String = ""
    Dim image2Path As String = ""
    Dim image3Path As String = ""


    Private Sub ManageApartmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picApartmentMain.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb1.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb2.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb3.SizeMode = PictureBoxSizeMode.StretchImage

        LoadApartments()

        lblMessage.Text = "Manage apartment listings and images here."

    End Sub


    Private Function GetConnectionString() As String

        Return ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

    End Function


    Private Sub LoadApartments()

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT ApartmentID, HotelName, ApartmentNumber, Location, Price, Description, MainImagePath FROM Apartments"

            Using cmd As New SqlCommand(query, con)

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

        If dgvApartments.Columns.Contains("MainImagePath") Then
            dgvApartments.Columns("MainImagePath").Visible = False
        End If

    End Sub


    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click

        Dim ofd As New OpenFileDialog()

        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Multiselect = True

        If ofd.ShowDialog() = DialogResult.OK Then

            If ofd.FileNames.Length >= 1 Then

                mainImagePath = ofd.FileNames(0)
                picApartmentMain.ImageLocation = mainImagePath

            End If

            If ofd.FileNames.Length >= 2 Then

                image1Path = ofd.FileNames(1)
                picThumb1.ImageLocation = image1Path

            End If

            If ofd.FileNames.Length >= 3 Then

                image2Path = ofd.FileNames(2)
                picThumb2.ImageLocation = image2Path

            End If

            If ofd.FileNames.Length >= 4 Then

                image3Path = ofd.FileNames(3)
                picThumb3.ImageLocation = image3Path

            End If

            lblMessage.Text = "Images selected successfully."

        End If

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtHotelName.Text.Trim() = "" Or
           txtApartmentNumber.Text.Trim() = "" Or
           txtLocation.Text.Trim() = "" Or
           txtPrice.Text.Trim() = "" Or
           txtDescription.Text.Trim() = "" Then

            lblMessage.Text = "Please fill in all fields."

            Exit Sub

        End If


        If IsNumeric(txtPrice.Text.Trim()) = False Then

            lblMessage.Text = "Price must be a number."

            Exit Sub

        End If


        Try

            Dim connectionString As String

            connectionString = GetConnectionString()

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim query As String

                query = "INSERT INTO Apartments " &
                        "(HotelName, ApartmentNumber, Location, Price, Description, MainImagePath) " &
                        "OUTPUT INSERTED.ApartmentID " &
                        "VALUES " &
                        "(@HotelName, @ApartmentNumber, @Location, @Price, @Description, @MainImagePath)"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@HotelName", txtHotelName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ApartmentNumber", txtApartmentNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@MainImagePath", mainImagePath)

                    Dim newApartmentID As Integer

                    newApartmentID = Convert.ToInt32(cmd.ExecuteScalar())

                    SaveApartmentImages(con, newApartmentID)

                End Using

            End Using

            lblMessage.Text = "Apartment added successfully."

            ClearFields()

            LoadApartments()


        Catch ex As Exception

            MessageBox.Show("Add failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            lblMessage.Text = "Add failed."

        End Try

    End Sub


    Private Sub SaveApartmentImages(con As SqlConnection, apartmentID As Integer)

        InsertImage(con, apartmentID, image1Path)
        InsertImage(con, apartmentID, image2Path)
        InsertImage(con, apartmentID, image3Path)

    End Sub


    Private Sub InsertImage(con As SqlConnection, apartmentID As Integer, imagePath As String)

        If imagePath = "" Then

            Exit Sub

        End If

        Dim query As String

        query = "INSERT INTO ApartmentImages (ApartmentID, ImagePath) VALUES (@ApartmentID, @ImagePath)"

        Using cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@ApartmentID", apartmentID)
            cmd.Parameters.AddWithValue("@ImagePath", imagePath)

            cmd.ExecuteNonQuery()

        End Using

    End Sub


    Private Sub dgvApartments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApartments.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = dgvApartments.Rows(e.RowIndex)

            selectedApartmentID = Convert.ToInt32(row.Cells("ApartmentID").Value)

            txtHotelName.Text = row.Cells("HotelName").Value.ToString()
            txtApartmentNumber.Text = row.Cells("ApartmentNumber").Value.ToString()
            txtLocation.Text = row.Cells("Location").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()

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

        image1Path = ""
        image2Path = ""
        image3Path = ""

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

                    Dim count As Integer

                    count = 0

                    While reader.Read()

                        count += 1

                        If count = 1 Then

                            image1Path = reader("ImagePath").ToString()
                            picThumb1.ImageLocation = image1Path

                        ElseIf count = 2 Then

                            image2Path = reader("ImagePath").ToString()
                            picThumb2.ImageLocation = image2Path

                        ElseIf count = 3 Then

                            image3Path = reader("ImagePath").ToString()
                            picThumb3.ImageLocation = image3Path

                        End If

                    End While

                End Using

            End Using

        End Using

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If selectedApartmentID = 0 Then

            lblMessage.Text = "Please select an apartment to edit."

            Exit Sub

        End If


        If txtHotelName.Text.Trim() = "" Or
           txtApartmentNumber.Text.Trim() = "" Or
           txtLocation.Text.Trim() = "" Or
           txtPrice.Text.Trim() = "" Or
           txtDescription.Text.Trim() = "" Then

            lblMessage.Text = "Please fill in all fields."

            Exit Sub

        End If


        If IsNumeric(txtPrice.Text.Trim()) = False Then

            lblMessage.Text = "Price must be a number."

            Exit Sub

        End If


        Try

            Dim connectionString As String

            connectionString = GetConnectionString()

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim updateQuery As String

                updateQuery = "UPDATE Apartments SET " &
                              "HotelName = @HotelName, " &
                              "ApartmentNumber = @ApartmentNumber, " &
                              "Location = @Location, " &
                              "Price = @Price, " &
                              "Description = @Description, " &
                              "MainImagePath = @MainImagePath " &
                              "WHERE ApartmentID = @ApartmentID"

                Using cmd As New SqlCommand(updateQuery, con)

                    cmd.Parameters.AddWithValue("@HotelName", txtHotelName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ApartmentNumber", txtApartmentNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@MainImagePath", mainImagePath)
                    cmd.Parameters.AddWithValue("@ApartmentID", selectedApartmentID)

                    cmd.ExecuteNonQuery()

                End Using


                Dim deleteImagesQuery As String

                deleteImagesQuery = "DELETE FROM ApartmentImages WHERE ApartmentID = @ApartmentID"

                Using deleteCmd As New SqlCommand(deleteImagesQuery, con)

                    deleteCmd.Parameters.AddWithValue("@ApartmentID", selectedApartmentID)

                    deleteCmd.ExecuteNonQuery()

                End Using

                SaveApartmentImages(con, selectedApartmentID)

            End Using

            lblMessage.Text = "Apartment updated successfully."

            ClearFields()

            LoadApartments()


        Catch ex As Exception

            MessageBox.Show("Update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            lblMessage.Text = "Update failed."

        End Try

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedApartmentID = 0 Then

            lblMessage.Text = "Please select an apartment to delete."

            Exit Sub

        End If


        Try

            If ApartmentHasBookings(selectedApartmentID) = True Then

                MessageBox.Show(
                    "This apartment cannot be deleted because it already has bookings.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                lblMessage.Text = "Cannot delete this apartment because it has bookings."

                Exit Sub

            End If


            Dim result As DialogResult

            result = MessageBox.Show(
                "Are you sure you want to delete this apartment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


            If result = DialogResult.No Then

                Exit Sub

            End If


            Dim connectionString As String

            connectionString = GetConnectionString()

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim deleteImagesQuery As String

                deleteImagesQuery = "DELETE FROM ApartmentImages WHERE ApartmentID = @ApartmentID"

                Using cmdImages As New SqlCommand(deleteImagesQuery, con)

                    cmdImages.Parameters.AddWithValue("@ApartmentID", selectedApartmentID)

                    cmdImages.ExecuteNonQuery()

                End Using


                Dim deleteApartmentQuery As String

                deleteApartmentQuery = "DELETE FROM Apartments WHERE ApartmentID = @ApartmentID"

                Using cmdApartment As New SqlCommand(deleteApartmentQuery, con)

                    cmdApartment.Parameters.AddWithValue("@ApartmentID", selectedApartmentID)

                    cmdApartment.ExecuteNonQuery()

                End Using

            End Using

            lblMessage.Text = "Apartment deleted successfully."

            ClearFields()

            LoadApartments()


        Catch ex As Exception

            MessageBox.Show(
                "Delete failed: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            lblMessage.Text = "Delete failed."

        End Try

    End Sub


    Private Function ApartmentHasBookings(apartmentID As Integer) As Boolean

        Dim count As Integer

        count = 0

        Dim connectionString As String

        connectionString = GetConnectionString()

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT COUNT(*) FROM Bookings WHERE ApartmentID = @ApartmentID"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@ApartmentID", apartmentID)

                con.Open()

                count = Convert.ToInt32(cmd.ExecuteScalar())

            End Using

        End Using


        If count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click

        mainImagePath = ""
        image1Path = ""
        image2Path = ""
        image3Path = ""

        picApartmentMain.Image = Nothing
        picThumb1.Image = Nothing
        picThumb2.Image = Nothing
        picThumb3.Image = Nothing

        lblMessage.Text = "Images removed."

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearFields()

        lblMessage.Text = "Fields cleared."

    End Sub


    Private Sub ClearFields()

        selectedApartmentID = 0

        txtHotelName.Clear()
        txtApartmentNumber.Clear()
        txtLocation.Clear()
        txtPrice.Clear()
        txtDescription.Clear()

        mainImagePath = ""
        image1Path = ""
        image2Path = ""
        image3Path = ""

        picApartmentMain.Image = Nothing
        picThumb1.Image = Nothing
        picThumb2.Image = Nothing
        picThumb3.Image = Nothing

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ManagerForm.Show()

        Me.Hide()

    End Sub

End Class
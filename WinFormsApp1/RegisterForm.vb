Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"c
        txtConfirmPassword.PasswordChar = "*"c

        cmbRole.Items.Clear()
        cmbRole.Items.Add("Customer")
        cmbRole.Items.Add("Manager")

        cmbRole.SelectedIndex = 0

        lblMessage.Text = ""

    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim fullName As String
        Dim username As String
        Dim password As String
        Dim confirmPassword As String
        Dim role As String

        fullName = txtUsername.Text.Trim()
        username = txtFullName.Text.Trim()
        password = txtPassword.Text.Trim()
        confirmPassword = txtConfirmPassword.Text.Trim()
        role = cmbRole.Text.Trim()


        If fullName = "" Or username = "" Or password = "" Or confirmPassword = "" Or role = "" Then

            lblMessage.Text = "Please fill in all fields."

            Exit Sub

        End If


        If password <> confirmPassword Then

            lblMessage.Text = "Passwords do not match."

            Exit Sub

        End If


        If IsUsernameTaken(username) = True Then

            lblMessage.Text = "Username already exists."

            Exit Sub

        End If


        SaveUser(fullName, username, password, role)

        MessageBox.Show("Account created successfully. You can now login.", "Success")

        LoginForm.Show()
        Me.Hide()

    End Sub


    Private Function IsUsernameTaken(username As String) As Boolean

        Dim connectionString As String
        Dim count As Integer

        connectionString = ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT COUNT(*) FROM Users WHERE Username = @Username"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Username", username)

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


    Private Sub SaveUser(fullName As String, username As String, password As String, role As String)

        Dim connectionString As String

        connectionString = ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString

        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "INSERT INTO Users (FullName, Username, Password, Role) VALUES (@FullName, @Username, @Password, @Role)"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@FullName", fullName)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@Role", role)

                con.Open()

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        LoginForm.Show()
        Me.Hide()

    End Sub

End Class
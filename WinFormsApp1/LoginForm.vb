Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"c

        lblMessage.Text = ""

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String
        Dim userRole As String
        Dim fullName As String = ""
        Dim userID As Integer = 0

        username = txtUsername.Text.Trim()
        password = txtPassword.Text.Trim()


        If username = "" Or password = "" Then

            lblMessage.Text = "Please enter username and password."

            Exit Sub

        End If


        userRole = GetUserRole(username, password, fullName, userID)


        If userRole = "" Then

            lblMessage.Text = "Invalid username or password."

        ElseIf userRole = "Customer" Then

            CustomerForm.CustomerID = userID
            CustomerForm.CustomerName = fullName

            CustomerForm.Show()
            Me.Hide()

        ElseIf userRole = "Manager" Then

            ManagerForm.ManagerName = fullName

            ManagerForm.Show()
            Me.Hide()

        Else

            lblMessage.Text = "Unknown user role."

        End If

    End Sub


    Private Function GetUserRole(username As String, password As String, ByRef fullName As String, ByRef userID As Integer) As String

        Dim role As String
        Dim connectionString As String

        role = ""
        fullName = ""
        userID = 0

        connectionString = ConfigurationManager.ConnectionStrings("BookingDB").ConnectionString


        Using con As New SqlConnection(connectionString)

            Dim query As String

            query = "SELECT UserID, FullName, Role FROM Users WHERE Username = @Username AND Password = @Password"


            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                con.Open()


                Using reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        userID = Convert.ToInt32(reader("UserID"))
                        fullName = reader("FullName").ToString()
                        role = reader("Role").ToString()

                    End If

                End Using

            End Using

        End Using


        Return role

    End Function


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        RegisterForm.Show()
        Me.Hide()

    End Sub

End Class
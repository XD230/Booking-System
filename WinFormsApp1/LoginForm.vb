Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"c

        lblMessage.Text = ""

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String
        Dim userRole As String

        username = txtUsername.Text.Trim()
        password = txtPassword.Text.Trim()

        If username = "" Or password = "" Then

            lblMessage.Text = "Please enter username and password."

            Exit Sub

        End If


        userRole = GetUserRole(username, password)


        If userRole = "" Then

            lblMessage.Text = "Invalid username or password."

        ElseIf userRole = "Customer" Then

            CustomerForm.Show()
            Me.Hide()

        ElseIf userRole = "Manager" Then

            ManagerForm.Show()
            Me.Hide()

        Else

            lblMessage.Text = "Unknown user role."

        End If

    End Sub


    Private Function GetUserRole(username As String, password As String) As String


        ' ادريس هذا مؤقت بيكون

        If username = "customer" And password = "123" Then

            Return "Customer"

        ElseIf username = "manager" And password = "123" Then

            Return "Manager"

        Else

            Return ""

        End If

    End Function


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        RegisterForm.Show()
        Me.Hide()

    End Sub

End Class
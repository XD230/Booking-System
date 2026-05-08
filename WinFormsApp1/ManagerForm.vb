Public Class ManagerForm

    Public ManagerName As String

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ManagerName = "" Then

            lblWelcome.Text = "Welcome, Manager"

        Else

            lblWelcome.Text = "Welcome, " & ManagerName

        End If

        lblMessage.Text = "Select an option to continue."

    End Sub


    Private Sub btnManageApartments_Click(sender As Object, e As EventArgs) Handles btnManageApartments.Click

        ManageApartmentsForm.Show()
        Me.Hide()

    End Sub


    Private Sub btnViewBookings_Click(sender As Object, e As EventArgs) Handles btnViewBookings.Click

        ViewBookingsForm.Show()
        Me.Hide()

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        LoginForm.Show()
        Me.Hide()

    End Sub

End Class
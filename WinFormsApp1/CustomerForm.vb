Public Class CustomerForm

    Public CustomerID As Integer = 0
    Public CustomerName As String = ""


    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CustomerName = "" Then

            lblWelcome.Text = "Welcome, Customer"

        Else

            lblWelcome.Text = "Welcome, " & CustomerName

        End If


        lblMessage.Text = "Select an option to continue."

    End Sub


    Private Sub btnBrowseApartments_Click(sender As Object, e As EventArgs) Handles btnBrowseApartments.Click

        BrowseApartmentsForm.CurrentCustomerID = CustomerID

        BrowseApartmentsForm.Show()

        Me.Hide()

    End Sub


    Private Sub btnMyBookings_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click

        MyBookingsForm.CurrentCustomerID = CustomerID

        MyBookingsForm.Show()

        Me.Hide()

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        CustomerID = 0
        CustomerName = ""

        LoginForm.Show()

        Me.Hide()

    End Sub

End Class
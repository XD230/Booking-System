<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblWelcome = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnBrowseApartments = New Button()
        btnMyBookings = New Button()
        btnLogout = New Button()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.WindowFrame
        Label2.Location = New Point(300, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 23)
        Label2.TabIndex = 6
        Label2.Text = "Customer Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(300, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 41)
        Label1.TabIndex = 5
        Label1.Text = "Booking System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(8, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(253, 223)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(26, 286)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 20)
        lblWelcome.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.WindowFrame
        Label3.Location = New Point(26, 322)
        Label3.Name = "Label3"
        Label3.Size = New Size(528, 23)
        Label3.TabIndex = 9
        Label3.Text = "Browse apartments, book rooms, and manage your reservations."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(8, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(1059, 20)
        Label4.TabIndex = 12
        Label4.Text = "_________________________________________________________________________________________________________"
        ' 
        ' btnBrowseApartments
        ' 
        btnBrowseApartments.Location = New Point(371, 368)
        btnBrowseApartments.Name = "btnBrowseApartments"
        btnBrowseApartments.Size = New Size(307, 73)
        btnBrowseApartments.TabIndex = 13
        btnBrowseApartments.Text = "Browse Apartments"
        btnBrowseApartments.UseVisualStyleBackColor = True
        ' 
        ' btnMyBookings
        ' 
        btnMyBookings.Location = New Point(371, 462)
        btnMyBookings.Name = "btnMyBookings"
        btnMyBookings.Size = New Size(307, 73)
        btnMyBookings.TabIndex = 14
        btnMyBookings.Text = "My Bookings"
        btnMyBookings.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(371, 555)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(307, 73)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(26, 645)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 16
        ' 
        ' CustomerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 703)
        Controls.Add(lblMessage)
        Controls.Add(btnLogout)
        Controls.Add(btnMyBookings)
        Controls.Add(btnBrowseApartments)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblWelcome)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CustomerForm"
        Text = "CustomerForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBrowseApartments As Button
    Friend WithEvents btnMyBookings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblMessage As Label
End Class

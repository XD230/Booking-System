<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerForm
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
        btnManageApartments = New Button()
        btnViewBookings = New Button()
        btnLogout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        lblWelcome = New Label()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnManageApartments
        ' 
        btnManageApartments.Location = New Point(312, 295)
        btnManageApartments.Name = "btnManageApartments"
        btnManageApartments.Size = New Size(168, 46)
        btnManageApartments.TabIndex = 0
        btnManageApartments.Text = "Manage Apartments"
        btnManageApartments.UseVisualStyleBackColor = True
        ' 
        ' btnViewBookings
        ' 
        btnViewBookings.Location = New Point(312, 371)
        btnViewBookings.Name = "btnViewBookings"
        btnViewBookings.Size = New Size(168, 46)
        btnViewBookings.TabIndex = 1
        btnViewBookings.Text = "View Bookings"
        btnViewBookings.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(312, 447)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(168, 46)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(312, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 41)
        Label1.TabIndex = 3
        Label1.Text = "Booking System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.WindowFrame
        Label2.Location = New Point(312, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 23)
        Label2.TabIndex = 4
        Label2.Text = "Manager Dashboard" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_08_153212
        PictureBox1.Location = New Point(42, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 171)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(24, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(749, 20)
        Label4.TabIndex = 11
        Label4.Text = "__________________________________________________________________________"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(53, 242)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 20)
        lblWelcome.TabIndex = 12
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(42, 539)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 13
        ' 
        ' ManagerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(785, 568)
        Controls.Add(lblMessage)
        Controls.Add(lblWelcome)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnViewBookings)
        Controls.Add(btnManageApartments)
        Name = "ManagerForm"
        Text = "ManagerForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnManageApartments As Button
    Friend WithEvents btnViewBookings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblMessage As Label
End Class

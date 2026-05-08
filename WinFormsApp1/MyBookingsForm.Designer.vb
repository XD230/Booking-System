<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyBookingsForm
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        dgvMyBookings = New DataGridView()
        Label3 = New Label()
        btnRefresh = New Button()
        btnBack = New Button()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMyBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 110)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.WindowFrame
        Label2.Location = New Point(151, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 23)
        Label2.TabIndex = 8
        Label2.Text = "My Bookings"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(151, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 41)
        Label1.TabIndex = 7
        Label1.Text = "Booking System"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(939, 20)
        Label4.TabIndex = 12
        Label4.Text = "_____________________________________________________________________________________________"
        ' 
        ' dgvMyBookings
        ' 
        dgvMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyBookings.Location = New Point(19, 226)
        dgvMyBookings.Name = "dgvMyBookings"
        dgvMyBookings.RowHeadersWidth = 51
        dgvMyBookings.Size = New Size(932, 273)
        dgvMyBookings.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label3.Location = New Point(19, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 23)
        Label3.TabIndex = 14
        Label3.Text = "My Booking Records"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(239, 507)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(192, 52)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(470, 507)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(192, 52)
        btnBack.TabIndex = 16
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(12, 563)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 17
        ' 
        ' MyBookingsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 603)
        Controls.Add(lblMessage)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(Label3)
        Controls.Add(dgvMyBookings)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "MyBookingsForm"
        Text = "MyBookingsForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMyBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvMyBookings As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblMessage As Label
End Class

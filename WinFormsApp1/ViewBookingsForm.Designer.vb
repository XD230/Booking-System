<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBookingsForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlCard = New RoundedPanel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lblSectionSubtitle = New Label()
        dgvBookings = New DataGridView()
        btnRefresh = New RoundedButton()
        btnApprove = New RoundedButton()
        btnReject = New RoundedButton()
        btnBack = New RoundedButton()
        pnlCard.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.BorderColor = Color.FromArgb(228, 232, 240)
        pnlCard.BorderThickness = 1
        pnlCard.Controls.Add(btnBack)
        pnlCard.Controls.Add(btnReject)
        pnlCard.Controls.Add(btnApprove)
        pnlCard.Controls.Add(btnRefresh)
        pnlCard.Controls.Add(dgvBookings)
        pnlCard.Controls.Add(lblSectionSubtitle)
        pnlCard.Controls.Add(Label3)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(20, 20)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1140, 800)
        pnlCard.TabIndex = 0
        '
        ' PictureBox1
        '
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(50, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(15, 34, 80)
        Label1.Location = New Point(210, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 60)
        Label1.TabIndex = 1
        Label1.Text = "Booking System"
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(110, 120, 140)
        Label2.Location = New Point(215, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 26)
        Label2.TabIndex = 2
        Label2.Text = "View Bookings"
        '
        ' Label4
        '
        Label4.BackColor = Color.FromArgb(228, 232, 240)
        Label4.Location = New Point(40, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(1060, 1)
        Label4.TabIndex = 3
        '
        ' Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(37, 99, 235)
        Label3.Location = New Point(40, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(280, 32)
        Label3.TabIndex = 4
        Label3.Text = "Customer Booking Records"
        '
        ' lblSectionSubtitle
        '
        lblSectionSubtitle.AutoSize = True
        lblSectionSubtitle.BackColor = Color.Transparent
        lblSectionSubtitle.Font = New Font("Segoe UI", 11F)
        lblSectionSubtitle.ForeColor = Color.FromArgb(110, 120, 140)
        lblSectionSubtitle.Location = New Point(40, 252)
        lblSectionSubtitle.Name = "lblSectionSubtitle"
        lblSectionSubtitle.Size = New Size(280, 20)
        lblSectionSubtitle.TabIndex = 5
        lblSectionSubtitle.Text = "Review, approve, or reject booking requests."
        '
        ' dgvBookings
        '
        dgvBookings.AllowUserToAddRows = False
        dgvBookings.AllowUserToDeleteRows = False
        dgvBookings.AllowUserToResizeRows = False
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBookings.BackgroundColor = Color.White
        dgvBookings.BorderStyle = BorderStyle.None
        dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 252)
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(60, 70, 90)
        DataGridViewCellStyle1.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 252)
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(60, 70, 90)
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvBookings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBookings.ColumnHeadersHeight = 46
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 50, 70)
        DataGridViewCellStyle2.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 241, 255)
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(40, 50, 70)
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvBookings.DefaultCellStyle = DataGridViewCellStyle2
        dgvBookings.EnableHeadersVisualStyles = False
        dgvBookings.GridColor = Color.FromArgb(228, 232, 240)
        dgvBookings.Location = New Point(40, 295)
        dgvBookings.MultiSelect = False
        dgvBookings.Name = "dgvBookings"
        dgvBookings.ReadOnly = True
        dgvBookings.RowHeadersVisible = False
        dgvBookings.RowTemplate.Height = 52
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBookings.Size = New Size(1060, 320)
        dgvBookings.TabIndex = 6
        '
        ' btnRefresh
        '
        btnRefresh.BackColor = Color.FromArgb(245, 248, 254)
        btnRefresh.BorderThickness = 1
        btnRefresh.CornerRadius = 0
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.FromArgb(37, 99, 235)
        btnRefresh.Location = New Point(40, 635)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(250, 60)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        '
        ' btnApprove
        '
        btnApprove.BackColor = Color.FromArgb(232, 248, 232)
        btnApprove.BorderThickness = 1
        btnApprove.CornerRadius = 0
        btnApprove.FlatAppearance.BorderSize = 0
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnApprove.ForeColor = Color.FromArgb(34, 139, 80)
        btnApprove.Location = New Point(305, 635)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(250, 60)
        btnApprove.TabIndex = 8
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = False
        '
        ' btnReject
        '
        btnReject.BackColor = Color.FromArgb(251, 232, 232)
        btnReject.BorderThickness = 1
        btnReject.CornerRadius = 0
        btnReject.FlatAppearance.BorderSize = 0
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnReject.ForeColor = Color.FromArgb(220, 60, 60)
        btnReject.Location = New Point(570, 635)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(250, 60)
        btnReject.TabIndex = 9
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = False
        '
        ' btnBack
        '
        btnBack.BackColor = Color.FromArgb(232, 241, 255)
        btnBack.BorderThickness = 1
        btnBack.CornerRadius = 0
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(37, 99, 235)
        btnBack.Location = New Point(835, 635)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(250, 60)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        '
        ' ViewBookingsForm
        '
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 244, 250)
        ClientSize = New Size(1180, 840)
        Controls.Add(pnlCard)
        Name = "ViewBookingsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewBookingsForm"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSectionSubtitle As Label
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents btnApprove As RoundedButton
    Friend WithEvents btnReject As RoundedButton
    Friend WithEvents btnBack As RoundedButton
End Class

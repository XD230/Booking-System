<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseApartmentsForm
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlCard = New RoundedPanel()
        btnBack = New RoundedButton()
        btnBook = New RoundedButton()
        lblTotalValue = New Label()
        lblTotalLabel = New Label()
        lblRightDivider = New Label()
        pnlNights = New RoundedPanel()
        numNights = New NumericUpDown()
        Label15 = New Label()
        pnlCheckIn = New RoundedPanel()
        dtpCheckIn = New DateTimePicker()
        Label14 = New Label()
        pnlDescription = New RoundedPanel()
        txtDescription = New TextBox()
        Label10 = New Label()
        lblPriceValue = New Label()
        lblLocationValue = New Label()
        lblApartmentNumberValue = New Label()
        lblHotelValue = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        picThumb3 = New CoverPictureBox()
        picThumb2 = New CoverPictureBox()
        picThumb1 = New CoverPictureBox()
        picApartmentMain = New CoverPictureBox()
        Label5 = New Label()
        dgvApartments = New DataGridView()
        Label4 = New Label()
        btnClearSearch = New RoundedButton()
        btnSearch = New RoundedButton()
        pnlSearch = New RoundedPanel()
        txtSearch = New TextBox()
        Label3 = New Label()
        lblHeaderDivider = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        pnlCard.SuspendLayout()
        pnlNights.SuspendLayout()
        CType(numNights, ComponentModel.ISupportInitialize).BeginInit()
        pnlCheckIn.SuspendLayout()
        pnlDescription.SuspendLayout()
        CType(picThumb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearch.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(btnBack)
        pnlCard.Controls.Add(btnBook)
        pnlCard.Controls.Add(lblTotalValue)
        pnlCard.Controls.Add(lblTotalLabel)
        pnlCard.Controls.Add(lblRightDivider)
        pnlCard.Controls.Add(pnlNights)
        pnlCard.Controls.Add(Label15)
        pnlCard.Controls.Add(pnlCheckIn)
        pnlCard.Controls.Add(Label14)
        pnlCard.Controls.Add(pnlDescription)
        pnlCard.Controls.Add(Label10)
        pnlCard.Controls.Add(lblPriceValue)
        pnlCard.Controls.Add(lblLocationValue)
        pnlCard.Controls.Add(lblApartmentNumberValue)
        pnlCard.Controls.Add(lblHotelValue)
        pnlCard.Controls.Add(Label9)
        pnlCard.Controls.Add(Label8)
        pnlCard.Controls.Add(Label7)
        pnlCard.Controls.Add(Label6)
        pnlCard.Controls.Add(picThumb3)
        pnlCard.Controls.Add(picThumb2)
        pnlCard.Controls.Add(picThumb1)
        pnlCard.Controls.Add(picApartmentMain)
        pnlCard.Controls.Add(Label5)
        pnlCard.Controls.Add(dgvApartments)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(btnClearSearch)
        pnlCard.Controls.Add(btnSearch)
        pnlCard.Controls.Add(pnlSearch)
        pnlCard.Controls.Add(Label3)
        pnlCard.Controls.Add(lblHeaderDivider)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(20, 19)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1380, 1026)
        pnlCard.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(246))
        btnBack.CornerRadius = 0
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        btnBack.Location = New Point(975, 841)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(360, 52)
        btnBack.TabIndex = 33
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnBook
        ' 
        btnBook.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBook.CornerRadius = 0
        btnBook.FlatAppearance.BorderSize = 0
        btnBook.FlatStyle = FlatStyle.Flat
        btnBook.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnBook.ForeColor = Color.White
        btnBook.Location = New Point(975, 774)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(360, 57)
        btnBook.TabIndex = 32
        btnBook.Text = "Book Apartment"
        btnBook.UseVisualStyleBackColor = False
        ' 
        ' lblTotalValue
        ' 
        lblTotalValue.AutoSize = True
        lblTotalValue.BackColor = Color.Transparent
        lblTotalValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTotalValue.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblTotalValue.Location = New Point(1140, 712)
        lblTotalValue.Name = "lblTotalValue"
        lblTotalValue.Size = New Size(89, 46)
        lblTotalValue.TabIndex = 31
        lblTotalValue.Text = "0.00"
        ' 
        ' lblTotalLabel
        ' 
        lblTotalLabel.AutoSize = True
        lblTotalLabel.BackColor = Color.Transparent
        lblTotalLabel.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalLabel.ForeColor = Color.FromArgb(CByte(15), CByte(34), CByte(80))
        lblTotalLabel.Location = New Point(975, 722)
        lblTotalLabel.Name = "lblTotalLabel"
        lblTotalLabel.Size = New Size(145, 35)
        lblTotalLabel.TabIndex = 30
        lblTotalLabel.Text = "Total Price:"
        ' 
        ' lblRightDivider
        ' 
        lblRightDivider.BackColor = Color.FromArgb(CByte(228), CByte(232), CByte(240))
        lblRightDivider.Location = New Point(975, 703)
        lblRightDivider.Name = "lblRightDivider"
        lblRightDivider.Size = New Size(360, 1)
        lblRightDivider.TabIndex = 29
        ' 
        ' pnlNights
        ' 
        pnlNights.BackColor = Color.White
        pnlNights.Controls.Add(numNights)
        pnlNights.CornerRadius = 0
        pnlNights.Location = New Point(1240, 646)
        pnlNights.Name = "pnlNights"
        pnlNights.Size = New Size(95, 40)
        pnlNights.TabIndex = 28
        ' 
        ' numNights
        ' 
        numNights.BorderStyle = BorderStyle.None
        numNights.Font = New Font("Segoe UI", 11F)
        numNights.Location = New Point(12, 10)
        numNights.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        numNights.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numNights.Name = "numNights"
        numNights.Size = New Size(70, 26)
        numNights.TabIndex = 0
        numNights.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label15.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label15.Location = New Point(975, 651)
        Label15.Name = "Label15"
        Label15.Size = New Size(161, 23)
        Label15.TabIndex = 27
        Label15.Text = "Number of Nights:"
        ' 
        ' pnlCheckIn
        ' 
        pnlCheckIn.BackColor = Color.White
        pnlCheckIn.Controls.Add(dtpCheckIn)
        pnlCheckIn.CornerRadius = 0
        pnlCheckIn.Location = New Point(975, 594)
        pnlCheckIn.Name = "pnlCheckIn"
        pnlCheckIn.Size = New Size(360, 40)
        pnlCheckIn.TabIndex = 26
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.CalendarFont = New Font("Segoe UI", 11F)
        dtpCheckIn.Font = New Font("Segoe UI", 11F)
        dtpCheckIn.Format = DateTimePickerFormat.Short
        dtpCheckIn.Location = New Point(12, 5)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(336, 30)
        dtpCheckIn.TabIndex = 0
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label14.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label14.Location = New Point(975, 570)
        Label14.Name = "Label14"
        Label14.Size = New Size(127, 23)
        Label14.TabIndex = 25
        Label14.Text = "Check-in Date:"
        ' 
        ' pnlDescription
        ' 
        pnlDescription.BackColor = Color.White
        pnlDescription.BorderThickness = 0
        pnlDescription.Controls.Add(txtDescription)
        pnlDescription.CornerRadius = 0
        pnlDescription.Location = New Point(500, 760)
        pnlDescription.Name = "pnlDescription"
        pnlDescription.Size = New Size(420, 128)
        pnlDescription.TabIndex = 24
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = Color.White
        txtDescription.BorderStyle = BorderStyle.None
        txtDescription.Font = New Font("Segoe UI", 11F)
        txtDescription.Location = New Point(0, 0)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(420, 128)
        txtDescription.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label10.Location = New Point(500, 732)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 23)
        Label10.TabIndex = 19
        Label10.Text = "Description:"
        ' 
        ' lblPriceValue
        ' 
        lblPriceValue.AutoSize = True
        lblPriceValue.BackColor = Color.Transparent
        lblPriceValue.Font = New Font("Segoe UI", 11F)
        lblPriceValue.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        lblPriceValue.Location = New Point(680, 684)
        lblPriceValue.Name = "lblPriceValue"
        lblPriceValue.Size = New Size(17, 23)
        lblPriceValue.TabIndex = 23
        lblPriceValue.Text = "-"
        ' 
        ' lblLocationValue
        ' 
        lblLocationValue.AutoSize = True
        lblLocationValue.BackColor = Color.Transparent
        lblLocationValue.Font = New Font("Segoe UI", 11F)
        lblLocationValue.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        lblLocationValue.Location = New Point(680, 646)
        lblLocationValue.Name = "lblLocationValue"
        lblLocationValue.Size = New Size(17, 23)
        lblLocationValue.TabIndex = 22
        lblLocationValue.Text = "-"
        ' 
        ' lblApartmentNumberValue
        ' 
        lblApartmentNumberValue.AutoSize = True
        lblApartmentNumberValue.BackColor = Color.Transparent
        lblApartmentNumberValue.Font = New Font("Segoe UI", 11F)
        lblApartmentNumberValue.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        lblApartmentNumberValue.Location = New Point(680, 608)
        lblApartmentNumberValue.Name = "lblApartmentNumberValue"
        lblApartmentNumberValue.Size = New Size(17, 23)
        lblApartmentNumberValue.TabIndex = 21
        lblApartmentNumberValue.Text = "-"
        ' 
        ' lblHotelValue
        ' 
        lblHotelValue.AutoSize = True
        lblHotelValue.BackColor = Color.Transparent
        lblHotelValue.Font = New Font("Segoe UI", 11F)
        lblHotelValue.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        lblHotelValue.Location = New Point(680, 570)
        lblHotelValue.Name = "lblHotelValue"
        lblHotelValue.Size = New Size(17, 23)
        lblHotelValue.TabIndex = 20
        lblHotelValue.Text = "-"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label9.Location = New Point(500, 684)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 23)
        Label9.TabIndex = 18
        Label9.Text = "Price per Night:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label8.Location = New Point(500, 646)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 23)
        Label8.TabIndex = 17
        Label8.Text = "Location:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label7.Location = New Point(500, 608)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 23)
        Label7.TabIndex = 16
        Label7.Text = "Apartment Number:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label6.Location = New Point(500, 570)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 23)
        Label6.TabIndex = 15
        Label6.Text = "Hotel Name:"
        ' 
        ' picThumb3
        ' 
        picThumb3.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb3.BorderStyle = BorderStyle.FixedSingle
        picThumb3.Location = New Point(330, 793)
        picThumb3.Name = "picThumb3"
        picThumb3.Size = New Size(130, 95)
        picThumb3.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb3.TabIndex = 14
        picThumb3.TabStop = False
        ' 
        ' picThumb2
        ' 
        picThumb2.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb2.BorderStyle = BorderStyle.FixedSingle
        picThumb2.Location = New Point(185, 793)
        picThumb2.Name = "picThumb2"
        picThumb2.Size = New Size(130, 95)
        picThumb2.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb2.TabIndex = 13
        picThumb2.TabStop = False
        ' 
        ' picThumb1
        ' 
        picThumb1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb1.BorderStyle = BorderStyle.FixedSingle
        picThumb1.Location = New Point(40, 793)
        picThumb1.Name = "picThumb1"
        picThumb1.Size = New Size(130, 95)
        picThumb1.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb1.TabIndex = 12
        picThumb1.TabStop = False
        ' 
        ' picApartmentMain
        ' 
        picApartmentMain.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picApartmentMain.BorderStyle = BorderStyle.FixedSingle
        picApartmentMain.Location = New Point(40, 560)
        picApartmentMain.Name = "picApartmentMain"
        picApartmentMain.Size = New Size(420, 219)
        picApartmentMain.SizeMode = PictureBoxSizeMode.StretchImage
        picApartmentMain.TabIndex = 11
        picApartmentMain.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(15), CByte(34), CByte(80))
        Label5.Location = New Point(40, 527)
        Label5.Name = "Label5"
        Label5.Size = New Size(204, 30)
        Label5.TabIndex = 10
        Label5.Text = "Apartment Details"
        ' 
        ' dgvApartments
        ' 
        dgvApartments.AllowUserToAddRows = False
        dgvApartments.AllowUserToDeleteRows = False
        dgvApartments.AllowUserToResizeRows = False
        dgvApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApartments.BackgroundColor = Color.White
        dgvApartments.BorderStyle = BorderStyle.None
        dgvApartments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvApartments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        DataGridViewCellStyle3.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvApartments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvApartments.ColumnHeadersHeight = 46
        dgvApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        DataGridViewCellStyle4.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvApartments.DefaultCellStyle = DataGridViewCellStyle4
        dgvApartments.EnableHeadersVisualStyles = False
        dgvApartments.GridColor = Color.FromArgb(CByte(228), CByte(232), CByte(240))
        dgvApartments.Location = New Point(40, 285)
        dgvApartments.MultiSelect = False
        dgvApartments.Name = "dgvApartments"
        dgvApartments.ReadOnly = True
        dgvApartments.RowHeadersVisible = False
        dgvApartments.RowHeadersWidth = 47
        dgvApartments.RowTemplate.Height = 48
        dgvApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApartments.Size = New Size(1300, 218)
        dgvApartments.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(15), CByte(34), CByte(80))
        Label4.Location = New Point(40, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(238, 30)
        Label4.TabIndex = 8
        Label4.Text = "Available Apartments"
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(246))
        btnClearSearch.CornerRadius = 0
        btnClearSearch.FlatAppearance.BorderSize = 0
        btnClearSearch.FlatStyle = FlatStyle.Flat
        btnClearSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClearSearch.ForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        btnClearSearch.Location = New Point(1100, 180)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(180, 44)
        btnClearSearch.TabIndex = 7
        btnClearSearch.Text = "Clear"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSearch.CornerRadius = 0
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(905, 180)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(180, 44)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.White
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.CornerRadius = 0
        pnlSearch.Location = New Point(283, 182)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(602, 40)
        pnlSearch.TabIndex = 5
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.Location = New Point(14, 10)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Enter hotel name or location..."
        txtSearch.Size = New Size(612, 23)
        txtSearch.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label3.Location = New Point(40, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(237, 25)
        Label3.TabIndex = 4
        Label3.Text = "Search Hotel or Location:"
        ' 
        ' lblHeaderDivider
        ' 
        lblHeaderDivider.BackColor = Color.FromArgb(CByte(228), CByte(232), CByte(240))
        lblHeaderDivider.Location = New Point(40, 162)
        lblHeaderDivider.Name = "lblHeaderDivider"
        lblHeaderDivider.Size = New Size(1300, 1)
        lblHeaderDivider.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(110), CByte(120), CByte(140))
        Label2.Location = New Point(205, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 30)
        Label2.TabIndex = 2
        Label2.Text = "Browse Apartments"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(15), CByte(34), CByte(80))
        Label1.Location = New Point(200, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 54)
        Label1.TabIndex = 1
        Label1.Text = "Booking System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_06_2223293
        PictureBox1.Location = New Point(40, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 124)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BrowseApartmentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(250))
        ClientSize = New Size(1420, 1083)
        Controls.Add(pnlCard)
        Name = "BrowseApartmentsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BrowseApartmentsForm"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlNights.ResumeLayout(False)
        CType(numNights, ComponentModel.ISupportInitialize).EndInit()
        pnlCheckIn.ResumeLayout(False)
        pnlDescription.ResumeLayout(False)
        pnlDescription.PerformLayout()
        CType(picThumb3, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).EndInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).EndInit()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHeaderDivider As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlSearch As RoundedPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents btnClearSearch As RoundedButton
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvApartments As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents picApartmentMain As CoverPictureBox
    Friend WithEvents picThumb1 As CoverPictureBox
    Friend WithEvents picThumb2 As CoverPictureBox
    Friend WithEvents picThumb3 As CoverPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHotelValue As Label
    Friend WithEvents lblApartmentNumberValue As Label
    Friend WithEvents lblLocationValue As Label
    Friend WithEvents lblPriceValue As Label
    Friend WithEvents pnlDescription As RoundedPanel
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlCheckIn As RoundedPanel
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents pnlNights As RoundedPanel
    Friend WithEvents numNights As NumericUpDown
    Friend WithEvents lblRightDivider As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents btnBook As RoundedButton
    Friend WithEvents btnBack As RoundedButton
End Class

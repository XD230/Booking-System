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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnClearSearch = New Button()
        Label4 = New Label()
        dgvApartments = New DataGridView()
        Label5 = New Label()
        picApartmentMain = New PictureBox()
        picThumb1 = New PictureBox()
        picThumb2 = New PictureBox()
        picThumb3 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtDescription = New TextBox()
        lblHotelValue = New Label()
        lblLocationValue = New Label()
        lblPriceValue = New Label()
        lblApartmentNumberValue = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        dtpCheckIn = New DateTimePicker()
        Label15 = New Label()
        numNights = New NumericUpDown()
        btnBook = New Button()
        btnBack = New Button()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).BeginInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 101)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.WindowFrame
        Label2.Location = New Point(199, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 23)
        Label2.TabIndex = 6
        Label2.Text = "Browse Apartments"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(199, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 41)
        Label1.TabIndex = 5
        Label1.Text = "Booking System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 20)
        Label3.TabIndex = 7
        Label3.Text = "Search Hotel or Location:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.WindowFrame
        txtSearch.Location = New Point(223, 151)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(482, 27)
        txtSearch.TabIndex = 8
        txtSearch.Text = "Enter Name or Location .."
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(732, 152)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(157, 26)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Location = New Point(903, 151)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(157, 26)
        btnClearSearch.TabIndex = 10
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Location = New Point(25, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 25)
        Label4.TabIndex = 11
        Label4.Text = "Available Apartments" & vbLf
        ' 
        ' dgvApartments
        ' 
        dgvApartments.AllowUserToAddRows = False
        dgvApartments.AllowUserToDeleteRows = False
        dgvApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApartments.Location = New Point(21, 240)
        dgvApartments.Name = "dgvApartments"
        dgvApartments.ReadOnly = True
        dgvApartments.RowHeadersWidth = 51
        dgvApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApartments.Size = New Size(1135, 226)
        dgvApartments.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label5.Location = New Point(25, 471)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 25)
        Label5.TabIndex = 13
        Label5.Text = "Apartments Details"
        ' 
        ' picApartmentMain
        ' 
        picApartmentMain.Location = New Point(35, 503)
        picApartmentMain.Name = "picApartmentMain"
        picApartmentMain.Size = New Size(388, 131)
        picApartmentMain.TabIndex = 14
        picApartmentMain.TabStop = False
        ' 
        ' picThumb1
        ' 
        picThumb1.Location = New Point(36, 647)
        picThumb1.Name = "picThumb1"
        picThumb1.Size = New Size(109, 91)
        picThumb1.TabIndex = 15
        picThumb1.TabStop = False
        ' 
        ' picThumb2
        ' 
        picThumb2.Location = New Point(176, 647)
        picThumb2.Name = "picThumb2"
        picThumb2.Size = New Size(109, 91)
        picThumb2.TabIndex = 16
        picThumb2.TabStop = False
        ' 
        ' picThumb3
        ' 
        picThumb3.Location = New Point(314, 647)
        picThumb3.Name = "picThumb3"
        picThumb3.Size = New Size(109, 91)
        picThumb3.TabIndex = 17
        picThumb3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(453, 509)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 18
        Label6.Text = "Hotel Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(453, 546)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 20)
        Label7.TabIndex = 19
        Label7.Text = "Apartment Number:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(453, 583)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 20
        Label8.Text = "Location:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(453, 619)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 20)
        Label9.TabIndex = 21
        Label9.Text = "Price per Night:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(453, 652)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 22
        Label10.Text = "Description:"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(459, 677)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(280, 77)
        txtDescription.TabIndex = 23
        ' 
        ' lblHotelValue
        ' 
        lblHotelValue.AutoSize = True
        lblHotelValue.Location = New Point(609, 509)
        lblHotelValue.Name = "lblHotelValue"
        lblHotelValue.Size = New Size(0, 20)
        lblHotelValue.TabIndex = 24
        ' 
        ' lblLocationValue
        ' 
        lblLocationValue.AutoSize = True
        lblLocationValue.Location = New Point(609, 583)
        lblLocationValue.Name = "lblLocationValue"
        lblLocationValue.Size = New Size(0, 20)
        lblLocationValue.TabIndex = 25
        ' 
        ' lblPriceValue
        ' 
        lblPriceValue.AutoSize = True
        lblPriceValue.Location = New Point(609, 619)
        lblPriceValue.Name = "lblPriceValue"
        lblPriceValue.Size = New Size(0, 20)
        lblPriceValue.TabIndex = 26
        ' 
        ' lblApartmentNumberValue
        ' 
        lblApartmentNumberValue.AutoSize = True
        lblApartmentNumberValue.Location = New Point(609, 546)
        lblApartmentNumberValue.Name = "lblApartmentNumberValue"
        lblApartmentNumberValue.Size = New Size(0, 20)
        lblApartmentNumberValue.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoEllipsis = True
        Label11.BackColor = SystemColors.GradientInactiveCaption
        Label11.Location = New Point(21, 471)
        Label11.Name = "Label11"
        Label11.Size = New Size(1135, 298)
        Label11.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDark
        Label12.Location = New Point(13, 207)
        Label12.Name = "Label12"
        Label12.Size = New Size(1150, 574)
        Label12.TabIndex = 30
        ' 
        ' Label13
        ' 
        Label13.BackColor = SystemColors.ControlDark
        Label13.Location = New Point(13, 137)
        Label13.Name = "Label13"
        Label13.Size = New Size(1150, 51)
        Label13.TabIndex = 31
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(903, 509)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 20)
        Label14.TabIndex = 32
        Label14.Text = "Check-in Date:"
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Format = DateTimePickerFormat.Short
        dtpCheckIn.Location = New Point(903, 541)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(204, 27)
        dtpCheckIn.TabIndex = 33
        dtpCheckIn.Value = New Date(2026, 5, 8, 21, 24, 31, 0)
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(903, 583)
        Label15.Name = "Label15"
        Label15.Size = New Size(131, 20)
        Label15.TabIndex = 34
        Label15.Text = "Number of Nights:"
        ' 
        ' numNights
        ' 
        numNights.Location = New Point(1051, 581)
        numNights.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numNights.Name = "numNights"
        numNights.Size = New Size(86, 27)
        numNights.TabIndex = 35
        numNights.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(905, 619)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(202, 45)
        btnBook.TabIndex = 36
        btnBook.Text = "Book Apartment"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(903, 677)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(202, 45)
        btnBack.TabIndex = 37
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(25, 798)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 38
        ' 
        ' BrowseApartmentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 838)
        Controls.Add(lblMessage)
        Controls.Add(btnBack)
        Controls.Add(btnBook)
        Controls.Add(numNights)
        Controls.Add(Label15)
        Controls.Add(dtpCheckIn)
        Controls.Add(Label14)
        Controls.Add(lblApartmentNumberValue)
        Controls.Add(lblPriceValue)
        Controls.Add(lblLocationValue)
        Controls.Add(lblHotelValue)
        Controls.Add(txtDescription)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(picThumb3)
        Controls.Add(picThumb2)
        Controls.Add(picThumb1)
        Controls.Add(picApartmentMain)
        Controls.Add(Label5)
        Controls.Add(dgvApartments)
        Controls.Add(Label4)
        Controls.Add(btnClearSearch)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Name = "BrowseApartmentsForm"
        Text = "BrowseApartmentsForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).EndInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).EndInit()
        CType(numNights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvApartments As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents picApartmentMain As PictureBox
    Friend WithEvents picThumb1 As PictureBox
    Friend WithEvents picThumb2 As PictureBox
    Friend WithEvents picThumb3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblHotelValue As Label
    Friend WithEvents lblLocationValue As Label
    Friend WithEvents lblPriceValue As Label
    Friend WithEvents lblApartmentNumberValue As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents numNights As NumericUpDown
    Friend WithEvents btnBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblMessage As Label
End Class

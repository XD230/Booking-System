<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageApartmentsForm
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
        btnBack = New RoundedButton()
        lblBottomDivider = New Label()
        dgvApartments = New DataGridView()
        btnRemoveImage = New RoundedButton()
        btnBrowseImage = New RoundedButton()
        picThumb3 = New CoverPictureBox()
        picThumb2 = New CoverPictureBox()
        picThumb1 = New CoverPictureBox()
        picApartmentMain = New CoverPictureBox()
        Label8 = New Label()
        btnClear = New RoundedButton()
        btnDelete = New RoundedButton()
        btnEdit = New RoundedButton()
        btnAdd = New RoundedButton()
        pnlDescription = New RoundedPanel()
        txtDescription = New TextBox()
        pnlPrice = New RoundedPanel()
        txtPrice = New TextBox()
        pnlLocation = New RoundedPanel()
        txtLocation = New TextBox()
        pnlApartmentNumber = New RoundedPanel()
        txtApartmentNumber = New TextBox()
        pnlHotelName = New RoundedPanel()
        txtHotelName = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblHeaderDivider = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        pnlCard.SuspendLayout()
        CType(dgvApartments, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).BeginInit()
        pnlDescription.SuspendLayout()
        pnlPrice.SuspendLayout()
        pnlLocation.SuspendLayout()
        pnlApartmentNumber.SuspendLayout()
        pnlHotelName.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(btnBack)
        pnlCard.Controls.Add(lblBottomDivider)
        pnlCard.Controls.Add(dgvApartments)
        pnlCard.Controls.Add(btnRemoveImage)
        pnlCard.Controls.Add(btnBrowseImage)
        pnlCard.Controls.Add(picThumb3)
        pnlCard.Controls.Add(picThumb2)
        pnlCard.Controls.Add(picThumb1)
        pnlCard.Controls.Add(picApartmentMain)
        pnlCard.Controls.Add(Label8)
        pnlCard.Controls.Add(btnClear)
        pnlCard.Controls.Add(btnDelete)
        pnlCard.Controls.Add(btnEdit)
        pnlCard.Controls.Add(btnAdd)
        pnlCard.Controls.Add(pnlDescription)
        pnlCard.Controls.Add(pnlPrice)
        pnlCard.Controls.Add(pnlLocation)
        pnlCard.Controls.Add(pnlApartmentNumber)
        pnlCard.Controls.Add(pnlHotelName)
        pnlCard.Controls.Add(Label7)
        pnlCard.Controls.Add(Label4)
        pnlCard.Controls.Add(Label3)
        pnlCard.Controls.Add(Label2)
        pnlCard.Controls.Add(Label1)
        pnlCard.Controls.Add(lblHeaderDivider)
        pnlCard.Controls.Add(Label5)
        pnlCard.Controls.Add(Label6)
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.CornerRadius = 0
        pnlCard.Location = New Point(20, 19)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1140, 874)
        pnlCard.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.White
        btnBack.BorderThickness = 1
        btnBack.CornerRadius = 0
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        btnBack.IconGlyph = ""
        btnBack.Location = New Point(50, 803)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(150, 43)
        btnBack.TabIndex = 27
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblBottomDivider
        ' 
        lblBottomDivider.BackColor = Color.FromArgb(CByte(228), CByte(232), CByte(240))
        lblBottomDivider.Location = New Point(50, 788)
        lblBottomDivider.Name = "lblBottomDivider"
        lblBottomDivider.Size = New Size(980, 1)
        lblBottomDivider.TabIndex = 26
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        DataGridViewCellStyle1.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(60), CByte(70), CByte(90))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvApartments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvApartments.ColumnHeadersHeight = 46
        dgvApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        DataGridViewCellStyle2.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(232), CByte(241), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvApartments.DefaultCellStyle = DataGridViewCellStyle2
        dgvApartments.EnableHeadersVisualStyles = False
        dgvApartments.GridColor = Color.FromArgb(CByte(228), CByte(232), CByte(240))
        dgvApartments.Location = New Point(50, 646)
        dgvApartments.MultiSelect = False
        dgvApartments.Name = "dgvApartments"
        dgvApartments.ReadOnly = True
        dgvApartments.RowHeadersVisible = False
        dgvApartments.RowHeadersWidth = 47
        dgvApartments.RowTemplate.Height = 42
        dgvApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApartments.Size = New Size(980, 124)
        dgvApartments.TabIndex = 25
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.BackColor = Color.White
        btnRemoveImage.BorderThickness = 2
        btnRemoveImage.CornerRadius = 0
        btnRemoveImage.FlatAppearance.BorderSize = 0
        btnRemoveImage.FlatStyle = FlatStyle.Flat
        btnRemoveImage.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnRemoveImage.ForeColor = Color.FromArgb(CByte(220), CByte(60), CByte(60))
        btnRemoveImage.IconGlyph = ""
        btnRemoveImage.Location = New Point(859, 575)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New Size(220, 52)
        btnRemoveImage.TabIndex = 24
        btnRemoveImage.Text = "Remove Image"
        btnRemoveImage.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.BackColor = Color.White
        btnBrowseImage.BorderThickness = 2
        btnBrowseImage.CornerRadius = 0
        btnBrowseImage.FlatAppearance.BorderSize = 0
        btnBrowseImage.FlatStyle = FlatStyle.Flat
        btnBrowseImage.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnBrowseImage.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnBrowseImage.IconGlyph = ""
        btnBrowseImage.Location = New Point(619, 575)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(220, 52)
        btnBrowseImage.TabIndex = 23
        btnBrowseImage.Text = "Browse Image"
        btnBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' picThumb3
        ' 
        picThumb3.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb3.BorderStyle = BorderStyle.FixedSingle
        picThumb3.Location = New Point(935, 428)
        picThumb3.Name = "picThumb3"
        picThumb3.Size = New Size(145, 119)
        picThumb3.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb3.TabIndex = 22
        picThumb3.TabStop = False
        ' 
        ' picThumb2
        ' 
        picThumb2.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb2.BorderStyle = BorderStyle.FixedSingle
        picThumb2.Location = New Point(777, 428)
        picThumb2.Name = "picThumb2"
        picThumb2.Size = New Size(145, 119)
        picThumb2.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb2.TabIndex = 21
        picThumb2.TabStop = False
        ' 
        ' picThumb1
        ' 
        picThumb1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picThumb1.BorderStyle = BorderStyle.FixedSingle
        picThumb1.Location = New Point(619, 428)
        picThumb1.Name = "picThumb1"
        picThumb1.Size = New Size(145, 119)
        picThumb1.SizeMode = PictureBoxSizeMode.StretchImage
        picThumb1.TabIndex = 20
        picThumb1.TabStop = False
        ' 
        ' picApartmentMain
        ' 
        picApartmentMain.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        picApartmentMain.BorderStyle = BorderStyle.FixedSingle
        picApartmentMain.Location = New Point(619, 242)
        picApartmentMain.Name = "picApartmentMain"
        picApartmentMain.Size = New Size(460, 171)
        picApartmentMain.SizeMode = PictureBoxSizeMode.StretchImage
        picApartmentMain.TabIndex = 19
        picApartmentMain.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label8.Location = New Point(619, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(208, 30)
        Label8.TabIndex = 9
        Label8.Text = "Apartment Images"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.BorderThickness = 2
        btnClear.CornerRadius = 0
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnClear.IconGlyph = ""
        btnClear.IconSpacing = 10
        btnClear.Location = New Point(449, 546)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(121, 52)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.White
        btnDelete.BorderThickness = 2
        btnDelete.CornerRadius = 0
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnDelete.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnDelete.IconGlyph = ""
        btnDelete.IconSpacing = 10
        btnDelete.Location = New Point(318, 546)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(121, 52)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.White
        btnEdit.BorderThickness = 2
        btnEdit.CornerRadius = 0
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnEdit.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnEdit.IconGlyph = ""
        btnEdit.IconSpacing = 10
        btnEdit.Location = New Point(185, 546)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(121, 52)
        btnEdit.TabIndex = 16
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnAdd.CornerRadius = 0
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.IconGlyph = ""
        btnAdd.IconSpacing = 10
        btnAdd.Location = New Point(50, 546)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(121, 52)
        btnAdd.TabIndex = 15
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' pnlDescription
        ' 
        pnlDescription.BackColor = Color.White
        pnlDescription.Controls.Add(txtDescription)
        pnlDescription.CornerRadius = 0
        pnlDescription.Location = New Point(230, 390)
        pnlDescription.Name = "pnlDescription"
        pnlDescription.Size = New Size(340, 124)
        pnlDescription.TabIndex = 14
        ' 
        ' txtDescription
        ' 
        txtDescription.AcceptsReturn = True
        txtDescription.BackColor = Color.White
        txtDescription.BorderStyle = BorderStyle.None
        txtDescription.Font = New Font("Segoe UI", 11F)
        txtDescription.Location = New Point(14, 9)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "Enter description"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(312, 106)
        txtDescription.TabIndex = 0
        ' 
        ' pnlPrice
        ' 
        pnlPrice.BackColor = Color.White
        pnlPrice.Controls.Add(txtPrice)
        pnlPrice.CornerRadius = 0
        pnlPrice.Location = New Point(230, 340)
        pnlPrice.Name = "pnlPrice"
        pnlPrice.Size = New Size(340, 38)
        pnlPrice.TabIndex = 13
        ' 
        ' txtPrice
        ' 
        txtPrice.BackColor = Color.White
        txtPrice.BorderStyle = BorderStyle.None
        txtPrice.Font = New Font("Segoe UI", 11F)
        txtPrice.Location = New Point(14, 9)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Enter price"
        txtPrice.Size = New Size(312, 23)
        txtPrice.TabIndex = 0
        ' 
        ' pnlLocation
        ' 
        pnlLocation.BackColor = Color.White
        pnlLocation.Controls.Add(txtLocation)
        pnlLocation.CornerRadius = 0
        pnlLocation.Location = New Point(230, 294)
        pnlLocation.Name = "pnlLocation"
        pnlLocation.Size = New Size(340, 38)
        pnlLocation.TabIndex = 12
        ' 
        ' txtLocation
        ' 
        txtLocation.BackColor = Color.White
        txtLocation.BorderStyle = BorderStyle.None
        txtLocation.Font = New Font("Segoe UI", 11F)
        txtLocation.Location = New Point(14, 9)
        txtLocation.Name = "txtLocation"
        txtLocation.PlaceholderText = "Enter location"
        txtLocation.Size = New Size(312, 23)
        txtLocation.TabIndex = 0
        ' 
        ' pnlApartmentNumber
        ' 
        pnlApartmentNumber.BackColor = Color.White
        pnlApartmentNumber.Controls.Add(txtApartmentNumber)
        pnlApartmentNumber.CornerRadius = 0
        pnlApartmentNumber.Location = New Point(230, 250)
        pnlApartmentNumber.Name = "pnlApartmentNumber"
        pnlApartmentNumber.Size = New Size(340, 38)
        pnlApartmentNumber.TabIndex = 11
        ' 
        ' txtApartmentNumber
        ' 
        txtApartmentNumber.BackColor = Color.White
        txtApartmentNumber.BorderStyle = BorderStyle.None
        txtApartmentNumber.Font = New Font("Segoe UI", 11F)
        txtApartmentNumber.Location = New Point(14, 9)
        txtApartmentNumber.Name = "txtApartmentNumber"
        txtApartmentNumber.PlaceholderText = "Enter apartment name"
        txtApartmentNumber.Size = New Size(312, 23)
        txtApartmentNumber.TabIndex = 0
        ' 
        ' pnlHotelName
        ' 
        pnlHotelName.BackColor = Color.White
        pnlHotelName.Controls.Add(txtHotelName)
        pnlHotelName.CornerRadius = 0
        pnlHotelName.Location = New Point(230, 204)
        pnlHotelName.Name = "pnlHotelName"
        pnlHotelName.Size = New Size(340, 38)
        pnlHotelName.TabIndex = 10
        ' 
        ' txtHotelName
        ' 
        txtHotelName.BackColor = Color.White
        txtHotelName.BorderStyle = BorderStyle.None
        txtHotelName.Font = New Font("Segoe UI", 11F)
        txtHotelName.Location = New Point(14, 9)
        txtHotelName.Name = "txtHotelName"
        txtHotelName.PlaceholderText = "Enter hotel name"
        txtHotelName.Size = New Size(312, 23)
        txtHotelName.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label7.Location = New Point(50, 397)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 25)
        Label7.TabIndex = 8
        Label7.Text = "Description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label4.Location = New Point(50, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 25)
        Label4.TabIndex = 7
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label3.Location = New Point(50, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 25)
        Label3.TabIndex = 6
        Label3.Text = "Location"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label2.Location = New Point(50, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 25)
        Label2.TabIndex = 5
        Label2.Text = "Apartment Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(40), CByte(50), CByte(70))
        Label1.Location = New Point(50, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 25)
        Label1.TabIndex = 4
        Label1.Text = "Hotel Name"
        ' 
        ' lblHeaderDivider
        ' 
        lblHeaderDivider.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblHeaderDivider.Location = New Point(50, 176)
        lblHeaderDivider.Name = "lblHeaderDivider"
        lblHeaderDivider.Size = New Size(1032, 10)
        lblHeaderDivider.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(110), CByte(120), CByte(140))
        Label5.Location = New Point(215, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 30)
        Label5.TabIndex = 2
        Label5.Text = "Manage Apartments"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(15), CByte(34), CByte(80))
        Label6.Location = New Point(210, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(350, 59)
        Label6.TabIndex = 1
        Label6.Text = "Booking System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_08_153212
        PictureBox1.Location = New Point(50, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ManageApartmentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(250))
        ClientSize = New Size(1180, 912)
        Controls.Add(pnlCard)
        Name = "ManageApartmentsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageApartmentsForm"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        CType(dgvApartments, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).EndInit()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).EndInit()
        pnlDescription.ResumeLayout(False)
        pnlDescription.PerformLayout()
        pnlPrice.ResumeLayout(False)
        pnlPrice.PerformLayout()
        pnlLocation.ResumeLayout(False)
        pnlLocation.PerformLayout()
        pnlApartmentNumber.ResumeLayout(False)
        pnlApartmentNumber.PerformLayout()
        pnlHotelName.ResumeLayout(False)
        pnlHotelName.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblHeaderDivider As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlHotelName As RoundedPanel
    Friend WithEvents txtHotelName As TextBox
    Friend WithEvents pnlApartmentNumber As RoundedPanel
    Friend WithEvents txtApartmentNumber As TextBox
    Friend WithEvents pnlLocation As RoundedPanel
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents pnlPrice As RoundedPanel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents pnlDescription As RoundedPanel
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnAdd As RoundedButton
    Friend WithEvents btnEdit As RoundedButton
    Friend WithEvents btnDelete As RoundedButton
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents picApartmentMain As CoverPictureBox
    Friend WithEvents picThumb1 As CoverPictureBox
    Friend WithEvents picThumb2 As CoverPictureBox
    Friend WithEvents picThumb3 As CoverPictureBox
    Friend WithEvents btnBrowseImage As RoundedButton
    Friend WithEvents btnRemoveImage As RoundedButton
    Friend WithEvents dgvApartments As DataGridView
    Friend WithEvents lblBottomDivider As Label
    Friend WithEvents btnBack As RoundedButton
End Class

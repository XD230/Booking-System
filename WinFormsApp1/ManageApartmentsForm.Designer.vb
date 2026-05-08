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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblMessage = New Label()
        txtHotelName = New TextBox()
        txtDescription = New TextBox()
        txtPrice = New TextBox()
        txtLocation = New TextBox()
        txtApartmentNumber = New TextBox()
        picApartmentMain = New PictureBox()
        picThumb1 = New PictureBox()
        picThumb2 = New PictureBox()
        picThumb3 = New PictureBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnBrowseImage = New Button()
        btnRemoveImage = New Button()
        dgvApartments = New DataGridView()
        btnBack = New Button()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        CType(picApartmentMain, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hotel Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 1
        Label2.Text = "Apartment Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 2
        Label3.Text = "Location"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 3
        Label4.Text = "Price"
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(263, 798)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 4
        ' 
        ' txtHotelName
        ' 
        txtHotelName.Location = New Point(193, 187)
        txtHotelName.Name = "txtHotelName"
        txtHotelName.Size = New Size(376, 27)
        txtHotelName.TabIndex = 5
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(193, 345)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(376, 100)
        txtDescription.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(193, 307)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(376, 27)
        txtPrice.TabIndex = 7
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(193, 265)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(376, 27)
        txtLocation.TabIndex = 8
        ' 
        ' txtApartmentNumber
        ' 
        txtApartmentNumber.Location = New Point(193, 226)
        txtApartmentNumber.Name = "txtApartmentNumber"
        txtApartmentNumber.Size = New Size(376, 27)
        txtApartmentNumber.TabIndex = 9
        ' 
        ' picApartmentMain
        ' 
        picApartmentMain.Location = New Point(662, 195)
        picApartmentMain.Name = "picApartmentMain"
        picApartmentMain.Size = New Size(476, 183)
        picApartmentMain.TabIndex = 10
        picApartmentMain.TabStop = False
        ' 
        ' picThumb1
        ' 
        picThumb1.Location = New Point(662, 384)
        picThumb1.Name = "picThumb1"
        picThumb1.Size = New Size(131, 119)
        picThumb1.TabIndex = 11
        picThumb1.TabStop = False
        ' 
        ' picThumb2
        ' 
        picThumb2.Location = New Point(839, 384)
        picThumb2.Name = "picThumb2"
        picThumb2.Size = New Size(126, 119)
        picThumb2.TabIndex = 13
        picThumb2.TabStop = False
        ' 
        ' picThumb3
        ' 
        picThumb3.Location = New Point(1007, 384)
        picThumb3.Name = "picThumb3"
        picThumb3.Size = New Size(131, 119)
        picThumb3.TabIndex = 15
        picThumb3.TabStop = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(32, 490)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(133, 48)
        btnAdd.TabIndex = 16
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(180, 490)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(133, 48)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(333, 490)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(133, 48)
        btnDelete.TabIndex = 18
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(486, 490)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(133, 48)
        btnClear.TabIndex = 19
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.Location = New Point(740, 508)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(133, 48)
        btnBrowseImage.TabIndex = 20
        btnBrowseImage.Text = "Browse Image"
        btnBrowseImage.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.Location = New Point(917, 508)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New Size(133, 48)
        btnRemoveImage.TabIndex = 21
        btnRemoveImage.Text = "Remove Image"
        btnRemoveImage.UseVisualStyleBackColor = True
        ' 
        ' dgvApartments
        ' 
        dgvApartments.AllowUserToAddRows = False
        dgvApartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApartments.Location = New Point(32, 560)
        dgvApartments.Name = "dgvApartments"
        dgvApartments.ReadOnly = True
        dgvApartments.RowHeadersWidth = 51
        dgvApartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApartments.Size = New Size(1106, 204)
        dgvApartments.TabIndex = 22
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(32, 768)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 48)
        btnBack.TabIndex = 23
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.WindowFrame
        Label5.Location = New Point(250, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 23)
        Label5.TabIndex = 25
        Label5.Text = "Manager Dashboard" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(250, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(244, 41)
        Label6.TabIndex = 24
        Label6.Text = "Booking System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_05_08_153212
        PictureBox1.Location = New Point(32, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(206, 171)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' ManageApartmentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 828)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(btnBack)
        Controls.Add(dgvApartments)
        Controls.Add(btnRemoveImage)
        Controls.Add(btnBrowseImage)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(picThumb3)
        Controls.Add(picThumb2)
        Controls.Add(picThumb1)
        Controls.Add(picApartmentMain)
        Controls.Add(txtApartmentNumber)
        Controls.Add(txtLocation)
        Controls.Add(txtPrice)
        Controls.Add(txtDescription)
        Controls.Add(txtHotelName)
        Controls.Add(lblMessage)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ManageApartmentsForm"
        Text = "ManageApartmentsForm"
        CType(picApartmentMain, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb1, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb2, ComponentModel.ISupportInitialize).EndInit()
        CType(picThumb3, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvApartments, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtHotelName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtApartmentNumber As TextBox
    Friend WithEvents picApartmentMain As PictureBox
    Friend WithEvents picThumb1 As PictureBox
    Friend WithEvents picThumb2 As PictureBox
    Friend WithEvents picThumb3 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents btnRemoveImage As Button
    Friend WithEvents dgvApartments As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

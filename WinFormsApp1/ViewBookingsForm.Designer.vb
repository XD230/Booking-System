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
        dgvBookings = New DataGridView()
        btnRefresh = New Button()
        btnApprove = New Button()
        btnReject = New Button()
        btnBack = New Button()
        lblMessage = New Label()
        CType(dgvBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBookings
        ' 
        dgvBookings.AllowUserToAddRows = False
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookings.Location = New Point(12, 222)
        dgvBookings.Name = "dgvBookings"
        dgvBookings.ReadOnly = True
        dgvBookings.RowHeadersWidth = 51
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBookings.Size = New Size(960, 286)
        dgvBookings.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(34, 525)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(205, 45)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnApprove
        ' 
        btnApprove.Location = New Point(265, 525)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(205, 45)
        btnApprove.TabIndex = 2
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = True
        ' 
        ' btnReject
        ' 
        btnReject.Location = New Point(503, 525)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(205, 45)
        btnReject.TabIndex = 3
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(739, 525)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(205, 45)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(34, 585)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 20)
        lblMessage.TabIndex = 5
        ' 
        ' ViewBookingsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 619)
        Controls.Add(lblMessage)
        Controls.Add(btnBack)
        Controls.Add(btnReject)
        Controls.Add(btnApprove)
        Controls.Add(btnRefresh)
        Controls.Add(dgvBookings)
        Name = "ViewBookingsForm"
        Text = "ViewBookingsForm"
        CType(dgvBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblMessage As Label
End Class
